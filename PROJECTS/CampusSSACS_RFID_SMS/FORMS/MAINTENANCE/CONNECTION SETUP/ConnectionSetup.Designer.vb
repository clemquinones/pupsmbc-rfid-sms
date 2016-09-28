<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSetup
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
        Me.rbClient = New System.Windows.Forms.RadioButton
        Me.lblStatus = New System.Windows.Forms.Label
        Me.gbConn = New System.Windows.Forms.GroupBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDataSource = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.rbServer = New System.Windows.Forms.RadioButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblSaved = New System.Windows.Forms.Label
        Me.gbLocalMachine = New System.Windows.Forms.GroupBox
        Me.gbConn.SuspendLayout()
        Me.gbLocalMachine.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbClient
        '
        Me.rbClient.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClient.Location = New System.Drawing.Point(10, 24)
        Me.rbClient.Name = "rbClient"
        Me.rbClient.Size = New System.Drawing.Size(218, 18)
        Me.rbClient.TabIndex = 13
        Me.rbClient.TabStop = True
        Me.rbClient.Text = "This is the client system"
        Me.rbClient.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(7, 177)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(250, 17)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Status: NOT CONNECTED"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbConn
        '
        Me.gbConn.Controls.Add(Me.lblStatus)
        Me.gbConn.Controls.Add(Me.btnTest)
        Me.gbConn.Controls.Add(Me.Label4)
        Me.gbConn.Controls.Add(Me.txtDataSource)
        Me.gbConn.Controls.Add(Me.Label3)
        Me.gbConn.Controls.Add(Me.txtUserID)
        Me.gbConn.Controls.Add(Me.Label2)
        Me.gbConn.Controls.Add(Me.txtPassword)
        Me.gbConn.Controls.Add(Me.Label1)
        Me.gbConn.Controls.Add(Me.txtDatabase)
        Me.gbConn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConn.Location = New System.Drawing.Point(12, 12)
        Me.gbConn.Name = "gbConn"
        Me.gbConn.Size = New System.Drawing.Size(263, 201)
        Me.gbConn.TabIndex = 15
        Me.gbConn.TabStop = False
        Me.gbConn.Text = "Connection"
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.White
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(112, 139)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(136, 27)
        Me.btnTest.TabIndex = 4
        Me.btnTest.Text = "&Test Connection"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Database:"
        '
        'txtDataSource
        '
        Me.txtDataSource.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataSource.Location = New System.Drawing.Point(97, 20)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(151, 26)
        Me.txtDataSource.TabIndex = 0
        Me.txtDataSource.Text = "localhost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password:"
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(97, 49)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(151, 26)
        Me.txtUserID.TabIndex = 1
        Me.txtUserID.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "User ID:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(97, 78)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(151, 26)
        Me.txtPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Source:"
        '
        'txtDatabase
        '
        Me.txtDatabase.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Location = New System.Drawing.Point(97, 107)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(151, 26)
        Me.txtDatabase.TabIndex = 3
        Me.txtDatabase.Text = "db_campus"
        '
        'rbServer
        '
        Me.rbServer.Checked = True
        Me.rbServer.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServer.Location = New System.Drawing.Point(10, 48)
        Me.rbServer.Name = "rbServer"
        Me.rbServer.Size = New System.Drawing.Size(218, 18)
        Me.rbServer.TabIndex = 14
        Me.rbServer.TabStop = True
        Me.rbServer.Text = "This is the server system"
        Me.rbServer.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(380, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 27)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "&Save Connection"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblSaved
        '
        Me.lblSaved.Location = New System.Drawing.Point(380, 158)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(136, 18)
        Me.lblSaved.TabIndex = 17
        Me.lblSaved.Text = "Saved!"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSaved.Visible = False
        '
        'gbLocalMachine
        '
        Me.gbLocalMachine.Controls.Add(Me.rbClient)
        Me.gbLocalMachine.Controls.Add(Me.rbServer)
        Me.gbLocalMachine.Enabled = False
        Me.gbLocalMachine.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLocalMachine.Location = New System.Drawing.Point(281, 22)
        Me.gbLocalMachine.Name = "gbLocalMachine"
        Me.gbLocalMachine.Size = New System.Drawing.Size(235, 76)
        Me.gbLocalMachine.TabIndex = 18
        Me.gbLocalMachine.TabStop = False
        Me.gbLocalMachine.Text = "Local Machine Type"
        '
        'frmConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 220)
        Me.Controls.Add(Me.gbLocalMachine)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.gbConn)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmConnectionSetup"
        Me.Text = "ConnectionSetup"
        Me.gbConn.ResumeLayout(False)
        Me.gbConn.PerformLayout()
        Me.gbLocalMachine.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbClient As System.Windows.Forms.RadioButton
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gbConn As System.Windows.Forms.GroupBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataSource As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents rbServer As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents gbLocalMachine As System.Windows.Forms.GroupBox
End Class
