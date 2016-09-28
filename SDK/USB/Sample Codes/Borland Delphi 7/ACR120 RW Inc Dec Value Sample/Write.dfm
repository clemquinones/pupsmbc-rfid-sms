object FormWrite: TFormWrite
  Left = 319
  Top = 246
  Width = 279
  Height = 177
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
    Width = 257
    Height = 137
    BevelOuter = bvLowered
    TabOrder = 0
    object Label1: TLabel
      Left = 8
      Top = 16
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
    object Label2: TLabel
      Left = 8
      Top = 56
      Width = 134
      Height = 14
      Caption = 'Value To Write (Decimal)'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object txtblock: TEdit
      Left = 170
      Top = 16
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
      Left = 80
      Top = 96
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
      Left = 168
      Top = 96
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
      Left = 170
      Top = 56
      Width = 73
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
