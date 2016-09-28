object Main: TMain
  Left = 192
  Top = 107
  Width = 564
  Height = 458
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Read/Write - Inc/Dec Value Block Sample'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 8
    Top = 8
    Width = 537
    Height = 417
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 241
      Height = 185
      Caption = 'Connection'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      object Label1: TLabel
        Left = 16
        Top = 36
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
        Left = 16
        Top = 52
        Width = 97
        Height = 22
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = []
        ItemHeight = 14
        ParentFont = False
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
        Left = 16
        Top = 97
        Width = 97
        Height = 25
        Caption = 'Connect'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = []
        ParentFont = False
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnSelect: TButton
        Left = 128
        Top = 52
        Width = 97
        Height = 25
        Caption = 'Select'
        Enabled = False
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = []
        ParentFont = False
        TabOrder = 2
        OnClick = BtnSelectClick
      end
      object BtnLogin: TButton
        Left = 128
        Top = 97
        Width = 97
        Height = 25
        Caption = 'Login'
        Enabled = False
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = []
        ParentFont = False
        TabOrder = 3
        OnClick = BtnLoginClick
      end
    end
    object GroupBox2: TGroupBox
      Left = 280
      Top = 216
      Width = 241
      Height = 185
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
        Left = 9
        Top = 74
        Width = 134
        Height = 14
        Caption = 'Block Number: (Decimal)'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
        WordWrap = True
      end
      object Label4: TLabel
        Left = 7
        Top = 107
        Width = 147
        Height = 14
        Caption = ' Value to Inc/Dec: (Decimal)'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
        WordWrap = True
      end
      object BtnReadValue: TButton
        Left = 128
        Top = 32
        Width = 97
        Height = 25
        Caption = 'Read Value'
        TabOrder = 0
        OnClick = BtnReadValueClick
      end
      object BtnWriteValue: TButton
        Left = 16
        Top = 32
        Width = 97
        Height = 25
        Caption = 'Write Value'
        TabOrder = 1
        OnClick = BtnWriteValueClick
      end
      object txtblock: TEdit
        Left = 160
        Top = 72
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 2
        Text = '0'
      end
      object Text1: TEdit
        Left = 160
        Top = 104
        Width = 57
        Height = 22
        TabOrder = 3
        Text = '100'
      end
      object cmdInc: TButton
        Left = 16
        Top = 142
        Width = 97
        Height = 25
        Caption = 'Increment'
        TabOrder = 4
        OnClick = cmdIncClick
      end
      object cmdDec: TButton
        Left = 128
        Top = 142
        Width = 97
        Height = 25
        Caption = 'Decrement'
        TabOrder = 5
        OnClick = cmdDecClick
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 505
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
