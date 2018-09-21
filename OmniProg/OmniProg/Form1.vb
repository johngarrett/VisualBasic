Imports System
Imports System.IO
Imports System.Text

    Public Class OmniProg
    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)

        'Window spam, not true crash
        Private Sub btnCrash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrash.Click
            Timer11.Start()
            MessageBox.Show("Honey, you've got a big storm coming")
        MessageBox.Show(Shell("C:\Programs\DIR.bat", AppWinStyle.MaximizedFocus))
    End Sub
        Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        Shell("C:\Programs\TREE.bat", AppWinStyle.MaximizedFocus)
            btnCrash.PerformClick()
        End Sub
        'Michelle Obama show
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueen.Click
        queen.Show()
        Master.Show()
        Music.Show()
    End Sub
        'The hack speed
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSlow.CheckedChanged
        Timer11.Interval = 100000000
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMax.CheckedChanged
        Timer11.Interval = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radReg.CheckedChanged
        Timer11.Interval = 1000
    End Sub
        'True crash
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruCrash.Click
        MessageBox.Show("BAD IDEA!!!!!!!!!!!!!!!!!!!!!")
        Timer12.Start()
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
        Timer12.Start()
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
        Timer12.Start()
    End Sub
    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
        btnTruCrash.PerformClick()
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
        btnTruCrash.PerformClick()
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
        btnTruCrash.PerformClick()
        Shell("\\H0526sfs01\Home$\Students\9394216\My Documents\Finished exe\RUN AT OWN RISK.exe")
    End Sub
        'Show hidden button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResize.Click
        Me.Size = MaximumSize
    End Sub
    'Opens CMD window
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCMD.Click
        CMD.Show()
    End Sub
    'Creates universal hack dir
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUniCrash.Click
        My.Computer.FileSystem.CreateDirectory("C:\Hack\")

        Dim fileName As String
        fileName = "DIR"
        Dim pathD As String = "C:\Hack\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(Path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "DIR")
        fs.Write(info, 0, info.Length)
        fs.Close()
        Timer16.Enabled = True
    End Sub
    'Loops back to button
    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        Dim fileName As String
        fileName = "DIR"
        Dim pathD As String = "C:\Hack\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "DIR")
        fs.Write(info, 0, info.Length)
        fs.Close()
        btnUniCrash.Enabled = True
    End Sub
    Private Sub btnMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Music.Show()
    End Sub
    Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWord.Click
        Word1.Show()
    End Sub
    'Line 101-125 is unknown
    Private Sub Sync()
        CurPos = Cursor.Position
        AppSize = Me.Size
    End Sub
    Private Sub refpositions()
        oloc = Me.Location
        ocur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMove.MouseDown
        RszTmr.Start()
        refpositions()
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMove.MouseUp
        RszTmr.Stop()
        refpositions()
    End Sub
    Private Sub RszTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RszTmr.Tick
        Me.Location = oloc - ocur + System.Windows.Forms.Cursor.Position
        refpositions()
    End Sub
    'Line 124 through 134 is the bar movement
    Private Sub pnlMove_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        tmrMove.Start()
        Sync()
    End Sub
    Private Sub pnlMove_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        tmrMove.Stop()
        Sync()
    End Sub
    Private Sub MoveTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrMove.Tick
        Me.Size = AppSize - CurPos + Cursor.Position
        refpositions()
    End Sub
    'Clicking on the X closes the form
    Private Sub ptrExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ptrExit.Click
        Me.Close()
    End Sub
    ' Line 143 to line 170 is the New Flash
    Private Sub btnNewFlash_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFlash.Click
        tmrFlash.Enabled = True
        Dim rndFlash As New Random
        rndFlash.Next(1, 11)
        Select Case rndFlash.Next(1, 11)
            Case 1
                Me.BackColor = Color.Red
            Case 2
                Me.BackColor = Color.Blue
            Case 3
                Me.BackColor = Color.Green
            Case 4
                Me.BackColor = Color.Yellow
            Case 5
                Me.BackColor = Color.White
            Case 6
                Me.BackColor = Color.Chocolate
            Case 7
                Me.BackColor = Color.Black
            Case 8
                Me.BackColor = Color.Indigo
            Case 9
                Me.BackColor = Color.Purple
        End Select
    End Sub
    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick
        btnNewFlash.PerformClick()
    End Sub

End Class