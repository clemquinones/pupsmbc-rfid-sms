Public Class frmCreateAdmin

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Sounds(AUDIO.CLICK)
        If txtFName.Text.Trim = "" Then MB("Enter first name!", "!") : toHL(txtFName) : Return
        If txtLName.Text.Trim = "" Then MB("Enter last name!", "!") : toHL(txtLName) : Return
        If txtUserID.Text.Trim = "" Then MB("You must have the user-id format!", "!") : toHL(txtUserID) : Return
        If IsNumeric(txtUserID.Text.Trim) Then MB("User-ID format should contains atleast a consonant letter.", "!") : toHL(txtUserID) : Return
        If txtUserName.Text.Trim = "" Then MB("Enter User Name!" & vbCr & vbCr & "This will use everytime you logged in.", "!") : toHL(txtUserName) : Return
        If txtPassword1.Text = "" Or txtPassword2.Text = "" Then MB("Enter Administrator Password!" & vbCr & vbCr & "This will use everytime you logged in and make confidential action.", "!") : toHL(txtPassword1) : Return
        If txtPassword1.Text <> txtPassword2.Text Then MB("Password and confirmation password did not match!" & vbCr & vbCr & "This will use everytime you logged in and make confidential action.", "!") : toHL(txtPassword1) : Return
        If txtNumber.Text.Trim = "" Or txtNumber.Text.Trim.ToLower = "number" Then MB("Enter a valid phone number!" & vbCr & vbCr & "This will use for remoting the system via SMS.", "!") : toHL(txtNumber) : Return
        If MB("Do you want to save?", "?") = "n" Then Return
        INSERTr("tbleusers", "'" & v(txtUserID.Text.Trim.ToUpper & lblUserID.Text) & "','" & v(txtUserName.Text.Trim.ToUpper) & "','" & EncryptText(txtPassword1.Text) & _
                "','" & v(txtFName.Text.Trim.ToUpper) & "','" & v(txtLName.Text.Trim.ToUpper) & "','" & v(txtNumber.Text.Trim) & "','Administrator',0,0,1,1,1,1,1,1")
        UPDATEr("tbleid", "format='" & v(txtUserID.Text.Trim) & "',value=1", "field = 'User'")
        LOGS("Successfully created system administrator.")
        MB("Done!" & vbCr & vbCr & "You have been created administrator!")
        Me.Close()
    End Sub
 
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to cancel creating of administrator?", "?") = "y" Then MB("No user is created." & vbCr & vbCr & "The system will remains empty and unused.") : End
    End Sub
 
    Private Sub txtUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus
        TextClicked(txtUserName, "USER NAME")
    End Sub

    Private Sub txtFName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.GotFocus
        TextClicked(txtFName, "First")
    End Sub

    Private Sub txtFName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.LostFocus
        If txtLName.Text.Trim.ToUpper = "FIRST" Then txtLName.Text = "First"
    End Sub
 
    Private Sub txtLName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.GotFocus
        TextClicked(txtLName, "Last")
    End Sub

    Private Sub txtLName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.LostFocus
        If txtLName.Text.Trim.ToUpper = "LAST" Then txtLName.Text = "Last"
    End Sub

    Private Sub txtUserName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.LostFocus
        If txtUserName.Text.Trim.ToUpper = "USER NAME" Then txtUserName.Text = "USER NAME"
    End Sub

    Private Sub txtNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.GotFocus
        TextClicked(txtNumber, "Number")
    End Sub

    Private Sub txtNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.LostFocus
        If txtNumber.Text.Trim.ToUpper = "NUMBER" Then txtNumber.Text = "Number"
    End Sub
  
End Class