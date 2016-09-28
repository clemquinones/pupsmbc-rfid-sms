// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__08892A94_0E5E_4655_97D7_177A5B213FB9__INCLUDED_)
#define AFX_DLGPROXY_H__08892A94_0E5E_4655_97D7_177A5B213FB9__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWBlockDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlgAutoProxy command target

class CACR120RWBlockDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120RWBlockDlgAutoProxy)

	CACR120RWBlockDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120RWBlockDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWBlockDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120RWBlockDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120RWBlockDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120RWBlockDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120RWBlockDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__08892A94_0E5E_4655_97D7_177A5B213FB9__INCLUDED_)
