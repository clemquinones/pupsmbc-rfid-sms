//'=========================================================================================
//'
//'   Project Name :  ACR120RWIDValueProj
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 30, 2005
//'
//'   Description  :  This Sample Reads and Writes Value to the Value Block.
//'                   Aided With Increment and Decrement Functions, this was Intended for
//'                   ease of use when the data need to be write on a block was a
//'                   numerical value which later to be use in computation.
//'                   This also shows how to Connect, Select card, and Login to card sector.
//'
//'   Initial Step :  1. Connect.
//'                   2. Select "Make sure that only 1 card is within antenna range".
//'                   3. Login to card sector that you want to manipulate.
//'
//'                                                                     
//'=========================================================================================



#include "stdafx.h"
#include "ACR120RWIncDecValue.h"
#include "ACR120RWIncDecValueDlg.h"
#include "DlgProxy.h"
#include "ACR120U.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlg dialog

IMPLEMENT_DYNAMIC(CACR120RWIncDecValueDlg, CDialog);

CACR120RWIncDecValueDlg::CACR120RWIncDecValueDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120RWIncDecValueDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120RWIncDecValueDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_pAutoProxy = NULL;
}

CACR120RWIncDecValueDlg::~CACR120RWIncDecValueDlg()
{
	// If there is an automation proxy for this dialog, set
	//  its back pointer to this dialog to NULL, so it knows
	//  the dialog has been deleted.
	if (m_pAutoProxy != NULL)
		m_pAutoProxy->m_pDialog = NULL;
}

void CACR120RWIncDecValueDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120RWIncDecValueDlg)
	DDX_Control(pDX, IDC_BtnWV, m_WV);
	DDX_Control(pDX, IDC_BtnSelect, m_Select);
	DDX_Control(pDX, IDC_BtnRV, m_RV);
	DDX_Control(pDX, IDC_BtnLogIn, m_Login);
	DDX_Control(pDX, IDC_BtnInc, m_Inc);
	DDX_Control(pDX, IDC_BtnDec, m_Dec);
	DDX_Control(pDX, IDC_BtnConnect, m_Connect);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	DDX_Control(pDX, IDC_LIST1, m_List);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120RWIncDecValueDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120RWIncDecValueDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnSelect, OnBtnSelect)
	ON_BN_CLICKED(IDC_BtnLogIn, OnBtnLogIn)
	ON_BN_CLICKED(IDC_BtnWV, OnBtnWV)
	ON_BN_CLICKED(IDC_BtnRV, OnBtnRV)
	ON_BN_CLICKED(IDC_BtnInc, OnBtnInc)
	ON_BN_CLICKED(IDC_BtnDec, OnBtnDec)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlg message handlers

BOOL CACR120RWIncDecValueDlg::OnInitDialog()
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

void CACR120RWIncDecValueDlg::OnPaint() 
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
HCURSOR CACR120RWIncDecValueDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

// Automation servers should not exit when a user closes the UI
//  if a controller still holds on to one of its objects.  These
//  message handlers make sure that if the proxy is still in use,
//  then the UI is hidden but the dialog remains around if it
//  is dismissed.

void CACR120RWIncDecValueDlg::OnClose() 
{
	if (CanExit())
		CDialog::OnClose();
}

void CACR120RWIncDecValueDlg::OnOK() 
{
	if (CanExit())
		CDialog::OnOK();
}

void CACR120RWIncDecValueDlg::OnCancel() 
{
	if (CanExit())
		CDialog::OnCancel();
}

BOOL CACR120RWIncDecValueDlg::CanExit()
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

void CACR120RWIncDecValueDlg::OnBtnConnect() 
{
	
	UINT8 FirmwareVer [30];
	UINT8 FirmwareVer1 [19];
	UINT8 infolen;
	char FirmStr[100];
	int ctr,ctr2;

	STRUCT_STATUS ReaderStat;
	
	

    //'open port connection to ACR120 Reader.
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
		m_Select.EnableWindow(true);

		

    }

	//AutoScroll Listbox
	m_List.SetCurSel(LstIndx);	
    
	

}


