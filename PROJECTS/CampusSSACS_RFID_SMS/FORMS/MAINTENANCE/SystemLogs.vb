Imports MySql.Data.MySqlClient
Public Class frmSystemLogs

    Private Sub frmSystemLogs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSystemLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub
    Public Sub viewLV(Optional ByVal WHERE As String = "1")
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select id,logusertype,action,datetime,loguserid from tblemonitoring where " & WHERE & " order by id")
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(getDateTime(dR.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            li.SubItems.Add(dR.Item(4))
        Next
        dR.Close()
        If LV.Items.Count <= 0 Then btnClear.Enabled = False Else btnClear.Enabled = True
        lblCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Sounds(AUDIO.CLICK)
        viewLV()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to clear all read system history?", "?") = "n" Then Return
        If AdminPass() Then
            eSQL("insert into tblemonitoring2 select * from tblemonitoring")
            DELETEr("tblemonitoring") : LOGS("Deletes all system tracks.")
        End If
        viewLV()
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        txtSearch.ForeColor = Color.Black : TextClicked(txtSearch, "Search") : lblTip.Show()
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.Gray : If txtSearch.Text.Trim = "" Then txtSearch.Text = "Search" : lblTip.Hide()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower.Contains("search") Then viewLV() : Return
        viewLV("logusertype like '%" & txtSearch.Text.Trim & "%' or action like '%" & txtSearch.Text.Trim & "%'")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate a report for system users logs?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor : ViewReport(RPT.SYSTEMLOGS) : Cursor = Cursors.Default
    End Sub

End Class