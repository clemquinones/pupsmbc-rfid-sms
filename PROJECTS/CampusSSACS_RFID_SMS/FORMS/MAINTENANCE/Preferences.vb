
Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Public Class frmPreferences
    Dim ButtonClicked As String = Nothing
    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    'LOAD: 1. setSizeLocation
    '      2. showHideGB
    'Public bGB As String = ""
    'Public GBSize As New Size, GBLocation As Point, GBRLocation As New Point()
    Public Sub setSizeLocation() '1
        'GBLocation = New Point(gbGeneral.Location)
        'GBSize = gbGeneral.Size
        gbSystemUsers.Size = gbGeneral.Size : gbSystemUsers.Hide()
        gbSystemUsers.Location = gbGeneral.Location
        gbSMSTechnology.Size = gbGeneral.Size : gbSMSTechnology.Hide()
        gbSMSTechnology.Location = gbGeneral.Location
        gbClient.Size = gbGeneral.Size : gbClient.Hide()
        gbClient.Location = gbGeneral.Location
        gbRecords.Size = gbGeneral.Size : gbRecords.Hide()
        gbRecords.Location = gbGeneral.Location
        gbGeneral.Show() : SHOWHIDEGB()
        'ID FORMAT - if already updated
        'If CBool(gIDVal("IDFormat")) = False Then btnIDFormat.Enabled = True : lblID_Note.Text = "Note: If you continue changing of ID, you cannot update it again." Else btnIDFormat.Enabled = False : lblID_Note.Text = "You have already updated this settings. You cannot change it again."

        GB_RESET_ALL()
    End Sub

    Public LefButton As String = ""
    Public Sub SHOWHIDEGB(Optional ByVal bGB As String = "")
        If bGB = "" Then bGB = btnGeneral.Name
        If bGB <> btnGeneral.Name Then
            gbGeneral.Hide() ': gbGeneral.Location = GBRLocation
        ElseIf bGB = btnGeneral.Name And gbGeneral.Visible = False Then
            gbGeneral.Show() : btnGeneral.BackColor = Color.Magenta ': gbGeneral.Location = GBLocation ':        End If
        End If

        If bGB <> btnSystemUsers.Name Then
            gbSystemUsers.Hide() ': gbSystemUsers.Location = GBRLocation
        ElseIf bGB = btnSystemUsers.Name And gbSystemUsers.Visible = False Then
            gbSystemUsers.Show() : btnSystemUsers.BackColor = Color.Magenta ': gbSystemUsers.Location = GBLocation 
        End If

        If bGB <> btnSMSTechnology.Name Then
            gbSMSTechnology.Hide() ': gbSMSTechnology.Location = GBRLocation
        ElseIf bGB = btnSMSTechnology.Name And gbSMSTechnology.Visible = False Then
            gbSMSTechnology.Show() : btnSMSTechnology.BackColor = Color.Magenta ': gbSMSTechnology.Location = GBLocation 
        End If

        If bGB <> btnClient.Name Then
            gbClient.Hide() ': gbClient.Location = GBRLocation
        ElseIf bGB = btnClient.Name And gbClient.Visible = False Then
            gbClient.Show() : btnClient.BackColor = Color.Magenta ': gbClient.Location = GBLocation 
        End If

        If bGB <> btnRecords.Name Then
            gbRecords.Hide() ' : gbRecords.Location = GBRLocation
        ElseIf bGB = btnRecords.Name And gbRecords.Visible = False Then
            gbRecords.Show() : btnRecords.BackColor = Color.Magenta ': gbRecords.Location = GBLocation 
        End If

        If bGB <> btnGSMModule.Name Then
            gbGSMModule.Hide() ': gbGSMModule.Location = GBRLocation
        ElseIf bGB = btnGSMModule.Name And gbGSMModule.Visible = False Then
            gbGSMModule.Show() : btnGSMModule.BackColor = Color.Magenta ': gbGSMModule.Location = GBLocation 
        End If
        LefButton = bGB
    End Sub

    Public Sub GB_RESET_ALL()
        'GENERAL
        ' Call btnGeneral_Click()
        lblGPrev.Text = "" : lblGNext.Text = ""
        GCenter = New Point(6, gbG1.Top) : GRigth = New Point(6 + gbG1.Width + 20, gbG1.Top)
        chkGSplash.Checked = My.Settings.SplashScreen
        chkGGSMDetect.Checked = My.Settings.AutoDetectGSM
        chkGStartSend.Checked = My.Settings.StartSending
        chkGAutoStartClient.Checked = My.Settings.StartClient
        chkSounds.Checked = Not My.Settings.Sounds



        'SYSTEM USRES
        'GB_SU_CLocation = gbUsersList.Location
        'GB_SU_RLocation = New Point(GB_SU_CLocation.X + gbUsersList.Size.Width + 20, GB_SU_CLocation.Y)
        gbUpdateUser.Size = gbUsersList.Size : gbUpdateUser.Location = gbUsersList.Location
        gbAddUser.Size = gbUsersList.Size : gbAddUser.Location = gbUsersList.Location
        gbUpdateUser.Hide() : gbAddUser.Hide() : gbUsersList.Show()
        'gbUpdateUser.Size = gbUsersList.Size : gbUpdateUser.Location = gbUsersList.Location
        'gbAddUser.Size = gbUsersList.Size : gbAddUser.Location = gbUsersList.Location
        Call btnListUsers_Click()

        Return
        gbGSMModule.Size = gbMessage.Size : gbGSMModule.Location = gbMessage.Location
        Call btnSaved_Click()

        'If gbClient.Visible = True Then
        '   dtpClientShtdown.Text = getDateTime(CDate(getVal("tbleid", "format", "field like '%SystemShutdown%'")), GetDateTimeValue.OO_OO_AM_PM)
        '   guard settings
        'End If
        'If gbRecords.Visible = True Then Call btnSystem_Click()
    End Sub

