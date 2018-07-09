Public Class LogDetails

    Private Sub LogDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)

        intCurrentForm = 24
        InitForm(Me, picLogo)

        LogsBindingSource.MoveFirst()
        For i = 0 To LogsBindingSource.Count - 1
            If LogsDataGridView.CurrentRow.Cells(0).Value = intCurrentLog Then
                lblLogType.Text = LogsDataGridView.CurrentRow.Cells(1).Value
                lblLogDate.Text = Format(LogsDataGridView.CurrentRow.Cells(4).Value, "dddd, MMM d yyyy")
                lblLogTime.Text = Format(LogsDataGridView.CurrentRow.Cells(5).Value, "HH:mm")
                lblLogNotes.Text = LogsDataGridView.CurrentRow.Cells(6).Value
                Exit For
            End If
            LogsBindingSource.MoveNext()
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, ViewLogs)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub
End Class