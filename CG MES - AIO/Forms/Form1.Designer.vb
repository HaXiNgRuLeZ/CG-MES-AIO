<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnGRN = New FontAwesome.Sharp.IconButton()
        Me.btnBuffer = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnGRN)
        Me.PanelMenu.Controls.Add(Me.btnBuffer)
        Me.PanelMenu.Controls.Add(Me.btnInventory)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 686)
        Me.PanelMenu.TabIndex = 1
        '
        'btnGRN
        '
        Me.btnGRN.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGRN.FlatAppearance.BorderSize = 0
        Me.btnGRN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGRN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGRN.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGRN.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btnGRN.IconColor = System.Drawing.Color.Gainsboro
        Me.btnGRN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGRN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGRN.Location = New System.Drawing.Point(0, 260)
        Me.btnGRN.Name = "btnGRN"
        Me.btnGRN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnGRN.Size = New System.Drawing.Size(220, 60)
        Me.btnGRN.TabIndex = 6
        Me.btnGRN.Text = "Good Receiving Notes (GRN)"
        Me.btnGRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGRN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGRN.UseVisualStyleBackColor = True
        '
        'btnBuffer
        '
        Me.btnBuffer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuffer.FlatAppearance.BorderSize = 0
        Me.btnBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuffer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuffer.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBuffer.IconChar = FontAwesome.Sharp.IconChar.Buffer
        Me.btnBuffer.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBuffer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuffer.Location = New System.Drawing.Point(0, 200)
        Me.btnBuffer.Name = "btnBuffer"
        Me.btnBuffer.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBuffer.Size = New System.Drawing.Size(220, 60)
        Me.btnBuffer.TabIndex = 4
        Me.btnBuffer.Text = "Buffer Checker"
        Me.btnBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuffer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuffer.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 140)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(220, 60)
        Me.btnInventory.TabIndex = 3
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 2
        '
        'imgHome
        '
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(22, 24)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(174, 90)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 2
        Me.imgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(879, 75)
        Me.PanelTitleBar.TabIndex = 3
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(798, 7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 21)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 6
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), System.Drawing.Image)
        Me.btnMaximize.Location = New System.Drawing.Point(824, 7)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(20, 21)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximize.TabIndex = 5
        Me.btnMaximize.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(850, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 21)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 4
        Me.btnExit.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(49, 30)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(47, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(13, 22)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.lblConnection)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(879, 611)
        Me.PanelDesktop.TabIndex = 4
        '
        'lblConnection
        '
        Me.lblConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblConnection.Location = New System.Drawing.Point(6, 588)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(43, 17)
        Me.lblConnection.TabIndex = 8
        Me.lblConnection.Text = "Idle..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(261, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(6, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Connection Status:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 686)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CG MES - All in One"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnGRN As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBuffer As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMaximize As PictureBox
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConnection As Label
End Class
