////////////////////////////////////////////////////////////////////////////////
//
// Project Name : ACR120U
//
// Company      : ACS Technologies Ltd.
//
// Author       : Mary Anne C.A. Arana
//
// Date         : September 21, 2005
//
////////////////////////////////////////////////////////////////////////////////

unit ACR120U;

interface
uses windows;

Const
//=============================== Error Code ===============================
ERR_READER_NO_RESPONSE = -5000;
ERR_ACR120_INTERNAL_UNEXPECTED = -1000;
ERR_ACR120_PORT_INVALID = -2000;
ERR_ACR120_PORT_OCCUPIED = -2010;
ERR_ACR120_HANDLE_INVALID = -2020;
ERR_ACR120_INCORRECT_PARAM = -2030;
ERR_ACR120_READER_NO_TAG = -3000;
ERR_ACR120_READER_READ_FAIL_AFTER_OP = -3010;
ERR_ACR120_READER_NO_VALUE_BLOCK = -3020;
ERR_ACR120_READER_OP_FAILURE = -3030;
ERR_ACR120_READER_UNKNOWN = -3040;
ERR_ACR120_READER_LOGIN_INVALID_STORED_KEY_FORMAT = -4010;
ERR_ACR120_READER_WRITE_READ_AFTER_WRITE_ERROR = -4020;
ERR_ACR120_READER_DEC_FAILURE_EMPTY = -4030;
ERR_READER_VALUE_INC_OVERFLOW = -4031;
ERR_READER_VALUE_OP_FAILURE = -4032;
ERR_READER_VALUE_INVALID_BLOCK = -4033;
ERR_READER_VALUE_ACCESS_FAILURE = -4034 ;

//======================= Reader Port for AC_Open ==========================

ACR120_USB1 = 0;
ACR120_USB2 = 1;
ACR120_USB3 = 2;
ACR120_USB4 = 3;
ACR120_USB5 = 4;
ACR120_USB6 = 5;
ACR120_USB7 = 6;
ACR120_USB8 = 7;

//*======================== Key Type for ACR120_Login ========================

ACR120_LOGIN_KEYTYPE_A = $AA;
ACR120_LOGIN_KEYTYPE_B = $BB;
ACR120_LOGIN_KEYTYPE_DEFAULT_A = $AD;
ACR120_LOGIN_KEYTYPE_DEFAULT_B = $BD;
ACR120_LOGIN_KEYTYPE_DEFAULT_F = $FD;
ACR120_LOGIN_KEYTYPE_STORED_A = $AF;
ACR120_LOGIN_KEYTYPE_STORED_B = $BF;

type tReaderStatus = record

    // 0x01 = Type A; 0x02 = Type B; 0x03 = Type A + Type B
    MifareInterfaceType: Byte;
    // Bit 0 = Mifare Light;
    // Bit 1 = Mifare1K;
    // Bit 2 = Mifare 4K;
    // Bit 3 = Mifare DESFire
    // Bit 4 = Mifare UltraLight;
    // Bit 5 = JCOP30;
    // Bit 6 = Shanghai Transport;
    // Bit 7 = MPCOS Combi;
    //Bit 8 = ISO type B, Calypso
    // Bit 9 - Bit 31 = To be defined

    CardsSupported:array[0..3] of BYTE;
    CardOpMode: byte;
    // 0x00 = Type A; 0x01 = Type B TAG is being processed
    // 0xFF = No TAG is being processed.
    FWI: byte; // the current FWI value (time out value)
    RFU: byte; // To be defined
    RFU2: Integer; // to be defined
end;
    LPSCARD_tReaderStatus = ^tReaderStatus;

//-------------------------------------------------------------------------------
//Prototype section
//-------------------------------------------------------------------------------

type mpSN = array [0..3] of Byte;
type pLTSN = array [0..199] of Byte;
type mpKey = array [0..5] of Byte;

type mpBlockData = array [0..15] of Byte;
type mVersionInfo = array [0..13] of Byte;


type mpFirmwareVersion = byte;
     mRegData = byte;
     mpData = byte;
     mpResponseDataLength = byte;
     mpResponseData = byte;
     mpReceivedDataLength = byte;
     mpReceivedData = byte;
     mpVersionInfoLen = byte;
     mpVersionInfo = byte;
     mpUserPortState = byte;
     mpResultTagType = byte;
     mpResultTagLength = byte;
     mpResultSN = byte;
     mpValueData = LongInt;
     mpNewValue = LongInt;
     mpNumTagFound = byte;
     mpTagType = byte;
     mpTagLength = byte;
     mSN = byte;
     mpSendData = byte;
     mpEEPROMData = byte;


     TpFirmwareVersion = ^mpFirmwareVersion;
     TRegData = ^mRegData;
     TpData = ^mpData;
     TpResponseDataLength = ^mpResponseDataLength;
     TpResponseData = ^mpResponseData;
     TpReceivedDataLength = ^mpReceivedDataLength;
     TpReceivedData = ^mpReceivedData;
     TpVersionInfoLen = ^mpVersionInfoLen;
     TpVersionInfo = ^mpVersionInfo;
     TpEEPROMData = ^mpEEPROMData;
     TpUserPortState = ^mpUserPortState;
     TpResultTagType =  ^mpResultTagType;
     TpResultTagLength = ^mpResultTagLength;
     TpResultSN = ^mpResultSN;
     TpKey = ^mpKey;
     TpBlockData = ^mpBlockData;
     TpValueData = ^mpValueData;
     TpNewValue = ^mpNewValue;
     TpNumTagFound = ^mpNumTagFound;
     TpTagType = ^mpTagType;
     TpTagLength = ^mpTagLength;
     TpSN = ^mpSN;
     TSN = ^mSN;
     TpSendData = ^mpSendData;




  //////////////////////////////
 //   USB   READER COMMANDS  //
