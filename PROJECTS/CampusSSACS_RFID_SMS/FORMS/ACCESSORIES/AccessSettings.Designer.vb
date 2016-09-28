<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessSettings
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"No Items...", "User Type...", "User Name...", "User name...", "State..."}, -1)
        Me.btnDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnLock = New System.Windows.Forms.Button
        Me.lblTip = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.cmsUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmLock = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDisconnect = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmSendMessage = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ttAccess = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.cmsUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gold
        Me.btnDelete.Location = New System.Drawing.Point(555, 183)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 39)
        Me.btnDelete.TabIndex = 197
        Me.btnDelete.Text = "&DELETE USER"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttAccess.SetToolTip(Me.btnDelete, "Delete user")
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnLock)
        Me.GroupBox1.Controls.Add(Me.lblTip)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(543, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 120)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access"
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLock.Enabled = False
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ForeColor = System.Drawing.Color.Black
        Me.btnLock.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Lock
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.Location = New System.Drawing.Point(12, 74)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(152, 40)
        Me.btnLock.TabIndex = 1
        Me.btnLock.Text = "&LOCK USER"
        Me.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttAccess.SetToolTip(Me.btnLock, "Lock/Unlock user")
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.ForeColor = System.Drawing.Color.Black
        Me.lblTip.Location = New System.Drawing.Point(9, 18)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(163, 43)
        Me.lblTip.TabIndex = 186
        Me.lblTip.Text = "User cannot access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the system."
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 31)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "System Users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.Transparent
        Me.btnDisconnect.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.ForeColor = System.Drawing.Color.Gold
        Me.btnDisconnect.Location = New System.Drawing.Point(555, 138)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(157, 39)
        Me.btnDisconnect.TabIndex = 199
        Me.btnDisconnect.Text = "D&ISCONNECT"
        Me.btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ttAccess.SetToolTip(Me.btnDisconnect, "Disconnect the user")
        Me.btnDisconnect.UseVisualStyleBackColor = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "State"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 108
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.ContextMenuStrip = Me.cmsUser
        Me.LV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        ListViewItem2.StateImageIndex = 0
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.LV.Location = New System.Drawing.Point(11, 53)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(512, 169)
        Me.LV.TabIndex = 194
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "User Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Access"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'cmsUser
        '
        Me.cmsUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmLock, Me.tsmDisconnect, Me.tsmDelete, Me.ToolStripSeparator1, Me.tsmSendMessage})
        Me.cmsUser.Name = "cmsUser"
        Me.cmsUser.Size = New System.Drawing.Size(167, 98)
        '
        'tsmLock
        '
        Me.tsmLock.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Lock
        Me.tsmLock.Name = "tsmLock"
        Me.tsmLock.Size = New System.Drawing.Size(166, 22)
        Me.tsmLock.Text = "Lock User"
        '
        'tsmDisconnect
        '
        Me.tsmDisconnect.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Disconnect
        Me.tsmDisconnect.Name = "tsmDisconnect"
        Me.tsmDisconnect.Size = New System.Drawing.Size(166, 22)
        Me.tsmDisconnect.Text = "Disconnect"
        '
        'tsmDelete
        '
        Me.tsmDelete.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Delete
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(166, 22)
        Me.tsmDelete.Text = "Delete User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'tsmSendMessage
        '
        Me.tsmSendMessage.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.tsmSendMessage.Name = "tsmSendMessage"
        Me.tsmSendMessage.Size = New System.Drawing.Size(166, 22)
        Me.tsmSendMessage.Text = "Send Message..."
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 3000
        '
        'frmAccessSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.AccessSetting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 234)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAccessSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Access Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.cmsUser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents cmsUser As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmLock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDisconnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSendMessage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttAccess As System.Windows.Forms.ToolTip
End Class
