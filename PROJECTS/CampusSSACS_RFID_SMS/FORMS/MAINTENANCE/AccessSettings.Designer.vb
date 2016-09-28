<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessSettings
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"No Items...", "User Type...", "User Name...", "User name...", "State..."}, -1)
        Me.btnDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnLock = New System.Windows.Forms.Button
        Me.lblTip = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Delete
        Me.btnDelete.Location = New System.Drawing.Point(547, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 39)
        Me.btnDelete.TabIndex = 197
        Me.btnDelete.Text = "&DELETE USER"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnLock)
        Me.GroupBox1.Controls.Add(Me.lblTip)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(527, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 98)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access"
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ForeColor = System.Drawing.Color.Black
        Me.btnLock.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Lock
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.Location = New System.Drawing.Point(35, 51)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(135, 40)
        Me.btnLock.TabIndex = 1
        Me.btnLock.Text = "&LOCK USER"
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTip.ForeColor = System.Drawing.Color.White
        Me.lblTip.Location = New System.Drawing.Point(9, 15)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(181, 31)
        Me.lblTip.TabIndex = 186
        Me.lblTip.Text = "User cannot access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the system."
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 31)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "System Users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.White
        Me.btnDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Disconnect
        Me.btnDisconnect.Location = New System.Drawing.Point(547, 108)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(157, 39)
        Me.btnDisconnect.TabIndex = 199
        Me.btnDisconnect.Text = "D&ISCONNECT"
        Me.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisconnect.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 19)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Check the user to select. The user with checked mark will be affected."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "State"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'LV
        '
        Me.LV.CheckBoxes = True
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        ListViewItem1.StateImageIndex = 0
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LV.Location = New System.Drawing.Point(11, 40)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(510, 150)
        Me.LV.TabIndex = 194
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "User Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Access"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 4000
        '
        'frmAccessSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(735, 230)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAccessSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Access Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
End Class
