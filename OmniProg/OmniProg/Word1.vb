
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class Word1
    Dim Textsave As String

    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)
    Dim filename As String
    Private Sub picLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLower.Click
        txtMain.Text.ToUpper()
    End Sub
    Private Sub picUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUpper.Click
        Textsave = txtMain.Text
        Textsave.ToUpper()
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHelp.Click
        Help.show()
    End Sub
    Private Sub Sync()
        CurPos = Cursor.Position
        AppSize = Me.Size
    End Sub
    Private Sub refpositions()
        oloc = Me.Location
        ocur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        RszTmr.Start()
        refpositions()
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        RszTmr.Stop()
        refpositions()
    End Sub
    Private Sub RszTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RszTmr.Tick
        Me.Location = oloc - ocur + System.Windows.Forms.Cursor.Position
        refpositions()
    End Sub
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        MoveTmr.Start()
        Sync()
    End Sub
    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        MoveTmr.Stop()
        Sync()
    End Sub
    Private Sub MoveTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveTmr.Tick
        Me.Size = AppSize - CurPos + Cursor.Position
        refpositions()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, picSave.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, picAdvanced.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub txtMain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMain.TextChanged

    End Sub
End Class