// ACR120RWIncDecValue.h : main header file for the ACR120RWINCDECVALUE application
//

#if !defined(AFX_ACR120RWINCDECVALUE_H__169E67DF_99FE_4D9D_B631_116750E871F0__INCLUDED_)
#define AFX_ACR120RWINCDECVALUE_H__169E67DF_99FE_4D9D_B631_116750E871F0__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueApp:
// See ACR120RWIncDecValue.cpp for the implementation of this class
//

class CACR120RWIncDecValueApp : public CWinApp
{
public:
	CACR120RWIncDecValueApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWIncDecValueApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120RWIncDecValueApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWINCDECVALUE_H__169E67DF_99FE_4D9D_B631_116750E871F0__INCLUDED_)
