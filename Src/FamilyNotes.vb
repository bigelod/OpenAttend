Public Class FamilyNotes

    Private Sub FamilyNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Families' table. You can move, or remove it, as needed.
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)

        intCurrentForm = 16
        InitForm(Me, picLogo)

        FamiliesBindingSource.MoveFirst()
        For i = 0 To FamiliesBindingSource.Count - 1
            If FamiliesDataGridView.CurrentRow.Cells(0).Value = intCurrentFamily Then
                lblFamilyName.Text = "Family Name: " & FamiliesDataGridView.CurrentRow.Cells(1).Value
                If FamiliesDataGridView.CurrentRow.Cells(7).Value() <> "" Then txtDetails.Text = FamiliesDataGridView.CurrentRow.Cells(7).Value()
                Exit For
            ElseIf i = FamiliesBindingSource.Count Then 'Unknown ID, cancel editing
                Keyboard.Close()
                MessageBox.Show("Error: Unknown family.", "Unable to edit family notes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                GoToForm(Me, FamilyMembers)
            End If
            FamiliesBindingSource.MoveNext()
        Next
    End Sub

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Try
            SaveFamilyNotes()
            GoToForm(Me, AdminEditFamily)
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("Error: Notes could not be saved", "Unable to save family notes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            GoToForm(Me, AddMember)
        End Try
    End Sub
    Private Sub SaveFamilyNotes()
        Dim intRow As Integer

        FamiliesBindingSource.MoveFirst()
        For i = 0 To FamiliesBindingSource.Count - 1
            If FamiliesDataGridView.CurrentRow.Cells(0).Value = intCurrentFamily Then
                intRow = i
                Exit For
            End If
            FamiliesBindingSource.MoveNext()
        Next

        If txtDetails.Text <> "" Then
            FamiliesDataGridView.Item(7, intRow).Value = txtDetails.Text
        Else
            FamiliesDataGridView.Item(7, intRow).Value = ""
        End If

        Me.Validate()
        Me.FamiliesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OpenAttendDataSet)
    End Sub
    Public Sub ProcessInput(ByVal strInput As String)

        If strInput <> Nothing Then
            Select Case UCase(strInput)
                Case "DELETE"
                    Try
                        txtDetails.Text = DeleteLast(txtDetails.Text)
                    Catch ex As Exception
                        'Nevermind the error
                    End Try
                Case "HELP"
                    ShowHelp(5)
                Case "CLEAR"
                    txtDetails.Text = ""
                Case "CUT"
                    Clipboard.SetText(txtDetails.Text)
                    txtDetails.Text = ""
                Case "COPY"
                    Clipboard.SetText(txtDetails.Text)
                Case "PASTE"
                    txtDetails.Text += Clipboard.GetText()
                Case Else
                    txtDetails.Text += strInput
            End Select
        End If

        If txtDetails.TextLength > 255 Then txtDetails.Text = Mid(txtDetails.Text, 1, 255)

        txtDetails.SelectionStart() = txtDetails.TextLength

    End Sub
End Class