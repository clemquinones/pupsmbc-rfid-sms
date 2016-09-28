VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Status Sample"
   ClientHeight    =   6075
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7965
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
   ScaleHeight     =   6075
   ScaleWidth      =   7965
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
      Height          =   5775
      Left            =   120
      ScaleHeight     =   5715
      ScaleWidth      =   7635
      TabIndex        =   0
      Top             =   120
      Width           =   7695
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         Height          =   2415
         Left            =   4200
         TabIndex        =   6
         Top             =   3000
         Width           =   3135
         Begin VB.CommandButton cmdStatus 
            Caption         =   "Status"
            Height          =   375
            Left            =   930
            TabIndex        =   7
            Top             =   1080
            Width           =   1335
         End
      End
      Begin VB.ListBox List1 
         Height          =   2580
         ItemData        =   "Main.frx":030A
         Left            =   240
         List            =   "Main.frx":030C
         TabIndex        =   5
         Top             =   240
         Width           =   7095
      End
      Begin VB.Frame Frame1 
         Caption         =   "Connection"
         Height          =   2415
         Left            =   240
         TabIndex        =   1
         Top             =   3000
         Width           =   3735
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1140
            TabIndex        =   4
            Top             =   1080
            Width           =   1335
         End
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1170
            List            =   "Main.frx":032A
            TabIndex        =   2
            Text            =   "Port List"
            Top             =   570
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
            Left            =   1170
            TabIndex        =   3
            Top             =   330
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
'   Project Name :  ACR120UStatus
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 21, 2005
'
'   Description  :  This Sample Pragram that shows the STATUS of the Reader
'
'
'   Initial Step :  1. Connect.
'                   2. Status
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
       cmdStatus.Enabled = True
       
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






Private Sub cmdStatus_Click()
Dim FirmwareVer1(0 To 19) As Byte
Dim ReaderStat As tReaderStatus
Dim FirmStr As String
Dim ctr As Integer
Dim SCardSwitch As String
Dim HexB1 As String
Dim HexB2 As String
Dim HexB3 As String
Dim HexB4 As String

    
    retcode = ACR120_Status(rHandle, FirmwareVer1(0), ReaderStat)
    
    
    'Check if Handle is Valid
    If rHandle < 0 Then
       List1.AddItem (ErrDef(rHandle))
    Else
       FirmStr = ""
          
        For ctr = 0 To 19
            If FirmwareVer1(ctr) <> 0 And FirmwareVer1(ctr) <> &HFF Then
                FirmStr = FirmStr + Chr(FirmwareVer1(ctr))
            End If
        Next
       
       
       If FirmStr <> "" Then
         
         List1.AddItem ("Firmware Version  : " + FirmStr)
         
         HexB1 = ""
         HexB2 = ""
         HexB3 = ""
         HexB4 = ""
         
         SCardSwitch = ""
         
         
         HexB1 = A_BUGFIX(ReaderStat.CardsSupported(0))
         HexB2 = A_BUGFIX(ReaderStat.CardsSupported(1))
         HexB3 = A_BUGFIX(ReaderStat.CardsSupported(2))
         HexB4 = A_BUGFIX(ReaderStat.CardsSupported(3))
         
         
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB4, 1, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB4, 2, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB3, 1, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB3, 2, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB2, 1, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB2, 2, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB1, 1, 1))
         SCardSwitch = SCardSwitch + HEX_2_BIN(Mid(HexB1, 2, 1))
         
         
         
         List1.AddItem ("Cards Supported  : " & HexB4 & HexB3 & HexB2 & HexB1)
         
         '// Bit 0 = Mifare Light; Bit 1 = Mifare1K; Bit 2 = Mifare 4K; Bit 3 = Mifare DESFire
         '// Bit 4 = Mifare UltraLight; Bit 5 = JCOP30; Bit 6 = Shanghai Transport
         '// Bit 7 = MPCOS Combi; Bit 8 = ISO type B, Calypso
         '// Bit 9 - Bit 31 = To be defined
         
         If Mid(SCardSwitch, 32, 1) = "1" Then
             List1.AddItem (">> Mifare Light ")
             
         End If
         
         If Mid(SCardSwitch, 31, 1) = "1" Then
             List1.AddItem (">> Mifare1K ")
             
         End If
         
         If Mid(SCardSwitch, 30, 1) = "1" Then
             List1.AddItem (">> Mifare 4K ")
             
         End If
         
         If Mid(SCardSwitch, 29, 1) = "1" Then
             List1.AddItem (">> Mifare DESFire ")
             
         End If
         
         If Mid(SCardSwitch, 28, 1) = "1" Then
             List1.AddItem (">> Mifare UltraLight ")
             
         End If
         
         If Mid(SCardSwitch, 27, 1) = "1" Then
             List1.AddItem (">> JCOP30 ")
             
         End If
         
         If Mid(SCardSwitch, 26, 1) = "1" Then
             List1.AddItem (">> Shanghai Transport ")
             
         End If
         
         If Mid(SCardSwitch, 25, 1) = "1" Then
             List1.AddItem (">> MPCOS Combi ")
             
         End If
         
         
         If Mid(SCardSwitch, 24, 1) = "1" Then
             List1.AddItem (">> ISO type B, Calypso ")
             
         End If
         
        
         List1.AddItem ("Contactless Interface Type : " & GetInterfaceType(ReaderStat.MifareInterfaceType))
         
         '====Not yet implemented======
         'List1.AddItem ("CardOpMode : " & GetCardOpMode(ReaderStat.CardOpMode) & "TAG is being processed")
         
        End If
       
       
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex

End Sub





Public Function GetInterfaceType(ByVal x As Byte) As String

    'Get the type of card supported
    
    If x = 1 Then
        GetInterfaceType = "Type A"
    ElseIf x = 2 Then
        GetInterfaceType = "Type B"
    ElseIf x = 3 Then
        GetInterfaceType = "Type A + Type B"
    End If


End Function





Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)

End Sub

