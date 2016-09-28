Imports MySql.Data.MySqlClient
Imports PUPSMBCSSMS_CLIENT.My.Resources
Public Class frmStudentProfile

    Private Sub frmStudentProfile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then Me.Close()
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
        For Each item As Object In dR
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

End Class