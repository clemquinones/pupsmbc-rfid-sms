Public Class frmListener
    Public ACTIVE As Boolean = False
    Private Sub frmListener_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then frmUserPass.Tag = " to terminate:" : If UserPass() Then End
    End Sub
    Public Sub reSET()
        lblConfig.Text = My.Settings.MACHINE & " : " & My.Settings.PCNAME
        ACTIVE = False
        tmrDetect.Start()
    End Sub
    Dim ctr As Integer = 0
    Private Sub tmrDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetect.Tick
        If recCount("tbleclient", "name='" & My.Settings.PCNAME & "' and online=0") > 0 Then End
        If ACTIVE = True Then frmClient.Show() : frmClient.reSET() : tmrDetect.Stop() : Me.Close()
        If recCount("tbleclient c,tbleusers u", "c.userid=u.userid and u.online=1") > 0 Then
            ACTIVE = True : lblTip.Text = "SUCCESSFULLY CONNECTED TO '" & getVal("tbleclient", "userid", "name='" & My.Settings.PCNAME & "'") & "'" : Return
        ElseIf recCount("tbleclient", "name='" & My.Settings.PCNAME & "'") <= 0 Then
            End
        Else
            If getVal("tbleclient", "userid", "name='" & My.Settings.PCNAME & "'") = "" Or recCount("tbleusers u,tbleclient c", "u.userid=c.userid and u.online=0") > 0 Then
                lblTip.Text = "WAITING FOR THE USER TO ACTIVATE MONITORING..."
            ElseIf recCount("tbleusers u,tbleclient c", "c.userid=u.userid") <= 0 Then : ctr += 1
                lblTip.Text = "Oops! there's a conflict from database." & vbNewLine & "The user that is associated with this system is no longer active or unavailable." & vbNewLine & "The system will reset this settings."
                If ctr >= 3 Then UPDATEr("tbleclient", "userid=''") : ctr = 0
            End If
        End If
    End Sub

    Private Sub frmListener_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UPDATEr("tbleclient", "online=1", "name='" & My.Settings.PCNAME & "'")
        reSET()
    End Sub
End Class