<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLogs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLogs))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.picButUp = New System.Windows.Forms.PictureBox
        Me.lblLog4 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.lblLog3 = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.lblLog2 = New System.Windows.Forms.Label
        Me.lblLog1 = New System.Windows.Forms.Label
        Me.btnMoreDetails = New System.Windows.Forms.Button
        Me.picButDown = New System.Windows.Forms.PictureBox
        Me.lblPageNum = New System.Windows.Forms.Label
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.picRow4 = New System.Windows.Forms.PictureBox
        Me.picRow3 = New System.Windows.Forms.PictureBox
        Me.picRow2 = New System.Windows.Forms.PictureBox
        Me.picRow1 = New System.Windows.Forms.PictureBox
        Me.calMonth = New System.Windows.Forms.MonthCalendar
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogsTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblLogType = New System.Windows.Forms.Label
        Me.lstLogType = New System.Windows.Forms.ComboBox
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 88
        Me.lblTitle.Text = "View Logs"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 87
        Me.picLogo.TabStop = False
        '
        'picButUp
        '
        Me.picButUp.Image = CType(resources.GetObject("picButUp.Image"), System.Drawing.Image)
        Me.picButUp.Location = New System.Drawing.Point(757, 154)
        Me.picButUp.Name = "picButUp"
        Me.picButUp.Size = New System.Drawing.Size(101, 83)
        Me.picButUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButUp.TabIndex = 89
        Me.picButUp.TabStop = False
        '
        'lblLog4
        '
        Me.lblLog4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLog4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog4.ForeColor = System.Drawing.Color.White
        Me.lblLog4.Location = New System.Drawing.Point(16, 374)
        Me.lblLog4.Name = "lblLog4"
        Me.lblLog4.Size = New System.Drawing.Size(348, 73)
        Me.lblLog4.TabIndex = 11
        Me.lblLog4.Text = "N/A"
        Me.lblLog4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(864, 663)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(148, 93)
        Me.btnBack.TabIndex = 97
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblLog3
        '
        Me.lblLog3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLog3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog3.ForeColor = System.Drawing.Color.White
        Me.lblLog3.Location = New System.Drawing.Point(16, 258)
        Me.lblLog3.Name = "lblLog3"
        Me.lblLog3.Size = New System.Drawing.Size(348, 73)
        Me.lblLog3.TabIndex = 10
        Me.lblLog3.Text = "N/A"
        Me.lblLog3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(864, 564)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(148, 93)
        Me.btnHelp.TabIndex = 96
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblLog2
        '
        Me.lblLog2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLog2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog2.ForeColor = System.Drawing.Color.White
        Me.lblLog2.Location = New System.Drawing.Point(16, 144)
        Me.lblLog2.Name = "lblLog2"
        Me.lblLog2.Size = New System.Drawing.Size(348, 73)
        Me.lblLog2.TabIndex = 9
        Me.lblLog2.Text = "N/A"
        Me.lblLog2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLog1
        '
        Me.lblLog1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLog1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog1.ForeColor = System.Drawing.Color.White
        Me.lblLog1.Location = New System.Drawing.Point(16, 27)
        Me.lblLog1.Name = "lblLog1"
        Me.lblLog1.Size = New System.Drawing.Size(348, 73)
        Me.lblLog1.TabIndex = 8
        Me.lblLog1.Text = "N/A"
        Me.lblLog1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnMoreDetails.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMoreDetails.Location = New System.Drawing.Point(864, 189)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(148, 119)
        Me.btnMoreDetails.TabIndex = 93
        Me.btnMoreDetails.Text = "More Details"
        Me.btnMoreDetails.UseVisualStyleBackColor = False
        '
        'picButDown
        '
        Me.picButDown.Image = CType(resources.GetObject("picButDown.Image"), System.Drawing.Image)
        Me.picButDown.Location = New System.Drawing.Point(757, 614)
        Me.picButDown.Name = "picButDown"
        Me.picButDown.Size = New System.Drawing.Size(101, 83)
        Me.picButDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButDown.TabIndex = 90
        Me.picButDown.TabStop = False
        '
        'lblPageNum
        '
        Me.lblPageNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPageNum.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPageNum.Location = New System.Drawing.Point(757, 229)
        Me.lblPageNum.Name = "lblPageNum"
        Me.lblPageNum.Size = New System.Drawing.Size(101, 391)
        Me.lblPageNum.TabIndex = 91
        Me.lblPageNum.Text = "Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.lblLog4)
        Me.grpMembers.Controls.Add(Me.lblLog3)
        Me.grpMembers.Controls.Add(Me.lblLog2)
        Me.grpMembers.Controls.Add(Me.lblLog1)
        Me.grpMembers.Controls.Add(Me.picRow4)
        Me.grpMembers.Controls.Add(Me.picRow3)
        Me.grpMembers.Controls.Add(Me.picRow2)
        Me.grpMembers.Controls.Add(Me.picRow1)
        Me.grpMembers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMembers.Location = New System.Drawing.Point(373, 189)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(384, 473)
        Me.grpMembers.TabIndex = 92
        Me.grpMembers.TabStop = False
        '
        'picRow4
        '
        Me.picRow4.ImageLocation = ""
        Me.picRow4.Location = New System.Drawing.Point(7, 357)
        Me.picRow4.Name = "picRow4"
        Me.picRow4.Size = New System.Drawing.Size(370, 108)
        Me.picRow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow4.TabIndex = 3
        Me.picRow4.TabStop = False
        '
        'picRow3
        '
        Me.picRow3.ImageLocation = ""
        Me.picRow3.Location = New System.Drawing.Point(7, 241)
        Me.picRow3.Name = "picRow3"
        Me.picRow3.Size = New System.Drawing.Size(370, 108)
        Me.picRow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow3.TabIndex = 2
        Me.picRow3.TabStop = False
        '
        'picRow2
        '
        Me.picRow2.ImageLocation = ""
        Me.picRow2.Location = New System.Drawing.Point(7, 126)
        Me.picRow2.Name = "picRow2"
        Me.picRow2.Size = New System.Drawing.Size(370, 108)
        Me.picRow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow2.TabIndex = 1
        Me.picRow2.TabStop = False
        '
        'picRow1
        '
        Me.picRow1.ImageLocation = ""
        Me.picRow1.Location = New System.Drawing.Point(7, 11)
        Me.picRow1.Name = "picRow1"
        Me.picRow1.Size = New System.Drawing.Size(370, 108)
        Me.picRow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow1.TabIndex = 0
        Me.picRow1.TabStop = False
        '
        'calMonth
        '
        Me.calMonth.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calMonth.Location = New System.Drawing.Point(18, 189)
        Me.calMonth.MaxSelectionCount = 1
        Me.calMonth.Name = "calMonth"
        Me.calMonth.TabIndex = 98
        '
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogsBindingSource
        '
        Me.LogsBindingSource.DataMember = "Logs"
        Me.LogsBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'LogsTableAdapter
        '
        Me.LogsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventsTableAdapter = Nothing
        Me.TableAdapterManager.FamiliesTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.LogsTableAdapter = Me.LogsTableAdapter
        Me.TableAdapterManager.People_TeamsTableAdapter = Nothing
        Me.TableAdapterManager.PeopleTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.Rules_EventsTableAdapter = Nothing
        Me.TableAdapterManager.RulesTableAdapter = Nothing
        Me.TableAdapterManager.Teams_EventsTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LogsDataGridView
        '
        Me.LogsDataGridView.AutoGenerateColumns = False
        Me.LogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.LogsDataGridView.DataSource = Me.LogsBindingSource
        Me.LogsDataGridView.Location = New System.Drawing.Point(18, 732)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(43, 24)
        Me.LogsDataGridView.TabIndex = 99
        Me.LogsDataGridView.TabStop = False
        Me.LogsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Log_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Log_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Log_Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Log_Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date_Logged"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date_Logged"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Time_Logged"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Time_Logged"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'lblLogType
        '
        Me.lblLogType.AutoSize = True
        Me.lblLogType.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogType.Location = New System.Drawing.Point(12, 490)
        Me.lblLogType.Name = "lblLogType"
        Me.lblLogType.Size = New System.Drawing.Size(175, 30)
        Me.lblLogType.TabIndex = 101
        Me.lblLogType.Text = "Log Type:"
        '
        'lstLogType
        '
        Me.lstLogType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstLogType.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogType.FormattingEnabled = True
        Me.lstLogType.Items.AddRange(New Object() {"All", "Login", "Logout", "SignIn", "SignOut", "FamCreate", "FamEdit", "FamDelete", "MemCreate", "MemEdit", "MemDelete", "EventCreate", "EventDelete", "EventEdit", "LoginCreate", "LoginDelete", "LoginEdit"})
        Me.lstLogType.Location = New System.Drawing.Point(18, 523)
        Me.lstLogType.Name = "lstLogType"
        Me.lstLogType.Size = New System.Drawing.Size(346, 38)
        Me.lstLogType.TabIndex = 100
        '
        'ViewLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblLogType)
        Me.Controls.Add(Me.lstLogType)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.picButUp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMoreDetails)
        Me.Controls.Add(Me.picButDown)
        Me.Controls.Add(Me.lblPageNum)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.calMonth)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewLogs"
        Me.Text = "ViewLogs"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picButUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblLog4 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblLog3 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblLog2 As System.Windows.Forms.Label
    Friend WithEvents lblLog1 As System.Windows.Forms.Label
    Friend WithEvents btnMoreDetails As System.Windows.Forms.Button
    Friend WithEvents picButDown As System.Windows.Forms.PictureBox
    Friend WithEvents lblPageNum As System.Windows.Forms.Label
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents picRow4 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow1 As System.Windows.Forms.PictureBox
    Friend WithEvents calMonth As System.Windows.Forms.MonthCalendar
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents LogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogsTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LogsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLogType As System.Windows.Forms.Label
    Friend WithEvents lstLogType As System.Windows.Forms.ComboBox
End Class
