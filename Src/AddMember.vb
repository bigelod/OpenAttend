Public Class AddMember
    Dim bolCRB As Boolean
    Dim bolNewPerson As Boolean
    Dim bolException As Boolean
    Private Sub AddMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        intCurrentForm = 7
        InitForm(Me, picLogo)

        picPersonPhoto.ImageLocation = strPicturePath & "PersonPhoto.bmp"

        If intCurrentPerson = 0 Then 'If the person is being added, they need an ID
            bolNewPerson = True
            txtSurname.Text = strFamilyName
            lblTitle.Text = "Add Member"
            bolCRB = False
            bolPhotoTaken = False
        Else 'Otherwise, load their details
            PeopleBindingSource.MoveFirst()
            For i = 0 To PeopleBindingSource.Count - 1
                If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                    LoadDetails()
                    bolNewPerson = False
                    lblTitle.Text = "Edit Member"
                    bolPhotoTaken = True
                    Exit For
                ElseIf i = PeopleBindingSource.Count Then 'Unknown ID, cancel editing
                    Keyboard.Close()
                    MessageBox.Show("Error: Unknown member.", "Unable to edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoToForm(Me, FamilyMembers)
                End If
                PeopleBindingSource.MoveNext()
            Next
        End If

        If UCase(strCurrentLevel) = "ADMIN" Or bolAdminOverride = True Then
            picTick.Visible = True
            lblCRB.Visible = True
        Else
            picTick.Visible = False
            lblCRB.Visible = False
        End If
    End Sub
    Public Sub ProcessInput(ByVal strInput As String)

        If strInput <> Nothing Then
            Select Case UCase(strInput)
                Case "DELETE"
                    Try
                        Select Case intSelectedTxtBox
                            Case 1
                                txtName.Text = DeleteLast(txtName.Text)
                            Case 2
                                txtSurname.Text = DeleteLast(txtSurname.Text)
                            Case 3
                                txtEmail.Text = DeleteLast(txtEmail.Text)
                            Case 4
                                txtMobile.Text = DeleteLast(txtMobile.Text)
                            Case 5
                                txtDay.Text = DeleteLast(txtDay.Text)
                            Case 6
                                txtMonth.Text = DeleteLast(txtMonth.Text)
                            Case 7
                                txtYear.Text = DeleteLast(txtYear.Text)
                        End Select
                    Catch ex As Exception
                        'Nevermind the error
                    End Try
                Case "HELP"
                    ShowHelp(5)
                Case "CLEAR"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtName.Text = ""
                        Case 2
                            txtSurname.Text = ""
                        Case 3
                            txtEmail.Text = ""
                        Case 4
                            txtMobile.Text = ""
                        Case 5
                            txtDay.Text = ""
                        Case 6
                            txtMonth.Text = ""
                        Case 7
                            txtYear.Text = ""
                    End Select
                Case "CUT"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtName.Text)
                            txtName.Text = ""
                        Case 2
                            Clipboard.SetText(txtSurname.Text)
                            txtSurname.Text = ""
                        Case 3
                            Clipboard.SetText(txtEmail.Text)
                            txtEmail.Text = ""
                        Case 4
                            Clipboard.SetText(txtMobile.Text)
                            txtMobile.Text = ""
                        Case 5
                            Clipboard.SetText(txtDay.Text)
                            txtDay.Text = ""
                        Case 6
                            Clipboard.SetText(txtMonth.Text)
                            txtMonth.Text = ""
                        Case 7
                            Clipboard.SetText(txtYear.Text)
                            txtYear.Text = ""
                    End Select
                Case "COPY"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtName.Text)
                        Case 2
                            Clipboard.SetText(txtSurname.Text)
                        Case 3
                            Clipboard.SetText(txtEmail.Text)
                        Case 4
                            Clipboard.SetText(txtMobile.Text)
                        Case 5
                            Clipboard.SetText(txtDay.Text)
                        Case 6
                            Clipboard.SetText(txtMonth.Text)
                        Case 7
                            Clipboard.SetText(txtYear.Text)
                    End Select
                Case "PASTE"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtName.Text += Clipboard.GetText()
                        Case 2
                            txtSurname.Text += Clipboard.GetText()
                        Case 3
                            txtEmail.Text += Clipboard.GetText()
                        Case 4
                            txtMobile.Text += Clipboard.GetText()
                        Case 5
                            txtDay.Text += Clipboard.GetText()
                        Case 6
                            txtMonth.Text += Clipboard.GetText()
                        Case 7
                            txtYear.Text += Clipboard.GetText()
                    End Select
                Case Else
                    Select Case intSelectedTxtBox
                        Case 1
                            txtName.Text += strInput
                        Case 2
                            txtSurname.Text += strInput
                        Case 3
                            txtEmail.Text += strInput
                        Case 4
                            txtMobile.Text += strInput
                        Case 5
                            txtDay.Text += strInput
                        Case 6
                            txtMonth.Text += strInput
                        Case 7
                            txtYear.Text += strInput
                    End Select
            End Select
        End If

        If txtName.TextLength > 25 Then txtName.Text = Mid(txtName.Text, 1, 25)
        If txtSurname.TextLength > 25 Then txtSurname.Text = Mid(txtSurname.Text, 1, 25)
        If txtEmail.TextLength > 50 Then txtEmail.Text = Mid(txtEmail.Text, 1, 50)
        If txtMobile.TextLength > 13 Then txtMobile.Text = Mid(txtMobile.Text, 1, 13)
        If txtDay.TextLength > 2 Then txtDay.Text = Mid(txtDay.Text, 1, 2)
        If txtMonth.TextLength > 2 Then txtMonth.Text = Mid(txtMonth.Text, 1, 2)
        If txtYear.TextLength > 4 Then txtYear.Text = Mid(txtYear.Text, 1, 4)


        txtName.SelectionStart() = txtName.Text.Length
        txtSurname.SelectionStart() = txtSurname.Text.Length
        txtEmail.SelectionStart() = txtEmail.Text.Length
        txtMobile.SelectionStart() = txtMobile.Text.Length

    End Sub

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub


    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OpenAttendDataSet)
    End Sub

    Private Sub picPersonPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPersonPhoto.Click
        Keyboard.Close()
        TakePhoto.Show()
        TakePhoto.Focus()
        Me.Enabled() = False
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, FamilyMembers)
    End Sub

    Private Sub LoadDetails()
        Dim datDOB As Date
        txtName.Text = PeopleDataGridView.CurrentRow.Cells(1).Value
        txtSurname.Text = PeopleDataGridView.CurrentRow.Cells(2).Value
        txtEmail.Text = PeopleDataGridView.CurrentRow.Cells(6).Value
        txtMobile.Text = PeopleDataGridView.CurrentRow.Cells(5).Value
        datDOB = PeopleDataGridView.CurrentRow.Cells(4).Value
        bolCRB = PeopleDataGridView.CurrentRow.Cells(10).Value

        Select Case UCase(PeopleDataGridView.CurrentRow.Cells(3).Value)
            Case "MALE"
                radMale.Checked = True
            Case "FEMALE"
                radFemale.Checked = True
            Case Else
                radMale.Checked = True
        End Select

        txtDay.Text = datDOB.Day()
        txtMonth.Text = datDOB.Month()
        txtYear.Text = datDOB.Year()

        picPersonPhoto.ImageLocation = "\\" & strServer & "\SharedDocs\OpenAttend\PPhotos\" & intCurrentPerson & ".png"

        Select Case bolCRB
            Case True
                picTick.ImageLocation = strPicturePath & "Tick.bmp"
            Case False
                picTick.ImageLocation = strPicturePath & "Cross.bmp"
        End Select
    End Sub

    Private Sub txtName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Click
        intSelectedTxtBox = 1
    End Sub

    Private Sub txtSurname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSurname.Click
        intSelectedTxtBox = 2
    End Sub

    Private Sub txtEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Click
        intSelectedTxtBox = 3
    End Sub

    Private Sub txtMobile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobile.Click
        intSelectedTxtBox = 4
    End Sub

    Private Sub txtDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDay.Click
        intSelectedTxtBox = 5
        If txtDay.Text = "DD" Then
            txtDay.Text = ""
        End If
    End Sub

    Private Sub txtMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.Click
        intSelectedTxtBox = 6
        If txtMonth.Text = "MM" Then
            txtMonth.Text = ""
        End If
    End Sub

    Private Sub txtYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.Click
        intSelectedTxtBox = 7
        If txtYear.Text = "YYYY" Then
            txtYear.Text = ""
        End If
    End Sub

    Private Sub picTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick.Click
        If UCase(strCurrentLevel) = "ADMIN" Or bolAdminOverride = True Then
            Select Case bolCRB
                Case True
                    picTick.ImageLocation = strPicturePath & "Cross.bmp"
                    bolCRB = False
                Case False
                    picTick.ImageLocation = strPicturePath & "Tick.bmp"
                    bolCRB = True
            End Select
        End If
    End Sub

    Private Sub btnMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedical.Click
        bolException = False
        Try
            SaveMemberData()
            If bolException = False Then
                GoToForm(Me, MedicalDetails)
            Else
                MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        bolException = False
        Try
            SaveMemberData()
            If bolException = False Then
                SaveLog()
                GoToForm(Me, FamilyMembers)
            Else
                MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Sub SaveMemberData()
        Dim intRow As Integer
        Dim datDOB As Date

        bolException = False

        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)

        If intCurrentPerson = 0 Then
            intCurrentPerson = PeopleBindingSource.Count() + 1 'Get a person id if we don't have one
        End If

        If bolNewPerson = True Then
            PeopleBindingSource.AddNew()
            intRow = PeopleDataGridView.NewRowIndex - 1

            PeopleDataGridView.Item(0, intRow).Value = intCurrentPerson
        Else
            PeopleBindingSource.MoveFirst()
            For i = 0 To PeopleBindingSource.Count - 1
                If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                    intRow = i
                    Exit For
                End If
                PeopleBindingSource.MoveNext()
            Next
        End If

        If txtSurname.Text <> Nothing Then
            PeopleDataGridView.Item(1, intRow).Value = txtName.Text
            PeopleDataGridView.Item(2, intRow).Value = txtSurname.Text

            If radMale.Checked = True Then
                PeopleDataGridView.Item(3, intRow).Value = "Male"
            Else
                PeopleDataGridView.Item(3, intRow).Value = "Female"
            End If

            Try
                datDOB = Date.Parse(txtDay.Text & "/" & txtMonth.Text & "/" & txtYear.Text)
                If DateDiff(DateInterval.Day, Date.Now, datDOB) > 1 Then 'Can't be born in the future
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect date of birth entered (date of birth is in the future).", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    PeopleDataGridView.Item(4, intRow).Value = datDOB.Date
                End If
            Catch ex As Exception
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Incorrect date of birth entered.", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            PeopleDataGridView.Item(5, intRow).Value = txtMobile.Text
            PeopleDataGridView.Item(6, intRow).Value = txtEmail.Text

            picPersonPhoto.Image.Save("\\" & strServer & "\SharedDocs\OpenAttend\PPhotos\" & intCurrentPerson & ".png")

            If bolPhotoTaken = True Then
                PeopleDataGridView.Item(7, intRow).Value = intCurrentPerson & ".png"
            Else
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Missing member details (Photo required).", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            PeopleDataGridView.Item(8, intRow).Value = intCurrentFamily

            PeopleDataGridView.Item(9, intRow).Value = False 'Due to time restrictions, guardians will be added in a future release

            PeopleDataGridView.Item(10, intRow).Value = bolCRB

            If bolNewPerson = True Then 'If they are new, they have no medical details (yet)
                PeopleDataGridView.Item(11, intRow).Value = "N/A"
            End If

        Else
            bolException = True
            Keyboard.Close()
            MessageBox.Show("Missing member details (Surname required).", "Unable to create/edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.PeopleTableAdapter.Update(Me.OpenAttendDataSet.People)

    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow

        If bolNewPerson = True Then
            LogsDataGridView.Item(1, intRow).Value = "MemCreate"
            LogsDataGridView.Item(6, intRow).Value = "Member " & txtName.Text & " created."
        Else
            LogsDataGridView.Item(1, intRow).Value = "MemEdit"
            LogsDataGridView.Item(6, intRow).Value = "Member " & txtName.Text & " edited."
        End If

        LogsDataGridView.Item(2, intRow).Value = intCurrentPerson
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()


        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub

End Class