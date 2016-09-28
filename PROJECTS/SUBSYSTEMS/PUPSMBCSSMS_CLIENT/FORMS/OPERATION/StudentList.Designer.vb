<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentList
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTip = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbDept = New System.Windows.Forms.ComboBox
        Me.cmsStud = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.cmsStud.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 19)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(572, 529)
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
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Yr-Sec"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gender"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 585)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(483, 554)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(3, 551)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(180, 16)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "Record count: 0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.lblTip)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.cmbDept)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lblTip
        '
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(201, 17)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(180, 23)
        Me.lblTip.TabIndex = 2
        Me.lblTip.Text = "Type any part of the findstudent:"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(386, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(161, 22)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Search"
        '
        'cmbDept
        '
        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Items.AddRange(New Object() {"All Department"})
        Me.cmbDept.Location = New System.Drawing.Point(21, 20)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(162, 22)
        Me.cmbDept.TabIndex = 0
        '
        'cmsStud
        '
        Me.cmsStud.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmView, Me.ToolStripSeparator1, Me.tsmExit})
        Me.cmsStud.Name = "cmsStud"
        Me.cmsStud.Size = New System.Drawing.Size(202, 54)
        '
        'tsmView
        '
        Me.tsmView.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmView.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.No_Picture
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(201, 22)
        Me.tsmView.Text = "View Student Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(201, 22)
        Me.tsmExit.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.searchIcon
        Me.PictureBox1.Location = New System.Drawing.Point(553, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'frmStudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 652)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmStudentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.cmsStud.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmsStud As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
