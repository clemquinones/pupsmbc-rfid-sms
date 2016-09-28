// ACR120WriteMasterKeyDlg.h : header file
//

#if !defined(AFX_ACR120WRITEMASTERKEYDLG_H__4A1E7D05_8C25_4DEC_B2D8_5C651968FF11__INCLUDED_)
#define AFX_ACR120WRITEMASTERKEYDLG_H__4A1E7D05_8C25_4DEC_B2D8_5C651968FF11__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120WriteMasterKeyDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120WriteMasterKeyDlg dialog

class CACR120WriteMasterKeyDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120WriteMasterKeyDlg);
	friend class CACR120WriteMasterKeyDlgAutoProxy;

// Construction
public:
	CACR120WriteMasterKeyDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120WriteMasterKeyDlg();

// Dialog Data
	//{{AFX_DATA(CACR120WriteMasterKeyDlg)
	enum { IDD = IDD_ACR120WRITEMASTERKEY_DIALOG };
	CButton	m_WriteMasterKey;
	CButton	m_Select;
	CButton	m_Login;
	CButton	m_Connect;
	CListBox	m_List;
	CEdit	m_EditSID;
	CComboBox	m_Port;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120WriteMasterKeyDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120WriteMasterKeyDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();

	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;

	// Generated message map functions
	//{{AFX_MSG(CACR120WriteMasterKeyDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnSelect();
	afx_msg void OnBtnLogIn();
	afx_msg void OnBtnWriteMasterKey();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120WRITEMASTERKEYDLG_H__4A1E7D05_8C25_4DEC_B2D8_5C651968FF11__INCLUDED_)
