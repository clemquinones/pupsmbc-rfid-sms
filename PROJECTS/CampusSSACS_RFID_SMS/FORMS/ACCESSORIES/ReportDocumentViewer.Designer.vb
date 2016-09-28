<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvReport
        '
        Me.crvReport.ActiveViewIndex = -1
        Me.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReport.Location = New System.Drawing.Point(0, 0)
        Me.crvReport.Name = "crvReport"
        Me.crvReport.SelectionFormula = ""
        Me.crvReport.Size = New System.Drawing.Size(828, 659)
        Me.crvReport.TabIndex = 0
        Me.crvReport.ViewTimeSelectionFormula = ""
        '
        'frmVReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 659)
        Me.Controls.Add(Me.crvReport)
        Me.KeyPreview = True
        Me.Name = "frmVReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polytechnic University of the Philippines Sta. Maria Bulacan Campus Student Secur" & _
            "ity Monitoring System Using RFID with SMS Technology"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
