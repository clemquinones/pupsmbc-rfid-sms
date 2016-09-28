VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Read/Write - EEPROM Sample"
   ClientHeight    =   5970
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
   ScaleHeight     =   5970
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
      Height          =   5655
      Left            =   120
      ScaleHeight     =   5595
      ScaleWidth      =   7875
      TabIndex        =   0
      Top             =   120
      Width           =   7935
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         Height          =   2295
         Left            =   4200
         TabIndex        =   6
         Top             =   3000
         Width           =   3375
         Begin VB.TextBox Text2 
            Alignment       =   1  'Right Justify
            Enabled         =   0   'False
            Height          =   285
            Left            =   2280
            TabIndex        =   14
            Text            =   "0"
            Top             =   840
            Width           =   735
         End
         Begin VB.TextBox Text1 
            Alignment       =   1  'Right Justify
            Enabled         =   0   'False
            Height          =   285
            Left            =   2280
            TabIndex        =   9
            Text            =   "0"
            Top             =   360
            Width           =   735
         End
         Begin VB.CommandButton cmdWriteEEPROM 
            Caption         =   "Write EEPROM"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1800
            TabIndex        =   8
            Top             =   1560
            Width           =   1335
         End
         Begin VB.CommandButton cmdReadEEPROM 
            Caption         =   "Read EEPROM"
            Enabled         =   0   'False
            Height          =   375
            Left            =   240
            TabIndex        =   7
            Top             =   1560
            Width           =   1335
         End
         Begin VB.Label Label1 
            Caption         =   "(Decimal)"
            Height          =   255
            Index           =   3
            Left            =   480
            TabIndex        =   13
            Top             =   1200
            Width           =   855
         End
         Begin VB.Label Label1 
            Caption         =   "(Decimal)"
            Height          =   255
            Index           =   2
            Left            =   480
            TabIndex        =   12
            Top             =   600
            Width           =   855
         End
         Begin VB.Label Label4 
            Caption         =   "Value To Write"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   0
            Left            =   480
            TabIndex        =   11
            Top             =   960
            Width           =   1215
         End
         Begin VB.Label Label3 
            Caption         =   "Register Number"
            Height          =   255
            Left            =   480
            TabIndex        =   10
            Top             =   360
            Width           =   1455
         End
      End
      Begin VB.ListBox List1 
         Height          =   2580
         ItemData        =   "Main.frx":030A
         Left            =   240
         List            =   "Main.frx":030C
         TabIndex        =   5
         Top             =   225
         Width           =   7335
      End
      Begin VB.Frame Frame1 
         Caption         =   "Connection"
         Height          =   2295
         Left            =   240
         TabIndex        =   1
         Top             =   3000
         Width           =   3735
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1185
            TabIndex        =   4
            Top             =   1035
            Width           =   1335
         End
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1200
            List            =   "Main.frx":032A
            TabIndex        =   2
            Text            =   "Port List"
            Top             =   600
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
            Left            =   1215
            TabIndex        =   3
            Top             =   360
            Width           =   840
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
'   Project Name :  ACR120RWEEPROM
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 9, 2005
'
'   Description  :  This Sample Reads and Writes to ACR120 Reader EEPROM.
'                   This also shows how to connect, Reset.
'
'   Initial Step :  1. Connect.
'                   2. Choose any from the functions.
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
       cmdWriteEEPROM.Enabled = True
       cmdReadEEPROM.Enabled = True
       Text1.Enabled = True
       Text2.Enabled = True
       
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


























Private Sub cmdReadEEPROM_Click()
Dim eePROMData As Byte
Dim reg As Byte
    
    'assign register number to Reg Variable
    reg = CByte(Text1.Text)
    
    'Read EEPROM
    retcode = ACR120_ReadEEPROM(rHandle, reg, eePROMData)
     
     
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Read EEPROM Error: " + CStr(retcode))
    Else
       List1.AddItem ("Read EEPROM Success: " + CStr(retcode))
       List1.AddItem ("Read EEPROM Value of Register " + CStr(reg) + " : 0x" + Format(Hex(eePROMData), "00"))
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
End Sub













Private Sub cmdReset_Click()
    
    'Reset Reader
    retcode = ACR120_Reset(rHandle)
     
    'Check if Retcode is Error
    If retcode < 0 Then
       List1.AddItem (ErrDef(retcode))
    Else
       List1.AddItem ("( i ) Reset Success")
       
    End If
    
    
    
      
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
    
End Sub












Private Sub cmdWriteEEPROM_Click()
Dim eePROMData As Byte
Dim reg As Byte
    
    'assign register number to Reg Variable
    reg = CByte(Text1.Text)
    
    'assign the value to write at the EEPROM
    eePROMData = CByte(Text2.Text)
    
    'Read EEPROM
    retcode = ACR120_WriteEEPROM(rHandle, reg, eePROMData)
     
     
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Write EEPROM Error: " + CStr(retcode))
    Else
       List1.AddItem ("Write EEPROM to Register " + CStr(reg) + " Success...")
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
End Sub













Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
End Sub




Private Function ToInteger(ByVal xKey As Integer) As Integer
    Select Case xKey
        Case 8
            ToInteger = xKey
        Case 13
            ToInteger = xKey
        Case Asc("0") To Asc("9")
            ToInteger = xKey
        'Case Asc("-")
        '    ToInteger = xKey
        Case Else
            ToInteger = 0
    End Select
End Function



Private Sub Text1_KeyPress(KeyAscii As Integer)
    KeyAscii = ToInteger(KeyAscii)
End Sub


