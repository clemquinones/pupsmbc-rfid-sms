Imports MySql.Data.MySqlClient

Public Class frmStudentCounts

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Public Sub viewLV(Optional ByVal WHERE As String = "1")
        LV.Items.Clear() : Dim li As New ListViewItem
        lblCYS.Text = Me.Tag & IIf(cmbYearLevel.Text <> "All" And cmbYearLevel.Text <> "", " " & cmbYearLevel.Text & IIf(cmbSection.Text <> "All" And cmbSection.Text <> "", "-" & cmbSection.Text, ""), "")
        Dim dR As MySqlDataReader = DataReader("select studno,fname,mname,lname,course,yearlevel,section from tblestudent where course='" & Me.Tag & "' and " & WHERE & " order by yearlevel")
        If Not dR.Read Then dR.Close() : LV.Items.Add("No items..") : lblReCount.Text = "Record count: 0" : Return
        Do
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(3) & ", " & dR.Item(1) & " " & dR.Item(2))
            li.SubItems.Add(dR.Item(4))
            li.SubItems.Add(dR.Item(5))
            li.SubItems.Add(dR.Item(6))
        Loop While dR.Read
        dR.Close()
        lblReCount.Text = "Record count: " & LV.Items.Count
    End Sub

    Private Sub frmStudentCounts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' viewLV() : Return
        cmbYearLevel.Items.Clear() : cmbYearLevel.Items.Add("All")
        cmbSection.Items.Clear()
        For i As Integer = 1 To CInt(getVal("tblecodedesc", "year", "field like '%Course%' and code='" & Me.Tag & "'"))
            cmbYearLevel.Items.Add(i)
        Next : cmbYearLevel.Sorted = True
        viewLV()
    End Sub
    Sub Section()
        cmbSection.Items.Clear() : cmbSection.Enabled = False : cmbSection.Items.Add("All")
        If cmbYearLevel.Text = "" Or cmbYearLevel.Text = "All" Then lblCYS.Text = Me.Tag : viewLV() : Return
        cmbSection.Enabled = False
        Dim s As String = getVal("tblecodedesc", "section", "code='" & Me.Tag & "'")
        For Each Yr As String In Split(s, ";")
            If Yr.Substring(0, 1) = cmbYearLevel.Text Then
                Dim secNum1 As String = Replace(Yr, cmbYearLevel.Text & ":", "")
                Dim secNum2 As Integer = CInt(Replace(secNum1, ";", "").Trim)
                For i As Integer = 1 To secNum2
                    cmbSection.Items.Add(i)
                Next
                Exit For
            End If
        Next
        cmbSection.Enabled = True
        viewLV("yearlevel = " & cmbYearLevel.Text)
    End Sub

    Private Sub cmbYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYearLevel.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)

        If cmbYearLevel.Text = "All" Then lblCYS.Text = Me.Tag : viewLV() : Return
        Section()
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
        If cmbYearLevel.Text = "All" Then viewLV() : Return
        If cmbSection.Text = "All" Then viewLV("yearlevel=" & cmbYearLevel.Text) : Return

        viewLV("yearlevel=" & cmbYearLevel.Text & " and section=" & cmbSection.Text)
    End Sub

 
End Class