Public Class TerminalMode

    
    Private Sub TerminalMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        intCurrentForm = 2
        InitForm(Me, picLogo)

        SignInMode.ImageLocation = strPicturePath & "SignInMode.bmp"
        SignInMode.Visible = True
        SignInMode.Left = 12
        SignInMode.Top = 287

        RegMode.ImageLocation = strPicturePath & "RegistrationMode.bmp"
        RegMode.Visible = True
        RegMode.Left = 355
        RegMode.Top = 287

        AdminMode.ImageLocation = strPicturePath & "AdminMode.bmp"
        AdminMode.Visible = True
        AdminMode.Left = 696
        AdminMode.Top = 287

        Select Case UCase(strCurrentLevel)
            Case "GUEST"
                'Hide everything but the guest view
                RegMode.Visible = False
                AdminMode.Visible = False
                SignInMode.Left = 355
                SignInMode.Top = 287
            Case "TEAM"
                'Hide the admin mode, but show the two other modes
                AdminMode.Visible = False
                RegMode.Left = 696
                RegMode.Top = 287
            Case "ADMIN"
                'Everything is ready for the admin
            Case Else
                'Hide everything as we do not know who this person is
                SignInMode.Visible = False
                RegMode.Visible = False
                AdminMode.Visible = False
        End Select
        
    End Sub

    Private Sub SignInMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInMode.Click
        strCurrentMode = "SignIn"
        GoToForm(Me, SignIn)
    End Sub

    Private Sub RegMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegMode.Click
        If UCase(strCurrentLevel) <> "GUEST" Then
            strCurrentMode = "Registration"
            GoToForm(Me, GroupSelect)
        End If
    End Sub

    Private Sub AdminMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminMode.Click
        If UCase(strCurrentLevel) = "ADMIN" Then
            strCurrentMode = "Administration"
            GoToForm(Me, AdminSignIn)
        End If
    End Sub
End Class