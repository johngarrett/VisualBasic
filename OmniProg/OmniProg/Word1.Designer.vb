<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Word1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Word1))
        Me.txtMain = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSave = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picLower = New System.Windows.Forms.PictureBox()
        Me.picUpper = New System.Windows.Forms.PictureBox()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        Me.picAdvanced = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MoveTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RszTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpSave.SuspendLayout()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(0, 36)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(681, 470)
        Me.txtMain.TabIndex = 0
        Me.txtMain.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File Name"
        '
        'grpSave
        '
        Me.grpSave.Controls.Add(Me.Label2)
        Me.grpSave.Controls.Add(Me.TextBox2)
        Me.grpSave.Controls.Add(Me.TextBox1)
        Me.grpSave.Controls.Add(Me.Label1)
        Me.grpSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSave.Location = New System.Drawing.Point(687, 12)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.Size = New System.Drawing.Size(112, 100)
        Me.grpSave.TabIndex = 3
        Me.grpSave.TabStop = False
        Me.grpSave.Text = "Save As..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Extention"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(0, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'picSave
        '
        Me.picSave.Image = CType(resources.GetObject("picSave.Image"), System.Drawing.Image)
        Me.picSave.Location = New System.Drawing.Point(623, 5)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(26, 25)
        Me.picSave.TabIndex = 5
        Me.picSave.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(687, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 114)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'picLower
        '
        Me.picLower.Image = CType(resources.GetObject("picLower.Image"), System.Drawing.Image)
        Me.picLower.Location = New System.Drawing.Point(44, 5)
        Me.picLower.Name = "picLower"
        Me.picLower.Size = New System.Drawing.Size(26, 25)
        Me.picLower.TabIndex = 9
        Me.picLower.TabStop = False
        '
        'picUpper
        '
        Me.picUpper.Image = CType(resources.GetObject("picUpper.Image"), System.Drawing.Image)
        Me.picUpper.Location = New System.Drawing.Point(12, 5)
        Me.picUpper.Name = "picUpper"
        Me.picUpper.Size = New System.Drawing.Size(26, 25)
        Me.picUpper.TabIndex = 10
        Me.picUpper.TabStop = False
        '
        'picHelp
        '
        Me.picHelp.Image = CType(resources.GetObject("picHelp.Image"), System.Drawing.Image)
        Me.picHelp.Location = New System.Drawing.Point(773, 238)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(26, 25)
        Me.picHelp.TabIndex = 11
        Me.picHelp.TabStop = False
        '
        'picAdvanced
        '
        Me.picAdvanced.Image = CType(resources.GetObject("picAdvanced.Image"), System.Drawing.Image)
        Me.picAdvanced.Location = New System.Drawing.Point(655, 3)
        Me.picAdvanced.Name = "picAdvanced"
        Me.picAdvanced.Size = New System.Drawing.Size(26, 25)
        Me.picAdvanced.TabIndex = 12
        Me.picAdvanced.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(687, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Need help?"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(52, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "---"
        '
        'MoveTmr
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(76, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 24)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(27, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'RszTmr
        '
        '
        'Panel2
        '
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Panel2.Location = New System.Drawing.Point(590, 257)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 14
        '
        'Word1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 506)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picHelp)
        Me.Controls.Add(Me.picAdvanced)
        Me.Controls.Add(Me.picUpper)
        Me.Controls.Add(Me.picLower)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.grpSave)
        Me.Controls.Add(Me.txtMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(818, 544)
        Me.Name = "Word1"
        Me.Text = "Text Editor"
        Me.grpSave.ResumeLayout(False)
        Me.grpSave.PerformLayout()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMain As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpSave As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents picSave As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picLower As System.Windows.Forms.PictureBox
    Friend WithEvents picUpper As System.Windows.Forms.PictureBox
    Friend WithEvents picHelp As System.Windows.Forms.PictureBox
    Friend WithEvents picAdvanced As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MoveTmr As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RszTmr As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
