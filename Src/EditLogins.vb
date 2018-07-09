Public Class EditLogins
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intNumLogins As Integer
    Dim intSelectedID As Integer
    Dim strLoginDetails(9999, 3) As String

    Private Sub EditLogins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.OpenAttendDataSet.Login)


        intCurrentForm = 21
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "Row.bmp"
        picRow2.ImageLocation = strPicturePath & "Row.bmp"
        picRow3.ImageLocation = strPicturePath & "Row.bmp"
        picRow4.ImageLocation = strPicturePath & "Row.bmp"

        intCurrentLogin = 0

        InitPages()
    End Sub
    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intNumLogins = 0
        intCurrentPage = 1

        ClearRows()

        LoginBindingSource.MoveFirst()
        For i = 0 To LoginBindingSource.Count - 1
            If UCase(LoginDataGridView.CurrentRow.Cells(1).Value) <> "DELETED" Then
                intNumLogins += 1
                strLoginDetails(intNumLogins, 1) = Str(LoginDataGridView.CurrentRow.Cells(0).Value)
                strLoginDetails(intNumLogins, 2) = LoginDataGridView.CurrentRow.Cells(1).Value
                strLoginDetails(intNumLogins, 3) = LoginDataGridView.CurrentRow.Cells(2).Value
            End If

            LoginBindingSource.MoveNext()
        Next

        If intNumLogins > 0 Then
            intMaxPages = Math.Ceiling(intNumLogins / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateLogin()
            SelectRow(1)
        Else
            For i = 1 To 9999
                strLoginDetails(i, 1) = Nothing
                strLoginDetails(i, 2) = Nothing
                strLoginDetails(i, 3) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblLogin1.ForeColor = Color.White
        lblLogin2.ForeColor = Color.White
        lblLogin3.ForeColor = Color.White
        lblLogin4.ForeColor = Color.White

        lblLogin1.Text = "N/A"
        lblLogin2.Text = "N/A"
        lblLogin3.Text = "N/A"
        lblLogin4.Text = "N/A"

    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to select the current login for editing
        Dim intLogin As Integer
        intLogin = ((intCurrentPage - 1) * 4) + intRow

        lblLogin1.ForeColor = Color.White
        lblLogin2.ForeColor = Color.White
        lblLogin3.ForeColor = Color.White
        lblLogin4.ForeColor = Color.White

        intSelectedID = strLoginDetails(intLogin, 1)

        Select Case intRow
            Case 1
                lblLogin1.ForeColor = Color.Yellow
            Case 2
                lblLogin2.ForeColor = Color.Yellow
            Case 3
                lblLogin3.ForeColor = Color.Yellow
            Case 4
                lblLogin4.ForeColor = Color.Yellow
        End Select

    End Sub
    Private Sub UpdateLogin()
        'Update the logins
        Dim intLoginLeft As Integer
        Dim intStartLogin As Integer

        ClearRows()

        If intNumLogins > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartLogin = ((intCurrentPage - 1) * 4) + 1

                lblLogin1.Text = strLoginDetails(intStartLogin, 2) & vbNewLine & strLoginDetails(intStartLogin, 3)
                lblLogin2.Text = strLoginDetails(intStartLogin + 1, 2) & vbNewLine & strLoginDetails(intStartLogin + 1, 3)
                lblLogin3.Text = strLoginDetails(intStartLogin + 2, 2) & vbNewLine & strLoginDetails(intStartLogin + 2, 3)
                lblLogin4.Text = strLoginDetails(intStartLogin + 3, 2) & vbNewLine & strLoginDetails(intStartLogin + 3, 3)

            ElseIf (intNumLogins Mod 4) > 0 Then
                intLoginLeft = intNumLogins Mod 4
                intStartLogin = ((intCurrentPage - 1) * 4) + 1

                lblLogin1.Text = strLoginDetails(intStartLogin, 2) & vbNewLine & strLoginDetails(intStartLogin, 3)

                Select Case intLoginLeft
                    Case 4
                        lblLogin2.Text = strLoginDetails(intStartLogin + 1, 2) & vbNewLine & strLoginDetails(intStartLogin + 1, 3)
                        lblLogin3.Text = strLoginDetails(intStartLogin + 2, 2) & vbNewLine & strLoginDetails(intStartLogin + 2, 3)
                        lblLogin4.Text = strLoginDetails(intStartLogin + 3, 2) & vbNewLine & strLoginDetails(intStartLogin + 3, 3)
                    Case 3
                        lblLogin2.Text = strLoginDetails(intStartLogin + 1, 2) & vbNewLine & strLoginDetails(intStartLogin + 1, 3)
                        lblLogin3.Text = strLoginDetails(intStartLogin + 2, 2) & vbNewLine & strLoginDetails(intStartLogin + 2, 3)
                        lblLogin4.Text = "N/A"
                    Case 2
                        lblLogin2.Text = strLoginDetails(intStartLogin + 1, 2) & vbNewLine & strLoginDetails(intStartLogin + 1, 3)
                        lblLogin3.Text = "N/A"
                        lblLogin4.Text = "N/A"
                    Case Else
                        lblLogin2.Text = "N/A"
                        lblLogin3.Text = "N/A"
                        lblLogin4.Text = "N/A"
                End Select
            Else 'Four logins
                intStartLogin = ((intCurrentPage - 1) * 4) + 1

                lblLogin1.Text = strLoginDetails(intStartLogin, 2) & vbNewLine & strLoginDetails(intStartLogin, 3)
                lblLogin2.Text = strLoginDetails(intStartLogin + 1, 2) & vbNewLine & strLoginDetails(intStartLogin + 1, 3)
                lblLogin3.Text = strLoginDetails(intStartLogin + 2, 2) & vbNewLine & strLoginDetails(intStartLogin + 2, 3)
                lblLogin4.Text = strLoginDetails(intStartLogin + 3, 2) & vbNewLine & strLoginDetails(intStartLogin + 3, 3)
            End If
        End If
    End Sub
    Private Sub UpdateButtons()
        'The code to change the image of each button
        Select Case intCurrentPage
            Case 1
                picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

                If intMaxPages > 1 Then
                    picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
                Else
                    picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
                End If

            Case intMaxPages

                picButUp.ImageLocation = strPicturePath & "UpButton.bmp"
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"

            Case Else

                picButUp.ImageLocation = strPicturePath & "UpButton.bmp"
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"

        End Select
    End Sub
    Private Sub ChangePage()
        'A sub to change the current page
        Select Case intDir
            Case 1

                intCurrentPage += 1
                If intCurrentPage > intMaxPages Then intCurrentPage = intMaxPages

            Case -1

                intCurrentPage -= 1
                If intCurrentPage < 1 Then intCurrentPage = 1

        End Select

        UpdateLogin()

        intSelectedID = 0
        SelectRow(1)

        lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
    End Sub

    Private Sub picButUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picButUp.Click
        intDir = -1
        ChangePage()
        UpdateButtons()
    End Sub

    Private Sub picButDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picButDown.Click
        intDir = 1
        ChangePage()
        UpdateButtons()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, EditSettings)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub

    Private Sub btnEditLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditLogin.Click
        intCurrentLogin = intSelectedID
        GoToForm(Me, EditLogin)
    End Sub

    Private Sub btnRemoveLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveLogin.Click
        'A sub to remove the selected login
        If MessageBox.Show("Are you sure you wish to remove this login?", "Confirmation of removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LoginBindingSource.MoveFirst()
            For i = 0 To LoginBindingSource.Count - 1
                If intSelectedID = LoginDataGridView.CurrentRow.Cells(0).Value Then
                    If (strLoginDetails(intSelectedID, 1) + 1) <> LoginDataGridView.CurrentRow.Cells(0).Value Then
                        'The login can only be deleted if it is not the current login
                        LoginDataGridView.CurrentRow.Cells(1).Value = "DELETED"
                        SaveLog()
                        Exit For
                    Else
                        'Otherwise, don't let the user delete the login
                        MessageBox.Show("Error: Login selected is currently in use", "Unable to remove login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                End If

                LoginBindingSource.MoveNext()
            Next

            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OpenAttendDataSet)

            InitPages()
            lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
        End If
    End Sub

    Private Sub btnAddLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLogin.Click
        intCurrentLogin = 0
        GoToForm(Me, EditLogin)
    End Sub

    Private Sub lblLogin4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogin4.Click
        If lblLogin4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblLogin4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub lblLogin3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogin3.Click
        If lblLogin3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblLogin3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub lblLogin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogin2.Click
        If lblLogin2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblLogin2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub lblLogin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogin1.Click
        If lblLogin1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblLogin1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "LoginDelete"
        LogsDataGridView.Item(2, intRow).Value = intSelectedID
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = "Login " & strLoginDetails(intSelectedID, 2) & " deleted."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub

End Class