<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFamilyChoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminFamilyChoice))
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.lblFamily4 = New System.Windows.Forms.Label
        Me.btnEdFamily = New System.Windows.Forms.Button
        Me.btnRmFamily = New System.Windows.Forms.Button
        Me.picButUp = New System.Windows.Forms.PictureBox
        Me.picButDown = New System.Windows.Forms.PictureBox
        Me.lblFamily3 = New System.Windows.Forms.Label
        Me.lblFamily2 = New System.Windows.Forms.Label
        Me.lblFamily1 = New System.Windows.Forms.Label
        Me.picFamily3 = New System.Windows.Forms.PictureBox
        Me.picRow4 = New System.Windows.Forms.PictureBox
        Me.picRow3 = New System.Windows.Forms.PictureBox
        Me.picRow2 = New System.Windows.Forms.PictureBox
        Me.picFamily4 = New System.Windows.Forms.PictureBox
        Me.btnAdFamily = New System.Windows.Forms.Button
        Me.picFamily2 = New System.Windows.Forms.PictureBox
        Me.picFamily1 = New System.Windows.Forms.PictureBox
        Me.lblPageNum = New System.Windows.Forms.Label
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.picRow1 = New System.Windows.Forms.PictureBox
        Me.btnSearchPref = New System.Windows.Forms.Button
        Me.btnScan = New System.Windows.Forms.Button
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.FamiliesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamiliesTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.FamiliesTableAdapter
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.FamiliesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogsTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamily3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamily4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamily2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamily1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 61
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 60
        Me.lblTitle.Text = "Choose Family"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(772, 522)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(240, 111)
        Me.btnHelp.TabIndex = 71
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(772, 642)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(240, 111)
        Me.btnBack.TabIndex = 70
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblFamily4
        '
        Me.lblFamily4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFamily4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily4.ForeColor = System.Drawing.Color.White
        Me.lblFamily4.Location = New System.Drawing.Point(89, 329)
        Me.lblFamily4.Name = "lblFamily4"
        Me.lblFamily4.Size = New System.Drawing.Size(539, 57)
        Me.lblFamily4.TabIndex = 11
        Me.lblFamily4.Text = "N/A"
        Me.lblFamily4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdFamily
        '
        Me.btnEdFamily.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEdFamily.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdFamily.Location = New System.Drawing.Point(772, 402)
        Me.btnEdFamily.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnEdFamily.Name = "btnEdFamily"
        Me.btnEdFamily.Size = New System.Drawing.Size(240, 111)
        Me.btnEdFamily.TabIndex = 68
        Me.btnEdFamily.Text = "Edit Family"
        Me.btnEdFamily.UseVisualStyleBackColor = False
        '
        'btnRmFamily
        '
        Me.btnRmFamily.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRmFamily.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRmFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRmFamily.Location = New System.Drawing.Point(772, 282)
        Me.btnRmFamily.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnRmFamily.Name = "btnRmFamily"
        Me.btnRmFamily.Size = New System.Drawing.Size(240, 111)
        Me.btnRmFamily.TabIndex = 67
        Me.btnRmFamily.Text = "Remove Family"
        Me.btnRmFamily.UseVisualStyleBackColor = False
        '
        'picButUp
        '
        Me.picButUp.Image = CType(resources.GetObject("picButUp.Image"), System.Drawing.Image)
        Me.picButUp.Location = New System.Drawing.Point(659, 156)
        Me.picButUp.Name = "picButUp"
        Me.picButUp.Size = New System.Drawing.Size(101, 83)
        Me.picButUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButUp.TabIndex = 63
        Me.picButUp.TabStop = False
        '
        'picButDown
        '
        Me.picButDown.Image = CType(resources.GetObject("picButDown.Image"), System.Drawing.Image)
        Me.picButDown.Location = New System.Drawing.Point(659, 553)
        Me.picButDown.Name = "picButDown"
        Me.picButDown.Size = New System.Drawing.Size(101, 83)
        Me.picButDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picButDown.TabIndex = 64
        Me.picButDown.TabStop = False
        '
        'lblFamily3
        '
        Me.lblFamily3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFamily3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily3.ForeColor = System.Drawing.Color.White
        Me.lblFamily3.Location = New System.Drawing.Point(89, 231)
        Me.lblFamily3.Name = "lblFamily3"
        Me.lblFamily3.Size = New System.Drawing.Size(539, 57)
        Me.lblFamily3.TabIndex = 10
        Me.lblFamily3.Text = "N/A"
        Me.lblFamily3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFamily2
        '
        Me.lblFamily2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFamily2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily2.ForeColor = System.Drawing.Color.White
        Me.lblFamily2.Location = New System.Drawing.Point(89, 134)
        Me.lblFamily2.Name = "lblFamily2"
        Me.lblFamily2.Size = New System.Drawing.Size(539, 57)
        Me.lblFamily2.TabIndex = 9
        Me.lblFamily2.Text = "N/A"
        Me.lblFamily2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFamily1
        '
        Me.lblFamily1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFamily1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily1.ForeColor = System.Drawing.Color.White
        Me.lblFamily1.Location = New System.Drawing.Point(89, 34)
        Me.lblFamily1.Name = "lblFamily1"
        Me.lblFamily1.Size = New System.Drawing.Size(539, 57)
        Me.lblFamily1.TabIndex = 8
        Me.lblFamily1.Text = "N/A"
        Me.lblFamily1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFamily3
        '
        Me.picFamily3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picFamily3.Location = New System.Drawing.Point(22, 238)
        Me.picFamily3.Name = "picFamily3"
        Me.picFamily3.Size = New System.Drawing.Size(60, 45)
        Me.picFamily3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamily3.TabIndex = 6
        Me.picFamily3.TabStop = False
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
        'picFamily4
        '
        Me.picFamily4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picFamily4.Location = New System.Drawing.Point(22, 336)
        Me.picFamily4.Name = "picFamily4"
        Me.picFamily4.Size = New System.Drawing.Size(60, 45)
        Me.picFamily4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamily4.TabIndex = 7
        Me.picFamily4.TabStop = False
        '
        'btnAdFamily
        '
        Me.btnAdFamily.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdFamily.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdFamily.Location = New System.Drawing.Point(772, 162)
        Me.btnAdFamily.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnAdFamily.Name = "btnAdFamily"
        Me.btnAdFamily.Size = New System.Drawing.Size(240, 111)
        Me.btnAdFamily.TabIndex = 66
        Me.btnAdFamily.Text = "Add Family"
        Me.btnAdFamily.UseVisualStyleBackColor = False
        '
        'picFamily2
        '
        Me.picFamily2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picFamily2.Location = New System.Drawing.Point(21, 141)
        Me.picFamily2.Name = "picFamily2"
        Me.picFamily2.Size = New System.Drawing.Size(60, 45)
        Me.picFamily2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamily2.TabIndex = 5
        Me.picFamily2.TabStop = False
        '
        'picFamily1
        '
        Me.picFamily1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.picFamily1.Location = New System.Drawing.Point(23, 41)
        Me.picFamily1.Name = "picFamily1"
        Me.picFamily1.Size = New System.Drawing.Size(60, 45)
        Me.picFamily1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamily1.TabIndex = 4
        Me.picFamily1.TabStop = False
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
        Me.lblPageNum.TabIndex = 65
        Me.lblPageNum.Text = "Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.lblFamily4)
        Me.grpMembers.Controls.Add(Me.lblFamily3)
        Me.grpMembers.Controls.Add(Me.lblFamily2)
        Me.grpMembers.Controls.Add(Me.lblFamily1)
        Me.grpMembers.Controls.Add(Me.picFamily4)
        Me.grpMembers.Controls.Add(Me.picFamily3)
        Me.grpMembers.Controls.Add(Me.picFamily2)
        Me.grpMembers.Controls.Add(Me.picFamily1)
        Me.grpMembers.Controls.Add(Me.picRow4)
        Me.grpMembers.Controls.Add(Me.picRow3)
        Me.grpMembers.Controls.Add(Me.picRow2)
        Me.grpMembers.Controls.Add(Me.picRow1)
        Me.grpMembers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMembers.Location = New System.Drawing.Point(12, 190)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(647, 411)
        Me.grpMembers.TabIndex = 72
        Me.grpMembers.TabStop = False
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
        'btnSearchPref
        '
        Me.btnSearchPref.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSearchPref.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPref.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearchPref.Location = New System.Drawing.Point(12, 642)
        Me.btnSearchPref.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnSearchPref.Name = "btnSearchPref"
        Me.btnSearchPref.Size = New System.Drawing.Size(240, 111)
        Me.btnSearchPref.TabIndex = 73
        Me.btnSearchPref.Text = "Search Family Name"
        Me.btnSearchPref.UseVisualStyleBackColor = False
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnScan.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnScan.Location = New System.Drawing.Point(269, 642)
        Me.btnScan.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(240, 111)
        Me.btnScan.TabIndex = 74
        Me.btnScan.Text = "Scan Barcode"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FamiliesBindingSource
        '
        Me.FamiliesBindingSource.DataMember = "Families"
        Me.FamiliesBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'FamiliesTableAdapter
        '
        Me.FamiliesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventsTableAdapter = Nothing
        Me.TableAdapterManager.FamiliesTableAdapter = Me.FamiliesTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
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
        'FamiliesDataGridView
        '
        Me.FamiliesDataGridView.AutoGenerateColumns = False
        Me.FamiliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.FamiliesDataGridView.DataSource = Me.FamiliesBindingSource
        Me.FamiliesDataGridView.Location = New System.Drawing.Point(18, 609)
        Me.FamiliesDataGridView.Name = "FamiliesDataGridView"
        Me.FamiliesDataGridView.ReadOnly = True
        Me.FamiliesDataGridView.Size = New System.Drawing.Size(46, 27)
        Me.FamiliesDataGridView.TabIndex = 75
        Me.FamiliesDataGridView.TabStop = False
        Me.FamiliesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Family_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Family_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date_Created"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date_Created"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Photo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Photo"
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
        Me.LogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.LogsDataGridView.DataSource = Me.LogsBindingSource
        Me.LogsDataGridView.Location = New System.Drawing.Point(70, 608)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(44, 28)
        Me.LogsDataGridView.TabIndex = 75
        Me.LogsDataGridView.TabStop = False
        Me.LogsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Log_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Log_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Log_Type"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Log_Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Item_Logged_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Action_Logged_ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Date_Logged"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date_Logged"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Time_Logged"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Time_Logged"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'AdminFamilyChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.FamiliesDataGridView)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnSearchPref)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEdFamily)
        Me.Controls.Add(Me.btnRmFamily)
        Me.Controls.Add(Me.picButUp)
        Me.Controls.Add(Me.picButDown)
        Me.Controls.Add(Me.btnAdFamily)
        Me.Controls.Add(Me.lblPageNum)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminFamilyChoice"
        Me.Text = "AdminFamilyChoice"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamily3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamily4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamily2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamily1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        CType(Me.picRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblFamily4 As System.Windows.Forms.Label
    Friend WithEvents btnEdFamily As System.Windows.Forms.Button
    Friend WithEvents btnRmFamily As System.Windows.Forms.Button
    Friend WithEvents picButUp As System.Windows.Forms.PictureBox
    Friend WithEvents picButDown As System.Windows.Forms.PictureBox
    Friend WithEvents lblFamily3 As System.Windows.Forms.Label
    Friend WithEvents lblFamily2 As System.Windows.Forms.Label
    Friend WithEvents lblFamily1 As System.Windows.Forms.Label
    Friend WithEvents picFamily3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow4 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picFamily4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdFamily As System.Windows.Forms.Button
    Friend WithEvents picFamily2 As System.Windows.Forms.PictureBox
    Friend WithEvents picFamily1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPageNum As System.Windows.Forms.Label
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents picRow1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearchPref As System.Windows.Forms.Button
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents FamiliesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FamiliesTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.FamiliesTableAdapter
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FamiliesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogsTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LogsTableAdapter
    Friend WithEvents LogsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
