
Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources
Public Class frmAccessSettings
    Private Sub frmAccessSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Sub viewLV()
        'On Error GoTo c
        Cursor = Cursors.WaitCursor
        dR = DataReader("select userid,usertype,username,locked,online from tbleusers")
        If Not dr.Read Then mB("No admin!" & vbCr & vbCr & "System/Database is interupted by other user.", "x") : End
        LV.Items.Clear() : Dim li As New ListViewItem
        Do
            If dr.Item(1) Like "Administrator" Then dr.Read()
            li = LV.Items.Add(dr.Item(0))
            li.SubItems.Add(dr.Item(1))
            li.SubItems.Add(dr.Item(2))
            li.SubItems.Add(IIf(dr.Item(3) = True, "Locked", "Authorized"))
            li.SubItems.Add(IIf(dr.Item(4) = True, "Active", "Offline"))
        Loop While dr.Read
c:      dr.Close() : CONclose()
        Cursor = Cursors.Default
    End Sub

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        On Error GoTo c
        dR = DataReader("select userid,locked,online from tbleusers")
        If Not dr.Read Then Return
        If recCount("tbleusers") <= 1 Then Return
        dr.Read() : Dim ListUser((recCount("tbleusers") - 1) + 2) As String
        Dim i As Integer = 0
        Do : ListUser(i) = dr.Item(0) : ListUser(i + 1) = dr.Item(1) : ListUser(i + 2) = dr.Item(2) : i += 2
        Loop While dr.Read
        dr.Close() : CONclose() : i = 0
        For x As Integer = 0 To LV.Items.Count - 1
            If LV.Items(x).Text = ListUser(i) Then
                LV.Items(x).SubItems(3).Text = IIf(ListUser(i + 1) = True, "Locked", "Authorized")
                LV.Items(x).SubItems(4).Text = IIf(ListUser(i + 2) = True, "Active", "Offline")
            End If : i += 3
        Next
c:
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        If LV.CheckedItems.Count <= 0 Then Return
        Dim ListValid As String = ""
        If btnLock.Text.Contains("UNLOCK") Then GoTo UNLOCKED
        For i As Integer = 0 To CheckItems.Length - 1
            If LV.Items(CheckItems(i)).SubItems(4).Text Like "Active" Then
                MB("Cannot lock on-process user." & vbCr & vbCr & "To Lock this user, disconnect first the user then choose the lock action.", "!") : Return
            End If
            ListValid &= IIf(Not LV.Items(CheckItems(i)).SubItems(3).Text.Contains("Locked"), "◘ " & LV.Items(CheckItems(i)).Text & vbNewLine, "")
        Next
        If ListValid = "" Then MB("No authorized user is selected", "!") : Return
        If MB(ListValid & vbCr & "Lock user" & IIf(ListValid.Contains(vbNewLine), "s?", "?"), "?") = "n" Then Return
        For i As Integer = 0 To CheckItems.Length - 1
            If Not LV.Items(CheckItems(i)).SubItems(3).Text.Contains("Locked") Then
                UPDATEr("tbleusers", "locked=1", "userid='" & LV.Items(CheckItems(i)).Text & "'")
                LV.Items(CheckItems(i)).SubItems(3).Text = "Locked"
            End If
            LV.Items(CheckItems(i)).Checked = False
        Next
        MB(ListValid & vbCr & "User" & IIf(ListValid.Contains(vbNewLine), "s are", " is") & " successfully locked.")
        Call frmAccessSettings_Load(sender, e) : LOCKED(True)
        Return
UNLOCKED:
        For i As Integer = 0 To CheckItems.Length - 1
            ListValid &= IIf(LV.Items(CheckItems(i)).SubItems(3).Text.Contains("Locked"), "◘ " & LV.Items(CheckItems(i)).Text & vbNewLine, "")
        Next
        If ListValid = "" Then MB("No locked user is selected", "!") : Return
        If MB(ListValid & vbCr & "Unlock user" & IIf(ListValid.Contains(vbNewLine), "s?", "?"), "?") = "n" Then Return
        For i As Integer = 0 To CheckItems.Length - 1
            If Not LV.Items(CheckItems(i)).SubItems(3).Text.Contains("Authorized") Then
                UPDATEr("tbleusers", "locked=0", "userid='" & LV.Items(CheckItems(i)).Text & "'")
                LV.Items(CheckItems(i)).SubItems(3).Text = "Authorized"
            End If
            LV.Items(CheckItems(i)).Checked = False
        Next
        MB(ListValid & vbCr & "User" & IIf(ListValid.Contains(vbNewLine), "s are", " is") & " successfully unlocked.")
        Call frmAccessSettings_Load(sender, e) : LOCKED(True)
    End Sub
    Function CheckItems() As Integer()
        If LV.CheckedItems.Count <= 0 Then Return Nothing
        Dim chkI(LV.CheckedItems.Count - 1) As Integer
        Dim i As Integer = LV.CheckedItems.Count - 1
        For Each ci As Integer In LV.CheckedIndices
            chkI(i) = ci : i -= 1
        Next
        Return chkI
    End Function

    Public Sub LOCKED(Optional ByVal state As Boolean = True)
        If state = True Then : btnLock.Text = "&UNLOCK USER" : btnLock.Image = Resources.Unlock _
                : lblTip.Text = "User has an authorized" & vbCr & "access to the system."
        Else : btnLock.Text = "&LOCK USER" : btnLock.Image = Resources.Lock _
             : lblTip.Text = "User cannot access" & vbCr & "the system."
        End If
    End Sub
 

    Private Sub LV_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseClick
        If LV.CheckedItems.Count <= 0 Then LOCKED(True) : Return
        ' If LV.Items(LV.CheckedIndices(0)).SubItems(3).Text.Contains("Authorized") Then LOCKED(True) Else LOCKED(False)
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class