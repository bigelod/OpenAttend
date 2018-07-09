Public Class EditSettings

    Private Sub btnEditLogins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditLogins.Click
        GoToForm(Me, EditLogins)
    End Sub

    Private Sub EditSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intCurrentForm = 20
        InitForm(Me, picLogo)
    End Sub

    Private Sub btnViewLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewLogs.Click
        GoToForm(Me, ViewLogs)
    End Sub

    Private Sub btnViewStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewStats.Click
        GoToForm(Me, Reports)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, AdminSignIn)
    End Sub
End Class