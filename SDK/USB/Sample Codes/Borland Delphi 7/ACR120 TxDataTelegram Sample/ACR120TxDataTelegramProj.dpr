program ACR120TxDataTelegramProj;

uses
  Forms,
  ACR120TxDataTelegram in 'ACR120TxDataTelegram.pas' {Main},
  MyRoutines in 'MyRoutines.pas',
  ACR120 in 'ACR120.pas',
  ACR120U in 'ACR120U.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TMain, Main);
  Application.Run;
end.
