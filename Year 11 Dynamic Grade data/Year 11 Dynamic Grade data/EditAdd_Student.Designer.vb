<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Edit_Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Edit_Student))
        Me.Add_Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Fnamelabel = New System.Windows.Forms.Label()
        Me.Snamelabel = New System.Windows.Forms.Label()
        Me.Genderlabel = New System.Windows.Forms.Label()
        Me.FSMlabel = New System.Windows.Forms.Label()
        Me.SNSlabel = New System.Windows.Forms.Label()
        Me.Ethnicitylabel = New System.Windows.Forms.Label()
        Me.Attendancelabel = New System.Windows.Forms.Label()
        Me.DOBlabel = New System.Windows.Forms.Label()
        Me.Formlabel = New System.Windows.Forms.Label()
        Me.Yearlabel = New System.Windows.Forms.Label()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Free_School_Meals = New System.Windows.Forms.ComboBox()
        Me.Form = New System.Windows.Forms.TextBox()
        Me.Attendance = New System.Windows.Forms.TextBox()
        Me.Year = New System.Windows.Forms.TextBox()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Adddetail = New System.Windows.Forms.Label()
        Me.SNS = New System.Windows.Forms.TextBox()
        Me.Ethnicity = New System.Windows.Forms.TextBox()
        Me.Datasetlabel = New System.Windows.Forms.Label()
        Me.Student = New System.Windows.Forms.LinkLabel()
        Me.editlabel = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.linkarrow2 = New System.Windows.Forms.Label()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Dataset = New System.Windows.Forms.ComboBox()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Add_Edit.Location = New System.Drawing.Point(128, 412)
        Me.Add_Edit.Name = "Add_Edit"
        Me.Add_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Add_Edit.TabIndex = 1
        Me.Add_Edit.Text = "Add"
        Me.Add_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Add_Edit.UseVisualStyleBackColor = False
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
        Me.Delete.Location = New System.Drawing.Point(267, 412)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Delete"
        Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Delete.UseVisualStyleBackColor = False
        Me.Delete.Visible = False
        '
        'Fnamelabel
        '
        Me.Fnamelabel.AutoSize = True
        Me.Fnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Fnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Fnamelabel.Location = New System.Drawing.Point(11, 77)
        Me.Fnamelabel.Name = "Fnamelabel"
        Me.Fnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.Fnamelabel.TabIndex = 3
        Me.Fnamelabel.Text = "Firstname:"
        '
        'Snamelabel
        '
        Me.Snamelabel.AutoSize = True
        Me.Snamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Snamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Snamelabel.Location = New System.Drawing.Point(11, 105)
        Me.Snamelabel.Name = "Snamelabel"
        Me.Snamelabel.Size = New System.Drawing.Size(49, 13)
        Me.Snamelabel.TabIndex = 4
        Me.Snamelabel.Text = "Surname"
        '
        'Genderlabel
        '
        Me.Genderlabel.AutoSize = True
        Me.Genderlabel.BackColor = System.Drawing.Color.Transparent
        Me.Genderlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Genderlabel.Location = New System.Drawing.Point(11, 137)
        Me.Genderlabel.Name = "Genderlabel"
        Me.Genderlabel.Size = New System.Drawing.Size(45, 13)
        Me.Genderlabel.TabIndex = 5
        Me.Genderlabel.Text = "Gender:"
        '
        'FSMlabel
        '
        Me.FSMlabel.AutoSize = True
        Me.FSMlabel.BackColor = System.Drawing.Color.Transparent
        Me.FSMlabel.ForeColor = System.Drawing.Color.Maroon
        Me.FSMlabel.Location = New System.Drawing.Point(11, 293)
        Me.FSMlabel.Name = "FSMlabel"
        Me.FSMlabel.Size = New System.Drawing.Size(180, 13)
        Me.FSMlabel.TabIndex = 6
        Me.FSMlabel.Text = "Entitled To Free School Meals(FSM):"
        '
        'SNSlabel
        '
        Me.SNSlabel.AutoSize = True
        Me.SNSlabel.BackColor = System.Drawing.Color.Transparent
        Me.SNSlabel.ForeColor = System.Drawing.Color.Maroon
        Me.SNSlabel.Location = New System.Drawing.Point(11, 261)
        Me.SNSlabel.Name = "SNSlabel"
        Me.SNSlabel.Size = New System.Drawing.Size(140, 13)
        Me.SNSlabel.TabIndex = 7
        Me.SNSlabel.Text = "Special Needs Status(SNS):"
        '
        'Ethnicitylabel
        '
        Me.Ethnicitylabel.AutoSize = True
        Me.Ethnicitylabel.BackColor = System.Drawing.Color.Transparent
        Me.Ethnicitylabel.ForeColor = System.Drawing.Color.Maroon
        Me.Ethnicitylabel.Location = New System.Drawing.Point(11, 168)
        Me.Ethnicitylabel.Name = "Ethnicitylabel"
        Me.Ethnicitylabel.Size = New System.Drawing.Size(50, 13)
        Me.Ethnicitylabel.TabIndex = 8
        Me.Ethnicitylabel.Text = "Ethnicity:"
        '
        'Attendancelabel
        '
        Me.Attendancelabel.AutoSize = True
        Me.Attendancelabel.BackColor = System.Drawing.Color.Transparent
        Me.Attendancelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Attendancelabel.Location = New System.Drawing.Point(11, 199)
        Me.Attendancelabel.Name = "Attendancelabel"
        Me.Attendancelabel.Size = New System.Drawing.Size(79, 13)
        Me.Attendancelabel.TabIndex = 9
        Me.Attendancelabel.Text = "Attendance(%):"
        '
        'DOBlabel
        '
        Me.DOBlabel.AutoSize = True
        Me.DOBlabel.BackColor = System.Drawing.Color.Transparent
        Me.DOBlabel.ForeColor = System.Drawing.Color.Maroon
        Me.DOBlabel.Location = New System.Drawing.Point(11, 230)
        Me.DOBlabel.Name = "DOBlabel"
        Me.DOBlabel.Size = New System.Drawing.Size(71, 13)
        Me.DOBlabel.TabIndex = 10
        Me.DOBlabel.Text = "Date Of Birth:"
        '
        'Formlabel
        '
        Me.Formlabel.AutoSize = True
        Me.Formlabel.BackColor = System.Drawing.Color.Transparent
        Me.Formlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Formlabel.Location = New System.Drawing.Point(11, 324)
        Me.Formlabel.Name = "Formlabel"
        Me.Formlabel.Size = New System.Drawing.Size(33, 13)
        Me.Formlabel.TabIndex = 11
        Me.Formlabel.Text = "Form:"
        '
        'Yearlabel
        '
        Me.Yearlabel.AutoSize = True
        Me.Yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.Yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Yearlabel.Location = New System.Drawing.Point(11, 355)
        Me.Yearlabel.Name = "Yearlabel"
        Me.Yearlabel.Size = New System.Drawing.Size(105, 13)
        Me.Yearlabel.TabIndex = 12
        Me.Yearlabel.Text = "Current School Year:"
        '
        'Firstname
        '
        Me.Firstname.Location = New System.Drawing.Point(210, 67)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(132, 20)
        Me.Firstname.TabIndex = 1
        '
        'Surname
        '
        Me.Surname.Location = New System.Drawing.Point(210, 98)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(132, 20)
        Me.Surname.TabIndex = 2
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(210, 129)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(132, 21)
        Me.Gender.TabIndex = 3
        '
        'Free_School_Meals
        '
        Me.Free_School_Meals.FormattingEnabled = True
        Me.Free_School_Meals.Location = New System.Drawing.Point(210, 285)
        Me.Free_School_Meals.Name = "Free_School_Meals"
        Me.Free_School_Meals.Size = New System.Drawing.Size(132, 21)
        Me.Free_School_Meals.TabIndex = 8
        '
        'Form
        '
        Me.Form.Location = New System.Drawing.Point(210, 317)
        Me.Form.Name = "Form"
        Me.Form.Size = New System.Drawing.Size(132, 20)
        Me.Form.TabIndex = 9
        '
        'Attendance
        '
        Me.Attendance.Location = New System.Drawing.Point(210, 192)
        Me.Attendance.Name = "Attendance"
        Me.Attendance.Size = New System.Drawing.Size(132, 20)
        Me.Attendance.TabIndex = 5
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(210, 348)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(132, 20)
        Me.Year.TabIndex = 10
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Location = New System.Drawing.Point(210, 223)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(132, 20)
        Me.DateOfBirth.TabIndex = 6
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(19, 14)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 32
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Adddetail
        '
        Me.Adddetail.AutoSize = True
        Me.Adddetail.BackColor = System.Drawing.Color.Transparent
        Me.Adddetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adddetail.ForeColor = System.Drawing.Color.Maroon
        Me.Adddetail.Location = New System.Drawing.Point(10, 40)
        Me.Adddetail.Name = "Adddetail"
        Me.Adddetail.Size = New System.Drawing.Size(193, 24)
        Me.Adddetail.TabIndex = 34
        Me.Adddetail.Text = "Add Student Details"
        '
        'SNS
        '
        Me.SNS.Location = New System.Drawing.Point(210, 254)
        Me.SNS.Name = "SNS"
        Me.SNS.Size = New System.Drawing.Size(132, 20)
        Me.SNS.TabIndex = 7
        '
        'Ethnicity
        '
        Me.Ethnicity.Location = New System.Drawing.Point(210, 161)
        Me.Ethnicity.Name = "Ethnicity"
        Me.Ethnicity.Size = New System.Drawing.Size(132, 20)
        Me.Ethnicity.TabIndex = 4
        '
        'Datasetlabel
        '
        Me.Datasetlabel.AutoSize = True
        Me.Datasetlabel.BackColor = System.Drawing.Color.Transparent
        Me.Datasetlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Datasetlabel.Location = New System.Drawing.Point(11, 387)
        Me.Datasetlabel.Name = "Datasetlabel"
        Me.Datasetlabel.Size = New System.Drawing.Size(66, 13)
        Me.Datasetlabel.TabIndex = 38
        Me.Datasetlabel.Text = "Exams Year:"
        '
        'Student
        '
        Me.Student.AutoSize = True
        Me.Student.BackColor = System.Drawing.Color.White
        Me.Student.Location = New System.Drawing.Point(98, 14)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(44, 13)
        Me.Student.TabIndex = 39
        Me.Student.TabStop = True
        Me.Student.Text = "Student"
        '
        'editlabel
        '
        Me.editlabel.AutoSize = True
        Me.editlabel.BackColor = System.Drawing.Color.White
        Me.editlabel.Enabled = False
        Me.editlabel.ForeColor = System.Drawing.Color.Transparent
        Me.editlabel.LinkColor = System.Drawing.Color.Gray
        Me.editlabel.Location = New System.Drawing.Point(163, 14)
        Me.editlabel.Name = "editlabel"
        Me.editlabel.Size = New System.Drawing.Size(66, 13)
        Me.editlabel.TabIndex = 40
        Me.editlabel.TabStop = True
        Me.editlabel.Text = "Add Student"
        Me.editlabel.VisitedLinkColor = System.Drawing.Color.Maroon
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(76, 11)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 67
        Me.linkarrow.Text = "4"
        '
        'linkarrow2
        '
        Me.linkarrow2.AutoSize = True
        Me.linkarrow2.BackColor = System.Drawing.Color.White
        Me.linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow2.Location = New System.Drawing.Point(139, 11)
        Me.linkarrow2.Name = "linkarrow2"
        Me.linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow2.TabIndex = 68
        Me.linkarrow2.Text = "4"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(7, 5)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(343, 31)
        Me.banner.TabIndex = 71
        Me.banner.TabStop = False
        '
        'Dataset
        '
        Me.Dataset.FormattingEnabled = True
        Me.Dataset.Location = New System.Drawing.Point(210, 379)
        Me.Dataset.Name = "Dataset"
        Me.Dataset.Size = New System.Drawing.Size(132, 21)
        Me.Dataset.TabIndex = 10
        '
        'Add_Edit_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(354, 443)
        Me.Controls.Add(Me.Dataset)
        Me.Controls.Add(Me.linkarrow2)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.editlabel)
        Me.Controls.Add(Me.Student)
        Me.Controls.Add(Me.Datasetlabel)
        Me.Controls.Add(Me.Ethnicity)
        Me.Controls.Add(Me.SNS)
        Me.Controls.Add(Me.Adddetail)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Form)
        Me.Controls.Add(Me.Attendance)
        Me.Controls.Add(Me.Free_School_Meals)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Yearlabel)
        Me.Controls.Add(Me.Formlabel)
        Me.Controls.Add(Me.DOBlabel)
        Me.Controls.Add(Me.Attendancelabel)
        Me.Controls.Add(Me.Ethnicitylabel)
        Me.Controls.Add(Me.SNSlabel)
        Me.Controls.Add(Me.FSMlabel)
        Me.Controls.Add(Me.Genderlabel)
        Me.Controls.Add(Me.Snamelabel)
        Me.Controls.Add(Me.Fnamelabel)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add_Edit)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(370, 481)
        Me.MinimumSize = New System.Drawing.Size(370, 481)
        Me.Name = "Add_Edit_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add_Edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Fnamelabel As System.Windows.Forms.Label
    Friend WithEvents Snamelabel As System.Windows.Forms.Label
    Friend WithEvents Genderlabel As System.Windows.Forms.Label
    Friend WithEvents FSMlabel As System.Windows.Forms.Label
    Friend WithEvents SNSlabel As System.Windows.Forms.Label
    Friend WithEvents Ethnicitylabel As System.Windows.Forms.Label
    Friend WithEvents Attendancelabel As System.Windows.Forms.Label
    Friend WithEvents DOBlabel As System.Windows.Forms.Label
    Friend WithEvents Formlabel As System.Windows.Forms.Label
    Friend WithEvents Yearlabel As System.Windows.Forms.Label
    Friend WithEvents Firstname As System.Windows.Forms.TextBox
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Free_School_Meals As System.Windows.Forms.ComboBox
    Friend WithEvents Form As System.Windows.Forms.TextBox
    Friend WithEvents Attendance As System.Windows.Forms.TextBox
    Friend WithEvents Year As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Adddetail As System.Windows.Forms.Label
    Friend WithEvents SNS As System.Windows.Forms.TextBox
    Friend WithEvents Ethnicity As System.Windows.Forms.TextBox
    Friend WithEvents Datasetlabel As System.Windows.Forms.Label
    Friend WithEvents Student As System.Windows.Forms.LinkLabel
    Friend WithEvents editlabel As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Dataset As System.Windows.Forms.ComboBox
End Class
