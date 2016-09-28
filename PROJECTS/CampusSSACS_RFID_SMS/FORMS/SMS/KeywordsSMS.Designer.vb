<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeywordsSMS
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
        Me.txtKeyword = New System.Windows.Forms.TextBox
        Me.btnSet = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCount = New System.Windows.Forms.Label
        Me.gbKeyword = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gbKeyword.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 19)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(305, 220)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Command"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Keyword"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'txtKeyword
        '
        Me.txtKeyword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.ForeColor = System.Drawing.Color.Gray
        Me.txtKeyword.Location = New System.Drawing.Point(9, 19)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(171, 22)
        Me.txtKeyword.TabIndex = 1
        Me.txtKeyword.Text = "Keyword"
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.Black
        Me.btnSet.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.Gold
        Me.btnSet.Location = New System.Drawing.Point(186, 15)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(126, 29)
        Me.btnSet.TabIndex = 13
        Me.btnSet.Text = "&Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 34)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SMS Command"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 261)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'lblCount
        '
        Me.lblCount.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCount.Location = New System.Drawing.Point(3, 242)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(181, 16)
        Me.lblCount.TabIndex = 19
        Me.lblCount.Text = "Record count: 0"
        '
        'gbKeyword
        '
        Me.gbKeyword.Controls.Add(Me.txtKeyword)
        Me.gbKeyword.Controls.Add(Me.btnSet)
        Me.gbKeyword.Location = New System.Drawing.Point(12, 313)
        Me.gbKeyword.Name = "gbKeyword"
        Me.gbKeyword.Size = New System.Drawing.Size(318, 55)
        Me.gbKeyword.TabIndex = 17
        Me.gbKeyword.TabStop = False
        Me.gbKeyword.Text = "Keyword"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(9, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 41)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "To use the sms command, Send <Keyword><Space><Password> then send to server numbe" & _
            "r." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: Keywords are not case-sensitive."
        '
        'frmKeywordsSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(341, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbKeyword)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmKeywordsSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator: Keywords Command"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbKeyword.ResumeLayout(False)
        Me.gbKeyword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbKeyword As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class
