<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Me.cmsDept = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmUpdate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmList = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmReport = New System.Windows.Forms.ToolStripMenuItem
        Me.lblReCount = New System.Windows.Forms.Label
        Me.llblView = New System.Windows.Forms.LinkLabel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.llblRefresh = New System.Windows.Forms.LinkLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.cmsDept.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.ContextMenuStrip = Me.cmsDept
        Me.LV.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(9, 17)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(557, 238)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 320
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total # of students"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'cmsDept
        '
        Me.cmsDept.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmUpdate, Me.ToolStripSeparator1, Me.tsmList, Me.ToolStripSeparator2, Me.tsmReport})
        Me.cmsDept.Name = "cmsDept"
        Me.cmsDept.Size = New System.Drawing.Size(233, 82)
        '
        'tsmUpdate
        '
        Me.tsmUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmUpdate.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.edit
        Me.tsmUpdate.Name = "tsmUpdate"
        Me.tsmUpdate.Size = New System.Drawing.Size(232, 22)
        Me.tsmUpdate.Text = "Update Department Detaills"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        'tsmList
        '
        Me.tsmList.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.tsmList.Name = "tsmList"
        Me.tsmList.Size = New System.Drawing.Size(232, 22)
        Me.tsmList.Text = "List All Student"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(229, 6)
        '
        'tsmReport
        '
        Me.tsmReport.Name = "tsmReport"
        Me.tsmReport.Size = New System.Drawing.Size(232, 22)
        Me.tsmReport.Text = "Make a report"
        '
        'lblReCount
        '
        Me.lblReCount.AutoSize = True
        Me.lblReCount.BackColor = System.Drawing.Color.Transparent
        Me.lblReCount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblReCount.Location = New System.Drawing.Point(7, 258)
        Me.lblReCount.Name = "lblReCount"
        Me.lblReCount.Size = New System.Drawing.Size(83, 15)
        Me.lblReCount.TabIndex = 6
        Me.lblReCount.Text = "Record count:"
        '
        'llblView
        '
        Me.llblView.AutoSize = True
        Me.llblView.BackColor = System.Drawing.Color.Transparent
        Me.llblView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblView.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblView.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblView.Location = New System.Drawing.Point(460, 259)
        Me.llblView.Name = "llblView"
        Me.llblView.Size = New System.Drawing.Size(90, 14)
        Me.llblView.TabIndex = 9
        Me.llblView.TabStop = True
        Me.llblView.Text = "List Students"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gold
        Me.btnAdd.Location = New System.Drawing.Point(18, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 28)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Gold
        Me.btnEdit.Location = New System.Drawing.Point(114, 348)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 28)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(484, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 28)
        Me.btnClose.TabIndex = 25
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
        Me.btnPrint.Location = New System.Drawing.Point(389, 348)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 28)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.llblRefresh)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.llblView)
        Me.GroupBox1.Controls.Add(Me.lblReCount)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 282)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'llblRefresh
        '
        Me.llblRefresh.AutoSize = True
        Me.llblRefresh.BackColor = System.Drawing.Color.Transparent
        Me.llblRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRefresh.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblRefresh.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblRefresh.Location = New System.Drawing.Point(251, 258)
        Me.llblRefresh.Name = "llblRefresh"
        Me.llblRefresh.Size = New System.Drawing.Size(55, 14)
        Me.llblRefresh.TabIndex = 10
        Me.llblRefresh.TabStop = True
        Me.llblRefresh.Text = "Refresh"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 52)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PUPSMBC Departments"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(114, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(18, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 28)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "&Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(389, 348)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 28)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "&Print..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(484, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "&Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        Me.cmsDept.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblReCount As System.Windows.Forms.Label
    Friend WithEvents llblView As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmsDept As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llblRefresh As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
