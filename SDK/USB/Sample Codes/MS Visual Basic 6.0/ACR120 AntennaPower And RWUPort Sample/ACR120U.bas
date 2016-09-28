Attribute VB_Name = "ACR120U"
'=========================================================================================
'
'   Company:  Advanced Card Systems LTD.
'
'   Module :  ACR120U API
'
'   Author :  Richard C. Siman
'
'   Date   :  August 8, 2005
'
'             ®ichard C. Siman
'
'=======================================================================================
'Revision Trail
'=======================================================================================
'
'   Company:
'
'   Module :  ACR120U API
'
'   Author :
'
'   Date   :
'
'   Revision Info :
'
'=======================================================================================





'=============================== Error Code ===============================
Global Const ERR_READER_NO_RESPONSE = -5000
Global Const ERR_ACR120_INTERNAL_UNEXPECTED = -1000
Global Const ERR_ACR120_PORT_INVALID = -2000
Global Const ERR_ACR120_PORT_OCCUPIED = -2010
Global Const ERR_ACR120_HANDLE_INVALID = -2020
Global Const ERR_ACR120_INCORRECT_PARAM = -2030
Global Const ERR_ACR120_READER_NO_TAG = -3000
Global Const ERR_ACR120_READER_READ_FAIL_AFTER_OP = -3010
Global Const ERR_ACR120_READER_NO_VALUE_BLOCK = -3020
Global Const ERR_ACR120_READER_OP_FAILURE = -3030
Global Const ERR_ACR120_READER_UNKNOWN = -3040
Global Const ERR_ACR120_READER_LOGIN_INVALID_STORED_KEY_FORMAT = -4010
Global Const ERR_ACR120_READER_WRITE_READ_AFTER_WRITE_ERROR = -4020
Global Const ERR_ACR120_READER_DEC_FAILURE_EMPTY = -4030
Global Const ERR_READER_VALUE_INC_OVERFLOW = -4031
Global Const ERR_READER_VALUE_OP_FAILURE = -4032
Global Const ERR_READER_VALUE_INVALID_BLOCK = -4033
Global Const ERR_READER_VALUE_ACCESS_FAILURE = -4034
    
    
    


'======================= Reader Ports for ACR120_Open ==========================
Enum PORTS
ACR120_USB1 = 0
ACR120_USB2 = 1
ACR120_USB3 = 2
ACR120_USB4 = 3
ACR120_USB5 = 4
ACR120_USB6 = 5
ACR120_USB7 = 6
ACR120_USB8 = 7
End Enum

'======================== Key Type for ACR120_Login ===========================
    
Enum KEYTYPES
ACR120_LOGIN_KEYTYPE_A = &HAA
ACR120_LOGIN_KEYTYPE_B = &HBB
ACR120_LOGIN_KEYTYPE_DEFAULT_A = &HAD
ACR120_LOGIN_KEYTYPE_DEFAULT_B = &HBD
ACR120_LOGIN_KEYTYPE_DEFAULT_F = &HFD
ACR120_LOGIN_KEYTYPE_STORED_A = &HAF
ACR120_LOGIN_KEYTYPE_STORED_B = &HBF
End Enum


                                 

Type tReaderStatus

    '// 0x01 = Type A; 0x02 = Type B; 0x03 = Type A + Type B
    MifareInterfaceType As Byte

    '// Bit 0 = Mifare Light; Bit 1 = Mifare1K; Bit 2 = Mifare 4K; Bit 3 = Mifare DESFire
    '// Bit 4 = Mifare UltraLight; Bit 5 = JCOP30; Bit 6 = Shanghai Transport
    '// Bit 7 = MPCOS Combi; Bit 8 = ISO type B, Calypso
    '// Bit 9 - Bit 31 = To be defined
    CardsSupported(0 To 3) As Byte
    

    CardOpMode As Byte '// 0x00 = Type A; 0x01 = Type B TAG is being processed
                       '// 0xFF = No TAG is being processed.

    FWI As Byte '// the current FWI value (time out value)

    RFU As Byte ' // To be defined

    RFU2 As Integer '// to be defined

End Type








'------------------------------------------------------------------------------------------
'Prototype section
'------------------------------------------------------------------------------------------
'======================================================================================
' READER COMMANDS
'======================================================================================



Declare Function ACR120_Open Lib "ACR120U.DLL" (ByVal ReaderPort As PORTS) As Integer
                                                  
Declare Function ACR120_Close Lib "ACR120U.DLL" (ByVal hReader As Integer) As Integer
                                                   
