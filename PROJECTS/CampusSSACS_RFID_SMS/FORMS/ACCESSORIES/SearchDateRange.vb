Public Class frmSearchDateRange
    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If CDate(Format(dtpEnd.Value, "yyyy/MM/dd")) < CDate(Format(dtpStart.Value, "yyyy/MM/dd")) Then
            MB("Illegal set of end date." & vbCr & vbCr & "End date must be less than or equal to start date.") : dtpEnd.Focus() : Return
        End If
        If CDate(Format(dtpStart.Value, "yyyy/MM/dd")) > CDate(Format(Now, "yyyy/MM/dd")) Then
            MB("The starting date is greater than the system date." & vbCr & vbCr & "Make sure the system date is updated") : dtpStart.Focus() : Return
        End If
        Dim StartDate As String = Format(dtpStart.Value, "yyyy/MM/dd") & " 00:00:01"
        Dim EndDate As String = Format(dtpEnd.Value, "yyyy/MM/dd") & " 23:59:59"

        If Me.Tag.ToString.ToLower = "studentlogrecord" Then
            '     frmStudentLogRecord.viewLV("select tblestudent.studno,tblestudent.fname,tblestudent.mname,tblestudent.lname," & _
            '    "tblestudent.course,tblestudent.yearlevel,tblestudent.section,tbletempdetection.field," & _
            '    "tbletempdetection.datetime from tblestudent,tbletempdetection where tbletempdetection.rfidtagid=tblestudent.rfidtagid " & _
            '    " and tbletempdetection.datetime between '" & StartDate & "' and '" & EndDate & "' order by tbletempdetection.datetime")
            frmStudentLogRecord.viewLV("select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section,m.logstate,m.datetime from tblestudent s,tblemonitoringlogs m where m.rfidtagid=s.rfidtagid and m.datetime between '" & StartDate & "' and '" & EndDate & "'")
        End If
        Me.Close()
    End Sub

    Private Sub frmSearchDateRange_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
 
    Private Sub frmSearchDateRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class