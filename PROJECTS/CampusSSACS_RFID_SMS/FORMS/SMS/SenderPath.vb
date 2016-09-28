Public Class frmSenderPath
    Private Sub frmSenderPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPath.Text = AppPath
        IFEXISTSMSSENDER = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        With My.Settings 
BROWSE:     Dim ofd As New OpenFileDialog
            ofd = New OpenFileDialog
            ofd.Filter = "SMS Sender Executable file (SenderReceive Application)|*.exe|All files(*.*)|*.*"
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not ofd.FileName.Contains("Receive") Then MB("Wrong executable file!" & vbCr & vbCr & "Find file: sampleReceive.exe", "x") : GoTo BROWSE
                If MB("Do you want to save this path?", "?") = "y" Then
                    .SendSMS_PATH = ofd.FileName : .Save()
                    IFEXISTSMSSENDER = True
                    MB("Saved!")
                    Me.Close()
                Else : GoTo BROWSE
                End If
            Else
                If MB("Do you want to resolve this problem later?" & vbCr & vbCr & "System SMS technology will not function during operation.", "!", "oc") = "c" Then
                    GoTo BROWSE
                Else
                    Me.Close()
                End If
            End If
        End With
    End Sub
End Class