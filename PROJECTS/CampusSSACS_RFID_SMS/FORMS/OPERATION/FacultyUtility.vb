Imports MySql.Data.MySqlClient
Public Class frmFacultyUtility
    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        btnSendMessage.Enabled = IIf(LV.SelectedItems.Count > 0, True, False)
    End Sub

    Private Sub btnSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMessage.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return Else showCreateMessage(LV.SelectedItems(0).Text, "id", "tblefacultyutility")
    End Sub

    Private Sub frmFacultyUtility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub


    Sub viewLV()
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySqlDataReader = DataReader("select id,fname,mname,lname,field,number from tblefacultyutility order by field")
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & " " & dR.Item(2) & " " & dR.Item(3))
            li.SubItems.Add(dR.Item(4))
            li.SubItems.Add(dR.Item(5))
        Next
        dR.Close()
        lblCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Sounds(AUDIO.CLICK)
        If LV.Items.Count <= 0 Then MB("Unable to generate report with empty records!", "!") : Return
        If MB("Do you want to generate report?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor
        ViewReport(RPT.FACULTYUTILITY)
        Cursor = Cursors.Default
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUpdate.Click
        frmFacultyUtilityEncode.Show()
        viewLV()
    End Sub
 
End Class