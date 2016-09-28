Imports MySql.Data.MySqlClient
Public Class frmListParents
    Private Sub frmListParents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub
    Sub viewLV(Optional ByVal sql As String = "")
        LV.Items.Clear() : Dim li As New ListViewItem
        If sql = "" Then sql = "select s.studno,p.fname,p.lname,p.number,if(p.block=false,'ON','OFF') from tbleparentinfo p,tblestudent s where s.rfidtagid=p.rfidtagid"
        Dim dR As MySqlDataReader = DataReader(sql)
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & " " & dR.Item(2))
            li.SubItems.Add(dR.Item(3))
            li.SubItems.Add(dR.Item(4))
        Next
        dR.Close()
        lblCount.Text = "Record count: " & LV.Items.Count
    End Sub


    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count < 0 Then btnSend.Enabled = False Else btnSend.Enabled = True
    End Sub


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedIndices.Count < 0 Then Return
        frmCreateMessage.Tag = LV.Items(LV.SelectedIndices(0)).SubItems(2).Text
        frmCreateMessage.Show()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate a report for the list of parents?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor : ViewReport(RPT.PARENTLIST) : Cursor = Cursors.Default
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        TextClicked(txtSearch, "Search") : txtSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.DimGray : If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search" Then txtSearch.Text = "Search"
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim s As String = txtSearch.Text.Trim
        viewLV(IIf(s = "" Or s.ToLower = "search", "", "select s.studno,p.fname,p.lname,p.number,if(p.block=false,'ON','OFF') from tbleparentinfo p,tblestudent s where s.rfidtagid=p.rfidtagid and (s.studno like '%" & s & "%' or p.fname like '%" & s & "%' or p.lname like '%" & s & "%' or p.number like '%" & s & "%')"))
    End Sub
End Class