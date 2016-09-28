// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__1C675FCD_9210_4847_8046_311C15F07855__INCLUDED_)
#define AFX_DLGPROXY_H__1C675FCD_9210_4847_8046_311C15F07855__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120AntennaPowerAndRWUPortDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlgAutoProxy command target

class CACR120AntennaPowerAndRWUPortDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120AntennaPowerAndRWUPortDlgAutoProxy)

	CACR120AntennaPowerAndRWUPortDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120AntennaPowerAndRWUPortDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120AntennaPowerAndRWUPortDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120AntennaPowerAndRWUPortDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120AntennaPowerAndRWUPortDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120AntennaPowerAndRWUPortDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120AntennaPowerAndRWUPortDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__1C675FCD_9210_4847_8046_311C15F07855__INCLUDED_)
