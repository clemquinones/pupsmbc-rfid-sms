<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordsAchive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordsAchive))
        Me.btnMessage = New System.Windows.Forms.Button
        Me.btnSystem = New System.Windows.Forms.Button
        Me.btnStudent = New System.Windows.Forms.Button
        Me.gbRecords = New System.Windows.Forms.GroupBox
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.lblReCount = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnAnnouncement = New System.Windows.Forms.Button
        Me.chkCheck = New System.Windows.Forms.CheckBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnRestore = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbRecords.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.Transparent
        Me.btnMessage.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.ForeColor = System.Drawing.Color.Gold
        Me.btnMessage.Location = New System.Drawing.Point(161, 12)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(63, 50)
        Me.btnMessage.TabIndex = 162
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'btnSystem
        '
        Me.btnSystem.BackColor = System.Drawing.Color.Transparent
        Me.btnSystem.BackgroundImage = CType(resources.GetObject("btnSystem.BackgroundImage"), System.Drawing.Image)
        Me.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSystem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystem.ForeColor = System.Drawing.Color.Gold
        Me.btnSystem.Location = New System.Drawing.Point(23, 12)
        Me.btnSystem.Name = "btnSystem"
        Me.btnSystem.Size = New System.Drawing.Size(63, 50)
        Me.btnSystem.TabIndex = 161
        Me.btnSystem.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BackgroundImage = CType(resources.GetObject("btnStudent.BackgroundImage"), System.Drawing.Image)
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudent.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Gold
        Me.btnStudent.Location = New System.Drawing.Point(92, 12)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(63, 50)
        Me.btnStudent.TabIndex = 160
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'gbRecords
        '
        Me.gbRecords.Controls.Add(Me.LV)
        Me.gbRecords.Controls.Add(Me.PictureBox5)
        Me.gbRecords.Controls.Add(Me.lblReCount)
        Me.gbRecords.Controls.Add(Me.lblTip)
        Me.gbRecords.Controls.Add(Me.txtSearch)
        Me.gbRecords.ForeColor = System.Drawing.Color.White
        Me.gbRecords.Location = New System.Drawing.Point(12, 80)
        Me.gbRecords.Name = "gbRecords"
        Me.gbRecords.Size = New System.Drawing.Size(757, 449)
        Me.gbRecords.TabIndex = 163
        Me.gbRecords.TabStop = False
        Me.gbRecords.Text = "System Monitoring Logs"
        '
        'LV
        '
        Me.LV.CheckBoxes = True
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 40)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(744, 403)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Action"
        Me.ColumnHeader3.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date / Time"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(721, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 21)
        Me.PictureBox5.TabIndex = 169
        Me.PictureBox5.TabStop = False
        '
        'lblReCount
        '
        Me.lblReCount.ForeColor = System.Drawing.Color.Gold
        Me.lblReCount.Location = New System.Drawing.Point(11, 14)
        Me.lblReCount.Name = "lblReCount"
        Me.lblReCount.Size = New System.Drawing.Size(307, 23)
        Me.lblReCount.TabIndex = 166
        Me.lblReCount.Text = "Record count: 0"
        Me.lblReCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTip
        '
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(386, 12)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(175, 23)
        Me.lblTip.TabIndex = 167
        Me.lblTip.Text = "Type any key words that will match"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTip.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(567, 14)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(149, 21)
        Me.txtSearch.TabIndex = 168
        Me.txtSearch.Text = "Search"
        '
        'btnAnnouncement
        '
        Me.btnAnnouncement.BackColor = System.Drawing.Color.Transparent
        Me.btnAnnouncement.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Announce_Icon
        Me.btnAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnnouncement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnouncement.Location = New System.Drawing.Point(230, 12)
        Me.btnAnnouncement.Name = "btnAnnouncement"
        Me.btnAnnouncement.Size = New System.Drawing.Size(63, 50)
        Me.btnAnnouncement.TabIndex = 170
        Me.btnAnnouncement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAnnouncement.UseVisualStyleBackColor = False
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCheck.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheck.ForeColor = System.Drawing.Color.White
        Me.chkCheck.Location = New System.Drawing.Point(12, 539)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(86, 17)
        Me.chkCheck.TabIndex = 171
        Me.chkCheck.Text = "Check All"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(309, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(419, 50)
        Me.lblTitle.TabIndex = 172
        Me.lblTitle.Text = "System Monitoring Logs"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(104, 532)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(111, 29)
        Me.btnPrint.TabIndex = 202
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Location = New System.Drawing.Point(532, 532)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(113, 29)
        Me.btnRefresh.TabIndex = 203
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.Black
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.Gold
        Me.btnRestore.Location = New System.Drawing.Point(288, 532)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(172, 29)
        Me.btnRestore.TabIndex = 204
        Me.btnRestore.Text = "&Restore Records"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(651, 532)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 29)
        Me.btnClose.TabIndex = 205
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmRecordsAchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 568)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkCheck)
        Me.Controls.Add(Me.btnAnnouncement)
        Me.Controls.Add(Me.gbRecords)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnSystem)
        Me.Controls.Add(Me.btnStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRecordsAchive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Deleted Records"
        Me.gbRecords.ResumeLayout(False)
        Me.gbRecords.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSystem As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents gbRecords As System.Windows.Forms.GroupBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblReCount As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAnnouncement As System.Windows.Forms.Button
    Friend WithEvents chkCheck As System.Windows.Forms.CheckBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
