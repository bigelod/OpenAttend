Public Class EditLogin
    Dim bolNewLogin As Boolean
    Dim bolException As Boolean

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub

    Private Sub LogsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)

    End Sub

    Private Sub EditLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.OpenAttendDataSet.Login)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)

        intCurrentForm = 22
        InitForm(Me, picLogo)

        If intCurrentLogin = 0 Then
            lblTitle.Text = "Add Login"
            lstLoginlevel.SelectedIndex = 2 'By default, assume the login is for guests/registration
            bolNewLogin = True
        Else
            lblTitle.Text = "Edit Login"
            bolNewLogin = False
            LoadLoginDetails()
        End If
    End Sub
    Private Sub SaveLoginDetails()
        Dim intRow As Integer

        Me.LoginTableAdapter.Fill(Me.OpenAttendDataSet.Login)

        If txtUsername.Text = Nothing Then
            bolException = True
            Keyboard.Close()
            MessageBox.Show("Incorrect username entered (must not be blank).", "Unable to create/edit login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If intCurrentLogin = 0 Then

            LoginBindingSource.MoveFirst()
            For i = 0 To LoginBindingSource.Count - 1 'To check if the name has already been used
                If LoginDataGridView.CurrentRow.Cells(1).Value = txtUsername.Text Then
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect username entered (already used).", "Unable to create/edit login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                LoginBindingSource.MoveNext()
            Next

            intCurrentLogin = LoginBindingSource.Count() + 1

            LoginBindingSource.AddNew()
            intRow = LoginDataGridView.NewRowIndex - 1

            LoginDataGridView.Item(0, intRow).Value = intCurrentLogin
        Else
            LoginBindingSource.MoveFirst()
            For i = 0 To LoginBindingSource.Count - 1
                If LoginDataGridView.CurrentRow.Cells(0).Value = intCurrentLogin Then
                    intRow = i
                    Exit For
                ElseIf LoginDataGridView.CurrentRow.Cells(1).Value = txtUsername.Text Then
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect username entered (already used).", "Unable to create/edit login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                LoginBindingSource.MoveNext()
            Next
        End If


        LoginDataGridView.Item(1, intRow).Value = txtUsername.Text
        LoginDataGridView.Item(3, intRow).Value = txtPassword.Text
        LoginDataGridView.Item(2, intRow).Value = lstLoginlevel.SelectedItem

        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.LoginTableAdapter.Update(Me.OpenAttendDataSet.Login)
    End Sub
    Private Sub LoadLoginDetails()

        For i = 0 To LoginBindingSource.Count - 1
            If LoginDataGridView.CurrentRow.Cells(0).Value = intCurrentLogin Then
                txtUsername.Text = LoginDataGridView.CurrentRow.Cells(1).Value
                txtPassword.Text = LoginDataGridView.CurrentRow.Cells(3).Value
                lstLoginlevel.SelectedItem = LoginDataGridView.CurrentRow.Cells(2).Value
                Exit For
            End If
            LoginBindingSource.MoveNext()
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GoToForm(Me, EditLogins)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            SaveLoginDetails()
            If bolException = False Then
                SaveLog()
                GoToForm(Me, EditLogins)
            Else
                Keyboard.Close()
                MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Public Sub ProcessInput(ByVal strInput As String)
        If strInput <> Nothing Then
            Select Case UCase(strInput)
                Case "DELETE"
                    Try
                        Select Case intSelectedTxtBox
                            Case 1
                                txtUsername.Text = DeleteLast(txtUsername.Text)
                            Case 2
                                txtPassword.Text = DeleteLast(txtPassword.Text)
                        End Select
                    Catch ex As Exception
                        'Nevermind the error
                    End Try
                Case "HELP"
                    ShowHelp(5)
                Case "CLEAR"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtUsername.Text = ""
                        Case 2
                            txtPassword.Text = ""
                    End Select
                Case "CUT"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtUsername.Text)
                            txtUsername.Text = ""
                        Case 2
                            Clipboard.SetText(txtPassword.Text)
                            txtPassword.Text = ""
                    End Select
                Case "COPY"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtUsername.Text)
                        Case 2
                            Clipboard.SetText(txtPassword.Text)
                    End Select
                Case "PASTE"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtUsername.Text += Clipboard.GetText()
                        Case 2
                            txtPassword.Text += Clipboard.GetText()
                    End Select
                Case Else
                    Select Case intSelectedTxtBox
                        Case 1
                            txtUsername.Text += strInput
                        Case 2
                            txtPassword.Text += strInput
                    End Select
            End Select
        End If

        If txtUsername.TextLength > 16 Then txtUsername.Text = Mid(txtUsername.Text, 1, 16)
        If txtPassword.TextLength > 16 Then txtPassword.Text = Mid(txtPassword.Text, 1, 16)

        txtUsername.SelectionStart() = txtUsername.Text.Length
        txtPassword.SelectionStart() = txtPassword.Text.Length
    End Sub

    Private Sub txtUsername_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.Click
        intSelectedTxtBox = 1
    End Sub

    Private Sub txtPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Click
        intSelectedTxtBox = 2
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        If bolNewLogin = True Then
            LogsDataGridView.Item(1, intRow).Value = "LoginCreate"
            LogsDataGridView.Item(6, intRow).Value = "Login " & txtUsername.Text & " created."
        Else
            LogsDataGridView.Item(1, intRow).Value = "LoginEdit"
            LogsDataGridView.Item(6, intRow).Value = "Login " & txtUsername.Text & " edited."
        End If

        LogsDataGridView.Item(2, intRow).Value = intCurrentLogin
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()


        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class