program ACR120RWEEPROMProj;

uses
  Forms,
  ACR120RWEEPROM in 'ACR120RWEEPROM.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  ACR120 in 'ACR120.pas',
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.Run;
end.
