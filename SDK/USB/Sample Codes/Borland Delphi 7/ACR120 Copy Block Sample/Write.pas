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
    cmdOK: TButton;
    cmdCancel: TButton;
    Label2: TLabel;
    Edit1: TEdit;

    procedure cmdOKClick(Sender: TObject);
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


   //set value2write
   Value2Write := strtoint64(Edit1.text);

   //set ButtonOK to True
   buttonOK:=True;

   //Close FormWrite
   formwrite.Close;

end;







procedure TFormWrite.cmdCancelClick(Sender: TObject);
begin
   //set buttonOk to False
   buttonOK := False;

   //Close FormWrite
   formwrite.Close;
end;

end.
