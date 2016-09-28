VERSION 5.00
Begin VB.Form frmReadBlock 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Read Block"
   ClientHeight    =   1935
   ClientLeft      =   5550
   ClientTop       =   6330
   ClientWidth     =   4710
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmReadBlock.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1935
   ScaleWidth      =   4710
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
      Height          =   1695
      Left            =   120
      ScaleHeight     =   1635
      ScaleWidth      =   4395
      TabIndex        =   0
      Top             =   120
      Width           =   4455
      Begin VB.CommandButton cmdCancel 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   375
         Left            =   3000
         TabIndex        =   6
         Top             =   840
         Width           =   1215
      End
      Begin VB.CommandButton cmdOK 
         Caption         =   "OK"
         Default         =   -1  'True
         Height          =   375
         Left            =   3000
         TabIndex        =   5
         Top             =   360
         Width           =   1215
      End
      Begin VB.OptionButton optASC 
         Caption         =   "READ AS ASCII"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   1200
         Width           =   2175
      End
      Begin VB.OptionButton optHex 
         Caption         =   "READ AS HEXADECIMAL"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   840
         Width           =   2415
      End
      Begin VB.TextBox txtblock 
         Alignment       =   2  'Center
         Height          =   285
         Left            =   1920
         MaxLength       =   2
         TabIndex        =   2
         Text            =   "0"
         Top             =   240
         Width           =   495
      End
      Begin VB.Label Label2 
         Caption         =   "(Decimal)"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   480
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
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   1695
      End
   End
End
Attribute VB_Name = "frmReadBlock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit



Private Sub cmdCancel_Click()
    
    'cancel Read operation
    frmMain.List1.AddItem ("Read Operation Cancelled....")
    
    
    'autoscroll listbox to the latest added item
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
    
End Sub








Private Sub cmdOK_Click()

Dim dataRead(0 To 15) As Byte
Dim dstr As String
Dim ctr As Integer
Dim BLCK As Byte

    
    
    'check block range if within the range of 0 to 3
    If CByte(txtblock.Text) < 0 Or CByte(txtblock.Text) > 3 And Sec <= 31 Then
       MsgBox "In the current Sector Block Ranges From 0 to 3 only", vbInformation, "Block Out of Range"
       txtblock.SetFocus
       Exit Sub
    Else
       'set block
       BLCK = CByte(txtblock.Text)
    End If
    
    
    
    'Computation for the exact block to Access....
    If Sec > 31 Then    'if sector more that 31
    
        BLCK = ((Sec - 32) * 16) + 128 + BLCK
        
    Else                'if sector less or equal to 31
    
        BLCK = Sec * 4 + BLCK
        
    End If
    
    
    'read specified block
    retcode = ACR120_Read(rHandle, BLCK, dataRead(0))
    
    
    'check if retcode is error
    If retcode < 0 Then
       frmMain.List1.AddItem (ErrDef(retcode))
    Else
       frmMain.List1.AddItem ("Read Block Success: " + CStr(retcode))
    End If
    
    
    
    
'convert bytes read to chosen option (e.g. AS HEX, AS ASCII)
    dstr = ""
        For ctr = 0 To 15
        
           If optHEX.value = True Then
                dstr = dstr + Format(Hex(dataRead(ctr)), "00") + " "
           ElseIf optASC.value = True Then
                dstr = dstr + Chr(dataRead(ctr))
           End If
           
        Next
            
            
    'display bytes read
    If optHEX.value = True Then
        frmMain.List1.AddItem ("Data Readed at block " + CStr(BLCK) + " Hex mode: " + dstr)
    ElseIf optASC.value = True Then
         frmMain.List1.AddItem ("Data Readed at block " + CStr(BLCK) + " Ascii mode: " + dstr)
    End If
    
    
    
    'auto scroll listbox to the latest entry
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
End Sub










Private Sub Form_Load()
    'set default option
    optHEX.value = True
End Sub

