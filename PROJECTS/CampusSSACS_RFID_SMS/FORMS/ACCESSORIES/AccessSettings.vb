
Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources
Public Class frmAccessSettings

    Private Sub frmAccessSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmAccessSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOGS("Show access settings.")
        viewUsers()
    End Sub

  

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        Dim dR As MySqlDataReader = DataReader("select userid,locked,online from tbleusers")
        'If recCount("tbleusers", "usertype not like '%Admnistrator%'") <> LV.Items.Count Then viewUsers()
        For Each item In dR
            For x As Integer = 0 To LV.Items.Count - 1
                If LV.Items(x).Text = dR.Item(0) Then
                    LV.Items(x).SubItems(3).Text = IIf(dR.Item(1) = True, "Locked", "Authorized")
                    LV.Items(x).SubItems(4).Text = IIf(dR.Item(2) = True, "Active", "Offline")
                End If
            Next
        Next
        dR.Close()
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        On Error Resume Next

        If LV.SelectedItems.Count < 0 Then MB("Select user!") : Return
        If btnLock.Text Like "&UNLOCK USER" Then
            If Not LV.Items(LV.SelectedIndices(0)).SubItems(3).Text Like "Locked" Then MB("No locked user to unlocked!") : Return
            If MB(LV.Items(LV.SelectedIndices(0)).Text & vbCr & vbCr & "Unlocked this user?", "?") = "n" Then Return
            UPDATEr("tbleusers", "locked=0", "userid='" & LV.Items(LV.SelectedIndices(0)).Text & "'")
            LOCKED(False) : LOGS("Unlock user " & LV.Items(LV.SelectedIndices(0)).Text)
        Else
            If Not LV.Items(LV.SelectedIndices(0)).SubItems(3).Text Like "Authorized" Then MB("No authorized user to locked!") : Return
            If LV.Items(LV.SelectedIndices(0)).SubItems(4).Text Like "Active" Then
                MB("Cannot lock on-process user." & vbCr & vbCr & "To Lock this user, disconnect first the user then choose the lock action.", "!") : Return
            End If
            If MB(LV.Items(LV.SelectedIndices(0)).Text & vbCr & vbCr & "Locked this user?", "?") = "n" Then Return
            UPDATEr("tbleusers", "locked=1", "userid='" & LV.Items(LV.SelectedIndices(0)).Text & "'")
            LOCKED(True) : LOGS("Lock user " & LV.Items(LV.SelectedIndices(0)).Text)
        End If

    End Sub

    Public Sub LOCKED(Optional ByVal state As Boolean = True)
        If state = True Then
            btnLock.Text = "&UNLOCK USER" : btnLock.Image = Resources.Unlock
            lblTip.Text = "User has an authorized" & vbCr & "access to the system."
        Else
            btnLock.Text = "&LOCK USER" : btnLock.Image = Resources.Lock
            lblTip.Text = "User cannot access" & vbCr & "the system."
        End If
    End Sub


    Sub viewUsers()
        LV.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select userid,usertype,username,locked,online from tbleusers where userid != '" & logID & "'")
        Dim li As New ListViewItem
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2))
            li.SubItems.Add(IIf(dR.Item(3) = True, "Locked", "Authorized"))
            li.SubItems.Add(IIf(dR.Item(4) = True, "Active", "Offline"))
        Next
        dR.Close()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count <= 0 Then
            btnLock.Enabled = False : btnDelete.Enabled = False : btnDisconnect.Enabled = False
        Else 'if meron
            If LV.Items(LV.SelectedIndices(0)).SubItems(3).Text Like "Locked" Then LOCKED(True) Else LOCKED(False)
            If LV.Items(LV.SelectedIndices(0)).SubItems(4).Text Like "Active" Then btnDisconnect.Enabled = True Else btnDisconnect.Enabled = False
            btnLock.Enabled = True : btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        If LV.SelectedItems.Count < 0 Then MB("No active user to disconnect.") : Return
        MB("Warning!" & vbCr & vbCr & "If you continue, the operation currently operating of this user will be terminated.", "!")
        On Error Resume Next
        If MB(LV.SelectedItems(0).Text & vbCr & vbCr & "Do you want to disconnect this user?", "?") = "n" Then Return
        UPDATEr("tbleusers", "online=0", "userid='" & LV.SelectedItems(0).Text & "'")
        LV.SelectedItems(0).SubItems(4).Text = "Offline"
        viewUsers() : LOGS("Disconnect user " & LV.SelectedItems(0).Text & ".")
        MB("Successfully disconnected!")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        On Error Resume Next
        If LV.SelectedItems.Count < 0 Then MB("No selected user to delete.") : Return
        If LV.Items(LV.SelectedIndices(0)).SubItems(4).Text Like "Active" Then MB("Cannot delete on-process user." & vbCr & vbCr & "Disconnect first the user then delete.", "!") : Return
        If MB(LV.Items(LV.SelectedIndices(0)).Text & vbCr & vbCr & "Do you want to delete this user?", "?") = "n" Then Return
        If Not AdminPass() Then Return
        DELETEr("tbleusers", "userid='" & LV.Items(LV.SelectedIndices(0)).Text & "'")
        viewUsers() : LOGS("Delete user " & LV.Items(LV.SelectedIndices(0)).Text & ".")
        MB("Successfully deleted!")
    End Sub

    Private Sub tsmLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLock.Click
        Call btnLock_Click(sender, e)
    End Sub

    Private Sub tsmDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDisconnect.Click
        Call btnDisconnect_Click(sender, e)
    End Sub

    Private Sub tsmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelete.Click
        Call btnDelete_Click(sender, e)
    End Sub

    Private Sub cmsUser_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsUser.Opening
        If LV.SelectedItems.Count <= 0 Then cmsUser.Enabled = 0 Else cmsUser.Enabled = 1
        On Error Resume Next
        If LV.SelectedItems(0).SubItems(4).Text Like "Active" Then : tsmDelete.Enabled = 0 : tsmDisconnect.Enabled = 1
        Else : tsmDelete.Enabled = 1 : tsmDisconnect.Enabled = 0
        End If
        If LV.SelectedItems(0).SubItems(3).Text Like "Locked" Then : tsmLock.Text = "Unlock """ & LV.SelectedItems(0).Text & """" : tsmLock.Image = My.Resources.Unlock
        Else : tsmLock.Text = "Lock """ & LV.SelectedItems(0).Text & """" : tsmLock.Image = My.Resources.Lock
        End If
    End Sub

    Private Sub tsmSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSendMessage.Click
        If NoSelected(LV) Then MB("No selected user!", "!") : Return
        On Error Resume Next
        Dim n As String = getVal("tbleusers", "number", "userid='" & LV.SelectedItems(0).Text & "'")
        If n = "" Then MB("User '" & LV.SelectedItems(0).Text & "' has no registered phone number.") : Return
        showCreateMessage(LV.SelectedItems(0).Text, "userid", "tbleusers")
    End Sub
End Class