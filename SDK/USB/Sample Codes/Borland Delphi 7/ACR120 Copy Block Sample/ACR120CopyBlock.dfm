object Main: TMain
  Left = 213
  Top = 129
  Width = 535
  Height = 435
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Read / Write - Copy Block Value Sample'
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
    Width = 513
    Height = 393
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 233
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
        Left = 16
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
        Left = 16
        Top = 40
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
          'USB 8'
          '')
      end
      object BtnConnect: TButton
        Left = 16
        Top = 96
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnSelect: TButton
        Left = 128
        Top = 40
        Width = 97
        Height = 25
        Caption = 'Select'
        Enabled = False
        TabOrder = 2
        OnClick = BtnSelectClick
      end
      object BtnLogin: TButton
        Left = 128
        Top = 96
        Width = 97
        Height = 25
        Caption = 'Login'
        Enabled = False
        TabOrder = 3
        OnClick = BtnLoginClick
      end
    end
    object GroupBox2: TGroupBox
      Left = 256
      Top = 216
      Width = 241
      Height = 161
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
        Left = 8
        Top = 75
        Width = 86
        Height = 28
        Caption = 'From Block:       ( Decimal )'
        Font.Charset = ANSI_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
        WordWrap = True
      end
      object Label4: TLabel
        Left = 128
        Top = 75
        Width = 71
        Height = 28
        Caption = 'To Block:       ( Decimal )'
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
        Top = 40
        Width = 97
        Height = 25
        Caption = 'Read Value'
        TabOrder = 0
        OnClick = BtnReadValueClick
      end
      object BtnWriteValue: TButton
        Left = 16
        Top = 40
        Width = 97
        Height = 25
        Caption = 'Write Value'
        TabOrder = 1
        OnClick = BtnWriteValueClick
      end
      object Text1: TEdit
        Left = 80
        Top = 83
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 2
        Text = '0'
      end
      object Text2: TEdit
        Left = 200
        Top = 83
        Width = 33
        Height = 22
        TabOrder = 3
        Text = '0'
      end
      object CopyBlock: TButton
        Left = 80
        Top = 120
        Width = 97
        Height = 25
        Caption = 'Copy  Block'
        TabOrder = 4
        OnClick = CopyBlockClick
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 481
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
