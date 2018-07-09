Module SharedFunctions
    'Many variables, subs, and functions used across the whole of the program
    Public strPicturePath As String = Application.StartupPath & "/Pictures/" 'Path to the local picture folder
    Public strHelpPath As String = Application.StartupPath & "/Help.chm" 'The path to the local help file
    Public strBadgePath As String = Application.StartupPath & "/Badges/" 'The path to the local badge folder
    Public strReportPath As String = Application.StartupPath & "/Reports/" 'The path to the local report folder
    Public strServer As String = "OpenAttend-Server" 'The server name
    Public strOrganisation As String = "OpenAttend" 'The organisation printed on family badges
    Public intExpireTime As Integer = 1 'The amount of years before a badge expires
    Public intMaxAge As Integer = 12 'The max age of youth members
    Public intMinAge As Integer = 2 'The minimum age of youth members
    Public bolAdminOverride As Boolean 'A global variable to state whether an admin is currently overriding the system
    Public bolLocked As Boolean 'A global variable to state whether the program is locked or not
    Public bolSelectedTeams(9999) As Boolean 'A global variable to check which teams have been selected for editing
    Public bolPhotoTaken As Boolean 'A global variable to check if a photo has been taken
    Public strTeamDetails(9999, 4) As String 'the TeamID, Team Name, Min Age and Max Age of selected teams
    Public intSignedIn(99999) As Integer 'The youth that are currently signed in
    Public strInvalidInOutMessage As String 'The message shown for why signing in and out is invalid
    Public intInOutMode As Integer 'The mode of validation for signing in and out (eg: 2 = signing in, 3 = signing out)
    Public intSelectedTxtBox As Integer 'A global variable to check which text box was last selected
    Public intCurrentForm As Integer 'A global variable to check which form is currently active
    Public intCurrentEvent As Integer 'A global veriable to store the currently selected event
    Public intCurrentLogin As Integer 'A global variable to store the currently selected login
    Public intCurrentLog As Integer 'A global variable to store the currently selected log
    Public intCurrentFamily As Integer 'A global variable to store the currently selected family ID
    Public intCurrentTeam As Integer 'A global variable to store the current team
    Public strFamilyName As String 'A global variable to store the family name
    Public intCurrentPerson As Integer 'A global variable to store the currently selected personal ID
    Public strCurrentUser As String 'A global variable to check which user is currently logged in
    Public strNonAdminUser As String 'A global variable to store the non-admin user logged in before an override
    Public strCurrentLevel As String 'A global variable to store what the current user level is
    Public strCurrentMode As String 'A global variable to store what the current terminal mode is
    Public datEventDate As Date 'A global variable to store the selected event date

    Public Function ScreenWidth() As String
        'A function to calculate the width of the screen
        Dim ScreenX As Integer = Screen.PrimaryScreen.Bounds.Width
        Return ScreenX
    End Function
    Public Function ScreenHeight() As String
        'A function to calculate the height of the screen
        Dim ScreenY As Integer = Screen.PrimaryScreen.Bounds.Height
        Return ScreenY
    End Function
    Public Function MaskText(ByVal strInput As String, ByVal strMask As String) As String
        'A function to mask text
        Dim strOutput As String = Nothing

        For i = 1 To strInput.Length
            strOutput += strMask
        Next

        Return strOutput
    End Function
    Public Function DeleteLast(ByVal strInput As String)
        'A function to delete the last character of a string
        Return Mid(strInput, 1, strInput.Length - 1)
    End Function
    Public Function GetTime(Optional ByVal AsDate As Integer = 0)
        'A function to return the current time
        Dim strTime As String

        strTime = Date.Now.TimeOfDay.ToString

        If AsDate = 0 Then
            Return strTime
        Else
            Return Date.Now.TimeOfDay
        End If
    End Function
    Public Sub InitKeyboard()
        'A sub to bring the keyboard up
        Keyboard.Show()
        SetKeyboardPosition()
        Keyboard.Focus()
    End Sub
    Public Sub InitForm(ByVal Form As Object, ByVal LogoObj As Object)
        'A sub to prepare and position a form
        Form.Top = 0
        Form.Left = 0

        intSelectedTxtBox = 0
        Keyboard.Close()
        LogoObj.ImageLocation = strPicturePath & "Logo.bmp"
    End Sub
    Public Sub GoToForm(ByVal OldForm As Object, ByVal NewForm As Object)
        'A sub to load a new form and close the old one
        NewForm.Show()
        OldForm.Close()
    End Sub
    Public Sub ShowHelp(ByVal TopicNo As Integer)
        'A sub to show help for a given topic number
        Help.ShowHelp(Form.ActiveForm, strHelpPath, HelpNavigator.TopicId, Str(TopicNo))
        Keyboard.Close()
    End Sub
    Private Sub SetKeyboardPosition()
        'A function to position the keyboard form in the right spot
        Keyboard.Top = 768 - Keyboard.Height
        Keyboard.Left = 0
    End Sub
End Module
