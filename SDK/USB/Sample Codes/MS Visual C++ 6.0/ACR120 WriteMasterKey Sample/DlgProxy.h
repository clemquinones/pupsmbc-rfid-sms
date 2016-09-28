// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__00C02617_8671_428F_A8B9_F95352693A98__INCLUDED_)
#define AFX_DLGPROXY_H__00C02617_8671_428F_A8B9_F95352693A98__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120WriteMasterKeyDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120WriteMasterKeyDlgAutoProxy command target

class CACR120WriteMasterKeyDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120WriteMasterKeyDlgAutoProxy)

	CACR120WriteMasterKeyDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120WriteMasterKeyDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120WriteMasterKeyDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120WriteMasterKeyDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120WriteMasterKeyDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120WriteMasterKeyDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120WriteMasterKeyDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__00C02617_8671_428F_A8B9_F95352693A98__INCLUDED_)
