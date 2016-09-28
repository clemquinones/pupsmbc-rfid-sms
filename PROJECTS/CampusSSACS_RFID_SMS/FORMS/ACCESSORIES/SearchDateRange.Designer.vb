<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDateRange
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.btnFilter = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(22, 49)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(249, 23)
        Me.dtpStart.TabIndex = 0
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(22, 103)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(249, 23)
        Me.dtpEnd.TabIndex = 1
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.White
        Me.btnFilter.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(183, 141)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(98, 31)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Date:"
        '
        'frmSearchDateRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.SearchDateRange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(292, 182)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchDateRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchDateRange"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
