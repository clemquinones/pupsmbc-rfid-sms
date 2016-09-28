Imports MySql.Data.MySqlClient
Public Class frmSchedule
    Public Sub reLOAD()
        lvSched.Items.Clear()
        dR = DataReader("select course,yearlevel,section from tbleschedule")
        If Not dr.Read Then Exit Sub
        cmbCourse.Items.Clear()
        Do
            If Not cmbCourse.Items.Contains(dr.Item(0)) Then cmbCourse.Items.Add(dr.Item(0))
            If Not cmbYearLevel.Items.Contains(dr.Item(1).ToString) Then cmbYearLevel.Items.Add(dr.Item(1))
            If Not cmbSection.Items.Contains(dr.Item(2).ToString) Then cmbSection.Items.Add(dr.Item(2))
        Loop While dr.Read
        dr.Close() : CONclose()

        cmbCourse.Sorted = True
        cmbYearLevel.Sorted = True
        cmbSection.Sorted = True
    End Sub


    Private Sub frmSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reLOAD()
        viewLV(cmbCourse.Text)
    End Sub
    Public Sub viewLV(Optional ByVal Course As String = "All", Optional ByVal YearLevel As Integer = 0, Optional ByVal Section As Integer = 0)
        dR = DataReader("select * from tbleschedule" & IIf(Course Like "All", "", _
            " where course='" & Course & "'" & IIf(YearLevel <= 0, "", _
            " and yearlevel=" & YearLevel & IIf(Section <= 0, "", " and section=" & Section))))
        Dim li As ListViewItem : lvSched.Items.Clear()
        If Not dr.Read Then Exit Sub
        'Dim Day As Integer = 0
        'course,year,sec,mons,mone,monsu,tues,tuee,tuesu,weds,wede,wedsu,thus,thue,thusu

        Do
            li = lvSched.Items.Add(dr.Item(0))
            For x As Integer = 5 To 23 Step 3
                'If Not lvSched.Items(lvSched.Items.Count - 1).SubItems(1).Text.Contains(dr.Item(x)) Then
                li.SubItems.Add(dr.Item(x))
                If li.SubItems(x - 3).Text.Contains(dr.Item(x)) Then
                    li.SubItems.Add(dr.Item(x - 3).ToString & " - " & dr.Item(x - 2).ToString)

                    '  lvSched.Items(lvSched.Items.Count - 1).SubItems(2).Text = dr.Item(x - 2) & " - " & dr.Item(x - 1)
                    '  lvSched.Items(lvSched.Items.Count - 1).SubItems(1).Text = dr.Item(x)
                End If
            Next
        Loop While dr.Read

c:      dr.Close() : CONclose()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        '  If Not cmbCourse.Items.Contains(cmbCourse.Text) Then toHL(cmbCourse) : Exit Sub
        '  If Not cmbYearLevel.Items.Contains(cmbYearLevel.Text) And Not cmbCourse.Text Like "All" Then toHL(cmbYearLevel) : Exit Sub
        '  If Not cmbSection.Items.Contains(cmbSection.Text) And Not cmbCourse.Text Like "All" Then toHL(cmbSection) : Exit Sub
        '   Dim YLevel, Sec As Integer, Course As String
        '   If Not cmbCourse.Text.Trim Like "--Choose course" Then Course = cmbCourse.Text
        '   If Not cmbYearLevel.Text.Trim Like "--Year" Then YLevel = cmbYearLevel.Text
        '   If Not cmbSection.Text.Trim Like "--Sec" Then Sec = cmbSection.Text
        '  viewLV(Course, YLevel, Sec)
        viewLV(cmbCourse.Text, CInt(cmbYearLevel.Text), CInt(cmbSection.Text))
    End Sub
End Class