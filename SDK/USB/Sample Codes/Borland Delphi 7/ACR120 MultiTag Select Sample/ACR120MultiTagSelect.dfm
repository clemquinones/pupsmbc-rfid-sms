object Main: TMain
  Left = 196
  Top = 111
  Width = 445
  Height = 506
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'MultiTag Select Sample'
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
    Width = 425
    Height = 465
    BevelOuter = bvLowered
    TabOrder = 0
    object GroupBox1: TGroupBox
      Left = 16
      Top = 232
      Width = 169
      Height = 217
      Caption = 'Connection'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 0
      object Label1: TLabel
        Left = 40
        Top = 40
        Width = 29
        Height = 14
        Caption = 'PORT'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = [fsBold]
        ParentFont = False
      end
      object cmbPort: TComboBox
        Left = 40
        Top = 64
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
        Left = 40
        Top = 101
        Width = 97
        Height = 25
        Caption = 'Connect'
        TabOrder = 1
        OnClick = BtnConnectClick
      end
      object BtnLogin: TButton
        Left = 40
        Top = 157
        Width = 97
        Height = 25
        Caption = 'Login'
        Enabled = False
        TabOrder = 2
        OnClick = BtnLoginClick
      end
    end
    object GroupBox2: TGroupBox
      Left = 192
      Top = 232
      Width = 217
      Height = 217
      Caption = 'Functions'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Arial'
      Font.Style = []
      ParentFont = False
      TabOrder = 1
      object Label4: TLabel
        Left = 9
        Top = 105
        Width = 154
        Height = 14
        Caption = 'Serial Number :  ( Hexadecimal )'
        WordWrap = True
      end
      object MultiTagSelect: TButton
        Left = 56
        Top = 181
        Width = 105
        Height = 25
        Caption = 'MultiTag Select'
        Enabled = False
        TabOrder = 0
        OnClick = MultiTagSelectClick
      end
      object Edit1: TEdit
        Left = 10
        Top = 119
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 1
        Text = 'FF'
      end
      object Edit2: TEdit
        Left = 50
        Top = 119
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 2
        Text = 'FF'
      end
      object Edit3: TEdit
        Left = 90
        Top = 119
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 3
        Text = 'FF'
      end
      object Edit4: TEdit
        Left = 130
        Top = 119
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 4
        Text = 'FF'
      end
      object ListTag: TButton
        Left = 56
        Top = 19
        Width = 105
        Height = 25
        Caption = 'List Tag'
        Enabled = False
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Arial'
        Font.Style = []
        ParentFont = False
        TabOrder = 5
        OnClick = ListTagClick
      end
      object Edit5: TEdit
        Left = 171
        Top = 120
        Width = 32
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 6
        Text = 'FF'
      end
      object Edit6: TEdit
        Left = 10
        Top = 148
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 7
        Text = 'FF'
      end
      object Edit7: TEdit
        Left = 50
        Top = 148
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 8
        Text = 'FF'
      end
      object Edit8: TEdit
        Left = 90
        Top = 148
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 9
        Text = 'FF'
      end
      object Edit9: TEdit
        Left = 130
        Top = 148
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 10
        Text = 'FF'
      end
      object Edit10: TEdit
        Left = 170
        Top = 148
        Width = 33
        Height = 22
        Enabled = False
        MaxLength = 2
        TabOrder = 11
        Text = 'FF'
      end
      object RadioButton1: TRadioButton
        Left = 32
        Top = 52
        Width = 137
        Height = 13
        Caption = '4 Bytes Serial Number'
        TabOrder = 12
        OnClick = RadioButton1Click
      end
      object RadioButton2: TRadioButton
        Left = 32
        Top = 68
        Width = 129
        Height = 13
        Caption = '7 Bytes Serial Number'
        TabOrder = 13
        OnClick = RadioButton2Click
      end
      object RadioButton3: TRadioButton
        Left = 32
        Top = 84
        Width = 145
        Height = 13
        Caption = '10 Bytes Serial Number'
        TabOrder = 14
        OnClick = RadioButton3Click
      end
    end
    object Memo1: TMemo
      Left = 16
      Top = 16
      Width = 393
      Height = 209
      ScrollBars = ssVertical
      TabOrder = 2
    end
  end
end
