; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CACR120StatusDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "ACR120Status.h"

ClassCount=3
Class1=CACR120StatusApp
Class2=CACR120StatusDlg
Class3=CAboutDlg

ResourceCount=2
Resource1=IDR_MAINFRAME
Resource2=IDD_ACR120STATUS_DIALOG

[CLS:CACR120StatusApp]
Type=0
HeaderFile=ACR120Status.h
ImplementationFile=ACR120Status.cpp
Filter=N

[CLS:CACR120StatusDlg]
Type=0
HeaderFile=ACR120StatusDlg.h
ImplementationFile=ACR120StatusDlg.cpp
Filter=D
LastObject=IDC_BtnConnect
BaseClass=CDialog
VirtualFilter=dWC

[CLS:CAboutDlg]
Type=0
HeaderFile=ACR120StatusDlg.h
ImplementationFile=ACR120StatusDlg.cpp
Filter=D

[DLG:IDD_ACR120STATUS_DIALOG]
Type=1
Class=CACR120StatusDlg
ControlCount=7
Control1=IDC_STATIC,button,1342177287
Control2=IDC_STATIC,button,1342177287
Control3=IDC_LIST1,listbox,1352728833
Control4=IDC_STATIC,static,1342308352
Control5=IDC_CONNECT_TYPE,combobox,1344340226
Control6=IDC_BtnConnect,button,1342242816
Control7=IDC_Status,button,1342242816

