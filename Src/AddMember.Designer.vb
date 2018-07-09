<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
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
        Me.btnShowKeyboard = New System.Windows.Forms.Button
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.lblFamPhoto = New System.Windows.Forms.Label
        Me.lblChange = New System.Windows.Forms.Label
        Me.picPersonPhoto = New System.Windows.Forms.PictureBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.radFemale = New System.Windows.Forms.RadioButton
        Me.radMale = New System.Windows.Forms.RadioButton
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.btnMedical = New System.Windows.Forms.Button
        Me.lblDOB = New System.Windows.Forms.Label
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.txtMonth = New System.Windows.Forms.TextBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.lblCRB = New System.Windows.Forms.Label
        Me.picTick = New System.Windows.Forms.PictureBox
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogsTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPersonPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowKeyboard
        '
        Me.btnShowKeyboard.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnShowKeyboard.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowKeyboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShowKeyboard.Location = New System.Drawing.Point(12, 645)
        Me.btnShowKeyboard.Name = "btnShowKeyboard"
        Me.btnShowKeyboard.Size = New System.Drawing.Size(240, 111)
        Me.btnShowKeyboard.TabIndex = 15
        Me.btnShowKeyboard.Text = "Show keyboard"
        Me.btnShowKeyboard.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 14
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Add/Edit Member"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(864, 146)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(148, 59)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOk.Location = New System.Drawing.Point(864, 217)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(148, 59)
        Me.btnOk.TabIndex = 29
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblFamPhoto
        '
        Me.lblFamPhoto.AutoSize = True
        Me.lblFamPhoto.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamPhoto.Location = New System.Drawing.Point(712, 132)
        Me.lblFamPhoto.Name = "lblFamPhoto"
        Me.lblFamPhoto.Size = New System.Drawing.Size(98, 39)
        Me.lblFamPhoto.TabIndex = 37
        Me.lblFamPhoto.Text = "Photo"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(700, 281)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(104, 16)
        Me.lblChange.TabIndex = 39
        Me.lblChange.Text = "(Click to change)"
        '
        'picPersonPhoto
        '
        Me.picPersonPhoto.Location = New System.Drawing.Point(703, 170)
        Me.picPersonPhoto.Name = "picPersonPhoto"
        Me.picPersonPhoto.Size = New System.Drawing.Size(140, 105)
        Me.picPersonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPersonPhoto.TabIndex = 38
        Me.picPersonPhoto.TabStop = False
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(169, 207)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtSurname.MaxLength = 25
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(370, 43)
        Me.txtSurname.TabIndex = 46
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(6, 210)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(137, 35)
        Me.lblSurname.TabIndex = 41
        Me.lblSurname.Text = "Surname:"
        '
        'radFemale
        '
        Me.radFemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.radFemale.FlatAppearance.BorderSize = 2
        Me.radFemale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.radFemale.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(551, 216)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(123, 41)
        Me.radFemale.TabIndex = 53
        Me.radFemale.Text = "Female"
        Me.radFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radFemale.UseVisualStyleBackColor = False
        '
        'radMale
        '
        Me.radMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.radMale.Checked = True
        Me.radMale.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.radMale.FlatAppearance.BorderSize = 2
        Me.radMale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.radMale.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(551, 169)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(123, 41)
        Me.radMale.TabIndex = 52
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radMale.UseVisualStyleBackColor = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(545, 131)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(120, 39)
        Me.lblGender.TabIndex = 43
        Me.lblGender.Text = "Gender"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 159)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 35)
        Me.lblName.TabIndex = 44
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 160)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtName.MaxLength = 25
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(424, 43)
        Me.txtName.TabIndex = 45
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 257)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(94, 35)
        Me.lblEmail.TabIndex = 47
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(133, 253)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(406, 43)
        Me.txtEmail.TabIndex = 47
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(6, 304)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(108, 35)
        Me.lblPhone.TabIndex = 49
        Me.lblPhone.Text = "Mobile:"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(151, 300)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtMobile.MaxLength = 13
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(388, 43)
        Me.txtMobile.TabIndex = 48
        '
        'btnMedical
        '
        Me.btnMedical.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnMedical.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedical.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMedical.Location = New System.Drawing.Point(864, 286)
        Me.btnMedical.Name = "btnMedical"
        Me.btnMedical.Size = New System.Drawing.Size(148, 71)
        Me.btnMedical.TabIndex = 30
        Me.btnMedical.Text = "Medical Details"
        Me.btnMedical.UseVisualStyleBackColor = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(547, 314)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(83, 35)
        Me.lblDOB.TabIndex = 51
        Me.lblDOB.Text = "DOB:"
        '
        'txtDay
        '
        Me.txtDay.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(629, 311)
        Me.txtDay.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtDay.MaxLength = 2
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(54, 43)
        Me.txtDay.TabIndex = 49
        Me.txtDay.Text = "DD"
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(701, 311)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(51, 43)
        Me.txtMonth.TabIndex = 50
        Me.txtMonth.Text = "MM"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(769, 311)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(89, 43)
        Me.txtYear.TabIndex = 51
        Me.txtYear.Text = "YYYY"
        '
        'lblCRB
        '
        Me.lblCRB.AutoSize = True
        Me.lblCRB.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCRB.Location = New System.Drawing.Point(547, 271)
        Me.lblCRB.Name = "lblCRB"
        Me.lblCRB.Size = New System.Drawing.Size(77, 35)
        Me.lblCRB.TabIndex = 56
        Me.lblCRB.Text = "CRB:"
        '
        'picTick
        '
        Me.picTick.BackColor = System.Drawing.Color.White
        Me.picTick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTick.Location = New System.Drawing.Point(629, 266)
        Me.picTick.Name = "picTick"
        Me.picTick.Size = New System.Drawing.Size(51, 39)
        Me.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTick.TabIndex = 57
        Me.picTick.TabStop = False
        '
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataMember = "People"
        Me.PeopleBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'PeopleTableAdapter
        '
        Me.PeopleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventsTableAdapter = Nothing
        Me.TableAdapterManager.FamiliesTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.LogsTableAdapter = Nothing
        Me.TableAdapterManager.People_TeamsTableAdapter = Nothing
        Me.TableAdapterManager.PeopleTableAdapter = Me.PeopleTableAdapter
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.Rules_EventsTableAdapter = Nothing
        Me.TableAdapterManager.RulesTableAdapter = Nothing
        Me.TableAdapterManager.Teams_EventsTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "CRB"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "CRB"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Guardian"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Guardian"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Family_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Family_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Photo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Photo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mobile_Num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mobile_Num"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Person_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Person_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.AutoGenerateColumns = False
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn10})
        Me.PeopleDataGridView.DataSource = Me.PeopleBindingSource
        Me.PeopleDataGridView.Location = New System.Drawing.Point(977, 743)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.ReadOnly = True
        Me.PeopleDataGridView.Size = New System.Drawing.Size(45, 23)
        Me.PeopleDataGridView.TabIndex = 55
        Me.PeopleDataGridView.TabStop = False
        Me.PeopleDataGridView.Visible = False
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
        Me.LogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.LogsDataGridView.DataSource = Me.LogsBindingSource
        Me.LogsDataGridView.Location = New System.Drawing.Point(928, 739)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(43, 27)
        Me.LogsDataGridView.TabIndex = 57
        Me.LogsDataGridView.TabStop = False
        Me.LogsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Log_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Log_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Log_Type"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Log_Type"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Date_Logged"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date_Logged"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Time_Logged"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Time_Logged"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.picTick)
        Me.Controls.Add(Me.lblCRB)
        Me.Controls.Add(Me.PeopleDataGridView)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.btnMedical)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.picPersonPhoto)
        Me.Controls.Add(Me.lblFamPhoto)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnShowKeyboard)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMember"
        Me.Text = "AddMember"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPersonPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowKeyboard As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblFamPhoto As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents picPersonPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents btnMedical As System.Windows.Forms.Button
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents lblCRB As System.Windows.Forms.Label
    Friend WithEvents picTick As System.Windows.Forms.PictureBox
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogsTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
    Friend WithEvents LogsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
