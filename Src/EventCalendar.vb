Public Class EventCalendar
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intNumEvents As Integer
    Dim intSelectedID As Integer
    Dim strEventDetails(99999, 5) As String
    Dim datSelectedDate As Date
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, AdminSignIn)
    End Sub

    Private Sub EventCalendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)

        intCurrentForm = 18
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "Row.bmp"
        picRow2.ImageLocation = strPicturePath & "Row.bmp"
        picRow3.ImageLocation = strPicturePath & "Row.bmp"
        picRow4.ImageLocation = strPicturePath & "Row.bmp"

        datSelectedDate = calMonth.SelectionRange.Start()

        intCurrentEvent = 0

        InitPages()
    End Sub

    Private Sub calMonth_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calMonth.DateChanged
        datSelectedDate = calMonth.SelectionRange.Start()
        InitPages()
    End Sub

    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intNumEvents = 0
        intCurrentPage = 1

        ClearRows()

        EventsBindingSource.MoveFirst()
        For i = 0 To EventsBindingSource.Count - 1
            If UCase(EventsDataGridView.CurrentRow.Cells(1).Value) <> "DELETED" Then
                If DateDiff(DateInterval.Day, EventsDataGridView.CurrentRow.Cells(2).Value, datSelectedDate) = 0 Then
                    'If the event takes place today (0 days between the event and the selected date)
                    intNumEvents += 1
                    strEventDetails(intNumEvents, 1) = Str(EventsDataGridView.CurrentRow.Cells(0).Value)
                    strEventDetails(intNumEvents, 2) = EventsDataGridView.CurrentRow.Cells(1).Value
                    strEventDetails(intNumEvents, 3) = Format(EventsDataGridView.CurrentRow.Cells(3).Value, "HH:mm")
                    strEventDetails(intNumEvents, 4) = Format(EventsDataGridView.CurrentRow.Cells(4).Value, "HH:mm")
                End If
            End If

            EventsBindingSource.MoveNext()
        Next

        If intNumEvents > 0 Then
            intMaxPages = Math.Ceiling(intNumEvents / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateEvents()
            SelectRow(1)
        Else
            For i = 1 To 99999
                strEventDetails(i, 1) = Nothing
                strEventDetails(i, 2) = Nothing
                strEventDetails(i, 3) = Nothing
                strEventDetails(i, 4) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblEvent1.ForeColor = Color.White
        lblEvent2.ForeColor = Color.White
        lblEvent3.ForeColor = Color.White
        lblEvent4.ForeColor = Color.White

        lblEvent1.Text = "N/A"
        lblEvent2.Text = "N/A"
        lblEvent3.Text = "N/A"
        lblEvent4.Text = "N/A"

    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to select the current event for editing
        Dim intEvent As Integer
        intEvent = ((intCurrentPage - 1) * 4) + intRow

        lblEvent1.ForeColor = Color.White
        lblEvent2.ForeColor = Color.White
        lblEvent3.ForeColor = Color.White
        lblEvent4.ForeColor = Color.White

        intSelectedID = strEventDetails(intEvent, 1)

        Select Case intRow
            Case 1
                lblEvent1.ForeColor = Color.Yellow
            Case 2
                lblEvent2.ForeColor = Color.Yellow
            Case 3
                lblEvent3.ForeColor = Color.Yellow
            Case 4
                lblEvent4.ForeColor = Color.Yellow
        End Select

    End Sub
    Private Sub UpdateEvents()
        'Update the events today
        Dim intEventsLeft As Integer
        Dim intStartEvent As Integer

        ClearRows()

        If intNumEvents > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartEvent = ((intCurrentPage - 1) * 4) + 1

                lblEvent1.Text = strEventDetails(intStartEvent, 3) & " - " & strEventDetails(intStartEvent, 4) & vbNewLine & strEventDetails(intStartEvent, 2)
                lblEvent2.Text = strEventDetails(intStartEvent + 1, 3) & " - " & strEventDetails(intStartEvent + 1, 4) & vbNewLine & strEventDetails(intStartEvent + 1, 2)
                lblEvent3.Text = strEventDetails(intStartEvent + 2, 3) & " - " & strEventDetails(intStartEvent + 2, 4) & vbNewLine & strEventDetails(intStartEvent + 2, 2)
                lblEvent4.Text = strEventDetails(intStartEvent + 3, 3) & " - " & strEventDetails(intStartEvent + 3, 4) & vbNewLine & strEventDetails(intStartEvent + 3, 2)

            ElseIf (intNumEvents Mod 4) > 0 Then
                intEventsLeft = intNumEvents Mod 4
                intStartEvent = ((intCurrentPage - 1) * 4) + 1

                lblEvent1.Text = strEventDetails(intStartEvent, 3) & " - " & strEventDetails(intStartEvent, 4) & vbNewLine & strEventDetails(intStartEvent, 2)

                Select Case intEventsLeft
                    Case 4
                        lblEvent2.Text = strEventDetails(intStartEvent + 1, 3) & " - " & strEventDetails(intStartEvent + 1, 4) & vbNewLine & strEventDetails(intStartEvent + 1, 2)
                        lblEvent3.Text = strEventDetails(intStartEvent + 2, 3) & " - " & strEventDetails(intStartEvent + 2, 4) & vbNewLine & strEventDetails(intStartEvent + 2, 2)
                        lblEvent4.Text = strEventDetails(intStartEvent + 3, 3) & " - " & strEventDetails(intStartEvent + 3, 4) & vbNewLine & strEventDetails(intStartEvent + 3, 2)
                    Case 3
                        lblEvent2.Text = strEventDetails(intStartEvent + 1, 3) & " - " & strEventDetails(intStartEvent + 1, 4) & vbNewLine & strEventDetails(intStartEvent + 1, 2)
                        lblEvent3.Text = strEventDetails(intStartEvent + 2, 3) & " - " & strEventDetails(intStartEvent + 2, 4) & vbNewLine & strEventDetails(intStartEvent + 2, 2)
                        lblEvent4.Text = "N/A"
                    Case 2
                        lblEvent2.Text = strEventDetails(intStartEvent + 1, 3) & " - " & strEventDetails(intStartEvent + 1, 4) & vbNewLine & strEventDetails(intStartEvent + 1, 2)
                        lblEvent3.Text = "N/A"
                        lblEvent4.Text = "N/A"
                    Case Else
                        lblEvent2.Text = "N/A"
                        lblEvent3.Text = "N/A"
                        lblEvent4.Text = "N/A"
                End Select
            Else 'Four events today
                intStartEvent = ((intCurrentPage - 1) * 4) + 1

                lblEvent1.Text = strEventDetails(intStartEvent, 3) & " - " & strEventDetails(intStartEvent, 4) & vbNewLine & strEventDetails(intStartEvent, 2)
                lblEvent2.Text = strEventDetails(intStartEvent + 1, 3) & " - " & strEventDetails(intStartEvent + 1, 4) & vbNewLine & strEventDetails(intStartEvent + 1, 2)
                lblEvent3.Text = strEventDetails(intStartEvent + 2, 3) & " - " & strEventDetails(intStartEvent + 2, 4) & vbNewLine & strEventDetails(intStartEvent + 2, 2)
                lblEvent4.Text = strEventDetails(intStartEvent + 3, 3) & " - " & strEventDetails(intStartEvent + 3, 4) & vbNewLine & strEventDetails(intStartEvent + 3, 2)
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

        UpdateEvents()

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

    Private Sub btnAddEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddEvent.Click
        intCurrentEvent = 0
        datEventDate = datSelectedDate
        GoToForm(Me, AddEditEvent)
    End Sub

    Private Sub btnRemoveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveEvent.Click
        'A sub to remove the selected event from the selected day
        If intNumEvents > 0 Then

            If MessageBox.Show("Are you sure you wish to remove this event?", "Confirmation of removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EventsBindingSource.MoveFirst()
                For i = 0 To EventsBindingSource.Count - 1
                    If intSelectedID = EventsDataGridView.CurrentRow.Cells(0).Value Then
                        If DateDiff(DateInterval.Minute, Date.Now, EventsDataGridView.CurrentRow.Cells(3).Value) > 1 Then
                            'The event can only be deleted if it hasn't happened yet
                            EventsDataGridView.CurrentRow.Cells(1).Value = "DELETED"
                            EventsDataGridView.CurrentRow.Cells(2).Value = Date.Parse("01/01/1800") 'Setting the event date to 01/01/1800 effectively deletes it
                            SaveLog()
                            Exit For
                        Else
                            'Otherwise, don't let the user delete the event
                            MessageBox.Show("Error: Event has already past", "Unable to remove event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                    End If

                    EventsBindingSource.MoveNext()
                Next

                Me.Validate()
                Me.EventsBindingSource.EndEdit()
                Me.EventsTableAdapter.Update(Me.OpenAttendDataSet.Events)

                InitPages()
                lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
            End If
        Else
            MessageBox.Show("Error: Day has no events", "Unable to remove events", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnEditEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEvent.Click
        'A sub to view the edit form for the selected member
        If intNumEvents < 1 Then
            MessageBox.Show("Error: Day has no events", "Unable to edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            intCurrentEvent = intSelectedID
            GoToForm(Me, AddEditEvent)
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblEvent4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblEvent3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblEvent2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblEvent1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblEvent1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEvent1.Click
        If lblEvent1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblEvent2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEvent2.Click
        If lblEvent2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub
    Private Sub lblEvent3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEvent3.Click
        If lblEvent3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub
    Private Sub lblEvent4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEvent4.Click
        If lblEvent4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow
        LogsDataGridView.Item(1, intRow).Value = "EventDelete"
        LogsDataGridView.Item(2, intRow).Value = intSelectedID
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()
        LogsDataGridView.Item(6, intRow).Value = "Event " & strEventDetails(intSelectedID, 2) & " deleted."

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class