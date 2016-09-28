﻿Imports MySql.Data.MySqlClient
Public Class frmConnectionSetup
    Dim connecteD As Boolean = False 
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        lblStatus.Text = "Status: NOT CONNECTED"
        txtDataSource.Text.ToLower() : If txtDataSource.Text.Trim = "" Then MB("Enter data source!", "!") : toHL(txtDataSource) : Exit Sub
        txtUserID.Text.ToLower() : If txtUserID.Text.Trim = "" Then MB("Enter user id!", "!") : toHL(txtUserID) : Exit Sub
        txtDatabase.Text.ToLower() : If txtDatabase.Text.Trim = "" Then MB("Enter database!", "!") : toHL(txtDatabase) : Exit Sub
        Try
            connecteD = False
            conN = New MySqlConnection("data source=" & txtDataSource.Text.Trim.ToLower & "; user id=" & txtUserID.Text.Trim.ToLower & "; password=; database=" & txtDatabase.Text.Trim.ToLower & ";")
            If conN.State = ConnectionState.Closed Then conN.Open()
            Dim CMDtest As New MySqlCommand("select * from  tbleid  where format like '%CD3RKingsRoxPat%' and value=1")
            CMDtest.Connection = conN
            Cursor = Cursors.Default
            Try
                Dim mdR As MySqlDataReader = CMDtest.ExecuteReader
                DataSource = txtDataSource.Text.Trim.ToLower
                dbUserID = txtUserID.Text.Trim.ToLower
                dbPassword = txtPassword.Text
                DB = txtDatabase.Text.Trim.ToLower.ToLower
                connecteD = True : lblStatus.Text = "Status: CONNECTED"
                MB("Successfully connected to " & DataSource & ".")
                gbLocalMachine.Enabled = True
                mdR.Close()
            Catch ex As Exception
                MB(DB & vbCr & vbCr & "Wrong database!", "x") : toHL(txtDatabase): Return
            End Try
            If conN.State = ConnectionState.Open Then conN.Close()
        Catch ex As Exception
            Cursor = Cursors.Default
            MB(ex.Message) : Return
        End Try
    End Sub

    Private Sub txtDataSource_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataSource.GotFocus
        toHL(txtDataSource)
    End Sub

    Private Sub txtUserID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserID.GotFocus
        toHL(txtUserID)
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        toHL(txtPassword)
    End Sub

    Private Sub txtDatabase_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDatabase.GotFocus
        toHL(txtDatabase)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text.Contains("Finish Settings") Then Me.Close() : Return
        Cursor = Cursors.WaitCursor
        If connecteD = False Then MB("Connection Setup Information not yet gathered.", "!") : toHL(txtDataSource) : Cursor = Cursors.Default : Exit Sub
        If MB("Are you sure you want to  set  this  machine as " & IIf(rbServer.Checked, "server", "client") & "?", "?") = "n" Then Cursor = Cursors.Default : Exit Sub
        Write("[MACHINE]", IIf(rbServer.Checked, "Server", "Client"))
        Write("[PCNAME]", Environ("ComputerName"))
        Write("[PCMONITOR]", "LOG IN")
        Write("[DATASOURCE]", DataSource)
        Write("[USERID]", dbUserID)
        Write("[PASSWORD]", dbPassword)
        Write("[DATABASE]", DB)
        Cursor = Cursors.Default
        lblSaved.Show() : btnSave.Text = "&Finish Settings"
        gbConn.Enabled = False : rbClient.Enabled = False : rbServer.Enabled = False
    End Sub

    Private Sub frmConnectionSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If connecteD = False Then End
    End Sub

    Private Sub frmConnectionSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSaved.Hide()
    End Sub

     
End Class