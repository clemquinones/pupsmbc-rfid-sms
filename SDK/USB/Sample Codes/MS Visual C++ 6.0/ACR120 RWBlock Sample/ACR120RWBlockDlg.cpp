//'=========================================================================================
//'
//'   Project Name :  ACR120RWBlock
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 30, 2005
//'
//'   Description  :  This Sample Reads and Writes to block of Contactless Card.
//'                   This also shows how to Connect, Select card, and Login to card sector.
//'
//'   Initial Step :  1. Connect.
//'                   2. Select "Make sure that only 1 card is within antenna range".
//'                   3. Login to card sector that you want to manipulate.
//'
//'
//'                                                                     
//'=========================================================================================

#include "stdafx.h"
#include "ACR120RWBlock.h"
#include "ACR120RWBlockDlg.h"
#include "DlgProxy.h"
#include "ACR120U.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlg dialog

IMPLEMENT_DYNAMIC(CACR120RWBlockDlg, CDialog);

CACR120RWBlockDlg::CACR120RWBlockDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120RWBlockDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120RWBlockDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_pAutoProxy = NULL;
}

CACR120RWBlockDlg::~CACR120RWBlockDlg()
{
	// If there is an automation proxy for this dialog, set
	//  its back pointer to this dialog to NULL, so it knows
	//  the dialog has been deleted.
	if (m_pAutoProxy != NULL)
		m_pAutoProxy->m_pDialog = NULL;
}

void CACR120RWBlockDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120RWBlockDlg)
	DDX_Control(pDX, IDC_BtnWriteBlock, m_WriteBlock);
	DDX_Control(pDX, IDC_BtnSelect, m_Select);
	DDX_Control(pDX, IDC_BtnReadBlock, m_ReadBlock);
	DDX_Control(pDX, IDC_BtnLogIn, m_Login);
	DDX_Control(pDX, IDC_BtnConnect, m_Connect);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	DDX_Control(pDX, IDC_LIST1, m_List);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120RWBlockDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120RWBlockDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnSelect, OnBtnSelect)
	ON_BN_CLICKED(IDC_BtnLogIn, OnBtnLogIn)
	ON_BN_CLICKED(IDC_BtnReadBlock, OnBtnReadBlock)
	ON_BN_CLICKED(IDC_BtnWriteBlock, OnBtnWriteBlock)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlg message handlers

BOOL CACR120RWBlockDlg::OnInitDialog()
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

void CACR120RWBlockDlg::OnPaint() 
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
HCURSOR CACR120RWBlockDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

// Automation servers should not exit when a user closes the UI
//  if a controller still holds on to one of its objects.  These
//  message handlers make sure that if the proxy is still in use,
//  then the UI is hidden but the dialog remains around if it
//  is dismissed.

void CACR120RWBlockDlg::OnClose() 
{
	if (CanExit())
		CDialog::OnClose();
}

void CACR120RWBlockDlg::OnOK() 
{
	if (CanExit())
		CDialog::OnOK();
}

void CACR120RWBlockDlg::OnCancel() 
{
	if (CanExit())
		CDialog::OnCancel();
}

BOOL CACR120RWBlockDlg::CanExit()
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

void CACR120RWBlockDlg::OnBtnConnect() 
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



void CACR120RWBlockDlg::OnBtnSelect() 
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

void CACR120RWBlockDlg::OnBtnLogIn() 
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
		m_ReadBlock.EnableWindow(true); 
		m_WriteBlock.EnableWindow(true); 
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

void CACR120RWBlockDlg::OnBtnReadBlock() 
{
BYTE dataRead[15];
	
	//'read Block 1 of Sector 1 = Block 5
    retcode = ACR120_Read(rHandle, 5, dataRead);


    //'check if retcode is error
    if (retcode < 0)
	{
       StrMsg.Format("Error Reading Block 5: %d",retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Read Block 5 Success: %d", retcode);
        LstIndx=m_List.AddString(StrMsg);


	   //'Convert Data Read to Hex Format.
          StrMsg.Format("Read Block Data: %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x",
			  dataRead[0],dataRead[1],dataRead[2],dataRead[3],dataRead[4],dataRead[5],
			  dataRead[6],dataRead[7],dataRead[8],dataRead[9],dataRead[10],dataRead[11],
			  dataRead[12],dataRead[13],dataRead[14],dataRead[15]);
       
	   //'Display Serial Number
       LstIndx =  m_List.AddString(StrMsg);
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);

		
}

void CACR120RWBlockDlg::OnBtnWriteBlock() 
{

	BYTE dout[15];
	
	//Write the Word "ACSMiFare Sample" = hex(41, 43, 53, 4D, 69, 46, 61, 72, 65, 20, 53, 61, 6D, 70, 6C, 65)
    dout[0] = 65; //A
    dout[1] =67;  //C
	dout[2] =83;  //S
	dout[3] =77;  //M
	dout[4] =105; //i
	dout[5] =70;  //F
	dout[6] =97;  //a
	dout[7] =114; //r
	dout[8] =101; //e
	dout[9] =32;  // 
	dout[10] =83; //S
	dout[11] =97; //a
	dout[12] =109; //m
	dout[13] =112; //p
	dout[14] =108; //l
	dout[15] =101; //e

    //Write to Sector 1 Block 1 = Block 5
    retcode = ACR120_Write(rHandle, 5, dout);

    //'check if retcode is error
    if (retcode < 0)
	{
       StrMsg.Format("Error Writing to Block 5: %d",retcode);
       LstIndx=m_List.AddString(StrMsg);
    }
    else
    {
		StrMsg.Format("Write to Block 5 Success: %d", retcode);
        LstIndx=m_List.AddString(StrMsg);

    }

    m_List.SetCurSel(LstIndx);
	
}
