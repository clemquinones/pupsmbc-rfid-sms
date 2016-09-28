//'=========================================================================================
//'
//'   Project Name :  ACR120StatusProj
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A. Arana
//'
//'   Date         :  September 24, 2005
//'
//'   Description  :  This sample codes describes the status of ACR120U.
//'
//'=========================================================================================




unit ACR120StatusSample;

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
    Memo1: TMemo;
    GroupBox2: TGroupBox;
    cmdStatus: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure cmdStatusClick(Sender: TObject);


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
     GroupBox2.Enabled :=  true;

end;




procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin
     retcode := ACR120_Close(rhandle);
end;

procedure TMain.cmdStatusClick(Sender: TObject);

var
FirmVer1: array[0..19] of Byte;
RState: tReaderStatus;
FirmStr: String;
ctr: Integer;
SCardSwitch: String;
HexB1: String;
HexB2: String;
HexB3: String;
HexB4: String;
CardSup: Longint;
begin


    retcode := ACR120_Status(rHandle, @FirmVer1, @RState);

     If rHandle < 0 Then
        memo1.Lines.add(ErrDef(rHandle))
     Else

         begin

              FirmStr := '';

              For ctr := 0 To 19 do

              begin
                  If (FirmVer1[ctr] <> 0) And (FirmVer1[ctr] <> $255) Then
                      FirmStr := FirmStr + Chr(FirmVer1[ctr]);
                  end
              end;

              If FirmStr <> '' Then
                  begin
                  memo1.Lines.Add('Firmware Version : ' + FirmStr);

                  HexB1 := '';
                  HexB2 := '';
                  HexB3 := '';
                  HexB4 := '';


                   HexB1 := inttohex(RState.CardsSupported[3],2);
                  HexB2 := inttohex(RState.CardsSupported[2],2);
                  HexB3 := inttohex(RState.CardsSupported[1],2);
                  HexB4 := inttohex(RState.CardsSupported[0],2);

                  cardsup := (RState.CardsSupported[3] * 256 *256 *256);
                  cardsup := cardsup+(RState.CardsSupported[2] * 256 *256);
                  cardsup := cardsup+(RState.CardsSupported[1] * 256);
                  cardsup := cardsup+RState.CardsSupported[0];

                  memo1.lines.Add('Cards Supported : ' + ' ' +  HexB1 +  ' ' +  HexB2 + ' ' +  HexB3 + ' ' +  HexB4);

                  if (cardsup and 1) = 1 then
                     memo1.Lines.Add('>> MiFare Light');

                  if (cardsup and 2) = 2 then
                     memo1.Lines.Add('>> MiFare 1k');

                  if (cardsup and 4) = 4 then
                     memo1.Lines.Add('>> MiFare 4k');

                  if (cardsup and 8) = 8 then
                     memo1.Lines.Add('>> MiFare DesFire');

                  if (cardsup and 16) = 16 then
                     memo1.Lines.Add('>> MiFare Ultralight');

                  if (cardsup and 32) = 32 then
                     memo1.Lines.Add('>> JCOP30');

                  if (cardsup and 64) = 64 then
                     memo1.Lines.Add('>> Shanghai Transport');

                  if (cardsup and 128) = 128 then
                     memo1.Lines.Add('>> MPCOS Combi');

                  if (cardsup and 256) = 256 then
                     memo1.Lines.Add('>> ISO TypeB Calypso');

                     memo1.Lines.Add('>> Mifare Interface Type : ' + GetInterfaceType(RState.MifareInterfaceType));

                end
            end;
end.


