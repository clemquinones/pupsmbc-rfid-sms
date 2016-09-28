Imports MySql.Data.MySqlClient 
Imports PUPSMBCSSMS_CLIENT.My.Resources
Imports System.IO
Imports System.IO.File


Module modSub
 

#Region "Connection Penetration"
    Dim RetryOpen As Integer = 0
    Public Sub openCONN()
        Try
            If conN.State = ConnectionState.Closed Then conN = New MySqlConnection("server=" & My.Settings.SERVER & "; uid=" & My.Settings.USERID & ";password=" & My.Settings.PASSWORD & ";database=" & My.Settings.DATABASE & ";") : conN.Open()
            RetryOpen = 0
        Catch ex As Exception
            RetryOpen += 1
            Try
                conN.Close()
            Catch
            End Try
            If RetryOpen >= 3 Then
                If MB("Cannot connect from the server." & vbCr & vbCr & "Do you want to show the connection setup window?.", "x", "yn", "Cannot find server") = "y" Then
                    frmMB.Hide() : frmConnectionSetup.ShowDialog() : Return
                Else : End : End If
            End If
            If conN.State = ConnectionState.Broken Then CONNclose()
            If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then RetryOpen += 1 : openCONN() Else End
            'MsgBox("Opening Connection" & vbNewLine & ex.Message, 32)
        End Try
    End Sub
    Dim RetryClose As Integer = 0
    Public Sub CONNclose()
        Try
            conN.Close()
            RetryClose = 0
        Catch ex As Exception
            RetryClose += 1
            If RetryClose >= 3 Then
                If MB("Cannot connect from the server." & vbCr & vbCr & "Do you want to show the connection setup window?.", "x", "yn", "Cannot find server") = "y" Then
                    frmMB.Hide() : frmConnectionSetup.ShowDialog() : Return
                Else : End : End If
            End If
            If conN.State = ConnectionState.Broken Then CONNclose()
            If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then RetryClose += 1 : CONNclose() Else End
        End Try
    End Sub
 
#End Region


#Region "RECORD MANIPULATION"
    '-============RECORD MANIPULATION===========-
    Public Sub INSERTr(ByVal TABLE As String, ByVal VALUES As String, Optional ByVal FIELDS As String = "*")
        'On Error Goto c
        openCONN()
        If FIELDS = "*" Then FIELDS = "" Else FIELDS = "(" & FIELDS & ")"
        Dim dRtemp As MySqlDataReader = DataReader("insert into " & TABLE & FIELDS & " values(" & VALUES & ")")
        dRtemp.Close() : CONNclose()
        Exit Sub
c:      dRtemp.Close() : CONNclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then INSERTr(TABLE, VALUES, FIELDS) Else End
    End Sub

    Public Sub DELETEr(ByVal TABLE As String, Optional ByVal WHERE As String = "true")
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("delete from " & TABLE & " where " & WHERE)
        dRtemp.Close() : CONNclose()
        Exit Sub
c:      dRtemp.Close() : CONNclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then DELETEr(TABLE, WHERE) Else End
    End Sub
    Public Sub UPDATEr(ByVal TABLE As String, ByVal COLUMN_VALUE As String, Optional ByVal WHERE As String = "true")
        'On Error Goto c
        Dim dRtemp As MySqlDataReader = DataReader("update " & TABLE & " set " & COLUMN_VALUE & " where " & WHERE)
        dRtemp.Close() : CONNclose()
        Exit Sub
