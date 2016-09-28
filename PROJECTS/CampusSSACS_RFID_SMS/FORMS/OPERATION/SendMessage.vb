Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Public Class frmSend
    Public Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If TestSMSPORT(SMSPORT) = False Then
            MB("Unable to connect to any  GSM Module." & vbCr & vbCr & "Make sure  it is  properly attached  to this  machine.")
            If MB("Do  you want to show  the GSM Module Connection Set up?", "?") = "y" Then frmGSM_Module_Setting.ShowDialog()
            Return
        End If

        Cursor = Cursors.WaitCursor
        If rbSendToSpecific.Checked = True Then
            Try
                comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
                If Not comM.IsConnected = True Or Not comM.IsOpen = True Then comM.Open()
                pdU = New SmsSubmitPdu(txtMessage.Text, txtNumber.Text.Trim, "")
                comM.SendMessage(pdU)
                If comM.IsConnected = True Or comM.IsOpen = True Then comM.Close()
                lblOutPut.Text = "Message sent!"
            Catch ex As Exception
                MB(ex.Message)
            End Try
        Else
            Dim Numbers As String = "", DestCTR As Integer = 0
            For x As Integer = 0 To lvStud.Items.Count - 1
                If Not lvStud.Items(x).SubItems(3).Text = "" Then DestCTR += 1 : Numbers &= lvStud.Items(x).SubItems(3).Text & ";"
                If Not lvStud.Items(x).SubItems(4).Text = "" Then DestCTR += 1 : Numbers &= lvStud.Items(x).SubItems(4).Text & ";"
            Next
            Dim DestinationNo(DestCTR - 1) As String, i As Integer = 0
            For Each s As String In Split(Numbers, ";")
                If Not s.Trim = "" Then DestinationNo(i) = a : i += 1
            Next
            Send(txtMessage.Text, DestinationNo, lblOutPut, CInt(txtSendTimes.Text.Trim))
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub txtMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged
        lblRemaining.Text = "Remaining(" & (1000 - txtMessage.Text.Length) & "/1000)"
    End Sub

    Sub viewLV(Optional ByVal sql As String = "")
        'On Error Goto c
        'studno,course,year,sec,name,number,pnumber
        Dim RFID As String = ""
        If sql = "" Then sql = "select tblestudent.studno,tblestudent.course,tblestudent.yearlevel,tblestudent.section,tblestudent.fname,tblestudent.mname,tblestudent.lname,tblestudent.number,tbleparentinfo.number from tblestudent,tbleparentinfo where tblestudent.rfidtagid=tbleparentinfo.rfidtagid"
        dR = DataReader(sql)
        Dim li As New ListViewItem : lvStud.Items.Clear()
        If Not dR.Read Then Exit Sub
        Do
            li = lvStud.Items.Add(dr.Item(0))
            li.SubItems.Add(dr.Item(1) & " " & dr.Item(2) & "-" & dr.Item(3))
            li.SubItems.Add(dr.Item(4) & " " & dr.Item(5).ToString.Substring(0, 1).ToUpper & ". " & dr.Item(6))
            li.SubItems.Add(dr.Item(7))
            li.SubItems.Add(dr.Item(8))
        Loop While dr.Read
c:      dr.Close() : CONclose()

        Dim Counter As Integer = 0
        For i As Integer = 0 To lvStud.Items.Count - 1
            If Not lvStud.Items(i).SubItems(3).Text = "" Then Counter += 1
            If Not lvStud.Items(i).SubItems(3).Text = "" Then Counter += 1
        Next
        lblOutPut.Text = "Total number of recipients: " & Counter & "."
    End Sub

    Private Sub chkSendTimes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSendTimes.CheckedChanged
        If chkSendTimes.Checked = True Then toHL(txtSendTimes)
    End Sub

    Private Sub frmSend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        viewLV()
    End Sub

 
End Class