#Region "LEFT TOOLBAR BUTTONS"
    Public Sub btnGeneral_Click() Handles btnGeneral.Click
        Sounds(AUDIO.CLICK)
        SHOWHIDEGB()
    End Sub
    Public Sub btnSystemUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemUsers.Click
        Sounds(AUDIO.CLICK)
        Sounds(AUDIO.CLICK)
        SHOWHIDEGB(btnSystemUsers.Name)
    End Sub
    Public Sub btnSMSTechnology_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSTechnology.Click
        Sounds(AUDIO.CLICK)
        Sounds(AUDIO.CLICK)
        SHOWHIDEGB(btnSMSTechnology.Name)
        If Not tmrUpdateMSG.Enabled Then tmrUpdateMSG.Start()
    End Sub
    Public Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        Sounds(AUDIO.CLICK)
        Sounds(AUDIO.CLICK)
        SHOWHIDEGB(btnClient.Name)
    End Sub
    Public Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        Sounds(AUDIO.CLICK)
        Sounds(AUDIO.CLICK)
        SHOWHIDEGB(btnRecords.Name)
        Call btnSystem_Click(sender, e)
    End Sub
#End Region

    Public Sub frmPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Size = New Size(743, 547) ' size of gb = 
        'RIGTH GB location: 745, 69
        'CENTER GB location: 493, 388
        'gbRecords.Show()
        'gbgeneral location: 226, 69

        'gbGeneral SIZE: 494, 408

        '  GBLocation = gbGeneral.Location
        ' GBRLocation = New Point((gbGeneral.Location.X + gbGeneral.Size.Width) + 60, gbGeneral.Location.Y)
        setSizeLocation() 'final positioning
        lblVersion.Text = Environment.OSVersion.VersionString
    End Sub

#Region "GENERAL"
    Private Sub btnDefaultGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefaultGeneral.Click
        Sounds(AUDIO.CLICK)
        If MB("Restore to default?", "?") = "n" Then Return
        chkGSplash.Checked = True
        chkGGSMDetect.Checked = True
        chkGAutoStartClient.Checked = False
        chkGStartSend.Checked = True
        chkSounds.Checked = True
    End Sub
    Private Sub btnGPrevious_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGPrevious.MouseLeave
        lblGPrev.Text = "" : btnGPrevious.ForeColor = Color.DimGray
    End Sub
    Private Sub btnGPrevious_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnGPrevious.MouseMove
        If gbG1.Visible = True Then Return Else lblGPrev.Text = "Previous" : btnGPrevious.ForeColor = Color.White
    End Sub
    Private Sub btnGNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGNext.MouseLeave
        lblGNext.Text = "" : btnGNext.ForeColor = Color.DimGray
    End Sub
  
    Public GRigth, GCenter As Point
    Private Sub btnGPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGPrevious.Click
        Sounds(AUDIO.CLICK)
        If gbG1.Visible = True Then Return Else btnGPrevious.ForeColor = Color.DimGray : gbG1.Location = GCenter : gbG1.Show()
    End Sub
    Private Sub btnGNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGNext.Click
        Sounds(AUDIO.CLICK)
    End Sub
    Private Sub btnGSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGApply.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to save?", "?") = "n" Then Return
        If gbG1.Visible = True Then
            UPDATEr("tbleid", "value=" & chkGSplash.Checked, "field = 'SplashScreen'")
            UPDATEr("tbleid", "value=" & chkGGSMDetect.Checked, "field = 'DetectSMS'")
            UPDATEr("tbleid", "value=" & chkGStartSend.Checked, "field = 'SendSMS'")
            UPDATEr("tbleid", "value=" & Not chkSounds.Checked, "field = 'Sounds'")

            If chkGAutoStartClient.Checked = True Then UPDATEr("tbleid", "value=" & IIf(rbShowLogin.Checked = True And rbShowLogin.Checked = True, "1", "2"), "field like '%StartClient%'")
            UPDATEr("tbleid", "value=" & chkGShutdownDisconnected.Checked, "field like '%ShutdownDisconnect%'")

            My.Settings.SplashScreen = chkGSplash.Checked
            My.Settings.AutoDetectGSM = chkGGSMDetect.Checked
            My.Settings.StartSending = chkGStartSend.Checked
            My.Settings.StartClient = chkGAutoStartClient.Checked
            My.Settings.StartClientLogIn = rbShowLogin.Checked
            My.Settings.StartClientAdmin = rbLogAsAdmin.Checked
            My.Settings.Sounds = Not chkSounds.Checked


            My.Settings.Save()
            LOGS("Update general system settings.")
        Else
            'id format change
        End If
        MB("Saved!")
    End Sub

    Private Sub btnIDFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sounds(AUDIO.CLICK)
        If MB("D you want to continue?", "?") = "y" Then Call btnGNext_Click(sender, e)
    End Sub
