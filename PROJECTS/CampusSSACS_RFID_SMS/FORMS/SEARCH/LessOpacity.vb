Public Class frmLessOpacity
 

    Private Sub LessOpacity_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmPreview.Close()
        frmSearchStudent.Show()
    End Sub

    Private Sub frmLessOpacity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then End
    End Sub

    Private Sub LessOpacity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmPreview.Show()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub lblClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblClose.MouseDown
        lblClose.ForeColor = Color.White
        lblClose.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub lblClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClose.MouseLeave
        lblTip.Hide()
        lblClose.ForeColor = Color.Orange
    End Sub

    Private Sub lblClose_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblClose.MouseMove
        lblTip.Show()
        lblClose.ForeColor = Color.Yellow
    End Sub
End Class