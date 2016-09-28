unit MyRoutines;

interface

uses Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
     ExtCtrls, StdCtrls;



var
sto: Longint;
LogType: Byte;
buttonOK: Boolean;
rHandle: smallint;
retcode: smallint;
SID: Byte;
Sec:smallint;
pKey: array[0..5] of Byte;
dataRead: array[0..15] of Byte;
dout: array[0..15] of byte;
str: String;
BLCK: Byte;
ReadAsc: boolean;
WriteAsc: boolean;
Value2Write: Longint;


function ErrDef(ErrorCode:smallint):string;
Function StrHEX_Dec(StrHex: char) : Integer;
Function Hex_Dec(val: TEdit): Byte;



implementation





//'======================================================
//'  Routine for Defining Error Code
//'======================================================

function ErrDef(ErrorCode:smallint):string;

begin

     case ErrorCode of
          -1000: ErrDef := '( X ) Unexpected Internal Library Error : -1000';
          -2000: ErrDef := '( X ) Invalid Port : -2000';
          -2010: ErrDef := '( X ) Port Occupied by Another Application : -2010';
          -2020: ErrDef := '( X ) Invalid Handle : -2020';
          -2030: ErrDef := '( X ) Incorrect Parameter : -2030';
          -3000: ErrDef := '( X ) No TAG Selected or in Reachable Range : -3000';
          -3010: ErrDef := '( X ) Read Failed after Operation : -3010';
          -3020: ErrDef := '( X ) Block does not contain value : -3020';
          -3030: ErrDef := '( X ) Operation Failed : -3030';
          -3040: ErrDef := '( X ) Unknown Reader Error : -3040';
          -4010: ErrDef := '( X ) Invalid stored key format in login process : -4010';
          -4020: ErrDef := '( X ) Reader cannot read after write operation : -4020';
          -4030: ErrDef := '( X ) Decrement Failure (Empty) : -4030';
     end;

end;





//'======================================================
//'  Routine for converting Hex Significant Byte value
//'  to it's Decimal value.
//'======================================================
Function StrHEX_Dec(StrHex: char) : Integer;
begin

      Case ord(StrHex) of
        ord('0'):  StrHEX_Dec := 0;
        ord('1'):  StrHEX_Dec := 1;
        ord('2'):  StrHEX_Dec := 2;
        ord('3'):  StrHEX_Dec := 3;
        ord('4'):  StrHEX_Dec := 4;
        ord('5'):  StrHEX_Dec := 5;
        ord('6'):  StrHEX_Dec := 6;
        ord('7'):  StrHEX_Dec := 7;
        ord('8'):  StrHEX_Dec := 8;
        ord('9'):  StrHEX_Dec := 9;
        ord('A'):  StrHEX_Dec := 10;
        ord('B'):  StrHEX_Dec := 11;
        ord('C'):  StrHEX_Dec := 12;
        ord('D'):  StrHEX_Dec := 13;
        ord('E'):  StrHEX_Dec := 14;
        ord('F'):  StrHEX_Dec := 15;
      end;  

End;






//'======================================================
//'  Routine for converting Hex to Decimal value.
//'======================================================

Function Hex_Dec(val: TEdit): Byte;
var
MSB: Byte;
LSB: Byte;
Fbyte: Byte;
begin
              Fbyte := 0;
              MSB := 0;
              LSB := 0;

              MSB := StrHEX_Dec(val.Text[1]);
              LSB := StrHEX_Dec(val.Text[2]);
              Fbyte := (MSB * 16) + LSB;

Hex_Dec := Fbyte;

End;




end.
