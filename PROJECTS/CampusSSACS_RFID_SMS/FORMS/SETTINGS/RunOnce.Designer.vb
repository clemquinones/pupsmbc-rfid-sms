<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstTimeRunOnce
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
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pbLoad = New System.Windows.Forms.PictureBox
        Me.lblConfig = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbLoading = New System.Windows.Forms.PictureBox
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 10000
        '
        'pbLoad
        '
        Me.pbLoad.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Loading1
        Me.pbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoad.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Loading
        Me.pbLoad.Location = New System.Drawing.Point(10, 123)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(338, 10)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 0
        Me.pbLoad.TabStop = False
        '
        'lblConfig
        '
        Me.lblConfig.AutoSize = True
        Me.lblConfig.Location = New System.Drawing.Point(7, 107)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(198, 13)
        Me.lblConfig.TabIndex = 1
        Me.lblConfig.Text = "Configuring the system for first time use..."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 96)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PUPSMBC STUDENT SECURITY MONITORING SYSTEM USING RADIO FREQUENCY IDENTIFICATION W" & _
            "ITH SMS TECHNOLOGY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.Location = New System.Drawing.Point(331, 103)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(16, 14)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 145
        Me.pbLoading.TabStop = False
        '
        'frmFirstTimeRunOnce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 139)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblConfig)
        Me.Controls.Add(Me.pbLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFirstTimeRunOnce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please wait..."
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrLoad As System.Windows.Forms.Timer
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfig As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
End Class
