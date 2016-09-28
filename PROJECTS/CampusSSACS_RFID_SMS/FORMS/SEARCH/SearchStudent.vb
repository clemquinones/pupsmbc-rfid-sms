Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources

Public Class frmSearchStudent
#Region "FRMSEARCH"

    Public Where As String = Nothing
    Public SQLCOMMAND As String = "select s.studno,s.fname,s.lname,m.rfidtagid from tblestudent s,tblemonitoringlogs m where m.rfidtagid=s.rfidtagid "
    Public TimeStart As String = "", TimeEnd As String = "", DateStart As String = "", DateEnd As String = "", Dept As String = ""

    Private Sub frmSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignConnection()
        cmbLog.SelectedIndex = 0
        DisplayResult(SQLCOMMAND & " order by m.datetime desc")
        FillCmbCourse()
        txtKey.Focus()
    End Sub


#Region "LV_RESULT_KEYDOWN"
    Private Sub lvResult_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvResult.KeyDown
        selected = lvResult.SelectedIndices(0)
        Call txtKey_KeyDown(sender, e)
        If e.KeyCode = Keys.Enter Then
            If lvResult.SelectedIndices.Count <= 0 Then MB("No selected record!") : Return
            Dim dR As MySqlDataReader = DataReader("select studno,lname,fname,mname,course,yearlevel,section,picture from tblestudent where studno='" & lvResult.Items(lvResult.SelectedIndices(0)).Text & "'")
            If Not dR.Read Then Return
            With frmPreview
                .lblStudNo.Text = dR.Item(0)
                .lblName.Text = dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3)
                .lblCourseYrSec.Text = dR.Item(4) & " " & dR.Item(5) & "-" & dR.Item(6)
                dR.Close()
                displayPic(.lblStudNo.Text, .pbPic, "studno")
                Dim dR2 As MySqlDataReader = DataReader("select m.logstate,m.datetime from tblemonitoringlogs m,tblestudent s where m.rfidtagid=s.rfidtagid and s.studno='" & lvResult.Items(lvResult.SelectedIndices(0)).Text & "' order by m.datetime desc")
                .LV.Items.Clear()
                Dim li As New ListViewItem
                For Each item In dR2
                    li = .LV.Items.Add(dR2.Item(0))
                    li.SubItems.Add(getDateTime(dR2.Item(1), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
                Next
                dR2.Close()
                .lblRecCounts.Text = "Record counts: " & .LV.Items.Count
                Me.Hide()
                frmLessOpacity.ShowDialog()
            End With
        End If
    End Sub
#End Region

    Dim selected As Integer = -1
#Region "TXTKET_KEYDOWN"

    Private Sub txtKey_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.GotFocus
        TextClicked(txtKey, "Search") : txtKey.ForeColor = Color.Black
    End Sub
    Private Sub txtKey_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKey.KeyDown
        For Each item As ListViewItem In lvResult.Items
            item.ForeColor = Color.White
            item.BackColor = Color.Black
        Next
        If lvResult.Items.Count <= 0 Then Return
        If e.KeyCode = Keys.Down Then
            On Error Resume Next
            'If lvResult.SelectedIndices(0) >= lvResult.Items.Count - 1 Then Return
            If Not selected >= lvResult.Items.Count - 1 Then selected += 1
            displaySelected()
        End If
        If e.KeyCode = Keys.Up Then
            On Error Resume Next
            ' If lvResult.SelectedIndices(0) <= 0 Then Return
            If Not selected <= 0 Then selected -= 1
            displaySelected()
        End If
        If e.KeyCode = Keys.Enter Then
            If selected < 0 Then Return
            With frmPreview
                Dim dR As MySqlDataReader = DataReader("select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section from tblestudent s,tblemonitoringlogs m where m.rfidtagid=s.rfidtagid" & _
                   " and s.studno='" & lvResult.Items(selected).Text & "'")
                If Not dR.Read Then dR.Close() : CONNclose() : Return
                .lblName.Text = dR.Item(1) & " " & dR.Item(2) & " " & dR.Item(3)
                .lblStudNo.Text = dR.Item(0)
                .lblCourseYrSec.Text = dR.Item(4) & " " & dR.Item(5) & "-" & dR.Item(6)
                displayPic(lvResult.Items(selected).Text, .pbPic, "studno")
                dR.Close() : CONNclose()
                Me.Hide()
                frmLessOpacity.Show()
            End With
        End If
    End Sub
#End Region

#Region "CHECKED_CHANGED"
    Private Sub chkTimeRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTimeRange.CheckedChanged
        If cmbLog.Enabled = True And cmbLog.Text.Contains("All Read") Or cmbLog.Text.Contains("This Week") Then dtpStartT.Enabled = False : dtpEndT.Enabled = False : Return
        dtpStartT.Enabled = chkTimeRange.Checked
        dtpEndT.Enabled = chkTimeRange.Checked
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartD.Enabled = chkDate.Checked
        dtpEndD.Enabled = chkDate.Checked
        dtpStartT.Enabled = chkDate.Checked
        dtpEndT.Enabled = chkDate.Checked
        cmbLog.Enabled = Not chkDate.Checked
    End Sub

    Private Sub chkDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDept.CheckedChanged
        cmbCourse.Enabled = chkDept.Checked
    End Sub
#End Region

    Private Sub txtKey_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.LostFocus
        If txtKey.Text.Trim = "" Or txtKey.Text.Trim.ToLower = "search" Then txtKey.Text = "Search" : txtKey.ForeColor = Color.DimGray
    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged
        If txtKey.Text.Trim.ToLower = "search" Then Return
        DisplayResult()
    End Sub

    Public Sub FillCmbCourse()
        cmbCourse.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select code from tblecodedesc where field like '%Course%' order by code")
        cmbCourse.Items.Add("All Department")
        For Each item As Object In dR
            cmbCourse.Items.Add(dR.Item(0))
        Next
        dR.Close()
    End Sub

    Public Sub DisplayResult(Optional ByVal sql As String = Nothing)
        If sql = Nothing Then sql = SQLCOMMAND & Where & " and (s.studno like '%" & txtKey.Text.Trim & "%' or s.fname like '%" & txtKey.Text.Trim & "%' or s.lname like '%" & txtKey.Text.Trim & "%') order by m.datetime desc"
        lvResult.Items.Clear()
        Dim dR As MySqlDataReader = DataReader(sql)
        For Each item As Object In dR
            Dim meron As Boolean = False
            For Each lvItems As ListViewItem In lvResult.Items
                If dR.Item(0) = lvItems.Text Then meron = True
            Next
            If meron = False Then lvResult.Items.Add(dR.Item(0)).SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3).ToString.Substring(0, 1) & ".")
        Next

        If lvResult.Items.Count <= 0 Then : selected = -1
            lvResult.Items.Add("No items...").SubItems.Add("No items...") : pbPic.Image = NoPicture
        Else
            selected = 0 : displayPic(lvResult.Items(0).Text, pbPic, "studno") : displaySelected()
        End If

        dR.Close()
    End Sub

    Public Sub displaySelected()
        lvResult.Items(selected).ForeColor = Color.Yellow
        lvResult.Items(selected).BackColor = Color.Violet
        displayPic(lvResult.Items(selected).Text, pbPic, "studno")
        Dim dR As MySqlDataReader = DataReader("select studno,lname,fname,mname,course,yearlevel,section from tblestudent where studno='" & lvResult.Items(selected).Text & "'")
        For Each item As Object In dR
            lblStudNo.Text = dR.Item(0)
            lblName.Text = dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3)
            lblDept.Text = dR.Item(4) & " " & dR.Item(5) & "-" & dR.Item(6)
        Next
        dR.Close()
    End Sub

