<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListParents
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
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lblCount = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(8, 15)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(610, 543)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student #"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Number"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SMS Advisory"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(6, 561)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(84, 13)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "Record count: 0"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(535, 642)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 29)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.Gold
        Me.btnSend.Location = New System.Drawing.Point(102, 642)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(127, 29)
        Me.btnSend.TabIndex = 11
        Me.btnSend.Text = "&Send Message..."
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(9, 642)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 29)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 583)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTip)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 45)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 28)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "List of all parents"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(282, 16)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(176, 16)
        Me.lblTip.TabIndex = 202
        Me.lblTip.Text = "Type any part of the find item:"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTip.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.searchicon
        Me.PictureBox2.Location = New System.Drawing.Point(587, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 201
        Me.PictureBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(464, 14)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(117, 21)
        Me.txtSearch.TabIndex = 200
        Me.txtSearch.Text = "Search"
        '
        'frmListParents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(637, 679)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListParents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of All Parents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