#End Region
#Region "SYSTEM USERS" 
    Sub SU_ShowHideGB(Optional ByVal button As String = "")
        If button = "" Then button = btnListUsers.Name
        If button = btnListUsers.Name And Not gbUsersList.Visible = True Then
            gbUpdateUser.Hide() : btnUpdateMy.Tag = "" : btnUpdateMy.Text = "&Update My Profile" ' : gbUpdateUser.Location = GB_SU_RLocation
            gbAddUser.Hide() 'gbAddUser.Location = GB_SU_RLocation
            gbUsersList.Show()
            LV_ListUsers()
        ElseIf button = btnUpdateMy.Name And Not gbUpdateUser.Visible = True Then
            gbUsersList.Hide()
            gbAddUser.Hide()
            gbUpdateUser.Show()
            Dim dR As MySqlDataReader = DataReader("select userid,username,fname,lname,number from tbleusers where userid='" & IIf(btnUpdateMy.Tag = "", logID, btnUpdateMy.Tag) & "'")
            For Each item In dR
                lblUUserID.Text = dR.Item(0)
                txtUUserName.Text = dR.Item(1)
                txtUFName.Text = dR.Item(2)
                txtULName.Text = dR.Item(3)
                chkPass.Checked = False : txtUPass.Text = "" : txtUPass1.Text = "" : txtUPass2.Text = ""
                txtUNumber.Text = dR.Item(4)
                Exit For
            Next
            dR.Close()
            toHL(txtUFName)
        ElseIf button = btnAddUser.Name And Not gbAddUser.Visible = True Then
            gbUsersList.Hide() ' : gbUsersList.Location = GB_SU_RLocation
            gbUpdateUser.Hide() : btnUpdateMy.Text = "&Update My Profile"
            gbAddUser.Show()
            lblAUserID.Text = generateID("User")
            txtAFName.Text = "First" : txtALName.Text = "Last"
            cmbUserType.Text = "Client Manager"
            txtAUserName.Text = "User name"
            txtAPass1.Text = "" : txtAPass2.Text = ""
            chkALocked.Checked = True
            chkASearch.Checked = True
            chkAView.Checked = True
            chkAShutdown.Checked = True
            chkAOperate.Checked = True
            toHL(txtAFName)
        End If
    End Sub
    Public Sub btnUpdateMy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateMy.Click
        Sounds(AUDIO.CLICK)
        If btnUpdateMy.Text.Contains("Update My Profile") Then btnUpdateMy.Text = "Update Changes"
        If Not gbUpdateUser.Visible = True Then SU_ShowHideGB(btnUpdateMy.Name) : btnUpdateMy.Tag = "" : Return
        'If gbUpdateUser.Visible = False Then gbUpdateUser.Show() : Return
        If txtUUserName.Text.Trim = "" Then MB("Empty user name!", "!") : toHL(txtUUserName) : Return
        If Not chkPass.Checked = True Then GoTo UPDATEUSER
        If txtUPass.Text = "" Then MB("Empty old password!") : toHL(txtUPass) : Return
        If Not txtUPass.Text = DecryptText(getVal("tbleusers", "password", "userid='" & logID & "'")) Then MB("Password did not match from your old password!") : toHL(txtUPass) : Return
        If txtUPass1.Text = "" Or txtUPass2.Text = "" Then MB("Empty new password cannot accept!") : toHL(IIf(txtUPass1.Text.Trim = "", txtUPass1, txtUPass2)) : Return
        If txtUPass1.Text <> txtUPass2.Text Then MB("New password did not match!") : toHL(txtUPass1) : Return
        If txtUNumber.Text.Trim.ToLower = "" Or "number" Then MB("Enter valid contact number!", "!") : toHL(txtUNumber) : Return
UPDATEUSER: If MB("Do you want to save?", "?") = "n" Then Return
        UPDATEr("tbleusers", "username='" & txtUUserName.Text.Trim & "'" & IIf(chkPass.Checked = True, ",password='" & EncryptText(txtUPass1.Text) & "'", "") & ",number='" & txtUNumber.Text.Trim & "'", "userid = '" & lblUUserID.Text & "'")
        LOGS("Update profile of user " & txtUUserName.Text & ".")
        MB("Saved!") : btnUpdateMy.Text = "&Update My Profile"
        SU_ShowHideGB(btnListUsers.Name)
    End Sub
    Public Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Sounds(AUDIO.CLICK)
        If Not gbAddUser.Visible = True Then SU_ShowHideGB(btnAddUser.Name) : Return
        If txtAFName.Text.Trim = "" Or txtAFName.Text.Trim.ToLower.Contains("first") Then MB("Cannot accept null first name!", "!") : toHL(txtAFName) : Return
        If txtALName.Text.Trim = "" Or txtALName.Text.Trim.ToLower.Contains("last") Then MB("Cannot accept null last name!", "!") : toHL(txtALName) : Return
        If cmbUserType.Text = "" Then MB("Choose user-type!", "!") : cmbUserType.Focus() : Return
        If txtAUserName.Text.Trim = "" Then MB("Cannot accept null username!" & vbCr & vbCr & "This will use everytime you log in.", "!") : toHL(txtAUserName) : Return
        If txtAUserName.Text.Trim.ToLower.Contains("user name") Then MB("Cannot use reserved word 'User Name'", "!") : toHL(txtAUserName) : Return
        If txtAUserName.Text.Trim.Length < 6 Or txtAUserName.Text.Trim.Length > 12 Then MB("User name must be atleast 6 characters and less than or equal 12.") : toHL(txtAUserName) : Return
        If recCount("tbleusers", "upper(username)='" & txtAUserName.Text.Trim.ToUpper & "'") > 0 Then MB("User Name is already exists!", "!") : toHL(txtAUserName) : Return
        If txtAPass1.Text = "" Or txtAPass2.Text = "" Then MB("Cannot accept null password!", "!") : toHL(IIf(txtAPass1.Text = "", txtAPass1, txtAPass2)) : Return
        If txtAPass1.Text.Length < 6 Or txtAPass2.Text.Length < 6 Or txtAPass1.Text.Length > 12 Or txtAPass2.Text.Length > 12 Then MB("Password length must be atleast 6 characters and less than or equals 12 characters.", "!") : toHL(txtAPass1) : txtAPass2.Text = "" : Return
        If Not txtAPass1.Text = txtAPass2.Text Then MB("Password did not match!", "!") : toHL(txtAPass1) : Return
        If MB("Do you want to save new user?", "?") = "n" Then Return
        INSERTr("tbleusers", "'" & generateID("User") & "','" & v(txtAUserName.Text.Trim.ToUpper) & "','" & EncryptText(txtAPass1.Text) & "','" & _
               v(txtAFName.Text.Trim) & "','" & v(txtALName.Text.Trim) & "','" & v(txtUNumber.Text.Trim) & "','" & cmbUserType.Text & IIf(cmbUserType.Text = "Administrator", "_" & (recCount("tbleusers", "usertype like '%Admin%'") + 1), "") & "'," & chkALocked.Checked & ",0," & _
                chkASearch.Checked & "," & chkAView.Checked & "," & chkAShutdown.Checked & "," & chkAOperate.Checked & ",0,0")
        incrementID("User") : LOGS("User account of user " & lblAUserID.Text & " has been created.")
        MB("New user saved!")
        SU_ShowHideGB(btnListUsers.Name)
    End Sub
    Public Sub btnListUsers_Click() Handles btnListUsers.Click
        Sounds(AUDIO.CLICK)
        SU_ShowHideGB(btnListUsers.Name)
    End Sub
    Public Sub LV_ListUsers()
        LVUsers.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select userid,fname,lname,username,usertype from tbleusers")
        For Each item In dR
            li = LVUsers.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & " " & dR.Item(2))
            li.SubItems.Add(dR.Item(3)) : li.SubItems.Add(dR.Item(4))
        Next
        dR.Close()
        lblURecordCount.Text = "Record count: " & LVUsers.Items.Count
    End Sub
    Private Sub btnShowAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAccess.Click
        Sounds(AUDIO.CLICK)
        If MB("Show User Access Control Window?", "?") = "n" Then Return
        Me.Hide() : frmAccessSettings.ShowDialog() : Me.Show()
    End Sub
    Private Sub btnUpdateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUser.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LVUsers) Then Return
        On Error Resume Next
        btnUpdateMy.Tag = LVUsers.Items(LVUsers.SelectedIndices(0)).Text
        btnUpdateMy_Click(sender, e)
    End Sub

    Private Sub chkPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPass.CheckedChanged
        txtUPass.Enabled = chkPass.Checked
        txtUPass1.Enabled = chkPass.Checked
        txtUPass2.Enabled = chkPass.Checked
        If txtUPass.Enabled Then toHL(txtUPass)
    End Sub

