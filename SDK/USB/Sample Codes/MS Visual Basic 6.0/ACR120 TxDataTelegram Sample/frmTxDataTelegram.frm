VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmTxDataTele 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  TxData Telegram"
   ClientHeight    =   2970
   ClientLeft      =   5415
   ClientTop       =   7830
   ClientWidth     =   9120
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmTxDataTelegram.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2970
   ScaleWidth      =   9120
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   6495
      TabIndex        =   5
      Top             =   2490
      Width           =   1215
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   7800
      TabIndex        =   6
      Top             =   2490
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2370
      Left            =   150
      TabIndex        =   0
      Top             =   30
      Width           =   8865
      Begin VB.TextBox txtLength 
         Alignment       =   2  'Center
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   330
         Left            =   930
         MaxLength       =   2
         TabIndex        =   1
         Top             =   255
         Width           =   765
      End
      Begin VB.TextBox txtRecNo 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1740
         MaxLength       =   2
         TabIndex        =   3
         Top             =   5625
         Visible         =   0   'False
         Width           =   765
      End
      Begin VB.TextBox txtDatain 
         Alignment       =   2  'Center
         BorderStyle     =   0  'None
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   2625
         MaxLength       =   2
         TabIndex        =   2
         Top             =   1230
         Visible         =   0   'False
         Width           =   840
      End
      Begin MSFlexGridLib.MSFlexGrid grdBody 
         Height          =   1365
         Left            =   255
         TabIndex        =   4
         Top             =   780
         Width           =   7935
         _ExtentX        =   13996
         _ExtentY        =   2408
         _Version        =   393216
         Rows            =   17
         Cols            =   17
         BackColorFixed  =   14737632
         ForeColorFixed  =   8421504
         BackColorBkg    =   -2147483633
         GridColorFixed  =   12632256
         AllowBigSelection=   0   'False
         HighLight       =   2
         GridLinesFixed  =   1
         BorderStyle     =   0
         Appearance      =   0
         FormatString    =   "|^+00|^+01|^+02|^+03|^+04|^+05|^+06|^+07|^+08|^+09|^+0A|^+0B|^+0C|^+0D|^+0E|^+0F;|00|10|20|30|40|50|60|70|80|90|A0|B0|C0|D0|E0|F0"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "Length"
         Height          =   210
         Left            =   255
         TabIndex        =   8
         Top             =   390
         Width           =   495
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Record No."
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   570
         TabIndex        =   7
         Top             =   5700
         Visible         =   0   'False
         Width           =   1140
      End
      Begin VB.Shape Shape1 
         BorderColor     =   &H00C0C0C0&
         BorderWidth     =   3
         Height          =   1365
         Left            =   240
         Top             =   780
         Width           =   7950
      End
   End
End
Attribute VB_Name = "frmTxDataTele"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private m_RecNo As Byte
Private m_Length As Byte
Private m_PINID As Long

Private m_Data As Collection
Public Cancel As Boolean


Dim aDES_data() As Byte
Dim aKEY_data() As Byte


Private Sub Form_Load()
    Dim i As Integer
    With grdBody
        .FormatString = "|^+00|^+01|^+02|^+03|^+04|^+05|^+06|^+07|^+08|^+09|^+0A|^+0B|^+0C|^+0D|^+0E|^+0F;|00|10|20|30|40|50|60|70|80|90|A0|B0|C0|D0|E0|F0"
        For i = 1 To 10
            .ColWidth(i) = 517
            .RowHeight(i) = 280
        Next i
    End With
    Set m_Data = New Collection
    
    
  
End Sub

Private Sub cmdCancel_Click()
    'cancel Txt Data Telegram operation
    frmMain.List1.AddItem ("ACR120_TxDataTelegram Canceled....")
    
    'Auto Scroll List Box to the latest Entry
    frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    Unload Me
End Sub

