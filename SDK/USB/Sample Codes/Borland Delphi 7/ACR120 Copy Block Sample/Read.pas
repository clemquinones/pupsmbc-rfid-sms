unit Read;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, MyRoutines;

type
  TFormRead = class(TForm)
    Panel1: TPanel;
    Label1: TLabel;
    txtblock: TEdit;
    cmdOK: TButton;
    cmdCancel: TButton;
    procedure cmdOKClick(Sender: TObject);
    procedure RBHexClick(Sender: TObject);
    procedure RBAsciiClick(Sender: TObject);
    procedure cmdCancelClick(Sender: TObject);
    
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormRead: TFormRead;

implementation

{$R *.DFM}







procedure TFormRead.cmdOKClick(Sender: TObject);
begin
     


    //'check block if within the range of 0 to 3
    If (strtoint(txtblock.Text) < 0) Or (strtoint(txtblock.Text) > 3) Then
       begin
       application.MessageBox('Block Ranges From 0 to 3 only', 'Block Out of Range',mb_ok);
       txtblock.SetFocus;
       Exit;
       end
    Else
       //'set block
       BLCK := strtoint(txtblock.Text);

    //Computation for the exact block to Access....
    If Sec > 31 Then
        begin
        BLCK := ((Sec - 32) * 16) + 128 + BLCK;
        end
    Else
        BLCK := Sec * 4 + BLCK;

    //set buttonOK to True
    buttonOK:=true;
    //close FormRead
    formread.Close;
end;

procedure TFormRead.RBHexClick(Sender: TObject);
begin
   //set ReadAsc to False
   ReadAsc := False;
end;

procedure TFormRead.RBAsciiClick(Sender: TObject);
begin
   //set ReadAsc to True
   ReadAsc := True;
end;



procedure TFormRead.cmdCancelClick(Sender: TObject);
begin
   //set buttonOK to False then Closed FormRead
   buttonOK:=false;
   formRead.Close;
end;

end.
