// ACR120TxDataTeleramSampleDlg.h : header file
//

#if !defined(AFX_ACR120TXDATATELERAMSAMPLEDLG_H__B3546F9C_7BCF_48BD_98B2_415D9275EF5C__INCLUDED_)
#define AFX_ACR120TXDATATELERAMSAMPLEDLG_H__B3546F9C_7BCF_48BD_98B2_415D9275EF5C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CACR120TxDataTeleramSampleDlg dialog

class CACR120TxDataTeleramSampleDlg : public CDialog
{
// Construction
public:
	CACR120TxDataTeleramSampleDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CACR120TxDataTeleramSampleDlg)
	enum { IDD = IDD_ACR120TXDATATELERAMSAMPLE_DIALOG };
	CButton	m_Connect;
	CButton	m_TxtTele;
	CButton	m_Select;
	CListBox	m_List;
	CEdit	m_EditSID;
	CComboBox	m_Port;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CACR120TxDataTeleramSampleDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	BOOL CanExit();
	int rHandle;
	int retcode;
	int SID;
	CString	StrMsg;
	int LstIndx;

	// Generated message map functions
	//{{AFX_MSG(CACR120TxDataTeleramSampleDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBtnConnect();
	afx_msg void OnBtnSelect();
	afx_msg void OnBtnReadBlock();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACR120TXDATATELERAMSAMPLEDLG_H__B3546F9C_7BCF_48BD_98B2_415D9275EF5C__INCLUDED_)
