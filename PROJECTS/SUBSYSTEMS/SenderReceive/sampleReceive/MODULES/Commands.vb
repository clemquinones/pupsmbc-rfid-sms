Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports MySql.Data.MySqlClient

Module Commands
    Public Sender As New frmSMSSender

#Region "Count the Message To Be Sent"
    Public Function Parents(ByVal userNum As String, ByVal Message As String) As Boolean
        Parents = False
        Try
            If recCount("tbleparentinfo", "number like '%" & userNum & "' and block=false") <= 0 Then Exit Function
            If userNum > 10 Then userNum = "0" & userNum
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & userNum & "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and p.number like '%" & userNum & "' limit 1),'Parent','" & v(Message) & "',sysdate(),sysdate(),1,0,0")
            incrementID("Message")
            Parents = True
        Catch ex As Exception
            Parents = False
        End Try
        Return Parents
    End Function
    Public Function User(ByVal userNum As String, ByVal Message As String) As Boolean
        User = False
        Try
            If recCount("tbleusers", "number like '%" & userNum & "' and usertype like '%admin%'") <= 0 Then Exit Function
            If userNum > 10 Then userNum = "0" & userNum
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & userNum & "',(select userid from tbleusers where number like '%" & userNum & "' limit 1),'Parent','" & v(Message) & "',sysdate(),sysdate(),1,0,0")
            incrementID("Message")
            User = True
        Catch ex As Exception
            User = False
        End Try
        Return User
    End Function
    Public Function UnRegistered(ByVal userNum As String, ByVal Message As String) As Boolean
        UnRegistered = False
        Try
            If recCount("tbleparentinfo", "number like '%" & userNum & "'") > 0 Or recCount("tbleusers", "number like '%" & userNum & "'") > 0 Then Exit Function
            Dim RecID As String, RecType As String
            If recCount("tblestudent", "number like '%" & userNum & "'") > 0 Then
                RecID = getVal("tblestudent", "studno", "number like '%" & userNum & "'")
                RecType = "Student"
            Else
                RecID = "0" & userNum
                RecType = "Unregistered"
            End If
            If userNum > 10 Then userNum = "0" & userNum
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & userNum & "','" & RecID & "','" & RecType & "','" & v(Message) & "',sysdate(),sysdate(),1,0,0")
            incrementID("Message")
            UnRegistered = True
        Catch ex As Exception
            UnRegistered = False
        End Try
        Return UnRegistered
    End Function
