Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices

Public Class frmBuffer
    Public SQL As New SQLControl

    Private Sort As String
    Private Sub frmBuffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMTF.DoubleBuffered(True)
        SetupDataGridView()
        LoadModelincbx()
        cbxMTF.Enabled = False
    End Sub

    Private Sub SetupDataGridView()
        dgvMTF.Width = Width
        dgvMTF.RowsDefaultCellStyle.BackColor = Color.White
        dgvMTF.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, CInt(Byte.MaxValue))
        dgvMTF.RowHeadersVisible = False
    End Sub

    Private Sub LoadModelincbx()
        'REFRESH COMBOBOX
        cbxModel.Items.Clear()

        cbxModel.Items.Add("[SELECT MODEL]")
        cbxModel.SelectedIndex = 0

        'Query
        SQL.ExecQuery("SELECT id, module FROM bom ORDER by module;")

        If SQL.HasException(True) Then Exit Sub

        'LOOP ROW &  ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cbxModel.Items.Add(r("module").ToString)
        Next
    End Sub

    Private Sub LoadcbxMTF()
        cbxMTF.Items.Clear()

        SQL.AddParam("@modelname", cbxModel.Text.Trim)
        SQL.ExecQuery("select sht, wo from vw_chkout_sht where dsc like '%工单完结%' AND pd_model LIKE @modelname;")

        If SQL.RecordCount > 0 Then
            cbxMTF.Items.Add("[SELECT MTF]")
            For Each r As DataRow In SQL.DBDT.Rows
                cbxMTF.Items.Add(r("sht"))
            Next
            cbxMTF.SelectedIndex = 0
            cbxMTF.Enabled = True
        Else
            cbxMTF.Items.Add("---")
            cbxMTF.SelectedIndex = 0
            cbxMTF.Enabled = False
            While dgvMTF.Rows.Count > 0
                dgvMTF.Rows.RemoveAt(0)
            End While

        End If
    End Sub

    Private Sub LoadMTFNum()
        SQL.AddParam("@mtfnumber", cbxMTF.Text.Trim)
        SQL.ExecQuery("select sht from vw_wms_chkout_sht where sht = @mtfnumber;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            Sort = r("sht")
        Next


        LoadDatatodgv()
    End Sub

    Private Sub LoadDatatodgv()

        SQL.AddParam("@mtf", "%" & Sort & "%")
        SQL.ExecQuery("SELECT pn, chkout_sht_id, pn_spec, wo_plan_qty, need_qty, act_qty, extra_qty, pd_model FROM vw_chkout_sum_sync where chkout_sht_id LIKE @mtf;")

        If SQL.HasException(True) Then Exit Sub

        Cursor.Current = Cursors.WaitCursor
        dgvMTF.DataSource = SQL.DBDT
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "pn").HeaderText = "Part Number"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "chkout_sht_id").HeaderText = "MTF Number"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "pn_spec").HeaderText = "Code"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "wo_plan_qty").HeaderText = "LOT Quantity"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "need_qty").HeaderText = "ACT Qty Request"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "act_qty").HeaderText = "Issued Qty"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "extra_qty").HeaderText = "Incoming Buffer"
        dgvMTF.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "pd_model").HeaderText = "Model"

        dgvMTF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMTF.AutoResizeColumns()
    End Sub


    Private Sub FindMTFPN()
        SQL.AddParam("@mtf", "%" & Sort & "%")
        SQL.AddParam("@item", "%" & txtPN.Text & "%")

        SQL.ExecQuery("SELECT pn, chkout_sht_id, pn_spec, wo_plan_qty, need_qty, act_qty, extra_qty, pd_model FROM vw_chkout_sum_sync WHERE pn LIKE @item AND chkout_sht_id LIKE @mtf;") '  ORDER by chkout_sht_id

        dgvMTF.DataSource = SQL.DBDT
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbxModel.Text = "[SELECT MODEL]" And cbxMTF.Text = "---" Then
            MessageBox.Show("Please Select the Product Model.", "Select Product Model", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbxMTF.Text = "---" Then
            MessageBox.Show("This Product Model does not have an MTF.", "MTF CANNOT BE FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbxMTF.Text = "[SELECT MTF]" Then
            MessageBox.Show("Please Select the MTF.", "Select MTF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtPN.Text.Trim.Length > 0 Then
            FindMTFPN()
        ElseIf txtPN.Text = "" Then
            LoadDatatodgv()
        End If

    End Sub

    Private Sub txtPN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPN.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnSearch_Click(Nothing, Nothing)

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub cbxMTF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMTF.SelectedIndexChanged
        If cbxMTF.SelectedIndex = 0 Then
            While dgvMTF.Rows.Count > 0
                dgvMTF.Rows.RemoveAt(0)
            End While
        Else
            LoadMTFNum()
        End If

    End Sub

    Private Sub cbxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModel.SelectedIndexChanged
        LoadcbxMTF()
    End Sub
End Class