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
        Me.rbLogOut = New System.Windows.Forms.RadioButton
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
        Me.rbLogIn = New System.Windows.Forms.RadioButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblSaved = New System.Windows.Forms.Label
        Me.gbLocalMachine = New System.Windows.Forms.GroupBox
        Me.gbConn.SuspendLayout()
        Me.gbLocalMachine.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbLogOut
        '
        Me.rbLogOut.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLogOut.ForeColor = System.Drawing.Color.White
        Me.rbLogOut.Location = New System.Drawing.Point(10, 58)
        Me.rbLogOut.Name = "rbLogOut"
        Me.rbLogOut.Size = New System.Drawing.Size(218, 18)
        Me.rbLogOut.TabIndex = 13
        Me.rbLogOut.TabStop = True
        Me.rbLogOut.Text = "This machine is for log out."
        Me.rbLogOut.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(9, 255)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(263, 26)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Status: NOT CONNECTED"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbConn
        '
        Me.gbConn.BackColor = System.Drawing.Color.Transparent
        Me.gbConn.Controls.Add(Me.btnTest)
        Me.gbConn.Controls.Add(Me.Label4)
        Me.gbConn.Controls.Add(Me.txtDataSource)
        Me.gbConn.Controls.Add(Me.Label3)
        Me.gbConn.Controls.Add(Me.txtUserID)
        Me.gbConn.Controls.Add(Me.Label2)
        Me.gbConn.Controls.Add(Me.txtPassword)
        Me.gbConn.Controls.Add(Me.Label1)
        Me.gbConn.Controls.Add(Me.txtDatabase)
        Me.gbConn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConn.ForeColor = System.Drawing.Color.Gold
        Me.gbConn.Location = New System.Drawing.Point(12, 52)
        Me.gbConn.Name = "gbConn"
        Me.gbConn.Size = New System.Drawing.Size(263, 179)
        Me.gbConn.TabIndex = 15
        Me.gbConn.TabStop = False
        Me.gbConn.Text = "Connection"
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.White
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.Black
        Me.btnTest.Location = New System.Drawing.Point(121, 139)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(136, 27)
        Me.btnTest.TabIndex = 4
        Me.btnTest.Text = "&Test Connection"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Database:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataSource
        '
        Me.txtDataSource.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataSource.Location = New System.Drawing.Point(106, 19)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(151, 26)
        Me.txtDataSource.TabIndex = 0
        Me.txtDataSource.Text = "localhost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(106, 48)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(151, 26)
        Me.txtUserID.TabIndex = 1
        Me.txtUserID.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "User ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(106, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(151, 26)
        Me.txtPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Source:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDatabase
        '
        Me.txtDatabase.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Location = New System.Drawing.Point(106, 106)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(151, 26)
        Me.txtDatabase.TabIndex = 3
        Me.txtDatabase.Text = "db_campus"
        '
        'rbLogIn
        '
        Me.rbLogIn.Checked = True
        Me.rbLogIn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLogIn.ForeColor = System.Drawing.Color.White
        Me.rbLogIn.Location = New System.Drawing.Point(10, 31)
        Me.rbLogIn.Name = "rbLogIn"
        Me.rbLogIn.Size = New System.Drawing.Size(218, 18)
        Me.rbLogIn.TabIndex = 14
        Me.rbLogIn.TabStop = True
        Me.rbLogIn.Text = "This machine is for log in."
        Me.rbLogIn.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(285, 255)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 27)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "&Save Connection"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.Transparent
        Me.lblSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaved.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.White
        Me.lblSaved.Location = New System.Drawing.Point(285, 224)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(221, 22)
        Me.lblSaved.TabIndex = 17
        Me.lblSaved.Text = "Saved!"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSaved.Visible = False
        '
        'gbLocalMachine
        '
        Me.gbLocalMachine.BackColor = System.Drawing.Color.Transparent
        Me.gbLocalMachine.Controls.Add(Me.rbLogOut)
        Me.gbLocalMachine.Controls.Add(Me.rbLogIn)
        Me.gbLocalMachine.Enabled = False
        Me.gbLocalMachine.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLocalMachine.ForeColor = System.Drawing.Color.Gold
        Me.gbLocalMachine.Location = New System.Drawing.Point(282, 96)
        Me.gbLocalMachine.Name = "gbLocalMachine"
        Me.gbLocalMachine.Size = New System.Drawing.Size(228, 92)
        Me.gbLocalMachine.TabIndex = 18
        Me.gbLocalMachine.TabStop = False
        Me.gbLocalMachine.Text = "Local Machine Type"
        '
        'frmConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.StudLogRecord1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 291)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.gbLocalMachine)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.gbConn)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmConnectionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Setup"
        Me.gbConn.ResumeLayout(False)
        Me.gbConn.PerformLayout()
        Me.gbLocalMachine.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbLogOut As System.Windows.Forms.RadioButton
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
    Friend WithEvents rbLogIn As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents gbLocalMachine As System.Windows.Forms.GroupBox
End Class
