<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAdd_Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAdd_Teacher))
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Snamelabel = New System.Windows.Forms.Label()
        Me.Fnamelabel = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add_Edit = New System.Windows.Forms.Button()
        Me.AddT = New System.Windows.Forms.Label()
        Me.addeditlabel = New System.Windows.Forms.LinkLabel()
        Me.Teacher = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Linkarrow = New System.Windows.Forms.Label()
        Me.Linkarrow2 = New System.Windows.Forms.Label()
        Me.Banner = New System.Windows.Forms.PictureBox()
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Surname
        '
        Me.Surname.Location = New System.Drawing.Point(128, 99)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(121, 20)
        Me.Surname.TabIndex = 2
        '
        'Firstname
        '
        Me.Firstname.Location = New System.Drawing.Point(128, 66)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(121, 20)
        Me.Firstname.TabIndex = 1
        '
        'Snamelabel
        '
        Me.Snamelabel.AutoSize = True
        Me.Snamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Snamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Snamelabel.Location = New System.Drawing.Point(41, 101)
        Me.Snamelabel.Name = "Snamelabel"
        Me.Snamelabel.Size = New System.Drawing.Size(52, 13)
        Me.Snamelabel.TabIndex = 28
        Me.Snamelabel.Text = "Surname:"
        '
        'Fnamelabel
        '
        Me.Fnamelabel.AutoSize = True
        Me.Fnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Fnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Fnamelabel.Location = New System.Drawing.Point(43, 69)
        Me.Fnamelabel.Name = "Fnamelabel"
        Me.Fnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.Fnamelabel.TabIndex = 27
        Me.Fnamelabel.Text = "Firstname:"
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Transparent
        Me.Delete.BackgroundImage = CType(resources.GetObject("Delete.BackgroundImage"), System.Drawing.Image)
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Delete.FlatAppearance.BorderSize = 0
        Me.Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Location = New System.Drawing.Point(174, 127)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 33
        Me.Delete.Text = "Delete"
        Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Delete.UseVisualStyleBackColor = False
        Me.Delete.Visible = False
        '
        'Add_Edit
        '
        Me.Add_Edit.BackColor = System.Drawing.Color.Transparent
        Me.Add_Edit.BackgroundImage = CType(resources.GetObject("Add_Edit.BackgroundImage"), System.Drawing.Image)
        Me.Add_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Edit.FlatAppearance.BorderSize = 0
        Me.Add_Edit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Add_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Add_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Add_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Edit.ForeColor = System.Drawing.Color.White
        Me.Add_Edit.Location = New System.Drawing.Point(60, 127)
        Me.Add_Edit.Name = "Add_Edit"
        Me.Add_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Add_Edit.TabIndex = 32
        Me.Add_Edit.Text = "Add"
        Me.Add_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Add_Edit.UseVisualStyleBackColor = False
        '
        'AddT
        '
        Me.AddT.AutoSize = True
        Me.AddT.BackColor = System.Drawing.Color.Transparent
        Me.AddT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddT.ForeColor = System.Drawing.Color.Maroon
        Me.AddT.Location = New System.Drawing.Point(12, 39)
        Me.AddT.Name = "AddT"
        Me.AddT.Size = New System.Drawing.Size(200, 24)
        Me.AddT.TabIndex = 35
        Me.AddT.Text = "Add Teacher Details"
        '
        'addeditlabel
        '
        Me.addeditlabel.AutoSize = True
        Me.addeditlabel.BackColor = System.Drawing.Color.White
        Me.addeditlabel.Enabled = False
        Me.addeditlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.addeditlabel.LinkColor = System.Drawing.Color.Gray
        Me.addeditlabel.Location = New System.Drawing.Point(154, 9)
        Me.addeditlabel.Name = "addeditlabel"
        Me.addeditlabel.Size = New System.Drawing.Size(69, 13)
        Me.addeditlabel.TabIndex = 43
        Me.addeditlabel.TabStop = True
        Me.addeditlabel.Text = "Add Teacher"
        Me.addeditlabel.VisitedLinkColor = System.Drawing.Color.Maroon
        '
        'Teacher
        '
        Me.Teacher.AutoSize = True
        Me.Teacher.BackColor = System.Drawing.Color.White
        Me.Teacher.Location = New System.Drawing.Point(88, 9)
        Me.Teacher.Name = "Teacher"
        Me.Teacher.Size = New System.Drawing.Size(47, 13)
        Me.Teacher.TabIndex = 42
        Me.Teacher.TabStop = True
        Me.Teacher.Text = "Teacher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(11, 9)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 41
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Linkarrow
        '
        Me.Linkarrow.AutoSize = True
        Me.Linkarrow.BackColor = System.Drawing.Color.White
        Me.Linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Linkarrow.Location = New System.Drawing.Point(67, 6)
        Me.Linkarrow.Name = "Linkarrow"
        Me.Linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.Linkarrow.TabIndex = 68
        Me.Linkarrow.Text = "4"
        '
        'Linkarrow2
        '
        Me.Linkarrow2.AutoSize = True
        Me.Linkarrow2.BackColor = System.Drawing.Color.White
        Me.Linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Linkarrow2.Location = New System.Drawing.Point(131, 6)
        Me.Linkarrow2.Name = "Linkarrow2"
        Me.Linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.Linkarrow2.TabIndex = 69
        Me.Linkarrow2.Text = "4"
        '
        'Banner
        '
        Me.Banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd
        Me.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Banner.Location = New System.Drawing.Point(0, 0)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(276, 31)
        Me.Banner.TabIndex = 70
        Me.Banner.TabStop = False
        '
        'EditAdd_Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(279, 161)
        Me.Controls.Add(Me.Linkarrow2)
        Me.Controls.Add(Me.Linkarrow)
        Me.Controls.Add(Me.addeditlabel)
        Me.Controls.Add(Me.Teacher)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.AddT)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add_Edit)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Snamelabel)
        Me.Controls.Add(Me.Fnamelabel)
        Me.Controls.Add(Me.Banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(295, 199)
        Me.MinimumSize = New System.Drawing.Size(295, 199)
        Me.Name = "EditAdd_Teacher"
        Me.Text = "Add Teacher"
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Firstname As System.Windows.Forms.TextBox
    Friend WithEvents Snamelabel As System.Windows.Forms.Label
    Friend WithEvents Fnamelabel As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Add_Edit As System.Windows.Forms.Button
    Friend WithEvents AddT As System.Windows.Forms.Label
    Friend WithEvents addeditlabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Teacher As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Linkarrow As System.Windows.Forms.Label
    Friend WithEvents Linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents Banner As System.Windows.Forms.PictureBox
End Class
