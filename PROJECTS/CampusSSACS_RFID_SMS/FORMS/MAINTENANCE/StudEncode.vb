
Imports MySql.Data.MySqlClient
Imports CampusSSACS_RFID_SMS.My.Resources
Imports System.IO
Public Class frmEncodeStudInfo
    Dim imgName As String

    Dim MyParam As New MySqlParameter
    Dim Read As Boolean = False
    Public Tag_STUDNO As String = ""
#Region "BTNSAVE"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo c
        Sounds(AUDIO.CLICK)
        If txtStudNo.Text Like "Student Number" Or txtStudNo.Text.Trim = "" Then toHL(txtStudNo) : Exit Sub
        If txtFName.Text.ToLower = "first" Or txtFName.Text.Trim = "" Then toHL(txtFName) : Return
        If txtMName.Text.ToLower = "middle" Or txtMName.Text.Trim = "" Then toHL(txtMName) : Return
        If txtLName.Text.ToLower = "last" Or txtLName.Text.Trim = "" Then toHL(txtLName) : Return
        If Not IsNumeric(txtONumber.Text) Then MB("Invalid number!", "!") : toHL(txtONumber) : Return
        If txtAddress.Text.Trim = "" Or txtAddress.Text.Trim Like "Address" Then toHL(txtAddress) : Return
        If cmbCourse.FindStringExact(cmbCourse.Text.Trim) < 0 Or cmbYearLevel.Text.Trim = "" Then toHL(cmbCourse) : Return
        If Not IsNumeric(cmbYearLevel.Text.Trim) Or cmbYearLevel.Text.Trim = "" Then MB("Enter numeric value for year level!") : toHL(cmbYearLevel) : Return
        ' If Not cmbYearLevel.FindStringExact(cmbYearLevel.Text.Trim) > 0 Then MB("Year level out of bounds.") : toHL(cmbYearLevel) : Return
        If Not IsNumeric(cmbSection.Text.Trim) Then MB("Enter numeric value for section!") : toHL(cmbSection) : Return
        If Not IsNumeric(cmbSection.Text.Trim) Then toHL(cmbSection) : Return
        If cmbStatus.Text = "" Or Not IsNumeric(cmbSection.Text) Then MB("Invalid status", "!") : Return
        If txtFNameP.Text.ToLower = "first" Or txtFNameP.Text.Trim = "" Then toHL(txtFNameP) : Return
        If txtLNameP.Text.ToLower = "last" Or txtLNameP.Text.Trim = "" Then toHL(txtLNameP) : Return
        If txtPRelation.Text Like "Relation" Or txtPRelation.Text.Trim = "" Then toHL(txtPRelation) : Return
        If Not IsNumeric(txtPNumber.Text.Trim) Then MB("Invalid number!", "!") : toHL(txtPNumber) : Return

        If Me.Tag = "Add" Then
            If recCount("tblestudent", "studno='" & txtStudNo.Text.Trim & "'") > 0 Then MB("Student number already exist.", "!") : Return
            If cmbGender.FindStringExact(cmbGender.Text.Trim) < 0 Or cmbGender.Text.Trim = "" Then toHL(cmbGender) : Return
            If G_rHandle < 0 Then MB("Device is disconnected!", "!") : Return
            If recCount("tblestudent", "rfidtagid='" & lblRFID.Text & "'") > 0 Then MB("This card is already registered.") : Return
            If Read = False Then MB("Please present the rfid card.") : Return
            If MB("Save student information?", "?") = "n" Then Return
            'On Error GoTo c
            AddStudent("insert into tblestudent values('" & v(txtStudNo.Text.Trim) & "','" & lblRFID.Text & "','" & lblPasscode.Text & "','" & v(txtFName.Text.Trim) & _
                    "','" & txtMName.Text.Trim & "','" & txtLName.Text.Trim & "','" & txtAddress.Text.Trim & "','" & cmbCourse.Text & "'," & cmbYearLevel.Text & "," & _
                    cmbSection.Text & ",'" & cmbStatus.Text & "','" & cmbGender.Text & "','" & v(txtONumber.Text.Trim) & "',@img,0,0)")
            INSERTr("tbleparentinfo", "'" & IDserialNo & "','" & v(txtFNameP.Text.Trim) & "','" & _
                   v(txtLNameP.Text.Trim) & "','" & v(txtPNumber.Text.Trim) & "','" & v(txtPRelation.Text.Trim) & "'," & Not chkSendAdvisory.Checked)
            LOGS("Encoded student " & v(txtStudNo.Text.Trim) & ".")
            MB("Saved!") : reLOAD()
        ElseIf Me.Tag = "Edit" Then
            If MB("Update student details?", "?") = "n" Then Return
            UPDATEr("tblestudent", "fname='" & v(txtFName.Text.Trim) & "',mname='" & v(txtMName.Text.Trim) & "',lname='" & v(txtLName.Text.Trim) & "',number='" & v(txtONumber.Text.Trim) & "',address='" & v(txtAddress.Text.Trim) & "',status='" & cmbStatus.Text & "'", "studno='" & v(txtStudNo.Text.Trim) & "'")
            If Not recCount("tbleparentinfo", "rfidtagid='" & lblRFID.Text & "'") Then
                INSERTr("tbleparentinfo", "'" & lblRFID.Text & "','" & v(txtFNameP.Text.Trim) & "','" & _
                   v(txtLNameP.Text.Trim) & "','" & v(txtPNumber.Text.Trim) & "','" & v(txtPRelation.Text.Trim) & "'," & Not chkSendAdvisory.Checked)
            Else
                UPDATEr("tbleparentinfo", "fname='" & v(txtFNameP.Text.Trim) & "',lname='" & v(txtLNameP.Text.Trim) & "',relation='" & v(txtPRelation.Text.Trim) & "',number='" & v(txtPNumber.Text.Trim) & "',block=" & Not chkSendAdvisory.Checked, "rfidtagid='" & lblRFID.Text & "'")
            End If
            MB("Updated!") : viewProfile(v(txtStudNo.Text.Trim)) : Me.Close()
        End If
