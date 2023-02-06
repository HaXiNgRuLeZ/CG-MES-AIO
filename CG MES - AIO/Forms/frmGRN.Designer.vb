<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGRN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.btnBrowser = New System.Windows.Forms.Button()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(0, 30)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(863, 542)
        Me.WebView21.TabIndex = 0
        Me.WebView21.ZoomFactor = 1.0R
        '
        'btnBrowser
        '
        Me.btnBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBrowser.FlatAppearance.BorderSize = 0
        Me.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowser.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBrowser.Location = New System.Drawing.Point(0, 0)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBrowser.Size = New System.Drawing.Size(863, 31)
        Me.btnBrowser.TabIndex = 1
        Me.btnBrowser.Text = "OPEN IN BROWSER"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'frmGRN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(863, 572)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.WebView21)
        Me.Name = "frmGRN"
        Me.Text = "Good Receiving Notes (GRN)"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnBrowser As Button
End Class
