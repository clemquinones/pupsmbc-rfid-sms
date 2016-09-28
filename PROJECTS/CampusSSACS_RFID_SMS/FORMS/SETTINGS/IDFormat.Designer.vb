<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIDFormat
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.llblAnn = New System.Windows.Forms.LinkLabel
        Me.txtAnn = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.llblPass = New System.Windows.Forms.LinkLabel
        Me.txtPassCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.llblMonitoring = New System.Windows.Forms.LinkLabel
        Me.txtMonitoring = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.llblLog = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLogs = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPrev = New System.Windows.Forms.Label
        Me.lDef = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.llblAnn)
        Me.GroupBox1.Controls.Add(Me.txtAnn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.llblPass)
        Me.GroupBox1.Controls.Add(Me.txtPassCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.llblMonitoring)
        Me.GroupBox1.Controls.Add(Me.txtMonitoring)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.llblLog)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLogs)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 183)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System ID Format"
        '
        'llblAnn
        '
        Me.llblAnn.AutoSize = True
        Me.llblAnn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblAnn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblAnn.Location = New System.Drawing.Point(311, 136)
        Me.llblAnn.Name = "llblAnn"
        Me.llblAnn.Size = New System.Drawing.Size(52, 14)
        Me.llblAnn.TabIndex = 12
        Me.llblAnn.TabStop = True
        Me.llblAnn.Text = "Default"
        '
        'txtAnn
        '
        Me.txtAnn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnn.ForeColor = System.Drawing.Color.Gray
        Me.txtAnn.Location = New System.Drawing.Point(120, 131)
        Me.txtAnn.MaxLength = 7
        Me.txtAnn.Name = "txtAnn"
        Me.txtAnn.Size = New System.Drawing.Size(185, 22)
        Me.txtAnn.TabIndex = 3
        Me.txtAnn.Text = "CAMPUSA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ANNOUNCEMENT:"
        '
        'llblPass
        '
        Me.llblPass.AutoSize = True
        Me.llblPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblPass.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblPass.Location = New System.Drawing.Point(311, 102)
        Me.llblPass.Name = "llblPass"
        Me.llblPass.Size = New System.Drawing.Size(52, 14)
        Me.llblPass.TabIndex = 9
        Me.llblPass.TabStop = True
        Me.llblPass.Text = "Default"
        '
        'txtPassCode
        '
        Me.txtPassCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassCode.ForeColor = System.Drawing.Color.Gray
        Me.txtPassCode.Location = New System.Drawing.Point(120, 99)
        Me.txtPassCode.MaxLength = 7
        Me.txtPassCode.Name = "txtPassCode"
        Me.txtPassCode.Size = New System.Drawing.Size(185, 22)
        Me.txtPassCode.TabIndex = 2
        Me.txtPassCode.Text = "PUP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PASSCODE:"
        '
        'llblMonitoring
        '
        Me.llblMonitoring.AutoSize = True
        Me.llblMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblMonitoring.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblMonitoring.Location = New System.Drawing.Point(311, 70)
        Me.llblMonitoring.Name = "llblMonitoring"
        Me.llblMonitoring.Size = New System.Drawing.Size(52, 14)
        Me.llblMonitoring.TabIndex = 6
        Me.llblMonitoring.TabStop = True
        Me.llblMonitoring.Text = "Default"
        '
        'txtMonitoring
        '
        Me.txtMonitoring.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonitoring.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonitoring.ForeColor = System.Drawing.Color.Gray
        Me.txtMonitoring.Location = New System.Drawing.Point(120, 67)
        Me.txtMonitoring.MaxLength = 7
        Me.txtMonitoring.Name = "txtMonitoring"
        Me.txtMonitoring.Size = New System.Drawing.Size(185, 22)
        Me.txtMonitoring.TabIndex = 1
        Me.txtMonitoring.Text = "CAMPUSM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(24, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MONITORING:"
        '
        'llblLog
        '
        Me.llblLog.AutoSize = True
        Me.llblLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblLog.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblLog.Location = New System.Drawing.Point(311, 37)
        Me.llblLog.Name = "llblLog"
        Me.llblLog.Size = New System.Drawing.Size(52, 14)
        Me.llblLog.TabIndex = 3
        Me.llblLog.TabStop = True
        Me.llblLog.Text = "Default"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(71, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LOGS:"
        '
        'txtLogs
        '
        Me.txtLogs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogs.ForeColor = System.Drawing.Color.Gray
        Me.txtLogs.Location = New System.Drawing.Point(120, 34)
        Me.txtLogs.MaxLength = 7
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.Size = New System.Drawing.Size(185, 22)
        Me.txtLogs.TabIndex = 0
        Me.txtLogs.Text = "CAMPUSL"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(379, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CHANGE ID FORMAT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(194, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 29)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(293, 334)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 29)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(10, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(370, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Note:If you continue changing of ID, you cannot update it again."
        '
        'lblPrev
        '
        Me.lblPrev.BackColor = System.Drawing.Color.Transparent
        Me.lblPrev.ForeColor = System.Drawing.Color.White
        Me.lblPrev.Location = New System.Drawing.Point(22, 334)
        Me.lblPrev.Name = "lblPrev"
        Me.lblPrev.Size = New System.Drawing.Size(174, 48)
        Me.lblPrev.TabIndex = 7
        Me.lblPrev.Text = "Preview: "
        Me.lblPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lDef
        '
        Me.lDef.BackColor = System.Drawing.Color.Transparent
        Me.lDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDef.ForeColor = System.Drawing.Color.Gray
        Me.lDef.Location = New System.Drawing.Point(12, 269)
        Me.lDef.Name = "lDef"
        Me.lDef.Size = New System.Drawing.Size(370, 44)
        Me.lDef.TabIndex = 8
        Me.lDef.Text = "SYSTEM ID FORMAT CHANGER"
        Me.lDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmIDFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Department3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(399, 391)
        Me.Controls.Add(Me.lDef)
        Me.Controls.Add(Me.lblPrev)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIDFormat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System ID Format"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents llblLog As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMonitoring As System.Windows.Forms.TextBox
    Friend WithEvents llblMonitoring As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents llblAnn As System.Windows.Forms.LinkLabel
    Friend WithEvents txtAnn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents llblPass As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPassCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrev As System.Windows.Forms.Label
    Friend WithEvents lDef As System.Windows.Forms.Label
End Class
