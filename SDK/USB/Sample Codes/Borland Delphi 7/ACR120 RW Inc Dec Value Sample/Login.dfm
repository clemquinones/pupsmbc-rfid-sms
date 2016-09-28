object FormLogin: TFormLogin
  Left = 324
  Top = 192
  Width = 301
  Height = 237
  Caption = 'Login'
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
    Width = 281
    Height = 193
    BevelInner = bvLowered
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 16
      Top = 18
      Width = 61
      Height = 14
      Caption = 'Login Type'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label2: TLabel
      Left = 150
      Top = 8
      Width = 53
      Height = 28
      Caption = '    Sector    ( Decimal )'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label3: TLabel
      Left = 209
      Top = 8
      Width = 63
      Height = 28
      Caption = '  Stored No.    ( Decimal )'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object Label4: TLabel
      Left = 16
      Top = 88
      Width = 91
      Height = 14
      Caption = 'Key (Hexadecimal)'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object cmbbox1: TComboBox
      Left = 15
      Top = 39
      Width = 123
      Height = 22
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ItemHeight = 14
      ParentFont = False
      TabOrder = 0
      Items.Strings = (
        'Key A'
        'Key B'
        'Default A'
        'Default B'
        'Default F'
        'Stored A'
        'Stored B')
    end
    object txtsector: TEdit
      Left = 161
      Top = 40
      Width = 33
      Height = 22
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 1
      Text = '0'
    end
    object txtstorednumber: TEdit
      Left = 221
      Top = 40
      Width = 33
      Height = 22
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 2
      Text = '0'
    end
    object Edit1: TEdit
      Left = 16
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 3
      Text = 'FF'
    end
    object Edit2: TEdit
      Left = 57
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 4
      Text = 'FF'
    end
    object Edit3: TEdit
      Left = 98
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 5
      Text = 'FF'
    end
    object Edit4: TEdit
      Left = 139
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 6
      Text = 'FF'
    end
    object Edit5: TEdit
      Left = 179
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 7
      Text = 'FF'
    end
    object Edit6: TEdit
      Left = 220
      Top = 108
      Width = 33
      Height = 22
      CharCase = ecUpperCase
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 8
      Text = 'FF'
    end
    object cmdOK: TButton
      Left = 105
      Top = 157
      Width = 73
      Height = 25
      Caption = 'OK'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 9
      OnClick = cmdOKClick
    end
    object cmdCancel: TButton
      Left = 185
      Top = 157
      Width = 73
      Height = 25
      Caption = 'Cancel'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 10
      OnClick = cmdCancelClick
    end
  end
end
