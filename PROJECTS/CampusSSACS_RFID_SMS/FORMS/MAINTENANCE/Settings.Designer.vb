<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.btnGSMtest = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbSystemShutdown = New System.Windows.Forms.PictureBox
        Me.chkCShutdownDefault = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpClientShtdown = New System.Windows.Forms.DateTimePicker
        Me.btnSet = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTimeOut = New System.Windows.Forms.ComboBox
        Me.cmbPort = New System.Windows.Forms.ComboBox
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.llblChange = New System.Windows.Forms.LinkLabel
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbSystemShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGSMtest
        '
        Me.btnGSMtest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSMtest.Location = New System.Drawing.Point(238, 68)
        Me.btnGSMtest.Name = "btnGSMtest"
        Me.btnGSMtest.Size = New System.Drawing.Size(96, 29)
        Me.btnGSMtest.TabIndex = 0
        Me.btnGSMtest.Text = "&Test"
        Me.btnGSMtest.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbSystemShutdown)
        Me.GroupBox1.Controls.Add(Me.chkCShutdownDefault)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpClientShtdown)
        Me.GroupBox1.Controls.Add(Me.btnSet)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System Settings"
        '
        'pbSystemShutdown
        '
        Me.pbSystemShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSystemShutdown.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.HourGlassShutdown
        Me.pbSystemShutdown.Location = New System.Drawing.Point(14, 20)
        Me.pbSystemShutdown.Name = "pbSystemShutdown"
        Me.pbSystemShutdown.Size = New System.Drawing.Size(43, 67)
        Me.pbSystemShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSystemShutdown.TabIndex = 4
        Me.pbSystemShutdown.TabStop = False
        '
        'chkCShutdownDefault
        '
        Me.chkCShutdownDefault.AutoSize = True
        Me.chkCShutdownDefault.Location = New System.Drawing.Point(70, 65)
        Me.chkCShutdownDefault.Name = "chkCShutdownDefault"
        Me.chkCShutdownDefault.Size = New System.Drawing.Size(163, 17)
        Me.chkCShutdownDefault.TabIndex = 6
        Me.chkCShutdownDefault.Text = "Set as default shutdown"
        Me.chkCShutdownDefault.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Shutdown Client at"
        '
        'dtpClientShtdown
        '
        Me.dtpClientShtdown.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClientShtdown.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpClientShtdown.Location = New System.Drawing.Point(188, 26)
        Me.dtpClientShtdown.Name = "dtpClientShtdown"
        Me.dtpClientShtdown.Size = New System.Drawing.Size(140, 26)
        Me.dtpClientShtdown.TabIndex = 2
        '
        'btnSet
        '
        Me.btnSet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.Location = New System.Drawing.Point(248, 58)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(86, 29)
        Me.btnSet.TabIndex = 1
        Me.btnSet.Text = "&Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbTimeOut)
        Me.GroupBox2.Controls.Add(Me.cmbPort)
        Me.GroupBox2.Controls.Add(Me.cmbBaudRate)
        Me.GroupBox2.Controls.Add(Me.btnGSMtest)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 109)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GSM Module Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS
        Me.PictureBox1.Location = New System.Drawing.Point(26, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time out period:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baud Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comm Port:"
        '
        'cmbTimeOut
        '
        Me.cmbTimeOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeOut.FormattingEnabled = True
        Me.cmbTimeOut.Location = New System.Drawing.Point(124, 75)
        Me.cmbTimeOut.Name = "cmbTimeOut"
        Me.cmbTimeOut.Size = New System.Drawing.Size(102, 22)
        Me.cmbTimeOut.TabIndex = 6
        '
        'cmbPort
        '
        Me.cmbPort.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(124, 33)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(102, 22)
        Me.cmbPort.TabIndex = 5
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Location = New System.Drawing.Point(232, 33)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(102, 22)
        Me.cmbBaudRate.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(239, 399)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 29)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.llblChange)
        Me.GroupBox3.Controls.Add(Me.lblPassword)
        Me.GroupBox3.Controls.Add(Me.lblUserID)
        Me.GroupBox3.Controls.Add(Me.lblUserName)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 109)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User profile"
        '
        'llblChange
        '
        Me.llblChange.AutoSize = True
        Me.llblChange.BackColor = System.Drawing.Color.Gray
        Me.llblChange.Location = New System.Drawing.Point(233, 59)
        Me.llblChange.Name = "llblChange"
        Me.llblChange.Size = New System.Drawing.Size(61, 13)
        Me.llblChange.TabIndex = 10
        Me.llblChange.TabStop = True
        Me.llblChange.Text = "Settings.."
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Gray
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(88, 72)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(102, 18)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password: Yes"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.White
        Me.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(91, 26)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(131, 23)
        Me.lblUserID.TabIndex = 7
        Me.lblUserID.Text = "CAMPUSU-0000"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.White
        Me.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(91, 49)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(131, 23)
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "User name"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "USER ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "USER NAME:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 78)
        Me.Label6.TabIndex = 9
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Tools
        Me.pbAnnouncement.Location = New System.Drawing.Point(12, 3)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(46, 41)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 23
        Me.pbAnnouncement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(64, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Settings"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-3, -4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(644, 54)
        Me.Label7.TabIndex = 22
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 436)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbSystemShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGSMtest As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTimeOut As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpClientShtdown As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents chkCShutdownDefault As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pbSystemShutdown As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents llblChange As System.Windows.Forms.LinkLabel
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
