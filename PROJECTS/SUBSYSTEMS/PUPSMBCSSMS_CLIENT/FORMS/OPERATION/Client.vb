Option Strict Off
Option Explicit On
Imports MySql.Data.MySqlClient
Imports PUPSMBCSSMS_CLIENT.My.Resources
Imports System.Windows.Forms

Public Class frmClient
    Inherits System.Windows.Forms.Form

#Region "RESET"
    Public Sub reSET()
        'Me.BackgroundImage = Resources.BGLigthBlue
        pbMainPic.Left = (Me.Width / 2) - (pbMainPic.Width / 2)
        'gbMainInfo.Left = pbMainPic.Left + pbMainPic.Width + 5
        pbMainPic.Image = Resources.No_Picture
        pbLogIn(0).Image = Resources.No_Picture
        pbLogIn(1).Image = Resources.No_Picture
        pbLogIn(2).Image = Resources.No_Picture
        pbLogIn(3).Image = Resources.No_Picture
        pbLogOut(0).Image = Resources.No_Picture
        pbLogOut(1).Image = Resources.No_Picture
        pbLogOut(2).Image = Resources.No_Picture
        pbLogOut(3).Image = Resources.No_Picture
        btnLogInPrev.Image = Nothing
        btnLogInNext.Image = Nothing
        btnLogOutPrev.Image = Nothing
        btnLogOutNext.Image = Nothing

        lblLogState.Text = "WELCOME"
        lblStudNo.Text = "Student Number"
        lblName.Text = "Name"
        lblCourse.Text = "Department"
        lblYearSec.Text = "Year-Section"
        lblDateTimeLog.Text = "Date Time Log" '  getDateTime(sDT, GetDateTimeValue.MM_dd_yyyy_OO_OO_OO_AM_PM_DAYOFWEEK)
        dS = New DataSet
    End Sub
#End Region
#Region "KEYDOWN EVENTS"

    Private Sub frmClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UPDATEr("tbleid", "value=0", "field like '%Client%'")
    End Sub
    Private Sub frmClient_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then Call btnLogOut_Click(sender, e)
    End Sub
#End Region

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOGS("Client was started.")

        reSET()
    End Sub


    Private Sub pbLogOutNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LogOutNext = False Then Return Else btnLogOutPrev.Image = Resources.PreviousArrow : LogOutPrev = True
    End Sub
    Private Sub pbLogOutPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LogOutPrev = False Then Return
    End Sub
    Private Sub pbLogInNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LogInNext = False Then Return
    End Sub
    Private Sub pbLogInPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LogInPrev = False Then Return Else btnLogInNext.Image = Resources.NextArrow : LogInNext = True
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        tmrRead.Stop()
        If MB("Log out " & logID & "?", "?") = "n" Then tmrRead.Enabled = True : Return
        UPDATEr("tbleusers", "online=0", "userid='" & logID & "'")
        LOGS("Log out client manager " & logID & ". End monitoring.")
        Me.Close()
        frmLogIn.Show()
    End Sub

    Dim LogInMain As Boolean = False
    Private Sub tmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRead.Tick
        If recCount("tbleusers", "userid='" & logID & "' and online=0") > 0 Then ' CBool(getVal("tbleusers", "online", "userid='" & logID & "'")) = False Then
            tmrRead.Stop() : tmrAnn.Stop()
            Me.Enabled = False
            If CBool(gIDVal("ShutdownDisconnect")) = True Then
                Shell("shutdown -c ""This computer will shutdown in a moment..."" -f -s -t 3600")
                MB("Cannot continue the operation." & vbCr & vbCr & "You have been disconnected by the administrator." & vbCr & vbCr & "System will now shutdown...", "x") : End
            Else : If MB("Cannot continue the operation." & vbCr & vbCr & "You have been disconnected by the administrator." & vbCr & "Do you want to shutdown client?", "x", "oc") = "o" Then
                    Shell("shutdown -c ""This computer will shutdown in a moment..."" -f -s -t 3600") : End
                End If
            End If
            Return
        End If


        Dim dR As MySqlDataReader = DataReader("select s.studno,s.fname,s.mname,s.lname,s.course,s.yearlevel,s.section,s.unlogout,d.datetime from tbletempdetection d,tblestudent s where d.rfidtagid=s.rfidtagid order by d.datetime desc limit 1")
        If dR.Read Then : LogInMain = dR.Item(7)
            lblStudNo.Text = dR.Item(0)
            lblName.Text = dR.Item(1) & " " & dR.Item(2).ToString.Substring(0, 1) & ". " & dR.Item(3)
            Dim course As String = dR.Item(4)
            If dR.Item(5) = 1 Then : lblYearSec.Text = "1st Year Section "
            ElseIf dR.Item(5) = 2 Then : lblYearSec.Text = "2nd Year Section "
            ElseIf dR.Item(5) = 3 Then : lblYearSec.Text = "3rd Year Section "
            Else : lblYearSec.Text = dR.Item(5) & "th Year Section" : End If
            lblYearSec.Text &= dR.Item(6)
            If dR.Item(7) Then lblLogState.Text = "LOG IN" Else lblLogState.Text = "LOG OUT"
            lblDateTimeLog.Text = getDateTime(sDT, GetDateTimeValue.MM_dd_yyyy_OO_OO_AM_PM, "-")
            displayPic(dR.Item(0), pbMainPic, "studno")
            lblCourse.Text = getVal("tblecodedesc", "description", "field like '%course%'  and  code='" & course & "'")
        Else
            dR.Close() : GoTo c
        End If
        dR.Close()
