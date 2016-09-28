// ACR120MulitTagSelect.h : main header file for the ACR120MULITTAGSELECT application
//

#if !defined(AFX_ACR120MULITTAGSELECT_H__98A90FB2_58FB_4314_89E7_1344F90254F1__INCLUDED_)
#define AFX_ACR120MULITTAGSELECT_H__98A90FB2_58FB_4314_89E7_1344F90254F1__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectApp:
// See ACR120MulitTagSelect.cpp for the implementation of this class
//

class CACR120MulitTagSelectApp : public CWinApp
{
public:
	CACR120MulitTagSelectApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120MulitTagSelectApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120MulitTagSelectApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120MULITTAGSELECT_H__98A90FB2_58FB_4314_89E7_1344F90254F1__INCLUDED_)
