Public Class frmReportDirectory

    Private Sub frmReportDirectory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPath.Text = AppPath
        lDefDir.Text = AppPath
        chkDefault.Checked = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
BROWSE: Dim fbd As New FolderBrowserDialog
        If Not fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
        If Not IO.Directory.Exists(fbd.SelectedPath) Then
            MB("The directory doesn't exists!", "!")
            GoTo BROWSE
        Else
            txtPath.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub chkDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefault.CheckedChanged
        txtPath.Enabled = Not chkDefault.Checked
        btnBrowse.Enabled = Not chkDefault.Checked
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MB("Do you want to set-up this step later?", "?") = "y" Then Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error Resume Next
        If Not chkDefault.Checked And txtPath.Text.Trim = "" Then MB("Enter valid path", "!") : toHL(txtPath) : Exit Sub
        If Not IO.Directory.Exists(txtPath.Text) Then MB("The directory doesn't exists!", "!") : toHL(txtPath) : Exit Sub
        If MB("REPORT FOLDER PATH: " & IIf(chkDefault.Checked, lDefDir.Text, txtPath.Text) & vbCr & vbCr & "Do you want to save this path for reports?", "?") = "n" Then Exit Sub
        My.Settings.REPORT_FOLDER_PATH = IIf(chkDefault.Checked, lDefDir.Text, txtPath.Text) & "\REPORTS"
        My.Settings.Save()
        If Not IO.Directory.Exists(My.Settings.REPORT_FOLDER_PATH) Then IO.Directory.CreateDirectory(My.Settings.REPORT_FOLDER_PATH)
        IO.File.Copy(AppPath & "\REPORTS\Departments.rpt", My.Settings.REPORT_FOLDER_PATH & "\Departments.rpt")
        IO.File.Copy(AppPath & "\REPORTS\FacultyUtility.rpt", My.Settings.REPORT_FOLDER_PATH & "\FacultyUtility.rpt")
        IO.File.Copy(AppPath & "\REPORTS\ParentList.rpt", My.Settings.REPORT_FOLDER_PATH & "\ParentList.rpt")
        IO.File.Copy(AppPath & "\REPORTS\StudentList.rpt", My.Settings.REPORT_FOLDER_PATH & "\StudentList.rpt")
        IO.File.Copy(AppPath & "\REPORTS\StudentLogRecords.rpt", My.Settings.REPORT_FOLDER_PATH & "\StudentLogRecords.rpt")
        IO.File.Copy(AppPath & "\REPORTS\SystemLogs.rpt", My.Settings.REPORT_FOLDER_PATH & "\SystemLogs.rpt")

        IO.File.Copy(AppPath & "\REPORTS\Departments.vb", My.Settings.REPORT_FOLDER_PATH & "\Departments.vb")
        IO.File.Copy(AppPath & "\REPORTS\FacultyUtility.vb", My.Settings.REPORT_FOLDER_PATH & "\FacultyUtility.vb")
        IO.File.Copy(AppPath & "\REPORTS\ParentList.vb", My.Settings.REPORT_FOLDER_PATH & "\ParentList.vb")
        IO.File.Copy(AppPath & "\REPORTS\StudentList.vb", My.Settings.REPORT_FOLDER_PATH & "\StudentList.vb")
        IO.File.Copy(AppPath & "\REPORTS\StudentLogRecords.vb", My.Settings.REPORT_FOLDER_PATH & "\StudentLogRecords.vb")
        IO.File.Copy(AppPath & "\REPORTS\SystemLogs.vb", My.Settings.REPORT_FOLDER_PATH & "\SystemLogs.vb")

        MB("Saved!")
        Me.Close()
    End Sub
End Class