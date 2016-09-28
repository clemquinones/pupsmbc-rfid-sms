Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports MySql.Data.MySqlClient

Public Class frmSMSSender
    Public WithEvents comM As GsmCommMain
    Public Sending As Boolean = False
    Dim Starting As Boolean = True

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Starting = True
        lblStatus.Text = "Initializing messages..."
        tmrDetect.Start()
        DataSource = My.Settings.SERVER
        dbUserID = My.Settings.UID
        dbPassword = My.Settings.PWD
        DB = My.Settings.DB
        Dim CMd As New MySqlCommand
        openCon()
        Dim dR As MySqlDataReader = DataReader("select replace(port,'COM',''),baudrate,timeout from tblegsm")
        If dR.Read Then
            SMSPORT = CInt(dR.Item(0))
            BAUDRATE = dR.Item(1)
            TIMEOUT = dR.Item(2)
        End If
        dR.Close()
        UPDATEr("tbleid", "value=1", "field = 'SMSSending'")
        Try
            comM = New GsmCommMain(SMSPORT, BAUDRATE, TIMEOUT)
            comM.Open()
            comM.EnableMessageNotifications()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tmrDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetect.Tick
        On Error Resume Next
        lblStatus.Text = "Processing..."
        'Me.Visible = False
        If Not Sending Then
            If Logs() Then
                If comM.IsOpen Then comM.Close()
                SendLogs()
            ElseIf Announce() Then
                If comM.IsOpen Then comM.Close()
                SendAnnounce()
            ElseIf Anonymous() Then
                If comM.IsOpen Then comM.Close()
                SendAnonymous()
            Else
                If comM.IsOpen Then comM.Close()
                comM = New GsmCommMain(SMSPORT, BAUDRATE, TIMEOUT)
                comM.Open()
                ReadUnReadMessage()
                comM.Close()
            End If
        End If
        If Not CBool(gIDVal("SMSSending", True)) Then
            Me.Visible = True
            lblStatus.Text = "Finishing task..."
            tmrDetect.Stop()
            tmrEnding.Start()
        End If
    End Sub

    Public Sub ReadUnReadMessage()
        ' On Error Resume Next
        Try
            Dim messages() As DecodedShortMessage = comM.ReadMessages(PhoneMessageStatus.ReceivedUnread, PhoneStorageType.Sim)
            For Each message As DecodedShortMessage In messages
                Dim data As SmsDeliverPdu = CType(CType(message.Data, SmsPdu), SmsDeliverPdu)
                Dim Text As String = data.UserDataText
                Dim UserNum As String = ""
                If data.OriginatingAddress.ToString.Length > 10 Then
                    UserNum = data.OriginatingAddress.ToString.Substring(data.OriginatingAddress.Length - 10, 10)
                Else
                    UserNum = data.OriginatingAddress
                End If
                comM.DeleteMessage(message.Index, PhoneStorageType.Sim)
                If Parents(UserNum, Text) Then : Parent_Command(UserNum, Text)
                ElseIf User(UserNum, Text) Then : User_Command(UserNum, Text)
                ElseIf UnRegistered(UserNum, Text) Then : Unreg_Command(UserNum, Text)
                End If
            Next
        Catch ex As Exception
            UPDATEr("tbleid", "value=0", "field = 'SMSSending'")
            Sender.tmrEnding.Start()
        End Try

    End Sub

    Private Sub tmrEnding_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnding.Tick
        End
    End Sub
    Public Sub EndNow()
        UPDATEr("tbleid", "value=0", "field = 'SMSSending'")
        lblStatus.Text = "Finishing task..."
        tmrEnding.Start()
    End Sub

    Private Sub comM_MessageSendFailed(ByVal sender As Object, ByVal e As GsmComm.GsmCommunication.MessageErrorEventArgs) Handles comM.MessageSendFailed
        MsgBox(e.Exception.Message, MsgBoxStyle.Information, "Check operator service")
    End Sub
End Class

