<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudViewDetails
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
        Me.pbPic = New System.Windows.Forms.PictureBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.lblCourseYrSec = New System.Windows.Forms.Label
        Me.llblViewLogs = New System.Windows.Forms.LinkLabel
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lblRecCount = New System.Windows.Forms.Label
        Me.llblRefresh = New System.Windows.Forms.LinkLabel
        Me.gbStudentInfo = New System.Windows.Forms.GroupBox
        Me.llblUpdateInfo = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.llblSendMessage = New System.Windows.Forms.LinkLabel
        Me.lblAddress = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttPic = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStudentInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPic.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.NoPicture
        Me.pbPic.Location = New System.Drawing.Point(385, 18)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(138, 138)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 15
        Me.pbPic.TabStop = False
        Me.ttPic.SetToolTip(Me.pbPic, "Click to send message")
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gold
        Me.lblName.Location = New System.Drawing.Point(103, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(276, 33)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name: Brittle BukoPandan"
        '
        'lblStudNo
        '
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.Gold
        Me.lblStudNo.Location = New System.Drawing.Point(103, 18)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(276, 21)
        Me.lblStudNo.TabIndex = 17
        Me.lblStudNo.Text = "Student Number: 00000"
        '
        'lblCourseYrSec
        '
        Me.lblCourseYrSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseYrSec.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseYrSec.ForeColor = System.Drawing.Color.Gold
        Me.lblCourseYrSec.Location = New System.Drawing.Point(103, 88)
        Me.lblCourseYrSec.Name = "lblCourseYrSec"
        Me.lblCourseYrSec.Size = New System.Drawing.Size(276, 19)
        Me.lblCourseYrSec.TabIndex = 19
        Me.lblCourseYrSec.Text = "Course/Yr/Sec: BSCOE 1-4"
        '
        'llblViewLogs
        '
        Me.llblViewLogs.AutoSize = True
        Me.llblViewLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblViewLogs.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblViewLogs.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.llblViewLogs.Location = New System.Drawing.Point(7, 161)
        Me.llblViewLogs.Name = "llblViewLogs"
        Me.llblViewLogs.Size = New System.Drawing.Size(119, 15)
        Me.llblViewLogs.TabIndex = 0
        Me.llblViewLogs.TabStop = True
        Me.llblViewLogs.Text = "View log records"
        Me.ttPic.SetToolTip(Me.llblViewLogs, "View all logs")
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(10, 19)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(513, 292)
        Me.LV.TabIndex = 21
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date/Time"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Log state"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 140
        '
        'lblRecCount
        '
        Me.lblRecCount.AutoSize = True
        Me.lblRecCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecCount.ForeColor = System.Drawing.Color.White
        Me.lblRecCount.Location = New System.Drawing.Point(15, 316)
        Me.lblRecCount.Name = "lblRecCount"
        Me.lblRecCount.Size = New System.Drawing.Size(104, 13)
        Me.lblRecCount.TabIndex = 22
        Me.lblRecCount.Text = "Records count: 0"
        '
        'llblRefresh
        '
        Me.llblRefresh.AutoSize = True
        Me.llblRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRefresh.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblRefresh.Location = New System.Drawing.Point(466, 316)
        Me.llblRefresh.Name = "llblRefresh"
        Me.llblRefresh.Size = New System.Drawing.Size(44, 13)
        Me.llblRefresh.TabIndex = 23
        Me.llblRefresh.TabStop = True
        Me.llblRefresh.Text = "Refresh"
        Me.ttPic.SetToolTip(Me.llblRefresh, "Refresh")
        '
        'gbStudentInfo
        '
        Me.gbStudentInfo.Controls.Add(Me.llblUpdateInfo)
        Me.gbStudentInfo.Controls.Add(Me.Label4)
        Me.gbStudentInfo.Controls.Add(Me.Label3)
        Me.gbStudentInfo.Controls.Add(Me.Label2)
        Me.gbStudentInfo.Controls.Add(Me.Label1)
        Me.gbStudentInfo.Controls.Add(Me.llblSendMessage)
        Me.gbStudentInfo.Controls.Add(Me.lblAddress)
        Me.gbStudentInfo.Controls.Add(Me.lblStudNo)
        Me.gbStudentInfo.Controls.Add(Me.lblName)
        Me.gbStudentInfo.Controls.Add(Me.llblViewLogs)
        Me.gbStudentInfo.Controls.Add(Me.lblCourseYrSec)
        Me.gbStudentInfo.Controls.Add(Me.pbPic)
        Me.gbStudentInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudentInfo.ForeColor = System.Drawing.Color.White
        Me.gbStudentInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbStudentInfo.Name = "gbStudentInfo"
        Me.gbStudentInfo.Size = New System.Drawing.Size(531, 185)
        Me.gbStudentInfo.TabIndex = 24
        Me.gbStudentInfo.TabStop = False
        Me.gbStudentInfo.Text = "Student Information"
        '
        'llblUpdateInfo
        '
        Me.llblUpdateInfo.AutoSize = True
        Me.llblUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblUpdateInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblUpdateInfo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.llblUpdateInfo.Location = New System.Drawing.Point(197, 161)
        Me.llblUpdateInfo.Name = "llblUpdateInfo"
        Me.llblUpdateInfo.Size = New System.Drawing.Size(140, 15)
        Me.llblUpdateInfo.TabIndex = 26
        Me.llblUpdateInfo.TabStop = True
        Me.llblUpdateInfo.Text = "Update Inforrmation"
        Me.ttPic.SetToolTip(Me.llblUpdateInfo, "Update student details")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Course/Yr/Sec:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Student #:"
        '
        'llblSendMessage
        '
        Me.llblSendMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblSendMessage.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.llblSendMessage.Location = New System.Drawing.Point(385, 159)
        Me.llblSendMessage.Name = "llblSendMessage"
        Me.llblSendMessage.Size = New System.Drawing.Size(138, 19)
        Me.llblSendMessage.TabIndex = 25
        Me.llblSendMessage.TabStop = True
        Me.llblSendMessage.Text = "Send Message..."
        Me.llblSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Gold
        Me.lblAddress.Location = New System.Drawing.Point(103, 114)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(276, 42)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.lblRecCount)
        Me.GroupBox1.Controls.Add(Me.llblRefresh)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 332)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'frmStudViewDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbStudentInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudViewDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Profile"
        Me.TopMost = True
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStudentInfo.ResumeLayout(False)
        Me.gbStudentInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblCourseYrSec As System.Windows.Forms.Label
    Friend WithEvents llblViewLogs As System.Windows.Forms.LinkLabel
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRecCount As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents llblRefresh As System.Windows.Forms.LinkLabel
    Friend WithEvents gbStudentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents llblSendMessage As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents llblUpdateInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents ttPic As System.Windows.Forms.ToolTip
End Class
