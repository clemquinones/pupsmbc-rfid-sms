<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.rbRFID = New System.Windows.Forms.RadioButton
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.rbCode = New System.Windows.Forms.RadioButton
        Me.gbVerification = New System.Windows.Forms.GroupBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRFID = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtStudNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.gbShutdown = New System.Windows.Forms.GroupBox
        Me.lblTimeShutdown = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbLog = New System.Windows.Forms.RadioButton
        Me.rbShutdown = New System.Windows.Forms.RadioButton
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.gbVerification.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShutdown.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbRFID
        '
        Me.rbRFID.BackColor = System.Drawing.Color.Gray
        Me.rbRFID.Checked = True
        Me.rbRFID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRFID.ForeColor = System.Drawing.Color.White
        Me.rbRFID.Location = New System.Drawing.Point(16, 76)
        Me.rbRFID.Name = "rbRFID"
        Me.rbRFID.Size = New System.Drawing.Size(297, 18)
        Me.rbRFID.TabIndex = 12
        Me.rbRFID.TabStop = True
        Me.rbRFID.Text = "RFID TAG ID SERIAL ID:"
        Me.rbRFID.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Enabled = False
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCode.Location = New System.Drawing.Point(140, 182)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCode.Size = New System.Drawing.Size(162, 22)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbCode
        '
        Me.rbCode.BackColor = System.Drawing.Color.Gray
        Me.rbCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCode.ForeColor = System.Drawing.Color.White
        Me.rbCode.Location = New System.Drawing.Point(16, 129)
        Me.rbCode.Name = "rbCode"
        Me.rbCode.Size = New System.Drawing.Size(297, 19)
        Me.rbCode.TabIndex = 12
        Me.rbCode.Text = "SECRET CODE:"
        Me.rbCode.UseVisualStyleBackColor = False
        '
        'gbVerification
        '
        Me.gbVerification.BackColor = System.Drawing.SystemColors.Control
        Me.gbVerification.Controls.Add(Me.btnSubmit)
        Me.gbVerification.Controls.Add(Me.Label8)
        Me.gbVerification.Controls.Add(Me.Label7)
        Me.gbVerification.Controls.Add(Me.Label5)
        Me.gbVerification.Controls.Add(Me.txtRFID)
        Me.gbVerification.Controls.Add(Me.Label4)
        Me.gbVerification.Controls.Add(Me.PictureBox1)
        Me.gbVerification.Controls.Add(Me.rbCode)
        Me.gbVerification.Controls.Add(Me.txtStudNo)
        Me.gbVerification.Controls.Add(Me.txtCode)
        Me.gbVerification.Controls.Add(Me.rbRFID)
        Me.gbVerification.Controls.Add(Me.Label1)
        Me.gbVerification.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVerification.ForeColor = System.Drawing.Color.Blue
        Me.gbVerification.Location = New System.Drawing.Point(26, 85)
        Me.gbVerification.Name = "gbVerification"
        Me.gbVerification.Size = New System.Drawing.Size(319, 248)
        Me.gbVerification.TabIndex = 13
        Me.gbVerification.TabStop = False
        Me.gbVerification.Text = "Enter verification code"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(168, 210)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 29)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(65, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Student #:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(51, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Secret Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "RFID SERIAL ID:"
        '
        'txtRFID
        '
        Me.txtRFID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Gray
        Me.txtRFID.Location = New System.Drawing.Point(140, 100)
        Me.txtRFID.Mask = "•• •• •• ••"
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(162, 26)
        Me.txtRFID.TabIndex = 27
        Me.txtRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(69, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Verify your Identification"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Log
        Me.PictureBox1.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'txtStudNo
        '
        Me.txtStudNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudNo.Enabled = False
        Me.txtStudNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNo.ForeColor = System.Drawing.Color.Gray
        Me.txtStudNo.Location = New System.Drawing.Point(140, 154)
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(162, 22)
        Me.txtStudNo.TabIndex = 1
        Me.txtStudNo.Text = "STUDENT NUMBER"
        Me.txtStudNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 54)
        Me.Label1.TabIndex = 26
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.White
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(39, 15)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(183, 13)
        Me.lblDescription.TabIndex = 24
        Me.lblDescription.Text = "This will log you by verification"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, -5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(644, 54)
        Me.Label6.TabIndex = 25
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Information
        Me.pbAnnouncement.Location = New System.Drawing.Point(13, 12)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(20, 20)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 26
        Me.pbAnnouncement.TabStop = False
        '
        'gbShutdown
        '
        Me.gbShutdown.Controls.Add(Me.lblTimeShutdown)
        Me.gbShutdown.Controls.Add(Me.Button2)
        Me.gbShutdown.Controls.Add(Me.PictureBox2)
        Me.gbShutdown.Controls.Add(Me.Label11)
        Me.gbShutdown.Controls.Add(Me.Label9)
        Me.gbShutdown.Enabled = False
        Me.gbShutdown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShutdown.Location = New System.Drawing.Point(26, 365)
        Me.gbShutdown.Name = "gbShutdown"
        Me.gbShutdown.Size = New System.Drawing.Size(319, 152)
        Me.gbShutdown.TabIndex = 27
        Me.gbShutdown.TabStop = False
        Me.gbShutdown.Text = "Shutdown"
        '
        'lblTimeShutdown
        '
        Me.lblTimeShutdown.ForeColor = System.Drawing.Color.Black
        Me.lblTimeShutdown.Location = New System.Drawing.Point(3, 73)
        Me.lblTimeShutdown.Name = "lblTimeShutdown"
        Me.lblTimeShutdown.Size = New System.Drawing.Size(156, 76)
        Me.lblTimeShutdown.TabIndex = 29
        Me.lblTimeShutdown.Text = "System will automatically shutdown @ 00:00:00"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(170, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 29)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Shutdown Now"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Logout
        Me.PictureBox2.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(69, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Shutdown Client"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-1, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(517, 54)
        Me.Label9.TabIndex = 26
        '
        'rbLog
        '
        Me.rbLog.AutoSize = True
        Me.rbLog.BackColor = System.Drawing.SystemColors.Control
        Me.rbLog.Checked = True
        Me.rbLog.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLog.ForeColor = System.Drawing.Color.Black
        Me.rbLog.Location = New System.Drawing.Point(6, 59)
        Me.rbLog.Name = "rbLog"
        Me.rbLog.Size = New System.Drawing.Size(148, 20)
        Me.rbLog.TabIndex = 28
        Me.rbLog.TabStop = True
        Me.rbLog.Text = "Log by verification"
        Me.rbLog.UseVisualStyleBackColor = False
        '
        'rbShutdown
        '
        Me.rbShutdown.AutoSize = True
        Me.rbShutdown.BackColor = System.Drawing.SystemColors.Control
        Me.rbShutdown.Checked = True
        Me.rbShutdown.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShutdown.ForeColor = System.Drawing.Color.Black
        Me.rbShutdown.Location = New System.Drawing.Point(6, 339)
        Me.rbShutdown.Name = "rbShutdown"
        Me.rbShutdown.Size = New System.Drawing.Size(134, 20)
        Me.rbShutdown.TabIndex = 28
        Me.rbShutdown.TabStop = True
        Me.rbShutdown.Text = "Shutdown Client"
        Me.rbShutdown.UseVisualStyleBackColor = False
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 529)
        Me.Controls.Add(Me.rbShutdown)
        Me.Controls.Add(Me.rbLog)
        Me.Controls.Add(Me.gbShutdown)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbVerification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.gbVerification.ResumeLayout(False)
        Me.gbVerification.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShutdown.ResumeLayout(False)
        Me.gbShutdown.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbRFID As System.Windows.Forms.RadioButton
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents rbCode As System.Windows.Forms.RadioButton
    Friend WithEvents gbVerification As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtStudNo As System.Windows.Forms.TextBox
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRFID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbShutdown As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTimeShutdown As System.Windows.Forms.Label
    Friend WithEvents rbLog As System.Windows.Forms.RadioButton
    Friend WithEvents rbShutdown As System.Windows.Forms.RadioButton
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
End Class
