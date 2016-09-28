Imports MySql.Data.MySqlClient
Public Class frmKeywordsSMS

    Private Sub frmKeywordsSMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub txtKeyword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyword.GotFocus
        TextClicked(txtKeyword, "Keyword") : txtKeyword.ForeColor = Color.Black
    End Sub

    Private Sub txtKeyword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyword.LostFocus
        txtKeyword.ForeColor = Color.Gray
        If txtKeyword.Text.Trim = "" Or txtKeyword.Text.Trim.ToLower = "keyword" Then txtKeyword.Text = "Keyword"
    End Sub


    Private Sub txtKeyword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeyword.TextChanged

    End Sub

    Public Sub viewLV()
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select description,keyword from tblesmscommand")
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
        Next
        dR.Close() : lblCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub frmKeywordsSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count < 0 Or LV.Items.Count < 0 Then lblCount.Text = "Keyword" : txtKeyword.Enabled = False : Exit Sub Else txtKeyword.Enabled = True
        On Error Resume Next
        txtKeyword.Text = LV.Items(LV.SelectedIndices(0)).SubItems(1).Text
        gbKeyword.Text = LV.Items(LV.SelectedIndices(0)).Text
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Sounds(AUDIO.CLICK)
        If txtKeyword.Text.Trim = "" Or txtKeyword.Text.Trim.ToLower = "keyword" Then MB("Cannot accept null keyword!", "!") : toHL(txtKeyword) : Return
        If gbKeyword.Text = "Keyword" Then MB("No selected command!", "!") : Return
        If MB("Are you sure?", "?") = "n" Then Return
        On Error Resume Next
        UPDATEr("tblesmscommand", "keyword='" & txtKeyword.Text.Trim.ToUpper & "'", "description='" & gbKeyword.Text & "'")
        viewLV()
    End Sub
End Class