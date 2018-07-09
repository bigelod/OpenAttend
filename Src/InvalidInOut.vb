Public Class InvalidInOut

    Private Sub InvalidInOut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitForm(Me, picLogo)

        picInvalid.ImageLocation = strPicturePath & "InvalidCross.bmp"

        lblReason.Text = "Unauthorised for sign-in" & vbNewLine & "Reason: " & strInvalidInOutMessage

        If Screen.PrimaryScreen.Bounds.Height = 600 Then 'If this is being run on a 1024x600 laptop rather than 1024x768
            btnOk.Top = 272
            btnOk.Left = 772
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        GoToForm(Me, GroupRegister)
    End Sub
End Class