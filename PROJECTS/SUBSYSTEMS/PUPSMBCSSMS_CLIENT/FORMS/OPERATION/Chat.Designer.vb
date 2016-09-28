<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Me.cmbUser = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtConfe = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.llblClear = New System.Windows.Forms.LinkLabel
        Me.llblRestore = New System.Windows.Forms.LinkLabel
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbUser
        '
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(45, 30)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(142, 25)
        Me.cmbUser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To:"
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(17, 336)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(390, 59)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "Type your message here..."
        '
        'txtConfe
        '
        Me.txtConfe.AllowDrop = True
        Me.txtConfe.BackColor = System.Drawing.Color.White
        Me.txtConfe.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfe.Location = New System.Drawing.Point(17, 61)
        Me.txtConfe.Multiline = True
        Me.txtConfe.Name = "txtConfe"
        Me.txtConfe.ReadOnly = True
        Me.txtConfe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConfe.Size = New System.Drawing.Size(390, 269)
        Me.txtConfe.TabIndex = 4
        Me.txtConfe.Text = "No messages..."
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(309, 402)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 37)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 500
        '
        'llblClear
        '
        Me.llblClear.AutoSize = True
        Me.llblClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblClear.Location = New System.Drawing.Point(254, 45)
        Me.llblClear.Name = "llblClear"
        Me.llblClear.Size = New System.Drawing.Size(66, 13)
        Me.llblClear.TabIndex = 7
        Me.llblClear.TabStop = True
        Me.llblClear.Text = "Clear History"
        '
        'llblRestore
        '
        Me.llblRestore.AutoSize = True
        Me.llblRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRestore.Location = New System.Drawing.Point(326, 45)
        Me.llblRestore.Name = "llblRestore"
        Me.llblRestore.Size = New System.Drawing.Size(79, 13)
        Me.llblRestore.TabIndex = 8
        Me.llblRestore.TabStop = True
        Me.llblRestore.Text = "Restore History"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Black
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Gold
        Me.btnSubmit.Location = New System.Drawing.Point(17, 402)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 37)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 451)
        Me.Controls.Add(Me.llblRestore)
        Me.Controls.Add(Me.llblClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtConfe)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmChat"
        Me.Text = "Chat User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtConfe As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents llblClear As System.Windows.Forms.LinkLabel
    Friend WithEvents llblRestore As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
