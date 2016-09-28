<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseRecipients
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
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("No items...")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("No items...")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowseRecipients))
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("No items...")
        Me.LVStud = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.LVParent = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.gbOption = New System.Windows.Forms.GroupBox
        Me.chkAllRead = New System.Windows.Forms.CheckBox
        Me.chkParent = New System.Windows.Forms.CheckBox
        Me.chkStudent = New System.Windows.Forms.CheckBox
        Me.cmbDept = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbStudParent = New System.Windows.Forms.RadioButton
        Me.rbFacultyUtility = New System.Windows.Forms.RadioButton
        Me.gbStudPar = New System.Windows.Forms.GroupBox
        Me.gbFacUtl = New System.Windows.Forms.GroupBox
        Me.LVFU = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkFaUt = New System.Windows.Forms.CheckBox
        Me.chkUtility = New System.Windows.Forms.CheckBox
        Me.chkFaculty = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbDept1 = New System.Windows.Forms.ComboBox
        Me.gbOption.SuspendLayout()
        Me.gbStudPar.SuspendLayout()
        Me.gbFacUtl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVStud
        '
        Me.LVStud.CheckBoxes = True
        Me.LVStud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LVStud.FullRowSelect = True
        Me.LVStud.GridLines = True
        ListViewItem7.StateImageIndex = 0
        Me.LVStud.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7})
        Me.LVStud.Location = New System.Drawing.Point(11, 72)
        Me.LVStud.MultiSelect = False
        Me.LVStud.Name = "LVStud"
        Me.LVStud.Size = New System.Drawing.Size(207, 349)
        Me.LVStud.TabIndex = 0
        Me.LVStud.UseCompatibleStateImageBehavior = False
        Me.LVStud.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student Number"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'LVParent
        '
        Me.LVParent.CheckBoxes = True
        Me.LVParent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVParent.FullRowSelect = True
        Me.LVParent.GridLines = True
        ListViewItem8.StateImageIndex = 0
        Me.LVParent.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem8})
        Me.LVParent.Location = New System.Drawing.Point(224, 72)
        Me.LVParent.MultiSelect = False
        Me.LVParent.Name = "LVParent"
        Me.LVParent.Size = New System.Drawing.Size(208, 349)
        Me.LVParent.TabIndex = 1
        Me.LVParent.UseCompatibleStateImageBehavior = False
        Me.LVParent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Student Number"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Number of Gurdian"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'gbOption
        '
        Me.gbOption.Controls.Add(Me.chkAllRead)
        Me.gbOption.Controls.Add(Me.chkParent)
        Me.gbOption.Controls.Add(Me.chkStudent)
        Me.gbOption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOption.ForeColor = System.Drawing.Color.White
        Me.gbOption.Location = New System.Drawing.Point(11, 18)
        Me.gbOption.Name = "gbOption"
        Me.gbOption.Size = New System.Drawing.Size(288, 48)
        Me.gbOption.TabIndex = 2
        Me.gbOption.TabStop = False
        Me.gbOption.Text = "Selection"
        '
        'chkAllRead
        '
        Me.chkAllRead.AutoSize = True
        Me.chkAllRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAllRead.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllRead.Location = New System.Drawing.Point(16, 21)
        Me.chkAllRead.Name = "chkAllRead"
        Me.chkAllRead.Size = New System.Drawing.Size(76, 18)
        Me.chkAllRead.TabIndex = 2
        Me.chkAllRead.Text = "All Read"
        Me.chkAllRead.UseVisualStyleBackColor = True
        '
        'chkParent
        '
        Me.chkParent.AutoSize = True
        Me.chkParent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkParent.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkParent.Location = New System.Drawing.Point(198, 21)
        Me.chkParent.Name = "chkParent"
        Me.chkParent.Size = New System.Drawing.Size(86, 18)
        Me.chkParent.TabIndex = 1
        Me.chkParent.Text = "All Parent"
        Me.chkParent.UseVisualStyleBackColor = True
        '
        'chkStudent
        '
        Me.chkStudent.AutoSize = True
        Me.chkStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkStudent.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStudent.Location = New System.Drawing.Point(98, 21)
        Me.chkStudent.Name = "chkStudent"
        Me.chkStudent.Size = New System.Drawing.Size(94, 18)
        Me.chkStudent.TabIndex = 0
        Me.chkStudent.Text = "All Student"
        Me.chkStudent.UseVisualStyleBackColor = True
        '
        'cmbDept
        '
        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(313, 45)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(119, 21)
        Me.cmbDept.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(355, 480)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 28)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Black
        Me.btnOk.BackgroundImage = CType(resources.GetObject("btnOk.BackgroundImage"), System.Drawing.Image)
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Gold
        Me.btnOk.Location = New System.Drawing.Point(240, 480)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(109, 28)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Filter by Department:"
        '
        'rbStudParent
        '
        Me.rbStudParent.AutoSize = True
        Me.rbStudParent.Checked = True
        Me.rbStudParent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbStudParent.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStudParent.ForeColor = System.Drawing.Color.Gold
        Me.rbStudParent.Location = New System.Drawing.Point(20, 13)
        Me.rbStudParent.Name = "rbStudParent"
        Me.rbStudParent.Size = New System.Drawing.Size(136, 18)
        Me.rbStudParent.TabIndex = 15
        Me.rbStudParent.TabStop = True
        Me.rbStudParent.Text = "Student / Parent"
        Me.rbStudParent.UseVisualStyleBackColor = True
        '
        'rbFacultyUtility
        '
        Me.rbFacultyUtility.AutoSize = True
        Me.rbFacultyUtility.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbFacultyUtility.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacultyUtility.ForeColor = System.Drawing.Color.Gold
        Me.rbFacultyUtility.Location = New System.Drawing.Point(162, 13)
        Me.rbFacultyUtility.Name = "rbFacultyUtility"
        Me.rbFacultyUtility.Size = New System.Drawing.Size(129, 18)
        Me.rbFacultyUtility.TabIndex = 16
        Me.rbFacultyUtility.Text = "Faculty / Utility"
        Me.rbFacultyUtility.UseVisualStyleBackColor = True
        '
        'gbStudPar
        '
        Me.gbStudPar.Controls.Add(Me.LVStud)
        Me.gbStudPar.Controls.Add(Me.LVParent)
        Me.gbStudPar.Controls.Add(Me.gbOption)
        Me.gbStudPar.Controls.Add(Me.Label1)
        Me.gbStudPar.Controls.Add(Me.cmbDept)
        Me.gbStudPar.ForeColor = System.Drawing.Color.White
        Me.gbStudPar.Location = New System.Drawing.Point(10, 37)
        Me.gbStudPar.Name = "gbStudPar"
        Me.gbStudPar.Size = New System.Drawing.Size(446, 437)
        Me.gbStudPar.TabIndex = 17
        Me.gbStudPar.TabStop = False
        '
        'gbFacUtl
        '
        Me.gbFacUtl.Controls.Add(Me.LVFU)
        Me.gbFacUtl.Controls.Add(Me.GroupBox2)
        Me.gbFacUtl.Controls.Add(Me.Label2)
        Me.gbFacUtl.Controls.Add(Me.cmbDept1)
        Me.gbFacUtl.ForeColor = System.Drawing.Color.Black
        Me.gbFacUtl.Location = New System.Drawing.Point(464, 37)
        Me.gbFacUtl.Name = "gbFacUtl"
        Me.gbFacUtl.Size = New System.Drawing.Size(446, 437)
        Me.gbFacUtl.TabIndex = 18
        Me.gbFacUtl.TabStop = False
        Me.gbFacUtl.Text = "Faculty and Utility"
        '
        'LVFU
        '
        Me.LVFU.CheckBoxes = True
        Me.LVFU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9})
        Me.LVFU.FullRowSelect = True
        Me.LVFU.GridLines = True
        ListViewItem9.StateImageIndex = 0
        Me.LVFU.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9})
        Me.LVFU.Location = New System.Drawing.Point(11, 73)
        Me.LVFU.MultiSelect = False
        Me.LVFU.Name = "LVFU"
        Me.LVFU.Size = New System.Drawing.Size(424, 348)
        Me.LVFU.TabIndex = 0
        Me.LVFU.UseCompatibleStateImageBehavior = False
        Me.LVFU.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Field"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Number"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFaUt)
        Me.GroupBox2.Controls.Add(Me.chkUtility)
        Me.GroupBox2.Controls.Add(Me.chkFaculty)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection"
        '
        'chkFaUt
        '
        Me.chkFaUt.AutoSize = True
        Me.chkFaUt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkFaUt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFaUt.Location = New System.Drawing.Point(16, 21)
        Me.chkFaUt.Name = "chkFaUt"
        Me.chkFaUt.Size = New System.Drawing.Size(76, 18)
        Me.chkFaUt.TabIndex = 2
        Me.chkFaUt.Text = "All Read"
        Me.chkFaUt.UseVisualStyleBackColor = True
        '
        'chkUtility
        '
        Me.chkUtility.AutoSize = True
        Me.chkUtility.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkUtility.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUtility.Location = New System.Drawing.Point(198, 21)
        Me.chkUtility.Name = "chkUtility"
        Me.chkUtility.Size = New System.Drawing.Size(79, 18)
        Me.chkUtility.TabIndex = 1
        Me.chkUtility.Text = "All Utility"
        Me.chkUtility.UseVisualStyleBackColor = True
        '
        'chkFaculty
        '
        Me.chkFaculty.AutoSize = True
        Me.chkFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkFaculty.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFaculty.Location = New System.Drawing.Point(98, 21)
        Me.chkFaculty.Name = "chkFaculty"
        Me.chkFaculty.Size = New System.Drawing.Size(88, 18)
        Me.chkFaculty.TabIndex = 0
        Me.chkFaculty.Text = "All Faculty"
        Me.chkFaculty.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Filter by Department:"
        '
        'cmbDept1
        '
        Me.cmbDept1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept1.FormattingEnabled = True
        Me.cmbDept1.Items.AddRange(New Object() {"All Read", "Faculty", "Utility"})
        Me.cmbDept1.Location = New System.Drawing.Point(316, 47)
        Me.cmbDept1.Name = "cmbDept1"
        Me.cmbDept1.Size = New System.Drawing.Size(119, 21)
        Me.cmbDept1.TabIndex = 3
        '
        'frmBrowseRecipients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 515)
        Me.Controls.Add(Me.gbFacUtl)
        Me.Controls.Add(Me.gbStudPar)
        Me.Controls.Add(Me.rbFacultyUtility)
        Me.Controls.Add(Me.rbStudParent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowseRecipients"
        Me.Text = "Browse..."
        Me.TopMost = True
        Me.gbOption.ResumeLayout(False)
        Me.gbOption.PerformLayout()
        Me.gbStudPar.ResumeLayout(False)
        Me.gbStudPar.PerformLayout()
        Me.gbFacUtl.ResumeLayout(False)
        Me.gbFacUtl.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVStud As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVParent As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbOption As System.Windows.Forms.GroupBox
    Friend WithEvents chkParent As System.Windows.Forms.CheckBox
    Friend WithEvents chkStudent As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllRead As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbStudParent As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacultyUtility As System.Windows.Forms.RadioButton
    Friend WithEvents gbStudPar As System.Windows.Forms.GroupBox
    Friend WithEvents gbFacUtl As System.Windows.Forms.GroupBox
    Friend WithEvents LVFU As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFaUt As System.Windows.Forms.CheckBox
    Friend WithEvents chkUtility As System.Windows.Forms.CheckBox
    Friend WithEvents chkFaculty As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDept1 As System.Windows.Forms.ComboBox
End Class
