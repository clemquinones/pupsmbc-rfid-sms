//'===============================================================================================================
//'
//'   Project Name :  ACR120UMultiTagSelectProj
//'
//'   Company      :  Advanced Card Systems LTD.
//'
//'   Author       :  Fernando G. Robles
//'
//'   Date         :  September 27, 2005
//'
//'   Description  :  This Sample Select a specific Mifare1 Card, when there are more than
//'                   one Non-Contact present within the readable range of ACR120 reader
//'                   using the serial number of the card.
//'                   You can see the serial number of the Non-Contact cards in range by using the
//'                   ListTag command.
//'                   This also shows how to Connect, and Login to card sector.
//'
//'   Initial Step :  1. Connect.
//'                   2. Login to card sector that you want to manipulate.
//'
//'
//'                                                                     
//'=================================================================================================================
//

#include "stdafx.h"
#include "ACR120MulitTagSelect.h"
#include "ACR120MulitTagSelectDlg.h"
#include "DlgProxy.h"
#include "ACR120U.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlg dialog

IMPLEMENT_DYNAMIC(CACR120MulitTagSelectDlg, CDialog);

CACR120MulitTagSelectDlg::CACR120MulitTagSelectDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CACR120MulitTagSelectDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CACR120MulitTagSelectDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_pAutoProxy = NULL;
}

CACR120MulitTagSelectDlg::~CACR120MulitTagSelectDlg()
{
	// If there is an automation proxy for this dialog, set
	//  its back pointer to this dialog to NULL, so it knows
	//  the dialog has been deleted.
	if (m_pAutoProxy != NULL)
		m_pAutoProxy->m_pDialog = NULL;
}

void CACR120MulitTagSelectDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CACR120MulitTagSelectDlg)
	DDX_Control(pDX, IDC_EDIT10, m_Edit10);
	DDX_Control(pDX, IDC_RADIO3, m_radio10);
	DDX_Control(pDX, IDC_RADIO2, m_radio7);
	DDX_Control(pDX, IDC_RADIO1, m_radio4);
	DDX_Control(pDX, IDC_EDIT9, m_Edit9);
	DDX_Control(pDX, IDC_EDIT8, m_Edit8);
	DDX_Control(pDX, IDC_EDIT7, m_Edit7);
	DDX_Control(pDX, IDC_EDIT6, m_Edit6);
	DDX_Control(pDX, IDC_EDIT5, m_Edit5);
	DDX_Control(pDX, IDC_EDIT4, m_Edit4);
	DDX_Control(pDX, IDC_EDIT3, m_Edit3);
	DDX_Control(pDX, IDC_EDIT2, m_Edit2);
	DDX_Control(pDX, IDC_EDIT1, m_Edit1);
	DDX_Control(pDX, IDC_CONNECT_TYPE, m_Port);
	DDX_Control(pDX, IDC_LIST1, m_List);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CACR120MulitTagSelectDlg, CDialog)
	//{{AFX_MSG_MAP(CACR120MulitTagSelectDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BtnConnect, OnBtnConnect)
	ON_BN_CLICKED(IDC_BtnLogIn, OnBtnLogIn)
	ON_BN_CLICKED(IDC_BtnListTag, OnBtnListTag)
	ON_BN_CLICKED(IDC_BtnMultiTagSelect, OnBtnMultiTagSelect)
	ON_BN_CLICKED(IDC_RADIO1, OnRadio1)
	ON_BN_CLICKED(IDC_RADIO2, OnRadio2)
	ON_BN_CLICKED(IDC_RADIO3, OnRadio3)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlg message handlers

BOOL CACR120MulitTagSelectDlg::OnInitDialog()
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

void CACR120MulitTagSelectDlg::OnPaint() 
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
HCURSOR CACR120MulitTagSelectDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

// Automation servers should not exit when a user closes the UI
//  if a controller still holds on to one of its objects.  These
//  message handlers make sure that if the proxy is still in use,
//  then the UI is hidden but the dialog remains around if it
//  is dismissed.

void CACR120MulitTagSelectDlg::OnClose() 
{
	if (CanExit())
		CDialog::OnClose();
}

void CACR120MulitTagSelectDlg::OnOK() 
{
	if (CanExit())
		CDialog::OnOK();
}

