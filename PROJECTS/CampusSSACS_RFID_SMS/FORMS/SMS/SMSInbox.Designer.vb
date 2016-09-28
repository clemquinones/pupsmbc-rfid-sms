<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInbox
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
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cmsReceivedSMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmForward = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmDelAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem
        Me.btnForward = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmsReceivedSMS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.ContextMenuStrip = Me.cmsReceivedSMS
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(8, 15)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(618, 312)
        Me.LV.TabIndex = 1
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
        Me.ColumnHeader2.Text = "Sender"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DateTime"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        '
        'cmsReceivedSMS
        '
        Me.cmsReceivedSMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEdit, Me.ToolStripSeparator3, Me.tsmForward, Me.ToolStripSeparator2, Me.tsmDelete, Me.ToolStripSeparator1, Me.tsmDelAll, Me.ToolStripSeparator4, Me.tsmClose})
        Me.cmsReceivedSMS.Name = "cmsReceivedSMS"
        Me.cmsReceivedSMS.Size = New System.Drawing.Size(142, 138)
        '
        'tsmEdit
        '
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(141, 22)
        Me.tsmEdit.Text = "Edit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(138, 6)
        '
        'tsmForward
        '
        Me.tsmForward.Name = "tsmForward"
        Me.tsmForward.Size = New System.Drawing.Size(141, 22)
        Me.tsmForward.Text = "Forward"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(138, 6)
        '
        'tsmDelete
        '
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(141, 22)
        Me.tsmDelete.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'tsmDelAll
        '
        Me.tsmDelAll.Name = "tsmDelAll"
        Me.tsmDelAll.Size = New System.Drawing.Size(141, 22)
        Me.tsmDelAll.Text = "Delete All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(138, 6)
        '
        'tsmClose
        '
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(141, 22)
        Me.tsmClose.Text = "Close Window"
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.Black
        Me.btnForward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForward.ForeColor = System.Drawing.Color.Gold
        Me.btnForward.Location = New System.Drawing.Point(8, 454)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(126, 29)
        Me.btnForward.TabIndex = 8
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
        Me.btnClose.Location = New System.Drawing.Point(510, 454)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 29)
        Me.btnClose.TabIndex = 7
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
        Me.btnDeleteAll.Location = New System.Drawing.Point(331, 454)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(126, 29)
        Me.btnDeleteAll.TabIndex = 6
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
        Me.btnDelete.Location = New System.Drawing.Point(199, 454)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 29)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(7, 333)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(619, 115)
        Me.txtContent.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 50)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Received Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtContent)
        Me.GroupBox2.Controls.Add(Me.btnForward)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAll)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 498)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'frmInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Received Messages"
        Me.cmsReceivedSMS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmsReceivedSMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmForward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmDelAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmClose As System.Windows.Forms.ToolStripMenuItem
End Class
