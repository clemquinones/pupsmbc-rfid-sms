Imports MySql.Data.MySqlClient
Public Class frmSelectPC
    Private Sub frmSelectPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub
    Sub viewLV()
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select name,userid,online from tbleclient")
        For Each item As Object In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
        Next
        dR.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If NoSelected(LV) Then Return
        If MB("Do you want to choose this client?", "?") = "n" Then Return
        UPDATEr("tbleclient", "userid='" & logID & "'", "name='" & LV.SelectedItems(0).Text & "'")
        Me.Close()
    End Sub
End Class