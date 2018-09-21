
Public Class Form1
    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)
    Private Sub Sync()
        CurPos = Cursor.Position
        AppSize = Me.Size
    End Sub
    Private Sub refpositions()
        oloc = Me.Location
        ocur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        RszTmr.Start()
        refpositions()
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        RszTmr.Stop()
        refpositions()
    End Sub

    Private Sub RszTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RszTmr.Tick
        Me.Location = oloc - ocur + System.Windows.Forms.Cursor.Position
        refpositions()
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MoveTmr.Start()
        Sync()
    End Sub

    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MoveTmr.Stop()
        Sync()
    End Sub

    Private Sub MoveTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveTmr.Tick
        Me.Size = AppSize - CurPos + Cursor.Position
        refpositions()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        MessageBox.Show("Login Application" & vbCrLf & "By John Garrett" & vbCrLf & "v1.0 BETA", "About")
    End Sub

    Private Sub txtPw_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPw.TextChanged
        btnLogin.Show()
        txtPw.PasswordChar = "*"
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "John Garrett" And txtPw.Text = "john" Then Slot.Show() Else lblWrong.Visible = True

    End Sub
    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        lblWrong.Visible = False
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Slot.Show()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class