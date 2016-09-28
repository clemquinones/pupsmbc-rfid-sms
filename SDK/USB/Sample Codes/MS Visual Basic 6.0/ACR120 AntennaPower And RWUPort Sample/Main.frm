VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "ACR120AntennaPowerAndRWUPort"
   ClientHeight    =   6645
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
   ScaleHeight     =   6645
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
      TabIndex        =   0
      Top             =   120
      Width           =   7695
      Begin VB.Frame Frame2 
         Caption         =   "Functions"
         Height          =   3135
         Left            =   4200
         TabIndex        =   6
         Top             =   3000
         Width           =   3135
         Begin VB.CommandButton cmdAntennaOn 
            Caption         =   "Antenna On"
            Enabled         =   0   'False
            Height          =   375
            Left            =   120
            TabIndex        =   12
            Top             =   600
            Width           =   1335
         End
         Begin VB.CommandButton cmdAntennaOff 
            Caption         =   "Antenna Off"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1680
            TabIndex        =   11
            Top             =   600
            Width           =   1335
         End
         Begin VB.CheckBox chk_LED 
            Caption         =   "LED"
            Enabled         =   0   'False
            Height          =   285
            Left            =   1785
            TabIndex        =   10
            Top             =   1965
            Width           =   915
         End
         Begin VB.CheckBox chk_buzz 
            Caption         =   "Buzzer"
            Enabled         =   0   'False
            Height          =   285
            Left            =   525
            TabIndex        =   9
            Top             =   1965
            Width           =   915
         End
         Begin VB.CommandButton cmdWriteUPort 
            Caption         =   "Write User Port"
            Enabled         =   0   'False
            Height          =   375
            Left            =   840
            TabIndex        =   8
            Top             =   2400
            Width           =   1335
         End
         Begin VB.CommandButton cmdReadUPort 
            Caption         =   "Read User Port"
            Enabled         =   0   'False
            Height          =   375
            Left            =   840
            TabIndex        =   7
            Top             =   1320
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
         Height          =   3135
         Left            =   240
         TabIndex        =   1
         Top             =   3000
         Width           =   3735
         Begin VB.CommandButton cmdConnect 
            Caption         =   "Connect"
            Height          =   375
            Left            =   1170
            TabIndex        =   4
            Top             =   1080
            Width           =   1335
         End
         Begin VB.ComboBox cmbPort 
            Height          =   330
            ItemData        =   "Main.frx":030E
            Left            =   1200
            List            =   "Main.frx":032A
            TabIndex        =   2
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
            Left            =   1200
            TabIndex        =   3
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
'   Project Name :  ACR120AntennaPowerAndRWUPort
'
'   Company      :  Advanced Card Systems LTD.
'
'   Author       :  Fernando G. Robles
'
'   Date         :  October 27, 2005
'
'   Description  :  This Sample Turns On or Off the Antenna Power.
'                   Also in this sample Read in the state of user port (PIN 14 of the OEM module)
'                   and Set up the state of user port (PIN 14 of the OEM module).
'
'                   This also Read in the state of user port meaning its checking the state
'                   of the BUZZER and LED of the reader if its ON or OFF. This program also do a Sample
'                   Write in the state of the user port meaning you can ON or OFF the state of the BUZZER
'                   and the LED. This also shows how to connect.
'
'                   This also shows how to Connect.
'
'   Initial Step :  1. Connect.
'                   2. Choose any from the functions.
'
'
'
'=========================================================================================

Option Explicit








Private Sub cmdAntennaOff_Click()
    'Turn Antenna Power Off
   retcode = ACR120_Power(rHandle, 0)
   
   
    'Check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Antenna Power Off Error: " + ErrDef(retcode))
    Else
       List1.AddItem ("Antenna Power Off Success: " + CStr(retcode))
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
End Sub

Private Sub cmdAntennaOn_Click()
     'Turn Antenna Power On
   retcode = ACR120_Power(rHandle, 1)
   
   
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Antenna Power On Error: " + ErrDef(retcode))
    Else
       List1.AddItem ("Antenna Power On Success: " + CStr(retcode))
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
End Sub

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
       cmdReadUPort.Enabled = True
       cmdWriteUPort.Enabled = True
       chk_buzz.Enabled = True
       chk_LED.Enabled = True
       cmdAntennaOn.Enabled = True
       cmdAntennaOff.Enabled = True
       
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

















Private Sub cmdReadUPort_Click()
Dim portstat As Byte
     
    'Read user port state, this means you are CHECKING for the state
    'of the buzzer and the LED light if its ON or OFF.
    
    retcode = ACR120_ReadUserPort(rHandle, portstat)
     
             
    'check if retcode is error
    If retcode < 0 Then
       List1.AddItem ("Read User Port Error: " + CStr(retcode))
    Else
       List1.AddItem ("Read User Port Success: " + CStr(retcode))
       If portstat = 4 Then
            List1.AddItem ("Buzzer ON  LED OFF: " & A_BUGFIX(portstat))
       ElseIf portstat = 64 Then
            List1.AddItem ("Buzzer OFF  LED ON: " & A_BUGFIX(portstat))
       ElseIf portstat = 68 Then
            List1.AddItem ("Buzzer ON  LED ON: " & A_BUGFIX(portstat))
       Else
            List1.AddItem ("Buzzer OFF  LED OFF: " & A_BUGFIX(portstat))
       End If
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
End Sub

























Private Sub cmdWriteUPort_Click()
Dim portstate As Byte

    'Write user port state, this means you are ASSIGNING the state
    'of the buzzer and the LED light if its ON or OFF.

    If chk_buzz.value = 1 And chk_LED.value = 0 Then
        portstate = 4
        List1.AddItem ("Buzzer ON  LED OFF: " & A_BUGFIX(portstate))
    ElseIf chk_buzz.value = 0 And chk_LED.value = 1 Then
        portstate = 64
        List1.AddItem ("Buzzer OFF  LED ON: " & A_BUGFIX(portstate))
    ElseIf chk_buzz.value = 1 And chk_LED.value = 1 Then
        portstate = 68
        List1.AddItem ("Buzzer ON  LED ON: " & A_BUGFIX(portstate))
    Else
        portstate = 0
        List1.AddItem ("Buzzer OFF  LED OFF: " & A_BUGFIX(portstate))
    End If


   
     retcode = ACR120_WriteUserPort(rHandle, portstate)
   
 
   'check if retcode is error
   If retcode < 0 Then
       List1.AddItem ("Write User Port Error: " + CStr(retcode))
    Else
       List1.AddItem ("Write User Port Success: " + CStr(retcode))
       
    End If
    
    
    'Auto Scroll List Box to the latest Entry
    List1.ListIndex = List1.NewIndex
    
    
End Sub













Private Sub Form_Unload(Cancel As Integer)
    
    'close connection to port
    retcode = ACR120_Close(rHandle)
    
    
End Sub

