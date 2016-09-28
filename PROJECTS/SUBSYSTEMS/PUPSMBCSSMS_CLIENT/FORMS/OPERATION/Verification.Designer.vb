<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeriication
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRFID = New System.Windows.Forms.MaskedTextBox
        Me.txtStudNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.vdgv = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lblTimeShutdown = New System.Windows.Forms.Label
        Me.btnShutdown = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbShutdown = New System.Windows.Forms.GroupBox
        Me.gbVerify = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnShutdownGB = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.gbVerification.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vdgv.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbShutdown.SuspendLayout()
        Me.gbVerify.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbRFID
        '
        Me.rbRFID.BackColor = System.Drawing.Color.Transparent
        Me.rbRFID.Checked = True
        Me.rbRFID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbRFID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRFID.ForeColor = System.Drawing.Color.Gold
        Me.rbRFID.Location = New System.Drawing.Point(5, 21)
        Me.rbRFID.Name = "rbRFID"
        Me.rbRFID.Size = New System.Drawing.Size(307, 18)
        Me.rbRFID.TabIndex = 12
        Me.rbRFID.TabStop = True
        Me.rbRFID.Text = "RFID TAG ID SERIAL ID:"
        Me.rbRFID.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCode.Location = New System.Drawing.Point(140, 154)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCode.Size = New System.Drawing.Size(173, 22)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbCode
        '
        Me.rbCode.BackColor = System.Drawing.Color.Transparent
        Me.rbCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCode.ForeColor = System.Drawing.Color.Gold
        Me.rbCode.Location = New System.Drawing.Point(9, 101)
        Me.rbCode.Name = "rbCode"
        Me.rbCode.Size = New System.Drawing.Size(304, 19)
        Me.rbCode.TabIndex = 12
        Me.rbCode.Text = "SECRET CODE:"
        Me.rbCode.UseVisualStyleBackColor = False
        '
        'gbVerification
        '
        Me.gbVerification.BackColor = System.Drawing.Color.Black
        Me.gbVerification.Controls.Add(Me.Label8)
        Me.gbVerification.Controls.Add(Me.Label7)
        Me.gbVerification.Controls.Add(Me.Label5)
        Me.gbVerification.Controls.Add(Me.txtRFID)
        Me.gbVerification.Controls.Add(Me.rbCode)
        Me.gbVerification.Controls.Add(Me.txtStudNo)
        Me.gbVerification.Controls.Add(Me.txtCode)
        Me.gbVerification.Controls.Add(Me.rbRFID)
        Me.gbVerification.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVerification.ForeColor = System.Drawing.Color.White
        Me.gbVerification.Location = New System.Drawing.Point(13, 73)
        Me.gbVerification.Name = "gbVerification"
        Me.gbVerification.Size = New System.Drawing.Size(319, 191)
        Me.gbVerification.TabIndex = 13
        Me.gbVerification.TabStop = False
        Me.gbVerification.Text = "Enter verification code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(59, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Student #:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(45, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Pass Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "RFID SERIAL ID:"
        '
        'txtRFID
        '
        Me.txtRFID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Gray
        Me.txtRFID.Location = New System.Drawing.Point(139, 45)
        Me.txtRFID.Mask = "AA AA AA AA"
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(173, 26)
        Me.txtRFID.SkipLiterals = False
        Me.txtRFID.TabIndex = 27
        Me.txtRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudNo
        '
        Me.txtStudNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNo.ForeColor = System.Drawing.Color.Gray
        Me.txtStudNo.Location = New System.Drawing.Point(140, 126)
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(173, 22)
        Me.txtStudNo.TabIndex = 1
        Me.txtStudNo.Text = "STUDENT NUMBER"
        Me.txtStudNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(81, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Verify your Identification"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.check
        Me.PictureBox1.Location = New System.Drawing.Point(27, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 54)
        Me.Label1.TabIndex = 26
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Black
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Gold
        Me.btnSubmit.Location = New System.Drawing.Point(90, 16)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 40)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'vdgv
        '
        Me.vdgv.BackColor = System.Drawing.Color.Black
        Me.vdgv.Controls.Add(Me.PictureBox3)
        Me.vdgv.Controls.Add(Me.lblTimeShutdown)
        Me.vdgv.Controls.Add(Me.btnShutdown)
        Me.vdgv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdgv.ForeColor = System.Drawing.Color.Gold
        Me.vdgv.Location = New System.Drawing.Point(14, 73)
        Me.vdgv.Name = "vdgv"
        Me.vdgv.Size = New System.Drawing.Size(319, 238)
        Me.vdgv.TabIndex = 27
        Me.vdgv.TabStop = False
        Me.vdgv.Text = "Shutdown"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.HourGlassShutdown
        Me.PictureBox3.Location = New System.Drawing.Point(18, 122)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'lblTimeShutdown
        '
        Me.lblTimeShutdown.ForeColor = System.Drawing.Color.White
        Me.lblTimeShutdown.Location = New System.Drawing.Point(6, 23)
        Me.lblTimeShutdown.Name = "lblTimeShutdown"
        Me.lblTimeShutdown.Size = New System.Drawing.Size(307, 76)
        Me.lblTimeShutdown.TabIndex = 29
        Me.lblTimeShutdown.Text = "System will automatically shutdown @ 00:00:00"
        Me.lblTimeShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShutdown
        '
        Me.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShutdown.Enabled = False
        Me.btnShutdown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.ForeColor = System.Drawing.Color.Black
        Me.btnShutdown.Location = New System.Drawing.Point(170, 170)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(134, 29)
        Me.btnShutdown.TabIndex = 28
        Me.btnShutdown.Text = "Shutdown Now!"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Logout
        Me.PictureBox2.Location = New System.Drawing.Point(18, 19)
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
        Me.Label11.Location = New System.Drawing.Point(81, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Shutdown Client"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(320, 54)
        Me.Label9.TabIndex = 26
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(128, 317)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 29)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'gbShutdown
        '
        Me.gbShutdown.BackColor = System.Drawing.Color.Transparent
        Me.gbShutdown.Controls.Add(Me.btnClose)
        Me.gbShutdown.Controls.Add(Me.PictureBox2)
        Me.gbShutdown.Controls.Add(Me.Label11)
        Me.gbShutdown.Controls.Add(Me.Label9)
        Me.gbShutdown.Controls.Add(Me.vdgv)
        Me.gbShutdown.Location = New System.Drawing.Point(378, 12)
        Me.gbShutdown.Name = "gbShutdown"
        Me.gbShutdown.Size = New System.Drawing.Size(345, 351)
        Me.gbShutdown.TabIndex = 30
        Me.gbShutdown.TabStop = False
        Me.gbShutdown.Visible = False
        '
        'gbVerify
        '
        Me.gbVerify.BackColor = System.Drawing.Color.Transparent
        Me.gbVerify.Controls.Add(Me.GroupBox1)
        Me.gbVerify.Controls.Add(Me.gbVerification)
        Me.gbVerify.Controls.Add(Me.Label4)
        Me.gbVerify.Controls.Add(Me.Label1)
        Me.gbVerify.Controls.Add(Me.PictureBox1)
        Me.gbVerify.Location = New System.Drawing.Point(12, 12)
        Me.gbVerify.Name = "gbVerify"
        Me.gbVerify.Size = New System.Drawing.Size(345, 352)
        Me.gbVerify.TabIndex = 31
        Me.gbVerify.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 65)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnShutdownGB
        '
        Me.btnShutdownGB.BackColor = System.Drawing.Color.Black
        Me.btnShutdownGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShutdownGB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdownGB.ForeColor = System.Drawing.Color.Gold
        Me.btnShutdownGB.Location = New System.Drawing.Point(218, 393)
        Me.btnShutdownGB.Name = "btnShutdownGB"
        Me.btnShutdownGB.Size = New System.Drawing.Size(135, 29)
        Me.btnShutdownGB.TabIndex = 32
        Me.btnShutdownGB.Text = "&Shutdown..."
        Me.btnShutdownGB.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(15, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(134, 29)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmVeriication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Verify
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 445)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnShutdownGB)
        Me.Controls.Add(Me.gbVerify)
        Me.Controls.Add(Me.gbShutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVeriication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.gbVerification.ResumeLayout(False)
        Me.gbVerification.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vdgv.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbShutdown.ResumeLayout(False)
        Me.gbShutdown.PerformLayout()
        Me.gbVerify.ResumeLayout(False)
        Me.gbVerify.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbRFID As System.Windows.Forms.RadioButton
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents rbCode As System.Windows.Forms.RadioButton
    Friend WithEvents gbVerification As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtStudNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRFID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents vdgv As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents lblTimeShutdown As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gbShutdown As System.Windows.Forms.GroupBox
    Friend WithEvents gbVerify As System.Windows.Forms.GroupBox
    Friend WithEvents btnShutdownGB As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
