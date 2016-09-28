VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Read/Write - Inc/Dec Value Block Sample"
   ClientHeight    =   6540
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8235
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Main.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6540
   ScaleWidth      =   8235
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   6255
      Left            =   120
      ScaleHeight     =   6195
      ScaleWidth      =   7875
      TabIndex        =   0
      Top             =   120
      Width           =   7935
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         Height          =   2895
         Left            =   4200
         TabIndex        =   5
         Top             =   3000
         Width           =   3375
         Begin VB.TextBox Text1 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   2040
            MaxLength       =   9
            TabIndex        =   15
            Text            =   "0"
            Top             =   1560
            Width           =   1095
         End
         Begin VB.TextBox txtblock 
            Alignment       =   2  'Center
            Height          =   285
            Left            =   2040
            MaxLength       =   2
            TabIndex        =   12
            Text            =   "0"
            Top             =   1080
            Width           =   495
         End
         Begin VB.CommandButton cmdDec 
            Caption         =   "Decrement"
            Height          =   375
            Left            =   1800
            TabIndex        =   11
            Top             =   2280
            Width           =   1335
         End
         Begin VB.CommandButton cmdInc 
            Caption         =   "Increment"
            Height          =   375
            Left            =   240
            TabIndex        =   10
            Top             =   2280
            Width           =   1335
         End
         Begin VB.CommandButton Command1 
            Caption         =   "Read Value"
            Height          =   375
            Left            =   1800
            TabIndex        =   9
            Top             =   480
            Width           =   1335
         End
         Begin VB.CommandButton Command2 
            Caption         =   "Write Value"
            Height          =   375
            Left            =   360
            TabIndex        =   8
            Top             =   480
            Width           =   1335
         End
         Begin VB.Label Label3 
            Caption         =   "Value To Inc/Dec   :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   17
            Top             =   1635
            Width           =   1695
         End
         Begin VB.Label Label1 
            Caption         =   "(Decimal)"
            Height          =   255
            Index           =   4
            Left            =   360
            TabIndex        =   16
            Top             =   1920
            Width           =   855
         End
         Begin VB.Label Label1 
            Caption         =   "Block Number :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   3
            Left            =   360
            TabIndex        =   14
            Top             =   1080
            Width           =   1695
         End
         Begin VB.Label Label1 
            Caption         =   "(Decimal)"
            Height          =   255
            Index           =   1
            Left            =   360
            TabIndex        =   13
            Top             =   1320
            Width           =   855
         End
      End
      Begin VB.ListBox List1 
         Height          =   2580
         ItemData        =   "Main.frx":030A
         Left            =   240
         List            =   "Main.frx":030C
         TabIndex        =   4
         Top             =   240
         Width           =   7335
      End
      Begin VB.Frame Frame1 
         Caption         =   "Connection"
         Height          =   2895
         Left            =   240
         TabIndex        =   1
         Top             =   3000
         Width           =   3735
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1350
            List            =   "Main.frx":032A
            TabIndex        =   18
            Text            =   "Port List"
            Top             =   705
            Width           =   1335
         End
         Begin VB.CommandButton cmdLogin 
            Caption         =   "Log-In"
            Height          =   375
            Left            =   1335
            TabIndex        =   7
            Top             =   2280
            Width           =   1335
         End
         Begin VB.CommandButton cmdSelect 
            Caption         =   "Select"
            Height          =   375
            Left            =   1335
            TabIndex        =   6
            Top             =   1845
            Width           =   1335
         End
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1335
            TabIndex        =   3
            Top             =   1080
            Width           =   1335
         End
         Begin VB.Label Label1 
            Caption         =   "PORT"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   0
            Left            =   1335
            TabIndex        =   2
            Top             =   360
            Width           =   855
         End
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'=========================================================================================
'
'   Project Name :  ACR120RWIDValue
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 15, 2004
'
'   Description  :  This Sample Reads and Writes Value to the Value Block.
'                   Aided With Increment and Decrement Functions, this was Intended for
'                   ease of use when the data need to be written on a block was a
'                   numerical value which later to be use in computation.
'                   This also shows how to Connect, Select card, and Login to card sector.
'
'   Initial Step :  1. Connect.
'                   2. Select "Make sure that only 1 card is within antenna range".
'                   3. Login to card sector that you want to manipulate.
'                   4. Use the Function on the right side of the form.
'
'
'
'=========================================================================================
Option Explicit









