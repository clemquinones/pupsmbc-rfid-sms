Public Class frmVeriication
 
    Private Sub rbRFID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRFID.CheckedChanged
        If rbRFID.Checked = True Then rbRFID.BackColor = Color.Purple Else rbRFID.BackColor = Color.Transparent
    End Sub

    Private Sub rbCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCode.CheckedChanged
        If rbCode.Checked = True Then rbCode.BackColor = Color.Purple Else rbCode.BackColor = Color.Transparent
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim ID As String = txtStudNo.Text.Trim.ToUpper
        If rbRFID.Checked = True Then
            If recCount("tblestudent", "rfidtagid='" & txtRFID.Text.Trim.ToUpper & "'") > 0 Then
                ID = getVal("tblestudent", "studno", "rfidtagid='" & txtRFID.Text.Trim.ToUpper & "'") : GoTo READ
            Else : MB("The ID you entered is not registered or did not match to any of the registered RFID Card.", "!")
            End If
        Else
            If recCount("tblestudent", "passcode='" & txtCode.Text.Trim & "' and studno = '" & txtStudNo.Text.Trim & "'") > 0 Then : GoTo READ
            Else : If recCount("tblestudent", "studno='" & txtStudNo.Text.Trim & "'") > 0 Then MB(txtStudNo.Text.Trim & vbCr & vbCr & "Student number matched, but the secret code did not match.", "!") Else MB("Student and secret code did not match", "!")
            End If
        End If
        Return
READ:   UPDATEr("tblestudent", "unlogout=not unlogout", "studno='" & ID & "'")
        INSERTr("tbletempdetection", "'" & generateID("Logs") & "','" & IIf(CBool(getVal("tblestudent", "unlogout", "studno='" & ID & "'")) = True, "Log in", "Log out") & "','" & getVal("tblestudent", "rfidtagid", "studno='" & ID & "'") & "',sysdate()")
        INSERTr("tblemonitoringlogs", "'" & generateID("Logs") & "','" & ID & "','" & IIf(CBool(getVal("tblestudent", "unlogout", "studno='" & ID & "'")) = True, "Log in", "Log out") & "',sysdate()")
        incrementID("Logs")
        'id smstype usernum recid rectype mesg datetime expir sencopy alert unicode
        If recCount("tbleparentinfo p,tblestudent s", "p.rfidtagid=s.rfidtagid and s.studno='" & ID & "' and p.number !='' and p.block=0") Then
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','Logs','" & getVal("tbleparentinfo p,tblestudent s", "p.number", "p.rfidtagid=s.rfidtagid and s.studno='" & ID & "'") & "','" & ID & _
                     "','Parent','" & getMessage(Message.LoginMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
            INSERTr("tblesms", "'" & gIDVal("Message", True) & "','Logs','" & getVal("tbleparentinfo p,tblestudent s", "p.number", "p.rfidtagid=s.rfidtagid and s.studno='" & ID & "'") & "','" & ID & _
                     "','Parent','" & getMessage(Message.AdvisoryMessage) & "',sysdate(),concat(current_date(),' 23:59:59'),1,0,0")
            incrementID("Message")
        End If
        Me.Close()
    End Sub

    Private Sub frmOptions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If recCount("tbleusers", "operatever=0 and userid='" & logID & "'") Then gbVerify.Enabled = False
        gbShutdown.Location = gbVerify.Location
        txtRFID.Text = ""
        txtStudNo.Text = "STUDENT NUMBER"
        txtCode.Text = ""
    End Sub

 

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        lblTimeShutdown.Text = "System will automatically shutdown @ exactly the time of " & getDateTime(CDate(getVal("tbleid", "format", "field like '%SystemShutdown%'")), GetDateTimeValue.OO_OO_AM_PM) & "."
    End Sub

    Private Sub rbRFID_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRFID.ClientSizeChanged
        If rbRFID.Checked Then
            rbRFID.BackColor = Color.Purple
            txtRFID.ReadOnly = False
            toHL(txtRFID)
        Else
            rbRFID.BackColor = Color.Transparent
            txtStudNo.ReadOnly = True
            txtCode.ReadOnly = True
            txtStudNo.Text = ""
            txtCode.Text = ""
        End If
    End Sub
 
 
    Private Sub rbCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCode.Click
        If rbCode.Checked Then
            rbCode.BackColor = Color.Purple
            txtStudNo.ReadOnly = False
            txtCode.ReadOnly = False
            toHL(txtStudNo)
        Else
            rbCode.BackColor = Color.Transparent
            txtRFID.ReadOnly = True
            txtRFID.Text = ""
        End If
    End Sub

    Private Sub rbCode_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCode.MouseLeave

    End Sub

    Private Sub rbCode_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbCode.MouseMove
        rbCode.BackColor = Color.Purple
    End Sub


    Private Sub txtStudNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudNo.GotFocus
        txtStudNo.ForeColor = Color.Black
        TextClicked(txtStudNo, "STUDENT NUMBER")
        rbCode.BackColor = Color.Purple
    End Sub

    Private Sub txtStudNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtStudNo.Text.Trim = "" Then Return
            If txtCode.Text.Trim = "" Then txtCode.Focus() Else Call btnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub txtStudNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudNo.LostFocus
        If txtStudNo.Text.Trim.ToLower = "STUDENT NUMBER" Or txtStudNo.Text.Trim = "" Then txtStudNo.Text = "STUDENT NUMBER"
        txtStudNo.ForeColor = Color.Gray
        rbCode.BackColor = Color.Black
    End Sub


    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        If CBool(getVal("tbleusers", "shutdownclient", "userid='" & logID & "'")) = False Then MB("You do not have a proper privileges to shutdown this computer." & vbCr & vbCr & "Report this issue to the administrator.", "!") : rbCode.Checked = True : Return
        If MB("Do you want to shutdown client?", "?") = "n" Then Return
        LOGS("Shutdown the client." & " Undue client shutdown.")
        Shell("shutdown -s -c ""Program will now shutdown..."" -t 3600 -f") : End
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text.ToString.Contains("Back") Then
            gbShutdown.Hide() : gbVerify.Show() : btnShutdownGB.Show() : btnCancel.Text = "&Cancel"
        Else
            Me.Close()
        End If
    End Sub

 
    Private Sub btnShutdownGB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdownGB.Click
        If recCount("tbleusers", "shutdownclient=0 and userid='" & logID & "'") Then MB("You do not have a proper privilege to terminate the monitoring!" & vbCr & vbCr & "Contact administrator regarding this issue.", "!") : Return
        gbShutdown.Show() : gbVerify.Hide() : btnShutdownGB.Hide() : btnCancel.Text = "<< Back"
    End Sub

    Private Sub txtRFID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRFID.GotFocus
        rbRFID.BackColor = Color.Purple
    End Sub

    Private Sub txtRFID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRFID.KeyDown
        If e.KeyCode = Keys.Enter Then Call btnSubmit_Click(sender, e)
    End Sub

    Private Sub txtRFID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRFID.LostFocus
        rbRFID.BackColor = Color.Black
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        rbCode.BackColor = Color.Purple
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCode.Text.Trim = "" Then Return
            If txtStudNo.Text.Trim = "" Then txtStudNo.Focus() Else Call btnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        rbCode.BackColor = Color.Black
    End Sub
 
    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub txtStudNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudNo.TextChanged

    End Sub

    Private Sub txtRFID_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtRFID.MaskInputRejected

    End Sub
End Class