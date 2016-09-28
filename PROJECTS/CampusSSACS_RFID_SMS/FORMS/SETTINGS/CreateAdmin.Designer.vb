<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAdmin
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
        Me.gbName = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPassword1 = New System.Windows.Forms.TextBox
        Me.txtPassword2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.pbAdmin = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbName.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 78)
        Me.Label1.TabIndex = 3
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbName
        '
        Me.gbName.BackColor = System.Drawing.Color.Black
        Me.gbName.Controls.Add(Me.Label7)
        Me.gbName.Controls.Add(Me.Label6)
        Me.gbName.Controls.Add(Me.txtLName)
        Me.gbName.Controls.Add(Me.txtFName)
        Me.gbName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbName.ForeColor = System.Drawing.Color.Gold
        Me.gbName.Location = New System.Drawing.Point(12, 91)
        Me.gbName.Name = "gbName"
        Me.gbName.Size = New System.Drawing.Size(318, 97)
        Me.gbName.TabIndex = 4
        Me.gbName.TabStop = False
        Me.gbName.Text = "Administrator Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(35, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "*Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(35, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "*First Name:"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.Color.Gray
        Me.txtLName.Location = New System.Drawing.Point(133, 52)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(159, 22)
        Me.txtLName.TabIndex = 1
        Me.txtLName.Text = "Last"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.Gray
        Me.txtFName.Location = New System.Drawing.Point(133, 26)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(159, 22)
        Me.txtFName.TabIndex = 0
        Me.txtFName.Text = "First"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Gold
        Me.btnNext.Location = New System.Drawing.Point(100, 438)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 34)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "&Continue"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(213, 438)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 34)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUserID)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword1)
        Me.GroupBox1.Controls.Add(Me.txtPassword2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(13, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 160)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access Security"
        '
        'txtUserID
        '
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.Color.Black
        Me.txtUserID.Location = New System.Drawing.Point(133, 28)
        Me.txtUserID.MaxLength = 7
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(97, 22)
        Me.txtUserID.TabIndex = 2
        Me.txtUserID.Text = "CAMPUSU"
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(72, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "User ID:"
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.White
        Me.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.Black
        Me.lblUserID.Location = New System.Drawing.Point(231, 28)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(61, 23)
        Me.lblUserID.TabIndex = 10
        Me.lblUserID.Text = "-00000"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Gray
        Me.txtUserName.Location = New System.Drawing.Point(132, 71)
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(159, 22)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Text = "USER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(44, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "*User Name:"
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword1.Location = New System.Drawing.Point(132, 99)
        Me.txtPassword1.MaxLength = 12
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword1.Size = New System.Drawing.Size(159, 22)
        Me.txtPassword1.TabIndex = 4
        '
        'txtPassword2
        '
        Me.txtPassword2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword2.Location = New System.Drawing.Point(132, 127)
        Me.txtPassword2.MaxLength = 12
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword2.Size = New System.Drawing.Size(159, 22)
        Me.txtPassword2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(48, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "*Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(26, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "*Re-Type Pass:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNumber)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(13, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 63)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remote System"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(82, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 14)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Cell #:"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.Gray
        Me.txtNumber.Location = New System.Drawing.Point(133, 26)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(159, 22)
        Me.txtNumber.TabIndex = 6
        Me.txtNumber.Text = "Number"
        '
        'pbAdmin
        '
        Me.pbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAdmin.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.AdminSettings
        Me.pbAdmin.Location = New System.Drawing.Point(12, 10)
        Me.pbAdmin.Name = "pbAdmin"
        Me.pbAdmin.Size = New System.Drawing.Size(97, 56)
        Me.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdmin.TabIndex = 15
        Me.pbAdmin.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(129, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 27)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Create System Administrator"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(344, 480)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pbAdmin)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create System: Level 1 Administrator"
        Me.TopMost = True
        Me.gbName.ResumeLayout(False)
        Me.gbName.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbName As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents pbAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
