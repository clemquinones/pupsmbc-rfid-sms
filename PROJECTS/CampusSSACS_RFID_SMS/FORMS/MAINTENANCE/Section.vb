Public Class frmAddSection
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Sounds(AUDIO.CLICK)
        If MB("Do you want to save?", "?") = "n" Then Return
        Dim YearSec As String = ""
        For i As Integer = 0 To LV.Items.Count - 1
            YearSec &= LV.Items(i).Text & ":" & LV.Items(i).SubItems(1).Text & IIf(i >= LV.Items.Count - 1, "", ";")
        Next
        If Me.Tag = "Add" Then
            Me.Tag = YearSec
        Else
            UPDATEr("tblecodedesc", "section='" & YearSec & "'", "field like '%Course%' and code = '" & frmDeptAddEdit.txtCode.Text.Trim & "'")
        End If
        MB("Saved!") : frmDeptAddEdit.txtYear.Text = LV.Items.Count
        Me.Close()
    End Sub

    Private Sub lbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        On Error Resume Next
        If LV.SelectedIndices(0) < 0 Then txtSec.Text = "" : txtSec.Enabled = False : lblSec.Text = "Select year level" : Return
        txtSec.Enabled = True
        If LV.Items(LV.SelectedIndices(0)).Text = "1" Then
            lblSec.Text = "Enter number of sections in 1st Year"
        ElseIf LV.Items(LV.SelectedIndices(0)).Text = "2" Then
            lblSec.Text = "Enter number of sections in 2nd Year"
        ElseIf LV.Items(LV.SelectedIndices(0)).Text = "3" Then
            lblSec.Text = "Enter number of sections in 3rd Year"
        Else
            lblSec.Text = "Enter number of sections in " & LV.Items(LV.SelectedIndices(0)).Text & "th Year"
        End If
        txtSec.Text = LV.Items(LV.SelectedIndices(0)).SubItems(1).Text
        toHL(txtSec)
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub


    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Sounds(AUDIO.CLICK)
        If txtSec.Text.Trim = "" Then Return
        If Not IsNumeric(txtSec.Text) Then MB("Invalid number of sections value!") : toHL(txtSec) : Return
        LV.Items(LV.SelectedIndices(0)).SubItems(1).Text = txtSec.Text.Trim
    End Sub

    Private Sub AddSection_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Call btnCancel_Click(sender, e)
    End Sub

    Private Sub frmAddSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewLV()
    End Sub
    Sub viewLV()
        LV.Items.Clear() : Dim li As New ListViewItem
        If Me.Tag = "Add" Then
ADD:        For i As Integer = 1 To CInt(frmDeptAddEdit.txtYear.Text.Trim)
                li = LV.Items.Add(i) : li.SubItems.Add("")
            Next
        Else
            Dim YrSec As String = getVal("tblecodedesc", "section", "code='" & frmDeptAddEdit.txtCode.Text.Trim & "'")
            If YrSec.Trim = "" Then GoTo ADD
            For Each item In Split(YrSec, ";")
                item = item.Replace(";", "")
                li = LV.Items.Add(item.Substring(0, 1))
                item = Split(item, ":")(1)
                li.SubItems.Add(item)
            Next
        End If
    End Sub
End Class