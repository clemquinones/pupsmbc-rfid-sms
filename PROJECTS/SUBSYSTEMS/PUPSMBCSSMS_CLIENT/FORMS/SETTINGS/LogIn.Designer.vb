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
        Me.Button2 = New System.Windows.Forms.Button
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pbPadLock = New System.Windows.Forms.PictureBox
        Me.tmrListener = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPadLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(100, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "LOG IN"
        '
        'lblTrial
        '
        Me.lblTrial.AutoSize = True
        Me.lblTrial.BackColor = System.Drawing.Color.Black
        Me.lblTrial.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrial.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTrial.Location = New System.Drawing.Point(401, 92)
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
        Me.lblAccessFailed.Location = New System.Drawing.Point(83, 307)
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
        Me.Label2.Location = New System.Drawing.Point(100, 195)
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
        Me.Label1.Location = New System.Drawing.Point(100, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "User Name:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(377, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 28)
        Me.btnClose.TabIndex = 131
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(219, 192)
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
        Me.txtUserName.Location = New System.Drawing.Point(219, 158)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(252, 23)
        Me.txtUserName.TabIndex = 128
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.White
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Location = New System.Drawing.Point(277, 261)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(94, 28)
        Me.btnLogIn.TabIndex = 130
        Me.btnLogIn.Text = "&Log in"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'pbWarn
        '
        Me.pbWarn.BackColor = System.Drawing.Color.Black
        Me.pbWarn.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Exclamation1
        Me.pbWarn.Location = New System.Drawing.Point(370, 82)
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
        Me.lblShutdown.ForeColor = System.Drawing.Color.Red
        Me.lblShutdown.Location = New System.Drawing.Point(103, 348)
        Me.lblShutdown.Name = "lblShutdown"
        Me.lblShutdown.Size = New System.Drawing.Size(80, 16)
        Me.lblShutdown.TabIndex = 140
        Me.lblShutdown.Text = "Shutdown"
        Me.lblShutdown.Visible = False
        '
        'lblCapslock
        '
        Me.lblCapslock.AutoSize = True
        Me.lblCapslock.BackColor = System.Drawing.Color.Black
        Me.lblCapslock.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapslock.ForeColor = System.Drawing.Color.Red
        Me.lblCapslock.Location = New System.Drawing.Point(344, 218)
        Me.lblCapslock.Name = "lblCapslock"
        Me.lblCapslock.Size = New System.Drawing.Size(125, 13)
        Me.lblCapslock.TabIndex = 141
        Me.lblCapslock.Text = "Note: Capslock is on"
        Me.lblCapslock.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(23, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 28)
        Me.Button2.TabIndex = 143
        Me.Button2.Text = "i-log in si guard"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.appleload
        Me.pbLoading.Location = New System.Drawing.Point(257, 268)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(16, 14)
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
        Me.pbPadLock.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.PadLock
        Me.pbPadLock.Location = New System.Drawing.Point(112, 232)
        Me.pbPadLock.Name = "pbPadLock"
        Me.pbPadLock.Size = New System.Drawing.Size(50, 64)
        Me.pbPadLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPadLock.TabIndex = 145
        Me.pbPadLock.TabStop = False
        '
        'tmrListener
        '
        Me.tmrListener.Enabled = True
        Me.tmrListener.Interval = 1000
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.LogIn
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(543, 408)
        Me.Controls.Add(Me.pbPadLock)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblCapslock)
        Me.Controls.Add(Me.lblShutdown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbWarn)
        Me.Controls.Add(Me.lblTrial)
        Me.Controls.Add(Me.lblAccessFailed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLoad As System.Windows.Forms.Timer
    Friend WithEvents pbPadLock As System.Windows.Forms.PictureBox
    Friend WithEvents tmrListener As System.Windows.Forms.Timer

End Class
