Public Class frmOptions
    Public Verified As Boolean = False
   
    Private Sub rbRFID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRFID.CheckedChanged
        If rbRFID.Checked = True Then
            txtRFID.Text = "RFID SERIAL ID"
            txtRFID.Enabled = True
            txtCode.Enabled = False
            txtStudNo.Enabled = False
        End If
    End Sub

    Private Sub rbCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCode.CheckedChanged
        If rbCode.Checked = True Then
            txtCode.Text = ""
            txtRFID.Enabled = False
            txtCode.Enabled = True
            txtStudNo.Enabled = True
        End If
    End Sub
     
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If rbRFID.Checked = True Then
            If recCount("tblestudent", "rfidtagid='" & txtRFID.Text.Trim & "'") > 0 Then
                Verified = True : IDserialNo = txtRFID.Text.Trim
            Else
                MB("The ID you entered is not registered or did not match to any of the registered RFID Card.", "!") : Return
            End If
        Else
            If recCount("tblestudent", "secretcode='" & txtCode.Text.Trim & "' and studno = '" & txtStudNo.Text.Trim & "'") > 0 Then
                Verified = True : IDserialNo = getVal("tblestudent", "rfidtagid", "studno='" & txtStudNo.Text.Trim & "'")
            Else
                If recCount("tblestudent", "studno='" & txtStudNo.Text.Trim & "'") > 0 Then
                    MB(txtStudNo.Text.Trim & vbCr & vbCr & "Student number found, but the secret code you provide did not match.") : Return
                Else
                    MB("Student and secret code did not match", "!") : Return
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Verified = False
   
    End Sub
 
     
    Private Sub rbLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLog.CheckedChanged
        If rbLog.Checked = True Then gbVerification.Enabled = True : lblDescription.Text = "This will log you by verification"
    End Sub

    Private Sub rbShutdown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbShutdown.CheckedChanged
        If rbShutdown.Checked = True Then gbShutdown.Enabled = True : lblDescription.Text = "This will shutdown the client by the set time."
    End Sub
     
    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        lblTimeShutdown.Text = "System will automatically shutdown @ exactly the time of " & getDateTime(CDate(getVal("tbleid", "format", "field like '%SystemShutdown%'")), GetDateTimeValue.OO_OO_AM_PM) & "."
    End Sub

    Private Sub rbRFID_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRFID.MouseLeave
        rbRFID.BackColor = Color.Gray
    End Sub

    Private Sub rbRFID_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbRFID.MouseMove
        rbRFID.BackColor = Color.Purple
    End Sub

    Private Sub rbCode_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCode.MouseLeave
        rbCode.BackColor = Color.Gray
    End Sub

    Private Sub rbCode_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbCode.MouseMove
        rbCode.BackColor = Color.Purple
    End Sub
End Class