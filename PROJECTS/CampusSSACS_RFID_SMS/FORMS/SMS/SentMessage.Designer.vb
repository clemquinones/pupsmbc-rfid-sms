<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSentMessage
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
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDrop = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.Black
        Me.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.ForeColor = System.Drawing.Color.Gold
        Me.btnClearAll.Location = New System.Drawing.Point(10, 546)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(126, 28)
        Me.btnClearAll.TabIndex = 22
        Me.btnClearAll.Text = "&Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(544, 546)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 28)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDrop
        '
        Me.btnDrop.BackColor = System.Drawing.Color.Black
        Me.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrop.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrop.ForeColor = System.Drawing.Color.Gold
        Me.btnDrop.Location = New System.Drawing.Point(142, 546)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(112, 28)
        Me.btnDrop.TabIndex = 20
        Me.btnDrop.Text = "&Drop"
        Me.btnDrop.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Gold
        Me.btnEdit.Location = New System.Drawing.Point(412, 546)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 28)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(10, 13)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(637, 441)
        Me.LV.TabIndex = 23
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
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date/Time"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        Me.ColumnHeader5.Width = 80
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Gold
        Me.btnRefresh.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.refresh
        Me.btnRefresh.Location = New System.Drawing.Point(375, 546)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(31, 28)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 56)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sent Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtContent)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnClearAll)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDrop)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(653, 589)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(10, 460)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(637, 75)
        Me.txtContent.TabIndex = 28
        Me.txtContent.Text = "Message count:  0"
        '
        'frmSentMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(670, 657)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSentMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sent Message"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDrop As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
