Imports MySql.Data.MySqlClient
Public Class frmExpiredMessages
    Dim ed As String = "date_format(sysdate(),'%Y/%m/%d 00:00:01')"
    Private Sub frmExpiredMessages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLog() : viewAnn() : viewAnonym()

    End Sub

    Sub viewLog()
        'id,usernum,message,datetime
        Dim li As New ListViewItem : LVLogs.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,usernum,message,datetime from tblesms where smstype = 'Logs' and expirydatetime < " & ed & "order by id")
        For Each item In dR
            li = LVLogs.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblLogs.Text = "Message count: " & LVLogs.Items.Count
    End Sub
    Sub viewAnn() 'id parent/stud usernum message datetime
        Dim li As New ListViewItem : LVAnn.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,rectype,usernum,message,datetime from tblesms where smstype = 'Announcement' and expirydatetime < " & ed & " order by id")
        For Each item In dR
            li = LVAnn.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(dR.Item(3))
            li.SubItems.Add(getDateTime(dR.Item(4), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblAnn.Text = "Message count: " & LVAnn.Items.Count
    End Sub
    Sub viewAnonym() 'id parent/stud/* usernum message daetime
        Dim li As New ListViewItem : LVAnonym.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,rectype,usernum,message,datetime from tblesms where smstype = 'ToSent' and expirydatetime < " & ed & " order by id")
        For Each item In dR
            li = LVAnonym.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(dR.Item(3))
            li.SubItems.Add(getDateTime(dR.Item(4), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblAnonym.Text = "Message count: " & LVAnonym.Items.Count
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        viewLog() : viewAnn() : viewAnonym()
    End Sub

    Private Sub LVLogs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVLogs.SelectedIndexChanged
        If LVLogs.SelectedItems.Count <= 0 Then lblLogs.Text = "Message count: " & LVLogs.Items.Count : Return
        On Error Resume Next
        lblLogs.Text = LVLogs.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub LVAnn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVAnn.SelectedIndexChanged
        If LVAnn.SelectedItems.Count <= 0 Then lblAnn.Text = "Message count: " & LVAnn.Items.Count : Return
        On Error Resume Next
        lblLogs.Text = LVLogs.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub LVAnonym_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVAnonym.SelectedIndexChanged
        If LVAnonym.SelectedItems.Count <= 0 Then lblAnonym.Text = "Message count: " & LVAnonym.Items.Count : Return
        On Error Resume Next
        lblLogs.Text = LVAnonym.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub btnLogReSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogReSend.Click
        If LVLogs.Items.Count <= 0 Then Return
        If LVLogs.CheckedItems.Count <= 0 Then MB("No selected item", "!") : Return
        If MB("Do you want to resend selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVLogs.CheckedItems
            UPDATEr("tblesms", "expirydatetime=date_format(sysdate(),'%Y/%m/%d 23:59:59')", "id=" & item.Text)
        Next
        viewLog()
        MB("Message successfully queued.")
    End Sub

    Private Sub btnAnnReSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnReSent.Click
        If LVAnn.Items.Count <= 0 Then Return
        If LVAnn.CheckedItems.Count <= 0 Then MB("No selected item", "!") : Return
        If MB("Do you want to resend selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVAnn.CheckedItems
            UPDATEr("tblesms", "expirydatetime=date_format(sysdate(),'%Y/%m/%d 23:59:59')", "id=" & item.Text)
        Next
        viewAnn()
        MB("Message successfully queued.")
    End Sub

    Private Sub btnAnonymReSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnonymReSend.Click
        If LVAnonym.Items.Count <= 0 Then Return
        If LVAnonym.CheckedItems.Count <= 0 Then MB("No selected item", "!") : Return
        If MB("Do you want to resend selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVAnonym.CheckedItems
            UPDATEr("tblesms", "expirydatetime=date_format(sysdate(),'%Y/%m/%d 23:59:59')", "id=" & item.Text)
        Next
        viewAnonym()
        MB("Message successfully queued.")
    End Sub

    Private Sub chkLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLog.CheckedChanged
        If chkLog.Text = "Check All" Then : chkLog.Text = "Uncheck All"
            For i As Integer = 0 To LVLogs.Items.Count - 1
                LVLogs.Items(i).Checked = True
            Next
        Else : chkLog.Text = "Check All"
            For i As Integer = 0 To LVLogs.Items.Count - 1
                LVLogs.Items(i).Checked = False
            Next
        End If
    End Sub

    Private Sub chkAnn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnn.CheckedChanged
        If chkAnn.Text = "Check All" Then : chkAnn.Text = "Uncheck All"
            For i As Integer = 0 To LVAnn.Items.Count - 1
                LVAnn.Items(i).Checked = True
            Next
        Else : chkAnn.Text = "Check All"
            For i As Integer = 0 To LVAnn.Items.Count - 1
                LVAnn.Items(i).Checked = False
            Next
        End If
    End Sub

    Private Sub chkAnonym_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnonym.CheckedChanged
        If chkAnonym.Text = "Check All" Then : chkAnonym.Text = "Uncheck All"
            For i As Integer = 0 To LVAnonym.Items.Count - 1
                LVAnonym.Items(i).Checked = True
            Next
        Else : chkAnonym.Text = "Check All"
            For i As Integer = 0 To LVAnonym.Items.Count - 1
                LVAnonym.Items(i).Checked = False
            Next
        End If
    End Sub

    Private Sub btnLogDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogDel.Click
        If LVLogs.CheckedItems.Count <= 0 Then Return
        On Error Resume Next
        If MB("[Count: " & LVLogs.CheckedItems.Count & "]" & vbNewLine & "Do you want to delete selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVLogs.CheckedItems
            eSQL("insert into tblesms2 select * from tblesms where id=" & item.Text)
            DELETEr("tblesms", "id=" & item.Text)
        Next
        viewLog()
        MB("Successfully deleted!")
    End Sub

    Private Sub btnAnnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnDel.Click
        If LVAnn.CheckedItems.Count <= 0 Then Return
        On Error Resume Next
        If MB("[Count: " & LVAnn.CheckedItems.Count & "]" & vbNewLine & "Do you want to delete selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVAnn.CheckedItems
            eSQL("insert into tblesms2 select * from tblesms where id=" & item.Text)
            DELETEr("tblesms", "id=" & item.Text)
        Next
        viewAnn()
        MB("Successfully deleted!")
    End Sub

    Private Sub btnAnonymDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnonymDel.Click
        If LVAnonym.CheckedItems.Count <= 0 Then Return
        On Error Resume Next
        If MB("[Count: " & LVAnonym.CheckedItems.Count & "]" & vbNewLine & "Do you want to delete selected message(s)?", "?") = "n" Then Return
        For Each item As ListViewItem In LVAnonym.CheckedItems
            eSQL("insert into tblesms2 select * from tblesms where id=" & item.Text)
            DELETEr("tblesms", "id=" & item.Text)
        Next
        viewAnonym()
        MB("Successfully deleted!")
    End Sub

    Private Sub btnLogDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogDelAll.Click
        If LVLogs.Items.Count <= 0 Then Return
        If MB("Do you really want to delete all expired logs messages?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where smstype = 'Logs' and expirydatetime < " & ed)
        DELETEr("tblesms", "smstype = 'Logs' and expirydatetime < " & ed)
        viewLog() : chkLog.Checked = False
    End Sub

    Private Sub btnAnnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnDelAll.Click
        If LVAnn.Items.Count <= 0 Then Return
        If MB("Do you really want to delete all expired announcement messages?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where smstype like 'Announcement' and expirydatetime < " & ed)
        DELETEr("tblesms", "smstype = 'Announcement' and expirydatetime < " & ed)
        viewAnn() : chkAnn.Checked = False
    End Sub

    Private Sub btnAnonymDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnonymDelAll.Click
        If LVAnonym.Items.Count <= 0 Then Return
        If MB("Do you really want to delete all anonymous messages?", "?") = "n" Then Return
        eSQL("insert into tblesms2 select * from tblesms where smstype = 'ToSent' and expirydatetime < " & ed)
        DELETEr("tblesms", "smstype = 'Announcement' and expirydatetime < " & ed)
        viewAnn() : chkAnn.Checked = False
    End Sub

     
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub
End Class