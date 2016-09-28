<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchStudent
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
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lvResult = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAdvanced = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnFilter = New System.Windows.Forms.Button
        Me.dtpStartT = New System.Windows.Forms.DateTimePicker
        Me.dtpEndT = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbTimeRange = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbLog = New System.Windows.Forms.ComboBox
        Me.gbDateRange = New System.Windows.Forms.GroupBox
        Me.dtpEndD = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpStartD = New System.Windows.Forms.DateTimePicker
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.chkTimeRange = New System.Windows.Forms.CheckBox
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.chkDept = New System.Windows.Forms.CheckBox
        Me.pbPic = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbTimeRange.SuspendLayout()
        Me.gbDateRange.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 189
        '
        'lvResult
        '
        Me.lvResult.BackColor = System.Drawing.Color.Black
        Me.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvResult.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResult.ForeColor = System.Drawing.Color.White
        Me.lvResult.FullRowSelect = True
        Me.lvResult.GridLines = True
        Me.lvResult.Location = New System.Drawing.Point(26, 217)
        Me.lvResult.MultiSelect = False
        Me.lvResult.Name = "lvResult"
        Me.lvResult.Size = New System.Drawing.Size(278, 190)
        Me.lvResult.TabIndex = 10
        Me.lvResult.UseCompatibleStateImageBehavior = False
        Me.lvResult.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student #"
        Me.ColumnHeader1.Width = 110
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.Black
        Me.txtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.White
        Me.txtKey.Location = New System.Drawing.Point(19, 444)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(292, 24)
        Me.txtKey.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Type student # or any part of the name (first,middle,last)"
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanced.Location = New System.Drawing.Point(182, 468)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(129, 23)
        Me.btnAdvanced.TabIndex = 14
        Me.btnAdvanced.Text = "Advanced >>"
        Me.btnAdvanced.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "More option for searching"
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(348, 468)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(182, 23)
        Me.btnFilter.TabIndex = 18
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dtpStartT
        '
        Me.dtpStartT.Enabled = False
        Me.dtpStartT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartT.Location = New System.Drawing.Point(9, 33)
        Me.dtpStartT.Name = "dtpStartT"
        Me.dtpStartT.ShowUpDown = True
        Me.dtpStartT.Size = New System.Drawing.Size(167, 22)
        Me.dtpStartT.TabIndex = 19
        '
        'dtpEndT
        '
        Me.dtpEndT.Enabled = False
        Me.dtpEndT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndT.Location = New System.Drawing.Point(9, 92)
        Me.dtpEndT.Name = "dtpEndT"
        Me.dtpEndT.ShowUpDown = True
        Me.dtpEndT.Size = New System.Drawing.Size(167, 22)
        Me.dtpEndT.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Start Time:"
        '
        'gbTimeRange
        '
        Me.gbTimeRange.BackColor = System.Drawing.Color.Black
        Me.gbTimeRange.Controls.Add(Me.dtpEndT)
        Me.gbTimeRange.Controls.Add(Me.Label9)
        Me.gbTimeRange.Controls.Add(Me.Label8)
        Me.gbTimeRange.Controls.Add(Me.dtpStartT)
        Me.gbTimeRange.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTimeRange.Location = New System.Drawing.Point(351, 102)
        Me.gbTimeRange.Name = "gbTimeRange"
        Me.gbTimeRange.Size = New System.Drawing.Size(182, 118)
        Me.gbTimeRange.TabIndex = 21
        Me.gbTimeRange.TabStop = False
        Me.gbTimeRange.Text = "Search by Time-Range"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "End Time:"
        '
        'cmbLog
        '
        Me.cmbLog.BackColor = System.Drawing.Color.Black
        Me.cmbLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbLog.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLog.ForeColor = System.Drawing.Color.White
        Me.cmbLog.FormattingEnabled = True
        Me.cmbLog.Items.AddRange(New Object() {"All Read", "Today", "Yesterday", "This Week"})
        Me.cmbLog.Location = New System.Drawing.Point(351, 30)
        Me.cmbLog.Name = "cmbLog"
        Me.cmbLog.Size = New System.Drawing.Size(182, 22)
        Me.cmbLog.TabIndex = 24
        '
        'gbDateRange
        '
        Me.gbDateRange.BackColor = System.Drawing.Color.Black
        Me.gbDateRange.Controls.Add(Me.dtpEndD)
        Me.gbDateRange.Controls.Add(Me.Label10)
        Me.gbDateRange.Controls.Add(Me.Label11)
        Me.gbDateRange.Controls.Add(Me.dtpStartD)
        Me.gbDateRange.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDateRange.Location = New System.Drawing.Point(351, 265)
        Me.gbDateRange.Name = "gbDateRange"
        Me.gbDateRange.Size = New System.Drawing.Size(182, 118)
        Me.gbDateRange.TabIndex = 21
        Me.gbDateRange.TabStop = False
        Me.gbDateRange.Text = "Search by Date-Range"
        '
        'dtpEndD
        '
        Me.dtpEndD.Enabled = False
        Me.dtpEndD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndD.Location = New System.Drawing.Point(9, 90)
        Me.dtpEndD.Name = "dtpEndD"
        Me.dtpEndD.Size = New System.Drawing.Size(167, 22)
        Me.dtpEndD.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "End Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Start Date:"
        '
        'dtpStartD
        '
        Me.dtpStartD.Enabled = False
        Me.dtpStartD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartD.Location = New System.Drawing.Point(9, 33)
        Me.dtpStartD.Name = "dtpStartD"
        Me.dtpStartD.Size = New System.Drawing.Size(167, 22)
        Me.dtpStartD.TabIndex = 19
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCourse.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(351, 427)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(182, 22)
        Me.cmbCourse.TabIndex = 26
        '
        'chkTimeRange
        '
        Me.chkTimeRange.BackColor = System.Drawing.Color.Gray
        Me.chkTimeRange.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeRange.ForeColor = System.Drawing.Color.White
        Me.chkTimeRange.Location = New System.Drawing.Point(351, 74)
        Me.chkTimeRange.Name = "chkTimeRange"
        Me.chkTimeRange.Size = New System.Drawing.Size(182, 22)
        Me.chkTimeRange.TabIndex = 27
        Me.chkTimeRange.Text = "Time Range"
        Me.chkTimeRange.UseVisualStyleBackColor = False
        '
        'chkDate
        '
        Me.chkDate.BackColor = System.Drawing.Color.Gray
        Me.chkDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate.ForeColor = System.Drawing.Color.White
        Me.chkDate.Location = New System.Drawing.Point(351, 237)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(182, 22)
        Me.chkDate.TabIndex = 27
        Me.chkDate.Text = "Filter By Date"
        Me.chkDate.UseVisualStyleBackColor = False
        '
        'chkDept
        '
        Me.chkDept.BackColor = System.Drawing.Color.Gray
        Me.chkDept.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDept.ForeColor = System.Drawing.Color.White
        Me.chkDept.Location = New System.Drawing.Point(351, 399)
        Me.chkDept.Name = "chkDept"
        Me.chkDept.Size = New System.Drawing.Size(182, 22)
        Me.chkDept.TabIndex = 27
        Me.chkDept.Text = "Filter By Department"
        Me.chkDept.UseVisualStyleBackColor = False
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.Black
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.Location = New System.Drawing.Point(79, 18)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(175, 177)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 28
        Me.pbPic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SearchStudentLogs.My.Resources.Resources.Search_3
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(549, 505)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(550, 504)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.chkDept)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.chkTimeRange)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.cmbLog)
        Me.Controls.Add(Me.gbDateRange)
        Me.Controls.Add(Me.gbTimeRange)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAdvanced)
        Me.Controls.Add(Me.lvResult)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search student from logs"
        Me.TopMost = True
        Me.gbTimeRange.ResumeLayout(False)
        Me.gbTimeRange.PerformLayout()
        Me.gbDateRange.ResumeLayout(False)
        Me.gbDateRange.PerformLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvResult As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdvanced As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents dtpStartT As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbTimeRange As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbLog As System.Windows.Forms.ComboBox
    Friend WithEvents gbDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpStartD As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents chkTimeRange As System.Windows.Forms.CheckBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkDept As System.Windows.Forms.CheckBox
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