#Region "GENERAL GOTFOCUS/LOSTFOCUS"
    Private Sub txtUUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUUserName.GotFocus
        GotFocusText(txtUUserName, "User name")
    End Sub

    Private Sub txtUUserName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUUserName.LostFocus
        LostFocusText(txtUUserName, "User name")
    End Sub
    Private Sub txtUFName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUFName.GotFocus
        GotFocusText(txtUFName, "First")
    End Sub

    Private Sub txtUFName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUFName.LostFocus
        LostFocusText(txtUFName, "First")
    End Sub

    Private Sub txtULName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtULName.GotFocus
        GotFocusText(txtULName, "Last")
    End Sub

    Private Sub txtULName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtULName.LostFocus
        LostFocusText(txtULName, "Last")
    End Sub
    Private Sub txtUPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass.GotFocus
        GotFocusText(txtUPass)
    End Sub

    Private Sub txtUPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass.LostFocus
        LostFocusText(txtUPass)
    End Sub

    Private Sub txtUPass1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass1.GotFocus
        GotFocusText(txtUPass1)
    End Sub

    Private Sub txtUPass1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass1.LostFocus
        LostFocusText(txtUPass1)
    End Sub
    Private Sub txtUPass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass2.GotFocus
        GotFocusText(txtUPass2)
    End Sub

    Private Sub txtUPass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUPass2.LostFocus
        LostFocusText(txtUPass2)
    End Sub

    Private Sub txtAPass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAPass2.GotFocus
        GotFocusText(txtAPass2)
    End Sub

    Private Sub txtAPass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAPass2.LostFocus
        LostFocusText(txtAPass2)
    End Sub

    Private Sub txtAFName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAFName.GotFocus
        GotFocusText(txtAFName, "First")
    End Sub

    Private Sub txtAFName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAFName.LostFocus
        LostFocusText(txtAFName, "First")
    End Sub

    Private Sub txtALName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtALName.GotFocus
        GotFocusText(txtALName, "Last")
    End Sub

    Private Sub txtALName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtALName.LostFocus
        LostFocusText(txtALName, "Last")
    End Sub

    Private Sub txtAUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAUserName.GotFocus
        GotFocusText(txtAUserName, "User name")
    End Sub

    Private Sub txtAUserName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAUserName.LostFocus
        LostFocusText(txtAUserName, "User name")
    End Sub
#End Region
#End Region

