object FormRead: TFormRead
  Left = 339
  Top = 336
  Width = 252
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
    Width = 225
    Height = 105
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 8
      Top = 24
      Width = 137
      Height = 14
      Caption = ' Block Number: (Decimal)'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object txtblock: TEdit
      Left = 168
      Top = 24
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
      Left = 64
      Top = 72
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
      Left = 144
      Top = 72
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
