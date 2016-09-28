<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeptAddEdit
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
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAddSection = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gold
        Me.btnAdd.Location = New System.Drawing.Point(76, 267)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 30)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Black
        Me.txtDescription.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(17, 99)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(235, 75)
        Me.txtDescription.TabIndex = 10
        Me.txtDescription.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Department Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "(Bachelor of Science in... e.g.)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(105, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "(BSIT, BSA, BSEM... e.g.)"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(167, 267)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 30)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Black
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(17, 28)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(237, 22)
        Me.txtCode.TabIndex = 9
        Me.txtCode.Text = "Code"
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.Black
        Me.txtYear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.White
        Me.txtYear.Location = New System.Drawing.Point(19, 219)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(64, 22)
        Me.txtYear.TabIndex = 17
        Me.txtYear.Text = "Year"
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(7, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 14)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "No. of Years:"
        '
        'btnAddSection
        '
        Me.btnAddSection.BackColor = System.Drawing.Color.White
        Me.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSection.Enabled = False
        Me.btnAddSection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSection.Location = New System.Drawing.Point(109, 218)
        Me.btnAddSection.Name = "btnAddSection"
        Me.btnAddSection.Size = New System.Drawing.Size(143, 25)
        Me.btnAddSection.TabIndex = 19
        Me.btnAddSection.Text = "Add Sections..."
        Me.btnAddSection.UseVisualStyleBackColor = False
        '
        'frmDeptAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.AddDepartment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(264, 309)
        Me.Controls.Add(Me.btnAddSection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeptAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Add"
        Me.Text = "Add Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAddSection As System.Windows.Forms.Button
End Class
