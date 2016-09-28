Imports MySql.Data.MySqlClient
Public Class frmInbox

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Public Sub viewLV()
        'id recipient message datetime type
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,usernum,message,datetime,recid from tblesms where smstype like 'Received%' order by datetime desc")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            li.SubItems.Add(IIf(dR.Item(4).ToString.Contains("***"), "Unregistered No.", dR.Item(4)))
        Next
        dR.Close()
        txtContent.Text = "Message count: " & LV.Items.Count
    End Sub

    Private Sub frmInbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmInbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count <= 0 Then txtContent.Text = "Message count: " & LV.Items.Count : Return
        On Error Resume Next
        txtContent.Text = getVal("tblesms", "message", "smstype like 'Received%' and id=" & LV.Items(LV.SelectedIndices(0)).Text)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        On Error Resume Next
        If MB("Do you want to delete selected item?", "?") = "n" Then Return
        DELETEr("tblesms", "smstype like 'Received%' and id=" & LV.Items(LV.SelectedIndices(0)).Text)
        LOGS("Delete received message. Message ID: " & LV.Items(LV.SelectedIndices(0)).Text)
        LV.Items.RemoveAt(LV.SelectedIndices(0))
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to delete all received message?", "?") = "n" Then Return
        DELETEr("tblesms", "smstype like 'Received%'")
        LOGS("Deletes all received messages. Message count: " & LV.Items.Count & ".")
        LV.Items.Clear()
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        If MB("Do you want to edit this message in create message window?", "?") = "n" Then Return
        On Error Resume Next
        With frmCreateMessage
            .Show()
            .txtMessage.Text = txtContent.Text ' LV.SelectedItems(0).SubItems(2).Text
            .txtSendCopy.Text = "1" 'LV.SelectedItems(0).SubItems(4).Text
            .LV.Items.Clear()
            .txtRecipients.Text = "Recipients"
            'Dim Rec As String = LV.SelectedItems(0).SubItems(1).Text
            'Dim li As New ListViewItem
            'For Each item As String In Rec.Split(";")
            'If Not item.Trim = "" And Split(item, "|").Length = 2 Then
            'li = .LV.Items.Add(item.Split("|")(0).Trim)
            'li.SubItems.Add(item.Split("|")(1).Trim)
            'End If
            'Next
        End With
        Me.Close()
    End Sub

    Private Sub cmsReceivedSMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsReceivedSMS.Opening
        If LV.Items.Count <= 0 Then cmsReceivedSMS.Enabled = False : Return
        If LV.SelectedItems.Count <= 0 Then tsmEdit.Enabled = 0 : tsmForward.Enabled = 0 : tsmDelete.Enabled = 0 : tsmDelAll.Enabled = 1 : Return
    End Sub

    Private Sub tsmEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEdit.Click
        Call btnForward_Click(sender, e)
    End Sub

    Private Sub tsmForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmForward.Click
        Call btnForward_Click(sender, e)
    End Sub

    Private Sub tsmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelete.Click
        Call btnDelete_Click(sender, e)
    End Sub

    Private Sub tsmDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelAll.Click
        Call btnDeleteAll_Click(sender, e)
    End Sub

    Private Sub tsmClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmClose.Click
        Call btnClose_Click(sender, e)
    End Sub
End Class