c:
    End Sub

    Public Sub AddStudent(ByVal SQLCommand As String)
        Try
            Dim CMD_Encode As New MySqlCommand
            Dim FS As New IO.FileStream(IIf(Not imgName = "", imgName, AppPath & "\Files\No Picture.jpg"), FileMode.Open, FileAccess.Read)
            Dim imgByte(FS.Length() - 1) As Byte
            FS.Read(imgByte, 0, imgByte.Length) : FS.Close()
            openCONN()
            Dim MyParamE As New MySqlParameter("@img", MySqlDbType.VarBinary, imgByte.Length, ParameterDirection.Input, False, 0, 0, Nothing, DataRowVersion.Current, imgByte)
            If CMD_Encode.Parameters.Contains("@img") Then CMD_Encode.Parameters.RemoveAt("@img")
            CMD_Encode.Parameters.Add(MyParamE)
            CMD_Encode.Connection = conN
            CMD_Encode.CommandText = SQLCommand
            Dim dREncodeStud As MySqlDataReader = CMD_Encode.ExecuteReader(CommandBehavior.CloseConnection)
            dREncodeStud.Close()
        Catch ex As Exception
            MsgBox("Adding of Student" & vbNewLine & ex.Message, 48)
        End Try
    End Sub

#End Region
    Private Sub frmEncodeStudInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmEncodeStudInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reLOAD()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblWebCam.LinkClicked
        MB("No webcam device attached")
    End Sub
    Dim RFIDselect As Boolean = False
    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        OpenRFID()
        If G_rHandle < 0 Then
            lblCard.Text = "Device not connected."
            Sounds(AUDIO.ERRORWARN)
        Else
            OpenRFID()
            IDserialNo = GetID_RFID()
            If IDserialNo = "" Or IDserialNo.Trim.ToLower.ToString.Contains("cannot read.") Then
                lblCard.Text = "No TAG is selected or unreachable range. Place again the card to read."
                lblRFID.Text = "----"
                Sounds(AUDIO.ERRORWARN)
            Else
                Sounds(AUDIO.TOONG)
                If recCount("tblestudent", "rfidtagid='" & IDserialNo & "'") > 0 Then lblCard.Text = "This card is already registered." : lblRFID.Text = "----" : Return
                lblRFID.Text = IDserialNo
                lblCard.Text = "Your RFID tag will be " & IDserialNo & "."
                Sounds(AUDIO.SCAN)
                Read = True
            End If
        End If
    End Sub
    Private Sub pbPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPic.Click
        On Error GoTo c
        ofdImage = New OpenFileDialog
        ofdImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
        If Not ofdImage.ShowDialog = DialogResult.OK Then Return
        imgName = ofdImage.FileName
        Dim FS As New FileStream(ofdImage.FileName, FileMode.Open, FileAccess.Read)
        Dim imgByte As Byte() = New Byte(FS.Length - 1) {}
        FS.Read(imgByte, 0, FS.Length) : FS.Close()
        MyParam.Value = imgByte
        pbPic.Image = Image.FromFile(ofdImage.FileName)
        Return
