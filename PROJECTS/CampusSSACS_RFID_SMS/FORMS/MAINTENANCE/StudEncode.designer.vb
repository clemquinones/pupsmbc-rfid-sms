<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncodeStudInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblRFID = New System.Windows.Forms.Label
        Me.btnRead = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtStudNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPRelation = New System.Windows.Forms.TextBox
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox
        Me.txtFNameP = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.gbGuardian = New System.Windows.Forms.GroupBox
        Me.chkSendAdvisory = New System.Windows.Forms.CheckBox
        Me.lblGuardian = New System.Windows.Forms.Label
        Me.txtLNameP = New System.Windows.Forms.TextBox
        Me.txtPNumber = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtONumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCourseYrSec = New System.Windows.Forms.Label
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.llblWebCam = New System.Windows.Forms.LinkLabel
        Me.lblCard = New System.Windows.Forms.Label
        Me.pbPic = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblBasicInfo = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblPasscode = New System.Windows.Forms.Label
        Me.gbPicture = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblEncode = New System.Windows.Forms.Label
        Me.ttEncode = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbGuardian.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbPicture.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRFID
        '
        Me.lblRFID.BackColor = System.Drawing.Color.White
        Me.lblRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRFID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFID.ForeColor = System.Drawing.Color.Black
        Me.lblRFID.Location = New System.Drawing.Point(102, 51)
        Me.lblRFID.Name = "lblRFID"
        Me.lblRFID.Size = New System.Drawing.Size(260, 28)
        Me.lblRFID.TabIndex = 55
        Me.lblRFID.Text = "RFID Tag ID"
        Me.lblRFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.White
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRead.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.Black
        Me.btnRead.Location = New System.Drawing.Point(253, 85)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(109, 52)
        Me.btnRead.TabIndex = 49
        Me.btnRead.Text = "&Read Card"
        Me.ttEncode.SetToolTip(Me.btnRead, "Read Card")
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "RFID Serial #:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(6, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = " Pass code:"
        '
        'txtStudNo
        '
        Me.txtStudNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNo.ForeColor = System.Drawing.Color.Gray
        Me.txtStudNo.Location = New System.Drawing.Point(159, 22)
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(216, 27)
        Me.txtStudNo.TabIndex = 37
        Me.txtStudNo.Text = "Student Number"
        Me.txtStudNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttEncode.SetToolTip(Me.txtStudNo, "Enter student number")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "* Student #:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPRelation
        '
        Me.txtPRelation.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRelation.ForeColor = System.Drawing.Color.DimGray
        Me.txtPRelation.Location = New System.Drawing.Point(211, 66)
        Me.txtPRelation.Name = "txtPRelation"
        Me.txtPRelation.Size = New System.Drawing.Size(186, 20)
        Me.txtPRelation.TabIndex = 20
        Me.txtPRelation.Text = "Enter relation"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Enabled = False
        Me.cmbYearLevel.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.ForeColor = System.Drawing.Color.Gray
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Location = New System.Drawing.Point(200, 35)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(110, 23)
        Me.cmbYearLevel.Sorted = True
        Me.cmbYearLevel.TabIndex = 52
        Me.ttEncode.SetToolTip(Me.cmbYearLevel, "Choose year level")
        '
        'txtFNameP
        '
        Me.txtFNameP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFNameP.ForeColor = System.Drawing.Color.DimGray
        Me.txtFNameP.Location = New System.Drawing.Point(23, 36)
        Me.txtFNameP.Name = "txtFNameP"
        Me.txtFNameP.Size = New System.Drawing.Size(184, 20)
        Me.txtFNameP.TabIndex = 18
        Me.txtFNameP.Text = "Enter first name"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Yellow
        Me.btnSave.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(584, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 39)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttEncode.SetToolTip(Me.btnSave, "Save")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'gbGuardian
        '
        Me.gbGuardian.BackColor = System.Drawing.Color.Black
        Me.gbGuardian.Controls.Add(Me.chkSendAdvisory)
        Me.gbGuardian.Controls.Add(Me.lblGuardian)
        Me.gbGuardian.Controls.Add(Me.txtLNameP)
        Me.gbGuardian.Controls.Add(Me.txtPRelation)
        Me.gbGuardian.Controls.Add(Me.txtPNumber)
        Me.gbGuardian.Controls.Add(Me.Label21)
        Me.gbGuardian.Controls.Add(Me.Label23)
        Me.gbGuardian.Controls.Add(Me.Label22)
        Me.gbGuardian.Controls.Add(Me.Label19)
        Me.gbGuardian.Controls.Add(Me.txtFNameP)
        Me.gbGuardian.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGuardian.ForeColor = System.Drawing.Color.Gold
        Me.gbGuardian.Location = New System.Drawing.Point(35, 350)
        Me.gbGuardian.Name = "gbGuardian"
        Me.gbGuardian.Size = New System.Drawing.Size(407, 150)
        Me.gbGuardian.TabIndex = 46
        Me.gbGuardian.TabStop = False
        Me.gbGuardian.Text = "In Case of Emergency"
        '
        'chkSendAdvisory
        '
        Me.chkSendAdvisory.AutoSize = True
        Me.chkSendAdvisory.Checked = True
        Me.chkSendAdvisory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSendAdvisory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSendAdvisory.ForeColor = System.Drawing.Color.DimGray
        Me.chkSendAdvisory.Location = New System.Drawing.Point(213, 127)
        Me.chkSendAdvisory.Name = "chkSendAdvisory"
        Me.chkSendAdvisory.Size = New System.Drawing.Size(109, 17)
        Me.chkSendAdvisory.TabIndex = 47
        Me.chkSendAdvisory.Text = "Send Advisory"
        Me.ttEncode.SetToolTip(Me.chkSendAdvisory, "Lets to receive student advisory")
        Me.chkSendAdvisory.UseVisualStyleBackColor = True
        '
        'lblGuardian
        '
        Me.lblGuardian.BackColor = System.Drawing.Color.Black
        Me.lblGuardian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGuardian.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardian.ForeColor = System.Drawing.Color.DimGray
        Me.lblGuardian.Location = New System.Drawing.Point(15, 71)
        Me.lblGuardian.Name = "lblGuardian"
        Me.lblGuardian.Size = New System.Drawing.Size(120, 66)
        Me.lblGuardian.TabIndex = 46
        Me.lblGuardian.Text = "Announcement and Advisory"
        '
        'txtLNameP
        '
        Me.txtLNameP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLNameP.ForeColor = System.Drawing.Color.DimGray
        Me.txtLNameP.Location = New System.Drawing.Point(213, 36)
        Me.txtLNameP.Name = "txtLNameP"
        Me.txtLNameP.Size = New System.Drawing.Size(184, 20)
        Me.txtLNameP.TabIndex = 18
        Me.txtLNameP.Text = "Enter last name"
        '
        'txtPNumber
        '
        Me.txtPNumber.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNumber.ForeColor = System.Drawing.Color.DimGray
        Me.txtPNumber.Location = New System.Drawing.Point(213, 95)
        Me.txtPNumber.Name = "txtPNumber"
        Me.txtPNumber.Size = New System.Drawing.Size(184, 20)
        Me.txtPNumber.TabIndex = 17
        Me.txtPNumber.Text = "Enter parent number"
        Me.txtPNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(208, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Last Name:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(141, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Number:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(141, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Relation:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(18, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "First Name:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.ForeColor = System.Drawing.Color.Gray
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(23, 35)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(162, 23)
        Me.cmbCourse.Sorted = True
        Me.cmbCourse.TabIndex = 44
        Me.ttEncode.SetToolTip(Me.cmbCourse, "Choose course")
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.Color.DimGray
        Me.txtLName.Location = New System.Drawing.Point(403, 32)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(184, 20)
        Me.txtLName.TabIndex = 36
        Me.txtLName.Text = "Name"
        Me.ttEncode.SetToolTip(Me.txtLName, "Enter last name")
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.DimGray
        Me.txtMName.Location = New System.Drawing.Point(213, 32)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(184, 20)
        Me.txtMName.TabIndex = 35
        Me.txtMName.Text = "Middle"
        Me.ttEncode.SetToolTip(Me.txtMName, "Enter middle name")
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.DimGray
        Me.txtFName.Location = New System.Drawing.Point(23, 33)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(184, 20)
        Me.txtFName.TabIndex = 33
        Me.txtFName.Text = "First"
        Me.ttEncode.SetToolTip(Me.txtFName, "Enter first name")
        '
        'txtONumber
        '
        Me.txtONumber.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtONumber.ForeColor = System.Drawing.Color.DimGray
        Me.txtONumber.Location = New System.Drawing.Point(403, 103)
        Me.txtONumber.Name = "txtONumber"
        Me.txtONumber.Size = New System.Drawing.Size(184, 20)
        Me.txtONumber.TabIndex = 45
        Me.txtONumber.Text = "Student phone number"
        Me.txtONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(310, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "* Section:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(182, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "* Year Level:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "* Course:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "* First Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.lblCourseYrSec)
        Me.GroupBox2.Controls.Add(Me.cmbSection)
        Me.GroupBox2.Controls.Add(Me.cmbCourse)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbYearLevel)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(35, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 69)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Department"
        '
        'lblCourseYrSec
        '
        Me.lblCourseYrSec.BackColor = System.Drawing.Color.Black
        Me.lblCourseYrSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseYrSec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseYrSec.ForeColor = System.Drawing.Color.DimGray
        Me.lblCourseYrSec.Location = New System.Drawing.Point(414, 17)
        Me.lblCourseYrSec.Name = "lblCourseYrSec"
        Me.lblCourseYrSec.Size = New System.Drawing.Size(173, 44)
        Me.lblCourseYrSec.TabIndex = 56
        Me.lblCourseYrSec.Text = "Course / Yr / Section"
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Enabled = False
        Me.cmbSection.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.ForeColor = System.Drawing.Color.Gray
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(324, 35)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(83, 23)
        Me.cmbSection.Sorted = True
        Me.cmbSection.TabIndex = 55
        Me.ttEncode.SetToolTip(Me.cmbSection, "Choose section")
        '
        'llblWebCam
        '
        Me.llblWebCam.AutoSize = True
        Me.llblWebCam.BackColor = System.Drawing.Color.Transparent
        Me.llblWebCam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblWebCam.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblWebCam.Location = New System.Drawing.Point(105, 15)
        Me.llblWebCam.Name = "llblWebCam"
        Me.llblWebCam.Size = New System.Drawing.Size(68, 13)
        Me.llblWebCam.TabIndex = 56
        Me.llblWebCam.TabStop = True
        Me.llblWebCam.Text = "Webcam..."
        Me.ttEncode.SetToolTip(Me.llblWebCam, "Capture image via webcam")
        '
        'lblCard
        '
        Me.lblCard.BackColor = System.Drawing.Color.Transparent
        Me.lblCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCard.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.ForeColor = System.Drawing.Color.DimGray
        Me.lblCard.Location = New System.Drawing.Point(9, 85)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(238, 52)
        Me.lblCard.TabIndex = 56
        Me.lblCard.Text = "Please present the card"
        Me.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPic.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture_Click
        Me.pbPic.Location = New System.Drawing.Point(6, 33)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(167, 168)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 32
        Me.pbPic.TabStop = False
        Me.ttEncode.SetToolTip(Me.pbPic, "Click to browse picture")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(197, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "* Middle Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(386, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "* Last Name:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.Controls.Add(Me.lblBasicInfo)
        Me.GroupBox5.Controls.Add(Me.txtONumber)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtFName)
        Me.GroupBox5.Controls.Add(Me.txtMName)
        Me.GroupBox5.Controls.Add(Me.txtLName)
        Me.GroupBox5.Controls.Add(Me.cmbGender)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox5.Location = New System.Drawing.Point(35, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(597, 136)
        Me.GroupBox5.TabIndex = 60
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Basic Information"
        '
        'lblBasicInfo
        '
        Me.lblBasicInfo.BackColor = System.Drawing.Color.Black
        Me.lblBasicInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBasicInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasicInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblBasicInfo.Location = New System.Drawing.Point(15, 67)
        Me.lblBasicInfo.Name = "lblBasicInfo"
        Me.lblBasicInfo.Size = New System.Drawing.Size(238, 58)
        Me.lblBasicInfo.TabIndex = 46
        Me.lblBasicInfo.Text = "Basic Information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(259, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Currently use number:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.Gray
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(403, 69)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(184, 23)
        Me.cmbGender.TabIndex = 62
        Me.ttEncode.SetToolTip(Me.cmbGender, "Choose gender")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(328, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "* Gender:"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "*Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.ForeColor = System.Drawing.Color.Gray
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Irregular", "Regular"})
        Me.cmbStatus.Location = New System.Drawing.Point(21, 35)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(152, 23)
        Me.cmbStatus.Sorted = True
        Me.cmbStatus.TabIndex = 66
        Me.ttEncode.SetToolTip(Me.cmbStatus, "Choose student status")
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(683, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 39)
        Me.btnExit.TabIndex = 67
        Me.btnExit.Text = "&Exit"
        Me.ttEncode.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnRead)
        Me.GroupBox3.Controls.Add(Me.lblRFID)
        Me.GroupBox3.Controls.Add(Me.lblPasscode)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblCard)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(449, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 150)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Access Security"
        '
        'lblPasscode
        '
        Me.lblPasscode.BackColor = System.Drawing.Color.White
        Me.lblPasscode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPasscode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPasscode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasscode.ForeColor = System.Drawing.Color.Black
        Me.lblPasscode.Location = New System.Drawing.Point(102, 18)
        Me.lblPasscode.Name = "lblPasscode"
        Me.lblPasscode.Size = New System.Drawing.Size(260, 28)
        Me.lblPasscode.TabIndex = 56
        Me.lblPasscode.Text = "Pass code"
        Me.lblPasscode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbPicture
        '
        Me.gbPicture.BackColor = System.Drawing.Color.Transparent
        Me.gbPicture.Controls.Add(Me.pbPic)
        Me.gbPicture.Controls.Add(Me.llblWebCam)
        Me.gbPicture.Location = New System.Drawing.Point(638, 58)
        Me.gbPicture.Name = "gbPicture"
        Me.gbPicture.Size = New System.Drawing.Size(179, 209)
        Me.gbPicture.TabIndex = 69
        Me.gbPicture.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox4.Location = New System.Drawing.Point(35, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(597, 67)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Permanent Address"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.DimGray
        Me.txtAddress.Location = New System.Drawing.Point(23, 34)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(564, 20)
        Me.txtAddress.TabIndex = 41
        Me.txtAddress.Text = "Student address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Black
        Me.GroupBox6.Controls.Add(Me.cmbStatus)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox6.Location = New System.Drawing.Point(638, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(179, 69)
        Me.GroupBox6.TabIndex = 71
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Student Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtStudNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 506)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 64)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'lblEncode
        '
        Me.lblEncode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEncode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEncode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncode.ForeColor = System.Drawing.Color.Yellow
        Me.lblEncode.Location = New System.Drawing.Point(31, 15)
        Me.lblEncode.Name = "lblEncode"
        Me.lblEncode.Size = New System.Drawing.Size(797, 29)
        Me.lblEncode.TabIndex = 73
        Me.lblEncode.Text = "Encode Student"
        Me.lblEncode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEncodeStudInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Encode1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 635)
        Me.Controls.Add(Me.lblEncode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbPicture)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gbGuardian)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmEncodeStudInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encode StudInfo"
        Me.gbGuardian.ResumeLayout(False)
        Me.gbGuardian.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbPicture.ResumeLayout(False)
        Me.gbPicture.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPRelation As System.Windows.Forms.TextBox
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtFNameP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbGuardian As System.Windows.Forms.GroupBox
    Friend WithEvents txtPNumber As System.Windows.Forms.TextBox
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtONumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRFID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents llblWebCam As System.Windows.Forms.LinkLabel
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents lblCard As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLNameP As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPasscode As System.Windows.Forms.Label
    Friend WithEvents gbPicture As System.Windows.Forms.GroupBox
    Friend WithEvents lblBasicInfo As System.Windows.Forms.Label
    Friend WithEvents lblCourseYrSec As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuardian As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEncode As System.Windows.Forms.Label
    Friend WithEvents chkSendAdvisory As System.Windows.Forms.CheckBox
    Friend WithEvents ttEncode As System.Windows.Forms.ToolTip
End Class
