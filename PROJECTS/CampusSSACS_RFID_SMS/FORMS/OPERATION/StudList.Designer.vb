<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentsList
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
        Me.cmsStud = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmViewStud = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEditStud = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmSendMessage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmListLogs = New System.Windows.Forms.ToolStripMenuItem
        Me.btnEncode = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblReCount = New System.Windows.Forms.Label
        Me.llblStudProf = New System.Windows.Forms.LinkLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtRSearch = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnParent = New System.Windows.Forms.Button
        Me.ttStudList = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsStud.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LV.ContextMenuStrip = Me.cmsStud
        Me.LV.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 16)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(713, 552)
        Me.LV.TabIndex = 1
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
        Me.ColumnHeader2.Width = 230
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Department"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Year"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 65
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Section"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 65
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 75
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Gender"
        Me.ColumnHeader7.Width = 70
        '
        'cmsStud
        '
        Me.cmsStud.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmViewStud, Me.tsmEditStud, Me.tsmSendMessage, Me.ToolStripSeparator4, Me.tsmListLogs})
        Me.cmsStud.Name = "ContextMenuStrip1"
        Me.cmsStud.Size = New System.Drawing.Size(193, 98)
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
        'tsmSendMessage
        '
        Me.tsmSendMessage.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SMS1
        Me.tsmSendMessage.Name = "tsmSendMessage"
        Me.tsmSendMessage.Size = New System.Drawing.Size(192, 22)
        Me.tsmSendMessage.Text = "Send Message..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
        '
        'tsmListLogs
        '
        Me.tsmListLogs.Name = "tsmListLogs"
        Me.tsmListLogs.Size = New System.Drawing.Size(192, 22)
        Me.tsmListLogs.Text = "List Student Logs"
        '
        'btnEncode
        '
        Me.btnEncode.BackColor = System.Drawing.Color.Black
        Me.btnEncode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncode.ForeColor = System.Drawing.Color.Gold
        Me.btnEncode.Location = New System.Drawing.Point(134, 650)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(165, 29)
        Me.btnEncode.TabIndex = 9
        Me.btnEncode.Text = "&Encode new student"
        Me.ttStudList.SetToolTip(Me.btnEncode, "Add new student")
        Me.btnEncode.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(638, 650)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 29)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.ttStudList.SetToolTip(Me.btnClose, "Close")
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblReCount
        '
        Me.lblReCount.AutoSize = True
        Me.lblReCount.BackColor = System.Drawing.Color.Transparent
        Me.lblReCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblReCount.Location = New System.Drawing.Point(6, 573)
        Me.lblReCount.Name = "lblReCount"
        Me.lblReCount.Size = New System.Drawing.Size(87, 13)
        Me.lblReCount.TabIndex = 10
        Me.lblReCount.Text = "Record count:"
        '
        'llblStudProf
        '
        Me.llblStudProf.AutoSize = True
        Me.llblStudProf.BackColor = System.Drawing.Color.Transparent
        Me.llblStudProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblStudProf.Enabled = False
        Me.llblStudProf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblStudProf.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblStudProf.Location = New System.Drawing.Point(584, 573)
        Me.llblStudProf.Name = "llblStudProf"
        Me.llblStudProf.Size = New System.Drawing.Size(132, 13)
        Me.llblStudProf.TabIndex = 197
        Me.llblStudProf.TabStop = True
        Me.llblStudProf.Text = "View student profile..."
        Me.ttStudList.SetToolTip(Me.llblStudProf, "View student profile")
        Me.llblStudProf.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.lblReCount)
        Me.GroupBox1.Controls.Add(Me.llblStudProf)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 593)
        Me.GroupBox1.TabIndex = 198
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTip)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtRSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 45)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 28)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "All Students"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(381, 16)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(176, 16)
        Me.lblTip.TabIndex = 202
        Me.lblTip.Text = "Type any part of the find item:"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTip.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.searchicon
        Me.PictureBox1.Location = New System.Drawing.Point(693, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 201
        Me.PictureBox1.TabStop = False
        '
        'txtRSearch
        '
        Me.txtRSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtRSearch.Location = New System.Drawing.Point(563, 14)
        Me.txtRSearch.MaxLength = 20
        Me.txtRSearch.Name = "txtRSearch"
        Me.txtRSearch.Size = New System.Drawing.Size(124, 21)
        Me.txtRSearch.TabIndex = 200
        Me.txtRSearch.Text = "Search"
        Me.ttStudList.SetToolTip(Me.txtRSearch, "Search student here")
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(14, 650)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 29)
        Me.btnPrint.TabIndex = 200
        Me.btnPrint.Text = "&Print..."
        Me.ttStudList.SetToolTip(Me.btnPrint, "Print student list")
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnParent
        '
        Me.btnParent.BackColor = System.Drawing.Color.Black
        Me.btnParent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParent.ForeColor = System.Drawing.Color.Gold
        Me.btnParent.Location = New System.Drawing.Point(514, 650)
        Me.btnParent.Name = "btnParent"
        Me.btnParent.Size = New System.Drawing.Size(118, 29)
        Me.btnParent.TabIndex = 201
        Me.btnParent.Text = "&List Parents..."
        Me.ttStudList.SetToolTip(Me.btnParent, "List parents")
        Me.btnParent.UseVisualStyleBackColor = False
        '
        'frmStudentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 688)
        Me.Controls.Add(Me.btnParent)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students List"
        Me.cmsStud.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEncode As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblReCount As System.Windows.Forms.Label
    Friend WithEvents llblStudProf As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnParent As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsStud As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmViewStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEditStud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSendMessage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmListLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttStudList As System.Windows.Forms.ToolTip
End Class
