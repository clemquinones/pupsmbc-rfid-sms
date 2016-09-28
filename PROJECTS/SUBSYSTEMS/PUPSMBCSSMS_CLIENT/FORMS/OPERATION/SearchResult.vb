Public Class frmResult

    Private Sub frmLVResult_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
 
    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        Sounds(AUDIO.CLICK)
        If LV.SelectedIndices.Count <= 0 Then Return
        On Error Resume Next
        Me.Hide()
        viewProfile(LV.SelectedItems(0).Text) : Me.Close()
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then Call btnDetails_Click(sender, e)
    End Sub
    
    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedIndices.Count < 0 Then btnDetails.Enabled = False Else btnDetails.Enabled = True
    End Sub

    Private Sub frmResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class