UPDATEPREVIOUS:
        On Error Resume Next
        openCONN()
        Dim dALogIn As New MySqlDataAdapter("select s.studno,d.datetime from tblestudent s,tbletempdetection d where s.rfidtagid=d.rfidtagid and d.field like '%Log in%' order by d.datetime desc limit " & IIf(LogInMain = True, "1,", "") & "5", conN)
        dALogIn.Fill(dS)
        Dim logInCount As Integer = dS.Tables(0).Rows.Count
        If logInCount > 4 Then LogInctr = 0 : btnLogInPrev.Show() Else btnLogInPrev.Hide()
        With dS.Tables(0)
            For i As Integer = 0 To logInCount - 2
                lblLogInSN(i).Text = .Rows(i).Item(0)
                lblLogIn(i).Text = getDateTime(.Rows(i).Item(1), GetDateTimeValue.OO_OO_AM_PM)
                displayPic(.Rows(i).Item(0), pbLogIn(i), "studno")
            Next
        End With
        dS = New DataSet
        openCONN()
        Dim dALogOut As New MySqlDataAdapter("select s.studno,d.datetime from tblestudent s,tbletempdetection d where s.rfidtagid=d.rfidtagid and d.field like '%Log out%' order by d.datetime desc limit " & IIf(LogInMain = False, "1,", "") & "5", conN)
        dALogOut.Fill(dS)
        Dim logOutCount As Integer = dS.Tables(0).Rows.Count
        If logOutCount > 4 Then btnLogOutPrev.Show() Else btnLogOutPrev.Hide()
        With dS.Tables(0)
            For i As Integer = 0 To logOutCount - 2
                lblLogOutSN(i).Text = .Rows(i).Item(0)
                lblLogOut(i).Text = getDateTime(.Rows(i).Item(1), GetDateTimeValue.OO_OO_AM_PM)
                displayPic(.Rows(i).Item(0), pbLogOut(i), "studno")
            Next
        End With
        dS = New DataSet : CONNclose()
c:
    End Sub

    Private Sub btnOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOption.Click
        If recCount("tbleusers", "operatever=0 and shutdownclient=0 and userid='" & logID & "'") Then MB("You do not have a proper privilege to have system options!" & vbCr & vbCr & "Contact administrator regarding this issue.", "!") : Return
        frmVeriication.ShowDialog()
    End Sub



#Region "MOUSEMOVE/MOUSELEAVE"
    Private Sub btnSearch_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSearch.MouseMove
        btnSearch.BackColor = Color.Purple
        btnSearch.ForeColor = Color.Yellow
    End Sub

    Private Sub btnOption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOption.MouseMove
        btnOption.BackColor = Color.Purple
        btnOption.ForeColor = Color.Yellow
    End Sub

    Private Sub btnLogOut_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLogOut.MouseMove
        btnLogOut.BackColor = Color.Purple
        btnLogOut.ForeColor = Color.Yellow
    End Sub

    Private Sub btnSearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackColor = Color.Maroon
        btnSearch.ForeColor = Color.White
    End Sub

    Private Sub btnOption_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOption.MouseLeave
        btnOption.BackColor = Color.Maroon
        btnOption.ForeColor = Color.White
    End Sub

    Private Sub btnLogOut_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.BackColor = Color.Maroon
        btnLogOut.ForeColor = Color.White
    End Sub
    Private Sub btnLogOut_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLogOut.MouseDown
        btnLogOut.BackColor = Color.DarkSlateGray
        btnLogOut.ForeColor = Color.WhiteSmoke
    End Sub
