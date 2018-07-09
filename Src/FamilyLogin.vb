Public Class FamilyLogin
    Private Sub FamilyLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Families' table. You can move, or remove it, as needed.
        Me.FamiliesTableAdapter.Fill(Me.OpenAttendDataSet.Families)
        intCurrentForm = 4
        InitForm(Me, picLogo)
        Keyboard.Close()

        picScan.ImageLocation = strPicturePath & "ScanBarcode.bmp"
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(3)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Select Case bolAdminOverride
            Case True
                GoToForm(Me, AdminFamilyChoice)
            Case False
                If UCase(strCurrentLevel) = "ADMIN" Then
                    GoToForm(Me, AdminFamilyChoice)
                Else
                    GoToForm(Me, SignIn)
                End If
        End Select
    End Sub

    Private Sub txtBarcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.LostFocus
        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        Dim strBarcode As String
        Dim intFamilyID As Integer
        Dim intExpireYear As Integer

        If txtBarcode.Text.Length = 7 Then
            strBarcode = UCase(txtBarcode.Text)

            intFamilyID = Val(Mid(strBarcode, 1, 5))
            intExpireYear = Val(Mid(strBarcode, 6, 2))

            If intExpireYear >= Mid(Date.Today.Year.ToString, Date.Today.Year.ToString.Length - 1, 2) Then
                'If their badge is not expired

                FamiliesBindingSource.MoveFirst()

                For i = 0 To FamiliesBindingSource.Count() - 1
                    If intFamilyID = FamiliesDataGridView.CurrentRow.Cells(0).Value Then
                        If intFamilyID <> 0 Then
                            If FamiliesDataGridView.CurrentRow.Cells(1).Value <> "DELETED" Then
                                intCurrentFamily = intFamilyID
                                strFamilyName = FamiliesDataGridView.CurrentRow.Cells(1).Value
                                If strCurrentLevel = "ADMIN" Then
                                    GoToForm(Me, AdminEditFamily)
                                Else
                                    GoToForm(Me, FamilyMembers)
                                End If
                                Exit Sub
                            Else
                                MessageBox.Show("Error: Family has been deleted.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End If
                        End If
                    End If

                    FamiliesBindingSource.MoveNext()
                Next

                MessageBox.Show("Error: Unknown family identity.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                'If the family badge is expired, tell them sign in is not allowed
                MessageBox.Show("Error: Family barcode has expired.", "Please contact an administrator", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

            txtBarcode.Clear()
        End If
    End Sub
End Class