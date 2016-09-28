// ACR120MulitTagSelectDlg.h : header file
//

#if !defined(AFX_ACR120MULITTAGSELECTDLG_H__48A5800A_1150_4A56_B0D2_6C46C0C89521__INCLUDED_)
#define AFX_ACR120MULITTAGSELECTDLG_H__48A5800A_1150_4A56_B0D2_6C46C0C89521__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120MulitTagSelectDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120MulitTagSelectDlg dialog

class CACR120MulitTagSelectDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120MulitTagSelectDlg);
	friend class CACR120MulitTagSelectDlgAutoProxy;

// Construction
public:
	CACR120MulitTagSelectDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120MulitTagSelectDlg();

// Dialog Data
	//{{AFX_DATA(CACR120MulitTagSelectDlg)
	enum { IDD = IDD_ACR120MULITTAGSELECT_DIALOG };
	CEdit	m_Edit10;
	CButton	m_radio10;
	CButton	m_radio7;
	CButton	m_radio4;
	CEdit	m_Edit9;
	CEdit	m_Edit8;
	CEdit	m_Edit7;
	CEdit	m_Edit6;
	CEdit	m_Edit5;
	CEdit	m_Edit4;
	CEdit	m_Edit3;
	CEdit	m_Edit2;
	CEdit	m_Edit1;
	CComboBox	m_Port;
	CEdit	m_EditSID;
	CListBox	m_List;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120MulitTagSelectDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120MulitTagSelectDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();
int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;


	// Generated message map functions
	//{{AFX_MSG(CACR120MulitTagSelectDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnLogIn();
	afx_msg void OnBtnListTag();
	afx_msg void OnBtnMultiTagSelect();
	afx_msg void OnRadio1();
	afx_msg void OnRadio2();
	afx_msg void OnRadio3();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120MULITTAGSELECTDLG_H__48A5800A_1150_4A56_B0D2_6C46C0C89521__INCLUDED_)
