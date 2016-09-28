<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserPass
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblMsg = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 37)
        Me.Label1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.Gold
        Me.btnOK.Location = New System.Drawing.Point(147, 111)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(228, 111)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(32, 66)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(261, 23)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.ForeColor = System.Drawing.Color.Gold
        Me.lblMsg.Location = New System.Drawing.Point(8, 13)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(106, 13)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "Enter user password:"
        '
        'frmUserPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 146)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = " to stop monitorin:"
        Me.Text = "System Security"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
