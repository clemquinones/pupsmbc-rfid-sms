object Main: TMain
  Left = 192
  Top = 107
  Width = 478
  Height = 385
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Read/Write Block Sample'
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
    Height = 345
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 12
      Top = 216
      Width = 233
      Height = 113
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
          'USB 8')
      end
      object BtnConnect: TButton
        Left = 16
        Top = 72
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnSelect: TButton
        Left = 122
        Top = 40
        Width = 97
        Height = 25
        Caption = 'Select'
        Enabled = False
        TabOrder = 2
        OnClick = BtnSelectClick
      end
      object BtnLogin: TButton
        Left = 122
        Top = 72
        Width = 97
        Height = 25
        Caption = 'Login'
        Enabled = False
        TabOrder = 3
        OnClick = BtnLoginClick
      end
    end
    object GroupBox2: TGroupBox
      Left = 252
      Top = 216
      Width = 193
      Height = 113
      Caption = 'Functions'
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      object BtnReadBlock: TButton
        Left = 40
        Top = 32
        Width = 105
        Height = 25
        Caption = 'Read Block'
        TabOrder = 0
        OnClick = BtnReadBlockClick
      end
      object BtnWriteBlock: TButton
        Left = 40
        Top = 64
        Width = 105
        Height = 25
        Caption = 'Write Block'
        TabOrder = 1
        OnClick = BtnWriteBlockClick
      end
    end
    object Memo1: TMemo
      Left = 12
      Top = 16
      Width = 433
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
