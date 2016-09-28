// ACR120CopyBlockValue.h : main header file for the ACR120COPYBLOCKVALUE application
//

#if !defined(AFX_ACR120COPYBLOCKVALUE_H__A549B906_7D02_4E0F_8775_3D97C22E290D__INCLUDED_)
#define AFX_ACR120COPYBLOCKVALUE_H__A549B906_7D02_4E0F_8775_3D97C22E290D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120CopyBlockValueApp:
// See ACR120CopyBlockValue.cpp for the implementation of this class
//

class CACR120CopyBlockValueApp : public CWinApp
{
public:
	CACR120CopyBlockValueApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120CopyBlockValueApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120CopyBlockValueApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120COPYBLOCKVALUE_H__A549B906_7D02_4E0F_8775_3D97C22E290D__INCLUDED_)
