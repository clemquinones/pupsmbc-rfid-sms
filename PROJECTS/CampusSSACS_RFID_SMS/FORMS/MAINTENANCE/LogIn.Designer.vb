<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTrial = New System.Windows.Forms.Label
        Me.lblAccessFailed = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.btnLogIn = New System.Windows.Forms.Button
        Me.pbWarn = New System.Windows.Forms.PictureBox
        Me.lblShutdown = New System.Windows.Forms.Label
        Me.lblCapslock = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pbPadLock = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.pbWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPadLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(95, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 45)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "LOG IN"
        '
        'lblTrial
        '
        Me.lblTrial.AutoSize = True
        Me.lblTrial.BackColor = System.Drawing.Color.Black
        Me.lblTrial.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrial.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTrial.Location = New System.Drawing.Point(538, 86)
        Me.lblTrial.Name = "lblTrial"
        Me.lblTrial.Size = New System.Drawing.Size(86, 14)
        Me.lblTrial.TabIndex = 134
        Me.lblTrial.Text = "No. of trial: "
        Me.lblTrial.Visible = False
        '
        'lblAccessFailed
        '
        Me.lblAccessFailed.AutoSize = True
        Me.lblAccessFailed.BackColor = System.Drawing.Color.Black
        Me.lblAccessFailed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessFailed.ForeColor = System.Drawing.Color.White
        Me.lblAccessFailed.Location = New System.Drawing.Point(515, 251)
        Me.lblAccessFailed.Name = "lblAccessFailed"
        Me.lblAccessFailed.Size = New System.Drawing.Size(109, 16)
        Me.lblAccessFailed.TabIndex = 136
        Me.lblAccessFailed.Text = "Access failed!"
        Me.lblAccessFailed.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "User Name:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(454, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 32)
        Me.btnClose.TabIndex = 131
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(125, 58)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(252, 23)
        Me.txtPassword.TabIndex = 129
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(125, 24)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(252, 23)
        Me.txtUserName.TabIndex = 128
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Gold
        Me.btnLogIn.Location = New System.Drawing.Point(572, 330)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(64, 54)
        Me.btnLogIn.TabIndex = 130
        Me.btnLogIn.Text = "&Log in"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'pbWarn
        '
        Me.pbWarn.BackColor = System.Drawing.Color.Black
        Me.pbWarn.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Exclamation1
        Me.pbWarn.Location = New System.Drawing.Point(507, 76)
        Me.pbWarn.Name = "pbWarn"
        Me.pbWarn.Size = New System.Drawing.Size(25, 23)
        Me.pbWarn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWarn.TabIndex = 135
        Me.pbWarn.TabStop = False
        Me.pbWarn.Visible = False
        '
        'lblShutdown
        '
        Me.lblShutdown.AutoSize = True
        Me.lblShutdown.BackColor = System.Drawing.Color.Transparent
        Me.lblShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShutdown.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShutdown.ForeColor = System.Drawing.Color.Purple
        Me.lblShutdown.Location = New System.Drawing.Point(109, 387)
        Me.lblShutdown.Name = "lblShutdown"
        Me.lblShutdown.Size = New System.Drawing.Size(80, 16)
        Me.lblShutdown.TabIndex = 140
        Me.lblShutdown.Text = "Shutdown"
        '
        'lblCapslock
        '
        Me.lblCapslock.AutoSize = True
        Me.lblCapslock.BackColor = System.Drawing.Color.Black
        Me.lblCapslock.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapslock.ForeColor = System.Drawing.Color.Red
        Me.lblCapslock.Location = New System.Drawing.Point(250, 88)
        Me.lblCapslock.Name = "lblCapslock"
        Me.lblCapslock.Size = New System.Drawing.Size(125, 13)
        Me.lblCapslock.TabIndex = 141
        Me.lblCapslock.Text = "Note: Capslock is on"
        Me.lblCapslock.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 28)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "i log-in si Admin"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 28)
        Me.Button2.TabIndex = 143
        Me.Button2.Text = "i log-in si guard"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.Location = New System.Drawing.Point(301, 97)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(20, 18)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 144
        Me.pbLoading.TabStop = False
        Me.pbLoading.Visible = False
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 2000
        '
        'pbPadLock
        '
        Me.pbPadLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPadLock.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.PadLock
        Me.pbPadLock.Location = New System.Drawing.Point(541, 161)
        Me.pbPadLock.Name = "pbPadLock"
        Me.pbPadLock.Size = New System.Drawing.Size(50, 64)
        Me.pbPadLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPadLock.TabIndex = 145
        Me.pbPadLock.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblCapslock)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 111)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(95, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 51)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "PUP-SMBC Student Monitoring System Using Radio Frequency Identification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With SMS" & _
            " Technology"
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Login_Bluebutton
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 423)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbPadLock)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblShutdown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbWarn)
        Me.Controls.Add(Me.lblTrial)
        Me.Controls.Add(Me.lblAccessFailed)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUP_CAMPUS_SSACS_RFIDSMS - Log in"
        CType(Me.pbWarn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPadLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbWarn As System.Windows.Forms.PictureBox
    Friend WithEvents lblTrial As System.Windows.Forms.Label
    Friend WithEvents lblAccessFailed As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents lblShutdown As System.Windows.Forms.Label
    Friend WithEvents lblCapslock As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLoad As System.Windows.Forms.Timer
    Friend WithEvents pbPadLock As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
