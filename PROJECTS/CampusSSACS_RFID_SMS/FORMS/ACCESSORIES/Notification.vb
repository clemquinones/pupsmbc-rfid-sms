Imports MySql.Data.MySqlClient

Public Class frmNotification

    Private Sub tcNoti_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcNoti.SelectedIndexChanged

    End Sub

    Private Sub frmNotification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub List()
        'reciv sent queued saved block tempall tempin tempout monit
        Dim dR As MySqlDataReader = DataReader("select (select count(*) from tblesms where smstype like '%Received%'),(select count(*) from tblesms where smstype like '%Sent' and smstype not like 'ToSent'),(select count(*) from tblesms where smstype like 'ToSent' or smstype like 'Logs' or smstype like 'Announcement'),(select count(*) from tblesms where smstype like 'UnSent'),(select count(*) from tbleparentinfo where block=1)," & _
                        "(select count(*) from tbletempdetection),(select count(*) from tbletempdetection where field like 'Log in'),(select count(*) from tbletempdetection where field like 'Log out'),(select count(*) from tblemonitoringlogs)")
        If dR.Read Then
            lblInbox.Text = "Inbox Messages: " & dR.Item(0)
            lblSent.Text = "Sent Messages: " & dR.Item(1)
            lblQueued.Text = "Queued Messages: " & dR.Item(2)
            lblSave.Text = "Saved Messages: " & dR.Item(3)
            lblUnSubscribe.Text = "Parents Unsubscribed: " & dR.Item(4)
            lblTTotal.Text = "Todays total detections: " & dR.Item(5)
            lblTLogn.Text = "Todays total log in detections: " & dR.Item(6)
            lblTLogOut.Text = "Todays total log out detections: " & dR.Item(7)
            lblTotal.Text = "Total detections: " & dR.Item(8)
        End If
        dR.Close()
    End Sub

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        List()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class