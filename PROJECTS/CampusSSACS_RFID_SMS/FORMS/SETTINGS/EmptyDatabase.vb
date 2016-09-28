Public Class frmEmptyDatabase
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Sounds(AUDIO.CLICK)
        If MB("Close program?", "?") = "y" Then End
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Sounds(AUDIO.CLICK)
        Me.Hide()
        frmCreateAdmin.ShowDialog()
        UPDATEr("tbleid", "value=0", "field = 'IDFormat'")
        frmIDFormat.ShowDialog()
        Me.Close()
    End Sub

    Private Sub frmEmptyDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class