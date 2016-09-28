Public Class frmDetectSMSDevice
    Private Sub tmrDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetect.Tick
        If frmMAIN.DetectSMS = "Connected" Then Me.Close()
        btnClose.Text = "Cancel" : btnRetry.Hide()

        frmMAIN.DetectSMS = "Disconnected"
        Dim gsmTest As New GsmComm.GsmCommunication.GsmCommMain(CInt(Replace(getVal("tblegsm", "port", "1 limit 1"), "COM", "")), 9600, 300)
        Try
            Cursor = Cursors.WaitCursor
            gsmTest.Open()
            lblStatus.Text = "GSM Module detected."
            frmMAIN.DetectSMS = "Connected"
            IFEXISTSMSPORT = True
            tmrDetect.Interval \= 2
            Cursor = Cursors.Default
            pbLoading.Hide()
            Sounds(AUDIO.TOONG)
        Catch ex As Exception
            Sounds(AUDIO.ERRORWARN)
            lblStatus.Text = ex.Message & vbCr & "You can set up the module from 'GSM Settings'"
            frmMAIN.DetectSMS = "Disconnected"
            btnRetry.Show() : btnClose.Show()
            pbLoading.Hide()
            tmrDetect.Stop()
        Finally
            Try
                gsmTest.Close()
            Catch ex As Exception
            End Try
            Cursor = Cursors.Default
        End Try
        btnRetry.Show() : btnClose.Text = "Close"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        If btnClose.Text = "Cancel" Then
            tmrDetect.Stop() : tmrDetect_Tick(sender, e)
        Else
            frmMAIN.DetectSMS = "Closed"
            Me.Close()
        End If
    End Sub

    Private Sub btnRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetry.Click
        Sounds(AUDIO.CLICK)
        Cursor = Cursors.WaitCursor : lblStatus.Text = "Detecting device..." : pbLoading.Show()
        tmrDetect.Enabled = True
        btnRetry.Hide() : btnClose.Text = "Cancel"
    End Sub

    Private Sub frmDetectSMSDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dR As MySql.Data.MySqlClient.MySqlDataReader = DataReader("select port,baudrate,timeout from tblegsm limit 1")
        For Each item In dR
            Me.Text = "GSM MODULE [PORT: " & dR.Item(0) & ", BAUDRATE: " & dR.Item(1) & ", TIMEOUT=" & dR.Item(2) & "]"
        Next
        dR.Close()
    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub
End Class