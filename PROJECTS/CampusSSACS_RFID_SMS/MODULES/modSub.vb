Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CampusSSACS_RFID_SMS.My.Resources
'Imports GsmComm.GsmCommunication
'Imports GsmComm.PduConverter
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
        UPDATEr("tbleid", "value=value+1", "field like '" & Field & "%'")
    End Sub

    Public Sub LOGS(ByVal Action As String)
        INSERTr("tblemonitoring", gIDVal("logs") & ",'" & logID & "','" & logUserType & "','" & v(Action) & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "'")
        incrementID("logs")
    End Sub


    Public Sub displayPic(ByVal ID As String, ByRef Sender As Object, Optional ByVal Field As String = "rfidtagid")
        Dim dR As MySqlDataReader = DataReader("select studno,picture from tblestudent where " & IIf(Not Field Like "rfidtagid", Field, "rfidtagid") & "='" & ID & "'")
        Try : If ID.Trim = "" Then Return
            If Not dR.Read Then Return
            Dim imgByte(dR.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dR.GetBytes(1, 0, imgByte, 0, imgByte.Length) : dR.Close()
            Dim mS As New MemoryStream(imgByte)
            Sender.Image = Image.FromStream(mS)
        Catch ex As Exception
            Sender.Image = Resources.NoPicture
            CONNclose()
        End Try
    End Sub
    Public Sub viewUpdateStud(ByVal STUDNO As String)
        frmEncodeStudInfo.Close()
        frmEncodeStudInfo.Tag = "Edit"
        frmEncodeStudInfo.Tag_STUDNO = STUDNO
        frmEncodeStudInfo.ShowDialog()
    End Sub

    Public Sub AssignConnection()
        ReadConnectionSetup()
        conN = New MySqlConnection("data source=" & DataSource & "; user id=" & dbUserID & "; password=" & dbPassword & "; database=" & DB & ";")
        openCONN() : CONNclose()
        If recCount("tbleusers", "usertype like '%Administrator%'") <= 0 Then
            frmEmptyDatabase.ShowDialog()
            MB("Locate the report directory", , , "System report documents directory")
            frmReportDirectory.ShowDialog()
            If Not IO.File.Exists(My.Settings.SendSMS_PATH) Then
                MB("GSM Module configuration." & vbCr & vbCr & "Configure the GSM Module settings.")
                frmGSMDeviceConfig.ShowDialog()
            End If
            Return
        End If
        RFIDConnected = False

        LastLogInDetectedRFID = Nothing
        LastLogOutDetectedRFID = Nothing
    End Sub

    Public Sub ReadConnectionSetup()
        With My.Settings
            If .DATABASE = "" Then
                frmFirstTimeRunOnce.ShowDialog()
                frmConnectionSetup.ShowDialog()
            End If
            PCname = .PCNAME
            DataSource = .SERVER
            dbUserID = .USERID
            dbPassword = .PASSWORD
            DB = .DATABASE
            SMSPORT = CInt(.SMS_PORT.Replace("COM", ""))
            SMSBAUDRATE = .SMS_BAUDRATE
            SMSTIMEOUT = .SMS_TIMEOUT
            SMSSENDDELAY = .SMS_SENDDELAY
            SMSVALIDITY = .SMS_VALIDITY
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
        For Each item In dR
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
        With frmStudViewDetails
            .Tag = ID
            .lblName.Text = "------"
            .lblStudNo.Text = "------"
            .lblCourseYrSec.Text = "------"
            .lblAddress.Text = "------"
            .pbPic.Image = My.Resources.NoPicture
            Dim dR As MySqlDataReader = DataReader("select fname,mname,lname,course,yearlevel,section,address from tblestudent where studno='" & .Tag & "'")
            Dim ctr As Integer = 0
            If dR.Read Then
                .lblName.Text = dR.Item(2) & ", " & dR.Item(0) & " " & dR.Item(1)
                .lblStudNo.Text = .Tag
                .lblCourseYrSec.Text = dR.Item(3) & " " & dR.Item(4) & "-" & dR.Item(5)
                .lblAddress.Text = dR.Item(6)
                ctr += 1
            End If
            dR.Close()
            displayPic(ID, .pbPic, "studno")
            .Show()
        End With
    End Sub


    Public Sub ViewReport(ByVal REPORT_FILE As RPT, Optional ByVal strSQL As String = "")
        Try
            If frmVReport.Visible = True Then frmVReport.Close()
            Dim CryRpt As New ReportDocument
            CryRpt.Load(My.Settings.REPORT_FOLDER_PATH & "\" & getREPORTFILE(REPORT_FILE, strSQL))
            CryRpt.SetDataSource(dS.Tables(0))
            frmVReport.crvReport.ReportSource = CryRpt
            frmVReport.crvReport.Refresh()
            frmVReport.Show()
        Catch ex As Exception
            MB("Error Description: " & ex.Message & vbCr & vbCr & "Cannot find report files to preview." & vbCr & "Check the Crystal Report Files Path", "x")
        End Try
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
        ' If Not FORMSENDER Is Nothing Then FORMSENDER.Cursor = Cursors.WaitCursor
        getREPORTFILE = Nothing
        Select Case (report)
            Case 0
                If recCount("tblestudent s, tblemonitoringlogs m", "s.rfidtagid=m.rfidtagid") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select s.studno as SN,concat(s.lname,', ',s.fname,' ',s.mname) as NAME, s.course as COURSE, s.yearlevel as YR, s.section as SC,m.logstate as DETECTION, m.datetime as DATELOG,(select datetime from tblemonitoringlogs order by datetime limit 1) as START_DT,(select datetime from tblemonitoringlogs order by datetime desc limit 1) as END_DT,'Student Monitoring Logs' as TITLE from tblestudent s, tblemonitoringlogs m where s.rfidtagid=m.rfidtagid order by m.datetime")
                Else : DataSet("select 'No items...' SN,'No items...' as NAME,'----' as COURSE,'-' as YR,'-' as SC,'--' as DETECTION, '' as DATELOG, 'First read' as START_DT,'last read' as END_DT,'Student Monitoring Logs' as TITLE")
                End If
                getREPORTFILE = "StudentLogRecords.rpt"
            Case 1
                If recCount("tblestudent s", "1 order by COURSE") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select studno as SN, concat(lname,', ',fname,' ',mname) as NAME, course as COURSE, yearlevel as YR, section as SC, status as STATUS, gender as GENDER, number as NUMBER, '" & InputBox("Enter title/header for this report: ", "Report Title", "List of all registered students") & "' as TITLE from tblestudent order by COURSE")
                Else : DataSet("select 'No items...' as CODE, 'No items...' as DESCRIPTION, '-' as YEARS, '-' as STUDCOUNT, 'List of Departments' as TITLE order by CODE")
                End If
                getREPORTFILE = "StudentList.rpt"
            Case 2
                If recCount("tblemonitoring m") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select cd.code as CODE, cd.description as DESCRIPTION, cd.year as YEARS, (select count(*) from tblestudent where course=cd.code) as STUDCOUNT, '" & InputBox("Enter title/header for this report: ", "Report Title", "Department List") & "' as TITLE from tblecodedesc cd order by cd.code")
                Else : DataSet("select '-' as ID, 'No items...' as USERID, 'No items...' as USERTYPE, 'No items...' as ACTION, '--' as DATELOG, 'Start read' as START_DT, 'last read' as END_DT, 'System User Logs' as TITLE order by ID")
                End If
                getREPORTFILE = "SystemLogs.rpt"
            Case 3
                If recCount("tblecodedesc") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select cd.code as CODE, cd.description as DESCRIPTION, cd.year as YEARS, (select count(*) from tblestudent where course=cd.code) as STUDCOUNT, '" & InputBox("Enter title/header for this report: ", "Report Title", "Department List") & "' as TITLE from tblecodedesc cd order by cd.code")
                Else : DataSet("select 'No items...' as CODE, 'No items...' as DESCRIPTION, '-' as YEARS, '-' as STUDCOUNT, 'List of Departments' as TITLE order by CODE")
                End If
                getREPORTFILE = "Departments.rpt"
            Case 4 : DataSet(IIf(strSQL <> "", strSQL, "select s.studno as SN,s.course as COURSE,concat(s.yearlevel,'-',s.section) as YS,concat(p.fname,' ',p.lname) as NAME, p.relation as RELATION,p.number as NUMBER,if(p.block=false,'ON','OFF') as ADVISORY,'" & InputBox("Enter title/header for this report: ", "Report Title", "Parent List") & "' as TITLE from tblestudent s,tbleparentinfo p where p.rfidtagid=s.rfidtagid order by s.course"))
                getREPORTFILE = "ParentList.rpt"
            Case 5
                getREPORTFILE = "Messages.rpt"
            Case 6
                If recCount("tblefacultyutility") > 0 Then
                    If strSQL <> "" Then DataSet(strSQL) Else DataSet("select ID as ID,concat(fname,' ',mname,' ',lname) as NAME, field as DEPARTMENT, number as NUMBER,'" & InputBox("Enter title/header for this report: ", "Report Title", "List of Faculties and Utilities") & "' as TITLE from tblefacultyutility order by field")
                Else : DataSet("select '--' as ID,'No items...' as NAME,'No items...' as DEPARTMENT,'--' as NUMBER,'List of Faculties and Utilities' as TITLE order by DEPARTMENT")
                End If
                getREPORTFILE = "FacultyUtility.rpt"
        End Select
        '  If Not FORMSENDER Is Nothing Then FORMSENDER.Cursor = Cursors.Default
        Return getREPORTFILE
    End Function
End Module
