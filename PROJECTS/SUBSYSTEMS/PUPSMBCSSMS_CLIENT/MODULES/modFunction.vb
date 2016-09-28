
Imports MySql.Data.MySqlClient

Imports System.IO
'Imports System.Security.Cryptography
Module modFunction

    Public Function getVal(ByVal table As String, ByVal field As String, Optional ByVal where As String = "true") As String
        On Error GoTo c
        Dim dRtemp As MySqlDataReader = DataReader("select " & field & " from " & table & " where " & where)
        If Not dRtemp.Read Then Return Nothing
        getVal = dRtemp.Item(0) : dRtemp.Close()
        Exit Function
c:      Return Nothing
    End Function

    Public Function DataReader(ByVal SQLcommand As String) As MySqlDataReader
        Try
            CONNclose()
            If conN.State = ConnectionState.Closed Then
                conN = New MySqlConnection("server=" & My.Settings.SERVER & "; uid=" & My.Settings.USERID & ";password=" & My.Settings.PASSWORD & ";database=" & My.Settings.DATABASE & ";")
                conN.Open()
            End If
            Dim CMD As New MySqlCommand(SQLcommand, conN)
            Return CMD.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            MsgBox("Data Reader" & vbNewLine & ex.Message, 48)
            Return Nothing
        End Try
    End Function


#Region "RECORD COUNT"
    Public Function recCount(ByVal TABLE As String, Optional ByVal WHERE As String = "True", Optional ByVal FIELD As String = "*") As Integer
        Return CInt(getVal(TABLE, "count(" & FIELD & ")", WHERE & " limit 1"))
        Return Nothing
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then recCount(TABLE, WHERE, FIELD) Else End
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

#Region "USER FAILURE ERROR MESSAGE..haha"
    Public Function errMSG() As String
        CONNclose()
        Return MB("You have an error during your transaction!" & vbCr & vbCr & "Please contact your maintenance for further assistance.", "!") : End
    End Function
#End Region

#Region "AUTOGENERATED ID"
    Public Function generateID(ByVal Field As String, Optional ByVal AutoInc As Boolean = False) As String
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("select value,format from tbleid where field like '%" & Field & "%'")
        If Not dRtemp.Read Then Return "0"
        Dim VAl As Integer = dRtemp.Item(0)
        Dim Format As String = dRtemp.Item(1)
        If AutoInc = False Then : generateID = Format & "-" & ("00000" & VAl).Substring(Len("00000" & VAl.ToString) - 5)
        Else : generateID = VAl
        End If
        dRtemp.Close()
        Exit Function
c:      Return "0" : dRtemp.Close() : CONNclose()
    End Function
#End Region

#Region "ENCRYPTION / DECRYPTION"
    Public Function EncryptText(ByVal strText As String) As String
        Dim byKey() As Byte = {}, IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Try : byKey = System.Text.Encoding.UTF8.GetBytes(Left("&%#@?,:*", 8))
            Dim des As New Security.Cryptography.DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
            Dim ms As New IO.MemoryStream()
            Dim cs As New Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(byKey, IV), Security.Cryptography.CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length) : cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception : Return Nothing : End Try
    End Function

    'The function used to decrypt the text
    Public Function DecryptText(ByVal strText As String) As String
        Dim byKey() As Byte = {}, IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte
        Try : byKey = System.Text.Encoding.UTF8.GetBytes(Left("&%#@?,:*", 8))
            Dim des As New Security.Cryptography.DESCryptoServiceProvider()
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New IO.MemoryStream()
            Dim cs As New Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(byKey, IV), Security.Cryptography.CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length) : cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception : Return Nothing : End Try
    End Function
