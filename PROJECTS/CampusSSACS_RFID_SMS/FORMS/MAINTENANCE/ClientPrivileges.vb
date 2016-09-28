Imports MySql.Data.MySqlClient
Public Class frmGuardSettings

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Sounds(AUDIO.CLICK)
        If MB("Save settings?", "?") = "n" Then Return
        UPDATEr("tbleusers", "locked=" & chkBlock.Checked & ",searchstud=" & chkSearch.Checked & ",viewstudinfo=" & chkView.Checked & ",shutdownclient=" & chkShutdown.Checked & ",operatever=" & chkOperate.Checked & ",viewstudentlist=" & chkViewStud.Checked & ",searchstudentlist=" & chkSearchStud.Checked, "userid='" & cmbUser.Text & "'")
        LOGS("Update client manager " & cmbUser.Text & ".")
        MB("Saved!") : Me.Close()
    End Sub

    Private Sub frmGuardSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmGuardSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUser.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select userid from tbleusers where usertype not like '%Administrator%'")
        For Each item In dR
            cmbUser.Items.Add(dR.Item(0))
        Next
        dR.Close()
        If cmbUser.Items.Count <= 0 Then Me.Hide() : MB("No client manager!") : Me.Close() Else cmbUser.SelectedIndex = 0
        showSETTINGS(cmbUser.Text)
    End Sub

    Sub showSETTINGS(ByVal USERID As String)
        Dim dR As MySqlDataReader = DataReader("select searchstud,viewstudinfo,shutdownclient,operatever,locked,fname,lname from tbleusers where userid='" & USERID & "'")
        For Each item In dR
            chkSearch.Checked = dR.Item(0)
            chkView.Checked = dR.Item(1)
            chkShutdown.Checked = dR.Item(2)
            chkOperate.Checked = dR.Item(3)
            chkBlock.Checked = dR.Item(4)
            lblName.Text = dR.Item(5) & " " & dR.Item(6)
            Exit For
        Next
        dR.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub


    Private Sub cmbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
        showSETTINGS(cmbUser.Text)
    End Sub
End Class