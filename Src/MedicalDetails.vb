Public Class MedicalDetails

    Private Sub MedicalDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        intCurrentForm = 17
        InitForm(Me, picLogo)

        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                lblMemberName.Text = "Member Name: " & PeopleDataGridView.CurrentRow.Cells(1).Value & " " & PeopleDataGridView.CurrentRow.Cells(2).Value
                If PeopleDataGridView.CurrentRow.Cells(11).Value() <> "N/A" Then txtDetails.Text = PeopleDataGridView.CurrentRow.Cells(11).Value()
                Exit For
            ElseIf i = PeopleBindingSource.Count Then 'Unknown ID, cancel editing
                Keyboard.Close()
                MessageBox.Show("Error: Unknown member.", "Unable to edit medical details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                GoToForm(Me, FamilyMembers)
            End If
            PeopleBindingSource.MoveNext()
        Next
    End Sub
    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Try
            SaveMemberData()
            GoToForm(Me, AddMember)
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to save medical details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            GoToForm(Me, AddMember)
        End Try
    End Sub
    
    Private Sub SaveMemberData()
        Dim intRow As Integer

        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                intRow = i
                Exit For
            End If
            PeopleBindingSource.MoveNext()
        Next

        If txtDetails.Text <> "" Then
            PeopleDataGridView.Item(11, intRow).Value = txtDetails.Text
        Else
            PeopleDataGridView.Item(11, intRow).Value = "N/A"
        End If


        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
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

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub
End Class