void CACR120RWIncDecValueDlg::OnBtnSelect() 
{
	BYTE ResultSN[11];
	BYTE TagType[50];
	BYTE ResultTag;
	char SN[100];


     //'Selects a single card and returns the card ID (Serial Number)
     retcode = ACR120_Select(rHandle, TagType, &ResultTag, ResultSN);
     
    
    //'Check if Retcode is Error
    if (retcode < 0)
	{
       StrMsg.Format("Error Select: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Select Card Success: %d", retcode);
        LstIndx=m_List.AddString(StrMsg);
		sprintf(SN,"%s","");
		 if ((TagType[0] == 4) || (TagType[0] == 5))
		 {
			memcpy(SN,ResultSN, 7);
			StrMsg.Format("Card Serial: %02x %02x %02x %02x %02x %02x %02x ",ResultSN[0],ResultSN[1],ResultSN[2],ResultSN[3],ResultSN[4],ResultSN[5],ResultSN[6] );
		 }
		 else
			memcpy(SN,ResultSN, ResultTag);
       
		
		 if (ResultTag == 4)
			StrMsg.Format("Card Serial: %02x %02x %02x %02x  ",ResultSN[0],ResultSN[1],ResultSN[2],ResultSN[3] );
		 else if (ResultTag == 7)
			StrMsg.Format("Card Serial: %02x %02x %02x %02x %02x %02x %02x ",ResultSN[0],ResultSN[1],ResultSN[2],ResultSN[3],ResultSN[4],ResultSN[5],ResultSN[6] );
		 else if (ResultTag == 10)
			StrMsg.Format("Card Serial: %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x ",ResultSN[0],ResultSN[1],ResultSN[2],ResultSN[3],ResultSN[4],ResultSN[5],ResultSN[6],ResultSN[7],ResultSN[8],ResultSN[9] );


    	
       m_Login.EnableWindow(true); 
	   //'Display Serial Number
       LstIndx =  m_List.AddString(StrMsg);
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);
       	
}

void CACR120RWIncDecValueDlg::OnBtnLogIn() 
{
BYTE pKey[5];


    //'Log in to Sector 1, LogType 0xAA, please refer to the Documentation about the different Logtype
    // Using pKey = 0xFF 0xFF 0xFF 0xFF 0xFF 0xFF
    pKey[0]= 255;
	pKey[1]= 255;
	pKey[2]= 255;
	pKey[3]= 255;
	pKey[4]= 255;
	pKey[5]= 255;
	
	//Login Command Function
    retcode = ACR120_Login(rHandle, 1, 0xAA, 0, pKey);
     
     
    //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("Error Login: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("Login Success: %d", retcode);
		m_List.AddString(StrMsg);

        LstIndx = m_List.AddString("Log at Sector: 1"); 
		m_RV.EnableWindow(true); 
		m_WV.EnableWindow(true); 
		m_Dec.EnableWindow(true); 
		m_Inc.EnableWindow(true); 
	}
    
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);

    //NOTE: If you are to Login to Sector 32 to 39 for other cards use the computation below.
    
   //If Sector > 31 
   //     
   //     PhysicalSector = Sec + ((Sec - 32) * 3);
   //Else
   //     PhysicalSector = Sector;
   

   //retcode = ACR120_Login(rHandle, PhysicalSector, vKeyType, sto, pKey(0));

}

void CACR120RWIncDecValueDlg::OnBtnWV() 
{
  //'write 500 value to (Sector 1 Block 1 = Block 5)
     retcode = ACR120_WriteValue(rHandle, 5, 500);

    //'check if retcode was error
    if(retcode < 0)
	{
       StrMsg.Format("Error Write Value: %d", retcode);
	   LstIndx=m_List.AddString(StrMsg);
	}
    else
    {
       StrMsg.Format("Write Value 500 Success: %d", retcode);
	   LstIndx=m_List.AddString(StrMsg);
	}	

    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);	
}

void CACR120RWIncDecValueDlg::OnBtnRV() 
{
int pVal;
    
	//'read value of (Sector 1 Block 1 = Block 5)
    retcode = ACR120_ReadValue(rHandle, 5, &pVal);


    //'check if retcode is error
    if (retcode < 0)
	{
         StrMsg.Format("Read Value Error: %d", retcode);
	     LstIndx=m_List.AddString(StrMsg);
	}  
    else
	{
         StrMsg.Format("Read Value Success: %d", retcode);
	     m_List.AddString(StrMsg);

		 StrMsg.Format("Value Read: %d", pVal);
	     LstIndx=m_List.AddString(StrMsg);

	}
	
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);	
}

void CACR120RWIncDecValueDlg::OnBtnInc() 
{

	int NewVal;
    
	//'Increment Value of (Sector 1 Block 1 = block 5) by 500

    retcode = ACR120_Inc(rHandle, 5, 500, &NewVal);

    //'check if retcode is error
    if (retcode < 0) 
	{
       	 StrMsg.Format("Increment Value Error: %d", retcode);
	     LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
       	 StrMsg.Format("Increment Value by 500 Success: %d", retcode );
	     LstIndx=m_List.AddString(StrMsg);

		 StrMsg.Format("New Value: %d", NewVal);
	     LstIndx=m_List.AddString(StrMsg);
    }
	
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);	
}

void CACR120RWIncDecValueDlg::OnBtnDec() 
{

int NewVal;
    //'Decrement Value of (Sector 1 Block 1 = block 5) by 500
    retcode = ACR120_Dec(rHandle, 5, 500, &NewVal);

    //'check if retcode is error
    if (retcode < 0) 
	{
       	 StrMsg.Format("Decrement Value Error: %d", retcode);
	     LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
       	 StrMsg.Format("Decrement Value by 500 Success: %d", retcode );
	     LstIndx=m_List.AddString(StrMsg);

		 StrMsg.Format("New Value: %d", NewVal);
	     LstIndx=m_List.AddString(StrMsg);
    }
	
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);		
}
