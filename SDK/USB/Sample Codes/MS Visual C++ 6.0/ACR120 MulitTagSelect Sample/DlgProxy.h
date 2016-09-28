// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__7CBBEA4C_61E9_4271_B206_EDBFE528F667__INCLUDED_)
#define AFX_DLGPROXY_H__7CBBEA4C_61E9_4271_B206_EDBFE528F667__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120MulitTagSelectDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlgAutoProxy command target

class CACR120MulitTagSelectDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120MulitTagSelectDlgAutoProxy)

	CACR120MulitTagSelectDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120MulitTagSelectDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120MulitTagSelectDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120MulitTagSelectDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120MulitTagSelectDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120MulitTagSelectDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120MulitTagSelectDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__7CBBEA4C_61E9_4271_B206_EDBFE528F667__INCLUDED_)
