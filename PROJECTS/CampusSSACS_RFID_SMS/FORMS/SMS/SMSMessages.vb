Public Class frmSMSMessages
    Dim Txt_RHeight As Integer = 0
    Dim Txt_OHeight As Integer = 0

    Dim GB_RHEIGHT As Integer = 0
    Dim GB_OHEIGHT As Integer = 0
    Dim BUTTON As String = ""

    Sub RESET()
        GB_OHEIGHT = gbLogIn.Size.Height
        GB_RHEIGHT = gbLogOut.Size.Height
        Txt_OHeight = txtLogIn.Size.Height
        Txt_RHeight = txtLogOut.Size.Height

        txtLogIn.Text = gIDVal("LogInMessage", 0)
        txtLogOut.Text = gIDVal("LogOutMessage", 0)
        txtUnLogOut.Text = gIDVal("UnLogOutMessage", 0)
        txtAdvisory.Text = gIDVal("AdvisoryMessage", 0)
        txtALERT_Confirm.Text = gIDVal("BlockConfirmMessage", 0)
        txtALERT_Invalid.Text = gIDVal("GuideBlockMessage", 0)

        btnLogIn.Text = "Save"
        btnLogOut.Text = "Change"
        btnUnLogOut.Text = "Change"
        btnAdvisory.Text = "Change"
        btnALERT_Confirm.Text = "Change"
        btnALERT_Invalid.Text = "Change"

        BUTTON = btnLogIn.Name
        Show_GB(btnLogIn.Name)
    End Sub

    Sub Show_GB(ByVal CLICKEDBUTTON As String)
        BUTTON = CLICKEDBUTTON
        If Not BUTTON = btnLogIn.Name Then gbLogIn.Height = GB_RHEIGHT : txtLogIn.Height = Txt_RHeight : btnLogIn.Text = "Change" Else gbLogIn.Height = GB_OHEIGHT : txtLogIn.Height = Txt_OHeight : btnLogIn.Text = "Save" : toHL(txtLogIn)
        If Not BUTTON = btnLogOut.Name Then gbLogOut.Height = GB_RHEIGHT : txtLogOut.Height = Txt_RHeight : btnLogOut.Text = "Change" Else gbLogOut.Height = GB_OHEIGHT : txtLogOut.Height = Txt_OHeight : btnLogOut.Text = "Save" : toHL(txtLogOut)
        If Not BUTTON = btnUnLogOut.Name Then gbUnLogOut.Height = GB_RHEIGHT : txtUnLogOut.Height = Txt_RHeight : btnUnLogOut.Text = "Change" Else gbUnLogOut.Height = GB_OHEIGHT : txtUnLogOut.Height = Txt_OHeight : btnUnLogOut.Text = "Save" : toHL(txtUnLogOut)
        If Not BUTTON = btnAdvisory.Name Then gbAdvisory.Height = GB_RHEIGHT : txtAdvisory.Height = Txt_RHeight : btnAdvisory.Text = "Change" Else gbAdvisory.Height = GB_OHEIGHT : txtAdvisory.Height = Txt_OHeight : btnAdvisory.Text = "Save" : toHL(txtAdvisory)
        If Not BUTTON = btnALERT_Confirm.Name Then gbALERT_Confirm.Height = GB_RHEIGHT : txtALERT_Confirm.Height = Txt_RHeight : btnALERT_Confirm.Text = "Change" Else gbALERT_Confirm.Height = GB_OHEIGHT : txtALERT_Confirm.Height = Txt_OHeight : btnALERT_Confirm.Text = "Save" : toHL(txtALERT_Confirm)
        If Not BUTTON = btnALERT_Invalid.Name Then gbALERT_Invalid.Height = GB_RHEIGHT : txtALERT_Invalid.Height = Txt_RHeight : btnALERT_Invalid.Text = "Change" Else gbALERT_Invalid.Height = GB_OHEIGHT : txtALERT_Invalid.Height = Txt_OHeight : btnALERT_Invalid.Text = "Save" : toHL(txtALERT_Invalid)

        gbLogIn.Top = 20
        gbLogOut.Top = (gbLogIn.Top + gbLogIn.Height) + 5
        gbUnLogOut.Top = (gbLogOut.Top + gbLogOut.Height) + 5
        gbAdvisory.Top = (gbUnLogOut.Top + gbUnLogOut.Height) + 5
        gbALERT_Confirm.Top = (gbAdvisory.Top + gbAdvisory.Height) + 5
        gbALERT_Invalid.Top = (gbALERT_Confirm.Top + gbALERT_Confirm.Height) + 5
    End Sub

    Private Sub frmSMSMessages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RESET()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Sounds(AUDIO.CLICK)
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Sounds(AUDIO.CLICK)
        If btnLogIn.Text = "Change" Then : Show_GB(btnLogIn.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtLogIn.Text.Trim, True) & "'", "field like '%LogInMessage%'")
            MB("Saved!")
        End If

    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Sounds(AUDIO.CLICK)
        If btnLogOut.Text = "Change" Then : Show_GB(btnLogOut.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtLogOut.Text.Trim, True) & "'", "field like '%LogOutMessage%'")
            MB("Saved!")
        End If
    End Sub

    Private Sub btnUnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnLogOut.Click
        Sounds(AUDIO.CLICK)
        If btnUnLogOut.Text = "Change" Then : Show_GB(btnUnLogOut.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtUnLogOut.Text.Trim, True) & "'", "field like '%UnLogOutMessage%'")
            MB("Saved!")
        End If
    End Sub

    Private Sub btnAdvisory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvisory.Click
        Sounds(AUDIO.CLICK)
        If btnAdvisory.Text = "Change" Then : Show_GB(btnAdvisory.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtAdvisory.Text.Trim, True) & "'", "field like '%AdvisoryMessage%'")
            MB("Saved!")
        End If
    End Sub

    Private Sub btnALERT_Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnALERT_Confirm.Click
        Sounds(AUDIO.CLICK)
        If btnALERT_Confirm.Text = "Change" Then : Show_GB(btnALERT_Confirm.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtALERT_Confirm.Text.Trim, True) & "'", "field like '%BlockConfirmMessage%'")
            MB("Saved!")
        End If
    End Sub

    Private Sub btnALERT_Invalid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnALERT_Invalid.Click
        Sounds(AUDIO.CLICK)
        If btnALERT_Invalid.Text = "Change" Then : Show_GB(btnALERT_Invalid.Name)
        Else : If MB("Are you sure you want to save this text message?", "?") = "n" Then Return
            UPDATEr("tbleid", "format='" & v(txtALERT_Confirm.Text.Trim, True) & "'", "field like '%GuideBlockMessage%'")
            MB("Saved!")
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Sounds(AUDIO.CLICK)
        frmCreateMessage.Close()
        frmCreateMessage.ShowDialog()
    End Sub

    Private Sub btnInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInbox.Click
        Sounds(AUDIO.CLICK)
        frmInbox.Show()
    End Sub

    Private Sub btnSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSent.Click
        Sounds(AUDIO.CLICK)
        frmSentMessage.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Sounds(AUDIO.CLICK)
        frmSaveMessage.Show()
    End Sub

