<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewStud
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
        Me.pbImg = New System.Windows.Forms.PictureBox
        Me.lblDetail = New System.Windows.Forms.Label
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImg
        '
        Me.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImg.Location = New System.Drawing.Point(53, 23)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(476, 342)
        Me.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImg.TabIndex = 0
        Me.pbImg.TabStop = False
        '
        'lblDetail
        '
        Me.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(19, 368)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(520, 60)
        Me.lblDetail.TabIndex = 1
        Me.lblDetail.Text = "lblDetail"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPreviewStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 445)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.pbImg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreviewStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PreviewStud"
        Me.TopMost = True
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImg As System.Windows.Forms.PictureBox
    Friend WithEvents lblDetail As System.Windows.Forms.Label
End Class