Private Sub cmdOK_Click()
   

    If txtLength.Text = "" Then
        txtLength.Text = "00"
    End If
    
    
    frmMain.List1.AddItem ("< Send Data Length: " & txtLength.Text)
    
    
    'autoscroll listbox to the latest added item
     frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
    
    
    
    m_Length = CByte("&h" & txtLength.Text)
  
    Set m_Data = New Collection
    If m_Length <> 0 Then
        Dim i As Integer
        Dim j As Integer
        For i = 0 To &HF
            For j = 0 To &HF
                If grdBody.TextMatrix(i + 1, j + 1) = "" Then
                    grdBody.TextMatrix(i + 1, j + 1) = "00"
                End If
                m_Data.Add grdBody.TextMatrix(i + 1, j + 1)
                If m_Length = (i * &H10 + j) + 1 Then
                    j = j + 1
                    Exit For
                End If
            Next j
            j = j - 1
            If m_Length = (i * &H10 + j) + 1 Then
                Exit For
            End If
        Next i
        
        
        
        Dim ctr As Integer
        Dim DataBuff() As Byte
        Dim pRD(0 To 255) As Byte
        Dim pRDL As Byte
        
        
        ReDim DataBuff(0 To m_Length - 1) As Byte
        Dim strBufTemp As String
        Dim ctr16 As Byte
        strBufTemp = ""
        
        strBufTemp = "<< Data: "
        
        ctr16 = 1
    
        For ctr = 0 To m_Length - 1
              DataBuff(ctr) = CInt("&H" & m_Data(ctr + 1))
              
              If ctr16 = 16 Then
                    frmMain.List1.AddItem (strBufTemp)
                    frmMain.List1.ListIndex = frmMain.List1.NewIndex
                    strBufTemp = ""
                    ctr16 = 1
              Else
                strBufTemp = strBufTemp + m_Data(ctr + 1) + " "
                ctr16 = ctr16 + 1
              End If
              
              
        Next
        
        
        If ctr16 < 16 Then
            frmMain.List1.AddItem (strBufTemp)
            frmMain.List1.ListIndex = frmMain.List1.NewIndex
        End If
        
        
        'Issue the Command.
        retcode = ACR120_TxDataTelegram(rHandle, m_Length, DataBuff(0), pRDL, pRD(0))
        
        
        
        'Check if retcode is error
        If retcode < 0 Then
       
            frmMain.List1.AddItem (ErrDef(retcode))
            'autoscroll listbox to the latest entry
            frmMain.List1.ListIndex = frmMain.List1.NewIndex
    
            Unload Me
            Exit Sub
        Else
    
            frmMain.List1.AddItem ("TxDataTelegram Success: " + CStr(retcode))
            strBufTemp = "> Response Data Length: " & A_BUGFIX(pRDL) + Chr(13) + Chr(10)
            frmMain.List1.AddItem (strBufTemp)
            
            'autoscroll listbox to the latest entry
            frmMain.List1.ListIndex = frmMain.List1.NewIndex
       
            If pRDL > 0 Then
        
                strBufTemp = ">> Data: "
        
                ctr16 = 0
    
                For ctr = 0 To pRDL - 1
              
              
                  If ctr16 = 16 Then
                      frmMain.List1.AddItem (strBufTemp)
                      frmMain.List1.ListIndex = frmMain.List1.NewIndex
                      strBufTemp = ""
                      strBufTemp = "                  "
                      ctr16 = 0
                  End If
                
                  strBufTemp = strBufTemp + A_BUGFIX(pRD(ctr)) + " "
                  ctr16 = ctr16 + 1
                
              
                Next
        
        
                If ctr16 < 16 Then
            
                frmMain.List1.AddItem (strBufTemp)
                frmMain.List1.ListIndex = frmMain.List1.NewIndex
                    
                End If
      
      
      
            End If
       
        End If
    
    End If
    
    Cancel = False
    Hide
    
End Sub


Public Sub txtKeyPress(KeyAscii As Integer)
Dim i As Integer
Dim Char1

Char1 = Chr(KeyAscii)

i = KeyAscii
If (Asc(Mid(UCase(Char1), 1, 1)) >= 48 And Asc(Mid(UCase(Char1), 1, 1)) <= 57) Or (Asc(Mid(UCase(Char1), 1, 1)) >= 65 And Asc(Mid(UCase(Char1), 1, 1)) <= 70) Then
    KeyAscii = Asc(UCase(Char1))
Else
    If i = 8 Then
        KeyAscii = 8
    ElseIf i = Asc(vbTab) Then
        KeyAscii = vbTab
    Else
    KeyAscii = 0
    End If
    
