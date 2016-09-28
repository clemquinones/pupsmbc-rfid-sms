Imports ATSMS
Imports System.IO.Ports
Imports System.IO.File
Imports System.IO

Public Class frmGSMDeviceConfig
#Region "GSM MODEM"
    Dim WithEvents GSMmodTemp As New GSMModem
    Private Sub GSMmodTemp_NewMessageReceived(ByVal e As ATSMS.NewMessageReceivedEventArgs) Handles GSMmodTemp.NewMessageReceived
        MsgBox("You have received message!")
        lblStatus.Text = "From: " & e.MSISDN & "Message:" & vbNewLine & e.TextMessage
    End Sub
#End Region

    Private Sub frmGSMDeviceConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        For Each port As String In SerialPort.GetPortNames
            If Not port Like "COM1" And Not port Like "COM3" Then
                cmbPorts.Items.Add(port)
            End If
        Next
        cmbPorts.Text = SMSPORT
        cmbBaudRate.Text = SMSBAUDRATE
        cmbTimeOut.Text = SMSTIMEOUT
        cmbStopBits.Text = SMSSTOPBITS
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If cmbPorts.Text = "" Then MB("Select the port!") : Return
        If cmbBaudRate.Text = "" Then MB("Choose baud rate!") : Return
        If cmbTimeOut.Text = "" Then MB("Choose time out period!") : Return

        If GSMmodTemp.IsConnected = True Then GSMmodTemp.Disconnect()
        GSMmodTemp.Port = cmbPorts.Text
        GSMmodTemp.BaudRate = CInt(cmbBaudRate.Text)
        GSMmodTemp.Timeout = CInt(cmbTimeOut.Text)

        GSMmodTemp.FlowControl = Common.EnumFlowControl.RTS_CTS

        Try
            GSMmodTemp.Connect()
            GSMmodTemp.MessageMemory = Common.EnumMessageMemory.PHONE
            GSMmodTemp.Disconnect()
        Catch ex As Exception
            GSMmodTemp.Disconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        End Try

        Try
            GSMmodTemp.NewMessageIndication = True
        Catch ex As Exception
        End Try

        lblStatus.Text = "STATUS: CONNECTED"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbPorts.Text = "" Then MB("Select the port!") : Return
        If cmbBaudRate.Text = "" Then MB("Choose baud rate!") : Return
        If cmbTimeOut.Text = "" Then MB("Choose time out period!") : Return
        If txtSendDelay.Text = "" Or Not IsNumeric(txtSendDelay.Text.Trim) Then MB("Invalid send delay value!") : Return
        If cmbStopBits.Text = "" Then MB("Select stop bits!") : Return
        If cmbValidity.Text = "" Then MB("Select validity period!") : Return

        If MB("Save changes?", "?") = "n" Then Return
        Write("[SMS_PORT]", cmbPorts.Text.Replace("COM", "")) : SMSPORT = CInt(cmbPorts.Text.Replace("COM", ""))
        Write("[SMS_BAUDRATE]", cmbBaudRate.Text) : SMSBAUDRATE = CInt(cmbBaudRate.Text)
        Write("[SMS_TIMEOUT]", cmbTimeOut.Text) : SMSTIMEOUT = CInt(cmbTimeOut.Text)
        Select Case cmbValidity.Text
            Case "1 Hour" : Write("[SMS_VALIDITY]", "11") : SMSVALIDITY = 11
            Case "3 Hours" : Write("[SMS_VALIDITY]", "29") : SMSVALIDITY = 29
            Case "6 Hours" : Write("[SMS_VALIDITY]", "71") : SMSVALIDITY = 71
            Case "12 Hours" : Write("[SMS_VALIDITY]", "143") : SMSVALIDITY = 143
            Case "1 Day" : Write("[SMS_VALIDITY]", "167") : SMSVALIDITY = 167
            Case "1 Week" : Write("[SMS_VALIDITY]", "196") : SMSVALIDITY = 196
            Case "Maximum" : Write("[SMS_VALIDITY]", "255") : SMSVALIDITY = 255
        End Select
        Select Case cmbStopBits.Text
            Case "None" : Write("[SMS_STOPBITS]", "0") : SMSSTOPBITS = 0
            Case "1" : Write("[SMS_STOPBITS]", "1") : SMSSTOPBITS = 1
            Case "1.5" : Write("[SMS_STOPBITS]", "3") : SMSSTOPBITS = 3
            Case "2" : Write("[SMS_STOPBITS]", "2") : SMSSTOPBITS = 2
        End Select
        Write("[SMS_SENDDELAY]", txtSendDelay.Text) : SMSSENDDELAY = CInt(txtSendDelay.Text.Trim)
        MB("Saved!")
        Me.Close() : Return

    End Sub
End Class