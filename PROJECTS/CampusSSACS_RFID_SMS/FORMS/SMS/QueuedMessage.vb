Imports MySql.Data.MySqlClient
Public Class frmQueuedMessage

    Public Sub viewLV() 'id rec mess date
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select id,usernum,message,datetime from tblesms where (smstype like '%ToSent%' or smstype='Announcement' or smstype='Logs') and expirydatetime >= sysdate()")
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedItems.Count <= 0 Then Return
        If MB("Delete selected record?", "?") = "n" Then Return
        On Error Resume Next
        eSQL("insert into tblesms2 select * from tblesms where id=" & LV.SelectedItems(0).Text)
        DELETEr("tblesms", "id=" & LV.SelectedItems(0).Text)
        LV.Items.Remove(LV.SelectedItems(0))
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Sounds(AUDIO.CLICK)
        viewLV()
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to delete all messages on-queued?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where (smstype='ToSent' or smstype='Announcement' or smstype='Logs') and expirydatetime >= sysdate()")
        DELETEr("tblesms", "(smstype='ToSent' or smstype='Announcement' or smstype='Logs') and expirydatetime >= sysdate()")
        viewLV()
        MB("Successfully deleted!")
    End Sub

    Private Sub frmQueuedMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count <= 0 Then lblContent.Text = "Message count: " & LV.Items.Count : Return
        On Error Resume Next
        lblContent.Text = LV.SelectedItems(0).SubItems(2).Text
    End Sub
End Class