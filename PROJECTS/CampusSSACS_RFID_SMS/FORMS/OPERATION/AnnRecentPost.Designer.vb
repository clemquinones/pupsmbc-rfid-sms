<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecentPost
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
        Me.btnRepost = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.llblClear = New System.Windows.Forms.LinkLabel
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.Black
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.LV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.ForeColor = System.Drawing.Color.White
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(12, 68)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(348, 191)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date/Time"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Message"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 241
        '
        'btnRepost
        '
        Me.btnRepost.BackColor = System.Drawing.Color.Black
        Me.btnRepost.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnRepost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRepost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepost.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepost.ForeColor = System.Drawing.Color.Gold
        Me.btnRepost.Location = New System.Drawing.Point(265, 383)
        Me.btnRepost.Name = "btnRepost"
        Me.btnRepost.Size = New System.Drawing.Size(95, 31)
        Me.btnRepost.TabIndex = 2
        Me.btnRepost.Text = "Re-post"
        Me.btnRepost.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Black
        Me.btnRemove.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Gold
        Me.btnRemove.Location = New System.Drawing.Point(12, 383)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(95, 31)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'llblClear
        '
        Me.llblClear.AutoSize = True
        Me.llblClear.BackColor = System.Drawing.Color.Transparent
        Me.llblClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblClear.LinkColor = System.Drawing.Color.White
        Me.llblClear.Location = New System.Drawing.Point(168, 40)
        Me.llblClear.Name = "llblClear"
        Me.llblClear.Size = New System.Drawing.Size(192, 14)
        Me.llblClear.TabIndex = 5
        Me.llblClear.TabStop = True
        Me.llblClear.Text = "Clear announcement history"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.Black
        Me.txtContent.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.ForeColor = System.Drawing.Color.White
        Me.txtContent.Location = New System.Drawing.Point(12, 265)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(348, 98)
        Me.txtContent.TabIndex = 6
        Me.txtContent.Text = "List of posted announcements"
        '
        'frmRecentPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.StudLogRecord1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(372, 435)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.llblClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnRepost)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecentPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecentPost"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRepost As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents llblClear As System.Windows.Forms.LinkLabel
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
End Class
