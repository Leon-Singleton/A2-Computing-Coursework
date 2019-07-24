<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Classes))
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.SearchStudent = New System.Windows.Forms.GroupBox()
        Me.instructlabel = New System.Windows.Forms.Label()
        Me.Classfield = New System.Windows.Forms.TextBox()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.Departmentfield = New System.Windows.Forms.ComboBox()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.fieldlabel1 = New System.Windows.Forms.Label()
        Me.addremoveField = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Namefield = New System.Windows.Forms.TextBox()
        Me.Classesgrid = New System.Windows.Forms.DataGridView()
        Me.Viewstudentsgrid = New System.Windows.Forms.DataGridView()
        Me.Studentclassesgrid = New System.Windows.Forms.DataGridView()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.Wherelabel1 = New System.Windows.Forms.Label()
        Me.fieldlabel = New System.Windows.Forms.Label()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.studentclassesfield = New System.Windows.Forms.ComboBox()
        Me.viewstudentsgroup = New System.Windows.Forms.GroupBox()
        Me.Searchstudentclasses = New System.Windows.Forms.Button()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchStudent.SuspendLayout()
        CType(Me.Classesgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Viewstudentsgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Studentclassesgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewstudentsgroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(90, 12)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(83, 13)
        Me.Classeslink.TabIndex = 85
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Student Classes"
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(72, 9)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 84
        Me.linkarrow.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 83
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(1, 3)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(994, 31)
        Me.banner.TabIndex = 86
        Me.banner.TabStop = False
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(9, 44)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(141, 20)
        Me.Formheader.TabIndex = 87
        Me.Formheader.Text = "Student Classes"
        '
        'SearchStudent
        '
        Me.SearchStudent.BackColor = System.Drawing.Color.Transparent
        Me.SearchStudent.Controls.Add(Me.instructlabel)
        Me.SearchStudent.Controls.Add(Me.Classfield)
        Me.SearchStudent.Controls.Add(Me.Yearfield)
        Me.SearchStudent.Controls.Add(Me.wherelabel)
        Me.SearchStudent.Controls.Add(Me.Departmentfield)
        Me.SearchStudent.Controls.Add(Me.Subjectfield)
        Me.SearchStudent.Controls.Add(Me.fieldlabel1)
        Me.SearchStudent.Controls.Add(Me.addremoveField)
        Me.SearchStudent.Controls.Add(Me.Search)
        Me.SearchStudent.Controls.Add(Me.Namefield)
        Me.SearchStudent.ForeColor = System.Drawing.Color.Maroon
        Me.SearchStudent.Location = New System.Drawing.Point(9, 242)
        Me.SearchStudent.Name = "SearchStudent"
        Me.SearchStudent.Size = New System.Drawing.Size(227, 140)
        Me.SearchStudent.TabIndex = 88
        Me.SearchStudent.TabStop = False
        Me.SearchStudent.Text = "Add and Remove Students from classes"
        '
        'instructlabel
        '
        Me.instructlabel.AutoSize = True
        Me.instructlabel.ForeColor = System.Drawing.Color.Maroon
        Me.instructlabel.Location = New System.Drawing.Point(3, 23)
        Me.instructlabel.Name = "instructlabel"
        Me.instructlabel.Size = New System.Drawing.Size(152, 13)
        Me.instructlabel.TabIndex = 102
        Me.instructlabel.Text = "First you must Select the class:"
        '
        'Classfield
        '
        Me.Classfield.Location = New System.Drawing.Point(80, 78)
        Me.Classfield.Name = "Classfield"
        Me.Classfield.Size = New System.Drawing.Size(134, 20)
        Me.Classfield.TabIndex = 2
        Me.Classfield.Visible = False
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(80, 78)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(124, 21)
        Me.Yearfield.TabIndex = 78
        Me.Yearfield.Visible = False
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(6, 81)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 57
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'Departmentfield
        '
        Me.Departmentfield.FormattingEnabled = True
        Me.Departmentfield.Location = New System.Drawing.Point(80, 77)
        Me.Departmentfield.Name = "Departmentfield"
        Me.Departmentfield.Size = New System.Drawing.Size(124, 21)
        Me.Departmentfield.TabIndex = 64
        Me.Departmentfield.Visible = False
        '
        'Subjectfield
        '
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(80, 78)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(124, 21)
        Me.Subjectfield.TabIndex = 63
        Me.Subjectfield.Visible = False
        '
        'fieldlabel1
        '
        Me.fieldlabel1.AutoSize = True
        Me.fieldlabel1.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel1.Location = New System.Drawing.Point(2, 48)
        Me.fieldlabel1.Name = "fieldlabel1"
        Me.fieldlabel1.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel1.TabIndex = 62
        Me.fieldlabel1.Text = "Select an attribute:"
        '
        'addremoveField
        '
        Me.addremoveField.FormattingEnabled = True
        Me.addremoveField.Items.AddRange(New Object() {"", "Teacher Name", "Subject", "Department", "Class"})
        Me.addremoveField.Location = New System.Drawing.Point(97, 45)
        Me.addremoveField.Name = "addremoveField"
        Me.addremoveField.Size = New System.Drawing.Size(117, 21)
        Me.addremoveField.TabIndex = 1
        '
        'Search
        '
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search.FlatAppearance.BorderSize = 0
        Me.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(80, 104)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(66, 26)
        Me.Search.TabIndex = 55
        Me.Search.Text = "Search"
        Me.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Search.UseVisualStyleBackColor = True
        '
        'Namefield
        '
        Me.Namefield.Location = New System.Drawing.Point(80, 78)
        Me.Namefield.Name = "Namefield"
        Me.Namefield.Size = New System.Drawing.Size(124, 20)
        Me.Namefield.TabIndex = 57
        Me.Namefield.Visible = False
        '
        'Classesgrid
        '
        Me.Classesgrid.AllowUserToAddRows = False
        Me.Classesgrid.AllowUserToDeleteRows = False
        Me.Classesgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Classesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Classesgrid.Location = New System.Drawing.Point(240, 73)
        Me.Classesgrid.Name = "Classesgrid"
        Me.Classesgrid.ReadOnly = True
        Me.Classesgrid.RowHeadersVisible = False
        Me.Classesgrid.Size = New System.Drawing.Size(787, 405)
        Me.Classesgrid.TabIndex = 89
        '
        'Viewstudentsgrid
        '
        Me.Viewstudentsgrid.AllowUserToAddRows = False
        Me.Viewstudentsgrid.AllowUserToDeleteRows = False
        Me.Viewstudentsgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Viewstudentsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Viewstudentsgrid.Location = New System.Drawing.Point(240, 73)
        Me.Viewstudentsgrid.Name = "Viewstudentsgrid"
        Me.Viewstudentsgrid.ReadOnly = True
        Me.Viewstudentsgrid.RowHeadersVisible = False
        Me.Viewstudentsgrid.Size = New System.Drawing.Size(787, 405)
        Me.Viewstudentsgrid.TabIndex = 90
        Me.Viewstudentsgrid.Visible = False
        '
        'Studentclassesgrid
        '
        Me.Studentclassesgrid.AllowUserToAddRows = False
        Me.Studentclassesgrid.AllowUserToDeleteRows = False
        Me.Studentclassesgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Studentclassesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Studentclassesgrid.Location = New System.Drawing.Point(242, 76)
        Me.Studentclassesgrid.Name = "Studentclassesgrid"
        Me.Studentclassesgrid.ReadOnly = True
        Me.Studentclassesgrid.RowHeadersVisible = False
        Me.Studentclassesgrid.Size = New System.Drawing.Size(787, 405)
        Me.Studentclassesgrid.TabIndex = 91
        Me.Studentclassesgrid.Visible = False
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(92, 70)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(115, 21)
        Me.SearchYear.TabIndex = 101
        Me.SearchYear.Visible = False
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(92, 70)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(115, 21)
        Me.SearchForm.TabIndex = 100
        Me.SearchForm.Visible = False
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(92, 70)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(115, 21)
        Me.SearchGender.TabIndex = 97
        Me.SearchGender.Visible = False
        '
        'Wherelabel1
        '
        Me.Wherelabel1.AutoSize = True
        Me.Wherelabel1.ForeColor = System.Drawing.Color.Maroon
        Me.Wherelabel1.Location = New System.Drawing.Point(6, 70)
        Me.Wherelabel1.Name = "Wherelabel1"
        Me.Wherelabel1.Size = New System.Drawing.Size(37, 13)
        Me.Wherelabel1.TabIndex = 96
        Me.Wherelabel1.Text = "Value:"
        Me.Wherelabel1.Visible = False
        '
        'fieldlabel
        '
        Me.fieldlabel.AutoSize = True
        Me.fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel.Location = New System.Drawing.Point(2, 32)
        Me.fieldlabel.Name = "fieldlabel"
        Me.fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel.TabIndex = 95
        Me.fieldlabel.Text = "Select an attribute:"
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(92, 70)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(115, 20)
        Me.SearchName.TabIndex = 94
        Me.SearchName.Visible = False
        '
        'studentclassesfield
        '
        Me.studentclassesfield.FormattingEnabled = True
        Me.studentclassesfield.Items.AddRange(New Object() {"", "Name", "Gender", "Form"})
        Me.studentclassesfield.Location = New System.Drawing.Point(95, 30)
        Me.studentclassesfield.Name = "studentclassesfield"
        Me.studentclassesfield.Size = New System.Drawing.Size(112, 21)
        Me.studentclassesfield.TabIndex = 92
        '
        'viewstudentsgroup
        '
        Me.viewstudentsgroup.BackColor = System.Drawing.Color.Transparent
        Me.viewstudentsgroup.Controls.Add(Me.Searchstudentclasses)
        Me.viewstudentsgroup.Controls.Add(Me.studentclassesfield)
        Me.viewstudentsgroup.Controls.Add(Me.SearchForm)
        Me.viewstudentsgroup.Controls.Add(Me.fieldlabel)
        Me.viewstudentsgroup.Controls.Add(Me.SearchName)
        Me.viewstudentsgroup.Controls.Add(Me.Wherelabel1)
        Me.viewstudentsgroup.Controls.Add(Me.SearchYear)
        Me.viewstudentsgroup.Controls.Add(Me.SearchGender)
        Me.viewstudentsgroup.ForeColor = System.Drawing.Color.Maroon
        Me.viewstudentsgroup.Location = New System.Drawing.Point(4, 76)
        Me.viewstudentsgroup.Name = "viewstudentsgroup"
        Me.viewstudentsgroup.Size = New System.Drawing.Size(227, 135)
        Me.viewstudentsgroup.TabIndex = 89
        Me.viewstudentsgroup.TabStop = False
        Me.viewstudentsgroup.Text = "View a Students Classes"
        '
        'Searchstudentclasses
        '
        Me.Searchstudentclasses.BackgroundImage = CType(resources.GetObject("Searchstudentclasses.BackgroundImage"), System.Drawing.Image)
        Me.Searchstudentclasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Searchstudentclasses.FlatAppearance.BorderSize = 0
        Me.Searchstudentclasses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Searchstudentclasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Searchstudentclasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Searchstudentclasses.ForeColor = System.Drawing.Color.White
        Me.Searchstudentclasses.Location = New System.Drawing.Point(85, 97)
        Me.Searchstudentclasses.Name = "Searchstudentclasses"
        Me.Searchstudentclasses.Size = New System.Drawing.Size(66, 26)
        Me.Searchstudentclasses.TabIndex = 55
        Me.Searchstudentclasses.Text = "Search"
        Me.Searchstudentclasses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Searchstudentclasses.UseVisualStyleBackColor = True
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
        Me.printbutton.Location = New System.Drawing.Point(1001, 4)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 124
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(99, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Or"
        '
        'Student_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(1035, 485)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.viewstudentsgroup)
        Me.Controls.Add(Me.Studentclassesgrid)
        Me.Controls.Add(Me.Viewstudentsgrid)
        Me.Controls.Add(Me.Classesgrid)
        Me.Controls.Add(Me.SearchStudent)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1051, 523)
        Me.MinimumSize = New System.Drawing.Size(1051, 523)
        Me.Name = "Student_Classes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Classes"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchStudent.ResumeLayout(False)
        Me.SearchStudent.PerformLayout()
        CType(Me.Classesgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Viewstudentsgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Studentclassesgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewstudentsgroup.ResumeLayout(False)
        Me.viewstudentsgroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents SearchStudent As System.Windows.Forms.GroupBox
    Friend WithEvents Classfield As System.Windows.Forms.TextBox
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents Departmentfield As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents fieldlabel1 As System.Windows.Forms.Label
    Friend WithEvents addremoveField As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Namefield As System.Windows.Forms.TextBox
    Friend WithEvents Classesgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Viewstudentsgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Studentclassesgrid As System.Windows.Forms.DataGridView
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents Wherelabel1 As System.Windows.Forms.Label
    Friend WithEvents fieldlabel As System.Windows.Forms.Label
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents studentclassesfield As System.Windows.Forms.ComboBox
    Friend WithEvents viewstudentsgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Searchstudentclasses As System.Windows.Forms.Button
    Friend WithEvents instructlabel As System.Windows.Forms.Label
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
