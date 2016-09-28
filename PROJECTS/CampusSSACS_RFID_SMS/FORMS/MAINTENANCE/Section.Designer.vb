<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSection
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
        Me.txtSec = New System.Windows.Forms.TextBox
        Me.lblSec = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSet = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSec
        '
        Me.txtSec.Enabled = False
        Me.txtSec.Location = New System.Drawing.Point(8, 67)
        Me.txtSec.MaxLength = 2
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(61, 20)
        Me.txtSec.TabIndex = 1
        Me.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSec
        '
        Me.lblSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSec.ForeColor = System.Drawing.Color.Gold
        Me.lblSec.Location = New System.Drawing.Point(6, 16)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(140, 45)
        Me.lblSec.TabIndex = 2
        Me.lblSec.Text = "Ente number of sections in "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(152, 161)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 26)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(9, 14)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(166, 96)
        Me.LV.TabIndex = 4
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Year Level"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sections"
        Me.ColumnHeader2.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSet)
        Me.GroupBox1.Controls.Add(Me.lblSec)
        Me.GroupBox1.Controls.Add(Me.txtSec)
        Me.GroupBox1.Location = New System.Drawing.Point(181, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 101)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.White
        Me.btnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.Location = New System.Drawing.Point(75, 64)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(71, 26)
        Me.btnSet.TabIndex = 4
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(251, 161)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 26)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Add sections"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 117)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'frmAddSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 194)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Section"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