c:      ofdImage.Dispose()
    End Sub
    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        CloseRFID()
        G_retcode = -1 : G_rHandle = -1
        OpenRFID()
        If G_rHandle < 0 Then lblCard.Text = getStat_RFID() Else lblCard.Text = "Please present your card." : tmrUpdate.Enabled = False
    End Sub
    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        YearItems()
    End Sub
    Private Sub cmbYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYearLevel.SelectedIndexChanged
        SectionItems()
    End Sub
    Private Sub cmbSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSection.SelectedIndexChanged
        lblCourseYrSec.Text = cmbCourse.Text & " " & cmbYearLevel.Text & "-" & cmbSection.Text
    End Sub

#Region "CMB_ITEMS"
    Sub YearItems()
        cmbYearLevel.Items.Clear()
        If cmbCourse.Text.Trim = "" Then cmbYearLevel.Enabled = False : cmbSection.Enabled = False Else cmbYearLevel.Enabled = True : cmbSection.Enabled = True
        Dim YearNum As Integer = CInt(getVal("tblecodedesc", "year", "field like '%Course%' and code='" & cmbCourse.Text & "'"))
        For i As Integer = 1 To YearNum
            cmbYearLevel.Items.Add(i)
        Next
        If cmbYearLevel.Items.Count <= 0 Then cmbYearLevel.Enabled = False : Return
        cmbYearLevel.SelectedIndex = 0 : lblCourseYrSec.Text = cmbCourse.Text & " " & cmbYearLevel.Text
        SectionItems()
    End Sub
    Sub SectionItems()
        cmbSection.Items.Clear()
        Dim meron As Boolean = False
        For i As Integer = 1 To CInt(getVal("tblecodedesc", "year", "code like '%" & cmbCourse.Text & "%' and field like '%Course%'"))
            If recCount("tblecodedesc", "year=" & i & " and code like '%" & cmbCourse.Text & "%' and field like '%Course%'") Then meron = True
        Next
        If Not meron Then cmbSection.Enabled = False : Exit Sub
        Dim YS As String = getVal("tblecodedesc", "section", "code='" & cmbCourse.Text & "'")
        For Each Yr As String In YS.Split(";")
            If Yr.Substring(0, 1) = cmbYearLevel.Text Then
                Dim secNum1 As String = Replace(Yr, cmbYearLevel.Text & ":", "")
                Dim secNum2 As Integer = CInt(Replace(secNum1, ";", "").Trim)
                For i As Integer = 1 To secNum2
                    cmbSection.Items.Add(i)
                Next
                Exit For
            End If
        Next
        If cmbSection.Items.Count > 0 Then lblCourseYrSec.Text = cmbCourse.Text & " " & cmbYearLevel.Text & IIf(Not cmbSection.Text = "", "-" & cmbSection.Text, "")
        cmbSection.Enabled = True
    End Sub
    Sub CourseItems()
        cmbCourse.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select course,yearlevel,section from tblestudent order by course")
        For Each item In dR
            If Not cmbCourse.Items.Contains(dR.Item(0)) Then cmbCourse.Items.Add(dR.Item(0))
            If Not cmbYearLevel.Items.Contains(dR.Item(1)) Then cmbYearLevel.Items.Add(dR.Item(1))
            If Not cmbSection.Items.Contains(dR.Item(2)) Then cmbSection.Items.Add(dR.Item(2))
        Next
        dR.Close()
        If cmbCourse.Items.Count <= 0 Then cmbCourse.Enabled = False : Return
        cmbCourse.SelectedIndex = 0 : lblCourseYrSec.Text = cmbCourse.Text
        YearItems()
    End Sub
