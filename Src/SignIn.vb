Public Class SignIn

    Private Sub SignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intCurrentForm = 3
        InitForm(Me, picLogo)
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Select Case UCase(strCurrentLevel)
            Case "ADMIN"
                GoToForm(Me, AdminSignIn)
            Case Else
                GoToForm(Me, AdminOverride)
        End Select

    End Sub

    Private Sub btnExistFam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistFam.Click
        GoToForm(Me, FamilyLogin)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(4)
    End Sub

    Private Sub btnNewFam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFam.Click
        GoToForm(Me, AddFamily)
    End Sub
End Class