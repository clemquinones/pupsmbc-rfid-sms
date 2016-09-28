program ACR120RWIDValueProj;

uses
  Forms,
  ACR120RWIDValue in 'ACR120RWIDValue.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  Login in 'Login.pas' {FormLogin},
  Read in 'Read.pas' {FormRead},
  Write in 'Write.pas' {FormWrite},
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.CreateForm(TFormLogin, FormLogin);
  Application.CreateForm(TFormRead, FormRead);
  Application.CreateForm(TFormWrite, FormWrite);
  Application.Run;
end.
