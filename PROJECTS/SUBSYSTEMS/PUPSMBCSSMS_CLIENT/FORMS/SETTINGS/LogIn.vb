Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Public Class frmLogIn
    Public LOGGED As Boolean = False
    Dim triaL As Integer = 0
    Dim PadLockSize As New Size
    Dim PadLockLoc As New Point

    Private Sub txtUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus
        toHL(txtUserName)
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtUserName.Text.Trim = "" Then Exit Sub
            If txtPassword.Text.Trim = "" Then toHL(txtPassword) Else Call btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogIn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblCapslock.Visible = My.Computer.Keyboard.CapsLock
    End Sub

    Private Sub frmLogIn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UPDATEr("tbleclient","online=0","userid='" & logID  & "'")
    End Sub

    Private Sub frmLogIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.CapsLock Then lblCapslock.Visible = My.Computer.Keyboard.CapsLock
        If e.KeyCode = Keys.Escape Then Call btnClose_Click(sender, e)
    End Sub

    Sub RESET()
        With My.Settings
            .SERVER = ""
            .USERID = ""
            .PASSWORD = ""
            .DATABASE = ""
            .Save()
        End With
    End Sub
    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' RESET()
        Me.Hide()
        AssignConnection()
        AssignConnection()

        PadLockSize = pbPadLock.Size
        PadLockLoc = pbPadLock.Location

        LOGGED = False
        logID = ""
        logUserType = ""
        logUserName = ""
        pbLoading.Hide()

  
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        '        On Error GoTo c
        Dim StartClient As Integer = CInt(gIDVal("StartClient"))
        If txtUserName.Text.Trim = "" Then MB("Username field is empty." & vbCr & vbCr & "Empty field is not accepted.") : toHL(txtUserName) : Exit Sub
        If txtPassword.Text.Trim = "" Then MB("Password field is empty." & vbCr & vbCr & "Empty field is not accepted.") : toHL(txtPassword) : Exit Sub

        Dim dR As MySqlDataReader = DataReader("select userid,password,usertype,online,locked from tbleusers where username = '" & txtUserName.Text.Trim.ToUpper & "' and password='" & EncryptText(txtPassword.Text) & "'")
        LOGGED = False
        If dR.Read Then
            If dR.Item(3) = True And Not (dR.Item(2) Like "Administrator" And StartClient = 2) Then MB("Logged in not possible!" & vbCr & vbCr & "Because the user you are trying to log-in is already on the process.", "!") : toHL(txtUserName) : dR.Close() : tmrLoad.Stop() : Return
            If dR.Item(4) = True Then MB("This user is locked!" & vbCr & vbCr & "Contact the administrator to unlock this user.", "x", , "System Locked") : txtUserName.Text.ToUpper() : toHL(txtUserName) : tmrLoad.Stop() : Return
            LOGGED = True : logID = dR.Item(0) : logUserType = dR.Item(2) : logUserName = txtUserName.Text.Trim.ToUpper : logUserPass = dR.Item(1)
        Else
            tmrLoad.Stop()
            triaL += 1 : lblTrial.Text = "No. of trial: " & triaL
            lblTrial.Visible = True : pbWarn.Visible = True
            MB("User name and password did not match." & vbCr & vbCr & "No. of trial: " & triaL, "!", , "Unauthorized User")
            lblAccessFailed.Show() : txtPassword.Focus()
            If triaL >= 3 Then
                MB("You reach the maximum number of trials." & IIf(recCount("tbleusers", "username like '%" & txtUserName.Text.Trim & "%' and usertype not like '%Administrator%'") >= 1, vbCr & getVal("tbleusers", "userid", "username like '%" & txtUserName.Text.Trim & "%'") & " | This user is now locked.", "") & vbCr & vbCr & "Program will terminated.", "x", , "System security")
                LOGS(IIf(recCount("tbleusers", "username like '%" & txtUserName.Text.Trim.ToUpper & "%' and usertype not like '%Administrator%'") > 0, logID & " user is locked.", "") & " " & "Reached the maximum retries allowed for log in.")
                If recCount("tbleusers", "username like '%" & txtUserName.Text.Trim.ToUpper & "%' and usertype not like '%Administrator%'") > 0 Then UPDATEr("tbleusers", "locked=1", "username='" & UCase(txtUserName.Text) & "'")
                End
            End If
            Return
        End If

        If tmrLoad.Enabled = False Then Cursor = Cursors.WaitCursor : pbLoading.Show() : tmrLoad.Enabled = True : Return
        pbLoading.Hide() : tmrLoad.Enabled = False : Cursor = Cursors.Default : txtPassword.Text = "" : tmrListener.Stop()
        Me.Hide()
        If recCount("tbleusers u,tbleclient c", "c.name='" & logID & "' and c.online=1") <= 0 Then frmSelectPC.ShowDialog() ' My.Settings.CIENT =Environ("computername")
        UPDATEr("tbleusers", "online=1", "username='" & logUserName & "' and password='" & logUserPass & "'")
        frmClient.Show() : frmClient.reSET() : frmClient.Refresh() : Close()
        LOGS("Logged in")
        Return
c:      dR.Close() : CONNclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then Call btnLogIn_Click(sender, e) Else End
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        toHL(txtPassword)
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPassword.Text.Trim = "" Then Exit Sub
            If txtUserName.Text.Trim = "" Then toHL(txtUserName) Else Call btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        lblCapslock.Visible = My.Computer.Keyboard.CapsLock
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MB("Close program?", "?") = "y" Then End
    End Sub

    Private Sub lblShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShutdown.Click
        ' If MB("Are you sure you want to shutdown this computer?", "?") = "n" Then Return
        ' Shell("shutdown -s -c ""Save all works before it lost."" -t 3600", AppWinStyle.MaximizedFocus)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtUserName.Text = "bukopandan"
        txtPassword.Text = "123456"
        Call btnLogIn_Click(sender, e)
    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        Cursor = Cursors.Default
        Call btnLogIn_Click(sender, e)
        tmrLoad.Enabled = False
    End Sub

    Private Sub pbPadLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPadLock.Click
        Call btnLogIn_Click(sender, e)
        pbPadLock_MouseLeave(sender, e)
    End Sub

    Private Sub pbPadLock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPadLock.MouseLeave
        pbPadLock.Size = PadLockSize
        pbPadLock.Location = PadLockLoc
    End Sub

    Private Sub pbPadLock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPadLock.MouseMove
        pbPadLock.Top = PadLockLoc.Y - 5
        pbPadLock.Left = PadLockLoc.X - 5
        pbPadLock.Height = PadLockSize.Height + 10
        pbPadLock.Width = PadLockSize.Width + 10
    End Sub

    Private Sub tmrListener_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrListener.Tick
        If CInt(gIDVal("StartClient")) = 2 And recCount("tbleusers", "usertype like '%Administrator%' and online=1") > 0 Then
            tmrListener.Stop()
            txtUserName.Text = getVal("tbleusers", "username", "usertype like '%Administrator%' and online=1")
            txtPassword.Text = DecryptText(getVal("tbleusers", "password", "usertype like '%Administrator%' and online=1"))
            Call btnLogIn_Click(sender, e)
        End If
    End Sub
End Class
