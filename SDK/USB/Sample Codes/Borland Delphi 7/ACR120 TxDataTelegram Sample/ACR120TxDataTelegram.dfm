object Main: TMain
  Left = 192
  Top = 107
  Width = 460
  Height = 376
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'TxDataTelegram Sample'
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
    Width = 438
    Height = 337
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 12
      Top = 197
      Width = 217
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
        Left = 60
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
        Left = 60
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
        Left = 7
        Top = 72
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnSelect: TButton
        Left = 111
        Top = 72
        Width = 97
        Height = 25
        Caption = 'Select'
        Enabled = False
        TabOrder = 2
        OnClick = BtnSelectClick
      end
    end
    object GroupBox2: TGroupBox
      Left = 231
      Top = 197
      Width = 193
      Height = 129
      Caption = 'Functions'
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      object BtnTxDataTelegram: TButton
        Left = 34
        Top = 56
        Width = 129
        Height = 27
        Caption = 't020FE000'
        TabOrder = 0
        OnClick = BtnTxDataTelegramClick
      end
    end
    object Memo1: TMemo
      Left = 14
      Top = 9
      Width = 409
      Height = 185
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