#Region "SMS TECHNOLOGY"

    Sub LV_Messages(Optional ByVal button As String = "")
        'smstype usernum message datetime
        If Not tmrUpdateMSG.Enabled Then tmrUpdateMSG.Start()
        lblRecordCount.Show() : gbGSMModule.Hide()
        If Not gbMessage.Visible = True Then gbMessage.Show()
        If button = "" Then button = btnSaved.Name
        Dim FIELD As String = ""
        If button = btnSaved.Name Then FIELD = "'UnSent'"
        If button = btnReceived.Name Then FIELD = "'%Received%'"
        If button = btnQueued.Name Then FIELD = "'ToSent' or smstype like '%Announcement' or smstype like '%Logs'"
        If button = btnSent.Name Then FIELD = "'Sent%' or smstype like 'Announcement_Sent%' or smstype like 'Logs_Sent%'"
        LVmsg.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select smstype,usernum,message,datetime,recid from tblesms where smstype like " & FIELD & " order by datetime desc")
        For Each item In dR
            Dim SMSType As String = ""
            If dR.Item(0).ToString.Contains("Received") Then If dR.Item(4).ToString.Contains("***") Then SMSType = "Unregistered No." Else SMSType = "F: " & dR.Item(4)
            If dR.Item(0) = "UnSent" Then SMSType = "Saved"
            If dR.Item(0) = "ToSent" Or dR.Item(0) = "Sent" Then SMSType = "Anonymous Text"
            If dR.Item(0).ToString.Contains("Announcement") Then SMSType = "Announcement"
            If dR.Item(0).ToString.Contains("Logs") Then SMSType = "Student Logs"

            li = LVmsg.Items.Add(SMSType)
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblMessageCount.Text = "Message count: " & LVmsg.Items.Count
    End Sub

    Public Sub btnSaved_Click() Handles btnSaved.Click
        Sounds(AUDIO.CLICK)
        btnAdvanceSMS.Tag = btnSaved.Name
        LV_Messages(btnSaved.Name) : lblSMSTechnology.Text = "Saved/Unsent Messages"
    End Sub
    Public Sub btnReceived_Click() Handles btnReceived.Click
        Sounds(AUDIO.CLICK)
        btnAdvanceSMS.Tag = btnReceived.Name
        LV_Messages(btnReceived.Name) : lblSMSTechnology.Text = "Received Messages"
    End Sub
    Public Sub btnQueued_Click() Handles btnQueued.Click
        Sounds(AUDIO.CLICK)
        btnAdvanceSMS.Tag = btnQueued.Name
        LV_Messages(btnQueued.Name) : lblSMSTechnology.Text = "Queued Messages"
    End Sub
    Public Sub btnSent_Click() Handles btnSent.Click
        Sounds(AUDIO.CLICK)
        btnAdvanceSMS.Tag = btnSent.Name
        LV_Messages(btnSent.Name) : lblSMSTechnology.Text = "Sent Messages"
    End Sub
    Private Sub btnCreate_Click() Handles btnCreate.Click
        Sounds(AUDIO.CLICK)
        If MB("Create new message?", "?") = "n" Then Return
        Me.Hide() : frmCreateMessage.Tag = "" : frmCreateMessage.ShowDialog() : Me.Show()
    End Sub
    Public Sub btnGSMModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSMModule.Click
        Sounds(AUDIO.CLICK)
        tmrUpdateMSG.Enabled = False
        lblMessageCount.Hide() : btnAdvanceSMS.Tag = btnGSMModule.Name : lblSMSTechnology.Text = "GSM Module Configuration"
        gbGSMModule.Location = gbMessage.Location : gbGSMModule.Size = gbMessage.Size
        If gbGSMModule.Visible = False Then : gbGSMModule.Show() : gbMessage.Hide()
            cmbPort.Items.Clear()
            On Error Resume Next
            For Each item In IO.Ports.SerialPort.GetPortNames : cmbPort.Items.Add(item) : Next
            If cmbPort.Items.Count > 0 Then cmbPort.SelectedItem = cmbPort.Items(cmbPort.FindStringExact("COM" & SMSPORT))
            cmbBaudRate.SelectedItem = cmbBaudRate.Items(cmbBaudRate.FindStringExact(SMSBAUDRATE.ToString))
            cmbStopBits.SelectedItem = cmbStopBits.Items(cmbTimeOut.FindStringExact(SMSSTOPBITS))
            cmbTimeOut.SelectedItem = cmbTimeOut.Items(cmbTimeOut.FindStringExact(SMSTIMEOUT))
            cmbValidity.SelectedItem = cmbValidity.Items(cmbValidity.FindStringExact(SMSVALIDITY))
            txtSendDelay.Text = SMSSENDDELAY
        End If
    End Sub
    Public Sub btnAdvanceSMS_Click() Handles btnAdvanceSMS.Click
        Sounds(AUDIO.CLICK)
        If btnAdvanceSMS.Tag Is btnGSMModule.Name Or gbGSMModule.Visible = True Then Me.Hide() : frmGSMDeviceConfig.ShowDialog() : Me.Show() : Exit Sub
        If btnAdvanceSMS.Tag Is Nothing Then Exit Sub
        Me.Hide()
        If btnAdvanceSMS.Tag Is btnSaved.Name Then frmSaveMessage.ShowDialog() : Me.Show() : Exit Sub
        If btnAdvanceSMS.Tag Is btnReceived.Name Then frmInbox.ShowDialog() : Me.Show() : Exit Sub
        If btnAdvanceSMS.Tag Is btnQueued.Name Then frmQueuedMessage.ShowDialog() : Me.Show() : Exit Sub
        If btnAdvanceSMS.Tag Is btnSent.Name Then frmSentMessage.ShowDialog() : Me.Show() : Exit Sub
        If btnAdvanceSMS.Tag Is btnGSMModule.Name Then frmGSMDeviceConfig.ShowDialog() : Me.SHOWHIDEGB() : Exit Sub
    End Sub
    Private Sub llblDetect_LinkClicked() Handles llblDetect.LinkClicked
        Me.Hide() : frmDetectPorts.ShowDialog() : Me.Show()
    End Sub
    Dim GSMconnectTemp As Boolean, SaveGSM As Boolean = False
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Sounds(AUDIO.CLICK)
        If Not cmbPort.Items.Contains(cmbPort.Text.Trim) Or cmbPort.Text = "" Then MB("Port not on the list!", "!") : toHL(cmbPort) : SaveGSM = False : Return
        If Not cmbBaudRate.Items.Contains(cmbBaudRate.Text.Trim) Then MB("Baud rate not on the list!", "!") : toHL(cmbBaudRate) : SaveGSM = False : Return
        If Not cmbTimeOut.Items.Contains(cmbTimeOut.Text.Trim) Then MB("Time out period not on the list!", "!") : toHL(cmbTimeOut) : SaveGSM = False : Return
        If Not IsNumeric(txtSendDelay.Text.Trim) Then MB("Invalid send delay value!") : toHL(txtSendDelay) : SaveGSM = False : Return

        GSMconnectTemp = False
        Cursor = Cursors.WaitCursor
        pbLoading.Show()

        '  Try
        '      Dim GSM As New GSMModem
        '    With GSM
        '     .Port = cmbPort.Text
        '      .BaudRate = cmbBaudRate.Text
        '   .Timeout = cmbTimeOut.Text
        '      Select Case cmbStopBits.SelectedIndex
        'Case 0 : .StopBits = Common.EnumStopBits.None
        '       Case 1 : .StopBits = Common.EnumStopBits.One
        '        Case 2 : .StopBits = Common.EnumStopBits.OnePointFive
        '        Case 3 : .StopBits = Common.EnumStopBits.Two
        '         Case Else : .StopBits = Common.EnumStopBits.Two
        '    End Select
        '   .SendDelay = CLng(txtSendDelay.Text.Trim)
        '   Select Case cmbValidity.SelectedIndex
        '       Case 0 : .Validity = SMS.ENUM_TP_VALID_PERIOD.OneHour
        '       Case 1 : .Validity = SMS.ENUM_TP_VALID_PERIOD.ThreeHours
        '      Case 2 : .Validity = SMS.ENUM_TP_VALID_PERIOD.SixHours
        '       Case 3 : .Validity = SMS.ENUM_TP_VALID_PERIOD.TwelveHours
        '       Case 4 : .Validity = SMS.ENUM_TP_VALID_PERIOD.OneDay
        '       Case 5 : .Validity = SMS.ENUM_TP_VALID_PERIOD.OneWeek
        '       Case 6 : .Validity = SMS.ENUM_TP_VALID_PERIOD.Maximum
        '       Case Else : .Validity = SMS.ENUM_TP_VALID_PERIOD.Maximum
        '   End Select
        '    .Connect()
        '    GSMconnectTemp = True
        '   End With
        '    Cursor = Cursors.Default
        '    pbLoading.Hide()
        '    MB("Successfully connected @" & cmbPort.Text & ".")
        '    Catch ex As Exception
        '   SaveGSM = False
        '   Cursor = Cursors.Default
        '   pbLoading.Hide()
        '    GSMconnectTemp = False
        '   MB(ex.Message)
        '   End Try
        '    Cursor = Cursors.Default : pbLoading.Hide()
        '   If SaveGSM = True Then SaveGSM = False : Call btnGSMSet_Click(sender, e)
    End Sub
    Private Sub btnGSMSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSMSet.Click
        Sounds(AUDIO.CLICK)
        '    SaveGSM = True
        '     If GSMconnectTemp = False Then Call btnTest_Click(sender, e) : Return
        '     If MB("Do you want to save?", "?") = "n" Then Return
        '     Dim StopBits As Integer = Nothing, Validity As Integer = Nothing
        With My.Settings
            '         .SMS_PORT = cmbPort.Text
            '        .SMS_BAUDRATE = CLng(cmbBaudRate.Text)
            ''        .SMS_TIMEOUT = CLng(cmbTimeOut.Text)
            '        .Save()
        End With
        '  SMSPORT = CInt(Replace(cmbPort.Text, "COM", ""))
        '    SMSBAUDRATE = CInt(cmbBaudRate.Text)
        '     SMSTIMEOUT = CInt(cmbTimeOut.Text)
        '  Select Case cmbStopBits.SelectedIndex
        '     Case 0 : StopBits = Common.EnumStopBits.None
        '      Case 1 : StopBits = Common.EnumStopBits.One
        '        Case 2 : StopBits = Common.EnumStopBits.OnePointFive
        '        Case 3 : StopBits = Common.EnumStopBits.Two
        '         Case Else : StopBits = Common.EnumStopBits.Two
        '    End Select
        '    Select Case cmbValidity.SelectedIndex
        '       Case 0 : Validity = SMS.ENUM_TP_VALID_PERIOD.OneHour
        '        Case 1 : Validity = SMS.ENUM_TP_VALID_PERIOD.ThreeHours
        '        Case 2 : Validity = SMS.ENUM_TP_VALID_PERIOD.SixHours
        '        Case 3 : Validity = SMS.ENUM_TP_VALID_PERIOD.TwelveHours
        '         Case 4 : Validity = SMS.ENUM_TP_VALID_PERIOD.OneDay
        '          Case 5 : Validity = SMS.ENUM_TP_VALID_PERIOD.OneWeek
        '          Case 6 : Validity = SMS.ENUM_TP_VALID_PERIOD.Maximum
        '          Case Else : Validity = SMS.ENUM_TP_VALID_PERIOD.Maximum
        '       End Select
        '  UPDATEr("tblegsm", "port='" & cmbPort.Text & "',baudrate=" & cmbBaudRate.Text & ", timeout=" & cmbTimeOut.Text & ",validity=" & Validity & ",senddelay=" & txtSendDelay.Text.Trim & ",stopbits=" & StopBits)
        '   LOGS("Update GSM Module device configuration.")
        '   MB("Successfully saved!")
    End Sub