Declare Function ACR120_Reset Lib "ACR120U.DLL" (ByVal hReader As Integer) As Integer
                                              
Declare Function ACR120_Status Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                      ByRef pFirmwareVersion As Byte, _
                                      ByRef pReaderStatus As tReaderStatus) As Integer
                                     

Declare Function ACR120_ReadRC531Reg Lib "ACR120U.DLL" Alias "ACR120_ReadRC500Reg" (ByVal hReader As Integer, _
                                     ByVal RegNo As Byte, _
                                     ByRef pRegData As Byte) As Integer


Declare Function ACR120_WriteRC531Reg Lib "ACR120U.DLL" Alias "ACR120_WriteRC500Reg" (ByVal hReader As Integer, _
                                     ByVal RegNo As Byte, _
                                     ByVal RegData As Byte) As Integer
                                     
                                     
Declare Function ACR120_DirectSend Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal DataLength As Byte, _
                                     ByRef pData As Byte, _
                                     ByRef pResponseDataLength As Byte, _
                                     ByRef pResponseData As Byte, _
                                     ByVal TimedOut As Integer) As Integer
                                     
                                     
Declare Function ACR120_DirectReceive Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal RespectedDataLength As Byte, _
                                     ByRef pReceivedDataLength As Byte, _
                                     ByRef pReceivedData As Byte, _
                                     ByVal TimedOut As Integer) As Integer
                                     



Declare Function ACR120_RequestDLLVersion Lib "ACR120U.DLL" (ByRef pVersionInfoLen As Byte, _
                                     ByRef pVersionInfo As Byte) As Integer




Declare Function ACR120_ReadEEPROM Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal RegNo As Byte, _
                                     ByRef pEEPROMData As Byte) As Integer





Declare Function ACR120_WriteEEPROM Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal RegNo As Byte, _
                                     ByVal eePROMData As Byte) As Integer




Declare Function ACR120_ReadUserPort Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByRef pUserPortState As Byte) As Integer
                            
                            
                            
                            
Declare Function ACR120_WriteUserPort Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal userPortState As Byte) As Integer







'======================================================================================
' CARD COMMANDS
'======================================================================================


Declare Function ACR120_Select Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByRef pResultTagType As Byte, _
                                     ByRef pResultTagLength As Byte, _
                                     ByRef pResultSN As Byte) As Integer
                                     


Declare Function ACR120_Login Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                          ByVal Sector As Byte, ByVal keyType As KEYTYPES, _
                          ByVal StoredNo As Byte, ByRef pKey As Byte) As Integer


Declare Function ACR120_Read Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByRef pBlockData As Byte) As Integer


Declare Function ACR120_ReadValue Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByRef pValueData As Long) As Integer


Declare Function ACR120_Write Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByRef pBlockData As Byte) As Integer


Declare Function ACR120_WriteValue Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByVal ValueData As Long) As Integer


Declare Function ACR120_WriteMasterKey Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal KeyNo As Byte, _
                                     ByRef pKey As Byte) As Integer
                                     
                                                                          
Declare Function ACR120_Inc Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByVal value As Long, _
                                     ByRef pNewValue As Long) As Integer
                                     
                                                                          
                                     
Declare Function ACR120_Dec Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal Block As Byte, _
                                     ByVal value As Long, _
                                     ByRef pNewValue As Long) As Integer
                                     
Declare Function ACR120_Copy Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal srcBlock As Byte, _
                                     ByVal desBlock As Byte, _
                                     ByRef pNewValue As Long) As Integer



Declare Function ACR120_Power Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                    ByVal State As Byte) As Integer
                            
                            

Declare Function ACR120_ListTags Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByRef pNumTagFound As Byte, _
                                     ByRef pTagType As Byte, _
                                     ByRef pTagLength As Byte, _
                                     ByRef pSN As Byte) As Integer
 
                                     
                            

Declare Function ACR120_MultiTagSelect Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal TagLength As Byte, _
                                     ByRef SN As Byte, _
                                     ByRef pResultTagType As Byte, _
                                     ByRef pResultTagLength As Byte, _
                                     ByRef pResultSN As Byte) As Integer
                                     
                            


Declare Function ACR120_TxDataTelegram Lib "ACR120U.DLL" (ByVal hReader As Integer, _
                                     ByVal SendDataLength As Byte, _
                                     ByRef pSendData As Byte, _
                                     ByRef pReceivedDataLength As Byte, _
                                     ByRef pReceivedData As Byte) As Integer




 



                            
