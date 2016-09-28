// ACR120CopyBlockValueDlg.h : header file
//

#if !defined(AFX_ACR120COPYBLOCKVALUEDLG_H__C5BFD7BD_742E_4BCA_8B5E_299B21FEACF7__INCLUDED_)
#define AFX_ACR120COPYBLOCKVALUEDLG_H__C5BFD7BD_742E_4BCA_8B5E_299B21FEACF7__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120CopyBlockValueDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120CopyBlockValueDlg dialog

class CACR120CopyBlockValueDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120CopyBlockValueDlg);
	friend class CACR120CopyBlockValueDlgAutoProxy;

// Construction
public:
	CACR120CopyBlockValueDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120CopyBlockValueDlg();

// Dialog Data
	//{{AFX_DATA(CACR120CopyBlockValueDlg)
	enum { IDD = IDD_ACR120COPYBLOCKVALUE_DIALOG };
	CButton	m_Connect;
	CButton	m_Copy;
	CButton	m_Login;
	CButton	m_Select;
	CComboBox	m_Port;
	CEdit	m_EditSID;
	CListBox	m_List;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120CopyBlockValueDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120CopyBlockValueDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();
	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;

	// Generated message map functions
	//{{AFX_MSG(CACR120CopyBlockValueDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnSelect();
	afx_msg void OnBtnLogIn();
	afx_msg void OnCopyBlock();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120COPYBLOCKVALUEDLG_H__C5BFD7BD_742E_4BCA_8B5E_299B21FEACF7__INCLUDED_)
