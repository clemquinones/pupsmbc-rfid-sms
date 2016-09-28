<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportDirectory
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
        Me.gbQuestion = New System.Windows.Forms.GroupBox
        Me.lDefDir = New System.Windows.Forms.Label
        Me.chkDefault = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ttBR = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbQuestion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbQuestion
        '
        Me.gbQuestion.Controls.Add(Me.lDefDir)
        Me.gbQuestion.Controls.Add(Me.chkDefault)
        Me.gbQuestion.Controls.Add(Me.Label5)
        Me.gbQuestion.Controls.Add(Me.btnBrowse)
        Me.gbQuestion.Controls.Add(Me.txtPath)
        Me.gbQuestion.Location = New System.Drawing.Point(10, 66)
        Me.gbQuestion.Name = "gbQuestion"
        Me.gbQuestion.Size = New System.Drawing.Size(447, 168)
        Me.gbQuestion.TabIndex = 30
        Me.gbQuestion.TabStop = False
        '
        'lDefDir
        '
        Me.lDefDir.BackColor = System.Drawing.Color.White
        Me.lDefDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lDefDir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDefDir.ForeColor = System.Drawing.Color.Black
        Me.lDefDir.Location = New System.Drawing.Point(26, 120)
        Me.lDefDir.Name = "lDefDir"
        Me.lDefDir.Size = New System.Drawing.Size(409, 23)
        Me.lDefDir.TabIndex = 15
        Me.lDefDir.Text = "C:\REPORTS"
        Me.lDefDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.ForeColor = System.Drawing.Color.DimGray
        Me.chkDefault.Location = New System.Drawing.Point(7, 100)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(203, 17)
        Me.chkDefault.TabIndex = 14
        Me.chkDefault.Text = "Use system default for report directory"
        Me.chkDefault.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Lets you to locate or set the location for your report documents."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(308, 71)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(127, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse folder..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.White
        Me.txtPath.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(10, 42)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(429, 23)
        Me.txtPath.TabIndex = 10
        Me.txtPath.Text = "C:\REPORTS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 58)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Report
        Me.PictureBox1.Location = New System.Drawing.Point(4, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(45, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(394, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REPORT DIRECTORY"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(267, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 28)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Tag = "NEXT"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(362, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 28)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmReportDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(468, 277)
        Me.Controls.Add(Me.gbQuestion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmReportDirectory"
        Me.Text = "Browse for report directory..."
        Me.gbQuestion.ResumeLayout(False)
        Me.gbQuestion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents ttBR As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lDefDir As System.Windows.Forms.Label
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
End Class
