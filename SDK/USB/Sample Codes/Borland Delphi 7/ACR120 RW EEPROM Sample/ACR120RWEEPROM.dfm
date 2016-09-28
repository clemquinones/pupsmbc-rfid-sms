object Main: TMain
  Left = 200
  Top = 109
  Width = 479
  Height = 419
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'MiFareRWEEPROM'
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
    Width = 457
    Height = 377
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 177
      Height = 145
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
        Top = 24
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
    object GroupBox2: TGroupBox
      Left = 200
      Top = 216
      Width = 241
      Height = 145
      Caption = 'Functions'
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      object Label3: TLabel
        Left = 18
        Top = 28
        Width = 100
        Height = 28
        Caption = 'Register Number:       ( Decimal )'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
        WordWrap = True
      end
      object Label4: TLabel
        Left = 18
        Top = 68
        Width = 92
        Height = 28
        Caption = ' Value to Write:       ( Decimal )'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
        WordWrap = True
      end
      object Text1: TEdit
        Left = 152
        Top = 30
        Width = 49
        Height = 22
        MaxLength = 2
        TabOrder = 0
        Text = '0'
      end
      object Text2: TEdit
        Left = 152
        Top = 62
        Width = 49
        Height = 22
        TabOrder = 1
        Text = '100'
      end
      object cmdReadEEPROM: TButton
        Left = 16
        Top = 112
        Width = 97
        Height = 25
        Caption = 'Read EEPROM'
        TabOrder = 2
        OnClick = cmdReadEEPROMClick
      end
      object cmdWriteEEPROM: TButton
        Left = 128
        Top = 112
        Width = 97
        Height = 25
        Caption = 'Write EEPROM'
        TabOrder = 3
        OnClick = cmdWriteEEPROMClick
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 425
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
