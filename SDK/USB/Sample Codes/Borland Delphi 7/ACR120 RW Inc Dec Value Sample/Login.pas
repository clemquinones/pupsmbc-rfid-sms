unit Login;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
  StdCtrls, ExtCtrls, MyRoutines;

type
  TFormLogin = class(TForm)
    Panel1: TPanel;
    Label1: TLabel;
    txtsector: TEdit;
    txtstorednumber: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    cmdOK: TButton;
    cmdCancel: TButton;
    cmbbox1: TComboBox;
    procedure cmdOKClick(Sender: TObject);
    procedure cmdCancelClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormLogin: TFormLogin;

implementation

{$R *.DFM}

procedure TFormLogin.cmdOKClick(Sender: TObject);
begin

   //set buttonOK to True
   buttonOK := true;

   //'Set LogType
   Case (Cmbbox1.ItemIndex) of

       0:    begin

             //'Log in using Keytype AA... User Key Input
             LogType := ACR120_LOGIN_KEYTYPE_A;

              //'Convert Hex keys to Decimal before storing in Pkey()
              pKey[0] := Hex_Dec(Edit1);
              pKey[1] := Hex_Dec(Edit2);
              pKey[2] := Hex_Dec(Edit3);
              pKey[3] := Hex_Dec(Edit4);
              pKey[4] := Hex_Dec(Edit5);
              pKey[5] := Hex_Dec(Edit6);

              end;

      1:      begin
              //'Log in using Keytype BB... User Key Input
               LogType := ACR120_LOGIN_KEYTYPE_B;

              //'Convert Hex keys to Decimal before storing in Pkey()
              pKey[0] := Hex_Dec(Edit1);
              pKey[1] := Hex_Dec(Edit2);
              pKey[2] := Hex_Dec(Edit3);
              pKey[3] := Hex_Dec(Edit4);
              pKey[4] := Hex_Dec(Edit5);
              pKey[5] := Hex_Dec(Edit6);

              end;

      2:      begin
              //'Log in using the Transport Key which is FF FF FF FF FF FF
              LogType := ACR120_LOGIN_KEYTYPE_DEFAULT_A;

              pKey[0]:= $FF;
              pKey[1] := $FF;
              pKey[2] := $FF;
              pKey[3] := $FF;
              pKey[4] := $FF;
              pKey[5]:= $FF;

              end;


      3:      begin
              //'Log in using the Transport Key which is FF FF FF FF FF FF
              LogType := ACR120_LOGIN_KEYTYPE_DEFAULT_B;

              pKey[0]:= $FF;
              pKey[1] := $FF;
              pKey[2] := $FF;
              pKey[3] := $FF;
              pKey[4] := $FF;
              pKey[5]:= $FF;
              end;

      4:      begin
              //'Log in using the Transport Key which is FF FF FF FF FF FF
              LogType := ACR120_LOGIN_KEYTYPE_DEFAULT_F;

              pKey[0]:= $FF;
              pKey[1] := $FF;
              pKey[2] := $FF;
              pKey[3] := $FF;
              pKey[4] := $FF;
              pKey[5]:= $FF;

              end;

      5:      begin

              //'Login using stored keys A from user specified Register in EEPROM
              LogType := ACR120_LOGIN_KEYTYPE_STORED_A;

              //'check If Stored Number is within Range
              If (strtoint(txtStoredNumber.Text) < 0) Or (strtoint(txtStoredNumber.Text) > 31) Then
                 begin
                 application.MessageBox('Please Enter stored number ranging from 0 to 31 only','Sector Out of Range',MB_OK);
                 txtStoredNumber.SetFocus;
                 Exit;
                 end;

              // assign stored number to variable sto
              sto := strtoint(txtStoredNumber.Text);
              end;

      6:      begin

              //'Login using stored keys B From user specified register in EEPROM
              LogType := ACR120_LOGIN_KEYTYPE_STORED_B;

              //'check If Stored Number is within Range
              If (strtoint(txtStoredNumber.Text) < 0) Or (strtoint(txtStoredNumber.Text) > 31) Then
                 begin
                 application.MessageBox('Please Enter stored number ranging from 0 to 31 only','Sector Out of Range',MB_OK);
                 txtStoredNumber.SetFocus;
                 Exit;
                 end;

              // assign stored number to variable sto
              sto := strtoint(txtStoredNumber.Text);
              end;

      Else    // if no login type selected alert user
              application.MessageBox('Please Select Log-in Type','Log-In Fail', MB_OK);
              Exit;
      end;


     //'check If Sector is within Range
     If Sec > 39 Then
        begin
        application.MessageBox('Sector Out of Range. Please Enter value from 0-39 only','Sector Out of Range',MB_OK);
        end;

     //assign sector number to Variable Sec
     Sec := strtoint(txtSector.Text);



     If Sec > 31 Then
         begin
         Sec := strtoint(txtSector.text);
         PhysicalSector := 32 + ((Sec - 32) * 4);
         end
     Else
         begin
         Sec := strtoint(txtSector.text);
         PhysicalSector := Sec;    //'- 1
         end;





     //Close formlogin
     formlogin.Close;

end;






procedure TFormLogin.cmdCancelClick(Sender: TObject);
begin
   //set buttonOK to False then Closed Form Login
   buttonOK:=false;
   formlogin.Close;
end;

end.
