<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmClient
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents _pbLogIn_0 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogIn_1 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogIn_2 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogIn_3 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogOut_0 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogOut_1 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogOut_2 As System.Windows.Forms.PictureBox
    Public WithEvents _pbLogOut_3 As System.Windows.Forms.PictureBox
    Public WithEvents _lblLogIn_0 As System.Windows.Forms.Label
    Public WithEvents _lblLogIn_1 As System.Windows.Forms.Label
    Public WithEvents _lblLogIn_2 As System.Windows.Forms.Label
    Public WithEvents _lblLogIn_3 As System.Windows.Forms.Label
    Public WithEvents _lblLogOut_0 As System.Windows.Forms.Label
    Public WithEvents _lblLogOut_1 As System.Windows.Forms.Label
    Public WithEvents _lblLogOut_2 As System.Windows.Forms.Label
    Public WithEvents _lblLogOut_3 As System.Windows.Forms.Label
    Public WithEvents _lblLogInSN_0 As System.Windows.Forms.Label
    Public WithEvents _lblLogInSN_1 As System.Windows.Forms.Label
    Public WithEvents _lblLogInSN_2 As System.Windows.Forms.Label
    Public WithEvents _lblLogInSN_3 As System.Windows.Forms.Label
    Public WithEvents _lblLogOutSN_0 As System.Windows.Forms.Label
    Public WithEvents _lblLogOutSN_1 As System.Windows.Forms.Label
    Public WithEvents _lblLogOutSN_2 As System.Windows.Forms.Label
    Public WithEvents _lblLogOutSN_3 As System.Windows.Forms.Label
    Public WithEvents lblLogIn As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblLogInSN As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblLogOut As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblLogOutSN As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents pbLogIn As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents pbLogOut As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Me._pbLogIn_0 = New System.Windows.Forms.PictureBox
        Me._pbLogIn_1 = New System.Windows.Forms.PictureBox
        Me._pbLogIn_2 = New System.Windows.Forms.PictureBox
        Me._pbLogIn_3 = New System.Windows.Forms.PictureBox
        Me._pbLogOut_0 = New System.Windows.Forms.PictureBox
        Me._pbLogOut_1 = New System.Windows.Forms.PictureBox
        Me._pbLogOut_2 = New System.Windows.Forms.PictureBox
        Me._pbLogOut_3 = New System.Windows.Forms.PictureBox
        Me._lblLogIn_0 = New System.Windows.Forms.Label
        Me._lblLogIn_1 = New System.Windows.Forms.Label
        Me._lblLogIn_2 = New System.Windows.Forms.Label
        Me._lblLogIn_3 = New System.Windows.Forms.Label
        Me._lblLogOut_0 = New System.Windows.Forms.Label
        Me._lblLogOut_1 = New System.Windows.Forms.Label
        Me._lblLogOut_2 = New System.Windows.Forms.Label
        Me._lblLogOut_3 = New System.Windows.Forms.Label
        Me._lblLogInSN_0 = New System.Windows.Forms.Label
        Me._lblLogInSN_1 = New System.Windows.Forms.Label
        Me._lblLogInSN_2 = New System.Windows.Forms.Label
        Me._lblLogInSN_3 = New System.Windows.Forms.Label
        Me._lblLogOutSN_0 = New System.Windows.Forms.Label
        Me._lblLogOutSN_1 = New System.Windows.Forms.Label
        Me._lblLogOutSN_2 = New System.Windows.Forms.Label
        Me._lblLogOutSN_3 = New System.Windows.Forms.Label
        Me.lblLogIn = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblLogInSN = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblLogOut = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblLogOutSN = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.pbLogIn = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.pbLogOut = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.pbMainPic = New System.Windows.Forms.PictureBox
        Me.lblResult = New System.Windows.Forms.Label
        Me.gbFindStud = New System.Windows.Forms.GroupBox
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.btnFindStud = New System.Windows.Forms.Button
        Me.btnChat = New System.Windows.Forms.Button
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.lblTime = New System.Windows.Forms.Label
        Me.btnOption = New System.Windows.Forms.Button
        Me.lblAnn = New System.Windows.Forms.Label
        Me.btnLogOutNext = New System.Windows.Forms.Button
        Me.btnLogInPrev = New System.Windows.Forms.Button
        Me.btnLogOutPrev = New System.Windows.Forms.Button
        Me.tmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogInNext = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblDateTimeLog = New System.Windows.Forms.Label
        Me.lblYearSec = New System.Windows.Forms.Label
        Me.lblLogState = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.lblStudNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnn = New System.Windows.Forms.Timer(Me.components)
        Me.ttClient = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me._pbLogIn_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogIn_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogIn_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogIn_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogOut_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogOut_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogOut_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pbLogOut_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogInSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogOutSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFindStud.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pbLogIn_0
        '
        Me._pbLogIn_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogIn_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogIn_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogIn_0.Image = CType(resources.GetObject("_pbLogIn_0.Image"), System.Drawing.Image)
        Me.pbLogIn.SetIndex(Me._pbLogIn_0, CType(0, Short))
        Me._pbLogIn_0.Location = New System.Drawing.Point(361, 546)
        Me._pbLogIn_0.Name = "_pbLogIn_0"
        Me._pbLogIn_0.Size = New System.Drawing.Size(105, 93)
        Me._pbLogIn_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogIn_0.TabIndex = 0
        Me._pbLogIn_0.TabStop = False
        '
        '_pbLogIn_1
        '
        Me._pbLogIn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogIn_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogIn_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogIn_1.Image = CType(resources.GetObject("_pbLogIn_1.Image"), System.Drawing.Image)
        Me.pbLogIn.SetIndex(Me._pbLogIn_1, CType(1, Short))
        Me._pbLogIn_1.Location = New System.Drawing.Point(250, 552)
        Me._pbLogIn_1.Name = "_pbLogIn_1"
        Me._pbLogIn_1.Size = New System.Drawing.Size(94, 87)
        Me._pbLogIn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogIn_1.TabIndex = 1
        Me._pbLogIn_1.TabStop = False
        '
        '_pbLogIn_2
        '
        Me._pbLogIn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogIn_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogIn_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogIn_2.Image = CType(resources.GetObject("_pbLogIn_2.Image"), System.Drawing.Image)
        Me.pbLogIn.SetIndex(Me._pbLogIn_2, CType(2, Short))
        Me._pbLogIn_2.Location = New System.Drawing.Point(153, 562)
        Me._pbLogIn_2.Name = "_pbLogIn_2"
        Me._pbLogIn_2.Size = New System.Drawing.Size(82, 77)
        Me._pbLogIn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogIn_2.TabIndex = 2
        Me._pbLogIn_2.TabStop = False
        '
        '_pbLogIn_3
        '
        Me._pbLogIn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogIn_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogIn_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogIn_3.Image = CType(resources.GetObject("_pbLogIn_3.Image"), System.Drawing.Image)
        Me.pbLogIn.SetIndex(Me._pbLogIn_3, CType(3, Short))
        Me._pbLogIn_3.Location = New System.Drawing.Point(65, 570)
        Me._pbLogIn_3.Name = "_pbLogIn_3"
        Me._pbLogIn_3.Size = New System.Drawing.Size(74, 69)
        Me._pbLogIn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogIn_3.TabIndex = 3
        Me._pbLogIn_3.TabStop = False
        '
        '_pbLogOut_0
        '
        Me._pbLogOut_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogOut_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogOut_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogOut_0.Image = CType(resources.GetObject("_pbLogOut_0.Image"), System.Drawing.Image)
        Me.pbLogOut.SetIndex(Me._pbLogOut_0, CType(0, Short))
        Me._pbLogOut_0.Location = New System.Drawing.Point(562, 546)
        Me._pbLogOut_0.Name = "_pbLogOut_0"
        Me._pbLogOut_0.Size = New System.Drawing.Size(105, 93)
        Me._pbLogOut_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogOut_0.TabIndex = 4
        Me._pbLogOut_0.TabStop = False
        '
        '_pbLogOut_1
        '
        Me._pbLogOut_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogOut_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogOut_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogOut_1.Image = CType(resources.GetObject("_pbLogOut_1.Image"), System.Drawing.Image)
        Me.pbLogOut.SetIndex(Me._pbLogOut_1, CType(1, Short))
        Me._pbLogOut_1.Location = New System.Drawing.Point(687, 552)
        Me._pbLogOut_1.Name = "_pbLogOut_1"
        Me._pbLogOut_1.Size = New System.Drawing.Size(94, 87)
        Me._pbLogOut_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogOut_1.TabIndex = 5
        Me._pbLogOut_1.TabStop = False
        '
        '_pbLogOut_2
        '
        Me._pbLogOut_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogOut_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogOut_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogOut_2.Image = CType(resources.GetObject("_pbLogOut_2.Image"), System.Drawing.Image)
        Me.pbLogOut.SetIndex(Me._pbLogOut_2, CType(2, Short))
        Me._pbLogOut_2.Location = New System.Drawing.Point(799, 562)
        Me._pbLogOut_2.Name = "_pbLogOut_2"
        Me._pbLogOut_2.Size = New System.Drawing.Size(82, 77)
        Me._pbLogOut_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogOut_2.TabIndex = 6
        Me._pbLogOut_2.TabStop = False
        '
        '_pbLogOut_3
        '
        Me._pbLogOut_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pbLogOut_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._pbLogOut_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._pbLogOut_3.Image = CType(resources.GetObject("_pbLogOut_3.Image"), System.Drawing.Image)
        Me.pbLogOut.SetIndex(Me._pbLogOut_3, CType(3, Short))
        Me._pbLogOut_3.Location = New System.Drawing.Point(899, 570)
        Me._pbLogOut_3.Name = "_pbLogOut_3"
        Me._pbLogOut_3.Size = New System.Drawing.Size(74, 69)
        Me._pbLogOut_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._pbLogOut_3.TabIndex = 7
        Me._pbLogOut_3.TabStop = False
        '
        '_lblLogIn_0
        '
        Me._lblLogIn_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogIn_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogIn_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogIn_0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogIn_0.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn.SetIndex(Me._lblLogIn_0, CType(0, Short))
        Me._lblLogIn_0.Location = New System.Drawing.Point(361, 642)
        Me._lblLogIn_0.Name = "_lblLogIn_0"
        Me._lblLogIn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogIn_0.Size = New System.Drawing.Size(105, 19)
        Me._lblLogIn_0.TabIndex = 15
        Me._lblLogIn_0.Text = "00:00 AM"
        Me._lblLogIn_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogIn_1
        '
        Me._lblLogIn_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogIn_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogIn_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogIn_1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogIn_1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn.SetIndex(Me._lblLogIn_1, CType(1, Short))
        Me._lblLogIn_1.Location = New System.Drawing.Point(250, 642)
        Me._lblLogIn_1.Name = "_lblLogIn_1"
        Me._lblLogIn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogIn_1.Size = New System.Drawing.Size(94, 19)
        Me._lblLogIn_1.TabIndex = 14
        Me._lblLogIn_1.Text = "00:00 AM"
        Me._lblLogIn_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogIn_2
        '
        Me._lblLogIn_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogIn_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogIn_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogIn_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogIn_2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn.SetIndex(Me._lblLogIn_2, CType(2, Short))
        Me._lblLogIn_2.Location = New System.Drawing.Point(153, 642)
        Me._lblLogIn_2.Name = "_lblLogIn_2"
        Me._lblLogIn_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogIn_2.Size = New System.Drawing.Size(82, 19)
        Me._lblLogIn_2.TabIndex = 13
        Me._lblLogIn_2.Text = "00:00 AM"
        Me._lblLogIn_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogIn_3
        '
        Me._lblLogIn_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogIn_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogIn_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogIn_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogIn_3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogIn.SetIndex(Me._lblLogIn_3, CType(3, Short))
        Me._lblLogIn_3.Location = New System.Drawing.Point(65, 642)
        Me._lblLogIn_3.Name = "_lblLogIn_3"
        Me._lblLogIn_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogIn_3.Size = New System.Drawing.Size(74, 19)
        Me._lblLogIn_3.TabIndex = 12
        Me._lblLogIn_3.Text = "00:00 AM"
        Me._lblLogIn_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOut_0
        '
        Me._lblLogOut_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOut_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOut_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOut_0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOut_0.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut.SetIndex(Me._lblLogOut_0, CType(0, Short))
        Me._lblLogOut_0.Location = New System.Drawing.Point(562, 642)
        Me._lblLogOut_0.Name = "_lblLogOut_0"
        Me._lblLogOut_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOut_0.Size = New System.Drawing.Size(105, 19)
        Me._lblLogOut_0.TabIndex = 11
        Me._lblLogOut_0.Text = "00:00 AM"
        Me._lblLogOut_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOut_1
        '
        Me._lblLogOut_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOut_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOut_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOut_1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOut_1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut.SetIndex(Me._lblLogOut_1, CType(1, Short))
        Me._lblLogOut_1.Location = New System.Drawing.Point(687, 642)
        Me._lblLogOut_1.Name = "_lblLogOut_1"
        Me._lblLogOut_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOut_1.Size = New System.Drawing.Size(94, 19)
        Me._lblLogOut_1.TabIndex = 10
        Me._lblLogOut_1.Text = "00:00 AM"
        Me._lblLogOut_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOut_2
        '
        Me._lblLogOut_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOut_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOut_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOut_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOut_2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut.SetIndex(Me._lblLogOut_2, CType(2, Short))
        Me._lblLogOut_2.Location = New System.Drawing.Point(799, 642)
        Me._lblLogOut_2.Name = "_lblLogOut_2"
        Me._lblLogOut_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOut_2.Size = New System.Drawing.Size(82, 19)
        Me._lblLogOut_2.TabIndex = 9
        Me._lblLogOut_2.Text = "00:00 AM"
        Me._lblLogOut_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOut_3
        '
        Me._lblLogOut_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOut_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOut_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOut_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOut_3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOut.SetIndex(Me._lblLogOut_3, CType(3, Short))
        Me._lblLogOut_3.Location = New System.Drawing.Point(899, 642)
        Me._lblLogOut_3.Name = "_lblLogOut_3"
        Me._lblLogOut_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOut_3.Size = New System.Drawing.Size(74, 19)
        Me._lblLogOut_3.TabIndex = 8
        Me._lblLogOut_3.Text = "00:00 AM"
        Me._lblLogOut_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogInSN_0
        '
        Me._lblLogInSN_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogInSN_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogInSN_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogInSN_0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogInSN_0.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN.SetIndex(Me._lblLogInSN_0, CType(0, Short))
        Me._lblLogInSN_0.Location = New System.Drawing.Point(361, 664)
        Me._lblLogInSN_0.Name = "_lblLogInSN_0"
        Me._lblLogInSN_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogInSN_0.Size = New System.Drawing.Size(105, 19)
        Me._lblLogInSN_0.TabIndex = 7
        Me._lblLogInSN_0.Text = "00:00 AM"
        Me._lblLogInSN_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogInSN_1
        '
        Me._lblLogInSN_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogInSN_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogInSN_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogInSN_1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogInSN_1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN.SetIndex(Me._lblLogInSN_1, CType(1, Short))
        Me._lblLogInSN_1.Location = New System.Drawing.Point(250, 663)
        Me._lblLogInSN_1.Name = "_lblLogInSN_1"
        Me._lblLogInSN_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogInSN_1.Size = New System.Drawing.Size(94, 19)
        Me._lblLogInSN_1.TabIndex = 6
        Me._lblLogInSN_1.Text = "00:00 AM"
        Me._lblLogInSN_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogInSN_2
        '
        Me._lblLogInSN_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogInSN_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogInSN_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogInSN_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogInSN_2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN.SetIndex(Me._lblLogInSN_2, CType(2, Short))
        Me._lblLogInSN_2.Location = New System.Drawing.Point(153, 664)
        Me._lblLogInSN_2.Name = "_lblLogInSN_2"
        Me._lblLogInSN_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogInSN_2.Size = New System.Drawing.Size(82, 19)
        Me._lblLogInSN_2.TabIndex = 5
        Me._lblLogInSN_2.Text = "00:00 AM"
        Me._lblLogInSN_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogInSN_3
        '
        Me._lblLogInSN_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogInSN_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogInSN_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogInSN_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogInSN_3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogInSN.SetIndex(Me._lblLogInSN_3, CType(3, Short))
        Me._lblLogInSN_3.Location = New System.Drawing.Point(65, 664)
        Me._lblLogInSN_3.Name = "_lblLogInSN_3"
        Me._lblLogInSN_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogInSN_3.Size = New System.Drawing.Size(74, 19)
        Me._lblLogInSN_3.TabIndex = 4
        Me._lblLogInSN_3.Text = "00:00 AM"
        Me._lblLogInSN_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOutSN_0
        '
        Me._lblLogOutSN_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOutSN_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOutSN_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOutSN_0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOutSN_0.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN.SetIndex(Me._lblLogOutSN_0, CType(0, Short))
        Me._lblLogOutSN_0.Location = New System.Drawing.Point(562, 665)
        Me._lblLogOutSN_0.Name = "_lblLogOutSN_0"
        Me._lblLogOutSN_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOutSN_0.Size = New System.Drawing.Size(105, 19)
        Me._lblLogOutSN_0.TabIndex = 3
        Me._lblLogOutSN_0.Text = "00:00 AM"
        Me._lblLogOutSN_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOutSN_1
        '
        Me._lblLogOutSN_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOutSN_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOutSN_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOutSN_1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOutSN_1.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN.SetIndex(Me._lblLogOutSN_1, CType(1, Short))
        Me._lblLogOutSN_1.Location = New System.Drawing.Point(687, 665)
        Me._lblLogOutSN_1.Name = "_lblLogOutSN_1"
        Me._lblLogOutSN_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOutSN_1.Size = New System.Drawing.Size(94, 19)
        Me._lblLogOutSN_1.TabIndex = 2
        Me._lblLogOutSN_1.Text = "00:00 AM"
        Me._lblLogOutSN_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOutSN_2
        '
        Me._lblLogOutSN_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOutSN_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOutSN_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOutSN_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOutSN_2.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN.SetIndex(Me._lblLogOutSN_2, CType(2, Short))
        Me._lblLogOutSN_2.Location = New System.Drawing.Point(799, 664)
        Me._lblLogOutSN_2.Name = "_lblLogOutSN_2"
        Me._lblLogOutSN_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOutSN_2.Size = New System.Drawing.Size(82, 19)
        Me._lblLogOutSN_2.TabIndex = 1
        Me._lblLogOutSN_2.Text = "00:00 AM"
        Me._lblLogOutSN_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblLogOutSN_3
        '
        Me._lblLogOutSN_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._lblLogOutSN_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblLogOutSN_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLogOutSN_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLogOutSN_3.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogOutSN.SetIndex(Me._lblLogOutSN_3, CType(3, Short))
        Me._lblLogOutSN_3.Location = New System.Drawing.Point(899, 664)
        Me._lblLogOutSN_3.Name = "_lblLogOutSN_3"
        Me._lblLogOutSN_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLogOutSN_3.Size = New System.Drawing.Size(74, 19)
        Me._lblLogOutSN_3.TabIndex = 0
        Me._lblLogOutSN_3.Text = "00:00 AM"
        Me._lblLogOutSN_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbMainPic
        '
        Me.pbMainPic.BackColor = System.Drawing.Color.White
        Me.pbMainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMainPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbMainPic.Image = CType(resources.GetObject("pbMainPic.Image"), System.Drawing.Image)
        Me.pbMainPic.Location = New System.Drawing.Point(333, 96)
        Me.pbMainPic.Name = "pbMainPic"
        Me.pbMainPic.Size = New System.Drawing.Size(373, 394)
        Me.pbMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMainPic.TabIndex = 234
        Me.pbMainPic.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(63, 171)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(267, 22)
        Me.lblResult.TabIndex = 233
        Me.lblResult.Text = "No result for ''"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblResult.Visible = False
        '
        'gbFindStud
        '
        Me.gbFindStud.BackColor = System.Drawing.Color.Transparent
        Me.gbFindStud.Controls.Add(Me.txtKey)
        Me.gbFindStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFindStud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbFindStud.Location = New System.Drawing.Point(63, 125)
        Me.gbFindStud.Name = "gbFindStud"
        Me.gbFindStud.Size = New System.Drawing.Size(174, 43)
        Me.gbFindStud.TabIndex = 232
        Me.gbFindStud.TabStop = False
        Me.gbFindStud.Text = "Student Number"
        Me.gbFindStud.Visible = False
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Gray
        Me.txtKey.Location = New System.Drawing.Point(8, 16)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(160, 22)
        Me.txtKey.TabIndex = 0
        Me.txtKey.Text = "Search"
        '
        'btnFindStud
        '
        Me.btnFindStud.BackColor = System.Drawing.Color.Transparent
        Me.btnFindStud.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Binocular
        Me.btnFindStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindStud.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindStud.Location = New System.Drawing.Point(25, 130)
        Me.btnFindStud.Name = "btnFindStud"
        Me.btnFindStud.Size = New System.Drawing.Size(39, 38)
        Me.btnFindStud.TabIndex = 231
        Me.btnFindStud.Tag = "Find"
        Me.btnFindStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindStud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttClient.SetToolTip(Me.btnFindStud, "Find Student")
        Me.btnFindStud.UseVisualStyleBackColor = False
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.Black
        Me.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.ForeColor = System.Drawing.Color.Gold
        Me.btnChat.Location = New System.Drawing.Point(43, 398)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(185, 29)
        Me.btnChat.TabIndex = 230
        Me.btnChat.Text = "Chat"
        Me.ttClient.SetToolTip(Me.btnChat, "Chat active users")
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Maroon
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(43, 359)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(185, 30)
        Me.btnLogOut.TabIndex = 229
        Me.btnLogOut.Text = "&Log out"
        Me.ttClient.SetToolTip(Me.btnLogOut, "Log out")
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(42, 723)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(213, 33)
        Me.lblTime.TabIndex = 221
        Me.lblTime.Text = "00:00:00 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOption
        '
        Me.btnOption.BackColor = System.Drawing.Color.Maroon
        Me.btnOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption.ForeColor = System.Drawing.Color.White
        Me.btnOption.Location = New System.Drawing.Point(43, 298)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(185, 30)
        Me.btnOption.TabIndex = 228
        Me.btnOption.Text = "&Option"
        Me.ttClient.SetToolTip(Me.btnOption, "System Option")
        Me.btnOption.UseVisualStyleBackColor = False
        '
        'lblAnn
        '
        Me.lblAnn.BackColor = System.Drawing.Color.Transparent
        Me.lblAnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnn.ForeColor = System.Drawing.Color.Yellow
        Me.lblAnn.Location = New System.Drawing.Point(260, 714)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(782, 24)
        Me.lblAnn.TabIndex = 220
        Me.lblAnn.Text = "ATTENTTION: NO CLASS TODAY!!  BITIN ANG STUDENTS SA VACATION"
        Me.lblAnn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogOutNext
        '
        Me.btnLogOutNext.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOutNext.BackgroundImage = CType(resources.GetObject("btnLogOutNext.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOutNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOutNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOutNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOutNext.Location = New System.Drawing.Point(975, 653)
        Me.btnLogOutNext.Name = "btnLogOutNext"
        Me.btnLogOutNext.Size = New System.Drawing.Size(35, 30)
        Me.btnLogOutNext.TabIndex = 227
        Me.ttClient.SetToolTip(Me.btnLogOutNext, "Previous log-out record")
        Me.btnLogOutNext.UseVisualStyleBackColor = False
        Me.btnLogOutNext.Visible = False
        '
        'btnLogInPrev
        '
        Me.btnLogInPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnLogInPrev.BackgroundImage = CType(resources.GetObject("btnLogInPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnLogInPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogInPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogInPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogInPrev.Location = New System.Drawing.Point(24, 653)
        Me.btnLogInPrev.Name = "btnLogInPrev"
        Me.btnLogInPrev.Size = New System.Drawing.Size(35, 30)
        Me.btnLogInPrev.TabIndex = 225
        Me.ttClient.SetToolTip(Me.btnLogInPrev, "Previous log-in record")
        Me.btnLogInPrev.UseVisualStyleBackColor = False
        Me.btnLogInPrev.Visible = False
        '
        'btnLogOutPrev
        '
        Me.btnLogOutPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOutPrev.BackgroundImage = CType(resources.GetObject("btnLogOutPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOutPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOutPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOutPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOutPrev.Location = New System.Drawing.Point(524, 654)
        Me.btnLogOutPrev.Name = "btnLogOutPrev"
        Me.btnLogOutPrev.Size = New System.Drawing.Size(35, 30)
        Me.btnLogOutPrev.TabIndex = 226
        Me.ttClient.SetToolTip(Me.btnLogOutPrev, "Next log-out record")
        Me.btnLogOutPrev.UseVisualStyleBackColor = False
        Me.btnLogOutPrev.Visible = False
        '
        'tmrRead
        '
        Me.tmrRead.Enabled = True
        Me.tmrRead.Interval = 2000
        '
        'btnLogInNext
        '
        Me.btnLogInNext.BackColor = System.Drawing.Color.Transparent
        Me.btnLogInNext.BackgroundImage = CType(resources.GetObject("btnLogInNext.BackgroundImage"), System.Drawing.Image)
        Me.btnLogInNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogInNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogInNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogInNext.Location = New System.Drawing.Point(472, 654)
        Me.btnLogInNext.Name = "btnLogInNext"
        Me.btnLogInNext.Size = New System.Drawing.Size(35, 30)
        Me.btnLogInNext.TabIndex = 224
        Me.ttClient.SetToolTip(Me.btnLogInNext, "Next log in record")
        Me.btnLogInNext.UseVisualStyleBackColor = False
        Me.btnLogInNext.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Maroon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(43, 236)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(185, 30)
        Me.btnSearch.TabIndex = 223
        Me.btnSearch.Text = "Search"
        Me.ttClient.SetToolTip(Me.btnSearch, "Search student from log records")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblDateTimeLog
        '
        Me.lblDateTimeLog.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTimeLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTimeLog.ForeColor = System.Drawing.Color.Cyan
        Me.lblDateTimeLog.Location = New System.Drawing.Point(752, 417)
        Me.lblDateTimeLog.Name = "lblDateTimeLog"
        Me.lblDateTimeLog.Size = New System.Drawing.Size(230, 27)
        Me.lblDateTimeLog.TabIndex = 219
        Me.lblDateTimeLog.Text = "Date Time Log"
        Me.lblDateTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYearSec
        '
        Me.lblYearSec.BackColor = System.Drawing.Color.Transparent
        Me.lblYearSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSec.ForeColor = System.Drawing.Color.White
        Me.lblYearSec.Location = New System.Drawing.Point(752, 387)
        Me.lblYearSec.Name = "lblYearSec"
        Me.lblYearSec.Size = New System.Drawing.Size(230, 24)
        Me.lblYearSec.TabIndex = 217
        Me.lblYearSec.Text = "Year-Section"
        Me.lblYearSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLogState
        '
        Me.lblLogState.BackColor = System.Drawing.Color.Transparent
        Me.lblLogState.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogState.ForeColor = System.Drawing.Color.White
        Me.lblLogState.Location = New System.Drawing.Point(754, 157)
        Me.lblLogState.Name = "lblLogState"
        Me.lblLogState.Size = New System.Drawing.Size(220, 37)
        Me.lblLogState.TabIndex = 218
        Me.lblLogState.Text = "WELCOME"
        Me.lblLogState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.White
        Me.lblCourse.Location = New System.Drawing.Point(756, 329)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(230, 50)
        Me.lblCourse.TabIndex = 216
        Me.lblCourse.Text = "Department"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStudNo
        '
        Me.lblStudNo.BackColor = System.Drawing.Color.Transparent
        Me.lblStudNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.Color.Cyan
        Me.lblStudNo.Location = New System.Drawing.Point(752, 250)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(230, 32)
        Me.lblStudNo.TabIndex = 215
        Me.lblStudNo.Text = "Student Number"
        Me.lblStudNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(756, 282)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(230, 50)
        Me.lblName.TabIndex = 214
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(1016, 703)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 40)
        Me.Label1.TabIndex = 235
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(60, 706)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(202, 17)
        Me.lblDate.TabIndex = 236
        Me.lblDate.Text = "January 01, 2011 Monday"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'tmrAnn
        '
        Me.tmrAnn.Enabled = True
        Me.tmrAnn.Interval = 300
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PUPSMBCSSMS_CLIENT.My.Resources.Resources.Client
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 754)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.pbMainPic)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.gbFindStud)
        Me.Controls.Add(Me.btnFindStud)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnOption)
        Me.Controls.Add(Me.btnLogOutNext)
        Me.Controls.Add(Me.btnLogInPrev)
        Me.Controls.Add(Me.btnLogOutPrev)
        Me.Controls.Add(Me.btnLogInNext)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblDateTimeLog)
        Me.Controls.Add(Me.lblYearSec)
        Me.Controls.Add(Me.lblLogState)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblStudNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me._pbLogIn_0)
        Me.Controls.Add(Me._pbLogIn_1)
        Me.Controls.Add(Me._pbLogIn_2)
        Me.Controls.Add(Me._pbLogIn_3)
        Me.Controls.Add(Me._pbLogOut_0)
        Me.Controls.Add(Me._pbLogOut_1)
        Me.Controls.Add(Me._pbLogOut_2)
        Me.Controls.Add(Me._pbLogOut_3)
        Me.Controls.Add(Me._lblLogIn_0)
        Me.Controls.Add(Me._lblLogIn_1)
        Me.Controls.Add(Me._lblLogIn_2)
        Me.Controls.Add(Me._lblLogIn_3)
        Me.Controls.Add(Me._lblLogOut_0)
        Me.Controls.Add(Me._lblLogOut_1)
        Me.Controls.Add(Me._lblLogOut_2)
        Me.Controls.Add(Me._lblLogOut_3)
        Me.Controls.Add(Me._lblLogInSN_0)
        Me.Controls.Add(Me._lblLogInSN_1)
        Me.Controls.Add(Me._lblLogInSN_2)
        Me.Controls.Add(Me._lblLogInSN_3)
        Me.Controls.Add(Me._lblLogOutSN_0)
        Me.Controls.Add(Me._lblLogOutSN_1)
        Me.Controls.Add(Me._lblLogOutSN_2)
        Me.Controls.Add(Me._lblLogOutSN_3)
        Me.Controls.Add(Me.lblAnn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmClient"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        CType(Me._pbLogIn_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogIn_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogIn_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogIn_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogOut_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogOut_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogOut_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pbLogOut_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogInSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogOutSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFindStud.ResumeLayout(False)
        Me.gbFindStud.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbMainPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents gbFindStud As System.Windows.Forms.GroupBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents btnFindStud As System.Windows.Forms.Button
    Friend WithEvents btnChat As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnOption As System.Windows.Forms.Button
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents btnLogOutNext As System.Windows.Forms.Button
    Friend WithEvents btnLogInPrev As System.Windows.Forms.Button
    Friend WithEvents btnLogOutPrev As System.Windows.Forms.Button
    Friend WithEvents tmrRead As System.Windows.Forms.Timer
    Friend WithEvents btnLogInNext As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblDateTimeLog As System.Windows.Forms.Label
    Friend WithEvents lblYearSec As System.Windows.Forms.Label
    Friend WithEvents lblLogState As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblStudNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents tmrAnn As System.Windows.Forms.Timer
    Friend WithEvents ttClient As System.Windows.Forms.ToolTip
#End Region
End Class