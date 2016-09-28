
Imports System.IO.Ports
Imports GsmComm.PduConverter
Imports GsmComm.GsmCommunication

Public Class frmGSM_Module_Setting
    Dim Done As Boolean = False, OK As Boolean = False

    Private Sub rbAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAuto.CheckedChanged
        If rbAuto.Checked = True Then gbManual.Enabled = False
    End Sub

    Private Sub rbManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked = True Then gbManual.Enabled = True
    End Sub

    Private Sub frmGSM_Module_Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Done = False
        cmbCommPort.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            cmbCommPort.Items.Add(s)
        Next
        cmbCommPort.Items.RemoveAt(0)
        cmbCommPort.Sorted = True
        cmbCommPort.SelectedIndex = 0
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Done = True
        If OK = False Then Call btnTest_Click(sender, e) : Exit Sub
        Dim s() As String = IO.File.ReadAllLines(Path)
        Dim Text As String = ""
        For i As Integer = 0 To s.Length - 1
            If s(i).Contains("[SMS_PORT]") Then s(i) = "[SMS_PORT]=" & SMSPORT & ";"
            If s(i).Contains("[SMS_BAUDRATE]") Then s(i) = "[SMS_BAUDRATE]=" & SMSBAUDRATE & ";"
            If s(i).Contains("[SMS_TIMEOUT]") Then s(i) = "[SMS_TIMEOUT]=" & SMSTIMEOUT & ";"
            Text &= IIf(Not s(i).Replace(vbCr, "").Trim = "", s(i), "") & vbCr
        Next i
        IO.File.WriteAllText(Path, Text)
        MsgBox("Successfully saved!") : Me.Hide()
    End Sub


    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If cmbBaudRate.Text = "" Or Not IsNumeric(cmbBaudRate.Text.Trim) Then MB("Invalid baud rate value!", "!") : toHL(cmbBaudRate) : Exit Sub Else SMSBAUDRATE = CInt(cmbBaudRate.Text)
        If cmbTimeOut.Text = "" Or Not IsNumeric(cmbTimeOut.Text.Trim) Then MB("Invalid time out value!", "!") : toHL(cmbTimeOut) : Exit Sub Else SMSTIMEOUT = CInt(cmbTimeOut.Text)
        lvPorts.Items.Clear()
        If rbAuto.Checked = True Then
            AutoDetect()
        Else
            If cmbCommPort.SelectedIndex < 0 Then MB("Select COMM port!", "!") : cmbCommPort.SelectedIndex = 0 : Exit Sub
            ManualDetect()
        End If
    End Sub
    Public Sub ManualDetect()
        Try
            Cursor = Cursors.WaitCursor
            lvPorts.Items.Add(cmbCommPort.SelectedItem)
            lvPorts.Items(0).SubItems.Add("Detecting...")
            lblStatus.Text = "Detecting GSM Device from port " & cmbCommPort.SelectedItem & "..."
            comM = New GsmCommMain(cmbCommPort.SelectedIndex, SMSBAUDRATE, SMSTIMEOUT)
            SMSPORT = cmbCommPort.SelectedItem.ToString.Replace("COM", "")
            'openComm(CInt(cmbCommPort.SelectedItem.ToString.Replace("COM", "")))
            openComm()
            lblStatus.Text = "Device detected @port " & cmbCommPort.SelectedItem & "."
            lvPorts.Items(0).SubItems(1).Text = "Found"
            closeComm() : Cursor = Cursors.Default
            OK = True
            ' Port = cmbCommPort.SelectedIndex
        Catch ex As Exception
            closeComm()
            Cursor = Cursors.Default
            lvPorts.Items(0).SubItems(1).Text = "Not found."
            '   lvPorts.Items.Clear()
            MB(ex.Message & vbCr & vbCr & "Make sure the device is properly attached to this computer.")
            lblStatus.Text = "Select the port of the device."
            OK = False
        End Try
    End Sub

    Public Sub AutoDetect()
        Dim i As Integer = 1 : Dim li As New ListViewItem : lvPorts.Items.Clear()
        Dim DetectedAt As String = "" : Dim DetectCount As String = ""
        Do
            Cursor = Cursors.WaitCursor
            Try
                li = lvPorts.Items.Add(SerialPort.GetPortNames(i))
                li.SubItems.Add("Detecting...")
                lblStatus.Text = "Detecting GSM Device from port " & SerialPort.GetPortNames(i) & "..."
                Dim asd As Integer = CInt(SerialPort.GetPortNames(i).Replace("COM", ""))
                'comM = New GsmCommMain(CInt(SerialPort.GetPortNames(i).Replace("COM", "")), BaudRate, TimeOut)
                SMSPORT = SerialPort.GetPortNames(i).Replace("COM", "")
                openComm()
                '  openComm(CInt(SerialPort.GetPortNames(i).Replace("COM", "")))
                DetectedAt &= IIf(i > 0, SerialPort.GetPortNames(i) & vbNewLine, "")
                lblStatus.Text = "Device detected @port " & SerialPort.GetPortNames(i) & "."
                li.SubItems(1).Text = "Found"
                closeComm() : Cursor = Cursors.Default
                DetectCount &= i.ToString

            Catch ex As Exception
                li.SubItems(1).Text = "Not found. "
                Dim msg As String = ""
                For Each x As String In ex.Message.Split(vbNewLine) : msg &= x & " " : Next
                li.SubItems(1).Text &= msg
                lblStatus.Text = "Could not read from " & SerialPort.GetPortNames(i) & "."
            End Try
            i += 1
            '  While True And i < SerialPort.GetPortNames.Length - 1

            ' End While

            If i >= SerialPort.GetPortNames.Length - 1 Then
                closeComm()
                Cursor = Cursors.Default
                If DetectedAt = "" Then
                    MB("No GSM Module detected to this machine." & vbCr & vbCr & "Make  sure it is  properly attached.")
                Else
                    MB("Device(s) found on this  following  port:" & vbCr & vbCr & DetectedAt)
                End If
                If lvPorts.Items.Count = 1 Then
                    '  lvPorts.Items.Clear()
                    '   Port = CInt(DetectCount.Substring(0))
                    '  openComm() : closeComm()
                    '  MB(Port)
                End If
                lblStatus.Text = "Select the port of the device."
                Exit Do
            End If
            closeComm() : Cursor = Cursors.Default
        Loop
    End Sub


End Class