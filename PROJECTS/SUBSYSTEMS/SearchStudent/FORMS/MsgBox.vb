Imports SearchStudentLogs.My.Resources

Public Class frmMB
    Private Sub frmMB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cursor = Cursors.Default
    End Sub
    Private Sub frmMB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Y Then
            If mbButtons Like "ync" Then Call btn1_Click(sender, e)
            If mbButtons Like "yn" Then Call btn2_Click(sender, e)
        ElseIf e.KeyCode = Keys.O Then
            If mbButtons Like "oc" Then Call btn2_Click(sender, e)
            If mbButtons Like "o" Then Call btn3_Click(sender, e)
        ElseIf e.KeyCode = Keys.N Then
            If mbButtons Like "ync" Then Call btn2_Click(sender, e)
            If mbButtons Like "yn" Then Call btn3_Click(sender, e)
        ElseIf e.KeyCode = Keys.R Then
            If mbButtons Like "rc" Then Call btn2_Click(sender, e)
        ElseIf e.KeyCode = Keys.C Then

        End If
    End Sub

    Private Sub frmMB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.Text = "" Then Me.Tag = ""
        Me.Text = mbTitle
        lblMessage.Text = mbMessage
        lblWhiteBG.Height = lblMessage.Top + lblMessage.Height + 5
        gbButtons.Top = lblWhiteBG.Top + lblWhiteBG.Height
        showmbIcon() : showButtons()
    End Sub

    Sub showmbIcon()
        On Error GoTo c
        If mbIcon Like "i" Or mbIcon = "" Then
            pbIcon.Image = Resources.Information
        ElseIf mbIcon Like "?" And Not mbIcon Like "x" And Not mbIcon Like "!" Then
            pbIcon.Image = Resources.Question
        ElseIf mbIcon Like "!" Then
            pbIcon.Image = Resources.Exclamation
        ElseIf mbIcon Like "x" Then
            pbIcon.Image = Resources.Critical
        Else
            MsgBox("Invalid msg Icon!") : Me.Close()
        End If
c:
    End Sub

    Sub showButtons()
        On Error Resume Next
        btn1.Hide() : btn2.Hide() : btn3.Hide()
        If mbButtons Like "o" Then
            btn3.Show() : btn3.Left = 210 : btn3.Text = "&OK"
        ElseIf mbButtons Like "yn" And Not mbButtons Like "ync" Then
            btn2.Show() : btn3.Show() : btn2.Left = 126 : btn3.Left = btn2.Left + btn2.Width + 5
            btn2.Text = "&Yes" : btn3.Text = "&No" : btn2.Focus() : btn2.Focus()
        ElseIf mbButtons Like "oc" Then
            btn2.Show() : btn3.Show() : btn2.Left = 126 : btn3.Left = btn2.Left + btn2.Width + 5
            btn2.Text = "&Ok" : btn3.Text = "&Cancel" : btn2.Focus() : btn2.Focus()
        ElseIf mbButtons Like "rc" Then
            btn2.Show() : btn3.Show() : btn2.Left = 126 : btn3.Left = btn2.Left + btn2.Width + 5
            btn2.Text = "&Retry" : btn3.Text = "&Cancel" : btn2.Focus() : btn2.Focus()
        ElseIf mbButtons Like "ync" Then
            btn1.Show() : btn2.Show() : btn3.Show()
            btn1.Left = 41 : btn2.Left = btn1.Left + btn1.Width + 5 : btn3.Left = btn2.Left + btn2.Width + 5
            btn1.Text = "&Yes" : btn2.Text = "&No" : btn3.Text = "&Cancel" : btn1.Focus() : btn1.Focus()
        Else
            MsgBox("Invalid msg buttons") : Me.Close()
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If btn3.Text Like "&OK" Then : Me.Tag = "o"
        ElseIf btn3.Text Like "&Cancel" Then : Me.Tag = "c"
        ElseIf btn3.Text Like "&No" Then : Me.Tag = "n"
        End If : Me.Close()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If btn2.Text Like "&Yes" Then : Me.Tag = "y"
        ElseIf btn2.Text Like "&Retry" Then : Me.Tag = "r"
        ElseIf btn2.Text Like "&Ok" Then : Me.Tag = "o"
        ElseIf btn2.Text Like "&No" Then : Me.Tag = "n"
        End If : Me.Close()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If btn1.Text Like "&Yes" Then Me.Tag = "y"
        Me.Close()
    End Sub
End Class