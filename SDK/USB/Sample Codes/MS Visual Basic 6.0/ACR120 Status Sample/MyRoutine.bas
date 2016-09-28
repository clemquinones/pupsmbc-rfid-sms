Attribute VB_Name = "MyRoutine"
'=========================================================================================
'
'   Company:  Advanced Card Systems LTD.
'
'   Module :  MyRoutine Module
'
'   Author :  Richard C. Siman
'
'   Date   :  January 21, 2004
'
'   Description:
'             Module of Common Routines
'             ®ichard C. Siman
'
'=======================================================================================







Global rHandle As Integer
Global retcode As Integer
Global SID As Byte
Global Sec As Integer
Global pKey(0 To 5) As Byte






'=======================================================================================
'
' String Definition of Error Codes
'
'=======================================================================================

Public Function ErrDef(ByVal ErrCode As Integer) As String
          
          
          Select Case (ErrCode)
                
                Case -1000: ErrDef = "( X ) Unexpected Internal Library Error : -1000"

                Case -2000: ErrDef = "( X ) Invalid Port : -2000"

                Case -2010: ErrDef = "( X ) Port Occupied by Another Application : -2010"

                Case -2020: ErrDef = "( X ) Invalid Handle : -2020"
                
                Case -2030: ErrDef = "( X ) Incorrect Parameter : -2030"
                
                Case -3000: ErrDef = "( X ) No TAG Selected or in Reachable Range : -3000"
                                
                Case -3010: ErrDef = "( X ) Read Failed after Operation : -3010"

                Case -3020: ErrDef = "( X ) Block doesn't contain value : -3020"

                Case -3030: ErrDef = "( X ) Operation Failed : -3030"
                
                Case -3040: ErrDef = "( X ) Unknown Reader Error : -3040"
                
                Case -4010: ErrDef = "( X ) Invalid stored key format in login process : -4010"

                Case -4020: ErrDef = "( X ) Reader can't read after write operation : -4020"
                
                Case -4030: ErrDef = "( X ) Decrement Failure (Empty) : -4030"

           End Select
           
          
End Function









'=========================================
'  Routine for Verifying the Inputed
'  Character as member of HEX value
'  In Short It will allow Hex and backspace
'  Input only
'=========================================
Public Function KeyVerify(ByVal key As Integer) As Integer

    If key >= 48 And key <= 57 Or key >= 65 And key <= 70 Then
             key = key
    ElseIf key >= 97 And key <= 102 Then
             key = (Asc(UCase(Chr(key))))
    ElseIf key = 8 Then
             key = key
    Else
             key = 13
    End If

    KeyVerify = key
    
End Function








'======================================================
'  Routine for converting Hex Significant Byte value
'  to it's Decimal value.
'======================================================
Public Function StrHEX_Dec(ByVal StrHex As String) As Integer


      Select Case StrHex
      
        Case "1"
            StrHEX_Dec = 1
        Case "2"
            StrHEX_Dec = 2
        Case "3"
            StrHEX_Dec = 3
        Case "4"
            StrHEX_Dec = 4
        Case "5"
            StrHEX_Dec = 5
        Case "6"
            StrHEX_Dec = 6
        Case "7"
            StrHEX_Dec = 7
        Case "8"
            StrHEX_Dec = 8
        Case "9"
            StrHEX_Dec = 9
        Case "0"
            StrHEX_Dec = 0
        Case "A"
            StrHEX_Dec = 10
        Case "B"
            StrHEX_Dec = 11
        Case "C"
            StrHEX_Dec = 12
        Case "D"
            StrHEX_Dec = 13
        Case "E"
            StrHEX_Dec = 14
        Case "F"
            StrHEX_Dec = 15
      End Select
      
End Function






'======================================================
'  Routine for converting Hex to Decimal value.
'======================================================

Public Function Hex_Dec(val As TextBox, ByVal start As Byte) As Byte
Dim MSB As Byte
Dim LSB As Byte
Dim Fbyte As Byte

              Fbyte = 0
              MSB = 0
              LSB = 0
              
              MSB = StrHEX_Dec(Mid(val.Text, start, 1))
              LSB = StrHEX_Dec(Mid(val.Text, start + 1, 1))
              Fbyte = (MSB * 16) + LSB

Hex_Dec = Fbyte

End Function



'======================================================================
'
'  Bug Fix For FORMAT(hexVALUE, "00") Function That Display 00 if value OF THE LSB
'  IS A  Ex. 1A, 2A 3A.....FA
'======================================================================



Public Function A_BUGFIX(ByVal NUM As Integer) As String

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





'=========================================================================
' converts single HEX digit to BINARY:
'=========================================================================
Function HEX_2_BIN(ByVal sHEX_DIGIT As String) As String
    Select Case UCase(sHEX_DIGIT)
    
    Case "0"
        HEX_2_BIN = "0000"

    Case "1"
        HEX_2_BIN = "0001"
 
    Case "2"
        HEX_2_BIN = "0010"

    Case "3"
        HEX_2_BIN = "0011"

    Case "4"
        HEX_2_BIN = "0100"

    Case "5"
        HEX_2_BIN = "0101"

    Case "6"
        HEX_2_BIN = "0110"

    Case "7"
        HEX_2_BIN = "0111"

    Case "8"
        HEX_2_BIN = "1000"

    Case "9"
        HEX_2_BIN = "1001"

    Case "A"
        HEX_2_BIN = "1010"

    Case "B"
        HEX_2_BIN = "1011"

    Case "C"
        HEX_2_BIN = "1100"

    Case "D"
        HEX_2_BIN = "1101"

    Case "E"
        HEX_2_BIN = "1110"

    Case "F"
        HEX_2_BIN = "1111"
        
    Case "h", "H"   ' ignore (suffix).
        HEX_2_BIN = ""
        
    Case Else
        MsgBox "wrong argument in HEX_2_BIN(" & sHEX_DIGIT & ")", vbCritical, "Error"
    End Select
End Function









'=========================================================================
' converts BINARY to HEX:
'=========================================================================
Function Bin_2_Hex(ByVal sBin_DIGIT As String) As String
    
    Select Case (sBin_DIGIT)
    
    Case "0000"
        Bin_2_Hex = "0"

    Case "0001"
        Bin_2_Hex = "1"
 
    Case "0010"
        Bin_2_Hex = "2"

    Case "0011"
        Bin_2_Hex = "3"

    Case "0100"
        Bin_2_Hex = "4"

    Case "0101"
        Bin_2_Hex = "5"

    Case "0110"
        Bin_2_Hex = "6"

    Case "0111"
        Bin_2_Hex = "7"

    Case "1000"
        Bin_2_Hex = "8"

    Case "1001"
        Bin_2_Hex = "9"

    Case "1010"
        Bin_2_Hex = "A"

    Case "1011"
        Bin_2_Hex = "B"

    Case "1100"
        Bin_2_Hex = "C"

    Case "1101"
        Bin_2_Hex = "D"

    Case "1110"
        Bin_2_Hex = "E"

    Case "1111"
        Bin_2_Hex = "F"
        
    Case "h", "H"   ' ignore (suffix).
        Bin_2_Hex = ""
        
    Case Else
        MsgBox "wrong argument in Bin_2_Hex(" & sBin_DIGIT & ")", vbCritical, "Error"
    End Select
End Function