c:      dRtemp.Close() : CONNclose()
        If MB(Err.Description & vbCr & vbCr & "Connection lost occur." & vbCr & "Click 'Retry' to connect from the server.", "x", "rc", "Cannot find server") = "r" Then UPDATEr(TABLE, COLUMN_VALUE, WHERE) Else End
    End Sub

    Public Sub DataSet(ByVal strSQL As String)
        Try
            CONNclose()
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

 
    Public Sub displayPic(ByVal ID As String, ByRef Sender As PictureBox, Optional ByVal Field As String = "rfidtagid")
        Dim dR As MySqlDataReader = DataReader("select studno,picture from tblestudent where " & IIf(Not Field Like "rfidtagid", Field, "rfidtagid") & "='" & ID & "'")
        Try : If ID.Trim = "" Then Return
            If Not dR.Read Then Return
            Dim imgByte(dR.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dR.GetBytes(1, 0, imgByte, 0, imgByte.Length) : dR.Close()
            Dim mS As New MemoryStream(imgByte)
            Sender.Image = Image.FromStream(mS)
        Catch ex As Exception
            Sender.Image = Resources.No_Picture
            CONNclose()
        End Try
    End Sub

    Public Sub AssignConnection()
        ReadConnectionSetup()
        conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
        openCONN() : CONNclose()
    End Sub

    Public Sub ReadConnectionSetup()
        With My.Settings
            If .DATABASE = "" Then
                frmConnectionSetup.ShowDialog()
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

    Public Sub eSQL(ByVal SQLcommand As String)
        Try
            Dim dReSQL As MySqlDataReader = DataReader(SQLcommand)
            dReSQL.Close()
        Catch ex As Exception
            MsgBox("Executing SQL command" & vbNewLine & ex.Message, 32)
        End Try
    End Sub

    Public Sub showResults(ByVal KEYWORD As String)
        frmResult.LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select studno,lname,fname,mname from tblestudent where studno like '%" & KEYWORD & "%' or lname like '%" & KEYWORD & "%' or fname like '%" & KEYWORD & "%' or mname like '%" & KEYWORD & "%'")
        Dim li As New ListViewItem
        For Each item As Object In dR
            li = frmResult.LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3))
        Next
        dR.Close()
        frmResult.lblResults.Text = frmResult.LV.Items.Count & " result for '" & KEYWORD & "'"
        If frmResult.LV.Items.Count = 1 Then viewProfile(frmResult.LV.Items(0).Text) : Return
        If frmResult.LV.Items.Count <= 0 Then MB("No record(s) matched!", "!") : Return
        frmResult.ShowDialog()
    End Sub
    Public Sub viewProfile(ByVal ID As String)
        With frmStudentProfile
            .Tag = ID
            .lblName.Text = "------"
            .lblStudNo.Text = "------"
            .lblCourseYrSec.Text = "------"
            .lblAddress.Text = "------"
            .pbPic.Image = My.Resources.No_Picture
            Dim dR As MySqlDataReader = DataReader("select fname,mname,lname,course,yearlevel,section,address from tblestudent where studno='" & .Tag & "'")
            Dim ctr As Integer = 0
            For Each item As Object In dR
                .lblName.Text = dR.Item(2) & ", " & dR.Item(0) & " " & dR.Item(1)
                .lblStudNo.Text = .Tag
                .lblCourseYrSec.Text = dR.Item(3) & " " & dR.Item(4) & "-" & dR.Item(5)
                .lblAddress.Text = dR.Item(6)
                displayPic(ID, .pbPic, "studno")
                ctr += 1
                Exit For
            Next
            If ctr <= 0 Then dR.Close() : Return
            dR.Close()
            .Show()
        End With
    End Sub

    Public Enum RPT
        STUDENTLOG = 0
        STUDENTLIST = 1
        SYSTEMLOGS = 2
        DEPARTMENT = 3
        PARENTLIST = 4
        MESSAGE = 5
        FACULTYUTILITY = 6
    End Enum
    Public Function getREPORTFILE(ByVal report As RPT, Optional ByVal strSQL As String = "") As String
        Select Case (report)
            Case 0
                '  If recCount("tblestudent s, tblemonitoringlogs m", "s.rfidtagid=m.rfidtagid order by m.datetime", "s.studno as SN,concat(s.lname,', ',s.fname,' ',s.mname) as NAME, s.course as COURSE, s.yearlevel as YR, s.section as SC,m.logstate as DETECTION, m.datetime as DATELOG,(select datetime from tblemonitoringlogs order by datetime limit 1) as START_DT,(select datetime from tblemonitoringlogs order by datetime desc limit 1) as END_DT,'Student Monitoring Logs' as TITLE") > 0 Then
                If recCount("tblestudent s, tblemonitoringlogs m", "s.rfidtagid=m.rfidtagid") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select s.studno as SN,concat(s.lname,', ',s.fname,' ',s.mname) as NAME, s.course as COURSE, s.yearlevel as YR, s.section as SC,m.logstate as DETECTION, m.datetime as DATELOG,(select datetime from tblemonitoringlogs order by datetime limit 1) as START_DT,(select datetime from tblemonitoringlogs order by datetime desc limit 1) as END_DT,'Student Monitoring Logs' as TITLE from tblestudent s, tblemonitoringlogs m where s.rfidtagid=m.rfidtagid order by m.datetime")
                Else : DataSet("select 'No items...' SN,'No items...' as NAME,'----' as COURSE,'-' as YR,'-' as SC,'--' as DETECTION, '' as DATELOG, 'First read' as START_DT,'last read' as END_DT,'Student Monitoring Logs' as TITLE")
                End If
                Return "StudentLogRecords.rpt"
            Case 1
                ' If recCount("tblestudent s", "1 order by COURSE", "s.studno as SN, concat(s.fname,' ',s.mname, ' ', s.lname) as NAME, s.course as COURSE, concat(s.yearlevel,'') as YR, concat(s.section,'') as SC, s.status as STATUS, s.gender as GENDER, s.number as NUMBER, 'Student List' as TITLE") > 0 Then
                If recCount("tblestudent s", "1 order by COURSE") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select s.studno as SN, concat(s.fname,' ',s.mname, ' ', s.lname) as NAME, s.course as COURSE, concat(s.yearlevel,'') as YR, concat(s.section,'') as SC, s.status as STATUS, s.gender as GENDER, s.number as NUMBER, '" & InputBox("Enter title/header for this report: ", "Report Title", "Student List") & "' as TITLE from tblestudent s order by COURSE")
                Else : DataSet("select 'No items...' as CODE, 'No items...' as DESCRIPTION, '-' as YEARS, '-' as STUDCOUNT, 'List of Departments' as TITLE order by CODE")
                End If
                Return "StudentList.rpt"
            Case 2
                'If recCount("tblemonitoring m", "1 order by ID", "m.id as ID, m.loguserid as USERID, m.logusertype as USERTYPE, m.action as ACTION, m.datetime as DATELOG, (select datetime from tblemonitoring order by datetime limit 1) as START_DT, (select datetime from tblemonitoring order by datetime desc limit 1) as END_DT, 'System User Logs' as TITLE") > 0 Then
                If recCount("tblemonitoring m") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select cd.code as CODE, cd.description as DESCRIPTION, cd.year as YEARS, (select count(*) from tblestudent where course=cd.code) as STUDCOUNT, '" & InputBox("Enter title/header for this report: ", "Report Title", "Department List") & "' as TITLE from tblecodedesc cd order by cd.code")
                Else : DataSet("select '-' as ID, 'No items...' as USERID, 'No items...' as USERTYPE, 'No items...' as ACTION, '--' as DATELOG, 'Start read' as START_DT, 'last read' as END_DT, 'System User Logs' as TITLE order by ID")
                End If
                Return "SystemLogs.rpt"
            Case 3
                If recCount("tblecodedesc") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select cd.code as CODE, cd.description as DESCRIPTION, cd.year as YEARS, (select count(*) from tblestudent where course=cd.code) as STUDCOUNT, '" & InputBox("Enter title/header for this report: ", "Report Title", "Department List") & "' as TITLE from tblecodedesc cd order by cd.code")
                Else : DataSet("select 'No items...' as CODE, 'No items...' as DESCRIPTION, '-' as YEARS, '-' as STUDCOUNT, 'List of Departments' as TITLE order by CODE")
                End If
                Return "Departments.rpt"
            Case 4 : DataSet(IIf(strSQL <> "", strSQL, "select s.studno as SN,s.course as COURSE,concat(s.yearlevel,'-',s.section) as YS,concat(p.fname,' ',p.lname) as NAME, p.relation as RELATION,p.number as NUMBER,if(p.block=false,'ON','OFF') as ADVISORY,'" & InputBox("Enter title/header for this report: ", "Report Title", "Parent List") & "' as TITLE from tblestudent s,tbleparentinfo p where p.rfidtagid=s.rfidtagid order by s.course"))
                Return "ParentList.rpt"
            Case 5
                Return "Messages.rpt"
            Case 6
                'If recCount("tblefacultyutility", , "ID as ID,concat(fname,' ',mname,' ',lname) as NAME, field as DEPARTMENT, number as NUMBER,'List of Faculties and Utilities' as TITLE") > 0 Then
                If recCount("tblefacultyutility") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select ID as ID,concat(fname,' ',mname,' ',lname) as NAME, field as DEPARTMENT, number as NUMBER,'" & InputBox("Enter title/header for this report: ", "Report Title", "List of Faculties and Utilities") & "' as TITLE from tblefacultyutility order by field")
                Else : DataSet("select '--' as ID,'No items...' as NAME,'No items...' as DEPARTMENT,'--' as NUMBER,'List of Faculties and Utilities' as TITLE order by DEPARTMENT")
                End If
                Return "FacultyUtility.rpt"
        End Select
        Return Nothing
    End Function
End Module
