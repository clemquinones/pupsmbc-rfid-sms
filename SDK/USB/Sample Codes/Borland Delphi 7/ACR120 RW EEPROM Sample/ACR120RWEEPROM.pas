//'=========================================================================================
//'
//'   Project Name :  ACR120RWEEPROM
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A. Arana
//'
//'   Date         :  September 23, 2005
//'
//'   Description  :  This Sample Reads and Writes to ACR120 Reader EEPROM.
//'                   This also shows how to connect.
//'
//'=========================================================================================



unit ACR120RWEEPROM;

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
    GroupBox2: TGroupBox;
    Memo1: TMemo;
    Text1: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    Text2: TEdit;
    cmdReadEEPROM: TButton;
    cmdWriteEEPROM: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure cmdReadEEPROMClick(Sender: TObject);
    procedure cmdWriteEEPROMClick(Sender: TObject);
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

      GroupBox2.Enabled := true; 

end;













procedure TMain.cmdReadEEPROMClick(Sender: TObject);
var
eePROMData: Byte;
reg: Byte;
begin

    //'assign register number to Reg Variable
    reg := strtoint(Text1.Text);

    //'Read EEPROM
    retcode := ACR120_ReadEEPROM(rHandle, reg, @eePROMData);


    //'check if retcode is error
    If retcode < 0 Then
       begin
       memo1.lines.Add ('Read EEPROM Error: ' + inttostr(retcode));
       end
    Else
       begin
       memo1.lines.Add('Read EEPROM Success: ' + inttostr(retcode));
       memo1.lines.Add('Read EEPROM Value of Register ' + inttostr(reg) + ' : 0x' + inttoHex(eePROMData,2));
       end;

end;







procedure TMain.cmdWriteEEPROMClick(Sender: TObject);
var
eePROMData: Byte;
reg: Byte;
begin

    //'assign register number to Reg Variable
    reg := strtoint(Text1.Text);

    //'assign the value to write at the EEPROM
    eePROMData := strtoint(Text2.Text);

    //'Write EEPROM
    retcode := ACR120_WriteEEPROM(rHandle, reg, eePROMData);


    //'check if retcode is error
    If retcode < 0 Then
      memo1.Lines.Add('Write EEPROM Error: ' + inttostr(retcode))
    Else
      memo1.Lines.Add('Write EEPROM to Register ' + inttostr(reg) + ' Success...');


end;








procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin
    retcode := ACR120_Close(rhandle)
end;

end.


