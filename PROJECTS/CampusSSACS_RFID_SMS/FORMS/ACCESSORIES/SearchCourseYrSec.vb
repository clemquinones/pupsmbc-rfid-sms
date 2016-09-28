
Public Class frmSearchCourseYrSec
    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If cmbCourse.Text = "" Then MB("Empty field cannot accept.") : cmbCourse.Focus() : Return
        If Me.Tag = "studentlogrecord" Then
            Dim where As String = " s.course like '%" & cmbCourse.Text.Trim & "%'"
            If Not cmbYear.Text.Trim = "" And Not cmbYear.Text.Contains("All Read") Then where &= " and s.yearlevel=" & cmbYear.Text.Trim
            If Not cmbSection.Text.Trim = "" And Not cmbSection.Text.Contains("All Read") Then where &= " and s.section=" & cmbSection.Text.Trim

            '    frmStudentLogRecord.viewLV("select tblestudent.studno,tblestudent.fname,tblestudent.mname,tblestudent.lname," & _
            '   "tblestudent.course,tblestudent.yearlevel,tblestudent.section,tbletempdetection.field," & _
            '   "tbletempdetection.datetime from tblestudent,tbletempdetection where (" & where & _
            '   ") and tbletempdetection.rfidtagid=tblestudent.rfidtagid order by tbletempdetection.datetime")

            frmStudentLogRecord.viewLV("select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section,m.logstate,m.datetime from tblestudent s,tblemonitoringlogs m where (" & where & ") and m.rfidtagid=s.rfidtagid ")
            frmStudentLogRecord.txtSearch.Text = ""
        ElseIf Me.Tag = "" Then
        ElseIf Me.Tag = "studentslist" Then
        End If

        Me.Close()
    End Sub

    Private Sub frmSearchCourseYrSec_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmStudentLogRecord.cmbSearchBy.SelectedIndex = 0
    End Sub

    Private Sub frmSearchCourseYrSec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub


    Private Sub frmSearchCourseYrSec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CourseItems()
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        If Not cmbCourse.Items.Contains(cmbCourse.Text.Trim) Then Return
        lblDes.Text = getVal("tblecodedesc", "description", "code='" & cmbCourse.Text.Trim & "' and field like '%course%'")
    End Sub
    Private Sub cmbCourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.TextChanged
        YearItems()
    End Sub
    Private Sub cmbYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbYear.TextChanged
        SectionItems()
    End Sub

    Sub YearItems()
        cmbYear.Items.Clear()
        cmbYear.Items.Add("All Read")
        If cmbCourse.Text.Trim = "" Then cmbYear.Enabled = False : cmbSection.Enabled = False Else cmbYear.Enabled = True : cmbSection.Enabled = True
        Dim YearNum As Integer = CInt(getVal("tblecodedesc", "year", "field like '%Course%' and code='" & cmbCourse.Text & "'"))
        For i As Integer = 1 To YearNum
            cmbYear.Items.Add(i)
        Next
        If cmbYear.Items.Count <= 0 Then cmbYear.Enabled = False : Return
        cmbYear.SelectedIndex = 0
        SectionItems()
    End Sub
    Sub SectionItems()
        cmbSection.Items.Clear()
        Dim meron As Boolean = False
        For i As Integer = 1 To CInt(getVal("tblecodedesc", "year", "code like '%" & cmbCourse.Text & "%' and field like '%Course%'"))
            If recCount("tblecodedesc", "year=" & i & " and code like '%" & cmbCourse.Text & "%' and field like '%Course%'") Then meron = True
        Next
        If Not meron Then cmbSection.Enabled = False : Exit Sub
        Dim YS As String = getVal("tblecodedesc", "section", "code='" & cmbCourse.Text & "'")
        For Each Yr As String In YS.Split(";")
            If Yr.Substring(0, 1) = cmbYear.Text Then
                Dim secNum1 As String = Replace(Yr, cmbYear.Text & ":", "")
                Dim secNum2 As Integer = CInt(Replace(secNum1, ";", "").Trim)
                cmbSection.Items.Add("All Read")
                For i As Integer = 1 To secNum2
                    cmbSection.Items.Add(i)
                Next
                Exit For
            End If
        Next
        cmbSection.Enabled = True
    End Sub
    Sub CourseItems()
        cmbCourse.Items.Clear()
        Dim dR As MySql.Data.MySqlClient.MySqlDataReader = DataReader("select course,yearlevel,section from tblestudent order by course")
        For Each item In dR
            If Not cmbCourse.Items.Contains(dR.Item(0)) Then cmbCourse.Items.Add(dR.Item(0))
            If Not cmbYear.Items.Contains(dR.Item(1)) Then cmbYear.Items.Add(dR.Item(1))
            If Not cmbSection.Items.Contains(dR.Item(2)) Then cmbSection.Items.Add(dR.Item(2))
        Next
        dR.Close()
        If cmbCourse.Items.Count <= 0 Then cmbCourse.Enabled = False : Return
        cmbCourse.SelectedIndex = 0
        YearItems()
    End Sub
End Class