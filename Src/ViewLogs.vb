Public Class ViewLogs
    Dim intCurrentPage As Integer = 1
    Dim intMaxPages As Integer = 1
    Dim intDir As Integer = 1
    Dim intNumLogs As Integer
    Dim intSelectedID As Integer
    Dim strLogDetails(99999, 3) As String
    Dim datSelectedDate As Date
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        GoToForm(Me, EditSettings)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ShowHelp(1)
    End Sub

    Private Sub btnMoreDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreDetails.Click
        intCurrentLog = intSelectedID
        GoToForm(Me, LogDetails)
    End Sub

    Private Sub ViewLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpenAttendDataSet.Logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.OpenAttendDataSet.Logs)

        intCurrentForm = 23
        InitForm(Me, picLogo)

        picRow1.ImageLocation = strPicturePath & "Row.bmp"
        picRow2.ImageLocation = strPicturePath & "Row.bmp"
        picRow3.ImageLocation = strPicturePath & "Row.bmp"
        picRow4.ImageLocation = strPicturePath & "Row.bmp"

        datSelectedDate = calMonth.SelectionRange.Start()

        intCurrentLog = 0
        lstLogType.SelectedIndex = 0

        InitPages()
    End Sub
    Private Sub InitPages()
        'A sub to initialize the pages and family members
        intNumLogs = 0
        intCurrentPage = 1

        ClearRows()

        LogsBindingSource.MoveFirst()
        For i = 0 To LogsBindingSource.Count - 1
            If UCase(LogsDataGridView.CurrentRow.Cells(1).Value) <> "DELETED" Then
                If DateDiff(DateInterval.Day, LogsDataGridView.CurrentRow.Cells(4).Value, datSelectedDate) = 0 Then
                    'If the Log takes place today (0 days between the Log and the selected date)
                    If lstLogType.SelectedIndex = 0 Or LogsDataGridView.CurrentRow.Cells(1).Value = lstLogType.SelectedItem Then
                        'If the log is of the selected type (or all)
                        intNumLogs += 1
                        strLogDetails(intNumLogs, 1) = Str(LogsDataGridView.CurrentRow.Cells(0).Value)
                        strLogDetails(intNumLogs, 2) = Format(LogsDataGridView.CurrentRow.Cells(5).Value, "HH:mm")
                        strLogDetails(intNumLogs, 3) = LogsDataGridView.CurrentRow.Cells(1).Value
                    End If
                    
                End If
            End If

            LogsBindingSource.MoveNext()
        Next

        If intNumLogs > 0 Then
            intMaxPages = Math.Ceiling(intNumLogs / 4)

            picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

            If intMaxPages > 1 Then
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
            Else
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
            End If

            UpdateLogs()
            SelectRow(1)
        Else
            For i = 1 To 99999
                strLogDetails(i, 1) = Nothing
                strLogDetails(i, 2) = Nothing
                strLogDetails(i, 3) = Nothing
            Next
        End If

    End Sub

    Private Sub ClearRows()
        lblLog1.ForeColor = Color.White
        lblLog2.ForeColor = Color.White
        lblLog3.ForeColor = Color.White
        lblLog4.ForeColor = Color.White

        lblLog1.Text = "N/A"
        lblLog2.Text = "N/A"
        lblLog3.Text = "N/A"
        lblLog4.Text = "N/A"

    End Sub

    Private Sub SelectRow(ByVal intRow As Integer)
        'A sub to select the current Log for editing
        Dim intLog As Integer
        intLog = ((intCurrentPage - 1) * 4) + intRow

        lblLog1.ForeColor = Color.White
        lblLog2.ForeColor = Color.White
        lblLog3.ForeColor = Color.White
        lblLog4.ForeColor = Color.White

        intSelectedID = strLogDetails(intLog, 1)

        Select Case intRow
            Case 1
                lblLog1.ForeColor = Color.Yellow
            Case 2
                lblLog2.ForeColor = Color.Yellow
            Case 3
                lblLog3.ForeColor = Color.Yellow
            Case 4
                lblLog4.ForeColor = Color.Yellow
        End Select

    End Sub
    Private Sub UpdateLogs()
        'Update the Logs today
        Dim intLogsLeft As Integer
        Dim intStartLog As Integer

        ClearRows()

        If intNumLogs > 0 Then
            If intMaxPages - intCurrentPage > 0 Then
                intStartLog = ((intCurrentPage - 1) * 4) + 1

                lblLog1.Text = strLogDetails(intStartLog, 2) & " - " & strLogDetails(intStartLog, 3)
                lblLog2.Text = strLogDetails(intStartLog + 1, 2) & " - " & strLogDetails(intStartLog + 1, 3)
                lblLog3.Text = strLogDetails(intStartLog + 2, 2) & " - " & strLogDetails(intStartLog + 2, 3)
                lblLog4.Text = strLogDetails(intStartLog + 3, 2) & " - " & strLogDetails(intStartLog + 3, 3)

            ElseIf (intNumLogs Mod 4) > 0 Then
                intLogsLeft = intNumLogs Mod 4
                intStartLog = ((intCurrentPage - 1) * 4) + 1

                lblLog1.Text = strLogDetails(intStartLog, 2) & " - " & strLogDetails(intStartLog, 3)

                Select Case intLogsLeft
                    Case 4
                        lblLog2.Text = strLogDetails(intStartLog + 1, 2) & " - " & strLogDetails(intStartLog + 1, 3)
                        lblLog3.Text = strLogDetails(intStartLog + 2, 2) & " - " & strLogDetails(intStartLog + 2, 3)
                        lblLog4.Text = strLogDetails(intStartLog + 3, 2) & " - " & strLogDetails(intStartLog + 3, 3)
                    Case 3
                        lblLog2.Text = strLogDetails(intStartLog + 1, 2) & " - " & strLogDetails(intStartLog + 1, 3)
                        lblLog3.Text = strLogDetails(intStartLog + 2, 2) & " - " & strLogDetails(intStartLog + 2, 3)
                        lblLog4.Text = "N/A"
                    Case 2
                        lblLog2.Text = strLogDetails(intStartLog + 1, 2) & " - " & strLogDetails(intStartLog + 1, 3)
                        lblLog3.Text = "N/A"
                        lblLog4.Text = "N/A"
                    Case Else
                        lblLog2.Text = "N/A"
                        lblLog3.Text = "N/A"
                        lblLog4.Text = "N/A"
                End Select
            Else 'Four Logs today
                intStartLog = ((intCurrentPage - 1) * 4) + 1

                lblLog1.Text = strLogDetails(intStartLog, 2) & " - " & strLogDetails(intStartLog, 3)
                lblLog2.Text = strLogDetails(intStartLog + 1, 2) & " - " & strLogDetails(intStartLog + 1, 3)
                lblLog3.Text = strLogDetails(intStartLog + 2, 2) & " - " & strLogDetails(intStartLog + 2, 3)
                lblLog4.Text = strLogDetails(intStartLog + 3, 2) & " - " & strLogDetails(intStartLog + 3, 3)
            End If
        End If
    End Sub
    Private Sub UpdateButtons()
        'The code to change the image of each button
        Select Case intCurrentPage
            Case 1
                picButUp.ImageLocation = strPicturePath & "UBMax.bmp"

                If intMaxPages > 1 Then
                    picButDown.ImageLocation = strPicturePath & "DownButton.bmp"
                Else
                    picButDown.ImageLocation = strPicturePath & "DBMax.bmp"
                End If

            Case intMaxPages

                picButUp.ImageLocation = strPicturePath & "UpButton.bmp"
                picButDown.ImageLocation = strPicturePath & "DBMax.bmp"

            Case Else

                picButUp.ImageLocation = strPicturePath & "UpButton.bmp"
                picButDown.ImageLocation = strPicturePath & "DownButton.bmp"

        End Select
    End Sub
    Private Sub ChangePage()
        'A sub to change the current page
        Select Case intDir
            Case 1

                intCurrentPage += 1
                If intCurrentPage > intMaxPages Then intCurrentPage = intMaxPages

            Case -1

                intCurrentPage -= 1
                If intCurrentPage < 1 Then intCurrentPage = 1

        End Select

        UpdateLogs()

        intSelectedID = 0
        SelectRow(1)

        lblPageNum.Text = "Page" & vbNewLine & intCurrentPage
    End Sub

    Private Sub picButUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picButUp.Click
        intDir = -1
        ChangePage()
        UpdateButtons()
    End Sub

    Private Sub picButDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picButDown.Click
        intDir = 1
        ChangePage()
        UpdateButtons()
    End Sub
    Private Sub calMonth_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calMonth.DateChanged
        datSelectedDate = calMonth.SelectionRange.Start()
        InitPages()
    End Sub

    Private Sub lstLogType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLogType.SelectedIndexChanged
        InitPages()
    End Sub

    Private Sub lblLog1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog1.Click
        If lblLog1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub

    Private Sub lblLog2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog2.Click
        If lblLog2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub lblLog3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog3.Click
        If lblLog3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub lblLog4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog4.Click
        If lblLog4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow4.Click
        If lblLog4.Text <> "N/A" Then
            SelectRow(4)
        End If
    End Sub

    Private Sub picRow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow3.Click
        If lblLog3.Text <> "N/A" Then
            SelectRow(3)
        End If
    End Sub

    Private Sub picRow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow2.Click
        If lblLog2.Text <> "N/A" Then
            SelectRow(2)
        End If
    End Sub

    Private Sub picRow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRow1.Click
        If lblLog1.Text <> "N/A" Then
            SelectRow(1)
        End If
    End Sub
End Class