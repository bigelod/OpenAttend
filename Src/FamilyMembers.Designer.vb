<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamilyMembers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FamilyMembers))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.picButUp = New System.Windows.Forms.PictureBox
        Me.picButDown = New System.Windows.Forms.PictureBox
        Me.lblPageNum = New System.Windows.Forms.Label
        Me.btnAdMember = New System.Windows.Forms.Button
        Me.btnRmMember = New System.Windows.Forms.Button
        Me.btnEdMember = New System.Windows.Forms.Button
        Me.btnContinue = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.lblPerson4 = New System.Windows.Forms.Label
        Me.lblPerson3 = New System.Windows.Forms.Label
        Me.lblPerson2 = New System.Windows.Forms.Label
        Me.lblPerson1 = New System.Windows.Forms.Label
        Me.picPerson4 = New System.Windows.Forms.PictureBox
        Me.picPerson3 = New System.Windows.Forms.PictureBox
        Me.picPerson2 = New System.Windows.Forms.PictureBox
        Me.picPerson1 = New System.Windows.Forms.PictureBox
        Me.picRow4 = New System.Windows.Forms.PictureBox
        Me.picRow3 = New System.Windows.Forms.PictureBox
        Me.picRow2 = New System.Windows.Forms.PictureBox
        Me.picRow1 = New System.Windows.Forms.PictureBox
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
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.picPerson4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Family Members"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
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
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PeopleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn10})
        Me.PeopleDataGridView.DataSource = Me.PeopleBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PeopleDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PeopleDataGridView.Location = New System.Drawing.Point(0, 749)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PeopleDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.PeopleDataGridView.Size = New System.Drawing.Size(32, 18)
        Me.PeopleDataGridView.TabIndex = 10
        Me.PeopleDataGridView.TabStop = False
        Me.PeopleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Person_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Person_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mobile_Num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mobile_Num"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Photo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Photo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Family_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Family_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Guardian"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Guardian"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "CRB"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "CRB"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'picButUp
        '
        Me.picButUp.Image = CType(resources.GetObject("picButUp.Image"), System.Drawing.Image)
        Me.picButUp.Location = New System.Drawing.Point(659, 156)
        Me.picButUp.Name = "picButUp"
        Me.picButUp.Size = New System.Drawing.Size(101, 83)
        Me.picButUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButUp.TabIndex = 37
        Me.picButUp.TabStop = False
        '
        'picButDown
        '
        Me.picButDown.Image = CType(resources.GetObject("picButDown.Image"), System.Drawing.Image)
        Me.picButDown.Location = New System.Drawing.Point(659, 553)
        Me.picButDown.Name = "picButDown"
        Me.picButDown.Size = New System.Drawing.Size(101, 83)
        Me.picButDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButDown.TabIndex = 38
        Me.picButDown.TabStop = False
        '
        'lblPageNum
        '
        Me.lblPageNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPageNum.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPageNum.Location = New System.Drawing.Point(659, 232)
        Me.lblPageNum.Name = "lblPageNum"
        Me.lblPageNum.Size = New System.Drawing.Size(101, 328)
        Me.lblPageNum.TabIndex = 39
        Me.lblPageNum.Text = "Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdMember
        '
        Me.btnAdMember.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdMember.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdMember.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdMember.Location = New System.Drawing.Point(772, 165)
        Me.btnAdMember.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnAdMember.Name = "btnAdMember"
        Me.btnAdMember.Size = New System.Drawing.Size(240, 111)
        Me.btnAdMember.TabIndex = 40
        Me.btnAdMember.Text = "Add Member"
        Me.btnAdMember.UseVisualStyleBackColor = False
        '
        'btnRmMember
        '
        Me.btnRmMember.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRmMember.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRmMember.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRmMember.Location = New System.Drawing.Point(772, 285)
        Me.btnRmMember.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnRmMember.Name = "btnRmMember"
        Me.btnRmMember.Size = New System.Drawing.Size(240, 111)
        Me.btnRmMember.TabIndex = 41
        Me.btnRmMember.Text = "Remove Member"
        Me.btnRmMember.UseVisualStyleBackColor = False
        '
        'btnEdMember
        '
        Me.btnEdMember.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEdMember.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdMember.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdMember.Location = New System.Drawing.Point(772, 405)
        Me.btnEdMember.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnEdMember.Name = "btnEdMember"
        Me.btnEdMember.Size = New System.Drawing.Size(240, 111)
        Me.btnEdMember.TabIndex = 42
        Me.btnEdMember.Text = "Edit Member"
        Me.btnEdMember.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnContinue.Location = New System.Drawing.Point(772, 642)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(240, 111)
        Me.btnContinue.TabIndex = 43
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(520, 642)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(240, 111)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(12, 642)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(240, 111)
        Me.btnHelp.TabIndex = 45
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.lblPerson4)
        Me.grpMembers.Controls.Add(Me.lblPerson3)
        Me.grpMembers.Controls.Add(Me.lblPerson2)
        Me.grpMembers.Controls.Add(Me.lblPerson1)
        Me.grpMembers.Controls.Add(Me.picPerson4)
        Me.grpMembers.Controls.Add(Me.picPerson3)
        Me.grpMembers.Controls.Add(Me.picPerson2)
        Me.grpMembers.Controls.Add(Me.picPerson1)
        Me.grpMembers.Controls.Add(Me.picRow4)
        Me.grpMembers.Controls.Add(Me.picRow3)
        Me.grpMembers.Controls.Add(Me.picRow2)
        Me.grpMembers.Controls.Add(Me.picRow1)
        Me.grpMembers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMembers.Location = New System.Drawing.Point(12, 190)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(647, 411)
        Me.grpMembers.TabIndex = 46
        Me.grpMembers.TabStop = False
        '
        'lblPerson4
        '
        Me.lblPerson4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPerson4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson4.ForeColor = System.Drawing.Color.White
        Me.lblPerson4.Location = New System.Drawing.Point(89, 329)
        Me.lblPerson4.Name = "lblPerson4"
        Me.lblPerson4.Size = New System.Drawing.Size(539, 57)
        Me.lblPerson4.TabIndex = 11
        Me.lblPerson4.Text = "N/A"
        Me.lblPerson4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPerson3
        '
        Me.lblPerson3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPerson3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson3.ForeColor = System.Drawing.Color.White
        Me.lblPerson3.Location = New System.Drawing.Point(89, 231)
        Me.lblPerson3.Name = "lblPerson3"
        Me.lblPerson3.Size = New System.Drawing.Size(539, 57)
        Me.lblPerson3.TabIndex = 10
        Me.lblPerson3.Text = "N/A"
        Me.lblPerson3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPerson2
        '
        Me.lblPerson2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPerson2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson2.ForeColor = System.Drawing.Color.White
        Me.lblPerson2.Location = New System.Drawing.Point(89, 134)
        Me.lblPerson2.Name = "lblPerson2"
        Me.lblPerson2.Size = New System.Drawing.Size(539, 57)
        Me.lblPerson2.TabIndex = 9
        Me.lblPerson2.Text = "N/A"
        Me.lblPerson2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPerson1
        '
        Me.lblPerson1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblPerson1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson1.ForeColor = System.Drawing.Color.White
        Me.lblPerson1.Location = New System.Drawing.Point(89, 34)
        Me.lblPerson1.Name = "lblPerson1"
        Me.lblPerson1.Size = New System.Drawing.Size(539, 57)
        Me.lblPerson1.TabIndex = 8
        Me.lblPerson1.Text = "N/A"
        Me.lblPerson1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPerson4
        '
        Me.picPerson4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picPerson4.Location = New System.Drawing.Point(22, 336)
        Me.picPerson4.Name = "picPerson4"
        Me.picPerson4.Size = New System.Drawing.Size(60, 45)
        Me.picPerson4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerson4.TabIndex = 7
        Me.picPerson4.TabStop = False
        '
        'picPerson3
        '
        Me.picPerson3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picPerson3.Location = New System.Drawing.Point(22, 238)
        Me.picPerson3.Name = "picPerson3"
        Me.picPerson3.Size = New System.Drawing.Size(60, 45)
        Me.picPerson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerson3.TabIndex = 6
        Me.picPerson3.TabStop = False
        '
        'picPerson2
        '
        Me.picPerson2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picPerson2.Location = New System.Drawing.Point(21, 141)
        Me.picPerson2.Name = "picPerson2"
        Me.picPerson2.Size = New System.Drawing.Size(60, 45)
        Me.picPerson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerson2.TabIndex = 5
        Me.picPerson2.TabStop = False
        '
        'picPerson1
        '
        Me.picPerson1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picPerson1.Location = New System.Drawing.Point(23, 41)
        Me.picPerson1.Name = "picPerson1"
        Me.picPerson1.Size = New System.Drawing.Size(60, 45)
        Me.picPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerson1.TabIndex = 4
        Me.picPerson1.TabStop = False
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
        Me.LogsDataGridView.Location = New System.Drawing.Point(367, 740)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(39, 27)
        Me.LogsDataGridView.TabIndex = 46
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
        'FamilyMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnEdMember)
        Me.Controls.Add(Me.btnRmMember)
        Me.Controls.Add(Me.btnAdMember)
        Me.Controls.Add(Me.picButDown)
        Me.Controls.Add(Me.picButUp)
        Me.Controls.Add(Me.PeopleDataGridView)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblPageNum)
        Me.Controls.Add(Me.grpMembers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FamilyMembers"
        Me.Text = "FamilyMembers"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        CType(Me.picPerson4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeopleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picButUp As System.Windows.Forms.PictureBox
    Friend WithEvents picButDown As System.Windows.Forms.PictureBox
    Friend WithEvents lblPageNum As System.Windows.Forms.Label
    Friend WithEvents btnAdMember As System.Windows.Forms.Button
    Friend WithEvents btnRmMember As System.Windows.Forms.Button
    Friend WithEvents btnEdMember As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents picRow1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow4 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson4 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPerson1 As System.Windows.Forms.Label
    Friend WithEvents picRow3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPerson4 As System.Windows.Forms.Label
    Friend WithEvents lblPerson3 As System.Windows.Forms.Label
    Friend WithEvents lblPerson2 As System.Windows.Forms.Label
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
