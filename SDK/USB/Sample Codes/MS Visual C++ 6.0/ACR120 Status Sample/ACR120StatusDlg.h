// ACR120StatusDlg.h : header file
//

#if !defined(AFX_ACR120STATUSDLG_H__A93D57B4_5B4E_4E4C_A0EE_A70A04B73636__INCLUDED_)
#define AFX_ACR120STATUSDLG_H__A93D57B4_5B4E_4E4C_A0EE_A70A04B73636__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CACR120StatusDlg dialog

class CACR120StatusDlg : public CDialog
{
// Construction
public:
	CACR120StatusDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CACR120StatusDlg)
	enum { IDD = IDD_ACR120STATUS_DIALOG };
	CButton	m_Connect;
	CComboBox	m_Port;
	CListBox	m_List;
	CButton	m_Status;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120StatusDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;
	
	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;

	// Generated message map functions
	//{{AFX_MSG(CACR120StatusDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBtnConnect();
	afx_msg void OnStatus();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120STATUSDLG_H__A93D57B4_5B4E_4E4C_A0EE_A70A04B73636__INCLUDED_)
