<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchStudentLog
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
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSelected = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lvResult = New System.Windows.Forms.ListView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(12, 19)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(286, 26)
        Me.txtKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name / Student No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selected item"
        '
        'lblSelected
        '
        Me.lblSelected.BackColor = System.Drawing.Color.Gray
        Me.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelected.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.White
        Me.lblSelected.Location = New System.Drawing.Point(12, 200)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(286, 22)
        Me.lblSelected.TabIndex = 4
        Me.lblSelected.Text = "--Student Number"
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student #"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 180
        '
        'lvResult
        '
        Me.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvResult.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResult.FullRowSelect = True
        Me.lvResult.GridLines = True
        Me.lvResult.Location = New System.Drawing.Point(12, 51)
        Me.lvResult.MultiSelect = False
        Me.lvResult.Name = "lvResult"
        Me.lvResult.Size = New System.Drawing.Size(286, 133)
        Me.lvResult.TabIndex = 3
        Me.lvResult.UseCompatibleStateImageBehavior = False
        Me.lvResult.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter (View details)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Esc (Cancel)"
        '
        'frmSearchStudentLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 260)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lvResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchStudentLog"
        Me.Text = "Search from logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvResult As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
