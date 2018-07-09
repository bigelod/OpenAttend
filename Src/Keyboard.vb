Public Class Keyboard
    Dim bolShift As Boolean 'A variable to check if the keyboard has shift toggled
    Dim bolControl As Boolean 'A variable to check if the keyboard has control toggled
    Dim strKeyInput As String 'A variable used to hold the current virtual keyboard input

    Private Sub btnKey1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey1.Click
        Select Case bolShift
            Case True
                strKeyInput = "!"
            Case False
                strKeyInput = "1"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey2.Click
        Select Case bolShift
            Case True
                strKeyInput = ";"
            Case False
                strKeyInput = "2"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey8.Click
        Select Case bolShift
            Case True
                strKeyInput = "*"
            Case False
                strKeyInput = "8"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey7.Click
        Select Case bolShift
            Case True
                strKeyInput = "#"
            Case False
                strKeyInput = "7"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey6.Click
        Select Case bolShift
            Case True
                strKeyInput = "^"
            Case False
                strKeyInput = "6"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey5.Click
        Select Case bolShift
            Case True
                strKeyInput = "%"
            Case False
                strKeyInput = "5"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey4.Click
        Select Case bolShift
            Case True
                strKeyInput = "$"
            Case False
                strKeyInput = "4"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey3.Click
        Select Case bolShift
            Case True
                strKeyInput = "£"
            Case False
                strKeyInput = "3"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey9.Click
        Select Case bolShift
            Case True
                strKeyInput = "("
            Case False
                strKeyInput = "9"
        End Select

        SendInput()
    End Sub

    Private Sub btnKey0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey0.Click
        Select Case bolShift
            Case True
                strKeyInput = ")"
            Case False
                strKeyInput = "0"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyMinus.Click
        Select Case bolShift
            Case True
                strKeyInput = "_"
            Case False
                strKeyInput = "-"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyAt.Click
        Select Case bolShift
            Case True
                strKeyInput = "@"
            Case False
                strKeyInput = "'"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyQ.Click
        Select Case bolShift
            Case True
                strKeyInput = "Q"
            Case False
                strKeyInput = "q"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyW.Click
        Select Case bolShift
            Case True
                strKeyInput = "W"
            Case False
                strKeyInput = "w"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyE.Click
        Select Case bolShift
            Case True
                strKeyInput = "E"
            Case False
                strKeyInput = "e"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyR.Click
        Select Case bolShift
            Case True
                strKeyInput = "R"
            Case False
                strKeyInput = "r"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyT.Click
        Select Case bolShift
            Case True
                strKeyInput = "T"
            Case False
                strKeyInput = "t"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyY.Click
        Select Case bolShift
            Case True
                strKeyInput = "Y"
            Case False
                strKeyInput = "y"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyU.Click
        Select Case bolShift
            Case True
                strKeyInput = "U"
            Case False
                strKeyInput = "u"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyI.Click
        Select Case bolShift
            Case True
                strKeyInput = "I"
            Case False
                strKeyInput = "i"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyO.Click
        Select Case bolShift
            Case True
                strKeyInput = "O"
            Case False
                strKeyInput = "o"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyP.Click
        Select Case bolShift
            Case True
                strKeyInput = "P"
            Case False
                strKeyInput = "p"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyDel.Click
        strKeyInput = "DELETE"
        bolControl = False
        bolShift = False
        SendInput()
    End Sub

    Private Sub btnKeyLSlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyLSlash.Click

        Select Case bolShift
            Case True
                strKeyInput = "|"
            Case False
                strKeyInput = "\"
        End Select
        SendInput()
    End Sub

    Private Sub btnKeyA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyA.Click
        Select Case bolShift
            Case True
                strKeyInput = "A"
            Case False
                strKeyInput = "a"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyS.Click
        Select Case bolShift
            Case True
                strKeyInput = "S"
            Case False
                strKeyInput = "s"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyD.Click
        Select Case bolShift
            Case True
                strKeyInput = "D"
            Case False
                strKeyInput = "d"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyF.Click
        Select Case bolShift
            Case True
                strKeyInput = "F"
            Case False
                strKeyInput = "f"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyG.Click
        Select Case bolShift
            Case True
                strKeyInput = "G"
            Case False
                strKeyInput = "g"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyH.Click
        Select Case bolShift
            Case True
                strKeyInput = "H"
            Case False
                strKeyInput = "h"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyJ.Click
        Select Case bolShift
            Case True
                strKeyInput = "J"
            Case False
                strKeyInput = "j"
        End Select

        SendInput()
    End Sub

    Private Sub btnkeyK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeyK.Click
        Select Case bolShift
            Case True
                strKeyInput = "K"
            Case False
                strKeyInput = "k"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyL.Click
        Select Case bolShift
            Case True
                strKeyInput = "L"
            Case False
                strKeyInput = "l"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyHelp.Click
        strKeyInput = "HELP"
        bolControl = False
        bolShift = False
        SendInput()
    End Sub

    Private Sub btnKeyShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyShift.Click
        If bolShift = False Then
            bolShift = True
        Else
            bolShift = False
        End If
        bolControl = False
        UpdateShiftControl()
    End Sub

    Private Sub btnKeyZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyZ.Click
        Select Case bolShift
            Case True
                strKeyInput = "Z"
            Case False
                strKeyInput = "z"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyX.Click
        Select Case bolControl
            Case True
                strKeyInput = "CUT"
            Case False
                Select Case bolShift
                    Case True
                        strKeyInput = "X"
                    Case False
                        strKeyInput = "x"
                End Select
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyC.Click
        Select Case bolControl
            Case True
                strKeyInput = "COPY"
            Case False
                Select Case bolShift
                    Case True
                        strKeyInput = "C"
                    Case False
                        strKeyInput = "c"
                End Select
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyV.Click
        Select Case bolControl
            Case True
                strKeyInput = "PASTE"
            Case False
                Select Case bolShift
                    Case True
                        strKeyInput = "V"
                    Case False
                        strKeyInput = "v"
                End Select
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyB.Click
        Select Case bolShift
            Case True
                strKeyInput = "B"
            Case False
                strKeyInput = "b"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyN.Click
        Select Case bolShift
            Case True
                strKeyInput = "N"
            Case False
                strKeyInput = "n"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyM.Click
        Select Case bolShift
            Case True
                strKeyInput = "M"
            Case False
                strKeyInput = "m"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyComma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyComma.Click
        Select Case bolShift
            Case True
                strKeyInput = "<"
            Case False
                strKeyInput = ","
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyPeriod.Click
        Select Case bolShift
            Case True
                strKeyInput = ">"
            Case False
                strKeyInput = "."
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyRSlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyRSlash.Click
        Select Case bolShift
            Case True
                strKeyInput = "?"
            Case False
                strKeyInput = "/"
        End Select

        SendInput()
    End Sub

    Private Sub btnKeyControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyControl.Click
        If bolControl = False Then
            bolControl = True
        Else
            bolControl = False
        End If
        bolShift = False
        UpdateShiftControl()
    End Sub

    Private Sub btnKeySpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeySpace.Click
        strKeyInput = " "
        bolControl = False
        bolShift = False
        SendInput()
    End Sub

    Private Sub btnKeyClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyClear.Click
        strKeyInput = "CLEAR"
        bolControl = False
        bolShift = False
        SendInput()
    End Sub

    Private Sub lblKeyDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeyDot.Click
        btnKeyPeriod.PerformClick()
    End Sub
    Private Sub lblKeyRSlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeyRSlash.Click
        btnKeyRSlash.PerformClick()
    End Sub

    Private Sub lblKeyComma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeyComma.Click
        btnKeyComma.PerformClick()
    End Sub

    Private Sub lblCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCut.Click
        btnKeyX.PerformClick()
    End Sub

    Private Sub lblCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCopy.Click
        btnKeyC.PerformClick()
    End Sub

    Private Sub lblPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPaste.Click
        btnKeyV.PerformClick()
    End Sub

    Private Sub lblKey1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey1.Click
        btnKey1.PerformClick()
    End Sub

    Private Sub lblKey2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey2.Click
        btnKey2.PerformClick()
    End Sub

    Private Sub lblKeyApostrophe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeyApostrophe.Click
        btnKeyAt.PerformClick()
    End Sub

    Private Sub lblKeyDash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKeyDash.Click
        btnKeyMinus.PerformClick()
    End Sub

    Private Sub lblKey0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey0.Click
        btnKey0.PerformClick()
    End Sub

    Private Sub lblKey9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey9.Click
        btnKey9.PerformClick()
    End Sub

    Private Sub lblKey8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey8.Click
        btnKey8.PerformClick()
    End Sub

    Private Sub lblKey7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey7.Click
        btnKey7.PerformClick()
    End Sub

    Private Sub lblKey6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey6.Click
        btnKey6.PerformClick()
    End Sub

    Private Sub lblKey5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey5.Click
        btnKey5.PerformClick()
    End Sub

    Private Sub lblKey4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey4.Click
        btnKey4.PerformClick()
    End Sub

    Private Sub lblKey3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKey3.Click
        btnKey3.PerformClick()
    End Sub

    Private Sub SendInput()
        'A sub to send the keyboard input to the current form

        Select Case intCurrentForm
            Case 1 'The login screen
                Login.ProcessInput(strKeyInput)
            Case 3 'The admin override login is accessed from the sign in form
                AdminOverride.ProcessInput(strKeyInput)
            Case 5 'The add family screen
                AddFamily.ProcessInput(strKeyInput)
            Case 7 'The add member screen
                AddMember.ProcessInput(strKeyInput)
            Case 11 'The admin lock screen is accessed from the admin sign in form
                AdminOverride.ProcessInput(strKeyInput)
            Case 14 'The family search screen
                FamilySearchPref.ProcessInput(strKeyInput)
            Case 15 'The edit family screen
                AdminEditFamily.ProcessInput(strKeyInput)
            Case 16 'The family notes screen
                FamilyNotes.ProcessInput(strKeyInput)
            Case 17 'The member medical details screen
                MedicalDetails.ProcessInput(strKeyInput)
            Case 19 'Add/edit event screen
                AddEditEvent.ProcessInput(strKeyInput)
            Case 22 'Add/edit login screen
                EditLogin.ProcessInput(strKeyInput)
        End Select

        strKeyInput = Nothing

        bolShift = False
        bolControl = False

        UpdateShiftControl()
    End Sub
    Private Sub UpdateShiftControl()
        'A sub to update the colours of the shift and control buttons
        If bolShift = True Then
            btnKeyShift.BackColor = Color.FromArgb(31, 73, 125)
        Else
            btnKeyShift.BackColor = Color.FromArgb(79, 129, 189)
        End If


        If bolControl = True Then
            btnKeyControl.BackColor = Color.FromArgb(31, 73, 125)
        Else
            btnKeyControl.BackColor = Color.FromArgb(79, 129, 189)
        End If

    End Sub

    Private Sub Keyboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'When the keyboard starts, select the first field text can be entered in
        intSelectedTxtBox = 1
    End Sub
End Class