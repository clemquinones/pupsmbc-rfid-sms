Public Class frmDeptAddEdit

    Private Sub frmDeptAddEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmDeptAddEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "Add" Then
            Me.Text = "Add Department" : btnAdd.Text = "&Add" : btnAddSection.Text = "&Add Sections..."
            txtCode.Text = "Code" : txtDescription.Text = "Description" : txtYear.Text = "Year"
        ElseIf Me.Tag = "Edit" Then
            Me.Text = "Update Department" : btnAdd.Text = "&Update" : btnAddSection.Text = "&Update Sections..."
            txtCode.Text = frmDepartment.LV.Items(frmDepartment.LV.SelectedIndices(0)).Text
            txtDescription.Text = frmDepartment.LV.Items(frmDepartment.LV.SelectedIndices(0)).SubItems(1).Text
            txtYear.Text = getVal("tblecodedesc", "year", "code='" & txtCode.Text & "'")
        Else : Me.Close()
        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Sounds(AUDIO.CLICK)
        If txtCode.Text.Trim = "" Or txtCode.Text.Trim.ToLower = "code" Then MB("Enter department code!") : toHL(txtCode) : Return
        If txtDescription.Text.Trim = "" Or txtDescription.Text.Trim.ToLower = "description" Then MB("Enter department description!") : toHL(txtDescription) : Return
        If txtYear.Text.Trim = "" Or txtYear.Text.Trim.ToLower = "year" Then MB("Enter number of years!") : toHL(txtYear) : Return
        If Not IsNumeric(txtYear.Text.Trim) Then MB("Invalid number of years!") : toHL(txtYear) : Return

        If recCount("tblecodedesc", "field like '%Course%' and code='" & txtCode.Text.Trim.Trim.ToUpper & "'") > 0 And btnAdd.Text.ToLower Like "&add" Then
            MB("The department code is already exist!") : toHL(txtCode) : Return
        End If

        If MB("Save " & IIf(btnAdd.Text = "&Add", "department?", "Changes?"), "?") = "n" Then Return
        If btnAdd.Text = "&Add" Then GoTo ADD Else GoTo EDIT
ADD:    INSERTr("tblecodedesc", "'Course','" & v(txtCode.Text.Trim.ToUpper) & "','" & v(txtDescription.Text.Trim) & "'," & v(txtYear.Text.Trim) & ",'" & frmAddSection.Tag & "'")
        If MB("New entry saved!" & vbCr & vbCr & "Add more department?", "?") = "n" Then Me.Close() Else txtCode.Text = "" : txtDescription.Text = "" : txtCode.Focus()
        Return
EDIT:   UPDATEr("tblecodedesc", "code='" & v(txtCode.Text.Trim.ToUpper) & "',description='" & v(Replace(txtDescription.Text.Trim, vbNewLine, " ")) & "',year=" & v(txtYear.Text.Trim), "code like '%" & v(txtCode.Text.Trim) & "%' and field like '%Course%'")
        MB("Saved!") : Me.Close()
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        txtCode.ForeColor = Color.White
        TextClicked(txtCode, "Code")
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        txtCode.ForeColor = Color.Gray
    End Sub



    Private Sub txtDescription_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.GotFocus
        txtDescription.ForeColor = Color.White
        TextClicked(txtDescription, "Description")
    End Sub

    Private Sub txtDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.LostFocus
        txtDescription.ForeColor = Color.Gray
    End Sub


    Private Sub txtYear_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.GotFocus
        txtYear.ForeColor = Color.White
        TextClicked(txtYear, "Year")
    End Sub

    Private Sub txtYear_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.LostFocus
        txtYear.ForeColor = Color.Gray
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
        frmAddSection.Tag = ""
        If txtYear.Text.Trim = "" Then btnAddSection.Enabled = False : Return
        If Not IsNumeric(txtYear.Text.Trim) Then btnAddSection.Enabled = False : Return
        btnAddSection.Enabled = True
    End Sub

    Private Sub btnAddSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSection.Click
        Sounds(AUDIO.CLICK)
        If txtYear.Text.Trim = "" Then btnAddSection.Enabled = False : Return
        If Not IsNumeric(txtYear.Text.Trim) Then btnAddSection.Enabled = False : Return
        frmAddSection.Tag = Me.Tag
        frmAddSection.ShowDialog()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged

    End Sub
End Class