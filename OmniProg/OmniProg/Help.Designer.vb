<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.picLower = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picUpper = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picAdvanced = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLower
        '
        Me.picLower.Image = CType(resources.GetObject("picLower.Image"), System.Drawing.Image)
        Me.picLower.Location = New System.Drawing.Point(3, 2)
        Me.picLower.Name = "picLower"
        Me.picLower.Size = New System.Drawing.Size(26, 25)
        Me.picLower.TabIndex = 10
        Me.picLower.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "This image puts all of the text into a lowercase format."
        '
        'picUpper
        '
        Me.picUpper.Image = CType(resources.GetObject("picUpper.Image"), System.Drawing.Image)
        Me.picUpper.Location = New System.Drawing.Point(3, 33)
        Me.picUpper.Name = "picUpper"
        Me.picUpper.Size = New System.Drawing.Size(26, 25)
        Me.picUpper.TabIndex = 12
        Me.picUpper.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "This image puts all of the text into a uppercase format."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "This icon saves your text as a notepad file onto your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desktop. The defualt file" & _
            " name is untitled."
        '
        'picAdvanced
        '
        Me.picAdvanced.Image = CType(resources.GetObject("picAdvanced.Image"), System.Drawing.Image)
        Me.picAdvanced.Location = New System.Drawing.Point(3, 95)
        Me.picAdvanced.Name = "picAdvanced"
        Me.picAdvanced.Size = New System.Drawing.Size(26, 25)
        Me.picAdvanced.TabIndex = 16
        Me.picAdvanced.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "This icon gives you advanced options."
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picAdvanced)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picUpper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLower)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.picLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLower As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picUpper As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picAdvanced As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
