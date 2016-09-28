Imports MySql.Data.MySqlClient
Public Class frmSearchStudentLog
    Dim selected As Integer = 0
    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged
        lvResult.Items.Clear()
        dR = DataReader("select tblestudent.studno,tblestudent.fname,tblestudent.lname,tbletempdetection.rfidtagid from tblestudent,tbletempdetection where tbletempdetection.rfidtagid=tblestudent.rfidtagid and (tblestudent.studno like '%" & txtKey.Text.Trim & "%' or tblestudent.fname like '%" & txtKey.Text.Trim & "%' or tblestudent.lname like '%" & txtKey.Text.Trim & "%')")
        If Not dr.Read Then lblSelected.Text = "" : dr.Close() : CONclose() : Return
        Dim li As New ListViewItem
        Do While dr.Read
            li = lvResult.Items.Add(dr.Item(0))
            li.SubItems.Add(dr.Item(1) & " " & dr.Item(2))
        Loop
        If lvResult.Items.Count >= 1 Then selected = 0 : displaySelect() Else lblSelected.Text = ""
        dR.Close() : CONclose()
    End Sub

  
    Private Sub lvResult_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvResult.ColumnClick
        If MousePosition.X >= lvResult.Left And MousePosition.X <= lvResult.Columns(0).Width Then lvResult.Sort()
    End Sub

    Private Sub lvResult_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvResult.MouseClick

    End Sub

    Private Sub lvResult_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvResult.SelectedIndexChanged
        On Error Resume Next
        lblSelected.Text = lvResult.Items(lvResult.SelectedIndices(0)).SubItems(0).Text
    End Sub

    Private Sub frmSearchStudentLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmClient.Visible = True Then frmClient.tmrRead.Enabled = True
    End Sub

    Private Sub frmSearchStudentLog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Down Then selected += 1 : displaySelect()
        If e.KeyCode = Keys.Up Then selected -= 1 : displaySelect()
        If e.KeyCode = Keys.Enter And Not lblSelected.Text = "" Then
            With frmStudLogDetails : 
                dR = DataReader("select tblestudent.studno,tblestudent.fname,tblestudent.mname," & _
                    "tblestudent.lname,tblestudent.course,tblestudent.yearlevel,tblestudent.section," & _
                    "tbletempdetection.datetime from tblestudent,tbletempdetection" & _
                    " where tblestudent.studno='" & lblSelected.Text & "' and tbletempdetection.rfidtagid=tblestudent.rfidtagid")
                If Not dR.Read Then dR.Close() : CONclose() : Return
                displayPic(lblSelected.Text, .pbPic, "studno")
                .lblName.Text = dR.Item(1) & " " & dR.Item(2) & " " & dR.Item(3)
                .lblStudNo.Text = dR.Item(0)
                .lblCourseYearSec.Text = dR.Item(4) & " " & dR.Item(5) & "-" & dR.Item(6)
                .lblDateTimeLog.Text = getDateTime(dR.Item(7), GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM, "-")
                dR.Close() : CONclose()
                Me.Hide() : .ShowDialog()
            End With
        End If
    End Sub

    Sub displaySelect()
        If selected < lvResult.Items.Count And selected >= 0 Then
            For i As Integer = 0 To lvResult.Items.Count - 1
                lvResult.Items(i).ForeColor = Color.Black
                lvResult.Items(i).BackColor = Color.White
            Next
            lblSelected.Text = lvResult.Items(selected).Text
            If Not txtKey.Text.Trim = "" Then lvResult.Items(selected).ForeColor = Color.Yellow _
              : lvResult.Items(selected).BackColor = Color.Purple
        End If
    End Sub

    Private Sub frmSearchStudentLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class