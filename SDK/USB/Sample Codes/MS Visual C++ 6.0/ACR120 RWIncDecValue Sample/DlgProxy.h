// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__789D74A1_F33D_402E_A783_5868489F7E85__INCLUDED_)
#define AFX_DLGPROXY_H__789D74A1_F33D_402E_A783_5868489F7E85__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWIncDecValueDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlgAutoProxy command target

class CACR120RWIncDecValueDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120RWIncDecValueDlgAutoProxy)

	CACR120RWIncDecValueDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120RWIncDecValueDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWIncDecValueDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120RWIncDecValueDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120RWIncDecValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120RWIncDecValueDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120RWIncDecValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__789D74A1_F33D_402E_A783_5868489F7E85__INCLUDED_)
