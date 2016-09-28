//'=========================================================================================
//'
//'   Project Name :  ACR120AntennaPowerAndRWUserPortProj
//'
//'   Company      :  Advanced Card Systems Ltd.
//'
//'   Author       :  Mary Anne C.A. Arana
//'
//'   Date         :  September 22, 2005
//'
//'   Description  :  This Sample Turns On or Off the Antenna Power.
//'                   Also in this sample Read in the state of user port (PIN 14 of the OEM module)
//'                   and Set up the state of user port (PIN 14 of the OEM module).
//'
//'                   This also Read in the state of user port meaning its checking the state
//'                   of the BUZZER and LED of the reader if its ON or OFF. This program also do a Sample
//'                   Write in the state of the user port meaning you can ON or OFF the state of the BUZZER
//'                   and the LED. This also shows how to connect.
//'
//'                   This also shows how to Connect.
//'
//'   Initial Step :  1. Connect.
//'                   2. Choose any from the functions.
//
//'
//'
//'=========================================================================================




unit ACR120RWUserPort;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs, ACR120U,
  ExtCtrls, StdCtrls, MyRoutines;

type
  TMain = class(TForm)
    Panel1: TPanel;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    cmbPort: TComboBox;
    BtnConnect: TButton;
    Memo1: TMemo;
    GroupBox2: TGroupBox;
    ReadUserPort: TButton;
    WriteUserPort: TButton;
    CBSet: TCheckBox;
    CBClear: TCheckBox;
    PowerON: TButton;
    PowerOFF: TButton;
    procedure BtnConnectClick(Sender: TObject);
    procedure ReadUserPortClick(Sender: TObject);
    procedure WriteUserPortClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure PowerONClick(Sender: TObject);
    procedure PowerOFFClick(Sender: TObject);


  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Main: TMain;
  Lindx: longint;
  listbox: Trect;





implementation

{$R *.DFM}









procedure TMain.BtnConnectClick(Sender: TObject);

var
FirmVer: array[0..30] of Byte;
infolen: Byte;
Firm: String;
temp: smallint;
FirmVer1: array[0..19] of Byte;
RState : tReaderStatus;
begin

    //'open port connection to ACR120 Reader
    rHandle := ACR120_Open(cmbPort.itemindex);

    //'Check if Handle is Valid
    If rHandle < 0 Then
        memo1.Lines.add(ErrDef(rHandle))
    Else

       begin
       memo1.Lines.add('Connected to : ' + cmbPort.Text);


       //DLL version
       retcode := ACR120_RequestDLLVersion(@infolen, @FirmVer);

       Firm := '';

       for temp := 0 to infolen - 1 do
            begin
            Firm := Firm + Chr(FirmVer[temp]);
            end;

       memo1.Lines.add('DLL Version : ' + Firm);

       //Get the firmware version.
       retcode := ACR120_Status(rHandle, @FirmVer1, @RState);

       Firm := '';

          for temp := 0 to infolen - 1 do
              begin

                if (FirmVer1[temp] <> 0) And (FirmVer1[temp] <> 255) Then
                   begin
                   Firm := Firm + chr(FirmVer1[temp]);
                   end;


              end;

          memo1.Lines.add ('Firmware Version  : ' + Firm);
          lindx:=lindx + 1;

        end;

        GroupBox2.Enabled := true;

end;







procedure TMain.ReadUserPortClick(Sender: TObject);
Var
portstate: Byte;


Begin

    //'read user port state
    retcode := ACR120_ReadUserPort(rHandle, @portstate);

    //'check if retcode is error
    If retcode < 0 Then
        memo1.Lines.Add(ErrDef(retcode))
    Else
       case portstate of
         4: memo1.Lines.Add('Buzzer_ON  LED_OFF: ' + inttostr(retcode));
         64: memo1.Lines.Add('Buzzer_OFF  LED_ON: ' + inttostr(retcode));
         68: memo1.Lines.Add('Buzzer_ON  LED_ON: ' + inttostr(retcode));
       else
         memo1.Lines.Add('Buzzer_OFF  LED_OFF: ' + inttostr(retcode));
       end;

end;


















procedure TMain.WriteUserPortClick(Sender: TObject);

Var
portstate: Byte;

begin

        If (CBSet.Checked = true) And (CBClear.Checked = false) then
        begin
            portstate := 4;

        end
        else

        If (CBSet.Checked = false) And (CBClear.Checked = true) then
            begin
                portstate := 64;

            end
        else

        If (CBSet.Checked = true) And (CBClear.Checked = true) then
            begin
                    portstate := 68;

            end
        else
            begin
                  portstate := 0;

            end;


      retcode := ACR120_WriteUserPort(rHandle, portstate);

      If (retcode < 0) then
        begin
          memo1.Lines.Add('Write User Port Error: ' + ErrDef(retcode));
        end
      else
        begin
          memo1.Lines.Add('Write User Port Success: ' + inttostr(retcode) + ' ' + ErrDef(retcode));
        end;


end;











procedure TMain.FormClose(Sender: TObject; var Action: TCloseAction);
begin
        //close connection to port
    retcode := ACR120_Close(rHandle);
end;

procedure TMain.PowerONClick(Sender: TObject);
begin
   // Turn Antenna Power On
   retcode := ACR120_Power(rHandle, 1);

   If retcode < 0 Then
    begin
       memo1.Lines.Add('Antenna Power On Error: ' + ErrDef(retcode));
    end
   Else
       memo1.Lines.Add('Antenna Power On Success: ' + inttostr(retcode));


end;

procedure TMain.PowerOFFClick(Sender: TObject);
begin
    // Turn Antenna Power Off
   retcode := ACR120_Power(rHandle, 0);
   If retcode < 0 Then
    begin
       memo1.Lines.Add('Antenna Power Off Error: ' + ErrDef(retcode));
    end
   Else
       memo1.Lines.Add('Antenna Power Off Success: ' + inttostr(retcode));
end;

end.


