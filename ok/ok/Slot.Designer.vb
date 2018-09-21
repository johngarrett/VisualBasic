<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Slot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Slot))
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNumbers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPictures = New System.Windows.Forms.Button()
        Me.RszTmr = New System.Windows.Forms.Timer(Me.components)
        Me.moveTmr = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.mnuMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.BackColor = System.Drawing.Color.Transparent
        Me.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 64.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(0, 33)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(100, 100)
        Me.lblNum1.TabIndex = 0
        '
        'lblNum2
        '
        Me.lblNum2.BackColor = System.Drawing.Color.Transparent
        Me.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 64.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(106, 33)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(100, 100)
        Me.lblNum2.TabIndex = 1
        '
        'lblNum3
        '
        Me.lblNum3.BackColor = System.Drawing.Color.Transparent
        Me.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 64.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(212, 33)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(100, 100)
        Me.lblNum3.TabIndex = 2
        '
        'lblTokens
        '
        Me.lblTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblTokens.Font = New System.Drawing.Font("Microsoft Yi Baiti", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTokens.Location = New System.Drawing.Point(-3, 147)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(315, 69)
        Me.lblTokens.TabIndex = 3
        '
        'btnPull
        '
        Me.btnPull.BackColor = System.Drawing.Color.Transparent
        Me.btnPull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPull.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPull.Location = New System.Drawing.Point(106, 219)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(100, 45)
        Me.btnPull.TabIndex = 4
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = False
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.LightGray
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptions, Me.mnuExit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(319, 24)
        Me.mnuMain.TabIndex = 5
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNumbers, Me.mnuPictures, Me.mnuHistory})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuNumbers
        '
        Me.mnuNumbers.Name = "mnuNumbers"
        Me.mnuNumbers.Size = New System.Drawing.Size(144, 22)
        Me.mnuNumbers.Text = "Numbers"
        '
        'mnuPictures
        '
        Me.mnuPictures.Name = "mnuPictures"
        Me.mnuPictures.Size = New System.Drawing.Size(144, 22)
        Me.mnuPictures.Text = "Pictures"
        '
        'mnuHistory
        '
        Me.mnuHistory.Name = "mnuHistory"
        Me.mnuHistory.Size = New System.Drawing.Size(144, 22)
        Me.mnuHistory.Text = "Show History"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'btnPictures
        '
        Me.btnPictures.Location = New System.Drawing.Point(381, 33)
        Me.btnPictures.Name = "btnPictures"
        Me.btnPictures.Size = New System.Drawing.Size(117, 120)
        Me.btnPictures.TabIndex = 6
        Me.btnPictures.Text = "Button1"
        Me.btnPictures.UseVisualStyleBackColor = True
        '
        'RszTmr
        '
        Me.RszTmr.Interval = 1
        '
        'moveTmr
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(297, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.Location = New System.Drawing.Point(12, 270)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(120, 121)
        Me.lstHistory.TabIndex = 5
        '
        'Slot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(319, 269)
        Me.Controls.Add(Me.lstHistory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.btnPictures)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.lblNum2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(319, 403)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(319, 269)
        Me.Name = "Slot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents lblTokens As System.Windows.Forms.Label
    Friend WithEvents btnPull As System.Windows.Forms.Button
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNumbers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictures As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPictures As System.Windows.Forms.Button
    Friend WithEvents RszTmr As System.Windows.Forms.Timer
    Friend WithEvents moveTmr As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
End Class
