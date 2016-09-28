<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtNewPass1 = New System.Windows.Forms.TextBox
        Me.txtNewPass2 = New System.Windows.Forms.TextBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkPass = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(122, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User name:"
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.White
        Me.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(194, 61)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(131, 23)
        Me.lblUserID.TabIndex = 9
        Me.lblUserID.Text = "CAMPUSU-0000"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(130, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "USER ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Old Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "New Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Re-type Password:"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Gray
        Me.txtUserName.Location = New System.Drawing.Point(194, 87)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(131, 22)
        Me.txtUserName.TabIndex = 10
        Me.txtUserName.Text = "User name"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(123, 20)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(134, 22)
        Me.txtPassword.TabIndex = 10
        '
        'txtNewPass1
        '
        Me.txtNewPass1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass1.ForeColor = System.Drawing.Color.Black
        Me.txtNewPass1.Location = New System.Drawing.Point(123, 48)
        Me.txtNewPass1.Name = "txtNewPass1"
        Me.txtNewPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass1.Size = New System.Drawing.Size(134, 22)
        Me.txtNewPass1.TabIndex = 10
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass2.ForeColor = System.Drawing.Color.Black
        Me.txtNewPass2.Location = New System.Drawing.Point(123, 76)
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass2.Size = New System.Drawing.Size(134, 22)
        Me.txtNewPass2.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(169, 257)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 28)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(257, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 28)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNewPass2)
        Me.GroupBox1.Controls.Add(Me.txtNewPass1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(68, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 108)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change password"
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.Location = New System.Drawing.Point(68, 120)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(128, 17)
        Me.chkPass.TabIndex = 14
        Me.chkPass.Text = "Change password"
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(62, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Update user profile"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-5, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(644, 54)
        Me.Label6.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 65)
        Me.Label7.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Security
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Profile
        Me.pbAnnouncement.Location = New System.Drawing.Point(10, 5)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(46, 41)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 23
        Me.pbAnnouncement.TabStop = False
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 288)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkPass)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass2 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPass As System.Windows.Forms.CheckBox
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
