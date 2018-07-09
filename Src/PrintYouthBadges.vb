Public Class PrintYouthBadges
    Public myDymoAddin = New Dymo.DymoAddIn
    Public myLabel = New Dymo.DymoLabels
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intPeopleInFam As Integer
    Dim strPersonDetails(99999, 5) As String
    Dim bolTicked(99999) As Boolean
    Dim strEventCode As String
    Private Sub PrintYouthBadges_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)

        Dim datEventStartTime As Date
        Dim datEventEndTime As Date

        intCurrentForm = 8
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow2.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow3.ImageLocation = strPicturePath & "RowTick.bmp"
        picRow4.ImageLocation = strPicturePath & "RowTick.bmp"

        If intCurrentFamily <> 0 Then 'Security check - must be an actual family
            EventsBindingSource.MoveFirst()
            For i = 0 To EventsBindingSource.Count - 1 'Check for an event on this day
                If EventsDataGridView.CurrentRow.Cells(2).Value = Date.Today.Date Then

                    datEventStartTime = EventsDataGridView.CurrentRow.Cells(3).Value
                    datEventEndTime = EventsDataGridView.CurrentRow.Cells(4).Value

                    If GetTime(1) >= datEventStartTime.TimeOfDay And GetTime(1) <= datEventEndTime.TimeOfDay Then 'If the event is still going
                        strEventCode = EventsDataGridView.CurrentRow.Cells(6).Value
                        InitPages()
                        Exit Sub
                    End If
                End If
                EventsBindingSource.MoveNext()
            Next
            GoToForm(Me, SignIn) 'If there are no events, skip this form entirely
        Else
            MessageBox.Show("Error: Unknown family", "Unable to show youth", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub PrintBadges()
        Dim strBarcode As String
        Dim strName As String
        Dim intID As Integer

        For i = 1 To intPeopleInFam
            intID = 0
            If bolTicked(i) = True Then
                intID = strPersonDetails(i, 1)
                strBarcode = Format(intID, "00000")
                strBarcode = strBarcode & strEventCode

                strName = strPersonDetails(i, 2) & " " & strPersonDetails(i, 3)

                myDymoAddin.Open(strBadgePath & "Youth.label")
                myLabel.SetField("NAME", "Name: " & strName)
                myLabel.SetField("GROUP", "Group: " & strPersonDetails(i, 5))
                myLabel.SetField("MEDICAL", "Medical Details: " & strPersonDetails(i, 4))
                myLabel.SetField("BARCODE", strBarcode) 'Person Num (5), Event Code (2) (7 chars max)
                myDymoAddin.StartPrintJob()
                myDymoAddin.Print(1, False)
                myDymoAddin.EndPrintJob()
            End If
        Next
    End Sub
    Private Sub InitPages()
        'A sub to initialize the pages and family members
        Dim intAge As Integer
        intPeopleInFam = 0
        intCurrentPage = 1

        ClearRows()

        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If intCurrentFamily = PeopleDataGridView.CurrentRow.Cells(8).Value Then
                If PeopleDataGridView.CurrentRow.Cells(9).Value = False Then
                    'If the person is not a guardian
                    If PeopleDataGridView.CurrentRow.Cells(4).Value >= Date.Today.AddYears(-intMaxAge) Then
                        'If the person is under the maximum age
                        If PeopleDataGridView.CurrentRow.Cells(4).Value <= Date.Today.AddYears(-intMinAge) Then
                            'If the person is over the minimum age
                            intPeopleInFam += 1
                            strPersonDetails(intPeopleInFam, 1) = Str(PeopleDataGridView.CurrentRow.Cells(0).Value)
                            strPersonDetails(intPeopleInFam, 2) = PeopleDataGridView.CurrentRow.Cells(1).Value
                            strPersonDetails(intPeopleInFam, 3) = PeopleDataGridView.CurrentRow.Cells(2).Value
                            strPersonDetails(intPeopleInFam, 4) = PeopleDataGridView.CurrentRow.Cells(11).Value
                            If strPersonDetails(intPeopleInFam, 4) = "N/A" Then
                                strPersonDetails(intPeopleInFam, 4) = "No"
                            Else
                                strPersonDetails(intPeopleInFam, 4) = "Yes"
                            End If
                            bolTicked(intPeopleInFam) = False

                            intAge = Math.Floor(DateDiff(DateInterval.Day, PeopleDataGridView.CurrentRow.Cells(4).Value, Date.Today) / 365)

                            Select Case intAge
                                'Hard coded teams due to time constraints
                                Case 2 To 15
                                    strPersonDetails(intPeopleInFam, 5) = "Youth 2-15"
                            End Select
                        End If
                    End If
                End If

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
        Else
            For i = 1 To 99999
                strPersonDetails(i, 1) = Nothing
                strPersonDetails(i, 2) = Nothing
                strPersonDetails(i, 3) = Nothing
                strPersonDetails(i, 4) = Nothing
                strPersonDetails(i, 5) = Nothing
                bolTicked(i) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblPerson1.Text = "N/A"
        lblPerson2.Text = "N/A"
        lblPerson3.Text = "N/A"
        lblPerson4.Text = "N/A"

        picTick1.ImageLocation = Nothing
        picTick2.ImageLocation = Nothing
        picTick3.ImageLocation = Nothing
        picTick4.ImageLocation = Nothing

    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to tick a member to be printed
        Dim intPerson As Integer
        intPerson = ((intCurrentPage - 1) * 4) + intRow

        If bolTicked(intPerson) Then
            bolTicked(intPerson) = False
        Else
            bolTicked(intPerson) = True
        End If

        UpdateMembers()
    End Sub
    Private Sub UpdateMembers()
        'Update the pictures and names of family members
        Dim intPeopleLeft As Integer
        Dim intStartPerson As Integer

        ClearRows()

        If intPeopleInFam > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)
                lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)

                UpdateTicks(intStartPerson, 4)

            ElseIf (intPeopleInFam Mod 4) > 0 Then
                'When on a page that is not full
                intPeopleLeft = intPeopleInFam Mod 4
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)

                Select Case intPeopleLeft
                    Case 4
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                        lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)
                    Case 3
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)
                        lblPerson4.Text = "N/A"
                    Case 2
                        lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)
                        lblPerson3.Text = "N/A"
                        lblPerson4.Text = "N/A"
                    Case Else
                        lblPerson2.Text = "N/A"
                        lblPerson3.Text = "N/A"
                        lblPerson4.Text = "N/A"
                End Select

                UpdateTicks(intStartPerson, intPeopleLeft)

            Else 'Four people in the family
                intStartPerson = ((intCurrentPage - 1) * 4) + 1

                lblPerson1.Text = strPersonDetails(intStartPerson, 2) & " " & strPersonDetails(intStartPerson, 3)

                lblPerson2.Text = strPersonDetails(intStartPerson + 1, 2) & " " & strPersonDetails(intStartPerson + 1, 3)

                lblPerson3.Text = strPersonDetails(intStartPerson + 2, 2) & " " & strPersonDetails(intStartPerson + 2, 3)

                lblPerson4.Text = strPersonDetails(intStartPerson + 3, 2) & " " & strPersonDetails(intStartPerson + 3, 3)

                UpdateTicks(intStartPerson, 4)
            End If
        End If


    End Sub
    Private Sub UpdateTicks(ByVal intStart As Integer, ByVal intPagePeople As Integer)
        'A sub to update whether a row is ticked or crossed
        If bolTicked(intStart) Then
            picTick1.ImageLocation = strPicturePath & "Tick.bmp"
        Else
            picTick1.ImageLocation = strPicturePath & "Cross.bmp"
        End If

        Select Case intPagePeople
            Case 4
                If bolTicked(intStart + 3) Then
                    picTick4.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick4.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolTicked(intStart + 2) Then
                    picTick3.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick3.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolTicked(intStart + 1) Then
                    picTick2.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick2.ImageLocation = strPicturePath & "Cross.bmp"
                End If
            Case 3
                If bolTicked(intStart + 2) Then
                    picTick3.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick3.ImageLocation = strPicturePath & "Cross.bmp"
                End If

                If bolTicked(intStart + 1) Then
                    picTick2.ImageLocation = strPicturePath & "Tick.bmp"
                Else
                    picTick2.ImageLocation = strPicturePath & "Cross.bmp"
                End If
            Case 2
                If bolTicked(intStart + 1) Then
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

        UpdateMembers()

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
    Private Sub lblPerson1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerson1.Click
        If lblPerson1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub picTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick1.Click
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

    Private Sub picTick2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick2.Click
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

    Private Sub picTick3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick3.Click
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

    Private Sub picTick4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTick4.Click
        If lblPerson4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        For i = 1 To intPeopleInFam
            If bolTicked(i) = True Then
                MessageBox.Show("Sending badges to printer.", "Starting printer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Enabled = False

                PrintBadges()
                MessageBox.Show("Please collect badges when printing stops.", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Enabled = True

                Exit For
            End If
        Next

        If UCase(strCurrentLevel) = "ADMIN" Or bolAdminOverride = True Then
            GoToForm(Me, AdminSignIn)
        Else
            GoToForm(Me, SignIn)
        End If
    End Sub
End Class