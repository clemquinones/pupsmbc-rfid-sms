// ACR120RWEEPROM.h : main header file for the ACR120RWEEPROM application
//

#if !defined(AFX_ACR120RWEEPROM_H__29F02C40_0FCD_429E_94E1_A47C911C9EA7__INCLUDED_)
#define AFX_ACR120RWEEPROM_H__29F02C40_0FCD_429E_94E1_A47C911C9EA7__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMApp:
// See ACR120RWEEPROM.cpp for the implementation of this class
//

class CACR120RWEEPROMApp : public CWinApp
{
public:
	CACR120RWEEPROMApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWEEPROMApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120RWEEPROMApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWEEPROM_H__29F02C40_0FCD_429E_94E1_A47C911C9EA7__INCLUDED_)