End If

End Sub



Private Sub txtLength_KeyPress(KeyAscii As Integer)
    If KeyAscii = vbKeyReturn Then
        KeyAscii = 0
        If Len(txtLength.Text) = 2 Then
            txtLength_Validate False
        End If
    End If
    txtKeyPress KeyAscii
End Sub

Private Sub txtLength_KeyUp(KeyCode As Integer, Shift As Integer)
    If Len(txtLength.Text) = 2 Then
        txtLength_Validate False
        grdBody.SetFocus
    End If
End Sub

Private Sub txtLength_LostFocus()
    txtLength.Text = Right("00" & txtLength.Text, 2)
End Sub

Private Sub txtLength_Validate(Cancel As Boolean)
    Dim i As Integer
    If Len(txtLength.Text) = 1 Then
        txtLength = "0" & txtLength
    End If
   
    ClearGrid grdBody
       
   If Len(txtLength.Text) = 2 Then
       
        
        If txtLength.Text = "00" Then Exit Sub
        Dim Dataout() As Byte
        
        Dim j As Integer
        Dim iDataLen As Integer
        Dim iColCount As Integer
        Dim iRowCount As Integer
        Dim iData(0 To &HF, 0 To &HF) As Byte
        
        iDataLen = CInt("&H" & txtLength)
        ReDim Dataout(0 To iDataLen)
        For i = 0 To iDataLen
            Dataout(i) = 0
        Next i
        Dim iRow As Integer
        Dim iCol As Integer
        iRow = (iDataLen) \ &H10
        iCol = (iDataLen) Mod &H10
        
        For i = 0 To &HF
            For j = 0 To &HF
                If iRow = i And iCol = j Then
                    Exit For
                End If
                iData(i, j) = Dataout(((&HF * i) + j))
            Next j
            If iRow = i And iCol = j Then
                Exit For
            End If
        Next i
        
   
        For i = 0 To &HF
            For j = 0 To &HF
                If iRow = i And iCol = j Then
                    Exit For
                End If
                DoEvents
                With grdBody
                    .Row = i + 1
                    .Col = j + 1
                    .Text = Right("00" & Hex(iData(i, j)), 2)
                End With
            Next j
            If iRow = i And iCol = j Then
                Exit For
            End If
        Next i
        grdBody.Row = 1
        grdBody.Col = 1
   End If
   
End Sub
Public Sub ClearGrid(grdControl As MSFlexGrid)
    Dim i As Integer
    Dim j As Integer
    With grdControl
        For i = 1 To &H10
            For j = 1 To &H10
                If .TextMatrix(i, j) <> "" Then
                    .TextMatrix(i, j) = ""
                End If
                If j >= grdControl.Cols Then
                    Exit For
                End If
            Next j
            If i >= grdControl.Rows Then
                Exit For
            End If
        Next i
    End With
End Sub

Public Property Get RecNo() As Byte
    RecNo = m_RecNo
End Property

Public Property Let RecNo(ByVal vNewValue As Byte)
    m_RecNo = vNewValue
End Property

Public Property Get Length() As Byte
    Length = m_Length
End Property

Public Property Let Length(ByVal vNewValue As Byte)
    m_Length = vNewValue
End Property


Public Property Get PINID() As Byte
    PINID = m_PINID
End Property

Public Property Let PINID(ByVal vNewValue As Byte)
    m_PINID = vNewValue
End Property


Public Property Get Data() As Collection
    Set Data = m_Data
End Property

Public Property Let Data(ByVal vNewValue As Collection)
    Set m_Data = vNewValue
End Property

Public Sub GridEdit(KeyAscii As Integer, txtEdit As TextBox, grdInput As MSFlexGrid)
   'use correct font
   txtEdit.FontName = grdInput.FontName
   txtEdit.FontSize = grdInput.FontSize
   Select Case KeyAscii
      Case 0 To Asc(" ")
         txtEdit = grdInput
         txtEdit.SelStart = 1000
      Case Else
         txtKeyPress KeyAscii
         txtEdit = Chr(KeyAscii)
         txtEdit.SelStart = 1
    
   End Select
   
    'position the edit box
    With txtEdit
        .Left = grdInput.CellLeft + grdInput.Left
        .Top = grdInput.CellTop + grdInput.Top
        .Width = grdInput.CellWidth
        .Height = grdInput.CellHeight - 10
        .Visible = True
        
        .SetFocus
    End With
