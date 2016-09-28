Imports MySql.Data.MySqlClient
'Imports ATSMS
'Imports GsmComm.GsmCommunication
'Imports GsmComm.PduConverter

Public Class frmAnnouncement
    Dim ParentsRec() As String = Nothing
    Dim Faculty() As String = Nothing
    Dim Utility() As String = Nothing
    Public Students() As String = Nothing
    Dim StartDateTime As String = Nothing, EndDateTime As String = Nothing


    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Sounds(AUDIO.CLICK)
        'Validation
        If txtMessage.Text.Trim.ToLower Like "--type your announcement here..." Or txtMessage.Text.Trim = "" Then MB("Enter valid announcement!") : toHL(txtMessage) : Return
        If chkSchedAnnounce.Checked = True Then
            If CDate(Format(dtpStartDate.Value, "yyyy/MM/dd") & " " & Format(dtpStartTime.Value, "HH:mm:ss")) < CDate(Format(Now, "yyyy/MM/dd") & " " & Format(Now, "HH:mm:ss")) Then _
                MB("Invalid starting date/time of posting!" & vbCr & vbCr & "The time you set: " & Format(dtpStartDate.Value, "yyyy/MM/dd") & " " & Format(dtpStartTime.Value, "HH:mm:ss") & vbCr & "The date/time now: " & Format(Now, "yyyy/MM/dd") & " " & Format(Now, "HH:mm:ss") & vbCr & "The starting date is already past.") : dtpStartDate.Focus() : Return
            If CDate(Format(dtpEndDate.Value, "yyyy/MM/dd") & " " & Format(dtpEndTime.Value, "HH:mm:ss")) <= CDate(Format(dtpStartDate.Value, "yyyy/MM/dd") & " " & Format(dtpStartTime.Value, "HH:mm:ss")) Then _
                            MB("Invalid post expiry date/time!" & vbCr & vbCr & "The expiry date/time is less than starting date/time of posting") : dtpEndDate.Focus() : Return
            If chkSchedAnnounce.Checked = True Then StartDateTime = saveDateTime(dtpStartDate.Value) & " " & saveDateTime(dtpStartTime.Value, SaveDateTimeFormat.OO_OO_OO) _
              : EndDateTime = saveDateTime(dtpEndDate.Value) & " " & saveDateTime(dtpEndTime.Value, SaveDateTimeFormat.OO_OO_OO)
        Else
            'id message startdatetime enddatetime 1
            UPDATEr("tbleannouncement", "primarya=0")
            'INSERTr("tbleannouncement", "'" & generateID("announcementid") & "','" & txtMessage.Text & "','" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "','" & saveDateTime(Now, SaveDateTimeFormat.yyyy_MM_dd) & " 23:59:59',1")
        End If

        If recCount("tbleannouncement", "enddatetime >= '" & saveDateTime(CDate(dtpStartDate.Text & " " & dtpStartTime.Text), SaveDateTimeFormat.yyyy_MM_dd_OO_OO_OO) & "' and primarya=1") > 0 Then
            If MB("There is existing at process announcement." & vbCr & vbCr & "Do you want to replace it with this new announcement?", "?") = "n" Then Return
            UPDATEr("tbleannouncement", "primarya=0")
            INSERTr("tbleannouncement", "'" & generateID("AnnouncementID") & "','" & v(txtMessage.Text, True) & "','" & saveDateTime(CDate(Format(dtpStartDate.Value, "yyyy/MM/dd") & " " & Format(dtpStartTime.Value, "HH:mm:ss"))) & "','" & saveDateTime(CDate(Format(dtpEndDate.Value, "yyyy/MM/dd") & " " & Format(dtpEndDate.Value, "HH:mm:ss"))) & "',1")
        Else : If MB("Do you wish to publish your announcement for this time setting?", "?") = "n" Then Return
            INSERTr("tbleannouncement", "'" & generateID("AnnouncementID") & "','" & v(txtMessage.Text, True) & "','" & saveDateTime(CDate(Format(dtpStartDate.Value, "yyyy/MM/dd") & " " & Format(dtpStartTime.Value, "HH:mm:ss"))) & "','" & saveDateTime(CDate(Format(dtpEndDate.Value, "yyyy/MM/dd") & " " & Format(dtpEndDate.Value, "HH:mm:ss"))) & "',0")
        End If
        If chkSend.Checked = True Then
            If txtSendCopy.Text.Trim = "" Or txtSendCopy.Text.ToLower Like "send copy" Or Not IsNumeric(txtSendCopy.Text.Trim) Then _
            MB("Enter valid message copy value!") : toHL(txtSendCopy) : Return

            If rbSendToAll.Checked = True Then Students = GetRecipientList("select number from tblestudent where block=false and number!=''")
            If chkParent.Checked = True Then ParentsRec = GetRecipientList("select number from tbleparentinfo where block=false and number !=''")
            If chkFaculty.Checked = True Then Faculty = GetRecipientList("select number from tblefacultyutility where block=false and field like '%Faculty%' and number!=''")
            If chkUtility.Checked = True Then Utility = GetRecipientList("select number from tblefacultyutility where block=false and field like '%Utility%' and number!=''")

            'id smstype usernum recid recetype message daettime expiirydat sncdopy alert unicode
            If Not Faculty Is Nothing And chkFaculty.Checked = True Then
                For Each item In Faculty
                    INSERTr("tblesms", gIDVal("Message") & ",'Announcement','" & item & "','" & getVal("tblefacultyutility", "id", "number='" & item & "'") & "','Faculty',concat(replace('" & txtMessage.Text.Trim & " [','\'','*'),sysdate(),']'),'" & StartDateTime & "','" & EndDateTime & "'," & txtSendCopy.Text.Trim & ",0,0")
                    incrementID("Message")
                Next
            End If

            If Not Utility Is Nothing And chkUtility.Checked = True Then
                For Each item In Utility
                    INSERTr("tblesms", gIDVal("Message") & ",'Announcement','" & item & "','" & getVal("tblefacultyutility", "id", "number='" & item & "'") & "','Utility',concat(replace('" & txtMessage.Text.Trim & " [','\'','*'),sysdate(),']'),'" & StartDateTime & "','" & EndDateTime & "'," & txtSendCopy.Text.Trim & ",0,0")
                    incrementID("Message")
                Next

            End If

            If Not Students Is Nothing Then
                For Each item In Students
                    INSERTr("tblesms", gIDVal("Message") & ",'Announcement','" & item & "','" & getVal("tblestudent", "studno", "number='" & item & "'") & "','Student',concat(replace('" & txtMessage.Text.Trim & " [','\'','*'),sysdate(),']'),'" & StartDateTime & "','" & EndDateTime & "'," & txtSendCopy.Text.Trim & ",0,0")
                    incrementID("Message")
                Next
            End If

            If Not ParentsRec Is Nothing And chkParent.Checked = True Then
                For Each item In ParentsRec
                    INSERTr("tblesms", gIDVal("Message") & ",'Announcement','" & item & "','" & getVal("tbleparentinfo p,tblestudent s", "s.studno", "s.rfidtagid=p.rfidtagid and p.number='" & item & "'") & "','Parent',concat(replace('" & txtMessage.Text.Trim & " [','\'','*'),sysdate(),']'),'" & StartDateTime & "','" & EndDateTime & "'," & txtSendCopy.Text.Trim & ",0,0")
                    incrementID("Message")
                Next
            End If
        End If
        LOGS("Announcement created. Announcement ID: " & generateID("AnnouncementID") & ".")
        incrementID("AnnouncementID")
        MB("Campus announcement is now at process.") : Me.Close()
    End Sub

    Private Sub btnCustomize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomize.Click
        Sounds(AUDIO.CLICK)
        frmDeptSendCustomize.ShowDialog()
        If frmDeptSendCustomize.Customized = True Then btnCustomize.Text = "Customize..."
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to cancel?", "?") = "y" Then Me.Close()
    End Sub

    Private Sub txtMessage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.GotFocus
        txtMessage.ForeColor = Color.White
        TextClicked(txtMessage, "--Type your announcement here...")
    End Sub

    Private Sub txtMessage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.LostFocus
        txtMessage.ForeColor = Color.Gray
        If txtMessage.Text.Trim.Trim Like "--Type your announcement here..." Or txtMessage.Text.Trim = "" Then txtMessage.Text = "--Type your announcement here..."
    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        lblRemaining.Text = "Remaining character for SMS: "
        If txtMessage.Text.Length >= 1000 Then lblRemaining.Text &= "0/1000" : Return
        lblRemaining.Text &= (1000 - txtMessage.Text.Length) & "/1000"
    End Sub

    Private Sub rbSendToAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSendToAll.CheckedChanged
        If rbSendToAll.Checked = True Then btnCustomize.Enabled = False
    End Sub

    Private Sub rbCustomize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCustomize.CheckedChanged
        If rbCustomize.Checked = True Then btnCustomize.Enabled = True
    End Sub

    Private Sub txtSendCopy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSendCopy.GotFocus
        txtSendCopy.ForeColor = Color.Black
        If txtSendCopy.Text.Trim.ToLower Like "send copy" Or txtSendCopy.Text.Trim = "" Then txtSendCopy.Text = ""
    End Sub

    Private Sub txtSendCopy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSendCopy.LostFocus
        txtSendCopy.ForeColor = Color.Gray
        If txtSendCopy.Text.Trim.ToLower Like "send copy" Or txtSendCopy.Text.Trim = "" Then txtSendCopy.Text = "Send Copy"
    End Sub

    Private Sub frmAnnouncement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Call btnCancel_Click(sender, e)
    End Sub

    Private Sub chkSchedAnnounce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSchedAnnounce.CheckedChanged
        If chkSchedAnnounce.Checked = True Then lblNoteSched.Show() : gbScheduleAnnouncement.Enabled = True Else gbScheduleAnnouncement.Enabled = False : lblNoteSched.Hide()
    End Sub

    Private Sub chkSend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSend.CheckedChanged
        If chkSend.Checked = True Then lblSMS.Show() : gbSendOption.Enabled = True Else gbSendOption.Enabled = False : lblSMS.Hide()
    End Sub

    Private Sub llblRecent_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRecent.LinkClicked
        frmRecentPost.ShowDialog()
    End Sub

    Private Sub frmAnnouncement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSendCopy.Text = "1"
    End Sub

    Private Sub txtSendCopy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSendCopy.TextChanged

    End Sub
End Class