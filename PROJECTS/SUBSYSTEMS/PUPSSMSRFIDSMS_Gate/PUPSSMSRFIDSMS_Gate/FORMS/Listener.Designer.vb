<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListener
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
        Me.lblConfig = New System.Windows.Forms.Label
        Me.tmrDetect = New System.Windows.Forms.Timer(Me.components)
        Me.lblTip = New System.Windows.Forms.Label
        Me.pbLoading = New System.Windows.Forms.PictureBox
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConfig
        '
        Me.lblConfig.Location = New System.Drawing.Point(7, 102)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(350, 34)
        Me.lblConfig.TabIndex = 151
        Me.lblConfig.Text = "LOG IN: INFOTECHNETWORK"
        '
        'tmrDetect
        '
        Me.tmrDetect.Interval = 2000
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.Black
        Me.lblTip.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.Gold
        Me.lblTip.Location = New System.Drawing.Point(0, 0)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(361, 96)
        Me.lblTip.TabIndex = 149
        Me.lblTip.Text = "WAITING FOR THE USER TO ACTIVATE MONITORING..."
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.Load
        Me.pbLoading.Location = New System.Drawing.Point(3, 3)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(23, 24)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 152
        Me.pbLoading.TabStop = False
        '
        'frmListener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(360, 143)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.lblConfig)
        Me.Controls.Add(Me.lblTip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmListener"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listening..."
        Me.TopMost = True
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfig As System.Windows.Forms.Label
    Friend WithEvents tmrDetect As System.Windows.Forms.Timer
    Friend WithEvents lblTip As System.Windows.Forms.Label
End Class
