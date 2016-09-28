<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetectPorts
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
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDetect = New System.Windows.Forms.Button
        Me.pbLoading = New System.Windows.Forms.PictureBox
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(9, 42)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(405, 130)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Port"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 300
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(316, 178)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of Available Communication Ports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDetect
        '
        Me.btnDetect.BackColor = System.Drawing.Color.Black
        Me.btnDetect.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnDetect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetect.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetect.ForeColor = System.Drawing.Color.Gold
        Me.btnDetect.Location = New System.Drawing.Point(166, 178)
        Me.btnDetect.Name = "btnDetect"
        Me.btnDetect.Size = New System.Drawing.Size(144, 30)
        Me.btnDetect.TabIndex = 3
        Me.btnDetect.Text = "Start Detecting"
        Me.btnDetect.UseVisualStyleBackColor = False
        '
        'pbLoading
        '
        Me.pbLoading.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoading.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Apple_Load
        Me.pbLoading.Location = New System.Drawing.Point(136, 185)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(24, 19)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 4
        Me.pbLoading.TabStop = False
        Me.pbLoading.Visible = False
        '
        'frmDetectPorts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 216)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.btnDetect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetectPorts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto-Detect device from the port list."
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDetect As System.Windows.Forms.Button
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
End Class
