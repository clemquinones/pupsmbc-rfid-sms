Imports MySql.Data.MySqlClient

Public Class frmDeptSendCustomize
    Public Customized As Boolean = False
    Dim DepClick As Boolean = False, YrClick As Boolean = False, SecClick As Boolean = False
    Public CoYeSec As String = ""

    Private Sub frmDeptSendCustomize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    'Public Recipients() As String = Nothing
    Private Sub frmDeptSendCustomize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLVdept()
        CoYeSec = Nothing
        Customized = False
    End Sub

    Public Sub viewLVdept()
        Dim dR As MySqlDataReader = DataReader("select code,description from tblecodedesc where field like '%Course%' order by code")
        lvDept.Items.Clear()
        If Not dR.Read Then dR.Close() : Return
        Dim li As New ListViewItem
        Do While dR.Read
            li = lvDept.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
        Loop
        dR.Close()
    End Sub
    Public Sub viewLVyear(ByVal Code As String)
        lvYear.Items.Clear()
        If Code.Trim = "" Then Return
        Dim years As Integer = CInt(getVal("tblecodedesc", "year", "code like '%" & Code & "%'"))
        If years <= 0 Then Return
        For i As Integer = 0 To years - 1
            lvYear.Items.Add(i + 1)
        Next
        '   lvYear.Items(0).Selected = True
        '    dR.Close()
    End Sub
    Public Sub viewLVsection(ByVal Code As String, ByVal Year As String)
        lvSections.Items.Clear()
        If Code.Trim = "" Or Year.Trim = "" Then Return
        Dim section As String = getVal("tblecodedesc", "section", "code like '%" & Code & "%'")
        If section.Trim = "" Then Return
        Dim secNum As Integer = 0
        For Each s As String In Split(section, ";")
            If s.First = Year Then secNum = CInt(s.Substring(2)) : Exit For
        Next
        If secNum = 0 Then Return
        For i As Integer = 0 To secNum - 1 : lvSections.Items.Add(i + 1) : Next
        '  lvSections.Items(0).Selected = True : dR.Close()
    End Sub

    Private Sub lvDept_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDept.Click
        DepClick = True : YrClick = False : SecClick = False
    End Sub
    Private Sub lvYear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvYear.Click
        DepClick = False : YrClick = True : SecClick = False
    End Sub


    Private Sub lvSections_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSections.Click
        DepClick = False : YrClick = False : SecClick = True
    End Sub


    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to continue?", "?") = "n" Then Exit Sub
        Dim Recip As String = "", i As Integer = 0
        If CoYeSec Is Nothing Then MB("No customation is happen. The default recipients(All students) will be used.") : Me.Close() : Return
        For Each item In CoYeSec.Split(vbNewLine)
            item = item.Replace(vbNewLine, "").Trim
            If Not item = "" Then
                Dim part() As String = item.Split(" ")
                ' If Not dR.IsClosed Then dR.Close()
                Dim s As String = ""
                s = getVal("tblestudent", "number", "course = '" & part(0).Trim & "' and yearlevel=" & part(1).Trim & " and section=" & part(2).Trim)
                'If Not dR.IsClosed Then dR.Close()
                If s <> "" Or Not s = Nothing Then i += 1 : Recip &= s & ";"
            End If
        Next
        If Recip = "" Then MB("No mobile numbers recipients is gathered.") : Me.Close() : Return
        Dim Students(i - 1) As String : i = 0
        For Each item In Split(Recip, ";")
            If Not item.Trim = "" Or Not item = Nothing Then Students(i) = item.Replace(";", "") : i += 1
        Next

        Customized = True
        frmAnnouncement.Students = Students
        Me.Close() : Return
    End Sub




    Private Sub tmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRead.Tick
        On Error Resume Next
        If CoYeSec.Contains(vbNewLine & vbNewLine) Then CoYeSec = CoYeSec.Replace(vbNewLine & vbNewLine, vbNewLine)
        Dim DepSel As Integer = lvDept.SelectedIndices(0), YeSel As Integer = lvYear.SelectedIndices(0), SeSel As Integer = lvSections.SelectedIndices(0)

        If DepClick = True Then : DepClick = False 'Department LV
            lvYear.Items.Clear() : lvSections.Items.Clear()
            If lvDept.Items.Count <= 0 Then Return
            If DepSel < 0 Then
                '   lvDept.Items(DepSel).ForeColor = Color.Black : lvDept.Items(DepSel).BackColor = Color.White
                Return
            End If
            '  For i As Integer = 0 To lvDept.Items.Count - 1 : lvDept.Items(i).ForeColor = Color.Black : lvDept.Items(i).BackColor = Color.White : Next
            ' lvDept.Items(DepSel).ForeColor = Color.White : lvDept.Items(DepSel).BackColor = Color.Gray

            viewLVyear(lvDept.Items(DepSel).Text)
            If lvYear.Items.Count <= 0 Or lvDept.Items(DepSel).Checked = False Then Return
            For i As Integer = 0 To lvYear.Items.Count - 1
                If CoYeSec Like (lvDept.Items(DepSel).Text & " " & lvYear.Items(i).Text) Then
                    lvYear.Items(i).Checked = True
                Else
                    lvYear.Items(i).Checked = False
                End If
            Next
        End If

        If YrClick = True Then : YrClick = False 'Year Level LV
            lvSections.Items.Clear()
            If lvYear.Items.Count <= 0 Then Return
            If YeSel < 0 Then
                '     lvYear.Items(YeSel).ForeColor = Color.Black : lvYear.Items(YeSel).BackColor = Color.White
                Return
            End If

            viewLVsection(lvDept.Items(DepSel).Text, lvYear.Items(YeSel).Text)

            If lvYear.CheckedItems.Count <= 0 Then
                lvDept.Items(DepSel).Checked = False
                For i As Integer = 0 To lvSections.Items.Count - 1 : lvSections.Items(i).Checked = False : Next
                Return
            End If
            ' For i As Integer = 0 To lvYear.Items.Count - 1 : lvYear.Items(i).ForeColor = Color.Black : lvYear.Items(i).BackColor = Color.White : Next
            '  lvYear.Items(YeSel).ForeColor = Color.White : lvYear.Items(YeSel).BackColor = Color.Gray

            If lvSections.Items.Count <= 0 Then Return
            For i As Integer = 0 To lvSections.Items.Count - 1
                If CoYeSec.ToLower Like (lvDept.Items(DepSel).Text & " " & lvYear.Items(YeSel).Text & " " & lvSections.Items(i).Text).ToLower Then
                    lvSections.Items(i).Checked = True
                Else : lvSections.Items(i).Checked = False
                End If
            Next
        End If

        If SecClick = True Then : SecClick = False 'Section LV
            If lvSections.Items.Count <= 0 Then Return
            If SeSel < 0 Then Return
            '    For i As Integer = 0 To lvSections.Items.Count - 1
            '       lvSections.Items(i).ForeColor = Color.Black
            '   lvSections.Items(i).BackColor = Color.White
            '   Next
            '      lvSections.Items(SeSel).ForeColor = Color.White : lvSections.Items(SeSel).BackColor = Color.Gray

            If lvSections.CheckedItems.Count <= 0 Then
                lvYear.Items(YeSel).Checked = False
                If lvYear.CheckedItems.Count <= 0 Then lvDept.Items(DepSel).Checked = False
                For Each item As String In CoYeSec.Split(vbNewLine)
                    If item Like (lvDept.Items(DepSel).Text & " " & lvYear.Items(YeSel).Text) Then CoYeSec = CoYeSec.Replace(item, "") : Exit For
                Next
                Return
            End If

            For i As Integer = 0 To lvSections.Items.Count - 1
                If CoYeSec.ToLower Like (lvDept.Items(DepSel).Text & " " & lvYear.Items(YeSel).Text & " " & lvSections.Items(i).Text).ToLower Then
                    CoYeSec = CoYeSec.Replace(lvDept.Items(DepSel).Text & " " & lvYear.Items(YeSel).Text & " " & lvSections.Items(i).Text & vbNewLine, "")
                End If

                If lvSections.Items(i).Checked = True Then
                    CoYeSec &= lvDept.Items(DepSel).Text & " " & lvYear.Items(YeSel).Text & " " & lvSections.Items(i).Text & vbNewLine
                    lvDept.Items(DepSel).Checked = True
                    lvYear.Items(YeSel).Checked = True
                End If
            Next
        End If
    End Sub
End Class