#End Region
#Region "CLIENT"
    Private Sub btnShowGuard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGuard.Click
        Sounds(AUDIO.CLICK)
        If MB("Show guard settings window?", "?") = "n" Then Return
        Me.Hide() : frmGuardSettings.ShowDialog() : Me.Show()
    End Sub
    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Sounds(AUDIO.CLICK)
        If recCount("tbleusers", "online=1") > 0 And saveDateTime(dtpClientShtdown.Value, SaveDateTimeFormat.OO_OO_OO) <= saveDateTime(Now, SaveDateTimeFormat.OO_OO_OO) Then
            If MB("The time you have set is already past." & vbCr & "Settings will affect to the next operation." & vbCr & vbCr & "Do you want to saved?", "?") = "n" Then Return
        Else : If MB("Do you want to save?", "?") = "n" Then Return
        End If
        UPDATEr("tbleid", "Format='" & saveDateTime(dtpClientShtdown.Value, SaveDateTimeFormat.OO_OO_OO) & "',value=" & chkCShutdownDefault.Checked, "field like '%SystemShutdown%'")
        LOGS("Update client system shutdown time.")
        MB("Saved!")
    End Sub
    Private Sub llblShutdown_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblShutdown.LinkClicked
        If MB("Do you wish to shutdown the client?", "?") = "n" Then Return
        UPDATEr("tbleid", "format='" & Format(Now, "HH:mm:ss") & "'", "field like '%SystemShutdown%'")
        LOGS("Shutdown client.")
        MB("Client is being terminated...")
    End Sub
