Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports MySql.Data.MySqlClient

Module ManageRecord
    Public conN As New MySqlConnection
    Public CMD As New MySqlCommand

    Public DataSource, dbUserID, dbPassword, DB As String
    Public SMSPORT, BAUDRATE, TIMEOUT As Integer

    Public Sub incrementID(ByVal Field As String)
        UPDATEr("tbleid", "value=value+1", "field = '" & Field & "'")
    End Sub
    Public Function recCount(ByVal TABLE As String, Optional ByVal WHERE As String = "True", Optional ByVal FIELD As String = "*") As Integer
        On Error GoTo c
        Return CInt(getVal(TABLE, "count(" & FIELD & ")", WHERE & " limit 1"))
c:      Return Nothing
    End Function

    Public Function DataReader(ByVal SQLcommand As String) As MySqlDataReader
        On Error GoTo c
        CONclose()
        openCon() : CMD.CommandText = SQLcommand : CMD.Connection = conN
        DataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        Exit Function
c:      Return Nothing
    End Function
    Public Sub CONclose()
        Try
            If conN.State = ConnectionState.Broken Then CONclose()
            If conN.State = ConnectionState.Open Then conN.Close()
        Catch ex As Exception
            CONclose()
        End Try
    End Sub
    Dim RetryCount As Integer = 0
    Public Sub openCon()
        Try
            conN = New MySqlConnection("server=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & "; ")
            If conN.State = ConnectionState.Open Then conN.Close()
            If conN.State = ConnectionState.Closed Then conN.Open()
            CMD.Connection = conN
        Catch ex As Exception
            conN.Dispose()
            If RetryCount >= 3 Then End
            If conN.State = ConnectionState.Broken Then CONclose()
            RetryCount += 1 : openCon()
        End Try
    End Sub
    Public Sub INSERTr(ByVal TABLE As String, ByVal VALUES As String, Optional ByVal FIELDS As String = "*")
        On Error GoTo c
        openCon()
        If FIELDS = "*" Then FIELDS = "" Else FIELDS = "(" & FIELDS & ")"
        Dim dRtemp As MySqlDataReader = DataReader("insert into " & TABLE & FIELDS & " values(" & VALUES & ")")
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
    End Sub
    Public Sub UPDATEr(ByVal TABLE As String, ByVal COLUMN_VALUE As String, Optional ByVal WHERE As String = "true")
        On Error Resume Next
        openCon()
        Dim CMD_UPDATE As New MySqlCommand("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE, conN)
        CMD_UPDATE.ExecuteNonQuery()
    End Sub
    Public Function getVal(ByVal table As String, ByVal field As String, Optional ByVal where As String = "true") As String
        Try
            Dim dRtemp As MySqlDataReader = DataReader("select " & field & " from " & table & " where " & where)
            If Not dRtemp.Read Then Return Nothing
            getVal = dRtemp.Item(0) : dRtemp.Close()
            Exit Function
        Catch ex As Exception
        End Try
c:      Return Nothing
    End Function
    Public Function gIDVal(ByVal FIELD As String, Optional ByVal VALUE As Boolean = True) As String
        On Error GoTo c
        Return getVal("tbleid", IIf(VALUE = True, "value", "Format"), "field like '" & FIELD & "%'")
c:      Return Nothing
    End Function
    Public Function v(ByVal InputString_To_Validate_For_MySQL As String, Optional ByVal Replicate_Char_valSQLchar As Boolean = False) As String
        Dim s As String = ""
        With InputString_To_Validate_For_MySQL
            s = .Replace("'", IIf(Replicate_Char_valSQLchar = True, "''", "\'"))
            s = .Replace("\", IIf(Replicate_Char_valSQLchar = True, "\\", "\\"))
        End With
        Return s.Trim
    End Function

    Enum SMSMessage
        LoginMessage = 0
        LogoutMessage = 1
        AnnouncementMessage = 2
        UnlogoutMessage = 3
        AdvisoryMessage = 4
        BlockConfirmMessage = 5
        ActivateConfirmMessage = 6
        GuideBlockMessage = 7
        GuideInvalidCommand = 8
        ExecuteConfirmMessage = 9
    End Enum
    Public Function getMessage(ByVal Msg As SMSMessage) As String
        getMessage = ""
        If Msg = SMSMessage.AnnouncementMessage Then getMessage = getVal("tbleannouncement", "concat(date_format(sysdate(),'%m/%d/%Y %h:%i:%s'),': ',Message)", "primarya=1 order by startdatetime desc limit 1")
        If Msg = SMSMessage.LoginMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'LoginMessage%'")
        If Msg = SMSMessage.LogoutMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'LogOutMessage%'")
        If Msg = SMSMessage.UnlogoutMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'UnlogoutMessage%'")
        If Msg = SMSMessage.AdvisoryMessage Then getMessage = getVal("tbleid", "concat(date_format(sysdate(),'%m/%d/%Y %h:%i:%s'),': ',format)", "field like 'AdvisoryMessage%'")
        If Msg = SMSMessage.BlockConfirmMessage Then getMessage = getVal("tbleid", "concat(format,'.')", "field like 'BlockConfirmMessage%'")
        If Msg = SMSMessage.ActivateConfirmMessage Then getMessage = getVal("tbleid", "concat(format,'.')", "field like 'ActivateConfirmMessage%'")
        If Msg = SMSMessage.GuideBlockMessage Then getMessage = getVal("tbleid", "concat(format,'.')", "field like 'GuideBlockMessage%'")
        If Msg = SMSMessage.GuideInvalidCommand Then getMessage = getVal("tbleid", "concat(format,'.')", "field like 'GuideInvalidCommand%'")
        If Msg = SMSMessage.ExecuteConfirmMessage Then getMessage = getVal("tbleid", "concat(format,'.')", "field like 'ExecuteConfirmMessage%'")

        Return getMessage
    End Function
End Module
