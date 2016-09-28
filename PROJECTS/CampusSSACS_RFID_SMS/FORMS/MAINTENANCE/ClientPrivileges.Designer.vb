<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuardSettings
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
        Me.chkSearchStud = New System.Windows.Forms.CheckBox
        Me.chkViewStud = New System.Windows.Forms.CheckBox
        Me.chkOperate = New System.Windows.Forms.CheckBox
        Me.chkShutdown = New System.Windows.Forms.CheckBox
        Me.chkView = New System.Windows.Forms.CheckBox
        Me.chkSearch = New System.Windows.Forms.CheckBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.chkBlock = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbUser = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.chkSearchStud)
        Me.GroupBox1.Controls.Add(Me.chkViewStud)
        Me.GroupBox1.Controls.Add(Me.chkOperate)
        Me.GroupBox1.Controls.Add(Me.chkShutdown)
        Me.GroupBox1.Controls.Add(Me.chkView)
        Me.GroupBox1.Controls.Add(Me.chkSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Privileges"
        '
        'chkSearchStud
        '
        Me.chkSearchStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSearchStud.ForeColor = System.Drawing.Color.White
        Me.chkSearchStud.Location = New System.Drawing.Point(228, 46)
        Me.chkSearchStud.Name = "chkSearchStud"
        Me.chkSearchStud.Size = New System.Drawing.Size(199, 19)
        Me.chkSearchStud.TabIndex = 2
        Me.chkSearchStud.Text = "Search from Student List"
        Me.chkSearchStud.UseVisualStyleBackColor = True
        '
        'chkViewStud
        '
        Me.chkViewStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkViewStud.ForeColor = System.Drawing.Color.White
        Me.chkViewStud.Location = New System.Drawing.Point(228, 21)
        Me.chkViewStud.Name = "chkViewStud"
        Me.chkViewStud.Size = New System.Drawing.Size(199, 19)
        Me.chkViewStud.TabIndex = 1
        Me.chkViewStud.Text = "View Student List"
        Me.chkViewStud.UseVisualStyleBackColor = True
        '
        'chkOperate
        '
        Me.chkOperate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkOperate.ForeColor = System.Drawing.Color.White
        Me.chkOperate.Location = New System.Drawing.Point(6, 95)
        Me.chkOperate.Name = "chkOperate"
        Me.chkOperate.Size = New System.Drawing.Size(238, 19)
        Me.chkOperate.TabIndex = 0
        Me.chkOperate.Text = "Operate the verfication window"
        Me.chkOperate.UseVisualStyleBackColor = True
        '
        'chkShutdown
        '
        Me.chkShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShutdown.ForeColor = System.Drawing.Color.White
        Me.chkShutdown.Location = New System.Drawing.Point(6, 70)
        Me.chkShutdown.Name = "chkShutdown"
        Me.chkShutdown.Size = New System.Drawing.Size(205, 19)
        Me.chkShutdown.TabIndex = 0
        Me.chkShutdown.Text = "Shutdown Client"
        Me.chkShutdown.UseVisualStyleBackColor = True
        '
        'chkView
        '
        Me.chkView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkView.ForeColor = System.Drawing.Color.White
        Me.chkView.Location = New System.Drawing.Point(6, 45)
        Me.chkView.Name = "chkView"
        Me.chkView.Size = New System.Drawing.Size(205, 19)
        Me.chkView.TabIndex = 0
        Me.chkView.Text = "View Student Information"
        Me.chkView.UseVisualStyleBackColor = True
        '
        'chkSearch
        '
        Me.chkSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSearch.ForeColor = System.Drawing.Color.White
        Me.chkSearch.Location = New System.Drawing.Point(6, 20)
        Me.chkSearch.Name = "chkSearch"
        Me.chkSearch.Size = New System.Drawing.Size(205, 19)
        Me.chkSearch.TabIndex = 0
        Me.chkSearch.Text = "Search Student Logs"
        Me.chkSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(258, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 26)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 58)
        Me.Label1.TabIndex = 1
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Guard
        Me.pbAnnouncement.Location = New System.Drawing.Point(10, 8)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(46, 41)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 22
        Me.pbAnnouncement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(62, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Client Manager Privileges"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(349, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 26)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chkBlock
        '
        Me.chkBlock.BackColor = System.Drawing.Color.Transparent
        Me.chkBlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBlock.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBlock.ForeColor = System.Drawing.Color.Black
        Me.chkBlock.Location = New System.Drawing.Point(9, 230)
        Me.chkBlock.Name = "chkBlock"
        Me.chkBlock.Size = New System.Drawing.Size(327, 24)
        Me.chkBlock.TabIndex = 0
        Me.chkBlock.Text = "Restrict the guard to access the system"
        Me.chkBlock.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Tools
        Me.PictureBox1.Location = New System.Drawing.Point(346, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'cmbUser
        '
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(62, 73)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(142, 21)
        Me.cmbUser.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "User:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DimGray
        Me.lblName.Location = New System.Drawing.Point(214, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(99, 14)
        Me.lblName.TabIndex = 27
        Me.lblName.Text = "Client Manager"
        '
        'frmGuardSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SEARCH1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(455, 324)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkBlock)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuardSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guard Privileges Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSearch As System.Windows.Forms.CheckBox
    Friend WithEvents chkView As System.Windows.Forms.CheckBox
    Friend WithEvents chkShutdown As System.Windows.Forms.CheckBox
    Friend WithEvents chkOperate As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkBlock As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents chkSearchStud As System.Windows.Forms.CheckBox
    Friend WithEvents chkViewStud As System.Windows.Forms.CheckBox
End Class
