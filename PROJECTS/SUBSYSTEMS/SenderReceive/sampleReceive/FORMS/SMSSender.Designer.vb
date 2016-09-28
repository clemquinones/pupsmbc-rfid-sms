<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSSender
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
        Me.tmrDetect = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pbRotate = New System.Windows.Forms.PictureBox
        Me.pbLoad = New System.Windows.Forms.PictureBox
        Me.tmrEnding = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrDetect
        '
        Me.tmrDetect.Interval = 2500
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gold
        Me.lblStatus.Location = New System.Drawing.Point(34, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(186, 15)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Initializing messages sequence..."
        '
        'pbRotate
        '
        Me.pbRotate.Image = Global.sampleReceive.My.Resources.Resources.appleload
        Me.pbRotate.Location = New System.Drawing.Point(12, 12)
        Me.pbRotate.Name = "pbRotate"
        Me.pbRotate.Size = New System.Drawing.Size(16, 16)
        Me.pbRotate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRotate.TabIndex = 21
        Me.pbRotate.TabStop = False
        '
        'pbLoad
        '
        Me.pbLoad.Image = Global.sampleReceive.My.Resources.Resources.progress
        Me.pbLoad.Location = New System.Drawing.Point(12, 57)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(351, 10)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 22
        Me.pbLoad.TabStop = False
        '
        'tmrEnding
        '
        Me.tmrEnding.Interval = 3000
        '
        'frmSMSSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(373, 74)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbRotate)
        Me.Controls.Add(Me.pbLoad)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSMSSender"
        Me.Text = "SMS Technology"
        CType(Me.pbRotate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDetect As System.Windows.Forms.Timer
    Friend WithEvents pbRotate As System.Windows.Forms.PictureBox
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrEnding As System.Windows.Forms.Timer

End Class
