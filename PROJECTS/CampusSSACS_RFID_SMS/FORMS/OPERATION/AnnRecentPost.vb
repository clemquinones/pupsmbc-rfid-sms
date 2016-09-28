Imports MySql.Data.MySqlClient
Public Class frmRecentPost

    Private Sub frmRecentPost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmRecentPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Public Sub viewLV()
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select startdatetime,message from tbleannouncement order by startdatetime  desc")
        If Not dR.Read Then CONNclose() : Return
        Dim li As New ListViewItem
        Do
            li = LV.Items.Add(getDateTime(dR.Item(0), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
            li.SubItems.Add(dR.Item(1))
        Loop While dR.Read
        dR.Close()
    End Sub

    Private Sub llblClear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblClear.LinkClicked
        Sounds(AUDIO.CLICK)
        If MB("Are you sure you want to clear all read history of posted announcement?", "?") = "n" Then Return
        If AdminPass() Then DELETEr("tbleannouncement")
        viewLV()
    End Sub

 

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedIndices.Count <= 0 Then Return
        If MB("Do you wish to remove this announcement from the list?", "?") = "n" Then Return
        On Error Resume Next
        DELETEr("tbleannouncement", "message like '%" & LV.Items(LV.SelectedIndices(0)).SubItems(1).Text & "%'")
        MB("Removed!")
        LV.Items.RemoveAt(LV.SelectedIndices(0))
        txtContent.Text = ""
    End Sub

    Private Sub btnRepost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepost.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedIndices.Count <= 0 Then MB("No announcement is selected") : Return
        If MB("Are you sure?..", "?") = "n" Then Return
        frmAnnouncement.txtMessage.Text = txtContent.Text
        Me.Close()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count <= 0 Then Return
        txtContent.Text = LV.Items(LV.SelectedIndices(0)).SubItems(1).Text
    End Sub
End Class