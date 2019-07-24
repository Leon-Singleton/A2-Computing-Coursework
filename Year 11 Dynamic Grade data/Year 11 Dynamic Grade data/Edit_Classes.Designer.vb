<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Classes))
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.linkarrow2 = New System.Windows.Forms.Label()
        Me.Editclasseslink = New System.Windows.Forms.LinkLabel()
        Me.Subjectlabel = New System.Windows.Forms.Label()
        Me.Classgrouplabel = New System.Windows.Forms.Label()
        Me.Surnamelabel = New System.Windows.Forms.Label()
        Me.Firtnamelabel = New System.Windows.Forms.Label()
        Me.edittitle = New System.Windows.Forms.Label()
        Me.Yearlabel = New System.Windows.Forms.Label()
        Me.Surnamefield = New System.Windows.Forms.TextBox()
        Me.Firstnamefield = New System.Windows.Forms.TextBox()
        Me.Classgroupfield = New System.Windows.Forms.TextBox()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Banner = New System.Windows.Forms.PictureBox()
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.LinkColor = System.Drawing.Color.Blue
        Me.Classeslink.Location = New System.Drawing.Point(86, 15)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(86, 13)
        Me.Classeslink.TabIndex = 77
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Teacher Classes"
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(69, 12)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 76
        Me.linkarrow.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(13, 15)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 75
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'linkarrow2
        '
        Me.linkarrow2.AutoSize = True
        Me.linkarrow2.BackColor = System.Drawing.Color.White
        Me.linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow2.Location = New System.Drawing.Point(170, 12)
        Me.linkarrow2.Name = "linkarrow2"
        Me.linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow2.TabIndex = 78
        Me.linkarrow2.Text = "4"
        '
        'Editclasseslink
        '
        Me.Editclasseslink.AutoSize = True
        Me.Editclasseslink.BackColor = System.Drawing.Color.White
        Me.Editclasseslink.Enabled = False
        Me.Editclasseslink.LinkColor = System.Drawing.Color.Gray
        Me.Editclasseslink.Location = New System.Drawing.Point(187, 16)
        Me.Editclasseslink.Name = "Editclasseslink"
        Me.Editclasseslink.Size = New System.Drawing.Size(64, 13)
        Me.Editclasseslink.TabIndex = 79
        Me.Editclasseslink.TabStop = True
        Me.Editclasseslink.Text = "Edit Classes"
        '
        'Subjectlabel
        '
        Me.Subjectlabel.AutoSize = True
        Me.Subjectlabel.BackColor = System.Drawing.Color.Transparent
        Me.Subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectlabel.Location = New System.Drawing.Point(20, 166)
        Me.Subjectlabel.Name = "Subjectlabel"
        Me.Subjectlabel.Size = New System.Drawing.Size(46, 13)
        Me.Subjectlabel.TabIndex = 83
        Me.Subjectlabel.Text = "Subject:"
        '
        'Classgrouplabel
        '
        Me.Classgrouplabel.AutoSize = True
        Me.Classgrouplabel.BackColor = System.Drawing.Color.Transparent
        Me.Classgrouplabel.ForeColor = System.Drawing.Color.Maroon
        Me.Classgrouplabel.Location = New System.Drawing.Point(20, 139)
        Me.Classgrouplabel.Name = "Classgrouplabel"
        Me.Classgrouplabel.Size = New System.Drawing.Size(67, 13)
        Me.Classgrouplabel.TabIndex = 82
        Me.Classgrouplabel.Text = "Class Group:"
        '
        'Surnamelabel
        '
        Me.Surnamelabel.AutoSize = True
        Me.Surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Surnamelabel.Location = New System.Drawing.Point(20, 113)
        Me.Surnamelabel.Name = "Surnamelabel"
        Me.Surnamelabel.Size = New System.Drawing.Size(95, 13)
        Me.Surnamelabel.TabIndex = 81
        Me.Surnamelabel.Text = "Teacher Surname:"
        '
        'Firtnamelabel
        '
        Me.Firtnamelabel.AutoSize = True
        Me.Firtnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Firtnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Firtnamelabel.Location = New System.Drawing.Point(20, 85)
        Me.Firtnamelabel.Name = "Firtnamelabel"
        Me.Firtnamelabel.Size = New System.Drawing.Size(98, 13)
        Me.Firtnamelabel.TabIndex = 80
        Me.Firtnamelabel.Text = "Teacher Firstname:"
        '
        'edittitle
        '
        Me.edittitle.AutoSize = True
        Me.edittitle.BackColor = System.Drawing.Color.Transparent
        Me.edittitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edittitle.ForeColor = System.Drawing.Color.Maroon
        Me.edittitle.Location = New System.Drawing.Point(19, 46)
        Me.edittitle.Name = "edittitle"
        Me.edittitle.Size = New System.Drawing.Size(112, 24)
        Me.edittitle.TabIndex = 84
        Me.edittitle.Text = "Edit Classes"
        '
        'Yearlabel
        '
        Me.Yearlabel.AutoSize = True
        Me.Yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.Yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Yearlabel.Location = New System.Drawing.Point(20, 192)
        Me.Yearlabel.Name = "Yearlabel"
        Me.Yearlabel.Size = New System.Drawing.Size(32, 13)
        Me.Yearlabel.TabIndex = 86
        Me.Yearlabel.Text = "Year:"
        '
        'Surnamefield
        '
        Me.Surnamefield.Location = New System.Drawing.Point(122, 108)
        Me.Surnamefield.Name = "Surnamefield"
        Me.Surnamefield.Size = New System.Drawing.Size(121, 20)
        Me.Surnamefield.TabIndex = 2
        '
        'Firstnamefield
        '
        Me.Firstnamefield.Location = New System.Drawing.Point(122, 82)
        Me.Firstnamefield.Name = "Firstnamefield"
        Me.Firstnamefield.Size = New System.Drawing.Size(121, 20)
        Me.Firstnamefield.TabIndex = 1
        '
        'Classgroupfield
        '
        Me.Classgroupfield.Location = New System.Drawing.Point(122, 136)
        Me.Classgroupfield.Name = "Classgroupfield"
        Me.Classgroupfield.Size = New System.Drawing.Size(121, 20)
        Me.Classgroupfield.TabIndex = 3
        '
        'Subjectfield
        '
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(122, 166)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(121, 21)
        Me.Subjectfield.TabIndex = 4
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(122, 193)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(121, 21)
        Me.Yearfield.TabIndex = 5
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
        Me.Deletebtn.Location = New System.Drawing.Point(176, 223)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(75, 23)
        Me.Deletebtn.TabIndex = 95
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Deletebtn.UseVisualStyleBackColor = False
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
        Me.Edit.Location = New System.Drawing.Point(69, 223)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 94
        Me.Edit.Text = "Edit Class"
        Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Banner
        '
        Me.Banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd_2
        Me.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Banner.Location = New System.Drawing.Point(3, 6)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(296, 31)
        Me.Banner.TabIndex = 96
        Me.Banner.TabStop = False
        '
        'Edit_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(305, 258)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Yearfield)
        Me.Controls.Add(Me.Subjectfield)
        Me.Controls.Add(Me.Classgroupfield)
        Me.Controls.Add(Me.Surnamefield)
        Me.Controls.Add(Me.Firstnamefield)
        Me.Controls.Add(Me.Yearlabel)
        Me.Controls.Add(Me.edittitle)
        Me.Controls.Add(Me.Subjectlabel)
        Me.Controls.Add(Me.Classgrouplabel)
        Me.Controls.Add(Me.Surnamelabel)
        Me.Controls.Add(Me.Firtnamelabel)
        Me.Controls.Add(Me.Editclasseslink)
        Me.Controls.Add(Me.linkarrow2)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.Banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(321, 296)
        Me.MinimumSize = New System.Drawing.Size(321, 296)
        Me.Name = "Edit_Classes"
        Me.Text = "Edit Classes"
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents Editclasseslink As System.Windows.Forms.LinkLabel
    Friend WithEvents Subjectlabel As System.Windows.Forms.Label
    Friend WithEvents Classgrouplabel As System.Windows.Forms.Label
    Friend WithEvents Surnamelabel As System.Windows.Forms.Label
    Friend WithEvents Firtnamelabel As System.Windows.Forms.Label
    Friend WithEvents edittitle As System.Windows.Forms.Label
    Friend WithEvents Yearlabel As System.Windows.Forms.Label
    Friend WithEvents Surnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Firstnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Classgroupfield As System.Windows.Forms.TextBox
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Banner As System.Windows.Forms.PictureBox
End Class
