Public Class GroupSelect
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intNumTeams As Integer
    Dim intNumSelected As Integer


    Private Sub GroupSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.OpenAttendDataSet.Teams)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)

        Dim datEventStartTime As Date
        Dim datEventEndTime As Date

        intCurrentForm = 9
        InitForm(Me, picLogo)

        intNumSelected = 0
        picRow1.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow2.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow3.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow4.ImageLocation = strPicturePath & "RowTick.bmp"

        If Screen.PrimaryScreen.Bounds.Height = 600 Then
            'If this is being run on a 1024x600 laptop, rather than 1024x768, resize the form
            btnContinue.Top = 476
            btnContinue.Left = 772
            btnHelp.Top = 356
            btnHelp.Left = 772
            lblPageNum.Top = 206
            lblPageNum.Left = 658
            picButDown.Top = 516
            picButDown.Left = 658
            picButUp.Top = 152
            picButUp.Left = 658
            lblGroup1.Top = 34
            lblGroup1.Left = 89
            lblGroup2.Top = 134
            lblGroup2.Left = 89
            lblGroup3.Top = 231
            lblGroup3.Left = 89
            lblGroup4.Top = 329
            lblGroup4.Left = 89
            grpMembers.Top = 164
            grpMembers.Left = 11
            picTick1.Top = 46
            picTick1.Left = 33
            picTick2.Top = 144
            picTick2.Left = 33
            picTick3.Top = 243
            picTick3.Left = 33
            picTick4.Top = 341
            picTick4.Left = 33
            picRow1.Top = 18
            picRow1.Left = 6
            picRow2.Top = 116
            picRow2.Left = 6
            picRow3.Top = 214
            picRow3.Left = 6
            picRow4.Top = 312
            picRow4.Left = 6
        End If

        EventsBindingSource.MoveFirst()
        For i = 0 To EventsBindingSource.Count - 1 'Check for an event on this day
            If EventsDataGridView.CurrentRow.Cells(2).Value = Date.Today.Date Then

                datEventStartTime = EventsDataGridView.CurrentRow.Cells(3).Value
                datEventEndTime = EventsDataGridView.CurrentRow.Cells(4).Value

                If GetTime(1) >= datEventStartTime.TimeOfDay And GetTime(1) <= datEventEndTime.TimeOfDay Then 'If the event is still going
                    InitPages()
                    Exit Sub
                End If
            End If
            EventsBindingSource.MoveNext()
        Next
        MessageBox.Show("Error: No events today, logging out", "Unable to select groups", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'If there are no events, logout
        strCurrentLevel = Nothing
        strCurrentMode = Nothing
        strCurrentUser = Nothing
        strNonAdminUser = Nothing
        bolAdminOverride = False
        GoToForm(Me, Login)
    End Sub

    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intNumTeams = 0
        intCurrentPage = 1

        ClearRows()

        TeamsBindingSource.MoveFirst()
        For i = 0 To TeamsBindingSource.Count - 1
            If intNumTeams < 9999 Then
                intNumTeams += 1
                strTeamDetails(intNumTeams, 1) = Str(TeamsDataGridView.CurrentRow.Cells(0).Value)
                strTeamDetails(intNumTeams, 2) = TeamsDataGridView.CurrentRow.Cells(1).Value
                strTeamDetails(intNumTeams, 3) = TeamsDataGridView.CurrentRow.Cells(3).Value
                strTeamDetails(intNumTeams, 4) = TeamsDataGridView.CurrentRow.Cells(4).Value

                TeamsBindingSource.MoveNext()
            Else
                Exit For 'No teams allowed beyond 9999
            End If
        Next

        If intNumTeams > 0 Then
            intMaxPages = Math.Ceiling(intNumTeams / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateTeams()
        Else
            intNumSelected = 0
            For i = 1 To 9999
                strTeamDetails(i, 1) = Nothing
                strTeamDetails(i, 2) = Nothing
                strTeamDetails(i, 3) = Nothing
                strTeamDetails(i, 4) = Nothing
                bolSelectedTeams(i) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblGroup1.Text = "N/A"
        lblGroup2.Text = "N/A"
        lblGroup3.Text = "N/A"
        lblGroup4.Text = "N/A"

        picTick1.ImageLocation = Nothing
        picTick2.ImageLocation = Nothing
        picTick3.ImageLocation = Nothing
        picTick4.ImageLocation = Nothing

    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to tick a member to be printed
        Dim intPerson As Integer
        intPerson = ((intCurrentPage - 1) * 4) + intRow

        If bolSelectedTeams(intPerson) Then
            bolSelectedTeams(intPerson) = False
            intNumSelected -= 1
        Else
            bolSelectedTeams(intPerson) = True
            intNumSelected += 1
        End If

        UpdateTeams()
    End Sub
    Private Sub UpdateTeams()
        'Update the pictures and names of family members
        Dim intPeopleLeft As Integer
        Dim intStartPerson As Integer

        ClearRows()

        If intNumTeams > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblGroup1.Text = strTeamDetails(intStartPerson, 2) & " " & strTeamDetails(intStartPerson, 3) & " - " & strTeamDetails(intStartPerson, 4)
                lblGroup2.Text = strTeamDetails(intStartPerson + 1, 2) & " " & strTeamDetails(intStartPerson + 1, 3) & " - " & strTeamDetails(intStartPerson + 1, 4)
                lblGroup3.Text = strTeamDetails(intStartPerson + 2, 2) & " " & strTeamDetails(intStartPerson + 2, 3) & " - " & strTeamDetails(intStartPerson + 2, 4)
                lblGroup4.Text = strTeamDetails(intStartPerson + 3, 2) & " " & strTeamDetails(intStartPerson + 3, 3) & " - " & strTeamDetails(intStartPerson + 3, 4)

                UpdateTicks(intStartPerson, 4)

            ElseIf (intNumTeams Mod 4) > 0 Then
                'When on a page that is not full
                intPeopleLeft = intNumTeams Mod 4
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblGroup1.Text = strTeamDetails(intStartPerson, 2) & " " & strTeamDetails(intStartPerson, 3) & " - " & strTeamDetails(intStartPerson, 4)

                Select Case intPeopleLeft
                    Case 4
                        lblGroup2.Text = strTeamDetails(intStartPerson + 1, 2) & " " & strTeamDetails(intStartPerson + 1, 3) & " - " & strTeamDetails(intStartPerson + 1, 4)
                        lblGroup3.Text = strTeamDetails(intStartPerson + 2, 2) & " " & strTeamDetails(intStartPerson + 2, 3) & " - " & strTeamDetails(intStartPerson + 2, 4)
                        lblGroup4.Text = strTeamDetails(intStartPerson + 3, 2) & " " & strTeamDetails(intStartPerson + 3, 3) & " - " & strTeamDetails(intStartPerson + 3, 4)
                    Case 3
                        lblGroup2.Text = strTeamDetails(intStartPerson + 1, 2) & " " & strTeamDetails(intStartPerson + 1, 3) & " - " & strTeamDetails(intStartPerson + 1, 4)
                        lblGroup3.Text = strTeamDetails(intStartPerson + 2, 2) & " " & strTeamDetails(intStartPerson + 2, 3) & " - " & strTeamDetails(intStartPerson + 2, 4)
                        lblGroup4.Text = "N/A"
                    Case 2
                        lblGroup2.Text = strTeamDetails(intStartPerson + 1, 2) & " " & strTeamDetails(intStartPerson + 1, 3) & " - " & strTeamDetails(intStartPerson + 1, 4)
                        lblGroup3.Text = "N/A"
                        lblGroup4.Text = "N/A"
                    Case Else
                        lblGroup2.Text = "N/A"
                        lblGroup3.Text = "N/A"
                        lblGroup4.Text = "N/A"
                End Select

                UpdateTicks(intStartPerson, intPeopleLeft)

            Else 'Four people in the family
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblGroup1.Text = strTeamDetails(intStartPerson, 2) & " " & strTeamDetails(intStartPerson, 3) & " - " & strTeamDetails(intStartPerson, 4)

                lblGroup2.Text = strTeamDetails(intStartPerson + 1, 2) & " " & strTeamDetails(intStartPerson + 1, 3) & " - " & strTeamDetails(intStartPerson + 1, 4)

                lblGroup3.Text = strTeamDetails(intStartPerson + 2, 2) & " " & strTeamDetails(intStartPerson + 2, 3) & " - " & strTeamDetails(intStartPerson + 2, 4)

                lblGroup4.Text = strTeamDetails(intStartPerson + 3, 2) & " " & strTeamDetails(intStartPerson + 3, 3) & " - " & strTeamDetails(intStartPerson + 3, 4)

                UpdateTicks(intStartPerson, 4)
            End If
        End If


    End Sub
    Private Sub UpdateTicks(ByVal intStart As Integer, ByVal intPagePeople As Integer)
        'A sub to update whether a row is ticked or crossed
        If bolSelectedTeams(intStart) Then
            picTick1.ImageLocation = strPicturePath & "Tick.bmp"
        Else
            picTick1.ImageLocation = strPicturePath & "Cross.bmp"
        End If

        Select Case intPagePeople
            Case 4
                If bolSelectedTeams(intStart + 3) Then
                    picTick4.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick4.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolSelectedTeams(intStart + 2) Then
                    picTick3.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick3.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolSelectedTeams(intStart + 1) Then
                    picTick2.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick2.ImageLocation = strPicturePath & "Cross.bmp"
                End If
            Case 3
                If bolSelectedTeams(intStart + 2) Then
                    picTick3.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick3.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolSelectedTeams(intStart + 1) Then
                    picTick2.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick2.ImageLocation = strPicturePath & "Cross.bmp"
                End If
            Case 2
                If bolSelectedTeams(intStart + 1) Then
                    picTick2.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick2.ImageLocation = strPicturePath & "Cross.bmp"
                End If
        End Select
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

        UpdateTeams()

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
    Private Sub lblGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGroup1.Click
        If lblGroup1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick1.Click
        If lblGroup1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblGroup1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGroup2.Click
        If lblGroup2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picTick2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick2.Click
        If lblGroup2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblGroup2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub lblGroup3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGroup3.Click
        If lblGroup3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picTick3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick3.Click
        If lblGroup3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblGroup3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub lblGroup4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGroup4.Click
        If lblGroup4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblGroup4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picTick4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick4.Click
        If lblGroup4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If intNumSelected > 0 Then
            GoToForm(Me, GroupRegister)
            Exit Sub
        Else
            MessageBox.Show("Error: No groups selected", "Please select a group", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
End Class