Public Class frmSplashScreen
    Sub reset()
        My.Settings.SERVER = ""
        My.Settings.USERID = ""
        My.Settings.PASSWORD = ""
        My.Settings.DATABASE = ""
        My.Settings.MACHINE = ""
        My.Settings.PCNAME = ""
        My.Settings.Save() : My.Settings.Reload()
    End Sub
    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        'reset()
        Me.Hide() : tmrLoad.Stop()
        AssignConnection()
        AssignConnection()
        frmListener.ShowDialog()
        frmClient.Show()
    End Sub

    Private Sub pbLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLoad.Click

    End Sub

    Private Sub pbLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLoading.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConfig.Click

    End Sub

    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.WAV_Path = CurDir() & "\FILES\WAV\" : My.Settings.Save()
    End Sub
End Class