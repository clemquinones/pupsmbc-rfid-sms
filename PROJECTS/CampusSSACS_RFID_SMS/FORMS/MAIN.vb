Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources

Public Class frmMAIN

    Public DetectSMS As String = ""
    Dim gbPreviousLV_Left As Integer = 0, gbPreviousLV_OSize As Size, gbPreviousLV_RSize As Size, gbChat_Loc As Point
    Public DisplayLog As String = " 1 "
    Dim SMSSending As Boolean = False

    Private Sub frmMAIN_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmLogIn.Close()
    End Sub

    Public Sub LOAD_STARTUP_SETTINGS()
        gbEditAnn.Size = New Size(lblAnnouncement.Width + 11, lblAnnouncement.Height + 15)
        gbEditAnn.Top = lblAnnouncement.Top - 8
        gbEditAnn.Left = lblAnnouncement.Left - 6
        lblAnnouncement.Show() : gbEditAnn.Hide()


        gbPreviousLV.Size = New Size(392, 508)
        gbChat.Size = New Size(394, 194)
        gbDateTime.Size = New Size(241, 73)

        gbDateTime.Location = New Point(770, 654)
        gbPreviousLV_Left = gbPreviousLV.Left
        gbChat_Loc = New Point(gbPreviousLV.Left, 545)
        gbPreviousLV_OSize = New Size(gbPreviousLV.Width, gbPreviousLV.Height) ' gbPreviousLV.Size
        gbPreviousLV_RSize = New Size(gbPreviousLV.Width, 407)
 
        gbPreviousLV.Show()

        gbChat.Hide() : tsmChat.Text = "Chat Active User"

        '=========SET THE SIZE AND LOCATION OF TAB BUTTONS==================
        OPT_SIZE = gbRFIDSMS.Size : OPT_LOCATION = gbRFIDSMS.Location
        gbSMSTechnology.Size = OPT_SIZE : gbRecords.Size = OPT_SIZE : gbSettings.Size = OPT_SIZE : gbLogs.Size = OPT_SIZE
        gbSMSTechnology.Location = OPT_LOCATION : gbRecords.Location = OPT_LOCATION : gbSettings.Location = OPT_LOCATION : gbLogs.Location = OPT_LOCATION
        '===================================================================


        SHOWGB_OPT()
        DisplayLog = " 1 "
        tmrUpdate.Start()

        With My.Settings
            If .AutoDetectGSM = True Then frmDetectSMSDevice.Show()
            If .StartSending = True Then If IO.File.Exists(My.Settings.SendSMS_PATH) Then Shell(My.Settings.SendSMS_PATH)
        End With
    End Sub

    Private Sub frmMAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Dim s As String = getResult("select concat(current_date(),' ',Format) from tbleid where field='SystemShutdown'")
        '  Dim a As String = Format(Now, "yyyy-MM-dd") & " " & Format(Now, "HH:mm:ss")
        '' MB(a & vbCr & s & vbCr & DateDiff(DateInterval.Minute, CDate(a), CDate(s)))

        btnClient.BackgroundImage = IIf(gIDVal("Client") = 0, PC_Offline, PC_Online)

        LOAD_STARTUP_SETTINGS()
        tmrDisplayLog_Tick(sender, e)
    End Sub

 

    Private Sub btnLogOut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click

        Sounds(AUDIO.CLICK)
        If MB("Log out " & logID & " and close program?", "?") = "n" Then Return
        UPDATEr("tbleusers", "online=0", "userid='" & logID & "'")
        LOGS("Logged out.")
        tmrDisplayLog.Stop()
        tmrUpdate.Stop()
        frmLogIn.Show() : Me.Hide()
        Sounds(AUDIO.DEACTIVATED)
    End Sub


    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
      
        lblDate.Text = FormatDateTime(Now, DateFormat.LongDate)
        lblTime.Text = getDateTime(Now, GetDateTimeValue.OO_OO_OO_AM_PM)

        Dim Logs As Integer = CInt(getVal("tblesms", "sum(sendcopy)", "smstype like '%Logs' and sysdate() < expirydatetime"))
        Dim Ann As Integer = CInt(getVal("tblesms", "sum(sendcopy)", "smstype = 'Announcement' and sysdate() < expirydatetime"))
        Dim AnonymText As Integer = CInt(getVal("tblesms", "sum(sendcopy)", "smstype like '%ToSent' and sysdate() < expirydatetime"))
        SMSSending = CBool(gIDVal("SMSSending", True))
        ' If SMSSending = False Then Shell(My.Settings.SendSMS_PATH)
        If SMSSending Then
            If recCount("tblesms", "smstype='ToSent' or smstype like 'Announcement' or smstype like 'Logs'") <= 0 Then
                btnStart.Tag = "Idle" : btnStart.BackgroundImage = turnoff : lblGSM.Text = "Idle."
            Else : btnStart.Tag = "Sending" : btnStart.BackgroundImage = turnoff : lblGSM.Text = "Sending messages..."
            End If
        Else : btnStart.Tag = "Stopped" : btnStart.BackgroundImage = turnon : lblGSM.Text = "GSM module is not active."
        End If


        lblLogs.Text = IIf(Logs <= 0, "No messages.", Logs & " Remaining...")
        lblAnn.Text = IIf(Ann <= 0, "No messages.", Ann & " Remaining...")
        lblAnonymText.Text = IIf(AnonymText <= 0, "No messages.", AnonymText & " Remaining...")

        If Logs <= 0 Then : pbLogs.Tag = "Finished" : pbLogs.Image = check
        Else : If Not SMSSending Then pbLogs.Tag = "Stopped" : pbLogs.Image = NotConnected Else pbLogs.Tag = "Sending" : pbLogs.Image = Apple_Load
        End If
        If Ann <= 0 Then : pbAnn.Tag = "Finished" : pbAnn.Image = check
        Else : If Not SMSSending Then pbAnn.Tag = "Stopped" : pbAnn.Image = NotConnected Else pbAnn.Tag = "Sending" : pbAnn.Image = Apple_Load
        End If
        If AnonymText <= 0 Then : pbAnonym.Tag = "Finished" : pbAnonym.Image = check
        Else : If Not SMSSending Then pbAnonym.Tag = "Stopped" : pbAnonym.Image = NotConnected Else pbAnonym.Tag = "Sending" : pbAnonym.Image = Apple_Load
        End If

        If recCount("tbleannouncement", "primarya=1 and current_date() between startdatetime and enddatetime") <= 0 Then : lblEditAnn.Hide()
            lblAnnouncement.Text = "Announcement:" & vbNewLine & vbNewLine & "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES STA. MARIA CAMPUS STUDENT SECURITY MONITORING SYSTEM USING RADIO FREQUENCY IDENTIFICATION WITH SMS TECHNOLOGY"
        Else : lblEditAnn.Show()
            lblAnnouncement.Text = "Announcement:" & vbNewLine & vbNewLine & getVal("tbleannouncement", "message", "primarya=1")
        End If

        lblSMS_Noti.Text = recCount("tbleparentinfo", "block=1") & " Parent(s) unsubscribed from recieving advisory" & vbNewLine
        lblSMS_Noti.Text &= recCount("tblesms", "smstype like '%ReceivedUnRead%'") & " Message(s) Unread" & vbNewLine
        lblSMS_Noti.Text &= recCount("tblesms", "('ToSent' or smstype = 'Logs' or smstype = 'Announcement') ") & " Message(s) Queued"

        lblRFID_Noti.Text = recCount("tbletempdetection") & " Total detections" & vbNewLine
        lblRFID_Noti.Text &= recCount("tbletempdetection", "field like '%Log in%'") & " Log in" & vbNewLine
        lblRFID_Noti.Text &= recCount("tbletempdetection", "field like '%Log out%'") & " Log out"

        Dim SysShutdown As Date = CDate(Format(CDate(gIDVal("SystemShutdown", False)), "HH:mm:ss"))
        Dim SysTime As Date = CDate(Format(Now, "HH:mm:ss"))
        Dim MinRemaining As Integer = DateDiff(DateInterval.Minute, SysShutdown, SysTime)
        If CDate(Format(Now, "HH:mm:ss")) >= CDate(Format(CDate(gIDVal("SystemShutdown", False)), "HH:mm:ss")) Then
            lShutdown.Text = "System will shutdown" & vbCr & "in " & IIf(MinRemaining <= 0, " a few seconds...", MinRemaining & " minutes...")
            gbShutdown.Show()
        Else
            gbShutdown.Hide()
        End If

        If DateDiff(DateInterval.Second, CDate(gIDVal("SystemShutdown", False)), Now) <= 30 Then
            Dim dR As MySqlDataReader = DataReader("select s.studno,p.number from tblestudents s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and p.number !='' and p.block=0 and s.unlogout=true")
            For Each item In dR
                INSERTr("tblesms", "'" & gIDVal("Message", True) & "','Logs','" & dR.Item(1) & "','" & dR.Item(0) & _
                                   "','Parent','" & getMessage(Message.UnlogoutMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                incrementID("Message")
            Next
            dR.Close()
            UPDATEr("tblestudent", "unlogout=false")
        End If
    End Sub


    Private Sub btnClient_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClient.MouseLeave
        Dim PowerOn As Boolean = CBool(getVal("tbleid", "value", "field like '%ClientGaurd%'"))
        btnClient.BackgroundImage = IIf(PowerOn = False, PC_Offline, PC_Online)
        btnClient.Text = "Client"
    End Sub

    Private Sub btnClient_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClient.MouseMove
        btnClient.BackgroundImage = Client
        ttMain.SetToolTip(btnClient, IIf(CInt(gIDVal("ClientGaurd")) = 0, "Power ON", "Power OFF"))
    End Sub

    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        Sounds(AUDIO.CLICK)
        Dim CG As Boolean = CBool(gIDVal("ClientGaurd"))
        If CG Then : If MB("Do you want to end the monitoring operation?", "?") = "n" Then Return
        Else : If MB("Do you want to start the monitoring operation?", "?") = "n" Then Return
        End If
        UPDATEr("tbleid", "value=not value", "field like '%ClientGaurd%'")
        btnClient.BackgroundImage = IIf(CG, PC_Offline, PC_Online)
    End Sub
    Dim RFID As String = ""
    Private Sub tmrDisplayLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDisplayLog.Tick
        If DetectSMS = "" Or DetectSMS = "Disconnected" Then If My.Settings.AutoDetectGSM = True Then frmDetectSMSDevice.Show() : Return

        If gbPreviousLV.Left <= gbPreviousLV_Left Then
            'studno nme state time
            LVlogs.Items.Clear() : Dim li As New ListViewItem
            Dim dR As MySqlDataReader = DataReader("select s.studno,s.fname,s.lname,d.field,d.datetime from tbletempdetection d,tblestudent s where " & DisplayLog & " order by d.datetime desc limit 30")
            '     Dim dR As MySqlDataReader= DataReader("select s.studno,s.fname,s.lname,m.logstate,m.datetime,m.rfidtagid from tblestudent s,tblemonitoringlogs m where m.rfidtagid=s.rfidtagid and m.datetime between date_format(sysdate(),'%Y/%m/%d 00:00:01') and date_format(sysdate(),'%Y/%m/%d 23:59:59') and " & DisplayLog & " order by m.datetime desc")
            For Each item In dR
                li = LVlogs.Items.Add(dR.Item(0)) : li.SubItems.Add(dR.Item(1) & " " & dR.Item(2)) : li.SubItems.Add(dR.Item(3)) : li.SubItems.Add(getDateTime(dR.Item(4), GetDateTimeValue.OO_OO_AM_PM))
            Next
            dR.Close()
            lblCount.Text = "Detections count: " & LVlogs.Items.Count
        End If

        RFID = getVal("tbletempdetection", "rfidtagid", " 1 order by datetime desc limit 1")
        If RFID = Nothing Then Return
        Dim CourseCode As String = "", dR_Read As Boolean = False
        Dim dR2 As MySqlDataReader = DataReader("select s.studno,s.lname,s.fname,s.mname,s.course,s.yearlevel,s.section,d.field,d.datetime,d.rfidtagid from tblestudent s,tbletempdetection d where d.rfidtagid=s.rfidtagid and s.rfidtagid='" & RFID & "' and d.datetime between date_format(sysdate(),'%Y/%m/%d 00:00:01') and date_format(sysdate(),'%Y/%m/%d 23:59:59') order by d.datetime desc limit 1")
        If Not dR2.Read Then
            pbPic.Image = NoPicture
            lblStudNo.Text = "Student Number"
            lblName.Text = "Name"
            lblLogState.Text = "Log state"
            lblDeptYrSc.Text = "Course/Year/Section"
            lblDateTimeLog.Text = "Date / Time Log"
            '   LVlogs.Items.Clear()
        Else : dR_Read = True
            CourseCode = dR2.Item(4)
            lblStudNo.Text = dR2.Item(0)
            lblName.Text = dR2.Item(1) & ", " & dR2.Item(2) & " " & dR2.Item(3)
            lblDeptYrSc.Text = " " & dR2.Item(5) & "-" & dR2.Item(6)
            lblLogState.Text = dR2.Item(7)
            lblDateTimeLog.Text = getDateTime(dR2.Item(8), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM)
        End If
        If dR_Read Then
            lblDeptYrSc.Text = getVal("tblecodedesc", "description", "code='" & CourseCode & "' and field like'%Course%'") & lblDeptYrSc.Text
            displayPic(RFID, pbPic)
        End If
        dR2.Close()
        lblCount.Text = "Logs count: " & LVlogs.Items.Count
    End Sub

    Private Sub btnFindStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindStud.Click
        Sounds(AUDIO.SELECTED)
        If btnFindStud.Tag = "Find" Then
            btnFindStud.Tag = "Hide" : gbFindStud.Show() : toHL(txtKey)
        Else
            btnFindStud.Tag = "Find" : gbFindStud.Hide() : lblResult.Hide()
        End If
    End Sub

    Private Sub txtStudNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.GotFocus
        txtKey.ForeColor = Color.Black : TextClicked(txtKey, "Search")
    End Sub

    Private Sub txtStudNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKey.KeyDown
        If e.KeyCode = Keys.Escape And btnFindStud.Tag = "Hide" Then lblResult.Hide() : Call btnFindStud_Click(sender, e) : Return
        If Not e.KeyCode = Keys.Enter Then Return
        lblResult.Hide() : showResults(txtKey.Text.Trim)
    End Sub

    Private Sub txtStudNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.LostFocus
        txtKey.ForeColor = Color.Gray : If txtKey.Text.Trim.ToUpper Like "search" Or txtKey.Text.Trim = "" Then txtKey.Text = "Search"
    End Sub


    Private Sub chkAutoHide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPinLog.CheckedChanged
        gbPreviousLV.Tag = chkPinLog.Checked
    End Sub


    Private Sub tmrLVlogs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLV_animate.Tick
        gbPreviousLV.Show()
        If tmrLV_animate.Tag = "Show" Then
            If gbPreviousLV.Left <= gbPreviousLV_Left Then gbPreviousLV.Left = gbPreviousLV_Left : tmrLV_animate.Stop() : Return
            gbPreviousLV.Left -= 50
        ElseIf tmrLV_animate.Tag = "Hide" Then
            'If gbPreviousLV.Left >= gbPreviousLV_Left + gbPreviousLV.Width + 30 Then gbPreviousLV.Hide() : chkPinLog.Checked = False : tmrLV_animate.Stop() : Return
            If gbPreviousLV.Left >= Me.Width Then gbPreviousLV.Hide() : chkPinLog.Checked = False : tmrLV_animate.Stop() : Return
            gbPreviousLV.Left += 50
        End If
    End Sub


    Private Sub txtStudNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged
        txtKey.Text = LTrim(txtKey.Text)
        If txtKey.Text.Trim = "" Or txtKey.Text.Trim.ToLower = "search" Then lblResult.Hide() : Return
        lblResult.Show()
        Dim dR As MySqlDataReader = DataReader("select studno,fname,mname,lname from tblestudent where studno like '%" & txtKey.Text.Trim & "%' or fname like '%" & txtKey.Text.Trim & "%' or mname like '%" & txtKey.Text.Trim & "%' or lname like '%" & txtKey.Text.Trim & "%'")
        Dim Count As Integer = 0
        For Each item In dR : Count += 1
            If Count = 1 Then lblResult.Text = dR.Item(0) & " | " & dR.Item(1) & " " & dR.Item(2) & " " & dR.Item(3)
        Next
        dR.Close()
        If Count <= 0 Then
            lblResult.Text = "No matches result for '" & txtKey.Text.Trim & "'"
        Else
            lblResult.Text = Count & " Matches: " & lblResult.Text & IIf(Count > 1, " ...", "")
        End If
    End Sub

    Private Sub frmMAIN_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        lblEditAnn.Hide()
        Dim m As New Point(MousePosition.X, MousePosition.Y)
        If (m.X < lblOPT.Left Or m.X > lblOPT.Left + lblOPT.Width Or m.Y < lblOPT.Top Or m.Y > lblOPT.Top + lblOPT.Height) Then
            If (chkSMS.Checked = False And chkRecord.Checked = False And chkSettings.Checked = False) Then
                HIDEGB_OPT()
            End If
        End If

        If MousePosition.X < gbPreviousLV.Location.X Or MousePosition.Y < gbPreviousLV.Location.Y Then
            If tmrLV_animate.Enabled = False Then If chkPinLog.Checked = False Then tmrLV_animate.Tag = "Hide" : tmrLV_animate.Start()
        End If
    End Sub

    Private Sub llblViewProfile_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblViewProfile.LinkClicked
        If NoSelected(LVlogs) Then Return
        viewProfile(LVlogs.SelectedItems(0).Text)
    End Sub

    Private Sub LVlogs_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LVlogs.MouseDown

    End Sub

    Private Sub LVlogs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVlogs.SelectedIndexChanged
        If LVlogs.SelectedItems.Count <= 0 Then llblViewProfile.Hide() Else llblViewProfile.Show()
    End Sub

    Private Sub llblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblClose.LinkClicked
        gbChat.Hide()
    End Sub

    Private Sub btnChangeDT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDT.Click
        Sounds(AUDIO.CLICK)
        If MB("Change system date and time?", "?") = "y" Then Shell("rundll32.exe shell32.dll,Control_RunDLL timedate.cpl")
    End Sub


    Private Sub tsmListLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmListLogs.Click
        frmStudentLogRecord.Show()
    End Sub

    Private Sub tsmViewStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmViewStud.Click
        On Error Resume Next
        viewProfile(LVlogs.SelectedItems(0).Text)
    End Sub

    Private Sub tsmEditStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditStud.Click
        On Error Resume Next
        frmEncodeStudInfo.Tag = "Edit" : frmEncodeStudInfo.Tag_STUDNO = LVlogs.SelectedItems(0).Text
        frmEncodeStudInfo.ShowDialog()
    End Sub



#Region "gbCHAT"
    Dim LastDT As Date = Nothing
    Dim DT As String = Nothing

    Private Sub txtMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Escape Then Call tsmChat_Click(sender, e)
        If e.KeyCode = Keys.Enter Then
            txtMessage.Text = txtMessage.Text.Replace(vbNewLine, "")
            If txtMessage.Text.Trim = "" Or txtConfe.Text.Trim.ToLower = "no active users..." Then Return
            Dim Msg As String = txtMessage.Text.Replace("'", "''") : Msg = Msg.Replace("\", "\\") : Msg = Msg.Replace("/", "//")
            If txtConfe.Text = "No messages..." Then txtConfe.Text = ""
            txtConfe.Text &= "You [" & getDateTime(Now, GetDateTimeValue.OO_OO_AM_PM) & "]: " & txtMessage.Text & vbNewLine
            If cmbUser.Text <> "All Client" Then
                INSERTr("tblechat", "'" & logUserName & "','" & cmbUser.Text & "','" & Msg & "','" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "',1")
            Else
                Dim dR As MySqlDataReader = DataReader("select username from tbleusers where username != '" & logUserName & "' and online=1")
                For Each item In dR
                    INSERTr("tblechat", "'" & logUserName & "','" & dR.Item(0) & "','" & Msg & "','" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "',1")
                Next
                dR.Close()
            End If
            txtMessage.Text = "" : txtMessage.Focus()
        End If
    End Sub

    Private Sub tmrChat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChat.Tick
        If txtConfe.Text = "No messages..." Then txtConfe.Text = ""
        Dim dR As MySqlDataReader = DataReader("select userfrom,userto,message,datetime from tblechat where userto='" & logUserName & "' and (" & DT & " order by datetime desc limit 1")
        If dR.Read Then
            If dR.Item(3) <> LastDT Then
                LastDT = dR.Item(3)
                txtConfe.Text &= IIf(logUserName = dR.Item(0), "You", dR.Item(0)) & " [" & getDateTime(dR.Item(3), GetDateTimeValue.OO_OO_AM_PM) & "]: " & dR.Item(2) & vbNewLine
            End If
        End If
        dR.Close()
        If recCount("tblechat", "(userto regexp '" & logUserName & "' or userfrom regexp '" & logUserName & "') and (" & DT) <= 0 Then
            txtConfe.Text = "No messages..."
        End If
        If recCount("tbleusers", "userid != '" & logID & "' and online=1") <= 0 Then
            txtConfe.Text = "No active users..."
        End If
        On Error Resume Next
        For Each item In cmbUser.Items
            If recCount("tbleusers", "username='" & item.ToString & "' and online=0") Then cmbUser.Items.Remove(item)
        Next
    End Sub
    Private Sub txtMessage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.LostFocus
        If txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.ToLower = "type your message here..." Then txtMessage.Text = "Type your message here..."
    End Sub
    Private Sub txtMessage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.GotFocus
        TextClicked(txtMessage, "Type your message here...")
    End Sub
    Private Sub llblRestore_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblHistory.LinkClicked
        txtConfe.Text = ""
        Dim dR As MySqlDataReader = DataReader("select userfrom,userto,message,datetime from tblechat where (userto='" & logUserName & "' or  " & DT & " order by datetime desc")
        For Each item In dR
            txtConfe.Text &= IIf(logUserName = dR.Item(0), "You", dR.Item(0)) & " [" & getDateTime(dR.Item(3), GetDateTimeValue.OO_OO_AM_PM) & "]: " & dR.Item(2) & vbNewLine
        Next
        dR.Close()
    End Sub

    Private Sub llblClearChat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblClearChat.LinkClicked
        txtConfe.Text = "No messages..."
    End Sub
    Private Sub cmbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedIndexChanged
        If cmbUser.Text = "All User" Or cmbUser.Text = "" Then lblUser.Text = "All active user" : Return
        lblUser.Text = getVal("tbleusers", "fname", "username='" & cmbUser.Text & "'") & " " & getVal("tbleusers", "lname", "username='" & cmbUser.Text & "'")
    End Sub
#End Region


    Private Sub llblSMS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblSMS.LinkClicked
        frmNotification.Show()
        frmNotification.tcNoti.SelectTab(0)
    End Sub

    Private Sub llblRFID_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRFID.LinkClicked
        frmNotification.Show()
        frmNotification.tcNoti.SelectTab(1)
    End Sub

    Private Sub btnUserPrivilege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserPrivilege.Click
        Sounds(AUDIO.CLICK)
        frmGuardSettings.ShowDialog()
    End Sub

    'DataSet("select tblestudent.studno,concat(tblestudent.fname,' ',tblestudent.mname,' ',tblestudent.lname), concat(tblestudent.course,' ',tblestudent.yearlevel,'-',tblestudent.section),tbletempdetection.field, tbletempdetection.datetime from tblestudent,tbletempdetection where tbletempdetection.rfidtagid=tblestudent.rfidtagid order by tbletempdetection.datetime")

    Private Sub tsmSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSendMessage.Click
        On Error Resume Next
        showCreateMessage(LVlogs.SelectedItems(0).Text)
    End Sub

    Private Sub cmsLV_Logs_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsLV_Logs.Opening
        If LVlogs.SelectedIndices.Count <= 0 Then tsmEditStud.Enabled = 0 : tsmViewStud.Enabled = 0 : tsmSendMessage.Enabled = 0 Else tsmEditStud.Enabled = 1 : tsmViewStud.Enabled = 1 : tsmSendMessage.Enabled = 1
    End Sub

    Private Sub tsmViewStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmViewStudent.Click
        frmStudentLogRecord.Show()
    End Sub

    Private Sub tsmAnnouncement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAnnouncement.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to post an announcement?", "?") = "n" Then Return
        frmAnnouncement.ShowDialog()
    End Sub

    Private Sub tsmCreateMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCreateMessage.Click
        frmCreateMessage.Tag = "" : frmCreateMessage.Show()
    End Sub


    Dim OPT_LOCATION As Point = New Point(12, 615), OPT_SIZE As New Size
    Dim OPT_SELECTED As String = "", PIN As Boolean = False, INSIDELBL As Boolean = False

    Sub SHOWGB_OPT(Optional ByVal BUTTON As String = Nothing)
        If BUTTON <> btnRecord_opt.Name Then gbRecords.Hide() Else gbRecords.Show() : chkRecord.Checked = False : gbSMSTechnology.Hide() : gbLogs.Hide() : gbSettings.Hide() : gbRFIDSMS.Hide() : Return
        If BUTTON <> btnLogs_opt.Name Then gbLogs.Hide() Else gbLogs.Show() : chkLogs.Checked = False : gbSMSTechnology.Hide() : gbRecords.Hide() : gbSettings.Hide() : gbRFIDSMS.Hide() : Return
        If BUTTON <> btnSMS_opt.Name Then gbSMSTechnology.Hide() Else gbSMSTechnology.Show() : chkSMS.Checked = False : gbRecords.Hide() : gbSettings.Hide() : gbLogs.Hide() : gbRFIDSMS.Hide() : Return
        If BUTTON <> btnSettings_opt.Name Then gbSettings.Hide() Else gbSettings.Show() : chkSettings.Checked = False : gbRecords.Hide() : gbLogs.Hide() : gbSMSTechnology.Hide() : gbRFIDSMS.Hide() : Return

        If BUTTON <> Nothing Then gbRFIDSMS.Hide() Else gbRFIDSMS.Show() : Return
    End Sub
    Sub HIDEGB_OPT()
        gbSMSTechnology.Visible = False
        gbRecords.Visible = False
        gbSettings.Visible = False
        gbLogs.Visible = False

        btnLogs_opt.BackColor = Color.Transparent
        btnRecord_opt.BackColor = Color.Transparent
        btnSettings_opt.BackColor = Color.Transparent
        btnSMS_opt.BackColor = Color.Transparent
        gbRFIDSMS.Show()
    End Sub

    Private Sub btnLogs_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogs_opt.MouseLeave
        btnLogs_opt.Tag = False
        If gbLogs.Visible = True Then btnLogs_opt.BackColor = Color.Maroon Else btnLogs_opt.BackColor = Color.Transparent
    End Sub



    Private Sub btnLogs_opt_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogs_opt.MouseMove
        If btnLogs_opt.Tag = False Then btnLogs_opt.Tag = True : Sounds(AUDIO.SELECTED)
        btnLogs_opt.BackColor = Color.Purple
        If gbSettings.Visible = False Then btnSettings_opt.BackColor = Color.Transparent Else btnSettings_opt.BackColor = Color.Maroon
        If gbRecords.Visible = False Then btnRecord_opt.BackColor = Color.Transparent Else btnRecord_opt.BackColor = Color.Maroon
        If gbSMSTechnology.Visible = False Then btnSMS_opt.BackColor = Color.Transparent Else btnSMS_opt.BackColor = Color.Maroon

        If (gbLogs.Visible AndAlso chkLogs.Checked = True) Or (gbSMSTechnology.Visible AndAlso chkSMS.Checked = True) Or (gbSettings.Visible AndAlso chkSettings.Checked = True) Or (gbRecords.Visible AndAlso chkRecord.Checked = True) Then Return
        SHOWGB_OPT(btnLogs_opt.Name)
    End Sub

    Private Sub btnRecord_opt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecord_opt.MouseLeave
        btnRecord_opt.Tag = False
        If gbRecords.Visible = True Then btnRecord_opt.BackColor = Color.Maroon Else btnRecord_opt.BackColor = Color.Transparent
    End Sub


    Private Sub btnRecord_opt_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord_opt.MouseMove
        If btnRecord_opt.Tag = False Then btnRecord_opt.Tag = True : Sounds(AUDIO.SELECTED)
        btnRecord_opt.BackColor = Color.Purple
        If gbSettings.Visible = False Then btnSettings_opt.BackColor = Color.Transparent Else btnSettings_opt.BackColor = Color.Maroon
        If gbSMSTechnology.Visible = False Then btnLogs_opt.BackColor = Color.Transparent Else btnLogs_opt.BackColor = Color.Maroon
        If gbRecords.Visible = False Then btnRecord_opt.BackColor = Color.Transparent Else btnRecord_opt.BackColor = Color.Maroon

        If (gbLogs.Visible AndAlso chkLogs.Checked = True) Or (gbSMSTechnology.Visible AndAlso chkSMS.Checked = True) Or (gbSettings.Visible AndAlso chkSettings.Checked = True) Or (gbRecords.Visible AndAlso chkRecord.Checked = True) Then Return
        SHOWGB_OPT(btnRecord_opt.Name)
    End Sub

    Private Sub btnSettings_opt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings_opt.Click
        Sounds(AUDIO.CLICK)
        If chkSettings.Checked = True Then Return
        chkRecord.Checked = False : chkSMS.Checked = False : chkLogs.Checked = False
        SHOWGB_OPT(btnSettings_opt.Name)
    End Sub



    Private Sub btnLogs_opt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogs_opt.Click
        Sounds(AUDIO.CLICK)
        If chkLogs.Checked = True Then Return
        chkRecord.Checked = False : chkSettings.Checked = False : chkSMS.Checked = False
        SHOWGB_OPT(btnLogs_opt.Name)
    End Sub


    Private Sub btnRecord_opt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord_opt.Click

        Sounds(AUDIO.CLICK)
        If chkRecord.Checked = True Then Return
        chkSMS.Checked = False : chkSettings.Checked = False : chkLogs.Checked = False
        SHOWGB_OPT(btnRecord_opt.Name)
    End Sub

    Private Sub btnSettings_opt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings_opt.MouseLeave
        btnSettings_opt.Tag = False
        If gbSettings.Visible = True Then btnSettings_opt.BackColor = Color.Maroon Else btnSettings_opt.BackColor = Color.Transparent
    End Sub

    Private Sub btnSettings_opt_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings_opt.MouseMove
        If btnSettings_opt.Tag = False Then btnSettings_opt.Tag = True : Sounds(AUDIO.SELECTED)
        btnSettings_opt.BackColor = Color.Purple
        If gbRecords.Visible = False Then btnRecord_opt.BackColor = Color.Transparent Else btnRecord_opt.BackColor = Color.Maroon
        If gbSMSTechnology.Visible = False Then btnLogs_opt.BackColor = Color.Transparent Else btnLogs_opt.BackColor = Color.Maroon
        If (gbSMSTechnology.Visible AndAlso chkSMS.Checked = True) Or (gbSettings.Visible AndAlso chkSettings.Checked = True) Or (gbRecords.Visible AndAlso chkRecord.Checked = True) Then Return
        SHOWGB_OPT(btnSettings_opt.Name)
    End Sub

    Private Sub tsmAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAll.Click
        DisplayLog = " 1 " : llblFilterLog.Text = "All Read"
        tmrDisplayLog_Tick(sender, e)
    End Sub

    Private Sub tsmLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLogOut.Click
        DisplayLog = " d.field like '%Log out%'" : llblFilterLog.Text = "All Log out"
        tmrDisplayLog_Tick(sender, e)
    End Sub

    Private Sub tsmLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLogIn.Click
        DisplayLog = " d.field like '%Log in%'" : llblFilterLog.Text = "All Log In"
        tmrDisplayLog_Tick(sender, e)
    End Sub

    Private Sub llblFilterLog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblFilterLog.LinkClicked
        cmsLog.Show()
    End Sub


    Private Sub btnGSMModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSMModule.Click
        Sounds(AUDIO.CLICK)
        frmGSMDeviceConfig.Show()
    End Sub


    Private Sub btnDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept.Click
        Sounds(AUDIO.CLICK)
        frmDepartment.Show()
    End Sub


    Private Sub btnStudList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudList.Click
        Sounds(AUDIO.CLICK)
        frmStudentsList.Show()
    End Sub

    Private Sub btnSystemLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemLog.Click
        Sounds(AUDIO.CLICK)
        frmSystemLogs.Show()
    End Sub

    Private Sub btnFacultyUtily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacultyUtily.Click
        Sounds(AUDIO.CLICK)
        frmFacultyUtility.Show()
    End Sub

    Private Sub btnAccessSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccessSettings.Click
        Sounds(AUDIO.CLICK)
        If MB("Show access settings?", "?") = "y" Then frmAccessSettings.ShowDialog()
    End Sub


    Private Sub btnParentList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnParentList.Click

        Sounds(AUDIO.CLICK)
        frmListParents.Show()
    End Sub

    Private Sub btnBackUpRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUpRestore.Click
        Sounds(AUDIO.CLICK)
        If AdminPass() Then frmBackupRestoreDB.Show()
    End Sub


    Private Sub btnRecordArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordArchive.Click
        Sounds(AUDIO.CLICK)
        If AdminPass() Then frmRecordsAchive.Show()
    End Sub



    Private Sub btnLogLV_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLogLV.MouseMove
        If tmrLV_animate.Enabled = True Then Return
        If chkPinLog.Checked = True Then Return
        tmrLV_animate.Tag = IIf(tmrLV_animate.Tag = "Show", "Hide", "Show") : tmrLV_animate.Start()
    End Sub

    Private Sub tsmRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmRefresh.Click
        Cursor = Cursors.WaitCursor
        Me.Refresh()
        Cursor = Cursors.Default
    End Sub

    Private Sub pbLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLogs.Click
        If pbLogs.Tag = "Finished" Then Return
        If pbLogs.Tag = "Stopped" Then UPDATEr("tblegsm", "logs=1")
        If pbLogs.Tag = "Sending" Then UPDATEr("tblegsm", "logs=0")
    End Sub

    Private Sub pbAnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAnn.Click
        If pbAnn.Tag = "Finished" Then Return
        If pbAnn.Tag = "Stopped" Then UPDATEr("tblegsm", "announce=1")
        If pbAnn.Tag = "Sending" Then UPDATEr("tblegsm", "announce=0")
    End Sub

    Private Sub pbAnonym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAnonym.Click
        If pbAnonym.Tag = "Finished" Then Return
        If pbAnonym.Tag = "Stopped" Then UPDATEr("tblegsm", "Anonym=1")
        If pbAnonym.Tag = "Sending" Then UPDATEr("tblegsm", "logs=0")
    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If Not btnStart.Tag = "Sending" Then
            If MB("Do you want to start sending of messages?", "?") = "n" Then Return
            If Not IO.File.Exists(My.Settings.SendSMS_PATH) Then
                MB("Cannot find 'SMSMODULE.exe'" & vbCr & vbCr & "This will use for sending queued messages.", "x")
LOCATE:         Dim ofd As New OpenFileDialog
                ofd.Filter = "SMS MODULE Sender (SMSMODULE.exe)|*.exe|All files (*.*)|*.*"
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Not ofd.FileName.ToString.Contains("SMSMODULE.exe") Then MB("Wrong application!", "!") : GoTo LOCATE
                    If MB("Do you want to save this path?", "?") = "y" Then My.Settings.SendSMS_PATH = ofd.FileName : My.Settings.Save() : My.Settings.Reload()

                End If
            End If
            Try
                Shell(My.Settings.SendSMS_PATH)
            Catch ex As Exception
            End Try
        Else
            If MB("Do you want to stop sending of messages?", "?") = "n" Then Return
            UPDATEr("tbleid", "value=0", "field like '%SMSSending%'")
        End If
    End Sub



    Private Sub pbLogs_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbLogs.MouseMove
        If pbLogs.Tag = "Finished" Then Return
        ttMain.SetToolTip(pbLogs, IIf(pbLogs.Tag = "Sending", "Stop sending of student logs messages", "Start sending of student logs messages"))
    End Sub

    Private Sub pbAnn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbAnn.MouseMove
        If pbAnn.Tag = "Finished" Then Return
        ttMain.SetToolTip(pbAnn, IIf(pbAnn.Tag = "Sending", "Stop sending of announcement messages", "Start sending of announcement messages"))
    End Sub

    Private Sub pbAnonym_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbAnonym.MouseMove
        If pbAnonym.Tag = "Finished" Then Return
        ttMain.SetToolTip(pbAnn, IIf(pbAnonym.Tag = "Sending", "Stop sending of messages", "Start sending of messages"))
    End Sub


    Private Sub btnSMSMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSMessages.Click
        Sounds(AUDIO.CLICK)
        frmSMSMessages.ShowDialog()
    End Sub

    Private Sub btnExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpired.Click
        Sounds(AUDIO.CLICK)
        frmExpiredMessages.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblAnnouncement.Show() : lblEditAnn.Show()
        gbEditAnn.Hide()
    End Sub

    Private Sub btnEditAnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAnn.Click
        If txtAnn.Text.Trim = "" Then MB("Cannot accept null announcement value!", "!") : Exit Sub
        If MB("Do you want to make changes on your announcement?", "?") = "n" Then Exit Sub
        UPDATEr("tbleannouncement", "message='" & v(txtAnn.Text.Trim) & "'", "primarya=1 and current_date() between startdatetime and enddatetime")
        lblAnnouncement.Text = txtAnn.Text.Trim
        btnCancel_Click(sender, e)
    End Sub

    Private Sub txtAnn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAnn.KeyDown
        If e.KeyCode = Keys.Escape Then Call btnCancel_Click(sender, e)
    End Sub



    Private Sub tsmChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmChat.Click
        Sounds(AUDIO.CLICK)
        If gbChat.Visible = True Then : tsmChat.Text = "Chat Active Users"
            gbChat.Hide() : gbPreviousLV.Size = gbPreviousLV_OSize
            tmrChat.Stop() : gbDateTime.Show()
            eSQL("insert into tblechat2 select * from tblechat")
            DELETEr("tblechat")
        Else : tsmChat.Text = "Close Chat Box"
            cmbUser.Items.Clear() : cmbUser.Items.Add("All Client")
            Dim dR As MySqlDataReader = DataReader("select username from tbleusers where username != '" & logUserName & "' and online=1")
            For Each item In dR
                cmbUser.Items.Add(dR.Item(0))
            Next
            dR.Close()
            If cmbUser.Items.Count > 0 Then cmbUser.SelectedIndex = 0 : TextClicked(txtMessage, "Type your message here...")
            DT = IIf(cmbUser.Text = "All Client", " 1", " userfrom = '" & cmbUser.Text & "'") & ") and datetime between '" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd) & " 00:00:01' and '" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd) & " 23:59:59'"

            tmrChat.Start()
            gbPreviousLV.Size = gbPreviousLV_RSize : gbChat.Location = gbChat_Loc : gbDateTime.Hide() : gbChat.Show()
            txtMessage.Focus()
        End If
    End Sub

    Private Sub btnSMS_opt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMS_opt.Click
        Sounds(AUDIO.CLICK)
        If chkSMS.Checked = True Then Return
        chkRecord.Checked = False : chkSettings.Checked = False : chkLogs.Checked = False
        SHOWGB_OPT(btnSMS_opt.Name)
    End Sub

    Private Sub btnSMS_opt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSMS_opt.MouseLeave
        btnSMS_opt.Tag = False
        If gbSMSTechnology.Visible = True Then btnSMS_opt.BackColor = Color.Maroon Else btnSMS_opt.BackColor = Color.Transparent
    End Sub

    Private Sub btnSMS_opt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSMS_opt.MouseMove
        If btnSMS_opt.Tag = False Then btnSMS_opt.Tag = True : Sounds(AUDIO.SELECTED)
        btnSMS_opt.BackColor = Color.Purple
        If gbRecords.Visible = False Then btnRecord_opt.BackColor = Color.Transparent Else btnRecord_opt.BackColor = Color.Maroon
        If gbLogs.Visible = False Then btnLogs_opt.BackColor = Color.Transparent Else btnLogs_opt.BackColor = Color.Maroon
        If gbSettings.Visible = False Then btnSettings_opt.BackColor = Color.Transparent Else btnSettings_opt.BackColor = Color.Maroon

        If (gbLogs.Visible AndAlso chkLogs.Checked = True) Or (gbSMSTechnology.Visible AndAlso chkSMS.Checked = True) Or (gbSettings.Visible AndAlso chkSettings.Checked = True) Or (gbRecords.Visible AndAlso chkRecord.Checked = True) Then Return
        SHOWGB_OPT(btnSMS_opt.Name)

    End Sub


    Private Sub btnStudLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudLog.Click
        Sounds(AUDIO.CLICK)
        frmStudentLogRecord.ShowDialog()
    End Sub

    Private Sub btnFU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFU.Click
        Sounds(AUDIO.CLICK)
        frmFacultyUtility.ShowDialog()
    End Sub

    Private Sub btnVisitorLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisitorLog.Click
        Sounds(AUDIO.CLICK)
    End Sub

    Private Sub btnReceivedMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedMessages.Click
        Sounds(AUDIO.CLICK)
        frmInbox.ShowDialog()
    End Sub

    Private Sub btnSavedMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavedMessages.Click
        Sounds(AUDIO.CLICK)
        frmSaveMessage.ShowDialog()
    End Sub

    Private Sub btnSystemPreferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemPreferences.Click
        Sounds(AUDIO.CLICK)
        frmPreferences.ShowDialog()
    End Sub

    Private Sub lblEditAnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEditAnn.Click
        If lblEditAnn.Text = "" Then Return
        txtAnn.Text = getVal("tbleannouncement", "message", "primarya=1 and current_date() between startdatetime and enddatetime")
        lblAnnouncement.Hide() : lblEditAnn.Hide()
        gbEditAnn.Show()
        toHL(txtAnn)
    End Sub

    Private Sub lblEditAnn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEditAnn.MouseHover
        lblEditAnn.Text = "Edit"
        lblEditAnn.Show()
    End Sub

    Private Sub lblEditAnn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEditAnn.MouseLeave
        lblEditAnn.Text = ""
        lblEditAnn.Hide()
    End Sub

    Private Sub lblAnnouncement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnnouncement.Click

    End Sub

    Private Sub lblAnnouncement_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAnnouncement.MouseHover
        lblEditAnn.Show()
    End Sub

    Private Sub lblAnnouncement_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAnnouncement.MouseLeave
        lblEditAnn.Hide()
    End Sub

   

    Private Sub tsmSystemUserAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSystemUserAct.Click
        frmSystemLogs.Show()
    End Sub

    Private Sub tsmUpdateMyProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUpdateMyProfile.Click
        frmPreferences.Show()
        frmPreferences.btnSystemUsers_Click(sender, e)
        frmPreferences.btnUpdateMy_Click(sender, e)
    End Sub

    Private Sub tsmAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddUser.Click
        frmPreferences.Show()
        frmPreferences.btnSystemUsers_Click(sender, e)
        frmPreferences.btnAddUser_Click(sender, e)
    End Sub

    Private Sub tsmDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDeleteUser.Click
        frmAccessSettings.Show()
    End Sub

    Private Sub tsmDisconnectUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDisconnectUser.Click
        frmAccessSettings.Show()
    End Sub

    Private Sub tsmListUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmListUser.Click
        frmPreferences.Show()
        frmPreferences.btnSystemUsers_Click(sender, e)
        frmPreferences.btnListUsers_Click()
    End Sub

    Private Sub tsmGSMModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmGSMModule.Click
        frmGSMDeviceConfig.ShowDialog()
    End Sub

    Private Sub tsmReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmReceived.Click
        frmPreferences.Show()
        frmPreferences.btnSMSTechnology_Click(sender, e)
        frmPreferences.btnReceived_Click()
    End Sub

    Private Sub tsmSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSent.Click
        frmPreferences.Show()
        frmPreferences.btnSMSTechnology_Click(sender, e)
        frmPreferences.btnSent_Click()
    End Sub

    Private Sub tsmQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmQueue.Click
        frmPreferences.Show()
        frmPreferences.btnSMSTechnology_Click(sender, e)
        frmPreferences.btnQueued_Click()
    End Sub

    Private Sub tsmSaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSaved.Click
        frmPreferences.Show()
        frmPreferences.btnSMSTechnology_Click(sender, e)
        frmPreferences.btnSaved_Click()
    End Sub

    Private Sub tsmExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmExpired.Click
        frmExpiredMessages.Show()
    End Sub

    Private Sub tsmStudLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmStudLogs.Click
        frmPreferences.Show()
        frmPreferences.btnRecords_Click(sender, e)
        frmPreferences.btnStudent_Click(sender, e)

    End Sub
End Class