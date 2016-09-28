<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblConfig = New System.Windows.Forms.Label
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.pbLoad = New System.Windows.Forms.PictureBox
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(-2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 96)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PUPSMBC STUDENT SECURITY MONITORING SYSTEM USING RADIO FREQUENCY IDENTIFICATION W" & _
            "ITH SMS TECHNOLOGY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConfig
        '
        Me.lblConfig.AutoSize = True
        Me.lblConfig.Location = New System.Drawing.Point(10, 108)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(152, 13)
        Me.lblConfig.TabIndex = 147
        Me.lblConfig.Text = "Initializing program sequence..."
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 7000
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.appleload
        Me.pbLoading.Location = New System.Drawing.Point(334, 104)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(16, 14)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 148
        Me.pbLoading.TabStop = False
        '
        'pbLoad
        '
        Me.pbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoad.Image = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.Apple_Loading
        Me.pbLoad.Location = New System.Drawing.Point(13, 124)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(338, 10)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 146
        Me.pbLoad.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 139)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.lblConfig)
        Me.Controls.Add(Me.pbLoad)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Starting program"
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfig As System.Windows.Forms.Label
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLoad As System.Windows.Forms.Timer
End Class
