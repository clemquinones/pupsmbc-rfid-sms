Imports MySql.Data.MySqlClient
Imports PUPSSMSRFIDSMS_Gate.My.Resources

Public Class frmClient
#Region "RESET"
    Public Sub reSET()
        'Me.BackgroundImage = Resources.BGLigthBlue
        '   pbMainPic.Left = (Me.Width / 2) - (pbMainPic.Width / 2)
        'gbMainInfo.Left = pbMainPic.Left + pbMainPic.Width + 5
        pbMainPic.Image = Resources.No_Picture
        pbLogIn1.Image = Resources.No_Picture
        pbLogIn2.Image = Resources.No_Picture
        pbLogIn3.Image = Resources.No_Picture
        pbLogIn4.Image = Resources.No_Picture
        pbLogOut1.Image = Resources.No_Picture
        pbLogOut2.Image = Resources.No_Picture
        pbLogOut3.Image = Resources.No_Picture
        pbLogOut4.Image = Resources.No_Picture

        lblLogState.Text = "WELCOME"
        lblStudNo.Text = "○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○"
        lblName.Text = "○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○"
        lblCourse.Text = "○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○"
        lblYearSec.Text = "○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○ ○"
        lblDateTimeLog.Text = getDateTime(Now, GetDateTimeValue.MM_dd_yyyy_OO_OO_OO_AM_PM_DAYOFWEEK)

        StudentDetectionRFID = ""
        tmrRead.Start()
    End Sub
#End Region
#Region "KEYDOWN EVENTS"

    Private Sub frmClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UPDATEr("tbleclient", "online=0", "name='" & My.Settings.PCNAME & "'")
        DELETEr("tbletempdetection")
    End Sub

#End Region
    Public Announcement As String
    Public AStr As String
    Public RunAnnounce As Boolean = False
    Dim AnnCTR As Integer = 0

    Private Sub frmClient_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then frmUserPass.Tag = " to stop monitoring:" : If UserPass() Then End
    End Sub
    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sounds(AUDIO.ACTIVATED)
        CloseRFID()
        UPDATEr("tbleclient", "online=1", "name='" & My.Settings.PCNAME & "'")
        LOGS("Client was started.")

        reSET()
        AnnCTR = 0
        If recCount("tbleannouncement", "'" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "' between startdatetime and enddatetime") > 0 Then
            Announcement = getVal("tbleannouncement", "message", "'" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "' between startdatetime and enddatetime order by startdatetime desc")
            Dim s As String = ""
            Dim aDT As String = getVal("tbleannouncement", "startdatetime", "'" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "' between startdatetime and enddatetime order by startdatetime desc")
            While s.Length < 100 : s &= " " : End While
            AStr = s & Announcement & "[" & aDT & "]"
            RunAnnounce = True
        Else
            RunAnnounce = False
        End If
        tm.Start()
    End Sub


    Dim ctr As Integer = 0, rfidCTR As Integer = 0, readCTR As Integer = 0


    Dim ID_LastRead As String = "", RFDIctr As Integer = 0
    Dim UNLOGOUT As Boolean = True, LASTDETECTION As String = "", LASTDETECTION_CTR As Integer = 0

    Private Sub tmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRead.Tick
        If recCount("tbleannouncement", "primarya=1 and current_date() between startdatetime and enddatetime") <= 0 Then
            Ann = SPACES() & "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES STA. MARIA CAMPUS STUDENT SECURITY MONITORING SYSTEM USING RADIO FREQUENCY IDENTIFICATION WITH SMS TECHNOLOGY"
        Else
            Ann = SPACES() & getVal("tbleannouncement", "message", "primarya=1") & " [" & getDateTime(CDate(getVal("tbleannouncement", "startdatetime", "primarya=1")), GetDateTimeValue.MM_dd_yyyy) & "]"
        End If

        If recCount("tbleclient", "name='" & My.Settings.PCNAME & "' and online=0") Then End
        If recCount("tbleusers u,tbleclient c", "u.userid=c.userid and u.online=0") Then tmrRead.Stop() : frmListener.reSET() : frmListener.Show() : Me.Close()

