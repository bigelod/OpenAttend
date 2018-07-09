<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminalMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerminalMode))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.AdminMode = New System.Windows.Forms.PictureBox
        Me.RegMode = New System.Windows.Forms.PictureBox
        Me.SignInMode = New System.Windows.Forms.PictureBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        CType(Me.AdminMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignInMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Neuropol", 48.0!, System.Drawing.FontStyle.Underline)
        Me.lblTitle.Location = New System.Drawing.Point(258, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(754, 123)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Select Mode"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AdminMode
        '
        Me.AdminMode.Location = New System.Drawing.Point(696, 287)
        Me.AdminMode.Name = "AdminMode"
        Me.AdminMode.Size = New System.Drawing.Size(316, 315)
        Me.AdminMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminMode.TabIndex = 6
        Me.AdminMode.TabStop = False
        '
        'RegMode
        '
        Me.RegMode.Location = New System.Drawing.Point(355, 287)
        Me.RegMode.Name = "RegMode"
        Me.RegMode.Size = New System.Drawing.Size(316, 315)
        Me.RegMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RegMode.TabIndex = 5
        Me.RegMode.TabStop = False
        '
        'SignInMode
        '
        Me.SignInMode.Location = New System.Drawing.Point(12, 287)
        Me.SignInMode.Name = "SignInMode"
        Me.SignInMode.Size = New System.Drawing.Size(316, 315)
        Me.SignInMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SignInMode.TabIndex = 4
        Me.SignInMode.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'TerminalMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.AdminMode)
        Me.Controls.Add(Me.RegMode)
        Me.Controls.Add(Me.SignInMode)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TerminalMode"
        Me.Text = resources.GetString("$this.Text")
        CType(Me.AdminMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignInMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents SignInMode As System.Windows.Forms.PictureBox
    Friend WithEvents RegMode As System.Windows.Forms.PictureBox
    Friend WithEvents AdminMode As System.Windows.Forms.PictureBox
End Class
