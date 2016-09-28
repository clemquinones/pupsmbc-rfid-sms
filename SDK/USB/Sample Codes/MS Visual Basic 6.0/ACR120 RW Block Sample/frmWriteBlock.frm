VERSION 5.00
Begin VB.Form frmWriteBlock 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Write Block"
   ClientHeight    =   3870
   ClientLeft      =   5550
   ClientTop       =   5835
   ClientWidth     =   4710
   Icon            =   "frmWriteBlock.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3870
   ScaleWidth      =   4710
   Begin VB.PictureBox Picture1 
      Height          =   3615
      Left            =   120
      ScaleHeight     =   3555
      ScaleWidth      =   4395
      TabIndex        =   0
      Top             =   120
      Width           =   4455
      Begin VB.TextBox Text16 
         Alignment       =   2  'Center
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
         Left            =   2280
         MaxLength       =   2
         TabIndex        =   23
         Text            =   "FF"
         Top             =   3120
         Width           =   495
      End
      Begin VB.TextBox Text15 
         Alignment       =   2  'Center
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
         Left            =   1560
         MaxLength       =   2
         TabIndex        =   22
         Text            =   "FF"
         Top             =   3120
         Width           =   495
      End
      Begin VB.TextBox Text14 
         Alignment       =   2  'Center
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
         Left            =   840
         MaxLength       =   2
         TabIndex        =   21
         Text            =   "FF"
         Top             =   3120
         Width           =   495
      End
      Begin VB.TextBox Text13 
         Alignment       =   2  'Center
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
         Left            =   120
         MaxLength       =   2
         TabIndex        =   20
         Text            =   "FF"
         Top             =   3120
         Width           =   495
      End
      Begin VB.TextBox Text12 
         Alignment       =   2  'Center
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
         Left            =   3720
         MaxLength       =   2
         TabIndex        =   19
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text11 
         Alignment       =   2  'Center
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
         Left            =   3000
         MaxLength       =   2
         TabIndex        =   18
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text10 
         Alignment       =   2  'Center
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
         Left            =   2280
         MaxLength       =   2
         TabIndex        =   17
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text9 
         Alignment       =   2  'Center
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
         Left            =   1560
         MaxLength       =   2
         TabIndex        =   16
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text8 
         Alignment       =   2  'Center
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
         Left            =   840
         MaxLength       =   2
         TabIndex        =   15
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text7 
         Alignment       =   2  'Center
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
         Left            =   120
         MaxLength       =   2
         TabIndex        =   14
         Text            =   "FF"
         Top             =   2640
         Width           =   495
      End
      Begin VB.TextBox Text6 
         Alignment       =   2  'Center
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
         Left            =   3720
         MaxLength       =   2
         TabIndex        =   13
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.TextBox Text5 
         Alignment       =   2  'Center
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
         Left            =   3000
         MaxLength       =   2
         TabIndex        =   12
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.TextBox Text4 
         Alignment       =   2  'Center
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
         Left            =   2280
         MaxLength       =   2
         TabIndex        =   11
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.TextBox Text3 
         Alignment       =   2  'Center
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
         Left            =   1560
         MaxLength       =   2
         TabIndex        =   10
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.TextBox Text2 
         Alignment       =   2  'Center
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
         Left            =   840
         MaxLength       =   2
         TabIndex        =   9
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.CommandButton Command1 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
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
         Left            =   3000
         TabIndex        =   6
         Top             =   840
         Width           =   1215
      End
      Begin VB.CommandButton Command2 
         Caption         =   "OK"
         Default         =   -1  'True
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
         Left            =   3000
         TabIndex        =   5
         Top             =   360
         Width           =   1215
      End
      Begin VB.OptionButton optASC 
         Caption         =   "ASCII"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   600
         Width           =   2175
      End
      Begin VB.OptionButton optHEX 
         Caption         =   "HEXADECIMAL"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   2415
      End
      Begin VB.TextBox txtblock 
         Alignment       =   2  'Center
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
         MaxLength       =   2
         TabIndex        =   2
         Text            =   "0"
         Top             =   960
         Width           =   495
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
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
         Left            =   120
         MaxLength       =   2
         TabIndex        =   1
         Text            =   "FF"
         Top             =   2160
         Width           =   495
      End
      Begin VB.Label Label4 
         Caption         =   "(Hexadecimal)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   25
         Top             =   1800
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "(Decimal)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   24
         Top             =   1200
         Width           =   855
      End
      Begin VB.Label Label2 
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
         TabIndex        =   8
         Top             =   960
         Width           =   1695
      End
      Begin VB.Label Label3 
         Caption         =   "DATA TO WRITE"
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
         TabIndex        =   7
         Top             =   1560
         Width           =   1575
      End
   End
End
Attribute VB_Name = "frmWriteBlock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit




Private Sub Command1_Click()
    'cancel write operation
    frmMain.List1.AddItem ("Write Operation Cancelled....")

    
    'autoscroll listbox to the latest added item
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
    
End Sub






Private Sub Command2_Click()
Dim ctr As Integer
Dim BLCK As Byte
Dim dout(0 To 15) As Byte


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
   
   


If optHEX.value = True Then
   'if Hexadecimal was selected CONVERT hex to decimal
   dout(0) = Hex_Dec(Text1, 1)
   dout(1) = Hex_Dec(Text2, 1)
   dout(2) = Hex_Dec(Text3, 1)
   dout(3) = Hex_Dec(Text4, 1)
   dout(4) = Hex_Dec(Text5, 1)
   dout(5) = Hex_Dec(Text6, 1)
   dout(6) = Hex_Dec(Text7, 1)
   dout(7) = Hex_Dec(Text8, 1)
   dout(8) = Hex_Dec(Text9, 1)
   dout(9) = Hex_Dec(Text10, 1)
   dout(10) = Hex_Dec(Text11, 1)
   dout(11) = Hex_Dec(Text12, 1)
   dout(12) = Hex_Dec(Text13, 1)
   dout(13) = Hex_Dec(Text14, 1)
   dout(14) = Hex_Dec(Text15, 1)
   dout(15) = Hex_Dec(Text16, 1)
   
   
