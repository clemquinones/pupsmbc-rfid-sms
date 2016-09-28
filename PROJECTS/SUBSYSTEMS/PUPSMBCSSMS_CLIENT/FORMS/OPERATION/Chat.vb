Imports MySql.Data.MySqlClient
Public Class frmChat
    Dim LastDT As Date = Nothing
    Dim DT As String = Nothing
    Private Sub tmrUpdate_() Handles tmrUpdate.Tick
      
        Dim dR As MySqlDataReader = DataReader("select username,online from tbleusers where username != '" & logUserName & "'")
        For Each item As Object In dR
            Dim UserToBeAdd As String = ""
            For Each cmbItem As Object In cmbUser.Items.ToString
                If txtConfe.Text.Trim.ToLower = "no messages..." Then txtConfe.Text = ""
                If cmbUser.Text = dR.Item(0) And dR.Item(1) = False Then txtConfe.Text &= vbNewLine & cmbUser.Text & " is now offline. Leave message." & vbNewLine & vbNewLine : cmbUser.Text = "All Active Users"
                If dR.Item(0) = cmbItem And dR.Item(1) = False Then cmbUser.Items.Remove(cmbItem)
                If dR.Item(0) <> cmbItem And dR.Item(1) = True And Not cmbUser.Items.Contains(dR.Item(0)) Then UserToBeAdd = dR.Item(0)
            Next
            cmbUser.Items.Add(UserToBeAdd)
        Next
        dR.Close()

        If cmbUser.Items.Count = 1 Then txtConfe.Text = vbNewLine & "No active users..." & vbNewLine : Return

        Dim dR2 As MySqlDataReader = DataReader("select userfrom,userto,message,datetime from tblechat where (userto='" & logUserName & "')" & IIf(cmbUser.Text = "All Active Users", "", " or (userfrom='" & cmbUser.Text & "')") & " and unread=1")
        For Each item As Object In dR2
            UPDATEr("tblechat", "unread=0", "userfrom='" & dR2.Item(0) & "' and datetime='" & dR2.Item(3) & "'")
            txtConfe.Text &= dR2.Item(0) & " [" & getDateTime(dR2.Item(3), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM) & "]: " & dR2.Item(2) & vbNewLine
        Next
        dR2.Close()
        UPDATEr("tblechat", "unread=0", "(userto='" & logUserName & "')" & IIf(cmbUser.Text = "All Active Users", "", " or (userfrom='" & cmbUser.Text & "')") & " and unread=1")
 
    End Sub

    Private Sub frmChat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        eSQL("insert into tblechat2 select * from tblechat")
        DELETEr("tblechat")
    End Sub

    Private Sub frmChat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmChat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUser.Items.Clear() : btnSubmit.Enabled = False : cmbUser.Items.Add("All Active Users")
        Dim dR As MySqlDataReader = DataReader("select username from tbleusers where username != '" & logUserName & "'")
        For Each item As Object In dR
            cmbUser.Items.Add(dR.Item(0))
        Next
        dR.Close()
        If cmbUser.Items.Count > 0 Then cmbUser.SelectedIndex = 0 : btnSubmit.Enabled = True Else tmrUpdate.Stop()
        DT = IIf(cmbUser.Text = "All Active Users", " 1", " userfrom = '" & cmbUser.Text & "'") & ") and datetime between '" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd) & " 00:00:01' and '" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd) & " 23:59:59'"


    End Sub

    Private Sub llblClear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblClear.LinkClicked
        txtConfe.Text = "No messages..."
    End Sub

    Private Sub llblRestore_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRestore.LinkClicked
        txtConfe.Text = ""
        Dim dR As MySqlDataReader = DataReader("select userfrom,userto,message,datetime from tblechat where (userto='" & logUserName & "' or  " & DT & " order by datetime")
        For Each item As Object In dR
            txtConfe.Text &= IIf(logUserName = dR.Item(0), "You", dR.Item(0)) & " [" & getDateTime(dR.Item(3), GetDateTimeValue.OO_OO_AM_PM) & "]: " & dR.Item(2) & vbNewLine
        Next
        dR.Close()
    End Sub

    Private Sub txtMessage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.GotFocus
        TextClicked(txtMessage, "Type your message here...")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown

        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then
            Call btnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub txtMessage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.LostFocus
        If txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.ToLower = "type your message here..." Then txtMessage.Text = "Type your message here..."
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        txtMessage.Text = txtMessage.Text.Replace(vbNewLine, "")
        If txtMessage.Text.Trim = "" Or txtMessage.Text.Trim.ToLower = "type your message here..." Or txtConfe.Text.Trim.ToLower = "no active users..." Then Return
        Dim Msg As String = txtMessage.Text.Replace("'", "''") : Msg = Msg.Replace("\", "\\") : Msg = Msg.Replace("/", "//")
        If txtConfe.Text = "No messages..." Then txtConfe.Text = ""
        txtConfe.Text &= "You [" & getDateTime(sDT, GetDateTimeValue.OO_OO_AM_PM) & "]: " & txtMessage.Text & vbNewLine
        If cmbUser.Text <> "All Active Users" Then
            INSERTr("tblechat", "'" & logUserName & "','" & cmbUser.Text & "','" & Msg & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "',1")
        Else
            Dim dR As MySqlDataReader = DataReader("select username from tbleusers where username != '" & logUserName & "' and online=1")
            For Each item As Object In dR
                INSERTr("tblechat", "'" & logUserName & "','" & dR.Item(0) & "','" & Msg & "','" & saveDateTime(sDT, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "',1")
            Next
            dR.Close()
        End If
        txtMessage.Text = "" : txtMessage.Focus()
    End Sub
 
End Class
