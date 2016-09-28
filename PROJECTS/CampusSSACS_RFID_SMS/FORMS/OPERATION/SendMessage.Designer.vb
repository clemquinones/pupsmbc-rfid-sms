<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSend
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "222", "24332"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "433444", "222222"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "", "232323"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "2332", ""}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "", ""}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "", "3434", "4343"}, -1)
        Me.txtDestination = New System.Windows.Forms.TextBox
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvStud = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbSendToAll = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSendTimes = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSendTimes = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.rbSendToSpecific = New System.Windows.Forms.RadioButton
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.lblOutPut = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDestination
        '
        Me.txtDestination.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(125, 148)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(184, 26)
        Me.txtDestination.TabIndex = 22
        Me.txtDestination.Text = "222"
        Me.txtDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student #"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Course/Year/Sec"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(190, 132)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(116, 13)
        Me.lblRemaining.TabIndex = 20
        Me.lblRemaining.Text = "Remaining(1000/1000)"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Number"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Recipients:"
        '
        'lvStud
        '
        Me.lvStud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvStud.FullRowSelect = True
        Me.lvStud.GridLines = True
        Me.lvStud.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lvStud.Location = New System.Drawing.Point(315, 72)
        Me.lvStud.Name = "lvStud"
        Me.lvStud.Size = New System.Drawing.Size(506, 213)
        Me.lvStud.TabIndex = 17
        Me.lvStud.UseCompatibleStateImageBehavior = False
        Me.lvStud.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Parent Number"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Type your message here:"
        '
        'rbSendToAll
        '
        Me.rbSendToAll.AutoSize = True
        Me.rbSendToAll.Checked = True
        Me.rbSendToAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSendToAll.Location = New System.Drawing.Point(6, 54)
        Me.rbSendToAll.Name = "rbSendToAll"
        Me.rbSendToAll.Size = New System.Drawing.Size(101, 20)
        Me.rbSendToAll.TabIndex = 13
        Me.rbSendToAll.TabStop = True
        Me.rbSendToAll.Text = "Send To All"
        Me.rbSendToAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.chkSendTimes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSendTimes)
        Me.GroupBox1.Controls.Add(Me.rbSendToAll)
        Me.GroupBox1.Controls.Add(Me.rbSendToSpecific)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(346, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 112)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send Option"
        '
        'chkSendTimes
        '
        Me.chkSendTimes.AutoSize = True
        Me.chkSendTimes.Location = New System.Drawing.Point(6, 21)
        Me.chkSendTimes.Name = "chkSendTimes"
        Me.chkSendTimes.Size = New System.Drawing.Size(118, 18)
        Me.chkSendTimes.TabIndex = 11
        Me.chkSendTimes.Text = "Send Message"
        Me.chkSendTimes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Time(s)"
        '
        'txtSendTimes
        '
        Me.txtSendTimes.Location = New System.Drawing.Point(130, 19)
        Me.txtSendTimes.MaxLength = 100
        Me.txtSendTimes.Name = "txtSendTimes"
        Me.txtSendTimes.Size = New System.Drawing.Size(59, 22)
        Me.txtSendTimes.TabIndex = 2
        Me.txtSendTimes.Text = "1"
        Me.txtSendTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(756, 360)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(104, 26)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'rbSendToSpecific
        '
        Me.rbSendToSpecific.AutoSize = True
        Me.rbSendToSpecific.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSendToSpecific.Location = New System.Drawing.Point(6, 80)
        Me.rbSendToSpecific.Name = "rbSendToSpecific"
        Me.rbSendToSpecific.Size = New System.Drawing.Size(138, 20)
        Me.rbSendToSpecific.TabIndex = 14
        Me.rbSendToSpecific.Text = "Send To Specific"
        Me.rbSendToSpecific.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.White
        Me.txtMessage.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(12, 31)
        Me.txtMessage.MaxLength = 1000
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(294, 98)
        Me.txtMessage.TabIndex = 12
        Me.txtMessage.Text = "--Message here"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(739, 40)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(82, 26)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblOutPut
        '
        Me.lblOutPut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOutPut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutPut.ForeColor = System.Drawing.Color.White
        Me.lblOutPut.Location = New System.Drawing.Point(18, 319)
        Me.lblOutPut.Name = "lblOutPut"
        Me.lblOutPut.Size = New System.Drawing.Size(285, 90)
        Me.lblOutPut.TabIndex = 24
        Me.lblOutPut.Text = "Details:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(150, 80)
        Me.txtNumber.MaxLength = 100
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(218, 22)
        Me.txtNumber.TabIndex = 15
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(756, 392)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 436)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblOutPut)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvStud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Message"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvStud As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbSendToAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSendTimes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSendTimes As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents rbSendToSpecific As System.Windows.Forms.RadioButton
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblOutPut As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
