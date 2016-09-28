program ACR120AntennaPowerAndRWUPortProj;

uses
  Forms,
  ACR120RWUserPort in 'ACR120RWUserPort.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.Run;
end.
