<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class queen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(queen))
        Me.ptrMichelle = New System.Windows.Forms.PictureBox()
        CType(Me.ptrMichelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptrMichelle
        '
        Me.ptrMichelle.Image = CType(resources.GetObject("ptrMichelle.Image"), System.Drawing.Image)
        Me.ptrMichelle.Location = New System.Drawing.Point(2, 0)
        Me.ptrMichelle.Name = "ptrMichelle"
        Me.ptrMichelle.Size = New System.Drawing.Size(293, 303)
        Me.ptrMichelle.TabIndex = 0
        Me.ptrMichelle.TabStop = False
        '
        'queen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 299)
        Me.Controls.Add(Me.ptrMichelle)
        Me.Name = "queen"
        Me.Text = "queen"
        CType(Me.ptrMichelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptrMichelle As System.Windows.Forms.PictureBox
End Class
