Imports MySql.Data.MySqlClient 
Imports PUPSSMSRFIDSMS_Gate.My.Resources
Imports System.IO
'Imports System.IO.File


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
            If RetryCount >= 3 Then
                If MB("Cannot connect from the server." & vbCr & vbCr & "Do you want to show the connection setup window?.", "x", "yn", "Cannot find server") = "y" Then
                    frmMB.Hide() : frmConnectionSetup.ShowDialog() : Return
                Else : End : End If
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

    Public Sub DataSet(ByVal strSQL As String)
        Try
            CONclose()
            Dim dA As New MySqlDataAdapter(strSQL, conN)
            dS = New DataSet
            dA.Fill(dS)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '-============END RECORD MANIPULATION===========-
#End Region

    Public Sub incrementID(ByVal Field As String)
        UPDATEr("tbleid", "value=value+1", "field like '%" & Field & "%'")
    End Sub

    Public Sub LOGS(ByVal Action As String)
        INSERTr("tblemonitoring", gIDVal("logs") & ",'" & logID & "','" & logUserType & "','" & v(Action) & "','" & saveDateTime(sDT) & "'")
        incrementID("logs")
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
            Sender.Image = Resources.No_Picture
            CONclose()
        End Try
    End Sub

    Public Sub AssignConnection()
        ReadConnectionSetup()
        conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
        openCon() : CONclose()

        If recCount("tbleclient", "name='" & My.Settings.PCNAME & "'") <= 0 Then _
                   INSERTr("tbleclient", "'" & IIf(My.Settings.MACHINE = "", "LOG IN", My.Settings.MACHINE) & "','" & IIf(My.Settings.PCNAME = "", Environ("computername"), My.Settings.PCNAME) & "','',0")

        RFIDConnected = False

        LastLogInDetectedRFID = Nothing
        LastLogOutDetectedRFID = Nothing
    End Sub

    Public Sub ReadConnectionSetup()
        With My.Settings
            If .USERID = "" Or .DATABASE = "" Then
                If MB("The connection of this system is not yet configured ." & vbCr & vbCr & "Do you want to show the connection configuration window?", "?") = "n" Then End
                If frmConnectionSetup.Visible = False Then frmConnectionSetup.ShowDialog()
            End If
            PCname = .PCNAME
            DataSource = .SERVER
            dbUserID = .USERID
            dbPassword = .PASSWORD
            DB = .DATABASE
        End With
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

    Public Sub eSQL(ByVal SQL_Command As String)
        openCon() : CMD.CommandText = SQL_Command
        Dim drTemp As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection)
c:      drTemp.Close() : CONclose()
    End Sub
 
   
End Module
