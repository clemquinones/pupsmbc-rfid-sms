Public Class frmCreateMessage
    'SMS Type: ToSent,UnSent
    'Prompt to save if exiting without sending the message created


    Private Sub btnSendTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBrowseRecipients.ShowDialog()
        Dim Rec As String = frmBrowseRecipients.Tag
        Dim li As New ListViewItem
        For Each item As String In Rec.Split(";")
            If Not item.Trim = "" And Split(item, "|").Length = 2 Then
                li = LV.Items.Add(item.Split("|")(0).Trim)
                li.SubItems.Add(item.Split("|")(1).Trim)
            End If
        Next
    End Sub

    Private Sub chkSendCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSendCopy.CheckedChanged
        Sounds(AUDIO.CLICK)
        txtSendCopy.Enabled = chkSendCopy.Checked : If chkSendCopy.Checked = True Then toHL(txtSendCopy)
    End Sub

    Private Sub txtRecipients_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecipients.GotFocus
        txtRecipients.ForeColor = Color.Black : TextClicked(txtRecipients, "Recipient")
    End Sub

    Sub addRec(Optional ByVal HasTag As Boolean = False)
        Dim Rec As String = IIf(HasTag = True, Me.Tag, txtRecipients.Text.Trim)
        If Not IsNumeric(Rec) Then MB("Invalid phone number!", "!") : toHL(txtRecipients) : Return
        Dim li As New ListViewItem
        If recCount("tblestudent", "number='" & Rec & "'") > 0 Then
            li = LV.Items.Add(getVal("tblestudent", "studno", "number='" & Rec & "'"))
            li.SubItems.Add(Rec)
            li.SubItems.Add("Student")
        ElseIf recCount("tbleparentinfo", "number='" & Rec & "'") > 0 Then
            li = LV.Items.Add(getVal("tblestudent s,tbleparentinfo p", "s.studno", "s.rfidtagid=p.rfidtagid and p.number='" & Rec & "'"))
            li.SubItems.Add(Rec)
            li.SubItems.Add("Parent")
        ElseIf recCount("tblefacultyutility", "number='" & Rec & "'") > 0 Then
            li = LV.Items.Add(getVal("tblefacultyutility", "id", "number='" & Rec & "'"))
            li.SubItems.Add(Rec)
            li.SubItems.Add(getVal("tblefacultyutility", "field", "number='" & Rec & "'"))
        Else
            li = LV.Items.Add("*****")
            li.SubItems.Add(Rec)
            li.SubItems.Add("Anonymous")
        End If
        txtRecipients.Text = "" : toHL(txtRecipients)
    End Sub

    Private Sub txtRecipients_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRecipients.KeyDown
        If e.KeyCode = Keys.Enter Then addRec()
    End Sub

    Private Sub txtRecipients_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecipients.LostFocus
        txtRecipients.ForeColor = Color.Gray : If txtRecipients.Text.Trim.ToLower Like "recipients" Or txtRecipients.Text.Trim = "" Then txtRecipients.Text = "Recipient"
    End Sub

#Region "RESET"
    Public Sub RESET()
        LV.Items.Clear()
        txtMessage.Text = "Type your message here..."
        If Me.Tag <> "" Then addRec(True) Else txtRecipients.Text = "Recipient"
        txtSendCopy.Text = "1"

        chkSendCopy.Checked = False
        chkAlert.Checked = False
        chkUnicode.Checked = False
        btnSend.Tag = False
        btnSave.Tag = False
        btnCancel.Tag = False
    End Sub
#End Region

    Private Sub frmCreateMessage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' If btnSend.Tag = False And btnSave.Tag = False And btnSend.Tag = False Then Call btnCancel_Click(sender, e)
    End Sub

    Private Sub frmCreateMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmCreateMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'AssignConnection()
        RESET()
    End Sub

    Private Sub txtSendCopy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSendCopy.LostFocus
        If txtSendCopy.Text.Trim = "" Then txtSendCopy.Text = "1" : Return
        If Not IsNumeric(txtSendCopy.Text.Trim) Then MB("Invalid send copy value." & vbCr & vbCr & "It must me a number!", "!") : toHL(txtSendCopy) : Return
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedItems.Count <= 0 Or LV.Items.Count <= 0 Then Return
        On Error Resume Next
        LV.Items.Remove(LV.SelectedItems(0))
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then Return
        If MB("Remove all recipients?", "?") = "n" Then Return
        On Error Resume Next
        LV.Items.Clear() : txtRecipients.Text = "Recipient"
    End Sub

    Private Sub txtMessage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.GotFocus
        txtMessage.ForeColor = Color.Black : TextClicked(txtMessage, "Type your message here...")
    End Sub

    Private Sub txtMessage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.LostFocus
        txtMessage.ForeColor = Color.Gray
        If txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.Trim.ToLower Like "Type your message here..." Then txtMessage.Text = "Type your message here..."
    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        lblRemaining.Text = "Remaining characters (" & IIf((2048 - txtMessage.Text.Length) <= 0, "2048", 2048 - txtMessage.Text.Length) & "/2048)"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Sounds(AUDIO.CLICK)
        If btnCancel.Tag = True Then GoTo SAVING

        If btnSave.Tag = True Then MB("Unable to duplicate save messages.") : Return

        If txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.ToLower.ToString = "type your message here..." Then MB("Unable to save empty message!") : toHL(txtMessage) : Return
        If LV.Items.Count <= 0 And (txtRecipients.Text.Trim = "" Or txtRecipients.Text.Trim.ToLower.Contains("recipient")) Then MB("Cannot accept null recipients") : toHL(txtRecipients) : Return
        If chkSendCopy.Checked = True And Not IsNumeric(txtSendCopy.Text.Trim) Then MB("Invalid send copy value." & vbCr & vbCr & "It must be number!", "!") : toHL(txtSendCopy) : Return

        If MB("Do you want to save?", "?") = "n" Then Return
