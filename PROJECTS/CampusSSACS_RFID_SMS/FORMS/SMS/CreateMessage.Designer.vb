<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateMessage))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtRecipients = New System.Windows.Forms.TextBox
        Me.txtSendCopy = New System.Windows.Forms.TextBox
        Me.chkSendCopy = New System.Windows.Forms.CheckBox
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.gbRecipients = New System.Windows.Forms.GroupBox
        Me.btnRemoveAll = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.llblFromSent = New System.Windows.Forms.LinkLabel
        Me.llblFromFile = New System.Windows.Forms.LinkLabel
        Me.nSending = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrEnding = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkUnicode = New System.Windows.Forms.CheckBox
        Me.chkAlert = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbRecipients.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(24, 490)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 28)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Tag = "False"
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.Gold
        Me.btnSend.Location = New System.Drawing.Point(351, 21)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(144, 42)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Tag = ""
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(12, 32)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage.Size = New System.Drawing.Size(484, 195)
        Me.txtMessage.TabIndex = 11
        Me.txtMessage.Text = "Type your message here..."
        '
        'txtRecipients
        '
        Me.txtRecipients.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecipients.ForeColor = System.Drawing.Color.Gray
        Me.txtRecipients.Location = New System.Drawing.Point(184, 23)
        Me.txtRecipients.Name = "txtRecipients"
        Me.txtRecipients.Size = New System.Drawing.Size(224, 22)
        Me.txtRecipients.TabIndex = 12
        Me.txtRecipients.Text = "Recipient"
        '
        'txtSendCopy
        '
        Me.txtSendCopy.Enabled = False
        Me.txtSendCopy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendCopy.ForeColor = System.Drawing.Color.Gray
        Me.txtSendCopy.Location = New System.Drawing.Point(118, 34)
        Me.txtSendCopy.Name = "txtSendCopy"
        Me.txtSendCopy.Size = New System.Drawing.Size(87, 22)
        Me.txtSendCopy.TabIndex = 16
        Me.txtSendCopy.Text = "Send Copy"
        Me.txtSendCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSendCopy
        '
        Me.chkSendCopy.AutoSize = True
        Me.chkSendCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSendCopy.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSendCopy.Location = New System.Drawing.Point(14, 36)
        Me.chkSendCopy.Name = "chkSendCopy"
        Me.chkSendCopy.Size = New System.Drawing.Size(99, 18)
        Me.chkSendCopy.TabIndex = 17
        Me.chkSendCopy.Text = "Send Copy:"
        Me.chkSendCopy.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(13, 51)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(435, 368)
        Me.LV.TabIndex = 24
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'gbRecipients
        '
        Me.gbRecipients.Controls.Add(Me.btnRemoveAll)
        Me.gbRecipients.Controls.Add(Me.btnRemove)
        Me.gbRecipients.Controls.Add(Me.btnInsert)
        Me.gbRecipients.Controls.Add(Me.btnBrowse)
        Me.gbRecipients.Controls.Add(Me.LV)
        Me.gbRecipients.Controls.Add(Me.txtRecipients)
        Me.gbRecipients.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRecipients.ForeColor = System.Drawing.Color.White
        Me.gbRecipients.Location = New System.Drawing.Point(531, 57)
        Me.gbRecipients.Name = "gbRecipients"
        Me.gbRecipients.Size = New System.Drawing.Size(461, 461)
        Me.gbRecipients.TabIndex = 27
        Me.gbRecipients.TabStop = False
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnRemoveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnRemoveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAll.ForeColor = System.Drawing.Color.White
        Me.btnRemoveAll.Location = New System.Drawing.Point(117, 425)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(98, 23)
        Me.btnRemoveAll.TabIndex = 31
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(13, 425)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(98, 23)
        Me.btnRemove.TabIndex = 31
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NextArrow
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(414, 22)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(34, 23)
        Me.btnInsert.TabIndex = 33
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(16, 20)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 32
        Me.btnBrowse.Text = "&Sent To..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 403)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 73)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(10, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 42)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Tag = "False"
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblRemaining)
        Me.GroupBox4.Controls.Add(Me.llblFromSent)
        Me.GroupBox4.Controls.Add(Me.llblFromFile)
        Me.GroupBox4.Controls.Add(Me.txtMessage)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(505, 254)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'lblRemaining
        '
        Me.lblRemaining.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(13, 13)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(484, 14)
        Me.lblRemaining.TabIndex = 21
        Me.lblRemaining.Text = "Remaining characters for single message (2048/2048)"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'llblFromSent
        '
        Me.llblFromSent.AutoSize = True
        Me.llblFromSent.BackColor = System.Drawing.Color.Black
        Me.llblFromSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblFromSent.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblFromSent.LinkColor = System.Drawing.Color.Lime
        Me.llblFromSent.Location = New System.Drawing.Point(145, 233)
        Me.llblFromSent.Name = "llblFromSent"
        Me.llblFromSent.Size = New System.Drawing.Size(126, 15)
        Me.llblFromSent.TabIndex = 20
        Me.llblFromSent.TabStop = True
        Me.llblFromSent.Text = "Load from sent..."
        '
        'llblFromFile
        '
        Me.llblFromFile.AutoSize = True
        Me.llblFromFile.BackColor = System.Drawing.Color.Black
        Me.llblFromFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblFromFile.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblFromFile.LinkColor = System.Drawing.Color.Lime
        Me.llblFromFile.Location = New System.Drawing.Point(10, 233)
        Me.llblFromFile.Name = "llblFromFile"
        Me.llblFromFile.Size = New System.Drawing.Size(126, 15)
        Me.llblFromFile.TabIndex = 19
        Me.llblFromFile.TabStop = True
        Me.llblFromFile.Text = "Load from file..."
        '
        'nSending
        '
        Me.nSending.BalloonTipTitle = "Message Queued"
        Me.nSending.Icon = CType(resources.GetObject("nSending.Icon"), System.Drawing.Icon)
        Me.nSending.Text = "Message successfully queued and ready to sent."
        Me.nSending.Visible = True
        '
        'tmrEnding
        '
        Me.tmrEnding.Interval = 5000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkUnicode)
        Me.GroupBox3.Controls.Add(Me.chkAlert)
        Me.GroupBox3.Controls.Add(Me.txtSendCopy)
        Me.GroupBox3.Controls.Add(Me.chkSendCopy)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(505, 80)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'chkUnicode
        '
        Me.chkUnicode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkUnicode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnicode.Location = New System.Drawing.Point(251, 49)
        Me.chkUnicode.Name = "chkUnicode"
        Me.chkUnicode.Size = New System.Drawing.Size(245, 24)
        Me.chkUnicode.TabIndex = 19
        Me.chkUnicode.Text = "Send as Unicode (UCS2)"
        Me.chkUnicode.UseVisualStyleBackColor = True
        '
        'chkAlert
        '
        Me.chkAlert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAlert.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlert.Location = New System.Drawing.Point(251, 19)
        Me.chkAlert.Name = "chkAlert"
        Me.chkAlert.Size = New System.Drawing.Size(245, 24)
        Me.chkAlert.TabIndex = 18
        Me.chkAlert.Text = "Request immediate display (alert)"
        Me.chkAlert.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(504, 43)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 26)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Create SMS Message"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(531, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(504, 43)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(10, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 26)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Recipents"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreateMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 530)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbRecipients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCreateMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compose Message"
        Me.gbRecipients.ResumeLayout(False)
        Me.gbRecipients.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtRecipients As System.Windows.Forms.TextBox
    Friend WithEvents txtSendCopy As System.Windows.Forms.TextBox
    Friend WithEvents chkSendCopy As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbRecipients As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents llblFromSent As System.Windows.Forms.LinkLabel
    Friend WithEvents llblFromFile As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents nSending As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrEnding As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUnicode As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlert As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
