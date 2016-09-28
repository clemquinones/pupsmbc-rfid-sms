// ACR120RWEEPROMDlg.h : header file
//

#if !defined(AFX_ACR120RWEEPROMDLG_H__35E95385_B07B_4F9D_88E7_21BD0583346D__INCLUDED_)
#define AFX_ACR120RWEEPROMDLG_H__35E95385_B07B_4F9D_88E7_21BD0583346D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CACR120RWEEPROMDlgAutoProxy;

/////////////////////////////////////////////////////////////////////////////
// CACR120RWEEPROMDlg dialog

class CACR120RWEEPROMDlg : public CDialog
{
	DECLARE_DYNAMIC(CACR120RWEEPROMDlg);
	friend class CACR120RWEEPROMDlgAutoProxy;

// Construction
public:
	CACR120RWEEPROMDlg(CWnd* pParent = NULL);	// standard constructor
	virtual ~CACR120RWEEPROMDlg();

// Dialog Data
	//{{AFX_DATA(CACR120RWEEPROMDlg)
	enum { IDD = IDD_ACR120RWEEPROM_DIALOG };
	CComboBox	m_Port;
	CEdit	m_EditSID;
	CListBox	m_List;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120RWEEPROMDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	CACR120RWEEPROMDlgAutoProxy* m_pAutoProxy;
	HICON m_hIcon;

	BOOL CanExit();
		int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;


	// Generated message map functions
	//{{AFX_MSG(CACR120RWEEPROMDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnClose();
	virtual void OnOK();
	virtual void OnCancel();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnREEPROM();
	afx_msg void OnBtnWEEPROM();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120RWEEPROMDLG_H__35E95385_B07B_4F9D_88E7_21BD0583346D__INCLUDED_)
