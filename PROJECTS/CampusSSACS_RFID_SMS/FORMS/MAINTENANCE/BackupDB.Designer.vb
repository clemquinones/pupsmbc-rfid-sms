<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupRestoreDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestoreDB))
        Me.gbQuestion = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblRestore = New System.Windows.Forms.Label
        Me.lblBackUp = New System.Windows.Forms.Label
        Me.pbRestore = New System.Windows.Forms.PictureBox
        Me.pbBackUp = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.gbBackUp = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnBackUp = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkFileName = New System.Windows.Forms.CheckBox
        Me.txtBU_FileName = New System.Windows.Forms.TextBox
        Me.chkDirectory = New System.Windows.Forms.CheckBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.btnBrowseB = New System.Windows.Forms.Button
        Me.gbRestore = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnRestoreNow = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBUPathFile = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnBrowseR = New System.Windows.Forms.Button
        Me.ttBR = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbQuestion.SuspendLayout()
        CType(Me.pbRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBackUp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbRestore.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbQuestion
        '
        Me.gbQuestion.Controls.Add(Me.Label4)
        Me.gbQuestion.Controls.Add(Me.Label3)
        Me.gbQuestion.Controls.Add(Me.lblRestore)
        Me.gbQuestion.Controls.Add(Me.lblBackUp)
        Me.gbQuestion.Controls.Add(Me.pbRestore)
        Me.gbQuestion.Controls.Add(Me.pbBackUp)
        Me.gbQuestion.Location = New System.Drawing.Point(3, 59)
        Me.gbQuestion.Name = "gbQuestion"
        Me.gbQuestion.Size = New System.Drawing.Size(447, 203)
        Me.gbQuestion.TabIndex = 0
        Me.gbQuestion.TabStop = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(108, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lets you to restore database records from saved back up file."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(109, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lets you to create a back up file of current database records."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRestore
        '
        Me.lblRestore.BackColor = System.Drawing.Color.Transparent
        Me.lblRestore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRestore.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestore.ForeColor = System.Drawing.Color.Gold
        Me.lblRestore.Location = New System.Drawing.Point(108, 115)
        Me.lblRestore.Name = "lblRestore"
        Me.lblRestore.Size = New System.Drawing.Size(312, 48)
        Me.lblRestore.TabIndex = 6
        Me.lblRestore.Text = "RESTORE DATABASE"
        Me.lblRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttBR.SetToolTip(Me.lblRestore, "Choose Restore Operation")
        '
        'lblBackUp
        '
        Me.lblBackUp.BackColor = System.Drawing.Color.Maroon
        Me.lblBackUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBackUp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackUp.ForeColor = System.Drawing.Color.Gold
        Me.lblBackUp.Location = New System.Drawing.Point(108, 24)
        Me.lblBackUp.Name = "lblBackUp"
        Me.lblBackUp.Size = New System.Drawing.Size(312, 48)
        Me.lblBackUp.TabIndex = 5
        Me.lblBackUp.Text = "BACK UP DATABASE"
        Me.lblBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttBR.SetToolTip(Me.lblBackUp, "Choose Backup Operation")
        '
        'pbRestore
        '
        Me.pbRestore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRestore.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.RestoreDB
        Me.pbRestore.Location = New System.Drawing.Point(23, 113)
        Me.pbRestore.Name = "pbRestore"
        Me.pbRestore.Size = New System.Drawing.Size(79, 74)
        Me.pbRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRestore.TabIndex = 4
        Me.pbRestore.TabStop = False
        Me.ttBR.SetToolTip(Me.pbRestore, "Choose Restore Operation")
        '
        'pbBackUp
        '
        Me.pbBackUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBackUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBackUp.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.BackupDB
        Me.pbBackUp.Location = New System.Drawing.Point(23, 22)
        Me.pbBackUp.Name = "pbBackUp"
        Me.pbBackUp.Size = New System.Drawing.Size(79, 74)
        Me.pbBackUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBackUp.TabIndex = 3
        Me.pbBackUp.TabStop = False
        Me.ttBR.SetToolTip(Me.pbBackUp, "Choose Backup Operation")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Database
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
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
        Me.lblTitle.Location = New System.Drawing.Point(57, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(384, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "BACK UP OR RESTORE DATABASE!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(351, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 28)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Gold
        Me.btnNext.Location = New System.Drawing.Point(256, 268)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 28)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Tag = "NEXT"
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Enabled = False
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(9, 268)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 28)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Tag = ""
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gbBackUp
        '
        Me.gbBackUp.Controls.Add(Me.Label5)
        Me.gbBackUp.Controls.Add(Me.GroupBox3)
        Me.gbBackUp.Controls.Add(Me.chkDirectory)
        Me.gbBackUp.Controls.Add(Me.txtPath)
        Me.gbBackUp.Controls.Add(Me.btnBrowseB)
        Me.gbBackUp.Location = New System.Drawing.Point(468, 60)
        Me.gbBackUp.Name = "gbBackUp"
        Me.gbBackUp.Size = New System.Drawing.Size(420, 49)
        Me.gbBackUp.TabIndex = 28
        Me.gbBackUp.TabStop = False
        Me.gbBackUp.Text = "Back Up Database"
        Me.gbBackUp.Visible = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Lets you to create a back up file of current database records."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBackUp)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.chkFileName)
        Me.GroupBox3.Controls.Add(Me.txtBU_FileName)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 86)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'btnBackUp
        '
        Me.btnBackUp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.Location = New System.Drawing.Point(333, 15)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(93, 61)
        Me.btnBackUp.TabIndex = 13
        Me.btnBackUp.Text = "BACK UP NOW!"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Enter back up file name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFileName
        '
        Me.chkFileName.AutoSize = True
        Me.chkFileName.ForeColor = System.Drawing.Color.DimGray
        Me.chkFileName.Location = New System.Drawing.Point(138, 48)
        Me.chkFileName.Name = "chkFileName"
        Me.chkFileName.Size = New System.Drawing.Size(146, 17)
        Me.chkFileName.TabIndex = 11
        Me.chkFileName.Text = "Always use this file name."
        Me.chkFileName.UseVisualStyleBackColor = True
        '
        'txtBU_FileName
        '
        Me.txtBU_FileName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBU_FileName.Location = New System.Drawing.Point(138, 19)
        Me.txtBU_FileName.Name = "txtBU_FileName"
        Me.txtBU_FileName.Size = New System.Drawing.Size(152, 23)
        Me.txtBU_FileName.TabIndex = 11
        Me.txtBU_FileName.Text = "db_campus_BACK_UP"
        '
        'chkDirectory
        '
        Me.chkDirectory.AutoSize = True
        Me.chkDirectory.ForeColor = System.Drawing.Color.DimGray
        Me.chkDirectory.Location = New System.Drawing.Point(14, 79)
        Me.chkDirectory.Name = "chkDirectory"
        Me.chkDirectory.Size = New System.Drawing.Size(176, 17)
        Me.chkDirectory.TabIndex = 11
        Me.chkDirectory.Text = "Make default back up directory."
        Me.chkDirectory.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.White
        Me.txtPath.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(14, 49)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(418, 23)
        Me.txtPath.TabIndex = 10
        Me.txtPath.Text = "C:\xampp\mysql\bin"
        '
        'btnBrowseB
        '
        Me.btnBrowseB.BackColor = System.Drawing.Color.White
        Me.btnBrowseB.Location = New System.Drawing.Point(275, 75)
        Me.btnBrowseB.Name = "btnBrowseB"
        Me.btnBrowseB.Size = New System.Drawing.Size(157, 23)
        Me.btnBrowseB.TabIndex = 0
        Me.btnBrowseB.Text = "Browse backup directory..."
        Me.btnBrowseB.UseVisualStyleBackColor = False
        '
        'gbRestore
        '
        Me.gbRestore.Controls.Add(Me.GroupBox5)
        Me.gbRestore.Controls.Add(Me.txtBUPathFile)
        Me.gbRestore.Controls.Add(Me.Label8)
        Me.gbRestore.Controls.Add(Me.btnBrowseR)
        Me.gbRestore.Location = New System.Drawing.Point(468, 11)
        Me.gbRestore.Name = "gbRestore"
        Me.gbRestore.Size = New System.Drawing.Size(420, 48)
        Me.gbRestore.TabIndex = 29
        Me.gbRestore.TabStop = False
        Me.gbRestore.Text = "Restore Session"
        Me.gbRestore.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnRestoreNow)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 86)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'btnRestoreNow
        '
        Me.btnRestoreNow.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreNow.Location = New System.Drawing.Point(333, 15)
        Me.btnRestoreNow.Name = "btnRestoreNow"
        Me.btnRestoreNow.Size = New System.Drawing.Size(93, 61)
        Me.btnRestoreNow.TabIndex = 13
        Me.btnRestoreNow.Text = "RESTORE NOW"
        Me.btnRestoreNow.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(321, 63)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBUPathFile
        '
        Me.txtBUPathFile.BackColor = System.Drawing.Color.White
        Me.txtBUPathFile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBUPathFile.Location = New System.Drawing.Point(14, 49)
        Me.txtBUPathFile.Name = "txtBUPathFile"
        Me.txtBUPathFile.ReadOnly = True
        Me.txtBUPathFile.Size = New System.Drawing.Size(418, 23)
        Me.txtBUPathFile.TabIndex = 10
        Me.txtBUPathFile.Text = "D:\db_campus_BACK_UP.SQL"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(11, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Lets you to restore database records from saved back up file."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBrowseR
        '
        Me.btnBrowseR.BackColor = System.Drawing.Color.White
        Me.btnBrowseR.Location = New System.Drawing.Point(275, 75)
        Me.btnBrowseR.Name = "btnBrowseR"
        Me.btnBrowseR.Size = New System.Drawing.Size(157, 23)
        Me.btnBrowseR.TabIndex = 0
        Me.btnBrowseR.Text = "Browse back up file..."
        Me.btnBrowseR.UseVisualStyleBackColor = False
        '
        'frmBackupRestoreDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(453, 300)
        Me.Controls.Add(Me.gbRestore)
        Me.Controls.Add(Me.gbBackUp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbQuestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmBackupRestoreDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Back-up or Restore database"
        Me.TopMost = True
        Me.gbQuestion.ResumeLayout(False)
        CType(Me.pbRestore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBackUp.ResumeLayout(False)
        Me.gbBackUp.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbRestore.ResumeLayout(False)
        Me.gbRestore.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pbRestore As System.Windows.Forms.PictureBox
    Friend WithEvents pbBackUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblBackUp As System.Windows.Forms.Label
    Friend WithEvents lblRestore As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbBackUp As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseB As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents chkDirectory As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBU_FileName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkFileName As System.Windows.Forms.CheckBox
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
    Friend WithEvents gbRestore As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestoreNow As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBUPathFile As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseR As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ttBR As System.Windows.Forms.ToolTip
End Class
