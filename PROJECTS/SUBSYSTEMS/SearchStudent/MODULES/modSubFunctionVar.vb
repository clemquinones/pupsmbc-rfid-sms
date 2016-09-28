Imports MySql.Data.MySqlClient
Imports System.IO
Imports SearchStudentLogs.My.Resources

Module modSubFunctionVar
    '------//===○--||--||--||==\\-------------------------------------------------------------------------------------------------------
    '------\\==\\--||--||--||=<<-----------------------------------------------------------------------------------------------------
    '------○===//--||||||--||==//-----------------------------------------------------------------------------------------------------
#Region "SUB PROCEDURE"
#Region "Connection Penetration"
    Dim RetryCount As Integer = 0
    Public Sub openCon()
        Try
            conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
            If conN.State = ConnectionState.Open Then conN.Close()
            If conN.State = ConnectionState.Closed Then conN.Open()
            CMD.Connection = conN
        Catch ex As Exception
            conN.Dispose()
            If RetryCount >= 3 Then
                MB(ex.Message)
                End
            End If
            If conN.State = ConnectionState.Broken Then CONclose()
            If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then RetryCount += 1 : openCon() Else End
        End Try
    End Sub

    Public Sub CONclose()
        Try
            If conN.State = ConnectionState.Broken Then CONclose()
            '      conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
            If conN.State = ConnectionState.Open Then conN.Close()
        Catch ex As Exception
            conN.Dispose()
            If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "- Cannot find server") = "r" Then CONclose() Else End
        End Try
    End Sub
#End Region

#Region "RECORD MANIPULATION"
    '-============RECORD MANIPULATION===========-
    Public Sub INSERTr(ByVal TABLE As String, ByVal VALUES As String, Optional ByVal FIELDS As String = "*")
        'On Error Goto c
        openCon()
        If FIELDS = "*" Then FIELDS = "" Else FIELDS = "(" & FIELDS & ")"
        Dim dRtemp As MySqlDataReader = DataReader("insert into " & TABLE & FIELDS & " values(" & VALUES & ")")
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then INSERTr(TABLE, VALUES, FIELDS) Else End
    End Sub

    Public Sub DELETEr(ByVal TABLE As String, Optional ByVal WHERE As String = "true")
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("delete from " & TABLE & " where " & WHERE)
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then DELETEr(TABLE, WHERE) Else End
    End Sub
    Public Sub UPDATEr(ByVal TABLE As String, ByVal COLUMN_VALUE As String, Optional ByVal WHERE As String = "true")
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE)
        dRtemp.Close() : CONclose()
        Exit Sub
c:      dRtemp.Close() : CONclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then UPDATEr(TABLE, COLUMN_VALUE, WHERE) Else End
    End Sub
    '-============END RECORD MANIPULATION===========-