#End Region
#Region "RELOAD"
    Sub reLOAD()
        cmbCourse.Items.Clear()
        Dim dR As MySqlDataReader = DataReader("select code from tblecodedesc where field='Course'")
        If Not dR.Read Then cmbCourse.Text = "Enter course" : MB("Unable to encode new student. The department list is empty!", "x") : Me.Close() : Exit Sub
        Do
            cmbCourse.Items.Add(dR.Item(0))
        Loop While dR.Read : cmbCourse.Text = "Select course"
        dR.Close()

        MyParam.MySqlDbType = MySqlDbType.Binary
        MyParam.ParameterName = "studpic"
        MyParam.Value = ""

        If Me.Tag = "Add" Then
            txtStudNo.Enabled = True
            btnRead.Enabled = True
            cmbGender.Enabled = True
            cmbCourse.Enabled = True
            cmbYearLevel.Enabled = True
            cmbSection.Enabled = True
            lblEncode.Text = "Encode Student"
            Me.Text = "Encode Student"


            cmbYearLevel.Text = "Select year level" : cmbYearLevel.Items.Clear() : cmbYearLevel.Enabled = False
            cmbSection.Text = "Section"
            cmbGender.Text = "Select gender"
            txtFName.Text = "First"
            txtMName.Text = "Middle"
            txtLName.Text = "Last"
            txtAddress.Text = "Address"
            txtStudNo.Text = "Student Number"
            txtONumber.Text = "Number"
            txtFNameP.Text = "First"
            txtLNameP.Text = "Last"
            txtPRelation.Text = "Relation"
            txtPNumber.Text = "Number"
            'lblPasscode = 
            lblRFID.Text = "------"
            tmrUpdate.Enabled = True
            ofdImage = Nothing
            pbPic.Image = NoPicture_Click
            Read = False

            Do
                Dim n As String = "00000" & CInt((Rnd() * 10000))
                n = gIDVal("Passcode", 0) & n.Substring(n.Length - 5, 5)
                If Not recCount("tblestudent", "passcode='" & n & "'") > 0 Then lblPasscode.Text = n : Exit Do
            Loop

        ElseIf Me.Tag = "Edit" Then 'Edit
            openCONN()
            Dim dS As New DataSet
            Dim dA As New MySqlDataAdapter("select studno,passcode,rfidtagid,fname,mname,lname,gender,number,address,course,yearlevel,section,status from tblestudent where studno='" & Me.Tag_STUDNO & "'", conN)
            dA.Fill(dS)
            With dS.Tables(0).Rows(0)
                txtStudNo.Text = .Item(0).ToString
                lblPasscode.Text = .Item(1).ToString
                lblRFID.Text = .Item(2).ToString
                txtFName.Text = .Item(3).ToString
                txtMName.Text = .Item(4).ToString
                txtLName.Text = .Item(5).ToString
                cmbGender.SelectedIndex = cmbGender.FindStringExact(.Item(6).ToString)
                txtONumber.Text = .Item(7).ToString
                txtAddress.Text = .Item(8).ToString
                cmbCourse.SelectedIndex = cmbCourse.FindStringExact(.Item(9).ToString)
                cmbYearLevel.SelectedIndex = cmbYearLevel.FindStringExact(.Item(10).ToString)
                cmbSection.SelectedIndex = cmbSection.FindStringExact(.Item(11).ToString)
                cmbStatus.Text = .Item(12).ToString
                displayPic(.Item(2), pbPic)
            End With
            CONNclose()

            Dim dR2 As MySqlDataReader = DataReader("select fname,lname,relation,number,block from tbleparentinfo where rfidtagid='" & lblRFID.Text & "'")
            If dR2.Read Then
                With dR2
                    txtFNameP.Text = .Item(0)
                    txtLNameP.Text = .Item(1)
                    txtPRelation.Text = .Item(2)
                    txtPNumber.Text = .Item(3)
                    chkSendAdvisory.Checked = .Item(4)
                End With
            End If
            dR2.Close()

            txtStudNo.Enabled = False
            btnRead.Enabled = False
            cmbGender.Enabled = False
            '   cmbCourse.Enabled = False
            '  cmbYearLevel.Enabled = False
            ' cmbSection.Enabled = False
            lblEncode.Text = "Update Student Information"
            Me.Text = "Update Student Information"
        End If
        ' Me.Show()
    End Sub
