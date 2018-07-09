Public Class AdminSignIn
    Private Sub AdminSignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        intCurrentForm = 11
        InitForm(Me, picLogo)
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        bolLocked = True
        bolAdminOverride = False
        GoToForm(Me, AdminOverride)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        strCurrentLevel = Nothing
        strCurrentMode = Nothing
        strCurrentUser = Nothing
        strNonAdminUser = Nothing
        bolAdminOverride = False
        GoToForm(Me, Login)
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnEditFam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditFam.Click
        GoToForm(Me, AdminFamilyChoice)
    End Sub

    Private Sub btnEditEvents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEvents.Click
        GoToForm(Me, EventCalendar)
    End Sub

    Private Sub btnEditSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSettings.Click
        GoToForm(Me, EditSettings)
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "Logout"
        LogsDataGridView.Item(2, intRow).Value = intCurrentLogin
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = strCurrentUser & " logged out."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class