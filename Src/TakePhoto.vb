Public Class TakePhoto
    Dim WCam As New iCam
    Dim bolCountdown As Boolean
    Dim decTimeLeft As Decimal

    Private Sub TakePhoto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case intCurrentForm
            Case 5
                AddFamily.Enabled() = True
                AddFamily.Focus()
            Case 7
                AddMember.Enabled() = True
                AddMember.Focus()
            Case 15
                AdminEditFamily.Enabled() = True
                AdminEditFamily.Focus()
        End Select

        WCam.closeCam()
        WCam = Nothing
    End Sub

    Private Sub TakePhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WCam = New iCam
        WCam.initCam(Me.picWebcam.Handle.ToInt32)
        decTimeLeft = 5
        bolCountdown = False
    End Sub
    Private Sub GetPhoto()
        'A sub to save the photo from the webcam
        Try
            Clipboard.SetImage(WCam.copyFrame(Me.picWebcam, New RectangleF(0, 0, Me.picWebcam.Width, Me.picWebcam.Height)))

            Select Case intCurrentForm
                Case 5
                    AddFamily.picFamPhoto.Image = Clipboard.GetImage()
                    bolPhotoTaken = True
                Case 7
                    AddMember.picPersonPhoto.Image = Clipboard.GetImage()
                    bolPhotoTaken = True
                Case 15
                    AdminEditFamily.picFamPhoto.Image = Clipboard.GetImage()
                    bolPhotoTaken = True
            End Select

            Clipboard.Clear()
        Catch ex As Exception
            'If there is an error, no photo is taken
        End Try

        Me.Close()
    End Sub

    Private Sub btnPhotoGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoGet.Click
        bolCountdown = True
        decTimeLeft = 5
        btnPhotoGet.Text() = "Get Ready!"
        btnPhotoGet.Enabled = False
    End Sub

    Private Sub timHalfSeconds_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timHalfSeconds.Tick
        'Every half second, if the timer is started, count down
        If bolCountdown = True Then
            decTimeLeft -= 0.5
            If decTimeLeft <= 0 Then
                bolCountdown = False
                picFlash.Width = 0
                picFlash.Height = 0
                picFlash.Visible = False
                Application.DoEvents()
                GetPhoto()
            ElseIf decTimeLeft = 0.5 Then
                picFlash.Visible = True
                picFlash.Height = Me.Height
                picFlash.Width = Me.Width
            End If
        Else
            btnPhotoGet.Text() = "Take photo"
            picFlash.Visible = False
        End If

        lblTimeLeft.Text = Int(decTimeLeft)
    End Sub
End Class