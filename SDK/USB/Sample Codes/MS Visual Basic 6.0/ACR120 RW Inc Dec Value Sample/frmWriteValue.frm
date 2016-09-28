VERSION 5.00
Begin VB.Form frmWriteValue 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Write Value"
   ClientHeight    =   1740
   ClientLeft      =   5550
   ClientTop       =   5835
   ClientWidth     =   5580
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmWriteValue.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1740
   ScaleWidth      =   5580
   StartUpPosition =   1  'CenterOwner
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
      Height          =   1455
      Left            =   120
      ScaleHeight     =   1395
      ScaleWidth      =   5235
      TabIndex        =   0
      Top             =   120
      Width           =   5295
      Begin VB.CommandButton Command1 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   375
         Left            =   3840
         TabIndex        =   4
         Top             =   720
         Width           =   1215
      End
      Begin VB.CommandButton Command2 
         Caption         =   "OK"
         Default         =   -1  'True
         Height          =   375
         Left            =   3840
         TabIndex        =   3
         Top             =   240
         Width           =   1215
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
      Begin VB.TextBox Text1 
         Alignment       =   1  'Right Justify
         Height          =   285
         Left            =   1920
         MaxLength       =   9
         TabIndex        =   1
         Text            =   "0"
         Top             =   840
         Width           =   1575
      End
      Begin VB.Label Label1 
         Caption         =   "(Decimal)"
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
         Index           =   1
         Left            =   240
         TabIndex        =   8
         Top             =   480
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "(Decimal)"
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
         Left            =   240
         TabIndex        =   7
         Top             =   1080
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
         Left            =   240
         TabIndex        =   6
         Top             =   240
         Width           =   1695
      End
      Begin VB.Label Label3 
         Caption         =   "Value To Write    :"
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
         Left            =   240
         TabIndex        =   5
         Top             =   920
         Width           =   1695
      End
   End
End
Attribute VB_Name = "frmWriteValue"
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
Dim pVal As Long
Dim Blck As Byte



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
    If Sec > 31 Then    'if sector more that 31
    
        Blck = ((Sec - 32) * 16) + 128 + Blck
        
    Else                'if sector less or equal to 31
    
        Blck = Sec * 4 + Blck
        
    End If
    
   


    'Pass to a variable the inputed data.
    pVal = CLng(Text1.Text)


    'Write value
    retcode = ACR120_WriteValue(rHandle, Blck, pVal)

    'check if retcode was error
    If retcode < 0 Then
       frmMain.List1.AddItem (ErrDef(retcode))
    Else
       frmMain.List1.AddItem ("Write To Block " + CStr(Blck) + " Success: " + CStr(retcode))
       frmMain.List1.AddItem ("Written Value at Block " + CStr(Blck) + " : " + CStr(pVal))
       
    End If

 
    'autoscroll listbox to the latest entry
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
 
 
 
    Unload Me
End Sub











