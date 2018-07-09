<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakePhoto
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
        Me.timHalfSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.btnPhotoGet = New System.Windows.Forms.Button
        Me.lblCountdown = New System.Windows.Forms.Label
        Me.lblTimeLeft = New System.Windows.Forms.Label
        Me.picWebcam = New System.Windows.Forms.PictureBox
        Me.picFlash = New System.Windows.Forms.PictureBox
        CType(Me.picWebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timHalfSeconds
        '
        Me.timHalfSeconds.Enabled = True
        Me.timHalfSeconds.Interval = 500
        '
        'btnPhotoGet
        '
        Me.btnPhotoGet.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPhotoGet.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoGet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPhotoGet.Location = New System.Drawing.Point(12, 370)
        Me.btnPhotoGet.Name = "btnPhotoGet"
        Me.btnPhotoGet.Size = New System.Drawing.Size(189, 44)
        Me.btnPhotoGet.TabIndex = 1
        Me.btnPhotoGet.Text = "Take photo"
        Me.btnPhotoGet.UseVisualStyleBackColor = False
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCountdown.Location = New System.Drawing.Point(264, 377)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(127, 29)
        Me.lblCountdown.TabIndex = 2
        Me.lblCountdown.Text = "Time left:"
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTimeLeft.Location = New System.Drawing.Point(397, 375)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(71, 31)
        Me.lblTimeLeft.TabIndex = 3
        Me.lblTimeLeft.Text = "5"
        Me.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picWebcam
        '
        Me.picWebcam.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.picWebcam.Location = New System.Drawing.Point(12, 12)
        Me.picWebcam.Name = "picWebcam"
        Me.picWebcam.Size = New System.Drawing.Size(456, 342)
        Me.picWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWebcam.TabIndex = 0
        Me.picWebcam.TabStop = False
        '
        'picFlash
        '
        Me.picFlash.BackColor = System.Drawing.Color.White
        Me.picFlash.Location = New System.Drawing.Point(0, 0)
        Me.picFlash.Name = "picFlash"
        Me.picFlash.Size = New System.Drawing.Size(14, 10)
        Me.picFlash.TabIndex = 4
        Me.picFlash.TabStop = False
        Me.picFlash.Visible = False
        '
        'TakePhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 423)
        Me.Controls.Add(Me.picFlash)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.btnPhotoGet)
        Me.Controls.Add(Me.picWebcam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TakePhoto"
        Me.Text = "Taking photo"
        Me.TopMost = True
        CType(Me.picWebcam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timHalfSeconds As System.Windows.Forms.Timer
    Friend WithEvents btnPhotoGet As System.Windows.Forms.Button
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label
    Friend WithEvents picWebcam As System.Windows.Forms.PictureBox
    Friend WithEvents picFlash As System.Windows.Forms.PictureBox
End Class
