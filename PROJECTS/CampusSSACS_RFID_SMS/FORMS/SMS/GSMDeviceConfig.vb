Imports ATSMS
Imports System.IO.Ports
Imports System.IO.File
Imports System.IO

Public Class frmGSMDeviceConfig 
    Dim WithEvents GSMmodTemp As New GSMModem


    Private Sub frmGSMDeviceConfig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

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
        'On Error Resume Next

        Sounds(AUDIO.CLICK)
        If cmbPorts.Text = "" Then MB("Select the port!") : Return
        If cmbBaudRate.Text = "" Then MB("Choose baud rate!") : Return
        If cmbTimeOut.Text = "" Then MB("Choose time out period!") : Return
        If txtSendDelay.Text = "" Or Not IsNumeric(txtSendDelay.Text.Trim) Then MB("Invalid send delay value!") : Return
        If cmbStopBits.Text = "" Then MB("Select stop bits!") : Return
        If cmbValidity.Text = "" Then MB("Select validity period!") : Return

        If MB("Save changes?", "?") = "n" Then Return
        With My.Settings
            .SMS_PORT = cmbPorts.Text : SMSPORT = CInt(cmbPorts.Text.Replace("COM", ""))
            .SMS_BAUDRATE = CLng(cmbBaudRate.Text) : SMSBAUDRATE = CInt(cmbBaudRate.Text)
            .SMS_TIMEOUT = CLng(cmbTimeOut.Text) : SMSTIMEOUT = CInt(cmbTimeOut.Text)

            Select Case cmbValidity.Text
                Case "1 Hour" : .SMS_VALIDITY = 11 : SMSVALIDITY = 11
                Case "3 Hours" : .SMS_VALIDITY = 29 : SMSVALIDITY = 29
                Case "6 Hours" : .SMS_VALIDITY = 71 : SMSVALIDITY = 71
                Case "12 Hours" : .SMS_VALIDITY = 143 : SMSVALIDITY = 143
                Case "1 Day" : .SMS_VALIDITY = 167 : SMSVALIDITY = 167
                Case "1 Week" : .SMS_VALIDITY = 196 : SMSVALIDITY = 196
                Case "Maximum" : .SMS_VALIDITY = 255 : SMSVALIDITY = 255
            End Select
            Select Case cmbStopBits.Text
                Case "None" : .SMS_STOPBITS = 0 : SMSSTOPBITS = 0
                Case "1" : .SMS_STOPBITS = 1 : SMSSTOPBITS = 1
                Case "1.5" : .SMS_STOPBITS = 3 : SMSSTOPBITS = 3
                Case "2" : .SMS_STOPBITS = 2 : SMSSTOPBITS = 2
            End Select
            .SMS_SENDDELAY = CLng(txtSendDelay.Text.Trim) : SMSSENDDELAY = CInt(txtSendDelay.Text.Trim)
        End With
        UPDATEr("tblegsm", "port='" & SMSPORT & "',baudrate=" & SMSBAUDRATE & ",timeout=" & SMSTIMEOUT & ",validity=" & SMSVALIDITY & ",senddelay=" & SMSSENDDELAY & ",stopbits=" & SMSSTOPBITS)
        AssignConnection()
        IFEXISTSMSPORT = True
        MB("Saved!")
        If recCount("tbleusers", "usertype like '%Administrator%'") <= 0 Then : Me.Hide()
            frmEmptyDatabase.ShowDialog()
        End If
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbBaudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaudRate.SelectedIndexChanged

    End Sub
End Class