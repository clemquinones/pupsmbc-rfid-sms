// ACR120WriteMasterKey.h : main header file for the ACR120WRITEMASTERKEY application
//

#if !defined(AFX_ACR120WRITEMASTERKEY_H__0DD3458F_1B0D_44EE_8CAA_D378A0B7A020__INCLUDED_)
#define AFX_ACR120WRITEMASTERKEY_H__0DD3458F_1B0D_44EE_8CAA_D378A0B7A020__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120WriteMasterKeyApp:
// See ACR120WriteMasterKey.cpp for the implementation of this class
//

class CACR120WriteMasterKeyApp : public CWinApp
{
public:
	CACR120WriteMasterKeyApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120WriteMasterKeyApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120WriteMasterKeyApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120WRITEMASTERKEY_H__0DD3458F_1B0D_44EE_8CAA_D378A0B7A020__INCLUDED_)