void CACR120MulitTagSelectDlg::OnCancel() 
{
	if (CanExit())
		CDialog::OnCancel();
}

BOOL CACR120MulitTagSelectDlg::CanExit()
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

void CACR120MulitTagSelectDlg::OnBtnConnect() 
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



void CACR120MulitTagSelectDlg::OnBtnLogIn() 
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

void CACR120MulitTagSelectDlg::OnBtnListTag() 
{
BYTE SN[4][10];
BYTE Tag[50];
BYTE TagLength[50];
BYTE TCount;
int ctr;
int ctr1,ctr2;
char GetTagType[100]; 



    //'Get List of Tags with/in readable Range
    retcode = ACR120_ListTags(rHandle, &TCount, Tag, TagLength, SN);

    //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("ListTag Error: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("ListTag Success: %d", retcode);
		m_List.AddString(StrMsg);

        StrMsg.Format("Tag Found: %d", TCount);
		LstIndx = m_List.AddString(StrMsg);
      
		
    	//Display Serial Numbers Found <Loop to Number of TagFound(TCount)>
		ctr1 = 0;
		ctr = 0;
        for( ctr1 = 0 ; ctr1 < TCount; ctr1++)
		{
           
			
			ctr2 = 0;
			ctr = ctr1 * 10;
			
			//Determin the Tag Type of the Card.
			if (Tag[ctr1] == 1)
				strcpy(GetTagType, "Mifare Light");
			else if (Tag[ctr1] == 2)
				strcpy(GetTagType, "Mifare 1K");
			else if (Tag[ctr1] == 3)
				strcpy(GetTagType, "Mifare 4K");
			else if (Tag[ctr1] == 4)
				strcpy(GetTagType, "Mifare DESFire");
			else if (Tag[ctr1] == 5)
				strcpy(GetTagType, "Mifare Ultralight");
			else if (Tag[ctr1] == 6)
				strcpy(GetTagType, "JCOP30");
			else if (Tag[ctr1] == 7)
				strcpy(GetTagType, "Shanghai Transport");
			else if (Tag[ctr1] == 8)
				strcpy(GetTagType, "MPCOS Combi");
			else if (Tag[ctr1] == 0x80)
				strcpy(GetTagType, "ISO Type B, Calypso");

			//Displays the Serial number and Tag Type of all the cards detected by the reader

			if (TagLength[ctr1] == 4)
				StrMsg.Format("Tag ( %d )  %02x %02x %02x %02x (%s) ", ctr1, SN[ctr1][0],SN[ctr1][1],SN[ctr1][2],SN[ctr1][3], GetTagType);
			else if (TagLength[ctr1] == 7)
				StrMsg.Format("Tag ( %d )  %02x %02x %02x %02x %02x %02x %02x (%s) ", ctr1, SN[ctr1][0],SN[ctr1][1],SN[ctr1][2],SN[ctr1][3],SN[ctr1][4],SN[ctr1][5],SN[ctr1][6], GetTagType);
			else if (TagLength[ctr1] == 10)
				StrMsg.Format("Tag ( %d)  %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x (%s) ", ctr1, SN[ctr1][0],SN[ctr1][1],SN[ctr1][2],SN[ctr1][3],SN[ctr1][4],SN[ctr1][5],SN[ctr1][6],SN[ctr1][7],SN[ctr1][8],SN[ctr1][9], GetTagType);

      
		
			//'Display Serial Number
			LstIndx =  m_List.AddString(StrMsg);

			m_radio4.EnableWindow(true);	
			m_radio7.EnableWindow(true);	
			m_radio10.EnableWindow(true);	
			m_radio4.SetCheck(1);
			m_radio7.SetCheck(0);
			m_radio10.SetCheck(0);
			m_Edit1.EnableWindow(true);
			m_Edit2.EnableWindow(true);
			m_Edit3.EnableWindow(true);
			m_Edit4.EnableWindow(true);

		}

	
		
	}
    
    //Autoscroll Listbox
	m_List.SetCurSel(LstIndx);
     
	
	
}



