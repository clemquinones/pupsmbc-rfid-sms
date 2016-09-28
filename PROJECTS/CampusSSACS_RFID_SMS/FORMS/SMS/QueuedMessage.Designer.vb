<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueuedMessage
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
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblContent = New System.Windows.Forms.Label
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Modified"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Recipient"
        Me.ColumnHeader2.Width = 120
        '
        'lblContent
        '
        Me.lblContent.BackColor = System.Drawing.Color.White
        Me.lblContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContent.Location = New System.Drawing.Point(10, 402)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(566, 64)
        Me.lblContent.TabIndex = 21
        Me.lblContent.Text = "Message count: "
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 240
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Location = New System.Drawing.Point(9, 472)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 29)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(464, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 29)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Black
        Me.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.Gold
        Me.btnDeleteAll.Location = New System.Drawing.Point(332, 472)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(126, 29)
        Me.btnDeleteAll.TabIndex = 18
        Me.btnDeleteAll.Text = "&Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gold
        Me.btnDelete.Location = New System.Drawing.Point(200, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 29)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(10, 12)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(566, 383)
        Me.LV.TabIndex = 16
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 64)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Queue Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblContent)
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAll)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 515)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'frmQueuedMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 593)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmQueuedMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Queued Message"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
