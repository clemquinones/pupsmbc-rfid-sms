// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120CopyBlockValue.h"
#include "DlgProxy.h"
#include "ACR120CopyBlockValueDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120CopyBlockValueDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120CopyBlockValueDlgAutoProxy, CCmdTarget)

CACR120CopyBlockValueDlgAutoProxy::CACR120CopyBlockValueDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120CopyBlockValueDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120CopyBlockValueDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120CopyBlockValueDlgAutoProxy::~CACR120CopyBlockValueDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120CopyBlockValueDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120CopyBlockValueDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120CopyBlockValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120CopyBlockValueDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120CopyBlockValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120CopyBlockValue to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {F0F47402-F8F9-4196-9088-183803CAFC15}
static const IID IID_IACR120CopyBlockValue =
{ 0xf0f47402, 0xf8f9, 0x4196, { 0x90, 0x88, 0x18, 0x38, 0x3, 0xca, 0xfc, 0x15 } };

BEGIN_INTERFACE_MAP(CACR120CopyBlockValueDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120CopyBlockValueDlgAutoProxy, IID_IACR120CopyBlockValue, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {8764B166-E145-4660-843E-D85E43DF4927}
IMPLEMENT_OLECREATE2(CACR120CopyBlockValueDlgAutoProxy, "ACR120CopyBlockValue.Application", 0x8764b166, 0xe145, 0x4660, 0x84, 0x3e, 0xd8, 0x5e, 0x43, 0xdf, 0x49, 0x27)

/////////////////////////////////////////////////////////////////////////////
// CACR120CopyBlockValueDlgAutoProxy message handlers
