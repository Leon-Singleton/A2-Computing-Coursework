<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Loginbutton = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.userlabel = New System.Windows.Forms.Label()
        Me.passlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Loginbutton
        '
        Me.Loginbutton.BackColor = System.Drawing.Color.Transparent
        Me.Loginbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Loginbutton.FlatAppearance.BorderSize = 0
        Me.Loginbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Loginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Loginbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbutton.ForeColor = System.Drawing.Color.White
        Me.Loginbutton.Location = New System.Drawing.Point(72, 98)
        Me.Loginbutton.Name = "Loginbutton"
        Me.Loginbutton.Size = New System.Drawing.Size(73, 30)
        Me.Loginbutton.TabIndex = 0
        Me.Loginbutton.Text = "Login"
        Me.Loginbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Loginbutton.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(108, 59)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(108, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(108, 15)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(108, 20)
        Me.txtUsername.TabIndex = 1
        '
        'userlabel
        '
        Me.userlabel.AutoSize = True
        Me.userlabel.BackColor = System.Drawing.Color.Transparent
        Me.userlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlabel.ForeColor = System.Drawing.Color.Maroon
        Me.userlabel.Location = New System.Drawing.Point(16, 18)
        Me.userlabel.Name = "userlabel"
        Me.userlabel.Size = New System.Drawing.Size(74, 16)
        Me.userlabel.TabIndex = 3
        Me.userlabel.Text = "Username:"
        '
        'passlabel
        '
        Me.passlabel.AutoSize = True
        Me.passlabel.BackColor = System.Drawing.Color.Transparent
        Me.passlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlabel.ForeColor = System.Drawing.Color.Maroon
        Me.passlabel.Location = New System.Drawing.Point(16, 59)
        Me.passlabel.Name = "passlabel"
        Me.passlabel.Size = New System.Drawing.Size(71, 16)
        Me.passlabel.TabIndex = 4
        Me.passlabel.Text = "Password:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(228, 137)
        Me.Controls.Add(Me.passlabel)
        Me.Controls.Add(Me.userlabel)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Loginbutton)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(244, 175)
        Me.MinimumSize = New System.Drawing.Size(244, 175)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Loginbutton As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents userlabel As System.Windows.Forms.Label
    Friend WithEvents passlabel As System.Windows.Forms.Label
End Class
