Imports System
Imports System.IO
Imports System.Text
Public Class frmBank
    Dim oloc As New Point(0, 0)
    Dim ocur As New Point(System.Windows.Forms.Cursor.Position)
    Dim CurPos, AppSize As New Point(0, 0)
    Dim decAmount As Decimal
    Dim decWithdraw As Decimal
    Dim decDeposit As Decimal
    Dim decBalance As Decimal
    Dim decDepositAcc As Decimal
    Dim blnResult As Boolean
    Dim decWithAcc As Decimal
    'Line 15-55 moves the form with the pannel 
    Private Sub Sync()
        CurPos = Cursor.Position
        AppSize = Me.Size
    End Sub
    Private Sub refpositions()
        oloc = Me.Location
        ocur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMove.MouseDown
        tmrRsz.Start()
        refpositions()
    End Sub
    Private Sub pnlMove_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMove.MouseHover
        pnlMove.BackgroundImage = Image.FromFile("\\H0526sfs01\Home$\Students\9394216\My Documents\My Pictures\Move hover.png")
        lblAction.Text = "Move the form"
    End Sub
    Private Sub pnlMove_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMove.MouseLeave
        pnlMove.BackgroundImage = Image.FromFile("\\H0526sfs01\Home$\Students\9394216\My Documents\My Pictures\Move.png")
        lblAction.Text = ""
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMove.MouseUp
        tmrRsz.Stop()
        refpositions()
    End Sub
    Private Sub RszTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRsz.Tick
        Me.Location = oloc - ocur + System.Windows.Forms.Cursor.Position
        refpositions()
    End Sub
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
    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        'If blnResult is true then the tryparse worked sucessfully
        blnResult = Decimal.TryParse(txtAmount.Text, decAmount)
        If blnResult = False Then MessageBox.Show("Please enter your money in arabic Numbers, or enter a lower amount.")
        'If the user wants to perform a deposit
        If cboTrans.Text = "Deposit" And blnResult = True Then
            decDeposit = decAmount
            decDepositAcc += decDeposit
            lstMain.Items.Add("Deposit: $" & decDeposit)
        End If
        'If the user wants to take money out of the piggy bank
        If cboTrans.Text = "Withdraw" And blnResult = True Then
            decWithdraw = decAmount
            decWithAcc += decWithdraw
            lstMain.Items.Add("Withdraw: $" & decWithdraw)
        End If
        ' If nothing is entered an error will appear
        If cboTrans.Text = "" Then
            MessageBox.Show("Please enter a valid transaction type.")
        End If
        'Resets the combo box and text box text to nothing
        txtAmount.Text = ""
        cboTrans.Text = ""
    End Sub
    Private Sub cmbBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBalance.Click
        'Subtracts the Withdraw Accumulator Variable from the Deposit Accumulator
        decBalance = decDepositAcc - decWithAcc
        lstMain.Items.Add("Balance: $" & decBalance)
    End Sub
    Private Sub lstAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAbout.Click
        'Shows the about box
        About.Show()
    End Sub
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        subExit()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptrExit.Click
        subExit()
    End Sub
    Private Sub ptrMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cboReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReset.Click
        subReset()
    End Sub
    'Changes the picture box when you click exit
    Private Sub ptrExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptrExit.MouseHover
        ptrExit.Image = Image.FromFile("\\H0526sfs01\Home$\Students\9394216\My Documents\My Pictures\X hover.png")
        lblAction.Text = "Exit the form"
    End Sub
    Private Sub ptrExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptrExit.MouseLeave
        ptrExit.Image = Image.FromFile("\\H0526sfs01\Home$\Students\9394216\My Documents\My Pictures\X.png")
        lblAction.Text = ""
    End Sub
    Private Sub btnTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTrans.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                lblAmount.Text = "Matt's Hack"
        End Select
    End Sub
    Private Sub pnlEaster_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEaster.MouseHover
        My.Computer.Audio.Play("C:\4th Period VB\realitycheck.wav", AudioPlayMode.Background)
    End Sub
    'Public Start here
    Public Sub subReset()
        lstMain.Items.Clear()
        decDepositAcc = 0
        decWithAcc = 0
        decDeposit = 0
        decWithdraw = 0
    End Sub
    Public Sub subExit()
        Application.Exit()
    End Sub

    Private Sub lblEasterShow_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEasterShow.MouseHover
        MessageBox.Show("Find all three easter eggs on the form")
    End Sub

    Private Sub mnuMain_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles mnuMain.Scroll
        MessageBox.Show("@SDSDAASD")
    End Sub


End Class
