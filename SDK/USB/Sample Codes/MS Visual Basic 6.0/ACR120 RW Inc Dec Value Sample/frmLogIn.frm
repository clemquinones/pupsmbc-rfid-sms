VERSION 5.00
Begin VB.Form frmLogIn 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Log-In"
   ClientHeight    =   2895
   ClientLeft      =   7755
   ClientTop       =   5745
   ClientWidth     =   4845
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmLogIn.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2895
   ScaleWidth      =   4845
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
      Height          =   2655
      Left            =   120
      ScaleHeight     =   2595
      ScaleWidth      =   4515
      TabIndex        =   0
      Top             =   120
      Width           =   4575
      Begin VB.CommandButton cmdCancel 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   375
         Left            =   3360
         TabIndex        =   14
         Top             =   2040
         Width           =   975
      End
      Begin VB.CommandButton cmdOK 
         Caption         =   "OK"
         Default         =   -1  'True
         Height          =   375
         Left            =   2280
         TabIndex        =   13
         Top             =   2040
         Width           =   975
      End
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   3840
         MaxLength       =   2
         TabIndex        =   12
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox Text5 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   3120
         MaxLength       =   2
         TabIndex        =   11
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox Text4 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   2400
         MaxLength       =   2
         TabIndex        =   10
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox Text3 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   1680
         MaxLength       =   2
         TabIndex        =   9
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   960
         MaxLength       =   2
         TabIndex        =   8
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   240
         MaxLength       =   2
         TabIndex        =   7
         Text            =   "FF"
         Top             =   1560
         Width           =   495
      End
      Begin VB.TextBox txtStoredNumber 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   3600
         MaxLength       =   2
         TabIndex        =   3
         Text            =   "30"
         Top             =   600
         Width           =   735
      End
      Begin VB.ComboBox Combo1 
         Height          =   330
         ItemData        =   "frmLogIn.frx":030A
         Left            =   240
         List            =   "frmLogIn.frx":0323
         TabIndex        =   2
         Top             =   600
         Width           =   1695
      End
      Begin VB.TextBox txtSector 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   2520
         MaxLength       =   2
         TabIndex        =   1
         Text            =   "3"
         Top             =   600
         Width           =   495
      End
      Begin VB.Label Label3 
         Caption         =   "Login Type"
         Height          =   255
         Left            =   240
         TabIndex        =   15
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label2 
         Caption         =   "KEY: (Hexadecimal)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   6
         Top             =   1080
         Width           =   1335
      End
      Begin VB.Label Label10 
         Caption         =   "Stored No. (Decimal)"
         Height          =   375
         Left            =   3600
         TabIndex        =   5
         Top             =   120
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Sector (Decimal)"
         Height          =   495
         Index           =   1
         Left            =   2520
         TabIndex        =   4
         Top             =   120
         Width           =   735
      End
   End
End
Attribute VB_Name = "frmLogIn"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit










Private Sub cmdCancel_Click()
    'cancel Login operation
    frmMain.List1.AddItem ("Login Cancelled....")

    
    'autoscroll listbox to the latest added item
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
    
End Sub















Private Sub cmdOK_Click()

