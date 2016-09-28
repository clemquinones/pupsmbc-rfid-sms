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
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrWait
        '
        Me.tmrWait.Enabled = True
        Me.tmrWait.Interval = 50
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Silver
        Me.lblCount.Location = New System.Drawing.Point(258, 180)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(23, 13)
        Me.lblCount.TabIndex = 151
        Me.lblCount.Text = "0%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(55, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Initializing program sequence..."
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.appleload
        Me.pbLoading.Location = New System.Drawing.Point(33, 181)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(16, 14)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 149
        Me.pbLoading.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(369, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(46, 19)
        Me.btnCancel.TabIndex = 148
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(401, 58)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "STUDENT MONITORING SYSTEM USING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RADIO FREQUENCY IDENTIFICATION (RFID)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WITH SMS " & _
            "ADVISORY TECHNOLOGY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 33)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SANTA MARIA CAMPUS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Splash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 207)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.btnCancel)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrWait As System.Windows.Forms.Timer
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