Private Sub cmdConnect_Click()

Dim Port As Integer
Dim FirmwareVer(0 To 30) As Byte
Dim infolen As Byte
Dim FirmStr As String
Dim ctr As Integer
Dim FirmwareVer1(0 To 19) As Byte
Dim ReaderStat As tReaderStatus

   'open port connection to ACR120 Reader
    rHandle = ACR120_Open(cmbPort.ListIndex)
    
    
    'Check if Handle is Valid
    If rHandle < 0 Then
       List1.AddItem (ErrDef(rHandle))
    Else
       List1.AddItem ("Connected to : " + cmbPort.List(cmbPort.ListIndex))
       cmdSelect.Enabled = True
       cmdLogin.Enabled = True
       
       'Get the DLL version the program is using
       retcode = ACR120_RequestDLLVersion(infolen, FirmwareVer(0))
          
       FirmStr = ""
          
       For ctr = 0 To infolen - 1
            FirmStr = FirmStr + Chr(FirmwareVer(ctr))
       Next
                
       List1.AddItem ("DLL Version  : " + FirmStr)
    
        'Routine to get the firmware version.
        retcode = ACR120_Status(rHandle, FirmwareVer1(0), ReaderStat)
          
        FirmStr = ""
          
        For ctr = 0 To infolen - 1
            If FirmwareVer1(ctr) <> 0 And FirmwareVer1(ctr) <> &HFF Then
                FirmStr = FirmStr + Chr(FirmwareVer1(ctr))
            End If
        Next
          
        List1.AddItem ("Firmware Version  : " + FirmStr)
       
       
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
 
End Sub















Private Sub cmdDec_Click()

Dim NewVal As Long
Dim Blck As Byte
Dim val As Long

    
    'check block range if within the range of 0 to 3
    If CByte(txtblock.Text) < 0 Or CByte(txtblock.Text) > 3 And Sec <= 31 Then
       MsgBox "In the current Sector Block Ranges From 0 to 3 only", vbInformation, "Block Out of Range"
       txtblock.SetFocus
       Exit Sub
    Else
       'set block
       Blck = CByte(txtblock.Text)
    End If
    
    
   'Computation for the exact block to Access....
   If Sec > 31 Then
        Blck = ((Sec - 32) * 16) + 128 + Blck
    Else
        Blck = Sec * 4 + Blck
    End If
    
    
    val = CLng(Text1.Text)
    
    'decrement Value using the value given by the user
    retcode = ACR120_Dec(rHandle, Blck, val, NewVal)
    
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Decrement Error: " + CStr(retcode))
    Else
       List1.AddItem ("Decrement Success: " + CStr(retcode))
       
    End If
    
    'display decremented Value
    List1.AddItem ("Decremented Value of Block " + CStr(Blck) + " : " + CStr(NewVal))
    List1.ListIndex = List1.NewIndex
    
    
     


End Sub
























Private Sub cmdInc_Click()
Dim NewVal As Long
Dim Blck As Byte
Dim val As Long


    'check block range if within the range of 0 to 3
    If CByte(txtblock.Text) < 0 Or CByte(txtblock.Text) > 3 And Sec <= 31 Then
       MsgBox "In the current Sector Block Ranges From 0 to 3 only", vbInformation, "Block Out of Range"
       txtblock.SetFocus
       Exit Sub
    Else
       'set block
       Blck = CByte(txtblock.Text)
    End If
    
    
    'To access the exact block on the card you must Multiply Sector where you Login by 4
    'add the Block in the sector you want to access
   If Sec > 31 Then
        Blck = ((Sec - 32) * 16) + 128 + Blck
    Else
        Blck = Sec * 4 + Blck
    End If
    
    
    val = CLng(Text1.Text)
  
    
    'Increment Value using the value given by the user
    retcode = ACR120_Inc(rHandle, Blck, val, NewVal)
    
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Increment Error: " + CStr(retcode))
    Else
       List1.AddItem ("Increment Success: " + CStr(retcode))
       
    End If
    
    'display incremented Value
    List1.AddItem ("Incremented Value of Block " + CStr(Blck) + " : " + CStr(NewVal))
    
    'autoscroll listbox to the latest entry
    List1.ListIndex = List1.NewIndex
    
    
     
