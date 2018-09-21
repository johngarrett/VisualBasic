Public Class Blur
    Private BlurrForm As New Form
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        BlurrForm.StartPosition = FormStartPosition.Manual
        BlurrForm.Opacity = 1
        BlurrForm.Location = Me.Location
        BlurrForm.Size = Me.Size
        BlurrForm.Owner = Me
        BlurrForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        AddHandler BlurrForm.Click, AddressOf BlurredFormClicked
        BlurrForm.Show(Me)
    End Sub
    Sub BlurredFormClicked(ByVal sender As System.Object, ByVal e As EventArgs)
        BlurrForm.Hide()
    End Sub
End Class