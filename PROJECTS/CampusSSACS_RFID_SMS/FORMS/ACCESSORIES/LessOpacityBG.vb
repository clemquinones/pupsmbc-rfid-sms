Public Class frmLessOpacityBG

    Private Sub frmLessOpacityBG_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmPreviewStud.Close()
    End Sub


    Private Sub frmLessOpacityBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbClose.Left = Me.Width - 80
        frmPreviewStud.Show()
    End Sub

    Private Sub pbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.Click
        Me.Close()
    End Sub

    Private Sub pbClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbClose.MouseHover
        lblClose.Left = pbClose.Left - (lblClose.Width + 20)
        lblClose.Show()
    End Sub

    Private Sub pbClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbClose.MouseLeave
        lblClose.Hide()
    End Sub
End Class