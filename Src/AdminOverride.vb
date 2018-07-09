Public Class AdminOverride

    Private Sub AdminOverride_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.OpenAttendDataSet.Login)

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
                    ShowHelp(4)
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
                    Select Case UCase(Login_LevelTextBox.Text)
                        Case "ADMIN"
                            If bolLocked = True Then
                                bolLocked = False
                            Else
                                bolAdminOverride = True
                                strNonAdminUser = strCurrentUser
                                strCurrentUser = txtUsername.Text
                            End If
                            Select Case intCurrentForm
                                Case 3 'If previous screen was the welcome screen
                                    GoToForm(Me, AdminSignIn)
                                Case 10 'If previous screen was the group registration screen
                                    GoToForm(Me, GroupRegister)
                                Case 11
                                    GoToForm(Me, AdminSignIn)
                            End Select
                        Case Else
                            Keyboard.Close()
                            MessageBox.Show("Error: User is not an administrator.", "Unable to login as admin", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End Select
                    Exit For
                End If
            ElseIf i = LoginBindingSource.Count Then
                Keyboard.Close()
                MessageBox.Show("Error: Username or password incorrect.", "Unable to login as admin", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If bolLocked Then
            Keyboard.Close()
            MessageBox.Show("Error: Admin must sign in to unlock station.", "System locked", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Keyboard.Close()
            Select Case intCurrentForm
                Case 3
                    GoToForm(Me, SignIn)
                Case 10
                    GoToForm(Me, GroupRegister)
            End Select
        End If
    End Sub
End Class