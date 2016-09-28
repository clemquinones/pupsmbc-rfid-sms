Imports MySql.Data.MySqlClient
Public Class frmStudentList

    Private Sub frmStudentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Sub viewLV(Optional ByVal WHERE As String = " order by course")
        LV.Items.Clear() : Dim d As String = ""
        If cmbDept.Text = "All Department" Or cmbDept.Text.Trim = "" Then d = ""
        d = cmbDept.Text
        Dim dR As MySqlDataReader = DataReader("select studno,lname,fname,mname,course,yearlevel,section,gender from tblestudent where course like '%" & d & "%' " & WHERE)
        For Each item As Object In dR
            LV.Items.Add(dR.Item(0)).SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3)).SubItems.Add(dR.Item(4)).SubItems.Add(dR.Item(5) & "-" & dR.Item(6)).SubItems.Add(dR.Item(7))
        Next
        dR.Close()
        lblCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub tsmExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        txtSearch.ForeColor = Color.Black : TextClicked(txtSearch, "Search") : lblTip.Show()
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.DimGray : If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search" Then txtSearch.Text = "Search" : lblTip.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        txtSearch.Text = LTrim(txtSearch.Text)
        If txtSearch.Text.Trim = "" Or txtSearch.Text.Trim.ToLower = "search" Then viewLV() : Return
        Dim k As String = txtSearch.Text.Trim
        Dim n As Boolean = IIf(IsNumeric(k), 1, 0)
        viewLV(" and studno like '%" & k & "%' or lname like '%" & k & "%' or fname like '%" & k & "%' or mname like '%" & k & "%' or course like '%" & k & "%'" & IIf(n, " or yearlevel=" & k, "") & IIf(n, " or section=" & k, "") & " or gender like '%" & k & "%' order by course")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class