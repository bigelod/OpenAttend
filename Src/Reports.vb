Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Reports
    Dim cryRpt As New ReportDocument
    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    Dim crParameterFieldDefinition As ParameterFieldDefinition
    Dim crParameterValues As New ParameterValues
    Dim crParameterDiscreteValue As New ParameterDiscreteValue

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        intCurrentForm = 26
        Me.Top = 0
        Me.Left = 0

        intSelectedTxtBox = 0
        Keyboard.Close()

        lstReports.SelectedIndex = 0
    End Sub

    Private Sub lstReports_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstReports.SelectedIndexChanged
        Dim strReportName As String

        Select Case lstReports.SelectedIndex
            Case 0
                strReportName = "YouthAttendanceForDate"
                lblDate1.Visible = True
                dtpDate1.Visible = True
                lblDate2.Visible = False
                dtpDate2.Visible = False
            Case 1
                strReportName = "MemberByRegistrationDate"
                lblDate1.Visible = True
                dtpDate1.Visible = True
                lblDate2.Visible = True
                dtpDate2.Visible = True
            Case Else
                strReportName = "CongregationByAgeRatio"
                lblDate1.Visible = False
                dtpDate1.Visible = False
                lblDate2.Visible = False
                dtpDate2.Visible = False
        End Select

        cryRpt.Load(strReportPath & strReportName & ".rpt")
        cryRpt.SetDatabaseLogon("sa", "root")
        displayCR()
    End Sub
    Public Sub displayCR()
        'Modified version of a tutorial provided by my teacher
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields

        If lstReports.SelectedIndex <> 2 Then
            crParameterDiscreteValue.Value = dtpDate1.Value
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("StartDate")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            If lstReports.SelectedIndex = 1 Then
                crParameterDiscreteValue.Value = dtpDate2.Value
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("EndDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End If

        End If

        

        crvReportView.ReportSource = cryRpt
        crvReportView.Refresh()

    End Sub
    Private Sub dtpDate1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate1.ValueChanged
        displayCR()
    End Sub

    Private Sub dtpDate2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate2.ValueChanged
        displayCR()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, EditSettings)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        crvReportView.PrintReport()
    End Sub

End Class