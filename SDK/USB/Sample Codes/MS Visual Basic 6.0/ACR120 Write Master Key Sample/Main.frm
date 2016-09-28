VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Write Master Key"
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
         Top             =   3075
         Width           =   3375
         Begin VB.CommandButton cmdMkey 
            Caption         =   "Write MasterKey"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1080
            TabIndex        =   16
            Top             =   2400
            Width           =   1455
         End
         Begin VB.TextBox txtSTO 
            Alignment       =   1  'Right Justify
            Enabled         =   0   'False
            Height          =   285
            Left            =   1440
            MaxLength       =   2
            TabIndex        =   15
            Top             =   360
            Width           =   615
         End
         Begin VB.TextBox Text13 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   240
            MaxLength       =   2
            TabIndex        =   14
            Text            =   "FF"
            Top             =   1560
            Width           =   615
         End
         Begin VB.TextBox Text14 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1320
            MaxLength       =   2
            TabIndex        =   13
            Text            =   "FF"
            Top             =   1560
            Width           =   615
         End
         Begin VB.TextBox Text15 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   2280
            MaxLength       =   2
            TabIndex        =   12
            Text            =   "FF"
            Top             =   1560
            Width           =   615
         End
         Begin VB.TextBox Text16 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   240
            MaxLength       =   2
            TabIndex        =   11
            Text            =   "FF"
            Top             =   1920
            Width           =   615
         End
         Begin VB.TextBox Text17 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1320
            MaxLength       =   2
            TabIndex        =   10
            Text            =   "FF"
            Top             =   1920
            Width           =   615
         End
         Begin VB.TextBox Text18 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   2280
            MaxLength       =   2
            TabIndex        =   9
            Text            =   "FF"
            Top             =   1920
            Width           =   615
         End
         Begin VB.Label Label1 
            Caption         =   "(Decimal 0-31)"
            Height          =   255
            Index           =   1
            Left            =   240
            TabIndex        =   19
            Top             =   600
            Width           =   1050
         End
         Begin VB.Label Label8 
            Caption         =   "Stored Number"
            Height          =   255
            Left            =   240
            TabIndex        =   18
            Top             =   360
            Width           =   1095
         End
         Begin VB.Label Label9 
            Caption         =   "Keys"
            Height          =   255
            Left            =   240
            TabIndex        =   17
            Top             =   960
            Width           =   1335
         End
         Begin VB.Label Label1 
            Caption         =   "(Hexadecimal)"
            Height          =   255
            Index           =   3
            Left            =   240
            TabIndex        =   8
            Top             =   1200
            Width           =   1095
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
         Top             =   3075
         Width           =   3735
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1320
            List            =   "Main.frx":032A
            TabIndex        =   20
            Text            =   "Port List"
            Top             =   690
            Width           =   1335
         End
         Begin VB.CommandButton cmdLogin 
            Caption         =   "Log-In"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1290
            TabIndex        =   7
            Top             =   2400
            Width           =   1335
         End
         Begin VB.CommandButton cmdSelect 
            Caption         =   "Select"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1290
            TabIndex        =   6
            Top             =   1995
            Width           =   1335
         End
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1290
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
            Left            =   1290
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
'   Project Name :  ACR120WriteMasterKey
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 13, 2004
'
'   Description  :  This Sample Writes MasterKeys to ACR120 Reader EEPROM.
'                   MasterKey register Ranges From 0 to 31.
'                   Keys in the register can be use When Login Type
'                   Was Stored_A or Stored_B.
'                   This also shows how to connect,Select card, and Login to card sector.
'
'   Initial Step :  1. Connect.
'                   2. Use the write masterkey function.
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
       cmdMkey.Enabled = True
       txtSTO.Enabled = True
       Text13.Enabled = True
       Text14.Enabled = True
       Text15.Enabled = True
       Text16.Enabled = True
       Text17.Enabled = True
       Text18.Enabled = True
       txtSTO.SetFocus
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


















Private Sub cmdMKey_Click()

Dim skey(0 To 5) As Byte
Dim STONum As Byte

'assign storage number to stonum variable
STONum = CByte(txtSTO.Text)


          'Put Keys in an array Variable (converted to decimal)
          skey(0) = Hex_Dec(Text13, 1)
          skey(1) = Hex_Dec(Text14, 1)
          skey(2) = Hex_Dec(Text15, 1)
          skey(3) = Hex_Dec(Text16, 1)
          skey(4) = Hex_Dec(Text17, 1)
          skey(5) = Hex_Dec(Text18, 1)
          
    'write master Key
    retcode = ACR120_WriteMasterKey(rHandle, STONum, skey(0))
     
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Write Master Key Error: " + CStr(retcode))
    Else
       List1.AddItem ("Write Master Key Success: " + CStr(retcode))
       
    End If

'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
End Sub







Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
End Sub

