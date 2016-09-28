// ACR120RWBlockDlg.h : header file
//

#if !defined(AFX_ACR120RWBLOCKDLG_H__473C7203_9EAE_4DF7_B9C2_F71C1A5E2FF2__INCLUDED_)
#define AFX_ACR120RWBLOCKDLG_H__473C7203_9EAE_4DF7_B9C2_F71C1A5E2FF2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWBlockDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWBlockDlg dialog

class CACR120RWBlockDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120RWBlockDlg);
	friend class CACR120RWBlockDlgAutoProxy;

// Construction
public:
	CACR120RWBlockDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120RWBlockDlg();

// Dialog Data
	//{{AFX_DATA(CACR120RWBlockDlg)
	enum { IDD = IDD_ACR120RWBLOCK_DIALOG };
	CButton	m_WriteBlock;
	CButton	m_Select;
	CButton	m_ReadBlock;
	CButton	m_Login;
	CButton	m_Connect;
	CComboBox	m_Port;
	CEdit	m_EditSID;
	CListBox	m_List;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWBlockDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120RWBlockDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();
	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;


	// Generated message map functions
	//{{AFX_MSG(CACR120RWBlockDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnSelect();
	afx_msg void OnBtnLogIn();
	afx_msg void OnBtnReadBlock();
	afx_msg void OnBtnWriteBlock();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWBLOCKDLG_H__473C7203_9EAE_4DF7_B9C2_F71C1A5E2FF2__INCLUDED_)
