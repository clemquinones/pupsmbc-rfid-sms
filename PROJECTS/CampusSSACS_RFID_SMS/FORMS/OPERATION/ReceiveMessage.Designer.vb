<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveMessage
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
        Me.chkCheckAll = New System.Windows.Forms.CheckBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.tmrCount = New System.Windows.Forms.Timer(Me.components)
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnDisplayMessage = New System.Windows.Forms.Button
        Me.rbSIM = New System.Windows.Forms.RadioButton
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.gb = New System.Windows.Forms.GroupBox
        Me.rbLocal = New System.Windows.Forms.RadioButton
        Me.LV = New System.Windows.Forms.ListView
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkCheckAll
        '
        Me.chkCheckAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckAll.Location = New System.Drawing.Point(16, 358)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(129, 21)
        Me.chkCheckAll.TabIndex = 17
        Me.chkCheckAll.Text = "&Check All"
        Me.chkCheckAll.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Gray
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(12, 442)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(525, 17)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Message counts:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(248, 397)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(116, 31)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(424, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 31)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tmrCount
        '
        '
        'btnDelAll
        '
        Me.btnDelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAll.Location = New System.Drawing.Point(126, 397)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(116, 31)
        Me.btnDelAll.TabIndex = 13
        Me.btnDelAll.Text = "&Delete All"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(7, 397)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 31)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnDisplayMessage
        '
        Me.btnDisplayMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayMessage.Location = New System.Drawing.Point(272, 40)
        Me.btnDisplayMessage.Name = "btnDisplayMessage"
        Me.btnDisplayMessage.Size = New System.Drawing.Size(192, 31)
        Me.btnDisplayMessage.TabIndex = 11
        Me.btnDisplayMessage.Text = "&Show Content"
        Me.btnDisplayMessage.UseVisualStyleBackColor = True
        '
        'rbSIM
        '
        Me.rbSIM.AutoSize = True
        Me.rbSIM.Checked = True
        Me.rbSIM.Location = New System.Drawing.Point(16, 31)
        Me.rbSIM.Name = "rbSIM"
        Me.rbSIM.Size = New System.Drawing.Size(102, 18)
        Me.rbSIM.TabIndex = 0
        Me.rbSIM.TabStop = True
        Me.rbSIM.Text = "SIM Storage"
        Me.rbSIM.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sender"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Message"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Modified"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'gb
        '
        Me.gb.Controls.Add(Me.rbLocal)
        Me.gb.Controls.Add(Me.rbSIM)
        Me.gb.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb.Location = New System.Drawing.Point(16, 7)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(250, 64)
        Me.gb.TabIndex = 10
        Me.gb.TabStop = False
        Me.gb.Text = "Choose Message Storage"
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.Location = New System.Drawing.Point(124, 31)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(111, 18)
        Me.rbLocal.TabIndex = 1
        Me.rbLocal.Text = "Local Storage"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.CheckBoxes = True
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(16, 85)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(531, 267)
        Me.LV.TabIndex = 9
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(553, 85)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(169, 267)
        Me.txtContent.TabIndex = 18
        '
        'frmReceiveMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 466)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.chkCheckAll)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDisplayMessage)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReceiveMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Message"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tmrCount As System.Windows.Forms.Timer
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnDisplayMessage As System.Windows.Forms.Button
    Friend WithEvents rbSIM As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
End Class