//////////////////////////////


function ACR120_Open (ReaderPort:byte):smallint; stdcall; external 'ACR120U.dll';
function ACR120_Close(hReader:smallint):smallint; stdcall; external 'ACR120U.dll';

function ACR120_Reset(hReader:smallint):smallint; stdcall; external 'ACR120U.dll';
function ACR120_Status(hReader:smallint; pFirmwareVersion: TpFirmwareVersion; pReaderStatus :LPSCARD_tReaderStatus):smallint; stdcall; external 'ACR120U.dll';

function ACR120_ReadRC500Reg(hReader:smallint; RegNo:Byte; pRegData: TRegData):smallint; stdcall; external 'ACR120U.dll';
function ACR120_WriteRC500Reg(hReader:smallint; RegNo:Byte; TRegData:Byte):smallint; stdcall; external 'ACR120U.dll';

function ACR120_ReadRC531Reg(hReader:smallint; RegNo:Byte; pRegData: TRegData):smallint; stdcall;
function ACR120_WriteRC531Reg(hReader:smallint; RegNo:Byte; TRegData:Byte):smallint; stdcall;


function ACR120_DirectSend(hReader:smallint; DataLength:Byte; pData: TpData; pResponseDataLength: TpResponseDataLength; pResponseData: TpResponseData; TimedOut:smallint):smallint; stdcall; external 'ACR120U.dll';
function ACR120_DirectReceive(hReader:smallint; RespectedDataLength:Byte; pReceivedDataLength: TpReceivedDataLength; pReceivedData: TpReceivedData; TimedOut:smallint):smallint; stdcall; external 'ACR120U.dll';

function ACR120_RequestDLLVersion(pVersionInfoLen: TpVersionInfoLen; pVersionInfo: TpVersionInfo):smallint; stdcall; external 'ACR120U.dll';
function ACR120_ReadEEPROM(hReader:smallint; RegNo:Byte; pEEPROMData: TpEEPROMData):smallint; stdcall; external 'ACR120U.dll';

function ACR120_WriteEEPROM(hReader:smallint; RegNo:Byte; eePROMData:Byte):smallint; stdcall; external 'ACR120U.dll';
function ACR120_ReadUserPort(hReader:smallint; pUserPortState: TpUserPortState):smallint; stdcall; external 'ACR120U.dll';

function ACR120_WriteUserPort(hReader:smallint; userPortState:Byte):smallint; stdcall; external 'ACR120U.dll';

//======================================================================================
// CARD COMMANDS
//======================================================================================

function ACR120_Select(hReader:smallint; pResultTagType: TpResultTagType; pResultTagLength: TpResultTagLength; pResultSN: TpResultSN):smallint; stdcall; external 'ACR120U.dll';
function ACR120_Login(hReader:smallint; Sector:Byte; keyType:Byte; StoredNo:Byte; pKey: TpKey):smallint; stdcall; external 'ACR120U.dll';

function ACR120_Read(hReader:smallint; Block:Byte; pBlockData: TpBlockData):smallint; stdcall; external 'ACR120U.dll';
function ACR120_ReadValue(hReader:smallint; Block:Byte; pValueData: TpValueData):smallint; stdcall; external 'ACR120U.dll';

function ACR120_Write(hReader:smallint; Block:Byte; pBlockData: TpBlockData):smallint; stdcall; external 'ACR120U.dll';
function ACR120_WriteValue(hReader:smallint; Block:Byte; ValueData:LongInt):smallint; stdcall; external 'ACR120U.dll';

function ACR120_WriteMasterKey(hReader:smallint; KeyNo:Byte; pKey: TpKey):smallint; stdcall; external 'ACR120U.dll';
function ACR120_Inc(hReader:smallint; Block:Byte; value:LongInt; pNewValue: TpNewValue):smallint; stdcall; external 'ACR120U.dll';

function ACR120_Dec(hReader:smallint; Block:Byte; value:LongInt; pNewValue: TpNewValue):smallint; stdcall; external 'ACR120U.dll';
function ACR120_Copy(hReader:smallint; srcBlock:Byte; desBlock:Byte; pNewValue: TpNewValue):smallint; stdcall; external 'ACR120U.dll';

function ACR120_Power(hReader:smallint; State: Byte):smallint; stdcall; external 'ACR120U.dll';
function ACR120_ListTags(hReader:smallint; pNumTagFound: TpNumTagFound; pTagType: TpTagType; pTagLength: TpTagLength; pSN: TpSN):smallint; stdcall; external 'ACR120U.dll';

function ACR120_MultiTagSelect(hReader:smallint; TagLength:Byte; SN: TSN; pResultTagType: TpResultTagType; pResultTagLength: TpResultTagLength; pResultSN: TpResultSN):smallint; stdcall; external 'ACR120U.dll';
function ACR120_TxDataTelegram(hReader:smallint; SendDataLength:Byte; pSendData: TpSendData; pReceivedDataLength: TpReceivedDataLength; pReceivedData: TpReceivedData):smallint; stdcall; external 'ACR120U.dll';



implementation
function ACR120_ReadRC531Reg(hReader:smallint; RegNo:Byte; pRegData: TRegData):smallint;
begin
    ACR120_ReadRC500Reg(hReader, RegNo, pRegData);
end;

function ACR120_WriteRC531Reg(hReader:smallint; RegNo:Byte; TRegData:Byte):smallint;
begin
    ACR120_WriteRC500Reg(hReader, RegNo, TRegData);
end;



end.



