<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLogins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditLogins))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.picButDown = New System.Windows.Forms.PictureBox
        Me.picButUp = New System.Windows.Forms.PictureBox
        Me.lblPageNum = New System.Windows.Forms.Label
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.lblLogin4 = New System.Windows.Forms.Label
        Me.lblLogin3 = New System.Windows.Forms.Label
        Me.lblLogin2 = New System.Windows.Forms.Label
        Me.lblLogin1 = New System.Windows.Forms.Label
        Me.picRow4 = New System.Windows.Forms.PictureBox
        Me.picRow3 = New System.Windows.Forms.PictureBox
        Me.picRow2 = New System.Windows.Forms.PictureBox
        Me.picRow1 = New System.Windows.Forms.PictureBox
        Me.btnHelp = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnAddLogin = New System.Windows.Forms.Button
        Me.btnRemoveLogin = New System.Windows.Forms.Button
        Me.btnEditLogin = New System.Windows.Forms.Button
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LoginTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.LoginDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogsTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 84
        Me.lblTitle.Text = "View Logins"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 83
        Me.picLogo.TabStop = False
        '
        'picButDown
        '
        Me.picButDown.Image = CType(resources.GetObject("picButDown.Image"), System.Drawing.Image)
        Me.picButDown.Location = New System.Drawing.Point(692, 611)
        Me.picButDown.Name = "picButDown"
        Me.picButDown.Size = New System.Drawing.Size(101, 83)
        Me.picButDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButDown.TabIndex = 86
        Me.picButDown.TabStop = False
        '
        'picButUp
        '
        Me.picButUp.Image = CType(resources.GetObject("picButUp.Image"), System.Drawing.Image)
        Me.picButUp.Location = New System.Drawing.Point(692, 214)
        Me.picButUp.Name = "picButUp"
        Me.picButUp.Size = New System.Drawing.Size(101, 83)
        Me.picButUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButUp.TabIndex = 85
        Me.picButUp.TabStop = False
        '
        'lblPageNum
        '
        Me.lblPageNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPageNum.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPageNum.Location = New System.Drawing.Point(692, 290)
        Me.lblPageNum.Name = "lblPageNum"
        Me.lblPageNum.Size = New System.Drawing.Size(101, 328)
        Me.lblPageNum.TabIndex = 87
        Me.lblPageNum.Text = "Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.lblLogin4)
        Me.grpMembers.Controls.Add(Me.lblLogin3)
        Me.grpMembers.Controls.Add(Me.lblLogin2)
        Me.grpMembers.Controls.Add(Me.lblLogin1)
        Me.grpMembers.Controls.Add(Me.picRow4)
        Me.grpMembers.Controls.Add(Me.picRow3)
        Me.grpMembers.Controls.Add(Me.picRow2)
        Me.grpMembers.Controls.Add(Me.picRow1)
        Me.grpMembers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMembers.Location = New System.Drawing.Point(45, 248)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(647, 411)
        Me.grpMembers.TabIndex = 88
        Me.grpMembers.TabStop = False
        '
        'lblLogin4
        '
        Me.lblLogin4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLogin4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin4.ForeColor = System.Drawing.Color.White
        Me.lblLogin4.Location = New System.Drawing.Point(15, 329)
        Me.lblLogin4.Name = "lblLogin4"
        Me.lblLogin4.Size = New System.Drawing.Size(613, 57)
        Me.lblLogin4.TabIndex = 11
        Me.lblLogin4.Text = "N/A"
        Me.lblLogin4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogin3
        '
        Me.lblLogin3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLogin3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin3.ForeColor = System.Drawing.Color.White
        Me.lblLogin3.Location = New System.Drawing.Point(20, 231)
        Me.lblLogin3.Name = "lblLogin3"
        Me.lblLogin3.Size = New System.Drawing.Size(608, 57)
        Me.lblLogin3.TabIndex = 10
        Me.lblLogin3.Text = "N/A"
        Me.lblLogin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogin2
        '
        Me.lblLogin2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLogin2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin2.ForeColor = System.Drawing.Color.White
        Me.lblLogin2.Location = New System.Drawing.Point(20, 134)
        Me.lblLogin2.Name = "lblLogin2"
        Me.lblLogin2.Size = New System.Drawing.Size(608, 57)
        Me.lblLogin2.TabIndex = 9
        Me.lblLogin2.Text = "N/A"
        Me.lblLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogin1
        '
        Me.lblLogin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblLogin1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin1.ForeColor = System.Drawing.Color.White
        Me.lblLogin1.Location = New System.Drawing.Point(20, 34)
        Me.lblLogin1.Name = "lblLogin1"
        Me.lblLogin1.Size = New System.Drawing.Size(608, 57)
        Me.lblLogin1.TabIndex = 8
        Me.lblLogin1.Text = "N/A"
        Me.lblLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picRow4
        '
        Me.picRow4.ImageLocation = ""
        Me.picRow4.Location = New System.Drawing.Point(6, 312)
        Me.picRow4.Name = "picRow4"
        Me.picRow4.Size = New System.Drawing.Size(635, 92)
        Me.picRow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow4.TabIndex = 3
        Me.picRow4.TabStop = False
        '
        'picRow3
        '
        Me.picRow3.ImageLocation = ""
        Me.picRow3.Location = New System.Drawing.Point(6, 214)
        Me.picRow3.Name = "picRow3"
        Me.picRow3.Size = New System.Drawing.Size(635, 92)
        Me.picRow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow3.TabIndex = 2
        Me.picRow3.TabStop = False
        '
        'picRow2
        '
        Me.picRow2.ImageLocation = ""
        Me.picRow2.Location = New System.Drawing.Point(6, 116)
        Me.picRow2.Name = "picRow2"
        Me.picRow2.Size = New System.Drawing.Size(635, 92)
        Me.picRow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow2.TabIndex = 1
        Me.picRow2.TabStop = False
        '
        'picRow1
        '
        Me.picRow1.ImageLocation = ""
        Me.picRow1.Location = New System.Drawing.Point(6, 18)
        Me.picRow1.Name = "picRow1"
        Me.picRow1.Size = New System.Drawing.Size(635, 92)
        Me.picRow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRow1.TabIndex = 0
        Me.picRow1.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(808, 597)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(204, 75)
        Me.btnHelp.TabIndex = 90
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(808, 681)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(204, 75)
        Me.btnBack.TabIndex = 89
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddLogin
        '
        Me.btnAddLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddLogin.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddLogin.Location = New System.Drawing.Point(808, 214)
        Me.btnAddLogin.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnAddLogin.Name = "btnAddLogin"
        Me.btnAddLogin.Size = New System.Drawing.Size(204, 75)
        Me.btnAddLogin.TabIndex = 92
        Me.btnAddLogin.Text = "Add Login"
        Me.btnAddLogin.UseVisualStyleBackColor = False
        '
        'btnRemoveLogin
        '
        Me.btnRemoveLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRemoveLogin.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemoveLogin.Location = New System.Drawing.Point(808, 298)
        Me.btnRemoveLogin.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnRemoveLogin.Name = "btnRemoveLogin"
        Me.btnRemoveLogin.Size = New System.Drawing.Size(204, 75)
        Me.btnRemoveLogin.TabIndex = 91
        Me.btnRemoveLogin.Text = "Remove Login"
        Me.btnRemoveLogin.UseVisualStyleBackColor = False
        '
        'btnEditLogin
        '
        Me.btnEditLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEditLogin.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditLogin.Location = New System.Drawing.Point(808, 382)
        Me.btnEditLogin.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnEditLogin.Name = "btnEditLogin"
        Me.btnEditLogin.Size = New System.Drawing.Size(204, 75)
        Me.btnEditLogin.TabIndex = 93
        Me.btnEditLogin.Text = "Edit Login"
        Me.btnEditLogin.UseVisualStyleBackColor = False
        '
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventsTableAdapter = Nothing
        Me.TableAdapterManager.FamiliesTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.LogsTableAdapter = Nothing
        Me.TableAdapterManager.People_TeamsTableAdapter = Nothing
        Me.TableAdapterManager.PeopleTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.Rules_EventsTableAdapter = Nothing
        Me.TableAdapterManager.RulesTableAdapter = Nothing
        Me.TableAdapterManager.Teams_EventsTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginDataGridView
        '
        Me.LoginDataGridView.AutoGenerateColumns = False
        Me.LoginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LoginDataGridView.DataSource = Me.LoginBindingSource
        Me.LoginDataGridView.Location = New System.Drawing.Point(12, 734)
        Me.LoginDataGridView.Name = "LoginDataGridView"
        Me.LoginDataGridView.ReadOnly = True
        Me.LoginDataGridView.Size = New System.Drawing.Size(40, 22)
        Me.LoginDataGridView.TabIndex = 94
        Me.LoginDataGridView.TabStop = False
        Me.LoginDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Login_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Login_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "User_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "User_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Login_Level"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Login_Level"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        'LogsDataGridView
        '
        Me.LogsDataGridView.AutoGenerateColumns = False
        Me.LogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.LogsDataGridView.DataSource = Me.LogsBindingSource
        Me.LogsDataGridView.Location = New System.Drawing.Point(65, 734)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(45, 24)
        Me.LogsDataGridView.TabIndex = 94
        Me.LogsDataGridView.TabStop = False
        Me.LogsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Log_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Log_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Log_Type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Log_Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date_Logged"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date_Logged"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Time_Logged"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Time_Logged"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'EditLogins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.LoginDataGridView)
        Me.Controls.Add(Me.btnEditLogin)
        Me.Controls.Add(Me.btnAddLogin)
        Me.Controls.Add(Me.btnRemoveLogin)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picButDown)
        Me.Controls.Add(Me.picButUp)
        Me.Controls.Add(Me.lblPageNum)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditLogins"
        Me.Text = "EditLogins"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picButDown As System.Windows.Forms.PictureBox
    Friend WithEvents picButUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblPageNum As System.Windows.Forms.Label
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogin4 As System.Windows.Forms.Label
    Friend WithEvents lblLogin3 As System.Windows.Forms.Label
    Friend WithEvents lblLogin2 As System.Windows.Forms.Label
    Friend WithEvents lblLogin1 As System.Windows.Forms.Label
    Friend WithEvents picRow4 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddLogin As System.Windows.Forms.Button
    Friend WithEvents btnRemoveLogin As System.Windows.Forms.Button
    Friend WithEvents btnEditLogin As System.Windows.Forms.Button
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogsTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
    Friend WithEvents LogsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
