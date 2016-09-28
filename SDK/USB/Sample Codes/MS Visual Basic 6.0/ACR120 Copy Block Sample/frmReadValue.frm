VERSION 5.00
Begin VB.Form frmReadValue 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Read Value"
   ClientHeight    =   1935
   ClientLeft      =   5550
   ClientTop       =   6330
   ClientWidth     =   3255
   Icon            =   "frmReadValue.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1935
   ScaleWidth      =   3255
   StartUpPosition =   1  'CenterOwner
   Begin VB.PictureBox Picture1 
      Height          =   1695
      Left            =   120
      ScaleHeight     =   1635
      ScaleWidth      =   2955
      TabIndex        =   0
      Top             =   120
      Width           =   3015
      Begin VB.CommandButton cmdCancel 
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
         Left            =   1560
         TabIndex        =   4
         Top             =   840
         Width           =   1215
      End
      Begin VB.CommandButton cmdOK 
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
         Left            =   240
         TabIndex        =   3
         Top             =   840
         Width           =   1215
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
         Left            =   2040
         MaxLength       =   2
         TabIndex        =   2
         Text            =   "0"
         Top             =   240
         Width           =   495
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
         Index           =   1
         Left            =   360
         TabIndex        =   5
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
         Index           =   0
         Left            =   360
         TabIndex        =   1
         Top             =   240
         Width           =   1695
      End
   End
End
Attribute VB_Name = "frmReadValue"
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
    If Sec > 31 Then
        Blck = ((Sec - 32) * 16) + 128 + Blck
    Else
        Blck = Sec * 4 + Blck
    End If
    
    


    'read specified Value block
    retcode = ACR120_ReadValue(rHandle, Blck, pVal)
    
    
    'check if retcode is error
    If retcode < 0 Then
       frmMain.List1.AddItem (ErrDef(retcode))
       'frmMain.List1.AddItem ("Read Value Block Success: " + CStr(retcode))
    Else
       frmMain.List1.AddItem ("Read Value Block Success: " + CStr(retcode))
       frmMain.List1.AddItem ("Read Value at Block " + CStr(Blck) + " : " + CStr(pVal))
    End If
    
    
    'auto scroll listbox to the latest entry
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
End Sub










