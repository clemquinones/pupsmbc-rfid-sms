// ACR120AntennaPowerAndRWUPort.h : main header file for the ACR120ANTENNAPOWERANDRWUPORT application
//

#if !defined(AFX_ACR120ANTENNAPOWERANDRWUPORT_H__D603BBAD_2546_45FC_B7A0_898DAE365C6B__INCLUDED_)
#define AFX_ACR120ANTENNAPOWERANDRWUPORT_H__D603BBAD_2546_45FC_B7A0_898DAE365C6B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortApp:
// See ACR120AntennaPowerAndRWUPort.cpp for the implementation of this class
//

class CACR120AntennaPowerAndRWUPortApp : public CWinApp
{
public:
	CACR120AntennaPowerAndRWUPortApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120AntennaPowerAndRWUPortApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120AntennaPowerAndRWUPortApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120ANTENNAPOWERANDRWUPORT_H__D603BBAD_2546_45FC_B7A0_898DAE365C6B__INCLUDED_)
