Imports ATSMS
Imports System.IO.Ports
Public Class frmDetectPorts

    Private Sub frmDetectPorts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub AutoDetectGSM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbLoading.Show()
        viewLV()
        pbLoading.Hide()
    End Sub

    Public Sub viewLV()
        LV.Items.Clear()
        For Each item In SerialPort.GetPortNames
            LV.Items.Add(item).SubItems.Add("Undefined")
        Next
        LV.Sort()
    End Sub

    Public Sub Detect()
        For i As Integer = 0 To LV.Items.Count - 1
            Dim GSM As New GSMModem
            Cursor = Cursors.WaitCursor
            Try
                GSM.Port = LV.Items(i).Text
                GSM.Connect()
                LV.Items(i).SubItems(1).Text = "Available"
                Cursor = Cursors.Default : pbLoading.Hide()
            Catch ex As Exception
                Cursor = Cursors.Default : pbLoading.Hide()
                LV.Items(i).SubItems(1).Text = ex.Message
            End Try
        Next
    End Sub

    Dim Scanned As Boolean = False
    Private Sub btnDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetect.Click
        Sounds(AUDIO.CLICK)
        If Scanned = False Then MB("This migth take a few minutes to complete scan.") : Scanned = True
        pbLoading.Show()
        Cursor = Cursors.WaitCursor
        Detect()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub
End Class