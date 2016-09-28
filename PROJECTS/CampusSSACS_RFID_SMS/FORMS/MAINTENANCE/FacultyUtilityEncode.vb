
Public Class frmFacultyUtilityEncode

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddEditFacultyUtility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RELOAD()
        viewLV()
    End Sub

    Public Sub viewLV(Optional ByVal SQL As String = "")
        If SQL = "" Then SQL = "select id,field,fname,mname,lname from tblefacultyutility order by id"
        LV.Items.Clear() : Dim li As New ListViewItem
        Dim dR As MySql.Data.MySqlClient.MySqlDataReader = DataReader(SQL)
        For Each item In dR
            li = LV.Items.Add(dR.Item(0))
            li.SubItems.Add(dR.Item(1))
            li.SubItems.Add(dR.Item(2) & " " & dR.Item(3) & " " & dR.Item(4))
        Next
        dR.Close()
        RELOAD()
    End Sub

    Private Sub bUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click

        If tFN.Text.Trim = "" Then MB("Enter first name!") : toHL(tFN) : Return
        If tMN.Text.Trim = "" Then MB("Enter middle name!") : toHL(tMN) : Return
        If tLN.Text.Trim = "" Then MB("Enter last name!") : toHL(tLN) : Return
        If tNumber.Text.Trim = "" Then MB("Enter contact number!") : toHL(tNumber) : Return
        If cmbField.Text = "" Then MB("Select field!") : Return

        If bSave.Text = "Save" Then
            If MB("Do you want to add this " & cmbField.Text & "?", "?") = "n" Then Return
            INSERTr("tblefacultyutility", "'" & cmbField.Text & "','" & lbllD.Text & "','" & tFN.Text.Trim & "','" & tMN.Text.Trim & "','" & tLN.Text.Trim & "','" & tNumber.Text.Trim & "'," & Not chkSend.Checked)
            incrementID("FacultyUtility")
            MB("Saved!")
        Else
            If NoSelected(LV) Then Return
            If MB("Do you want to update this " & cmbField.Text & "?", "?") = "n" Then Return
            UPDATEr("tblefacultyutility", "fname='" & tFN.Text.Trim & "',mname='" & tMN.Text.Trim & "',lname='" & tLN.Text.Trim & "',block=" & Not chkSend.Checked, "id='" & lbllD.Text & "'")
            MB("Updated!")
        End If
        frmAddEditFacultyUtility_Load(sender, e)
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged
        '  On Error Resume Next
        If LV.Items.Count <= 0 Then RELOAD()
        If LV.SelectedItems.Count <= 0 Then
            RELOAD()
        Else
            Dim dR As MySql.Data.MySqlClient.MySqlDataReader = DataReader("select id,fname,mname,lname,number,block from tblefacultyutility where id='" & LV.SelectedItems(0).Text & "'")
            If dR.Read Then
                lbllD.Text = LV.SelectedItems(0).Text
                tFN.Text = dR.Item(1)
                tMN.Text = dR.Item(2)
                tLN.Text = dR.Item(3)
                tNumber.Text = dR.Item(4)
                chkSend.Checked = Not dR.Item(5)
            End If
            dR.Close()
            bRemove.Enabled = True
            bAdd.Show()
            RELOAD(False)
        End If
    End Sub

    Private Sub bRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRemove.Click
        If NoSelected(LV) Then Return
        If MB(LV.SelectedItems(0).Text & vbCr & vbCr & "Do you want to remove this " & cmbField.Text & "?", "?") = "n" Then Return
        DELETEr("tblefacultyutility", "id='" & lbllD.Text & "'")
        MB("Deleted!")
        frmAddEditFacultyUtility_Load(sender, e)
    End Sub


    Sub RELOAD(Optional ByVal en As Boolean = True)
        If en Then
            lbllD.Text = generateID("FacultyUtility")
            tFN.Text = ""
            tMN.Text = ""
            tLN.Text = ""
            tNumber.Text = ""
            chkSend.Checked = False
            cmbField.Text = ""
            cmbField.Enabled = True
            bRemove.Enabled = False
            bSave.Text = "Save"
        Else
            cmbField.Enabled = False
            bRemove.Enabled = True
            bSave.Enabled = True
            bSave.Text = "Update"
        End If
    End Sub

    
    Private Sub bAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAdd.Click
        bAdd.Hide()
        RELOAD()
    End Sub
End Class