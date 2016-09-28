// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120MulitTagSelect.h"
#include "DlgProxy.h"
#include "ACR120MulitTagSelectDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120MulitTagSelectDlgAutoProxy, CCmdTarget)

CACR120MulitTagSelectDlgAutoProxy::CACR120MulitTagSelectDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120MulitTagSelectDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120MulitTagSelectDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120MulitTagSelectDlgAutoProxy::~CACR120MulitTagSelectDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120MulitTagSelectDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120MulitTagSelectDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120MulitTagSelectDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120MulitTagSelectDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120MulitTagSelectDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120MulitTagSelect to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {A560074E-BC0E-45F0-8604-4F24C18C1E29}
static const IID IID_IACR120MulitTagSelect =
{ 0xa560074e, 0xbc0e, 0x45f0, { 0x86, 0x4, 0x4f, 0x24, 0xc1, 0x8c, 0x1e, 0x29 } };

BEGIN_INTERFACE_MAP(CACR120MulitTagSelectDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120MulitTagSelectDlgAutoProxy, IID_IACR120MulitTagSelect, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {2C424CFA-F18D-43C1-BD15-08917180F6AC}
IMPLEMENT_OLECREATE2(CACR120MulitTagSelectDlgAutoProxy, "ACR120MulitTagSelect.Application", 0x2c424cfa, 0xf18d, 0x43c1, 0xbd, 0x15, 0x8, 0x91, 0x71, 0x80, 0xf6, 0xac)

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlgAutoProxy message handlers
