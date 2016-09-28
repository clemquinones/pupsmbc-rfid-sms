//'=========================================================================================
//'
//'   Project Name :  ACR120UAntennaPower and RW UserPort
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 23, 2005
//'
//'   Description  :  This Sample Turns On or Off the Antenna Power.
//'                   Also in this sample Read in the state of user port (PIN 14 of the OEM module)
//'                   and Set up the state of user port (PIN 14 of the OEM module).
//'
//'					  This also Read in the state of user port meaning its checking the state
//'                   of the BUZZER and LED of the reader if its ON or OFF. This program also do a Sample
//'                   Write in the state of the user port meaning you can ON or OFF the state of the BUZZER
//'                   and the LED. This also shows how to connect.
//'
//'                   This also shows how to Connect.
//'
//'   Initial Step :  1. Connect.
//'                   2. Choose any from the functions.
//'
//'
//'=========================================================================================

#include "stdafx.h"
#include "ACR120AntennaPowerAndRWUPort.h"
#include "ACR120AntennaPowerAndRWUPortDlg.h"
#include "DlgProxy.h"
#include "ACR120U.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif


BYTE sPort;
/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlg dialog

IMPLEMENT_DYNAMIC(CACR120AntennaPowerAndRWUPortDlg, CDialog);

CACR120AntennaPowerAndRWUPortDlg::CACR120AntennaPowerAndRWUPortDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120AntennaPowerAndRWUPortDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120AntennaPowerAndRWUPortDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_pAutoProxy = NULL;
}

CACR120AntennaPowerAndRWUPortDlg::~CACR120AntennaPowerAndRWUPortDlg()
{
	// If there is an automation proxy for this dialog, set
	//  its back pointer to this dialog to NULL, so it knows
	//  the dialog has been deleted.
	if (m_pAutoProxy != NULL)
		m_pAutoProxy->m_pDialog = NULL;
}

void CACR120AntennaPowerAndRWUPortDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120AntennaPowerAndRWUPortDlg)
	DDX_Control(pDX, IDC_CHECK2, m_led);
	DDX_Control(pDX, IDC_CHECK1, m_buzz);
	DDX_Control(pDX, IDC_LIST1, m_List);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120AntennaPowerAndRWUPortDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120AntennaPowerAndRWUPortDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnPowerOn, OnBtnPowerOn)
	ON_BN_CLICKED(IDC_BtnAntennaPoweroff, OnBtnAntennaPoweroff)
	ON_BN_CLICKED(IDC_BtnRUPort, OnBtnRUPort)
	ON_BN_CLICKED(IDC_BtnWUPort, OnBtnWUPort)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlg message handlers

BOOL CACR120AntennaPowerAndRWUPortDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CACR120AntennaPowerAndRWUPortDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CACR120AntennaPowerAndRWUPortDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

// Automation servers should not exit when a user closes the UI
//  if a controller still holds on to one of its objects.  These
//  message handlers make sure that if the proxy is still in use,
//  then the UI is hidden but the dialog remains around if it
//  is dismissed.

void CACR120AntennaPowerAndRWUPortDlg::OnClose() 
{
	if (CanExit())
		CDialog::OnClose();
}

void CACR120AntennaPowerAndRWUPortDlg::OnOK() 
{
	if (CanExit())
		CDialog::OnOK();
}

void CACR120AntennaPowerAndRWUPortDlg::OnCancel() 
{
	if (CanExit())
		CDialog::OnCancel();
}

BOOL CACR120AntennaPowerAndRWUPortDlg::CanExit()
{
	// If the proxy object is still around, then the automation
	//  controller is still holding on to this application.  Leave
	//  the dialog around, but hide its UI.
	if (m_pAutoProxy != NULL)
	{
		ShowWindow(SW_HIDE);
		return FALSE;
	}

	return TRUE;
}

