<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGSM_Module_Setting
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
        Me.lvPorts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnDone = New System.Windows.Forms.Button
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbTimeOut = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTest = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbAuto = New System.Windows.Forms.RadioButton
        Me.rbManual = New System.Windows.Forms.RadioButton
        Me.cmbCommPort = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbManual = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.gbManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvPorts
        '
        Me.lvPorts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvPorts.FullRowSelect = True
        Me.lvPorts.GridLines = True
        Me.lvPorts.Location = New System.Drawing.Point(16, 289)
        Me.lvPorts.Name = "lvPorts"
        Me.lvPorts.Size = New System.Drawing.Size(385, 97)
        Me.lvPorts.TabIndex = 87
        Me.lvPorts.UseCompatibleStateImageBehavior = False
        Me.lvPorts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Port Name"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Details"
        Me.ColumnHeader2.Width = 300
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(13, 389)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(392, 21)
        Me.lblStatus.TabIndex = 86
        Me.lblStatus.Text = "Status: "
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.White
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(278, 257)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(120, 26)
        Me.btnDone.TabIndex = 84
        Me.btnDone.Text = "&Save"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaudRate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"9600", "19200", "3800", "57600", "115200"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(11, 42)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(132, 26)
        Me.cmbBaudRate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbTimeOut)
        Me.GroupBox1.Controls.Add(Me.cmbBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 82)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Baud Rate:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTimeOut
        '
        Me.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeOut.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeOut.FormattingEnabled = True
        Me.cmbTimeOut.Items.AddRange(New Object() {"150", "300", "600", "900", "1200", "1500", "1800", "2000"})
        Me.cmbTimeOut.Location = New System.Drawing.Point(224, 42)
        Me.cmbTimeOut.Name = "cmbTimeOut"
        Me.cmbTimeOut.Size = New System.Drawing.Size(132, 26)
        Me.cmbTimeOut.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Time Out (ms):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.White
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(16, 257)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(120, 26)
        Me.btnTest.TabIndex = 83
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(2, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 28)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Connection setup for the GSM Module"
        '
        'rbAuto
        '
        Me.rbAuto.AutoSize = True
        Me.rbAuto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAuto.Location = New System.Drawing.Point(16, 42)
        Me.rbAuto.Name = "rbAuto"
        Me.rbAuto.Size = New System.Drawing.Size(156, 20)
        Me.rbAuto.TabIndex = 81
        Me.rbAuto.TabStop = True
        Me.rbAuto.Text = "Auto-detect device"
        Me.rbAuto.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Checked = True
        Me.rbManual.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbManual.Location = New System.Drawing.Point(16, 68)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(202, 20)
        Me.rbManual.TabIndex = 79
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Manual selecting of device"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'cmbCommPort
        '
        Me.cmbCommPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCommPort.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCommPort.FormattingEnabled = True
        Me.cmbCommPort.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbCommPort.Location = New System.Drawing.Point(195, 21)
        Me.cmbCommPort.Name = "cmbCommPort"
        Me.cmbCommPort.Size = New System.Drawing.Size(132, 26)
        Me.cmbCommPort.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Comm-Port:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbManual
        '
        Me.gbManual.Controls.Add(Me.cmbCommPort)
        Me.gbManual.Controls.Add(Me.Label4)
        Me.gbManual.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbManual.Location = New System.Drawing.Point(45, 94)
        Me.gbManual.Name = "gbManual"
        Me.gbManual.Size = New System.Drawing.Size(356, 58)
        Me.gbManual.TabIndex = 80
        Me.gbManual.TabStop = False
        Me.gbManual.Text = "Select the comm port of the module:"
        '
        'frmGSM_Module_Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(410, 422)
        Me.Controls.Add(Me.lvPorts)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbAuto)
        Me.Controls.Add(Me.rbManual)
        Me.Controls.Add(Me.gbManual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmGSM_Module_Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "GSM Device Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbManual.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvPorts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTimeOut As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbAuto As System.Windows.Forms.RadioButton
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCommPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbManual As System.Windows.Forms.GroupBox
End Class
