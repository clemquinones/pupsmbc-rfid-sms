Imports MySql.Data.MySqlClient
Public Class frmDepartment

    Public Sub viewLV(Optional ByVal sql As String = "select code,description from tblecodedesc where field='Course' order by code")
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader(sql)
        While dR.Read
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add("0")
        End While
        dR.Close()
        For i As Integer = 0 To LV.Items.Count - 1
            LV.Items(i).SubItems(2).Text = recCount("tblestudent", "course like '%" & LV.Items(i).Text & "%'")
        Next
        lblReCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub llblView_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblView.LinkClicked
        Sounds(AUDIO.CLICK)
        If LV.SelectedItems.Count <= 0 Then Return
        On Error Resume Next
        frmStudentCounts.Tag = LV.SelectedItems(0).Text
        frmStudentCounts.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, Button2.Click
        Sounds(AUDIO.CLICK)
        frmDeptAddEdit.Tag = "Add" : frmDeptAddEdit.ShowDialog()
        viewLV()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, Button1.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then MB("Select department to update!") : Return
        On Error Resume Next
        frmDeptAddEdit.Tag = "Edit"
        frmDeptAddEdit.txtYear.Text = getVal("tblecodedesc", "year", "code like '%" & LV.Items(LV.SelectedIndices(0)).Text & "%' and field like '%Course%'")
        frmDeptAddEdit.txtCode.Text = LV.SelectedItems(0).Text
        frmDeptAddEdit.txtDescription.Text = LV.SelectedItems(0).SubItems(1).Text
        frmDeptAddEdit.ShowDialog() : viewLV()
    End Sub

    Private Sub frmDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click, Button4.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click, Button3.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate a report for department list?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor : ViewReport(RPT.DEPARTMENT) : Cursor = Cursors.Default
    End Sub

    Private Sub cmsDept_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsDept.Opening
        tsmUpdate.Enabled = IIf(LV.SelectedItems.Count <= 0, False, True)
        tsmList.Enabled = IIf(LV.SelectedItems.Count <= 0, False, True)
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        llblView.Enabled = IIf(LV.SelectedItems.Count <= 0, False, True)
        btnEdit.Enabled = llblView.Enabled
    End Sub

    Private Sub tsmUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUpdate.Click
        If LV.SelectedItems.Count <= 0 Then Return
        Call btnEdit_Click(sender, e)
    End Sub

    Private Sub tsmList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmList.Click
        If LV.SelectedItems.Count <= 0 Then Return
        On Error Resume Next
        frmStudentCounts.Tag = LV.SelectedItems(0).Text
        frmStudentCounts.Show()
    End Sub

    Private Sub tsmReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmReport.Click
        Call btnPrint_Click(sender, e)
    End Sub

    Private Sub llblRefresh_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRefresh.LinkClicked
        viewLV()
        Me.Refresh()
    End Sub
End Class