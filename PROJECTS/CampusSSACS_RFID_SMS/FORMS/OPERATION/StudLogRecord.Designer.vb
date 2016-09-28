<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentLogRecord
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
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.cmsStudLogs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmViewStud = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEditStud = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmSendMessage = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.rbCourseYrSec = New System.Windows.Forms.RadioButton
        Me.rbDateRange = New System.Windows.Forms.RadioButton
        Me.rbSearch = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbSortBy = New System.Windows.Forms.ComboBox
        Me.llblAlternative = New System.Windows.Forms.LinkLabel
        Me.lblReCount = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cmsStudLogs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LV.ContextMenuStrip = Me.cmsStudLogs
        Me.LV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(10, 13)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(738, 488)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student #"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Year Level"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Section"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Log state"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date / Time"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 130
        '
        'cmsStudLogs
        '
        Me.cmsStudLogs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmViewStud, Me.tsmEditStud, Me.ToolStripSeparator1, Me.tsmSendMessage})
        Me.cmsStudLogs.Name = "ContextMenuStrip1"
        Me.cmsStudLogs.Size = New System.Drawing.Size(193, 76)
        '
        'tsmViewStud
        '
        Me.tsmViewStud.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmViewStud.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.tsmViewStud.Name = "tsmViewStud"
        Me.tsmViewStud.Size = New System.Drawing.Size(192, 22)
        Me.tsmViewStud.Text = "View Student Details"
        '
        'tsmEditStud
        '
        Me.tsmEditStud.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.edit
        Me.tsmEditStud.Name = "tsmEditStud"
        Me.tsmEditStud.Size = New System.Drawing.Size(192, 22)
        Me.tsmEditStud.Text = "Edit Student Information"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'tsmSendMessage
        '
        Me.tsmSendMessage.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.tsmSendMessage.Name = "tsmSendMessage"
        Me.tsmSendMessage.Size = New System.Drawing.Size(192, 22)
        Me.tsmSendMessage.Text = "Send Message..."
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.BackColor = System.Drawing.Color.White
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.ForeColor = System.Drawing.Color.Black
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"Student Number", "Name", "Log state"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(621, 14)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(127, 22)
        Me.cmbSearchBy.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(421, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(194, 20)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Text = "Search"
        '
        'rbCourseYrSec
        '
        Me.rbCourseYrSec.AutoSize = True
        Me.rbCourseYrSec.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbCourseYrSec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCourseYrSec.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCourseYrSec.ForeColor = System.Drawing.Color.Gold
        Me.rbCourseYrSec.Location = New System.Drawing.Point(6, 14)
        Me.rbCourseYrSec.Name = "rbCourseYrSec"
        Me.rbCourseYrSec.Size = New System.Drawing.Size(116, 19)
        Me.rbCourseYrSec.TabIndex = 7
        Me.rbCourseYrSec.Text = "Course/Yr/Sec"
        Me.rbCourseYrSec.UseVisualStyleBackColor = False
        '
        'rbDateRange
        '
        Me.rbDateRange.AutoSize = True
        Me.rbDateRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbDateRange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbDateRange.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDateRange.ForeColor = System.Drawing.Color.Gold
        Me.rbDateRange.Location = New System.Drawing.Point(131, 14)
        Me.rbDateRange.Name = "rbDateRange"
        Me.rbDateRange.Size = New System.Drawing.Size(95, 19)
        Me.rbDateRange.TabIndex = 7
        Me.rbDateRange.Text = "Date Range"
        Me.rbDateRange.UseVisualStyleBackColor = False
        '
        'rbSearch
        '
        Me.rbSearch.AutoSize = True
        Me.rbSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbSearch.Checked = True
        Me.rbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSearch.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearch.ForeColor = System.Drawing.Color.Gold
        Me.rbSearch.Location = New System.Drawing.Point(313, 14)
        Me.rbSearch.Name = "rbSearch"
        Me.rbSearch.Size = New System.Drawing.Size(102, 19)
        Me.rbSearch.TabIndex = 7
        Me.rbSearch.TabStop = True
        Me.rbSearch.Text = "Search Key:"
        Me.rbSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(550, 507)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sort by:"
        '
        'cmbSortBy
        '
        Me.cmbSortBy.BackColor = System.Drawing.Color.White
        Me.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortBy.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSortBy.ForeColor = System.Drawing.Color.Black
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Items.AddRange(New Object() {"Student Number", "Name", "Log state", "Date/Time"})
        Me.cmbSortBy.Location = New System.Drawing.Point(613, 504)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(135, 24)
        Me.cmbSortBy.TabIndex = 4
        '
        'llblAlternative
        '
        Me.llblAlternative.AutoSize = True
        Me.llblAlternative.BackColor = System.Drawing.Color.Transparent
        Me.llblAlternative.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblAlternative.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblAlternative.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblAlternative.Location = New System.Drawing.Point(351, 599)
        Me.llblAlternative.Name = "llblAlternative"
        Me.llblAlternative.Size = New System.Drawing.Size(141, 15)
        Me.llblAlternative.TabIndex = 10
        Me.llblAlternative.TabStop = True
        Me.llblAlternative.Text = "Alternative searching"
        '
        'lblReCount
        '
        Me.lblReCount.AutoSize = True
        Me.lblReCount.BackColor = System.Drawing.Color.Transparent
        Me.lblReCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblReCount.Location = New System.Drawing.Point(7, 504)
        Me.lblReCount.Name = "lblReCount"
        Me.lblReCount.Size = New System.Drawing.Size(87, 13)
        Me.lblReCount.TabIndex = 11
        Me.lblReCount.Text = "Record count:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cmbSearchBy)
        Me.GroupBox1.Controls.Add(Me.rbCourseYrSec)
        Me.GroupBox1.Controls.Add(Me.rbSearch)
        Me.GroupBox1.Controls.Add(Me.rbDateRange)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 43)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Controls.Add(Me.lblReCount)
        Me.GroupBox2.Controls.Add(Me.cmbSortBy)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 539)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Location = New System.Drawing.Point(132, 593)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(117, 28)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(647, 589)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 28)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(9, 593)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(117, 28)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'frmStudentLogRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 627)
        Me.Controls.Add(Me.llblAlternative)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentLogRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of all student logs"
        Me.cmsStudLogs.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents rbCourseYrSec As System.Windows.Forms.RadioButton
    Friend WithEvents rbDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents rbSearch As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents llblAlternative As System.Windows.Forms.LinkLabel
    Friend WithEvents lblReCount As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmsStudLogs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmViewStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEditStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSendMessage As System.Windows.Forms.ToolStripMenuItem
End Class
