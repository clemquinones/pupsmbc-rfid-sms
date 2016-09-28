//'=========================================================================================
//'
//'   Project Name :  ACR120CopyBlock
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A. Arana
//'
//'   Date         :  September 23, 2005
//'
//'   Description  :  This sample Copy the Value of One Block to the Other within the same
//'                   Sector. This Sample also Reads and Writes a Value Block in MiFare1 Card.
//'                   This also shows how to Connect, Select card, and Login to card sector.
//'
//'=========================================================================================

unit ACR120CopyBlock;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
  ExtCtrls, StdCtrls, MyRoutines, login, Read, Write;

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
    BtnReadValue: TButton;
    Memo1: TMemo;
    BtnWriteValue: TButton;
    Text1: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    Text2: TEdit;
    CopyBlock: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure BtnSelectClick(Sender: TObject);
    procedure BtnLoginClick(Sender: TObject);
    procedure BtnReadValueClick(Sender: TObject);
    procedure BtnWriteValueClick(Sender: TObject);
    procedure CopyBlockClick(Sender: TObject);
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
         // Enable the button
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

     end;
        // Enable the button
        BtnLogin.Enabled := true;
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

       Groupbox2.Enabled := true;

  end

else
       memo1.Lines.Add('Login Cancelled...');

end;

















procedure TMain.BtnReadValueClick(Sender: TObject);
var
ctr: smallint;
pVal: Longint;
begin


//Open FormRead
formread.ShowModal;


//Check if Button press is OK or Cancel
if buttonOK = True then
   begin

    //'read specified block value
    retcode := ACR120_ReadValue(rHandle, BLCK, @pVal);


    //'check if retcode is error
    If retcode < 0 Then
       memo1.Lines.Add(ErrDef(retcode))
    Else
       begin
       memo1.Lines.Add('Read Block Success: ' + inttostr(retcode));
       memo1.Lines.Add('Value Readed: ' + inttostr(pVal));
       end;



 end

else

    memo1.Lines.Add('Read Block Cancelled...');


end;

















procedure TMain.BtnWriteValueClick(Sender: TObject);
begin

//show formwrite
formwrite.ShowModal;


if buttonOK = True then
  begin

     //'execute ACR120 write value , Write value to Block
     retcode := ACR120_WriteValue(rHandle, BLCK, Value2Write);

    //'check if retcode was error
    If retcode < 0 Then
       memo1.Lines.Add(ErrDef(retcode))
    Else
       memo1.Lines.Add('Write Value To Block ' + inttostr(BLCK) + ' Success: ' + inttostr(retcode));
  end
else
    memo1.Lines.Add('Write Block Cancelled...');

end;












procedure TMain.CopyBlockClick(Sender: TObject);
var
NewVal: Longint;
FB1:  Byte;
FB2: Byte;

begin

    //'set block
    FB1 := strtoint(Text1.Text);


    //'To access the exact block on the card you must Multiply Sector where you Login by 4
    //'and add the Block.
    FB1 := Sec * 4 + FB1;



    //'set block
    FB2 := strtoint(Text2.Text);



    //'To access the exact block on the card you must Multiply Sector where you Login by 4
    //'and add the Block.
    FB2 := Sec * 4 + FB2;







    //'copy Block from to Block To
    retcode := ACR120_Copy(rHandle, FB1, FB2, @NewVal);

    //'Check if Retcode is Error
    If retcode < 0 Then
       //'Call Function to Define Error Code in string form.
       memo1.Lines.Add (ErrDef(retcode))
    Else
       begin
       memo1.Lines.Add ('Copy From Block ' + inttostr(FB1) + ' To ' + inttostr(FB2) + ' Success');
       memo1.Lines.Add ('New Value: ' + inttostr(NewVal));
       End;



end;

procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin

    retcode := ACR120_Close(rhandle);
end;

end.