#End Region

    Public Function getMessage(ByVal Msg As Message) As String
        getMessage = ""
        If Msg = Message.AnnouncementMessage Then getMessage = getVal("tbleannouncement", "concat(date_format(sysdate(),'%m/%d/%Y %h:%i:%s'),': ',Message)", "primarya=1 order by startdatetime desc limit 1")
        If Msg = Message.LoginMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'LoginMessage%'")
        If Msg = Message.LogoutMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'LogOutMessage%'")
        If Msg = Message.UnlogoutMessage Then getMessage = getVal("tbleid", "concat(format,' ',sysdate(),'.')", "field like 'UnlogoutMessage%'")
        If Msg = Message.AdvisoryMessage Then getMessage = getVal("tbleid", "concat(date_format(sysdate(),'%m/%d/%Y %h:%i:%s'),': ',format)", "field like 'AdvisoryMessage%'")
        Return getMessage
    End Function
    Enum Message
        LoginMessage = 0
        LogoutMessage = 1
        AnnouncementMessage = 2
        UnlogoutMessage = 3
        AdvisoryMessage = 4
    End Enum


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

    Public Function getRecipients(Optional ByVal where As String = "1") As String()
        Dim dRtemp As MySqlDataReader = DataReader("select tblestudent.number,tbleparentinfo.number from tblestudent,tbleparentinfo where tblestudent.rfidtagid=tbleparentinfo.rfidtagid and " & where)
        Dim str As String = "" : Dim x As Integer = 0
        Do While (dRtemp.Read) 'student recipients
            'check if there's a number saved
            If Not dRtemp.Item(0) = "" Then str &= dRtemp.Item(0) & ";" : x += 1
        Loop
        Dim Recipients(x - 1) As String, i As Integer = 0
        For Each s As String In Split(str, ";")
            If s.Trim <> "" Then Recipients(i) = Replace(s, ";", "") : i += 1
        Next
        dRtemp.Close()
        Return Recipients
    End Function

    Public Function GetRecipientList(Optional ByVal SQLCommand As String = "") As String()
        'If SQLCommand.Trim = "" Then SQLCommand = "select tblestudent.number,tbleparentinfo.number from tblestudent,tbleparentinfo where tblestudent.rfidtagid=tbleparentinfo.rfidtagid"
        Dim dRtemp As MySqlDataReader = DataReader(SQLCommand)
        Dim strRec As String = Nothing, ctr As Integer = 0
        For Each item As Object In dRtemp
            If Not dRtemp.Item(0).ToString.Trim = "" Then strRec &= dRtemp.Item(0) & ";" : ctr += 1
        Next
        Dim Recipients(ctr - 1) As String : ctr = 0
        For Each s As String In Split(strRec, ";")
            If Not ctr > ctr = 1 And Not s.Trim = "" Then _
            Recipients(ctr) = Replace(s, ";", "") : ctr += 1
        Next
        dRtemp.Close()
        Return Recipients
    End Function


    Public Function RunSearch() As Boolean
        If File.Exists(PathSearch) Then
            If CBool(getVal("tbleid", "value", "field like '%" & IIf(logUserType Like "Administrator", "SearchAdmin", "SearchCliet") & "%'")) = False Then
                Try : Shell(PathSearch & " /abovenormal")
                    UPDATEr("tbleid", "value=1", "field like '%" & IIf(logUserType Like "Administrator", "SearchAdmin", "SearchCliet") & "%'")
                    Return True
                Catch ex As Exception : MB(ex.Message)
                End Try
            Else : Try : Shell("taskkill /im " & PathSearch & " /f")
                    UPDATEr("tbleid", "value=0", "field like '%" & IIf(logUserType Like "Administrator", "SearchAdmin", "SearchCliet") & "%'")
                    RunSearch()
                Catch ex As Exception : MB(ex.Message)
                End Try
            End If
        Else
            MB("Cannot find the path: " & PathSearch & ".", "x") : Return False
        End If
    End Function

 

    Public Function gIDVal(ByVal FIELD As String, Optional ByVal VALUE As Boolean = True) As String
        Return getVal("tbleid", IIf(VALUE = True, "value", "Format"), "field like '" & FIELD & "%'")
    End Function

    Public Function NoSelected(ByVal ListViewObject As ListView) As Boolean
        If ListViewObject.SelectedIndices.Count <= 0 Then MB("No Selected item!", "!") : Return True Else Return False
    End Function

    Public Function v(ByVal InputString_To_Validate_For_MySQL As String, Optional ByVal Replicate_Char_valSQLchar As Boolean = False) As String
        Dim s As String = ""
        With InputString_To_Validate_For_MySQL
            s = .Replace("'", IIf(Replicate_Char_valSQLchar = True, "''''", "\'"))
            s = .Replace("\", IIf(Replicate_Char_valSQLchar = True, "\\\\", "\\"))
            s = .Replace("/", IIf(Replicate_Char_valSQLchar = True, "////", "\/"))
            s = .Replace("(", IIf(Replicate_Char_valSQLchar = True, "((((", "\("))
            s = .Replace(")", IIf(Replicate_Char_valSQLchar, "))))", "\)"))
        End With
        Return s
    End Function

    Public Function AdminPass() As Boolean
        frmUserPass.ShowDialog()
        Return IIf(frmUserPass.Tag = "OK", True, False)
    End Function

    Public Function sDT() As Date
        Try
            Dim c As New MySqlConnection("server=" & My.Settings.SERVER & "; uid=" & My.Settings.USERID & "; password=" & My.Settings.PASSWORD & ";")
            c.Open()
            Dim cmdTemp As New MySqlCommand("select sysdate()")
            cmdTemp.Connection = c
            Dim drTemp As MySqlDataReader = cmdTemp.ExecuteReader(CommandBehavior.CloseConnection)
            If drTemp.Read Then : sDT = drTemp.Item(0)
            Else : GoTo ERRORHANDLE
            End If
            drTemp.Close()
        Catch ex As Exception
            GoTo ERRORHANDLE
        End Try
        Exit Function
ERRORHANDLE:
        sDT = Now
    End Function
	#Region "SOUND EFFECTS"
    Public Function Sounds(ByVal AUDIO As AUDIO) As Boolean
        Try
            My.Computer.Audio.Stop()
            If Not Directory.Exists(My.Settings.WAV_Path) Or AUDIO = Nothing Then Return False
            My.Computer.Audio.Play(My.Settings.WAV_Path & AUDIO.ToString & ".wav")
            Return True
        Catch ex As Exception
            GoTo ERRORHANDLE
        End Try
        Exit Function
ERRORHANDLE:
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Return False
    End Function
    Enum AUDIO
        ACCEPTED = 0
        ACTIVATED = 1
        DEACTIVATED = 2
        ERRORWARN = 3
        CLICK = 4
        MOVE = 5
        NOTIFY = 6
        SCAN = 7
        SELECTED = 8
        TOONG = 9
        CAMERA = 10
        MOUSE_OVER = 11
        SMS = 12
        WRONG = 13
        DELETED = 14
    End Enum
#End Region
End Module
