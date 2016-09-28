Imports MySql.Data.MySqlClient

Public Class frmBackupRestoreDB
    Public fbd As New FolderBrowserDialog
    Public ACTION As String = ""

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseB.Click
        fbd.Dispose()
BROWSE: If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = fbd.SelectedPath & "\_BACK_UP_" : toHL(txtPath)
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Sounds(AUDIO.CLICK)
        If ACTION = "BACKUP" Then
            If IO.Directory.Exists(My.Settings.BACKUP_PATH) Then chkDirectory.Checked = True Else chkDirectory.Checked = False
            txtPath.Text = IIf(IO.Directory.Exists(My.Settings.BACKUP_PATH), My.Settings.BACKUP_PATH, My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            txtBU_FileName.Text = IIf(My.Settings.BACKUP_FILENAME <> "", My.Settings.BACKUP_FILENAME, "db_campus_backup")
            gbQuestion.Hide() : gbBackUp.Show()
        ElseIf ACTION = "RESTORE" Then
            txtBUPathFile.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            gbQuestion.Hide() : gbRestore.Show()
        End If
        btnBack.Enabled = False
    End Sub

    Private Sub pbRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRestore.Click
        Sounds(AUDIO.CLICK)
        ACTION = "RESTORE"
    End Sub

    Private Sub pbBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBackUp.Click
        Sounds(AUDIO.CLICK)
        ACTION = "BACKUP"
    End Sub

    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        On Error Resume Next
        If txtBU_FileName.Text.Trim = "" Then MB("Enter back up file name!", "!") : toHL(txtBU_FileName) : Return
        If MB("The command file 'backup_setup.cmd' will run." & vbCr & vbCr & "Do you want to back the database now?", "?") = "n" Then Return
        If Not IO.Directory.Exists(fbd.SelectedPath & "\_BACK_UP_") Then MkDir(fbd.SelectedPath & "\_BACK_UP_")
        Cursor = Cursors.WaitCursor
        Dim DESTINATIONDIR As String = "set DESTINATIONDIR=" & txtPath.Text.Trim
        Dim CMD_CONTENT() As String = IO.File.ReadAllLines(My.Settings.BU_RES_CMD_PATH)
        Dim UPDATED_CMD_CONTENT As String = ""
        For i As Integer = 0 To CMD_CONTENT.Length - 1
            If CMD_CONTENT(i).Trim.ToLower.ToString.Contains("set action=") Then CMD_CONTENT(i) = CMD_CONTENT(i).Replace(CMD_CONTENT(i), "set ACTION=" & ACTION)
            If CMD_CONTENT(i).Trim.ToLower.ToString.Contains("set destinationdir=") Then CMD_CONTENT(i) = CMD_CONTENT(i).Replace(CMD_CONTENT(i), DESTINATIONDIR)
            If CMD_CONTENT(i).Trim.ToLower.ToString.Contains("set destinationfilename=") Then CMD_CONTENT(i) = CMD_CONTENT(i).Replace(CMD_CONTENT(i), "set DESTINATIONFILENAME=" & txtBU_FileName.Text.Trim & ".SQL")
            UPDATED_CMD_CONTENT &= CMD_CONTENT(i) & vbNewLine
        Next
        IO.File.WriteAllText(My.Settings.BU_RES_CMD_PATH, UPDATED_CMD_CONTENT)
        If chkDirectory.Checked = True Then My.Settings.BACKUP_PATH = txtPath.Text.Trim
        If chkFileName.Checked = True Then My.Settings.BACKUP_FILENAME = txtBU_FileName.Text.Trim
        My.Settings.Save() : My.Settings.Save()
        Shell(My.Settings.BU_RES_CMD_PATH)
        Me.Close()
    End Sub

    Private Sub frmBackupRestoreDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ACTION = "BACKUP" : lblBackUp.BackColor = Color.Maroon : lblRestore.BackColor = Color.Transparent
        gbBackUp.Location = gbQuestion.Location : gbBackUp.Size = gbQuestion.Size
        gbRestore.Location = gbQuestion.Location : gbRestore.Size = gbQuestion.Size

        If Not IO.File.Exists(My.Settings.BU_RES_CMD_PATH) Then
            MB("The command file 'backup_restore_setup.cmd' use to back-up and restore database is missing." & vbCr & vbCr & "Locate this file.", "x")
BROWSE:     Dim ofd As New OpenFileDialog
            ofd.Filter = "backup_restore_setup.cmd | backup_restore_setup.cmd"
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.BU_RES_CMD_PATH = ofd.FileName : My.Settings.Save() : My.Settings.Reload() : MB("Found!")
            Else
                If MB("Do you want to exit without locating the backup/restore command file?", "?") = "y" Then Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBrowseR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseR.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "SQSL File (*.sql)|*.sql|All Files (*.*)|*.*"
BROWSE: If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not ofd.FileName.ToString.ToLower.Contains(".sql") Then MB("No SQL file found!", "x") : GoTo BROWSE : Return
            If Not IO.File.ReadAllText(ofd.FileName).Contains("db_campus") Then MB("This file is not recognized as our system database!", "!") : GoTo BROWSE : Return
            txtBUPathFile.Text = ofd.FileName
        End If
    End Sub

#Region "Closes the forms"
    Sub CloseForms()
        frmAccessSettings.Close()
        frmAddSection.Close()
        frmAdminPass.Close()
        frmAnnouncement.Close()
        frmBrowseRecipients.Close()
        frmBrowseSent.Close()
        frmConnectionSetup.Close()
        frmCreateAdmin.Close()
        frmCreateMessage.Close()
        frmDepartment.Close()
        frmDeptAddEdit.Close()
        frmDeptSendCustomize.tmrRead.Stop()
        frmDetectPorts.Close()
        frmDetectPorts.Close()
        frmDetectSMSDevice.tmrDetect.Stop() : frmDetectSMSDevice.Close()
        frmEmptyDatabase.Close()
        frmEncodeStudInfo.tmrUpdate.Stop() : frmEncodeStudInfo.Close()
        frmExpiredMessages.Close()
        frmFacultyUtility.Close()
        frmFirstTimeRunOnce.tmrLoad.Stop() : frmFirstTimeRunOnce.Close()
        frmGSMDeviceConfig.Close()
        frmGuardSettings.Close()
        frmIDFormat.Close()
        frmInbox.Close()
        frmKeywordsSMS.Close()
        frmListParents.Close()
        frmLogIn.tmrLoad.Stop() : frmLogIn.Close()
        frmMAIN.tmrChat.Stop() : frmMAIN.tmrDisplayLog.Stop() : frmMAIN.tmrLV_animate.Stop() : frmMAIN.tmrUpdate.Stop() : frmMAIN.Close()
        frmMB.Close()
        frmNotification.Close()
        frmPreferences.Close()
        frmQueuedMessage.Close()
        frmReceiveMessage.Close()
        frmRecentPost.Close()
        frmRecordsAchive.Close()
        frmResult.Close()
        frmSaveMessage.Close()
        frmSearchCourseYrSec.Close()
        frmSearchDateRange.Close()
        frmSentMessage.Close()
        frmSplashScreen.tmrWait.Stop() : frmSplashScreen.Close()
        frmStudentCounts.Close()
        frmStudentLogRecord.Close()
        frmStudViewDetails.Close()
        frmStudentsList.Close()
        frmSystemLogs.Close()
        frmVReport.Close()
        frmReportDirectory.Close()
        frmSenderPath.Close()

    End Sub
#End Region
    Private Sub btnRestoreNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreNow.Click
        If Not txtBUPathFile.Text.ToString.ToLower.Contains(".sql") Then MB("No SQL file found!", "x") : toHL(txtBUPathFile) : Return
        If Not IO.File.ReadAllText(txtBUPathFile.Text.Trim).ToString.Contains("db_campus") Then MB("This file is not recognized as our system database!", "!") : toHL(txtBUPathFile) : Return
        MB("Warning!" & vbCr & vbCr & "Restoring session will result for system restarting and disconnecting of all users of this system.", "!")
        If MB("Do you want to restore now?", "?") = "n" Then Return
        Cursor = Cursors.WaitCursor
        CloseForms()
        Dim CMD_CONTENT() As String = IO.File.ReadAllLines(My.Settings.BU_RES_CMD_PATH)
        Dim UPDATED_CMD_CONTENT As String = ""
        For i As Integer = 0 To CMD_CONTENT.Length - 1
            If CMD_CONTENT(i).Trim.ToString.Contains("set ACTION=") Then CMD_CONTENT(i) = CMD_CONTENT(i).Replace(CMD_CONTENT(i), "set ACTION=" & ACTION)
            If CMD_CONTENT(i).Trim.ToString.Contains("set SOURCE=") Then CMD_CONTENT(i) = CMD_CONTENT(i).Replace(CMD_CONTENT(i), "set SOURCE=" & txtBUPathFile.Text.Trim)
            UPDATED_CMD_CONTENT &= CMD_CONTENT(i) & vbNewLine
        Next
        IO.File.WriteAllText(My.Settings.BU_RES_CMD_PATH, UPDATED_CMD_CONTENT)

        CONNclose()
        Dim conN_Temp As New MySql.Data.MySqlClient.MySqlConnection("server=" & My.Settings.SERVER & "; user id=" & My.Settings.USERID & "; password=" & My.Settings.PASSWORD & ";")
        conN_Temp.Open() : CMD.Connection = conN_Temp
        CMD.CommandText = "drop database if exists db_campus"
        Dim dR As MySqlDataReader = CMD.ExecuteReader(CommandBehavior.CloseConnection) : dR.Close()
        conN_Temp.Open() : CMD.Connection = conN_Temp
        CMD.CommandText = "create database if not exists db_campus"
        dR = CMD.ExecuteReader(CommandBehavior.CloseConnection) : dR.Close()
        Shell(My.Settings.BU_RES_CMD_PATH)
        Me.Hide()
        frmSplashScreen.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub pbBackUp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBackUp.MouseLeave
        pbBackUp.Tag = False
        If ACTION = "RESTORE" Then lblRestore.BackColor = Color.Maroon Else lblBackUp.BackColor = Color.Maroon
    End Sub

    Private Sub pbBackUp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBackUp.MouseMove
        If pbBackUp.Tag = False Then pbBackUp.Tag = True : Sounds(AUDIO.SELECTED)
        lblBackUp.BackColor = Color.Purple
        If ACTION <> "RESTORE" Then lblRestore.BackColor = Color.Transparent
    End Sub

    Private Sub pbRestore_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRestore.MouseLeave
        pbRestore.Tag = False
        If ACTION = "RESTORE" Then lblRestore.BackColor = Color.Maroon Else lblBackUp.BackColor = Color.Maroon
    End Sub

    Private Sub pbRestore_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbRestore.MouseMove
        If pbRestore.Tag = False Then pbRestore.Tag = True : Sounds(AUDIO.SELECTED)
        lblRestore.BackColor = Color.Purple
        If ACTION <> "BACKUP" Then lblBackUp.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackUp.Click
        Sounds(AUDIO.CLICK)
        ACTION = "BACKUP"
    End Sub

    Private Sub lblBackUp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackUp.MouseLeave
        If ACTION = "RESTORE" Then lblRestore.BackColor = Color.Maroon : lblBackUp.BackColor = Color.Transparent Else lblBackUp.BackColor = Color.Maroon : lblRestore.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackUp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackUp.MouseMove
        If pbBackUp.Tag = False Then pbBackUp.Tag = True : Sounds(AUDIO.SELECTED)
        lblBackUp.BackColor = Color.Purple
        If ACTION <> "RESTORE" Then lblRestore.BackColor = Color.Transparent
    End Sub

    Private Sub lblRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRestore.Click
        Sounds(AUDIO.CLICK)
        ACTION = "RESTORE"
    End Sub

    Private Sub lblRestore_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRestore.MouseLeave
        If ACTION = "RESTORE" Then lblRestore.BackColor = Color.Maroon : lblBackUp.BackColor = Color.Transparent Else lblBackUp.BackColor = Color.Maroon : lblRestore.BackColor = Color.Transparent
    End Sub

    Private Sub lblRestore_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblRestore.MouseMove
        If pbRestore.Tag = False Then pbRestore.Tag = True : Sounds(AUDIO.SELECTED)
        lblRestore.BackColor = Color.Purple
        If ACTION <> "BACKUP" Then lblBackUp.BackColor = Color.Transparent
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Sounds(AUDIO.CLICK)
        gbBackUp.Hide() : gbRestore.Hide() : gbQuestion.Show() : btnBack.Enabled = False
        btnNext.Enabled = True
    End Sub
End Class