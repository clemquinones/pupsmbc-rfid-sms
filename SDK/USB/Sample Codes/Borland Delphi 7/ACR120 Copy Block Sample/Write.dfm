object FormWrite: TFormWrite
  Left = 319
  Top = 246
  Width = 288
  Height = 186
  Caption = 'FormWrite'
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
    Width = 265
    Height = 145
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 8
      Top = 24
      Width = 143
      Height = 14
      Caption = ' Block Number: ( Decimal )'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object Label2: TLabel
      Left = 13
      Top = 56
      Width = 143
      Height = 14
      Caption = 'Value To Write: ( Decimal )'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object txtblock: TEdit
      Left = 176
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
      Left = 88
      Top = 104
      Width = 81
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
      Left = 176
      Top = 104
      Width = 81
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
    object Edit1: TEdit
      Left = 176
      Top = 56
      Width = 57
      Height = 22
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      Text = '100'
    end
  end
end
