Public Class Slot
    Dim int1 As Integer
    Dim int2 As Integer
    Dim int3 As Integer
    Dim Pic1 As String
    Dim Pic2 As String
    Dim Pic3 As String
    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)
    Dim blnGameModeNum As Boolean
    Dim blnGameModePic As Boolean
    Private Sub Sync()
        CurPos = Cursor.Position
        AppSize = Me.Size
    End Sub
    Private Sub refpositions()
        oloc = Me.Location
        ocur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        RszTmr.Start()
        refpositions()
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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
    Private Sub MoveTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles moveTmr.Tick
        Me.Size = AppSize - CurPos + Cursor.Position
        refpositions()
    End Sub
    'The Circulum begins here
    Private Sub btnPull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPull.Click
        Dim intNum1 As String
        Dim intNum2 As String
        Dim intNum3 As String
        intNum1 = lblNum1.Text
        intNum2 = lblNum2.Text
        intNum3 = lblNum3.Text
        If intNum1 = "" And intNum2 = "" And intNum3 = "" Then
        Else : lstHistory.Items.Add(intNum1 & "," & intNum2 & "," & intNum3)
        End If
        If blnGameModeNum = True Then
            blnGameModePic = False
            Static Token As Integer = 100
            lblTokens.Text = "You have " & Token & " Tokens."
            lblTokens.TextAlign = ContentAlignment.MiddleCenter
            Token -= 1
            Dim rdmNumber As New Random
            int1 = rdmNumber.Next(1, 4)
            int2 = rdmNumber.Next(1, 4)
            int3 = rdmNumber.Next(1, 4)
            lblNum1.Text = int1
            lblNum2.Text = int2
            lblNum3.Text = int3


            If int1 = 1 And int2 = 1 And int3 = 1 Then
                Token += 4
                MessageBox.Show("You had all Ones!" & vbCrLf & "You get 4 tokens.")
            End If
            If int1 = 2 And int2 = 2 And int3 = 2 Then
                Token += 4
                MessageBox.Show("You had all Twos!" & vbCrLf & "You get 4 tokens.")
            End If
            If int1 = 3 And int2 = 3 And int3 = 3 Then
                Token += 4
                MessageBox.Show("You had all Threes!" & vbCrLf & "You get 4 tokens.")
            End If

        End If
        'The pictures 
        If blnGameModePic = True Then
            blnGameModeNum = False
            Static Token1 As Integer = 100
            lblTokens.Text = "You have " & Token1 & " Tokens."
            lblTokens.TextAlign = ContentAlignment.MiddleCenter
            Token1 -= 1

            lblNum1.Text = ""
            lblNum2.Text = ""
            lblNum3.Text = ""
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            a = 1 + Int(Rnd() * 3)
            b = 1 + Int(Rnd() * 3)
            c = 1 + Int(Rnd() * 3)
            If a = 1 Then
                lblNum1.Image = Image.FromFile("H:\Downloads\Michelle slot\w.png")
            End If
            If a = 2 Then
                lblNum1.Image = Image.FromFile("H:\Downloads\Michelle slot\T.jpg")
            End If
            If a = 3 Then
                lblNum1.Image = Image.FromFile("H:\Downloads\Michelle slot\p.jpg")
            End If
            If b = 1 Then
                lblNum2.Image = Image.FromFile("H:\Downloads\Michelle slot\w.png")
            End If
            If b = 2 Then
                lblNum2.Image = Image.FromFile("H:\Downloads\Michelle slot\T.jpg")
            End If
            If b = 3 Then
                lblNum2.Image = Image.FromFile("H:\Downloads\Michelle slot\p.jpg")
            End If
            If c = 1 Then
                lblNum3.Image = Image.FromFile("H:\Downloads\Michelle slot\w.png")
            End If
            If c = 2 Then
                lblNum3.Image = Image.FromFile("H:\Downloads\Michelle slot\T.jpg")
            End If
            If c = 3 Then
                lblNum3.Image = Image.FromFile("H:\Downloads\Michelle slot\p.jpg")
            End If
            If c = 1 And a = 1 And b = 1 Then
                My.Computer.Audio.Play("C:\4th Period VB\work.wav", AudioPlayMode.Background)
                MessageBox.Show("You had all Ones!" & vbCrLf & "You get 4 tokens.")
                Token1 += 4
            End If
            If a = 2 And b = 2 And c = 2 Then
                My.Computer.Audio.Play("C:\4th Period VB\turnup.wav", AudioPlayMode.Background)
                MessageBox.Show("You had all Twos!" & vbCrLf & "You get 4 tokens.")
                Token1 += 4
            End If
            If a = 3 And c = 3 And b = 3 Then
                My.Computer.Audio.Play("C:\4th Period VB\sweet.wav", AudioPlayMode.Background)
                MessageBox.Show("You made michelle eat 3 times!" & vbCrLf & "You get 4 tokens.")
                Token1 += 4
            End If
        End If
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub mnuNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNumbers.Click
        blnGameModeNum = True
        blnGameModePic = False
    End Sub
    Private Sub mnuPictures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPictures.Click
        blnGameModePic = True
        blnGameModeNum = False
    End Sub
    Private Sub Slot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnGameModeNum = False
        blnGameModePic = False
    End Sub

    Private Sub ShowHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHistory.Click
        If mnuHistory.Text = "Show History" Then
            Me.Size = MaximumSize
            mnuHistory.Text = "Hide History"
        Else
            mnuHistory.Text = "Show History"
            Me.Size = MinimumSize
        End If
    End Sub
End Class