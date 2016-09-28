<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacultyUtility
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCount = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSendMessage = New System.Windows.Forms.Button
        Me.btnAddUpdate = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 355)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(6, 336)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(84, 13)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "Record count: 0"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LV.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(7, 17)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(485, 313)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Department"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Number"
        Me.ColumnHeader4.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculties and Utilities"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(12, 416)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 29)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(420, 416)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 29)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSendMessage
        '
        Me.btnSendMessage.BackColor = System.Drawing.Color.Black
        Me.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendMessage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendMessage.ForeColor = System.Drawing.Color.Gold
        Me.btnSendMessage.Location = New System.Drawing.Point(105, 416)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(127, 29)
        Me.btnSendMessage.TabIndex = 14
        Me.btnSendMessage.Text = "&Send Message..."
        Me.btnSendMessage.UseVisualStyleBackColor = False
        '
        'btnAddUpdate
        '
        Me.btnAddUpdate.BackColor = System.Drawing.Color.Black
        Me.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btnAddUpdate.Location = New System.Drawing.Point(257, 416)
        Me.btnAddUpdate.Name = "btnAddUpdate"
        Me.btnAddUpdate.Size = New System.Drawing.Size(116, 29)
        Me.btnAddUpdate.TabIndex = 15
        Me.btnAddUpdate.Text = "Add/Update"
        Me.btnAddUpdate.UseVisualStyleBackColor = False
        '
        'frmFacultyUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 451)
        Me.Controls.Add(Me.btnAddUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmFacultyUtility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculties and Utilities"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddUpdate As System.Windows.Forms.Button
End Class
