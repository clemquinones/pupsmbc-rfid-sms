<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLessOpacity
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
        Me.lblClose = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(820, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(40, 39)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "X"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.White
        Me.lblTip.Location = New System.Drawing.Point(761, 20)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(53, 19)
        Me.lblTip.TabIndex = 2
        Me.lblTip.Text = "Close"
        Me.lblTip.Visible = False
        '
        'frmLessOpacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(872, 631)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLessOpacity"
        Me.Opacity = 0.5
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LessOpacity"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
End Class