#End Region
#Region "RECORDS"
    Private Sub LVStud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LVStud.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LVStud.SelectedIndices.Count <= 0 Then Return
            'On Error Resume Next
            If buttonRecord = btnStudent.Name Then : viewProfile(LVStud.Items(LVStud.SelectedIndices(0)).SubItems(1).Text) : Return
            ElseIf buttonRecord = btnStudentList.Name Then : viewProfile(LVStud.Items(LVStud.SelectedIndices(0)).Text)
            End If
        End If
    End Sub
    Public Sub btnStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        Sounds(AUDIO.CLICK)
        buttonRecord = btnStudent.Name : lblRecords.Text = "Student Monitoring Logs"
        viewLVstudSystem()
    End Sub
    Public Sub btnSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystem.Click
        Sounds(AUDIO.CLICK)
        buttonRecord = btnSystem.Name : lblRecords.Text = "System Monitoring Logs"
        viewLVstudSystem()
    End Sub
    Public Sub btnStudentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentList.Click
        Sounds(AUDIO.CLICK)
        buttonRecord = btnStudentList.Name : lblRecords.Text = "List of All Registered Students"
        viewLVstudSystem()
    End Sub
    Private Sub btnEncodeStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncodeStud.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to encode new student?", "?") = "n" Then Return
        frmEncodeStudInfo.Tag = "Add"
        frmEncodeStudInfo.Show()
        Me.Close()
    End Sub
    Private Sub btnAddDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDept.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to add new department?", "?") = "n" Then Return
        frmDeptAddEdit.Tag = "Add" : frmDeptAddEdit.Show()
        Me.Close()
    End Sub
    Private Sub txtRSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRSearch.TextChanged
        If txtRSearch.Text.Trim.Contains("Search") Then Return
        Dim kw As String = txtRSearch.Text.Trim
        If buttonRecord = btnSystem.Name Then : viewLVstudSystem("select id,logusertype,action,datetime from tblemonitoring where logusertype like '%" & kw & "%' or action like '%" & kw & "%' order by id")
        ElseIf buttonRecord = btnStudent.Name Then : viewLVstudSystem("select tblemonitoringlogs.id,tblestudent.studno,tblemonitoringlogs.logstate,tblemonitoringlogs.datetime from tblemonitoringlogs,tblestudent where tblestudent.studno like '%" & kw & "%' or tblemonitoringlogs.logstate like '%" & kw & "%' order by tblemonitoringlogs.id")
        ElseIf buttonRecord = btnStudentList.Name Then : viewLVstudSystem("select studno,lname,fname,mname,course,yearlevel,section,status from tblestudent where studno like '%" & kw & "%' or lname like '%" & kw & "%' or fname like '%" & kw & "%' or mname like '%" & kw & "%' order by studno")
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Sounds(AUDIO.CLICK)
        If LVStud.Items.Count <= 0 Then Return
        If MB("Warning!" & vbCr & vbCr & "It will deleted all read history records." & vbCr & "Do you want to continue?", "!", "oc") = "c" Then Return
        If buttonRecord = btnSystem.Name Then
            frmAdminPass.ShowDialog()
            If Not frmAdminPass.Tag = "OK" Then Return
            eSQL("insert into tblemonitoring2 select * from tblemonitoring")
            DELETEr("tblemonitoring") : viewLVstudSystem() : LOGS("Deletes all system tracks.")
        ElseIf buttonRecord = btnStudent.Name Then
            frmAdminPass.ShowDialog()
            If Not frmAdminPass.Tag = "OK" Then Return
            eSQL("insert into tblemonitoringlogs2 select * from tblemonitoringlogs")
            DELETEr("tblemonitoringlogs") : viewLVstudSystem() : LOGS("Deletes all student logs tracks.")
        End If
    End Sub
    Public buttonRecord As String = ""
    Public Sub viewLVstudSystem(Optional ByVal COMMAND As String = "") '1=systemlog 2=studlog 3=stud
        LVStud.Items.Clear()
        Dim li As New ListViewItem
        If buttonRecord = btnSystem.Name Then 'id,logusertype,action.datetime
            LVStud.Columns.Item(0).Text = "ID" : LVStud.Columns.Item(1).Text = "User" : LVStud.Columns.Item(2).Text = "Action" : LVStud.Columns.Item(3).Text = "Date / Time"
            btnClear.Show()
            Dim dR As MySqlDataReader = DataReader(IIf(COMMAND = "", "select id,logusertype,action,datetime from tblemonitoring order by id", COMMAND))
            For Each item In dR
                li = LVStud.Items.Add(dR.Item(0)) : li.SubItems.Add(dR.Item(1))
                li.SubItems.Add(dR.Item(2))
                li.SubItems.Add(Format(dR.Item(3), "yyyy/MM/dd") & " " & Format(dR.Item(3), "HH:mm:ss"))
            Next
            dR.Close()
        ElseIf buttonRecord = btnStudent.Name Then 'id rfidtagid logstate datetime
            LVStud.Columns.Item(0).Text = "ID" : LVStud.Columns.Item(1).Text = "Student #" : LVStud.Columns.Item(2).Text = "Log state" : LVStud.Columns.Item(3).Text = "Date / Time"
            btnClear.Show()
            Dim dR As MySqlDataReader = DataReader(IIf(COMMAND = "", "select tblemonitoringlogs.id,tblestudent.studno,tblemonitoringlogs.logstate,tblemonitoringlogs.datetime from tblemonitoringlogs,tblestudent order by tblemonitoringlogs.datetime desc", COMMAND))
            For Each item In dR
                li = LVStud.Items.Add(dR.Item(0)) : li.SubItems.Add(dR.Item(1))
                li.SubItems.Add(dR.Item(2)) : li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            Next
            dR.Close()
        ElseIf buttonRecord = btnStudentList.Name Then
            LVStud.Columns.Item(0).Text = "Student #" : LVStud.Columns.Item(1).Text = "Name" : LVStud.Columns.Item(2).Text = "Course/Yr/Sec" : LVStud.Columns.Item(3).Text = "Status"
            btnClear.Hide()
            Dim dR As MySqlDataReader = DataReader(IIf(COMMAND = "", "select studno,lname,fname,mname,course,yearlevel,section,status from tblestudent order by studno", COMMAND))
            For Each item In dR
                li = LVStud.Items.Add(dR.Item(0))
                li.SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3))
                li.SubItems.Add(dR.Item(4) & " " & dR.Item(5) & "-" & dR.Item(6))
                li.SubItems.Add(dR.Item(7))
            Next
            dR.Close()
        End If
        If LVStud.Items.Count <= 0 Then btnClear.Enabled = False Else btnClear.Enabled = True
        lblRecordCount.Text = "Record count: " & LVStud.Items.Count

    End Sub
    Private Sub txtRSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRSearch.GotFocus
        If buttonRecord = btnSystem.Name Then lblSTip.Text = "Type 'User-Type' or 'Action'"
        If buttonRecord = btnStudent.Name Then lblSTip.Text = "Type 'Student No.' or 'Name' or 'Log-State'"
        If buttonRecord = btnStudentList.Name Then lblSTip.Text = "Type 'Student No.' or 'Name'"
        lblSTip.Show()
        txtRSearch.ForeColor = Color.Black : TextClicked(txtRSearch, "Search")
    End Sub
    Private Sub txtRSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRSearch.LostFocus
        lblSTip.Hide()
        txtRSearch.ForeColor = Color.DimGray : If txtRSearch.Text.Trim = "" Or txtRSearch.Text.Trim.ToLower.Contains("Search") Then txtRSearch.Text = "Search"
    End Sub