End Sub














Private Sub cmdLogin_Click()
    'show Login Form
    frmLogIn.Show vbModal, Me
End Sub































Private Sub cmdSelect_Click()
Dim ResultSN(0 To 10) As Byte
Dim ResultTag As Byte
Dim SN As String
Dim ctr As Integer
Dim TagType(0 To 50) As Byte

     'Selects a single card and returns the card ID (Serial Number)
     retcode = ACR120_Select(rHandle, TagType(0), ResultTag, ResultSN(0))
     
    
      'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
    
       List1.AddItem ("Select Success")
       
       'Convert Serial Number to Hex Format.
       '(You Can Bypass Hex() Conversion if you want to display serial number as decimal)
        If TagType(0) = 4 Or TagType(0) = 5 Then
                SN = ""
                For ctr = 0 To 6
                    SN = SN + " " + A_BUGFIX(ResultSN(ctr))
                Next
          Else
              
                SN = ""
                For ctr = 0 To ResultTag - 1
                    SN = SN + " " + A_BUGFIX(ResultSN(ctr))
                Next
        
          End If
        
        'Display Serial Number
        List1.AddItem ("( i ) Card Serial Number: " + SN + " ( " + GetTagType1(TagType(0)) + " )")
        cmdLogin.Enabled = True
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex


End Sub

Public Function A_BUGFIX(ByVal NUM As Integer) As String
Dim mTempSTR As String
            'Alternative Function for HEX formatting
            Select Case NUM
                Case 10
                    mTempSTR = "0A" + " "
                Case 11
                    mTempSTR = "0B" + " "
                Case 12
                    mTempSTR = "0C" + " "
                Case 13
                    mTempSTR = "0D" + " "
                Case 14
                    mTempSTR = "0E" + " "
                Case 15
                    mTempSTR = "0F" + " "
                Case 26
                    mTempSTR = "1A" + " "
                Case 42
                    mTempSTR = "2A" + " "
                Case 58
                    mTempSTR = "3A" + " "
                Case 74
                    mTempSTR = "4A" + " "
                Case 90
                    mTempSTR = "5A" + " "
                Case 106
                    mTempSTR = "6A" + " "
                Case 122
                    mTempSTR = "7A" + " "
                Case 138
                    mTempSTR = "8A" + " "
                Case 154
                    mTempSTR = "9A" + " "
                Case 170
                    mTempSTR = "AA" + " "
                Case 186
                    mTempSTR = "BA" + " "
                Case 202
                    mTempSTR = "CA" + " "
                Case 218
                    mTempSTR = "DA" + " "
                Case 234
                    mTempSTR = "EA" + " "
                Case 250
                    mTempSTR = "FA" + " "
                Case Else
                   mTempSTR = Format(Hex(NUM), "00") + " "
            End Select

  A_BUGFIX = mTempSTR

End Function


Public Function GetTagType1(ByVal XTag As Byte) As String

    'Function that explains the value of the TAGTYPE of the Card.
    Select Case (XTag)
    
        Case 1: GetTagType1 = "Mifare Light"
        
        Case 2: GetTagType1 = "Mifare 1K"
        
        Case 3: GetTagType1 = "Mifare 4K"
        
        Case 4: GetTagType1 = "Mifare DESFire"
        
        Case 5: GetTagType1 = "Mifare Ultralight"
        
        Case 6: GetTagType1 = "JCOP30"
        
        Case 7: GetTagType1 = "Shanghai Transport"
        
        Case 8: GetTagType1 = "MPCOS Combi"
        
        Case &H80: GetTagType1 = "ISO Type B, Calypso"
    
    End Select

End Function















Private Sub Command1_Click()
    'show Read Block Form
    frmReadValue.Show vbModal, Me
    
End Sub













Private Sub Command2_Click()
   'show write block form
   frmWriteValue.Show vbModal, Me
End Sub














Private Sub Form_Load()
    
    'set SID to 1
    SID = 1

End Sub







Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
    
End Sub

