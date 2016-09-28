<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpiredMessages
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
        Me.tcMessage = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkLog = New System.Windows.Forms.CheckBox
        Me.btnLogReSend = New System.Windows.Forms.Button
        Me.btnLogDelAll = New System.Windows.Forms.Button
        Me.btnLogDel = New System.Windows.Forms.Button
        Me.lblLogs = New System.Windows.Forms.Label
        Me.LVLogs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkAnn = New System.Windows.Forms.CheckBox
        Me.btnAnnReSent = New System.Windows.Forms.Button
        Me.btnAnnDelAll = New System.Windows.Forms.Button
        Me.btnAnnDel = New System.Windows.Forms.Button
        Me.lblAnn = New System.Windows.Forms.Label
        Me.LVAnn = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.LVAnonym = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.chkAnonym = New System.Windows.Forms.CheckBox
        Me.btnAnonymReSend = New System.Windows.Forms.Button
        Me.btnAnonymDelAll = New System.Windows.Forms.Button
        Me.btnAnonymDel = New System.Windows.Forms.Button
        Me.lblAnonym = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.tcMessage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMessage
        '
        Me.tcMessage.Controls.Add(Me.TabPage1)
        Me.tcMessage.Controls.Add(Me.TabPage2)
        Me.tcMessage.Controls.Add(Me.TabPage3)
        Me.tcMessage.Location = New System.Drawing.Point(6, 55)
        Me.tcMessage.Name = "tcMessage"
        Me.tcMessage.SelectedIndex = 0
        Me.tcMessage.Size = New System.Drawing.Size(568, 536)
        Me.tcMessage.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.chkLog)
        Me.TabPage1.Controls.Add(Me.btnLogReSend)
        Me.TabPage1.Controls.Add(Me.btnLogDelAll)
        Me.TabPage1.Controls.Add(Me.btnLogDel)
        Me.TabPage1.Controls.Add(Me.lblLogs)
        Me.TabPage1.Controls.Add(Me.LVLogs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(560, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student's Attendance"
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkLog.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLog.ForeColor = System.Drawing.Color.White
        Me.chkLog.Location = New System.Drawing.Point(113, 398)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(81, 18)
        Me.chkLog.TabIndex = 5
        Me.chkLog.Text = "Check All"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'btnLogReSend
        '
        Me.btnLogReSend.BackColor = System.Drawing.Color.Black
        Me.btnLogReSend.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnLogReSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogReSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogReSend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogReSend.ForeColor = System.Drawing.Color.Gold
        Me.btnLogReSend.Location = New System.Drawing.Point(10, 389)
        Me.btnLogReSend.Name = "btnLogReSend"
        Me.btnLogReSend.Size = New System.Drawing.Size(87, 34)
        Me.btnLogReSend.TabIndex = 4
        Me.btnLogReSend.Text = "Resend"
        Me.btnLogReSend.UseVisualStyleBackColor = False
        '
        'btnLogDelAll
        '
        Me.btnLogDelAll.BackColor = System.Drawing.Color.Black
        Me.btnLogDelAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogDelAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogDelAll.ForeColor = System.Drawing.Color.Gold
        Me.btnLogDelAll.Location = New System.Drawing.Point(461, 392)
        Me.btnLogDelAll.Name = "btnLogDelAll"
        Me.btnLogDelAll.Size = New System.Drawing.Size(87, 28)
        Me.btnLogDelAll.TabIndex = 3
        Me.btnLogDelAll.Text = "Delete All"
        Me.btnLogDelAll.UseVisualStyleBackColor = False
        '
        'btnLogDel
        '
        Me.btnLogDel.BackColor = System.Drawing.Color.Black
        Me.btnLogDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogDel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogDel.ForeColor = System.Drawing.Color.Gold
        Me.btnLogDel.Location = New System.Drawing.Point(368, 392)
        Me.btnLogDel.Name = "btnLogDel"
        Me.btnLogDel.Size = New System.Drawing.Size(87, 28)
        Me.btnLogDel.TabIndex = 2
        Me.btnLogDel.Text = "&Delete"
        Me.btnLogDel.UseVisualStyleBackColor = False
        '
        'lblLogs
        '
        Me.lblLogs.BackColor = System.Drawing.Color.White
        Me.lblLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogs.Location = New System.Drawing.Point(10, 426)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(541, 73)
        Me.lblLogs.TabIndex = 1
        Me.lblLogs.Text = "Message count: 0"
        '
        'LVLogs
        '
        Me.LVLogs.CheckBoxes = True
        Me.LVLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVLogs.FullRowSelect = True
        Me.LVLogs.GridLines = True
        Me.LVLogs.Location = New System.Drawing.Point(10, 10)
        Me.LVLogs.Name = "LVLogs"
        Me.LVLogs.Size = New System.Drawing.Size(541, 376)
        Me.LVLogs.TabIndex = 0
        Me.LVLogs.UseCompatibleStateImageBehavior = False
        Me.LVLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 55
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date/Time"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 120
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.chkAnn)
        Me.TabPage2.Controls.Add(Me.btnAnnReSent)
        Me.TabPage2.Controls.Add(Me.btnAnnDelAll)
        Me.TabPage2.Controls.Add(Me.btnAnnDel)
        Me.TabPage2.Controls.Add(Me.lblAnn)
        Me.TabPage2.Controls.Add(Me.LVAnn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(560, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Announcement"
        '
        'chkAnn
        '
        Me.chkAnn.AutoSize = True
        Me.chkAnn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAnn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnn.ForeColor = System.Drawing.Color.White
        Me.chkAnn.Location = New System.Drawing.Point(113, 398)
        Me.chkAnn.Name = "chkAnn"
        Me.chkAnn.Size = New System.Drawing.Size(81, 18)
        Me.chkAnn.TabIndex = 11
        Me.chkAnn.Text = "Check All"
        Me.chkAnn.UseVisualStyleBackColor = True
        '
        'btnAnnReSent
        '
        Me.btnAnnReSent.BackColor = System.Drawing.Color.Black
        Me.btnAnnReSent.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnAnnReSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnnReSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnReSent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnReSent.ForeColor = System.Drawing.Color.Gold
        Me.btnAnnReSent.Location = New System.Drawing.Point(10, 389)
        Me.btnAnnReSent.Name = "btnAnnReSent"
        Me.btnAnnReSent.Size = New System.Drawing.Size(87, 34)
        Me.btnAnnReSent.TabIndex = 10
        Me.btnAnnReSent.Text = "Resend"
        Me.btnAnnReSent.UseVisualStyleBackColor = False
        '
        'btnAnnDelAll
        '
        Me.btnAnnDelAll.BackColor = System.Drawing.Color.Black
        Me.btnAnnDelAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnDelAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnDelAll.ForeColor = System.Drawing.Color.Gold
        Me.btnAnnDelAll.Location = New System.Drawing.Point(448, 392)
        Me.btnAnnDelAll.Name = "btnAnnDelAll"
        Me.btnAnnDelAll.Size = New System.Drawing.Size(87, 28)
        Me.btnAnnDelAll.TabIndex = 9
        Me.btnAnnDelAll.Text = "Delete All"
        Me.btnAnnDelAll.UseVisualStyleBackColor = False
        '
        'btnAnnDel
        '
        Me.btnAnnDel.BackColor = System.Drawing.Color.Black
        Me.btnAnnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnDel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnDel.ForeColor = System.Drawing.Color.Gold
        Me.btnAnnDel.Location = New System.Drawing.Point(355, 392)
        Me.btnAnnDel.Name = "btnAnnDel"
        Me.btnAnnDel.Size = New System.Drawing.Size(87, 28)
        Me.btnAnnDel.TabIndex = 8
        Me.btnAnnDel.Text = "&Delete"
        Me.btnAnnDel.UseVisualStyleBackColor = False
        '
        'lblAnn
        '
        Me.lblAnn.BackColor = System.Drawing.Color.White
        Me.lblAnn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnn.Location = New System.Drawing.Point(10, 426)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(532, 73)
        Me.lblAnn.TabIndex = 7
        Me.lblAnn.Text = "Message count: 0"
        '
        'LVAnn
        '
        Me.LVAnn.CheckBoxes = True
        Me.LVAnn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader13})
        Me.LVAnn.FullRowSelect = True
        Me.LVAnn.GridLines = True
        Me.LVAnn.Location = New System.Drawing.Point(9, 9)
        Me.LVAnn.Name = "LVAnn"
        Me.LVAnn.Size = New System.Drawing.Size(533, 376)
        Me.LVAnn.TabIndex = 6
        Me.LVAnn.UseCompatibleStateImageBehavior = False
        Me.LVAnn.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 55
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Type"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "User Number"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Message"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 210
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date/Time"
        Me.ColumnHeader13.Width = 100
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Black
        Me.TabPage3.Controls.Add(Me.LVAnonym)
        Me.TabPage3.Controls.Add(Me.chkAnonym)
        Me.TabPage3.Controls.Add(Me.btnAnonymReSend)
        Me.TabPage3.Controls.Add(Me.btnAnonymDelAll)
        Me.TabPage3.Controls.Add(Me.btnAnonymDel)
        Me.TabPage3.Controls.Add(Me.lblAnonym)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(560, 510)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Anonymous Messaging"
        '
        'LVAnonym
        '
        Me.LVAnonym.CheckBoxes = True
        Me.LVAnonym.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader14})
        Me.LVAnonym.FullRowSelect = True
        Me.LVAnonym.GridLines = True
        Me.LVAnonym.Location = New System.Drawing.Point(9, 9)
        Me.LVAnonym.Name = "LVAnonym"
        Me.LVAnonym.Size = New System.Drawing.Size(533, 376)
        Me.LVAnonym.TabIndex = 18
        Me.LVAnonym.UseCompatibleStateImageBehavior = False
        Me.LVAnonym.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ID"
        Me.ColumnHeader9.Width = 55
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Type"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "User Number"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Message"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 210
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Date/Time"
        Me.ColumnHeader14.Width = 100
        '
        'chkAnonym
        '
        Me.chkAnonym.AutoSize = True
        Me.chkAnonym.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAnonym.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnonym.ForeColor = System.Drawing.Color.White
        Me.chkAnonym.Location = New System.Drawing.Point(113, 398)
        Me.chkAnonym.Name = "chkAnonym"
        Me.chkAnonym.Size = New System.Drawing.Size(81, 18)
        Me.chkAnonym.TabIndex = 17
        Me.chkAnonym.Text = "Check All"
        Me.chkAnonym.UseVisualStyleBackColor = True
        '
        'btnAnonymReSend
        '
        Me.btnAnonymReSend.BackColor = System.Drawing.Color.Black
        Me.btnAnonymReSend.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnAnonymReSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnonymReSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnonymReSend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnonymReSend.ForeColor = System.Drawing.Color.Gold
        Me.btnAnonymReSend.Location = New System.Drawing.Point(10, 389)
        Me.btnAnonymReSend.Name = "btnAnonymReSend"
        Me.btnAnonymReSend.Size = New System.Drawing.Size(87, 34)
        Me.btnAnonymReSend.TabIndex = 16
        Me.btnAnonymReSend.Text = "Resend"
        Me.btnAnonymReSend.UseVisualStyleBackColor = False
        '
        'btnAnonymDelAll
        '
        Me.btnAnonymDelAll.BackColor = System.Drawing.Color.Black
        Me.btnAnonymDelAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnonymDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnonymDelAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnonymDelAll.ForeColor = System.Drawing.Color.Gold
        Me.btnAnonymDelAll.Location = New System.Drawing.Point(448, 392)
        Me.btnAnonymDelAll.Name = "btnAnonymDelAll"
        Me.btnAnonymDelAll.Size = New System.Drawing.Size(87, 28)
        Me.btnAnonymDelAll.TabIndex = 15
        Me.btnAnonymDelAll.Text = "Delete All"
        Me.btnAnonymDelAll.UseVisualStyleBackColor = False
        '
        'btnAnonymDel
        '
        Me.btnAnonymDel.BackColor = System.Drawing.Color.Black
        Me.btnAnonymDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnonymDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnonymDel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnonymDel.ForeColor = System.Drawing.Color.Gold
        Me.btnAnonymDel.Location = New System.Drawing.Point(355, 392)
        Me.btnAnonymDel.Name = "btnAnonymDel"
        Me.btnAnonymDel.Size = New System.Drawing.Size(87, 28)
        Me.btnAnonymDel.TabIndex = 14
        Me.btnAnonymDel.Text = "&Delete"
        Me.btnAnonymDel.UseVisualStyleBackColor = False
        '
        'lblAnonym
        '
        Me.lblAnonym.BackColor = System.Drawing.Color.White
        Me.lblAnonym.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnonym.Location = New System.Drawing.Point(9, 426)
        Me.lblAnonym.Name = "lblAnonym"
        Me.lblAnonym.Size = New System.Drawing.Size(533, 73)
        Me.lblAnonym.TabIndex = 13
        Me.lblAnonym.Text = "Message count: 0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(483, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Location = New System.Drawing.Point(10, 596)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(87, 23)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitle.Location = New System.Drawing.Point(16, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(149, 19)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Expired Messages"
        '
        'frmExpiredMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(585, 624)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tcMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmExpiredMessages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expired Messages"
        Me.tcMessage.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcMessage As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LVLogs As System.Windows.Forms.ListView
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLogDelAll As System.Windows.Forms.Button
    Friend WithEvents btnLogDel As System.Windows.Forms.Button
    Friend WithEvents btnLogReSend As System.Windows.Forms.Button
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnn As System.Windows.Forms.CheckBox
    Friend WithEvents btnAnnReSent As System.Windows.Forms.Button
    Friend WithEvents btnAnnDelAll As System.Windows.Forms.Button
    Friend WithEvents btnAnnDel As System.Windows.Forms.Button
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents LVAnn As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkAnonym As System.Windows.Forms.CheckBox
    Friend WithEvents btnAnonymReSend As System.Windows.Forms.Button
    Friend WithEvents btnAnonymDelAll As System.Windows.Forms.Button
    Friend WithEvents btnAnonymDel As System.Windows.Forms.Button
    Friend WithEvents lblAnonym As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVAnonym As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
