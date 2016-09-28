VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "MultiTag Select sample"
   ClientHeight    =   6630
   ClientLeft      =   45
   ClientTop       =   330
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
   MinButton       =   0   'False
   ScaleHeight     =   6630
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
      Height          =   6375
      Left            =   120
      ScaleHeight     =   6315
      ScaleWidth      =   7635
      TabIndex        =   18
      Top             =   120
      Width           =   7695
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         Height          =   3240
         Left            =   4200
         TabIndex        =   22
         Top             =   3000
         Width           =   3135
         Begin VB.TextBox Text17 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   2535
            MaxLength       =   2
            TabIndex        =   15
            Text            =   "FF"
            Top             =   2370
            Width           =   495
         End
         Begin VB.TextBox Text16 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1950
            MaxLength       =   2
            TabIndex        =   14
            Text            =   "FF"
            Top             =   2370
            Width           =   495
         End
         Begin VB.TextBox Text15 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1350
            MaxLength       =   2
            TabIndex        =   13
            Text            =   "FF"
            Top             =   2370
            Width           =   495
         End
         Begin VB.TextBox Text14 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   750
            MaxLength       =   2
            TabIndex        =   12
            Text            =   "FF"
            Top             =   2370
            Width           =   495
         End
         Begin VB.TextBox Text13 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   150
            MaxLength       =   2
            TabIndex        =   11
            Text            =   "FF"
            Top             =   2370
            Width           =   495
         End
         Begin VB.TextBox Text12 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   2535
            MaxLength       =   2
            TabIndex        =   10
            Text            =   "FF"
            Top             =   2055
            Width           =   495
         End
         Begin VB.OptionButton opt10 
            Caption         =   "10 Bytes Serial Number (HEX)"
            Enabled         =   0   'False
            Height          =   420
            Left            =   330
            TabIndex        =   5
            Top             =   1530
            Width           =   2475
         End
         Begin VB.OptionButton opt7 
            Caption         =   "7 Bytes Serial Number (HEX)"
            Enabled         =   0   'False
            Height          =   420
            Left            =   330
            TabIndex        =   4
            Top             =   1140
            Width           =   2400
         End
         Begin VB.OptionButton opt4 
            Caption         =   "4 Bytes Serial Number (HEX)"
            Enabled         =   0   'False
            Height          =   420
            Left            =   330
            TabIndex        =   3
            Top             =   765
            Width           =   2400
         End
         Begin VB.CommandButton cmdListTag 
            Caption         =   "List Tag"
            Enabled         =   0   'False
            Height          =   375
            Left            =   840
            TabIndex        =   2
            Top             =   300
            Width           =   1455
         End
         Begin VB.CommandButton cmdMulti 
            Caption         =   "Multi Tag Select"
            Enabled         =   0   'False
            Height          =   375
            Left            =   825
            TabIndex        =   16
            Top             =   2730
            Width           =   1455
         End
         Begin VB.TextBox Text8 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   150
            MaxLength       =   2
            TabIndex        =   6
            Text            =   "FF"
            Top             =   2055
            Width           =   495
         End
         Begin VB.TextBox Text9 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   765
            MaxLength       =   2
            TabIndex        =   7
            Text            =   "FF"
            Top             =   2055
            Width           =   495
         End
         Begin VB.TextBox Text10 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1350
            MaxLength       =   2
            TabIndex        =   8
            Text            =   "FF"
            Top             =   2055
            Width           =   495
         End
         Begin VB.TextBox Text11 
            Alignment       =   2  'Center
            Enabled         =   0   'False
            Height          =   285
            Left            =   1950
            MaxLength       =   2
            TabIndex        =   9
            Text            =   "FF"
            Top             =   2055
            Width           =   495
         End
         Begin VB.Label Label3 
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   495
            Left            =   360
            TabIndex        =   23
            Top             =   1080
            Width           =   1335
         End
      End
      Begin VB.ListBox List1 
         Height          =   2580
         ItemData        =   "Main.frx":030A
         Left            =   240
         List            =   "Main.frx":030C
         TabIndex        =   21
         Top             =   240
         Width           =   7095
      End
      Begin VB.Frame Frame1 
         Caption         =   "Connection"
         Height          =   3240
         Left            =   240
         TabIndex        =   19
         Top             =   3000
         Width           =   3735
         Begin VB.CommandButton cmdLogin 
            Caption         =   "Log-In"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1155
            TabIndex        =   17
            Top             =   2715
            Width           =   1335
         End
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1155
            TabIndex        =   1
            Top             =   1035
            Width           =   1335
         End
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1170
            List            =   "Main.frx":032A
            TabIndex        =   0
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
            Left            =   1170
            TabIndex        =   20
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
'==================================================================================================================
'
'   Project Name :  ACR120MultiTagSelect
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  September 12, 2005
'
'   Description  :  This Sample Select a specific Mifare Card, when there are more than
'                   one MiFare Card present within the readable range of ACR120 reader
'                   using the serial number of the card.
'                   You can see the serial number of the MiFare cards in range by using the
'                   ListTag command.
'                   This also shows how to connect and Login to card sector.
'
'   Initial Step :  1. Connect.
'                   2. Click ListTag to see cards serial number that's in readable range.
'                   3. Input card serial number you want to select then click MultiTagSelect.
'                   4. Login to card sector that you want to manipulate.
'
'
'==================================================================================================================

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
        
        cmdListTag.Enabled = True
       
       
    End If
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex

 
End Sub






