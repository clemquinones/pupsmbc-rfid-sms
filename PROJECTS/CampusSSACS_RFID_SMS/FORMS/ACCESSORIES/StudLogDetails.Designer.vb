<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudLogDetails
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
        Me.lblName = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.lblCourseYearSec = New System.Windows.Forms.Label
        Me.lblDateTimeLog = New System.Windows.Forms.Label
        Me.pbPic = New System.Windows.Forms.PictureBox
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(37, 339)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(268, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "--Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudNo
        '
        Me.lblStudNo.BackColor = System.Drawing.Color.White
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudNo.Location = New System.Drawing.Point(37, 309)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(268, 25)
        Me.lblStudNo.TabIndex = 1
        Me.lblStudNo.Text = "--Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseYearSec
        '
        Me.lblCourseYearSec.BackColor = System.Drawing.Color.White
        Me.lblCourseYearSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCourseYearSec.Location = New System.Drawing.Point(37, 369)
        Me.lblCourseYearSec.Name = "lblCourseYearSec"
        Me.lblCourseYearSec.Size = New System.Drawing.Size(268, 25)
        Me.lblCourseYearSec.TabIndex = 2
        Me.lblCourseYearSec.Text = "--Course/Yr/Sec"
        Me.lblCourseYearSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTimeLog
        '
        Me.lblDateTimeLog.BackColor = System.Drawing.Color.White
        Me.lblDateTimeLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTimeLog.Location = New System.Drawing.Point(37, 399)
        Me.lblDateTimeLog.Name = "lblDateTimeLog"
        Me.lblDateTimeLog.Size = New System.Drawing.Size(268, 25)
        Me.lblDateTimeLog.TabIndex = 3
        Me.lblDateTimeLog.Text = "--Date Time log"
        Me.lblDateTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPic
        '
        Me.pbPic.BackColor = System.Drawing.Color.White
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPic.Location = New System.Drawing.Point(46, 12)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(268, 255)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 4
        Me.pbPic.TabStop = False
        '
        'frmStudLogDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 452)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.lblDateTimeLog)
        Me.Controls.Add(Me.lblCourseYearSec)
        Me.Controls.Add(Me.lblStudNo)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudLogDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudLogDetails"
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblCourseYearSec As System.Windows.Forms.Label
    Friend WithEvents lblDateTimeLog As System.Windows.Forms.Label
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
End Class