BEGIN:  tmrRead.Interval = 1000
        OpenRFID()
OPEN:   If Not RFIDConnected = True And RFDIctr <= 20 Then
            RFDIctr += 1 : OpenRFID() : GoTo OPEN
        ElseIf RFDIctr >= 3 Then : pbLoadRFID.Image = NotConnected
            lblRFIDStatus.Text = "Waiting for the device to attach..."
            OpenRFID() : RFDIctr = 0
            Return
        End If
        '============================================


        '====START DETECTING CARD=========

        Dim ID As String = GetID_RFID() : readCTR = 0

        '------validation
        If ID Is Nothing Or ID Like "Cannot read." Then GoTo StandBy 'if no card is detected then goto idle mode
        If ID_LastRead = ID Then GoTo Success 'if the card is match on the most recent last detection card then goto success read' mode
        If recCount("tblestudent", "rfidtagid='" & ID & "'") <= 0 Then GoTo CardNotRegistered
        '----------------------

Reading: Sounds(AUDIO.SCAN)
        lblRFIDStatus.Text = "Reading your card..." : readCTR += 1
        pbLoadRFID.Image = Resources.appleload
        ID_LastRead = ID
        'update the log status of the student
        UPDATEr("tblestudent", "unlogout=not unlogout", "rfidtagid='" & ID & "'")
        UNLOGOUT = CBool(getVal("tblestudent", "unlogout", "rfidtagid='" & ID & "'"))

        UpdateDisplay() 'Move Previous Logs
        UpdateMain(ID)  'Update Main Display


        INSERTr("tbletempdetection", "'" & generateID("Logs") & "','" & IIf(UNLOGOUT = True, "Log in", "Log out") & "','" & ID & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "'")
        INSERTr("tblemonitoringlogs", "'" & generateID("Logs") & "','" & ID & "','" & IIf(UNLOGOUT = True, "Log in", "Log out") & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "'")
        incrementID("Logs") : LASTDETECTION_CTR = 0
