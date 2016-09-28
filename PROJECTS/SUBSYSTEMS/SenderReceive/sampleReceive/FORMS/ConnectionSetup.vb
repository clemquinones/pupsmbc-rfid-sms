Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter

Public Class frmConnectionSetup
    Public connected As Boolean = False
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If cmbP.Text = "" Then MsgBox("Select available COM-PORT!", MsgBoxStyle.Exclamation) : Exit Sub
        If cmbBR.Text = "" Then MsgBox("Select baud rate!", MsgBoxStyle.Exclamation) : Exit Sub
        If cmbTO.Text = "" Then MsgBox("Select time out!", MsgBoxStyle.Exclamation) : Exit Sub
        Dim ComM As New GsmCommMain(CInt(Replace(cmbP.Text, "COM", "")), CInt(cmbBR.Text), CInt(cmbTO.Text))
        Try
            Cursor = Cursors.WaitCursor
            ComM.Open()
            ComM.Close()
            MsgBox("Port is available!", MsgBoxStyle.Information)
        Catch ex As Exception
            Try
                ComM.Close()
            Catch x As Exception
            End Try
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        connected = Test()
    End Sub
    Function Test() As Boolean
        Test = False
        txtDataSource.Text = txtDataSource.Text.Trim.ToLower
        txtUserID.Text = txtUserID.Text.Trim.ToLower
        txtDatabase.Text = txtDatabase.Text.Trim.ToLower
        Dim coN As MySqlConnection = New MySqlConnection("server=" & txtDataSource.Text & "; user id=" & txtUserID.Text & "; password=" & txtPassword.Text & "; database=" & txtDatabase.Text & ";")
        Try
            Cursor = Cursors.WaitCursor
            lblStatus.Text = "Connecting..."
            coN.Open()
            coN.Close()
            Test = True
            lblStatus.Text = "Status: CONNECTED"
            MsgBox("Successfully connected!", MsgBoxStyle.Information)
        Catch ex As Exception
            lblStatus.Text = "Status: NOT CONNECTED"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not connected Then
            connected = Test()
            If Not connected Then Exit Sub
            GoTo QUESTION
        Else
            GoTo QUESTION
        End If
        Exit Sub
QUESTION:
        If cmbP.Text = "" Then MsgBox("Select COM-PORT!", MsgBoxStyle.Exclamation) : Exit Sub
        If MsgBox("Do you want to save connection settings?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbNo Then Exit Sub
        With My.Settings
            .SERVER = txtDataSource.Text
            .DB = txtDatabase.Text
            .UID = txtUserID.Text
            .PWD = txtPassword.Text
            .Save()
        End With
        DataSource = txtDataSource.Text
        DB = txtDatabase.Text
        dbUserID = txtUserID.Text
        dbPassword = txtPassword.Text

        openCon()
        UPDATEr("tblegsm", "port='" & cmbP.Text & "',baudrate=" & IIf(cmbBR.Text = "", 9600, cmbBR.Text) & ",timeout=" & IIf(cmbTO.Text = "", 300, cmbTO.Text))
        MsgBox("Saved!")
        frmSMSSender.Show()
        Me.Hide()
    End Sub

    Private Sub frmConnectionSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '        reset()

        If Not My.Settings.DB = "" Then
            frmSMSSender.ShowDialog()
            Me.Close()
            Exit Sub
        End If
        cmbP.Items.Clear()
        For Each item In IO.Ports.SerialPort.GetPortNames : cmbP.Items.Add(item) : Next
    End Sub

    Sub reset()
        My.Settings.DB = ""
        My.Settings.PWD = ""
        My.Settings.SERVER = ""
        My.Settings.UID = ""
        My.Settings.Save()
    End Sub
End Class