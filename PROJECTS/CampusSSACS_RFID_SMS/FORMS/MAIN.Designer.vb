<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAIN
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
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.btnClient = New System.Windows.Forms.Button
        Me.gbPrevious = New System.Windows.Forms.GroupBox
        Me.lblLogState = New System.Windows.Forms.Label
        Me.lblDateTimeLog = New System.Windows.Forms.Label
        Me.lblDeptYrSc = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.pbPic = New System.Windows.Forms.PictureBox
        Me.tmrDisplayLog = New System.Windows.Forms.Timer(Me.components)
        Me.btnFindStud = New System.Windows.Forms.Button
        Me.gbFindStud = New System.Windows.Forms.GroupBox
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.gbPreviousLV = New System.Windows.Forms.GroupBox
        Me.llblFilterLog = New System.Windows.Forms.LinkLabel
        Me.cmsLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmLogIn = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmLogOut = New System.Windows.Forms.ToolStripMenuItem
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.llblViewProfile = New System.Windows.Forms.LinkLabel
        Me.LVlogs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.cmsLV_Logs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmViewStud = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEditStud = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSendMessage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmListLogs = New System.Windows.Forms.ToolStripMenuItem
        Me.chkPinLog = New System.Windows.Forms.CheckBox
        Me.tmrLV_animate = New System.Windows.Forms.Timer(Me.components)
        Me.gbSMS_Noti = New System.Windows.Forms.GroupBox
        Me.llblSMS = New System.Windows.Forms.LinkLabel
        Me.lblSMS_Noti = New System.Windows.Forms.Label
        Me.gbRFID_Noti = New System.Windows.Forms.GroupBox
        Me.llblRFID = New System.Windows.Forms.LinkLabel
        Me.lblRFID_Noti = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.gbRecords = New System.Windows.Forms.GroupBox
        Me.chkRecord = New System.Windows.Forms.CheckBox
        Me.btnParentList = New System.Windows.Forms.Button
        Me.btnFacultyUtily = New System.Windows.Forms.Button
        Me.btnStudList = New System.Windows.Forms.Button
        Me.btnDept = New System.Windows.Forms.Button
        Me.gbChat = New System.Windows.Forms.GroupBox
        Me.llblClose = New System.Windows.Forms.LinkLabel
        Me.lblUser = New System.Windows.Forms.Label
        Me.llblClearChat = New System.Windows.Forms.LinkLabel
        Me.llblHistory = New System.Windows.Forms.LinkLabel
        Me.cmbUser = New System.Windows.Forms.ComboBox
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtConfe = New System.Windows.Forms.TextBox
        Me.gbSMSTechnology = New System.Windows.Forms.GroupBox
        Me.btnSavedMessages = New System.Windows.Forms.Button
        Me.btnReceivedMessages = New System.Windows.Forms.Button
        Me.btnSMSMessages = New System.Windows.Forms.Button
        Me.chkSMS = New System.Windows.Forms.CheckBox
        Me.btnExpired = New System.Windows.Forms.Button
        Me.btnAccessSettings = New System.Windows.Forms.Button
        Me.gbSettings = New System.Windows.Forms.GroupBox
        Me.btnBackUpRestore = New System.Windows.Forms.Button
        Me.btnSystemPreferences = New System.Windows.Forms.Button
        Me.btnRecordArchive = New System.Windows.Forms.Button
        Me.chkSettings = New System.Windows.Forms.CheckBox
        Me.btnChangeDT = New System.Windows.Forms.Button
        Me.btnUserPrivilege = New System.Windows.Forms.Button
        Me.btnGSMModule = New System.Windows.Forms.Button
        Me.tmrChat = New System.Windows.Forms.Timer(Me.components)
        Me.gbRFIDSMS = New System.Windows.Forms.GroupBox
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmViewStudent = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmChat = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmAnnouncement = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmCreateMessage = New System.Windows.Forms.ToolStripMenuItem
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSystemUserAct = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmUpdateMyProfile = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmAddUser = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDeleteUser = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmListUser = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDisconnectUser = New System.Windows.Forms.ToolStripMenuItem
        Me.SMSTechnologyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmGSMModule = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmReceived = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSent = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmQueue = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSaved = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmExpired = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmStudLogs = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmStudList = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmParents = New System.Windows.Forms.ToolStripMenuItem
        Me.lblOPT = New System.Windows.Forms.Label
        Me.btnLogs_opt = New System.Windows.Forms.Button
        Me.btnSettings_opt = New System.Windows.Forms.Button
        Me.btnRecord_opt = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEditAnn = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSMS_opt = New System.Windows.Forms.Button
        Me.lblEditAnn = New System.Windows.Forms.Label
        Me.btnLogLV = New System.Windows.Forms.Button
        Me.lblAnnouncement = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.gbDateTime = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblLogs = New System.Windows.Forms.Label
        Me.lblAnn = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAnonymText = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pbLogs = New System.Windows.Forms.PictureBox
        Me.pbAnn = New System.Windows.Forms.PictureBox
        Me.pbAnonym = New System.Windows.Forms.PictureBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.gbSMS = New System.Windows.Forms.GroupBox
        Me.lblGSM = New System.Windows.Forms.Label
        Me.gbLogs = New System.Windows.Forms.GroupBox
        Me.chkLogs = New System.Windows.Forms.CheckBox
        Me.btnVisitorLog = New System.Windows.Forms.Button
        Me.btnFU = New System.Windows.Forms.Button
        Me.btnSystemLog = New System.Windows.Forms.Button
        Me.btnStudLog = New System.Windows.Forms.Button
        Me.txtAnn = New System.Windows.Forms.TextBox
        Me.gbEditAnn = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lShutdown = New System.Windows.Forms.Label
        Me.gbShutdown = New System.Windows.Forms.GroupBox
        Me.gbPrevious.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFindStud.SuspendLayout()
        Me.gbPreviousLV.SuspendLayout()
        Me.cmsLog.SuspendLayout()
        Me.cmsLV_Logs.SuspendLayout()
        Me.gbSMS_Noti.SuspendLayout()
        Me.gbRFID_Noti.SuspendLayout()
        Me.gbRecords.SuspendLayout()
        Me.gbChat.SuspendLayout()
        Me.gbSMSTechnology.SuspendLayout()
        Me.gbSettings.SuspendLayout()
        Me.gbRFIDSMS.SuspendLayout()
        Me.cmsMain.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDateTime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnonym, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSMS.SuspendLayout()
        Me.gbLogs.SuspendLayout()
        Me.gbEditAnn.SuspendLayout()
        Me.gbShutdown.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogOut.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Logout
        Me.btnLogOut.Location = New System.Drawing.Point(908, 16)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(102, 72)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "&Log out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttMain.SetToolTip(Me.btnLogOut, "Log out administrator")
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.Transparent
        Me.btnClient.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Client
        Me.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClient.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.White
        Me.btnClient.Location = New System.Drawing.Point(23, 657)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(64, 66)
        Me.btnClient.TabIndex = 22
        Me.btnClient.Text = "&Client"
        Me.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttMain.SetToolTip(Me.btnClient, "Student Monitoring")
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'gbPrevious
        '
        Me.gbPrevious.BackColor = System.Drawing.Color.Transparent
        Me.gbPrevious.Controls.Add(Me.lblLogState)
        Me.gbPrevious.Controls.Add(Me.lblDateTimeLog)
        Me.gbPrevious.Controls.Add(Me.lblDeptYrSc)
        Me.gbPrevious.Controls.Add(Me.lblName)
        Me.gbPrevious.Controls.Add(Me.lblStudNo)
        Me.gbPrevious.Controls.Add(Me.pbPic)
        Me.gbPrevious.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrevious.ForeColor = System.Drawing.Color.Gold
        Me.gbPrevious.Location = New System.Drawing.Point(22, 210)
        Me.gbPrevious.Name = "gbPrevious"
        Me.gbPrevious.Size = New System.Drawing.Size(359, 133)
        Me.gbPrevious.TabIndex = 167
        Me.gbPrevious.TabStop = False
        Me.gbPrevious.Text = "Most Recent Log Detection"
        '
        'lblLogState
        '
        Me.lblLogState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogState.ForeColor = System.Drawing.Color.Gold
        Me.lblLogState.Location = New System.Drawing.Point(197, 17)
        Me.lblLogState.Name = "lblLogState"
        Me.lblLogState.Size = New System.Drawing.Size(155, 20)
        Me.lblLogState.TabIndex = 2
        Me.lblLogState.Text = "Log State"
        Me.lblLogState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTimeLog
        '
        Me.lblDateTimeLog.BackColor = System.Drawing.Color.Black
        Me.lblDateTimeLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateTimeLog.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTimeLog.ForeColor = System.Drawing.Color.White
        Me.lblDateTimeLog.Location = New System.Drawing.Point(121, 108)
        Me.lblDateTimeLog.Name = "lblDateTimeLog"
        Me.lblDateTimeLog.Size = New System.Drawing.Size(231, 18)
        Me.lblDateTimeLog.TabIndex = 1
        Me.lblDateTimeLog.Text = "Date / Time Log"
        Me.lblDateTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeptYrSc
        '
        Me.lblDeptYrSc.BackColor = System.Drawing.Color.Black
        Me.lblDeptYrSc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeptYrSc.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptYrSc.ForeColor = System.Drawing.Color.White
        Me.lblDeptYrSc.Location = New System.Drawing.Point(121, 86)
        Me.lblDeptYrSc.Name = "lblDeptYrSc"
        Me.lblDeptYrSc.Size = New System.Drawing.Size(231, 20)
        Me.lblDeptYrSc.TabIndex = 1
        Me.lblDeptYrSc.Text = "Course/Year/Section"
        Me.lblDeptYrSc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(121, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(231, 21)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudNo
        '
        Me.lblStudNo.BackColor = System.Drawing.Color.Black
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudNo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.White
        Me.lblStudNo.Location = New System.Drawing.Point(121, 65)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(231, 18)
        Me.lblStudNo.TabIndex = 1
        Me.lblStudNo.Text = "Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPic
        '
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.pbPic.Location = New System.Drawing.Point(7, 18)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(109, 108)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 0
        Me.pbPic.TabStop = False
        '
        'tmrDisplayLog
        '
        Me.tmrDisplayLog.Enabled = True
        Me.tmrDisplayLog.Interval = 4000
        '
        'btnFindStud
        '
        Me.btnFindStud.BackColor = System.Drawing.Color.Transparent
        Me.btnFindStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindStud.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindStud.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Binocular_Icon
        Me.btnFindStud.Location = New System.Drawing.Point(23, 24)
        Me.btnFindStud.Name = "btnFindStud"
        Me.btnFindStud.Size = New System.Drawing.Size(39, 38)
        Me.btnFindStud.TabIndex = 169
        Me.btnFindStud.Tag = "Find"
        Me.btnFindStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindStud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnFindStud, "Find Student")
        Me.btnFindStud.UseVisualStyleBackColor = False
        '
        'gbFindStud
        '
        Me.gbFindStud.BackColor = System.Drawing.Color.Transparent
        Me.gbFindStud.Controls.Add(Me.txtKey)
        Me.gbFindStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFindStud.Location = New System.Drawing.Point(66, 19)
        Me.gbFindStud.Name = "gbFindStud"
        Me.gbFindStud.Size = New System.Drawing.Size(195, 43)
        Me.gbFindStud.TabIndex = 170
        Me.gbFindStud.TabStop = False
        Me.gbFindStud.Text = "Student Number"
        Me.gbFindStud.Visible = False
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Gray
        Me.txtKey.Location = New System.Drawing.Point(6, 16)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(179, 22)
        Me.txtKey.TabIndex = 0
        '
        'gbPreviousLV
        '
        Me.gbPreviousLV.BackColor = System.Drawing.Color.Transparent
        Me.gbPreviousLV.Controls.Add(Me.llblFilterLog)
        Me.gbPreviousLV.Controls.Add(Me.lblCount)
        Me.gbPreviousLV.Controls.Add(Me.Label5)
        Me.gbPreviousLV.Controls.Add(Me.llblViewProfile)
        Me.gbPreviousLV.Controls.Add(Me.LVlogs)
        Me.gbPreviousLV.Controls.Add(Me.chkPinLog)
        Me.gbPreviousLV.ForeColor = System.Drawing.Color.White
        Me.gbPreviousLV.Location = New System.Drawing.Point(616, 132)
        Me.gbPreviousLV.Name = "gbPreviousLV"
        Me.gbPreviousLV.Size = New System.Drawing.Size(392, 407)
        Me.gbPreviousLV.TabIndex = 171
        Me.gbPreviousLV.TabStop = False
        Me.gbPreviousLV.Visible = False
        '
        'llblFilterLog
        '
        Me.llblFilterLog.AutoSize = True
        Me.llblFilterLog.ContextMenuStrip = Me.cmsLog
        Me.llblFilterLog.LinkColor = System.Drawing.Color.White
        Me.llblFilterLog.Location = New System.Drawing.Point(173, 12)
        Me.llblFilterLog.Name = "llblFilterLog"
        Me.llblFilterLog.Size = New System.Drawing.Size(47, 13)
        Me.llblFilterLog.TabIndex = 206
        Me.llblFilterLog.TabStop = True
        Me.llblFilterLog.Text = "All Read"
        Me.ttMain.SetToolTip(Me.llblFilterLog, "Change/set the display log state")
        '
        'cmsLog
        '
        Me.cmsLog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAll, Me.ToolStripSeparator1, Me.tsmLogIn, Me.ToolStripSeparator5, Me.tsmLogOut})
        Me.cmsLog.Name = "cmsLog"
        Me.cmsLog.Size = New System.Drawing.Size(221, 82)
        '
        'tsmAll
        '
        Me.tsmAll.Name = "tsmAll"
        Me.tsmAll.Size = New System.Drawing.Size(220, 22)
        Me.tsmAll.Text = "Show Log in and Log out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'tsmLogIn
        '
        Me.tsmLogIn.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NextArrow
        Me.tsmLogIn.Name = "tsmLogIn"
        Me.tsmLogIn.Size = New System.Drawing.Size(220, 22)
        Me.tsmLogIn.Text = "Show only Log in"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(217, 6)
        '
        'tsmLogOut
        '
        Me.tsmLogOut.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.PreviousArrow
        Me.tsmLogOut.Name = "tsmLogOut"
        Me.tsmLogOut.Size = New System.Drawing.Size(220, 22)
        Me.tsmLogOut.Text = "Show only Log out"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(9, 486)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(85, 13)
        Me.lblCount.TabIndex = 175
        Me.lblCount.Text = "Record Count: 0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Previous Logs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'llblViewProfile
        '
        Me.llblViewProfile.AutoSize = True
        Me.llblViewProfile.Location = New System.Drawing.Point(269, 487)
        Me.llblViewProfile.Name = "llblViewProfile"
        Me.llblViewProfile.Size = New System.Drawing.Size(62, 13)
        Me.llblViewProfile.TabIndex = 2
        Me.llblViewProfile.TabStop = True
        Me.llblViewProfile.Text = "View Profile"
        Me.llblViewProfile.Visible = False
        '
        'LVlogs
        '
        Me.LVlogs.BackColor = System.Drawing.Color.Black
        Me.LVlogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVlogs.ContextMenuStrip = Me.cmsLV_Logs
        Me.LVlogs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVlogs.ForeColor = System.Drawing.Color.Gold
        Me.LVlogs.FullRowSelect = True
        Me.LVlogs.GridLines = True
        Me.LVlogs.Location = New System.Drawing.Point(6, 31)
        Me.LVlogs.MultiSelect = False
        Me.LVlogs.Name = "LVlogs"
        Me.LVlogs.Size = New System.Drawing.Size(379, 451)
        Me.LVlogs.TabIndex = 1
        Me.LVlogs.UseCompatibleStateImageBehavior = False
        Me.LVlogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student No."
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "State"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 64
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date/Time"
        Me.ColumnHeader4.Width = 100
        '
        'cmsLV_Logs
        '
        Me.cmsLV_Logs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmViewStud, Me.tsmEditStud, Me.tsmSendMessage, Me.ToolStripSeparator4, Me.tsmListLogs})
        Me.cmsLV_Logs.Name = "ContextMenuStrip1"
        Me.cmsLV_Logs.Size = New System.Drawing.Size(204, 98)
        '
        'tsmViewStud
        '
        Me.tsmViewStud.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmViewStud.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.tsmViewStud.Name = "tsmViewStud"
        Me.tsmViewStud.Size = New System.Drawing.Size(203, 22)
        Me.tsmViewStud.Text = "View Student Details"
        '
        'tsmEditStud
        '
        Me.tsmEditStud.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.edit
        Me.tsmEditStud.Name = "tsmEditStud"
        Me.tsmEditStud.Size = New System.Drawing.Size(203, 22)
        Me.tsmEditStud.Text = "Edit Student Information"
        '
        'tsmSendMessage
        '
        Me.tsmSendMessage.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.tsmSendMessage.Name = "tsmSendMessage"
        Me.tsmSendMessage.Size = New System.Drawing.Size(203, 22)
        Me.tsmSendMessage.Text = "Send Message..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'tsmListLogs
        '
        Me.tsmListLogs.Name = "tsmListLogs"
        Me.tsmListLogs.Size = New System.Drawing.Size(203, 22)
        Me.tsmListLogs.Text = "List Student Logs"
        '
        'chkPinLog
        '
        Me.chkPinLog.AutoSize = True
        Me.chkPinLog.ForeColor = System.Drawing.Color.Gold
        Me.chkPinLog.Location = New System.Drawing.Point(297, 11)
        Me.chkPinLog.Name = "chkPinLog"
        Me.chkPinLog.Size = New System.Drawing.Size(86, 17)
        Me.chkPinLog.TabIndex = 0
        Me.chkPinLog.Text = "Pin List View"
        Me.ttMain.SetToolTip(Me.chkPinLog, "Make the display List View Logs auto-hide")
        Me.chkPinLog.UseVisualStyleBackColor = True
        '
        'tmrLV_animate
        '
        Me.tmrLV_animate.Tag = "Show"
        '
        'gbSMS_Noti
        '
        Me.gbSMS_Noti.BackColor = System.Drawing.Color.Black
        Me.gbSMS_Noti.Controls.Add(Me.llblSMS)
        Me.gbSMS_Noti.Controls.Add(Me.lblSMS_Noti)
        Me.gbSMS_Noti.ForeColor = System.Drawing.Color.White
        Me.gbSMS_Noti.Location = New System.Drawing.Point(12, 16)
        Me.gbSMS_Noti.Name = "gbSMS_Noti"
        Me.gbSMS_Noti.Size = New System.Drawing.Size(249, 95)
        Me.gbSMS_Noti.TabIndex = 174
        Me.gbSMS_Noti.TabStop = False
        '
        'llblSMS
        '
        Me.llblSMS.AutoSize = True
        Me.llblSMS.Location = New System.Drawing.Point(178, 77)
        Me.llblSMS.Name = "llblSMS"
        Me.llblSMS.Size = New System.Drawing.Size(65, 13)
        Me.llblSMS.TabIndex = 1
        Me.llblSMS.TabStop = True
        Me.llblSMS.Text = "View Details"
        '
        'lblSMS_Noti
        '
        Me.lblSMS_Noti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSMS_Noti.Location = New System.Drawing.Point(6, 13)
        Me.lblSMS_Noti.Name = "lblSMS_Noti"
        Me.lblSMS_Noti.Size = New System.Drawing.Size(237, 62)
        Me.lblSMS_Noti.TabIndex = 0
        Me.lblSMS_Noti.Text = "0 Parent(s) unsubscribe from receiveing advisory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Message(s) Unread" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Message(" & _
            "s) Queued"
        Me.lblSMS_Noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbRFID_Noti
        '
        Me.gbRFID_Noti.BackColor = System.Drawing.Color.Black
        Me.gbRFID_Noti.Controls.Add(Me.llblRFID)
        Me.gbRFID_Noti.Controls.Add(Me.lblRFID_Noti)
        Me.gbRFID_Noti.ForeColor = System.Drawing.Color.White
        Me.gbRFID_Noti.Location = New System.Drawing.Point(271, 16)
        Me.gbRFID_Noti.Name = "gbRFID_Noti"
        Me.gbRFID_Noti.Size = New System.Drawing.Size(249, 95)
        Me.gbRFID_Noti.TabIndex = 177
        Me.gbRFID_Noti.TabStop = False
        '
        'llblRFID
        '
        Me.llblRFID.AutoSize = True
        Me.llblRFID.Location = New System.Drawing.Point(178, 77)
        Me.llblRFID.Name = "llblRFID"
        Me.llblRFID.Size = New System.Drawing.Size(65, 13)
        Me.llblRFID.TabIndex = 1
        Me.llblRFID.TabStop = True
        Me.llblRFID.Text = "View Details"
        '
        'lblRFID_Noti
        '
        Me.lblRFID_Noti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRFID_Noti.Location = New System.Drawing.Point(6, 14)
        Me.lblRFID_Noti.Name = "lblRFID_Noti"
        Me.lblRFID_Noti.Size = New System.Drawing.Size(237, 61)
        Me.lblRFID_Noti.TabIndex = 0
        Me.lblRFID_Noti.Text = "0 Total detections" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Log in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Log out"
        Me.lblRFID_Noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(68, 64)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(254, 23)
        Me.lblResult.TabIndex = 179
        Me.lblResult.Text = "No result for ''"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblResult.Visible = False
        '
        'gbRecords
        '
        Me.gbRecords.BackColor = System.Drawing.Color.Black
        Me.gbRecords.Controls.Add(Me.chkRecord)
        Me.gbRecords.Controls.Add(Me.btnParentList)
        Me.gbRecords.Controls.Add(Me.btnFacultyUtily)
        Me.gbRecords.Controls.Add(Me.btnStudList)
        Me.gbRecords.Controls.Add(Me.btnDept)
        Me.gbRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbRecords.Location = New System.Drawing.Point(405, 284)
        Me.gbRecords.Name = "gbRecords"
        Me.gbRecords.Size = New System.Drawing.Size(65, 21)
        Me.gbRecords.TabIndex = 192
        Me.gbRecords.TabStop = False
        Me.gbRecords.Text = "Records"
        Me.gbRecords.Visible = False
        '
        'chkRecord
        '
        Me.chkRecord.AutoSize = True
        Me.chkRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkRecord.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecord.ForeColor = System.Drawing.Color.Gold
        Me.chkRecord.Location = New System.Drawing.Point(453, 12)
        Me.chkRecord.Name = "chkRecord"
        Me.chkRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRecord.Size = New System.Drawing.Size(77, 17)
        Me.chkRecord.TabIndex = 199
        Me.chkRecord.Text = "Pin Panel"
        Me.chkRecord.UseVisualStyleBackColor = True
        '
        'btnParentList
        '
        Me.btnParentList.BackColor = System.Drawing.Color.Transparent
        Me.btnParentList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParentList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParentList.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParentList.ForeColor = System.Drawing.Color.White
        Me.btnParentList.Location = New System.Drawing.Point(288, 72)
        Me.btnParentList.Name = "btnParentList"
        Me.btnParentList.Size = New System.Drawing.Size(166, 36)
        Me.btnParentList.TabIndex = 193
        Me.btnParentList.Text = "Parents List"
        Me.btnParentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParentList.UseVisualStyleBackColor = False
        '
        'btnFacultyUtily
        '
        Me.btnFacultyUtily.BackColor = System.Drawing.Color.Transparent
        Me.btnFacultyUtily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacultyUtily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFacultyUtily.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacultyUtily.ForeColor = System.Drawing.Color.White
        Me.btnFacultyUtily.Location = New System.Drawing.Point(288, 30)
        Me.btnFacultyUtily.Name = "btnFacultyUtily"
        Me.btnFacultyUtily.Size = New System.Drawing.Size(166, 36)
        Me.btnFacultyUtily.TabIndex = 191
        Me.btnFacultyUtily.Text = "Faculty/Utility"
        Me.btnFacultyUtily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFacultyUtily.UseVisualStyleBackColor = False
        '
        'btnStudList
        '
        Me.btnStudList.BackColor = System.Drawing.Color.Transparent
        Me.btnStudList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudList.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudList.ForeColor = System.Drawing.Color.White
        Me.btnStudList.Location = New System.Drawing.Point(82, 72)
        Me.btnStudList.Name = "btnStudList"
        Me.btnStudList.Size = New System.Drawing.Size(166, 36)
        Me.btnStudList.TabIndex = 189
        Me.btnStudList.Text = "Student List"
        Me.btnStudList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudList.UseVisualStyleBackColor = False
        '
        'btnDept
        '
        Me.btnDept.BackColor = System.Drawing.Color.Transparent
        Me.btnDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept.ForeColor = System.Drawing.Color.White
        Me.btnDept.Location = New System.Drawing.Point(82, 30)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(166, 36)
        Me.btnDept.TabIndex = 188
        Me.btnDept.Text = "Departments"
        Me.btnDept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDept.UseVisualStyleBackColor = False
        '
        'gbChat
        '
        Me.gbChat.BackColor = System.Drawing.Color.Black
        Me.gbChat.Controls.Add(Me.llblClose)
        Me.gbChat.Controls.Add(Me.lblUser)
        Me.gbChat.Controls.Add(Me.llblClearChat)
        Me.gbChat.Controls.Add(Me.llblHistory)
        Me.gbChat.Controls.Add(Me.cmbUser)
        Me.gbChat.Controls.Add(Me.txtMessage)
        Me.gbChat.Controls.Add(Me.txtConfe)
        Me.gbChat.ForeColor = System.Drawing.Color.White
        Me.gbChat.Location = New System.Drawing.Point(616, 541)
        Me.gbChat.Name = "gbChat"
        Me.gbChat.Size = New System.Drawing.Size(394, 202)
        Me.gbChat.TabIndex = 193
        Me.gbChat.TabStop = False
        Me.gbChat.Visible = False
        '
        'llblClose
        '
        Me.llblClose.AutoSize = True
        Me.llblClose.Location = New System.Drawing.Point(307, 38)
        Me.llblClose.Name = "llblClose"
        Me.llblClose.Size = New System.Drawing.Size(78, 13)
        Me.llblClose.TabIndex = 176
        Me.llblClose.TabStop = True
        Me.llblClose.Text = "Close [Escape]"
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.DimGray
        Me.lblUser.Location = New System.Drawing.Point(197, 15)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(191, 23)
        Me.lblUser.TabIndex = 175
        Me.lblUser.Text = "FName LName"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUser.Visible = False
        '
        'llblClearChat
        '
        Me.llblClearChat.AutoSize = True
        Me.llblClearChat.Location = New System.Drawing.Point(3, 41)
        Me.llblClearChat.Name = "llblClearChat"
        Me.llblClearChat.Size = New System.Drawing.Size(31, 13)
        Me.llblClearChat.TabIndex = 6
        Me.llblClearChat.TabStop = True
        Me.llblClearChat.Text = "Clear"
        '
        'llblHistory
        '
        Me.llblHistory.AutoSize = True
        Me.llblHistory.Location = New System.Drawing.Point(194, 38)
        Me.llblHistory.Name = "llblHistory"
        Me.llblHistory.Size = New System.Drawing.Size(39, 13)
        Me.llblHistory.TabIndex = 5
        Me.llblHistory.TabStop = True
        Me.llblHistory.Text = "History"
        '
        'cmbUser
        '
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(7, 16)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(175, 22)
        Me.cmbUser.TabIndex = 4
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMessage.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.Gray
        Me.txtMessage.Location = New System.Drawing.Point(6, 155)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(382, 34)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "Type your message here..."
        '
        'txtConfe
        '
        Me.txtConfe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConfe.ForeColor = System.Drawing.Color.Gray
        Me.txtConfe.Location = New System.Drawing.Point(6, 57)
        Me.txtConfe.Multiline = True
        Me.txtConfe.Name = "txtConfe"
        Me.txtConfe.ReadOnly = True
        Me.txtConfe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConfe.Size = New System.Drawing.Size(382, 92)
        Me.txtConfe.TabIndex = 2
        Me.txtConfe.Text = "No messages..."
        '
        'gbSMSTechnology
        '
        Me.gbSMSTechnology.BackColor = System.Drawing.Color.Black
        Me.gbSMSTechnology.Controls.Add(Me.btnSavedMessages)
        Me.gbSMSTechnology.Controls.Add(Me.btnReceivedMessages)
        Me.gbSMSTechnology.Controls.Add(Me.btnSMSMessages)
        Me.gbSMSTechnology.Controls.Add(Me.chkSMS)
        Me.gbSMSTechnology.Controls.Add(Me.btnExpired)
        Me.gbSMSTechnology.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSMSTechnology.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbSMSTechnology.Location = New System.Drawing.Point(487, 284)
        Me.gbSMSTechnology.Name = "gbSMSTechnology"
        Me.gbSMSTechnology.Size = New System.Drawing.Size(49, 21)
        Me.gbSMSTechnology.TabIndex = 194
        Me.gbSMSTechnology.TabStop = False
        Me.gbSMSTechnology.Text = "SMS"
        Me.gbSMSTechnology.Visible = False
        '
        'btnSavedMessages
        '
        Me.btnSavedMessages.BackColor = System.Drawing.Color.Transparent
        Me.btnSavedMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavedMessages.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSavedMessages.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavedMessages.ForeColor = System.Drawing.Color.White
        Me.btnSavedMessages.Location = New System.Drawing.Point(71, 69)
        Me.btnSavedMessages.Name = "btnSavedMessages"
        Me.btnSavedMessages.Size = New System.Drawing.Size(166, 39)
        Me.btnSavedMessages.TabIndex = 219
        Me.btnSavedMessages.Text = "Saved Messages"
        Me.btnSavedMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavedMessages.UseVisualStyleBackColor = False
        '
        'btnReceivedMessages
        '
        Me.btnReceivedMessages.BackColor = System.Drawing.Color.Transparent
        Me.btnReceivedMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceivedMessages.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceivedMessages.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceivedMessages.ForeColor = System.Drawing.Color.White
        Me.btnReceivedMessages.Location = New System.Drawing.Point(71, 21)
        Me.btnReceivedMessages.Name = "btnReceivedMessages"
        Me.btnReceivedMessages.Size = New System.Drawing.Size(166, 39)
        Me.btnReceivedMessages.TabIndex = 218
        Me.btnReceivedMessages.Text = "Received Messages"
        Me.btnReceivedMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReceivedMessages.UseVisualStyleBackColor = False
        '
        'btnSMSMessages
        '
        Me.btnSMSMessages.BackColor = System.Drawing.Color.Transparent
        Me.btnSMSMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMSMessages.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSMSMessages.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSMSMessages.ForeColor = System.Drawing.Color.White
        Me.btnSMSMessages.Location = New System.Drawing.Point(250, 69)
        Me.btnSMSMessages.Name = "btnSMSMessages"
        Me.btnSMSMessages.Size = New System.Drawing.Size(166, 39)
        Me.btnSMSMessages.TabIndex = 203
        Me.btnSMSMessages.Text = "Change System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SMS Messages"
        Me.btnSMSMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSMSMessages.UseVisualStyleBackColor = False
        '
        'chkSMS
        '
        Me.chkSMS.AutoSize = True
        Me.chkSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSMS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSMS.ForeColor = System.Drawing.Color.Gold
        Me.chkSMS.Location = New System.Drawing.Point(453, 12)
        Me.chkSMS.Name = "chkSMS"
        Me.chkSMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSMS.Size = New System.Drawing.Size(77, 17)
        Me.chkSMS.TabIndex = 198
        Me.chkSMS.Text = "Pin Panel"
        Me.chkSMS.UseVisualStyleBackColor = True
        '
        'btnExpired
        '
        Me.btnExpired.BackColor = System.Drawing.Color.Transparent
        Me.btnExpired.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpired.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpired.ForeColor = System.Drawing.Color.White
        Me.btnExpired.Location = New System.Drawing.Point(250, 21)
        Me.btnExpired.Name = "btnExpired"
        Me.btnExpired.Size = New System.Drawing.Size(166, 39)
        Me.btnExpired.TabIndex = 217
        Me.btnExpired.Text = "Expired Messages"
        Me.btnExpired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpired.UseVisualStyleBackColor = False
        '
        'btnAccessSettings
        '
        Me.btnAccessSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnAccessSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccessSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccessSettings.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccessSettings.ForeColor = System.Drawing.Color.White
        Me.btnAccessSettings.Location = New System.Drawing.Point(64, 93)
        Me.btnAccessSettings.Name = "btnAccessSettings"
        Me.btnAccessSettings.Size = New System.Drawing.Size(186, 24)
        Me.btnAccessSettings.TabIndex = 193
        Me.btnAccessSettings.Text = "System User Settings"
        Me.btnAccessSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccessSettings.UseVisualStyleBackColor = False
        '
        'gbSettings
        '
        Me.gbSettings.BackColor = System.Drawing.Color.Black
        Me.gbSettings.Controls.Add(Me.btnBackUpRestore)
        Me.gbSettings.Controls.Add(Me.btnSystemPreferences)
        Me.gbSettings.Controls.Add(Me.btnRecordArchive)
        Me.gbSettings.Controls.Add(Me.chkSettings)
        Me.gbSettings.Controls.Add(Me.btnChangeDT)
        Me.gbSettings.Controls.Add(Me.btnUserPrivilege)
        Me.gbSettings.Controls.Add(Me.btnAccessSettings)
        Me.gbSettings.Controls.Add(Me.btnGSMModule)
        Me.gbSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbSettings.Location = New System.Drawing.Point(405, 311)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(69, 21)
        Me.gbSettings.TabIndex = 197
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        Me.gbSettings.Visible = False
        '
        'btnBackUpRestore
        '
        Me.btnBackUpRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnBackUpRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackUpRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackUpRestore.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUpRestore.ForeColor = System.Drawing.Color.White
        Me.btnBackUpRestore.Location = New System.Drawing.Point(259, 82)
        Me.btnBackUpRestore.Name = "btnBackUpRestore"
        Me.btnBackUpRestore.Size = New System.Drawing.Size(186, 24)
        Me.btnBackUpRestore.TabIndex = 202
        Me.btnBackUpRestore.Text = "Back-up/Restore Database"
        Me.btnBackUpRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackUpRestore.UseVisualStyleBackColor = False
        '
        'btnSystemPreferences
        '
        Me.btnSystemPreferences.BackColor = System.Drawing.Color.Transparent
        Me.btnSystemPreferences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystemPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSystemPreferences.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemPreferences.ForeColor = System.Drawing.Color.White
        Me.btnSystemPreferences.Location = New System.Drawing.Point(64, 15)
        Me.btnSystemPreferences.Name = "btnSystemPreferences"
        Me.btnSystemPreferences.Size = New System.Drawing.Size(186, 24)
        Me.btnSystemPreferences.TabIndex = 201
        Me.btnSystemPreferences.Text = "Show System Preference"
        Me.btnSystemPreferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSystemPreferences.UseVisualStyleBackColor = False
        '
        'btnRecordArchive
        '
        Me.btnRecordArchive.BackColor = System.Drawing.Color.Transparent
        Me.btnRecordArchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecordArchive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecordArchive.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordArchive.ForeColor = System.Drawing.Color.White
        Me.btnRecordArchive.Location = New System.Drawing.Point(64, 67)
        Me.btnRecordArchive.Name = "btnRecordArchive"
        Me.btnRecordArchive.Size = New System.Drawing.Size(186, 24)
        Me.btnRecordArchive.TabIndex = 216
        Me.btnRecordArchive.Text = "Record Archive"
        Me.btnRecordArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecordArchive.UseVisualStyleBackColor = False
        '
        'chkSettings
        '
        Me.chkSettings.AutoSize = True
        Me.chkSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSettings.ForeColor = System.Drawing.Color.Gold
        Me.chkSettings.Location = New System.Drawing.Point(454, 11)
        Me.chkSettings.Name = "chkSettings"
        Me.chkSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSettings.Size = New System.Drawing.Size(77, 17)
        Me.chkSettings.TabIndex = 200
        Me.chkSettings.Text = "Pin Panel"
        Me.chkSettings.UseVisualStyleBackColor = True
        '
        'btnChangeDT
        '
        Me.btnChangeDT.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeDT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangeDT.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeDT.ForeColor = System.Drawing.Color.White
        Me.btnChangeDT.Location = New System.Drawing.Point(259, 55)
        Me.btnChangeDT.Name = "btnChangeDT"
        Me.btnChangeDT.Size = New System.Drawing.Size(186, 24)
        Me.btnChangeDT.TabIndex = 199
        Me.btnChangeDT.Text = "Date and Time Settings"
        Me.btnChangeDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangeDT.UseVisualStyleBackColor = False
        '
        'btnUserPrivilege
        '
        Me.btnUserPrivilege.BackColor = System.Drawing.Color.Transparent
        Me.btnUserPrivilege.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserPrivilege.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUserPrivilege.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserPrivilege.ForeColor = System.Drawing.Color.White
        Me.btnUserPrivilege.Location = New System.Drawing.Point(259, 28)
        Me.btnUserPrivilege.Name = "btnUserPrivilege"
        Me.btnUserPrivilege.Size = New System.Drawing.Size(186, 24)
        Me.btnUserPrivilege.TabIndex = 198
        Me.btnUserPrivilege.Text = "Update User Privileges"
        Me.btnUserPrivilege.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserPrivilege.UseVisualStyleBackColor = False
        '
        'btnGSMModule
        '
        Me.btnGSMModule.BackColor = System.Drawing.Color.Transparent
        Me.btnGSMModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGSMModule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGSMModule.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSMModule.ForeColor = System.Drawing.Color.White
        Me.btnGSMModule.Location = New System.Drawing.Point(64, 41)
        Me.btnGSMModule.Name = "btnGSMModule"
        Me.btnGSMModule.Size = New System.Drawing.Size(186, 24)
        Me.btnGSMModule.TabIndex = 197
        Me.btnGSMModule.Text = "GSM Module Configuration"
        Me.btnGSMModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGSMModule.UseVisualStyleBackColor = False
        '
        'tmrChat
        '
        Me.tmrChat.Interval = 500
        '
        'gbRFIDSMS
        '
        Me.gbRFIDSMS.BackColor = System.Drawing.Color.Transparent
        Me.gbRFIDSMS.Controls.Add(Me.gbRFID_Noti)
        Me.gbRFIDSMS.Controls.Add(Me.gbSMS_Noti)
        Me.gbRFIDSMS.Location = New System.Drawing.Point(22, 518)
        Me.gbRFIDSMS.Name = "gbRFIDSMS"
        Me.gbRFIDSMS.Size = New System.Drawing.Size(536, 123)
        Me.gbRFIDSMS.TabIndex = 198
        Me.gbRFIDSMS.TabStop = False
        Me.gbRFIDSMS.Text = "Notification"
        '
        'cmsMain
        '
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmViewStudent, Me.ToolStripSeparator2, Me.tsmRefresh, Me.ToolStripSeparator7, Me.tsmChat, Me.ToolStripSeparator6, Me.tsmAnnouncement, Me.ToolStripSeparator3, Me.tsmCreateMessage, Me.NavigateToolStripMenuItem})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.Size = New System.Drawing.Size(253, 160)
        '
        'tsmViewStudent
        '
        Me.tsmViewStudent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmViewStudent.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.tsmViewStudent.Name = "tsmViewStudent"
        Me.tsmViewStudent.Size = New System.Drawing.Size(252, 22)
        Me.tsmViewStudent.Text = "View Student Monitoring Logs"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(249, 6)
        '
        'tsmRefresh
        '
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.Size = New System.Drawing.Size(252, 22)
        Me.tsmRefresh.Text = "Refresh"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(249, 6)
        '
        'tsmChat
        '
        Me.tsmChat.Name = "tsmChat"
        Me.tsmChat.Size = New System.Drawing.Size(252, 22)
        Me.tsmChat.Text = "Chat Active Users"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(249, 6)
        '
        'tsmAnnouncement
        '
        Me.tsmAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Announce
        Me.tsmAnnouncement.Name = "tsmAnnouncement"
        Me.tsmAnnouncement.Size = New System.Drawing.Size(252, 22)
        Me.tsmAnnouncement.Text = "Post Announcement"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(249, 6)
        '
        'tsmCreateMessage
        '
        Me.tsmCreateMessage.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.tsmCreateMessage.Name = "tsmCreateMessage"
        Me.tsmCreateMessage.Size = New System.Drawing.Size(252, 22)
        Me.tsmCreateMessage.Text = "Create Message..."
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemUsersToolStripMenuItem, Me.SMSTechnologyToolStripMenuItem, Me.StudentsToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.NavigateToolStripMenuItem.Text = "Navigate"
        '
        'SystemUsersToolStripMenuItem
        '
        Me.SystemUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSystemUserAct, Me.tsmUpdateMyProfile, Me.tsmAddUser, Me.tsmDeleteUser, Me.tsmListUser, Me.tsmDisconnectUser})
        Me.SystemUsersToolStripMenuItem.Name = "SystemUsersToolStripMenuItem"
        Me.SystemUsersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SystemUsersToolStripMenuItem.Text = "System Users"
        '
        'tsmSystemUserAct
        '
        Me.tsmSystemUserAct.Name = "tsmSystemUserAct"
        Me.tsmSystemUserAct.Size = New System.Drawing.Size(196, 22)
        Me.tsmSystemUserAct.Text = "System Users Activities"
        '
        'tsmUpdateMyProfile
        '
        Me.tsmUpdateMyProfile.Name = "tsmUpdateMyProfile"
        Me.tsmUpdateMyProfile.Size = New System.Drawing.Size(196, 22)
        Me.tsmUpdateMyProfile.Text = "Update My Account"
        '
        'tsmAddUser
        '
        Me.tsmAddUser.Name = "tsmAddUser"
        Me.tsmAddUser.Size = New System.Drawing.Size(196, 22)
        Me.tsmAddUser.Text = "Add"
        '
        'tsmDeleteUser
        '
        Me.tsmDeleteUser.Name = "tsmDeleteUser"
        Me.tsmDeleteUser.Size = New System.Drawing.Size(196, 22)
        Me.tsmDeleteUser.Text = "Delete"
        '
        'tsmListUser
        '
        Me.tsmListUser.Name = "tsmListUser"
        Me.tsmListUser.Size = New System.Drawing.Size(196, 22)
        Me.tsmListUser.Text = "List"
        '
        'tsmDisconnectUser
        '
        Me.tsmDisconnectUser.Name = "tsmDisconnectUser"
        Me.tsmDisconnectUser.Size = New System.Drawing.Size(196, 22)
        Me.tsmDisconnectUser.Text = "Disconnect"
        '
        'SMSTechnologyToolStripMenuItem
        '
        Me.SMSTechnologyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmGSMModule, Me.tsmReceived, Me.tsmSent, Me.tsmQueue, Me.tsmSaved, Me.tsmExpired})
        Me.SMSTechnologyToolStripMenuItem.Name = "SMSTechnologyToolStripMenuItem"
        Me.SMSTechnologyToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SMSTechnologyToolStripMenuItem.Text = "SMS Technology"
        '
        'tsmGSMModule
        '
        Me.tsmGSMModule.Name = "tsmGSMModule"
        Me.tsmGSMModule.Size = New System.Drawing.Size(211, 22)
        Me.tsmGSMModule.Text = "GSM Module Configuration"
        '
        'tsmReceived
        '
        Me.tsmReceived.Name = "tsmReceived"
        Me.tsmReceived.Size = New System.Drawing.Size(211, 22)
        Me.tsmReceived.Text = "Received"
        '
        'tsmSent
        '
        Me.tsmSent.Name = "tsmSent"
        Me.tsmSent.Size = New System.Drawing.Size(211, 22)
        Me.tsmSent.Text = "Sent"
        '
        'tsmQueue
        '
        Me.tsmQueue.Name = "tsmQueue"
        Me.tsmQueue.Size = New System.Drawing.Size(211, 22)
        Me.tsmQueue.Text = "Queue"
        '
        'tsmSaved
        '
        Me.tsmSaved.Name = "tsmSaved"
        Me.tsmSaved.Size = New System.Drawing.Size(211, 22)
        Me.tsmSaved.Text = "Saved"
        '
        'tsmExpired
        '
        Me.tsmExpired.Name = "tsmExpired"
        Me.tsmExpired.Size = New System.Drawing.Size(211, 22)
        Me.tsmExpired.Text = "Expired"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmStudLogs, Me.tsmStudList, Me.tsmParents})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'tsmStudLogs
        '
        Me.tsmStudLogs.Name = "tsmStudLogs"
        Me.tsmStudLogs.Size = New System.Drawing.Size(176, 22)
        Me.tsmStudLogs.Text = "Student Logs"
        '
        'tsmStudList
        '
        Me.tsmStudList.Name = "tsmStudList"
        Me.tsmStudList.Size = New System.Drawing.Size(176, 22)
        Me.tsmStudList.Text = "Student List"
        '
        'tsmParents
        '
        Me.tsmParents.Name = "tsmParents"
        Me.tsmParents.Size = New System.Drawing.Size(176, 22)
        Me.tsmParents.Text = "Parent Information"
        '
        'lblOPT
        '
        Me.lblOPT.Location = New System.Drawing.Point(17, 485)
        Me.lblOPT.Name = "lblOPT"
        Me.lblOPT.Size = New System.Drawing.Size(545, 160)
        Me.lblOPT.TabIndex = 199
        '
        'btnLogs_opt
        '
        Me.btnLogs_opt.BackColor = System.Drawing.Color.Transparent
        Me.btnLogs_opt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogs_opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogs_opt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs_opt.ForeColor = System.Drawing.Color.White
        Me.btnLogs_opt.Location = New System.Drawing.Point(22, 491)
        Me.btnLogs_opt.Name = "btnLogs_opt"
        Me.btnLogs_opt.Size = New System.Drawing.Size(82, 23)
        Me.btnLogs_opt.TabIndex = 202
        Me.btnLogs_opt.Text = "LOGS"
        Me.btnLogs_opt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnLogs_opt, "Client Options")
        Me.btnLogs_opt.UseVisualStyleBackColor = False
        '
        'btnSettings_opt
        '
        Me.btnSettings_opt.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings_opt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings_opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings_opt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings_opt.ForeColor = System.Drawing.Color.White
        Me.btnSettings_opt.Location = New System.Drawing.Point(193, 491)
        Me.btnSettings_opt.Name = "btnSettings_opt"
        Me.btnSettings_opt.Size = New System.Drawing.Size(82, 23)
        Me.btnSettings_opt.TabIndex = 201
        Me.btnSettings_opt.Text = "SETTINGS"
        Me.btnSettings_opt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnSettings_opt, "System Settings")
        Me.btnSettings_opt.UseVisualStyleBackColor = False
        '
        'btnRecord_opt
        '
        Me.btnRecord_opt.BackColor = System.Drawing.Color.Transparent
        Me.btnRecord_opt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecord_opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord_opt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord_opt.ForeColor = System.Drawing.Color.White
        Me.btnRecord_opt.Location = New System.Drawing.Point(107, 491)
        Me.btnRecord_opt.Name = "btnRecord_opt"
        Me.btnRecord_opt.Size = New System.Drawing.Size(82, 23)
        Me.btnRecord_opt.TabIndex = 200
        Me.btnRecord_opt.Text = "RECORDS"
        Me.btnRecord_opt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnRecord_opt, "Records ")
        Me.btnRecord_opt.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.PUP
        Me.PictureBox2.Location = New System.Drawing.Point(342, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 206
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(418, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(415, 78)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Polytechnic University of the Phiippines Sta. Maria Campus Student Security Monit" & _
            "oring System Using Radio Frequency Identification with SMS Technology"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditAnn
        '
        Me.btnEditAnn.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditAnn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAnn.Font = New System.Drawing.Font("DS-Digital", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAnn.ForeColor = System.Drawing.Color.White
        Me.btnEditAnn.Location = New System.Drawing.Point(364, 82)
        Me.btnEditAnn.Name = "btnEditAnn"
        Me.btnEditAnn.Size = New System.Drawing.Size(49, 19)
        Me.btnEditAnn.TabIndex = 221
        Me.btnEditAnn.Text = "Change"
        Me.btnEditAnn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnEditAnn, "Save changes")
        Me.btnEditAnn.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("DS-Digital", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(419, 82)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(49, 19)
        Me.btnCancel.TabIndex = 222
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnCancel, "Cancel Changing of Announcement")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSMS_opt
        '
        Me.btnSMS_opt.BackColor = System.Drawing.Color.Transparent
        Me.btnSMS_opt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMS_opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMS_opt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSMS_opt.ForeColor = System.Drawing.Color.White
        Me.btnSMS_opt.Location = New System.Drawing.Point(279, 491)
        Me.btnSMS_opt.Name = "btnSMS_opt"
        Me.btnSMS_opt.Size = New System.Drawing.Size(82, 23)
        Me.btnSMS_opt.TabIndex = 225
        Me.btnSMS_opt.Text = "SMS"
        Me.btnSMS_opt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnSMS_opt, "System Settings")
        Me.btnSMS_opt.UseVisualStyleBackColor = False
        '
        'lblEditAnn
        '
        Me.lblEditAnn.BackColor = System.Drawing.Color.Transparent
        Me.lblEditAnn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEditAnn.ForeColor = System.Drawing.Color.Lime
        Me.lblEditAnn.Location = New System.Drawing.Point(17, 90)
        Me.lblEditAnn.Name = "lblEditAnn"
        Me.lblEditAnn.Size = New System.Drawing.Size(39, 16)
        Me.lblEditAnn.TabIndex = 228
        Me.lblEditAnn.Text = "Edit"
        Me.lblEditAnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttMain.SetToolTip(Me.lblEditAnn, "Edit announcement")
        Me.lblEditAnn.Visible = False
        '
        'btnLogLV
        '
        Me.btnLogLV.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogLV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogLV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogLV.FlatAppearance.BorderSize = 2
        Me.btnLogLV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnLogLV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnLogLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogLV.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogLV.ForeColor = System.Drawing.Color.White
        Me.btnLogLV.Location = New System.Drawing.Point(1007, 140)
        Me.btnLogLV.Name = "btnLogLV"
        Me.btnLogLV.Size = New System.Drawing.Size(18, 130)
        Me.btnLogLV.TabIndex = 207
        Me.btnLogLV.Text = "Logs"
        Me.btnLogLV.UseVisualStyleBackColor = False
        '
        'lblAnnouncement
        '
        Me.lblAnnouncement.BackColor = System.Drawing.Color.Black
        Me.lblAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAnnouncement.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnouncement.ForeColor = System.Drawing.Color.DimGray
        Me.lblAnnouncement.Location = New System.Drawing.Point(18, 106)
        Me.lblAnnouncement.Name = "lblAnnouncement"
        Me.lblAnnouncement.Size = New System.Drawing.Size(480, 89)
        Me.lblAnnouncement.TabIndex = 209
        Me.lblAnnouncement.Text = "Announcement:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Polytechnic University of the Philippines Sta. Maria Campus Usin" & _
            "g Radio Frequency Identification w/ SMS Technology"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Yellow
        Me.lblTime.Location = New System.Drawing.Point(11, 32)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(224, 35)
        Me.lblTime.TabIndex = 210
        Me.lblTime.Text = "7:30 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(11, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(224, 18)
        Me.lblDate.TabIndex = 211
        Me.lblDate.Text = "January 01, 2011 Monday"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDateTime
        '
        Me.gbDateTime.BackColor = System.Drawing.Color.Transparent
        Me.gbDateTime.Controls.Add(Me.lblDate)
        Me.gbDateTime.Controls.Add(Me.lblTime)
        Me.gbDateTime.Location = New System.Drawing.Point(371, 657)
        Me.gbDateTime.Name = "gbDateTime"
        Me.gbDateTime.Size = New System.Drawing.Size(241, 73)
        Me.gbDateTime.TabIndex = 212
        Me.gbDateTime.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS
        Me.PictureBox1.Location = New System.Drawing.Point(7, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'lblLogs
        '
        Me.lblLogs.BackColor = System.Drawing.Color.Black
        Me.lblLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogs.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogs.ForeColor = System.Drawing.Color.White
        Me.lblLogs.Location = New System.Drawing.Point(178, 18)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(323, 20)
        Me.lblLogs.TabIndex = 25
        Me.lblLogs.Text = "SMS status"
        Me.lblLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnn
        '
        Me.lblAnn.BackColor = System.Drawing.Color.Black
        Me.lblAnn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnn.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnn.ForeColor = System.Drawing.Color.White
        Me.lblAnn.Location = New System.Drawing.Point(178, 42)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(323, 20)
        Me.lblAnn.TabIndex = 25
        Me.lblAnn.Text = "SMS status"
        Me.lblAnn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Monitoring Logs:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Announcement:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnonymText
        '
        Me.lblAnonymText.BackColor = System.Drawing.Color.Black
        Me.lblAnonymText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnonymText.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnonymText.ForeColor = System.Drawing.Color.White
        Me.lblAnonymText.Location = New System.Drawing.Point(178, 66)
        Me.lblAnonymText.Name = "lblAnonymText"
        Me.lblAnonymText.Size = New System.Drawing.Size(323, 20)
        Me.lblAnonymText.TabIndex = 167
        Me.lblAnonymText.Text = "SMS status"
        Me.lblAnonymText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(58, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Anonymous Text:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogs
        '
        Me.pbLogs.BackColor = System.Drawing.Color.Transparent
        Me.pbLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLogs.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLogs.Location = New System.Drawing.Point(510, 19)
        Me.pbLogs.Name = "pbLogs"
        Me.pbLogs.Size = New System.Drawing.Size(18, 18)
        Me.pbLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogs.TabIndex = 3
        Me.pbLogs.TabStop = False
        Me.pbLogs.Tag = "Stopped"
        '
        'pbAnn
        '
        Me.pbAnn.BackColor = System.Drawing.Color.Transparent
        Me.pbAnn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAnn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAnn.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NotConnected
        Me.pbAnn.Location = New System.Drawing.Point(510, 44)
        Me.pbAnn.Name = "pbAnn"
        Me.pbAnn.Size = New System.Drawing.Size(18, 18)
        Me.pbAnn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnn.TabIndex = 169
        Me.pbAnn.TabStop = False
        Me.pbAnn.Tag = "Stopped"
        '
        'pbAnonym
        '
        Me.pbAnonym.BackColor = System.Drawing.Color.Transparent
        Me.pbAnonym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnonym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAnonym.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAnonym.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.check
        Me.pbAnonym.Location = New System.Drawing.Point(510, 66)
        Me.pbAnonym.Name = "pbAnonym"
        Me.pbAnonym.Size = New System.Drawing.Size(18, 18)
        Me.pbAnonym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnonym.TabIndex = 170
        Me.pbAnonym.TabStop = False
        Me.pbAnonym.Tag = "Stopped"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.turnon
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(10, 101)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(62, 19)
        Me.btnStart.TabIndex = 204
        Me.btnStart.Tag = "Find"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'gbSMS
        '
        Me.gbSMS.BackColor = System.Drawing.Color.Black
        Me.gbSMS.Controls.Add(Me.lblGSM)
        Me.gbSMS.Controls.Add(Me.btnStart)
        Me.gbSMS.Controls.Add(Me.pbAnonym)
        Me.gbSMS.Controls.Add(Me.pbAnn)
        Me.gbSMS.Controls.Add(Me.pbLogs)
        Me.gbSMS.Controls.Add(Me.Label6)
        Me.gbSMS.Controls.Add(Me.lblAnonymText)
        Me.gbSMS.Controls.Add(Me.Label3)
        Me.gbSMS.Controls.Add(Me.Label1)
        Me.gbSMS.Controls.Add(Me.lblAnn)
        Me.gbSMS.Controls.Add(Me.lblLogs)
        Me.gbSMS.Controls.Add(Me.PictureBox1)
        Me.gbSMS.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSMS.ForeColor = System.Drawing.Color.Gold
        Me.gbSMS.Location = New System.Drawing.Point(20, 349)
        Me.gbSMS.Name = "gbSMS"
        Me.gbSMS.Size = New System.Drawing.Size(538, 126)
        Me.gbSMS.TabIndex = 166
        Me.gbSMS.TabStop = False
        Me.gbSMS.Text = "PUPSACS provides SMS technology."
        '
        'lblGSM
        '
        Me.lblGSM.BackColor = System.Drawing.Color.Black
        Me.lblGSM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGSM.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSM.ForeColor = System.Drawing.Color.White
        Me.lblGSM.Location = New System.Drawing.Point(78, 101)
        Me.lblGSM.Name = "lblGSM"
        Me.lblGSM.Size = New System.Drawing.Size(454, 19)
        Me.lblGSM.TabIndex = 205
        Me.lblGSM.Text = "GSM Module is not active!"
        Me.lblGSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbLogs
        '
        Me.gbLogs.BackColor = System.Drawing.Color.Black
        Me.gbLogs.Controls.Add(Me.chkLogs)
        Me.gbLogs.Controls.Add(Me.btnVisitorLog)
        Me.gbLogs.Controls.Add(Me.btnFU)
        Me.gbLogs.Controls.Add(Me.btnSystemLog)
        Me.gbLogs.Controls.Add(Me.btnStudLog)
        Me.gbLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbLogs.Location = New System.Drawing.Point(486, 311)
        Me.gbLogs.Name = "gbLogs"
        Me.gbLogs.Size = New System.Drawing.Size(50, 21)
        Me.gbLogs.TabIndex = 218
        Me.gbLogs.TabStop = False
        Me.gbLogs.Text = "Logs"
        Me.gbLogs.Visible = False
        '
        'chkLogs
        '
        Me.chkLogs.AutoSize = True
        Me.chkLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkLogs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLogs.ForeColor = System.Drawing.Color.Gold
        Me.chkLogs.Location = New System.Drawing.Point(453, 12)
        Me.chkLogs.Name = "chkLogs"
        Me.chkLogs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLogs.Size = New System.Drawing.Size(77, 17)
        Me.chkLogs.TabIndex = 199
        Me.chkLogs.Text = "Pin Panel"
        Me.chkLogs.UseVisualStyleBackColor = True
        '
        'btnVisitorLog
        '
        Me.btnVisitorLog.BackColor = System.Drawing.Color.Transparent
        Me.btnVisitorLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVisitorLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisitorLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitorLog.ForeColor = System.Drawing.Color.White
        Me.btnVisitorLog.Location = New System.Drawing.Point(288, 72)
        Me.btnVisitorLog.Name = "btnVisitorLog"
        Me.btnVisitorLog.Size = New System.Drawing.Size(166, 36)
        Me.btnVisitorLog.TabIndex = 193
        Me.btnVisitorLog.Text = "Visitors Logs"
        Me.btnVisitorLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVisitorLog.UseVisualStyleBackColor = False
        '
        'btnFU
        '
        Me.btnFU.BackColor = System.Drawing.Color.Transparent
        Me.btnFU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFU.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFU.ForeColor = System.Drawing.Color.White
        Me.btnFU.Location = New System.Drawing.Point(288, 30)
        Me.btnFU.Name = "btnFU"
        Me.btnFU.Size = New System.Drawing.Size(166, 36)
        Me.btnFU.TabIndex = 191
        Me.btnFU.Text = "Faculty/Utility Monitoring"
        Me.btnFU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFU.UseVisualStyleBackColor = False
        '
        'btnSystemLog
        '
        Me.btnSystemLog.BackColor = System.Drawing.Color.Transparent
        Me.btnSystemLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystemLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSystemLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemLog.ForeColor = System.Drawing.Color.White
        Me.btnSystemLog.Location = New System.Drawing.Point(82, 72)
        Me.btnSystemLog.Name = "btnSystemLog"
        Me.btnSystemLog.Size = New System.Drawing.Size(166, 36)
        Me.btnSystemLog.TabIndex = 189
        Me.btnSystemLog.Text = "System Monitoring"
        Me.btnSystemLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSystemLog.UseVisualStyleBackColor = False
        '
        'btnStudLog
        '
        Me.btnStudLog.BackColor = System.Drawing.Color.Transparent
        Me.btnStudLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudLog.ForeColor = System.Drawing.Color.White
        Me.btnStudLog.Location = New System.Drawing.Point(82, 30)
        Me.btnStudLog.Name = "btnStudLog"
        Me.btnStudLog.Size = New System.Drawing.Size(166, 36)
        Me.btnStudLog.TabIndex = 188
        Me.btnStudLog.Text = "Student Monitoring"
        Me.btnStudLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudLog.UseVisualStyleBackColor = False
        '
        'txtAnn
        '
        Me.txtAnn.BackColor = System.Drawing.Color.White
        Me.txtAnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnn.ForeColor = System.Drawing.Color.Black
        Me.txtAnn.Location = New System.Drawing.Point(5, 9)
        Me.txtAnn.Multiline = True
        Me.txtAnn.Name = "txtAnn"
        Me.txtAnn.Size = New System.Drawing.Size(481, 72)
        Me.txtAnn.TabIndex = 219
        Me.txtAnn.Text = "----"
        '
        'gbEditAnn
        '
        Me.gbEditAnn.BackColor = System.Drawing.Color.Transparent
        Me.gbEditAnn.Controls.Add(Me.Label7)
        Me.gbEditAnn.Controls.Add(Me.txtAnn)
        Me.gbEditAnn.Controls.Add(Me.btnCancel)
        Me.gbEditAnn.Controls.Add(Me.btnEditAnn)
        Me.gbEditAnn.Location = New System.Drawing.Point(37, 147)
        Me.gbEditAnn.Name = "gbEditAnn"
        Me.gbEditAnn.Size = New System.Drawing.Size(78, 27)
        Me.gbEditAnn.TabIndex = 223
        Me.gbEditAnn.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(201, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 18)
        Me.Label7.TabIndex = 223
        Me.Label7.Text = "Press escape to cancel"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lShutdown
        '
        Me.lShutdown.BackColor = System.Drawing.Color.Transparent
        Me.lShutdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lShutdown.ForeColor = System.Drawing.Color.Red
        Me.lShutdown.Location = New System.Drawing.Point(6, 13)
        Me.lShutdown.Name = "lShutdown"
        Me.lShutdown.Size = New System.Drawing.Size(260, 48)
        Me.lShutdown.TabIndex = 229
        Me.lShutdown.Text = "System will now shutdown" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in 0 second(s)..."
        Me.lShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbShutdown
        '
        Me.gbShutdown.BackColor = System.Drawing.Color.Transparent
        Me.gbShutdown.Controls.Add(Me.lShutdown)
        Me.gbShutdown.Location = New System.Drawing.Point(93, 652)
        Me.gbShutdown.Name = "gbShutdown"
        Me.gbShutdown.Size = New System.Drawing.Size(272, 72)
        Me.gbShutdown.TabIndex = 230
        Me.gbShutdown.TabStop = False
        Me.gbShutdown.Visible = False
        '
        'frmMAIN
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 744)
        Me.ContextMenuStrip = Me.cmsMain
        Me.Controls.Add(Me.gbShutdown)
        Me.Controls.Add(Me.btnSMS_opt)
        Me.Controls.Add(Me.btnLogLV)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbRFIDSMS)
        Me.Controls.Add(Me.btnSettings_opt)
        Me.Controls.Add(Me.gbDateTime)
        Me.Controls.Add(Me.btnLogs_opt)
        Me.Controls.Add(Me.gbEditAnn)
        Me.Controls.Add(Me.btnRecord_opt)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.gbSMSTechnology)
        Me.Controls.Add(Me.lblEditAnn)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.gbRecords)
        Me.Controls.Add(Me.gbFindStud)
        Me.Controls.Add(Me.gbLogs)
        Me.Controls.Add(Me.gbPreviousLV)
        Me.Controls.Add(Me.btnFindStud)
        Me.Controls.Add(Me.gbSMS)
        Me.Controls.Add(Me.gbPrevious)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.gbChat)
        Me.Controls.Add(Me.lblAnnouncement)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.lblOPT)
        Me.Name = "frmMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Main Window"
        Me.gbPrevious.ResumeLayout(False)
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFindStud.ResumeLayout(False)
        Me.gbFindStud.PerformLayout()
        Me.gbPreviousLV.ResumeLayout(False)
        Me.gbPreviousLV.PerformLayout()
        Me.cmsLog.ResumeLayout(False)
        Me.cmsLV_Logs.ResumeLayout(False)
        Me.gbSMS_Noti.ResumeLayout(False)
        Me.gbSMS_Noti.PerformLayout()
        Me.gbRFID_Noti.ResumeLayout(False)
        Me.gbRFID_Noti.PerformLayout()
        Me.gbRecords.ResumeLayout(False)
        Me.gbRecords.PerformLayout()
        Me.gbChat.ResumeLayout(False)
        Me.gbChat.PerformLayout()
        Me.gbSMSTechnology.ResumeLayout(False)
        Me.gbSMSTechnology.PerformLayout()
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.gbRFIDSMS.ResumeLayout(False)
        Me.cmsMain.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDateTime.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnonym, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSMS.ResumeLayout(False)
        Me.gbLogs.ResumeLayout(False)
        Me.gbLogs.PerformLayout()
        Me.gbEditAnn.ResumeLayout(False)
        Me.gbEditAnn.PerformLayout()
        Me.gbShutdown.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents gbPrevious As System.Windows.Forms.GroupBox
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblDateTimeLog As System.Windows.Forms.Label
    Friend WithEvents lblDeptYrSc As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLogState As System.Windows.Forms.Label
    Friend WithEvents tmrDisplayLog As System.Windows.Forms.Timer
    Friend WithEvents btnFindStud As System.Windows.Forms.Button
    Friend WithEvents gbFindStud As System.Windows.Forms.GroupBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents gbPreviousLV As System.Windows.Forms.GroupBox
    Friend WithEvents chkPinLog As System.Windows.Forms.CheckBox
    Friend WithEvents LVlogs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrLV_animate As System.Windows.Forms.Timer
    Friend WithEvents gbSMS_Noti As System.Windows.Forms.GroupBox
    Friend WithEvents lblSMS_Noti As System.Windows.Forms.Label
    Friend WithEvents llblSMS As System.Windows.Forms.LinkLabel
    Friend WithEvents gbRFID_Noti As System.Windows.Forms.GroupBox
    Friend WithEvents llblRFID As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRFID_Noti As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents llblViewProfile As System.Windows.Forms.LinkLabel
    Friend WithEvents gbRecords As System.Windows.Forms.GroupBox
    Friend WithEvents btnFacultyUtily As System.Windows.Forms.Button
    Friend WithEvents btnStudList As System.Windows.Forms.Button
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Friend WithEvents btnParentList As System.Windows.Forms.Button
    Friend WithEvents gbChat As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfe As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents llblClearChat As System.Windows.Forms.LinkLabel
    Friend WithEvents llblHistory As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents llblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents gbSMSTechnology As System.Windows.Forms.GroupBox
    Friend WithEvents btnAccessSettings As System.Windows.Forms.Button
    Friend WithEvents gbSettings As System.Windows.Forms.GroupBox
    Friend WithEvents btnGSMModule As System.Windows.Forms.Button
    Friend WithEvents btnUserPrivilege As System.Windows.Forms.Button
    Friend WithEvents cmsLV_Logs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmViewStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEditStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmListLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrChat As System.Windows.Forms.Timer
    Friend WithEvents gbRFIDSMS As System.Windows.Forms.GroupBox
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmAnnouncement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCreateMessage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSendMessage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblOPT As System.Windows.Forms.Label
    Friend WithEvents btnLogs_opt As System.Windows.Forms.Button
    Friend WithEvents btnSettings_opt As System.Windows.Forms.Button
    Friend WithEvents btnRecord_opt As System.Windows.Forms.Button
    Friend WithEvents chkSMS As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecord As System.Windows.Forms.CheckBox
    Friend WithEvents chkSettings As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents llblFilterLog As System.Windows.Forms.LinkLabel
    Friend WithEvents cmsLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmLogIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSystemPreferences As System.Windows.Forms.Button
    Friend WithEvents btnChangeDT As System.Windows.Forms.Button
    Friend WithEvents btnBackUpRestore As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents btnLogLV As System.Windows.Forms.Button
    Friend WithEvents lblAnnouncement As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents gbDateTime As System.Windows.Forms.GroupBox
    Friend WithEvents tsmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAnonymText As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbLogs As System.Windows.Forms.PictureBox
    Friend WithEvents pbAnn As System.Windows.Forms.PictureBox
    Friend WithEvents pbAnonym As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents gbSMS As System.Windows.Forms.GroupBox
    Friend WithEvents lblGSM As System.Windows.Forms.Label
    Friend WithEvents tsmViewStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSMSMessages As System.Windows.Forms.Button
    Friend WithEvents btnExpired As System.Windows.Forms.Button
    Friend WithEvents btnRecordArchive As System.Windows.Forms.Button
    Friend WithEvents gbLogs As System.Windows.Forms.GroupBox
    Friend WithEvents chkLogs As System.Windows.Forms.CheckBox
    Friend WithEvents btnVisitorLog As System.Windows.Forms.Button
    Friend WithEvents btnFU As System.Windows.Forms.Button
    Friend WithEvents btnSystemLog As System.Windows.Forms.Button
    Friend WithEvents btnStudLog As System.Windows.Forms.Button
    Friend WithEvents btnSavedMessages As System.Windows.Forms.Button
    Friend WithEvents btnReceivedMessages As System.Windows.Forms.Button
    Friend WithEvents txtAnn As System.Windows.Forms.TextBox
    Friend WithEvents btnEditAnn As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gbEditAnn As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSMS_opt As System.Windows.Forms.Button
    Friend WithEvents tsmChat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblEditAnn As System.Windows.Forms.Label
    Friend WithEvents NavigateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSystemUserAct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmUpdateMyProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDeleteUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmListUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDisconnectUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSTechnologyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGSMModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmReceived As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmQueue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSaved As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExpired As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmStudLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmStudList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmParents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lShutdown As System.Windows.Forms.Label
    Friend WithEvents gbShutdown As System.Windows.Forms.GroupBox
End Class