#End Region

    Private Sub cmbLog_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLog.TextChanged
        If cmbLog.Text.Contains("All Read") Or cmbLog.Text.Contains("This Week") Then chkTimeRange.Checked = False : dtpStartT.Enabled = False : dtpEndT.Enabled = False Else dtpStartT.Enabled = True : dtpEndT.Enabled = True

        If dtpStartT.Enabled = True And cmbLog.Text.Contains("") And Format(dtpEndT.Value, "HH:mm:ss") < Format(dtpStartT.Value, "HH:mm:ss") Then MB("Illegal set of end time") : dtpEndT.Focus() : Return

        btnFilter.Enabled = True
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Sounds(AUDIO.CLICK)
        Where = Nothing : Dept = ""
        If chkTimeRange.Checked = True Then
            If Format(dtpEndT.Value, "HH:mm:ss") < Format(dtpStartT.Value, "HH:mm:ss") Then MB("Illegal set of end time.") : dtpStartT.Focus() : Return
            TimeStart = Format(dtpStartT.Value, "HH:mm:ss") : TimeEnd = Format(dtpEndT.Value, "HH:mm:ss")
        Else
            TimeStart = "01:00:00" : TimeEnd = "23:59:59"
        End If
        If chkDate.Checked = True Then
            If Format(dtpEndD.Value, "yyyy/MM/dd") < Format(dtpStartD.Value, "yyyy/MM/dd") Then MB("Illegal set of end date.") : dtpEndD.Focus() : Return
            DateStart = " and m.datetime between '" & Format(dtpStartD.Value, "yyyy/MM/dd") & " " & TimeStart & "'"
            DateEnd = " and '" & Format(dtpEndD.Value, "yyyy/MM/dd") & " " & TimeEnd & "'"
        ElseIf cmbLog.Enabled = True Then
            If cmbLog.Text.Contains("Today") Then
                DateStart = " and m.datetime between '" & Format(Now, "yyyy/MM/dd") & " " & TimeStart & "'"
                DateEnd = " and '" & Format(Now, "yyyy/MM/dd") & " " & TimeEnd & "'"
            ElseIf cmbLog.Text.Contains("Yesterday") Then
                DateStart = " and m.datetime between '" & Format(Now, "yyyy/MM") & "/" & (CInt(Format(Now, "dd")) - 1) & " " & TimeStart & "'"
                DateEnd = " and '" & Format(Now, "yyyy/MM") & "/" & (CInt(Format(Now, "dd")) - 1) & " " & TimeEnd & "'"
            ElseIf cmbLog.Text.Contains("This Week") Then
                If Format(Now, "dd") - Now.DayOfWeek <= 0 Then
                    DateStart = " and m.datetime between '" & Format("yyyy") & "/" & Format(Now, "MM") & "/01" & " " & TimeStart & "'"
                Else
                    DateStart = " and m.datetime between '" & Format("yyyy") & "/" & Format(Now, "MM") & "/" & (Format(Now, "dd") - Now.DayOfWeek) & " " & TimeStart & "'"
                End If
                DateEnd = " and '" & Format(Now, "yyyy/MM/dd") & " " & TimeEnd & "'"
            ElseIf cmbLog.Text = "All Read" Then
                DateStart = "" : DateEnd = ""
            End If
        End If
        If cmbCourse.Enabled = True And Not cmbCourse.Text = "" Then Dept = IIf(cmbCourse.Text Like "All Department", "", " and s.course='" & cmbCourse.Text & "'")

        Where = DateStart & DateEnd & Dept

        DisplayResult(SQLCOMMAND & Where & " order by m.datetime desc")
    End Sub

    Private Sub dtpStartT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpStartT.GotFocus
        If cmbLog.Enabled = True And cmbLog.Text.Contains("All Read") Or cmbCourse.Text.Contains("This Week") Then dtpStartT.Enabled = False
    End Sub

    Private Sub dtpEndT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEndT.GotFocus
        If cmbLog.Enabled = True And cmbLog.Text.Contains("All Read") Or cmbCourse.Text.Contains("This Week") Then dtpEndT.Enabled = False
    End Sub
   

    Private Sub cmbLog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLog.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
    End Sub

     

    Private Sub bRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefresh.Click
        Call frmSearch_Load(sender, e)
    End Sub

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
