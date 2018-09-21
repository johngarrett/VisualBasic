<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OmniProg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OmniProg))
        Me.btnCrash = New System.Windows.Forms.Button()
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.btnQueen = New System.Windows.Forms.Button()
        Me.grpHack = New System.Windows.Forms.GroupBox()
        Me.radMax = New System.Windows.Forms.RadioButton()
        Me.radSlow = New System.Windows.Forms.RadioButton()
        Me.radReg = New System.Windows.Forms.RadioButton()
        Me.btnTruCrash = New System.Windows.Forms.Button()
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.btnResize = New System.Windows.Forms.Button()
        Me.tmrLoad1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoad2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoad3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoad4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoad5 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCMD = New System.Windows.Forms.Button()
        Me.Timer13 = New System.Windows.Forms.Timer(Me.components)
        Me.btnUniCrash = New System.Windows.Forms.Button()
        Me.Timer16 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.pnlMove = New System.Windows.Forms.Panel()
        Me.ptrExit = New System.Windows.Forms.PictureBox()
        Me.RszTmr = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.btnNewFlash = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.Timer15 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpHack.SuspendLayout()
        Me.pnlMove.SuspendLayout()
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrash
        '
        Me.btnCrash.BackColor = System.Drawing.Color.Black
        Me.btnCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrash.Font = New System.Drawing.Font("Motorwerk", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrash.ForeColor = System.Drawing.Color.Red
        Me.btnCrash.Location = New System.Drawing.Point(124, 19)
        Me.btnCrash.Name = "btnCrash"
        Me.btnCrash.Size = New System.Drawing.Size(141, 67)
        Me.btnCrash.TabIndex = 1
        Me.btnCrash.Text = "Crash"
        Me.btnCrash.UseVisualStyleBackColor = False
        '
        'Timer11
        '
        Me.Timer11.Interval = 300
        '
        'btnQueen
        '
        Me.btnQueen.BackColor = System.Drawing.Color.Transparent
        Me.btnQueen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQueen.Location = New System.Drawing.Point(96, 122)
        Me.btnQueen.Name = "btnQueen"
        Me.btnQueen.Size = New System.Drawing.Size(82, 23)
        Me.btnQueen.TabIndex = 2
        Me.btnQueen.Text = "Queen"
        Me.btnQueen.UseVisualStyleBackColor = False
        '
        'grpHack
        '
        Me.grpHack.Controls.Add(Me.radMax)
        Me.grpHack.Controls.Add(Me.btnCrash)
        Me.grpHack.Controls.Add(Me.radSlow)
        Me.grpHack.Controls.Add(Me.radReg)
        Me.grpHack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpHack.Location = New System.Drawing.Point(3, 24)
        Me.grpHack.Name = "grpHack"
        Me.grpHack.Size = New System.Drawing.Size(271, 92)
        Me.grpHack.TabIndex = 9
        Me.grpHack.TabStop = False
        Me.grpHack.Text = "HACK!#@$"
        '
        'radMax
        '
        Me.radMax.AutoSize = True
        Me.radMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMax.Location = New System.Drawing.Point(9, 65)
        Me.radMax.Name = "radMax"
        Me.radMax.Size = New System.Drawing.Size(108, 17)
        Me.radMax.TabIndex = 12
        Me.radMax.TabStop = True
        Me.radMax.Text = "MAXIMUM HACK"
        Me.radMax.UseVisualStyleBackColor = True
        '
        'radSlow
        '
        Me.radSlow.AutoSize = True
        Me.radSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radSlow.Location = New System.Drawing.Point(8, 19)
        Me.radSlow.Name = "radSlow"
        Me.radSlow.Size = New System.Drawing.Size(109, 17)
        Me.radSlow.TabIndex = 10
        Me.radSlow.TabStop = True
        Me.radSlow.Text = "SLOWEST HACK"
        Me.radSlow.UseVisualStyleBackColor = True
        '
        'radReg
        '
        Me.radReg.AutoSize = True
        Me.radReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radReg.Location = New System.Drawing.Point(9, 42)
        Me.radReg.Name = "radReg"
        Me.radReg.Size = New System.Drawing.Size(108, 17)
        Me.radReg.TabIndex = 11
        Me.radReg.TabStop = True
        Me.radReg.Text = "REGULAR HACK"
        Me.radReg.UseVisualStyleBackColor = True
        '
        'btnTruCrash
        '
        Me.btnTruCrash.BackColor = System.Drawing.Color.Transparent
        Me.btnTruCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTruCrash.Location = New System.Drawing.Point(293, 20)
        Me.btnTruCrash.Name = "btnTruCrash"
        Me.btnTruCrash.Size = New System.Drawing.Size(315, 114)
        Me.btnTruCrash.TabIndex = 10
        Me.btnTruCrash.Text = "COMPLETE UBER HACK UNSTOPPABLE U WILL DIE"
        Me.btnTruCrash.UseVisualStyleBackColor = False
        '
        'Timer12
        '
        '
        'btnResize
        '
        Me.btnResize.BackColor = System.Drawing.Color.Transparent
        Me.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResize.Location = New System.Drawing.Point(184, 122)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(90, 23)
        Me.btnResize.TabIndex = 11
        Me.btnResize.Text = "Secret"
        Me.btnResize.UseVisualStyleBackColor = False
        '
        'btnCMD
        '
        Me.btnCMD.BackColor = System.Drawing.Color.Transparent
        Me.btnCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCMD.Location = New System.Drawing.Point(3, 151)
        Me.btnCMD.Name = "btnCMD"
        Me.btnCMD.Size = New System.Drawing.Size(87, 23)
        Me.btnCMD.TabIndex = 12
        Me.btnCMD.Text = "CMD"
        Me.btnCMD.UseVisualStyleBackColor = False
        '
        'btnUniCrash
        '
        Me.btnUniCrash.BackColor = System.Drawing.Color.Transparent
        Me.btnUniCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUniCrash.Location = New System.Drawing.Point(371, 140)
        Me.btnUniCrash.Name = "btnUniCrash"
        Me.btnUniCrash.Size = New System.Drawing.Size(169, 39)
        Me.btnUniCrash.TabIndex = 13
        Me.btnUniCrash.Text = "Universial Hack"
        Me.btnUniCrash.UseVisualStyleBackColor = False
        '
        'Timer16
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(96, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Game"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnWord
        '
        Me.btnWord.BackColor = System.Drawing.Color.Transparent
        Me.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWord.Location = New System.Drawing.Point(184, 151)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(89, 23)
        Me.btnWord.TabIndex = 15
        Me.btnWord.Text = "Word"
        Me.btnWord.UseVisualStyleBackColor = False
        '
        'pnlMove
        '
        Me.pnlMove.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlMove.Controls.Add(Me.ptrExit)
        Me.pnlMove.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMove.Location = New System.Drawing.Point(0, 0)
        Me.pnlMove.Name = "pnlMove"
        Me.pnlMove.Size = New System.Drawing.Size(284, 18)
        Me.pnlMove.TabIndex = 17
        '
        'ptrExit
        '
        Me.ptrExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.ptrExit.Image = CType(resources.GetObject("ptrExit.Image"), System.Drawing.Image)
        Me.ptrExit.Location = New System.Drawing.Point(266, 0)
        Me.ptrExit.Name = "ptrExit"
        Me.ptrExit.Size = New System.Drawing.Size(18, 18)
        Me.ptrExit.TabIndex = 0
        Me.ptrExit.TabStop = False
        '
        'RszTmr
        '
        Me.RszTmr.Interval = 1
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 1
        '
        'btnNewFlash
        '
        Me.btnNewFlash.BackColor = System.Drawing.Color.Transparent
        Me.btnNewFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewFlash.Location = New System.Drawing.Point(3, 122)
        Me.btnNewFlash.Name = "btnNewFlash"
        Me.btnNewFlash.Size = New System.Drawing.Size(89, 23)
        Me.btnNewFlash.TabIndex = 18
        Me.btnNewFlash.Text = "Flash"
        Me.btnNewFlash.UseVisualStyleBackColor = False
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 70
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OmniProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNewFlash)
        Me.Controls.Add(Me.pnlMove)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUniCrash)
        Me.Controls.Add(Me.btnCMD)
        Me.Controls.Add(Me.btnResize)
        Me.Controls.Add(Me.btnTruCrash)
        Me.Controls.Add(Me.grpHack)
        Me.Controls.Add(Me.btnQueen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(631, 182)
        Me.MinimumSize = New System.Drawing.Size(277, 182)
        Me.Name = "OmniProg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OmniProg"
        Me.grpHack.ResumeLayout(False)
        Me.grpHack.PerformLayout()
        Me.pnlMove.ResumeLayout(False)
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrash As System.Windows.Forms.Button
    Friend WithEvents Timer11 As System.Windows.Forms.Timer
    Friend WithEvents btnQueen As System.Windows.Forms.Button
    Friend WithEvents grpHack As System.Windows.Forms.GroupBox
    Friend WithEvents radSlow As System.Windows.Forms.RadioButton
    Friend WithEvents radReg As System.Windows.Forms.RadioButton
    Friend WithEvents radMax As System.Windows.Forms.RadioButton
    Friend WithEvents btnTruCrash As System.Windows.Forms.Button
    Friend WithEvents Timer12 As System.Windows.Forms.Timer
    Friend WithEvents btnResize As System.Windows.Forms.Button
    Friend WithEvents tmrLoad1 As System.Windows.Forms.Timer
    Friend WithEvents tmrLoad2 As System.Windows.Forms.Timer
    Friend WithEvents tmrLoad3 As System.Windows.Forms.Timer
    Friend WithEvents tmrLoad4 As System.Windows.Forms.Timer
    Friend WithEvents tmrLoad5 As System.Windows.Forms.Timer
    Friend WithEvents btnCMD As System.Windows.Forms.Button
    Friend WithEvents Timer13 As System.Windows.Forms.Timer
    Friend WithEvents btnUniCrash As System.Windows.Forms.Button
    Friend WithEvents Timer16 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnWord As System.Windows.Forms.Button
    Friend WithEvents pnlMove As System.Windows.Forms.Panel
    Friend WithEvents ptrExit As System.Windows.Forms.PictureBox
    Friend WithEvents RszTmr As System.Windows.Forms.Timer
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents btnNewFlash As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
    Friend WithEvents Timer15 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
