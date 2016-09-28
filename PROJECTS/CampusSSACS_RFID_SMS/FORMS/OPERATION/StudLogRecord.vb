Imports MySql.Data.MySqlClient
Public Class frmStudentLogRecord
    Dim Searching As Boolean = False
    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        txtSearch.ForeColor = Color.Black
        TextClicked(txtSearch, "Search")
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.Gray : Searching = False
        If txtSearch.Text.Trim = "" Then txtSearch.Text = "Search"
    End Sub

    Public Sub viewLV(Optional ByVal StrCommand As String = "")
        If cmbSortBy.Text = "Student Number" Then : cmbSortBy.Tag = " order by s.studno"
        ElseIf cmbSortBy.Text = "Name" Then : cmbSortBy.Tag = " order by s.lname"
        ElseIf cmbSortBy.Text = "Log State" Then : cmbSortBy.Tag = " order by m.logstate"
        ElseIf cmbSortBy.Text = "Date/Time" Then : cmbSortBy.Tag = " order by m.datetime desc"
        Else : cmbSortBy.Tag = ""
        End If

        Dim dR As MySqlDataReader = DataReader(IIf(StrCommand.Trim <> "", StrCommand & cmbSortBy.Tag, "select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section,m.logstate,m.datetime from tblestudent s,tblemonitoringlogs m where m.rfidtagid=s.rfidtagid " & cmbSortBy.Tag))
        'If StrCommand = "" Then STRWHERE = ""
        LV.Items.Clear() : Dim li As New ListViewItem
        For Each item In dR
            If Searching And Not (txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search") And LV.Items.Count > 0 Then : Dim meron As Boolean = False
                For i As Integer = 0 To LV.Items.Count - 1
                    If dR.Item(0) = LV.Items(i).Text Then GoTo c
                Next
            End If
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(3) & ", " & dR.Item(1) & " " & dR.Item(2))
            li.SubItems.Add(dR.Item(4))
            li.SubItems.Add(dR.Item(5))
            li.SubItems.Add(dR.Item(6))
            li.SubItems.Add(dR.Item(7))
            li.SubItems.Add(getDateTime(dR.Item(8), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
c:
        Next
        dR.Close()
        lblReCount.Text = "Records count: " & LV.Items.Count
    End Sub

    Private Sub frmStudentLogRecord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmStudentLogRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
        cmbSearchBy.SelectedIndex = 0 : cmbSortBy.SelectedIndex = 3
        Call txtSearch_TextChanged(sender, e)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try : Searching = True
            If cmbSearchBy.Text.Trim = "" Or txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search" Then viewLV() : Return
            '  If Not cmbSearchBy.Items.Contains(cmbSearchBy.Text) Then MB("Unrecognized category!", "!") : cmbSearchBy.SelectedIndex = 0 : toHL(cmbSearchBy) : Return
            Dim Where As String = ""
            If cmbSearchBy.Text Like "Student Number" Then Where = "s.studno like '%" & txtSearch.Text.Trim & "%'"
            If cmbSearchBy.Text Like "Name" Then Where = "s.fname like '%" & txtSearch.Text.Trim & _
                "%' or s.mname like '%" & txtSearch.Text.Trim & "%' or s.lname like '%" & txtSearch.Text.Trim & "%'"
            If cmbSearchBy.Text Like "Log state" Then Where = "m.logstate like '%" & txtSearch.Text.Trim & "%'"
            If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search" Then Where = "1"
            viewLV("select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section,m.logstate,m.datetime from tblestudent s,tblemonitoringlogs m where " & Where & " and m.rfidtagid=s.rfidtagid ")
            '  STRWHERE = " and " & Where & cmbSortBy.Tag
        Catch ex As Exception
            Return
        End Try
    End Sub


    Private Sub rbCourseYrSec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCourseYrSec.CheckedChanged
        Sounds(AUDIO.CLICK)
        If rbCourseYrSec.Checked = True Then frmSearchCourseYrSec.Tag = "studentlogrecord" : frmSearchCourseYrSec.ShowDialog() : rbSearch.Checked = True
    End Sub

    Private Sub rbDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDateRange.CheckedChanged
        Sounds(AUDIO.CLICK)
        If rbDateRange.Checked = True Then frmSearchDateRange.Tag = "studentlogrecord" : frmSearchDateRange.ShowDialog() : rbSearch.Checked = True
    End Sub

    Private Sub cmbSortBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSortBy.TextChanged

    End Sub

    Private Sub cmbSortBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSortBy.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
        txtSearch_TextChanged(sender, e)
    End Sub

    Private Sub llblAlternative_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblAlternative.LinkClicked
        Sounds(AUDIO.CLICK)
        If MB("Do you want to show the advance searching windows?", "?") = "y" Then
            frmSearchStudent.ShowDialog()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        Sounds(AUDIO.CLICK)
        viewLV()
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)

        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate a report for student log records?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor : ViewReport(RPT.STUDENTLOG) : Cursor = Cursors.Default
    End Sub

    Private Sub cmsStudLogs_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsStudLogs.Opening
        If LV.SelectedItems.Count <= 0 Then cmsStudLogs.Enabled = 0 Else cmsStudLogs.Enabled = 1
    End Sub

    Private Sub tsmViewStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmViewStud.Click
        On Error Resume Next
        viewProfile(LV.SelectedItems(0).Text)
    End Sub

    Private Sub tsmEditStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditStud.Click
        On Error Resume Next
        frmEncodeStudInfo.Tag = "Edit" : frmEncodeStudInfo.Tag_STUDNO = LV.SelectedItems(0).Text
        frmEncodeStudInfo.ShowDialog()
    End Sub

    Private Sub tsmSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSendMessage.Click
        On Error Resume Next
        showCreateMessage(LV.SelectedItems(0).Text)
    End Sub

    Private Sub rbSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSearch.CheckedChanged
        Sounds(AUDIO.CLICK)

    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchBy.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class