<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBank
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBank))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.lstMain = New System.Windows.Forms.ListBox()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.cboTrans = New System.Windows.Forms.ComboBox()
        Me.lblPig = New System.Windows.Forms.Label()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRsz = New System.Windows.Forms.Timer(Me.components)
        Me.ptrExit = New System.Windows.Forms.PictureBox()
        Me.pnlResize = New System.Windows.Forms.Panel()
        Me.pnlMove = New System.Windows.Forms.Panel()
        Me.pnlEaster = New System.Windows.Forms.Panel()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.lblEasterShow = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram, Me.lstAbout})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuMain.Size = New System.Drawing.Size(324, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "Menu"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cboBalance, Me.cboReset, Me.mnuClose})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'cboBalance
        '
        Me.cboBalance.Name = "cboBalance"
        Me.cboBalance.Size = New System.Drawing.Size(136, 22)
        Me.cboBalance.Text = "Get Balance"
        '
        'cboReset
        '
        Me.cboReset.Name = "cboReset"
        Me.cboReset.Size = New System.Drawing.Size(136, 22)
        Me.cboReset.Text = "Reset"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(136, 22)
        Me.mnuClose.Text = "Close"
        '
        'lstAbout
        '
        Me.lstAbout.Name = "lstAbout"
        Me.lstAbout.Size = New System.Drawing.Size(52, 20)
        Me.lstAbout.Text = "About"
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.BackColor = System.Drawing.Color.Transparent
        Me.lblTrans.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrans.Location = New System.Drawing.Point(14, 54)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(125, 14)
        Me.lblTrans.TabIndex = 1
        Me.lblTrans.Text = "Chose transaction type"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(14, 96)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(78, 14)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Enter Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(176, 92)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(140, 22)
        Me.txtAmount.TabIndex = 4
        '
        'lblDollar
        '
        Me.lblDollar.AutoSize = True
        Me.lblDollar.BackColor = System.Drawing.Color.Transparent
        Me.lblDollar.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar.Location = New System.Drawing.Point(154, 96)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(13, 14)
        Me.lblDollar.TabIndex = 6
        Me.lblDollar.Text = "$"
        '
        'lstMain
        '
        Me.lstMain.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lstMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstMain.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMain.FormattingEnabled = True
        Me.lstMain.ItemHeight = 14
        Me.lstMain.Location = New System.Drawing.Point(14, 137)
        Me.lstMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(133, 154)
        Me.lstMain.TabIndex = 7
        '
        'btnTrans
        '
        Me.btnTrans.BackColor = System.Drawing.Color.Transparent
        Me.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrans.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrans.Location = New System.Drawing.Point(168, 137)
        Me.btnTrans.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(149, 65)
        Me.btnTrans.TabIndex = 8
        Me.btnTrans.Text = "Make Transaction"
        Me.btnTrans.UseVisualStyleBackColor = False
        '
        'cboTrans
        '
        Me.cboTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTrans.FormattingEnabled = True
        Me.cboTrans.Items.AddRange(New Object() {"Deposit", "Withdraw"})
        Me.cboTrans.Location = New System.Drawing.Point(176, 44)
        Me.cboTrans.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTrans.Name = "cboTrans"
        Me.cboTrans.Size = New System.Drawing.Size(140, 24)
        Me.cboTrans.TabIndex = 9
        '
        'lblPig
        '
        Me.lblPig.BackColor = System.Drawing.Color.Transparent
        Me.lblPig.Location = New System.Drawing.Point(153, 207)
        Me.lblPig.Name = "lblPig"
        Me.lblPig.Size = New System.Drawing.Size(164, 96)
        Me.lblPig.TabIndex = 10
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 1
        '
        'tmrRsz
        '
        Me.tmrRsz.Interval = 1
        '
        'ptrExit
        '
        Me.ptrExit.Image = CType(resources.GetObject("ptrExit.Image"), System.Drawing.Image)
        Me.ptrExit.Location = New System.Drawing.Point(302, 0)
        Me.ptrExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptrExit.Name = "ptrExit"
        Me.ptrExit.Size = New System.Drawing.Size(18, 18)
        Me.ptrExit.TabIndex = 12
        Me.ptrExit.TabStop = False
        '
        'pnlResize
        '
        Me.pnlResize.Location = New System.Drawing.Point(359, 180)
        Me.pnlResize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlResize.Name = "pnlResize"
        Me.pnlResize.Size = New System.Drawing.Size(21, 22)
        Me.pnlResize.TabIndex = 13
        '
        'pnlMove
        '
        Me.pnlMove.BackgroundImage = CType(resources.GetObject("pnlMove.BackgroundImage"), System.Drawing.Image)
        Me.pnlMove.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.pnlMove.Location = New System.Drawing.Point(278, 0)
        Me.pnlMove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlMove.Name = "pnlMove"
        Me.pnlMove.Size = New System.Drawing.Size(18, 18)
        Me.pnlMove.TabIndex = 14
        '
        'pnlEaster
        '
        Me.pnlEaster.BackColor = System.Drawing.Color.Transparent
        Me.pnlEaster.Location = New System.Drawing.Point(17, 74)
        Me.pnlEaster.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlEaster.Name = "pnlEaster"
        Me.pnlEaster.Size = New System.Drawing.Size(58, 22)
        Me.pnlEaster.TabIndex = 15
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblAction.Location = New System.Drawing.Point(173, 6)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(0, 16)
        Me.lblAction.TabIndex = 16
        '
        'lblEasterShow
        '
        Me.lblEasterShow.BackColor = System.Drawing.Color.Transparent
        Me.lblEasterShow.Location = New System.Drawing.Point(3, 24)
        Me.lblEasterShow.Name = "lblEasterShow"
        Me.lblEasterShow.Size = New System.Drawing.Size(170, 30)
        Me.lblEasterShow.TabIndex = 17
        '
        'frmBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(324, 316)
        Me.Controls.Add(Me.lblEasterShow)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.pnlEaster)
        Me.Controls.Add(Me.pnlMove)
        Me.Controls.Add(Me.pnlResize)
        Me.Controls.Add(Me.ptrExit)
        Me.Controls.Add(Me.lblPig)
        Me.Controls.Add(Me.cboTrans)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.lstMain)
        Me.Controls.Add(Me.lblDollar)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblTrans)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piggy Bank"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTrans As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblDollar As System.Windows.Forms.Label
    Friend WithEvents lstMain As System.Windows.Forms.ListBox
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents cboTrans As System.Windows.Forms.ComboBox
    Friend WithEvents lblPig As System.Windows.Forms.Label
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents tmrRsz As System.Windows.Forms.Timer
    Friend WithEvents ptrExit As System.Windows.Forms.PictureBox
    Friend WithEvents cboReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlResize As System.Windows.Forms.Panel
    Friend WithEvents pnlMove As System.Windows.Forms.Panel
    Friend WithEvents pnlEaster As System.Windows.Forms.Panel
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents lblEasterShow As System.Windows.Forms.Label

End Class
