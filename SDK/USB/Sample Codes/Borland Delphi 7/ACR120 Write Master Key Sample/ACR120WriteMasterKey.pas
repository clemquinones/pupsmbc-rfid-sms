//'=========================================================================================
//'
//'   Project Name :  ACR120WriteMasterKeyProj
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A Arana
//'
//'   Date         :  September 26, 2005
//'
//'   Description  :  This Sample Writes MasterKeys to ACR120 Reader EEPROM.
//'                   MasterKey register Ranges From 0 to 31.
//'                   Keys in the register can be use When Login Type
//'                   Was Stored_A or Stored_B.
//'
//'=========================================================================================


unit ACR120WriteMasterKey;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
  ExtCtrls, StdCtrls, MyRoutines, login;

type
  TMain = class(TForm)
    Panel1: TPanel;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    cmbPort: TComboBox;
    BtnConnect: TButton;
    BtnSelect: TButton;
    BtnLogin: TButton;
    GroupBox2: TGroupBox;
    BtnWriteMasterKey: TButton;
    Memo1: TMemo;
    txtSTO: TEdit;
    Label3: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Label4: TLabel;
    procedure BtnConnectClick(Sender: TObject);
    procedure BtnSelectClick(Sender: TObject);
    procedure BtnLoginClick(Sender: TObject);
    procedure BtnWriteMasterKeyClick(Sender: TObject);
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

          BtnSelect.Enabled := true;
        
        end;



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

       BtnLogin.Enabled := true;


     end;
end;












procedure TMain.BtnLoginClick(Sender: TObject);

begin

//show FormLogin
formlogin.ShowModal;

//Check if Button Press in Login Form is OK or Cancel
if buttonOK = true then
   begin

     //set buttonOK to false
     buttonOK := False;

    //'Log in
    retcode := ACR120_Login(rHandle, PhysicalSector, LogType, sto, @pKey);


    //'check if retcode is error
    If retcode < 0 Then
       begin
         memo1.Lines.Add(ErrDef(retcode));
       end
    Else
       begin
         memo1.Lines.Add('Login Success: ' + inttostr(retcode));
         memo1.Lines.Add('Log at Sector: ' + inttostr(Sec));
         memo1.Lines.Add('Login at Physical Sector: ' + inttostr(PhysicalSector));
        
       end;

  end

else
       memo1.Lines.Add('Login Cancelled...');

end;












procedure TMain.BtnWriteMasterKeyClick(Sender: TObject);
var
skey: array[0..5] of Byte;
STONum: Byte;
begin

//'assign storage number to stonum variable
STONum := strtoint(txtSTO.Text);


          //'Put Keys in an array Variable
          skey[0] := Hex_Dec(Edit1);
          skey[1] := Hex_Dec(Edit2);
          skey[2] := Hex_Dec(Edit3);
          skey[3] := Hex_Dec(Edit4);
          skey[4] := Hex_Dec(Edit5);
          skey[5] := Hex_Dec(Edit6);

    //'write master Key
    retcode := ACR120_WriteMasterKey(rHandle, STONum, @skey);

    //'check if retcode is error
    If retcode < 0 Then
       memo1.lines.add ('Write Master Key Error: ' + inttostr(retcode))
    Else
       memo1.lines.add ('Write Master Key Success: ' + inttostr(retcode));


end;




procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  retcode := ACR120_Close(rhandle);
end;

end.


