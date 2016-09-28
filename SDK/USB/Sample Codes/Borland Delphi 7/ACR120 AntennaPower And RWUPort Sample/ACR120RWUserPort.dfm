object Main: TMain
  Left = 192
  Top = 107
  Width = 416
  Height = 435
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'ACR120AntennaPowerAndRWUserPort Sample'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 8
    Top = 8
    Width = 393
    Height = 385
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 177
      Height = 161
      Caption = 'Connection'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      object Label1: TLabel
        Left = 40
        Top = 32
        Width = 29
        Height = 14
        Caption = 'PORT'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object cmbPort: TComboBox
        Left = 40
        Top = 48
        Width = 97
        Height = 22
        ItemHeight = 14
        TabOrder = 0
        Text = 'cmbPort'
        Items.Strings = (
          'USB 1'
          'USB 2'
          'USB 3'
          'USB 4'
          'USB 5'
          'USB 6'
          'USB 7'
          'USB 8')
      end
      object BtnConnect: TButton
        Left = 40
        Top = 80
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 361
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 1
    end
    object GroupBox2: TGroupBox
      Left = 200
      Top = 216
      Width = 177
      Height = 161
      Caption = 'Functions'
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      object ReadUserPort: TButton
        Left = 40
        Top = 56
        Width = 97
        Height = 25
        Caption = 'Read User Port'
        TabOrder = 0
        OnClick = ReadUserPortClick
      end
      object WriteUserPort: TButton
        Left = 40
        Top = 128
        Width = 97
        Height = 25
        Caption = 'Write User Port'
        TabOrder = 1
        OnClick = WriteUserPortClick
      end
      object CBSet: TCheckBox
        Left = 27
        Top = 96
        Width = 62
        Height = 17
        Caption = 'Buzzer'
        TabOrder = 2
      end
      object CBClear: TCheckBox
        Left = 91
        Top = 96
        Width = 65
        Height = 17
        Caption = 'LED'
        TabOrder = 3
      end
      object PowerON: TButton
        Left = 8
        Top = 24
        Width = 73
        Height = 25
        Caption = 'Power ON'
        TabOrder = 4
        OnClick = PowerONClick
      end
      object PowerOFF: TButton
        Left = 88
        Top = 24
        Width = 73
        Height = 25
        Caption = 'Power OFF'
        TabOrder = 5
        OnClick = PowerOFFClick
      end
    end
  end
end