ElseIf optASC.value = True Then

    'if ASCII was selected convert character to decimal
   
   If Text1.Text <> "" Then
        dout(0) = Asc(Text1.Text)
   Else
        dout(0) = 0
   End If
   
   If Text2.Text <> "" Then
        dout(1) = Asc(Text2.Text)
   Else
        dout(1) = 0
   End If
   
   If Text3.Text <> "" Then
        dout(2) = Asc(Text3.Text)
   Else
        dout(2) = 0
   End If
   
   If Text4.Text <> "" Then
        dout(3) = Asc(Text4.Text)
   Else
        dout(3) = 0
   End If
   
   If Text5.Text <> "" Then
        dout(4) = Asc(Text5.Text)
   Else
        dout(4) = 0
   End If
   
   If Text6.Text <> "" Then
        dout(5) = Asc(Text6.Text)
   Else
        dout(5) = 0
   End If
   
   If Text7.Text <> "" Then
        dout(6) = Asc(Text7.Text)
   Else
        dout(6) = 0
   End If
   
   If Text8.Text <> "" Then
        dout(7) = Asc(Text8.Text)
   Else
        dout(7) = 0
   End If
   
   If Text9.Text <> "" Then
        dout(8) = Asc(Text9.Text)
   Else
        dout(8) = 0
   End If
   
   If Text10.Text <> "" Then
        dout(9) = Asc(Text10.Text)
   Else
        dout(9) = 0
   End If
   
   If Text11.Text <> "" Then
        dout(10) = Asc(Text11.Text)
   Else
        dout(10) = 0
   End If
   
   If Text12.Text <> "" Then
        dout(11) = Asc(Text12.Text)
   Else
        dout(11) = 0
   End If
   
   If Text13.Text <> "" Then
        dout(12) = Asc(Text13.Text)
   Else
        dout(12) = 0
   End If
   
   If Text14.Text <> "" Then
        dout(13) = Asc(Text14.Text)
   Else
        dout(13) = 0
   End If
   
   If Text15.Text <> "" Then
        dout(14) = Asc(Text15.Text)
   Else
        dout(14) = 0
   End If
   
   If Text16.Text <> "" Then
        dout(15) = Asc(Text16.Text)
   Else
        dout(15) = 0
   End If

   
End If


'execute ACR120 write, Write to Block
retcode = ACR120_Write(rHandle, BLCK, dout(0))

    'check if retcode was error
    If retcode < 0 Then
       frmMain.List1.AddItem (ErrDef(retcode))
    Else
       frmMain.List1.AddItem ("Write To Block " + CStr(BLCK) + " Success: " + CStr(retcode))
    End If

 
 'autoscroll listbox to the ltest entry
 frmMain.List1.ListIndex = frmMain.List1.NewIndex
 
 
 
 Unload Me
End Sub





Private Sub Form_Load()
'set default option
    optHEX.value = True
End Sub






Private Sub optASC_Click()
'set maxlenght to 2 for Ascii Entry
   Text1.MaxLength = 1
   Text2.MaxLength = 1
   Text3.MaxLength = 1
   Text4.MaxLength = 1
   Text5.MaxLength = 1
   Text6.MaxLength = 1
   Text7.MaxLength = 1
   Text8.MaxLength = 1
   Text9.MaxLength = 1
   Text10.MaxLength = 1
   Text11.MaxLength = 1
   Text12.MaxLength = 1
   Text13.MaxLength = 1
   Text14.MaxLength = 1
   Text15.MaxLength = 1
   Text16.MaxLength = 1
   
   
   Text1.Text = "*"
   Text2.Text = "*"
   Text3.Text = "*"
   Text4.Text = "*"
   Text5.Text = "*"
   Text6.Text = "*"
   Text7.Text = "*"
   Text8.Text = "*"
   Text9.Text = "*"
   Text10.Text = "*"
   Text11.Text = "*"
   Text12.Text = "*"
   Text13.Text = "*"
   Text14.Text = "*"
   Text15.Text = "*"
   Text16.Text = "*"
   
End Sub







Private Sub optHEX_Click()

'set maxlenght to 2 for Hex Entry
   Text1.MaxLength = 2
   Text2.MaxLength = 2
   Text3.MaxLength = 2
   Text4.MaxLength = 2
   Text5.MaxLength = 2
   Text6.MaxLength = 2
   Text7.MaxLength = 2
   Text8.MaxLength = 2
   Text9.MaxLength = 2
   Text10.MaxLength = 2
   Text11.MaxLength = 2
   Text12.MaxLength = 2
   Text13.MaxLength = 2
   Text14.MaxLength = 2
   Text15.MaxLength = 2
   Text16.MaxLength = 2
   
   Text1.Text = "FF"
   Text2.Text = "FF"
   Text3.Text = "FF"
   Text4.Text = "FF"
   Text5.Text = "FF"
   Text6.Text = "FF"
   Text7.Text = "FF"
   Text8.Text = "FF"
   Text9.Text = "FF"
   Text10.Text = "FF"
   Text11.Text = "FF"
   Text12.Text = "FF"
   Text13.Text = "FF"
   Text14.Text = "FF"
   Text15.Text = "FF"
   Text16.Text = "FF"
End Sub

