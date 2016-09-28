<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreferences))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkCShutdownDefault = New System.Windows.Forms.CheckBox
        Me.btnSet = New System.Windows.Forms.Button
        Me.llblShutdown = New System.Windows.Forms.LinkLabel
        Me.dtpClientShtdown = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.pbSystemShutdown = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTimeOut = New System.Windows.Forms.ComboBox
        Me.cmbPort = New System.Windows.Forms.ComboBox
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkPass = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtUPass = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUPass2 = New System.Windows.Forms.TextBox
        Me.txtUPass1 = New System.Windows.Forms.TextBox
        Me.txtUUserName = New System.Windows.Forms.TextBox
        Me.lblUUserID = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gbSystemUsers = New System.Windows.Forms.GroupBox
        Me.gbUsersList = New System.Windows.Forms.GroupBox
        Me.lblURecordCount = New System.Windows.Forms.Label
        Me.btnUpdateUser = New System.Windows.Forms.Button
        Me.btnShowAccess = New System.Windows.Forms.Button
        Me.LVUsers = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.gbAddUser = New System.Windows.Forms.GroupBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtANumber = New System.Windows.Forms.TextBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.chkAOperate = New System.Windows.Forms.CheckBox
        Me.chkASearch = New System.Windows.Forms.CheckBox
        Me.chkAView = New System.Windows.Forms.CheckBox
        Me.chkAShutdown = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtAPass2 = New System.Windows.Forms.TextBox
        Me.txtAPass1 = New System.Windows.Forms.TextBox
        Me.txtAUserName = New System.Windows.Forms.TextBox
        Me.chkALocked = New System.Windows.Forms.CheckBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.cmbUserType = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblAUserID = New System.Windows.Forms.Label
        Me.txtALName = New System.Windows.Forms.TextBox
        Me.txtAFName = New System.Windows.Forms.TextBox
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.btnListUsers = New System.Windows.Forms.Button
        Me.btnUpdateMy = New System.Windows.Forms.Button
        Me.lblSystemUsers = New System.Windows.Forms.Label
        Me.gbUpdateUser = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtUNumber = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtUFName = New System.Windows.Forms.TextBox
        Me.txtULName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnGeneral = New System.Windows.Forms.Button
        Me.btnRecords = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSystemUsers = New System.Windows.Forms.Button
        Me.btnSMSTechnology = New System.Windows.Forms.Button
        Me.btnClient = New System.Windows.Forms.Button
        Me.gbSMSTechnology = New System.Windows.Forms.GroupBox
        Me.lblMessageCount = New System.Windows.Forms.Label
        Me.btnAdvanceSMS = New System.Windows.Forms.Button
        Me.gbMessage = New System.Windows.Forms.GroupBox
        Me.LVmsg = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.btnGSMModule = New System.Windows.Forms.Button
        Me.btnQueued = New System.Windows.Forms.Button
        Me.btnSaved = New System.Windows.Forms.Button
        Me.btnSent = New System.Windows.Forms.Button
        Me.btnReceived = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.gbGSMModule = New System.Windows.Forms.GroupBox
        Me.btnSMSCommands = New System.Windows.Forms.Button
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.cmbValidity = New System.Windows.Forms.ComboBox
        Me.txtSendDelay = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbStopBits = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.llblDetect = New System.Windows.Forms.LinkLabel
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.btnGSMSet = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.lblSMSTechnology = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.gbGeneral = New System.Windows.Forms.GroupBox
        Me.lblGNext = New System.Windows.Forms.Label
        Me.lblGPrev = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnGNext = New System.Windows.Forms.Button
        Me.gbG1 = New System.Windows.Forms.GroupBox
        Me.chkSounds = New System.Windows.Forms.CheckBox
        Me.chkGShutdownDisconnected = New System.Windows.Forms.CheckBox
        Me.rbLogAsAdmin = New System.Windows.Forms.RadioButton
        Me.rbShowLogin = New System.Windows.Forms.RadioButton
        Me.chkGAutoStartClient = New System.Windows.Forms.CheckBox
        Me.chkGStartSend = New System.Windows.Forms.CheckBox
        Me.chkGGSMDetect = New System.Windows.Forms.CheckBox
        Me.chkGSplash = New System.Windows.Forms.CheckBox
        Me.btnGPrevious = New System.Windows.Forms.Button
        Me.btnGApply = New System.Windows.Forms.Button
        Me.btnDefaultGeneral = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me.llblPUP = New System.Windows.Forms.LinkLabel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.gbRecords = New System.Windows.Forms.GroupBox
        Me.btnBIN = New System.Windows.Forms.Button
        Me.lblRecordCount = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnStudentList = New System.Windows.Forms.Button
        Me.btnAddDept = New System.Windows.Forms.Button
        Me.btnEncodeStud = New System.Windows.Forms.Button
        Me.btnSystem = New System.Windows.Forms.Button
        Me.btnStudent = New System.Windows.Forms.Button
        Me.lblRecords = New System.Windows.Forms.Label
        Me.gbRStudSystem = New System.Windows.Forms.GroupBox
        Me.lblSTip = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.txtRSearch = New System.Windows.Forms.TextBox
        Me.LVStud = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.gbClient = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.btnShowGuard = New System.Windows.Forms.Button
        Me.GroupB = New System.Windows.Forms.GroupBox
        Me.lblClient = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.tmrUpdateMSG = New System.Windows.Forms.Timer(Me.components)
        Me.ttOption = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbSystemShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSystemUsers.SuspendLayout()
        Me.gbUsersList.SuspendLayout()
        Me.gbAddUser.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbUpdateUser.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbSMSTechnology.SuspendLayout()
        Me.gbMessage.SuspendLayout()
        Me.gbGSMModule.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGeneral.SuspendLayout()
        Me.gbG1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRecords.SuspendLayout()
        Me.gbRStudSystem.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClient.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupB.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.chkCShutdownDefault)
        Me.GroupBox1.Controls.Add(Me.btnSet)
        Me.GroupBox1.Controls.Add(Me.llblShutdown)
        Me.GroupBox1.Controls.Add(Me.dtpClientShtdown)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(97, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkCShutdownDefault
        '
        Me.chkCShutdownDefault.AutoSize = True
        Me.chkCShutdownDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCShutdownDefault.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCShutdownDefault.ForeColor = System.Drawing.Color.Gray
        Me.chkCShutdownDefault.Location = New System.Drawing.Point(9, 120)
        Me.chkCShutdownDefault.Name = "chkCShutdownDefault"
        Me.chkCShutdownDefault.Size = New System.Drawing.Size(181, 18)
        Me.chkCShutdownDefault.TabIndex = 6
        Me.chkCShutdownDefault.Text = "Set as default shutdown"
        Me.chkCShutdownDefault.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.White
        Me.btnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.Black
        Me.btnSet.Location = New System.Drawing.Point(252, 109)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(109, 29)
        Me.btnSet.TabIndex = 37
        Me.btnSet.Text = "&Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'llblShutdown
        '
        Me.llblShutdown.AutoSize = True
        Me.llblShutdown.LinkColor = System.Drawing.Color.Red
        Me.llblShutdown.Location = New System.Drawing.Point(20, 66)
        Me.llblShutdown.Name = "llblShutdown"
        Me.llblShutdown.Size = New System.Drawing.Size(107, 14)
        Me.llblShutdown.TabIndex = 6
        Me.llblShutdown.TabStop = True
        Me.llblShutdown.Text = "Shutdown Now"
        '
        'dtpClientShtdown
        '
        Me.dtpClientShtdown.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClientShtdown.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpClientShtdown.Location = New System.Drawing.Point(251, 16)
        Me.dtpClientShtdown.Name = "dtpClientShtdown"
        Me.dtpClientShtdown.Size = New System.Drawing.Size(119, 26)
        Me.dtpClientShtdown.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 41)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "The Client System will shutdown @"
        '
        'pbSystemShutdown
        '
        Me.pbSystemShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSystemShutdown.Image = CType(resources.GetObject("pbSystemShutdown.Image"), System.Drawing.Image)
        Me.pbSystemShutdown.Location = New System.Drawing.Point(12, 47)
        Me.pbSystemShutdown.Name = "pbSystemShutdown"
        Me.pbSystemShutdown.Size = New System.Drawing.Size(68, 113)
        Me.pbSystemShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSystemShutdown.TabIndex = 4
        Me.pbSystemShutdown.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(40, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time out period:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(40, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baud Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(40, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comm Port:"
        '
        'cmbTimeOut
        '
        Me.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeOut.FormattingEnabled = True
        Me.cmbTimeOut.Items.AddRange(New Object() {"150", "300", "600", "900", "1200", "1500", "1800", "2000"})
        Me.cmbTimeOut.Location = New System.Drawing.Point(169, 66)
        Me.cmbTimeOut.Name = "cmbTimeOut"
        Me.cmbTimeOut.Size = New System.Drawing.Size(156, 22)
        Me.cmbTimeOut.TabIndex = 6
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(169, 14)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(156, 22)
        Me.cmbPort.TabIndex = 5
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaudRate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"9600", "19200", "3800", "57600", "115200"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(169, 40)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(156, 22)
        Me.cmbBaudRate.TabIndex = 4
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = CType(resources.GetObject("pbAnnouncement.Image"), System.Drawing.Image)
        Me.pbAnnouncement.Location = New System.Drawing.Point(22, 16)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(51, 41)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 23
        Me.pbAnnouncement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(82, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "System Preferences"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(721, 50)
        Me.Label7.TabIndex = 22
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.BackColor = System.Drawing.Color.Transparent
        Me.chkPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkPass.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.ForeColor = System.Drawing.Color.White
        Me.chkPass.Location = New System.Drawing.Point(13, 150)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(128, 17)
        Me.chkPass.TabIndex = 34
        Me.chkPass.Text = "Change password"
        Me.chkPass.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtUPass)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtUPass2)
        Me.GroupBox4.Controls.Add(Me.txtUPass1)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox4.Location = New System.Drawing.Point(8, 163)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(386, 96)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        '
        'txtUPass
        '
        Me.txtUPass.Enabled = False
        Me.txtUPass.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPass.ForeColor = System.Drawing.Color.Black
        Me.txtUPass.Location = New System.Drawing.Point(178, 15)
        Me.txtUPass.Name = "txtUPass"
        Me.txtUPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtUPass.Size = New System.Drawing.Size(191, 21)
        Me.txtUPass.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(50, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "*Old Password:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(43, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "*New Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(22, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "*Re-type Password:"
        '
        'txtUPass2
        '
        Me.txtUPass2.Enabled = False
        Me.txtUPass2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPass2.ForeColor = System.Drawing.Color.Black
        Me.txtUPass2.Location = New System.Drawing.Point(178, 68)
        Me.txtUPass2.Name = "txtUPass2"
        Me.txtUPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtUPass2.Size = New System.Drawing.Size(191, 21)
        Me.txtUPass2.TabIndex = 10
        '
        'txtUPass1
        '
        Me.txtUPass1.Enabled = False
        Me.txtUPass1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPass1.ForeColor = System.Drawing.Color.Black
        Me.txtUPass1.Location = New System.Drawing.Point(178, 41)
        Me.txtUPass1.Name = "txtUPass1"
        Me.txtUPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtUPass1.Size = New System.Drawing.Size(191, 21)
        Me.txtUPass1.TabIndex = 10
        '
        'txtUUserName
        '
        Me.txtUUserName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUUserName.ForeColor = System.Drawing.Color.Gray
        Me.txtUUserName.Location = New System.Drawing.Point(121, 15)
        Me.txtUUserName.Name = "txtUUserName"
        Me.txtUUserName.Size = New System.Drawing.Size(191, 21)
        Me.txtUUserName.TabIndex = 32
        Me.txtUUserName.Text = "User name"
        '
        'lblUUserID
        '
        Me.lblUUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUUserID.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUUserID.ForeColor = System.Drawing.Color.White
        Me.lblUUserID.Location = New System.Drawing.Point(233, 15)
        Me.lblUUserID.Name = "lblUUserID"
        Me.lblUUserID.Size = New System.Drawing.Size(161, 23)
        Me.lblUUserID.TabIndex = 31
        Me.lblUUserID.Text = "CAMPUSU-0000"
        Me.lblUUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(37, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "User Name:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 298)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'gbSystemUsers
        '
        Me.gbSystemUsers.BackColor = System.Drawing.Color.Transparent
        Me.gbSystemUsers.Controls.Add(Me.gbUsersList)
        Me.gbSystemUsers.Controls.Add(Me.gbAddUser)
        Me.gbSystemUsers.Controls.Add(Me.btnAddUser)
        Me.gbSystemUsers.Controls.Add(Me.btnListUsers)
        Me.gbSystemUsers.Controls.Add(Me.btnUpdateMy)
        Me.gbSystemUsers.Controls.Add(Me.lblSystemUsers)
        Me.gbSystemUsers.Controls.Add(Me.gbUpdateUser)
        Me.gbSystemUsers.Controls.Add(Me.PictureBox2)
        Me.gbSystemUsers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSystemUsers.ForeColor = System.Drawing.Color.White
        Me.gbSystemUsers.Location = New System.Drawing.Point(743, 121)
        Me.gbSystemUsers.Name = "gbSystemUsers"
        Me.gbSystemUsers.Size = New System.Drawing.Size(494, 55)
        Me.gbSystemUsers.TabIndex = 36
        Me.gbSystemUsers.TabStop = False
        Me.gbSystemUsers.Visible = False
        '
        'gbUsersList
        '
        Me.gbUsersList.Controls.Add(Me.lblURecordCount)
        Me.gbUsersList.Controls.Add(Me.btnUpdateUser)
        Me.gbUsersList.Controls.Add(Me.btnShowAccess)
        Me.gbUsersList.Controls.Add(Me.LVUsers)
        Me.gbUsersList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUsersList.Location = New System.Drawing.Point(85, 49)
        Me.gbUsersList.Name = "gbUsersList"
        Me.gbUsersList.Size = New System.Drawing.Size(400, 311)
        Me.gbUsersList.TabIndex = 43
        Me.gbUsersList.TabStop = False
        '
        'lblURecordCount
        '
        Me.lblURecordCount.AutoSize = True
        Me.lblURecordCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblURecordCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblURecordCount.Location = New System.Drawing.Point(6, 280)
        Me.lblURecordCount.Name = "lblURecordCount"
        Me.lblURecordCount.Size = New System.Drawing.Size(98, 13)
        Me.lblURecordCount.TabIndex = 44
        Me.lblURecordCount.Text = "Record count: 0"
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.White
        Me.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateUser.Location = New System.Drawing.Point(289, 272)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(102, 29)
        Me.btnUpdateUser.TabIndex = 43
        Me.btnUpdateUser.Text = "&Update Details"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'btnShowAccess
        '
        Me.btnShowAccess.BackColor = System.Drawing.Color.White
        Me.btnShowAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAccess.ForeColor = System.Drawing.Color.Black
        Me.btnShowAccess.Location = New System.Drawing.Point(144, 272)
        Me.btnShowAccess.Name = "btnShowAccess"
        Me.btnShowAccess.Size = New System.Drawing.Size(144, 29)
        Me.btnShowAccess.TabIndex = 42
        Me.btnShowAccess.Text = "&Show Access Settings..."
        Me.btnShowAccess.UseVisualStyleBackColor = False
        '
        'LVUsers
        '
        Me.LVUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LVUsers.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVUsers.FullRowSelect = True
        Me.LVUsers.GridLines = True
        Me.LVUsers.Location = New System.Drawing.Point(8, 16)
        Me.LVUsers.MultiSelect = False
        Me.LVUsers.Name = "LVUsers"
        Me.LVUsers.Size = New System.Drawing.Size(386, 254)
        Me.LVUsers.TabIndex = 1
        Me.LVUsers.UseCompatibleStateImageBehavior = False
        Me.LVUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User ID"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "User Name"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "User Type"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'gbAddUser
        '
        Me.gbAddUser.Controls.Add(Me.Label33)
        Me.gbAddUser.Controls.Add(Me.txtANumber)
        Me.gbAddUser.Controls.Add(Me.GroupBox9)
        Me.gbAddUser.Controls.Add(Me.GroupBox8)
        Me.gbAddUser.Controls.Add(Me.Label29)
        Me.gbAddUser.Controls.Add(Me.cmbUserType)
        Me.gbAddUser.Controls.Add(Me.Label27)
        Me.gbAddUser.Controls.Add(Me.Label28)
        Me.gbAddUser.Controls.Add(Me.lblAUserID)
        Me.gbAddUser.Controls.Add(Me.txtALName)
        Me.gbAddUser.Controls.Add(Me.txtAFName)
        Me.gbAddUser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAddUser.Location = New System.Drawing.Point(500, 20)
        Me.gbAddUser.Name = "gbAddUser"
        Me.gbAddUser.Size = New System.Drawing.Size(400, 46)
        Me.gbAddUser.TabIndex = 42
        Me.gbAddUser.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DimGray
        Me.Label33.Location = New System.Drawing.Point(144, 19)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 44
        Me.Label33.Text = "*User Type:"
        '
        'txtANumber
        '
        Me.txtANumber.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtANumber.ForeColor = System.Drawing.Color.Gray
        Me.txtANumber.Location = New System.Drawing.Point(222, 95)
        Me.txtANumber.Name = "txtANumber"
        Me.txtANumber.Size = New System.Drawing.Size(170, 21)
        Me.txtANumber.TabIndex = 160
        Me.txtANumber.Text = "Number"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkAOperate)
        Me.GroupBox9.Controls.Add(Me.chkASearch)
        Me.GroupBox9.Controls.Add(Me.chkAView)
        Me.GroupBox9.Controls.Add(Me.chkAShutdown)
        Me.GroupBox9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(6, 244)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(388, 61)
        Me.GroupBox9.TabIndex = 159
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Privileges"
        '
        'chkAOperate
        '
        Me.chkAOperate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAOperate.Location = New System.Drawing.Point(190, 39)
        Me.chkAOperate.Name = "chkAOperate"
        Me.chkAOperate.Size = New System.Drawing.Size(188, 17)
        Me.chkAOperate.TabIndex = 44
        Me.chkAOperate.Text = "Operate Verification Window"
        Me.chkAOperate.UseVisualStyleBackColor = True
        '
        'chkASearch
        '
        Me.chkASearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkASearch.Location = New System.Drawing.Point(10, 16)
        Me.chkASearch.Name = "chkASearch"
        Me.chkASearch.Size = New System.Drawing.Size(174, 17)
        Me.chkASearch.TabIndex = 41
        Me.chkASearch.Text = "Search Student logs"
        Me.chkASearch.UseVisualStyleBackColor = True
        '
        'chkAView
        '
        Me.chkAView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAView.Location = New System.Drawing.Point(190, 16)
        Me.chkAView.Name = "chkAView"
        Me.chkAView.Size = New System.Drawing.Size(188, 16)
        Me.chkAView.TabIndex = 42
        Me.chkAView.Text = "View Student Information"
        Me.chkAView.UseVisualStyleBackColor = True
        '
        'chkAShutdown
        '
        Me.chkAShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAShutdown.Location = New System.Drawing.Point(10, 38)
        Me.chkAShutdown.Name = "chkAShutdown"
        Me.chkAShutdown.Size = New System.Drawing.Size(174, 18)
        Me.chkAShutdown.TabIndex = 43
        Me.chkAShutdown.Text = "Shutdown Client System"
        Me.chkAShutdown.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.txtAPass2)
        Me.GroupBox8.Controls.Add(Me.txtAPass1)
        Me.GroupBox8.Controls.Add(Me.txtAUserName)
        Me.GroupBox8.Controls.Add(Me.chkALocked)
        Me.GroupBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(6, 122)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(387, 116)
        Me.GroupBox8.TabIndex = 42
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "This will use everytime you log in"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DimGray
        Me.Label32.Location = New System.Drawing.Point(7, 85)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(94, 13)
        Me.Label32.TabIndex = 43
        Me.Label32.Text = "*Re-type Pass:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(7, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(73, 13)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "*Password:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DimGray
        Me.Label30.Location = New System.Drawing.Point(7, 29)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 13)
        Me.Label30.TabIndex = 41
        Me.Label30.Text = "*User Name:"
        '
        'txtAPass2
        '
        Me.txtAPass2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPass2.ForeColor = System.Drawing.Color.Gray
        Me.txtAPass2.Location = New System.Drawing.Point(113, 81)
        Me.txtAPass2.Name = "txtAPass2"
        Me.txtAPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtAPass2.Size = New System.Drawing.Size(173, 22)
        Me.txtAPass2.TabIndex = 36
        Me.txtAPass2.Text = "Password2"
        Me.txtAPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAPass1
        '
        Me.txtAPass1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPass1.ForeColor = System.Drawing.Color.Gray
        Me.txtAPass1.Location = New System.Drawing.Point(113, 53)
        Me.txtAPass1.Name = "txtAPass1"
        Me.txtAPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtAPass1.Size = New System.Drawing.Size(173, 22)
        Me.txtAPass1.TabIndex = 35
        Me.txtAPass1.Text = "Password1"
        Me.txtAPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAUserName
        '
        Me.txtAUserName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAUserName.ForeColor = System.Drawing.Color.Gray
        Me.txtAUserName.Location = New System.Drawing.Point(113, 25)
        Me.txtAUserName.Name = "txtAUserName"
        Me.txtAUserName.Size = New System.Drawing.Size(173, 22)
        Me.txtAUserName.TabIndex = 34
        Me.txtAUserName.Text = "User name"
        Me.txtAUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkALocked
        '
        Me.chkALocked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkALocked.Location = New System.Drawing.Point(299, 85)
        Me.chkALocked.Name = "chkALocked"
        Me.chkALocked.Size = New System.Drawing.Size(66, 17)
        Me.chkALocked.TabIndex = 40
        Me.chkALocked.Text = "Locked"
        Me.chkALocked.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(196, 42)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 13)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "*Last Name"
        '
        'cmbUserType
        '
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Client Manager"})
        Me.cmbUserType.Location = New System.Drawing.Point(230, 16)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(162, 22)
        Me.cmbUserType.TabIndex = 39
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(134, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 13)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Cellphone #:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DimGray
        Me.Label28.Location = New System.Drawing.Point(9, 42)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 13)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "*First Name"
        '
        'lblAUserID
        '
        Me.lblAUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblAUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAUserID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAUserID.ForeColor = System.Drawing.Color.White
        Me.lblAUserID.Location = New System.Drawing.Point(6, 15)
        Me.lblAUserID.Name = "lblAUserID"
        Me.lblAUserID.Size = New System.Drawing.Size(128, 22)
        Me.lblAUserID.TabIndex = 32
        Me.lblAUserID.Text = "CAMPUSU-0000"
        Me.lblAUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtALName
        '
        Me.txtALName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtALName.ForeColor = System.Drawing.Color.Gray
        Me.txtALName.Location = New System.Drawing.Point(210, 63)
        Me.txtALName.Name = "txtALName"
        Me.txtALName.Size = New System.Drawing.Size(182, 21)
        Me.txtALName.TabIndex = 38
        Me.txtALName.Text = "Last"
        '
        'txtAFName
        '
        Me.txtAFName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAFName.ForeColor = System.Drawing.Color.Gray
        Me.txtAFName.Location = New System.Drawing.Point(19, 63)
        Me.txtAFName.Name = "txtAFName"
        Me.txtAFName.Size = New System.Drawing.Size(182, 21)
        Me.txtAFName.TabIndex = 37
        Me.txtAFName.Text = "First"
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.White
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.Black
        Me.btnAddUser.Location = New System.Drawing.Point(345, 366)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(121, 29)
        Me.btnAddUser.TabIndex = 41
        Me.btnAddUser.Text = "&Add User"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnListUsers
        '
        Me.btnListUsers.BackColor = System.Drawing.Color.White
        Me.btnListUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListUsers.ForeColor = System.Drawing.Color.Black
        Me.btnListUsers.Location = New System.Drawing.Point(99, 366)
        Me.btnListUsers.Name = "btnListUsers"
        Me.btnListUsers.Size = New System.Drawing.Size(121, 29)
        Me.btnListUsers.TabIndex = 40
        Me.btnListUsers.Text = "&List Users"
        Me.btnListUsers.UseVisualStyleBackColor = False
        '
        'btnUpdateMy
        '
        Me.btnUpdateMy.BackColor = System.Drawing.Color.White
        Me.btnUpdateMy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateMy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateMy.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateMy.Location = New System.Drawing.Point(223, 366)
        Me.btnUpdateMy.Name = "btnUpdateMy"
        Me.btnUpdateMy.Size = New System.Drawing.Size(121, 29)
        Me.btnUpdateMy.TabIndex = 39
        Me.btnUpdateMy.Text = "&Update My Profile"
        Me.btnUpdateMy.UseVisualStyleBackColor = False
        '
        'lblSystemUsers
        '
        Me.lblSystemUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSystemUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSystemUsers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemUsers.ForeColor = System.Drawing.Color.White
        Me.lblSystemUsers.Location = New System.Drawing.Point(3, 10)
        Me.lblSystemUsers.Name = "lblSystemUsers"
        Me.lblSystemUsers.Size = New System.Drawing.Size(486, 38)
        Me.lblSystemUsers.TabIndex = 36
        Me.lblSystemUsers.Text = "System Users"
        Me.lblSystemUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbUpdateUser
        '
        Me.gbUpdateUser.Controls.Add(Me.GroupBox5)
        Me.gbUpdateUser.Controls.Add(Me.Label13)
        Me.gbUpdateUser.Controls.Add(Me.GroupBox10)
        Me.gbUpdateUser.Controls.Add(Me.GroupBox2)
        Me.gbUpdateUser.Controls.Add(Me.lblUUserID)
        Me.gbUpdateUser.Controls.Add(Me.chkPass)
        Me.gbUpdateUser.Controls.Add(Me.GroupBox4)
        Me.gbUpdateUser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUpdateUser.Location = New System.Drawing.Point(500, 73)
        Me.gbUpdateUser.Name = "gbUpdateUser"
        Me.gbUpdateUser.Size = New System.Drawing.Size(400, 43)
        Me.gbUpdateUser.TabIndex = 38
        Me.gbUpdateUser.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtUNumber)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 259)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(386, 45)
        Me.GroupBox5.TabIndex = 161
        Me.GroupBox5.TabStop = False
        '
        'txtUNumber
        '
        Me.txtUNumber.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUNumber.ForeColor = System.Drawing.Color.Gray
        Me.txtUNumber.Location = New System.Drawing.Point(162, 13)
        Me.txtUNumber.Name = "txtUNumber"
        Me.txtUNumber.Size = New System.Drawing.Size(170, 21)
        Me.txtUNumber.TabIndex = 163
        Me.txtUNumber.Text = "Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(74, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Cellphone #:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(167, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "User ID:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.txtUFName)
        Me.GroupBox10.Controls.Add(Me.txtULName)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(386, 58)
        Me.GroupBox10.TabIndex = 159
        Me.GroupBox10.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DimGray
        Me.Label34.Location = New System.Drawing.Point(189, 11)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 13)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "*Last Name"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DimGray
        Me.Label35.Location = New System.Drawing.Point(7, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "*First Name"
        '
        'txtUFName
        '
        Me.txtUFName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUFName.ForeColor = System.Drawing.Color.Gray
        Me.txtUFName.Location = New System.Drawing.Point(17, 30)
        Me.txtUFName.Name = "txtUFName"
        Me.txtUFName.Size = New System.Drawing.Size(176, 21)
        Me.txtUFName.TabIndex = 42
        Me.txtUFName.Text = "First"
        '
        'txtULName
        '
        Me.txtULName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtULName.ForeColor = System.Drawing.Color.Gray
        Me.txtULName.Location = New System.Drawing.Point(200, 30)
        Me.txtULName.Name = "txtULName"
        Me.txtULName.Size = New System.Drawing.Size(176, 21)
        Me.txtULName.TabIndex = 43
        Me.txtULName.Text = "Last"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtUUserName)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 45)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.btnGeneral)
        Me.GroupBox6.Controls.Add(Me.btnRecords)
        Me.GroupBox6.Controls.Add(Me.btnExit)
        Me.GroupBox6.Controls.Add(Me.btnSystemUsers)
        Me.GroupBox6.Controls.Add(Me.btnSMSTechnology)
        Me.GroupBox6.Controls.Add(Me.btnClient)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 107)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(203, 265)
        Me.GroupBox6.TabIndex = 37
        Me.GroupBox6.TabStop = False
        '
        'btnGeneral
        '
        Me.btnGeneral.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGeneral.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.ForeColor = System.Drawing.Color.Gold
        Me.btnGeneral.Location = New System.Drawing.Point(8, 20)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(185, 30)
        Me.btnGeneral.TabIndex = 161
        Me.btnGeneral.Text = "General"
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecords.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.Gold
        Me.btnRecords.Location = New System.Drawing.Point(8, 157)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(185, 30)
        Me.btnRecords.TabIndex = 155
        Me.btnRecords.Text = "Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Location = New System.Drawing.Point(8, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(185, 30)
        Me.btnExit.TabIndex = 153
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSystemUsers
        '
        Me.btnSystemUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnSystemUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSystemUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystemUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSystemUsers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemUsers.ForeColor = System.Drawing.Color.Gold
        Me.btnSystemUsers.Location = New System.Drawing.Point(8, 55)
        Me.btnSystemUsers.Name = "btnSystemUsers"
        Me.btnSystemUsers.Size = New System.Drawing.Size(185, 30)
        Me.btnSystemUsers.TabIndex = 154
        Me.btnSystemUsers.Text = "System Users"
        Me.btnSystemUsers.UseVisualStyleBackColor = False
        '
        'btnSMSTechnology
        '
        Me.btnSMSTechnology.BackColor = System.Drawing.Color.Transparent
        Me.btnSMSTechnology.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSMSTechnology.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMSTechnology.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSMSTechnology.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSMSTechnology.ForeColor = System.Drawing.Color.Gold
        Me.btnSMSTechnology.Location = New System.Drawing.Point(8, 89)
        Me.btnSMSTechnology.Name = "btnSMSTechnology"
        Me.btnSMSTechnology.Size = New System.Drawing.Size(185, 30)
        Me.btnSMSTechnology.TabIndex = 156
        Me.btnSMSTechnology.Text = "SMS Technology"
        Me.btnSMSTechnology.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.Transparent
        Me.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClient.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.Gold
        Me.btnClient.Location = New System.Drawing.Point(8, 123)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(185, 30)
        Me.btnClient.TabIndex = 157
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'gbSMSTechnology
        '
        Me.gbSMSTechnology.BackColor = System.Drawing.Color.Transparent
        Me.gbSMSTechnology.Controls.Add(Me.lblMessageCount)
        Me.gbSMSTechnology.Controls.Add(Me.btnAdvanceSMS)
        Me.gbSMSTechnology.Controls.Add(Me.gbMessage)
        Me.gbSMSTechnology.Controls.Add(Me.btnGSMModule)
        Me.gbSMSTechnology.Controls.Add(Me.btnQueued)
        Me.gbSMSTechnology.Controls.Add(Me.btnSaved)
        Me.gbSMSTechnology.Controls.Add(Me.btnSent)
        Me.gbSMSTechnology.Controls.Add(Me.btnReceived)
        Me.gbSMSTechnology.Controls.Add(Me.btnCreate)
        Me.gbSMSTechnology.Controls.Add(Me.gbGSMModule)
        Me.gbSMSTechnology.Controls.Add(Me.lblSMSTechnology)
        Me.gbSMSTechnology.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSMSTechnology.ForeColor = System.Drawing.Color.White
        Me.gbSMSTechnology.Location = New System.Drawing.Point(741, 176)
        Me.gbSMSTechnology.Name = "gbSMSTechnology"
        Me.gbSMSTechnology.Size = New System.Drawing.Size(491, 51)
        Me.gbSMSTechnology.TabIndex = 39
        Me.gbSMSTechnology.TabStop = False
        Me.gbSMSTechnology.Visible = False
        '
        'lblMessageCount
        '
        Me.lblMessageCount.AutoSize = True
        Me.lblMessageCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblMessageCount.Location = New System.Drawing.Point(89, 379)
        Me.lblMessageCount.Name = "lblMessageCount"
        Me.lblMessageCount.Size = New System.Drawing.Size(107, 13)
        Me.lblMessageCount.TabIndex = 162
        Me.lblMessageCount.Text = "Message count: 0"
        '
        'btnAdvanceSMS
        '
        Me.btnAdvanceSMS.BackColor = System.Drawing.Color.White
        Me.btnAdvanceSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdvanceSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanceSMS.ForeColor = System.Drawing.Color.Black
        Me.btnAdvanceSMS.Location = New System.Drawing.Point(372, 370)
        Me.btnAdvanceSMS.Name = "btnAdvanceSMS"
        Me.btnAdvanceSMS.Size = New System.Drawing.Size(106, 28)
        Me.btnAdvanceSMS.TabIndex = 150
        Me.btnAdvanceSMS.Text = "&Advanced >>"
        Me.btnAdvanceSMS.UseVisualStyleBackColor = False
        '
        'gbMessage
        '
        Me.gbMessage.Controls.Add(Me.LVmsg)
        Me.gbMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMessage.Location = New System.Drawing.Point(86, 57)
        Me.gbMessage.Name = "gbMessage"
        Me.gbMessage.Size = New System.Drawing.Size(400, 307)
        Me.gbMessage.TabIndex = 161
        Me.gbMessage.TabStop = False
        Me.gbMessage.Text = "Messages"
        '
        'LVmsg
        '
        Me.LVmsg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.LVmsg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVmsg.FullRowSelect = True
        Me.LVmsg.GridLines = True
        Me.LVmsg.Location = New System.Drawing.Point(6, 20)
        Me.LVmsg.MultiSelect = False
        Me.LVmsg.Name = "LVmsg"
        Me.LVmsg.Size = New System.Drawing.Size(389, 281)
        Me.LVmsg.TabIndex = 148
        Me.LVmsg.UseCompatibleStateImageBehavior = False
        Me.LVmsg.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Type"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "User Number"
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Message"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 150
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Date/Time"
        Me.ColumnHeader12.Width = 80
        '
        'btnGSMModule
        '
        Me.btnGSMModule.BackColor = System.Drawing.Color.Transparent
        Me.btnGSMModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGSMModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGSMModule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGSMModule.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSMModule.ForeColor = System.Drawing.Color.Gold
        Me.btnGSMModule.Location = New System.Drawing.Point(6, 322)
        Me.btnGSMModule.Name = "btnGSMModule"
        Me.btnGSMModule.Size = New System.Drawing.Size(75, 41)
        Me.btnGSMModule.TabIndex = 157
        Me.btnGSMModule.Text = "GSM Module"
        Me.btnGSMModule.UseVisualStyleBackColor = False
        '
        'btnQueued
        '
        Me.btnQueued.BackColor = System.Drawing.Color.Transparent
        Me.btnQueued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQueued.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQueued.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQueued.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQueued.ForeColor = System.Drawing.Color.Gold
        Me.btnQueued.Location = New System.Drawing.Point(6, 156)
        Me.btnQueued.Name = "btnQueued"
        Me.btnQueued.Size = New System.Drawing.Size(75, 41)
        Me.btnQueued.TabIndex = 160
        Me.btnQueued.Text = "Queued"
        Me.btnQueued.UseVisualStyleBackColor = False
        '
        'btnSaved
        '
        Me.btnSaved.BackColor = System.Drawing.Color.Transparent
        Me.btnSaved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaved.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaved.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaved.ForeColor = System.Drawing.Color.Gold
        Me.btnSaved.Location = New System.Drawing.Point(6, 62)
        Me.btnSaved.Name = "btnSaved"
        Me.btnSaved.Size = New System.Drawing.Size(75, 41)
        Me.btnSaved.TabIndex = 159
        Me.btnSaved.Text = "Saved"
        Me.btnSaved.UseVisualStyleBackColor = False
        '
        'btnSent
        '
        Me.btnSent.BackColor = System.Drawing.Color.Transparent
        Me.btnSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSent.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSent.ForeColor = System.Drawing.Color.Gold
        Me.btnSent.Location = New System.Drawing.Point(6, 203)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(75, 41)
        Me.btnSent.TabIndex = 158
        Me.btnSent.Text = "Sent"
        Me.btnSent.UseVisualStyleBackColor = False
        '
        'btnReceived
        '
        Me.btnReceived.BackColor = System.Drawing.Color.Transparent
        Me.btnReceived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReceived.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceived.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceived.ForeColor = System.Drawing.Color.Gold
        Me.btnReceived.Location = New System.Drawing.Point(6, 109)
        Me.btnReceived.Name = "btnReceived"
        Me.btnReceived.Size = New System.Drawing.Size(75, 41)
        Me.btnReceived.TabIndex = 157
        Me.btnReceived.Text = "Received"
        Me.btnReceived.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Gold
        Me.btnCreate.Location = New System.Drawing.Point(6, 256)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 41)
        Me.btnCreate.TabIndex = 156
        Me.btnCreate.Text = "New"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'gbGSMModule
        '
        Me.gbGSMModule.Controls.Add(Me.btnSMSCommands)
        Me.gbGSMModule.Controls.Add(Me.GroupBox11)
        Me.gbGSMModule.Controls.Add(Me.llblDetect)
        Me.gbGSMModule.Controls.Add(Me.pbLoading)
        Me.gbGSMModule.Controls.Add(Me.btnTest)
        Me.gbGSMModule.Controls.Add(Me.PictureBox1)
        Me.gbGSMModule.Controls.Add(Me.btnGSMSet)
        Me.gbGSMModule.Controls.Add(Me.GroupBox7)
        Me.gbGSMModule.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGSMModule.Location = New System.Drawing.Point(518, 21)
        Me.gbGSMModule.Name = "gbGSMModule"
        Me.gbGSMModule.Size = New System.Drawing.Size(400, 54)
        Me.gbGSMModule.TabIndex = 147
        Me.gbGSMModule.TabStop = False
        Me.gbGSMModule.Text = "GSM Module Settings"
        Me.gbGSMModule.Visible = False
        '
        'btnSMSCommands
        '
        Me.btnSMSCommands.BackColor = System.Drawing.Color.Black
        Me.btnSMSCommands.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMSCommands.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMSCommands.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSMSCommands.ForeColor = System.Drawing.Color.Gold
        Me.btnSMSCommands.Location = New System.Drawing.Point(237, 23)
        Me.btnSMSCommands.Name = "btnSMSCommands"
        Me.btnSMSCommands.Size = New System.Drawing.Size(156, 26)
        Me.btnSMSCommands.TabIndex = 162
        Me.btnSMSCommands.Text = "Modify SMS Commands"
        Me.btnSMSCommands.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cmbValidity)
        Me.GroupBox11.Controls.Add(Me.txtSendDelay)
        Me.GroupBox11.Controls.Add(Me.Label21)
        Me.GroupBox11.Controls.Add(Me.cmbStopBits)
        Me.GroupBox11.Controls.Add(Me.Label20)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 156)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(386, 91)
        Me.GroupBox11.TabIndex = 148
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Other settings"
        '
        'cmbValidity
        '
        Me.cmbValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValidity.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValidity.FormattingEnabled = True
        Me.cmbValidity.Items.AddRange(New Object() {"1 Hour", "3 Hours", "6 Hours", "12 Hours", "1 Day", "1 Week", "Maximum"})
        Me.cmbValidity.Location = New System.Drawing.Point(170, 64)
        Me.cmbValidity.Name = "cmbValidity"
        Me.cmbValidity.Size = New System.Drawing.Size(155, 22)
        Me.cmbValidity.TabIndex = 0
        '
        'txtSendDelay
        '
        Me.txtSendDelay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendDelay.Location = New System.Drawing.Point(170, 13)
        Me.txtSendDelay.Name = "txtSendDelay"
        Me.txtSendDelay.Size = New System.Drawing.Size(155, 22)
        Me.txtSendDelay.TabIndex = 2
        Me.txtSendDelay.Text = "1000"
        Me.txtSendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(40, 41)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Stop Bits:"
        '
        'cmbStopBits
        '
        Me.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStopBits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStopBits.FormattingEnabled = True
        Me.cmbStopBits.Items.AddRange(New Object() {"None", "1", "1.5", "2"})
        Me.cmbStopBits.Location = New System.Drawing.Point(170, 38)
        Me.cmbStopBits.Name = "cmbStopBits"
        Me.cmbStopBits.Size = New System.Drawing.Size(155, 22)
        Me.cmbStopBits.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(40, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Message Validity:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(40, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Send Delay (ms):"
        '
        'llblDetect
        '
        Me.llblDetect.AutoSize = True
        Me.llblDetect.BackColor = System.Drawing.Color.Transparent
        Me.llblDetect.Location = New System.Drawing.Point(10, 266)
        Me.llblDetect.Name = "llblDetect"
        Me.llblDetect.Size = New System.Drawing.Size(95, 13)
        Me.llblDetect.TabIndex = 146
        Me.llblDetect.TabStop = True
        Me.llblDetect.Text = "Detect All Ports"
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = CType(resources.GetObject("pbLoading.Image"), System.Drawing.Image)
        Me.pbLoading.Location = New System.Drawing.Point(178, 265)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(16, 14)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 145
        Me.pbLoading.TabStop = False
        Me.pbLoading.Visible = False
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.White
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.Black
        Me.btnTest.Location = New System.Drawing.Point(195, 257)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(106, 28)
        Me.btnTest.TabIndex = 64
        Me.btnTest.Text = "&Test Device"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnGSMSet
        '
        Me.btnGSMSet.BackColor = System.Drawing.Color.White
        Me.btnGSMSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGSMSet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSMSet.ForeColor = System.Drawing.Color.Black
        Me.btnGSMSet.Location = New System.Drawing.Point(307, 257)
        Me.btnGSMSet.Name = "btnGSMSet"
        Me.btnGSMSet.Size = New System.Drawing.Size(87, 29)
        Me.btnGSMSet.TabIndex = 37
        Me.btnGSMSet.Text = "&Set"
        Me.btnGSMSet.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Black
        Me.GroupBox7.Controls.Add(Me.cmbTimeOut)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.cmbPort)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.cmbBaudRate)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(386, 97)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Primary Settings"
        '
        'lblSMSTechnology
        '
        Me.lblSMSTechnology.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSMSTechnology.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSMSTechnology.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMSTechnology.ForeColor = System.Drawing.Color.White
        Me.lblSMSTechnology.Location = New System.Drawing.Point(3, 10)
        Me.lblSMSTechnology.Name = "lblSMSTechnology"
        Me.lblSMSTechnology.Size = New System.Drawing.Size(486, 38)
        Me.lblSMSTechnology.TabIndex = 36
        Me.lblSMSTechnology.Text = "SMS Technology"
        Me.lblSMSTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Guard
        Me.PictureBox3.Location = New System.Drawing.Point(10, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Gray
        Me.Label25.Location = New System.Drawing.Point(92, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(366, 54)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "You can lock, disconnect or delete system users. Click the 'Show Access Settings'" & _
            " button to show the window."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbGeneral
        '
        Me.gbGeneral.BackColor = System.Drawing.Color.Transparent
        Me.gbGeneral.Controls.Add(Me.lblGNext)
        Me.gbGeneral.Controls.Add(Me.lblGPrev)
        Me.gbGeneral.Controls.Add(Me.Label26)
        Me.gbGeneral.Controls.Add(Me.btnGNext)
        Me.gbGeneral.Controls.Add(Me.gbG1)
        Me.gbGeneral.Controls.Add(Me.btnGPrevious)
        Me.gbGeneral.Controls.Add(Me.btnGApply)
        Me.gbGeneral.Controls.Add(Me.btnDefaultGeneral)
        Me.gbGeneral.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGeneral.ForeColor = System.Drawing.Color.White
        Me.gbGeneral.Location = New System.Drawing.Point(230, 63)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(495, 408)
        Me.gbGeneral.TabIndex = 42
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Visible = False
        '
        'lblGNext
        '
        Me.lblGNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGNext.ForeColor = System.Drawing.Color.DimGray
        Me.lblGNext.Location = New System.Drawing.Point(288, 373)
        Me.lblGNext.Name = "lblGNext"
        Me.lblGNext.Size = New System.Drawing.Size(55, 17)
        Me.lblGNext.TabIndex = 77
        Me.lblGNext.Text = "Next"
        Me.lblGNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGPrev
        '
        Me.lblGPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPrev.ForeColor = System.Drawing.Color.DimGray
        Me.lblGPrev.Location = New System.Drawing.Point(152, 372)
        Me.lblGPrev.Name = "lblGPrev"
        Me.lblGPrev.Size = New System.Drawing.Size(55, 17)
        Me.lblGPrev.TabIndex = 76
        Me.lblGPrev.Text = "Previous"
        Me.lblGPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(3, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(487, 38)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "PUPSMBC STUDENT SECURITY MONITORING SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USING RFID WITH SMS TECHNOLOGY"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGNext
        '
        Me.btnGNext.BackColor = System.Drawing.Color.Transparent
        Me.btnGNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGNext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGNext.ForeColor = System.Drawing.Color.DimGray
        Me.btnGNext.Location = New System.Drawing.Point(249, 370)
        Me.btnGNext.Name = "btnGNext"
        Me.btnGNext.Size = New System.Drawing.Size(33, 20)
        Me.btnGNext.TabIndex = 75
        Me.btnGNext.Text = ">>"
        Me.btnGNext.UseVisualStyleBackColor = False
        '
        'gbG1
        '
        Me.gbG1.BackColor = System.Drawing.Color.Black
        Me.gbG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbG1.Controls.Add(Me.chkSounds)
        Me.gbG1.Controls.Add(Me.chkGShutdownDisconnected)
        Me.gbG1.Controls.Add(Me.rbLogAsAdmin)
        Me.gbG1.Controls.Add(Me.rbShowLogin)
        Me.gbG1.Controls.Add(Me.chkGAutoStartClient)
        Me.gbG1.Controls.Add(Me.chkGStartSend)
        Me.gbG1.Controls.Add(Me.chkGGSMDetect)
        Me.gbG1.Controls.Add(Me.chkGSplash)
        Me.gbG1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.gbG1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbG1.ForeColor = System.Drawing.Color.Gold
        Me.gbG1.Location = New System.Drawing.Point(6, 49)
        Me.gbG1.Name = "gbG1"
        Me.gbG1.Size = New System.Drawing.Size(481, 308)
        Me.gbG1.TabIndex = 1
        Me.gbG1.TabStop = False
        '
        'chkSounds
        '
        Me.chkSounds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSounds.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSounds.ForeColor = System.Drawing.Color.White
        Me.chkSounds.Location = New System.Drawing.Point(13, 277)
        Me.chkSounds.Name = "chkSounds"
        Me.chkSounds.Size = New System.Drawing.Size(457, 18)
        Me.chkSounds.TabIndex = 77
        Me.chkSounds.Text = "Mute System Sounds Effect"
        Me.chkSounds.UseVisualStyleBackColor = True
        '
        'chkGShutdownDisconnected
        '
        Me.chkGShutdownDisconnected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkGShutdownDisconnected.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGShutdownDisconnected.ForeColor = System.Drawing.Color.White
        Me.chkGShutdownDisconnected.Location = New System.Drawing.Point(13, 161)
        Me.chkGShutdownDisconnected.Name = "chkGShutdownDisconnected"
        Me.chkGShutdownDisconnected.Size = New System.Drawing.Size(457, 18)
        Me.chkGShutdownDisconnected.TabIndex = 76
        Me.chkGShutdownDisconnected.Text = "Shutdown client machine when user disconnected."
        Me.chkGShutdownDisconnected.UseVisualStyleBackColor = True
        '
        'rbLogAsAdmin
        '
        Me.rbLogAsAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbLogAsAdmin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLogAsAdmin.ForeColor = System.Drawing.Color.White
        Me.rbLogAsAdmin.Location = New System.Drawing.Point(204, 135)
        Me.rbLogAsAdmin.Name = "rbLogAsAdmin"
        Me.rbLogAsAdmin.Size = New System.Drawing.Size(180, 18)
        Me.rbLogAsAdmin.TabIndex = 71
        Me.rbLogAsAdmin.Text = "Log-in as Administrator"
        Me.rbLogAsAdmin.UseVisualStyleBackColor = True
        '
        'rbShowLogin
        '
        Me.rbShowLogin.Checked = True
        Me.rbShowLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbShowLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShowLogin.ForeColor = System.Drawing.Color.White
        Me.rbShowLogin.Location = New System.Drawing.Point(40, 134)
        Me.rbShowLogin.Name = "rbShowLogin"
        Me.rbShowLogin.Size = New System.Drawing.Size(158, 18)
        Me.rbShowLogin.TabIndex = 70
        Me.rbShowLogin.TabStop = True
        Me.rbShowLogin.Text = "Show log in window"
        Me.rbShowLogin.UseVisualStyleBackColor = True
        '
        'chkGAutoStartClient
        '
        Me.chkGAutoStartClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkGAutoStartClient.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGAutoStartClient.ForeColor = System.Drawing.Color.White
        Me.chkGAutoStartClient.Location = New System.Drawing.Point(13, 114)
        Me.chkGAutoStartClient.Name = "chkGAutoStartClient"
        Me.chkGAutoStartClient.Size = New System.Drawing.Size(457, 18)
        Me.chkGAutoStartClient.TabIndex = 68
        Me.chkGAutoStartClient.Text = "Automatic start the client when server started."
        Me.chkGAutoStartClient.UseVisualStyleBackColor = True
        '
        'chkGStartSend
        '
        Me.chkGStartSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkGStartSend.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGStartSend.ForeColor = System.Drawing.Color.White
        Me.chkGStartSend.Location = New System.Drawing.Point(13, 88)
        Me.chkGStartSend.Name = "chkGStartSend"
        Me.chkGStartSend.Size = New System.Drawing.Size(457, 18)
        Me.chkGStartSend.TabIndex = 67
        Me.chkGStartSend.Text = "Start sending of queued messages at start up"
        Me.chkGStartSend.UseVisualStyleBackColor = True
        '
        'chkGGSMDetect
        '
        Me.chkGGSMDetect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkGGSMDetect.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGGSMDetect.ForeColor = System.Drawing.Color.White
        Me.chkGGSMDetect.Location = New System.Drawing.Point(13, 62)
        Me.chkGGSMDetect.Name = "chkGGSMDetect"
        Me.chkGGSMDetect.Size = New System.Drawing.Size(457, 18)
        Me.chkGGSMDetect.TabIndex = 66
        Me.chkGGSMDetect.Text = "Auto-detect GSM Module device at start up"
        Me.chkGGSMDetect.UseVisualStyleBackColor = True
        '
        'chkGSplash
        '
        Me.chkGSplash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkGSplash.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGSplash.ForeColor = System.Drawing.Color.White
        Me.chkGSplash.Location = New System.Drawing.Point(13, 37)
        Me.chkGSplash.Name = "chkGSplash"
        Me.chkGSplash.Size = New System.Drawing.Size(457, 18)
        Me.chkGSplash.TabIndex = 65
        Me.chkGSplash.Text = "Show splash screen at start up"
        Me.chkGSplash.UseVisualStyleBackColor = True
        '
        'btnGPrevious
        '
        Me.btnGPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnGPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGPrevious.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPrevious.ForeColor = System.Drawing.Color.DimGray
        Me.btnGPrevious.Location = New System.Drawing.Point(213, 370)
        Me.btnGPrevious.Name = "btnGPrevious"
        Me.btnGPrevious.Size = New System.Drawing.Size(33, 20)
        Me.btnGPrevious.TabIndex = 74
        Me.btnGPrevious.Text = "<<"
        Me.btnGPrevious.UseVisualStyleBackColor = False
        '
        'btnGApply
        '
        Me.btnGApply.BackColor = System.Drawing.Color.White
        Me.btnGApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGApply.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGApply.ForeColor = System.Drawing.Color.Black
        Me.btnGApply.Location = New System.Drawing.Point(359, 368)
        Me.btnGApply.Name = "btnGApply"
        Me.btnGApply.Size = New System.Drawing.Size(117, 26)
        Me.btnGApply.TabIndex = 64
        Me.btnGApply.Text = "&Apply"
        Me.btnGApply.UseVisualStyleBackColor = False
        '
        'btnDefaultGeneral
        '
        Me.btnDefaultGeneral.BackColor = System.Drawing.Color.White
        Me.btnDefaultGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefaultGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaultGeneral.ForeColor = System.Drawing.Color.Black
        Me.btnDefaultGeneral.Location = New System.Drawing.Point(18, 368)
        Me.btnDefaultGeneral.Name = "btnDefaultGeneral"
        Me.btnDefaultGeneral.Size = New System.Drawing.Size(117, 26)
        Me.btnDefaultGeneral.TabIndex = 72
        Me.btnDefaultGeneral.Text = "&Restore Defaults"
        Me.btnDefaultGeneral.UseVisualStyleBackColor = False
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(339, 499)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(388, 12)
        Me.lblVersion.TabIndex = 43
        Me.lblVersion.Text = "PUPSSMSRFIDSMS Ver1.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'llblPUP
        '
        Me.llblPUP.AutoSize = True
        Me.llblPUP.BackColor = System.Drawing.Color.Transparent
        Me.llblPUP.Location = New System.Drawing.Point(26, 497)
        Me.llblPUP.Name = "llblPUP"
        Me.llblPUP.Size = New System.Drawing.Size(124, 13)
        Me.llblPUP.TabIndex = 45
        Me.llblPUP.TabStop = True
        Me.llblPUP.Text = "http://www.pup.edu.ph/"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(657, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'gbRecords
        '
        Me.gbRecords.BackColor = System.Drawing.Color.Transparent
        Me.gbRecords.Controls.Add(Me.btnBIN)
        Me.gbRecords.Controls.Add(Me.lblRecordCount)
        Me.gbRecords.Controls.Add(Me.btnClear)
        Me.gbRecords.Controls.Add(Me.btnStudentList)
        Me.gbRecords.Controls.Add(Me.btnAddDept)
        Me.gbRecords.Controls.Add(Me.btnEncodeStud)
        Me.gbRecords.Controls.Add(Me.btnSystem)
        Me.gbRecords.Controls.Add(Me.btnStudent)
        Me.gbRecords.Controls.Add(Me.lblRecords)
        Me.gbRecords.Controls.Add(Me.gbRStudSystem)
        Me.gbRecords.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRecords.ForeColor = System.Drawing.Color.White
        Me.gbRecords.Location = New System.Drawing.Point(743, 16)
        Me.gbRecords.Name = "gbRecords"
        Me.gbRecords.Size = New System.Drawing.Size(495, 51)
        Me.gbRecords.TabIndex = 158
        Me.gbRecords.TabStop = False
        Me.gbRecords.Visible = False
        '
        'btnBIN
        '
        Me.btnBIN.BackColor = System.Drawing.Color.Transparent
        Me.btnBIN.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Bin
        Me.btnBIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBIN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBIN.ForeColor = System.Drawing.Color.Gold
        Me.btnBIN.Location = New System.Drawing.Point(8, 341)
        Me.btnBIN.Name = "btnBIN"
        Me.btnBIN.Size = New System.Drawing.Size(63, 50)
        Me.btnBIN.TabIndex = 165
        Me.btnBIN.UseVisualStyleBackColor = False
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblRecordCount.Location = New System.Drawing.Point(74, 375)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(240, 16)
        Me.lblRecordCount.TabIndex = 164
        Me.lblRecordCount.Text = "Record count: "
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(379, 372)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 163
        Me.btnClear.Text = "Clear History"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnStudentList
        '
        Me.btnStudentList.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentList.BackgroundImage = CType(resources.GetObject("btnStudentList.BackgroundImage"), System.Drawing.Image)
        Me.btnStudentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStudentList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudentList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentList.ForeColor = System.Drawing.Color.Gold
        Me.btnStudentList.Location = New System.Drawing.Point(6, 165)
        Me.btnStudentList.Name = "btnStudentList"
        Me.btnStudentList.Size = New System.Drawing.Size(63, 50)
        Me.btnStudentList.TabIndex = 162
        Me.btnStudentList.UseVisualStyleBackColor = False
        '
        'btnAddDept
        '
        Me.btnAddDept.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDept.BackgroundImage = CType(resources.GetObject("btnAddDept.BackgroundImage"), System.Drawing.Image)
        Me.btnAddDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddDept.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDept.ForeColor = System.Drawing.Color.Gold
        Me.btnAddDept.Location = New System.Drawing.Point(6, 274)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(63, 50)
        Me.btnAddDept.TabIndex = 161
        Me.btnAddDept.UseVisualStyleBackColor = False
        '
        'btnEncodeStud
        '
        Me.btnEncodeStud.BackColor = System.Drawing.Color.Transparent
        Me.btnEncodeStud.BackgroundImage = CType(resources.GetObject("btnEncodeStud.BackgroundImage"), System.Drawing.Image)
        Me.btnEncodeStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEncodeStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncodeStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEncodeStud.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncodeStud.ForeColor = System.Drawing.Color.Gold
        Me.btnEncodeStud.Location = New System.Drawing.Point(6, 219)
        Me.btnEncodeStud.Name = "btnEncodeStud"
        Me.btnEncodeStud.Size = New System.Drawing.Size(63, 50)
        Me.btnEncodeStud.TabIndex = 160
        Me.btnEncodeStud.UseVisualStyleBackColor = False
        '
        'btnSystem
        '
        Me.btnSystem.BackColor = System.Drawing.Color.Transparent
        Me.btnSystem.BackgroundImage = CType(resources.GetObject("btnSystem.BackgroundImage"), System.Drawing.Image)
        Me.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSystem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystem.ForeColor = System.Drawing.Color.Gold
        Me.btnSystem.Location = New System.Drawing.Point(6, 55)
        Me.btnSystem.Name = "btnSystem"
        Me.btnSystem.Size = New System.Drawing.Size(63, 50)
        Me.btnSystem.TabIndex = 159
        Me.btnSystem.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BackgroundImage = CType(resources.GetObject("btnStudent.BackgroundImage"), System.Drawing.Image)
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudent.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Gold
        Me.btnStudent.Location = New System.Drawing.Point(6, 110)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(63, 50)
        Me.btnStudent.TabIndex = 158
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'lblRecords
        '
        Me.lblRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.White
        Me.lblRecords.Location = New System.Drawing.Point(3, 10)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(487, 38)
        Me.lblRecords.TabIndex = 36
        Me.lblRecords.Text = "System Records"
        Me.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbRStudSystem
        '
        Me.gbRStudSystem.BackColor = System.Drawing.Color.Transparent
        Me.gbRStudSystem.Controls.Add(Me.lblSTip)
        Me.gbRStudSystem.Controls.Add(Me.PictureBox5)
        Me.gbRStudSystem.Controls.Add(Me.txtRSearch)
        Me.gbRStudSystem.Controls.Add(Me.LVStud)
        Me.gbRStudSystem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRStudSystem.ForeColor = System.Drawing.Color.Gold
        Me.gbRStudSystem.Location = New System.Drawing.Point(77, 49)
        Me.gbRStudSystem.Name = "gbRStudSystem"
        Me.gbRStudSystem.Size = New System.Drawing.Size(410, 317)
        Me.gbRStudSystem.TabIndex = 1
        Me.gbRStudSystem.TabStop = False
        '
        'lblSTip
        '
        Me.lblSTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblSTip.Location = New System.Drawing.Point(4, 13)
        Me.lblSTip.Name = "lblSTip"
        Me.lblSTip.Size = New System.Drawing.Size(240, 16)
        Me.lblSTip.TabIndex = 78
        Me.lblSTip.Text = "Type keyword:"
        Me.lblSTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSTip.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(373, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 21)
        Me.PictureBox5.TabIndex = 77
        Me.PictureBox5.TabStop = False
        '
        'txtRSearch
        '
        Me.txtRSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtRSearch.Location = New System.Drawing.Point(250, 12)
        Me.txtRSearch.MaxLength = 20
        Me.txtRSearch.Name = "txtRSearch"
        Me.txtRSearch.Size = New System.Drawing.Size(117, 21)
        Me.txtRSearch.TabIndex = 1
        Me.txtRSearch.Text = "Search"
        '
        'LVStud
        '
        Me.LVStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVStud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVStud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVStud.FullRowSelect = True
        Me.LVStud.GridLines = True
        Me.LVStud.Location = New System.Drawing.Point(6, 35)
        Me.LVStud.MultiSelect = False
        Me.LVStud.Name = "LVStud"
        Me.LVStud.Size = New System.Drawing.Size(398, 276)
        Me.LVStud.TabIndex = 0
        Me.LVStud.UseCompatibleStateImageBehavior = False
        Me.LVStud.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student #"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Log state"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date / Time"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 115
        '
        'gbClient
        '
        Me.gbClient.BackColor = System.Drawing.Color.Transparent
        Me.gbClient.Controls.Add(Me.GroupBox12)
        Me.gbClient.Controls.Add(Me.GroupB)
        Me.gbClient.Controls.Add(Me.lblClient)
        Me.gbClient.Location = New System.Drawing.Point(742, 69)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(503, 50)
        Me.gbClient.TabIndex = 160
        Me.gbClient.TabStop = False
        Me.gbClient.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.PictureBox3)
        Me.GroupBox12.Controls.Add(Me.btnShowGuard)
        Me.GroupBox12.Controls.Add(Me.Label25)
        Me.GroupBox12.Location = New System.Drawing.Point(7, 271)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(480, 111)
        Me.GroupBox12.TabIndex = 39
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Guard Privilege"
        '
        'btnShowGuard
        '
        Me.btnShowGuard.BackColor = System.Drawing.Color.White
        Me.btnShowGuard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowGuard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGuard.ForeColor = System.Drawing.Color.Black
        Me.btnShowGuard.Location = New System.Drawing.Point(155, 71)
        Me.btnShowGuard.Name = "btnShowGuard"
        Me.btnShowGuard.Size = New System.Drawing.Size(212, 29)
        Me.btnShowGuard.TabIndex = 38
        Me.btnShowGuard.Text = "&Show Guard Settings Window"
        Me.btnShowGuard.UseVisualStyleBackColor = False
        '
        'GroupB
        '
        Me.GroupB.Controls.Add(Me.pbSystemShutdown)
        Me.GroupB.Controls.Add(Me.GroupBox1)
        Me.GroupB.Location = New System.Drawing.Point(7, 56)
        Me.GroupB.Name = "GroupB"
        Me.GroupB.Size = New System.Drawing.Size(480, 201)
        Me.GroupB.TabIndex = 38
        Me.GroupB.TabStop = False
        Me.GroupB.Text = "Time Shutdown"
        '
        'lblClient
        '
        Me.lblClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClient.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.White
        Me.lblClient.Location = New System.Drawing.Point(2, 9)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(487, 38)
        Me.lblClient.TabIndex = 37
        Me.lblClient.Text = "Client System Settings"
        Me.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Splash
        Me.PictureBox6.Location = New System.Drawing.Point(21, 383)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(199, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 161
        Me.PictureBox6.TabStop = False
        '
        'tmrUpdateMSG
        '
        Me.tmrUpdateMSG.Interval = 1000
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.setting1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(741, 572)
        Me.Controls.Add(Me.gbSystemUsers)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.llblPUP)
        Me.Controls.Add(Me.gbRecords)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbGeneral)
        Me.Controls.Add(Me.gbSMSTechnology)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbSystemShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSystemUsers.ResumeLayout(False)
        Me.gbUsersList.ResumeLayout(False)
        Me.gbUsersList.PerformLayout()
        Me.gbAddUser.ResumeLayout(False)
        Me.gbAddUser.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbUpdateUser.ResumeLayout(False)
        Me.gbUpdateUser.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.gbSMSTechnology.ResumeLayout(False)
        Me.gbSMSTechnology.PerformLayout()
        Me.gbMessage.ResumeLayout(False)
        Me.gbGSMModule.ResumeLayout(False)
        Me.gbGSMModule.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGeneral.ResumeLayout(False)
        Me.gbG1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRecords.ResumeLayout(False)
        Me.gbRStudSystem.ResumeLayout(False)
        Me.gbRStudSystem.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClient.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupB.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTimeOut As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpClientShtdown As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkCShutdownDefault As System.Windows.Forms.CheckBox
    Friend WithEvents pbSystemShutdown As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkPass As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUPass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUPass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUUserID As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents gbSystemUsers As System.Windows.Forms.GroupBox
    Friend WithEvents lblSystemUsers As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents gbSMSTechnology As System.Windows.Forms.GroupBox
    Friend WithEvents btnGSMSet As System.Windows.Forms.Button
    Friend WithEvents lblSMSTechnology As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSendDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValidity As System.Windows.Forms.ComboBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gbGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents gbG1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGApply As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents llblShutdown As System.Windows.Forms.LinkLabel
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents llblPUP As System.Windows.Forms.LinkLabel
    Friend WithEvents chkGSplash As System.Windows.Forms.CheckBox
    Friend WithEvents chkGGSMDetect As System.Windows.Forms.CheckBox
    Friend WithEvents chkGStartSend As System.Windows.Forms.CheckBox
    Friend WithEvents chkGAutoStartClient As System.Windows.Forms.CheckBox
    Friend WithEvents rbLogAsAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbShowLogin As System.Windows.Forms.RadioButton
    Friend WithEvents btnDefaultGeneral As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents llblDetect As System.Windows.Forms.LinkLabel
    Friend WithEvents btnGPrevious As System.Windows.Forms.Button
    Friend WithEvents btnGNext As System.Windows.Forms.Button
    Friend WithEvents chkGShutdownDisconnected As System.Windows.Forms.CheckBox
    Friend WithEvents lblGNext As System.Windows.Forms.Label
    Friend WithEvents lblGPrev As System.Windows.Forms.Label
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnSystemUsers As System.Windows.Forms.Button
    Friend WithEvents btnSMSTechnology As System.Windows.Forms.Button
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents gbRecords As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents gbRStudSystem As System.Windows.Forms.GroupBox
    Friend WithEvents btnSystem As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents LVStud As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtRSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEncodeStud As System.Windows.Forms.Button
    Friend WithEvents btnAddDept As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnStudentList As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSTip As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents btnBIN As System.Windows.Forms.Button
    Friend WithEvents gbUpdateUser As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateMy As System.Windows.Forms.Button
    Friend WithEvents btnListUsers As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbAddUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblAUserID As System.Windows.Forms.Label
    Friend WithEvents txtALName As System.Windows.Forms.TextBox
    Friend WithEvents txtAFName As System.Windows.Forms.TextBox
    Friend WithEvents txtAPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAPass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAUserName As System.Windows.Forms.TextBox
    Friend WithEvents chkAOperate As System.Windows.Forms.CheckBox
    Friend WithEvents chkAShutdown As System.Windows.Forms.CheckBox
    Friend WithEvents chkAView As System.Windows.Forms.CheckBox
    Friend WithEvents chkASearch As System.Windows.Forms.CheckBox
    Friend WithEvents chkALocked As System.Windows.Forms.CheckBox
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtULName As System.Windows.Forms.TextBox
    Friend WithEvents txtUFName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents gbUsersList As System.Windows.Forms.GroupBox
    Friend WithEvents LVUsers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnShowAccess As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents lblURecordCount As System.Windows.Forms.Label
    Friend WithEvents gbClient As System.Windows.Forms.GroupBox
    Friend WithEvents btnGeneral As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbGSMModule As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnSent As System.Windows.Forms.Button
    Friend WithEvents btnReceived As System.Windows.Forms.Button
    Friend WithEvents btnSaved As System.Windows.Forms.Button
    Friend WithEvents btnQueued As System.Windows.Forms.Button
    Friend WithEvents btnGSMModule As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents gbMessage As System.Windows.Forms.GroupBox
    Friend WithEvents LVmsg As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdvanceSMS As System.Windows.Forms.Button
    Friend WithEvents lblMessageCount As System.Windows.Forms.Label
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents GroupB As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowGuard As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSMSCommands As System.Windows.Forms.Button
    Friend WithEvents txtANumber As System.Windows.Forms.TextBox
    Friend WithEvents txtUNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrUpdateMSG As System.Windows.Forms.Timer
    Friend WithEvents ttOption As System.Windows.Forms.ToolTip
    Friend WithEvents chkSounds As System.Windows.Forms.CheckBox
End Class
