Imports MySql.Data.MySqlClient
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter 

Module modSMS

#Region "VARIABLES"
    Public SMSPORT As Integer = Nothing, SMSBAUDRATE As Integer = Nothing, SMSTIMEOUT As Integer = Nothing
    Public SMSVALIDITY As Integer = Nothing, SMSSTOPBITS As Integer = Nothing, SMSSENDDELAY As Integer = Nothing
    Public WithEvents comM As New GsmCommMain
    Public GSMConnected As Boolean = False
#End Region

    Public Function TestSMSPORT() As Boolean
        Try
            Dim dR As MySqlDataReader = DataReader("select port,baudrate,timeout,validity,senddelay,stopbits,logs,announce,anonym from tblegsm limit 1")
            If dR.Read Then
                SMSPORT = Integer.Parse(Replace(dR.Item(0), "COM", ""))
                SMSBAUDRATE = dR.Item(1)
                SMSTIMEOUT = dR.Item(2)
                SMSVALIDITY = dR.Item(3)
                SMSSENDDELAY = dR.Item(4)
                SMSSTOPBITS = dR.Item(5)
                frmSend.Logs = dR.Item(6)
                frmSend.Ann = dR.Item(7)
                frmSend.Anonym = dR.Item(8)
            End If
            dR.Close()
        Catch ex As Exception
        End Try

        Dim comMtest As New GsmCommMain
        Try
            If comM.IsConnected Or comM.IsOpen Then comM.Close()
            '  closeComm()
            ' If comMtest.IsOpen = True Then comMtest.Close()
            comMtest = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
            comMtest.Open()
            comMtest.Close()
            TestSMSPORT = True
            Return True
        Catch ex As Exception
            Try
                comM.Close()
            Catch x As Exception
            End Try

            TestSMSPORT = False
            closeComm()
            If comMtest.IsConnected Or comM.IsOpen Then comMtest.Close()
            Return False
        End Try
    End Function

    Public Sub openComm()
        Try
OPEN:       '    closeComm()
            If comM.IsConnected Or comM.IsOpen Then comM.Close()
            comM = New GsmCommMain(SMSPORT, SMSBAUDRATE, SMSTIMEOUT)
            comM.Open()
            GSMConnected = True
        Catch ex As Exception
            Try
                comM.Close()
            Catch x As Exception
            End Try
            GSMConnected = False
        End Try
    End Sub
    Public Sub closeComm()
        Try
            If comM.IsConnected = True Or comM.IsOpen Then comM.Close()
        Catch ex As Exception
        End Try
    End Sub

End Module
