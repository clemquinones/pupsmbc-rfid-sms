// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120RWIncDecValue.h"
#include "DlgProxy.h"
#include "ACR120RWIncDecValueDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120RWIncDecValueDlgAutoProxy, CCmdTarget)

CACR120RWIncDecValueDlgAutoProxy::CACR120RWIncDecValueDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120RWIncDecValueDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120RWIncDecValueDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120RWIncDecValueDlgAutoProxy::~CACR120RWIncDecValueDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120RWIncDecValueDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120RWIncDecValueDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120RWIncDecValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120RWIncDecValueDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120RWIncDecValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120RWIncDecValue to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {A3437C05-42D5-4C7C-B96E-5F98F3EA9273}
static const IID IID_IACR120RWIncDecValue =
{ 0xa3437c05, 0x42d5, 0x4c7c, { 0xb9, 0x6e, 0x5f, 0x98, 0xf3, 0xea, 0x92, 0x73 } };

BEGIN_INTERFACE_MAP(CACR120RWIncDecValueDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120RWIncDecValueDlgAutoProxy, IID_IACR120RWIncDecValue, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {07212208-6748-42E5-9C36-0B13B0161848}
IMPLEMENT_OLECREATE2(CACR120RWIncDecValueDlgAutoProxy, "ACR120RWIncDecValue.Application", 0x7212208, 0x6748, 0x42e5, 0x9c, 0x36, 0xb, 0x13, 0xb0, 0x16, 0x18, 0x48)

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlgAutoProxy message handlers
