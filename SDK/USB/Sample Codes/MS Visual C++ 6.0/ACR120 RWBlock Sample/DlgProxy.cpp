// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120RWBlock.h"
#include "DlgProxy.h"
#include "ACR120RWBlockDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120RWBlockDlgAutoProxy, CCmdTarget)

CACR120RWBlockDlgAutoProxy::CACR120RWBlockDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120RWBlockDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120RWBlockDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120RWBlockDlgAutoProxy::~CACR120RWBlockDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120RWBlockDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120RWBlockDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120RWBlockDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120RWBlockDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120RWBlockDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120RWBlock to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {83CB2D8E-2528-429A-B950-C2366BBFEA3E}
static const IID IID_IACR120RWBlock =
{ 0x83cb2d8e, 0x2528, 0x429a, { 0xb9, 0x50, 0xc2, 0x36, 0x6b, 0xbf, 0xea, 0x3e } };

BEGIN_INTERFACE_MAP(CACR120RWBlockDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120RWBlockDlgAutoProxy, IID_IACR120RWBlock, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {5EBD899F-3A02-4F28-AD6B-25FDC6649FE6}
IMPLEMENT_OLECREATE2(CACR120RWBlockDlgAutoProxy, "ACR120RWBlock.Application", 0x5ebd899f, 0x3a02, 0x4f28, 0xad, 0x6b, 0x25, 0xfd, 0xc6, 0x64, 0x9f, 0xe6)

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlgAutoProxy message handlers