#End Region
#Region "Execute command"
    Public Function User_Command(ByVal UserNum As String, ByVal Message As String) As Boolean
        On Error Resume Next
        If Message.Trim.ToUpper = "SHUTDOWNS" Then
            MsgBox("The system received a command message from administrator." & vbCr & vbCr & _
                "The system will now shutdown..", MsgBoxStyle.Critical)
            Shell("shutdown -s -t 30")

            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & "0" & UserNum & _
                         "',(select userid from tbleusers where number like '%" & UserNum & "' limit 1),'User','" & _
                         Message & "',sysdate(),sysdate(),1,0,0")
            incrementID("Message")

            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
                         "',(select userid from tbleusers where number like '%" & UserNum & "' limit 1),'User','" & _
                         getMessage(SMSMessage.ExecuteConfirmMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        Else
            Message = "The SMSCOMMAND Keyword you provide does not exist on the system."
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
                         "',(select userid from tbleusers where number like '%" & UserNum & "' limit 1),'User','" & _
                         Message & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        End If
    End Function
    Public Function Parent_Command(ByVal UserNum As String, ByVal Message As String) As Boolean
        On Error Resume Next
Test:   If Message.Trim.ToUpper = "ALERT ON" Or Message.Trim.ToUpper = "ALERT OFF" Then GoTo Valid
        INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ReceivedUnRead','" & "0" & UserNum & _
                       "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and " & _
                       "p.number like '%" & UserNum & "' and p.block=false limit 1),'Parent','" & _
                       Message & "',sysdate(),sysdate(),1,0,0")
        incrementID("Message")
        INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
                "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and " & _
                "p.number like '%" & UserNum & "' and p.block=false limit 1),'Parent','" & _
                getMessage(SMSMessage.GuideBlockMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
        incrementID("Message")
        Exit Function
Valid:  If Message.Trim.ToUpper = "ALERT ON" Then
            If Not CBool(getVal("tbleparentinfo", "block", "number like '%" & UserNum & "'")) Then
                Message = "Your PUP-SMBC advisory is currently active."
            Else
                Message = getMessage(SMSMessage.ActivateConfirmMessage)
                UPDATEr("tbleparentinfo", "block=0", "number like '%" & UserNum & "'")
            End If
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
               "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and " & _
               "p.number like '%" & UserNum & "' and p.block=false limit 1),'Parent','" & _
               Message & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        ElseIf Message.Trim.ToUpper = "ALERT OFF" Then
            If CBool(getVal("tbleparentinfo", "block", "number like '%" & UserNum & "'")) Then
                Message = "Your PUP-SMBC advisory is currently not active."
            Else
                Message = getMessage(SMSMessage.BlockConfirmMessage)
                UPDATEr("tbleparentinfo", "block=1", "number like '%" & UserNum & "'")
            End If
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
               "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and " & _
               "p.number like '%" & UserNum & "' limit 1),'Parent','" & _
              Message & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        Else
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
               "',(select s.studno from tblestudent s,tbleparentinfo p where s.rfidtagid=p.rfidtagid and " & _
               "p.number like '%" & UserNum & "' and p.block=false limit 1),'Parent','" & _
               getMessage(SMSMessage.GuideBlockMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        End If
    End Function
    Public Function Unreg_Command(ByVal UserNum As String, ByVal Message As String) As Boolean
        On Error Resume Next
        If recCount("tblestudent", "number like '%" & UserNum & "'") < 0 Then
            Message = "Your number is not yet registered to the PUP-SMBC Campus Monitoring System."
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','ToSent','" & "0" & UserNum & _
               "','0" & UserNum & "','Unregistered','" & _
               Message & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        End If
    End Function
#End Region

    Public Function Logs() As Boolean
        On Error Resume Next
        Dim Active As Boolean = CBool(getVal("tblegsm", "Logs"))
        Dim Count As Integer = recCount("tblesms", "smstype like '%Logs' and sysdate()<= expirydatetime")
        If Active And Count > 0 Then Return True Else Return False
    End Function
    Public Function Announce() As Boolean
        On Error Resume Next
        Dim Active As Boolean = CBool(getVal("tblegsm", "Announce"))
        Dim Count As Integer = recCount("tblesms", "smstype like '%Announcement' and sysdate()<= expirydatetime")
        If Active And Count > 0 Then Return True Else Return False
    End Function
    Public Function Anonymous() As Boolean
        On Error Resume Next
        Dim Active As Boolean = CBool(getVal("tblegsm", "Anonym"))
        Dim Count As Integer = recCount("tblesms", "smstype like '%ToSent' and sysdate()<= expirydatetime")
        If Active And Count > 0 Then Return True Else Return False
    End Function

    Public Function SendLogs() As Boolean
        Sender.Sending = True
        Try
            openCon() : Dim ID As String = "-1"
            CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%Logs' and sysdate() < expirydatetime order by datetime desc limit 1", conN)
            Dim dR As MySqlDataReader = CMD.ExecuteReader()
            If dR.Read Then : ID = dR.Item(0)
                Dim pdU As New SmsSubmitPdu
                pdU = PDU_Encoding(dR.Item(1), dR.Item(2), dR.Item(4), dR.Item(5))
                For i As Integer = 1 To dR.Item(3)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                    Sender.comM = New GsmCommMain(SMSPORT, BAUDRATE, TIMEOUT)
                    Sender.comM.Open()
                    Sender.comM.EnableMessageNotifications()
                    Sender.ReadUnReadMessage()
                    Sender.comM.SendMessage(pdU)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                Next
            End If
            dR.Close()
            UPDATEr("tblesms", "smstype='Logs_Sent'", "id=" & ID)
            Sender.Sending = False
        Catch ex As Exception
            Sender.EndNow()
        End Try

    End Function
    Public Function SendAnnounce() As Boolean
        Sender.Sending = True
        Try
            openCon() : Dim ID As String = "-1"
            CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%Announcement' and sysdate()<= expirydatetime order by datetime desc limit 1", conN)
            Dim dR As MySqlDataReader = CMD.ExecuteReader()
            If dR.Read Then : ID = dR.Item(0)
                Dim pdu As New SmsSubmitPdu
                pdu = PDU_Encoding(dR.Item(1), dR.Item(2), dR.Item(4), dR.Item(5))
                For i As Integer = 1 To dR.Item(3)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                    Sender.comM = New GsmCommMain(SMSPORT, BAUDRATE, TIMEOUT)
                    Sender.comM.Open()
                    Sender.comM.EnableMessageNotifications()
                    Sender.ReadUnReadMessage()
                    Sender.comM.SendMessage(pdu)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                Next
            End If
            dR.Close()
            UPDATEr("tblesms", "smstype='Announcement_Sent'", "id=" & ID)
            Sender.Sending = False
        Catch ex As Exception
            Sender.EndNow()
        End Try

    End Function
    Public Function SendAnonymous() As Boolean
        'On Error Resume Next
        Sender.Sending = True
        Try
            openCon() : Dim ID As String = "-1"
            CMD = New MySqlCommand("select id,message,usernum,sendcopy,alert,unicode from tblesms where smstype like '%ToSent%' and expirydatetime >= sysdate() order by datetime desc limit 1", conN)
            Dim dR As MySqlDataReader = CMD.ExecuteReader()
            If dR.Read Then : ID = dR.Item(0)
                Dim pdU As New SmsSubmitPdu
                pdU = PDU_Encoding(dR.Item(1), dR.Item(2), dR.Item(4), dR.Item(5))
                For i As Integer = 1 To dR.Item(3)
                    Sender.comM = New GsmCommMain(SMSPORT, BAUDRATE, TIMEOUT)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                    Sender.comM.Open()
                    Sender.comM.EnableMessageNotifications()
                    Sender.ReadUnReadMessage()
                    Sender.comM.SendMessage(pdU)
                    If Sender.comM.IsOpen Then Sender.comM.Close()
                Next
            End If
            dR.Close()
            UPDATEr("tblesms", "smstype='Sent'", "id=" & ID)
            Sender.Sending = False
        Catch ex As Exception
            Sender.EndNow()
        End Try

    End Function

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
End Module
