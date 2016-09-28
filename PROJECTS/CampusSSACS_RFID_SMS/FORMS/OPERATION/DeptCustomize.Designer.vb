<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeptSendCustomize
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
        Me.pbAnnouncement = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnDone = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.tmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.lvDept = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lvYear = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lvSections = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.gbDept = New System.Windows.Forms.GroupBox
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDept.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbAnnouncement
        '
        Me.pbAnnouncement.BackColor = System.Drawing.Color.White
        Me.pbAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAnnouncement.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Department
        Me.pbAnnouncement.Location = New System.Drawing.Point(17, 18)
        Me.pbAnnouncement.Name = "pbAnnouncement"
        Me.pbAnnouncement.Size = New System.Drawing.Size(46, 41)
        Me.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnnouncement.TabIndex = 23
        Me.pbAnnouncement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(69, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(252, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Customize Department recipients"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(629, 54)
        Me.Label6.TabIndex = 22
        '
        'btnDone
        '
        Me.btnDone.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.Gold
        Me.btnDone.Location = New System.Drawing.Point(548, 315)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(93, 30)
        Me.btnDone.TabIndex = 24
        Me.btnDone.Text = "&Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(371, 28)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "• You can modify recipients under specific department." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-All checked items only w" & _
            "ill receive the announcement."
        '
        'tmrRead
        '
        Me.tmrRead.Enabled = True
        Me.tmrRead.Interval = 10
        '
        'lvDept
        '
        Me.lvDept.BackColor = System.Drawing.Color.Black
        Me.lvDept.CheckBoxes = True
        Me.lvDept.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4})
        Me.lvDept.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.lvDept.ForeColor = System.Drawing.Color.White
        Me.lvDept.FullRowSelect = True
        Me.lvDept.GridLines = True
        Me.lvDept.Location = New System.Drawing.Point(6, 20)
        Me.lvDept.MultiSelect = False
        Me.lvDept.Name = "lvDept"
        Me.lvDept.Size = New System.Drawing.Size(411, 202)
        Me.lvDept.TabIndex = 11
        Me.lvDept.UseCompatibleStateImageBehavior = False
        Me.lvDept.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Department Description"
        Me.ColumnHeader4.Width = 306
        '
        'lvYear
        '
        Me.lvYear.BackColor = System.Drawing.Color.Black
        Me.lvYear.CheckBoxes = True
        Me.lvYear.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvYear.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.lvYear.ForeColor = System.Drawing.Color.White
        Me.lvYear.FullRowSelect = True
        Me.lvYear.GridLines = True
        Me.lvYear.Location = New System.Drawing.Point(423, 20)
        Me.lvYear.MultiSelect = False
        Me.lvYear.Name = "lvYear"
        Me.lvYear.Size = New System.Drawing.Size(96, 202)
        Me.lvYear.TabIndex = 13
        Me.lvYear.UseCompatibleStateImageBehavior = False
        Me.lvYear.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Year"
        Me.ColumnHeader2.Width = 90
        '
        'lvSections
        '
        Me.lvSections.BackColor = System.Drawing.Color.Black
        Me.lvSections.CheckBoxes = True
        Me.lvSections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lvSections.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.lvSections.ForeColor = System.Drawing.Color.White
        Me.lvSections.FullRowSelect = True
        Me.lvSections.GridLines = True
        Me.lvSections.Location = New System.Drawing.Point(525, 20)
        Me.lvSections.MultiSelect = False
        Me.lvSections.Name = "lvSections"
        Me.lvSections.Size = New System.Drawing.Size(94, 202)
        Me.lvSections.TabIndex = 14
        Me.lvSections.UseCompatibleStateImageBehavior = False
        Me.lvSections.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sections"
        Me.ColumnHeader3.Width = 90
        '
        'gbDept
        '
        Me.gbDept.BackColor = System.Drawing.Color.Transparent
        Me.gbDept.Controls.Add(Me.lvSections)
        Me.gbDept.Controls.Add(Me.lvYear)
        Me.gbDept.Controls.Add(Me.lvDept)
        Me.gbDept.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDept.ForeColor = System.Drawing.Color.Gold
        Me.gbDept.Location = New System.Drawing.Point(16, 68)
        Me.gbDept.Name = "gbDept"
        Me.gbDept.Size = New System.Drawing.Size(625, 228)
        Me.gbDept.TabIndex = 9
        Me.gbDept.TabStop = False
        Me.gbDept.Text = "Departments"
        '
        'frmDeptSendCustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.setting1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 360)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.pbAnnouncement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbDept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeptSendCustomize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customize Recipients"
        Me.TopMost = True
        CType(Me.pbAnnouncement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDept.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAnnouncement As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tmrRead As System.Windows.Forms.Timer
    Friend WithEvents lvDept As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvYear As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSections As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbDept As System.Windows.Forms.GroupBox
End Class
