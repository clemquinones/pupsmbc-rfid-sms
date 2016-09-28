// DlgProxy.h : header file
//

#if !defined(AFX_DLGPROXY_H__B70F1F32_3649_4A9A_89A7_CC642BC435B2__INCLUDED_)
#define AFX_DLGPROXY_H__B70F1F32_3649_4A9A_89A7_CC642BC435B2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120CopyBlockValueDlg;

/////////////////////////////////////////////////////////////////////////////
// CACR120CopyBlockValueDlgAutoProxy command target

class CACR120CopyBlockValueDlgAutoProxy : public CCmdTarget
{
	DECLARE_DYNCREATE(CACR120CopyBlockValueDlgAutoProxy)

	CACR120CopyBlockValueDlgAutoProxy();           // protected constructor used by dynamic creation

// Attributes
public:
	CACR120CopyBlockValueDlg* m_pDialog;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120CopyBlockValueDlgAutoProxy)
	public:
	virtual void OnFinalRelease();
	//}}AFX_VIRTUAL

// Implementation
protected:
	virtual ~CACR120CopyBlockValueDlgAutoProxy();

	// Generated message map functions
	//{{AFX_MSG(CACR120CopyBlockValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
	DECLARE_OLECREATE(CACR120CopyBlockValueDlgAutoProxy)

	// Generated OLE dispatch map functions
	//{{AFX_DISPATCH(CACR120CopyBlockValueDlgAutoProxy)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_DISPATCH
	DECLARE_DISPATCH_MAP()
	DECLARE_INTERFACE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DLGPROXY_H__B70F1F32_3649_4A9A_89A7_CC642BC435B2__INCLUDED_)
