Imports MySql.Data.MySqlClient
Public Class frmBrowseSent

    Private Sub frmBrowseSent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Call btnCancel_Click(sender, e)
    End Sub

    Private Sub frmBrowseSent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub
    Public Sub viewLV()
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select id,usernum,type,message,datetime from tblesms where smstype !='ToSent' and smstype like '%Sent' order by id")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(dR.Item(3))
            li.SubItems.Add(getDateTime(dR.Item(4), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        txtContent.Text = "Message count: " & LV.Items.Count
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count <= 0 Then txtContent.Text = "Message count: " & LV.Items.Count : Return
        txtContent.Text = getVal("tblesms", "message", "id=" & LV.SelectedItems(0).Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Tag = "cancel"
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Sounds(AUDIO.CLICK)
        If NoSelected(LV) Then Return
        Me.Tag = txtContent.Text
        Me.Close()
    End Sub


End Class