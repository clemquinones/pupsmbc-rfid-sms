// ACR120RWIncDecValueDlg.h : header file
//

#if !defined(AFX_ACR120RWINCDECVALUEDLG_H__DADA67BA_574B_4F98_B3B4_80AE149AF860__INCLUDED_)
#define AFX_ACR120RWINCDECVALUEDLG_H__DADA67BA_574B_4F98_B3B4_80AE149AF860__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWIncDecValueDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWIncDecValueDlg dialog

class CACR120RWIncDecValueDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120RWIncDecValueDlg);
	friend class CACR120RWIncDecValueDlgAutoProxy;

// Construction
public:
	CACR120RWIncDecValueDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120RWIncDecValueDlg();

// Dialog Data
	//{{AFX_DATA(CACR120RWIncDecValueDlg)
	enum { IDD = IDD_ACR120RWINCDECVALUE_DIALOG };
	CButton	m_WV;
	CButton	m_Select;
	CButton	m_RV;
	CButton	m_Login;
	CButton	m_Inc;
	CButton	m_Dec;
	CButton	m_Connect;
	CComboBox	m_Port;
	CEdit	m_EditSID;
	CListBox	m_List;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWIncDecValueDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120RWIncDecValueDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();
		int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;


	// Generated message map functions
	//{{AFX_MSG(CACR120RWIncDecValueDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnSelect();
	afx_msg void OnBtnLogIn();
	afx_msg void OnBtnWV();
	afx_msg void OnBtnRV();
	afx_msg void OnBtnInc();
	afx_msg void OnBtnDec();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWINCDECVALUEDLG_H__DADA67BA_574B_4F98_B3B4_80AE149AF860__INCLUDED_)
