Public Class frmPreview

    Private Sub frmPicasa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then frmLessOpacity.Close()
        If e.KeyCode = Keys.Enter Then End
    End Sub
    Private Sub frmPicasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbLogState.SelectedIndex = 0
        viewLV(cmbLogState.Text)
    End Sub

    Public Sub viewLV(Optional ByVal Field As String = "All Read")
        If Field Like "All Read" Then Field = "1" Else Field = " m.logstate like '%" & Field & "%'"
        LV.Items.Clear()
        dR = DataReader("select m.logstate,m.datetime from tblemonitoringlogs m,tblestudent s where m.rfidtagid=s.rfidtagid and s.studno='" & lblStudNo.Text & "' and " & Field & " order by m.datetime desc")
        If Not dR.Read Then CONclose() : Return
        Dim li As New ListViewItem
        Do
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(getDateTime(dR.Item(1), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM))
        Loop While dR.Read
        dR.Close()
        lblRecCounts.Text = "Record counts: " & LV.Items.Count
        LV.Focus()
    End Sub


    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        viewLV(cmbLogState.Text)
    End Sub


    Private Sub cmbLogState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLogState.SelectedIndexChanged
        viewLV(cmbLogState.Text)
    End Sub

    Private Sub llblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblClose.LinkClicked
        frmLessOpacity.Close()
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Escape Then frmLessOpacity.Close()
        If e.KeyCode = Keys.Enter Then End
    End Sub


    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class