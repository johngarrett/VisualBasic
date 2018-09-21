<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMD))
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnDir = New System.Windows.Forms.Button()
        Me.btnTree = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCipher = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ptrExit = New System.Windows.Forms.PictureBox()
        Me.pnlMove = New System.Windows.Forms.Panel()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMove.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(0, 24)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(75, 23)
        Me.btnShutdown.TabIndex = 0
        Me.btnShutdown.Text = "Shutdown -i"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnDir
        '
        Me.btnDir.Location = New System.Drawing.Point(81, 24)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(75, 23)
        Me.btnDir.TabIndex = 1
        Me.btnDir.Text = "dir"
        Me.btnDir.UseVisualStyleBackColor = True
        '
        'btnTree
        '
        Me.btnTree.Location = New System.Drawing.Point(0, 140)
        Me.btnTree.Name = "btnTree"
        Me.btnTree.Size = New System.Drawing.Size(75, 23)
        Me.btnTree.TabIndex = 2
        Me.btnTree.Text = "Tree"
        Me.btnTree.UseVisualStyleBackColor = True
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(81, 82)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(75, 23)
        Me.btnDate.TabIndex = 3
        Me.btnDate.Text = "Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnLogOff
        '
        Me.btnLogOff.Location = New System.Drawing.Point(0, 53)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOff.TabIndex = 4
        Me.btnLogOff.Text = "Log Off"
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(81, 53)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(0, 111)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "Check Disk"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnCipher
        '
        Me.btnCipher.Location = New System.Drawing.Point(81, 111)
        Me.btnCipher.Name = "btnCipher"
        Me.btnCipher.Size = New System.Drawing.Size(75, 23)
        Me.btnCipher.TabIndex = 8
        Me.btnCipher.Text = "Cipher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCipher.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(0, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Host Name"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ptrExit
        '
        Me.ptrExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.ptrExit.Image = CType(resources.GetObject("ptrExit.Image"), System.Drawing.Image)
        Me.ptrExit.Location = New System.Drawing.Point(145, 0)
        Me.ptrExit.Name = "ptrExit"
        Me.ptrExit.Size = New System.Drawing.Size(18, 18)
        Me.ptrExit.TabIndex = 0
        Me.ptrExit.TabStop = False
        '
        'pnlMove
        '
        Me.pnlMove.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlMove.Controls.Add(Me.ptrExit)
        Me.pnlMove.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMove.Location = New System.Drawing.Point(0, 0)
        Me.pnlMove.Name = "pnlMove"
        Me.pnlMove.Size = New System.Drawing.Size(163, 18)
        Me.pnlMove.TabIndex = 18
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 1
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 70
        '
        'CMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(163, 171)
        Me.Controls.Add(Me.pnlMove)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnCipher)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.btnTree)
        Me.Controls.Add(Me.btnDir)
        Me.Controls.Add(Me.btnShutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CMD"
        Me.Text = "CMD"
        CType(Me.ptrExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMove.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnDir As System.Windows.Forms.Button
    Friend WithEvents btnTree As System.Windows.Forms.Button
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnCipher As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ptrExit As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMove As System.Windows.Forms.Panel
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
End Class
