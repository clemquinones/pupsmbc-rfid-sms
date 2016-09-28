VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "TxDataTelegram Sample"
   ClientHeight    =   6555
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7965
   BeginProperty Font 
      Name            =   "Arial Black"
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
   ScaleHeight     =   6555
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
      Height          =   6255
      Left            =   120
      ScaleHeight     =   6195
      ScaleWidth      =   7635
      TabIndex        =   0
      Top             =   120
      Width           =   7695
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   3045
         Left            =   4200
         TabIndex        =   5
         Top             =   3000
         Width           =   3150
         Begin VB.CommandButton cmdTxtDataTele 
            Caption         =   "TxDataTelegram"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   435
            Left            =   840
            TabIndex        =   7
            Top             =   1245
            Width           =   1515
         End
      End
      Begin VB.ListBox List1 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2580
         ItemData        =   "Main.frx":030A
         Left            =   240
         List            =   "Main.frx":030C
         TabIndex        =   4
         Top             =   240
         Width           =   7095
      End
      Begin VB.Frame Frame1 
         Caption         =   "Connection"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   3045
         Left            =   255
         TabIndex        =   1
         Top             =   2985
         Width           =   3735
         Begin VB.CommandButton cmdPowerOn 
            Caption         =   "Power On"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   1245
            TabIndex        =   11
            Top             =   2505
            Width           =   1335
         End
         Begin VB.CommandButton cmdPowerOff 
            Caption         =   "Power Off"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   1245
            TabIndex        =   10
            Top             =   2100
            Width           =   1335
         End
         Begin VB.CommandButton cmdReset 
            Caption         =   "Reset"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   1245
            TabIndex        =   9
            Top             =   1290
            Width           =   1335
         End
         Begin VB.ComboBox cmbPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1245
            List            =   "Main.frx":032A
            TabIndex        =   8
            Text            =   "Port List"
            Top             =   510
            Width           =   1335
         End
         Begin VB.CommandButton cmdSelect 
            Caption         =   "Select"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   1245
            TabIndex        =   6
            Top             =   1695
            Width           =   1335
         End
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   1245
            TabIndex        =   3
            Top             =   885
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
            Left            =   1245
            TabIndex        =   2
            Top             =   225
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
'=======================================================================================================================
'
'   Project Name :  ACR120TxDataTelegram
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  Sepetember 22, 2005
'
'   Description  :  This Sample Sends a Base/simple or ISO "t" Command.
'                   This also shows how to Connect, Reset, Select card, Power Off and Power On
'
'
'
'=========================================================================================================================
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
       
        cmdReset.Enabled = True
        cmdSelect.Enabled = True
        cmdPowerOn.Enabled = True
        cmdPowerOff.Enabled = True
        cmdTxtDataTele.Enabled = True
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
End Sub












































Private Sub cmdPowerOff_Click()
    
    retcode = ACR120_Power(rHandle, 0)
    
     'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
       
       List1.AddItem ("Antenna power turned OFF")
       
       
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
End Sub

Private Sub cmdPowerOn_Click()
    retcode = ACR120_Power(rHandle, 1)
    
     'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
       
       List1.AddItem ("Antenna power turned ON")
       
       
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
End Sub

Private Sub cmdReset_Click()
    
    'Reset Command
    retcode = ACR120_Reset(rHandle)
    
    
     'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
       
       List1.AddItem ("Reset Success!")
       
       
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
    
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
    
       List1.AddItem ("Select Success!")
       
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










Private Sub cmdTxtDataTele_Click()
    'show write block form
   frmTxDataTele.Show vbModal, Me
End Sub







Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
End Sub

