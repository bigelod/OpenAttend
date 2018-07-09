Public Class AdminEditFamily
    Public myDymoAddin = New Dymo.DymoAddIn
    Public myLabel = New Dymo.DymoLabels
    Dim bolNewFamily As Boolean
    Dim bolException As Boolean
    Private Sub AdminEditFamily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)
        intCurrentForm = 15
        InitForm(Me, picLogo)

        picFamPhoto.ImageLocation = strPicturePath & "FamPhoto.bmp"

        If intCurrentFamily = 0 Then
            bolNewFamily = True
            lblTitle.Text = "Add Family"
            bolPhotoTaken = False
        Else
            bolNewFamily = False
            lblTitle.Text = "Edit Family"
            LoadFamilyDetails()
            bolPhotoTaken = True
        End If
    End Sub
    Public Sub ProcessInput(ByVal strInput As String)
        If strInput <> Nothing Then
            Select Case UCase(strInput)
                Case "DELETE"
                    Try
                        Select Case intSelectedTxtBox
                            Case 1
                                txtSurname.Text = DeleteLast(txtSurname.Text)
                            Case 2
                                txtPhone.Text = DeleteLast(txtPhone.Text)
                            Case 3
                                txtEmail.Text = DeleteLast(txtEmail.Text)
                            Case 4
                                txtAddress.Text = DeleteLast(txtAddress.Text)
                        End Select
                    Catch ex As Exception
                        'Nevermind the error
                    End Try
                Case "HELP"
                    ShowHelp(5)
                Case "CLEAR"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtSurname.Text = ""
                        Case 2
                            txtPhone.Text = ""
                        Case 3
                            txtEmail.Text = ""
                        Case 4
                            txtAddress.Text = ""
                    End Select
                Case "CUT"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtSurname.Text)
                            txtSurname.Text = ""
                        Case 2
                            Clipboard.SetText(txtPhone.Text)
                            txtPhone.Text = ""
                        Case 3
                            Clipboard.SetText(txtEmail.Text)
                            txtEmail.Text = ""
                        Case 4
                            Clipboard.SetText(txtAddress.Text)
                            txtAddress.Text = ""
                    End Select
                Case "COPY"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtSurname.Text)
                        Case 2
                            Clipboard.SetText(txtPhone.Text)
                        Case 3
                            Clipboard.SetText(txtEmail.Text)
                        Case 4
                            Clipboard.SetText(txtAddress.Text)
                    End Select
                Case "PASTE"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtSurname.Text += Clipboard.GetText()
                        Case 2
                            txtPhone.Text += Clipboard.GetText()
                        Case 3
                            txtEmail.Text += Clipboard.GetText()
                        Case 4
                            txtAddress.Text += Clipboard.GetText()
                    End Select
                Case Else
                    Select Case intSelectedTxtBox
                        Case 1
                            txtSurname.Text += strInput
                        Case 2
                            txtPhone.Text += strInput
                        Case 3
                            txtEmail.Text += strInput
                        Case 4
                            txtAddress.Text += strInput
                    End Select
            End Select
        End If

        If txtSurname.TextLength > 25 Then txtSurname.Text = Mid(txtSurname.Text, 1, 25)
        If txtPhone.TextLength > 13 Then txtPhone.Text = Mid(txtPhone.Text, 1, 13)
        If txtEmail.TextLength > 50 Then txtEmail.Text = Mid(txtEmail.Text, 1, 50)
        If txtAddress.TextLength > 50 Then txtAddress.Text = Mid(txtAddress.Text, 1, 50)

        txtSurname.SelectionStart() = txtSurname.TextLength
        txtPhone.SelectionStart() = txtPhone.TextLength
        txtEmail.SelectionStart() = txtEmail.TextLength
        txtAddress.SelectionStart() = txtAddress.TextLength()

    End Sub


    Private Sub txtSurname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSurname.Click
        intSelectedTxtBox = 1
    End Sub

    Private Sub txtPhone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.Click
        intSelectedTxtBox = 2
    End Sub

    Private Sub txtEmail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Click
        intSelectedTxtBox = 3
    End Sub

    Private Sub txtAddress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Click
        intSelectedTxtBox = 4
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, AdminFamilyChoice)
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

        Try
            SaveFamilyData()
            If bolException = False Then
                strFamilyName = txtSurname.Text

                Keyboard.Close()

                SaveLog()

                GoToForm(Me, FamilyMembers)
            Else
                Keyboard.Close()
                MessageBox.Show("An error occured, please contact an administrator", "Unable to create family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to create family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub
    Private Sub SaveFamilyData()
        Dim intRow As Integer
        Dim strBarcode As String
        Dim strExpireYear As String

        bolException = False

        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)

        If intCurrentFamily = 0 Then
            intCurrentFamily = FamiliesBindingSource.Count() 'Get a family number if we dont have one
        End If

        If bolNewFamily = True Then
            FamiliesBindingSource.AddNew()
            intRow = FamiliesDataGridView.NewRowIndex - 1

            FamiliesDataGridView.Item(5, intRow).Value = Date.Today
            FamiliesDataGridView.Item(7, intRow).Value = ""
        Else
            FamiliesBindingSource.MoveFirst()
            For i = 0 To FamiliesBindingSource.Count - 1
                If FamiliesDataGridView.CurrentRow.Cells(0).Value = intCurrentFamily Then
                    intRow = i
                    Exit For
                End If
                FamiliesBindingSource.MoveNext()
            Next
        End If
        

        If txtSurname.Text <> Nothing Then
            FamiliesDataGridView.Item(0, intRow).Value = intCurrentFamily
            FamiliesDataGridView.Item(1, intRow).Value = txtSurname.Text
            FamiliesDataGridView.Item(2, intRow).Value = txtPhone.Text
            FamiliesDataGridView.Item(3, intRow).Value = txtEmail.Text
            FamiliesDataGridView.Item(4, intRow).Value = txtAddress.Text

            picFamPhoto.Image.Save("\\" & strServer & "\SharedDocs\OpenAttend\FPhotos\" & intCurrentFamily & ".png")

            If bolPhotoTaken = True Then
                FamiliesDataGridView.Item(6, intRow).Value = intCurrentFamily & ".png"
            Else
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Missing family details (Photo required).", "Unable to create family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

        Else
            bolException = True
            Keyboard.Close()
            MessageBox.Show("Missing family details (Surname required).", "Unable to create family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Me.Validate()
        Me.FamiliesBindingSource.EndEdit()
        Me.FamiliesTableAdapter.Update(Me.OpenAttendDataSet.Families)

        If MessageBox.Show("Do you wish to print a new badge for this family?", "Print family badge?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            strExpireYear = Date.Today.AddYears(intExpireTime).Year
            strBarcode = Format(intCurrentFamily, "00000")
            strBarcode += Mid(strExpireYear, strExpireYear.Length - 1, 2)

            myDymoAddin.Open(strBadgePath & "Family.label")
            myLabel.SetField("ORGANISATION", strOrganisation)
            myLabel.SetField("FAMILY", txtSurname.Text)
            myLabel.SetField("BARCODE", strBarcode) 'Family Num (5), Year of expiration(2) (7 chars max) 
            myDymoAddin.StartPrintJob()
            myDymoAddin.Print(1, False)
            myDymoAddin.EndPrintJob()

            MessageBox.Show("Please collect the badge.", "Family badge printed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub LoadFamilyDetails()

        FamiliesBindingSource.MoveFirst()
        For i = 0 To FamiliesBindingSource.Count - 1
            If FamiliesDataGridView.CurrentRow.Cells(0).Value = intCurrentFamily Then
                Exit For
            ElseIf i = FamiliesBindingSource.Count - 1 Then
                MessageBox.Show("Error: Family not found in database", "Unknown family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                GoToForm(Me, AdminFamilyChoice)
            End If
            FamiliesBindingSource.MoveNext()
        Next

        txtSurname.Text = FamiliesDataGridView.CurrentRow.Cells(1).Value
        txtPhone.Text = FamiliesDataGridView.CurrentRow.Cells(2).Value
        txtEmail.Text = FamiliesDataGridView.CurrentRow.Cells(3).Value
        txtAddress.Text = FamiliesDataGridView.CurrentRow.Cells(4).Value
        picFamPhoto.ImageLocation() = "\\" & strServer & "\SharedDocs\OpenAttend\FPhotos\" & intCurrentFamily & ".png"

    End Sub
    Private Sub btnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotes.Click
        GoToForm(Me, FamilyNotes)
    End Sub

    Private Sub picFamPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFamPhoto.Click
        Keyboard.Close()
        TakePhoto.Show()
        TakePhoto.Focus()
        Me.Enabled() = False
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

        If bolNewFamily = True Then
            LogsDataGridView.Item(1, intRow).Value = "FamCreate"
            LogsDataGridView.Item(6, intRow).Value = "Family " & txtSurname.Text & " created."
        Else
            LogsDataGridView.Item(1, intRow).Value = "FamEdit"
            LogsDataGridView.Item(6, intRow).Value = "Family " & txtSurname.Text & " edited."
        End If

        LogsDataGridView.Item(2, intRow).Value = intCurrentFamily
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()


        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class