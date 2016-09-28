<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCourseYrSec
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
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFilter = New System.Windows.Forms.Button
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(91, 37)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(155, 23)
        Me.cmbCourse.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Course:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.White
        Me.btnFilter.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(149, 123)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(98, 31)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(91, 66)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(155, 23)
        Me.cmbYear.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Year Level:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(91, 95)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(155, 23)
        Me.cmbSection.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(19, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Section:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDes
        '
        Me.lblDes.BackColor = System.Drawing.Color.Transparent
        Me.lblDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDes.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDes.ForeColor = System.Drawing.Color.Black
        Me.lblDes.Location = New System.Drawing.Point(14, 169)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(232, 66)
        Me.lblDes.TabIndex = 8
        Me.lblDes.Text = "Description"
        '
        'frmSearchCourseYrSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SearchCourseYrSec
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(263, 250)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSearchCourseYrSec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchCourseYrSec"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDes As System.Windows.Forms.Label
End Class
