<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamilySearchPref
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
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.btnShowKeyboard = New System.Windows.Forms.Button
        Me.txtFamilyName = New System.Windows.Forms.TextBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
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
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 63
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 62
        Me.lblTitle.Text = "Family Search"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(7, 227)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(189, 35)
        Me.lblSurname.TabIndex = 65
        Me.lblSurname.Text = "Family Name:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowKeyboard
        '
        Me.btnShowKeyboard.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnShowKeyboard.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowKeyboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShowKeyboard.Location = New System.Drawing.Point(12, 645)
        Me.btnShowKeyboard.Name = "btnShowKeyboard"
        Me.btnShowKeyboard.Size = New System.Drawing.Size(240, 111)
        Me.btnShowKeyboard.TabIndex = 66
        Me.btnShowKeyboard.Text = "Show keyboard"
        Me.btnShowKeyboard.UseVisualStyleBackColor = False
        '
        'txtFamilyName
        '
        Me.txtFamilyName.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilyName.Location = New System.Drawing.Point(202, 212)
        Me.txtFamilyName.MaxLength = 25
        Me.txtFamilyName.Name = "txtFamilyName"
        Me.txtFamilyName.Size = New System.Drawing.Size(644, 65)
        Me.txtFamilyName.TabIndex = 67
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(852, 145)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 59)
        Me.btnBack.TabIndex = 69
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(852, 210)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(160, 59)
        Me.btnSearch.TabIndex = 68
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
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
        Me.FamiliesDataGridView.Location = New System.Drawing.Point(967, 732)
        Me.FamiliesDataGridView.Name = "FamiliesDataGridView"
        Me.FamiliesDataGridView.ReadOnly = True
        Me.FamiliesDataGridView.Size = New System.Drawing.Size(45, 24)
        Me.FamiliesDataGridView.TabIndex = 70
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
        'FamilySearchPref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.FamiliesDataGridView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFamilyName)
        Me.Controls.Add(Me.btnShowKeyboard)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FamilySearchPref"
        Me.Text = "FamilySearchPref"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents btnShowKeyboard As System.Windows.Forms.Button
    Friend WithEvents txtFamilyName As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
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
End Class
