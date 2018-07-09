Public Class AddEditEvent
    Dim bolNewEvent As Boolean
    Dim bolException As Boolean
    Dim strEventCode As String
    Private Sub AddEditEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)

        intCurrentForm = 19
        InitForm(Me, picLogo)

        Randomize()

        If intCurrentEvent = 0 Then
            lblTitle.Text = "Add Event"
            bolNewEvent = True
            GenRandomCode()
            txtDay.Text = datEventDate.Day
            txtMonth.Text = datEventDate.Month
            txtYear.Text = datEventDate.Year
        Else
            lblTitle.Text = "Edit Event"
            bolNewEvent = False
            LoadEventDetails()
        End If
    End Sub

    Private Sub SaveEventDetails()
        Dim datDate As Date 'A temporary date
        Dim datStartDate As Date 'A temporary date to store the start time
        Dim datEndDate As Date 'A temporary date to store the end time

        Dim intRow As Integer

        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)

        If intCurrentEvent = 0 Then

            intCurrentEvent = EventsBindingSource.Count() + 1

            EventsBindingSource.AddNew()
            intRow = EventsDataGridView.NewRowIndex - 1



            EventsDataGridView.Item(0, intRow).Value = intCurrentEvent
        Else
            EventsBindingSource.MoveFirst()
            For i = 0 To EventsBindingSource.Count - 1
                If EventsDataGridView.CurrentRow.Cells(0).Value = intCurrentEvent Then
                    intRow = i
                    Exit For
                End If
                EventsBindingSource.MoveNext()
            Next
        End If

        bolException = False


        If txtName.Text <> Nothing Then
            EventsDataGridView.Item(1, intRow).Value = txtName.Text

            Try 'Store the date of the event
                datDate = Date.Parse(txtDay.Text & "/" & txtMonth.Text & "/" & txtYear.Text)
                If DateDiff(DateInterval.Day, Date.Now, datDate) < 0 Then 'Can't create an event in the past
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect date of event entered (date of event is in the past).", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    EventsDataGridView.Item(2, intRow).Value = datDate
                End If
            Catch ex As Exception
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Incorrect date of event entered.", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            Try 'Store the starting time of the event
                datStartDate = datDate.AddHours(Val(txtStartHour.Text))
                datStartDate = datStartDate.AddMinutes(Val(txtStartMin.Text))
                If DateDiff(DateInterval.Minute, datDate, datStartDate) < 1 Then 'Can't create an event in the past
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect time of event entered (time of event is in the past).", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    EventsDataGridView.Item(3, intRow).Value = datStartDate
                End If
            Catch ex As Exception
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Incorrect time of event entered.", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            Try 'Store the ending time of the event
                datDate = Date.Parse(txtDay.Text & "/" & txtMonth.Text & "/" & txtYear.Text)
                datEndDate = datDate.AddHours(Val(txtEndHour.Text))
                datEndDate = datEndDate.AddMinutes(Val(txtEndMin.Text))
                If DateDiff(DateInterval.Minute, datStartDate, datEndDate) < 1 Then 'Can't create an event before the start time
                    bolException = True
                    Keyboard.Close()
                    MessageBox.Show("Incorrect time of event entered (time of event is before the start time).", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    EventsDataGridView.Item(4, intRow).Value = datEndDate
                End If
            Catch ex As Exception
                bolException = True
                Keyboard.Close()
                MessageBox.Show("Incorrect time of event entered.", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            EventsDataGridView.Item(5, intRow).Value = txtCost.Text
            EventsDataGridView.Item(6, intRow).Value = strEventCode
            EventsDataGridView.Item(7, intRow).Value = txtNotes.Text

        Else
            bolException = True
            Keyboard.Close()
            MessageBox.Show("Error: no event name entered.", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        
        Me.Validate()
        Me.EventsBindingSource.EndEdit()
        Me.EventsTableAdapter.Update(Me.OpenAttendDataSet.Events)
    End Sub

    Private Sub GenRandomCode()
        'Generate a random event code
        Dim intCharType As Integer 'What type of letter to add
        Dim intLetterNum As Integer 'The number of the letter to add
        Dim intGenNum As Integer 'The number generated randomly

        strEventCode = ""

        For i = 1 To 2
            intCharType = Math.Round(Rnd() * 100) 'More random than rnd() * 2
            If intCharType <= 50 Then
                'Add a letter to the code
                intGenNum = Math.Round(Rnd() * 25)
                intLetterNum = intGenNum + 97 'Conver the lowercase letter to ascii
                strEventCode += UCase(Chr(intLetterNum)) 'Uppercase the letter and add it to the code
            Else
                'Add a number to the code
                intGenNum = Math.Round(Rnd() * 9)
                strEventCode = strEventCode & intGenNum
            End If
        Next
    End Sub

    Private Sub LoadEventDetails()
        Dim datSelectedDate As Date
        Dim datStartTime As Date
        Dim datEndTime As Date

        For i = 0 To EventsBindingSource.Count - 1
            If EventsDataGridView.CurrentRow.Cells(0).Value = intCurrentEvent Then
                txtName.Text = EventsDataGridView.CurrentRow.Cells(1).Value
                datSelectedDate = EventsDataGridView.CurrentRow.Cells(2).Value
                datStartTime = EventsDataGridView.CurrentRow.Cells(3).Value
                datEndTime = EventsDataGridView.CurrentRow.Cells(4).Value
                txtCost.Text = EventsDataGridView.CurrentRow.Cells(5).Value
                strEventCode = EventsDataGridView.CurrentRow.Cells(6).Value
                txtNotes.Text = EventsDataGridView.CurrentRow.Cells(7).Value

                txtDay.Text = datSelectedDate.Day
                txtMonth.Text = datSelectedDate.Month
                txtYear.Text = datSelectedDate.Year
                txtStartHour.Text = datStartTime.TimeOfDay.Hours
                txtStartMin.Text = datStartTime.TimeOfDay.Minutes
                txtEndHour.Text = datEndTime.TimeOfDay.Hours
                txtEndMin.Text = datEndTime.TimeOfDay.Minutes

                Exit For

            End If
            EventsBindingSource.MoveNext()
        Next
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            SaveEventDetails()
            If bolException = False Then
                SaveLog()
                GoToForm(Me, EventCalendar)
            Else
                Keyboard.Close()
                MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            Keyboard.Close()
            MessageBox.Show("An error occured, please contact an administrator", "Unable to create/edit event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub btnShowKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKeyboard.Click
        InitKeyboard()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GoToForm(Me, EventCalendar)
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
                                txtDay.Text = DeleteLast(txtDay.Text)
                            Case 3
                                txtNotes.Text = DeleteLast(txtNotes.Text)
                            Case 4
                                txtEndMin.Text = DeleteLast(txtEndMin.Text)
                            Case 5
                                txtEndHour.Text = DeleteLast(txtEndHour.Text)
                            Case 6
                                txtStartMin.Text = DeleteLast(txtStartMin.Text)
                            Case 7
                                txtStartHour.Text = DeleteLast(txtStartHour.Text)
                            Case 8
                                txtYear.Text = DeleteLast(txtYear.Text)
                            Case 9
                                txtMonth.Text = DeleteLast(txtMonth.Text)
                            Case 10
                                txtCost.Text = DeleteLast(txtCost.Text)
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
                            txtDay.Text = ""
                        Case 3
                            txtNotes.Text = ""
                        Case 4
                            txtEndMin.Text = ""
                        Case 5
                            txtEndHour.Text = ""
                        Case 6
                            txtStartMin.Text = ""
                        Case 7
                            txtStartHour.Text = ""
                        Case 8
                            txtYear.Text = ""
                        Case 9
                            txtMonth.Text = ""
                        Case 10
                            txtCost.Text = ""
                    End Select
                Case "CUT"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtName.Text)
                            txtName.Text = ""
                        Case 2
                            Clipboard.SetText(txtDay.Text)
                            txtDay.Text = ""
                        Case 3
                            Clipboard.SetText(txtNotes.Text)
                            txtNotes.Text = ""
                        Case 4
                            Clipboard.SetText(txtEndMin.Text)
                            txtEndMin.Text = ""
                        Case 5
                            Clipboard.SetText(txtEndHour.Text)
                            txtEndHour.Text = ""
                        Case 6
                            Clipboard.SetText(txtStartMin.Text)
                            txtStartMin.Text = ""
                        Case 7
                            Clipboard.SetText(txtStartHour.Text)
                            txtStartHour.Text = ""
                        Case 8
                            Clipboard.SetText(txtYear.Text)
                            txtYear.Text = ""
                        Case 9
                            Clipboard.SetText(txtMonth.Text)
                            txtMonth.Text = ""
                        Case 10
                            Clipboard.SetText(txtCost.Text)
                            txtCost.Text = ""
                    End Select
                Case "COPY"
                    Select Case intSelectedTxtBox
                        Case 1
                            Clipboard.SetText(txtName.Text)
                        Case 2
                            Clipboard.SetText(txtDay.Text)
                        Case 3
                            Clipboard.SetText(txtNotes.Text)
                        Case 4
                            Clipboard.SetText(txtEndMin.Text)
                        Case 5
                            Clipboard.SetText(txtEndHour.Text)
                        Case 6
                            Clipboard.SetText(txtStartMin.Text)
                        Case 7
                            Clipboard.SetText(txtStartHour.Text)
                        Case 8
                            Clipboard.SetText(txtYear.Text)
                        Case 9
                            Clipboard.SetText(txtMonth.Text)
                        Case 10
                            Clipboard.SetText(txtCost.Text)
                    End Select
                Case "PASTE"
                    Select Case intSelectedTxtBox
                        Case 1
                            txtName.Text += Clipboard.GetText()
                        Case 2
                            txtDay.Text += Clipboard.GetText()
                        Case 3
                            txtNotes.Text += Clipboard.GetText()
                        Case 4
                            txtEndMin.Text += Clipboard.GetText()
                        Case 5
                            txtEndHour.Text += Clipboard.GetText()
                        Case 6
                            txtStartMin.Text += Clipboard.GetText()
                        Case 7
                            txtStartHour.Text += Clipboard.GetText()
                        Case 8
                            txtYear.Text += Clipboard.GetText()
                        Case 9
                            txtMonth.Text += Clipboard.GetText()
                        Case 10
                            txtCost.Text += Clipboard.GetText()
                    End Select
                Case Else
                    Select Case intSelectedTxtBox
                        Case 1
                            txtName.Text += strInput
                        Case 2
                            txtDay.Text += strInput
                        Case 3
                            txtNotes.Text += strInput
                        Case 4
                            txtEndMin.Text += strInput
                        Case 5
                            txtEndHour.Text += strInput
                        Case 6
                            txtStartMin.Text += strInput
                        Case 7
                            txtStartHour.Text += strInput
                        Case 8
                            txtYear.Text += strInput
                        Case 9
                            txtMonth.Text += strInput
                        Case 10
                            txtCost.Text += strInput
                    End Select
            End Select
        End If

        If txtName.TextLength > 30 Then txtName.Text = Mid(txtName.Text, 1, 30)
        If txtDay.TextLength > 2 Then txtDay.Text = Mid(txtDay.Text, 1, 2)
        If txtMonth.TextLength > 2 Then txtMonth.Text = Mid(txtMonth.Text, 1, 2)
        If txtYear.TextLength > 4 Then txtYear.Text = Mid(txtYear.Text, 1, 4)
        If txtStartHour.TextLength > 2 Then txtStartHour.Text = Mid(txtStartHour.Text, 1, 2)
        If txtStartMin.TextLength > 2 Then txtStartMin.Text = Mid(txtStartMin.Text, 1, 2)
        If txtEndHour.TextLength > 2 Then txtEndHour.Text = Mid(txtEndHour.Text, 1, 2)
        If txtEndMin.TextLength > 2 Then txtEndMin.Text = Mid(txtEndMin.Text, 1, 2)
        If txtNotes.TextLength > 255 Then txtNotes.Text = Mid(txtNotes.Text, 1, 255)
        If txtCost.TextLength > 6 Then txtCost.Text = Mid(txtCost.Text, 1, 6)

        txtName.SelectionStart() = txtName.Text.Length
        txtDay.SelectionStart() = txtDay.Text.Length
        txtMonth.SelectionStart() = txtMonth.TextLength
        txtYear.SelectionStart() = txtYear.TextLength
        txtStartHour.SelectionStart() = txtStartHour.TextLength
        txtStartMin.SelectionStart() = txtStartMin.TextLength
        txtEndHour.SelectionStart() = txtEndHour.TextLength
        txtEndMin.SelectionStart() = txtEndMin.TextLength
        txtNotes.SelectionStart() = txtNotes.TextLength
        txtCost.SelectionStart() = txtCost.TextLength

    End Sub

    Private Sub txtName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Click
        intSelectedTxtBox = 1
    End Sub

    Private Sub txtDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDay.Click
        intSelectedTxtBox = 2
        If UCase(txtDay.Text) = "DD" Then
            txtDay.Clear()
        End If
    End Sub

    Private Sub txtNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotes.Click
        intSelectedTxtBox = 3
    End Sub

    Private Sub txtEndMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndMin.Click
        intSelectedTxtBox = 4
        If UCase(txtEndMin.Text) = "MM" Then
            txtEndMin.Clear()
        End If
    End Sub

    Private Sub txtEndHour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndHour.Click
        intSelectedTxtBox = 5
        If UCase(txtEndHour.Text) = "HH" Then
            txtEndHour.Clear()
        End If
    End Sub

    Private Sub txtStartMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartMin.Click
        intSelectedTxtBox = 6
        If UCase(txtStartMin.Text) = "MM" Then
            txtStartMin.Clear()
        End If
    End Sub

    Private Sub txtStartHour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartHour.Click
        intSelectedTxtBox = 7
        If UCase(txtStartHour.Text) = "HH" Then
            txtStartHour.Clear()
        End If
    End Sub

    Private Sub txtYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.Click
        intSelectedTxtBox = 8
        If UCase(txtYear.Text) = "YYYY" Then
            txtYear.Clear()
        End If
    End Sub

    Private Sub txtMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.Click
        intSelectedTxtBox = 9
        If UCase(txtMonth.Text) = "MM" Then
            txtMonth.Clear()
        End If
    End Sub

    Private Sub txtCost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.Click
        intSelectedTxtBox = 10
        If txtCost.Text = "000.00" Then
            txtCost.Clear()
        End If
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow

        If bolNewEvent = True Then
            LogsDataGridView.Item(1, intRow).Value = "EventCreate"
            LogsDataGridView.Item(6, intRow).Value = "Event " & txtName.Text & " created."
        Else
            LogsDataGridView.Item(1, intRow).Value = "EventEdit"
            LogsDataGridView.Item(6, intRow).Value = "Event " & txtName.Text & " edited."
        End If

        LogsDataGridView.Item(2, intRow).Value = intCurrentEvent
        LogsDataGridView.Item(3, intRow).Value = 0 'No action for this
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()


        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class