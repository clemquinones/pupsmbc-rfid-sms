//'=======================================================================================================================
//'
//'   Project Name :  ACR120UTxDataTelegram
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  October 1, 2005
//'
//'   Description  :  This Sample Sends a Base/simple or ISO "t" Command. 
//'					  In this Sample Code the Command is Simple "Request for Answer to Select"(RATS)	
//'                   This also shows how to connect, Get reader Station ID, Reset and Select card
//'
//'
//'=========================================================================================================================



// ACR120TxDataTeleramSampleDlg.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120TxDataTeleramSample.h"
#include "ACR120TxDataTeleramSampleDlg.h"
#include "ACR120U.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120TxDataTeleramSampleDlg dialog

CACR120TxDataTeleramSampleDlg::CACR120TxDataTeleramSampleDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120TxDataTeleramSampleDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120TxDataTeleramSampleDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
}

void CACR120TxDataTeleramSampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120TxDataTeleramSampleDlg)
	DDX_Control(pDX, IDC_BtnConnect, m_Connect);
	DDX_Control(pDX, IDC_BtnReadBlock, m_TxtTele);
	DDX_Control(pDX, IDC_BtnSelect, m_Select);
	DDX_Control(pDX, IDC_LIST1, m_List);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120TxDataTeleramSampleDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120TxDataTeleramSampleDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnSelect, OnBtnSelect)
	ON_BN_CLICKED(IDC_BtnReadBlock, OnBtnReadBlock)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120TxDataTeleramSampleDlg message handlers

BOOL CACR120TxDataTeleramSampleDlg::OnInitDialog()
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

void CACR120TxDataTeleramSampleDlg::OnPaint() 
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
HCURSOR CACR120TxDataTeleramSampleDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CACR120TxDataTeleramSampleDlg::OnBtnConnect() 
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


void CACR120TxDataTeleramSampleDlg::OnBtnSelect() 
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


    	
	   //'Display Serial Number
       LstIndx =  m_List.AddString(StrMsg);
	   m_TxtTele.EnableWindow(true);
	  
    }
    
    //AutoScroll Listbox
   m_List.SetCurSel(LstIndx);	
}

void CACR120TxDataTeleramSampleDlg::OnBtnReadBlock() 
{

	BYTE cmd[50];
	BYTE rlen; 
	BYTE rdata[50];
	char pdata[50];
	int i;


   cmd[0] =  0x02;
   cmd[1] =  0x0F;
   cmd[2] =  0xE0;
   cmd[3] =  0x50;
   cmd[4] =  0x00;
   
   //'Send "t" command which in this case it is a "Request for Answer to Select(RATS)"

   retcode = ACR120_TxDataTelegram(rHandle,  5, cmd, &rlen, rdata);
	
    //'check if retcode is error
   if(retcode < 0){
	   StrMsg.Format("TxDataTelegram Error: %d", retcode);
       LstIndx=m_List.AddString(StrMsg);
   }
   else
   {
		StrMsg.Format("TxDataTelegram Success: %d", retcode);
		LstIndx=m_List.AddString(StrMsg);
		StrMsg.Format("Response Data Length: %d", rlen);
		LstIndx=m_List.AddString(StrMsg);

		 
		if (rlen > 0)
		{
			pdata[0] = 0;
			for(i = 0; i< rlen; i++)
			{
				
				StrMsg.Format(" %02x", rdata[i]);	
				strcat(pdata,StrMsg);
				
			}

				StrMsg.Format("Response Data: %s", pdata);
				LstIndx=m_List.AddString(StrMsg);
			

		}

   }


	
}


