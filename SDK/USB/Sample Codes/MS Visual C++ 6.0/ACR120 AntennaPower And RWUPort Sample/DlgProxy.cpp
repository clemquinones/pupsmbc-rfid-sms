// DlgProxy.cpp : implementation file
//

#include "stdafx.h"
#include "ACR120AntennaPowerAndRWUPort.h"
#include "DlgProxy.h"
#include "ACR120AntennaPowerAndRWUPortDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlgAutoProxy

IMPLEMENT_DYNCREATE(CACR120AntennaPowerAndRWUPortDlgAutoProxy, CCmdTarget)

CACR120AntennaPowerAndRWUPortDlgAutoProxy::CACR120AntennaPowerAndRWUPortDlgAutoProxy()
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
	ASSERT_KINDOF(CACR120AntennaPowerAndRWUPortDlg, AfxGetApp()->m_pMainWnd);
	m_pDialog = (CACR120AntennaPowerAndRWUPortDlg*) AfxGetApp()->m_pMainWnd;
	m_pDialog->m_pAutoProxy = this;
}

CACR120AntennaPowerAndRWUPortDlgAutoProxy::~CACR120AntennaPowerAndRWUPortDlgAutoProxy()
{
	// To terminate the application when all objects created with
	// 	with automation, the destructor calls AfxOleUnlockApp.
	//  Among other things, this will destroy the main dialog
	if (m_pDialog != NULL)
		m_pDialog->m_pAutoProxy = NULL;
	AfxOleUnlockApp();
}

void CACR120AntennaPowerAndRWUPortDlgAutoProxy::OnFinalRelease()
{
	// When the last reference for an automation object is released
	// OnFinalRelease is called.  The base class will automatically
	// deletes the object.  Add additional cleanup required for your
	// object before calling the base class.

	CCmdTarget::OnFinalRelease();
}

BEGIN_MESSAGE_MAP(CACR120AntennaPowerAndRWUPortDlgAutoProxy, CCmdTarget)
	//{{AFX_MSG_MAP(CACR120AntennaPowerAndRWUPortDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

BEGIN_DISPATCH_MAP(CACR120AntennaPowerAndRWUPortDlgAutoProxy, CCmdTarget)
	//{{AFX_DISPATCH_MAP(CACR120AntennaPowerAndRWUPortDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_DISPATCH_MAP
END_DISPATCH_MAP()

// Note: we add support for IID_IACR120AntennaPowerAndRWUPort to support typesafe binding
//  from VBA.  This IID must match the GUID that is attached to the 
//  dispinterface in the .ODL file.

// {3D950F93-D0D4-4BC2-9B42-1963787D0B71}
static const IID IID_IACR120AntennaPowerAndRWUPort =
{ 0x3d950f93, 0xd0d4, 0x4bc2, { 0x9b, 0x42, 0x19, 0x63, 0x78, 0x7d, 0xb, 0x71 } };

BEGIN_INTERFACE_MAP(CACR120AntennaPowerAndRWUPortDlgAutoProxy, CCmdTarget)
	INTERFACE_PART(CACR120AntennaPowerAndRWUPortDlgAutoProxy, IID_IACR120AntennaPowerAndRWUPort, Dispatch)
END_INTERFACE_MAP()

// The IMPLEMENT_OLECREATE2 macro is defined in StdAfx.h of this project
// {9BAF8CFE-095D-4779-BEFD-D690F983D0ED}
IMPLEMENT_OLECREATE2(CACR120AntennaPowerAndRWUPortDlgAutoProxy, "ACR120AntennaPowerAndRWUPort.Application", 0x9baf8cfe, 0x95d, 0x4779, 0xbe, 0xfd, 0xd6, 0x90, 0xf9, 0x83, 0xd0, 0xed)

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlgAutoProxy message handlers
