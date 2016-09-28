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
        Me.lblStatus = New System.Windows.Forms.Label
        Me.gbConn = New System.Windows.Forms.GroupBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDataSource = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblSaved = New System.Windows.Forms.Label
        Me.gbLocalMachine = New System.Windows.Forms.GroupBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbTO = New System.Windows.Forms.ComboBox
        Me.cmbBR = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbP = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbConn.SuspendLayout()
        Me.gbLocalMachine.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gbConn.Controls.Add(Me.btnSubmit)
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
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Gold
        Me.btnSubmit.Location = New System.Drawing.Point(106, 139)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(151, 34)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
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
        Me.lblSaved.Location = New System.Drawing.Point(285, 208)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(221, 26)
        Me.lblSaved.TabIndex = 17
        Me.lblSaved.Text = "Saved!"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSaved.Visible = False
        '
        'gbLocalMachine
        '
        Me.gbLocalMachine.BackColor = System.Drawing.Color.Transparent
        Me.gbLocalMachine.Controls.Add(Me.btnTest)
        Me.gbLocalMachine.Controls.Add(Me.Label7)
        Me.gbLocalMachine.Controls.Add(Me.Label6)
        Me.gbLocalMachine.Controls.Add(Me.cmbTO)
        Me.gbLocalMachine.Controls.Add(Me.cmbBR)
        Me.gbLocalMachine.Controls.Add(Me.Label5)
        Me.gbLocalMachine.Controls.Add(Me.cmbP)
        Me.gbLocalMachine.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLocalMachine.ForeColor = System.Drawing.Color.Gold
        Me.gbLocalMachine.Location = New System.Drawing.Point(285, 52)
        Me.gbLocalMachine.Name = "gbLocalMachine"
        Me.gbLocalMachine.Size = New System.Drawing.Size(228, 153)
        Me.gbLocalMachine.TabIndex = 18
        Me.gbLocalMachine.TabStop = False
        Me.gbLocalMachine.Text = "GSM Module Settings"
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.Black
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(88, 116)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(133, 28)
        Me.btnTest.TabIndex = 17
        Me.btnTest.Text = "TEST"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Time Out:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Baud Rate:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTO
        '
        Me.cmbTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTO.FormattingEnabled = True
        Me.cmbTO.Items.AddRange(New Object() {"150", "300", "600", "900", "1200", "1500", "1800", "2000"})
        Me.cmbTO.Location = New System.Drawing.Point(88, 84)
        Me.cmbTO.Name = "cmbTO"
        Me.cmbTO.Size = New System.Drawing.Size(133, 22)
        Me.cmbTO.TabIndex = 10
        '
        'cmbBR
        '
        Me.cmbBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBR.FormattingEnabled = True
        Me.cmbBR.Items.AddRange(New Object() {"9600", "19200", "3800", "57600", "115200"})
        Me.cmbBR.Location = New System.Drawing.Point(88, 53)
        Me.cmbBR.Name = "cmbBR"
        Me.cmbBR.Size = New System.Drawing.Size(133, 22)
        Me.cmbBR.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "COM PORT:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbP
        '
        Me.cmbP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbP.FormattingEnabled = True
        Me.cmbP.Location = New System.Drawing.Point(88, 23)
        Me.cmbP.Name = "cmbP"
        Me.cmbP.Size = New System.Drawing.Size(133, 22)
        Me.cmbP.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(498, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Set-up Server connection and SMS Sender Configuration"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sampleReceive.My.Resources.Resources.StudLogRecord
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 291)
        Me.Controls.Add(Me.Label8)
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
        Me.gbLocalMachine.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gbConn As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataSource As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents gbLocalMachine As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTO As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBR As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbP As System.Windows.Forms.ComboBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
