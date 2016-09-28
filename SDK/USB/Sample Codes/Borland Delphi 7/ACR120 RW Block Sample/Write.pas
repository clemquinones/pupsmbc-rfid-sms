unit Write;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, MyRoutines;

type
  TFormWrite = class(TForm)
    Panel1: TPanel;
    Label1: TLabel;
    txtblock: TEdit;
    RBHex: TRadioButton;
    RBAscii: TRadioButton;
    cmdOK: TButton;
    cmdCancel: TButton;
    Label2: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    Edit11: TEdit;
    Edit12: TEdit;
    Edit13: TEdit;
    Edit14: TEdit;
    Edit15: TEdit;
    Edit16: TEdit;
    procedure RBHexClick(Sender: TObject);
    procedure RBAsciiClick(Sender: TObject);
    procedure cmdOKClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure cmdCancelClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormWrite: TFormWrite;

implementation

{$R *.DFM}

procedure TFormWrite.RBHexClick(Sender: TObject);
begin

//set WriteAsc to False
WriteAsc := False;

//'set maxlenght to 2 for Hex Entry
   Edit1.MaxLength := 2;
   Edit2.MaxLength := 2;
   Edit3.MaxLength := 2;
   Edit4.MaxLength := 2;
   Edit5.MaxLength := 2;
   Edit6.MaxLength := 2;
   Edit7.MaxLength := 2;
   Edit8.MaxLength := 2;
   Edit9.MaxLength := 2;
   Edit10.MaxLength := 2;
   Edit11.MaxLength := 2;
   Edit12.MaxLength := 2;
   Edit13.MaxLength := 2;
   Edit14.MaxLength := 2;
   Edit15.MaxLength := 2;
   Edit16.MaxLength := 2;

//Set default Text
   Edit1.Text := 'FF';
   Edit2.Text := 'FF';
   Edit3.Text := 'FF';
   Edit4.Text := 'FF';
   Edit5.Text := 'FF';
   Edit6.Text := 'FF';
   Edit7.Text := 'FF';
   Edit8.Text := 'FF';
   Edit9.Text := 'FF';
   Edit10.Text:= 'FF';
   Edit11.Text := 'FF';
   Edit12.Text := 'FF';
   Edit13.Text := 'FF';
   Edit14.Text := 'FF';
   Edit15.Text := 'FF';
   Edit16.Text := 'FF';
end;








procedure TFormWrite.RBAsciiClick(Sender: TObject);
begin

//Set WriteAsc  to True
WriteAsc := True;

//'set maxlenght to 1 for Ascii Entry
   Edit1.MaxLength := 1;
   Edit2.MaxLength := 1;
   Edit3.MaxLength := 1;
   Edit4.MaxLength := 1;
   Edit5.MaxLength := 1;
   Edit6.MaxLength := 1;
   Edit7.MaxLength := 1;
   Edit8.MaxLength := 1;
   Edit9.MaxLength := 1;
   Edit10.MaxLength :=1;
   Edit11.MaxLength := 1;
   Edit12.MaxLength := 1;
   Edit13.MaxLength := 1;
   Edit14.MaxLength := 1;
   Edit15.MaxLength := 1;
   Edit16.MaxLength := 1;


//set default text
   Edit1.Text := '';
   Edit2.Text := '';
   Edit3.Text := '';
   Edit4.Text := '';
   Edit5.Text := '';
   Edit6.Text := '';
   Edit7.Text := '';
   Edit8.Text := '';
   Edit9.Text := '';
   Edit10.Text:= '';
   Edit11.Text := '';
   Edit12.Text := '';
   Edit13.Text := '';
   Edit14.Text := '';
   Edit15.Text := '';
   Edit16.Text := '';

end;







procedure TFormWrite.cmdOKClick(Sender: TObject);
begin

    //'check block range if within the range of 0 to 3
    If (strtoint(txtblock.Text) < 0) Or (strtoint(txtblock.Text) > 3) Then
       begin
       application.MessageBox('Block Ranges From 0 to 3 only','Block Out of Range', MB_OK);
       txtblock.SetFocus;
       Exit;
       end
    Else
       //'set block
       BLCK := strtoint(txtblock.Text);


   //'This is for Trapping Accidental write to block 3 which is the Trailer Block
   //'If your not sure on how to setup Access Bit or what to write on Trailer Block
   //'Cancel the operation and Choose between 0 to 2 block, otherwise you can remove
   //'this part
   If BLCK = 3 Then
      begin
      If (application.MessageBox('This is for Trapping Accidental write to block 3 which is the Trailer Block if your not sure on how to setup Access Bit or what to write on Trailer Block Cancel the operation and Choose between 0 to 2 block, otherwise Click OK', 'Critical Block Chosen For Write', MB_OKCANCEL) = IDCANCEL) Then
          Exit;
      end;

    //Computation for the exact block to Access....
    If Sec > 31 Then
        begin
        BLCK := ((Sec - 32) * 16) + 128 + BLCK;
        end
    Else
        BLCK := Sec * 4 + BLCK;





If WriteAsc = False Then
   begin
   //'if Hexadecimal was selected CONVERT hex to decimal
   dout[0] := Hex_Dec(Edit1);
   dout[1] := Hex_Dec(Edit2);
   dout[2] := Hex_Dec(Edit3);
   dout[3] := Hex_Dec(Edit4);
   dout[4] := Hex_Dec(Edit5);
   dout[5] := Hex_Dec(Edit6);
   dout[6] := Hex_Dec(Edit7);
   dout[7] := Hex_Dec(Edit8);
   dout[8] := Hex_Dec(Edit9);
   dout[9]:= Hex_Dec(Edit10);
   dout[10] := Hex_Dec(Edit11);
   dout[11] := Hex_Dec(Edit12);
   dout[12] := Hex_Dec(Edit13);
   dout[13] := Hex_Dec(Edit14);
   dout[14] := Hex_Dec(Edit15);
   dout[15] := Hex_Dec(Edit16);
   end

Else
   begin
   //'if ASCII was selected convert character to decimal
   dout[0] := ord(Edit1.Text[1]);
   dout[1] := ord(Edit2.Text[1]);
   dout[2] := ord(Edit3.Text[1]);
   dout[3] := ord(Edit4.Text[1]);
   dout[4] := ord(Edit5.Text[1]);
   dout[5] := ord(Edit6.Text[1]);
   dout[6] := ord(Edit7.Text[1]);
   dout[7] := ord(Edit8.Text[1]);
   dout[8] := ord(Edit9.Text[1]);
   dout[9] := ord(Edit10.Text[1]);
   dout[10] := ord(Edit11.Text[1]);
   dout[11] := ord(Edit12.Text[1]);
   dout[12] := ord(Edit13.Text[1]);
   dout[13] := ord(Edit14.Text[1]);
   dout[14] := ord(Edit15.Text[1]);
   dout[15] := ord(Edit16.Text[1]);
   End;

   //set ButtonOK to True
   buttonOK:=True;

   //Close FormWrite
   formwrite.Close;

end;






procedure TFormWrite.FormCreate(Sender: TObject);
begin
   //set default Value of WriteAsc to False and RBHex as Default Selected Radio Button
   WriteAsc := False;
   RBHex.checked := true;

end;

procedure TFormWrite.cmdCancelClick(Sender: TObject);
begin
   //set buttonOk to False
   buttonOK := False;

   //Close FormWrite
   formwrite.Close;
end;

end.
