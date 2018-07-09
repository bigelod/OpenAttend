Public Class ValidateInOut
    Dim strName As String
    Private Sub ValidateInOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.OpenAttendDataSet.People)
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Families' table. You can move, or remove it, as needed.
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)
        InitForm(Me, picLogo)

        If Screen.PrimaryScreen.Bounds.Height = 600 Then 'If this is being run on a 1024x600 laptop rather than 1024x768
            lblSignInOut.Top = 521
            lblSignInOut.Left = 12
            btnYes.Top = 483
            btnYes.Left = 269
            btnNo.Top = 483
            btnNo.Left = 646
            picPerson.Top = 204
            picPerson.Left = 144
            picFamily.Top = 204
            picFamily.Left = 580
            lblMedical.Top = 204
            lblMedical.Left = 580
            lblName.Top = 159
            lblName.Left = 144
        End If

        Select Case intInOutMode
            Case 2
                lblTitle.Text = "Vailidate Sign In"
                lblSignInOut.Text = "Sign In?"
                picFamily.ImageLocation = Nothing
                picFamily.Visible = False
                lblMedical.Visible = True
                LoadSignIn()
            Case 3
                lblTitle.Text = "Vailidate Sign Out"
                lblMedical.Visible = False
                picFamily.Visible = True
                lblSignInOut.Text = "Sign Out?"
                LoadSignIn()
                LoadSignOut()
        End Select

    End Sub

    Private Sub LoadSignIn()
        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                strName = "Name: " & PeopleDataGridView.CurrentRow.Cells(1).Value & " " & PeopleDataGridView.CurrentRow.Cells(2).Value
                lblName.Text = strName
                If PeopleDataGridView.CurrentRow.Cells(11).Value <> "N/A" Then
                    lblMedical.Text = "Medical Details:" & vbNewLine & PeopleDataGridView.CurrentRow.Cells(11).Value
                End If
                picPerson.ImageLocation = "\\" & strServer & "\SharedDocs\OpenAttend\PPhotos\" & intCurrentPerson & ".png"
                Exit For
            End If

            PeopleBindingSource.MoveNext()
        Next
    End Sub
    Private Sub LoadSignOut()
        FamiliesBindingSource.MoveFirst()
        For i = 0 To FamiliesBindingSource.Count - 1
            If FamiliesDataGridView.CurrentRow.Cells(0).Value = intCurrentFamily Then
                picFamily.ImageLocation = "\\" & strServer & "\SharedDocs\OpenAttend\FPhotos\" & intCurrentFamily & ".png"
                Exit For
            End If
            FamiliesBindingSource.MoveNext()
        Next
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        If intSignedIn(intCurrentPerson) = 1 Then
            intSignedIn(intCurrentPerson) = 0
            intSignedIn(0) -= 1
        Else
            intSignedIn(intCurrentPerson) = 1
            intSignedIn(0) += 1
        End If

        SaveLog()
        GoToForm(Me, GroupRegister)
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        intCurrentPerson = 0
        intCurrentFamily = 0
        GoToForm(Me, GroupRegister)
    End Sub
    Private Sub SaveLog()
        Dim intRow As Integer

        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)
        LogsBindingSource.AddNew()
        intRow = LogsDataGridView.NewRowIndex - 1

        LogsDataGridView.Item(0, intRow).Value = intRow

        PeopleBindingSource.MoveFirst()
        For i = 0 To PeopleBindingSource.Count - 1
            If PeopleDataGridView.CurrentRow.Cells(0).Value = intCurrentPerson Then
                strName = PeopleDataGridView.CurrentRow.Cells(1).Value & " " & PeopleDataGridView.CurrentRow.Cells(2).Value
                Exit For
            End If
            PeopleBindingSource.MoveNext()
        Next

        Select Case intInOutMode
            Case 2
                LogsDataGridView.Item(1, intRow).Value = "SignIn"
                LogsDataGridView.Item(6, intRow).Value = strName & " signed in to group " & strTeamDetails(intCurrentTeam, 2) & "."
            Case 3
                LogsDataGridView.Item(1, intRow).Value = "SignOut"
                LogsDataGridView.Item(6, intRow).Value = strName & " signed out of group " & strTeamDetails(intCurrentTeam, 2) & "."
        End Select

        LogsDataGridView.Item(2, intRow).Value = intCurrentPerson
        LogsDataGridView.Item(3, intRow).Value = intCurrentTeam
        LogsDataGridView.Item(4, intRow).Value = Date.Today
        LogsDataGridView.Item(5, intRow).Value = GetTime()


        Me.Validate()
        Me.LogsBindingSource.EndEdit()
        Me.LogsTableAdapter.Update(Me.OpenAttendDataSet.Logs)
    End Sub
End Class