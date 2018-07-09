<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvalidInOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvalidInOut))
        Me.btnOk = New System.Windows.Forms.Button
        Me.picInvalid = New System.Windows.Forms.PictureBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblReason = New System.Windows.Forms.Label
        CType(Me.picInvalid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(381, 642)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(250, 111)
        Me.btnOk.TabIndex = 64
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'picInvalid
        '
        Me.picInvalid.Image = CType(resources.GetObject("picInvalid.Image"), System.Drawing.Image)
        Me.picInvalid.Location = New System.Drawing.Point(381, 157)
        Me.picInvalid.Name = "picInvalid"
        Me.picInvalid.Size = New System.Drawing.Size(250, 241)
        Me.picInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvalid.TabIndex = 63
        Me.picInvalid.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(252, 156)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 62
        Me.picLogo.TabStop = False
        '
        'lblReason
        '
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.ForeColor = System.Drawing.Color.Red
        Me.lblReason.Location = New System.Drawing.Point(12, 401)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(1000, 179)
        Me.lblReason.TabIndex = 66
        Me.lblReason.Text = "Unauthorised for sign-in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reason: Unknown barcode"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvalidInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.picInvalid)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InvalidInOut"
        Me.Text = "InvalidInOut"
        CType(Me.picInvalid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents picInvalid As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblReason As System.Windows.Forms.Label
End Class
