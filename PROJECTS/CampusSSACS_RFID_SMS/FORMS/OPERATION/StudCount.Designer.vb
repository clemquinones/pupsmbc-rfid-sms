<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentCounts
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
        Me.lblReCount = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox
        Me.lblCYS = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReCount
        '
        Me.lblReCount.AutoSize = True
        Me.lblReCount.BackColor = System.Drawing.Color.Transparent
        Me.lblReCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblReCount.Location = New System.Drawing.Point(10, 468)
        Me.lblReCount.Name = "lblReCount"
        Me.lblReCount.Size = New System.Drawing.Size(87, 13)
        Me.lblReCount.TabIndex = 9
        Me.lblReCount.Text = "Record count:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(495, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Enabled = False
        Me.cmbSection.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.ForeColor = System.Drawing.Color.Gray
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(455, 24)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(137, 26)
        Me.cmbSection.Sorted = True
        Me.cmbSection.TabIndex = 198
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.ForeColor = System.Drawing.Color.Gray
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Location = New System.Drawing.Point(227, 23)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(137, 26)
        Me.cmbYearLevel.Sorted = True
        Me.cmbYearLevel.TabIndex = 197
        '
        'lblCYS
        '
        Me.lblCYS.BackColor = System.Drawing.Color.Transparent
        Me.lblCYS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCYS.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCYS.ForeColor = System.Drawing.Color.Gold
        Me.lblCYS.Location = New System.Drawing.Point(6, 16)
        Me.lblCYS.Name = "lblCYS"
        Me.lblCYS.Size = New System.Drawing.Size(165, 38)
        Me.lblCYS.TabIndex = 199
        Me.lblCYS.Text = "BSIT IV-2"
        Me.lblCYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblCYS)
        Me.GroupBox1.Controls.Add(Me.cmbSection)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbYearLevel)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 62)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Students"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(390, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Section:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(177, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Year:"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LV.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.LV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(13, 16)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(593, 445)
        Me.LV.TabIndex = 202
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Student #"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Course"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Year"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Section"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LV)
        Me.GroupBox3.Controls.Add(Me.lblReCount)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 491)
        Me.GroupBox3.TabIndex = 203
        Me.GroupBox3.TabStop = False
        '
        'frmStudentCounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 614)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentCounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblReCount As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblCYS As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
