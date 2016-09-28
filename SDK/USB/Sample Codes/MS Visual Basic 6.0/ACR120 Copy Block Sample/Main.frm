VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Read/Write - Copy Block Value Sample"
   ClientHeight    =   6540
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8190
   Icon            =   "Main.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6540
   ScaleWidth      =   8190
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      Height          =   6255
      Left            =   120
      ScaleHeight     =   6195
      ScaleWidth      =   7875
      TabIndex        =   0
      Top             =   120
      Width           =   7935
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
         Height          =   2895
         Left            =   4200
         TabIndex        =   5
         Top             =   3000
         Width           =   3375
         Begin VB.CommandButton cmdCopy 
            Caption         =   "Copy"
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
            Left            =   1080
            TabIndex        =   12
            Top             =   2265
            Width           =   1335
         End
         Begin VB.TextBox Text1 
            Alignment       =   1  'Right Justify
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   285
            Left            =   480
            TabIndex        =   11
            Text            =   "0"
            Top             =   1785
            Width           =   855
         End
         Begin VB.TextBox Text2 
            Alignment       =   1  'Right Justify
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   285
            Left            =   1920
            TabIndex        =   10
            Text            =   "0"
            Top             =   1785
            Width           =   975
         End
         Begin VB.CommandButton Command2 
            Caption         =   "Write Value"
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
            Left            =   360
            TabIndex        =   8
            Top             =   480
            Width           =   1335
         End
         Begin VB.CommandButton Command1 
            Caption         =   "Read Value"
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
            Left            =   1800
            TabIndex        =   7
            Top             =   480
            Width           =   1335
         End
         Begin VB.Label Label3 
            Caption         =   "From Block (Decimal)"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   495
            Left            =   480
            TabIndex        =   14
            Top             =   1305
            Width           =   975
         End
         Begin VB.Label Label4 
            Caption         =   "To Block (Decimal)"
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
            Left            =   1920
            TabIndex        =   13
            Top             =   1305
            Width           =   855
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
         Width           =   7335
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
         Height          =   2895
         Left            =   240
         TabIndex        =   1
         Top             =   3000
         Width           =   3735
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
            Left            =   1290
            List            =   "Main.frx":032A
            TabIndex        =   15
            Text            =   "Port List"
            Top             =   645
            Width           =   1335
         End
         Begin VB.CommandButton cmdLogin 
            Caption         =   "Log-In"
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
            Left            =   1275
            TabIndex        =   9
            Top             =   2340
            Width           =   1335
         End
         Begin VB.CommandButton cmdSelect 
            Caption         =   "Select"
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
            Left            =   1275
            TabIndex        =   6
            Top             =   1905
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
            Left            =   1275
            TabIndex        =   3
            Top             =   1035
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
            Left            =   1305
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
'   Project Name :  ACR120CopyBlock
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 14, 2004
'
'   Description  :  This sample Copy the Value of One Block to the Other within the same
'                   Sector. This Sample also Reads and Writes a Value Block in MiFare Card.
'                   This also shows how to Connect,Select card, and Login to card sector.
'
'   Initial Step :  1. Connect.
'                   2. Select "Make sure that only 1 card is within antenna range".
'                   3. Login to card sector that you want to manipulate.
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






















Private Sub cmdCopy_Click()
Dim NewVal As Long
Dim FB1 As Byte
Dim FB2 As Byte


Text1.Text = Right("00" & Text1.Text, 2)
Text2.Text = Right("00" & Text2.Text, 2)


'check block range if within the range of 0 to 3
    If CByte("&H" & Text1.Text) < 0 Or CByte("&H" & Text1.Text) > 3 And Sec <= 31 Then
       MsgBox "In the current Sector Block Ranges From 0 to 3 only", vbInformation, "Block Out of Range"
       Text1.SetFocus
       
       Exit Sub
    Else
       'set block
       FB1 = CByte("&H" & Text1.Text)
    End If
       
    
    
    'To access the exact block on the card you must Multiply Sector where you Login by 4
    'and add the Block.
    If Sec > 31 Then
        FB1 = ((Sec - 32) * 16) + 128 + FB1
    Else
        FB1 = Sec * 4 + FB1
    End If





'check block range if within the range of 0 to 3
    If CByte("&H" & Text2.Text) < 0 Or CByte("&H" & Text2.Text) > 3 And Sec <= 31 Then
       MsgBox "In the current Sector Block Ranges From 0 to 3 only", vbInformation, "Block Out of Range"
       
       Text2.SetFocus
       Exit Sub
    Else
       'set block
       FB2 = CByte("&H" & Text2.Text)
    End If
    
    
    'To access the exact block on the card you must Multiply Sector where you Login by 4
    'and add the Block.
     If Sec > 31 Then
        FB2 = ((Sec - 32) * 16) + 128 + FB2
    Else
        FB2 = Sec * 4 + FB2
    End If


    'copy Block from FB1 to Block FB2
    retcode = ACR120_Copy(rHandle, FB1, FB2, NewVal)

    'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
       List1.AddItem ("Copy From Block " + CStr(FB1) + " To " + CStr(FB2) + " Success")
       List1.AddItem ("New Value: " + CStr(NewVal))
    End If
    
    
     'auto scroll listbox to the latest Entry
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











Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
End Sub