Success: lblRFIDStatus.Text = "Success!"
        tmrRead.Interval = 700
        pbLoadRFID.Image = check
        LASTDETECTION = ID : LASTDETECTION_CTR = 0
        If readCTR > 0 Then
            'id sms usernum recid rectype message datettim expi secndci alert unicode
            If recCount("tbleparentinfo p,tblestudent s", "p.rfidtagid='" & ID & "' and p.rfidtagid=s.rfidtagid and p.number !='' and p.block=0 and s.unlogout=0") Then
                Dim STUDNO As String = getVal("tblestudent", "studno", "rfidtagid='" & ID & "'")
                INSERTr("tblesms", "'" & gIDVal("Message", True) & "','Logs','" & getVal("tbleparentinfo", "number", "rfidtagid='" & ID & "'") & "','" & STUDNO & _
                    "','Parent','" & getMessage(Message.LoginMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                incrementID("Message")
                INSERTr("tblesms", "'" & gIDVal("Message", True) & "','Logs','" & getVal("tbleparentinfo", "number", "rfidtagid='" & ID & "'") & "','" & STUDNO & _
                     "','Parent','" & getMessage(Message.AdvisoryMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                incrementID("Message")
            End If
        End If
        Return
StandBy: lblRFIDStatus.Text = "Please present your card."
        pbLoadRFID.Image = StandBy : LASTDETECTION_CTR += 1
        ID_LastRead = Nothing 'idle=No card is detected then the sms will now send
        Return
CardNotRegistered: lblRFIDStatus.Text = "This card is not yet registered!"
        pbLoadRFID.Image = NotRegistered
        Sounds(AUDIO.ERRORWARN)
    End Sub

#Region "UPDATE DISPLAY"
    Public Sub UpdateDisplay()
        Try
            ' If getVal("tbletempdetection", "field", " 1 order by datetime desc limit 1").Contains("Log out") Then GoTo LOGOUT
            If lblLogState.Text.Contains("LOG OUT") Then GoTo LOGOUT
LOGIN:      pbLogIn4.Image = pbLogIn3.Image : lblLogIn4.Text = lblLogIn3.Text : lblLogInSN4.Text = lblLogInSN3.Text
            pbLogIn3.Image = pbLogIn2.Image : lblLogIn3.Text = lblLogIn2.Text : lblLogInSN3.Text = lblLogInSN2.Text
            pbLogIn2.Image = pbLogIn1.Image : lblLogIn2.Text = lblLogIn1.Text : lblLogInSN2.Text = lblLogInSN1.Text
            pbLogIn1.Image = pbMainPic.Image : lblLogIn1.Text = getDateTime(CDate(lblDateTimeLog.Text), GetDateTimeValue.OO_OO_AM_PM) : lblLogInSN1.Text = lblStudNo.Text
            Return
LOGOUT:     pbLogOut4.Image = pbLogOut3.Image : lblLogOut4.Text = lblLogOut3.Text : lblLogOutSN4.Text = lblLogOutSN3.Text
            pbLogOut3.Image = pbLogOut2.Image : lblLogOut3.Text = lblLogOut2.Text : lblLogOutSN3.Text = lblLogOutSN2.Text
            pbLogOut2.Image = pbLogOut1.Image : lblLogOut2.Text = lblLogOut1.Text : lblLogOutSN2.Text = lblLOgOutSN1.Text
            pbLogOut1.Image = pbMainPic.Image : lblLogOut1.Text = getDateTime(CDate(lblDateTimeLog.Text), GetDateTimeValue.OO_OO_AM_PM) : lblLOgOutSN1.Text = lblStudNo.Text
            Return
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Public Sub UpdateMain(ByVal ID As String)
        dR = DataReader("select studno,fname,mname,lname,course,yearlevel,section,unlogout from tblestudent where rfidtagid='" & ID & "'")
        If Not dR.Read Then Return 'display unknown
        lblStudNo.Text = dR.Item(0)
        lblName.Text = dR.Item(1) & " " & dR.Item(2).ToString.Substring(0, 1) & ". " & dR.Item(3)
        If dR.Item(5) = 1 Then : lblYearSec.Text = "1st Year Section "
        ElseIf dR.Item(5) = 2 Then : lblYearSec.Text = "2nd Year Section "
        ElseIf dR.Item(5) = 3 Then : lblYearSec.Text = "3rd Year Section "
        Else : lblYearSec.Text = dR.Item(5) & "th Year Section" : End If
        lblYearSec.Text &= dR.Item(6)
        If dR.Item(7) = True Then lblLogState.Text = "LOG IN" Else lblLogState.Text = "LOG OUT"
        displayPic(ID, pbMainPic)
        lblCourse.Text = getVal("tblecodedesc", "description", "field like '%course%'  and  code='" & dR.Item(4) & "'")
        dR.Close()
        lblDateTimeLog.Text = getDateTime(sDT, GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM, "-")
    End Sub
#End Region

    Dim Ann As String = "PUPSMBCSSMS"
    Dim Ann_ctr As Integer = 0
    Function SPACES() As String
        tm.Interval = 100
        Dim s As String = ""
        For i As Integer = 0 To 100
            s &= " "
        Next
        SPACES = s
    End Function
    Private Sub tmrAnn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.Tick
        Ann_ctr += 1
        If Ann_ctr >= Ann.Length Then Ann_ctr = 0
        lblAnn.Text = Ann.Substring(Ann_ctr)
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        lblDate.Text = FormatDateTime(sDT, DateFormat.LongDate)
        lblTime.Text = getDateTime(sDT, GetDateTimeValue.OO_OO_OO_AM_PM)
    End Sub
End Class