#End Region

    Public Sub AssignConnection()
        ReadConnectionSetup()
        conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
        openCon() : CONclose()
    End Sub

    Public Sub ReadConnectionSetup()
        If Not File.Exists(Path) Then
            MB("The file ConnSetup.SetupConfiguration is missing." & vbCr & vbCr & "System will create a new connection setup file with its value of defaults.", "x")
            IO.File.CreateText(Path)
            Shell("tskill explorer")
            Shell("explorer > null")
            IO.File.WriteAllText(Path, "" & _
                ":==--POLYTECHNIC UNIVERSITY OF THE PHILIPPINES CAMPUS STUDENT SECURITY AND ACCESS CONTROL SYSTEM USING RADIO FREQUENCY IDENTIFICATION WITH SMS TECHNOLOGY--==:" & vbNewLine & vbNewLine & _
                ":==-LOCAL MACHINE-==:" & vbNewLine & _
                "[MACHINE]=Server;" & vbNewLine & _
                "[PCNAME]=" & Environ("ComputerName") & ";" & vbNewLine & _
                "[PCMONITOR]=LOG IN;" & vbNewLine & _
                ":==---------------==:" & vbNewLine & vbNewLine & _
                ":==--CONNECTION--==:" & vbNewLine & _
                "[DATASOURCE]=;" & vbNewLine & _
                "[USERID]=root;" & vbNewLine & _
                "[PASSWORD]=;" & vbNewLine & _
                "[DATABASE]=db_campus;" & vbNewLine & _
                ":==---------------==:" & vbNewLine & vbNewLine & _
                ":==-----GSM------==:" & vbNewLine & _
                "[SMS_PORT]=5;" & vbNewLine & _
                "[SMS_BAUDRATE]=9600;" & vbNewLine & _
                "[SMS_TIMEOUT]=300;" & vbNewLine & _
                "[SMS_VALIDITY]=255;" & vbNewLine & _
                "[SMS_STOPBITS]=0;" & vbNewLine & _
                "[SMS_SENDDELAY]=1000;" & vbNewLine & _
                 ":==---------------==:")
        End If

        Dim TextContent() As String = IO.File.ReadAllLines(Path)
        For i As Integer = 0 To TextContent.Length - 1
            Dim strTextLine As String = TextContent(i).Replace(";", "") : If TextContent(i).Contains("[MACHINE]") Then
                strTextLine = strTextLine.Replace("[MACHINE]=", "") : Machine = strTextLine
            ElseIf TextContent(i).Contains("[PCNAME]") Then
                strTextLine = strTextLine.Replace("[PCNAME]=", "") : PCname = strTextLine
            ElseIf TextContent(i).Contains("[PCMONITOR]") Then
                strTextLine = strTextLine.Replace("[PCMONITOR]=", "") : PCSystem = strTextLine
            ElseIf TextContent(i).Contains("[DATASOURCE]") Then
                strTextLine = strTextLine.Replace("[DATASOURCE]=", "") : DataSource = strTextLine
            ElseIf TextContent(i).Contains("[USERID]") Then
                strTextLine = strTextLine.Replace("[USERID]=", "") : dbUserID = strTextLine
            ElseIf TextContent(i).Contains("[PASSWORD]") Then
                strTextLine = strTextLine.Replace("[PASSWORD]=", "") : dbPassword = strTextLine
            ElseIf TextContent(i).Contains("[DATABASE]") Then
                strTextLine = strTextLine.Replace("[DATABASE]=", "") : DB = strTextLine
            End If
        Next
    End Sub

    Public Sub displayPic(ByVal ID As String, ByRef Sender As Object, Optional ByVal Field As String = "rfidtagid")
        openCon()
        CMD.CommandText = "select studno,picture from tblestudent where " & IIf(Not Field Like "rfidtagid", Field, "rfidtagid") & "='" & ID & "'"
        Dim drPb As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        Try : If ID.Trim = "" Then Return
            If Not drPb.Read Then Return
            Dim imgByte(drPb.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            drPb.GetBytes(1, 0, imgByte, 0, imgByte.Length) : drPb.Close()
            Dim mS As New MemoryStream(imgByte)
            Sender.Image = Image.FromStream(mS)
        Catch ex As Exception
            Sender.Image = Resources.NoPicture
            CONclose()
        End Try
    End Sub

    Public Sub toHL(ByVal txt As Object)
        txt.SelectionStart = 0
        txt.SelectionLength = txt.Text.Length
        txt.Focus()
    End Sub

#Region "TextClicked"
    Public a As String = ""
    Public Sub TextClicked(ByVal sender As System.Object, ByVal txt As String)
        If Trim(sender.Text) = txt Then sender.Text = "" Else toHL(sender)
    End Sub
#End Region
#End Region

    '------||==○--||--||--||\-\\--//==\\--||=||=||--||--//==\\--------------------------------------------------------------------------------
    '------||==---||--||--||\\||--||---------||-----||--||--||-----------------------------------------------------------------------
    '------||-----\\||//--||-\||--\\==//-----||-----||--\\==//--------------------------------------------------------------------------
#Region "FUNCTIONS"
    Public Function MB(Optional ByVal msgMessage As String = "Message", Optional ByVal msgIcon As String = "i", Optional ByVal msgButtons As String = "", Optional ByVal msgTitle As String = "") As String
        If msgMessage = "" Then msgMessage = "Message"
        If msgButtons = "" And msgIcon = "?" Then msgButtons = "yn"
        If msgButtons = "" Then msgButtons = "o"
        If msgTitle = "" Then msgTitle = "Prompt"
        mbMessage = msgMessage
        mbIcon = msgIcon
        mbButtons = msgButtons
        mbTitle = "[" & Title & "] - " & msgTitle
        Try
            frmMB.ShowDialog()
        Catch ex As Exception
            frmMB.Close()
        End Try
        MB = frmMB.Tag
    End Function

    Public Function getVal(ByVal table As String, ByVal field As String, Optional ByVal where As String = "true") As String
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("select " & field & " from " & table & " where " & where)
        If Not dRtemp.Read Then Return Nothing
        getVal = dRtemp.Item(0) : dRtemp.Close()
        Exit Function
c:      Return Nothing
    End Function

    Public Function DataReader(ByVal SQLcommand As String) As MySqlDataReader
        CONclose()
        openCon() : CMD.CommandText = SQLcommand : CMD.Connection = conN
        DataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

#Region "RECORD COUNT"
    Public Function recCount(ByVal table As String, Optional ByVal where As String = "True", Optional ByVal cols As String = "*") As Integer
        On Error GoTo c
        Return CInt(getVal(table, "count(" & cols & ")", where)) : Exit Function
c:      If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then recCount(table, where, cols) Else End
    End Function
#End Region

#Region "GET DATE/TIME"
    'Returns DateTime in Format
    Public Function saveDateTime(Optional ByVal DateToConvert As Date = Nothing, Optional ByVal RetrievFormat As SaveDateTimeFormat = SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO, Optional ByVal DateSeparator As String = "/") As String
        Dim dt As String = Nothing
        If RetrievFormat = 0 Then dt = Format(DateToConvert, "yyyy" & DateSeparator & "MM" & DateSeparator & "dd") & " " & Format(DateToConvert, "HH:mm:ss")
        If RetrievFormat = 1 Then dt = Format(DateToConvert, "yyyy" & DateSeparator & "MM" & DateSeparator & "dd")
        If RetrievFormat = 2 Then dt = Format(DateToConvert, "HH:mm:ss")
        Return dt
    End Function

    Public Function getDateTime(ByVal DateToConvert As Date, Optional ByVal RetrievFormat As GetDateTimeValue = 0, Optional ByVal DateSeparator As String = "/") As String
        Dim dt As String = Nothing
        If RetrievFormat = GetDateTimeValue.MM_dd_yyyy_OO_OO_OO_AM_PM Then dt = Format(DateToConvert, "MM" & DateSeparator & "dd" & DateSeparator & "yyyy") & " " & Format(DateToConvert, "hh:mm:ss") & " " & IIf(CInt(Format(DateToConvert, "HH")) >= 12 And CInt(Format(DateToConvert, "mm") >= 0), "PM", "AM") '   MM_dd_yyyy_OO_OO_OO_AM_PM = 0
        If RetrievFormat = GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM Then dt = Format(DateToConvert, "MM" & DateSeparator & "dd" & DateSeparator & "yyyy") & " " & Format(DateToConvert, "hh:mm") & " " & IIf(CInt(Format(DateToConvert, "HH")) >= 12 And CInt(Format(DateToConvert, "mm") >= 0), "PM", "AM") 'MM_dd_yyyy_OO_OO_AM_PM = 1
        If RetrievFormat = GetDateTimeValue.MM_dd_yyyy_OO_OO_OO_AM_PM_DAYOFWEEK Then dt = Format(DateToConvert, "MM" & DateSeparator & "dd" & DateSeparator & "yyyy") & " " & Format(DateToConvert, "hh:mm:ss") & " " & IIf(CInt(Format(DateToConvert, "HH")) >= 12 And CInt(Format(DateToConvert, "mm") >= 0), "PM", "AM") & " " & DateToConvert.DayOfWeek.ToString '   MM_dd_yyyy_OO_OO_OO_AM_PM = 0
        If RetrievFormat = GetDateTimeValue.MM_dd_yyyy Then dt = Format(DateToConvert, "MM" & DateSeparator & "dd" & DateSeparator & "yyyy")
        If RetrievFormat = GetDateTimeValue.OO_OO_OO Then dt = Format(DateToConvert, "hh:mm:ss")
        If RetrievFormat = GetDateTimeValue.OO_OO_OO_AM_PM Then dt = Format(DateToConvert, "hh:mm:ss") & " " & IIf(CInt(Format(DateToConvert, "HH")) >= 12 And CInt(Format(DateToConvert, "mm") >= 0), "PM", "AM")
        If RetrievFormat = GetDateTimeValue.OO_OO_AM_PM Then dt = Format(DateToConvert, "hh:mm") & " " & IIf(CInt(Format(DateToConvert, "HH")) >= 12 And CInt(Format(DateToConvert, "mm") >= 0), "PM", "AM")
        Return dt
    End Function

    Enum GetDateTimeValue
        MM_dd_yyyy_OO_OO_OO_AM_PM = 0
        MM_dd_yyyy_OO_OO_AM_PM = 1
        MM_dd_yyyy_OO_OO_OO_AM_PM_DAYOFWEEK = 2
        MM_dd_yyyy = 3
        OO_OO_OO = 4
        OO_OO_OO_AM_PM = 5
        OO_OO_AM_PM = 6
    End Enum
    Enum SaveDateTimeFormat
        yyyy_MM_dd_OO_OO_OO = 0
        yyyy_MM_dd = 1
        OO_OO_OO = 2
    End Enum
#End Region
#End Region
    '--------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------
#Region "VARIABLES"
    Public mbTitle As String = "Prompt"
    Public mbIcon = "i"
    Public mbButtons = "ok"
    Public mbMessage = "Message"

    Public Title As String = Application.ProductName.ToString

    Public conN As New MySqlConnection
    Public CMD As New MySqlCommand
    Public dR As MySqlDataReader

#Region "Database Connection"
    Public DataSource, dbUserID, dbPassword, DB As String
    Public Path As String = CurDir() & "\DATA\CONNSETUP.SETUPCONFIGURATION"
#End Region

#Region "Local Machine"
    Public Machine, PCname, PCSystem As String
#End Region
 
#End Region
    '--------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------
End Module
