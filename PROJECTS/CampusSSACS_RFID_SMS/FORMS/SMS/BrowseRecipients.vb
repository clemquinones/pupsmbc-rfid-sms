
Imports MySql.Data.MySqlClient
Public Class frmBrowseRecipients
    Public GBloc As New Point

    Private Sub chkStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStudent.CheckedChanged
        Sounds(AUDIO.CLICK)
        For i As Integer = 0 To LVStud.Items.Count - 1
            LVStud.Items(i).Checked = chkStudent.Checked
        Next
    End Sub

    Private Sub chkParent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkParent.CheckedChanged
        Sounds(AUDIO.CLICK)
        For i As Integer = 0 To LVParent.Items.Count - 1
            LVParent.Items(i).Checked = chkParent.Checked
        Next
    End Sub

    Private Sub chkAllRead_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllRead.CheckedChanged
        Sounds(AUDIO.CLICK)
        For i As Integer = 0 To LVParent.Items.Count - 1
            LVParent.Items(i).Checked = chkAllRead.Checked
        Next
        For i As Integer = 0 To LVStud.Items.Count - 1
            LVStud.Items(i).Checked = chkAllRead.Checked
        Next
    End Sub

    Sub FillCombo()
        cmbDept.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select code from tblecodedesc where field like '%Course%' order by code")
        cmbDept.Items.Add("All Read")
        For Each item In dR : cmbDept.Items.Add(dR.Item(0)) : Next
        cmbDept.SelectedIndex = 0
        dR.Close()
        cmbDept1.SelectedIndex = 0
    End Sub

    Private Sub frmBrowseRecipients_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmBrowseRecipients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = ""

        GBloc = gbStudPar.Location
        FillCombo()
        viewStud()
        viewParent()
        viewFU()
    End Sub

    Public Sub viewStud(Optional ByVal WHERE As String = "")
        LVStud.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select studno,number from tblestudent " & WHERE & " order by studno")
        Dim li As New ListViewItem
        For Each item In dR
            li = LVStud.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
        Next
        dR.Close()
    End Sub
    Public Sub viewParent(Optional ByVal WHERE As String = "")
        LVParent.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select s.studno,p.number from tblestudent s,tbleparentinfo p where p.rfidtagid=s.rfidtagid " & WHERE & " order by s.studno")
        Dim li As New ListViewItem
        For Each item In dR
            li = LVParent.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
        Next
        dR.Close()
    End Sub

    Public Sub viewFU(Optional ByVal WHERE As String = "1")
        LVFU.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select field,lname,fname,mname,number from tblefacultyutility where " & WHERE & " order by field")
        Dim li As New ListViewItem
        For Each item In dR
            li = LVFU.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1) & ", " & dR.Item(2) & " " & dR.Item(3))
            li.SubItems.Add(dR.Item(4))
        Next
        dR.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Sounds(AUDIO.CLICK)
        If (LVStud.CheckedItems.Count <= 0 And LVParent.CheckedItems.Count <= 0 And rbStudParent.Checked = True) Or (rbFacultyUtility.Checked = True And LVFU.CheckedItems.Count <= 0) Then MB("No selected numbers.", "!") : Return
        If MB("Add selected recipients?", "?") = "n" Then Return
        If rbStudParent.Checked = True Then
            For Each i As Integer In LVStud.CheckedIndices
                Me.Tag &= LVStud.Items(i).Text & "|" & LVStud.Items(i).SubItems(1).Text & "|Student" & "; "
            Next
            For Each i As Integer In LVParent.CheckedIndices
                Me.Tag &= LVParent.Items(i).Text & "|" & LVParent.Items(i).SubItems(1).Text & "|Parent" & "; "
            Next
        Else
            For Each i As Integer In LVFU.CheckedIndices
                Me.Tag &= LVFU.Items(i).SubItems(1).Text & "|" & LVFU.Items(i).SubItems(2).Text & "|" & LVFU.Items(i).Text & ";"
            Next
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub cmbDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDept.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
        If cmbDept.Text.Contains("All Read") Then viewStud() : viewParent() : Return
        viewStud("where course='" & cmbDept.Text & "'") : viewParent(" and s.course='" & cmbDept.Text & "'")
    End Sub


    Sub ShowGB()
        gbStudPar.Location = GBloc
        gbFacUtl.Location = GBloc
        gbStudPar.Visible = rbStudParent.Checked
        gbFacUtl.Visible = rbFacultyUtility.Checked
    End Sub

    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStudParent.CheckedChanged, rbFacultyUtility.CheckedChanged
        Sounds(AUDIO.CLICK)
        ShowGB()
    End Sub

    Private Sub chkFaUt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFaUt.CheckedChanged
        Sounds(AUDIO.CLICK)
        'If LVFU.Items.Count <= 0 Then Return
        For i As Integer = 0 To LVFU.Items.Count - 1
            LVFU.Items(i).Checked = chkFaUt.Checked
        Next
    End Sub

    Private Sub chkFaculty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFaculty.CheckedChanged
        Sounds(AUDIO.CLICK)
        For i As Integer = 0 To LVFU.Items.Count - 1
            If LVFU.Items(i).Text.Contains("Faculty") Then LVFU.Items(i).Checked = chkFaculty.Checked
        Next
    End Sub

    Private Sub chkUtility_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUtility.CheckedChanged
        Sounds(AUDIO.CLICK)
        For i As Integer = 0 To LVFU.Items.Count - 1
            If LVFU.Items(i).Text.Contains("Utility") Then LVFU.Items(i).Checked = chkUtility.Checked
        Next
    End Sub

    Private Sub cmbDept1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDept1.SelectedIndexChanged
        Sounds(AUDIO.SELECTED)
        If cmbDept1.Text.Contains("All Read") Or cmbDept1.Text = "" Then viewFU() : Return
        viewFU("field like '%" & cmbDept1.Text & "%'")
    End Sub
End Class