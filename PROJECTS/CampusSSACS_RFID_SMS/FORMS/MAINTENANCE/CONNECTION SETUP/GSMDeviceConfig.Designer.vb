<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGSMDeviceConfig
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSendDelay = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbStopBits = New System.Windows.Forms.ComboBox
        Me.cmbValidity = New System.Windows.Forms.ComboBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.cmbTimeOut = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbPorts = New System.Windows.Forms.ComboBox
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSendDelay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbStopBits)
        Me.GroupBox1.Controls.Add(Me.cmbValidity)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(211, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 136)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Send Delay (ms):"
        '
        'txtSendDelay
        '
        Me.txtSendDelay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendDelay.Location = New System.Drawing.Point(115, 20)
        Me.txtSendDelay.Name = "txtSendDelay"
        Me.txtSendDelay.Size = New System.Drawing.Size(72, 22)
        Me.txtSendDelay.TabIndex = 2
        Me.txtSendDelay.Text = "1000"
        Me.txtSendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Validity of message:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stop Bits:"
        '
        'cmbStopBits
        '
        Me.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStopBits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStopBits.FormattingEnabled = True
        Me.cmbStopBits.Items.AddRange(New Object() {"None", "1", "1.5", "2"})
        Me.cmbStopBits.Location = New System.Drawing.Point(115, 48)
        Me.cmbStopBits.Name = "cmbStopBits"
        Me.cmbStopBits.Size = New System.Drawing.Size(72, 22)
        Me.cmbStopBits.TabIndex = 3
        '
        'cmbValidity
        '
        Me.cmbValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValidity.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValidity.FormattingEnabled = True
        Me.cmbValidity.Items.AddRange(New Object() {"1 Hour", "3 Hours", "6 Hours", "12 Hours", "1 Day", "1 Week", "Maximum"})
        Me.cmbValidity.Location = New System.Drawing.Point(26, 99)
        Me.cmbValidity.Name = "cmbValidity"
        Me.cmbValidity.Size = New System.Drawing.Size(161, 22)
        Me.cmbValidity.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(95, 101)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(92, 28)
        Me.btnTest.TabIndex = 63
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'cmbTimeOut
        '
        Me.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeOut.FormattingEnabled = True
        Me.cmbTimeOut.Items.AddRange(New Object() {"150", "300", "600", "900", "1200", "1500", "1800", "2000"})
        Me.cmbTimeOut.Location = New System.Drawing.Point(95, 73)
        Me.cmbTimeOut.Name = "cmbTimeOut"
        Me.cmbTimeOut.Size = New System.Drawing.Size(92, 22)
        Me.cmbTimeOut.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Baud Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Select Port:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnTest)
        Me.GroupBox5.Controls.Add(Me.cmbTimeOut)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.cmbPorts)
        Me.GroupBox5.Controls.Add(Me.cmbBaudRate)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(193, 138)
        Me.GroupBox5.TabIndex = 65
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GSM Module Settings"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Time out:"
        '
        'cmbPorts
        '
        Me.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPorts.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPorts.FormattingEnabled = True
        Me.cmbPorts.Location = New System.Drawing.Point(95, 17)
        Me.cmbPorts.Name = "cmbPorts"
        Me.cmbPorts.Size = New System.Drawing.Size(92, 22)
        Me.cmbPorts.TabIndex = 3
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaudRate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"9600", "19200", "3800", "57600", "115200"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(95, 45)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(92, 22)
        Me.cmbBaudRate.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(295, 153)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 28)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Gray
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(12, 153)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(277, 28)
        Me.lblStatus.TabIndex = 63
        Me.lblStatus.Text = "Status"
        '
        'frmGSMDeviceConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGSMDeviceConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GSMDeviceConfig"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSendDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValidity As System.Windows.Forms.ComboBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents cmbTimeOut As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbPorts As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
