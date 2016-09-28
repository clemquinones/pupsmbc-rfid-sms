<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Me.lblLogOut3 = New System.Windows.Forms.Label
        Me.lblLogOut1 = New System.Windows.Forms.Label
        Me.lblLogIn1 = New System.Windows.Forms.Label
        Me.lblLogIn2 = New System.Windows.Forms.Label
        Me.lblRFIDStatus = New System.Windows.Forms.Label
        Me.lblLogIn3 = New System.Windows.Forms.Label
        Me.lblLogIn4 = New System.Windows.Forms.Label
        Me.lblAnn = New System.Windows.Forms.Label
        Me.lblPCsystem = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblLogOutSN4 = New System.Windows.Forms.Label
        Me.lblDateTimeLog = New System.Windows.Forms.Label
        Me.lblLogOutSN3 = New System.Windows.Forms.Label
        Me.lblYearSec = New System.Windows.Forms.Label
        Me.lblLogState = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.lblLogOutSN2 = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblLOgOutSN1 = New System.Windows.Forms.Label
        Me.lblLogInSN1 = New System.Windows.Forms.Label
        Me.lblLogInSN2 = New System.Windows.Forms.Label
        Me.lblLogInSN3 = New System.Windows.Forms.Label
        Me.lblLogInSN4 = New System.Windows.Forms.Label
        Me.lblLogOut4 = New System.Windows.Forms.Label
        Me.lblLogOut2 = New System.Windows.Forms.Label
        Me.tmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.pbLogIn4 = New System.Windows.Forms.PictureBox
        Me.pbLoadRFID = New System.Windows.Forms.PictureBox
        Me.pbLogIn3 = New System.Windows.Forms.PictureBox
        Me.pbLogIn2 = New System.Windows.Forms.PictureBox
        Me.pbLogIn1 = New System.Windows.Forms.PictureBox
        Me.pbMainPic = New System.Windows.Forms.PictureBox
        Me.pbLogOut4 = New System.Windows.Forms.PictureBox
        Me.pbLogOut2 = New System.Windows.Forms.PictureBox
        Me.pbLogOut3 = New System.Windows.Forms.PictureBox
        Me.pbLogOut1 = New System.Windows.Forms.PictureBox
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbLogIn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoadRFID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogOut3
        '
        Me.lblLogOut3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOut3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOut3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut3.Location = New System.Drawing.Point(801, 667)
        Me.lblLogOut3.Name = "lblLogOut3"
        Me.lblLogOut3.Size = New System.Drawing.Size(98, 19)
        Me.lblLogOut3.TabIndex = 127
        Me.lblLogOut3.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOut3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogOut1
        '
        Me.lblLogOut1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOut1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut1.Location = New System.Drawing.Point(537, 667)
        Me.lblLogOut1.Name = "lblLogOut1"
        Me.lblLogOut1.Size = New System.Drawing.Size(114, 19)
        Me.lblLogOut1.TabIndex = 123
        Me.lblLogOut1.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOut1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogIn1
        '
        Me.lblLogIn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogIn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogIn1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn1.Location = New System.Drawing.Point(387, 667)
        Me.lblLogIn1.Name = "lblLogIn1"
        Me.lblLogIn1.Size = New System.Drawing.Size(114, 19)
        Me.lblLogIn1.TabIndex = 129
        Me.lblLogIn1.Text = "00:00 AM"
        Me.lblLogIn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogIn2
        '
        Me.lblLogIn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogIn2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogIn2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn2.Location = New System.Drawing.Point(260, 667)
        Me.lblLogIn2.Name = "lblLogIn2"
        Me.lblLogIn2.Size = New System.Drawing.Size(108, 19)
        Me.lblLogIn2.TabIndex = 128
        Me.lblLogIn2.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogIn2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRFIDStatus
        '
        Me.lblRFIDStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblRFIDStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFIDStatus.ForeColor = System.Drawing.Color.White
        Me.lblRFIDStatus.Location = New System.Drawing.Point(83, 488)
        Me.lblRFIDStatus.Name = "lblRFIDStatus"
        Me.lblRFIDStatus.Size = New System.Drawing.Size(159, 26)
        Me.lblRFIDStatus.TabIndex = 139
        Me.lblRFIDStatus.Text = "Please present your card."
        Me.lblRFIDStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLogIn3
        '
        Me.lblLogIn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogIn3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogIn3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn3.Location = New System.Drawing.Point(144, 667)
        Me.lblLogIn3.Name = "lblLogIn3"
        Me.lblLogIn3.Size = New System.Drawing.Size(98, 19)
        Me.lblLogIn3.TabIndex = 124
        Me.lblLogIn3.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogIn3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogIn4
        '
        Me.lblLogIn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogIn4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogIn4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn4.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn4.Location = New System.Drawing.Point(37, 667)
        Me.lblLogIn4.Name = "lblLogIn4"
        Me.lblLogIn4.Size = New System.Drawing.Size(88, 19)
        Me.lblLogIn4.TabIndex = 122
        Me.lblLogIn4.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogIn4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAnn
        '
        Me.lblAnn.BackColor = System.Drawing.Color.Transparent
        Me.lblAnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnn.ForeColor = System.Drawing.Color.Yellow
        Me.lblAnn.Location = New System.Drawing.Point(258, 735)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(810, 26)
        Me.lblAnn.TabIndex = 133
        Me.lblAnn.Text = "ATTENTTION: NO CLASS TODAY!!  BITIN ANG STUDENTS SA VACATION"
        Me.lblAnn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPCsystem
        '
        Me.lblPCsystem.BackColor = System.Drawing.Color.Transparent
        Me.lblPCsystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPCsystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPCsystem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCsystem.ForeColor = System.Drawing.Color.Red
        Me.lblPCsystem.Location = New System.Drawing.Point(44, 371)
        Me.lblPCsystem.Name = "lblPCsystem"
        Me.lblPCsystem.Size = New System.Drawing.Size(185, 29)
        Me.lblPCsystem.TabIndex = 142
        Me.lblPCsystem.Text = "PC 1: LOG IN"
        Me.lblPCsystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(41, 745)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(213, 33)
        Me.lblTime.TabIndex = 141
        Me.lblTime.Text = "00:00:00 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogOutSN4
        '
        Me.lblLogOutSN4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOutSN4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOutSN4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOutSN4.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN4.Location = New System.Drawing.Point(914, 687)
        Me.lblLogOutSN4.Name = "lblLogOutSN4"
        Me.lblLogOutSN4.Size = New System.Drawing.Size(88, 19)
        Me.lblLogOutSN4.TabIndex = 150
        Me.lblLogOutSN4.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOutSN4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDateTimeLog
        '
        Me.lblDateTimeLog.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTimeLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateTimeLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTimeLog.ForeColor = System.Drawing.Color.Cyan
        Me.lblDateTimeLog.Location = New System.Drawing.Point(754, 434)
        Me.lblDateTimeLog.Name = "lblDateTimeLog"
        Me.lblDateTimeLog.Size = New System.Drawing.Size(238, 27)
        Me.lblDateTimeLog.TabIndex = 118
        Me.lblDateTimeLog.Text = "Date/Time Log"
        Me.lblDateTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogOutSN3
        '
        Me.lblLogOutSN3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOutSN3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOutSN3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOutSN3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN3.Location = New System.Drawing.Point(801, 687)
        Me.lblLogOutSN3.Name = "lblLogOutSN3"
        Me.lblLogOutSN3.Size = New System.Drawing.Size(98, 19)
        Me.lblLogOutSN3.TabIndex = 149
        Me.lblLogOutSN3.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOutSN3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblYearSec
        '
        Me.lblYearSec.BackColor = System.Drawing.Color.Transparent
        Me.lblYearSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYearSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSec.ForeColor = System.Drawing.Color.White
        Me.lblYearSec.Location = New System.Drawing.Point(754, 405)
        Me.lblYearSec.Name = "lblYearSec"
        Me.lblYearSec.Size = New System.Drawing.Size(238, 26)
        Me.lblYearSec.TabIndex = 112
        Me.lblYearSec.Text = "Year - Section"
        Me.lblYearSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogState
        '
        Me.lblLogState.BackColor = System.Drawing.Color.Transparent
        Me.lblLogState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogState.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogState.ForeColor = System.Drawing.Color.White
        Me.lblLogState.Location = New System.Drawing.Point(747, 146)
        Me.lblLogState.Name = "lblLogState"
        Me.lblLogState.Size = New System.Drawing.Size(253, 81)
        Me.lblLogState.TabIndex = 114
        Me.lblLogState.Text = "WELCOME"
        Me.lblLogState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.White
        Me.lblCourse.Location = New System.Drawing.Point(754, 352)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(238, 50)
        Me.lblCourse.TabIndex = 111
        Me.lblCourse.Text = "Department"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogOutSN2
        '
        Me.lblLogOutSN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOutSN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOutSN2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOutSN2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN2.Location = New System.Drawing.Point(673, 688)
        Me.lblLogOutSN2.Name = "lblLogOutSN2"
        Me.lblLogOutSN2.Size = New System.Drawing.Size(108, 19)
        Me.lblLogOutSN2.TabIndex = 148
        Me.lblLogOutSN2.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOutSN2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStudNo
        '
        Me.lblStudNo.BackColor = System.Drawing.Color.Transparent
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.Cyan
        Me.lblStudNo.Location = New System.Drawing.Point(754, 254)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(236, 32)
        Me.lblStudNo.TabIndex = 110
        Me.lblStudNo.Text = "Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(754, 289)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(238, 62)
        Me.lblName.TabIndex = 109
        Me.lblName.Text = "Student Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLOgOutSN1
        '
        Me.lblLOgOutSN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLOgOutSN1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLOgOutSN1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLOgOutSN1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLOgOutSN1.Location = New System.Drawing.Point(537, 688)
        Me.lblLOgOutSN1.Name = "lblLOgOutSN1"
        Me.lblLOgOutSN1.Size = New System.Drawing.Size(114, 19)
        Me.lblLOgOutSN1.TabIndex = 147
        Me.lblLOgOutSN1.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLOgOutSN1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogInSN1
        '
        Me.lblLogInSN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogInSN1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogInSN1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInSN1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN1.Location = New System.Drawing.Point(387, 688)
        Me.lblLogInSN1.Name = "lblLogInSN1"
        Me.lblLogInSN1.Size = New System.Drawing.Size(114, 19)
        Me.lblLogInSN1.TabIndex = 146
        Me.lblLogInSN1.Text = "00:00 AM"
        Me.lblLogInSN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogInSN2
        '
        Me.lblLogInSN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogInSN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogInSN2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInSN2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN2.Location = New System.Drawing.Point(260, 688)
        Me.lblLogInSN2.Name = "lblLogInSN2"
        Me.lblLogInSN2.Size = New System.Drawing.Size(108, 19)
        Me.lblLogInSN2.TabIndex = 145
        Me.lblLogInSN2.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogInSN2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogInSN3
        '
        Me.lblLogInSN3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogInSN3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogInSN3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInSN3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN3.Location = New System.Drawing.Point(144, 687)
        Me.lblLogInSN3.Name = "lblLogInSN3"
        Me.lblLogInSN3.Size = New System.Drawing.Size(98, 19)
        Me.lblLogInSN3.TabIndex = 144
        Me.lblLogInSN3.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogInSN3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogInSN4
        '
        Me.lblLogInSN4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogInSN4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogInSN4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInSN4.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN4.Location = New System.Drawing.Point(37, 687)
        Me.lblLogInSN4.Name = "lblLogInSN4"
        Me.lblLogInSN4.Size = New System.Drawing.Size(88, 19)
        Me.lblLogInSN4.TabIndex = 143
        Me.lblLogInSN4.Text = "00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogInSN4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogOut4
        '
        Me.lblLogOut4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOut4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOut4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut4.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut4.Location = New System.Drawing.Point(914, 667)
        Me.lblLogOut4.Name = "lblLogOut4"
        Me.lblLogOut4.Size = New System.Drawing.Size(88, 19)
        Me.lblLogOut4.TabIndex = 130
        Me.lblLogOut4.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOut4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogOut2
        '
        Me.lblLogOut2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLogOut2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogOut2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut2.Location = New System.Drawing.Point(673, 667)
        Me.lblLogOut2.Name = "lblLogOut2"
        Me.lblLogOut2.Size = New System.Drawing.Size(108, 19)
        Me.lblLogOut2.TabIndex = 125
        Me.lblLogOut2.Text = "00:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":COURSE:"
        Me.lblLogOut2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrRead
        '
        Me.tmrRead.Interval = 2000
        '
        'pbLogIn4
        '
        Me.pbLogIn4.BackColor = System.Drawing.Color.White
        Me.pbLogIn4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogIn4.Image = CType(resources.GetObject("pbLogIn4.Image"), System.Drawing.Image)
        Me.pbLogIn4.Location = New System.Drawing.Point(37, 573)
        Me.pbLogIn4.Name = "pbLogIn4"
        Me.pbLogIn4.Size = New System.Drawing.Size(88, 92)
        Me.pbLogIn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogIn4.TabIndex = 138
        Me.pbLogIn4.TabStop = False
        '
        'pbLoadRFID
        '
        Me.pbLoadRFID.BackColor = System.Drawing.Color.Transparent
        Me.pbLoadRFID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoadRFID.Image = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.StandBy
        Me.pbLoadRFID.Location = New System.Drawing.Point(50, 490)
        Me.pbLoadRFID.Name = "pbLoadRFID"
        Me.pbLoadRFID.Size = New System.Drawing.Size(31, 25)
        Me.pbLoadRFID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoadRFID.TabIndex = 140
        Me.pbLoadRFID.TabStop = False
        '
        'pbLogIn3
        '
        Me.pbLogIn3.BackColor = System.Drawing.Color.White
        Me.pbLogIn3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogIn3.Image = CType(resources.GetObject("pbLogIn3.Image"), System.Drawing.Image)
        Me.pbLogIn3.Location = New System.Drawing.Point(144, 564)
        Me.pbLogIn3.Name = "pbLogIn3"
        Me.pbLogIn3.Size = New System.Drawing.Size(98, 101)
        Me.pbLogIn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogIn3.TabIndex = 115
        Me.pbLogIn3.TabStop = False
        '
        'pbLogIn2
        '
        Me.pbLogIn2.BackColor = System.Drawing.Color.White
        Me.pbLogIn2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogIn2.Image = CType(resources.GetObject("pbLogIn2.Image"), System.Drawing.Image)
        Me.pbLogIn2.Location = New System.Drawing.Point(260, 556)
        Me.pbLogIn2.Name = "pbLogIn2"
        Me.pbLogIn2.Size = New System.Drawing.Size(108, 109)
        Me.pbLogIn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogIn2.TabIndex = 117
        Me.pbLogIn2.TabStop = False
        '
        'pbLogIn1
        '
        Me.pbLogIn1.BackColor = System.Drawing.Color.White
        Me.pbLogIn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogIn1.Image = CType(resources.GetObject("pbLogIn1.Image"), System.Drawing.Image)
        Me.pbLogIn1.Location = New System.Drawing.Point(387, 549)
        Me.pbLogIn1.Name = "pbLogIn1"
        Me.pbLogIn1.Size = New System.Drawing.Size(114, 116)
        Me.pbLogIn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogIn1.TabIndex = 120
        Me.pbLogIn1.TabStop = False
        '
        'pbMainPic
        '
        Me.pbMainPic.BackColor = System.Drawing.Color.White
        Me.pbMainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMainPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbMainPic.Image = CType(resources.GetObject("pbMainPic.Image"), System.Drawing.Image)
        Me.pbMainPic.Location = New System.Drawing.Point(333, 100)
        Me.pbMainPic.Name = "pbMainPic"
        Me.pbMainPic.Size = New System.Drawing.Size(372, 407)
        Me.pbMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMainPic.TabIndex = 131
        Me.pbMainPic.TabStop = False
        '
        'pbLogOut4
        '
        Me.pbLogOut4.BackColor = System.Drawing.Color.White
        Me.pbLogOut4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogOut4.Image = CType(resources.GetObject("pbLogOut4.Image"), System.Drawing.Image)
        Me.pbLogOut4.Location = New System.Drawing.Point(914, 573)
        Me.pbLogOut4.Name = "pbLogOut4"
        Me.pbLogOut4.Size = New System.Drawing.Size(88, 92)
        Me.pbLogOut4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut4.TabIndex = 121
        Me.pbLogOut4.TabStop = False
        '
        'pbLogOut2
        '
        Me.pbLogOut2.BackColor = System.Drawing.Color.White
        Me.pbLogOut2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogOut2.Image = CType(resources.GetObject("pbLogOut2.Image"), System.Drawing.Image)
        Me.pbLogOut2.Location = New System.Drawing.Point(673, 556)
        Me.pbLogOut2.Name = "pbLogOut2"
        Me.pbLogOut2.Size = New System.Drawing.Size(108, 109)
        Me.pbLogOut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut2.TabIndex = 116
        Me.pbLogOut2.TabStop = False
        '
        'pbLogOut3
        '
        Me.pbLogOut3.BackColor = System.Drawing.Color.White
        Me.pbLogOut3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogOut3.Image = CType(resources.GetObject("pbLogOut3.Image"), System.Drawing.Image)
        Me.pbLogOut3.Location = New System.Drawing.Point(801, 564)
        Me.pbLogOut3.Name = "pbLogOut3"
        Me.pbLogOut3.Size = New System.Drawing.Size(98, 101)
        Me.pbLogOut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut3.TabIndex = 119
        Me.pbLogOut3.TabStop = False
        '
        'pbLogOut1
        '
        Me.pbLogOut1.BackColor = System.Drawing.Color.White
        Me.pbLogOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLogOut1.Image = CType(resources.GetObject("pbLogOut1.Image"), System.Drawing.Image)
        Me.pbLogOut1.Location = New System.Drawing.Point(537, 549)
        Me.pbLogOut1.Name = "pbLogOut1"
        Me.pbLogOut1.Size = New System.Drawing.Size(114, 116)
        Me.pbLogOut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut1.TabIndex = 113
        Me.pbLogOut1.TabStop = False
        '
        'tm
        '
        Me.tm.Interval = 300
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(1021, 726)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 45)
        Me.Label1.TabIndex = 151
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(59, 730)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(202, 17)
        Me.lblDate.TabIndex = 237
        Me.lblDate.Text = "January 01, 2011 Monday"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.Client
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPCsystem)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblLogOut3)
        Me.Controls.Add(Me.lblLogOut1)
        Me.Controls.Add(Me.lblLogIn1)
        Me.Controls.Add(Me.lblLogIn2)
        Me.Controls.Add(Me.lblRFIDStatus)
        Me.Controls.Add(Me.lblLogIn3)
        Me.Controls.Add(Me.lblLogIn4)
        Me.Controls.Add(Me.lblAnn)
        Me.Controls.Add(Me.pbLogIn4)
        Me.Controls.Add(Me.pbLoadRFID)
        Me.Controls.Add(Me.pbLogIn3)
        Me.Controls.Add(Me.pbLogIn2)
        Me.Controls.Add(Me.pbLogIn1)
        Me.Controls.Add(Me.pbMainPic)
        Me.Controls.Add(Me.pbLogOut4)
        Me.Controls.Add(Me.pbLogOut2)
        Me.Controls.Add(Me.pbLogOut3)
        Me.Controls.Add(Me.pbLogOut1)
        Me.Controls.Add(Me.lblLogOutSN4)
        Me.Controls.Add(Me.lblDateTimeLog)
        Me.Controls.Add(Me.lblLogOutSN3)
        Me.Controls.Add(Me.lblYearSec)
        Me.Controls.Add(Me.lblLogState)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblLogOutSN2)
        Me.Controls.Add(Me.lblStudNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblLOgOutSN1)
        Me.Controls.Add(Me.lblLogInSN1)
        Me.Controls.Add(Me.lblLogInSN2)
        Me.Controls.Add(Me.lblLogInSN3)
        Me.Controls.Add(Me.lblLogInSN4)
        Me.Controls.Add(Me.lblLogOut4)
        Me.Controls.Add(Me.lblLogOut2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = " "
        Me.Text = "Client"
        CType(Me.pbLogIn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoadRFID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogOut3 As System.Windows.Forms.Label
    Friend WithEvents lblLogOut1 As System.Windows.Forms.Label
    Friend WithEvents lblLogIn1 As System.Windows.Forms.Label
    Friend WithEvents lblLogIn2 As System.Windows.Forms.Label
    Friend WithEvents lblRFIDStatus As System.Windows.Forms.Label
    Friend WithEvents lblLogIn3 As System.Windows.Forms.Label
    Friend WithEvents lblLogIn4 As System.Windows.Forms.Label
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents pbLogIn4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLoadRFID As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogIn3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogIn2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogIn1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbMainPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblPCsystem As System.Windows.Forms.Label
    Friend WithEvents pbLogOut4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogOut2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents pbLogOut3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogOut1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogOutSN4 As System.Windows.Forms.Label
    Friend WithEvents lblDateTimeLog As System.Windows.Forms.Label
    Friend WithEvents lblLogOutSN3 As System.Windows.Forms.Label
    Friend WithEvents lblYearSec As System.Windows.Forms.Label
    Friend WithEvents lblLogState As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblLogOutSN2 As System.Windows.Forms.Label
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLOgOutSN1 As System.Windows.Forms.Label
    Friend WithEvents lblLogInSN1 As System.Windows.Forms.Label
    Friend WithEvents lblLogInSN2 As System.Windows.Forms.Label
    Friend WithEvents lblLogInSN3 As System.Windows.Forms.Label
    Friend WithEvents lblLogInSN4 As System.Windows.Forms.Label
    Friend WithEvents lblLogOut4 As System.Windows.Forms.Label
    Friend WithEvents lblLogOut2 As System.Windows.Forms.Label
    Friend WithEvents tmrRead As System.Windows.Forms.Timer
    Friend WithEvents tm As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
End Class
