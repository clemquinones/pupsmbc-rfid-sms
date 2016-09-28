// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__2363CCF9_BB93_43BC_80D6_972471FEAA87__INCLUDED_)
#define AFX_DLGPROXY_H__2363CCF9_BB93_43BC_80D6_972471FEAA87__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWEEPROMDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlgAutoProxy command target

class CACR120RWEEPROMDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120RWEEPROMDlgAutoProxy)

	CACR120RWEEPROMDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120RWEEPROMDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWEEPROMDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120RWEEPROMDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120RWEEPROMDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120RWEEPROMDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120RWEEPROMDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__2363CCF9_BB93_43BC_80D6_972471FEAA87__INCLUDED_)
