<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOverride
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
        Me.LoginTableAdapter = New OpenAttend.OpenAttendDataSetTableAdapters.LoginTableAdapter
        Me.Login_LevelTextBox = New System.Windows.Forms.TextBox
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenAttendDataSet = New OpenAttend.OpenAttendDataSet
        Me.TableAdapterManager = New OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.User_NameTextBox = New System.Windows.Forms.TextBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.btnShowKeyboard = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'Login_LevelTextBox
        '
        Me.Login_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Login_Level", True))
        Me.Login_LevelTextBox.Location = New System.Drawing.Point(-88, -88)
        Me.Login_LevelTextBox.Name = "Login_LevelTextBox"
        Me.Login_LevelTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Login_LevelTextBox.ReadOnly = True
        Me.Login_LevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Login_LevelTextBox.TabIndex = 22
        Me.Login_LevelTextBox.TabStop = False
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.OpenAttendDataSet
        '
        'OpenAttendDataSet
        '
        Me.OpenAttendDataSet.DataSetName = "OpenAttendDataSet"
        Me.OpenAttendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(-88, -88)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 21
        Me.PasswordTextBox.TabStop = False
        '
        'User_NameTextBox
        '
        Me.User_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "User_Name", True))
        Me.User_NameTextBox.Location = New System.Drawing.Point(-88, -88)
        Me.User_NameTextBox.Name = "User_NameTextBox"
        Me.User_NameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.User_NameTextBox.ReadOnly = True
        Me.User_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_NameTextBox.TabIndex = 20
        Me.User_NameTextBox.TabStop = False
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
        'btnShowKeyboard
        '
        Me.btnShowKeyboard.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnShowKeyboard.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowKeyboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShowKeyboard.Location = New System.Drawing.Point(12, 645)
        Me.btnShowKeyboard.Name = "btnShowKeyboard"
        Me.btnShowKeyboard.Size = New System.Drawing.Size(240, 111)
        Me.btnShowKeyboard.TabIndex = 23
        Me.btnShowKeyboard.Text = "Show keyboard"
        Me.btnShowKeyboard.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(870, 279)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(136, 59)
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(42, 289)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(215, 39)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(42, 217)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(215, 39)
        Me.lblUsername.TabIndex = 17
        Me.lblUsername.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(263, 276)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(586, 57)
        Me.txtPassword.TabIndex = 16
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(263, 199)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(586, 57)
        Me.txtUsername.TabIndex = 15
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(742, 111)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Admin Login"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(870, 202)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(136, 59)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'AdminOverride
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1026, 776)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Login_LevelTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.User_NameTextBox)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnShowKeyboard)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminOverride"
        Me.Text = "AdminOverride"
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenAttendDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginTableAdapter As OpenAttend.OpenAttendDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents Login_LevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpenAttendDataSet As OpenAttend.OpenAttendDataSet
    Friend WithEvents TableAdapterManager As OpenAttend.OpenAttendDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnShowKeyboard As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