void CACR120AntennaPowerAndRWUPortDlg::OnBtnConnect() 
{

	unsigned char FirmwareVer [30];
	unsigned char FirmwareVer1 [19];
	unsigned char infolen;
	char FirmStr[100];
	int ctr,ctr2;

	STRUCT_STATUS ReaderStat;
	
		

    //'open port connection to ACR120 Reader 
    rHandle = ACR120_Open(m_Port.GetCurSel());
    
    //'Check if Handle is Valid
    if(rHandle < 0)
	{   
	   StrMsg.Format("Open connection to reader on USB %d failed(%d)", m_Port.GetCurSel() + 1, rHandle);
       LstIndx = m_List.AddString(StrMsg);
	   
    }
    else
	{  
       StrMsg.Format("Connected to USB %d", m_Port.GetCurSel()+1);
       LstIndx = m_List.AddString(StrMsg);

	   //Get the DLL version the program is using
		retcode = ACR120_RequestDLLVersion(&infolen, FirmwareVer);

		sprintf(FirmStr,"%s", "");
		memcpy(FirmStr, FirmwareVer, infolen);
	

		StrMsg.Format("DLL Version  :  %s ", FirmStr);
		LstIndx = m_List.AddString(StrMsg);

	
		//Get Firmware Version 
		retcode = ACR120_Status(rHandle, FirmwareVer1, &ReaderStat);
		sprintf(FirmStr,"%s", "");

		for (ctr = ctr2 = 0;ctr<infolen;ctr++)
		{   
			if ((FirmwareVer1[ctr] != 0) && (FirmwareVer1[ctr] != 0xFF))
			{   

				FirmStr[ctr2] = FirmwareVer1[ctr];
				ctr2++;
			}   
		

		}
	
		FirmStr[ctr2] = 0;
		StrMsg.Format("Firmware Version  :   %s ", FirmStr);
		LstIndx = m_List.AddString(StrMsg);


		

    }

	//AutoScroll Listbox
	m_List.SetCurSel(LstIndx);	
    
	
}



void CACR120AntennaPowerAndRWUPortDlg::OnBtnPowerOn() 
{
 //'Turn Antenna Power On
    retcode = ACR120_Power(rHandle, true);


    //'Check if Retcode is Error
    if (retcode < 0)
	{
       StrMsg.Format("Error Setting Antenna Power On: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Setting Antenna Power On Success: %d", retcode);
        LstIndx=m_List.AddString(StrMsg);
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);	
}

void CACR120AntennaPowerAndRWUPortDlg::OnBtnAntennaPoweroff() 
{

 
	
	//'Turn Antenna Power Off
    retcode = ACR120_Power(rHandle, false);


    //'Check if Retcode is Error
    if (retcode < 0)
	{
       StrMsg.Format("Error Setting Antenna Power Off: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Setting Antenna Power Off Success: %d", retcode);
        LstIndx=m_List.AddString(StrMsg);
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);	
}

void CACR120AntennaPowerAndRWUPortDlg::OnBtnRUPort() 
{
	BYTE portstat;


    //'read user port state
    retcode = ACR120_ReadUserPort(rHandle, &portstat);


    //'Check if Retcode is Error
    if (retcode < 0)
	{
       StrMsg.Format("Error Reading User Port Status: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Reading User Port Status Success: %d", retcode);
		LstIndx=m_List.AddString(StrMsg);


		if(portstat==4)
		{
		  StrMsg.Format("Buzzer ON  LED OFF: %x ", portstat);
		  LstIndx=m_List.AddString(StrMsg);
		}
        else if(portstat==64)
        {
		  StrMsg.Format("Buzzer OFF  LED ON: %x", portstat);
		  LstIndx=m_List.AddString(StrMsg);
		} 
		else if(portstat==68)
        {
		  StrMsg.Format("Buzzer ON  LED ON: %x", portstat);
		  LstIndx=m_List.AddString(StrMsg);
		} 
		else 
        {
		  StrMsg.Format("Buzzer OFF  LED OFF: %x", portstat);
		  LstIndx=m_List.AddString(StrMsg);
		} 
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);
		
}

void CACR120AntennaPowerAndRWUPortDlg::OnBtnWUPort() 
{


	
	if ((m_buzz.GetCheck()==1) && (m_led.GetCheck()==0))
	{
		sPort = 4;	
		StrMsg.Format("Buzzer ON  LED OFF:  %x", sPort);
        LstIndx=m_List.AddString(StrMsg);
	}
	else if ((m_buzz.GetCheck()==0) && (m_led.GetCheck()==1))
	{
		sPort = 64;	
		StrMsg.Format("Buzzer OFF  LED ON:  %x", sPort);
		LstIndx=m_List.AddString(StrMsg);
	}
	else if ((m_buzz.GetCheck()==1) && (m_led.GetCheck()==1))
	{
		sPort = 68;	
		StrMsg.Format("Buzzer ON  LED ON:  %x", sPort);
		LstIndx=m_List.AddString(StrMsg);
	}
	else 
	{
		sPort = 0;	
		StrMsg.Format("Buzzer OFF  LED OFF:  %x", sPort);
		LstIndx=m_List.AddString(StrMsg);
	}

  //'set User Port State
    retcode = ACR120_WriteUserPort(rHandle, sPort);
   
    //'Check if Retcode is Error
    if (retcode < 0)
	{
       StrMsg.Format("Error Setting User Port Status: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Setting User Port Status Success: %d", retcode);
		LstIndx=m_List.AddString(StrMsg);	

	}

    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);	
}