BYTE HexStrToByte (char *s)
{

	BYTE b1, b2;
	b1 = b2 = 0;

	//Convertion of String HEX to Byte
	if (s[0] <= '9' && s[0] >= '0')
	{
		b1 = s[0] - '0';
	}
	else
		if (s[0] <= 'F' && s[0] >= 'A')
		{
			b1 = s[0] - 'A' + 10;
		}
	if (s[1] <= '9' && s[1] >= '0')
	{
		b2 = s[1] - '0';
	}
	else
		if (s[1] <= 'F' && s[1] >= 'A')
		{
			b2 = s[1] - 'A' + 10;
		}
	return (b1 << 4) + b2;
}




void CACR120MulitTagSelectDlg::OnBtnMultiTagSelect() 
{
BYTE SerialNum[10];
BYTE TagLength;
BYTE TagType[50];
BYTE RTag;
BYTE RSn[7];
char Str[4];
char SN[100];
char GetTagType[100]; 


     //'assign Serial number to array variable (Convert Hex to decimal before Assigning)
     
	if (m_radio4.GetCheck() == 1) //4 Bytes HEX Serial Number
	{
		m_Edit1.GetWindowText(Str,4);	 
		SerialNum[0] = HexStrToByte((char *)Str);

		m_Edit2.GetWindowText(Str,4);	 
		SerialNum[1] = HexStrToByte((char *)Str);

		m_Edit3.GetWindowText(Str,4);	 
		SerialNum[2] = HexStrToByte((char *)Str);

		m_Edit4.GetWindowText(Str,4);	 
		SerialNum[3] = HexStrToByte((char *)Str);

		TagLength = 4;
	}
	else if (m_radio7.GetCheck() == 1) //7 Bytes HEX Serial Number
	{
		m_Edit1.GetWindowText(Str,4);	 
		SerialNum[0] = HexStrToByte((char *)Str);

		m_Edit2.GetWindowText(Str,4);	 
		SerialNum[1] = HexStrToByte((char *)Str);

		m_Edit3.GetWindowText(Str,4);	 
		SerialNum[2] = HexStrToByte((char *)Str);

		m_Edit4.GetWindowText(Str,4);	 
		SerialNum[3] = HexStrToByte((char *)Str);

		m_Edit5.GetWindowText(Str,4);	 
		SerialNum[4] = HexStrToByte((char *)Str);

		m_Edit6.GetWindowText(Str,4);	 
		SerialNum[5] = HexStrToByte((char *)Str);

		m_Edit7.GetWindowText(Str,4);	 
		SerialNum[6] = HexStrToByte((char *)Str);

		TagLength = 7;

	}
	else if (m_radio10.GetCheck() == 1) //10 Bytes HEX Serial Number
	{
		m_Edit1.GetWindowText(Str,4);	 
		SerialNum[0] = HexStrToByte((char *)Str);

		m_Edit2.GetWindowText(Str,4);	 
		SerialNum[1] = HexStrToByte((char *)Str);

		m_Edit3.GetWindowText(Str,4);	 
		SerialNum[2] = HexStrToByte((char *)Str);

		m_Edit4.GetWindowText(Str,4);	 
		SerialNum[3] = HexStrToByte((char *)Str);

		m_Edit5.GetWindowText(Str,4);	 
		SerialNum[4] = HexStrToByte((char *)Str);

		m_Edit6.GetWindowText(Str,4);	 
		SerialNum[5] = HexStrToByte((char *)Str);

		m_Edit7.GetWindowText(Str,4);	 
		SerialNum[6] = HexStrToByte((char *)Str);

		m_Edit8.GetWindowText(Str,4);	 
		SerialNum[7] = HexStrToByte((char *)Str);

		m_Edit9.GetWindowText(Str,4);	 
		SerialNum[8] = HexStrToByte((char *)Str);

		m_Edit10.GetWindowText(Str,4);	 
		SerialNum[9] = HexStrToByte((char *)Str);

		TagLength = 10;

	}

          

     
     //'select specific card based from serial number
	retcode = ACR120_MultiTagSelect(rHandle, TagLength, SerialNum, TagType, &RTag, RSn);
	
     //'check if retcode is error
    if (retcode < 0)
	{
		StrMsg.Format("MultiTag Select Error: %d", retcode);
	    LstIndx = m_List.AddString(StrMsg);
	}  
    else
	{
	    StrMsg.Format("MultiTag Select Success: %d", retcode);
		m_List.AddString(StrMsg);

		if ((TagType[0] == 4) || (TagType[0] == 5))
		{
			memcpy(SN,RSn,7);
		}
		else
		{
			memcpy(SN,RSn,TagLength);
		}

		//Determine the Tag Type of the Card.
		if (TagType[0] == 1)
			strcpy(GetTagType, "Mifare Light");
		else if (TagType[0] == 2)
			strcpy(GetTagType, "Mifare 1K");
		else if (TagType[0] == 3)
			strcpy(GetTagType, "Mifare 4K");
		else if (TagType[0] == 4)
			strcpy(GetTagType, "Mifare DESFire");
		else if (TagType[0] == 5)
			strcpy(GetTagType, "Mifare Ultralight");
		else if (TagType[0] == 6)
			strcpy(GetTagType, "JCOP30");
		else if (TagType[0] == 7)
			strcpy(GetTagType, "Shanghai Transport");
		else if (TagType[0] == 8)
			strcpy(GetTagType, "MPCOS Combi");
		else if (TagType[0] == 0x80)
			strcpy(GetTagType, "ISO Type B, Calypso");


		

		if (TagLength == 4) // Display 4 Bytes HEX Serial Number
			StrMsg.Format("SN: %02x %02x %02x %02x ", RSn[0],RSn[1],RSn[2],RSn[3]);
			
		else if (TagLength == 7) // Display 7 Bytes HEX Serial Number
			StrMsg.Format("SN: %02x %02x %02x %02x %02x %02x %02x ", RSn[0],RSn[1],RSn[2],RSn[3],RSn[4],RSn[5],RSn[6]);
			
		else if (TagLength == 10) // Display 10 Bytes HEX Serial Number
			StrMsg.Format("SN: %02x %02x %02x %02x %02x %02x %02x %02x %02x %02x ", RSn[0],RSn[1],RSn[2],RSn[3],RSn[4],RSn[5],RSn[6],RSn[7],RSn[8],RSn[9]);
			
		

		LstIndx = m_List.AddString(StrMsg);
    }    
        
    //Autoscroll ListBox
	m_List.SetCurSel(LstIndx);

	


		
}

