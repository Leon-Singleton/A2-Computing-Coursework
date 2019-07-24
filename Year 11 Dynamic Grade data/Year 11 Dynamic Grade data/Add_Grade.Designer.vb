<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Student_Grade
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Student_Grade))
        Me.Editlabel = New System.Windows.Forms.LinkLabel()
        Me.GradeLink = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.linkarrow1 = New System.Windows.Forms.Label()
        Me.linkarrow2 = New System.Windows.Forms.Label()
        Me.SearchStudent = New System.Windows.Forms.GroupBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.fieldlabel = New System.Windows.Forms.Label()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.SearchSNS = New System.Windows.Forms.ComboBox()
        Me.Addsearch = New System.Windows.Forms.Button()
        Me.SearchEthnicity = New System.Windows.Forms.ComboBox()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.AddGradeGrid = New System.Windows.Forms.DataGridView()
        Me.LevelField = New System.Windows.Forms.ComboBox()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.Gradetypelabel = New System.Windows.Forms.Label()
        Me.Gradetypefield = New System.Windows.Forms.ComboBox()
        Me.Yearlabel = New System.Windows.Forms.Label()
        Me.Levellabel = New System.Windows.Forms.Label()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.Gradelabel = New System.Windows.Forms.Label()
        Me.Gradefield = New System.Windows.Forms.ComboBox()
        Me.Subjectlabel = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.surnamelabel = New System.Windows.Forms.Label()
        Me.firstnamelabel = New System.Windows.Forms.Label()
        Me.Addgradegroup = New System.Windows.Forms.GroupBox()
        Me.Addgradebutton = New System.Windows.Forms.Button()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.printbutton = New System.Windows.Forms.Button()
        Me.SearchStudent.SuspendLayout()
        CType(Me.AddGradeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Addgradegroup.SuspendLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Editlabel
        '
        Me.Editlabel.AutoSize = True
        Me.Editlabel.BackColor = System.Drawing.Color.White
        Me.Editlabel.DisabledLinkColor = System.Drawing.Color.White
        Me.Editlabel.Enabled = False
        Me.Editlabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Editlabel.LinkColor = System.Drawing.Color.Gray
        Me.Editlabel.Location = New System.Drawing.Point(139, 14)
        Me.Editlabel.Name = "Editlabel"
        Me.Editlabel.Size = New System.Drawing.Size(58, 13)
        Me.Editlabel.TabIndex = 40
        Me.Editlabel.TabStop = True
        Me.Editlabel.Text = "Add Grade"
        '
        'GradeLink
        '
        Me.GradeLink.AutoSize = True
        Me.GradeLink.BackColor = System.Drawing.Color.White
        Me.GradeLink.DisabledLinkColor = System.Drawing.Color.White
        Me.GradeLink.Location = New System.Drawing.Point(84, 14)
        Me.GradeLink.Name = "GradeLink"
        Me.GradeLink.Size = New System.Drawing.Size(36, 13)
        Me.GradeLink.TabIndex = 39
        Me.GradeLink.TabStop = True
        Me.GradeLink.Text = "Grade"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(10, 14)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 38
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'linkarrow1
        '
        Me.linkarrow1.AutoSize = True
        Me.linkarrow1.BackColor = System.Drawing.Color.White
        Me.linkarrow1.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow1.Location = New System.Drawing.Point(62, 11)
        Me.linkarrow1.Name = "linkarrow1"
        Me.linkarrow1.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow1.TabIndex = 41
        Me.linkarrow1.Text = "4"
        '
        'linkarrow2
        '
        Me.linkarrow2.AutoSize = True
        Me.linkarrow2.BackColor = System.Drawing.Color.White
        Me.linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow2.Location = New System.Drawing.Point(117, 11)
        Me.linkarrow2.Name = "linkarrow2"
        Me.linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow2.TabIndex = 43
        Me.linkarrow2.Text = "4"
        '
        'SearchStudent
        '
        Me.SearchStudent.BackColor = System.Drawing.Color.Transparent
        Me.SearchStudent.Controls.Add(Me.wherelabel)
        Me.SearchStudent.Controls.Add(Me.fieldlabel)
        Me.SearchStudent.Controls.Add(Me.SearchForm)
        Me.SearchStudent.Controls.Add(Me.Field)
        Me.SearchStudent.Controls.Add(Me.SearchSNS)
        Me.SearchStudent.Controls.Add(Me.Addsearch)
        Me.SearchStudent.Controls.Add(Me.SearchEthnicity)
        Me.SearchStudent.Controls.Add(Me.SearchName)
        Me.SearchStudent.Controls.Add(Me.SearchGender)
        Me.SearchStudent.Controls.Add(Me.SearchYear)
        Me.SearchStudent.ForeColor = System.Drawing.Color.Maroon
        Me.SearchStudent.Location = New System.Drawing.Point(11, 63)
        Me.SearchStudent.Name = "SearchStudent"
        Me.SearchStudent.Size = New System.Drawing.Size(263, 141)
        Me.SearchStudent.TabIndex = 57
        Me.SearchStudent.TabStop = False
        Me.SearchStudent.Text = "Select a Student"
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(5, 63)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 57
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'fieldlabel
        '
        Me.fieldlabel.AutoSize = True
        Me.fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel.Location = New System.Drawing.Point(3, 30)
        Me.fieldlabel.Name = "fieldlabel"
        Me.fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel.TabIndex = 62
        Me.fieldlabel.Text = "Select an attribute:"
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(119, 55)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(139, 21)
        Me.SearchForm.TabIndex = 62
        Me.SearchForm.Visible = False
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Name", "Gender", "Form"})
        Me.Field.Location = New System.Drawing.Point(150, 25)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(108, 21)
        Me.Field.TabIndex = 1
        '
        'SearchSNS
        '
        Me.SearchSNS.FormattingEnabled = True
        Me.SearchSNS.Location = New System.Drawing.Point(119, 57)
        Me.SearchSNS.Name = "SearchSNS"
        Me.SearchSNS.Size = New System.Drawing.Size(139, 21)
        Me.SearchSNS.TabIndex = 61
        Me.SearchSNS.Visible = False
        '
        'Addsearch
        '
        Me.Addsearch.BackColor = System.Drawing.Color.Transparent
        Me.Addsearch.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Addsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addsearch.FlatAppearance.BorderSize = 0
        Me.Addsearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addsearch.ForeColor = System.Drawing.Color.White
        Me.Addsearch.Location = New System.Drawing.Point(76, 94)
        Me.Addsearch.Name = "Addsearch"
        Me.Addsearch.Size = New System.Drawing.Size(85, 31)
        Me.Addsearch.TabIndex = 55
        Me.Addsearch.Text = "Search"
        Me.Addsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Addsearch.UseVisualStyleBackColor = False
        Me.Addsearch.Visible = False
        '
        'SearchEthnicity
        '
        Me.SearchEthnicity.FormattingEnabled = True
        Me.SearchEthnicity.Location = New System.Drawing.Point(119, 56)
        Me.SearchEthnicity.Name = "SearchEthnicity"
        Me.SearchEthnicity.Size = New System.Drawing.Size(139, 21)
        Me.SearchEthnicity.TabIndex = 60
        Me.SearchEthnicity.Visible = False
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(119, 57)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(139, 20)
        Me.SearchName.TabIndex = 57
        Me.SearchName.Visible = False
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(119, 57)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(139, 21)
        Me.SearchGender.TabIndex = 59
        Me.SearchGender.Visible = False
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(119, 56)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(139, 21)
        Me.SearchYear.TabIndex = 63
        Me.SearchYear.Visible = False
        '
        'AddGradeGrid
        '
        Me.AddGradeGrid.AllowUserToAddRows = False
        Me.AddGradeGrid.AllowUserToDeleteRows = False
        Me.AddGradeGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AddGradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddGradeGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.AddGradeGrid.Location = New System.Drawing.Point(280, 63)
        Me.AddGradeGrid.Name = "AddGradeGrid"
        Me.AddGradeGrid.ReadOnly = True
        Me.AddGradeGrid.RowHeadersVisible = False
        Me.AddGradeGrid.Size = New System.Drawing.Size(681, 427)
        Me.AddGradeGrid.TabIndex = 58
        '
        'LevelField
        '
        Me.LevelField.FormattingEnabled = True
        Me.LevelField.Location = New System.Drawing.Point(127, 105)
        Me.LevelField.Name = "LevelField"
        Me.LevelField.Size = New System.Drawing.Size(121, 21)
        Me.LevelField.TabIndex = 6
        '
        'Subjectfield
        '
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(127, 78)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(121, 21)
        Me.Subjectfield.TabIndex = 5
        '
        'Gradetypelabel
        '
        Me.Gradetypelabel.AutoSize = True
        Me.Gradetypelabel.BackColor = System.Drawing.Color.Transparent
        Me.Gradetypelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gradetypelabel.Location = New System.Drawing.Point(10, 172)
        Me.Gradetypelabel.Name = "Gradetypelabel"
        Me.Gradetypelabel.Size = New System.Drawing.Size(66, 13)
        Me.Gradetypelabel.TabIndex = 77
        Me.Gradetypelabel.Text = "Grade Type:"
        '
        'Gradetypefield
        '
        Me.Gradetypefield.Enabled = False
        Me.Gradetypefield.FormattingEnabled = True
        Me.Gradetypefield.Location = New System.Drawing.Point(128, 164)
        Me.Gradetypefield.Name = "Gradetypefield"
        Me.Gradetypefield.Size = New System.Drawing.Size(121, 21)
        Me.Gradetypefield.TabIndex = 8
        '
        'Yearlabel
        '
        Me.Yearlabel.AutoSize = True
        Me.Yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.Yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Yearlabel.Location = New System.Drawing.Point(10, 198)
        Me.Yearlabel.Name = "Yearlabel"
        Me.Yearlabel.Size = New System.Drawing.Size(80, 13)
        Me.Yearlabel.TabIndex = 75
        Me.Yearlabel.Text = "Year Achieved:"
        '
        'Levellabel
        '
        Me.Levellabel.AutoSize = True
        Me.Levellabel.BackColor = System.Drawing.Color.Transparent
        Me.Levellabel.ForeColor = System.Drawing.Color.Maroon
        Me.Levellabel.Location = New System.Drawing.Point(10, 112)
        Me.Levellabel.Name = "Levellabel"
        Me.Levellabel.Size = New System.Drawing.Size(36, 13)
        Me.Levellabel.TabIndex = 74
        Me.Levellabel.Text = "Level:"
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(128, 191)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(121, 21)
        Me.Yearfield.TabIndex = 9
        '
        'Gradelabel
        '
        Me.Gradelabel.AutoSize = True
        Me.Gradelabel.BackColor = System.Drawing.Color.Transparent
        Me.Gradelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gradelabel.Location = New System.Drawing.Point(10, 145)
        Me.Gradelabel.Name = "Gradelabel"
        Me.Gradelabel.Size = New System.Drawing.Size(39, 13)
        Me.Gradelabel.TabIndex = 72
        Me.Gradelabel.Text = "Grade:"
        '
        'Gradefield
        '
        Me.Gradefield.FormattingEnabled = True
        Me.Gradefield.Location = New System.Drawing.Point(127, 137)
        Me.Gradefield.Name = "Gradefield"
        Me.Gradefield.Size = New System.Drawing.Size(121, 21)
        Me.Gradefield.TabIndex = 7
        '
        'Subjectlabel
        '
        Me.Subjectlabel.AutoSize = True
        Me.Subjectlabel.BackColor = System.Drawing.Color.Transparent
        Me.Subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectlabel.Location = New System.Drawing.Point(10, 85)
        Me.Subjectlabel.Name = "Subjectlabel"
        Me.Subjectlabel.Size = New System.Drawing.Size(46, 13)
        Me.Subjectlabel.TabIndex = 70
        Me.Subjectlabel.Text = "Subject:"
        '
        'Surname
        '
        Me.Surname.Enabled = False
        Me.Surname.Location = New System.Drawing.Point(127, 49)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(121, 20)
        Me.Surname.TabIndex = 4
        '
        'Firstname
        '
        Me.Firstname.Enabled = False
        Me.Firstname.Location = New System.Drawing.Point(127, 24)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(121, 20)
        Me.Firstname.TabIndex = 3
        '
        'surnamelabel
        '
        Me.surnamelabel.AutoSize = True
        Me.surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.surnamelabel.Location = New System.Drawing.Point(10, 55)
        Me.surnamelabel.Name = "surnamelabel"
        Me.surnamelabel.Size = New System.Drawing.Size(49, 13)
        Me.surnamelabel.TabIndex = 67
        Me.surnamelabel.Text = "Surname"
        '
        'firstnamelabel
        '
        Me.firstnamelabel.AutoSize = True
        Me.firstnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.firstnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.firstnamelabel.Location = New System.Drawing.Point(10, 27)
        Me.firstnamelabel.Name = "firstnamelabel"
        Me.firstnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.firstnamelabel.TabIndex = 66
        Me.firstnamelabel.Text = "Firstname:"
        '
        'Addgradegroup
        '
        Me.Addgradegroup.BackColor = System.Drawing.Color.Transparent
        Me.Addgradegroup.Controls.Add(Me.Addgradebutton)
        Me.Addgradegroup.Controls.Add(Me.Yearfield)
        Me.Addgradegroup.Controls.Add(Me.LevelField)
        Me.Addgradegroup.Controls.Add(Me.firstnamelabel)
        Me.Addgradegroup.Controls.Add(Me.Subjectfield)
        Me.Addgradegroup.Controls.Add(Me.surnamelabel)
        Me.Addgradegroup.Controls.Add(Me.Gradetypelabel)
        Me.Addgradegroup.Controls.Add(Me.Firstname)
        Me.Addgradegroup.Controls.Add(Me.Gradetypefield)
        Me.Addgradegroup.Controls.Add(Me.Surname)
        Me.Addgradegroup.Controls.Add(Me.Yearlabel)
        Me.Addgradegroup.Controls.Add(Me.Subjectlabel)
        Me.Addgradegroup.Controls.Add(Me.Levellabel)
        Me.Addgradegroup.Controls.Add(Me.Gradefield)
        Me.Addgradegroup.Controls.Add(Me.Gradelabel)
        Me.Addgradegroup.ForeColor = System.Drawing.Color.Maroon
        Me.Addgradegroup.Location = New System.Drawing.Point(11, 210)
        Me.Addgradegroup.Name = "Addgradegroup"
        Me.Addgradegroup.Size = New System.Drawing.Size(263, 280)
        Me.Addgradegroup.TabIndex = 80
        Me.Addgradegroup.TabStop = False
        Me.Addgradegroup.Text = "Add a Grade"
        Me.Addgradegroup.Visible = False
        '
        'Addgradebutton
        '
        Me.Addgradebutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Addgradebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addgradebutton.FlatAppearance.BorderSize = 0
        Me.Addgradebutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addgradebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addgradebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addgradebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addgradebutton.ForeColor = System.Drawing.Color.White
        Me.Addgradebutton.Location = New System.Drawing.Point(84, 230)
        Me.Addgradebutton.Name = "Addgradebutton"
        Me.Addgradebutton.Size = New System.Drawing.Size(92, 27)
        Me.Addgradebutton.TabIndex = 81
        Me.Addgradebutton.Text = "Add Grade"
        Me.Addgradebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Addgradebutton.UseVisualStyleBackColor = True
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(3, 5)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(921, 31)
        Me.banner.TabIndex = 81
        Me.banner.TabStop = False
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(8, 40)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(96, 20)
        Me.Formheader.TabIndex = 82
        Me.Formheader.Text = "Add Grade"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'printbutton
        '
        Me.printbutton.BackColor = System.Drawing.Color.Transparent
        Me.printbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.print_icon
        Me.printbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.printbutton.FlatAppearance.BorderSize = 0
        Me.printbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.printbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printbutton.Location = New System.Drawing.Point(930, 5)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 123
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'Add_Student_Grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(966, 500)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.Addgradegroup)
        Me.Controls.Add(Me.AddGradeGrid)
        Me.Controls.Add(Me.SearchStudent)
        Me.Controls.Add(Me.linkarrow2)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.linkarrow1)
        Me.Controls.Add(Me.Editlabel)
        Me.Controls.Add(Me.GradeLink)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(982, 538)
        Me.MinimumSize = New System.Drawing.Size(982, 538)
        Me.Name = "Add_Student_Grade"
        Me.Text = "Add Grade"
        Me.SearchStudent.ResumeLayout(False)
        Me.SearchStudent.PerformLayout()
        CType(Me.AddGradeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Addgradegroup.ResumeLayout(False)
        Me.Addgradegroup.PerformLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Editlabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GradeLink As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow1 As System.Windows.Forms.Label
    Friend WithEvents linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents SearchStudent As System.Windows.Forms.GroupBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents fieldlabel As System.Windows.Forms.Label
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSNS As System.Windows.Forms.ComboBox
    Friend WithEvents Addsearch As System.Windows.Forms.Button
    Friend WithEvents SearchEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents AddGradeGrid As System.Windows.Forms.DataGridView
    Friend WithEvents LevelField As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents Gradetypelabel As System.Windows.Forms.Label
    Friend WithEvents Gradetypefield As System.Windows.Forms.ComboBox
    Friend WithEvents Yearlabel As System.Windows.Forms.Label
    Friend WithEvents Levellabel As System.Windows.Forms.Label
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents Gradelabel As System.Windows.Forms.Label
    Friend WithEvents Gradefield As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectlabel As System.Windows.Forms.Label
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Firstname As System.Windows.Forms.TextBox
    Friend WithEvents surnamelabel As System.Windows.Forms.Label
    Friend WithEvents firstnamelabel As System.Windows.Forms.Label
    Friend WithEvents Addgradegroup As System.Windows.Forms.GroupBox
    Friend WithEvents Addgradebutton As System.Windows.Forms.Button
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents printbutton As System.Windows.Forms.Button
End Class
