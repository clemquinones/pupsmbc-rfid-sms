<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMB
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
        Me.lblMessage = New System.Windows.Forms.Label
        Me.gbButtons = New System.Windows.Forms.GroupBox
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.pbIcon = New System.Windows.Forms.PictureBox
        Me.lblWhiteBG = New System.Windows.Forms.Label
        Me.gbButtons.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(59, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(252, 91)
        Me.lblMessage.TabIndex = 16
        Me.lblMessage.Text = "--Message--"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbButtons
        '
        Me.gbButtons.BackColor = System.Drawing.Color.Transparent
        Me.gbButtons.Controls.Add(Me.btn1)
        Me.gbButtons.Controls.Add(Me.btn2)
        Me.gbButtons.Controls.Add(Me.btn3)
        Me.gbButtons.Location = New System.Drawing.Point(11, 110)
        Me.gbButtons.Name = "gbButtons"
        Me.gbButtons.Size = New System.Drawing.Size(301, 41)
        Me.gbButtons.TabIndex = 15
        Me.gbButtons.TabStop = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.White
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(38, 13)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(82, 24)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "&OK"
        Me.btn1.UseVisualStyleBackColor = False
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.White
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(126, 13)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(82, 24)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "&OK"
        Me.btn2.UseVisualStyleBackColor = False
        Me.btn2.Visible = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.White
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(210, 13)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(82, 24)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "&OK"
        Me.btn3.UseVisualStyleBackColor = False
        Me.btn3.Visible = False
        '
        'pbIcon
        '
        Me.pbIcon.BackColor = System.Drawing.Color.White
        Me.pbIcon.Image = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.Information
        Me.pbIcon.Location = New System.Drawing.Point(12, 36)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(43, 40)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIcon.TabIndex = 13
        Me.pbIcon.TabStop = False
        '
        'lblWhiteBG
        '
        Me.lblWhiteBG.BackColor = System.Drawing.Color.White
        Me.lblWhiteBG.Location = New System.Drawing.Point(6, 5)
        Me.lblWhiteBG.Name = "lblWhiteBG"
        Me.lblWhiteBG.Size = New System.Drawing.Size(312, 99)
        Me.lblWhiteBG.TabIndex = 14
        '
        'frmMB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PUPSSMSRFIDSMS_Gate.My.Resources.Resources.SEARCH
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(326, 159)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.gbButtons)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.lblWhiteBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.gbButtons.ResumeLayout(False)
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents gbButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblWhiteBG As System.Windows.Forms.Label
End Class
