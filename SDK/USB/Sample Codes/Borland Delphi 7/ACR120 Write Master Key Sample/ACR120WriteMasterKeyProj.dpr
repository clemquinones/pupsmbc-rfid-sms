program ACR120WriteMasterKeyProj;

uses
  Forms,
  ACR120WriteMasterKey in 'ACR120WriteMasterKey.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  Login in 'Login.pas' {FormLogin},
  ACR120 in 'ACR120.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.CreateForm(TFormLogin, FormLogin);
  Application.Run;
end.
