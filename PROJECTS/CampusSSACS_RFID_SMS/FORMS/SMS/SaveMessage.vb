Imports MySql.Data.MySqlClient
Public Class frmSaveMessage


    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count <= 0 Then lblContent.Text = "Message count: " & LV.Items.Count : Return
        On Error Resume Next
        lblContent.Text = getVal("tblesms", "message", "smstype like '%UnSent%' and id=" & LV.Items(LV.SelectedIndices(0)).Text)
    End Sub

    Public Sub viewLV()
        'id recipient message datetime copy
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,usernum,message,datetime from tblesms where smstype like 'UnSent' order by datetime desc")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblContent.Text = "Message count: " & LV.Items.Count
    End Sub

    Private Sub frmSaveMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSaveMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        On Error Resume Next
        If MB("Do you want to delete selected record?", "?") = "n" Then Return
        DELETEr("tblesms", "id=" & LV.Items(LV.SelectedIndices(0)).Text)
        LOGS("Delete message. Message ID: " & LV.Items(LV.SelectedIndices(0)).Text)
        LV.Items.RemoveAt(LV.SelectedIndices(0))
        LV.Select()
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedItems.Count <= 0 Then Return
        If MB("Do you want to delete all unsent message?", "?") = "n" Then Return
        On Error Resume Next
        eSQL("insert into tblesms2 select * from tblesms where id=" & LV.SelectedItems(0).Text)
        DELETEr("tblesms", "id=" & LV.SelectedItems(0).Text)
        LOGS("Deletes all saved messages. Message count: " & LV.Items.Count)
        viewLV()
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        On Error Resume Next
        With frmCreateMessage
            .Show()
            .txtMessage.Text = LV.Items(LV.SelectedIndices(0)).SubItems(2).Text
            .txtSendCopy.Text = LV.Items(LV.SelectedIndices(0)).SubItems(4).Text
            Dim Rec As String = LV.Items(LV.SelectedIndices(0)).SubItems(1).Text
            Dim li As New ListViewItem
            For Each item As String In Rec.Split(";")
                If Not item.Trim = "" And Split(item, "|").Length = 2 Then
                    li = .LV.Items.Add(item.Split("|")(0).Trim)
                    li.SubItems.Add(item.Split("|")(1).Trim)
                End If
            Next
        End With
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub
End Class