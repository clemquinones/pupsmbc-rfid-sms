// ACR120RWBlock.h : main header file for the ACR120RWBLOCK application
//

#if !defined(AFX_ACR120RWBLOCK_H__51C5C763_3CAA_4FA3_8A42_70D98B786856__INCLUDED_)
#define AFX_ACR120RWBLOCK_H__51C5C763_3CAA_4FA3_8A42_70D98B786856__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockApp:
// See ACR120RWBlock.cpp for the implementation of this class
//

class CACR120RWBlockApp : public CWinApp
{
public:
	CACR120RWBlockApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWBlockApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120RWBlockApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWBLOCK_H__51C5C763_3CAA_4FA3_8A42_70D98B786856__INCLUDED_)
