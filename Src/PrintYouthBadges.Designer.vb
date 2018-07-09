<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintYouthBadges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintYouthBadges))
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picButDown = New System.Windows.Forms.PictureBox
        Me.picButUp = New System.Windows.Forms.PictureBox
        Me.lblPageNum = New System.Windows.Forms.Label
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.picTick4 = New System.Windows.Forms.PictureBox
        Me.picTick3 = New System.Windows.Forms.PictureBox
        Me.picTick2 = New System.Windows.Forms.PictureBox
        Me.lblPerson4 = New System.Windows.Forms.Label
        Me.lblPerson3 = New System.Windows.Forms.Label
        Me.lblPerson2 = New System.Windows.Forms.Label
        Me.lblPerson1 = New System.Windows.Forms.Label
        Me.picTick1 = New System.Windows.Forms.PictureBox
        Me.picRow4 = New System.Windows.Forms.PictureBox
        Me.picRow3 = New System.Windows.Forms.PictureBox
        Me.picRow2 = New System.Windows.Forms.PictureBox
        Me.picRow1 = New System.Windows.Forms.PictureBox
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventsTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.EventsTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.PeopleTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
        Me.EventsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnHelp = New System.Windows.Forms.Button
        Me.btnContinue = New System.Windows.Forms.Button
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.picTick4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTick3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 16
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Attending Youth"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picButDown
        '
        Me.picButDown.Image = CType(resources.GetObject("picButDown.Image"), System.Drawing.Image)
        Me.picButDown.Location = New System.Drawing.Point(849, 550)
        Me.picButDown.Name = "picButDown"
        Me.picButDown.Size = New System.Drawing.Size(101, 83)
        Me.picButDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButDown.TabIndex = 48
        Me.picButDown.TabStop = False
        '
        'picButUp
        '
        Me.picButUp.Image = CType(resources.GetObject("picButUp.Image"), System.Drawing.Image)
        Me.picButUp.Location = New System.Drawing.Point(849, 153)
        Me.picButUp.Name = "picButUp"
        Me.picButUp.Size = New System.Drawing.Size(101, 83)
        Me.picButUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButUp.TabIndex = 47
        Me.picButUp.TabStop = False
        '
        'lblPageNum
        '
        Me.lblPageNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPageNum.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPageNum.Location = New System.Drawing.Point(849, 229)
        Me.lblPageNum.Name = "lblPageNum"
        Me.lblPageNum.Size = New System.Drawing.Size(101, 328)
        Me.lblPageNum.TabIndex = 49
        Me.lblPageNum.Text = "Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.picTick4)
        Me.grpMembers.Controls.Add(Me.picTick3)
        Me.grpMembers.Controls.Add(Me.picTick2)
        Me.grpMembers.Controls.Add(Me.lblPerson4)
        Me.grpMembers.Controls.Add(Me.lblPerson3)
        Me.grpMembers.Controls.Add(Me.lblPerson2)
        Me.grpMembers.Controls.Add(Me.lblPerson1)
        Me.grpMembers.Controls.Add(Me.picTick1)
        Me.grpMembers.Controls.Add(Me.picRow4)
        Me.grpMembers.Controls.Add(Me.picRow3)
        Me.grpMembers.Controls.Add(Me.picRow2)
        Me.grpMembers.Controls.Add(Me.picRow1)
        Me.grpMembers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMembers.Location = New System.Drawing.Point(202, 187)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(647, 411)
        Me.grpMembers.TabIndex = 50
        Me.grpMembers.TabStop = False
        '
        'picTick4
        '
        Me.picTick4.BackColor = System.Drawing.Color.White
        Me.picTick4.Location = New System.Drawing.Point(33, 341)
        Me.picTick4.Name = "picTick4"
        Me.picTick4.Size = New System.Drawing.Size(35, 36)
        Me.picTick4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTick4.TabIndex = 14
        Me.picTick4.TabStop = False
        '
        'picTick3
        '
        Me.picTick3.BackColor = System.Drawing.Color.White
        Me.picTick3.Location = New System.Drawing.Point(33, 243)
        Me.picTick3.Name = "picTick3"
        Me.picTick3.Size = New System.Drawing.Size(35, 36)
        Me.picTick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTick3.TabIndex = 13
        Me.picTick3.TabStop = False
        '
        'picTick2
        '
        Me.picTick2.BackColor = System.Drawing.Color.White
        Me.picTick2.Location = New System.Drawing.Point(33, 144)
        Me.picTick2.Name = "picTick2"
        Me.picTick2.Size = New System.Drawing.Size(35, 36)
        Me.picTick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTick2.TabIndex = 12
        Me.picTick2.TabStop = False
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
        'picTick1
        '
        Me.picTick1.BackColor = System.Drawing.Color.White
        Me.picTick1.Location = New System.Drawing.Point(33, 46)
        Me.picTick1.Name = "picTick1"
        Me.picTick1.Size = New System.Drawing.Size(35, 36)
        Me.picTick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTick1.TabIndex = 4
        Me.picTick1.TabStop = False
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
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventsBindingSource
        '
        Me.EventsBindingSource.DataMember = "Events"
        Me.EventsBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'EventsTableAdapter
        '
        Me.EventsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventsTableAdapter = Me.EventsTableAdapter
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
        'PeopleTableAdapter
        '
        Me.PeopleTableAdapter.ClearBeforeFill = True
        '
        'EventsDataGridView
        '
        Me.EventsDataGridView.AutoGenerateColumns = False
        Me.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EventsDataGridView.DataSource = Me.EventsBindingSource
        Me.EventsDataGridView.Location = New System.Drawing.Point(0, 735)
        Me.EventsDataGridView.Name = "EventsDataGridView"
        Me.EventsDataGridView.ReadOnly = True
        Me.EventsDataGridView.Size = New System.Drawing.Size(43, 21)
        Me.EventsDataGridView.TabIndex = 51
        Me.EventsDataGridView.TabStop = False
        Me.EventsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Event_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Event_Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Start_Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Start_Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "End_Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "End_Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Event_Code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Event_Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataMember = "People"
        Me.PeopleBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.AutoGenerateColumns = False
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn18})
        Me.PeopleDataGridView.DataSource = Me.PeopleBindingSource
        Me.PeopleDataGridView.Location = New System.Drawing.Point(49, 735)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.ReadOnly = True
        Me.PeopleDataGridView.Size = New System.Drawing.Size(41, 21)
        Me.PeopleDataGridView.TabIndex = 51
        Me.PeopleDataGridView.TabStop = False
        Me.PeopleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Person_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Person_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Mobile_Num"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Mobile_Num"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Photo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Photo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Family_ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Family_ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
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
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(517, 645)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(240, 111)
        Me.btnHelp.TabIndex = 53
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnContinue.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnContinue.Location = New System.Drawing.Point(772, 645)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(240, 111)
        Me.btnContinue.TabIndex = 52
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'PrintYouthBadges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.PeopleDataGridView)
        Me.Controls.Add(Me.EventsDataGridView)
        Me.Controls.Add(Me.picButDown)
        Me.Controls.Add(Me.picButUp)
        Me.Controls.Add(Me.lblPageNum)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintYouthBadges"
        Me.Text = "PrintYouthBadges"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        CType(Me.picTick4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTick3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picButDown As System.Windows.Forms.PictureBox
    Friend WithEvents picButUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblPageNum As System.Windows.Forms.Label
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerson4 As System.Windows.Forms.Label
    Friend WithEvents lblPerson3 As System.Windows.Forms.Label
    Friend WithEvents lblPerson2 As System.Windows.Forms.Label
    Friend WithEvents lblPerson1 As System.Windows.Forms.Label
    Friend WithEvents picTick1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow4 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow1 As System.Windows.Forms.PictureBox
    Friend WithEvents picTick4 As System.Windows.Forms.PictureBox
    Friend WithEvents picTick3 As System.Windows.Forms.PictureBox
    Friend WithEvents picTick2 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents EventsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventsTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.EventsTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeopleTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents EventsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
