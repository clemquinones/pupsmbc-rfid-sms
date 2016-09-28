object FormLogin: TFormLogin
  Left = 337
  Top = 352
  Width = 303
  Height = 234
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
      Top = 16
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
      Left = 214
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
      Top = 80
      Width = 97
      Height = 13
      Caption = 'Key : (Hexadecimal )'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      WordWrap = True
    end
    object cmbbox1: TComboBox
      Left = 16
      Top = 40
      Width = 113
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
      Left = 158
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
      Left = 225
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
      Top = 100
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
      Left = 56
      Top = 100
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
      Left = 96
      Top = 100
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
      Left = 136
      Top = 100
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
      Left = 176
      Top = 100
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
      Left = 216
      Top = 100
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
      Left = 120
      Top = 152
      Width = 73
      Height = 25
      Caption = 'OK'
      TabOrder = 9
      OnClick = cmdOKClick
    end
    object cmdCancel: TButton
      Left = 200
      Top = 152
      Width = 73
      Height = 25
      Caption = 'Cancel'
      TabOrder = 10
      OnClick = cmdCancelClick
    end
  end
end
