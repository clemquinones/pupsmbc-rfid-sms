// ACR120AntennaPowerAndRWUPortDlg.h : header file
//

#if !defined(AFX_ACR120ANTENNAPOWERANDRWUPORTDLG_H__72B56D83_BDEF_43B7_BD0B_095125247BB2__INCLUDED_)
#define AFX_ACR120ANTENNAPOWERANDRWUPORTDLG_H__72B56D83_BDEF_43B7_BD0B_095125247BB2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120AntennaPowerAndRWUPortDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120AntennaPowerAndRWUPortDlg dialog

class CACR120AntennaPowerAndRWUPortDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120AntennaPowerAndRWUPortDlg);
	friend class CACR120AntennaPowerAndRWUPortDlgAutoProxy;

// Construction
public:
	CACR120AntennaPowerAndRWUPortDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120AntennaPowerAndRWUPortDlg();

// Dialog Data
	//{{AFX_DATA(CACR120AntennaPowerAndRWUPortDlg)
	enum { IDD = IDD_ACR120ANTENNAPOWERANDRWUPORT_DIALOG };
	CButton	m_led;
	CButton	m_buzz;
	CListBox	m_List;
	CEdit	m_EditSID;
	CComboBox	m_Port;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120AntennaPowerAndRWUPortDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120AntennaPowerAndRWUPortDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();

	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;

	// Generated message map functions
	//{{AFX_MSG(CACR120AntennaPowerAndRWUPortDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnPowerOn();
	afx_msg void OnBtnAntennaPoweroff();
	afx_msg void OnBtnRUPort();
	afx_msg void OnBtnWUPort();
	afx_msg void OnCheck1();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120ANTENNAPOWERANDRWUPORTDLG_H__72B56D83_BDEF_43B7_BD0B_095125247BB2__INCLUDED_)
