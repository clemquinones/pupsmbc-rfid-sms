//'==================================================================================================================
//'
//'   Project Name :  ACR120MultiTagSelect
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Mary Anne C.A. Arana
//'
//'   Date         :  September 23, 2005
//'
//'   Description  :  This Sample Select a specific Mifare1 Card, when there are more than
//'                   one MiFare1 Card present within the readable range of ACR120 reader
//'                   using the serial number of the card.
//'                   You can see the serial number of the MiFare1 cards in range by using the
//'                   ListTag command.
//'
//'==================================================================================================================


unit ACR120MultiTagSelect;

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
    BtnLogin: TButton;
    GroupBox2: TGroupBox;
    MultiTagSelect: TButton;
    Memo1: TMemo;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Label4: TLabel;
    ListTag: TButton;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    RadioButton3: TRadioButton;
    procedure BtnLoginClick(Sender: TObject);
    procedure MultiTagSelectClick(Sender: TObject);
    procedure ListTagClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure BtnConnectClick(Sender: TObject);
    procedure RadioButton1Click(Sender: TObject);
    procedure RadioButton2Click(Sender: TObject);
    procedure RadioButton3Click(Sender: TObject);

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













procedure TMain.MultiTagSelectClick(Sender: TObject);
var
SerialNum: array[0..9] of Byte;
TagLength: Byte;
RTag: Byte;
RSn: array[0..6] of Byte;
SN: string;
ctr: smallint;
TagType: array[0..50] of Byte;


begin
          // 4bytes of Serial Number
      if (Radiobutton1.Checked = true) then

          begin
          //'assign Serial number to array variable (Convert Hex to decimal before Assigning)
          SerialNum[0] := Hex_Dec(edit1);
          SerialNum[1] := Hex_Dec(edit2);
          SerialNum[2] := Hex_Dec(edit3);
          SerialNum[3] := Hex_Dec(edit4);
          TagLength := 4;
          end

               // 7bytes of Serial Number
      else if (Radiobutton2.Checked = true) then

          begin
          //'assign Serial number to array variable (Convert Hex to decimal before Assigning)
          SerialNum[0] := Hex_Dec(edit1);
          SerialNum[1] := Hex_Dec(edit2);
          SerialNum[2] := Hex_Dec(edit3);
          SerialNum[3] := Hex_Dec(edit4);
          SerialNum[4] := Hex_Dec(edit5);
          SerialNum[5] := Hex_Dec(edit6);
          SerialNum[6] := Hex_Dec(edit7);
          TagLength := 7;
          end

      else    // 10 bytes of Serial Number

          begin
          //'assign Serial number to array variable (Convert Hex to decimal before Assigning)
          SerialNum[0] := Hex_Dec(edit1);
          SerialNum[1] := Hex_Dec(edit2);
          SerialNum[2] := Hex_Dec(edit3);
          SerialNum[3] := Hex_Dec(edit4);
          SerialNum[4] := Hex_Dec(edit5);
          SerialNum[5] := Hex_Dec(edit6);
          SerialNum[6] := Hex_Dec(edit7);
          SerialNum[7] := Hex_Dec(edit8);
          SerialNum[8] := Hex_Dec(edit9);
          SerialNum[9] := Hex_Dec(edit10);
          TagLength := 10;
          end;

      //'select specific card based from serial number
      retcode := ACR120_MultiTagSelect(rHandle, TagLength, @SerialNum, @TagType, @RTag, @RSn);

      //'Check  if retcode is error
      if retcode < 0 Then
           begin
           memo1.Lines.Add('Multi Tag Select Error: ' + errdef(retcode))
           end
      else
          begin
          memo1.Lines.Add('Multi Tag Select Success: ' + inttostr(retcode));
          end;


          If (TagType[0] = 4) Or (TagType[0] = 5) Then

              begin
                SN := '';

                for ctr := 0 to 6 do
                    SN := SN + inttohex(RSn[ctr], 2) + ' ';
              end
          else

              begin
                SN := '';

                for ctr := 0 to (TagLength - 1) do
                    SN := SN + inttohex(RSn[ctr], 2) + ' ';
              end;
          //Display serial number of card selected.
          memo1.Lines.Add('Serial Number Selected: ' + SN + '( ' + GetTagType1(TagType[0]) + ' )');

     BtnLogin.Enabled := true;

end;










procedure TMain.ListTagClick(Sender: TObject);
var
TagLength: array[0..50] of Byte;
TagFound:  Byte;
TagType: array[0..50] of Byte;
SN: array[0..450] of Byte;
ctr: smallint;
ctr1:  smallint;
snstr: string;

begin

    //'Get List of Tags with/in readable Range
    retcode := ACR120_ListTags(rhandle, @TagFound, @TagType, @TagLength, @SN);

    If retcode < 0 Then
        //'Call Function to Define Error Code in string form.
        memo1.Lines.Add (ErrDef(retcode))
    Else

       begin
          memo1.Lines.Add('List Tag Success: ' + inttostr(retcode));
          memo1.Lines.Add('Tag Found: ' + inttostr(TagFound));

           ctr1 := 0;
           ctr := 0;

           for ctr1 := 0 to (TagFound - 1) do

              begin

                ctr := ctr1 * 10;
                snstr := '';

                for ctr := ctr To ((TagLength[ctr1] + ctr) - 1) do
                    begin
                    snstr := snstr + inttohex(SN[ctr], 2) + ' ';
                    end;
              end;

           memo1.Lines.Add('Tag(' + inttostr(ctr1) + ') : ' + snstr + '(' + GetTagType1(TagType[0]) + ')');



       end;
           radiobutton1.Checked := true;
           MultiTagSelect.Enabled := true;


     
end;








procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin
    retcode := ACR120_Close(rhandle);
end;


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

          ListTag.Enabled := true;
         

        end;

end;


procedure TMain.RadioButton1Click(Sender: TObject);
begin
          Edit1.Enabled := true;
          Edit2.Enabled := true;
          Edit3.Enabled := true;
          Edit4.Enabled := true;
          Edit5.Enabled := false;
          Edit6.Enabled := false;
          Edit7.Enabled := false;
          Edit8.Enabled := false;
          Edit9.Enabled := false;
          Edit10.Enabled := false;

          Edit5.Text := 'FF';
          Edit6.Text := 'FF';
          Edit7.Text := 'FF';
          Edit8.Text := 'FF';
          Edit9.Text := 'FF';
          Edit10.Text := 'FF';
end;

procedure TMain.RadioButton2Click(Sender: TObject);
begin

          Edit1.Enabled := true;
          Edit2.Enabled := true;
          Edit3.Enabled := true;
          Edit4.Enabled := true;

          Edit5.Enabled := true;
          Edit6.Enabled := true;
          Edit7.Enabled := true;
          Edit8.Enabled := false;
          Edit9.Enabled := false;
          Edit10.Enabled := false;

          Edit8.Text := 'FF';
          Edit9.Text := 'FF';
          Edit10.Text := 'FF';

end;

procedure TMain.RadioButton3Click(Sender: TObject);
begin

          Edit1.Enabled := true;
          Edit2.Enabled := true;
          Edit3.Enabled := true;
          Edit4.Enabled := true;

          Edit5.Enabled := true;
          Edit6.Enabled := true;
          Edit7.Enabled := true;
          Edit8.Enabled := true;
          Edit9.Enabled := true;
          Edit10.Enabled := true;
end;

end.


