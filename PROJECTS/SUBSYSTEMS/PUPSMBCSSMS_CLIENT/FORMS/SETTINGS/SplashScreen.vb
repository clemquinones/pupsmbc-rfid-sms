Public Class frmSplashScreen
    Dim i As Integer = 0
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Sub RESET()
        With My.Settings 
            .SERVER = "10.1.1.2"
            .USERID = "root"
            .PASSWORD = ""
            .DATABASE = "db_campus"
            .Save()
        End With
    End Sub

    Private Sub tmrWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWait.Tick

        i += 1
        If Not i > 100 Then lblCount.Text = i & "%"
        If i >= 110 Then : tmrWait.Stop() : Me.Hide()
            frmLogIn.Show()
            Me.Hide()
            tmrWait.Enabled = False
        End If
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  RESET()
    End Sub

   
End Class