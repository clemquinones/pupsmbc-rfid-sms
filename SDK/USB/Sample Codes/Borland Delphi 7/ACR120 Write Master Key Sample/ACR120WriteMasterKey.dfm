object Main: TMain
  Left = 192
  Top = 107
  Width = 543
  Height = 410
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Write Master Key Sample'
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
    Width = 521
    Height = 369
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 216
      Width = 233
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
        Left = 16
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
        Left = 16
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
        Left = 16
        Top = 88
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnSelect: TButton
        Left = 120
        Top = 48
        Width = 97
        Height = 25
        Caption = 'Select'
        Enabled = False
        TabOrder = 2
        OnClick = BtnSelectClick
      end
      object BtnLogin: TButton
        Left = 120
        Top = 88
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
      Width = 249
      Height = 145
      Caption = 'Functions'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      object Label3: TLabel
        Left = 11
        Top = 27
        Width = 123
        Height = 14
        Caption = 'Stored Number: (Decimal)'
        WordWrap = True
      end
      object Label4: TLabel
        Left = 11
        Top = 55
        Width = 103
        Height = 14
        Caption = 'Keys : (Hexadecimal)'
        WordWrap = True
      end
      object BtnWriteMasterKey: TButton
        Left = 80
        Top = 109
        Width = 105
        Height = 25
        Caption = 'Write Master Key'
        TabOrder = 0
        OnClick = BtnWriteMasterKeyClick
      end
      object txtSTO: TEdit
        Left = 160
        Top = 24
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 1
        Text = '0'
      end
      object Edit1: TEdit
        Left = 11
        Top = 75
        Width = 33
        Height = 22
        CharCase = ecUpperCase
        MaxLength = 2
        TabOrder = 2
        Text = 'FF'
      end
      object Edit2: TEdit
        Left = 51
        Top = 75
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 3
        Text = 'FF'
      end
      object Edit3: TEdit
        Left = 89
        Top = 75
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 4
        Text = 'FF'
      end
      object Edit4: TEdit
        Left = 127
        Top = 75
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 5
        Text = 'FF'
      end
      object Edit5: TEdit
        Left = 166
        Top = 75
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 6
        Text = 'FF'
      end
      object Edit6: TEdit
        Left = 205
        Top = 75
        Width = 33
        Height = 22
        MaxLength = 2
        TabOrder = 7
        Text = 'FF'
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 489
      Height = 193
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
