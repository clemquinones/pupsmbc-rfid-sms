Imports MySql.Data.MySqlClient
Public Class frmSentMessage


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        If MB("Do you want to edit this message in create message window?", "?") = "n" Then Return
        Me.Hide()
        frmCreateMessage.Show()
        frmCreateMessage.txtMessage.Text = txtContent.Text
        frmCreateMessage.txtRecipients.Focus()
        Me.Show()
    End Sub

    Private Sub frmSentMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub SentMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignConnection()
        viewLV()
    End Sub

    Public Sub viewLV()
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,usernum,message,datetime,rectype from tblesms where smstype like '%Sent' and smstype not like 'ToSent' order by datetime desc")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            li.SubItems.Add(IIf(dR.Item(4).ToString.Contains("***"), "Unregistered No.", dR.Item(4)))
        Next
        dR.Close()
        If LV.Items.Count > 0 Then txtContent.Text = "Message count: " & LV.Items.Count Else txtContent.Text = "No message."
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Sounds(AUDIO.CLICK)
        viewLV()
    End Sub

    Private Sub btnDrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrop.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        On Error Resume Next
        If MB("Drop message?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where id=" & LV.Items(LV.SelectedIndices(0)).Text)
        DELETEr("tblesms", "smstype = 'Sent' and id=" & LV.Items(LV.SelectedIndices(0)).Text)
        LOGS("Delete sent message. Message ID: " & LV.Items(LV.SelectedIndices(0)).Text)
        LV.Items.RemoveAt(LV.SelectedIndices(0))
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to drop all message?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where smstype = 'Sent'")
        DELETEr("tblesms", "type='Sent'")
        LOGS("Deletes all sent messages. Message count: " & LV.Items.Count)
        viewLV()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count <= 0 Then txtContent.Text = "Message count: " & LV.Items.Count : Return
        On Error Resume Next
        txtContent.Text = getVal("tblesms", "message", "smstype like '%Sent' and smstype not like 'ToSent' and id=" & LV.Items(LV.SelectedIndices(0)).Text)
    End Sub
End Class