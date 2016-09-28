Imports MySql.Data.MySqlClient
Public Class frmRecordsAchive
    'GB SIZE: 757, 403
    Dim ButtonClicked As String = ""

    Private Sub frmRecordsAchive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmRecordsAchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Hide() : frmAdminPass.ShowDialog() : If Not frmAdminPass.Tag = "OK" Then Me.Close() Else Me.Show()
        ButtonClicked = btnSystem.Name : viewLV()
    End Sub


    Public Sub viewLV(Optional ByVal sql As String = "")
        LV.Items.Clear() : Dim li As New ListViewItem
        Try
            Dim dR As MySqlDataReader = Nothing
            If ButtonClicked = btnSystem.Name Then : lblTitle.Text = "System monitoring logs"
                LV.Columns(0).Text = "ID" : LV.Columns(1).Text = "User Type" : LV.Columns(2).Text = "Action" : LV.Columns(3).Text = "Date/Time"
                dR = DataReader(IIf(sql = "", "select id,logusertype,action,datetime from tblemonitoring2 order by id", sql))
            ElseIf ButtonClicked = btnStudent.Name Then : lblTitle.Text = "Student monitorng logs"
                LV.Columns(0).Text = "ID" : LV.Columns(1).Text = "Student Number" : LV.Columns(2).Text = "Log type" : LV.Columns(3).Text = "Date/Time"
                dR = DataReader(IIf(sql = "", "select tblemonitoringlogs2.id,tblestudent.studno,tblemonitoringlogs2.logstate,tblemonitoringlogs2.datetime from tblestudent,tblemonitoringlogs2 where tblestudent.rfidtagid=tblemonitoringlogs2.rfidtagid order by id", sql))
            ElseIf ButtonClicked = btnMessage.Name Then : lblTitle.Text = "Deleted messages"
                LV.Columns(0).Text = "ID" : LV.Columns(1).Text = "User Number" : LV.Columns(2).Text = "Message" : LV.Columns(3).Text = "Date/Time"
                dR = DataReader(IIf(sql = "", "select id,smstype,usernum,message,datetime from tblesms2 order by id", sql)) : GoTo MESSAGE
            ElseIf ButtonClicked = btnAnnouncement.Name Then : lblTitle.Text = "Deleted Announcement"
                LV.Columns(0).Text = "ID" : LV.Columns(1).Text = "Announcement" : LV.Columns(2).Text = "Start Date/Time" : LV.Columns(3).Text = "End Date/Time"
                dR = DataReader(IIf(sql = "", "select id,message,startdatetime,enddatetime from tbleannouncement2", sql))
                GoTo ANNOUNCEMENT
            End If

SYSTEM_STUDENT:
            For Each item In dR
                li = LV.Items.Add(dR.Item(0)) : li.SubItems.Add(dR.Item(1)) : li.SubItems.Add(dR.Item(2))
                li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            Next
            dR.Close() : lblReCount.Text = "Record count: " & LV.Items.Count
            Return
