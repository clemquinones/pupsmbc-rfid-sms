Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports ATSMS
Imports System.IO
Imports System.IO.File

Module modSMS
    Public Sub showCreateMessage(Optional ByVal ID As String = "", Optional ByVal FIELD As String = "studno", Optional ByVal TABLE As String = "tblestudent")
        Dim Number As String = getVal(TABLE, "number", FIELD & "='" & ID & "'")
        If Number = "" Then MB("No phone number is gathered from this recipient.", "!") : Return
        If frmCreateMessage.Visible = 1 Then frmCreateMessage.Close()
        frmCreateMessage.Tag = Number
        frmCreateMessage.ShowDialog()
    End Sub

#Region "VARIABLES"
    Public SMSPORT As Integer = Nothing, SMSBAUDRATE As Integer = Nothing, SMSTIMEOUT As Integer = Nothing
    Public SMSVALIDITY As Integer = Nothing, SMSSTOPBITS As Integer = Nothing, SMSSENDDELAY As Integer = Nothing
    Public comM As New GsmCommMain
    Public pdU As New SmsSubmitPdu
    Public SendCopy As Integer = Nothing
    Public GSMConnected As Boolean = False
    Public SendSuccess As Boolean = False
#End Region
    '----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------
#Region "FUNCTIONS"
    Public Function getMessage(ByVal Msg As Message) As String
        Dim Field As String = ""
        If Msg = Message.AnnouncementMessage Then Field = "Annoucement"
        If Msg = Message.LoginMessage Then Field = "LoginMessage"
        If Msg = Message.LogoutMessage Then Field = "LogOutMessage"
        If Msg = Message.UnlogoutMessage Then Field = "UnlogoutMessage"
        If Msg = Message.AdvisoryMessage Then Field = "AdvisoryMessage"
        Return gIDVal(Field, 0) & IIf(Field = "LoginMessage" Or Field = "LogOutMessage" Or Field = "UnlogoutMessage", " " & getDateTime(Now, GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM), "") & ". "
    End Function

    Public Function TestSMSPORT(Optional ByVal PORT As String = "COM5") As Boolean
        Dim comMtest As New GsmCommMain
        Try
            If comMtest.IsOpen = True Then comMtest.Close()
            comMtest = New GsmCommMain(CInt(PORT.Replace("COM", "")), SMSBAUDRATE, SMSTIMEOUT)
            comMtest.Open()
            comMtest.Close()
            GSMConnected = True
            Return True
        Catch ex As Exception
            GSMConnected = True
            If comMtest.IsOpen Then comMtest.Close()
            MB(ex.Message)
            Return False
        End Try
    End Function

    'Send to Many Recipient()
    Public Function Send(ByVal Message As String, ByVal Destination() As String, ByVal TextOutput As Object, Optional ByVal SendCopy As Integer = 1) As Boolean
        comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
        Dim SendCtr As Integer = 0, DestCTR As Integer = 0
        For i As Integer = 1 To SendCopy
            TextOutput.Text = "Sending " & (SendCtr + 1) & " of " & (SendCopy * Destination.Length) & "..."
            Try : DestCTR = 0
                Do While (True And DestCTR < Destination.Length)
                    TextOutput.Text = "Sending " & (SendCtr + 1) & " of " & (SendCopy * Destination.Length) & "..."
                    If Not comM.IsConnected = True Or Not comM.IsOpen = True Then comM.Open()
                    pdU = New SmsSubmitPdu(Message, Destination(DestCTR), "")
                    comM.SendMessage(pdU) : DestCTR += 1 : SendCtr += 1
                    If comM.IsConnected = True Or comM.IsOpen Then comM.Close()
                    TextOutput.Text = "Sending " & (SendCtr + 1) & " of " & (SendCopy * Destination.Length) & "..."
                Loop
            Catch ex As Exception
                If comM.IsConnected = True Or comM.IsOpen Then comM.Close()
                TextOutput.Text = ex.Message : Return False
            End Try
        Next

        If SendCtr >= SendCopy * Destination.Length Then
            If comM.IsConnected = True Or comM.IsOpen Then comM.Close()
            TextOutput.Text = "Message sent!" : Return True
        Else
            If comM.IsConnected = True Or comM.IsOpen Then comM.Close()
            Return False
        End If
    End Function
    'Send to one recipient
    Public Function SendMsg(ByVal Recipient As String, ByVal Message As String) As Boolean
        Try
            openComm()
            pdU = New SmsSubmitPdu(Message, Recipient, "")
            comM.SendMessage(pdU)
            closeComm()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
    '----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------
