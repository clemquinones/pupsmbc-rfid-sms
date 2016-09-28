Public Class frmSplashScreen
    Dim i As Integer = 0
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Sub RESET()
        With My.Settings
            .BACKUP_FILENAME = "db_campus_back_up"
            .BU_RES_CMD_PATH = ""
            .REPORT_FOLDER_PATH = ""
            .SendSMS_PATH = ""
            .SplashScreen = True
            .AutoDetectGSM = True
            .Sounds = True
            .StartSending = False
            .SERVER = ""
            .USERID = ""
            .PASSWORD = ""
            .DATABASE = ""
            .SendSMS_PATH = ""
            .Save()
        End With
    End Sub

    Private Sub tmrWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWait.Tick
        i += 1
        If Not i > 100 Then lblCount.Text = i & "%"
        If i >= 110 Then : tmrWait.Stop() : Me.Hide()
            With My.Settings
                If .USERID = "" Or .DATABASE = "" Then
                    frmFirstTimeRunOnce.ShowDialog()
                    frmConnectionSetup.ShowDialog()
                    If Not IO.File.Exists(.SendSMS_PATH) Then
                        IFEXISTSMSSENDER = False
                        MB("Locate SMS Sender Application")
                        frmSenderPath.ShowDialog()
                    Else : IFEXISTSMSSENDER = True
                    End If
                End If

                If Not IO.File.Exists(.REPORT_FOLDER_PATH & "\StudentLogRecords.rpt") Then
                    MB("Locate the report directory.")
LOCATE:             frmReportDirectory.ShowDialog()
                End If
                frmLogIn.Show()
                Me.Close()
                tmrWait.Enabled = False
            End With
        End If

    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  RESET()
        Me.Hide()
        If My.Settings.SplashScreen = False Then Me.Hide() : i = 110 : tmrWait_Tick(sender, e)
        My.Settings.WAV_Path = CurDir() & "\FILES\WAV\" : My.Settings.Save()
        tmrWait.Start()
        On Error Resume Next
        Shell(Environ("SystemDrive") & "\xampp\xampp_start.exe")
    End Sub

   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class