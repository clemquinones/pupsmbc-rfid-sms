Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources
Public Class frmStudViewDetails

    Private Sub frmStudentProfile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmStudentProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2) - (Me.Width / 2), 88)
        Me.Height = 229
        llblViewLogs.Text = "View log records"
    End Sub


    Public Sub viewLV()
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select ID,logstate,datetime from tblemonitoringlogs where rfidtagid='" & getVal("tblestudent", "rfidtagid", "studno='" & Me.Tag & "'") & "' order by datetime desc")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(getDateTime(dR.Item(2), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Next
        dR.Close()
        lblRecCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub llblViewLogs_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblViewLogs.LinkClicked
        If llblViewLogs.Text.Contains("View") Then
            llblViewLogs.Text = "Hide records" : viewLV()
            Me.Height = 570
        Else
            Me.Height = 229 : llblViewLogs.Text = "View log records"
        End If
    End Sub

    Private Sub llblRefresh_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRefresh.LinkClicked
        viewLV()
    End Sub

    Private Sub llblSendMessage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblSendMessage.LinkClicked
        If MB("Send Message to " & lblStudNo.Text & " | " & lblName.Text & "?", "?") = "n" Then Return
        frmCreateMessage.Tag = getVal("tblestudent", "number", "studno='" & lblStudNo.Text & "'")
        Me.Hide() : frmCreateMessage.ShowDialog() : Me.Show()
    End Sub

    Private Sub llblUpdateInfo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblUpdateInfo.LinkClicked
        If MB("Update student info?", "?") = "n" Then Return
        Me.Hide() : viewUpdateStud(lblStudNo.Text) : Me.Show()
    End Sub

    Private Sub pbPic_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPic.MouseClick
        If MB("Send Message to " & lblStudNo.Text & " | " & lblName.Text & "?", "?") = "n" Then Return
        frmCreateMessage.Tag = getVal("tblestudent", "number", "studno='" & lblStudNo.Text & "'")
        Me.Hide() : frmCreateMessage.ShowDialog() : Me.Show()
    End Sub
End Class