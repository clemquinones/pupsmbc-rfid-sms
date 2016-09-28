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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDept = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.pbPic = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.bRefresh = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnFilter = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.bClose = New System.Windows.Forms.Button
        Me.gbTimeRange.SuspendLayout()
        Me.gbDateRange.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 220
        '
        'lvResult
        '
        Me.lvResult.BackColor = System.Drawing.Color.Black
        Me.lvResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvResult.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResult.ForeColor = System.Drawing.Color.White
        Me.lvResult.FullRowSelect = True
        Me.lvResult.GridLines = True
        Me.lvResult.Location = New System.Drawing.Point(7, 14)
        Me.lvResult.MultiSelect = False
        Me.lvResult.Name = "lvResult"
        Me.lvResult.Size = New System.Drawing.Size(403, 364)
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
        Me.txtKey.BackColor = System.Drawing.Color.White
        Me.txtKey.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.DimGray
        Me.txtKey.Location = New System.Drawing.Point(164, 20)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(158, 23)
        Me.txtKey.TabIndex = 7
        Me.txtKey.Text = "Search"
        '
        'dtpStartT
        '
        Me.dtpStartT.Enabled = False
        Me.dtpStartT.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartT.Location = New System.Drawing.Point(121, 21)
        Me.dtpStartT.Name = "dtpStartT"
        Me.dtpStartT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpStartT.ShowUpDown = True
        Me.dtpStartT.Size = New System.Drawing.Size(117, 22)
        Me.dtpStartT.TabIndex = 19
        '
        'dtpEndT
        '
        Me.dtpEndT.Enabled = False
        Me.dtpEndT.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndT.Location = New System.Drawing.Point(121, 49)
        Me.dtpEndT.Name = "dtpEndT"
        Me.dtpEndT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpEndT.ShowUpDown = True
        Me.dtpEndT.Size = New System.Drawing.Size(117, 22)
        Me.dtpEndT.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 25)
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
        Me.gbTimeRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTimeRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbTimeRange.Location = New System.Drawing.Point(429, 109)
        Me.gbTimeRange.Name = "gbTimeRange"
        Me.gbTimeRange.Size = New System.Drawing.Size(256, 84)
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
        Me.Label9.Location = New System.Drawing.Point(27, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "End Time:"
        '
        'cmbLog
        '
        Me.cmbLog.BackColor = System.Drawing.Color.White
        Me.cmbLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLog.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLog.ForeColor = System.Drawing.Color.Black
        Me.cmbLog.FormattingEnabled = True
        Me.cmbLog.Items.AddRange(New Object() {"All Read", "Today", "Yesterday", "This Week"})
        Me.cmbLog.Location = New System.Drawing.Point(30, 19)
        Me.cmbLog.Name = "cmbLog"
        Me.cmbLog.Size = New System.Drawing.Size(206, 22)
        Me.cmbLog.TabIndex = 24
        '
        'gbDateRange
        '
        Me.gbDateRange.BackColor = System.Drawing.Color.Black
        Me.gbDateRange.Controls.Add(Me.dtpEndD)
        Me.gbDateRange.Controls.Add(Me.Label10)
        Me.gbDateRange.Controls.Add(Me.Label11)
        Me.gbDateRange.Controls.Add(Me.dtpStartD)
        Me.gbDateRange.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDateRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbDateRange.Location = New System.Drawing.Point(429, 230)
        Me.gbDateRange.Name = "gbDateRange"
        Me.gbDateRange.Size = New System.Drawing.Size(256, 111)
        Me.gbDateRange.TabIndex = 21
        Me.gbDateRange.TabStop = False
        Me.gbDateRange.Text = "Search by Date-Range"
        '
        'dtpEndD
        '
        Me.dtpEndD.Enabled = False
        Me.dtpEndD.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndD.Location = New System.Drawing.Point(121, 77)
        Me.dtpEndD.Name = "dtpEndD"
        Me.dtpEndD.Size = New System.Drawing.Size(129, 21)
        Me.dtpEndD.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(28, 79)
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
        Me.Label11.Location = New System.Drawing.Point(18, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Start Date:"
        '
        'dtpStartD
        '
        Me.dtpStartD.Enabled = False
        Me.dtpStartD.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartD.Location = New System.Drawing.Point(121, 33)
        Me.dtpStartD.Name = "dtpStartD"
        Me.dtpStartD.Size = New System.Drawing.Size(129, 21)
        Me.dtpStartD.TabIndex = 19
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(24, 19)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(206, 22)
        Me.cmbCourse.TabIndex = 26
        '
        'chkTimeRange
        '
        Me.chkTimeRange.BackColor = System.Drawing.Color.Transparent
        Me.chkTimeRange.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimeRange.ForeColor = System.Drawing.Color.Gold
        Me.chkTimeRange.Location = New System.Drawing.Point(429, 90)
        Me.chkTimeRange.Name = "chkTimeRange"
        Me.chkTimeRange.Size = New System.Drawing.Size(182, 22)
        Me.chkTimeRange.TabIndex = 27
        Me.chkTimeRange.Text = "Time Range"
        Me.chkTimeRange.UseVisualStyleBackColor = False
        '
        'chkDate
        '
        Me.chkDate.BackColor = System.Drawing.Color.Transparent
        Me.chkDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate.ForeColor = System.Drawing.Color.Gold
        Me.chkDate.Location = New System.Drawing.Point(429, 209)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(182, 22)
        Me.chkDate.TabIndex = 27
        Me.chkDate.Text = "Filter By Date"
        Me.chkDate.UseVisualStyleBackColor = False
        '
        'chkDept
        '
        Me.chkDept.BackColor = System.Drawing.Color.Transparent
        Me.chkDept.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDept.ForeColor = System.Drawing.Color.Gold
        Me.chkDept.Location = New System.Drawing.Point(429, 361)
        Me.chkDept.Name = "chkDept"
        Me.chkDept.Size = New System.Drawing.Size(182, 22)
        Me.chkDept.TabIndex = 27
        Me.chkDept.Text = "Filter By Department"
        Me.chkDept.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblDept)
        Me.GroupBox1.Controls.Add(Me.lblStudNo)
        Me.GroupBox1.Controls.Add(Me.pbPic)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(416, 122)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Near Match"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gold
        Me.lblName.Location = New System.Drawing.Point(118, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblName.Size = New System.Drawing.Size(292, 27)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDept
        '
        Me.lblDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDept.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.Gold
        Me.lblDept.Location = New System.Drawing.Point(118, 83)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDept.Size = New System.Drawing.Size(292, 33)
        Me.lblDept.TabIndex = 30
        Me.lblDept.Text = "Department"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudNo
        '
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.Gold
        Me.lblStudNo.Location = New System.Drawing.Point(118, 25)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStudNo.Size = New System.Drawing.Size(292, 22)
        Me.lblStudNo.TabIndex = 29
        Me.lblStudNo.Text = "Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.Black
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPic.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.pbPic.Location = New System.Drawing.Point(9, 13)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(95, 103)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 28
        Me.pbPic.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvResult)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 384)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bRefresh)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.txtKey)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 519)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 52)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'bRefresh
        '
        Me.bRefresh.BackColor = System.Drawing.Color.Black
        Me.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRefresh.ForeColor = System.Drawing.Color.Gold
        Me.bRefresh.Location = New System.Drawing.Point(9, 17)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(82, 25)
        Me.bRefresh.TabIndex = 34
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.searchicon
        Me.PictureBox1.Location = New System.Drawing.Point(328, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Black
        Me.btnFilter.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.Gold
        Me.btnFilter.Location = New System.Drawing.Point(21, 14)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(215, 33)
        Me.btnFilter.TabIndex = 33
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnFilter)
        Me.GroupBox4.Location = New System.Drawing.Point(429, 438)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 58)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbLog)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(429, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 53)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select alternative searching"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbCourse)
        Me.GroupBox6.Location = New System.Drawing.Point(429, 383)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(256, 54)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Black
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClose.ForeColor = System.Drawing.Color.Gold
        Me.bClose.Location = New System.Drawing.Point(582, 536)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(97, 25)
        Me.bClose.TabIndex = 35
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'frmSearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 586)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.chkDept)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.chkTimeRange)
        Me.Controls.Add(Me.gbDateRange)
        Me.Controls.Add(Me.gbTimeRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search student from logs"
        Me.TopMost = True
        Me.gbTimeRange.ResumeLayout(False)
        Me.gbTimeRange.PerformLayout()
        Me.gbDateRange.ResumeLayout(False)
        Me.gbDateRange.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvResult As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents bRefresh As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button

End Class
