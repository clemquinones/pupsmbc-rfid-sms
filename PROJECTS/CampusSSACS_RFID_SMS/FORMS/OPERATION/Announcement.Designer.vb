<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnouncement
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
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnPost = New System.Windows.Forms.Button
        Me.chkSend = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCustomize = New System.Windows.Forms.Button
        Me.rbSendToAll = New System.Windows.Forms.RadioButton
        Me.rbCustomize = New System.Windows.Forms.RadioButton
        Me.chkUtility = New System.Windows.Forms.CheckBox
        Me.chkFaculty = New System.Windows.Forms.CheckBox
        Me.chkParent = New System.Windows.Forms.CheckBox
        Me.txtSendCopy = New System.Windows.Forms.TextBox
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbSendOption = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbScheduleAnnouncement = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkSchedAnnounce = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.llblRecent = New System.Windows.Forms.LinkLabel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblNoteSched = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblSMS = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbSendOption.SuspendLayout()
        Me.gbScheduleAnnouncement.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.Black
        Me.txtMessage.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(12, 19)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage.Size = New System.Drawing.Size(546, 118)
        Me.txtMessage.TabIndex = 0
        Me.txtMessage.Text = "--Type your announcement here..."
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.Black
        Me.btnPost.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPost.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.Gold
        Me.btnPost.Location = New System.Drawing.Point(356, 482)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(98, 30)
        Me.btnPost.TabIndex = 1
        Me.btnPost.Text = "&Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'chkSend
        '
        Me.chkSend.AutoSize = True
        Me.chkSend.BackColor = System.Drawing.Color.Black
        Me.chkSend.Checked = True
        Me.chkSend.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSend.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSend.ForeColor = System.Drawing.Color.Gold
        Me.chkSend.Location = New System.Drawing.Point(8, 353)
        Me.chkSend.Name = "chkSend"
        Me.chkSend.Size = New System.Drawing.Size(160, 18)
        Me.chkSend.TabIndex = 2
        Me.chkSend.Text = "Send Announcement"
        Me.chkSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date / Time to post:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Expiration of Announcement:"
        '
        'btnCustomize
        '
        Me.btnCustomize.BackColor = System.Drawing.Color.White
        Me.btnCustomize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomize.Enabled = False
        Me.btnCustomize.ForeColor = System.Drawing.Color.Black
        Me.btnCustomize.Location = New System.Drawing.Point(232, 20)
        Me.btnCustomize.Name = "btnCustomize"
        Me.btnCustomize.Size = New System.Drawing.Size(162, 25)
        Me.btnCustomize.TabIndex = 6
        Me.btnCustomize.Text = "Customize... [All]"
        Me.btnCustomize.UseVisualStyleBackColor = False
        '
        'rbSendToAll
        '
        Me.rbSendToAll.AutoSize = True
        Me.rbSendToAll.Checked = True
        Me.rbSendToAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSendToAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSendToAll.ForeColor = System.Drawing.Color.White
        Me.rbSendToAll.Location = New System.Drawing.Point(18, 24)
        Me.rbSendToAll.Name = "rbSendToAll"
        Me.rbSendToAll.Size = New System.Drawing.Size(94, 17)
        Me.rbSendToAll.TabIndex = 7
        Me.rbSendToAll.TabStop = True
        Me.rbSendToAll.Text = "Send to all"
        Me.rbSendToAll.UseVisualStyleBackColor = True
        '
        'rbCustomize
        '
        Me.rbCustomize.AutoSize = True
        Me.rbCustomize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCustomize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomize.ForeColor = System.Drawing.Color.White
        Me.rbCustomize.Location = New System.Drawing.Point(135, 24)
        Me.rbCustomize.Name = "rbCustomize"
        Me.rbCustomize.Size = New System.Drawing.Size(92, 17)
        Me.rbCustomize.TabIndex = 7
        Me.rbCustomize.Text = "Customize"
        Me.rbCustomize.UseVisualStyleBackColor = True
        '
        'chkUtility
        '
        Me.chkUtility.AutoSize = True
        Me.chkUtility.BackColor = System.Drawing.Color.Gray
        Me.chkUtility.Checked = True
        Me.chkUtility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUtility.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkUtility.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUtility.ForeColor = System.Drawing.Color.White
        Me.chkUtility.Location = New System.Drawing.Point(287, 56)
        Me.chkUtility.Name = "chkUtility"
        Me.chkUtility.Size = New System.Drawing.Size(129, 17)
        Me.chkUtility.TabIndex = 12
        Me.chkUtility.Text = "Send to Utilities"
        Me.chkUtility.UseVisualStyleBackColor = False
        '
        'chkFaculty
        '
        Me.chkFaculty.AutoSize = True
        Me.chkFaculty.BackColor = System.Drawing.Color.Gray
        Me.chkFaculty.Checked = True
        Me.chkFaculty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkFaculty.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFaculty.ForeColor = System.Drawing.Color.White
        Me.chkFaculty.Location = New System.Drawing.Point(161, 56)
        Me.chkFaculty.Name = "chkFaculty"
        Me.chkFaculty.Size = New System.Drawing.Size(124, 17)
        Me.chkFaculty.TabIndex = 12
        Me.chkFaculty.Text = "Send to faculty"
        Me.chkFaculty.UseVisualStyleBackColor = False
        '
        'chkParent
        '
        Me.chkParent.AutoSize = True
        Me.chkParent.BackColor = System.Drawing.Color.Gray
        Me.chkParent.Checked = True
        Me.chkParent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkParent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkParent.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkParent.ForeColor = System.Drawing.Color.White
        Me.chkParent.Location = New System.Drawing.Point(12, 56)
        Me.chkParent.Name = "chkParent"
        Me.chkParent.Size = New System.Drawing.Size(153, 17)
        Me.chkParent.TabIndex = 10
        Me.chkParent.Text = "Send also to parent"
        Me.chkParent.UseVisualStyleBackColor = False
        '
        'txtSendCopy
        '
        Me.txtSendCopy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendCopy.ForeColor = System.Drawing.Color.Gray
        Me.txtSendCopy.Location = New System.Drawing.Point(481, 20)
        Me.txtSendCopy.Name = "txtSendCopy"
        Me.txtSendCopy.Size = New System.Drawing.Size(85, 22)
        Me.txtSendCopy.TabIndex = 9
        Me.txtSendCopy.Text = "Send Copy"
        Me.txtSendCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(240, 24)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(174, 23)
        Me.dtpStartDate.TabIndex = 9
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(420, 24)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(136, 23)
        Me.dtpStartTime.TabIndex = 10
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(240, 59)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(174, 23)
        Me.dtpEndDate.TabIndex = 9
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(420, 59)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(136, 23)
        Me.dtpEndTime.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(400, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Send Copy:"
        '
        'gbSendOption
        '
        Me.gbSendOption.BackColor = System.Drawing.Color.Black
        Me.gbSendOption.Controls.Add(Me.rbCustomize)
        Me.gbSendOption.Controls.Add(Me.Label3)
        Me.gbSendOption.Controls.Add(Me.chkUtility)
        Me.gbSendOption.Controls.Add(Me.txtSendCopy)
        Me.gbSendOption.Controls.Add(Me.chkFaculty)
        Me.gbSendOption.Controls.Add(Me.btnCustomize)
        Me.gbSendOption.Controls.Add(Me.rbSendToAll)
        Me.gbSendOption.Controls.Add(Me.chkParent)
        Me.gbSendOption.Controls.Add(Me.Label4)
        Me.gbSendOption.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSendOption.ForeColor = System.Drawing.Color.Gold
        Me.gbSendOption.Location = New System.Drawing.Point(8, 377)
        Me.gbSendOption.Name = "gbSendOption"
        Me.gbSendOption.Size = New System.Drawing.Size(572, 82)
        Me.gbSendOption.TabIndex = 16
        Me.gbSendOption.TabStop = False
        Me.gbSendOption.Text = "Option for selecting message recipients"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(559, 23)
        Me.Label4.TabIndex = 16
        '
        'gbScheduleAnnouncement
        '
        Me.gbScheduleAnnouncement.BackColor = System.Drawing.Color.Black
        Me.gbScheduleAnnouncement.Controls.Add(Me.dtpStartDate)
        Me.gbScheduleAnnouncement.Controls.Add(Me.dtpStartTime)
        Me.gbScheduleAnnouncement.Controls.Add(Me.dtpEndDate)
        Me.gbScheduleAnnouncement.Controls.Add(Me.dtpEndTime)
        Me.gbScheduleAnnouncement.Controls.Add(Me.Label1)
        Me.gbScheduleAnnouncement.Controls.Add(Me.Label2)
        Me.gbScheduleAnnouncement.Controls.Add(Me.Label8)
        Me.gbScheduleAnnouncement.Controls.Add(Me.Label9)
        Me.gbScheduleAnnouncement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbScheduleAnnouncement.ForeColor = System.Drawing.Color.Gold
        Me.gbScheduleAnnouncement.Location = New System.Drawing.Point(8, 257)
        Me.gbScheduleAnnouncement.Name = "gbScheduleAnnouncement"
        Me.gbScheduleAnnouncement.Size = New System.Drawing.Size(572, 92)
        Me.gbScheduleAnnouncement.TabIndex = 17
        Me.gbScheduleAnnouncement.TabStop = False
        Me.gbScheduleAnnouncement.Text = "Set the starting and ending date/time of announcement"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(554, 29)
        Me.Label8.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(554, 30)
        Me.Label9.TabIndex = 16
        '
        'chkSchedAnnounce
        '
        Me.chkSchedAnnounce.AutoSize = True
        Me.chkSchedAnnounce.BackColor = System.Drawing.Color.Transparent
        Me.chkSchedAnnounce.Checked = True
        Me.chkSchedAnnounce.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSchedAnnounce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSchedAnnounce.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSchedAnnounce.ForeColor = System.Drawing.Color.Gold
        Me.chkSchedAnnounce.Location = New System.Drawing.Point(8, 236)
        Me.chkSchedAnnounce.Name = "chkSchedAnnounce"
        Me.chkSchedAnnounce.Size = New System.Drawing.Size(187, 18)
        Me.chkSchedAnnounce.TabIndex = 2
        Me.chkSchedAnnounce.Text = "Schedule Announcement"
        Me.chkSchedAnnounce.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.lblRemaining)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.llblRecent)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(8, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 160)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type your announcement"
        '
        'lblRemaining
        '
        Me.lblRemaining.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.ForeColor = System.Drawing.Color.DimGray
        Me.lblRemaining.Location = New System.Drawing.Point(238, 137)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(320, 22)
        Me.lblRemaining.TabIndex = 6
        Me.lblRemaining.Text = "Remaining character for SMS: 1000/1000"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'llblRecent
        '
        Me.llblRecent.AutoSize = True
        Me.llblRecent.BackColor = System.Drawing.Color.Transparent
        Me.llblRecent.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblRecent.Location = New System.Drawing.Point(15, 141)
        Me.llblRecent.Name = "llblRecent"
        Me.llblRecent.Size = New System.Drawing.Size(105, 15)
        Me.llblRecent.TabIndex = 23
        Me.llblRecent.TabStop = True
        Me.llblRecent.Text = "Recent Post..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(10, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 56)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "• Create campus announcement." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Post your announcement to client." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Send announ" & _
            "cement to mobile numbers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Schedule the posting of announcement."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(6, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(560, 40)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Campus Announcement"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoteSched
        '
        Me.lblNoteSched.AutoSize = True
        Me.lblNoteSched.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteSched.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteSched.ForeColor = System.Drawing.Color.White
        Me.lblNoteSched.Location = New System.Drawing.Point(233, 241)
        Me.lblNoteSched.Name = "lblNoteSched"
        Me.lblNoteSched.Size = New System.Drawing.Size(347, 13)
        Me.lblNoteSched.TabIndex = 21
        Me.lblNoteSched.Text = "Note: If uncheck, the announcement will set only for today."
        Me.lblNoteSched.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNoteSched.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(460, 482)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 30)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblSMS
        '
        Me.lblSMS.AutoSize = True
        Me.lblSMS.BackColor = System.Drawing.Color.Transparent
        Me.lblSMS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMS.ForeColor = System.Drawing.Color.White
        Me.lblSMS.Location = New System.Drawing.Point(370, 361)
        Me.lblSMS.Name = "lblSMS"
        Me.lblSMS.Size = New System.Drawing.Size(214, 13)
        Me.lblSMS.TabIndex = 24
        Me.lblSMS.Text = "Send your announcement thru SMS."
        Me.lblSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSMS.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 59)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Announce
        Me.PictureBox1.Location = New System.Drawing.Point(13, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmAnnouncement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(592, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblSMS)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNoteSched)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbScheduleAnnouncement)
        Me.Controls.Add(Me.gbSendOption)
        Me.Controls.Add(Me.chkSchedAnnounce)
        Me.Controls.Add(Me.chkSend)
        Me.Controls.Add(Me.btnPost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnnouncement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Announcement"
        Me.gbSendOption.ResumeLayout(False)
        Me.gbSendOption.PerformLayout()
        Me.gbScheduleAnnouncement.ResumeLayout(False)
        Me.gbScheduleAnnouncement.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents chkSend As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCustomize As System.Windows.Forms.Button
    Friend WithEvents rbSendToAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbCustomize As System.Windows.Forms.RadioButton
    Friend WithEvents txtSendCopy As System.Windows.Forms.TextBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkParent As System.Windows.Forms.CheckBox
    Friend WithEvents chkUtility As System.Windows.Forms.CheckBox
    Friend WithEvents chkFaculty As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbSendOption As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbScheduleAnnouncement As System.Windows.Forms.GroupBox
    Friend WithEvents chkSchedAnnounce As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNoteSched As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents llblRecent As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSMS As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
