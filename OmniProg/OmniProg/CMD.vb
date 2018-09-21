Imports System.IO
Imports System.Text
    Imports System

Public Class CMD
    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)
    'Shutdown -i Command
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        Dim fileName As String
        fileName = "Shutdown"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "shutdown -i")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Dir Command
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir.Click
        Dim fileName As String
        fileName = "DIR"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "DIR")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Tree Command
    Private Sub btnTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTree.Click
        Dim fileName As String
        fileName = "tree"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "tree")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Shows Date Command
    Private Sub btnDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDate.Click
        Dim fileName As String
        fileName = "DATE"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & "DATE")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Log Off Command
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        Dim fileName As String
        fileName = " LOGOFF "
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & " LOGOFF")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Help command
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim fileName As String
        fileName = " Help"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & " Help")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Delete files (not working yet)
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\help.bat")
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\logoff.bat")
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\date.bat")
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\tree.bat")
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\dir.bat")
        My.Computer.FileSystem.DeleteFile("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\shutdown.bat")
    End Sub
    'Creates folder
    Private Sub CMD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory("\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS")
    End Sub
    'Check Disk Command
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim fileName As String
        fileName = " Chkdsk"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & fileName)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Cipher Command
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCipher.Click
        Dim fileName As String
        fileName = " Cipher"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & fileName)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
    'Host name Command
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fileName As String
        fileName = " hostname"
        Dim pathD As String = "\\H0526sfs01\Home$\Students\9394216\Desktop\CMD COMMANDS\" & fileName & ".bat"
        Dim path As String = pathD
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.  
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo on" & vbCrLf & fileName)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick

    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick

    End Sub
End Class