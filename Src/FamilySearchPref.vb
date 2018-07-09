Public Class FamilySearchPref

    Private Sub FamilySearchPref_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Families' table. You can move, or remove it, as needed.
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)
        intCurrentForm = 14
        InitForm(Me, picLogo)
    End Sub

    Public Sub ProcessInput(ByVal strInput As String)
        If strInput <> Nothing Then
            Select Case UCase(strInput)
                Case "DELETE"
                    Try
                        txtFamilyName.Text = DeleteLast(txtFamilyName.Text)
                    Catch ex As Exception
                        'Nevermind the error
                    End Try
                Case "HELP"
                    ShowHelp(5)
                Case "CLEAR"
                    txtFamilyName.Text = ""
                Case "CUT"
                    Clipboard.SetText(txtFamilyName.Text)
                    txtFamilyName.Text = ""
                Case "COPY"
                    Clipboard.SetText(txtFamilyName.Text)
                Case "PASTE"
                    txtFamilyName.Text += Clipboard.GetText()
                Case Else
                    txtFamilyName.Text += strInput
            End Select
        End If

        If txtFamilyName.TextLength > 25 Then txtFamilyName.Text = Mid(txtFamilyName.Text, 1, 25)

        txtFamilyName.SelectionStart() = txtFamilyName.Text.Length

    End Sub

    Private Sub FamiliesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FamiliesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OpenAttendDataSet)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Keyboard.Close()
        If txtFamilyName.Text <> "" Then
            For i = 0 To FamiliesBindingSource.Count - 1
                If FamiliesDataGridView.CurrentRow.Cells(1).Value = txtFamilyName.Text Then
                    intCurrentFamily = FamiliesDataGridView.CurrentRow.Cells(0).Value
                    strFamilyName = FamiliesDataGridView.CurrentRow.Cells(1).Value
                    GoToForm(Me, AdminEditFamily)
                    Exit Sub
                End If
                FamiliesBindingSource.MoveNext()
            Next
            MessageBox.Show("Error: Family name not found.", "Unknown family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            MessageBox.Show("Error: No family name entered.", "Family name needed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, AdminFamilyChoice)
    End Sub
End Class