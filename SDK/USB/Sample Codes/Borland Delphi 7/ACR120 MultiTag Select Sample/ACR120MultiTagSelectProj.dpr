program ACR120MultiTagSelectProj;

uses
  Forms,
  ACR120MultiTagSelect in 'ACR120MultiTagSelect.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  Login in 'Login.pas' {FormLogin},
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.CreateForm(TFormLogin, FormLogin);
  Application.Run;
end.
