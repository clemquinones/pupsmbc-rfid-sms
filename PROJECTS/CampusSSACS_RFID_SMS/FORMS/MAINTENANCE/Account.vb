Public Class frmAccount

    Private Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUserID.Text = logID
        txtUserName.Text = getVal("tbleusers", "username", "userid='" & logID & "'")
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtUserName.Text.Trim = "" Then MB("Empty user name!", "!") : toHL(txtUserName) : Return
        If Not chkPass.Checked = True Then GoTo UPDATE
        If txtPassword.Text = "" Then MB("Empty old password!") : toHL(txtPassword) : Return
        If Not txtPassword.Text = DecryptText(getVal("tbleusers", "password", "userid='" & logID & "'")) Then MB("Password did not match from your old password!") : toHL(txtPassword) : Return
        If txtNewPass1.Text = "" Or txtNewPass2.Text = "" Then MB("Empty new password cannot accept!") : toHL(IIf(txtNewPass1.Text.Trim = "", txtNewPass1, txtNewPass2)) : Return
        If txtNewPass1.Text <> txtNewPass2.Text Then MB("New password did not match!") : toHL(txtNewPass1) : Return
        If MB("Save changes?", "?") = "n" Then Return
UPDATE: UPDATEr("tbleusers", "username='" & txtUserName.Text.Trim & "',password='" & EncryptText(txtNewPass1.Text) & "'", "userid = '" & logID & "'")
        MB("Saved!") : Me.Close() : Return
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class