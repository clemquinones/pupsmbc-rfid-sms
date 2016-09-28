<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
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
        Me.tcNoti = New System.Windows.Forms.TabControl
        Me.tpSMS = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSave = New System.Windows.Forms.Label
        Me.lblQueued = New System.Windows.Forms.Label
        Me.lblUnSubscribe = New System.Windows.Forms.Label
        Me.lblSent = New System.Windows.Forms.Label
        Me.lblInbox = New System.Windows.Forms.Label
        Me.tpRFID = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblTLogOut = New System.Windows.Forms.Label
        Me.lblTLogn = New System.Windows.Forms.Label
        Me.lblTTotal = New System.Windows.Forms.Label
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.tcNoti.SuspendLayout()
        Me.tpSMS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpRFID.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcNoti
        '
        Me.tcNoti.Controls.Add(Me.tpSMS)
        Me.tcNoti.Controls.Add(Me.tpRFID)
        Me.tcNoti.Location = New System.Drawing.Point(9, 10)
        Me.tcNoti.Name = "tcNoti"
        Me.tcNoti.SelectedIndex = 0
        Me.tcNoti.Size = New System.Drawing.Size(280, 210)
        Me.tcNoti.TabIndex = 0
        '
        'tpSMS
        '
        Me.tpSMS.Controls.Add(Me.GroupBox1)
        Me.tpSMS.Location = New System.Drawing.Point(4, 22)
        Me.tpSMS.Name = "tpSMS"
        Me.tpSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSMS.Size = New System.Drawing.Size(272, 184)
        Me.tpSMS.TabIndex = 0
        Me.tpSMS.Text = "SMS Messages"
        Me.tpSMS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.lblSave)
        Me.GroupBox1.Controls.Add(Me.lblQueued)
        Me.GroupBox1.Controls.Add(Me.lblUnSubscribe)
        Me.GroupBox1.Controls.Add(Me.lblSent)
        Me.GroupBox1.Controls.Add(Me.lblInbox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblSave
        '
        Me.lblSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.Gold
        Me.lblSave.Location = New System.Drawing.Point(6, 137)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(246, 26)
        Me.lblSave.TabIndex = 4
        Me.lblSave.Text = "Saved Message: 0"
        Me.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQueued
        '
        Me.lblQueued.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQueued.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueued.ForeColor = System.Drawing.Color.Gold
        Me.lblQueued.Location = New System.Drawing.Point(6, 107)
        Me.lblQueued.Name = "lblQueued"
        Me.lblQueued.Size = New System.Drawing.Size(246, 26)
        Me.lblQueued.TabIndex = 3
        Me.lblQueued.Text = "Queued Message: 0"
        Me.lblQueued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnSubscribe
        '
        Me.lblUnSubscribe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnSubscribe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnSubscribe.ForeColor = System.Drawing.Color.Gold
        Me.lblUnSubscribe.Location = New System.Drawing.Point(6, 77)
        Me.lblUnSubscribe.Name = "lblUnSubscribe"
        Me.lblUnSubscribe.Size = New System.Drawing.Size(246, 26)
        Me.lblUnSubscribe.TabIndex = 2
        Me.lblUnSubscribe.Text = "Parents Unsubscribed: 0"
        Me.lblUnSubscribe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSent
        '
        Me.lblSent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSent.ForeColor = System.Drawing.Color.Gold
        Me.lblSent.Location = New System.Drawing.Point(6, 47)
        Me.lblSent.Name = "lblSent"
        Me.lblSent.Size = New System.Drawing.Size(246, 26)
        Me.lblSent.TabIndex = 1
        Me.lblSent.Text = "Sent Message: 0"
        Me.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInbox
        '
        Me.lblInbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInbox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInbox.ForeColor = System.Drawing.Color.Gold
        Me.lblInbox.Location = New System.Drawing.Point(6, 18)
        Me.lblInbox.Name = "lblInbox"
        Me.lblInbox.Size = New System.Drawing.Size(246, 26)
        Me.lblInbox.TabIndex = 0
        Me.lblInbox.Text = "Inbox Message: 0"
        Me.lblInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpRFID
        '
        Me.tpRFID.Controls.Add(Me.GroupBox2)
        Me.tpRFID.Location = New System.Drawing.Point(4, 22)
        Me.tpRFID.Name = "tpRFID"
        Me.tpRFID.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRFID.Size = New System.Drawing.Size(272, 184)
        Me.tpRFID.TabIndex = 1
        Me.tpRFID.Text = "RFID Detections"
        Me.tpRFID.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTLogOut)
        Me.GroupBox2.Controls.Add(Me.lblTLogn)
        Me.GroupBox2.Controls.Add(Me.lblTTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal.Location = New System.Drawing.Point(6, 141)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(246, 26)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total Detections: 0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTLogOut
        '
        Me.lblTLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTLogOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTLogOut.ForeColor = System.Drawing.Color.Gold
        Me.lblTLogOut.Location = New System.Drawing.Point(6, 77)
        Me.lblTLogOut.Name = "lblTLogOut"
        Me.lblTLogOut.Size = New System.Drawing.Size(246, 26)
        Me.lblTLogOut.TabIndex = 2
        Me.lblTLogOut.Text = "Todays Total Log Out: 0"
        Me.lblTLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTLogn
        '
        Me.lblTLogn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTLogn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTLogn.ForeColor = System.Drawing.Color.Gold
        Me.lblTLogn.Location = New System.Drawing.Point(6, 47)
        Me.lblTLogn.Name = "lblTLogn"
        Me.lblTLogn.Size = New System.Drawing.Size(246, 26)
        Me.lblTLogn.TabIndex = 1
        Me.lblTLogn.Text = "Todays Total Log in: 0"
        Me.lblTLogn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTTotal
        '
        Me.lblTTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTTotal.Location = New System.Drawing.Point(6, 18)
        Me.lblTTotal.Name = "lblTTotal"
        Me.lblTTotal.Size = New System.Drawing.Size(246, 26)
        Me.lblTTotal.TabIndex = 0
        Me.lblTTotal.Text = "Todays Total Detections: 0"
        Me.lblTTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(156, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 27)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(297, 259)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tcNoti)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Counter"
        Me.TopMost = True
        Me.tcNoti.ResumeLayout(False)
        Me.tpSMS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tpRFID.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcNoti As System.Windows.Forms.TabControl
    Friend WithEvents tpSMS As System.Windows.Forms.TabPage
    Friend WithEvents tpRFID As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInbox As System.Windows.Forms.Label
    Friend WithEvents lblUnSubscribe As System.Windows.Forms.Label
    Friend WithEvents lblSent As System.Windows.Forms.Label
    Friend WithEvents lblQueued As System.Windows.Forms.Label
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTLogOut As System.Windows.Forms.Label
    Friend WithEvents lblTLogn As System.Windows.Forms.Label
    Friend WithEvents lblTTotal As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
