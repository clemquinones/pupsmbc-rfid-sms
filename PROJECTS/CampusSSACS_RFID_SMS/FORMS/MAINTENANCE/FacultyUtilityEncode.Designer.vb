<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacultyUtilityEncode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTip = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.LV = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbField = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tFN = New System.Windows.Forms.TextBox
        Me.tMN = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkSend = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tLN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tNumber = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bSave = New System.Windows.Forms.Button
        Me.bRemove = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbllD = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.bAdd = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTip)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 347)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblTip
        '
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.DimGray
        Me.lblTip.Location = New System.Drawing.Point(5, 15)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(151, 16)
        Me.lblTip.TabIndex = 205
        Me.lblTip.Text = "Type any part of the find item:"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTip.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.searchicon
        Me.PictureBox1.Location = New System.Drawing.Point(308, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 204
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(157, 13)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 22)
        Me.txtSearch.TabIndex = 203
        Me.txtSearch.Text = "Search"
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(9, 43)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(324, 298)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Field"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 150
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(221, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 30)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbField)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tFN)
        Me.GroupBox2.Controls.Add(Me.tMN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkSend)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tLN)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 246)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'cmbField
        '
        Me.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Items.AddRange(New Object() {"Faculty", "Utility"})
        Me.cmbField.Location = New System.Drawing.Point(121, 155)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(181, 23)
        Me.cmbField.TabIndex = 214
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(16, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 22)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "Field:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tFN
        '
        Me.tFN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFN.ForeColor = System.Drawing.Color.DimGray
        Me.tFN.Location = New System.Drawing.Point(123, 19)
        Me.tFN.MaxLength = 20
        Me.tFN.Name = "tFN"
        Me.tFN.Size = New System.Drawing.Size(179, 21)
        Me.tFN.TabIndex = 204
        Me.tFN.Text = "First"
        '
        'tMN
        '
        Me.tMN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMN.ForeColor = System.Drawing.Color.DimGray
        Me.tMN.Location = New System.Drawing.Point(123, 47)
        Me.tMN.MaxLength = 20
        Me.tMN.Name = "tMN"
        Me.tMN.Size = New System.Drawing.Size(179, 21)
        Me.tMN.TabIndex = 206
        Me.tMN.Text = "Middle"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(18, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Middle Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "First Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSend
        '
        Me.chkSend.AutoSize = True
        Me.chkSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSend.ForeColor = System.Drawing.Color.White
        Me.chkSend.Location = New System.Drawing.Point(200, 130)
        Me.chkSend.Name = "chkSend"
        Me.chkSend.Size = New System.Drawing.Size(102, 19)
        Me.chkSend.TabIndex = 212
        Me.chkSend.Text = "Send Advisory"
        Me.chkSend.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(18, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Number:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tLN
        '
        Me.tLN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLN.ForeColor = System.Drawing.Color.DimGray
        Me.tLN.Location = New System.Drawing.Point(123, 75)
        Me.tLN.MaxLength = 20
        Me.tLN.Name = "tLN"
        Me.tLN.Size = New System.Drawing.Size(179, 21)
        Me.tLN.TabIndex = 208
        Me.tLN.Text = "Last"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(18, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "Last Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tNumber
        '
        Me.tNumber.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNumber.ForeColor = System.Drawing.Color.DimGray
        Me.tNumber.Location = New System.Drawing.Point(123, 103)
        Me.tNumber.MaxLength = 20
        Me.tNumber.Name = "tNumber"
        Me.tNumber.Size = New System.Drawing.Size(179, 21)
        Me.tNumber.TabIndex = 210
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(663, 52)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PUPSMBC Faculty / Utility"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.Black
        Me.bSave.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.ForeColor = System.Drawing.Color.Gold
        Me.bSave.Location = New System.Drawing.Point(93, 12)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(81, 30)
        Me.bSave.TabIndex = 213
        Me.bSave.Text = "&Update"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bRemove
        '
        Me.bRemove.BackColor = System.Drawing.Color.Black
        Me.bRemove.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.bRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRemove.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRemove.ForeColor = System.Drawing.Color.Gold
        Me.bRemove.Location = New System.Drawing.Point(6, 13)
        Me.bRemove.Name = "bRemove"
        Me.bRemove.Size = New System.Drawing.Size(81, 30)
        Me.bRemove.TabIndex = 214
        Me.bRemove.Text = "&Remove"
        Me.bRemove.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bRemove)
        Me.GroupBox4.Controls.Add(Me.bSave)
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Location = New System.Drawing.Point(364, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 48)
        Me.GroupBox4.TabIndex = 215
        Me.GroupBox4.TabStop = False
        '
        'lbllD
        '
        Me.lbllD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllD.ForeColor = System.Drawing.Color.White
        Me.lbllD.Location = New System.Drawing.Point(487, 70)
        Me.lbllD.Name = "lbllD"
        Me.lbllD.Size = New System.Drawing.Size(186, 32)
        Me.lbllD.TabIndex = 213
        Me.lbllD.Text = "- - - - - "
        Me.lbllD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(454, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 22)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "ID:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.Black
        Me.bAdd.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.ForeColor = System.Drawing.Color.Gold
        Me.bAdd.Location = New System.Drawing.Point(364, 70)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(81, 30)
        Me.bAdd.TabIndex = 216
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'frmFacultyUtilityEncode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(685, 415)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbllD)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFacultyUtilityEncode"
        Me.Tag = "Add"
        Me.Text = "Add / Edit Faculty or utility"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tFN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tLN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tMN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tNumber As System.Windows.Forms.TextBox
    Friend WithEvents chkSend As System.Windows.Forms.CheckBox
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbllD As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbField As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bAdd As System.Windows.Forms.Button
End Class