Dim sto As Long
Dim LogType As Byte
Dim vKeyType As Byte
Dim PhysicalSector As Integer
Dim pKey(0 To 5) As Byte
     
   'Set LogType
   Select Case (Combo1.ListIndex)
      Case 0: vKeyType = ACR120_LOGIN_KEYTYPE_A
              
              'Log in using Keytype AA... User Key Input
              'Convert Hex keys to Decimal before storing in Pkey()
              
              pKey(0) = Hex_Dec(Text1, 1)
              pKey(1) = Hex_Dec(Text2, 1)
              pKey(2) = Hex_Dec(Text3, 1)
              pKey(3) = Hex_Dec(Text4, 1)
              pKey(4) = Hex_Dec(Text5, 1)
              pKey(5) = Hex_Dec(Text6, 1)
              
              
      Case 1: vKeyType = ACR120_LOGIN_KEYTYPE_B
      
              'Log in using Keytype BB... User Key Input
              'Convert Hex keys to Decimal before storing in Pkey()
              
              pKey(0) = Hex_Dec(Text1, 1)
              pKey(1) = Hex_Dec(Text2, 1)
              pKey(2) = Hex_Dec(Text3, 1)
              pKey(3) = Hex_Dec(Text4, 1)
              pKey(4) = Hex_Dec(Text5, 1)
              pKey(5) = Hex_Dec(Text6, 1)
               
      
      Case 2: vKeyType = ACR120_LOGIN_KEYTYPE_DEFAULT_A
              'Log in using the Transport Key which is FF FF FF FF FF FF
              pKey(0) = &HFF
              pKey(1) = &HFF
              pKey(2) = &HFF
              pKey(3) = &HFF
              pKey(4) = &HFF
              pKey(5) = &HFF
              
       Case 3: vKeyType = ACR120_LOGIN_KEYTYPE_DEFAULT_B
              'Log in using the Transport Key which is FF FF FF FF FF FF
              pKey(0) = &HFF
              pKey(1) = &HFF
              pKey(2) = &HFF
              pKey(3) = &HFF
              pKey(4) = &HFF
              pKey(5) = &HFF
              
       Case 4: vKeyType = ACR120_LOGIN_KEYTYPE_DEFAULT_F
              'Log in using the Transport Key which is FF FF FF FF FF FF
              pKey(0) = &HFF
              pKey(1) = &HFF
              pKey(2) = &HFF
              pKey(3) = &HFF
              pKey(4) = &HFF
              pKey(5) = &HFF
              
              
      Case 5: vKeyType = ACR120_LOGIN_KEYTYPE_STORED_A
              'Login using stored keys A from user specified Register in EEPROM
              sto = CLng(txtStoredNumber.Text)
      
      Case 6: vKeyType = ACR120_LOGIN_KEYTYPE_STORED_B
              'Login using stored keys B From user specified register in EEPROM
              sto = CLng(txtStoredNumber.Text)
              
      Case Else:
              MsgBox "Please Select Log-in Type", vbExclamation, "Log-In Fail"
              Exit Sub
   End Select
     
     
   'set sector
   Sec = CInt(txtSector.Text)
     
     
   If Sec > 39 Then
        MsgBox "Sector Out of Range. Please Enter value from 0-39 only", vbExclamation, "Log-In Fail"
        Exit Sub
    End If

    'Computation for obtaining the actual Physical Sector.
   If Sec > 31 Then
        Sec = CInt(txtSector.Text)
        PhysicalSector = Sec + ((Sec - 32) * 3)
   Else
        Sec = CInt(txtSector.Text)
        PhysicalSector = Sec
   End If
     
     
     
   'Log in
   retcode = ACR120_Login(rHandle, PhysicalSector, vKeyType, sto, pKey(0))
     
    'check if retcode is error
    If retcode < 0 Then
       frmMain.List1.AddItem (ErrDef(retcode))
       
    Else
       frmMain.List1.AddItem ("Login Success: " + CStr(retcode))
       frmMain.List1.AddItem ("Log at Logical Sector: " + CStr(Sec))
       frmMain.List1.AddItem ("Log at Physical Sector: " + CStr(PhysicalSector))
       frmMain.Command1.Enabled = True
       frmMain.Command2.Enabled = True
       Unload Me
    End If
    
    
    
    'autoscroll listbox to the latest added item
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
  
    Unload Me

End Sub












'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text1_KeyPress(KeyAscii As Integer)
      KeyAscii = KeyVerify(KeyAscii)
End Sub



Private Sub Text1_LostFocus()
    
    'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
    
End Sub




'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text2_KeyPress(KeyAscii As Integer)
KeyAscii = KeyVerify(KeyAscii)
End Sub




Private Sub Text2_LostFocus()
'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
End Sub



'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text3_KeyPress(KeyAscii As Integer)
KeyAscii = KeyVerify(KeyAscii)
End Sub



Private Sub Text3_LostFocus()
'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
End Sub



'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text4_KeyPress(KeyAscii As Integer)
KeyAscii = KeyVerify(KeyAscii)
End Sub



Private Sub Text4_LostFocus()
'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
End Sub



'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text5_KeyPress(KeyAscii As Integer)
KeyAscii = KeyVerify(KeyAscii)
End Sub



Private Sub Text5_LostFocus()
'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
End Sub



'=====================================================================
'   Key Press Filter: Accepts Only Hex Value
'=====================================================================

Private Sub Text6_KeyPress(KeyAscii As Integer)
KeyAscii = KeyVerify(KeyAscii)
End Sub



Private Sub Text6_LostFocus()
'return focus if character entered is < 2 or Null
    If Len(Text1.Text) < 2 Then
       Text1.SetFocus
    End If
End Sub