MESSAGE:
            For Each item In dR
                Dim SMSType As String = "Anonymous"
                If dR.Item(1).ToString.Contains("ToSent") Then SMSType = "Anonymous"
                If dR.Item(1).ToString.Contains("Announcement") Then SMSType = "Announcement"
                If dR.Item(1).ToString.Contains("Logs") Then SMSType = "Student Logs"
                li = LV.Items.Add(dR.Item(0)) : li.SubItems.Add("[" & dR.Item(1) & "] " & dR.Item(2)) : li.SubItems.Add(dR.Item(3))
                li.SubItems.Add(getDateTime(dR.Item(4), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            Next
            dR.Close() : lblReCount.Text = "Record count: " & LV.Items.Count
            Return
ANNOUNCEMENT:
            For Each item In dR
                li = LV.Items.Add(dR.Item(0)) : li.SubItems.Add(dR.Item(1))
                li.SubItems.Add(getDateTime(dR.Item(2), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
                li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            Next
            dR.Close() : lblReCount.Text = "Record count: " & LV.Items.Count
        Catch ex As Exception
            MB(ex.Message)
        End Try
    End Sub

    Private Sub btnSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystem.Click
        Sounds(AUDIO.CLICK)
        ButtonClicked = btnSystem.Name : viewLV()
    End Sub

    Private Sub btnStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        Sounds(AUDIO.CLICK)
        ButtonClicked = btnStudent.Name : viewLV()
    End Sub

    Private Sub btnMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessage.Click
        Sounds(AUDIO.CLICK)
        ButtonClicked = btnMessage.Name : viewLV()
    End Sub

    Private Sub btnAnnouncement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnouncement.Click
        Sounds(AUDIO.CLICK)
        ButtonClicked = btnAnnouncement.Name : viewLV()
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        lblTip.Show() : TextClicked(txtSearch, "Search")
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        lblTip.Hide() : txtSearch.ForeColor = Color.Gray
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "Search" Then txtSearch.Text = "Search"
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim kw As String = txtSearch.Text.Trim : Dim strSQL As String = ""
        If kw.Trim.ToLower = "search" Then Return
        Try
            If ButtonClicked = btnSystem.Name Then
                strSQL = "select id,logusertype,action,datetime from tblemonitoring2 where " & IIf(Not IsNumeric(kw), "", "id=" & kw & " or") & " logusertype like '%" & kw & "%' or action like '%" & kw & "%' order by id"
            ElseIf ButtonClicked = btnStudent.Name Then
                ' strSQL = "select tblemonitoringlogs2.id,tblestudent.studno,tblemonitoringlogs2.logstate,tblemonitoringlogs2.datetime from tblestudent,tblemonitoringlogs2 where tblestudent.rfidtagid=tblemonitoringlogs2.rfidtagid and " & _
                '     "(tblemonitoringlogs2.id='" & kw & "' or tblestudent.studno like '%" & kw & "%' or tblemonitoringlogs2.logstate like '%" & kw & "%') order by tblemonitoringlogs2.id "
                strSQL = "select m2.id,s.studno,m2.logstate,m2.datetime from tblestudent s,tblemonitoringlogs2 m2 where s.rfidtagid=m2.rfidtagid and (m2.id='" & kw & "' or s.studno like '%" & kw & "%' or m2.logstate like '%" & kw & "%') order by m2.id "
            ElseIf ButtonClicked = btnMessage.Name Then
                strSQL = "select id,smstype,message,usernum,datetime from tblesms2 where " & IIf(Not IsNumeric(kw), "", "id=" & kw & " or") & " smstype like '%" & kw & "%' or usernum like '%" & kw & "%' order by id"
            ElseIf ButtonClicked = btnAnnouncement.Name Then
                strSQL = "select id,message,startdatetime,enddatetime from tbleannouncement2 where " & IIf(Not IsNumeric(kw), "", "id=" & kw & " or") & " message like '%" & kw & "%' order by id"
            Else
                ButtonClicked = btnSystem.Name
            End If
            viewLV(strSQL)
        Catch ex As Exception
            MB(ex.Message)
        End Try

    End Sub

 

    Private Sub chkCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheck.CheckedChanged
        For i As Integer = 0 To LV.Items.Count - 1
            LV.Items(i).Checked = chkCheck.Checked
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Sounds(AUDIO.CLICK)
        viewLV()
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then Return
        If LV.CheckedIndices.Count <= 0 Then MB("No selected item(s) to restore.") : Return
        If MB("Do you want to restore records?", "?") = "n" Then Return
        frmAdminPass.ShowDialog() : If Not frmAdminPass.Tag = "OK" Then Return
        Dim strSQL_INSERT As String = "", strSQL_DELETE As String = ""
        If ButtonClicked = btnSystem.Name Then
            strSQL_INSERT = "insert into tblemonitoring select * from tblemonitoring2"
            strSQL_DELETE = "delete from tblemonitoring2"
        ElseIf ButtonClicked = btnStudent.Name Then
            strSQL_INSERT = "insert into tblemonitoringlogs select * from tblemonitoringlogs2"
            strSQL_DELETE = "delete from tblemonitoringlogs2"
        ElseIf ButtonClicked = btnMessage.Name Then
            strSQL_INSERT = "insert into tblesms select * from tblesms2"
            strSQL_DELETE = "delete from tblesms2"
        ElseIf ButtonClicked = btnAnnouncement.Name Then
            strSQL_INSERT = "insert into tbleannouncement select * from tbleannouncement2"
            strSQL_DELETE = "delete from tbleannouncement2"
        End If

        For Each item As ListViewItem In LV.CheckedItems
            eSQL(strSQL_INSERT & " where id=" & IIf(Not IsNumeric(item.Text), "'" & item.Text & "'", item.Text))
            eSQL(strSQL_DELETE & " where id=" & IIf(Not IsNumeric(item.Text), "'" & item.Text & "'", item.Text))
        Next

        For Each item As ListViewItem In LV.CheckedItems
            LV.Items.Remove(item)
        Next

        '  Dim CItem As New List(Of Integer)
        ' For Each item As Integer In LV.CheckedIndices
        ''.Add(item)
        '   Next
        '  For i As Integer = LV.CheckedIndices.Count - 1 To 0 Step -1
        'LV.Items.RemoveAt(CItem(i))
        '    Next
        viewLV()
        MB("Records successfully restored!")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate report?", "?") = "n" Then Return
        If ButtonClicked = btnSystem.Name Then
            ViewReport(RPT.SYSTEMLOGS, "select m.id as ID, m.loguserid as USERID, m.logusertype as USERTYPE, m.action as ACTION, m.datetime as DATELOG, (select datetime from tblemonitoring2 order by datetime limit 1) as START_DT, (select datetime from tblemonitoring2 order by datetime desc limit 1) as END_DT, '" & InputBox("Enter title/header report for deleted user monitoring: ", "Report", "Deleted User Monitoring Logs") & "' as TITLE from tblemonitoring2 m order by ID")
        ElseIf ButtonClicked = btnStudent.Name Then
            ViewReport(RPT.STUDENTLOG, "select s.studno as SN,concat(s.lname,', ',s.fname,' ',s.mname) as NAME, s.course as COURSE, s.yearlevel as YR, s.section as SC,m.logstate as DETECTION, m.datetime as DATELOG,(select datetime from tblemonitoringlogs2 order by datetime limit 1) as START_DT,(select datetime from tblemonitoringlogs2 order by datetime desc limit 1) as END_DT,'" & InputBox("Enter title/header report for deleted student monitoring: ", "Report", "Deleted Student Monitoring Logs") & "' as TITLE from tblestudent s, tblemonitoringlogs2 m where s.rfidtagid=m.rfidtagid order by m.datetime;")
        End If

    End Sub
End Class