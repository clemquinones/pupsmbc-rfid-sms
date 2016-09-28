<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmptyDatabase
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnContinue = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 59)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Click 'Continue' button to create administrator."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(5, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PUPSMBC Student Security Monitoring System " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "needs an administrator in order to m" & _
            "aintain the system."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DATABASE IS EMPTY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.warn
        Me.PictureBox2.Location = New System.Drawing.Point(308, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Database
        Me.PictureBox1.Location = New System.Drawing.Point(13, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Black
        Me.btnContinue.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.Gold
        Me.btnContinue.Location = New System.Drawing.Point(136, 218)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(107, 34)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Location = New System.Drawing.Point(249, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 34)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmEmptyDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 264)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmEmptyDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Database is empty"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
