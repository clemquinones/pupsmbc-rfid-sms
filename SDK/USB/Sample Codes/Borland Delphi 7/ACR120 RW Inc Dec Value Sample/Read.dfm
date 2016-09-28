object FormRead: TFormRead
  Left = 339
  Top = 336
  Width = 232
  Height = 148
  Caption = 'FormRead'
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
    Width = 209
    Height = 105
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 11
      Top = 21
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
    object txtblock: TEdit
      Left = 160
      Top = 21
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
    object cmdOK: TButton
      Left = 40
      Top = 64
      Width = 73
      Height = 25
      Caption = 'OK'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      OnClick = cmdOKClick
    end
    object cmdCancel: TButton
      Left = 120
      Top = 64
      Width = 73
      Height = 25
      Caption = 'Cancel'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 2
      OnClick = cmdCancelClick
    end
  end
end
