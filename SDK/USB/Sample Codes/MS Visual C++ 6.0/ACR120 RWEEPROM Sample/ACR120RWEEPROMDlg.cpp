//'=========================================================================================
//'
//'   Project Name :  ACR120URWEEPROM
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 26, 2005
//'
//'   Description  :  This Sample Reads and Writes to ACR120 Reader EEPROM.
//'                   Register Ranges From 0 to 19, and Register 4 is The StationID .
//'                   This also shows how to connect, Get reader Station ID, Reset.
//'
//'   Initial Step :  1. Connect.
//'                   2. Choose from the function frame.
//'
//'                                                                     
//'=========================================================================================


#include "stdafx.h"
#include "ACR120RWEEPROM.h"
#include "ACR120RWEEPROMDlg.h"
#include "DlgProxy.h"
#include "ACR120U.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlg dialog

IMPLEMENT_DYNAMIC(CACR120RWEEPROMDlg, CDialog);

CACR120RWEEPROMDlg::CACR120RWEEPROMDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120RWEEPROMDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120RWEEPROMDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_pAutoProxy = NULL;
}

CACR120RWEEPROMDlg::~CACR120RWEEPROMDlg()
{
	// If there is an automation proxy for this dialog, set
	//  its back pointer to this dialog to NULL, so it knows
	//  the dialog has been deleted.
	if (m_pAutoProxy != NULL)
		m_pAutoProxy->m_pDialog = NULL;
}

void CACR120RWEEPROMDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120RWEEPROMDlg)
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	DDX_Control(pDX, IDC_LIST1, m_List);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120RWEEPROMDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120RWEEPROMDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnREEPROM, OnBtnREEPROM)
	ON_BN_CLICKED(IDC_BtnWEEPROM, OnBtnWEEPROM)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlg message handlers

BOOL CACR120RWEEPROMDlg::OnInitDialog()
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

void CACR120RWEEPROMDlg::OnPaint() 
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
HCURSOR CACR120RWEEPROMDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

// Automation servers should not exit when a user closes the UI
//  if a controller still holds on to one of its objects.  These
//  message handlers make sure that if the proxy is still in use,
//  then the UI is hidden but the dialog remains around if it
//  is dismissed.

void CACR120RWEEPROMDlg::OnClose() 
{
	if (CanExit())
		CDialog::OnClose();
}

void CACR120RWEEPROMDlg::OnOK() 
{
	if (CanExit())
		CDialog::OnOK();
}

void CACR120RWEEPROMDlg::OnCancel() 
{
	if (CanExit())
		CDialog::OnCancel();
}

BOOL CACR120RWEEPROMDlg::CanExit()
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

void CACR120RWEEPROMDlg::OnBtnConnect() 
{

	UINT8 FirmwareVer [30];
	UINT8 FirmwareVer1 [19];
	UINT8 infolen;
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


void CACR120RWEEPROMDlg::OnBtnREEPROM() 
{
BYTE eePROMData;


	//'Read EEPROM register 4 (Station ID)
    retcode = ACR120_ReadEEPROM(rHandle, 4, &eePROMData);


    //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("Error Reading EEPROM: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("Reading EEPROM Success: %d", retcode);
		m_List.AddString(StrMsg);
        
		StrMsg.Format("EEPROM Register 4 Value: 0x%X", eePROMData);
		LstIndx =m_List.AddString(StrMsg);
        
	}
    
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);
		
}

void CACR120RWEEPROMDlg::OnBtnWEEPROM() 
{
BYTE eePROMData;
 
    //'Write 32 (0x20) to Register 4 (Station ID) of EEPROM
     retcode = ACR120_WriteEEPROM(rHandle, 4, 66);


    //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("Error Writing to EEPROM: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("Writing to EEPROM Success: %d", retcode);
		m_List.AddString(StrMsg);
        
		StrMsg.Format("Value Written to EEPROM Register 4: 0x%X", 66);
		m_List.AddString(StrMsg);
        
	}



    //'Read EEPROM register 4 (Station ID)
    retcode = ACR120_ReadEEPROM(rHandle, 4, &eePROMData);


    //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("Error Reading EEPROM: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("Reading EEPROM Success: %d", retcode);
		m_List.AddString(StrMsg);
        
		StrMsg.Format("EEPROM Register 4 Value: 0x%X", eePROMData);
		m_List.AddString(StrMsg);
        
	}
    
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);


	

}