End Sub


Private Sub grdBody_DblClick()
    GridEdit Asc(" "), txtDatain, grdBody
End Sub

Private Sub grdBody_Scroll()
    Call grdBody_LeaveCell
    grdBody.SetFocus
End Sub
Private Sub grdBody_GotFocus()
   If txtDatain.Visible Then
      grdBody = txtDatain
      txtDatain.Visible = False
   End If
End Sub
Private Sub grdBody_KeyPress(KeyAscii As Integer)
    GridEdit KeyAscii, txtDatain, grdBody
End Sub

Private Sub grdBody_LeaveCell()
   If txtDatain.Visible Then
      If Len(txtDatain) = 1 Then
        txtDatain = "0" & txtDatain
      End If
      grdBody = txtDatain
      txtDatain.Visible = False
   End If
End Sub

Public Sub txtKeyDown(KeyCode As Integer, txtInput As TextBox, grdInput As MSFlexGrid)
    Select Case KeyCode
        Case vbKeyTab
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
        Case vbKeyEscape
            txtInput.Visible = False
            grdInput.SetFocus
        Case vbKeyReturn
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
            grdInput.SetFocus
      Case vbKeyLeft
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
            grdInput.SetFocus
            DoEvents
            If grdInput.Col < grdInput.Cols - 1 Then
                grdInput.Col = grdInput.Col - 1
            End If
      Case vbKeyRight
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
            grdInput.SetFocus
            DoEvents
            If grdInput.Col = 16 Then
                If grdInput.Row <> 16 Then
                    grdInput.Row = grdInput.Row + 1
                    grdInput.Col = 0
                End If
            End If
            If grdInput.Col < grdInput.Cols - 1 Then
                grdInput.Col = grdInput.Col + 1
            End If
        Case vbKeyDown
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
            grdInput.SetFocus
            DoEvents
            If grdInput.Row < grdInput.Rows - 1 Then
                grdInput.Row = grdInput.Row + 1
            End If
        Case vbKeyUp
            If Len(txtInput.Text) = 1 Then
                txtInput.Text = "0" & txtInput.Text
            End If
             grdInput.SetFocus
             DoEvents
            If grdInput.Row > grdInput.FixedRows Then
                grdInput.Row = grdInput.Row - 1
            End If
    End Select
End Sub


Private Sub txtDatain_KeyDown(KeyCode As Integer, Shift As Integer)
    txtKeyDown KeyCode, txtDatain, grdBody
End Sub


Private Sub txtDatain_KeyUp(KeyCode As Integer, Shift As Integer)
    If KeyCode <> 8 Then
        If Len(txtDatain.Text) = 2 Then
            If grdBody.Col = 16 Then
                If grdBody.Row <> 16 Then grdBody.Row = grdBody.Row + 1
                grdBody.Col = 1
            Else
                grdBody.Col = grdBody.Col + 1
            End If
            
            If grdBody.Row = 16 Then
            
            Else
            
            End If
            
            If grdBody.TextMatrix(grdBody.Row, grdBody.Col) <> "" Then
                grdBody.SetFocus
            Else
                grdBody_LeaveCell
                cmdOK.SetFocus
            End If
        End If
    End If
End Sub
Private Sub txtDatain_KeyPress(KeyAscii As Integer)
   'noise suppression
   If KeyAscii = vbKeyReturn Then KeyAscii = 0
   txtKeyPress KeyAscii
End Sub
Private Sub txtDatain_Validate(Cancel As Boolean)
    If Len(txtDatain.Text) = 1 Then
        txtDatain = "0" & txtDatain
    End If
    If txtDatain.Visible Then
      grdBody = txtDatain
      txtDatain.Visible = False
   End If
End Sub



'======================================================================
'
'  Bug Fix For FORMAT(hexVALUE, "00") Function That Display 00 if value OF THE LSB
'  IS A  Ex. 1A, 2A 3A.....FA
'======================================================================



Public Function A_BUGFIX(ByVal NUM As Integer) As String

Dim mTempSTR As String

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


