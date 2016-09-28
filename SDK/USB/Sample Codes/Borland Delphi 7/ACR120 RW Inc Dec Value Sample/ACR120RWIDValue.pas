//'=========================================================================================
//'
//'   Project Name :  ACR120RWIDValue
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A Arana
//'
//'   Date         :  September 27, 2005
//'
//'   Description  :  This Sample Reads and Writes Value to the Value Block.
//'                   Aided With Increment and Decrement Functions, this was Intended for
//'                   ease of use when the data need to be written on a block was a
//'                   numerical value which later to be use in computation.
//'
//'
//'=========================================================================================


unit ACR120RWIDValue;

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
    txtblock: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    Text1: TEdit;
    cmdInc: TButton;
    cmdDec: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure BtnSelectClick(Sender: TObject);
    procedure BtnLoginClick(Sender: TObject);
    procedure BtnReadValueClick(Sender: TObject);
    procedure BtnWriteValueClick(Sender: TObject);
    procedure cmdIncClick(Sender: TObject);
    procedure cmdDecClick(Sender: TObject);
   
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
       GroupBox2.Enabled := true;


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

















procedure TMain.cmdIncClick(Sender: TObject);
var
NewVal: Longint;
val:  Longint;

begin


    //'check block range if within the range of 0 to 3
    If (strtoint(txtblock.Text) < 0) Or (strtoint(txtblock.Text) > 3) Then
       begin
       application.MessageBox('Block Ranges From 0 to 3 only','Block Out of Range', MB_OK);
       txtblock.SetFocus;
       Exit;
       end
    Else
       begin
       //'set block
       Blck := strtoint(txtblock.Text);
       end;



    //'To access the exact block on the card you must Multiply Sector where you Login by 4
    //'add the Block in the sector you want to access
    Blck := Sec * 4 + Blck;

    //set val variable
    val := strtoint64(Text1.Text);

    //'Increment Value using the value given by the user
    retcode := ACR120_Inc(rHandle, Blck, val, @NewVal);

    //'check if retcode is error
    If retcode < 0 Then
       memo1.lines.add('Increment Error: ' + inttostr(retcode))
    Else
       memo1.lines.add('Increment Success: ' + inttostr(retcode));


    //'display incremented Value
    memo1.lines.add('Incremented Value of Block ' + inttostr(Blck) + ' : ' + inttostr(NewVal));


end;
















procedure TMain.cmdDecClick(Sender: TObject);
var
NewVal: Longint;
Blck: Byte;
val: Longint;

begin



    //'check block range if within the range of 0 to 3
    If (strtoint(txtblock.Text) < 0) Or (strtoint(txtblock.Text) > 3) Then
       begin
       application.MessageBox('Block Ranges From 0 to 3 only','Block Out of Range', MB_OK);
       txtblock.SetFocus;
       Exit;
       end
    Else
       begin
       //'set block
       Blck := strtoint(txtblock.Text);
       end;


    //'To access the exact block on the card you must Multiply Sector where you Login by 4
    //'add the Block in the sector you want to access
    Blck := Sec * 4 + Blck;


    //set val variable
    val := strtoint64(Text1.Text);

    //'Decrement Value using the value given by the user
    retcode := ACR120_Dec(rHandle, Blck, val, @NewVal);

    //'check if retcode is error
    If retcode < 0 Then
       memo1.lines.add('Increment Error: ' + inttostr(retcode))
    Else
       memo1.lines.add('Increment Success: ' + inttostr(retcode));


     //'display decremented Value
    memo1.lines.add('Decremented Value of Block ' + inttostr(Blck) + ' : ' + inttostr(NewVal));

end;




end.


