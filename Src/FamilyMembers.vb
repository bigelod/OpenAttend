Public Class FamilyMembers
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intPeopleInFam As Integer
    Dim intSelectedID As Integer
    Dim strPersonDetails(99999, 4) As String

    Private Sub FamilyMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        intCurrentForm = 6
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "Row.bmp"
        picRow2.ImageLocation = strPicturePath & "Row.bmp"
        picRow3.ImageLocation = strPicturePath & "Row.bmp"
        picRow4.ImageLocation = strPicturePath & "Row.bmp"

        picPerson1.ImageLocation = Nothing
        picPerson2.ImageLocation = Nothing
        picPerson3.ImageLocation = Nothing
        picPerson4.ImageLocation = Nothing

        If intCurrentFamily <> 0 Then 'Security check - must be an actual family
            InitPages()
        Else
            MessageBox.Show("Error: Unknown family", "Unable to show members", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        
    End Sub
    Private Sub btnAdMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdMember.Click
        intCurrentPerson = 0
        GoToForm(Me, AddMember)
    End Sub

    Private Sub btnRmMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmMember.Click
        'A sub to remove the selected member from the family
        If intPeopleInFam > 0 Then

            If MessageBox.Show("Are you sure you wish to remove this member?", "Confirmation of removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                PeopleBindingSource.MoveFirst()
                For i = 0 To PeopleBindingSource.Count - 1
                    If intCurrentFamily = PeopleDataGridView.CurrentRow.Cells(8).Value Then
                        If intSelectedID = PeopleDataGridView.CurrentRow.Cells(0).Value Then
                            'Setting the family to zero removes them from the list, but an admin can return the person to the family
                            PeopleDataGridView.CurrentRow.Cells(8).Value = 0
                            SaveLog()
                            Exit For
                        End If
                    End If

                    PeopleBindingSource.MoveNext()
                Next

                Me.Validate()
                Me.PeopleBindingSource.EndEdit()
                Me.PeopleTableAdapter.Update(Me.OpenAttendDataSet.People)

                InitPages()
                lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
            End If
        Else
            MessageBox.Show("Error: Family has no members", "Unable to remove members", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        
    End Sub

    Private Sub btnEdMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdMember.Click
        'A sub to view the edit form for the selected member
        If intPeopleInFam < 1 Then
            MessageBox.Show("Error: Family has no members", "Unable to edit member", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            intCurrentPerson = intSelectedID
            GoToForm(Me, AddMember)
        End If
    End Sub

    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intPeopleInFam = 0
        intCurrentPage = 1

        ClearRows()

        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If intCurrentFamily = PeopleDataGridView.CurrentRow.Cells(8).Value Then
                intPeopleInFam += 1
                strPersonDetails(intPeopleInFam, 1) = Str(PeopleDataGridView.CurrentRow.Cells(0).Value)
                strPersonDetails(intPeopleInFam, 2) = PeopleDataGridView.CurrentRow.Cells(1).Value
                strPersonDetails(intPeopleInFam, 3) = PeopleDataGridView.CurrentRow.Cells(2).Value
                strPersonDetails(intPeopleInFam, 4) = PeopleDataGridView.CurrentRow.Cells(7).Value
            End If

            PeopleBindingSource.MoveNext()
        Next

        If intPeopleInFam > 0 Then
            intMaxPages = Math.Ceiling(intPeopleInFam / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateMembers()
            SelectRow(1)
        Else
            For i = 1 To 99999
                strPersonDetails(i, 1) = Nothing
                strPersonDetails(i, 2) = Nothing
                strPersonDetails(i, 3) = Nothing
                strPersonDetails(i, 4) = Nothing
            Next
        End If
        
    End Sub

    Private Sub ClearRows()
        lblPerson1.ForeColor = Color.White
        lblPerson2.ForeColor = Color.White
        lblPerson3.ForeColor = Color.White
        lblPerson4.ForeColor = Color.White

        lblPerson1.Text = "N/A"
        lblPerson2.Text = "N/A"
        lblPerson3.Text = "N/A"
        lblPerson4.Text = "N/A"

        picPerson1.ImageLocation = Nothing
        picPerson2.ImageLocation = Nothing
        picPerson3.ImageLocation = Nothing
        picPerson4.ImageLocation = Nothing
    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to select the current person for editing
        Dim intPerson As Integer
        intPerson = ((intCurrentPage - 1) * 4) + intRow

        lblPerson1.ForeColor = Color.White
        lblPerson2.ForeColor = Color.White
        lblPerson3.ForeColor = Color.White
        lblPerson4.ForeColor = Color.White

        intSelectedID = strPersonDetails(intPerson, 1)

        Select Case intRow
            Case 1
                lblPerson1.ForeColor = Color.Yellow
            Case 2
                lblPerson2.ForeColor = Color.Yellow
            Case 3
                lblPerson3.ForeColor = Color.Yellow
            Case 4
                lblPerson4.ForeColor = Color.Yellow
        End Select

    End Sub
    Private Sub UpdateMembers()
        'Update the pictures and names of family members
        Dim intPeopleLeft As Integer
        Dim intStartPerson As Integer
        Dim strPicPath As String = "\\" & strServer & "\SharedDocs\OpenAttend\PPhotos\"

        ClearRows()

        If intPeopleInFam > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)
                picPerson1.ImageLocation = strPicPath & strPersonDetails(intStartPerson, 4)

                lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                picPerson2.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 1, 4)

                lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                picPerson3.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 2, 4)

                lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)
                picPerson4.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 3, 4)

            ElseIf (intPeopleInFam Mod 4) > 0 Then
                intPeopleLeft = intPeopleInFam Mod 4
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)
                picPerson1.ImageLocation = strPicPath & strPersonDetails(intStartPerson, 4)

                Select Case intPeopleLeft
                    Case 4
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        picPerson2.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 1, 4)

                        lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                        picPerson3.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 2, 4)

                        lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)
                        picPerson4.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 3, 4)
                    Case 3
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        picPerson2.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 1, 4)

                        lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                        picPerson3.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 2, 4)

                        lblPerson4.Text = "N/A"
                    Case 2
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        picPerson2.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 1, 4)

                        lblPerson3.Text = "N/A"
                        lblPerson4.Text = "N/A"
                    Case Else
                        lblPerson2.Text = "N/A"
                        lblPerson3.Text = "N/A"
                        lblPerson4.Text = "N/A"
                End Select
            Else 'Four people in the family
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)
                picPerson1.ImageLocation = strPicPath & strPersonDetails(intStartPerson, 4)

                lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                picPerson2.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 1, 4)

                lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                picPerson3.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 2, 4)

                lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)
                picPerson4.ImageLocation = strPicPath & strPersonDetails(intStartPerson + 3, 4)
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

        UpdateMembers()

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Select Case UCase(strCurrentLevel)
            Case "ADMIN"
                GoToForm(Me, AdminEditFamily)
            Case Else
                If bolAdminOverride = True Then
                    GoToForm(Me, AdminEditFamily)
                Else
                    GoToForm(Me, SignIn)
                End If
        End Select
    End Sub

    Private Sub lblPerson1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerson1.Click
        If lblPerson1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picPerson1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson1.Click
        If lblPerson1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblPerson1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblPerson2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerson2.Click
        If lblPerson2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picPerson2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson2.Click
        If lblPerson2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblPerson2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub lblPerson3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerson3.Click
        If lblPerson3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picPerson3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson3.Click
        If lblPerson3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblPerson3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub lblPerson4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerson4.Click
        If lblPerson4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblPerson4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picPerson4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson4.Click
        If lblPerson4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        GoToForm(Me, PrintYouthBadges)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "MemDelete"
        LogsDataGridView.Item(2, intRow).Value = intSelectedID
        LogsDataGridView.Item(3, intRow).Value = intCurrentFamily
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = strPersonDetails(intSelectedID, 2) & " " & strPersonDetails(intSelectedID, 3) & " was deleted from their family."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class