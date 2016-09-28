//'=======================================================================================================================
//'
//'   Project Name :  ACR120TxDataTelegram
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A.Arana
//'
//'   Date         :  September 30, 2005
//'
//'   Description  :  This Sample Sends a Base/simple or ISO "t" Command.
//'                   This also shows how to connect and Select card.
//'
//'=========================================================================================================================
unit ACR120TxDataTelegram;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
  ExtCtrls, StdCtrls, MyRoutines;

type
  TMain = class(TForm)
    Panel1: TPanel;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    cmbPort: TComboBox;
    BtnConnect: TButton;
    BtnSelect: TButton;
    GroupBox2: TGroupBox;
    Memo1: TMemo;
    BtnTxDataTelegram: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure BtnSelectClick(Sender: TObject);
    procedure BtnTxDataTelegramClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Main: TMain;
  Lindx: longint;
  listbox: Trect;





implementation

//uses ;

{$R *.DFM}








procedure TMain.BtnConnectClick(Sender: TObject);
var
FirmVer: array[0..30] of Byte;
infolen: Byte;
Firm: String;
temp: smallint;
FirmVer1: array[0..19] of Byte;
RState : tReaderStatus;
begin

    //'open port connection to ACR120 Reader
    rHandle := ACR120_Open(cmbPort.itemindex);

    //'Check if Handle is Valid
    If rHandle < 0 Then
        memo1.Lines.add(ErrDef(rHandle))
    Else

       begin
       memo1.Lines.add('Connected to : ' + cmbPort.Text);


       //DLL version
       retcode := ACR120_RequestDLLVersion(@infolen, @FirmVer);

       Firm := '';

       for temp := 0 to infolen - 1 do
            begin
            Firm := Firm + Chr(FirmVer[temp]);
            end;

       memo1.Lines.add('DLL Version : ' + Firm);

       //Get the firmware version.
       retcode := ACR120_Status(rHandle, @FirmVer1, @RState);

       Firm := '';

          for temp := 0 to infolen - 1 do
              begin

                if (FirmVer1[temp] <> 0) And (FirmVer1[temp] <> 255) Then
                   begin
                   Firm := Firm + chr(FirmVer1[temp]);
                   end;


              end;

          memo1.Lines.add ('Firmware Version  : ' + Firm);
          lindx:=lindx + 1;

        end;

       BtnSelect.Enabled := true;

end;

































procedure TMain.BtnSelectClick(Sender: TObject);
var
HaveTag: array[0..49] of Byte;
tmpArray: array[0..9] of Byte;
tmpbyte: Byte;
SN: String;
ctr: Integer;


begin

     //'Selects a single card and returns the card ID (Serial Number)
     retcode := ACR120_Select(rHandle, @HaveTag, @tmpbyte, @tmpArray);

     //'Check if Retcode is Error
     If retcode < 0 Then
       begin
       //'Call Function to Define Error Code in string form.
       memo1.Lines.Add(ErrDef(retcode));
       end

     Else
     begin
       memo1.Lines.Add('Select Success');

          //'Convert Serial Number to Hex Format.
          //'(You Can Bypass Hex() Conversion if you want to display serial number as decimal)
          If (HaveTag[0] = 4) Or (HaveTag[0] = 5) Then begin
                SN := '';
                For ctr := 0 To 6 do begin
                    SN := SN + IntToHex(tmpArray[ctr], 2) + ' ';
                end;
          end

          Else begin
                SN := '';
                For ctr := 0 To 3 do begin
                    SN := SN + IntToHex(tmpArray[ctr], 2) + ' ';
                end;
          end;



        SN := '';
        For ctr := 0 To tmpbyte - 1 do begin
           SN := SN + IntToHex(tmpArray[ctr], 2) + ' ';
        end;

       //'Display Serial Number
       memo1.Lines.Add('Card Serial Number: ' + SN + GetTagType1(HaveTag[0]));


       Groupbox2.Enabled := true;

     end;
end;







procedure TMain.BtnTxDataTelegramClick(Sender: TObject);
var
cmd: array[1..50] of Byte;
str: string;
rlen: Byte;
rdata: array[1..50] of Byte;
i: integer;
temp: integer;





begin

for i:=1 to 50 do begin
   cmd[i] := 0;
end;

   cmd[1] := $02;
   cmd[2] := $0F;
   cmd[3] := $E0;
   cmd[4] := $50;
   cmd[5] := $E0;

   //'Send "t" command
   retcode := ACR120_TxDataTelegram(rHandle, 5, @cmd, @rlen, @rdata);

    //'check if retcode is error
    If retcode < 0 Then
       memo1.Lines.Add('Tx Data Error: ' + ErrDef(retcode))
    Else
       begin
          memo1.Lines.Add('Tx Data Success: ' + IntToStr(retcode));
          memo1.Lines.Add('Response Data Length: ' + IntToStr(rlen));

          str := '';

            //for temp := 0 to rlen -1  do //temp1
            for temp := 1 to  rlen  do
              begin
               str := str + IntTohex(rdata[temp], 2) + ' ';
              end;
               memo1.Lines.add ('Data : ' + str);

       end;

end;





procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin

    retcode := ACR120_Close(rhandle);

end;

end.


