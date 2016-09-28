<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLessOpacityBG
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
        Me.pbClose = New System.Windows.Forms.PictureBox
        Me.lblClose = New System.Windows.Forms.Label
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbClose
        '
        Me.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbClose.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Delete
        Me.pbClose.Location = New System.Drawing.Point(655, 12)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(64, 46)
        Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbClose.TabIndex = 0
        Me.pbClose.TabStop = False
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(609, 30)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(40, 15)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "CLOSE"
        '
        'frmLessOpacityBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 543)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.pbClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmLessOpacityBG"
        Me.Opacity = 0.5
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LessOpacityBG"
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblClose As System.Windows.Forms.Label
End Class
