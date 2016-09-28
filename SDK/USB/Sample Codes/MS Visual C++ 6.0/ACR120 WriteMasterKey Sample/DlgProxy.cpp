// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120WriteMasterKey.h"
#include "DlgProxy.h"
#include "ACR120WriteMasterKeyDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120WriteMasterKeyDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120WriteMasterKeyDlgAutoProxy, CCmdTarget)

CACR120WriteMasterKeyDlgAutoProxy::CACR120WriteMasterKeyDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120WriteMasterKeyDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120WriteMasterKeyDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120WriteMasterKeyDlgAutoProxy::~CACR120WriteMasterKeyDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120WriteMasterKeyDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120WriteMasterKeyDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120WriteMasterKeyDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120WriteMasterKeyDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120WriteMasterKeyDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120WriteMasterKey to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {03241AC9-2C56-4058-B808-66393C407536}
static const IID IID_IACR120WriteMasterKey =
{ 0x3241ac9, 0x2c56, 0x4058, { 0xb8, 0x8, 0x66, 0x39, 0x3c, 0x40, 0x75, 0x36 } };

BEGIN_INTERFACE_MAP(CACR120WriteMasterKeyDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120WriteMasterKeyDlgAutoProxy, IID_IACR120WriteMasterKey, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {F71B35DB-1712-4333-81E3-8158F5046F3C}
IMPLEMENT_OLECREATE2(CACR120WriteMasterKeyDlgAutoProxy, "ACR120WriteMasterKey.Application", 0xf71b35db, 0x1712, 0x4333, 0x81, 0xe3, 0x81, 0x58, 0xf5, 0x4, 0x6f, 0x3c)

/////////////////////////////////////////////////////////////////////////////
// CACR120WriteMasterKeyDlgAutoProxy message handlers
