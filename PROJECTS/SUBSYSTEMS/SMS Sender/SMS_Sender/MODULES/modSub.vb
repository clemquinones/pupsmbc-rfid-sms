Imports MySql.Data.MySqlClient 
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter

Module modSub
 

#Region "Connection Penetration"
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

    Public Sub CONclose()
        Try
            If conN.State = ConnectionState.Broken Then CONclose()
            If conN.State = ConnectionState.Open Then conN.Close()
        Catch ex As Exception
            CONclose()
        End Try
    End Sub
#End Region



#Region "RECORD MANIPULATION"
    '-============RECORD MANIPULATION===========-
    Public Sub INSERTr(ByVal TABLE As String, ByVal VALUES As String, Optional ByVal FIELDS As String = "*")
        On Error GoTo c
        openCon()
        If FIELDS = "*" Then FIELDS = "" Else FIELDS = "(" & FIELDS & ")"
        Dim dRtemp As MySqlDataReader = DataReader("insert into " & TABLE & FIELDS & " values(" & VALUES & ")")
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
    End Sub

    Public Sub DELETEr(ByVal TABLE As String, Optional ByVal WHERE As String = "true")
        On Error GoTo c
        Dim dRtemp As MySqlDataReader = DataReader("delete from " & TABLE & " where " & WHERE)
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
    End Sub
    Public Sub UPDATEr(ByVal TABLE As String, ByVal COLUMN_VALUE As String, Optional ByVal WHERE As String = "true")
        '   On Error GoTo c
        openCon()
        Dim CMD_UPDATE As New MySqlCommand("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE, conN)
        CMD_UPDATE.ExecuteNonQuery()

        '  Dim dRtemp As MySqlDataReader = DataReader("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE)
        '  dRtemp.Close() : CONclose()
        Exit Sub
c:      ' dRtemp.Close() : CONclose()
    End Sub

    Public Sub DataSet(ByVal strSQL As String)
        Try
            CONclose()
            Dim dA As New MySqlDataAdapter(strSQL, conN)
            dS = New DataSet
            dA.Fill(dS)
        Catch ex As Exception
            MakeLog(ex.Message)
            MsgBox(ex.Message)
        End Try
    End Sub
    '-============END RECORD MANIPULATION===========-
#End Region

    Public Sub incrementID(ByVal Field As String)
        UPDATEr("tbleid", "value=value+1", "field like '%" & Field & "%'")
    End Sub
 
    Public Sub AssignConnection()
        Try
            With My.Settings
                .WAV_Path = CurDir() & "\FILES\WAV\"
                .SERVER = ""
                .USERID = "root"
                .PASSWORD = ""
                .DATABASE = "db_campus"
                .Save() : .Reload()
                DataSource = .SERVER
                dbUserID = .USERID
                dbPassword = .PASSWORD
                DB = .DATABASE
            End With
            conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
            openCon() : CONclose()
            Dim dR As MySqlDataReader = DataReader("select port,baudrate,timeout,validity,senddelay,stopbits from tblegsm limit 1")
            If dR.Read Then
                SMSPORT = Integer.Parse(Replace(dR.Item(0), "COM", ""))
                SMSBAUDRATE = dR.Item(1)
                SMSTIMEOUT = dR.Item(2)
                SMSVALIDITY = dR.Item(3)
                SMSSENDDELAY = dR.Item(4)
                SMSSTOPBITS = dR.Item(5)
            End If
            dR.Close()
        Catch ex As Exception
            MakeLog(ex.Message)
        Finally
            Try : CONclose()
            Catch ex As Exception
            End Try
        End Try
    End Sub
  
    Public Sub eSQL(ByVal SQL_Command As String)
        Try
            openCon()
            CMD = New MySqlCommand(SQL_Command, conN)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MakeLog(ex.Message)
        End Try
    End Sub

    Public Sub MakeLog(ByVal ErrMessage As String)
        Exit Sub
        Try
            Dim FilePath As String = AppPath & "\ErrorLogs.ERRORLOGS"
            If Not IO.File.Exists(FilePath) Then IO.File.CreateText(FilePath)

            Dim Content As String = IO.File.ReadAllText(FilePath)
            IO.File.WriteAllText(AppPath, "[" & Now & "] " & Content & vbNewLine & ErrMessage)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
