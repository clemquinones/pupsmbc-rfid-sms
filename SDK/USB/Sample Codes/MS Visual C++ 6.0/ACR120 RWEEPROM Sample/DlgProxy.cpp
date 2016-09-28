// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120RWEEPROM.h"
#include "DlgProxy.h"
#include "ACR120RWEEPROMDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120RWEEPROMDlgAutoProxy, CCmdTarget)

CACR120RWEEPROMDlgAutoProxy::CACR120RWEEPROMDlgAutoProxy()
{
	EnableAutomation();
	
	// To keep the application running as long as an automation 
	//	object is active, the constructor calls AfxOleLockApp.
	AfxOleLockApp();

	// Get access to the dialog through the application's
	//  main window pointer.  Set the proxy's internal pointer
	//  to point to the dialog, and set the dialog's back pointer to
	//  this proxy.
	ASSERT (AfxGetApp()->m_pMainWnd != NULL);
	ASSERT_VALID (AfxGetApp()->m_pMainWnd);
	ASSERT_KINDOF(CACR120RWEEPROMDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120RWEEPROMDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120RWEEPROMDlgAutoProxy::~CACR120RWEEPROMDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120RWEEPROMDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120RWEEPROMDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120RWEEPROMDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120RWEEPROMDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120RWEEPROMDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120RWEEPROM to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {604EAFCD-F021-4D27-AB80-7D51DDF90344}
static const IID IID_IACR120RWEEPROM =
{ 0x604eafcd, 0xf021, 0x4d27, { 0xab, 0x80, 0x7d, 0x51, 0xdd, 0xf9, 0x3, 0x44 } };

BEGIN_INTERFACE_MAP(CACR120RWEEPROMDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120RWEEPROMDlgAutoProxy, IID_IACR120RWEEPROM, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {A11333C2-7AE8-4812-9B54-5DBE6EE551D5}
IMPLEMENT_OLECREATE2(CACR120RWEEPROMDlgAutoProxy, "ACR120RWEEPROM.Application", 0xa11333c2, 0x7ae8, 0x4812, 0x9b, 0x54, 0x5d, 0xbe, 0x6e, 0xe5, 0x51, 0xd5)

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlgAutoProxy message handlers
