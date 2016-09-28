Imports MySql.Data.MySqlClient

Public Class frmStudentsList

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncode.Click
        Sounds(AUDIO.CLICK)
        frmEncodeStudInfo.Tag = "Add"
        frmEncodeStudInfo.Show()
        Me.Close()
    End Sub

    Public Sub viewLV(Optional ByVal sql As String = "select studno,lname,fname,mname,course,yearlevel,section,status,gender from tblestudent order by course")
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader(sql)
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3))
            li.SubItems.Add(dR.Item(4))
            li.SubItems.Add(dR.Item(5))
            li.SubItems.Add(dR.Item(6))
            li.SubItems.Add(dR.Item(7))
            li.SubItems.Add(dR.Item(8))
        Next
        dR.Close()
        lblReCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub frmStudentsList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmStudentsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub llblStudProf_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblStudProf.LinkClicked
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        On Error Resume Next
        viewProfile(LV.SelectedItems(0).Text)
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        llblStudProf.Enabled = IIf(LV.SelectedItems.Count > 0, 1, 0)
        On Error Resume Next
        If LV.SelectedIndices(0) < 0 Then llblStudProf.Hide() Else llblStudProf.Show()
    End Sub

    Private Sub txtRSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRSearch.GotFocus
        lblTip.Show() : txtRSearch.ForeColor = Color.Black
        TextClicked(txtRSearch, "Search")
    End Sub

    Private Sub txtRSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRSearch.LostFocus
        lblTip.Hide() : txtRSearch.ForeColor = Color.Gray
        If txtRSearch.Text.Trim = "" Or txtRSearch.Text.Trim.ToLower = "search" Then txtRSearch.Text = "Search"
    End Sub

    Private Sub txtRSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRSearch.TextChanged
        If txtRSearch.Text.Trim = "" Or txtRSearch.Text.Trim.ToLower = "search" Then viewLV() : Return
        Dim s As String = v(txtRSearch.Text.Trim)
        On Error Resume Next
        viewLV("select studno,lname,fname,mname,course,yearlevel,section from tblestudent where studno like '%" & s & "%' or fname like '%" & s & "%' or mname like '%" & s & "%' or lname like '%" & s & "%'  or course like '%" & s & "%' " & IIf(s = "", "", IIf(Not IsNumeric(s), "", " or yearlevel=" & s & " or secton=" & s)) & " order by course,lname,fname")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate a report?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor
        ViewReport(RPT.STUDENTLIST)
        Cursor = Cursors.Default
    End Sub

    Private Sub btnParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParent.Click
        Sounds(AUDIO.CLICK)
        frmListParents.Show()
    End Sub

    Private Sub cmsStud_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsStud.Opening
        If LV.SelectedItems.Count <= 0 Then tsmEditStud.Enabled = 0 : tsmViewStud.Enabled = 0 : tsmSendMessage.Enabled = 0 Else tsmEditStud.Enabled = 1 : tsmViewStud.Enabled = 1 : tsmSendMessage.Enabled = 1
    End Sub

    Private Sub tsmViewStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmViewStud.Click
        If LV.SelectedItems.Count <= 0 Then Return
        On Error Resume Next
        viewProfile(LV.SelectedItems(0).Text)
    End Sub

    Private Sub tsmEditStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditStud.Click
        If LV.SelectedItems.Count <= 0 Then Return
        On Error Resume Next
        frmEncodeStudInfo.Tag = "Edit" : frmEncodeStudInfo.Tag_STUDNO = LV.SelectedItems(0).Text
        frmEncodeStudInfo.ShowDialog()
    End Sub

    Private Sub tsmSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSendMessage.Click
        If LV.SelectedItems.Count <= 0 Then Return
        On Error Resume Next
        showCreateMessage(LV.SelectedItems(0).Text)
    End Sub

    Private Sub tsmListLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmListLogs.Click
        frmStudentLogRecord.Show()
    End Sub
End Class