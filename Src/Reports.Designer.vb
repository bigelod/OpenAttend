<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.CongregationByAgeRatio1 = New OpenAttend.CongregationByAgeRatio
        Me.MemberByRegistrationDate1 = New OpenAttend.MemberByRegistrationDate
        Me.crvReportView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lstReports = New System.Windows.Forms.ComboBox
        Me.lblReportSource = New System.Windows.Forms.Label
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker
        Me.lblDate1 = New System.Windows.Forms.Label
        Me.lblDate2 = New System.Windows.Forms.Label
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker
        Me.YouthAttendanceForDate1 = New OpenAttend.YouthAttendanceForDate
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1000, 75)
        Me.lblTitle.TabIndex = 88
        Me.lblTitle.Text = "Statistics"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(823, 687)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(189, 69)
        Me.btnBack.TabIndex = 98
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.Location = New System.Drawing.Point(12, 687)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(255, 69)
        Me.btnPrint.TabIndex = 99
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'crvReportView
        '
        Me.crvReportView.ActiveViewIndex = 0
        Me.crvReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportView.DisplayBackgroundEdge = False
        Me.crvReportView.DisplayGroupTree = False
        Me.crvReportView.Location = New System.Drawing.Point(189, 98)
        Me.crvReportView.Name = "crvReportView"
        Me.crvReportView.ReportSource = Me.MemberByRegistrationDate1
        Me.crvReportView.ShowCloseButton = False
        Me.crvReportView.ShowGroupTreeButton = False
        Me.crvReportView.ShowRefreshButton = False
        Me.crvReportView.Size = New System.Drawing.Size(823, 583)
        Me.crvReportView.TabIndex = 89
        '
        'lstReports
        '
        Me.lstReports.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstReports.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReports.FormattingEnabled = True
        Me.lstReports.Items.AddRange(New Object() {"Youth attendance for a given date", "New members within date range", "Congregation age ratio"})
        Me.lstReports.Location = New System.Drawing.Point(360, 711)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(457, 33)
        Me.lstReports.TabIndex = 100
        '
        'lblReportSource
        '
        Me.lblReportSource.AutoSize = True
        Me.lblReportSource.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportSource.Location = New System.Drawing.Point(273, 714)
        Me.lblReportSource.Name = "lblReportSource"
        Me.lblReportSource.Size = New System.Drawing.Size(81, 25)
        Me.lblReportSource.TabIndex = 101
        Me.lblReportSource.Text = "Report:"
        Me.lblReportSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate1
        '
        Me.dtpDate1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate1.Location = New System.Drawing.Point(12, 147)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(171, 23)
        Me.dtpDate1.TabIndex = 102
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(7, 119)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(112, 25)
        Me.lblDate1.TabIndex = 103
        Me.lblDate1.Text = "Start date:"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(7, 186)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(105, 25)
        Me.lblDate2.TabIndex = 105
        Me.lblDate2.Text = "End Date:"
        Me.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate2
        '
        Me.dtpDate2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate2.Location = New System.Drawing.Point(12, 214)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(171, 23)
        Me.dtpDate2.TabIndex = 104
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.dtpDate2)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.dtpDate1)
        Me.Controls.Add(Me.lblReportSource)
        Me.Controls.Add(Me.lstReports)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.crvReportView)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents crvReportView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents CongregationByAgeRatio1 As OpenAttend.CongregationByAgeRatio
    Friend WithEvents MemberByRegistrationDate1 As OpenAttend.MemberByRegistrationDate
    Friend WithEvents YouthAttendanceForDate1 As OpenAttend.YouthAttendanceForDate
    Friend WithEvents lstReports As System.Windows.Forms.ComboBox
    Friend WithEvents lblReportSource As System.Windows.Forms.Label
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
End Class
