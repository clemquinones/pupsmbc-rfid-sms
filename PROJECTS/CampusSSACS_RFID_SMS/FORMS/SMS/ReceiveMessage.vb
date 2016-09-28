Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter

Public Class frmReceiveMessage
    Dim Storage As String = ""
    Public Sub reLOAD()
        If rbSIM.Checked = True Then Storage = PhoneStorageType.Sim Else Storage = PhoneStorageType.Phone
    End Sub

    Private Sub frmReceiveMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmReceiveMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = "Reading content..."
        'tmrCount.Enabled = True
        comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
        comM.Open()
        If rbSIM.Checked = True Then Storage = PhoneStorageType.Sim Else Storage = PhoneStorageType.Phone
        For Each msg As DecodedShortMessage In comM.ReadMessages(PhoneMessageStatus.ReceivedRead, Storage)
            msgStat(msg)
        Next


        Try
            'viewlv
        Catch ex As Exception

        End Try
    End Sub

    Sub viewLV()
        lblStatus.Text = "Message counts: " & comM.ReadMessages(PhoneMessageStatus.All, Storage).Length
    End Sub

    Private Sub btnDisplayMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayMessage.Click




        If rbSIM.Checked = True Then Storage = PhoneStorageType.Sim Else Storage = PhoneStorageType.Phone
        Cursor = Cursors.WaitCursor

        Try
            openComm()
            Dim Messages() As DecodedShortMessage = comM.ReadMessages(PhoneMessageStatus.All, Storage)

            Dim li As New ListViewItem
            


            lblStatus.Text = "Message counts: " & comM.ReadMessages(PhoneMessageStatus.All, Storage).Length
            MB("u have " & Messages.Length & " counts of  message  received (" & IIf(rbSIM.Checked, "SIM Storage", "Local Storage") & ").")

            For Each i As DecodedShortMessage In Messages

            Next

            closeComm()
            Cursor = Cursors.Default
        Catch ex As Exception
            closeComm()
            Cursor = Cursors.Default
            MB(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMAIN.Show()
        Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If LV.Items.Count <= 0 Then Exit Sub
        If LV.CheckedItems.Count <= 0 < 0 Then MB("Check the boxes to select items.") : Exit Sub
        Dim chkItems(LV.CheckedItems.Count - 1) As Integer
        For i As Integer = LV.CheckedItems.Count - 1 To 0 Step -1
            chkItems(i) = LV.CheckedIndices(i)
        Next
        If MB("Selected items count: " & LV.CheckedItems.Count & vbCr & vbCr & "Delete message?", "?") = "n" Then Exit Sub
        Cursor = Cursors.WaitCursor
        Dim x As Integer = chkItems.Length - 1
        Do
            While True And x > 0
                lblStatus.Text = "Deleting message from " & LV.Items(chkItems(x)).Text & "...(" & (chkItems.Length - (x + 1)) & "/" & chkItems.Length & ")"
                openComm()
                comM.DeleteMessage(chkItems(x), Storage)
                LV.Items.RemoveAt(chkItems(x))
                x -= 1
            End While
            If x <= 0 Then
                closeComm()
                Cursor = Cursors.Default
                lblStatus.Text = "Message deleted."
                Exit Do
            End If
            closeComm()
        Loop
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            'viewLV
            Call frmReceiveMessage_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If LV.Items.Count <= 0 Then Exit Sub
        For i As Integer = 0 To LV.Items.Count - 1 : LV.Items(i).Checked = True : Next
        If MB("Delete all messages?", "?") = "n" Then Exit Sub
        Cursor = Cursors.WaitCursor
        Dim deleted As Integer = 0
        Dim delItem As Integer = LV.Items.Count - 1
        Do
            While True And deleted > 0
                lblStatus.Text = "Deleting message from " & LV.Items(delItem).Text & "...(" & (LV.Items.Count - (delItem + 1)) & "/" & LV.Items.Count & ")"
                openComm()
                comM.DeleteMessage(delItem, Storage)
                deleted += 1
                LV.Items.RemoveAt(delItem)
                delItem -= 1
            End While
            If deleted <= 0 Then
                closeComm()
                Cursor = Cursors.Default
                lblStatus.Text = "Message deleted."
                Exit Do
            End If
            closeComm()
        Loop
    End Sub

    Private Sub rbLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLocal.CheckedChanged
        If rbSIM.Checked = True Then Storage = PhoneStorageType.Sim Else Storage = PhoneStorageType.Phone
    End Sub

    Private Sub rbSIM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSIM.CheckedChanged
        If rbSIM.Checked = True Then Storage = PhoneStorageType.Sim Else Storage = PhoneStorageType.Phone
    End Sub

    Private Sub tmrCount_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCount.Tick
        openComm()
        lblStatus.Text = "Message counts: " & comM.ReadMessages(PhoneMessageStatus.All, Storage).Length
        closeComm()
        tmrCount.Enabled = False
    End Sub

    Private Sub chkCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckAll.CheckedChanged
        chkCheckAll.Text = IIf(chkCheckAll.Text.Contains("Check All"), "&Uncheck All", "&Check All")
        If LV.Items.Count <= 0 Then Exit Sub
        For i As Integer = 0 To LV.Items.Count - 1
            LV.Items(i).Checked = IIf(chkCheckAll.Text.Contains("Check All"), True, False)
        Next
    End Sub

    Private Sub LV_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles LV.ItemCheck
        chkCheckAll.Text = IIf(LV.CheckedItems.Count <= 0, "&Check All", "Uncheck All")
    End Sub

    Sub msgStat(ByVal pd As DecodedShortMessage)
      
    End Sub









    Private Sub comm_MessageReceived(ByVal sender As Object, ByVal e As MessageReceivedEventArgs)
        Try
            Dim storage As String = PhoneStorageType.Sim
            Dim messages() As DecodedShortMessage = comM.ReadMessages(PhoneMessageStatus.ReceivedUnread, storage)
            For Each message As DecodedShortMessage In messages
                Output(String.Format("Message status = {0}, Location = {1}/{2}", message.Storage, message.Index))
                ShowMessage(message.Data)
                Output("")
            Next message
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub ShowException(ByVal ex As Exception)
        Output("Error: " + ex.Message + " (" + ex.GetType().ToString() + ")")
        Output("")
    End Sub

    Private Sub ShowMessage(ByVal pdu As SmsPdu)
        If TypeOf pdu Is SmsSubmitPdu Then
            'Stored (sent/unsent) message
            Dim data As SmsSubmitPdu = CType(pdu, SmsSubmitPdu)
            Output("SENT/UNSENT MESSAGE")
            Output("Recipient: " + data.DestinationAddress)
            Output("Message text: " + data.UserDataText)
            Output("-------------------------------------------------------------------")
            Exit Sub
        End If
        If TypeOf pdu Is SmsDeliverPdu Then
            'Received message
            Dim data As SmsDeliverPdu = CType(pdu, SmsDeliverPdu)
            Output("RECEIVED MESSAGE")
            Output("Sender: " + data.OriginatingAddress)
            Output("Sent: " + data.SCTimestamp.ToString())
            Output("Message text: " + data.UserDataText)
            Output("-------------------------------------------------------------------")
            Exit Sub
        End If
        If TypeOf pdu Is SmsStatusReportPdu Then
            'Status report
            Dim data As SmsStatusReportPdu = CType(pdu, SmsStatusReportPdu)
            Output("STATUS REPORT")
            Output("Recipient: " + data.RecipientAddress)
            Output("Status: " + data.Status.ToString())
            Output("Timestamp: " + data.DischargeTime.ToString())
            Output("Message ref: " + data.MessageReference.ToString())
            Output("-------------------------------------------------------------------")
            Exit Sub
        End If
        Output("Unknown message type: " + pdu.GetType().ToString())
    End Sub

    Private Sub Output(ByVal text As String)
        'If text is outputted from a different thread, invoke the sub again from the UI thread
        txtContent.Text = text

        'If lblStatus.InvokeRequired Then
        'Dim stc As SetTextCallback = New SetTextCallback(AddressOf Output)
        'Dim args() As Object = {text}
        'lblStatus.Invoke(stc, args)
        'Else
        'lblStatus.AppendText(text)
        'lblStatus.AppendText(Environment.NewLine)
        'End If
    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub
End Class