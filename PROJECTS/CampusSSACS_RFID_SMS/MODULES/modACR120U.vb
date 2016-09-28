Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Module modACR120U
    '============VARIABLES================
    Public Serial As String, ReadType As String, Data As String, SNum As String, _
        Availability As String, Compare As String = "000000"
    Public lngID As Long
    Public G_Cancel As Boolean
    Public G_vKeyType As Byte, G_pKey(5) As Byte, G_BlockNum As Byte, G_dout(15) As Byte
    Public G_StoredNum As Integer, G_PhysicalSector As Integer, Count As Integer = 0
    Public ReaderStat As tReaderStatus

    Public CurrentID As String
    Public SerialNumberPublic As String
    Public Updated As Boolean
    Public G_rHandle As Integer
    Public G_retcode As Integer
    Public G_Sec As Integer
    Public G_SID As Byte
    Public g_asd As Integer

    '==========END VARIABLES==============
    Enum Ports
        USB1 = 0 : USB2 = 1 : USB3 = 2 : USB4 = 3 : USB5 = 4 : USB6 = 5 : USB7 = 6 : USB8 = 7
    End Enum
    '======================== Key Type for ACR120_Login ===========================
    Enum OpenTypes
        Add = 1 : Modify = 2
    End Enum
    Enum KeyTypes
        LogIn_A = &HAA
        LogIn_B = &HBB
        LogIn_Def_A = &HAD
        LogIn_Def_B = &HBD
        LogIn_Def_F = &HFD
        LogIn_Stored_A = &HAF
        LogIn_Stored_B = &HBF
    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure tReaderStatus
        Dim MifareInterfaceType As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Dim CardsSupported() As Byte
        Dim FWI, RFU, RFU2 As Byte '// the current FWI value (time out value)
    End Structure

    'Prototype section | Reader Commands
    Declare Function ACR120_Open Lib "ACR120U.DLL" (ByVal ReaderPort As Ports) As Short
    Declare Function ACR120_Status Lib "ACR120U.DLL" (ByVal hReader As Short, ByRef pFirmwareVersion As Byte, ByRef pReaderStatus As tReaderStatus) As Short
    Declare Function RequestDLLVersion Lib "ACR120U.DLL" (ByRef pVersionInfoLen As Byte, ByRef pVersionInfo As Byte) As Short
    Declare Function ACR120_Close Lib "ACR120U.DLL" (ByVal hReader As Short) As Short
    Declare Function ACR120_Reset Lib "ACR120U.DLL" (ByVal hReader As Short) As Short
    'Declare Function ACR120_ReadRC531Reg Lib "ACR120U.DLL" Alias "ACR120_ReadRC500Reg" (ByVal hReader As Short, ByVal RegNo As Byte, ByRef pRegData As Byte) As Short
    ' Declare Function ACR120_WriteRC531Reg Lib "ACR120U.DLL" Alias "ACR120_WriteRC500Reg" (ByVal hReader As Short, ByVal RegNo As Byte, ByVal RegData As Byte) As Short
    '  Declare Function ACR120_DirectSend Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal DataLength As Byte, ByRef pData As Byte, ByRef pResponseDataLength As Byte, ByRef pResponseData As Byte, ByVal TimedOut As Short) As Short
    ' Declare Function ACR120_DirectReceive Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal RespectedDataLength As Byte, ByRef pReceivedDataLength As Byte, ByRef pReceivedData As Byte, ByVal TimedOut As Short) As Short
    '  Declare Function ACR120_ReadEEPROM Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal RegNo As Byte, ByRef pEEPROMData As Byte) As Short
    '  Declare Function ACR120_WriteEEPROM Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal RegNo As Byte, ByVal eePROMData As Byte) As Short
    '  Declare Function ACR120_ReadUserPort Lib "ACR120U.DLL" (ByVal hReader As Short, ByRef pUserPortState As Byte) As Short
    ' Declare Function ACR120_WriteUserPort Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal userPortState As Byte) As Short
    '======================================================================================
    ' CARD COMMANDS
    '======================================================================================
    Declare Function ACR120_Select Lib "ACR120U.DLL" (ByVal hReader As Short, ByRef pResultTagType As Byte, ByRef pResultTagLength As Byte, ByRef pResultSN As Byte) As Short
    Declare Function ACR120_Login Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal sector As Byte, ByVal keyType As KeyTypes, ByVal storedNo As Byte, ByRef pKey As Byte) As Short
    Declare Function ACR120_Read Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, ByRef pBlockData As Byte) As Short
    ' Declare Function ACR120_ReadValue Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, ByRef pValueData As Integer) As Short
    '  Declare Function ACR120_Write Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, ByRef pBlockData As Byte) As Short
    '  Declare Function ACR120_WriteValue Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, ByVal valueData As Integer) As Short
    '  Declare Function ACR120_WriteMasterKey Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal keyNo As Byte, ByRef pKey As Byte) As Short
    '  Declare Function ACR120_Inc Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal Block As Byte, ByVal value As Integer, ByRef pNewValue As Integer) As Short
    '  Declare Function ACR120_Dec Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, ByVal value As Integer, ByRef pNewValue As Integer) As Short
    ' Declare Function ACR120_Copy Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal srcBlock As Byte, ByVal desBlock As Byte, ByRef pNewValue As Integer) As Short
    ' Declare Function ACR120_Power Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal State As Byte) As Short
    ' Declare Function ACR120_ListTags Lib "ACR120U.DLL" (ByVal hReader As Short, ByRef pNumTagFound As Byte, ByRef pTagType As Byte, ByRef pTagLength As Byte, ByRef pSN As Byte) As Short
    '  Declare Function ACR120_MultiTagSelect Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal TagLength As Byte, ByRef SN As Byte, ByRef pResultTagType As Byte, ByRef pResultTagLength As Byte, ByRef pResultSN As Byte) As Short
    ' Declare Function ACR120_TxDataTelegram Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal SendDataLength As Byte, ByRef pSendData As Byte, ByRef pReceivedDataLength As Byte, ByRef pReceivedData As Byte) As Short

    '=============SUB=====================
    Public Sub getData()
        Dim BLCK, dataRead(16) As Byte, ctr As Byte = 0
        Dim TempStr As String, FF As String = "FF", Sektor As String = "00", dStr As String = ""
        If Updated = True Then
            Try : G_vKeyType = KeyTypes.LogIn_A
                'TempStr = ("&H" & Right("00" & FF, 2))
                For i As Integer = 0 To G_pKey.Length - 1
                    G_pKey(i) = CByte("&H" & Right("00" & FF, 2)) 'tempstr
                Next

                G_PhysicalSector = 0 : G_StoredNum = 0
                G_retcode = ACR120_Login(G_rHandle, G_PhysicalSector, G_vKeyType, G_StoredNum, G_pKey(0))
                'log  in sucess!
                TempStr = ("&H" & Right("00" & Sektor, 2))
                G_Sec = CInt(TempStr)
                If G_Sec > 31 Then
                    G_Sec = CInt(TempStr) : G_PhysicalSector = G_Sec + ((G_Sec - 32) * 3)
                Else
                    G_Sec = CInt(TempStr) : G_PhysicalSector = G_Sec
                End If
                ReadType = "Hex"
                'read specified block
                G_retcode = ACR120_Read(G_rHandle, 1, dataRead(0))
                'check if retcode is error
                If G_retcode < 0 Then
                    '  Form1.MB.Text = ErrDef(G_retcode)
                Else
                    '   lstOutput.Items.Add("Read Block Success: " + CStr(G_retcode))
                    ' lstOutput.SelectedIndex = lstOutput.Items.Count - 1
                End If
                'convert bytes read to chosen option (e.g. AS HEX, AS ASCII)
                'Start of Routine
                'check block range if within the range
                BLCK = CByte("&H" & 1)
                'To access the exact block on the card you must Multiply Sector where you Login by 4
                'and add the Block.
                If G_Sec > 31 Then : BLCK = ((G_Sec - 32) * 16) + 128 + BLCK
                Else : BLCK = G_Sec * 4 + BLCK : End If
                G_BlockNum = BLCK : dStr = ""
                For ctr = 0 To 15 : ReadType = "Hex"
                    dStr = dStr + Format_Hex2(dataRead(ctr)) + " "
                    If ctr = 0 Then Availability = dStr 'MessageBox.Show(availability)
                    'Form1.txtSerialNumber.Text = SNum
                Next
                Data = "Data Readed at block " & Format_Hex2(1) & " Hex mode: " & dStr
                'MessageBox.Show("" + serial + data)
            Catch ex As Exception
                'MessageBox.Show("no item detected")
            End Try
        Else
            'MessageBox.Show("add")
            Try : G_vKeyType = KeyTypes.LogIn_A
                ' TempStr = ("&H" & Right("00" & FF, 2))
                For i As Integer = 0 To G_pKey.Length - 1
                    G_pKey(i) = CByte("&H" & Right("00" & FF, 2)) 'tempstr
                Next

                G_PhysicalSector = 0
                G_StoredNum = 0
                G_retcode = ACR120_Login(G_rHandle, G_PhysicalSector, G_vKeyType, G_StoredNum, G_pKey(0))
                'lstOutput.Items.Add("Login Success: " + CStr(G_retcode))
                TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & Sektor, 2)))
                G_Sec = CInt(TempStr)
                If G_Sec > 31 Then
                    G_Sec = CInt(TempStr) : G_PhysicalSector = G_Sec + ((G_Sec - 32) * 3)
                Else
                    G_Sec = CInt(TempStr) : G_PhysicalSector = G_Sec
                End If
                ReadType = "Hex"
                'read specified block
                G_retcode = ACR120_Read(G_rHandle, 1, dataRead(0))
                'check if retcode is error
                If G_retcode < 0 Then 'lstOutput.Items.Add(MyRoutine.ErrDef(G_retcode))
                    '  Form1.MB.Text = ErrDef(G_retcode)
                Else  '   lstOutput.Items.Add("Read Block Success: " + CStr(G_retcode))
                    ' lstOutput.SelectedIndex = lstOutput.Items.Count - 1
                End If
                'convert bytes read to chosen option (e.g. AS HEX, AS ASCII)
                'Start of Routine
                'check block range if within the range
                BLCK = CByte("&H" & 1)
                'To access the exact block on the card you must Multiply Sector where you Login by 4
                'and add the Block.
                If G_Sec > 31 Then
                    BLCK = ((G_Sec - 32) * 16) + 128 + BLCK
                Else
                    BLCK = G_Sec * 4 + BLCK
                End If
                G_BlockNum = BLCK : dStr = ""
                For ctr = 0 To 15
                    ReadType = "Hex"
                    dStr = dStr + Format_Hex2(dataRead(ctr)) + " "
                    If ctr = 0 Then : Availability = dStr
                        If Availability = "01 " Then ' 'MessageBox.Show("d" + availability + "d")
                        ElseIf Availability = "00 " Then
                            System.Console.WriteLine("Cancel Clicked")
                            'Form1.txtSerialNumber.Text = SNum
                        End If
                        'MessageBox.Show(availability)
                    End If
                Next
                Data = "Data Readed at block " & Format_Hex2(1) & " Hex mode: " & dStr
                'MessageBox.Show("" + serial + data)
                'MessageBox.Show(serial)
            Catch ex As Exception
                MessageBox.Show("no item detected")
            End Try
        End If
        Availability = False
    End Sub

    Public Sub ScanCard()
        Dim FirmwareVer(30), FirmwareVer1(20), InfoLen As Byte
        Dim FirmStr As String
        Dim ctr As Integer
        Try            'Start of Routine
            G_rHandle = ACR120_Open(0)
            'Check if Handle is Valid
            If G_rHandle < 0 Then 'Form1.MB.Text = ""
                'Form1.Timer1.Enabled = False : Form1.MB.Text = "Device is disconnected" : Form1.Timer1.Enabled = True : Return
            Else
                'Form1.MB.Text = "Device is connected."
                'Get the DLL version the program is using
                G_retcode = RequestDLLVersion(InfoLen, FirmwareVer(0))
                FirmStr = ""
                For ctr = 0 To InfoLen - 1 : FirmStr &= Chr(FirmwareVer(ctr)) : Next 'lstOutput.Items.Add("DLL Version  : " + FirmStr)
                'Routine to get the firmware version.
                G_retcode = ACR120_Status(G_rHandle, FirmwareVer1(0), ReaderStat)
                FirmStr = ""
                For ctr = 0 To InfoLen - 1
                    If FirmwareVer1(ctr) <> 0 And FirmwareVer1(ctr) <> &HFF Then FirmStr = FirmStr + Chr(FirmwareVer1(ctr))
                Next
                '      lstOutput.Items.Add("Firmware Version  : " + FirmStr)
            End If
            'Auto Scroll List Box to the latest Entry
            '   lstOutput.SelectedIndex = lstOutput.Items.Count - 1
            Selection()
            getData()
        Catch ex As Exception
            MessageBox.Show("reader not connected")
        End Try
    End Sub

    '============END SUB==================

    '============FUNCTION=================
    Public Function GetTagType1(ByVal XTag As Byte) As String
        'Function that explains the value of the TAGTYPE of the Card.
        Select Case (XTag)
            Case 1 : GetTagType1 = "Mifare Light"
            Case 2 : GetTagType1 = "Mifare 1K"
            Case 3 : GetTagType1 = "Mifare 4K"
            Case 4 : GetTagType1 = "Mifare DESFire"
            Case 5 : GetTagType1 = "Mifare Ultralight"
            Case 6 : GetTagType1 = "JCOP30"
            Case 7 : GetTagType1 = "Shanghai Transport"
            Case 8 : GetTagType1 = "MPCOS Combi"
            Case &H80 : GetTagType1 = "ISO Type B, Calypso"
        End Select
        Return 1
    End Function

    Public Function Format_Hex2(ByVal NUM As Integer) As String
        'Format Byte into two-digit Hex
        Return Microsoft.VisualBasic.Right("00" & Hex(NUM), 2)
    End Function

    Public Function Selection() As Integer
        'Variable Declarations
        Dim ResultSN(11), ResultTag, TagType(50) As Byte
        Dim SN As String
        Dim ctr, counter As Integer
        G_retcode = -1
        Do While G_retcode < 0 Or counter = 20
            G_retcode = ACR120_Select(G_rHandle, TagType(0), ResultTag, ResultSN(0)) 'Start of Routine
            counter += 1
            If counter >= 50 Then Return 0 'MessageBox.Show("no item detected")
        Loop
        'Check if Retcode is Error
        If G_retcode < 0 Then 'Form1.MB.Text = "Device is disconnected." 'Call Function to Define Error Code in string form.
        Else
            'Form1.MB.Text = "Device is connected."
            SN = ""
            If TagType(1) = 4 Or TagType(1) = 5 Then
                For ctr = 0 To 6 : SN &= " " + Format_Hex2(ResultSN(ctr)) : Next
            Else
                For ctr = 0 To ResultTag - 1 : SN &= " " + Format_Hex2(ResultSN(ctr)) : Next
            End If
            'Display Serial Number
            Serial = SN & " ( " & GetTagType1(TagType(0)) & " )"
            SNum = SN
            SerialNumberPublic = SN
        End If
        Return 1
    End Function

    Public Function ErrDef(ByVal ErrCode As Integer) As String
        Select Case (ErrCode)
            Case -1000 : ErrDef = "( X ) Unexpected Internal Library Error : -1000"
            Case -2000 : ErrDef = "( X ) Invalid Port : -2000"
            Case -2010 : ErrDef = "( X ) Port Occupied by Another Application : -2010"
            Case -2020 : ErrDef = "( X ) Invalid Handle : -2020"
            Case -2030 : ErrDef = "( X ) Incorrect Parameter : -2030"
            Case -3000 : ErrDef = "( X ) No TAG Selected or in Reachable Range : -3000"
            Case -3010 : ErrDef = "( X ) Read Failed after Operation : -3010"
            Case -3020 : ErrDef = "( X ) Block doesn't contain value : -3020"
            Case -3030 : ErrDef = "( X ) Operation Failed : -3030"
            Case -3040 : ErrDef = "( X ) Unknown Reader Error : -3040"
            Case -4010 : ErrDef = "( X ) Invalid stored key format in login process : -4010"
            Case -4020 : ErrDef = "( X ) Reader can't read after write operation : -4020"
            Case -4030 : ErrDef = "( X ) Decrement Failure (Empty) : -4030"
            Case -4031 : ErrDef = "( X ) Increment Overflow : -4031"
            Case -4032 : ErrDef = "( X ) Value Operations failure : -4032"
            Case -4033 : ErrDef = "( X ) Block doesn't contain value : -4033"
            Case -4034 : ErrDef = "( X ) Value Access failure : -4034"
            Case Else
                ErrDef = "( X ) Error : " & ErrCode
        End Select
    End Function
    '==========END FUNCTION===============
