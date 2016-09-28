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
        ' Return
        ' Return   'Close()
        Path = CurDir() & "\DATA\CONNSETUP.SETUPCONFIGURATION"
        PathSMS = CurDir().Replace("\bin\Debug", "\SUBSYSTEMS\SMS\SMS\bin\Debug\SMS.exe") ' & "\SUBSYSTEMS\[SubSystem] SendSMSqueued\SendSMSqueued\bin\Debug\SendSMSqueued.exe"
        PathSearch = CurDir().Replace("\bin\Debug", "\SUBSYSTEMS\SearchStudent\bin\Debug\SearchLogs.exe")  ' & "\SUBSYSTEMS\[SubSystem] SearchStudentLogs\[SubSystem] SearchStudentLogs\bin\Debug\[SubSystem] SearchStudentLogs.exe"
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
        If txtUserName.Text.Trim = "" Then MB("Username field is empty." & vbCr & vbCr & "Empty field is not accepted.") : toHL(txtUserName) : Exit Sub
        If txtPassword.Text.Trim = "" Then MB("Password field is empty." & vbCr & vbCr & "Empty field is not accepted.") : toHL(txtPassword) : Exit Sub

        
        Dim dR As MySqlDataReader = DataReader("select userid,password,usertype,online,locked from tbleusers where username = '" & txtUserName.Text.Trim.ToUpper & "' and password='" & EncryptText(txtPassword.Text) & "'")
        LOGGED = False
        For Each item In dR
            LOGGED = True : logID = dR.Item(0) : logUserType = dR.Item(2) : logUserName = txtUserName.Text.Trim.ToUpper
            ADMINPASSWORD = dR.Item(1)


            Exit For

            'if user is logged on
            If dR.Item(3) = True Then MB("Logged in not possible!" & vbCr & vbCr & "Because the user you are trying to log-in is already on the process.", "!") : toHL(txtUserName) : dR.Close() : Return
            'if user is locked
            If dR.Item(4) = True Then MB("This user is locked!" & vbCr & vbCr & "Contact the administrator to unlock this user.", "x", , "System Locked") : txtUserName.Text.ToUpper() : toHL(txtUserName) : Return
            Exit For
        Next
        dR.Close()
        If LOGGED = False Then
            triaL += 1 : lblTrial.Text = "No. of trial: " & triaL
            lblTrial.Visible = True : pbWarn.Visible = True
            MB("User name and password did not match." & vbCr & vbCr & "No. of trial: " & triaL, "!", , "Unauthorized User")
            lblAccessFailed.Show() : txtPassword.Focus()
            If triaL >= 3 Then
                MB("You reach the maximum number of trials." & IIf(recCount("tbleusers", "username like '%" & txtUserName.Text.Trim & "%' and usertype not like '%Administrator%'") >= 1, _
                            vbCr & getVal("tbleusers", "userid", "username like '%" & txtUserName.Text.Trim & "%'") & " | This user is now locked.", "") & _
                            vbCr & vbCr & "Program will terminated.", "x", , "System security")
                If recCount("tbleusers", "username like '%" & txtUserName.Text.Trim & "%'") > 0 Then
                    logID = getVal("tbleusers", "userid", "username='" & txtUserName.Text.Trim.ToUpper & "'")
                    logUserType = getVal("tbleusers", "usertype", "username='" & txtUserName.Text.Trim.ToUpper & "'")
                End If
                LOGS(IIf(recCount("tbleusers", "username like '%" & txtUserName.Text.Trim.ToUpper & "%' and usertype not like '%Administrator%'") > 0, logID & " user is locked.", "") & " " & "Reached the maximum retries allowed for log in.")
                If recCount("tbleusers", "username like '%" & txtUserName.Text.Trim.ToUpper & "%' and usertype not like '%Administrator%'") > 0 Then _
                    UPDATEr("tbleusers", "locked=1", "username='" & UCase(txtUserName.Text) & "'")
                End
            End If
            Return
        End If

        If tmrLoad.Enabled = False Then Sounds(AUDIO.CLICK) : Cursor = Cursors.WaitCursor : pbLoading.Show() : tmrLoad.Enabled = True : Return
        UPDATEr("tbleusers", "online=1", "username='" & txtUserName.Text.Trim.ToUpper & "' and password='" & EncryptText(txtPassword.Text) & "'")
        pbLoading.Hide() : tmrLoad.Enabled = False : Cursor = Cursors.Default : txtPassword.Text = ""
        Sounds(AUDIO.ACTIVATED)
        Me.Hide()
        'If logUserType.ToLower.ToString.Contains("administrator") Then
        MB("Welcome " & logUserType & "!")
        If recCount("tbleusers", "locked=1") >= 1 Then If MB("Some of users of this system was locked." & vbCr & "Do you want to show the access settings?", "?") = "y" Then frmAccessSettings.ShowDialog()
        frmMAIN.Show() : frmMAIN.LOAD_STARTUP_SETTINGS() : frmMAIN.Refresh()
        'End If
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
        Sounds(AUDIO.CLICK)
        If MB("Close program?", "?") = "y" Then End
    End Sub

    Private Sub lblShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShutdown.Click
        Sounds(AUDIO.CLICK)
        If MB("Are you sure you want to shutdown this computer?", "?") = "n" Then Return
        Shell("shutdown -s -c ""Save all works before it lost."" -t 3600", AppWinStyle.MaximizedFocus)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtUserName.Text = "brittle"
        txtPassword.Text = "123456"
        Call btnLogIn_Click(sender, e)
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
End Class
