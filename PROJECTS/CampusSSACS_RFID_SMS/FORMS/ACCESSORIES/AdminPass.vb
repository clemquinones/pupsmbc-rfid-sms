Public Class frmAdminPass
    Public TRIAL As Integer = 0
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPassword.Text.Trim = "" Then MB("Cannot accept null password!", "!") : toHL(txtPassword) : Return
        TRIAL += 1
        If txtPassword.Text <> DecryptText(ADMINPASSWORD) Then
            MB("Password did not match!", "!")
            If TRIAL >= 3 Then MB("You have reached maximum retries allowed!", "x") : Me.Close()
            toHL(txtPassword) : Return
        Else
            Me.Tag = "OK" : Me.Close()
        End If
    End Sub

    Private Sub frmAdminPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = ""
        TRIAL = 0
        txtPassword.Text = ""
        toHL(txtPassword)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.ForeColor = Color.Black
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then Call btnOK_Click(sender, e)
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        txtPassword.ForeColor = Color.Gray

    End Sub
     
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class