<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemLogs
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
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTip = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 10)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(690, 492)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Action"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date / Time"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User ID"
        Me.ColumnHeader5.Width = 115
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.searchicon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(675, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTip
        '
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(376, 13)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(151, 23)
        Me.lblTip.TabIndex = 5
        Me.lblTip.Text = "Type 'User-Type' or 'Action'"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTip.Visible = False
        '
        'lblCount
        '
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(313, 567)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(108, 23)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "Record count: 0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(7, 564)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 29)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.lblTip)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 45)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 28)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "System Users Logs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(533, 15)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 21)
        Me.txtSearch.TabIndex = 200
        Me.txtSearch.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 508)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Gold
        Me.btnClear.Location = New System.Drawing.Point(100, 564)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 29)
        Me.btnClear.TabIndex = 202
        Me.btnClear.Text = "&Clear History"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(608, 564)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 29)
        Me.btnClose.TabIndex = 203
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Location = New System.Drawing.Point(507, 564)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 29)
        Me.btnRefresh.TabIndex = 204
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmSystemLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 596)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSystemLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Monitoring Logs"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
