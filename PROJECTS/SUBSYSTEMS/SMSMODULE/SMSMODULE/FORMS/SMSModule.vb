Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter

Public Class frmSender
    'tmrOpeningEnding tags: Starting,Ending,Finishing,ErrorEnding
    Private Sub frmSender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Sub Initialized()
        Try
            ConN.Open()

            ComM = New GsmCommMain(PORT, BAUDRATE, TIMEOUT)
            ComM.Open()
        Catch ex As Exception

        End Try
    End Sub

    Sub EndNow()
        tmrOpeningEnding.Tag = "Ending"
        tmrOpeningEnding.Start()
        Me.Show()
        UPDATEr("tbleid", "value=0", "field like '%SMSSending%'")
        lblStatus.Text = "Finishing task...  "
    End Sub
End Class

Public Module modAPPLICATION
    Public ConN As New MySqlConnection("server=" & My.Settings.SERVER & ";uid=" & My.Settings.USERID & ";password=" & My.Settings.PASSWORD & ";database=" & My.Settings.DATABASE & ";")
    Public CMD As New MySqlCommand()
    Public dR As MySqlDataReader
    Public SERVER As String = "", UID As String = "", PWD As String = "", DB As String = ""

    '=============SUB PROCEDURE=============
    Public Sub Initialized()
        openCon()
        openCOMM()
    End Sub

    Dim RetryCount As Integer = 0
    Public Sub openCon()
        Try
            ConN = New MySqlConnection("server=" & SERVER & "; user id=" & UID & "; password=" & PWD & "; database=" & DB & "; ")
            If ConN.State = ConnectionState.Open Then ConN.Close()
            If ConN.State = ConnectionState.Closed Then ConN.Open()
            CMD.Connection = ConN
        Catch ex As Exception
            ConN.Dispose()
            If RetryCount >= 3 Then frmSender.Tag = "Error: " & ex.Message : frmSender.tmrOpeningEnding.Tag = "ErrorEnding" : frmSender.EndNow() : Return
            If ConN.State = ConnectionState.Broken Then CONclose()
            RetryCount += 1 : openCon()
        End Try
    End Sub

    Public Sub CONclose()
        Try
            If ConN.State = ConnectionState.Broken Then CONclose()
            If ConN.State = ConnectionState.Open Then ConN.Close()
        Catch ex As Exception
            CONclose()
        End Try
    End Sub

    Public Sub UPDATEr(ByVal TABLE As String, ByVal COLUMN_VALUE As String, Optional ByVal WHERE As String = "true")
        On Error GoTo c
        Dim dRtemp As MySqlDataReader = DataReader("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE)
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
    End Sub
    '=============END SUB PROCEDURE=============

    '=============FUNCTION PROCEDURE=============
    Public Function DataReader(ByVal SQLcommand As String) As MySqlDataReader
        On Error GoTo c
        openCon() : CMD.CommandText = SQLcommand : CMD.Connection = ConN
        DataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        Exit Function
c:      Return Nothing
    End Function

    '=============END FUNCTION PROCEDURE=============
End Module

Public Module modSMS
    Public ComM As New GsmCommMain
    Public PORT As Integer = 0, BAUDRATE As Long = 0, TIMEOUT As Long = 0

    '=============SUB PROCEDURE=============
    Public Function openCOMM()
        Try
            ComM = New GsmCommMain(PORT, BAUDRATE, TIMEOUT)
            If ComM.IsConnected Then ComM.Close()
            If Not ComM.IsConnected Then ComM.Open()
            openCOMM = True
        Catch ex As Exception
            openCOMM = False
            frmSender.Tag = "Error: " & ex.Message
            frmSender.tmrOpeningEnding.Tag = "ErrorEnding"
            frmSender.EndNow()
        Finally
            Try
                ComM.Close()
            Catch ex As Exception
            End Try
        End Try
    End Function
    '=============END SUB PROCEDURE=============
End Module
