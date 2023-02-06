Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Public Class frmInventory
    Public SQL As New SQLControl
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInventory.DoubleBuffered(True)
        SetupDataGridView()
        LoadGrid()
        'dgvInventory.DataSource = dgvLoad()

    End Sub

    Private Sub SetupDataGridView()
        dgvInventory.Width = Width
        dgvInventory.RowsDefaultCellStyle.BackColor = Color.White
        dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, CInt(Byte.MaxValue))
        dgvInventory.RowHeadersVisible = False
    End Sub



    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            'SQL.ExecQuery("SELECT PN, pn_spec, count_id, balance_qty FROM vw_wms_stock WHERE balance_qty > 0 ORDER by pn_spec;")
            SQL.ExecQuery("SELECT vw_wms_stock.PN, vw_wms_stock.pn_spec, part_numbers.pn_dsc, vw_wms_stock.balance_qty FROM vw_wms_stock inner join part_numbers WHERE part_numbers.PN LIKE vw_wms_stock.PN AND vw_wms_stock.balance_qty > 0 ORDER by vw_wms_stock.pn_spec;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        Cursor.Current = Cursors.WaitCursor

        dgvInventory.DataSource = SQL.DBDT
        dgvInventory.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "PN").HeaderText = "Part Number"
        dgvInventory.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "pn_spec").HeaderText = "Code"
        dgvInventory.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "pn_dsc").HeaderText = "Description"
        dgvInventory.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "balance_qty").HeaderText = "Balance at Store"
        dgvInventory.Columns("PN").Width = 150
        dgvInventory.Columns("pn_spec").Width = 150
        dgvInventory.Columns("pn_dsc").Width = 469
        dgvInventory.Columns("balance_qty").Width = 70

        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventory.AutoResizeColumns()

        ''dgvInventory.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.DataPropertyName = "buffer").HeaderText = "Buffer"
    End Sub

    Private Sub FindItemPN()
        SQL.AddParam("@item", "%" & txtPN.Text & "%")

        LoadGrid("SELECT vw_wms_stock.PN, vw_wms_stock.pn_spec, part_numbers.pn_dsc, vw_wms_stock.balance_qty FROM vw_wms_stock inner join part_numbers WHERE part_numbers.PN LIKE vw_wms_stock.PN AND vw_wms_stock.PN LIKE @item ORDER by vw_wms_stock.pn_spec;")

    End Sub
    Private Sub FindItemCode()
        SQL.AddParam("@item", "%" & txtCode.Text & "%")
        'LoadGrid("SELECT PartNo,PartDesc FROM Products WHERE PartNo LIKE @item;")
        LoadGrid("SELECT vw_wms_stock.PN, vw_wms_stock.pn_spec, part_numbers.pn_dsc, vw_wms_stock.balance_qty FROM vw_wms_stock inner join part_numbers WHERE part_numbers.PN LIKE vw_wms_stock.PN AND vw_wms_stock.pn_spec LIKE @item ORDER by vw_wms_stock.pn_spec;")
        'SELECT * FROM  vw_wms_stock WHERE balance_qty > 0 ORDER by pn_spec
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtPN.Text = "" And txtCode.Text = "" Then
            LoadGrid()
        ElseIf txtCode.Text = "" Then
            FindItemPN()
        ElseIf txtPN.Text = "" Then
            FindItemCode()
            'Else

            '    LoadGrid()
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

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
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
End Class