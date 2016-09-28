// ACR120TxDataTeleramSample.h : main header file for the ACR120TXDATATELERAMSAMPLE application
//

#if !defined(AFX_ACR120TXDATATELERAMSAMPLE_H__A78A753D_902C_4A54_ABD2_8B3A5FFE8428__INCLUDED_)
#define AFX_ACR120TXDATATELERAMSAMPLE_H__A78A753D_902C_4A54_ABD2_8B3A5FFE8428__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CACR120TxDataTeleramSampleApp:
// See ACR120TxDataTeleramSample.cpp for the implementation of this class
//

class CACR120TxDataTeleramSampleApp : public CWinApp
{
public:
	CACR120TxDataTeleramSampleApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120TxDataTeleramSampleApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CACR120TxDataTeleramSampleApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120TXDATATELERAMSAMPLE_H__A78A753D_902C_4A54_ABD2_8B3A5FFE8428__INCLUDED_)