#Region "TEXTCHANGED"
    Private Sub txtLogIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogIn.TextChanged
        Dim Count As Integer = 160 - CInt(txtLogIn.Text.Length)
        lblLogIn.Text = "Remaining characters (" & IIf(Count <= 0, "0", Count) & "/160)"
    End Sub

    Private Sub txtLogOut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogOut.TextChanged
        Dim Count As Integer = 160 - CInt(txtLogOut.Text.Length)
        lblLogOut.Text = "Remaining characters (" & IIf(Count <= 0, 0, Count) & "/160)"
    End Sub

    Private Sub txtUnLogOut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnLogOut.TextChanged
        Dim Count As Integer = 160 - CInt(txtUnLogOut.Text.Length)
        lblUnLogOut.Text = "Remaining characters (" & IIf(Count <= 0, 0, Count) & "/160)"
    End Sub

    Private Sub txtAdvisory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvisory.TextChanged
        Dim Count As Integer = 160 - CInt(txtAdvisory.Text.Length)
        lblAdvisory.Text = "Remaining characters (" & IIf(Count <= 0, 0, Count) & "/160)"
    End Sub

    Private Sub txtALERT_Confirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtALERT_Confirm.TextChanged
        Dim Count As Integer = 160 - CInt(txtALERT_Confirm.Text.Length)
        lblALERT_Confirm.Text = "Remaining characters (" & IIf(Count <= 0, 0, Count) & "/160)"
    End Sub

    Private Sub txtALERT_Invalid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtALERT_Invalid.TextChanged
        Dim Count As Integer = 160 - CInt(txtALERT_Invalid.Text.Length)
        lblALERT_Invalid.Text = "Remaining characters (" & IIf(Count <= 0, 0, Count) & "/160)"
    End Sub
#End Region

    Private Sub pbText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbText.Click

    End Sub
End Class