Private Sub cmdListTag_Click()
Dim TagLength(0 To 50) As Byte
Dim TagFound As Byte
Dim TagType(0 To 50) As Byte
Dim SN(0 To 450) As Byte
Dim ctr As Integer
Dim ctr1 As Integer
Dim snstr As String


'Get List of Tags with/in readable Range
 retcode = ACR120_ListTags(rHandle, TagFound, TagType(0), TagLength(0), SN(0))


    'Check if Retcode is Error
    If retcode < 0 Then
       'Call Function to Define Error Code in string form.
       List1.AddItem (ErrDef(retcode))
    Else
       List1.AddItem ("List Tag Success: " + CStr(retcode))
       
       List1.AddItem ("Tag Found: " + CStr(TagFound))
       
       
    'Displays the Serial number of all the cards detected by the reader
    
       ctr1 = 0
       ctr = 0
       For ctr1 = 0 To (TagFound - 1)
             
           ctr = ctr1 * 10
       
                 
            snstr = ""
            For ctr = ctr To TagLength(ctr1) + ctr - 1
                snstr = snstr + A_BUGFIX(SN(ctr))
            Next
          
           
            List1.AddItem ("Tag(" + CStr(ctr1) + ") : " + snstr + "( " + GetTagType1(TagType(ctr1)) + " )")
            
             
             
             
       Next
       
       
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex


    opt4.Enabled = True
    opt7.Enabled = True
    opt10.Enabled = True
    cmdMulti.Enabled = True
    opt4.value = True
    

End Sub


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





Private Sub cmdLogin_Click()
    'show Login Form
    frmLogIn.Show vbModal, Me
End Sub













