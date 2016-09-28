<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSend
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
        Me.pbRotate = New System.Windows.Forms.PictureBox
        Me.pbLoad = New System.Windows.Forms.PictureBox
        Me.tmrEnd = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label
        Me.tmrSend = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIdle = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOpen = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRotate
        '
        Me.pbRotate.Image = Global.SMS_Sender.My.Resources.Resources.appleloadinga
        Me.pbRotate.Location = New System.Drawing.Point(12, 13)
        Me.pbRotate.Name = "pbRotate"
        Me.pbRotate.Size = New System.Drawing.Size(16, 16)
        Me.pbRotate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRotate.TabIndex = 18
        Me.pbRotate.TabStop = False
        '
        'pbLoad
        '
        Me.pbLoad.Image = Global.SMS_Sender.My.Resources.Resources.progress
        Me.pbLoad.Location = New System.Drawing.Point(12, 58)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(351, 10)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 19
        Me.pbLoad.TabStop = False
        '
        'tmrEnd
        '
        Me.tmrEnd.Interval = 2500
        Me.tmrEnd.Tag = "False"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gold
        Me.lblStatus.Location = New System.Drawing.Point(34, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(185, 15)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Initializing messages sequence..."
        '
        'tmrSend
        '
        Me.tmrSend.Interval = 3000
        '
        'tmrIdle
        '
        Me.tmrIdle.Interval = 3000
        '
        'tmrOpen
        '
        Me.tmrOpen.Interval = 3000
        '
        'frmSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(375, 75)
        Me.Controls.Add(Me.pbRotate)
        Me.Controls.Add(Me.pbLoad)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "Sending"
        Me.Text = "Sending messages..."
        Me.TopMost = True
        CType(Me.pbRotate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbRotate As System.Windows.Forms.PictureBox
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnd As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrSend As System.Windows.Forms.Timer
    Friend WithEvents tmrIdle As System.Windows.Forms.Timer
    Friend WithEvents tmrOpen As System.Windows.Forms.Timer

End Class
