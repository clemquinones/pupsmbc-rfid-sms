object Main: TMain
  Left = 192
  Top = 107
  Width = 384
  Height = 405
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Status Sample'
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
    Width = 361
    Height = 361
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 161
      Height = 129
      Caption = 'Connection'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      object Label1: TLabel
        Left = 37
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
        Left = 35
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
        Left = 33
        Top = 72
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
      Width = 329
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 1
    end
    object GroupBox2: TGroupBox
      Left = 183
      Top = 216
      Width = 159
      Height = 129
      Caption = 'Functions'
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      object cmdStatus: TButton
        Left = 32
        Top = 56
        Width = 97
        Height = 25
        Caption = 'Status'
        TabOrder = 0
        OnClick = cmdStatusClick
      end
    end
  end
end
