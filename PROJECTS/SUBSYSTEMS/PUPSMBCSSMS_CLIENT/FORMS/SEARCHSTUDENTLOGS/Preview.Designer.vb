<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"No items...", "No items..."}, -1)
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblCourseYrSec = New System.Windows.Forms.Label
        Me.lblRecCounts = New System.Windows.Forms.Label
        Me.cmbLogState = New System.Windows.Forms.ComboBox
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.llblClose = New System.Windows.Forms.LinkLabel
        Me.pbPic = New System.Windows.Forms.PictureBox
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LV.Location = New System.Drawing.Point(387, 71)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(265, 412)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Logs State"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date/Time"
        Me.ColumnHeader2.Width = 170
        '
        'lblStudNo
        '
        Me.lblStudNo.BackColor = System.Drawing.Color.Black
        Me.lblStudNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.White
        Me.lblStudNo.Location = New System.Drawing.Point(69, 346)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(237, 24)
        Me.lblStudNo.TabIndex = 2
        Me.lblStudNo.Text = "Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(69, 375)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(237, 24)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseYrSec
        '
        Me.lblCourseYrSec.BackColor = System.Drawing.Color.Black
        Me.lblCourseYrSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseYrSec.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseYrSec.ForeColor = System.Drawing.Color.White
        Me.lblCourseYrSec.Location = New System.Drawing.Point(69, 405)
        Me.lblCourseYrSec.Name = "lblCourseYrSec"
        Me.lblCourseYrSec.Size = New System.Drawing.Size(237, 24)
        Me.lblCourseYrSec.TabIndex = 2
        Me.lblCourseYrSec.Text = "Course / Yr / Sec"
        Me.lblCourseYrSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecCounts
        '
        Me.lblRecCounts.AutoSize = True
        Me.lblRecCounts.BackColor = System.Drawing.Color.Black
        Me.lblRecCounts.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecCounts.ForeColor = System.Drawing.Color.White
        Me.lblRecCounts.Location = New System.Drawing.Point(386, 487)
        Me.lblRecCounts.Name = "lblRecCounts"
        Me.lblRecCounts.Size = New System.Drawing.Size(93, 13)
        Me.lblRecCounts.TabIndex = 2
        Me.lblRecCounts.Text = "Record counts:"
        '
        'cmbLogState
        '
        Me.cmbLogState.BackColor = System.Drawing.Color.Black
        Me.cmbLogState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLogState.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLogState.ForeColor = System.Drawing.Color.White
        Me.cmbLogState.FormattingEnabled = True
        Me.cmbLogState.Items.AddRange(New Object() {"All Read", "Log in", "Log out"})
        Me.cmbLogState.Location = New System.Drawing.Point(387, 29)
        Me.cmbLogState.Name = "cmbLogState"
        Me.cmbLogState.Size = New System.Drawing.Size(265, 21)
        Me.cmbLogState.TabIndex = 4
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 5000
        '
        'llblClose
        '
        Me.llblClose.AutoSize = True
        Me.llblClose.BackColor = System.Drawing.Color.Black
        Me.llblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llblClose.Location = New System.Drawing.Point(619, 487)
        Me.llblClose.Name = "llblClose"
        Me.llblClose.Size = New System.Drawing.Size(33, 13)
        Me.llblClose.TabIndex = 6
        Me.llblClose.TabStop = True
        Me.llblClose.Text = "Close"
        '
        'pbPic
        '
        Me.pbPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPic.Image = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.No_Picture
        Me.pbPic.Location = New System.Drawing.Point(45, 39)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(283, 286)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 1
        Me.pbPic.TabStop = False
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.picasa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 521)
        Me.Controls.Add(Me.llblClose)
        Me.Controls.Add(Me.cmbLogState)
        Me.Controls.Add(Me.lblCourseYrSec)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStudNo)
        Me.Controls.Add(Me.lblRecCounts)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picasa"
        Me.TopMost = True
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents pbPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCourseYrSec As System.Windows.Forms.Label
    Friend WithEvents lblRecCounts As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbLogState As System.Windows.Forms.ComboBox
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents llblClose As System.Windows.Forms.LinkLabel
End Class