#End Region
#Region "EXIT"
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Sounds(AUDIO.CLICK)
        If MB("Close window settings", "?") = "y" Then Me.Close()
    End Sub
#End Region

   
#Region "MOUSEMOVE/MOUSELEAVE-COLOR"
    Sub MMove(ByVal button As Button)
        If button.Tag = False Then button.Tag = True : Sounds(AUDIO.SELECTED)
        MakeTransparent(button)
        button.BackColor = Color.Purple
    End Sub
    Sub MLeave(ByVal button As Button)
        button.Tag = False
        If LefButton Like button.Name Then button.BackColor = Color.Maroon Else button.BackColor = Color.Transparent
    End Sub
    Sub MakeTransparent(ByVal b As Button)
        Dim s As String = b.Name
        If Not LefButton = btnGeneral.Name And Not s = btnGeneral.Name Then btnGeneral.BackColor = Color.Transparent

        If Not LefButton = btnSystemUsers.Name And Not s = btnSystemUsers.Name Then btnSystemUsers.BackColor = Color.Transparent
        If Not LefButton = btnClient.Name And Not s = btnClient.Name Then btnClient.BackColor = Color.Transparent
        If Not LefButton = btnSMSTechnology.Name And Not s = btnSMSTechnology.Name Then btnSMSTechnology.BackColor = Color.Transparent
        'btnGSMModule.BackColor = Color.Transparent
        If Not LefButton = btnRecords.Name And Not s = btnRecords.Name Then btnRecords.BackColor = Color.Transparent
    End Sub
#End Region
#Region "MMOVE / MLEAVE"
    Private Sub btnGeneral_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGeneral.MouseLeave
        MLeave(btnGeneral)
    End Sub


    Private Sub btnGeneral_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnGeneral.MouseMove
        MMove(btnGeneral)
    End Sub

    Private Sub btnGSMModule_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGSMModule.MouseLeave
        MLeave(btnGSMModule)
    End Sub

    Private Sub btnGSMModule_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnGSMModule.MouseMove
        MMove(btnGSMModule)
    End Sub

    Private Sub btnRecords_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecords.MouseLeave
        MLeave(btnRecords)
    End Sub

    Private Sub btnRecords_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRecords.MouseMove
        MMove(btnRecords)
    End Sub

    Private Sub btnSMSTechnology_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSMSTechnology.MouseLeave
        MLeave(btnSMSTechnology)
    End Sub

    Private Sub btnSMSTechnology_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSMSTechnology.MouseMove
        MMove(btnSMSTechnology)
    End Sub

    Private Sub btnSystemUsers_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSystemUsers.MouseLeave
        MLeave(btnSystemUsers)
    End Sub

    Private Sub btnSystemUsers_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSystemUsers.MouseMove
        MMove(btnSystemUsers)
    End Sub

    Private Sub btnClient_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClient.MouseLeave
        MLeave(btnClient)
    End Sub

    Private Sub btnClient_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClient.MouseMove
        MMove(btnClient)
    End Sub

#End Region

    Public Sub LostFocusText(ByVal TXT As TextBox, Optional ByVal RESERVEDSTR As String = "")
        TXT.ForeColor = Color.DimGray
        If TXT.Text.Trim = "" Or TXT.Text.Trim.ToLower = RESERVEDSTR.ToLower Then TXT.Text = RESERVEDSTR
    End Sub
    Public s As String = ""
    Public Sub GotFocusText(ByVal TXT As TextBox, Optional ByVal RESERVERDSTR As String = "")
        TXT.ForeColor = Color.Black
        If s = TXT.Text Then Return
        If TXT.Text.Trim = "" Or TXT.Text.Trim.ToLower = RESERVERDSTR.ToLower Then TXT.Text = "" : s = True Else TXT.SelectionStart = 0 : TXT.SelectionLength = TXT.Text.Length : TXT.Focus() : s = TXT.Text
    End Sub

    Private Sub btnBIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBIN.Click
        Sounds(AUDIO.CLICK)
        frmAdminPass.ShowDialog()
        If frmAdminPass.Tag = "OK" Then Me.Hide() : frmRecordsAchive.ShowDialog() : Me.Show() Else Call btnSystem_Click(sender, e)
    End Sub

  
    Private Sub btnSMSCommands_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSCommands.Click
        Sounds(AUDIO.CLICK)
        frmAdminPass.ShowDialog()
        If frmAdminPass.Tag = "OK" Then Me.Hide() : frmKeywordsSMS.ShowDialog() : Me.Show()
    End Sub

    Private Sub txtANumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtANumber.GotFocus
        GotFocusText(txtANumber, "Number")
    End Sub

    Private Sub txtANumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtANumber.LostFocus
        LostFocusText(txtANumber, "Number")
    End Sub

    Private Sub tmrUpdateMSG_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdateMSG.Tick
        Dim s As Boolean = btnAdvanceSMS.Tag = btnGSMModule.Name
        If gbSMSTechnology.Visible = False Or btnAdvanceSMS.Tag = btnGSMModule.Name Then tmrUpdateMSG.Stop() : Exit Sub
        LV_Messages(btnAdvanceSMS.Tag)
    End Sub
 
   
    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub
End Class