#Region "RFID"
    Public RFIDConnected As Boolean = False
    Public Function getStat_RFID() As String
        If G_rHandle < 0 Then Return "Device is not active." Else Return "Device is active."
    End Function
    Public Function IsActive_RFID() As Boolean
        If G_rHandle < 0 Then RFIDConnected = False : Return False Else RFIDConnected = True : Return True
    End Function
    Public Sub OpenRFID()
        On Error Resume Next
        Dim ctr As Integer = 0
        G_rHandle = -1
        While G_rHandle < 0 : ctr += 1
            RFIDConnected = False
            G_rHandle = ACR120_Open(0)
            If ctr >= 20 Then Return
        End While
        RFIDConnected = True
    End Sub
    Public Sub CloseRFID()
        On Error Resume Next
        Dim ctr As Integer = 0
        While Not G_rHandle < 0 : ctr += 1
            G_rHandle = ACR120_Close(0)
            If ctr >= 20 Then Return
        End While
    End Sub
    Public Function GetID_RFID() As String
        Dim ResultSN(11), ResultTag, TagType(50) As Byte, ID As String = ""
        G_retcode = ACR120_Select(G_rHandle, TagType(0), ResultTag, ResultSN(0))
        If Not G_retcode < 0 Then
            For i As Integer = 0 To IIf(TagType(1) = 4 Or TagType(1) = 5, 6, ResultTag - 1) : ID = ID.Trim & " " & Format_Hex2(ResultSN(i)) : Next
            Return ID : Exit Function
        Else : frmEncodeStudInfo.lblRFID.Text = ErrDef(G_retcode)
        End If
        '     End While
        Return "Cannot read."
    End Function
#End Region
End Module