#Region "SUB PROCEDURES"
    Public Sub openComm()
        'If UsePort > 0 Then comM = New GsmCommMain(UsePort, BaudRate, TimeOut)
        Try
OPEN:       If comM.IsOpen Then comM.Close()
            comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
            If Not comM.IsOpen = True Then comM.Open()
            comM.Close()
            GSMConnected = True
        Catch ex As Exception
            GSMConnected = False
            MB(ex.Message & vbCr & vbCr & "Check the sms module.", "x")
        End Try
    End Sub
    Public Sub closeComm()
        If comM.IsOpen = True Then comM.Close()
    End Sub

#End Region

    Enum Message
        LoginMessage = 0
        LogoutMessage = 1
        AnnouncementMessage = 2
        UnlogoutMessage = 3
        AdvisoryMessage = 4
    End Enum


    Public Sub RunSMS_subsystem()
        Dim TRIAL As Integer = 0
SEND:   If CInt(gIDVal("SMSSending")) = 0 Then
            If IO.File.Exists(PathSMS) Then : TRIAL += 1
                Try
                    Shell(PathSMS & " /min /abovenormal")
                Catch ex As Exception
                    If TRIAL >= 3 Then MB(ex.Message) : Return
                    GoTo SEND
                End Try
            Else
                MB("The file '" & PathSMS & "' is missing." & vbCr & vbCr & "Cannot continue sending of messages." & vbCr & "Please contact the maintenance/administrator to fix this problem.", "x") : Return
            End If
        End If
        Return
    End Sub
End Module

Module modATSMS
#Region "VARIABLES"
    Public WithEvents GSMmodule As New GSMModem
    Public PathSMS As String = ""
#End Region
    '----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------
#Region "FUNCTIONS"

#End Region
    '----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------
#Region "SUB PROCEDURES"
    Public Sub GSMmodule_NewMessageReceived(ByVal e As NewMessageReceivedEventArgs) Handles GSMmodule.NewMessageReceived
        MsgBox("You have received messaged!")
    End Sub

    Public Sub openSMSmod()
        Try : Dim i As Integer = 0
CONNECT:    i += 1
            If GSMmodule.IsConnected = True Then GSMmodule.Disconnect()
            GSMmodule.Port = "COM" & SMSPORT
            GSMmodule.BaudRate = SMSBAUDRATE
            GSMmodule.Timeout = SMSTIMEOUT
            GSMmodule.StopBits = SMSSTOPBITS
            GSMmodule.Validity = SMSVALIDITY
            GSMmodule.SendDelay = SMSSENDDELAY
            If Not GSMmodule.IsConnected = True Then GSMmodule.Connect()
            GSMmodule.MessageMemory = Common.EnumMessageMemory.PHONE
            If i >= 3 Then Return
            If GSMmodule.IsConnected = True Then Return Else GoTo CONNECT
        Catch ex As Exception
            If GSMmodule.IsConnected = True Then GSMmodule.Disconnect()
            MB(ex.Message)
            Return
        End Try
    End Sub
    Public Sub closeSMSmod()
        If GSMmodule.IsConnected = True Then GSMmodule.Disconnect()
    End Sub
#End Region
End Module
