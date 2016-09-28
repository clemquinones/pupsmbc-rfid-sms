object FormRead: TFormRead
  Left = 339
  Top = 336
  Width = 263
  Height = 164
  Caption = 'FormRead'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 8
    Top = 8
    Width = 241
    Height = 121
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 8
      Top = 8
      Width = 131
      Height = 14
      Caption = 'Block Number:(Decimal)'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object txtblock: TEdit
      Left = 152
      Top = 8
      Width = 33
      Height = 22
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      MaxLength = 2
      ParentFont = False
      TabOrder = 0
      Text = '0'
    end
    object RBHex: TRadioButton
      Left = 8
      Top = 40
      Width = 129
      Height = 17
      Caption = 'Read As Hexadecimal'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      OnClick = RBHexClick
    end
    object RBAscii: TRadioButton
      Left = 8
      Top = 56
      Width = 137
      Height = 17
      Caption = 'Read As ASCII'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      OnClick = RBAsciiClick
    end
    object cmdOK: TButton
      Left = 64
      Top = 88
      Width = 81
      Height = 25
      Caption = 'OK'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      OnClick = cmdOKClick
    end
    object cmdCancel: TButton
      Left = 152
      Top = 88
      Width = 81
      Height = 25
      Caption = 'Cancel'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 4
      OnClick = cmdCancelClick
    end
  end
end
