//'=========================================================================================
//'
//'   Project Name :  ACR120UStatus
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 30, 2005
//'
//    Description  :  This Sample Pragram that shows the STATUS of the Reader
//'
//'                   This also shows how to Connect.
//'
//'   Initial Step :  1. Connect.
//'                   2. Click Status Button.
//'
//'
//'=========================================================================================

#include "stdafx.h"
#include "ACR120Status.h"
#include "ACR120StatusDlg.h"
#include "ACR120U.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120StatusDlg dialog

CACR120StatusDlg::CACR120StatusDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120StatusDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120StatusDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
}

void CACR120StatusDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120StatusDlg)
	DDX_Control(pDX, IDC_BtnConnect, m_Connect);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	DDX_Control(pDX, IDC_LIST1, m_List);
	DDX_Control(pDX, IDC_Status, m_Status);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120StatusDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120StatusDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_Status, OnStatus)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120StatusDlg message handlers

BOOL CACR120StatusDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CACR120StatusDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CACR120StatusDlg::OnPaint() 
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
HCURSOR CACR120StatusDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CACR120StatusDlg::OnBtnConnect() 
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

		//AutoScroll Listbox
		m_List.SetCurSel(LstIndx);
		

    }

	//AutoScroll Listbox
	m_List.SetCurSel(LstIndx);		
}

void CACR120StatusDlg::OnStatus() 
{
	UINT8 FirmwareVer [30];
	UINT8 FirmwareVer1 [19];
	UINT8 infolen;
	char FirmStr[100];
	int ctr,ctr2;

	STRUCT_STATUS ReaderStat;	
	
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
		
		
		
		StrMsg.Format("Card Supported  :   %08x ", ReaderStat.CardsSupported);
		LstIndx = m_List.AddString(StrMsg);

		if (ReaderStat.CardsSupported & 1 )
		{
			StrMsg.Format(">> Mifare Light ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 2 )
		{
			StrMsg.Format(">> Mifare 1K ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 4 )
		{
			StrMsg.Format(">> Mifare 4K ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 8 )
		{
			StrMsg.Format(">> Mifare DESFire ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 16 )
		{
			StrMsg.Format(">> Mifare UltraLight ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 32 )
		{
			StrMsg.Format(">> JCOP30 ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 64 )
		{
			StrMsg.Format(">> Shanghai Transport ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 128 )
		{
			StrMsg.Format(">> MPCOS Combi ");
			LstIndx = m_List.AddString(StrMsg);
		}

		if (ReaderStat.CardsSupported & 256 )
		{
			StrMsg.Format(">> ISO type B, Calypso ");
			LstIndx = m_List.AddString(StrMsg);
		}
	
		//Display the Interface Type
		if (ReaderStat.MifareInterfaceType == 1)
		{
			StrMsg.Format("Interface Type : Type A");
			LstIndx = m_List.AddString(StrMsg);
		}
		else if (ReaderStat.MifareInterfaceType == 2)
		{
			StrMsg.Format("Interface Type : Type B");
			LstIndx = m_List.AddString(StrMsg);
		}
		else if (ReaderStat.MifareInterfaceType == 3)
		{
			StrMsg.Format("Interface Type : Type A + Type B");
			LstIndx = m_List.AddString(StrMsg);
		}


	//AutoScroll Listbox
	m_List.SetCurSel(LstIndx);	
}
