// ACR120Status.h : main header file for the ACR120STATUS application
//

#if !defined(AFX_ACR120STATUS_H__7C6AAE51_09D6_4383_83D6_C4C895708A76__INCLUDED_)
#define AFX_ACR120STATUS_H__7C6AAE51_09D6_4383_83D6_C4C895708A76__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120StatusApp:
// See ACR120Status.cpp for the implementation of this class
//

class CACR120StatusApp : public CWinApp
{
public:
	CACR120StatusApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120StatusApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120StatusApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120STATUS_H__7C6AAE51_09D6_4383_83D6_C4C895708A76__INCLUDED_)
