Public Class GroupRegister
    Dim strOldEventCode As String
    Dim strCurrentEventCode As String
    Dim datEventStartTime As Date
    Dim datEventEndTime As Date
    Dim strName As String

    Private Sub Group_Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.OpenAttendDataSet.Teams)

        intCurrentForm = 10
        InitForm(Me, picLogo)

        Keyboard.Close()

        If bolAdminOverride = False Then
            btnAdmin.Visible = True
        Else
            btnAdmin.Visible = False
        End If

        picScan.ImageLocation = strPicturePath & "ScanBarcode.bmp"

        If Screen.PrimaryScreen.Bounds.Height = 600 Then 'If this is being run on a 1024x600 laptop rather than 1024x768
            btnLogout.Top = 464
            btnLogout.Left = 772
            btnHelp.Top = 344
            btnHelp.Left = 772
            btnAdmin.Top = 464
            btnAdmin.Left = 12
        End If

        strCurrentEventCode = ""

        CheckEvents()
        intInOutMode = 0

        lblMembersSignedIn.Text = "Number signed in: " & intSignedIn(0) 'Show the number of signed in members

    End Sub
    Private Sub CheckEvents()

        EventsBindingSource.MoveFirst()
        For i = 0 To EventsBindingSource.Count - 1 'Check for an event on this day
            If EventsDataGridView.CurrentRow.Cells(2).Value = Date.Today.Date Then

                datEventStartTime = EventsDataGridView.CurrentRow.Cells(3).Value
                datEventEndTime = EventsDataGridView.CurrentRow.Cells(4).Value
                datEventEndTime.AddHours(1) 'Add an hour to allow signing out after the event

                If GetTime(1) >= datEventStartTime.TimeOfDay And GetTime(1) <= datEventEndTime.TimeOfDay Then 'If the event is still going
                    strCurrentEventCode = EventsDataGridView.CurrentRow.Cells(6).Value
                    If strOldEventCode = "" Then strOldEventCode = strCurrentEventCode
                    If strCurrentEventCode <> strOldEventCode Then
                        MessageBox.Show("Error: Event has changed, logging out", "End of registration for event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        'Event changed, logout
                        strCurrentLevel = Nothing
                        strCurrentMode = Nothing
                        strCurrentUser = Nothing
                        strNonAdminUser = Nothing
                        bolAdminOverride = False
                        GoToForm(Me, Login)
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
            EventsBindingSource.MoveNext()
        Next
        MessageBox.Show("Error: No event on now, logging out", "End of registration for event", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'If there are no events, logout
        For i = 0 To 99999
            intSignedIn(i) = 0
        Next
        strCurrentLevel = Nothing
        strCurrentMode = Nothing
        strCurrentUser = Nothing
        strNonAdminUser = Nothing
        bolAdminOverride = False
        GoToForm(Me, Login)
    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(3)
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim strQuestion As String
        Dim strMessage As String

        strQuestion = "Youth still signed in"
        strMessage = "Are you sure you wish to logout? (all youth will be signed out)"

        If intSignedIn(0) <> 0 Then
            If MessageBox.Show(strMessage, strQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        For i = 1 To 99999
            If intSignedIn(i) <> 0 Then
                'Try to store the log of the member logging out
                Try
                    intCurrentPerson = i
                    SaveLog(1)
                Catch ex As Exception
                    'If there is an error, report the name of the youth that wasn't signed out

                    PeopleBindingSource.MoveFirst()
                    For n = 0 To PeopleBindingSource.Count - 1
                        If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                            strName = PeopleDataGridView.CurrentRow.Cells(1).Value & " " & PeopleDataGridView.CurrentRow.Cells(2).Value
                            Exit For
                        End If
                        PeopleBindingSource.MoveNext()
                    Next

                    MessageBox.Show("Error: Unable to sign out " & strName, "Error signing out", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try
            End If
            intSignedIn(i) = 0

            If i <= 9999 Then 'Deselect all teams
                bolSelectedTeams(i) = 0
            End If
        Next
        intSignedIn(0) = 0
        SaveLog()
        strCurrentLevel = Nothing
        strCurrentMode = Nothing
        strCurrentUser = Nothing
        strNonAdminUser = Nothing
        bolAdminOverride = False
        intInOutMode = 0
        GoToForm(Me, Login)
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        If bolAdminOverride = False Then GoToForm(Me, AdminOverride)
    End Sub

    Private Sub txtBarcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.LostFocus
        txtBarcode.Focus()
    End Sub
    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        Dim strBarcode As String
        Dim intPersonID As Integer
        Dim intFamilyID As Integer
        Dim intExpireYear As Integer
        Dim strEventCode As String
        Dim intYearsOld As Integer

        If txtBarcode.Text.Length = 7 Then

            strBarcode = UCase(txtBarcode.Text)

            If intInOutMode = 1 Then
                intFamilyID = Val(Mid(strBarcode, 1, 5))
                intExpireYear = Val(Mid(strBarcode, 6, 2))
                strEventCode = "00"
            Else
                intPersonID = Val(Mid(strBarcode, 1, 5))
                strEventCode = Mid(strBarcode, 6, 2)
            End If


            If strEventCode = strCurrentEventCode And intInOutMode < 1 Then
                'If their badge is for the right event and the member is not scanning their family badge

                intCurrentPerson = 0

                PeopleBindingSource.MoveFirst()

                For i = 0 To PeopleBindingSource.Count() - 1
                    If intPersonID = PeopleDataGridView.CurrentRow.Cells(0).Value Then
                        If intPersonID <> 0 Then
                            If PeopleDataGridView.CurrentRow.Cells(8).Value > 0 Then
                                intCurrentPerson = intPersonID
                                intCurrentFamily = PeopleDataGridView.CurrentRow.Cells(8).Value
                                If strCurrentLevel = "ADMIN" Then
                                    'Allow signin/out as the user is an admin
                                    If intSignedIn(intCurrentPerson) = 0 Then
                                        intInOutMode = 2
                                    Else
                                        intInOutMode = 3
                                    End If
                                    Exit For
                                Else
                                    'If not an admin, see which team to slot the youth into
                                    intYearsOld = Math.Floor(DateDiff(DateInterval.Day, PeopleDataGridView.CurrentRow.Cells(4).Value, Date.Today) / 365)
                                    For n = 1 To 9999
                                        If intYearsOld >= strTeamDetails(n, 3) And intYearsOld <= strTeamDetails(n, 4) And bolSelectedTeams(n) = True Then
                                            intCurrentTeam = n 'Set the current team number

                                            If intSignedIn(intCurrentPerson) = 0 Then
                                                intInOutMode = 2
                                                Exit For
                                            Else
                                                intInOutMode = 1
                                                MessageBox.Show("Please scan family badge", "Sign youth out", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                PeopleBindingSource.MoveFirst()

                                                For x = 0 To PeopleBindingSource.Count - 1
                                                    If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                                                        If PeopleDataGridView.CurrentRow.Cells(11).Value <> "N/A" Then
                                                            lblMedical.Text = "Medical Details:" & vbNewLine & PeopleDataGridView.CurrentRow.Cells(11).Value
                                                            Exit For
                                                        End If
                                                    End If

                                                    PeopleBindingSource.MoveNext()
                                                Next

                                                Exit For
                                            End If
                                        ElseIf n = 9999 Then
                                            strInvalidInOutMessage = "Member is of incorrect age for selected groups."
                                            GoToForm(Me, InvalidInOut)
                                        End If
                                    Next
                                    Exit For
                                End If
                                txtBarcode.Clear()
                                Exit Sub
                            Else
                                MessageBox.Show("Error: Member has been deleted.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                txtBarcode.Clear()
                                Exit Sub
                            End If
                        End If
                    End If

                    PeopleBindingSource.MoveNext()
                Next

                If intCurrentPerson = 0 Then
                    MessageBox.Show("Error: Unknown member identity.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    ReloadData() 'Reload incase the member has just been added
                End If
            ElseIf intInOutMode = 1 Then
                If intFamilyID = intCurrentFamily Then
                    If intExpireYear >= Mid(Date.Today.Year.ToString, Date.Today.Year.ToString.Length - 1, 2) Then
                        intInOutMode = 3
                    Else
                        intInOutMode = 0
                        MessageBox.Show("Error: Family badge has expired.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        lblMedical.Text = "Medical Details:" & vbNewLine & "N/A"
                    End If
                Else
                    intInOutMode = 0
                    lblMedical.Text = "Medical Details:" & vbNewLine & "N/A"
                    strInvalidInOutMessage = "Incorrect family badge, do not allow sign out"
                    GoToForm(Me, InvalidInOut)
                End If
            Else
                'If the member barcode is expired, tell them sign in is not allowed
                MessageBox.Show("Error: Member barcode is for another event.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                lblMedical.Text = "Medical Details:" & vbNewLine & "N/A"
            End If

            If intInOutMode >= 2 Then
                GoToForm(Me, ValidateInOut)
            End If

            txtBarcode.Clear()
        End If

        lblMembersSignedIn.Text = "Number signed in: " & intSignedIn(0) 'Show the number of signed in members
    End Sub
   

    Private Sub timFiveMin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timFiveMin.Tick
        'A sub to reload data and check for the status of the event every five minutes. This saves processing power

        ReloadData()
        CheckEvents()
        txtBarcode.Focus()
    End Sub

    Private Sub ReloadData()
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.OpenAttendDataSet.Events)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.OpenAttendDataSet.Teams)
    End Sub

    Private Sub SaveLog(Optional ByVal intType As Integer = 0)
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow

        If intType = 1 Then 'Store a signout log
            PeopleBindingSource.MoveFirst()
            For i = 0 To PeopleBindingSource.Count - 1
                If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                    strName = PeopleDataGridView.CurrentRow.Cells(1).Value & " " & PeopleDataGridView.CurrentRow.Cells(2).Value
                    Exit For
                End If
                PeopleBindingSource.MoveNext()
            Next


            LogsDataGridView.Item(1, intRow).Value = "SignOut"
            LogsDataGridView.Item(6, intRow).Value = strName & " was automatically signed out of group " & strTeamDetails(intCurrentTeam, 2) & "."
            LogsDataGridView.Item(2, intRow).Value = intCurrentPerson
            LogsDataGridView.Item(3, intRow).Value = intCurrentTeam
            LogsDataGridView.Item(4, intRow).Value = Date.Today
            LogsDataGridView.Item(5, intRow).Value = GetTime()
        Else 'Otherwise store a logout log
            LogsDataGridView.Item(1, intRow).Value = "Logout"
            LogsDataGridView.Item(6, intRow).Value = strCurrentUser & " logged out."
            LogsDataGridView.Item(2, intRow).Value = intCurrentLogin
            LogsDataGridView.Item(3, intRow).Value = 0
            LogsDataGridView.Item(4, intRow).Value = Date.Today
            LogsDataGridView.Item(5, intRow).Value = GetTime()
        End If

        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class