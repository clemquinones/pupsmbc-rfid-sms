<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveMessage
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
        Me.lblContent = New System.Windows.Forms.Label
        Me.btnForward = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblContent
        '
        Me.lblContent.BackColor = System.Drawing.Color.White
        Me.lblContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContent.Location = New System.Drawing.Point(10, 426)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(566, 64)
        Me.lblContent.TabIndex = 15
        Me.lblContent.Text = "Message count: "
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.Black
        Me.btnForward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForward.ForeColor = System.Drawing.Color.Gold
        Me.btnForward.Location = New System.Drawing.Point(9, 496)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(126, 29)
        Me.btnForward.TabIndex = 14
        Me.btnForward.Text = "&Forward"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(464, 496)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 29)
        Me.btnClose.TabIndex = 13
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
        Me.btnDeleteAll.Location = New System.Drawing.Point(332, 496)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(126, 29)
        Me.btnDeleteAll.TabIndex = 12
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
        Me.btnDelete.Location = New System.Drawing.Point(200, 496)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 29)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(10, 16)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(566, 401)
        Me.LV.TabIndex = 10
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
        Me.ColumnHeader2.Text = "Recipient"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 220
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Modified"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Copy"
        Me.ColumnHeader5.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContent)
        Me.GroupBox1.Controls.Add(Me.btnForward)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnDeleteAll)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 535)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 58)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Save Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSaveMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 605)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSaveMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saved Message"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
