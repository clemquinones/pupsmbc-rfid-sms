Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Public Class frmSettings

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If recCount("tbleusers", "online=1") > 0 And saveDateTime(dtpClientShtdown.Value, SaveDateTimeFormat.OO_OO_OO) >= saveDateTime(Now, SaveDateTimeFormat.OO_OO_OO) Then
            If MB("The time you have set is already past." & vbCr & "Settings will affect to the next operation." & vbCr & vbCr & "Do you want to saved?", "?") = "n" Then Return
            UPDATEr("tbleid", "Format='" & saveDateTime(dtpClientShtdown.Value, SaveDateTimeFormat.OO_OO_OO) & "'" & IIf(chkCShutdownDefault.Checked = True, ",value=1", ""))
            MB("Saved!") : Me.Close()
        End If
    End Sub
     
    Private Sub btnGSMtest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSMtest.Click
        If Not cmbPort.Items.Contains(cmbPort.Text.Trim) Then MB("Port not on the list!", "!") : toHL(cmbPort) : Return
        If Not cmbBaudRate.Items.Contains(cmbBaudRate.Text.Trim) Then MB("Baud rate not on the list!", "!") : toHL(cmbBaudRate) : Return
        If Not cmbTimeOut.Items.Contains(cmbTimeOut.Text.Trim) Then MB("Time out period not on the list!", "!") : toHL(cmbTimeOut) : Return
        If Not btnGSMtest.Text Like "Test" Then GoTo SAVE
TEST:   Try : If comM.IsOpen Then comM.Close()
            comM = New GsmCommMain(CInt(cmbPort.Text.Trim), CInt(cmbBaudRate.Text.Trim), CInt(cmbTimeOut.Text.Trim))
            If Not comM.IsOpen Then comM.Open()
            MB("Successfully connected!")
        Catch ex As Exception
            MB(ex.Message) : Return
        End Try
        Return
SAVE:   If MB("Do you want to saved?", "?") = "n" Then Return
        Write("[SMSPORT]", cmbPort.Text.Trim)
        Write("[SMSBAUDRATE]", cmbBaudRate.Text.Trim)
        Write("[SMSTIMEOUT]", cmbTimeOut.Text.Trim)
        MB("Saved!") : Return
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClientShtdown.Text = getDateTime(CDate(getVal("tbleid", "format", "field like '%SystemShutdown%'")), GetDateTimeValue.OO_OO_AM_PM)

    End Sub
 
 
    Private Sub llblChange_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblChange.LinkClicked
        frmAccount.Tag = logID
        frmAccount.ShowDialog()
    End Sub
End Class