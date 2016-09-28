<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvSched = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnShow = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Saturday"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(227, 23)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(59, 22)
        Me.cmbSection.TabIndex = 13
        Me.cmbSection.Text = "--Sec"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sunday"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Location = New System.Drawing.Point(156, 23)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(65, 22)
        Me.cmbYearLevel.TabIndex = 12
        Me.cmbYearLevel.Text = "--Year"
        '
        'cmbCourse
        '
        Me.cmbCourse.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(11, 23)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(139, 22)
        Me.cmbCourse.TabIndex = 11
        Me.cmbCourse.Text = "--Choose course"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Friday"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'lvSched
        '
        Me.lvSched.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvSched.FullRowSelect = True
        Me.lvSched.GridLines = True
        Me.lvSched.Location = New System.Drawing.Point(11, 51)
        Me.lvSched.MultiSelect = False
        Me.lvSched.Name = "lvSched"
        Me.lvSched.Size = New System.Drawing.Size(888, 294)
        Me.lvSched.TabIndex = 10
        Me.lvSched.UseCompatibleStateImageBehavior = False
        Me.lvSched.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Monday"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tuesday"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Wednesday"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Thursday"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(292, 20)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 26)
        Me.btnShow.TabIndex = 14
        Me.btnShow.Text = "◘ &Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 364)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.lvSched)
        Me.Controls.Add(Me.btnShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSched As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