Private Sub cmdMulti_Click()
Dim SerialNum(0 To 9) As Byte
Dim TagLength As Byte
Dim RTag As Byte
Dim RSn(0 To 6) As Byte
Dim SN As String
Dim ctr As Integer
Dim TagType(0 To 50) As Byte
     
     
     If opt4.value = True Then 'Card Serial Number that is 4 bytes only.
        SerialNum(0) = Hex_Dec(Text8, 1)
        SerialNum(1) = Hex_Dec(Text9, 1)
        SerialNum(2) = Hex_Dec(Text10, 1)
        SerialNum(3) = Hex_Dec(Text11, 1)
        TagLength = 4
     ElseIf opt7.value = True Then 'Card Serial Number that is 7 bytes only.
        SerialNum(0) = Hex_Dec(Text8, 1)
        SerialNum(1) = Hex_Dec(Text9, 1)
        SerialNum(2) = Hex_Dec(Text10, 1)
        SerialNum(3) = Hex_Dec(Text11, 1)
        SerialNum(4) = Hex_Dec(Text12, 1)
        SerialNum(5) = Hex_Dec(Text13, 1)
        SerialNum(6) = Hex_Dec(Text14, 1)
        TagLength = 7
     ElseIf opt10.value = True Then 'Card Serial Number that is 10 bytes only.
        SerialNum(0) = Hex_Dec(Text8, 1)
        SerialNum(1) = Hex_Dec(Text9, 1)
        SerialNum(2) = Hex_Dec(Text10, 1)
        SerialNum(3) = Hex_Dec(Text11, 1)
        SerialNum(4) = Hex_Dec(Text12, 1)
        SerialNum(5) = Hex_Dec(Text13, 1)
        SerialNum(6) = Hex_Dec(Text14, 1)
        SerialNum(7) = Hex_Dec(Text15, 1)
        SerialNum(8) = Hex_Dec(Text16, 1)
        SerialNum(9) = Hex_Dec(Text17, 1)
        TagLength = 10
     End If
     
     'Select specific card based from serial number.
     retcode = ACR120_MultiTagSelect(rHandle, TagLength, SerialNum(0), TagType(0), RTag, RSn(0))
     
    'Check  if retcode is error.
     If retcode < 0 Then
       List1.AddItem ("Multi Tag Select Error: " + CStr(retcode))
     Else
       List1.AddItem ("Multi Tag Select Success: " + CStr(retcode))
     End If
     
     
        
      If TagType(0) = 4 Or TagType(0) = 5 Then
                SN = ""
                For ctr = 0 To 6
                    SN = SN + A_BUGFIX(RSn(ctr))
                Next
          Else
              
                SN = ""
                For ctr = 0 To TagLength - 1
                    SN = SN + A_BUGFIX(RSn(ctr))
                Next
        
          End If
        
        
     'Display serial number of card selected.
     List1.AddItem ("Serial Number Selected: " + SN + "( " + GetTagType1(TagType(0)) + " )")
    

     'Autoscroll to the latest entry.
     List1.ListIndex = List1.NewIndex
     cmdLogin.Enabled = True

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



Private Sub Form_Unload(Cancel As Integer)
    
    'Close connection to port.
    retcode = ACR120_Close(rHandle)
    
End Sub

Private Sub opt10_Click()

    opt4.value = False
    opt7.value = False
    opt10.value = True
    Text8.Enabled = True
    Text9.Enabled = True
    Text10.Enabled = True
    Text11.Enabled = True
    Text12.Enabled = True
    Text13.Enabled = True
    Text14.Enabled = True
    Text15.Enabled = True
    Text16.Enabled = True
    Text17.Enabled = True
    Text8.Text = "FF"
    Text9.Text = "FF"
    Text10.Text = "FF"
    Text11.Text = "FF"
    Text12.Text = "FF"
    Text13.Text = "FF"
    Text14.Text = "FF"
    Text15.Text = "FF"
    Text16.Text = "FF"
    Text17.Text = "FF"
    
End Sub

Private Sub opt4_Click()
    
    opt4.value = True
    opt7.value = False
    opt10.value = False
    Text8.Enabled = True
    Text9.Enabled = True
    Text10.Enabled = True
    Text11.Enabled = True
    Text12.Enabled = False
    Text13.Enabled = False
    Text14.Enabled = False
    Text15.Enabled = False
    Text16.Enabled = False
    Text17.Enabled = False
    Text8.Text = "FF"
    Text9.Text = "FF"
    Text10.Text = "FF"
    Text11.Text = "FF"
    Text12.Text = "FF"
    Text13.Text = "FF"
    Text14.Text = "FF"
    Text15.Text = "FF"
    Text16.Text = "FF"
    Text17.Text = "FF"
    
End Sub

Private Sub opt7_Click()
    
    opt4.value = False
    opt7.value = True
    opt10.value = False
    Text8.Enabled = True
    Text9.Enabled = True
    Text10.Enabled = True
    Text11.Enabled = True
    Text12.Enabled = True
    Text13.Enabled = True
    Text14.Enabled = True
    Text15.Enabled = False
    Text16.Enabled = False
    Text17.Enabled = False
    Text8.Text = "FF"
    Text9.Text = "FF"
    Text10.Text = "FF"
    Text11.Text = "FF"
    Text12.Text = "FF"
    Text13.Text = "FF"
    Text14.Text = "FF"
    Text15.Text = "FF"
    Text16.Text = "FF"
    Text17.Text = "FF"
    
End Sub
