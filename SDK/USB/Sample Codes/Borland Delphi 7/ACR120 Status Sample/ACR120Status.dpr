program ACR120Status;

uses
  Forms,
  ACR120StatusSample in 'ACR120StatusSample.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  ACR120 in 'ACR120.pas',
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.Run;
end.
