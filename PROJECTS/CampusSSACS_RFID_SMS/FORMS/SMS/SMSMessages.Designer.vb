<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSMessages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSMessages))
        Me.gbALERT_Invalid = New System.Windows.Forms.GroupBox
        Me.lblALERT_Invalid = New System.Windows.Forms.Label
        Me.txtALERT_Invalid = New System.Windows.Forms.TextBox
        Me.btnALERT_Invalid = New System.Windows.Forms.Button
        Me.gbALERT_Confirm = New System.Windows.Forms.GroupBox
        Me.lblALERT_Confirm = New System.Windows.Forms.Label
        Me.txtALERT_Confirm = New System.Windows.Forms.TextBox
        Me.btnALERT_Confirm = New System.Windows.Forms.Button
        Me.gbLogOut = New System.Windows.Forms.GroupBox
        Me.lblLogOut = New System.Windows.Forms.Label
        Me.txtLogOut = New System.Windows.Forms.TextBox
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.gbUnLogOut = New System.Windows.Forms.GroupBox
        Me.lblUnLogOut = New System.Windows.Forms.Label
        Me.txtUnLogOut = New System.Windows.Forms.TextBox
        Me.btnUnLogOut = New System.Windows.Forms.Button
        Me.gbAdvisory = New System.Windows.Forms.GroupBox
        Me.lblAdvisory = New System.Windows.Forms.Label
        Me.txtAdvisory = New System.Windows.Forms.TextBox
        Me.btnAdvisory = New System.Windows.Forms.Button
        Me.gbLogIn = New System.Windows.Forms.GroupBox
        Me.lblLogIn = New System.Windows.Forms.Label
        Me.txtLogIn = New System.Windows.Forms.TextBox
        Me.btnLogIn = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbText = New System.Windows.Forms.PictureBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnSent = New System.Windows.Forms.Button
        Me.btnInbox = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.ttSMS = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbALERT_Invalid.SuspendLayout()
        Me.gbALERT_Confirm.SuspendLayout()
        Me.gbLogOut.SuspendLayout()
        Me.gbUnLogOut.SuspendLayout()
        Me.gbAdvisory.SuspendLayout()
        Me.gbLogIn.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbALERT_Invalid
        '
        Me.gbALERT_Invalid.Controls.Add(Me.lblALERT_Invalid)
        Me.gbALERT_Invalid.Controls.Add(Me.txtALERT_Invalid)
        Me.gbALERT_Invalid.Controls.Add(Me.btnALERT_Invalid)
        Me.gbALERT_Invalid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbALERT_Invalid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbALERT_Invalid.Location = New System.Drawing.Point(20, 343)
        Me.gbALERT_Invalid.Name = "gbALERT_Invalid"
        Me.gbALERT_Invalid.Size = New System.Drawing.Size(515, 50)
        Me.gbALERT_Invalid.TabIndex = 8
        Me.gbALERT_Invalid.TabStop = False
        Me.gbALERT_Invalid.Text = "ALERT OFF - Invalid keyword message"
        '
        'lblALERT_Invalid
        '
        Me.lblALERT_Invalid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALERT_Invalid.ForeColor = System.Drawing.Color.Gray
        Me.lblALERT_Invalid.Location = New System.Drawing.Point(430, 51)
        Me.lblALERT_Invalid.Name = "lblALERT_Invalid"
        Me.lblALERT_Invalid.Size = New System.Drawing.Size(79, 40)
        Me.lblALERT_Invalid.TabIndex = 10
        Me.lblALERT_Invalid.Text = "Remaining characters (160/160)"
        Me.lblALERT_Invalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtALERT_Invalid
        '
        Me.txtALERT_Invalid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtALERT_Invalid.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtALERT_Invalid.Location = New System.Drawing.Point(6, 19)
        Me.txtALERT_Invalid.MaxLength = 160
        Me.txtALERT_Invalid.Multiline = True
        Me.txtALERT_Invalid.Name = "txtALERT_Invalid"
        Me.txtALERT_Invalid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtALERT_Invalid.Size = New System.Drawing.Size(418, 23)
        Me.txtALERT_Invalid.TabIndex = 9
        Me.txtALERT_Invalid.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtALERT_Invalid, "[Invalid Unsubscribing Keyword Message]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: Sorry, your keyword is invalid. To" & _
                " deactivate receiving of student's attendance advisory, just reply ALERT OFF.")
        '
        'btnALERT_Invalid
        '
        Me.btnALERT_Invalid.BackColor = System.Drawing.Color.Black
        Me.btnALERT_Invalid.BackgroundImage = CType(resources.GetObject("btnALERT_Invalid.BackgroundImage"), System.Drawing.Image)
        Me.btnALERT_Invalid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnALERT_Invalid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnALERT_Invalid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnALERT_Invalid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnALERT_Invalid.ForeColor = System.Drawing.Color.Gold
        Me.btnALERT_Invalid.Location = New System.Drawing.Point(430, 19)
        Me.btnALERT_Invalid.Name = "btnALERT_Invalid"
        Me.btnALERT_Invalid.Size = New System.Drawing.Size(79, 23)
        Me.btnALERT_Invalid.TabIndex = 8
        Me.btnALERT_Invalid.Text = "&Save"
        Me.btnALERT_Invalid.UseVisualStyleBackColor = False
        '
        'gbALERT_Confirm
        '
        Me.gbALERT_Confirm.Controls.Add(Me.lblALERT_Confirm)
        Me.gbALERT_Confirm.Controls.Add(Me.txtALERT_Confirm)
        Me.gbALERT_Confirm.Controls.Add(Me.btnALERT_Confirm)
        Me.gbALERT_Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbALERT_Confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbALERT_Confirm.Location = New System.Drawing.Point(20, 287)
        Me.gbALERT_Confirm.Name = "gbALERT_Confirm"
        Me.gbALERT_Confirm.Size = New System.Drawing.Size(515, 50)
        Me.gbALERT_Confirm.TabIndex = 12
        Me.gbALERT_Confirm.TabStop = False
        Me.gbALERT_Confirm.Text = "ALERT OFF - Confirmation Message"
        '
        'lblALERT_Confirm
        '
        Me.lblALERT_Confirm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALERT_Confirm.ForeColor = System.Drawing.Color.Gray
        Me.lblALERT_Confirm.Location = New System.Drawing.Point(430, 51)
        Me.lblALERT_Confirm.Name = "lblALERT_Confirm"
        Me.lblALERT_Confirm.Size = New System.Drawing.Size(78, 40)
        Me.lblALERT_Confirm.TabIndex = 10
        Me.lblALERT_Confirm.Text = "Remaining characters (160/160)"
        Me.lblALERT_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtALERT_Confirm
        '
        Me.txtALERT_Confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtALERT_Confirm.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtALERT_Confirm.Location = New System.Drawing.Point(6, 19)
        Me.txtALERT_Confirm.MaxLength = 160
        Me.txtALERT_Confirm.Multiline = True
        Me.txtALERT_Confirm.Name = "txtALERT_Confirm"
        Me.txtALERT_Confirm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtALERT_Confirm.Size = New System.Drawing.Size(418, 23)
        Me.txtALERT_Confirm.TabIndex = 9
        Me.txtALERT_Confirm.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtALERT_Confirm, "[Unsubscribe Confirmation Message]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: You have successfully deactivate the PU" & _
                "P-SMB advisory. To reactivate the advisory, just  reply ALERT ON.")
        '
        'btnALERT_Confirm
        '
        Me.btnALERT_Confirm.BackColor = System.Drawing.Color.Black
        Me.btnALERT_Confirm.BackgroundImage = CType(resources.GetObject("btnALERT_Confirm.BackgroundImage"), System.Drawing.Image)
        Me.btnALERT_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnALERT_Confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnALERT_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnALERT_Confirm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnALERT_Confirm.ForeColor = System.Drawing.Color.Gold
        Me.btnALERT_Confirm.Location = New System.Drawing.Point(429, 19)
        Me.btnALERT_Confirm.Name = "btnALERT_Confirm"
        Me.btnALERT_Confirm.Size = New System.Drawing.Size(79, 23)
        Me.btnALERT_Confirm.TabIndex = 8
        Me.btnALERT_Confirm.Text = "&Save"
        Me.btnALERT_Confirm.UseVisualStyleBackColor = False
        '
        'gbLogOut
        '
        Me.gbLogOut.Controls.Add(Me.lblLogOut)
        Me.gbLogOut.Controls.Add(Me.txtLogOut)
        Me.gbLogOut.Controls.Add(Me.btnLogOut)
        Me.gbLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbLogOut.Location = New System.Drawing.Point(20, 119)
        Me.gbLogOut.Name = "gbLogOut"
        Me.gbLogOut.Size = New System.Drawing.Size(515, 50)
        Me.gbLogOut.TabIndex = 13
        Me.gbLogOut.TabStop = False
        Me.gbLogOut.Text = "Last Log-out Detection Message"
        '
        'lblLogOut
        '
        Me.lblLogOut.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.Gray
        Me.lblLogOut.Location = New System.Drawing.Point(429, 51)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(79, 40)
        Me.lblLogOut.TabIndex = 10
        Me.lblLogOut.Text = "Remaining characters (160/160)"
        Me.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogOut
        '
        Me.txtLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogOut.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogOut.Location = New System.Drawing.Point(6, 19)
        Me.txtLogOut.MaxLength = 160
        Me.txtLogOut.Multiline = True
        Me.txtLogOut.Name = "txtLogOut"
        Me.txtLogOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogOut.Size = New System.Drawing.Size(418, 23)
        Me.txtLogOut.TabIndex = 9
        Me.txtLogOut.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtLogOut, "[Message] + [Time last logged out]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: [Your child's last log out detection fr" & _
                "om the campus is exactly @time of ] + [7:30 PM]")
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Black
        Me.btnLogOut.BackgroundImage = CType(resources.GetObject("btnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Gold
        Me.btnLogOut.Location = New System.Drawing.Point(429, 19)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(79, 23)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "&Save"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'gbUnLogOut
        '
        Me.gbUnLogOut.Controls.Add(Me.lblUnLogOut)
        Me.gbUnLogOut.Controls.Add(Me.txtUnLogOut)
        Me.gbUnLogOut.Controls.Add(Me.btnUnLogOut)
        Me.gbUnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUnLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbUnLogOut.Location = New System.Drawing.Point(20, 175)
        Me.gbUnLogOut.Name = "gbUnLogOut"
        Me.gbUnLogOut.Size = New System.Drawing.Size(515, 50)
        Me.gbUnLogOut.TabIndex = 14
        Me.gbUnLogOut.TabStop = False
        Me.gbUnLogOut.Text = "Unlog-out at PUPSMBC Student Monitoring System End Time"
        '
        'lblUnLogOut
        '
        Me.lblUnLogOut.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnLogOut.ForeColor = System.Drawing.Color.Gray
        Me.lblUnLogOut.Location = New System.Drawing.Point(430, 50)
        Me.lblUnLogOut.Name = "lblUnLogOut"
        Me.lblUnLogOut.Size = New System.Drawing.Size(78, 43)
        Me.lblUnLogOut.TabIndex = 10
        Me.lblUnLogOut.Text = "Remaining characters (160/160)"
        Me.lblUnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnLogOut
        '
        Me.txtUnLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnLogOut.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnLogOut.Location = New System.Drawing.Point(6, 19)
        Me.txtUnLogOut.MaxLength = 160
        Me.txtUnLogOut.Multiline = True
        Me.txtUnLogOut.Name = "txtUnLogOut"
        Me.txtUnLogOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUnLogOut.Size = New System.Drawing.Size(418, 23)
        Me.txtUnLogOut.TabIndex = 9
        Me.txtUnLogOut.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtUnLogOut, resources.GetString("txtUnLogOut.ToolTip"))
        '
        'btnUnLogOut
        '
        Me.btnUnLogOut.BackColor = System.Drawing.Color.Black
        Me.btnUnLogOut.BackgroundImage = CType(resources.GetObject("btnUnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.btnUnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnLogOut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnLogOut.ForeColor = System.Drawing.Color.Gold
        Me.btnUnLogOut.Location = New System.Drawing.Point(429, 19)
        Me.btnUnLogOut.Name = "btnUnLogOut"
        Me.btnUnLogOut.Size = New System.Drawing.Size(79, 23)
        Me.btnUnLogOut.TabIndex = 8
        Me.btnUnLogOut.Text = "&Save"
        Me.btnUnLogOut.UseVisualStyleBackColor = False
        '
        'gbAdvisory
        '
        Me.gbAdvisory.Controls.Add(Me.lblAdvisory)
        Me.gbAdvisory.Controls.Add(Me.txtAdvisory)
        Me.gbAdvisory.Controls.Add(Me.btnAdvisory)
        Me.gbAdvisory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAdvisory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbAdvisory.Location = New System.Drawing.Point(20, 231)
        Me.gbAdvisory.Name = "gbAdvisory"
        Me.gbAdvisory.Size = New System.Drawing.Size(515, 50)
        Me.gbAdvisory.TabIndex = 14
        Me.gbAdvisory.TabStop = False
        Me.gbAdvisory.Text = "PUPSMBC Student Monitoring System Advisory Message"
        '
        'lblAdvisory
        '
        Me.lblAdvisory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvisory.ForeColor = System.Drawing.Color.Gray
        Me.lblAdvisory.Location = New System.Drawing.Point(429, 51)
        Me.lblAdvisory.Name = "lblAdvisory"
        Me.lblAdvisory.Size = New System.Drawing.Size(79, 40)
        Me.lblAdvisory.TabIndex = 10
        Me.lblAdvisory.Text = "Remaining characters (160/160)"
        Me.lblAdvisory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAdvisory
        '
        Me.txtAdvisory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdvisory.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvisory.Location = New System.Drawing.Point(6, 19)
        Me.txtAdvisory.MaxLength = 160
        Me.txtAdvisory.Multiline = True
        Me.txtAdvisory.Name = "txtAdvisory"
        Me.txtAdvisory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdvisory.Size = New System.Drawing.Size(418, 23)
        Me.txtAdvisory.TabIndex = 9
        Me.txtAdvisory.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtAdvisory, "[Advisory Message] " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: This message is part of Student Security Monitoring Sy" & _
                "stem of Polytechnic University of the Philippines Sta. Maria Campus. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'btnAdvisory
        '
        Me.btnAdvisory.BackColor = System.Drawing.Color.Black
        Me.btnAdvisory.BackgroundImage = CType(resources.GetObject("btnAdvisory.BackgroundImage"), System.Drawing.Image)
        Me.btnAdvisory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdvisory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdvisory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdvisory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvisory.ForeColor = System.Drawing.Color.Gold
        Me.btnAdvisory.Location = New System.Drawing.Point(429, 19)
        Me.btnAdvisory.Name = "btnAdvisory"
        Me.btnAdvisory.Size = New System.Drawing.Size(79, 23)
        Me.btnAdvisory.TabIndex = 8
        Me.btnAdvisory.Text = "&Save"
        Me.btnAdvisory.UseVisualStyleBackColor = False
        '
        'gbLogIn
        '
        Me.gbLogIn.BackColor = System.Drawing.Color.Black
        Me.gbLogIn.Controls.Add(Me.lblLogIn)
        Me.gbLogIn.Controls.Add(Me.txtLogIn)
        Me.gbLogIn.Controls.Add(Me.btnLogIn)
        Me.gbLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbLogIn.Location = New System.Drawing.Point(20, 20)
        Me.gbLogIn.Name = "gbLogIn"
        Me.gbLogIn.Size = New System.Drawing.Size(515, 94)
        Me.gbLogIn.TabIndex = 15
        Me.gbLogIn.TabStop = False
        Me.gbLogIn.Text = "Student's First Log-in Detection Time Message"
        '
        'lblLogIn
        '
        Me.lblLogIn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.ForeColor = System.Drawing.Color.Gray
        Me.lblLogIn.Location = New System.Drawing.Point(430, 51)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(78, 40)
        Me.lblLogIn.TabIndex = 10
        Me.lblLogIn.Text = "Remaining characters (160/160)"
        Me.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogIn
        '
        Me.txtLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogIn.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogIn.Location = New System.Drawing.Point(6, 19)
        Me.txtLogIn.MaxLength = 160
        Me.txtLogIn.Multiline = True
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogIn.Size = New System.Drawing.Size(418, 66)
        Me.txtLogIn.TabIndex = 9
        Me.txtLogIn.Text = "Message"
        Me.ttSMS.SetToolTip(Me.txtLogIn, "[Message] + [Time logged in]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: [Your child is inside the campus @time of ] +" & _
                " [7:30 AM]")
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Black
        Me.btnLogIn.BackgroundImage = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.Button
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Gold
        Me.btnLogIn.Location = New System.Drawing.Point(429, 19)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(79, 23)
        Me.btnLogIn.TabIndex = 8
        Me.btnLogIn.Text = "&Save"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LinkLabel7)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.TextBox3)
        Me.GroupBox8.Controls.Add(Me.Button4)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(616, 257)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(515, 120)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SAMPLE"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.LinkColor = System.Drawing.Color.White
        Me.LinkLabel7.Location = New System.Drawing.Point(286, 96)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(115, 13)
        Me.LinkLabel7.TabIndex = 11
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Set to default message"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(7, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Remaining characters (2048/2048)"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(6, 19)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(502, 66)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "asdsa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sdsada"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(429, 91)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBox8)
        Me.GroupBox9.Controls.Add(Me.Button5)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(616, 183)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(515, 53)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "SAMPLE"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(7, 19)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(417, 23)
        Me.TextBox8.TabIndex = 10
        Me.TextBox8.Text = "asdsa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sdsada"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Gold
        Me.Button5.Location = New System.Drawing.Point(430, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "&Change"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.pbText)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 82)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(54, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 61)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SMS Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbText
        '
        Me.pbText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbText.Image = Global.CampusSSACS_RFID_SMS.My.Resources.Resources.TextMessage
        Me.pbText.Location = New System.Drawing.Point(7, 13)
        Me.pbText.Name = "pbText"
        Me.pbText.Size = New System.Drawing.Size(41, 61)
        Me.pbText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbText.TabIndex = 0
        Me.pbText.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(231, 511)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 22)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Saved..."
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSent
        '
        Me.btnSent.BackColor = System.Drawing.Color.Black
        Me.btnSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSent.ForeColor = System.Drawing.Color.Gold
        Me.btnSent.Location = New System.Drawing.Point(158, 511)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(67, 22)
        Me.btnSent.TabIndex = 13
        Me.btnSent.Text = "Sent..."
        Me.btnSent.UseVisualStyleBackColor = False
        '
        'btnInbox
        '
        Me.btnInbox.BackColor = System.Drawing.Color.Black
        Me.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInbox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInbox.ForeColor = System.Drawing.Color.Gold
        Me.btnInbox.Location = New System.Drawing.Point(85, 511)
        Me.btnInbox.Name = "btnInbox"
        Me.btnInbox.Size = New System.Drawing.Size(67, 22)
        Me.btnInbox.TabIndex = 12
        Me.btnInbox.Text = "Inbox..."
        Me.btnInbox.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Gold
        Me.btnNew.Location = New System.Drawing.Point(12, 511)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(67, 22)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New..."
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.gbLogIn)
        Me.GroupBox1.Controls.Add(Me.gbAdvisory)
        Me.GroupBox1.Controls.Add(Me.gbUnLogOut)
        Me.GroupBox1.Controls.Add(Me.gbLogOut)
        Me.GroupBox1.Controls.Add(Me.gbALERT_Confirm)
        Me.GroupBox1.Controls.Add(Me.gbALERT_Invalid)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 412)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gold
        Me.btnClose.Location = New System.Drawing.Point(459, 511)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 22)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ttSMS
        '
        Me.ttSMS.AutoPopDelay = 5000
        Me.ttSMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ttSMS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ttSMS.InitialDelay = 300
        Me.ttSMS.IsBalloon = True
        Me.ttSMS.ReshowDelay = 50
        Me.ttSMS.ToolTipTitle = "Text Format when sending this message"
        '
        'frmSMSMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 543)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnInbox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 11)
        Me.Name = "frmSMSMessages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Messages"
        Me.gbALERT_Invalid.ResumeLayout(False)
        Me.gbALERT_Invalid.PerformLayout()
        Me.gbALERT_Confirm.ResumeLayout(False)
        Me.gbALERT_Confirm.PerformLayout()
        Me.gbLogOut.ResumeLayout(False)
        Me.gbLogOut.PerformLayout()
        Me.gbUnLogOut.ResumeLayout(False)
        Me.gbUnLogOut.PerformLayout()
        Me.gbAdvisory.ResumeLayout(False)
        Me.gbAdvisory.PerformLayout()
        Me.gbLogIn.ResumeLayout(False)
        Me.gbLogIn.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbALERT_Invalid As System.Windows.Forms.GroupBox
    Friend WithEvents btnALERT_Invalid As System.Windows.Forms.Button
    Friend WithEvents txtALERT_Invalid As System.Windows.Forms.TextBox
    Friend WithEvents lblALERT_Invalid As System.Windows.Forms.Label
    Friend WithEvents gbALERT_Confirm As System.Windows.Forms.GroupBox
    Friend WithEvents lblALERT_Confirm As System.Windows.Forms.Label
    Friend WithEvents txtALERT_Confirm As System.Windows.Forms.TextBox
    Friend WithEvents btnALERT_Confirm As System.Windows.Forms.Button
    Friend WithEvents gbLogOut As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogOut As System.Windows.Forms.Label
    Friend WithEvents txtLogOut As System.Windows.Forms.TextBox
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents gbUnLogOut As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnLogOut As System.Windows.Forms.Label
    Friend WithEvents txtUnLogOut As System.Windows.Forms.TextBox
    Friend WithEvents btnUnLogOut As System.Windows.Forms.Button
    Friend WithEvents gbAdvisory As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdvisory As System.Windows.Forms.Label
    Friend WithEvents txtAdvisory As System.Windows.Forms.TextBox
    Friend WithEvents btnAdvisory As System.Windows.Forms.Button
    Friend WithEvents gbLogIn As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents txtLogIn As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbText As System.Windows.Forms.PictureBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInbox As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSent As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ttSMS As System.Windows.Forms.ToolTip
End Class