SAVING:
        Dim SendCopy As Integer = IIf(chkSendCopy.Checked = True, CInt(txtSendCopy.Text.Trim), 1)
        Dim Message As String = txtMessage.Text
        Dim Alert As Boolean = chkAlert.Checked, UniCode As Boolean = chkUnicode.Checked

        For Each item As ListViewItem In LV.Items
            INSERTr("tblesms", gIDVal("Message", True) & ",'UnSent','" & item.SubItems(1).Text & "','" & item.Text & "','" & item.SubItems(2).Text & "','" & _
                    Message & "',sysdate(),sysdate()," & SendCopy & "," & Alert & "," & UniCode)
            incrementID("Message")
        Next

        MB("Saved!") : btnSave.Tag = True
        Me.Close()
    End Sub

    Public MsgClosing As Boolean = False, Saved As Boolean = False
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        btnCancel.Tag = True
        If btnSave.Tag = False Then If MB("Do you want to save unsent messages?", "?") = "y" Then Call btnSave_Click(sender, e) : Return
        Me.Close()
     End Sub

    Private Sub llblFromFile_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblFromFile.LinkClicked
        Sounds(AUDIO.CLICK)
        Try
            Dim ofdTxtFile As New OpenFileDialog
            ofdTxtFile.Filter = "Text File (*.txt;*.csv;*.doc;*.docx)|*.txt;*.csv;*.doc;*.docx| All files(*.*)|*.*"
            If ofdTxtFile.ShowDialog = Windows.Forms.DialogResult.OK Then txtMessage.Text = IO.File.ReadAllText(ofdTxtFile.FileName)
        Catch ex As Exception
            MB(ex.Message)
        End Try
    End Sub

    Private Sub llblFromSent_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblFromSent.LinkClicked
        Sounds(AUDIO.CLICK)
        If recCount("tblesms", "smstype like '%Sent' and smstype not like 'ToSent'") <= 0 Then MB("Sent Box is empty!") : Return
        frmBrowseSent.ShowDialog()
        If Not frmBrowseSent.Tag = "cancel" Then txtMessage.Text = frmBrowseSent.Tag
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Sounds(AUDIO.CLICK)
        btnSend.Tag = True
        If LV.Items.Count <= 0 And (txtRecipients.Text.Trim = "" Or txtRecipients.Text.Trim.ToLower.Contains("recipient")) Then MB("Cannot accept null recipients") : toHL(txtRecipients) : Return
        If chkSendCopy.Checked = True And Not IsNumeric(txtSendCopy.Text.Trim) Then MB("Invalid send copy value." & vbCr & vbCr & "It must be number!", "!") : toHL(txtSendCopy) : Return

        If MB("Messages will be on-queued." & vbCr & vbCr & "Do you want to proceed?", "?") = "n" Then Return
        
        Dim SendCopy As Integer = IIf(chkSendCopy.Checked = True, CInt(txtSendCopy.Text.Trim), 1)
        Dim Message As String = IIf(txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.ToLower.ToString = "type your message here...", "", txtMessage.Text)
        Dim Alert As Boolean = chkAlert.Checked, UniCode As Boolean = chkUnicode.Checked

        For Each item As ListViewItem In LV.Items
            INSERTr("tblesms", gIDVal("Message", True) & ",'ToSent','" & item.SubItems(1).Text & "','" & item.Text & "','" & item.SubItems(2).Text & "','" & _
                    Message & "',sysdate(),concat(current_date(),' 23:59:59')," & SendCopy & "," & Alert & "," & UniCode)
            incrementID("Message")
        Next
        nSending.ShowBalloonTip(5000, "Message queued.", "Your message is successfully queued on the message list.", ToolTipIcon.Info)
        Me.Close()
    End Sub

    Private Sub tmrEnding_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnding.Tick
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Sounds(AUDIO.CLICK)
        frmBrowseRecipients.ShowDialog()
        If frmBrowseRecipients.Tag = "" Then Return

        Dim li As New ListViewItem
        For Each item As String In Split(frmBrowseRecipients.Tag, ";") 'id,num,type
            item = item.Trim
            If Not item = "" And Not item = Nothing Then
                li = LV.Items.Add(item.Split("|")(0))
                li.SubItems.Add(item.Split("|")(1))
                li.SubItems.Add(item.Split("|")(2))
            End If
        Next
    End Sub

    Private Sub txtRecipients_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecipients.TextChanged

    End Sub
 

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        addRec()
    End Sub
End Class