<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.studentdetailsbutton = New System.Windows.Forms.Button()
        Me.teacherdetailsbutton = New System.Windows.Forms.Button()
        Me.Formtitle = New System.Windows.Forms.Label()
        Me.StudentGroup = New System.Windows.Forms.GroupBox()
        Me.StudentClasses = New System.Windows.Forms.Button()
        Me.Teacherclassesbutton = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Logo2 = New System.Windows.Forms.PictureBox()
        Me.Adminbutton = New System.Windows.Forms.Button()
        Me.TeacherGroup = New System.Windows.Forms.GroupBox()
        Me.Logout = New System.Windows.Forms.Button()
        Me.currentuser = New System.Windows.Forms.Label()
        Me.Gradegroup = New System.Windows.Forms.GroupBox()
        Me.Gradepercentages = New System.Windows.Forms.Button()
        Me.viewgradesbutton = New System.Windows.Forms.Button()
        Me.Predictionsgroup = New System.Windows.Forms.GroupBox()
        Me.gradepercentages1 = New System.Windows.Forms.Button()
        Me.gradepredictsbutton = New System.Windows.Forms.Button()
        Me.Comparegroup = New System.Windows.Forms.GroupBox()
        Me.Departments = New System.Windows.Forms.Button()
        Me.Classes = New System.Windows.Forms.Button()
        Me.Subjects = New System.Windows.Forms.Button()
        Me.Myclassesgroup = New System.Windows.Forms.GroupBox()
        Me.ClassGrades = New System.Windows.Forms.Button()
        Me.myclassesbutton = New System.Windows.Forms.Button()
        Me.catchphrase = New System.Windows.Forms.Label()
        Me.datasetcombo = New System.Windows.Forms.ComboBox()
        Me.datasetcombolabel = New System.Windows.Forms.Label()
        Me.StudentGroup.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeacherGroup.SuspendLayout()
        Me.Gradegroup.SuspendLayout()
        Me.Predictionsgroup.SuspendLayout()
        Me.Comparegroup.SuspendLayout()
        Me.Myclassesgroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentdetailsbutton
        '
        Me.studentdetailsbutton.BackColor = System.Drawing.Color.Transparent
        Me.studentdetailsbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.student_details_button
        Me.studentdetailsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentdetailsbutton.FlatAppearance.BorderSize = 0
        Me.studentdetailsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.studentdetailsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.studentdetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentdetailsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.studentdetailsbutton.ForeColor = System.Drawing.Color.White
        Me.studentdetailsbutton.Location = New System.Drawing.Point(10, 31)
        Me.studentdetailsbutton.Name = "studentdetailsbutton"
        Me.studentdetailsbutton.Size = New System.Drawing.Size(125, 48)
        Me.studentdetailsbutton.TabIndex = 0
        Me.studentdetailsbutton.Text = "  Student Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.studentdetailsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.studentdetailsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.studentdetailsbutton.UseVisualStyleBackColor = False
        '
        'teacherdetailsbutton
        '
        Me.teacherdetailsbutton.BackColor = System.Drawing.Color.Transparent
        Me.teacherdetailsbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.teacher_details_button
        Me.teacherdetailsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.teacherdetailsbutton.FlatAppearance.BorderSize = 0
        Me.teacherdetailsbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.teacherdetailsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.teacherdetailsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.teacherdetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teacherdetailsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.teacherdetailsbutton.ForeColor = System.Drawing.Color.White
        Me.teacherdetailsbutton.Location = New System.Drawing.Point(6, 33)
        Me.teacherdetailsbutton.Name = "teacherdetailsbutton"
        Me.teacherdetailsbutton.Size = New System.Drawing.Size(132, 45)
        Me.teacherdetailsbutton.TabIndex = 4
        Me.teacherdetailsbutton.Text = " Teacher Details"
        Me.teacherdetailsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.teacherdetailsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.teacherdetailsbutton.UseVisualStyleBackColor = False
        '
        'Formtitle
        '
        Me.Formtitle.AutoSize = True
        Me.Formtitle.BackColor = System.Drawing.Color.Transparent
        Me.Formtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formtitle.ForeColor = System.Drawing.Color.Maroon
        Me.Formtitle.Location = New System.Drawing.Point(201, 29)
        Me.Formtitle.Name = "Formtitle"
        Me.Formtitle.Size = New System.Drawing.Size(413, 42)
        Me.Formtitle.TabIndex = 8
        Me.Formtitle.Text = "Year 11 Dynamic Data"
        '
        'StudentGroup
        '
        Me.StudentGroup.BackColor = System.Drawing.Color.Transparent
        Me.StudentGroup.Controls.Add(Me.studentdetailsbutton)
        Me.StudentGroup.Controls.Add(Me.StudentClasses)
        Me.StudentGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGroup.ForeColor = System.Drawing.Color.Maroon
        Me.StudentGroup.Location = New System.Drawing.Point(11, 123)
        Me.StudentGroup.Name = "StudentGroup"
        Me.StudentGroup.Size = New System.Drawing.Size(147, 173)
        Me.StudentGroup.TabIndex = 9
        Me.StudentGroup.TabStop = False
        Me.StudentGroup.Text = "Student Details"
        '
        'StudentClasses
        '
        Me.StudentClasses.BackColor = System.Drawing.Color.Transparent
        Me.StudentClasses.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.student_classes_button
        Me.StudentClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentClasses.FlatAppearance.BorderSize = 0
        Me.StudentClasses.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.StudentClasses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StudentClasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StudentClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StudentClasses.ForeColor = System.Drawing.Color.White
        Me.StudentClasses.Location = New System.Drawing.Point(10, 100)
        Me.StudentClasses.Name = "StudentClasses"
        Me.StudentClasses.Size = New System.Drawing.Size(125, 46)
        Me.StudentClasses.TabIndex = 15
        Me.StudentClasses.Text = "  Student Classes"
        Me.StudentClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StudentClasses.UseVisualStyleBackColor = False
        '
        'Teacherclassesbutton
        '
        Me.Teacherclassesbutton.BackColor = System.Drawing.Color.Transparent
        Me.Teacherclassesbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.teacher_class_button
        Me.Teacherclassesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Teacherclassesbutton.FlatAppearance.BorderSize = 0
        Me.Teacherclassesbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Teacherclassesbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Teacherclassesbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Teacherclassesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Teacherclassesbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Teacherclassesbutton.ForeColor = System.Drawing.Color.White
        Me.Teacherclassesbutton.Location = New System.Drawing.Point(6, 101)
        Me.Teacherclassesbutton.Name = "Teacherclassesbutton"
        Me.Teacherclassesbutton.Size = New System.Drawing.Size(132, 45)
        Me.Teacherclassesbutton.TabIndex = 5
        Me.Teacherclassesbutton.Text = " Teacher Classes"
        Me.Teacherclassesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Teacherclassesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Teacherclassesbutton.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(3, 5)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(71, 99)
        Me.Logo.TabIndex = 11
        Me.Logo.TabStop = False
        '
        'Logo2
        '
        Me.Logo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Logo2.BackColor = System.Drawing.Color.Transparent
        Me.Logo2.BackgroundImage = CType(resources.GetObject("Logo2.BackgroundImage"), System.Drawing.Image)
        Me.Logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo2.Location = New System.Drawing.Point(749, 5)
        Me.Logo2.Name = "Logo2"
        Me.Logo2.Size = New System.Drawing.Size(71, 99)
        Me.Logo2.TabIndex = 12
        Me.Logo2.TabStop = False
        '
        'Adminbutton
        '
        Me.Adminbutton.BackColor = System.Drawing.Color.Transparent
        Me.Adminbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Adminbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Adminbutton.FlatAppearance.BorderSize = 0
        Me.Adminbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Adminbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Adminbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Adminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adminbutton.ForeColor = System.Drawing.Color.White
        Me.Adminbutton.Location = New System.Drawing.Point(345, 312)
        Me.Adminbutton.Name = "Adminbutton"
        Me.Adminbutton.Size = New System.Drawing.Size(125, 45)
        Me.Adminbutton.TabIndex = 14
        Me.Adminbutton.Text = "Admin Features"
        Me.Adminbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Adminbutton.UseVisualStyleBackColor = False
        '
        'TeacherGroup
        '
        Me.TeacherGroup.BackColor = System.Drawing.Color.Transparent
        Me.TeacherGroup.Controls.Add(Me.Teacherclassesbutton)
        Me.TeacherGroup.Controls.Add(Me.teacherdetailsbutton)
        Me.TeacherGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherGroup.ForeColor = System.Drawing.Color.Maroon
        Me.TeacherGroup.Location = New System.Drawing.Point(167, 123)
        Me.TeacherGroup.Name = "TeacherGroup"
        Me.TeacherGroup.Size = New System.Drawing.Size(147, 173)
        Me.TeacherGroup.TabIndex = 11
        Me.TeacherGroup.TabStop = False
        Me.TeacherGroup.Text = "Teacher Details"
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.BackgroundImage = CType(resources.GetObject("Logout.BackgroundImage"), System.Drawing.Image)
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.ForeColor = System.Drawing.Color.Transparent
        Me.Logout.Location = New System.Drawing.Point(787, 326)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(33, 32)
        Me.Logout.TabIndex = 16
        Me.Logout.UseVisualStyleBackColor = False
        '
        'currentuser
        '
        Me.currentuser.AutoSize = True
        Me.currentuser.BackColor = System.Drawing.Color.Transparent
        Me.currentuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentuser.ForeColor = System.Drawing.Color.Maroon
        Me.currentuser.Location = New System.Drawing.Point(539, 341)
        Me.currentuser.Name = "currentuser"
        Me.currentuser.Size = New System.Drawing.Size(144, 16)
        Me.currentuser.TabIndex = 15
        Me.currentuser.Text = "Currently Logged in as:"
        '
        'Gradegroup
        '
        Me.Gradegroup.BackColor = System.Drawing.Color.Transparent
        Me.Gradegroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Gradegroup.Controls.Add(Me.Gradepercentages)
        Me.Gradegroup.Controls.Add(Me.viewgradesbutton)
        Me.Gradegroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Gradegroup.ForeColor = System.Drawing.Color.Maroon
        Me.Gradegroup.Location = New System.Drawing.Point(323, 123)
        Me.Gradegroup.Name = "Gradegroup"
        Me.Gradegroup.Size = New System.Drawing.Size(147, 173)
        Me.Gradegroup.TabIndex = 10
        Me.Gradegroup.TabStop = False
        Me.Gradegroup.Text = "Grade Details"
        '
        'Gradepercentages
        '
        Me.Gradepercentages.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.view_percentage_button
        Me.Gradepercentages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Gradepercentages.FlatAppearance.BorderSize = 0
        Me.Gradepercentages.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Gradepercentages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Gradepercentages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Gradepercentages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gradepercentages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Gradepercentages.ForeColor = System.Drawing.Color.White
        Me.Gradepercentages.Location = New System.Drawing.Point(6, 100)
        Me.Gradepercentages.Name = "Gradepercentages"
        Me.Gradepercentages.Size = New System.Drawing.Size(125, 46)
        Me.Gradepercentages.TabIndex = 2
        Me.Gradepercentages.Text = "  Percentages"
        Me.Gradepercentages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Gradepercentages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Gradepercentages.UseVisualStyleBackColor = True
        '
        'viewgradesbutton
        '
        Me.viewgradesbutton.BackColor = System.Drawing.Color.Transparent
        Me.viewgradesbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.view_grades_button
        Me.viewgradesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewgradesbutton.FlatAppearance.BorderSize = 0
        Me.viewgradesbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.viewgradesbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.viewgradesbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.viewgradesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewgradesbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.viewgradesbutton.ForeColor = System.Drawing.Color.White
        Me.viewgradesbutton.Location = New System.Drawing.Point(6, 33)
        Me.viewgradesbutton.Name = "viewgradesbutton"
        Me.viewgradesbutton.Size = New System.Drawing.Size(125, 45)
        Me.viewgradesbutton.TabIndex = 1
        Me.viewgradesbutton.Text = "  View Grades"
        Me.viewgradesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewgradesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.viewgradesbutton.UseVisualStyleBackColor = False
        '
        'Predictionsgroup
        '
        Me.Predictionsgroup.BackColor = System.Drawing.Color.Transparent
        Me.Predictionsgroup.Controls.Add(Me.gradepercentages1)
        Me.Predictionsgroup.Controls.Add(Me.gradepredictsbutton)
        Me.Predictionsgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Predictionsgroup.ForeColor = System.Drawing.Color.Maroon
        Me.Predictionsgroup.Location = New System.Drawing.Point(476, 123)
        Me.Predictionsgroup.Name = "Predictionsgroup"
        Me.Predictionsgroup.Size = New System.Drawing.Size(147, 173)
        Me.Predictionsgroup.TabIndex = 11
        Me.Predictionsgroup.TabStop = False
        Me.Predictionsgroup.Text = "Grade Predictions"
        '
        'gradepercentages1
        '
        Me.gradepercentages1.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.view_percentage_button
        Me.gradepercentages1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gradepercentages1.FlatAppearance.BorderSize = 0
        Me.gradepercentages1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.gradepercentages1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gradepercentages1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gradepercentages1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gradepercentages1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gradepercentages1.ForeColor = System.Drawing.Color.White
        Me.gradepercentages1.Location = New System.Drawing.Point(13, 100)
        Me.gradepercentages1.Name = "gradepercentages1"
        Me.gradepercentages1.Size = New System.Drawing.Size(125, 46)
        Me.gradepercentages1.TabIndex = 95
        Me.gradepercentages1.Text = "  Percentages"
        Me.gradepercentages1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gradepercentages1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.gradepercentages1.UseVisualStyleBackColor = True
        Me.gradepercentages1.Visible = False
        '
        'gradepredictsbutton
        '
        Me.gradepredictsbutton.BackColor = System.Drawing.Color.Transparent
        Me.gradepredictsbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.predict_button
        Me.gradepredictsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gradepredictsbutton.FlatAppearance.BorderSize = 0
        Me.gradepredictsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gradepredictsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gradepredictsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gradepredictsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gradepredictsbutton.ForeColor = System.Drawing.Color.White
        Me.gradepredictsbutton.Location = New System.Drawing.Point(13, 33)
        Me.gradepredictsbutton.Name = "gradepredictsbutton"
        Me.gradepredictsbutton.Size = New System.Drawing.Size(125, 45)
        Me.gradepredictsbutton.TabIndex = 6
        Me.gradepredictsbutton.Text = "  Grade Predicts"
        Me.gradepredictsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gradepredictsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.gradepredictsbutton.UseVisualStyleBackColor = False
        '
        'Comparegroup
        '
        Me.Comparegroup.BackColor = System.Drawing.Color.Transparent
        Me.Comparegroup.Controls.Add(Me.Departments)
        Me.Comparegroup.Controls.Add(Me.Classes)
        Me.Comparegroup.Controls.Add(Me.Subjects)
        Me.Comparegroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comparegroup.ForeColor = System.Drawing.Color.Maroon
        Me.Comparegroup.Location = New System.Drawing.Point(629, 123)
        Me.Comparegroup.Name = "Comparegroup"
        Me.Comparegroup.Size = New System.Drawing.Size(185, 173)
        Me.Comparegroup.TabIndex = 94
        Me.Comparegroup.TabStop = False
        Me.Comparegroup.Text = "Compare Performance By:"
        '
        'Departments
        '
        Me.Departments.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.department_percentage_button
        Me.Departments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Departments.FlatAppearance.BorderSize = 0
        Me.Departments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Departments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Departments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Departments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Departments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Departments.ForeColor = System.Drawing.Color.White
        Me.Departments.Location = New System.Drawing.Point(31, 121)
        Me.Departments.Name = "Departments"
        Me.Departments.Size = New System.Drawing.Size(125, 45)
        Me.Departments.TabIndex = 97
        Me.Departments.Text = " Department "
        Me.Departments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Departments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Departments.UseVisualStyleBackColor = True
        '
        'Classes
        '
        Me.Classes.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.class_percentage_button
        Me.Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Classes.FlatAppearance.BorderSize = 0
        Me.Classes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Classes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Classes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Classes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Classes.ForeColor = System.Drawing.Color.White
        Me.Classes.Location = New System.Drawing.Point(31, 71)
        Me.Classes.Name = "Classes"
        Me.Classes.Size = New System.Drawing.Size(125, 45)
        Me.Classes.TabIndex = 95
        Me.Classes.Text = "  Class"
        Me.Classes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Classes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Classes.UseVisualStyleBackColor = True
        '
        'Subjects
        '
        Me.Subjects.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Subject_percentage_button
        Me.Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Subjects.FlatAppearance.BorderSize = 0
        Me.Subjects.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Subjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Subjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Subjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Subjects.ForeColor = System.Drawing.Color.White
        Me.Subjects.Location = New System.Drawing.Point(31, 22)
        Me.Subjects.Name = "Subjects"
        Me.Subjects.Size = New System.Drawing.Size(125, 45)
        Me.Subjects.TabIndex = 96
        Me.Subjects.Text = "  Subject"
        Me.Subjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Subjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Subjects.UseVisualStyleBackColor = True
        '
        'Myclassesgroup
        '
        Me.Myclassesgroup.BackColor = System.Drawing.Color.Transparent
        Me.Myclassesgroup.Controls.Add(Me.ClassGrades)
        Me.Myclassesgroup.Controls.Add(Me.myclassesbutton)
        Me.Myclassesgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myclassesgroup.ForeColor = System.Drawing.Color.Maroon
        Me.Myclassesgroup.Location = New System.Drawing.Point(176, 122)
        Me.Myclassesgroup.Name = "Myclassesgroup"
        Me.Myclassesgroup.Size = New System.Drawing.Size(147, 173)
        Me.Myclassesgroup.TabIndex = 95
        Me.Myclassesgroup.TabStop = False
        Me.Myclassesgroup.Text = "My classes"
        '
        'ClassGrades
        '
        Me.ClassGrades.BackColor = System.Drawing.Color.Transparent
        Me.ClassGrades.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.view_grades_button
        Me.ClassGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClassGrades.FlatAppearance.BorderSize = 0
        Me.ClassGrades.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ClassGrades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ClassGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ClassGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClassGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ClassGrades.ForeColor = System.Drawing.Color.White
        Me.ClassGrades.Location = New System.Drawing.Point(6, 102)
        Me.ClassGrades.Name = "ClassGrades"
        Me.ClassGrades.Size = New System.Drawing.Size(132, 45)
        Me.ClassGrades.TabIndex = 96
        Me.ClassGrades.Text = " My Class Grades"
        Me.ClassGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClassGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ClassGrades.UseVisualStyleBackColor = False
        '
        'myclassesbutton
        '
        Me.myclassesbutton.BackColor = System.Drawing.Color.Transparent
        Me.myclassesbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.teacher_class_button
        Me.myclassesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myclassesbutton.FlatAppearance.BorderSize = 0
        Me.myclassesbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.myclassesbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.myclassesbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.myclassesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.myclassesbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.myclassesbutton.ForeColor = System.Drawing.Color.White
        Me.myclassesbutton.Location = New System.Drawing.Point(6, 33)
        Me.myclassesbutton.Name = "myclassesbutton"
        Me.myclassesbutton.Size = New System.Drawing.Size(132, 45)
        Me.myclassesbutton.TabIndex = 4
        Me.myclassesbutton.Text = " My Classes"
        Me.myclassesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.myclassesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.myclassesbutton.UseVisualStyleBackColor = False
        '
        'catchphrase
        '
        Me.catchphrase.AutoSize = True
        Me.catchphrase.BackColor = System.Drawing.Color.Transparent
        Me.catchphrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catchphrase.ForeColor = System.Drawing.Color.Maroon
        Me.catchphrase.Location = New System.Drawing.Point(299, 71)
        Me.catchphrase.Name = "catchphrase"
        Me.catchphrase.Size = New System.Drawing.Size(195, 20)
        Me.catchphrase.TabIndex = 96
        Me.catchphrase.Text = "(Tracking and Analysis)"
        '
        'datasetcombo
        '
        Me.datasetcombo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.datasetcombo.FormattingEnabled = True
        Me.datasetcombo.Location = New System.Drawing.Point(173, 333)
        Me.datasetcombo.Name = "datasetcombo"
        Me.datasetcombo.Size = New System.Drawing.Size(121, 21)
        Me.datasetcombo.TabIndex = 97
        '
        'datasetcombolabel
        '
        Me.datasetcombolabel.AutoSize = True
        Me.datasetcombolabel.BackColor = System.Drawing.Color.Transparent
        Me.datasetcombolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datasetcombolabel.ForeColor = System.Drawing.Color.Maroon
        Me.datasetcombolabel.Location = New System.Drawing.Point(10, 334)
        Me.datasetcombolabel.Name = "datasetcombolabel"
        Me.datasetcombolabel.Size = New System.Drawing.Size(163, 16)
        Me.datasetcombolabel.TabIndex = 98
        Me.datasetcombolabel.Text = "Select an Academic Year:"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.datasetcombo)
        Me.Controls.Add(Me.datasetcombolabel)
        Me.Controls.Add(Me.catchphrase)
        Me.Controls.Add(Me.Comparegroup)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.currentuser)
        Me.Controls.Add(Me.Predictionsgroup)
        Me.Controls.Add(Me.Adminbutton)
        Me.Controls.Add(Me.Gradegroup)
        Me.Controls.Add(Me.Logo2)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.StudentGroup)
        Me.Controls.Add(Me.Formtitle)
        Me.Controls.Add(Me.Myclassesgroup)
        Me.Controls.Add(Me.TeacherGroup)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(840, 399)
        Me.MinimumSize = New System.Drawing.Size(840, 399)
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.StudentGroup.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeacherGroup.ResumeLayout(False)
        Me.Gradegroup.ResumeLayout(False)
        Me.Predictionsgroup.ResumeLayout(False)
        Me.Comparegroup.ResumeLayout(False)
        Me.Myclassesgroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents studentdetailsbutton As System.Windows.Forms.Button
    Friend WithEvents teacherdetailsbutton As System.Windows.Forms.Button
    Friend WithEvents Formtitle As System.Windows.Forms.Label
    Friend WithEvents StudentGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Teacherclassesbutton As System.Windows.Forms.Button
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents Adminbutton As System.Windows.Forms.Button
    Friend WithEvents StudentClasses As System.Windows.Forms.Button
    Friend WithEvents TeacherGroup As System.Windows.Forms.GroupBox
    Friend WithEvents currentuser As System.Windows.Forms.Label
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents Gradegroup As System.Windows.Forms.GroupBox
    Friend WithEvents Gradepercentages As System.Windows.Forms.Button
    Friend WithEvents viewgradesbutton As System.Windows.Forms.Button
    Friend WithEvents Predictionsgroup As System.Windows.Forms.GroupBox
    Friend WithEvents gradepredictsbutton As System.Windows.Forms.Button
    Friend WithEvents Comparegroup As System.Windows.Forms.GroupBox
    Friend WithEvents Departments As System.Windows.Forms.Button
    Friend WithEvents Classes As System.Windows.Forms.Button
    Friend WithEvents Subjects As System.Windows.Forms.Button
    Friend WithEvents gradepercentages1 As System.Windows.Forms.Button
    Friend WithEvents Myclassesgroup As System.Windows.Forms.GroupBox
    Friend WithEvents myclassesbutton As System.Windows.Forms.Button
    Friend WithEvents ClassGrades As System.Windows.Forms.Button
    Friend WithEvents catchphrase As System.Windows.Forms.Label
    Friend WithEvents datasetcombo As System.Windows.Forms.ComboBox
    Friend WithEvents datasetcombolabel As System.Windows.Forms.Label
End Class
