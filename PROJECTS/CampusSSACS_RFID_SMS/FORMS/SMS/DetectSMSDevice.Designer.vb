<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetectSMSDevice
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
        Me.lblStatus = New System.Windows.Forms.Label
        Me.tmrDetect = New System.Windows.Forms.Timer(Me.components)
        Me.btnRetry = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.pbLoading = New System.Windows.Forms.PictureBox
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gold
        Me.lblStatus.Location = New System.Drawing.Point(41, 3)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(328, 30)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Detecting device..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrDetect
        '
        Me.tmrDetect.Enabled = True
        Me.tmrDetect.Interval = 2000
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.White
        Me.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.ForeColor = System.Drawing.Color.Black
        Me.btnRetry.Location = New System.Drawing.Point(207, 34)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(75, 23)
        Me.btnRetry.TabIndex = 1
        Me.btnRetry.Text = "&Retry"
        Me.btnRetry.UseVisualStyleBackColor = False
        Me.btnRetry.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(288, 34)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.Location = New System.Drawing.Point(8, 9)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(24, 19)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 3
        Me.pbLoading.TabStop = False
        '
        'frmDetectSMSDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(375, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetectSMSDevice"
        Me.Text = "GSM Module"
        Me.TopMost = True
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrDetect As System.Windows.Forms.Timer
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
End Class
