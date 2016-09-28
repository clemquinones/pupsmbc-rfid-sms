Public Class frmStudLogDetails

    Private Sub frmStudLogDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then frmSearchStudentLog.Show() : Me.Close()
        If e.KeyCode = Keys.Enter Then Me.Close() : frmSearchStudentLog.Close()
    End Sub

    Private Sub frmStudLogDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class