#End Region


    Private Sub btnChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChat.Click
        frmChat.Show()
    End Sub

    Private Sub btnFindStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindStud.Click
        If btnFindStud.Tag = "Find" Then btnFindStud.Tag = "Hide" : gbFindStud.Show() : toHL(txtKey) Else _
  btnFindStud.Tag = "Find" : gbFindStud.Hide() : lblResult.Hide()
    End Sub

    Private Sub txtKey_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.GotFocus
        txtKey.ForeColor = Color.Black : TextClicked(txtKey, "Search")
    End Sub

    Private Sub txtKey_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKey.KeyDown
        If e.KeyCode = Keys.Escape And btnFindStud.Tag = "Hide" Then lblResult.Hide() : Call btnFindStud_Click(sender, e) : Return
        If Not e.KeyCode = Keys.Enter Then Return
        lblResult.Hide() : showResults(txtKey.Text.Trim)
    End Sub

    Private Sub txtKey_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKey.LostFocus
        txtKey.ForeColor = Color.Gray : If txtKey.Text.Trim.ToUpper Like "search" Or txtKey.Text.Trim = "" Then txtKey.Text = "Search"
    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged
        txtKey.Text = LTrim(txtKey.Text)
        If txtKey.Text.Trim = "" Or txtKey.Text.Trim.ToLower = "search" Then lblResult.Hide() : Return
        lblResult.Show()
        Dim dR As MySqlDataReader = DataReader("select studno,fname,mname,lname from tblestudent where studno like '%" & txtKey.Text.Trim & "%' or fname like '%" & txtKey.Text.Trim & "%' or mname like '%" & txtKey.Text.Trim & "%' or lname like '%" & txtKey.Text.Trim & "%'")
        Dim Count As Integer = 0
        For Each item As Object In dR : Count += 1
            If Count = 1 Then lblResult.Text = dR.Item(0) & " | " & dR.Item(1) & " " & dR.Item(2) & " " & dR.Item(3)
        Next
        dR.Close()
        If Count <= 0 Then
            lblResult.Text = "No matches result for '" & txtKey.Text.Trim & "'"
        Else
            lblResult.Text = Count & " Matches: " & lblResult.Text & IIf(Count > 1, " ...", "")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If recCount("tbleusers", "searchstud=0 and userid='" & logID & "'") Then MB("You do not have a proper privilege to search studen logs!" & vbCr & vbCr & "Contact administrator regarding this issue.", "!") : Return
        frmSearchStudent.ShowDialog()
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        If recCount("tbleannouncement", "primarya=1 and current_date() between startdatetime and enddatetime") <= 0 Then
            Ann = SPACES() & "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES STA. MARIA CAMPUS STUDENT SECURITY MONITORING SYSTEM USING RADIO FREQUENCY IDENTIFICATION WITH SMS TECHNOLOGY"
        Else
            Ann = SPACES() & getVal("tbleannouncement", "message", "primarya=1")
        End If
        lblDate.Text = FormatDateTime(sDT, DateFormat.LongDate)
        lblTime.Text = getDateTime(sDT, GetDateTimeValue.OO_OO_OO_AM_PM)
    End Sub

    Dim Ann As String = "PUPSMBCSSMS"
    Dim Ann_ctr As Integer = 0
    Function SPACES() As String
        tmrAnn.Interval = 100
        Dim s As String = ""
        For i As Integer = 0 To 100
            s &= " "
        Next
        SPACES = s
    End Function

    Private Sub tmrAnn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnn.Tick
        Ann_ctr += 1
        If Ann_ctr >= Ann.Length Then Ann_ctr = 0
        lblAnn.Text = Ann.Substring(Ann_ctr)
    End Sub

    Dim LogInctr As Integer = 0
    Private Sub btnLogInPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogInPrev.Click
        btnLogInNext.Show()
        LogInctr += 1
        openCONN()
        Dim dALogIn As New MySqlDataAdapter("select s.studno,d.datetime from tblestudent s,tbletempdetection d where s.rfidtagid=d.rfidtagid and d.field like '%Log in%' order by d.datetime desc limit " & IIf(LogInMain = True, LogInctr & ",", "") & "4", conN)
        Dim dS_Login As New DataSet
        dALogIn.Fill(dS_Login)
        Dim logCount As Integer = dS_Login.Tables(0).Rows.Count
        With dS_Login.Tables(0)
            For i As Integer = 0 To logCount - 1
                lblLogInSN(i).Text = .Rows(i).Item(0)
                lblLogIn(i).Text = getDateTime(.Rows(i).Item(1), GetDateTimeValue.OO_OO_AM_PM)
                displayPic(.Rows(i).Item(0), pbLogIn(i), "studno")
            Next
        End With
    End Sub

    Private Sub btnLogOutNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOutNext.Click
        btnLogOutPrev.Show()
    End Sub
End Class

