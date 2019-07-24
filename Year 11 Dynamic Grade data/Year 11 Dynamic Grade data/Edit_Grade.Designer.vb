<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Grade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Grade))
        Me.SubjectLink = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Editlabel = New System.Windows.Forms.LinkLabel()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.surnamlabel = New System.Windows.Forms.Label()
        Me.firstnamelabel = New System.Windows.Forms.Label()
        Me.edittitle = New System.Windows.Forms.Label()
        Me.Yearlabel = New System.Windows.Forms.Label()
        Me.Levellabel = New System.Windows.Forms.Label()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.Gradelabel = New System.Windows.Forms.Label()
        Me.Gradefield = New System.Windows.Forms.ComboBox()
        Me.Subjectlabel = New System.Windows.Forms.Label()
        Me.Gradetypelabel = New System.Windows.Forms.Label()
        Me.Gradetypefield = New System.Windows.Forms.ComboBox()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.LevelField = New System.Windows.Forms.ComboBox()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.arrowlink1 = New System.Windows.Forms.Label()
        Me.arrowlink = New System.Windows.Forms.Label()
        Me.banner = New System.Windows.Forms.PictureBox()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectLink
        '
        Me.SubjectLink.AutoSize = True
        Me.SubjectLink.BackColor = System.Drawing.Color.White
        Me.SubjectLink.DisabledLinkColor = System.Drawing.Color.White
        Me.SubjectLink.Enabled = False
        Me.SubjectLink.LinkColor = System.Drawing.Color.Gray
        Me.SubjectLink.Location = New System.Drawing.Point(91, 14)
        Me.SubjectLink.Name = "SubjectLink"
        Me.SubjectLink.Size = New System.Drawing.Size(36, 13)
        Me.SubjectLink.TabIndex = 36
        Me.SubjectLink.TabStop = True
        Me.SubjectLink.Text = "Grade"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(12, 14)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 35
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Editlabel
        '
        Me.Editlabel.AutoSize = True
        Me.Editlabel.BackColor = System.Drawing.Color.White
        Me.Editlabel.DisabledLinkColor = System.Drawing.Color.White
        Me.Editlabel.Enabled = False
        Me.Editlabel.LinkColor = System.Drawing.Color.Gray
        Me.Editlabel.Location = New System.Drawing.Point(145, 14)
        Me.Editlabel.Name = "Editlabel"
        Me.Editlabel.Size = New System.Drawing.Size(57, 13)
        Me.Editlabel.TabIndex = 37
        Me.Editlabel.TabStop = True
        Me.Editlabel.Text = "Edit Grade"
        '
        'Surname
        '
        Me.Surname.Enabled = False
        Me.Surname.Location = New System.Drawing.Point(89, 100)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(121, 20)
        Me.Surname.TabIndex = 2
        '
        'Firstname
        '
        Me.Firstname.Enabled = False
        Me.Firstname.Location = New System.Drawing.Point(89, 71)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(121, 20)
        Me.Firstname.TabIndex = 1
        '
        'surnamlabel
        '
        Me.surnamlabel.AutoSize = True
        Me.surnamlabel.BackColor = System.Drawing.Color.Transparent
        Me.surnamlabel.ForeColor = System.Drawing.Color.Maroon
        Me.surnamlabel.Location = New System.Drawing.Point(11, 106)
        Me.surnamlabel.Name = "surnamlabel"
        Me.surnamlabel.Size = New System.Drawing.Size(52, 13)
        Me.surnamlabel.TabIndex = 39
        Me.surnamlabel.Text = "Surname:"
        '
        'firstnamelabel
        '
        Me.firstnamelabel.AutoSize = True
        Me.firstnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.firstnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.firstnamelabel.Location = New System.Drawing.Point(11, 78)
        Me.firstnamelabel.Name = "firstnamelabel"
        Me.firstnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.firstnamelabel.TabIndex = 38
        Me.firstnamelabel.Text = "Firstname:"
        '
        'edittitle
        '
        Me.edittitle.AutoSize = True
        Me.edittitle.BackColor = System.Drawing.Color.Transparent
        Me.edittitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edittitle.ForeColor = System.Drawing.Color.Maroon
        Me.edittitle.Location = New System.Drawing.Point(10, 39)
        Me.edittitle.Name = "edittitle"
        Me.edittitle.Size = New System.Drawing.Size(99, 24)
        Me.edittitle.TabIndex = 43
        Me.edittitle.Text = "Edit Grade"
        '
        'Yearlabel
        '
        Me.Yearlabel.AutoSize = True
        Me.Yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.Yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Yearlabel.Location = New System.Drawing.Point(11, 253)
        Me.Yearlabel.Name = "Yearlabel"
        Me.Yearlabel.Size = New System.Drawing.Size(32, 13)
        Me.Yearlabel.TabIndex = 57
        Me.Yearlabel.Text = "Year:"
        '
        'Levellabel
        '
        Me.Levellabel.AutoSize = True
        Me.Levellabel.BackColor = System.Drawing.Color.Transparent
        Me.Levellabel.ForeColor = System.Drawing.Color.Maroon
        Me.Levellabel.Location = New System.Drawing.Point(11, 159)
        Me.Levellabel.Name = "Levellabel"
        Me.Levellabel.Size = New System.Drawing.Size(36, 13)
        Me.Levellabel.TabIndex = 55
        Me.Levellabel.Text = "Level:"
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(89, 253)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(121, 21)
        Me.Yearfield.TabIndex = 7
        '
        'Gradelabel
        '
        Me.Gradelabel.AutoSize = True
        Me.Gradelabel.BackColor = System.Drawing.Color.Transparent
        Me.Gradelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gradelabel.Location = New System.Drawing.Point(11, 199)
        Me.Gradelabel.Name = "Gradelabel"
        Me.Gradelabel.Size = New System.Drawing.Size(39, 13)
        Me.Gradelabel.TabIndex = 53
        Me.Gradelabel.Text = "Grade:"
        '
        'Gradefield
        '
        Me.Gradefield.FormattingEnabled = True
        Me.Gradefield.Location = New System.Drawing.Point(89, 199)
        Me.Gradefield.Name = "Gradefield"
        Me.Gradefield.Size = New System.Drawing.Size(121, 21)
        Me.Gradefield.TabIndex = 5
        '
        'Subjectlabel
        '
        Me.Subjectlabel.AutoSize = True
        Me.Subjectlabel.BackColor = System.Drawing.Color.Transparent
        Me.Subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectlabel.Location = New System.Drawing.Point(11, 132)
        Me.Subjectlabel.Name = "Subjectlabel"
        Me.Subjectlabel.Size = New System.Drawing.Size(46, 13)
        Me.Subjectlabel.TabIndex = 51
        Me.Subjectlabel.Text = "Subject:"
        '
        'Gradetypelabel
        '
        Me.Gradetypelabel.AutoSize = True
        Me.Gradetypelabel.BackColor = System.Drawing.Color.Transparent
        Me.Gradetypelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gradetypelabel.Location = New System.Drawing.Point(11, 226)
        Me.Gradetypelabel.Name = "Gradetypelabel"
        Me.Gradetypelabel.Size = New System.Drawing.Size(66, 13)
        Me.Gradetypelabel.TabIndex = 61
        Me.Gradetypelabel.Text = "Grade Type:"
        '
        'Gradetypefield
        '
        Me.Gradetypefield.Enabled = False
        Me.Gradetypefield.FormattingEnabled = True
        Me.Gradetypefield.Location = New System.Drawing.Point(89, 226)
        Me.Gradetypefield.Name = "Gradetypefield"
        Me.Gradetypefield.Size = New System.Drawing.Size(121, 21)
        Me.Gradetypefield.TabIndex = 6
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Transparent
        Me.Edit.BackgroundImage = CType(resources.GetObject("Edit.BackgroundImage"), System.Drawing.Image)
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(44, 288)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 62
        Me.Edit.Text = "Edit Grade"
        Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.Transparent
        Me.Deletebtn.BackgroundImage = CType(resources.GetObject("Deletebtn.BackgroundImage"), System.Drawing.Image)
        Me.Deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Deletebtn.FlatAppearance.BorderSize = 0
        Me.Deletebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deletebtn.ForeColor = System.Drawing.Color.White
        Me.Deletebtn.Location = New System.Drawing.Point(151, 288)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(75, 23)
        Me.Deletebtn.TabIndex = 63
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'LevelField
        '
        Me.LevelField.Enabled = False
        Me.LevelField.FormattingEnabled = True
        Me.LevelField.Location = New System.Drawing.Point(89, 156)
        Me.LevelField.Name = "LevelField"
        Me.LevelField.Size = New System.Drawing.Size(121, 21)
        Me.LevelField.TabIndex = 4
        '
        'Subjectfield
        '
        Me.Subjectfield.Enabled = False
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(89, 129)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(121, 21)
        Me.Subjectfield.TabIndex = 3
        '
        'arrowlink1
        '
        Me.arrowlink1.AutoSize = True
        Me.arrowlink1.BackColor = System.Drawing.Color.White
        Me.arrowlink1.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.arrowlink1.Location = New System.Drawing.Point(68, 11)
        Me.arrowlink1.Name = "arrowlink1"
        Me.arrowlink1.Size = New System.Drawing.Size(25, 19)
        Me.arrowlink1.TabIndex = 66
        Me.arrowlink1.Text = "4"
        '
        'arrowlink
        '
        Me.arrowlink.AutoSize = True
        Me.arrowlink.BackColor = System.Drawing.Color.White
        Me.arrowlink.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.arrowlink.Location = New System.Drawing.Point(123, 11)
        Me.arrowlink.Name = "arrowlink"
        Me.arrowlink.Size = New System.Drawing.Size(25, 19)
        Me.arrowlink.TabIndex = 67
        Me.arrowlink.Text = "4"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(4, 5)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(241, 31)
        Me.banner.TabIndex = 72
        Me.banner.TabStop = False
        '
        'Edit_Grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(247, 323)
        Me.Controls.Add(Me.arrowlink)
        Me.Controls.Add(Me.arrowlink1)
        Me.Controls.Add(Me.LevelField)
        Me.Controls.Add(Me.Subjectfield)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Gradetypelabel)
        Me.Controls.Add(Me.Gradetypefield)
        Me.Controls.Add(Me.Yearlabel)
        Me.Controls.Add(Me.Levellabel)
        Me.Controls.Add(Me.Yearfield)
        Me.Controls.Add(Me.Gradelabel)
        Me.Controls.Add(Me.Gradefield)
        Me.Controls.Add(Me.Subjectlabel)
        Me.Controls.Add(Me.edittitle)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.surnamlabel)
        Me.Controls.Add(Me.firstnamelabel)
        Me.Controls.Add(Me.Editlabel)
        Me.Controls.Add(Me.SubjectLink)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(263, 361)
        Me.MinimumSize = New System.Drawing.Size(263, 361)
        Me.Name = "Edit_Grade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Grade"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubjectLink As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Editlabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Firstname As System.Windows.Forms.TextBox
    Friend WithEvents surnamlabel As System.Windows.Forms.Label
    Friend WithEvents firstnamelabel As System.Windows.Forms.Label
    Friend WithEvents edittitle As System.Windows.Forms.Label
    Friend WithEvents Yearlabel As System.Windows.Forms.Label
    Friend WithEvents Levellabel As System.Windows.Forms.Label
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents Gradelabel As System.Windows.Forms.Label
    Friend WithEvents Gradefield As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectlabel As System.Windows.Forms.Label
    Friend WithEvents Gradetypelabel As System.Windows.Forms.Label
    Friend WithEvents Gradetypefield As System.Windows.Forms.ComboBox
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents LevelField As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents arrowlink1 As System.Windows.Forms.Label
    Friend WithEvents arrowlink As System.Windows.Forms.Label
    Friend WithEvents banner As System.Windows.Forms.PictureBox
End Class
