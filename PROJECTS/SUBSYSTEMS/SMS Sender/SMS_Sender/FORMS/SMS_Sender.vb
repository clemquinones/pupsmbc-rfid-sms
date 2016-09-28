Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter

Public Class frmSend
    Public WithEvents comM As GsmCommMain
    Public Logs As Boolean, LogCount As Integer = 0, Ann As Boolean, AnnCount As Integer = 0, Anonym As Boolean, AnonymCount As Integer = 0

    Private Sub frmSend_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UPDATEr("tbleid", "value=0", "field like '%SMSSending%'")
    End Sub


    'Public Sub comM_ReceivedMessage(ByVal sender As Object, ByVal e As GsmComm.GsmCommunication.MessageReceivedEventArgs) Handles comM.MessageReceived

    Public Sub comm_MessageReceived(ByVal sender As Object, ByVal e As MessageReceivedEventArgs) Handles comM.MessageReceived
        '  IO.File.Create("")
        tmrIdle.Start()
        Try
            If Not comM.IsConnected Then comM.Open()
            Dim obj As IMessageIndicationObject = e.IndicationObject
            Dim loc As MemoryLocation = CType(obj, MemoryLocation)
            Dim messages As DecodedShortMessage()
            messages = comM.ReadMessages(PhoneMessageStatus.ReceivedUnread, loc.Storage)
            For Each message As DecodedShortMessage In messages

                Dim data As SmsDeliverPdu = CType(CType(message.Data, SmsPdu), SmsDeliverPdu) 'New SmsDeliverPdu
                If data.OriginatingAddress.Length >= 10 Then
                    Dim number As String = data.OriginatingAddress.ToString.Substring(data.OriginatingAddress.Length - 10, 10)
                    If recCount("tbleparentinfo p,tblestudent s", "s.rfidtagid=p.rfidtagid and p.number like '%" & number & "'") Then
                        Dim STUDNO As String = getVal("tbleparentinfo p,tblestudent s", "s.studno", "p.rfidtagid=s.rfidtagid and p.number like '%" & number & "'")
                        Dim MsgText As String = "", ALERT As Boolean = True
                        If data.UserDataText.Trim.ToLower.ToString.Contains("alert off") Then
                            MsgText = getMessage(SMSMessage.BlockConfirmMessage)
                            If CBool(getVal("tbleparentinfo", "block", "number like '%" & number & "%'")) Then
                                MsgText = "Your PUP-SMBC advisory is currently not active."
                            End If
                            UPDATEr("tbleparentinfo", "block=1", "number like '%" & number & "'")
                        ElseIf data.UserDataText.Trim.ToLower.ToString.Contains("alert on") Then
                            MsgText = getMessage(SMSMessage.ActivateConfirmMessage)
                            If CBool(getVal("tbleparentinfo", "block", "number like '%" & number & "%'")) Then
                                MsgText = "Your PUP-SMBC advisory is currently active."
                            End If
                            UPDATEr("tbleparentinfo", "block=0", "number like '%" & number & "'")
                        ElseIf data.UserDataText.Trim.ToLower.ToString.Contains("alert ") Then
                            MsgText = getMessage(SMSMessage.GuideBlockMessage)
                        Else
                            ALERT = False
                            MsgText = data.UserDataText
                        End If
                        INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & "0" & number & "','" & STUDNO & "','Parent','" & v(data.UserDataText) & "',sysdate(),sysdate(),1,0,0")
                        incrementID("Message")
                        If ALERT Then 'ToSent
                            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & number & "','" & STUDNO & "','Parent','" & MsgText & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                            incrementID("Message")
                        End If

                    ElseIf recCount("tbleusers", "number like '%" & number & "'") Then
                        Dim USERID As String = getVal("tbleusers", "userid", "number like '%" & number & "'")
                        Dim MsgText As String = data.UserDataText
                        Dim Valid As Boolean = False
                        If MsgText.Trim.ToLower.ToString.Contains("smscommand ") Then
                            MsgText = MsgText.ToLower.Replace("smscommand ", "")
                            Dim SMSCOMMAND As String = ""
                            For i As Integer = 0 To MsgText.ToString.Length - 1
                                If MsgText(i) = " " Then Exit For
                                SMSCOMMAND &= MsgText(i)
                            Next
                            Dim ExistCommand As Integer = CMD_Exists(SMSCOMMAND)
                            If ExistCommand >= 0 Then
                                If recCount("tbleusers", "userid='" & USERID & "' and password='" & EncryptText(MsgText.Trim.Replace(SMSCOMMAND.ToString, "").Trim) & "'") Then
                                    Valid = True
                                    INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & number & "','" & USERID & "','User','" & getMessage(SMSMessage.ExecuteConfirmMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                                    incrementID("Message")
                                    Do_Command(ExistCommand)
                                Else 'wrongs password
                                    MsgText = "Cannot execute command. For security, you need to enter your correct password or password did not match."
                                End If
                            Else 'Invalid keyword- the keyword does not exist
                                MsgText = "The SMSCOMMAND Keyword you provide does not exist on the system."
                            End If
                        Else 'Invalid - SMSCOMMAND word is not found
                            Valid = True
                            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & "0" & number & "','" & _
                                 USERID & "','User','" & v(data.UserDataText) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                            incrementID("Message")
                        End If

                        If Not Valid Then
                            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & number & "','" & USERID & "','User','" & MsgText & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
                            incrementID("Message")
                        End If
                    End If
                End If

                Try
                    comM.DeleteMessage(message.Index, loc.Storage)
                Catch ex As Exception
                    MakeLog(ex.Message)
                End Try
            Next
        Catch ex As Exception
            MakeLog(ex.Message)
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Enum COMMAND
        SHUTDOWNS = 0
        SHUTDOWNC = 1
        SENDSTARTALL = 2
        SENDSTARTLOGS = 3
        SENDSTARTANNOUNCEMENT = 4
        SENDSTARTANONYMOUS = 5
        SENDSTOPLOGS = 6
        SENDSTOPANNOUNCEMENT = 7
        SENDSTOPANONYMOUS = 8
        SENDSTOPALL = 9
        SENDTURNOFF = 10
        SENDTURNON = 11
    End Enum
    Public Sub LOGACTION(ByVal Action As String, ByVal id As String)
        INSERTr("tblemonitoring", gIDVal("logs") & ",'" & id & "','Administrator','(via SMS) " & v(Action) & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "'")
        incrementID("logs")
    End Sub
    Public Function Do_Command(ByVal CMD As COMMAND) As Boolean

        Select Case CMD
            Case COMMAND.SHUTDOWNS
                MsgBox("The system received a command from administrator." & vbCr & vbCr & "System will now shutdown", 16)
                Shell("shutdown -s -t 3600")
            Case COMMAND.SHUTDOWNC
                UPDATEr("tbleid", "value=0", "field = 'Client'")
            Case COMMAND.SENDSTARTALL
                UPDATEr("tblegsm", "logs=1,announce=1,anonym=1")
            Case COMMAND.SENDSTARTLOGS
                UPDATEr("tblegsm", "logs=1")
            Case COMMAND.SENDSTARTANNOUNCEMENT
                UPDATEr("tblegsm", "announce=1")
            Case COMMAND.SENDSTARTANONYMOUS
                UPDATEr("tblegsm", "anonym=1")
            Case COMMAND.SENDSTOPLOGS
                UPDATEr("tblegsm", "logs=0")
            Case COMMAND.SENDSTOPANNOUNCEMENT
                UPDATEr("tblegsm", "announce=0")
            Case COMMAND.SENDSTOPANONYMOUS
                UPDATEr("tblegsm", "anonym=0")
            Case COMMAND.SENDSTOPALL
                UPDATEr("tblegsm", "logs=0,announce=0,anonym=0")
            Case COMMAND.SENDTURNOFF
                UPDATEr("tbleid", "value=0", "field = 'SMSSending'")
            Case COMMAND.SENDTURNON
                UPDATEr("tbleid", "value=1", "field = 'SMSSending'")
        End Select

    End Function
    Public Function CMD_Exists(ByVal CommandStr As String) As Integer
        CMD_Exists = -1
        For i As Integer = 0 To 11
            Dim SMSCOMMAND As COMMAND = i
            If SMSCOMMAND.ToString = CommandStr.ToUpper Then
                CMD_Exists = i : Exit For
            End If
        Next
    End Function



    Private Sub frmSend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppPath = CurDir()
        AssignConnection()
        If TestSMSPORT() = False Then EndNow() : Return
        openComm()
        tmrSend.Start()
        UPDATEr("tbleid", "value=1", "field like '%SMSSending%'")
        openComm()
    End Sub

    Private Sub tmrEnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnd.Tick
        If tmrEnd.Tag = True Then End Else tmrEnd.Tag = True : Sounds(AUDIO.COMPLETE)
    End Sub
    Sub EndNow()
        '    Exit Sub
        Me.Show()
        UPDATEr("tbleid", "value=0", "field like '%SMSSending%'")
        lblStatus.Text = "Finishing task...  "
        Me.Text = "Ending program..."
        tmrEnd.Start()
        ' SendNow()
    End Sub

    Function PDU_Encoding(ByVal USERDATATEXT As String, ByVal DESTINATIONADDRESS As String, Optional ByVal ALERT As Boolean = False, Optional ByVal UNICODE As Boolean = False) As SmsSubmitPdu
        If Not ALERT And Not UNICODE Then
            PDU_Encoding = New SmsSubmitPdu(USERDATATEXT, DESTINATIONADDRESS, "")
        ElseIf Not ALERT And UNICODE Then
            PDU_Encoding = New SmsSubmitPdu(USERDATATEXT, DESTINATIONADDRESS, "", DataCodingScheme.NoClass_16Bit)
        ElseIf ALERT And Not UNICODE Then
            PDU_Encoding = New SmsSubmitPdu(USERDATATEXT, DESTINATIONADDRESS, "", DataCodingScheme.Class0_7Bit)
        ElseIf ALERT And UNICODE Then
            PDU_Encoding = New SmsSubmitPdu(USERDATATEXT, DESTINATIONADDRESS, "", DataCodingScheme.Class0_16Bit)
        Else
            PDU_Encoding = New SmsSubmitPdu(USERDATATEXT, DESTINATIONADDRESS, "", DataCodingScheme.NoClass_7Bit)
        End If
    End Function

    Sub SendNow() 
        tmrEnd.Stop()
        tmrIdle.Stop()

    
        If Not TestSMSPORT() Then EndNow() : Return

        Do
            Try : Cursor = Cursors.WaitCursor
                If CBool(gIDVal("SMSSending", True)) = False Then EndNow() : Exit Do
                Dim pdU As New SmsSubmitPdu
                If recCount("tblesms", "(smstype like '%Logs' or smstype like '%Announcement' or smstype like '%ToSent') and sysdate() < expirydatetime") <= 0 Then Me.Tag = "Idle" : tmrIdle.Start() : Exit Do
                Dim dR As MySqlDataReader = DataReader("select logs,announce,anonym from tblegsm limit 1")
                If dR.Read Then Logs = dR.Item(0) : Ann = dR.Item(1) : Anonym = dR.Item(2)
                dR.Close()

                Dim ID As Integer = -1

                '-------------LOGS------------------------------------------------------------------------
                If Logs Then : openCon()
                    CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%Logs' and sysdate() < expirydatetime order by datetime desc limit 1", conN)
                    Dim dR1 As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
                    If dR1.Read Then : ID = dR1.Item(0)

                        pdU = New SmsSubmitPdu
                        pdU = PDU_Encoding(dR1.Item(1), dR1.Item(2), dR1.Item(4), dR1.Item(5))
                        For i As Integer = 1 To dR1.Item(3)
                            '  comM.Open()
                            comM.SendMessage(pdU)
                            ' comM.Close()
                        Next
                    End If
                    dR1.Close()
                End If
                UPDATEr("tblesms", "smstype='Logs_Sent'", "id=" & ID) : ID = -1
                '----------------------------------------------------------------------------------------------



                '-------------ANNOUNCEMENT------------------------------------------------------------------------
                If Ann Then : openCon()
                    CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%Announcement' and sysdate() < expirydatetime order by datetime desc limit 1", conN)
                    Dim dR2 As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
                    If dR2.Read Then : ID = dR2.Item(0)

                        pdU = New SmsSubmitPdu
                        pdU = PDU_Encoding(dR2.Item(1), dR2.Item(2), dR2.Item(4), dR2.Item(5))
                        For i As Integer = 1 To dR2.Item(3)
                            'comM.Open()
                            comM.SendMessage(pdU)
                            'comM.Close()
                        Next
                    End If
                    dR2.Close()
                End If
                UPDATEr("tblesms", "smstype='Announcement_Sent'", "id=" & ID) : ID = -1
                '----------------------------------------------------------------------------------------------



                '-------------ANONYMOUS------------------------------------------------------------------------
                If Anonym Then : openCon()
                    CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%ToSent%' and expirydatetime >= sysdate() order by datetime desc limit 1", conN)
                    Dim dR3 As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
                    If dR3.Read Then : ID = dR3.Item(0)
                        pdU = New SmsSubmitPdu
                        pdU = PDU_Encoding(dR3.Item(1), dR3.Item(2), dR3.Item(4), dR3.Item(5))
                        For i As Integer = 1 To dR3.Item(3)
                            'comM.Open()
                            comM.SendMessage(pdU)
                            'comM.Close()
                        Next
                    End If
                    dR3.Close()
                End If
                UPDATEr("tblesms", "smstype='Sent'", "id=" & ID)
                '----------------------------------------------------------------------------------------------


            Catch ex As Exception
                MakeLog(ex.Message)
                Me.Text = "Error: " & ex.Message
                EndNow() : Exit Do
            Finally
                Cursor = Cursors.Default
            End Try
        Loop
    End Sub

    Private Sub tmrSend_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSend.Tick
        'once running timer
        Me.Hide()
        tmrSend.Stop()
        SendNow()
    End Sub


    Private Sub tmrIdle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIdle.Tick
        'run every 3 seconds
        '  On Error Resume Next
        '  comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)

        '  If Not comM.IsOpen Then comM.Open()


        If Not Me.Tag = "Idle" Then Return
        Me.Hide()
        If CBool(gIDVal("SMSSending", True)) = False Then EndNow() : tmrIdle.Stop() : Exit Sub
        Dim dR As MySqlDataReader = DataReader("select logs,announce,anonym from tblegsm limit 1")
        If dR.Read Then Logs = dR.Item(0) : Ann = dR.Item(1) : Anonym = dR.Item(2)
        dR.Close()
        If recCount("tblesms", "(smstype like '%Logs' or smstype like '%Announcement' or smstype like '%ToSent') and sysdate() < expirydatetime") > 0 And (Logs Or Ann Or Anonym) Then
            tmrIdle.Stop() : Me.Tag = "Sending" : SendNow()
        End If
        '  comM.Close()
        'closeComm()
    End Sub
 
    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub tmrOpen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOpen.Tick

    End Sub
End Class
