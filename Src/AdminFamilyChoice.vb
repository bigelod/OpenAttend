Public Class AdminFamilyChoice
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intNumFamilies As Integer
    Dim intSelectedID As Integer
    Dim strFamilyDetails(99999, 4) As String
    Private Sub AdminFamilyChoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Families' table. You can move, or remove it, as needed.
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)

        intCurrentForm = 12
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "Row.bmp"
        picRow2.ImageLocation = strPicturePath & "Row.bmp"
        picRow3.ImageLocation = strPicturePath & "Row.bmp"
        picRow4.ImageLocation = strPicturePath & "Row.bmp"

        picFamily1.ImageLocation = Nothing
        picFamily2.ImageLocation = Nothing
        picFamily3.ImageLocation = Nothing
        picFamily4.ImageLocation = Nothing

        InitPages()
    End Sub
    Private Sub btnSearchPref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPref.Click
        'Go to the search form to search by family name
        GoToForm(Me, FamilySearchPref)
    End Sub

    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        'Go to the scan form to edit the family by barcode
        GoToForm(Me, FamilyLogin)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Go back to the admin main page
        GoToForm(Me, AdminSignIn)
    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

    End Sub

    Private Sub btnAdFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdFamily.Click
        intCurrentFamily = 0
        GoToForm(Me, AdminEditFamily)
    End Sub

    Private Sub btnRmFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmFamily.Click
        'A sub to remove the family and all members from the database
        If intNumFamilies > 0 Then

            If MessageBox.Show("Are you sure you wish to remove this family?", "Confirmation of removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                FamiliesBindingSource.MoveFirst()
                For i = 0 To FamiliesBindingSource.Count - 1
                    If intSelectedID = FamiliesDataGridView.CurrentRow.Cells(0).Value Then
                        'Set the family details to null values, deletion will affect how families are numbered, and hence will cause errors
                        FamiliesDataGridView.CurrentRow.Cells(1).Value = "DELETED"
                        FamiliesDataGridView.CurrentRow.Cells(2).Value = "00000000000"
                        FamiliesDataGridView.CurrentRow.Cells(3).Value = "DELETED"
                        FamiliesDataGridView.CurrentRow.Cells(4).Value = "DELETED"
                        FamiliesDataGridView.CurrentRow.Cells(6).Value = "0.png"
                        FamiliesDataGridView.CurrentRow.Cells(7).Value = "Family deleted on " & Date.Today.ToString
                        SaveLog()
                        Exit For
                    End If

                    FamiliesBindingSource.MoveNext()
                Next

            Me.Validate()
            Me.FamiliesBindingSource.EndEdit()
            Me.FamiliesTableAdapter.Update(Me.OpenAttendDataSet.Families)

            InitPages()
            lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
            End If
        Else
            MessageBox.Show("Error: No families to remove", "Unable to remove family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub btnEdFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdFamily.Click
        'A sub to view the edit form for the selected member
        If intNumFamilies < 1 Then
            MessageBox.Show("Error: No families available to edit", "Unable to edit family", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            intCurrentFamily = intSelectedID
            GoToForm(Me, AdminEditFamily)
        End If
    End Sub
    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intNumFamilies = 0
        intCurrentPage = 1

        ClearRows()

        FamiliesBindingSource.MoveFirst()
        For i = 1 To FamiliesBindingSource.Count
            If FamiliesDataGridView.CurrentRow.Cells(0).Value > 0 Then
                If FamiliesDataGridView.CurrentRow.Cells(1).Value <> "DELETED" Then
                    intNumFamilies += 1
                    strFamilyDetails(intNumFamilies, 1) = Str(FamiliesDataGridView.CurrentRow.Cells(0).Value)
                    strFamilyDetails(intNumFamilies, 2) = FamiliesDataGridView.CurrentRow.Cells(1).Value
                    strFamilyDetails(intNumFamilies, 3) = FamiliesDataGridView.CurrentRow.Cells(6).Value
                End If
            End If
            FamiliesBindingSource.MoveNext()
        Next

        If intNumFamilies > 0 Then
            intMaxPages = Math.Ceiling(intNumFamilies / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateFamilies()
            SelectRow(1)
        Else
            For i = 1 To 99999
                strFamilyDetails(i, 1) = Nothing
                strFamilyDetails(i, 2) = Nothing
                strFamilyDetails(i, 3) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblFamily1.ForeColor = Color.White
        lblFamily2.ForeColor = Color.White
        lblFamily3.ForeColor = Color.White
        lblFamily4.ForeColor = Color.White

        lblFamily1.Text = "N/A"
        lblFamily2.Text = "N/A"
        lblFamily3.Text = "N/A"
        lblFamily4.Text = "N/A"

        picFamily1.ImageLocation = Nothing
        picFamily2.ImageLocation = Nothing
        picFamily3.ImageLocation = Nothing
        picFamily4.ImageLocation = Nothing
    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to select the current Family for editing
        Dim intFamily As Integer
        intFamily = ((intCurrentPage - 1) * 4) + intRow

        lblFamily1.ForeColor = Color.White
        lblFamily2.ForeColor = Color.White
        lblFamily3.ForeColor = Color.White
        lblFamily4.ForeColor = Color.White

        intSelectedID = strFamilyDetails(intFamily, 1)

        Select Case intRow
            Case 1
                lblFamily1.ForeColor = Color.Yellow
            Case 2
                lblFamily2.ForeColor = Color.Yellow
            Case 3
                lblFamily3.ForeColor = Color.Yellow
            Case 4
                lblFamily4.ForeColor = Color.Yellow
        End Select

    End Sub
    Private Sub UpdateFamilies()
        'Update the pictures and names of family members
        Dim intFamiliesLeft As Integer
        Dim intStartFamily As Integer
        Dim strPicPath As String = "\\" & strServer & "\SharedDocs\OpenAttend\FPhotos\"

        ClearRows()

        If intNumFamilies > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartFamily = ((intCurrentPage - 1) * 4) + 1

                lblFamily1.Text = strFamilyDetails(intStartFamily, 2)
                picFamily1.ImageLocation = strPicPath & strFamilyDetails(intStartFamily, 3)

                lblFamily2.Text = strFamilyDetails(intStartFamily + 1, 2)
                picFamily2.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 1, 3)

                lblFamily3.Text = strFamilyDetails(intStartFamily + 2, 2)
                picFamily3.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 2, 3)

                lblFamily4.Text = strFamilyDetails(intStartFamily + 3, 2)
                picFamily4.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 3, 3)

            ElseIf (intNumFamilies Mod 4) > 0 Then
                intFamiliesLeft = intNumFamilies Mod 4
                intStartFamily = ((intCurrentPage - 1) * 4) + 1

                lblFamily1.Text = strFamilyDetails(intStartFamily, 2)
                picFamily1.ImageLocation = strPicPath & strFamilyDetails(intStartFamily, 3)

                Select Case intFamiliesLeft
                    Case 4
                        lblFamily2.Text = strFamilyDetails(intStartFamily + 1, 2)
                        picFamily2.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 1, 3)

                        lblFamily3.Text = strFamilyDetails(intStartFamily + 2, 2)
                        picFamily3.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 2, 3)

                        lblFamily4.Text = strFamilyDetails(intStartFamily + 3, 2)
                        picFamily4.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 3, 3)
                    Case 3
                        lblFamily2.Text = strFamilyDetails(intStartFamily + 1, 2)
                        picFamily2.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 1, 3)

                        lblFamily3.Text = strFamilyDetails(intStartFamily + 2, 2)
                        picFamily3.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 2, 3)

                        lblFamily4.Text = "N/A"
                    Case 2
                        lblFamily2.Text = strFamilyDetails(intStartFamily + 1, 2)
                        picFamily2.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 1, 3)
                        lblFamily3.Text = "N/A"
                        lblFamily4.Text = "N/A"
                    Case Else
                        lblFamily2.Text = "N/A"
                        lblFamily3.Text = "N/A"
                        lblFamily4.Text = "N/A"
                End Select
            Else 'Four people in the family
                intStartFamily = ((intCurrentPage - 1) * 4) + 1

                lblFamily1.Text = strFamilyDetails(intStartFamily, 2)
                picFamily1.ImageLocation = strPicPath & strFamilyDetails(intStartFamily, 3)

                lblFamily2.Text = strFamilyDetails(intStartFamily + 1, 2)
                picFamily2.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 1, 3)

                lblFamily3.Text = strFamilyDetails(intStartFamily + 2, 2)
                picFamily3.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 2, 3)

                lblFamily4.Text = strFamilyDetails(intStartFamily + 3, 2)
                picFamily4.ImageLocation = strPicPath & strFamilyDetails(intStartFamily + 3, 3)
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

        UpdateFamilies()

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

    Private Sub lblFamily1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFamily1.Click
        If lblFamily1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picFamily1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFamily1.Click
        If lblFamily1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblFamily1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblFamily2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFamily2.Click
        If lblFamily2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picFamily2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFamily2.Click
        If lblFamily2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblFamily2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub lblFamily3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFamily3.Click
        If lblFamily3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picFamily3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFamily3.Click
        If lblFamily3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblFamily3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub lblFamily4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFamily4.Click
        If lblFamily4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblFamily4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picFamily4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFamily4.Click
        If lblFamily4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "FamDelete"
        LogsDataGridView.Item(2, intRow).Value = intSelectedID
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this event
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = "Family " & strFamilyDetails(intSelectedID, 2) & " was deleted."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class