#End Region
#Region "GOTFOCUS"
    Private Sub txtSection_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbSection.ForeColor = Color.Black
        TextClicked(cmbSection, "Section")
    End Sub

    Private Sub cmbGender_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGender.GotFocus
        cmbGender.ForeColor = Color.Black : lblBasicInfo.Text = "Choose gender of the student."
    End Sub
    Private Sub txtONumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtONumber.GotFocus
        txtONumber.ForeColor = Color.Black : lblBasicInfo.Text = "Enter student phone number." & vbNewLine & "This will received announcement."
        TextClicked(txtONumber, "Number")
    End Sub
    Private Sub txtFNameP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFNameP.GotFocus
        txtFNameP.ForeColor = Color.Black : lblGuardian.Text = "Enter first name."
        TextClicked(txtFNameP, "First")
    End Sub

    Private Sub txtLNameP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLNameP.GotFocus
        txtLNameP.ForeColor = Color.Black : lblGuardian.Text = "Enter last name."
        TextClicked(txtLNameP, "Last")
    End Sub
    Private Sub txtPRelation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPRelation.GotFocus
        txtPRelation.ForeColor = Color.Black : lblGuardian.Text = "Relation from the student."
        TextClicked(txtPRelation, "Relation")
    End Sub
    Private Sub txtPNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPNumber.GotFocus
        txtPNumber.ForeColor = Color.Black : lblGuardian.Text = "Enter number." & vbCr & "This will received the monitoring advisory of the student and announcement."
        TextClicked(txtPNumber, "Number")
    End Sub
    Private Sub cmbYearLevel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbYearLevel.GotFocus
        cmbYearLevel.ForeColor = Color.Black
    End Sub
    Private Sub txtLName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.GotFocus
        txtLName.ForeColor = Color.Black : lblBasicInfo.Text = "Enter last name of the student."
        TextClicked(txtLName, "Last")
    End Sub
    Private Sub cmbCourse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.GotFocus
        cmbCourse.ForeColor = Color.Black
    End Sub
    Private Sub txtMName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMName.GotFocus
        txtMName.ForeColor = Color.Black : lblBasicInfo.Text = "Enter middle name of the student."
        TextClicked(txtMName, "Middle")
    End Sub
    Private Sub txtStudNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudNo.GotFocus
        txtStudNo.ForeColor = Color.Black
        TextClicked(txtStudNo, "Student Number")
    End Sub
    Private Sub txtFName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.GotFocus
        txtFName.ForeColor = Color.Black : lblBasicInfo.Text = "Enter first name of the student."
        TextClicked(txtFName, "First")
    End Sub
#End Region
#Region "LOSTFOCUS"
    Private Sub txtStudNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudNo.LostFocus
        txtStudNo.ForeColor = Color.Gray : If txtStudNo.Text.Trim = "" Then txtStudNo.Text = "Student Number"
    End Sub
    Private Sub txtFName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.LostFocus
        txtFName.ForeColor = Color.Gray : If txtFName.Text.Trim = "" Then txtFName.Text = "First"
        lblBasicInfo.Text = "Basic Information"
    End Sub
    Private Sub txtMName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMName.LostFocus
        lblBasicInfo.Text = "Basic Information"
        txtMName.ForeColor = Color.Gray : If txtMName.Text.Trim = "" Then txtMName.Text = "Middle"
    End Sub
    Private Sub txtLName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.LostFocus
        lblBasicInfo.Text = "Basic Information"
        txtLName.ForeColor = Color.Gray : If txtLName.Text.Trim = "" Then txtLName.Text = "Last"
    End Sub
    Private Sub cmbYearLevel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbYearLevel.LostFocus
        cmbYearLevel.ForeColor = Color.Gray : If cmbYearLevel.Text.Trim = "" Then cmbYearLevel.Text = "Select year"
    End Sub
    Private Sub txtSection_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbSection.ForeColor = Color.Gray : If cmbSection.Text.Trim = "" Then cmbSection.Text = "Section"
    End Sub
#End Region


    Private Sub cmbGender_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGender.LostFocus
        lblBasicInfo.Text = "Basic Information"
    End Sub


    Private Sub txtONumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtONumber.LostFocus
        lblBasicInfo.Text = "Basic Information"
    End Sub


    Private Sub lblPasscode_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPasscode.MouseLeave
        lblCard.Text = "Please present the card."
    End Sub

    Private Sub lblRFID_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRFID.MouseLeave
        lblCard.Text = "Please present the card."
    End Sub

    Private Sub lblRFID_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblRFID.MouseMove
        lblCard.Text = "Click 'Read Card' button to read the Serial ID of the card."
    End Sub

    Private Sub lblPasscode_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPasscode.MouseMove
        lblCard.Text = "This will use for log in whenever the RFID card ID cannot detect by the device."
    End Sub

    Private Sub txtFNameP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFNameP.LostFocus
        lblGuardian.Text = "Announcement and Advisory."
    End Sub

    Private Sub txtLNameP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLNameP.LostFocus
        lblGuardian.Text = "Announcement and Advisory."

    End Sub


    Private Sub txtPRelation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPRelation.LostFocus
        lblGuardian.Text = "Announcement and Advisory."
    End Sub


    Private Sub txtPNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPNumber.LostFocus
        lblGuardian.Text = "Announcement and Advisory."
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Sounds(AUDIO.CLICK)
        If Me.Tag = "Add" Then If MB("Cancel encoding?", "?") = "n" Then Return
        Me.Tag = "Add"
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class