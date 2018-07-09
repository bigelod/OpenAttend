Public Class Login
    Dim intLoginID As Integer
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.OpenAttendDataSet.Login)

        intCurrentForm = 1
        InitForm(Me, picLogo)

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
                            Clipboard.SetText(MaskText(txtPassword.Text, "*"))
                            txtPassword.Text = ""
                    End Select
                Case "COPY"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtUsername.Text)
                        Case 2
                            Clipboard.SetText(MaskText(txtPassword.Text, "*"))
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
        Keyboard.Focus()
    End Sub

    Private Sub txtPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Click
        intSelectedTxtBox = 2
        Keyboard.Focus()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Keyboard.Focus()
        LoginBindingSource.MoveFirst()

        For i = 0 To LoginBindingSource.Count

            If txtUsername.Text = User_NameTextBox.Text And txtUsername.Text <> "DELETED" Then
                If txtPassword.Text = PasswordTextBox.Text Then
                    strCurrentLevel = Login_LevelTextBox.Text
                    Select Case UCase(strCurrentLevel)
                        Case "ADMIN"
                            strCurrentUser = txtUsername.Text
                        Case Else
                            strCurrentUser = txtUsername.Text
                            strNonAdminUser = txtUsername.Text
                    End Select

                    intLoginID = i

                    SaveLog()

                    GoToForm(Me, TerminalMode)
                    Exit For
                End If
            ElseIf i = LoginBindingSource.Count Then
                Keyboard.Close()
                MessageBox.Show("Error: Username or password incorrect.", "Unable to login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit For
            End If

            LoginBindingSource.MoveNext()
        Next

    End Sub

    Private Sub Login_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Keyboard.Focus()
    End Sub

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "Login"
        LogsDataGridView.Item(2, intRow).Value = intLoginID
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = strCurrentUser & " logged in."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class
