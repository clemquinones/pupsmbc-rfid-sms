<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Me.btnDetails = New System.Windows.Forms.Button
        Me.lblResults = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(8, 16)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(357, 275)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student Number"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'btnDetails
        '
        Me.btnDetails.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.ForeColor = System.Drawing.Color.Gold
        Me.btnDetails.Location = New System.Drawing.Point(231, 297)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(129, 23)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "View Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.Transparent
        Me.lblResults.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.ForeColor = System.Drawing.Color.Gold
        Me.lblResults.Location = New System.Drawing.Point(12, 9)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(387, 21)
        Me.lblResults.TabIndex = 2
        Me.lblResults.Text = "0 result for ''"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnDetails)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 328)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(21, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Results"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(412, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