void CACR120MulitTagSelectDlg::OnRadio1() 
{
	m_radio4.SetCheck(1);
	m_radio7.SetCheck(0);
	m_radio10.SetCheck(0);	
	m_Edit1.EnableWindow(true);
	m_Edit2.EnableWindow(true);
	m_Edit3.EnableWindow(true);
	m_Edit4.EnableWindow(true);
	m_Edit5.EnableWindow(false);
	m_Edit6.EnableWindow(false);
	m_Edit7.EnableWindow(false);
	m_Edit8.EnableWindow(false);
	m_Edit9.EnableWindow(false);
	m_Edit10.EnableWindow(false);
}

void CACR120MulitTagSelectDlg::OnRadio2() 
{
	m_radio4.SetCheck(0);
	m_radio7.SetCheck(1);
	m_radio10.SetCheck(0);	
	m_Edit1.EnableWindow(true);
	m_Edit2.EnableWindow(true);
	m_Edit3.EnableWindow(true);
	m_Edit4.EnableWindow(true);
	m_Edit5.EnableWindow(true);
	m_Edit6.EnableWindow(true);
	m_Edit7.EnableWindow(true);
	m_Edit8.EnableWindow(false);
	m_Edit9.EnableWindow(false);
	m_Edit10.EnableWindow(false);

	
}

void CACR120MulitTagSelectDlg::OnRadio3() 
{
	m_radio4.SetCheck(0);
	m_radio7.SetCheck(0);
	m_radio10.SetCheck(1);	
	m_Edit1.EnableWindow(true);
	m_Edit2.EnableWindow(true);
	m_Edit3.EnableWindow(true);
	m_Edit4.EnableWindow(true);
	m_Edit5.EnableWindow(true);
	m_Edit6.EnableWindow(true);
	m_Edit7.EnableWindow(true);
	m_Edit8.EnableWindow(true);
	m_Edit9.EnableWindow(true);
	m_Edit10.EnableWindow(true);
}
