<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher_Classes))
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.Classesgrid = New System.Windows.Forms.DataGridView()
        Me.SearchStudent = New System.Windows.Forms.GroupBox()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.Departmentfield = New System.Windows.Forms.ComboBox()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.fieldlabel = New System.Windows.Forms.Label()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.Addsearch = New System.Windows.Forms.Button()
        Me.Namefield = New System.Windows.Forms.TextBox()
        Me.Classfield = New System.Windows.Forms.TextBox()
        Me.AddClassgroup = New System.Windows.Forms.GroupBox()
        Me.Classgrouplabel = New System.Windows.Forms.Label()
        Me.Classgroupfield = New System.Windows.Forms.TextBox()
        Me.Addclassbutton = New System.Windows.Forms.Button()
        Me.Yearfieldadd = New System.Windows.Forms.ComboBox()
        Me.Firstnamelabel = New System.Windows.Forms.Label()
        Me.Subjectfieldadd = New System.Windows.Forms.ComboBox()
        Me.Surnamelabel = New System.Windows.Forms.Label()
        Me.Firstnamefield = New System.Windows.Forms.TextBox()
        Me.Surnamefield = New System.Windows.Forms.TextBox()
        Me.Yearlabel = New System.Windows.Forms.Label()
        Me.Subjectlabel = New System.Windows.Forms.Label()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        CType(Me.Classesgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchStudent.SuspendLayout()
        Me.AddClassgroup.SuspendLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(74, 15)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 72
        Me.linkarrow.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(17, 18)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 70
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(92, 18)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(86, 13)
        Me.Classeslink.TabIndex = 74
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Teacher Classes"
        '
        'Classesgrid
        '
        Me.Classesgrid.AllowUserToAddRows = False
        Me.Classesgrid.AllowUserToDeleteRows = False
        Me.Classesgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Classesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Classesgrid.Location = New System.Drawing.Point(306, 69)
        Me.Classesgrid.Name = "Classesgrid"
        Me.Classesgrid.ReadOnly = True
        Me.Classesgrid.RowHeadersVisible = False
        Me.Classesgrid.Size = New System.Drawing.Size(670, 405)
        Me.Classesgrid.TabIndex = 76
        '
        'SearchStudent
        '
        Me.SearchStudent.BackColor = System.Drawing.Color.Transparent
        Me.SearchStudent.Controls.Add(Me.Yearfield)
        Me.SearchStudent.Controls.Add(Me.wherelabel)
        Me.SearchStudent.Controls.Add(Me.Departmentfield)
        Me.SearchStudent.Controls.Add(Me.Subjectfield)
        Me.SearchStudent.Controls.Add(Me.fieldlabel)
        Me.SearchStudent.Controls.Add(Me.Field)
        Me.SearchStudent.Controls.Add(Me.Addsearch)
        Me.SearchStudent.Controls.Add(Me.Namefield)
        Me.SearchStudent.Controls.Add(Me.Classfield)
        Me.SearchStudent.ForeColor = System.Drawing.Color.Maroon
        Me.SearchStudent.Location = New System.Drawing.Point(5, 66)
        Me.SearchStudent.Name = "SearchStudent"
        Me.SearchStudent.Size = New System.Drawing.Size(285, 128)
        Me.SearchStudent.TabIndex = 77
        Me.SearchStudent.TabStop = False
        Me.SearchStudent.Text = "Search for a Class"
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(137, 60)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(124, 21)
        Me.Yearfield.TabIndex = 78
        Me.Yearfield.Visible = False
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(6, 63)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 57
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'Departmentfield
        '
        Me.Departmentfield.FormattingEnabled = True
        Me.Departmentfield.Location = New System.Drawing.Point(137, 59)
        Me.Departmentfield.Name = "Departmentfield"
        Me.Departmentfield.Size = New System.Drawing.Size(124, 21)
        Me.Departmentfield.TabIndex = 64
        Me.Departmentfield.Visible = False
        '
        'Subjectfield
        '
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(137, 60)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(124, 21)
        Me.Subjectfield.TabIndex = 63
        Me.Subjectfield.Visible = False
        '
        'fieldlabel
        '
        Me.fieldlabel.AutoSize = True
        Me.fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel.Location = New System.Drawing.Point(6, 30)
        Me.fieldlabel.Name = "fieldlabel"
        Me.fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel.TabIndex = 62
        Me.fieldlabel.Text = "Select an attribute:"
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Teacher Name", "Subject", "Department", "Class"})
        Me.Field.Location = New System.Drawing.Point(144, 27)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(117, 21)
        Me.Field.TabIndex = 1
        '
        'Addsearch
        '
        Me.Addsearch.BackgroundImage = CType(resources.GetObject("Addsearch.BackgroundImage"), System.Drawing.Image)
        Me.Addsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addsearch.FlatAppearance.BorderSize = 0
        Me.Addsearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addsearch.ForeColor = System.Drawing.Color.White
        Me.Addsearch.Location = New System.Drawing.Point(88, 88)
        Me.Addsearch.Name = "Addsearch"
        Me.Addsearch.Size = New System.Drawing.Size(66, 26)
        Me.Addsearch.TabIndex = 55
        Me.Addsearch.Text = "Search"
        Me.Addsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addsearch.UseVisualStyleBackColor = True
        '
        'Namefield
        '
        Me.Namefield.Location = New System.Drawing.Point(137, 60)
        Me.Namefield.Name = "Namefield"
        Me.Namefield.Size = New System.Drawing.Size(124, 20)
        Me.Namefield.TabIndex = 57
        Me.Namefield.Visible = False
        '
        'Classfield
        '
        Me.Classfield.Location = New System.Drawing.Point(137, 60)
        Me.Classfield.Name = "Classfield"
        Me.Classfield.Size = New System.Drawing.Size(124, 20)
        Me.Classfield.TabIndex = 2
        Me.Classfield.Visible = False
        '
        'AddClassgroup
        '
        Me.AddClassgroup.BackColor = System.Drawing.Color.Transparent
        Me.AddClassgroup.Controls.Add(Me.Classgrouplabel)
        Me.AddClassgroup.Controls.Add(Me.Classgroupfield)
        Me.AddClassgroup.Controls.Add(Me.Addclassbutton)
        Me.AddClassgroup.Controls.Add(Me.Yearfieldadd)
        Me.AddClassgroup.Controls.Add(Me.Firstnamelabel)
        Me.AddClassgroup.Controls.Add(Me.Subjectfieldadd)
        Me.AddClassgroup.Controls.Add(Me.Surnamelabel)
        Me.AddClassgroup.Controls.Add(Me.Firstnamefield)
        Me.AddClassgroup.Controls.Add(Me.Surnamefield)
        Me.AddClassgroup.Controls.Add(Me.Yearlabel)
        Me.AddClassgroup.Controls.Add(Me.Subjectlabel)
        Me.AddClassgroup.ForeColor = System.Drawing.Color.Maroon
        Me.AddClassgroup.Location = New System.Drawing.Point(12, 200)
        Me.AddClassgroup.Name = "AddClassgroup"
        Me.AddClassgroup.Size = New System.Drawing.Size(278, 279)
        Me.AddClassgroup.TabIndex = 81
        Me.AddClassgroup.TabStop = False
        Me.AddClassgroup.Text = "Create a New Class"
        '
        'Classgrouplabel
        '
        Me.Classgrouplabel.AutoSize = True
        Me.Classgrouplabel.BackColor = System.Drawing.Color.Transparent
        Me.Classgrouplabel.ForeColor = System.Drawing.Color.Maroon
        Me.Classgrouplabel.Location = New System.Drawing.Point(5, 122)
        Me.Classgrouplabel.Name = "Classgrouplabel"
        Me.Classgrouplabel.Size = New System.Drawing.Size(67, 13)
        Me.Classgrouplabel.TabIndex = 82
        Me.Classgrouplabel.Text = "Class Group:"
        '
        'Classgroupfield
        '
        Me.Classgroupfield.Location = New System.Drawing.Point(137, 116)
        Me.Classgroupfield.Name = "Classgroupfield"
        Me.Classgroupfield.Size = New System.Drawing.Size(121, 20)
        Me.Classgroupfield.TabIndex = 6
        '
        'Addclassbutton
        '
        Me.Addclassbutton.BackgroundImage = CType(resources.GetObject("Addclassbutton.BackgroundImage"), System.Drawing.Image)
        Me.Addclassbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addclassbutton.FlatAppearance.BorderSize = 0
        Me.Addclassbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addclassbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addclassbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addclassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addclassbutton.ForeColor = System.Drawing.Color.White
        Me.Addclassbutton.Location = New System.Drawing.Point(76, 233)
        Me.Addclassbutton.Name = "Addclassbutton"
        Me.Addclassbutton.Size = New System.Drawing.Size(100, 31)
        Me.Addclassbutton.TabIndex = 81
        Me.Addclassbutton.Text = "Create Class"
        Me.Addclassbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addclassbutton.UseVisualStyleBackColor = True
        '
        'Yearfieldadd
        '
        Me.Yearfieldadd.FormattingEnabled = True
        Me.Yearfieldadd.Location = New System.Drawing.Point(137, 195)
        Me.Yearfieldadd.Name = "Yearfieldadd"
        Me.Yearfieldadd.Size = New System.Drawing.Size(121, 21)
        Me.Yearfieldadd.TabIndex = 8
        '
        'Firstnamelabel
        '
        Me.Firstnamelabel.AutoSize = True
        Me.Firstnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Firstnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Firstnamelabel.Location = New System.Drawing.Point(5, 38)
        Me.Firstnamelabel.Name = "Firstnamelabel"
        Me.Firstnamelabel.Size = New System.Drawing.Size(98, 13)
        Me.Firstnamelabel.TabIndex = 66
        Me.Firstnamelabel.Text = "Teacher Firstname:"
        '
        'Subjectfieldadd
        '
        Me.Subjectfieldadd.FormattingEnabled = True
        Me.Subjectfieldadd.Location = New System.Drawing.Point(137, 155)
        Me.Subjectfieldadd.Name = "Subjectfieldadd"
        Me.Subjectfieldadd.Size = New System.Drawing.Size(121, 21)
        Me.Subjectfieldadd.TabIndex = 7
        '
        'Surnamelabel
        '
        Me.Surnamelabel.AutoSize = True
        Me.Surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Surnamelabel.Location = New System.Drawing.Point(5, 80)
        Me.Surnamelabel.Name = "Surnamelabel"
        Me.Surnamelabel.Size = New System.Drawing.Size(92, 13)
        Me.Surnamelabel.TabIndex = 67
        Me.Surnamelabel.Text = "Teacher Surname"
        '
        'Firstnamefield
        '
        Me.Firstnamefield.Location = New System.Drawing.Point(137, 38)
        Me.Firstnamefield.Name = "Firstnamefield"
        Me.Firstnamefield.Size = New System.Drawing.Size(121, 20)
        Me.Firstnamefield.TabIndex = 3
        '
        'Surnamefield
        '
        Me.Surnamefield.Location = New System.Drawing.Point(137, 77)
        Me.Surnamefield.Name = "Surnamefield"
        Me.Surnamefield.Size = New System.Drawing.Size(121, 20)
        Me.Surnamefield.TabIndex = 5
        '
        'Yearlabel
        '
        Me.Yearlabel.AutoSize = True
        Me.Yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.Yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Yearlabel.Location = New System.Drawing.Point(5, 206)
        Me.Yearlabel.Name = "Yearlabel"
        Me.Yearlabel.Size = New System.Drawing.Size(32, 13)
        Me.Yearlabel.TabIndex = 75
        Me.Yearlabel.Text = "Year:"
        '
        'Subjectlabel
        '
        Me.Subjectlabel.AutoSize = True
        Me.Subjectlabel.BackColor = System.Drawing.Color.Transparent
        Me.Subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectlabel.Location = New System.Drawing.Point(5, 164)
        Me.Subjectlabel.Name = "Subjectlabel"
        Me.Subjectlabel.Size = New System.Drawing.Size(46, 13)
        Me.Subjectlabel.TabIndex = 70
        Me.Subjectlabel.Text = "Subject:"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(6, 9)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(937, 31)
        Me.banner.TabIndex = 82
        Me.banner.TabStop = False
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(4, 43)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(142, 20)
        Me.Formheader.TabIndex = 83
        Me.Formheader.Text = "Teacher Classes"
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
        Me.printbutton.Location = New System.Drawing.Point(946, 10)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 125
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
        'Teacher_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(980, 486)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.AddClassgroup)
        Me.Controls.Add(Me.SearchStudent)
        Me.Controls.Add(Me.Classesgrid)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(996, 524)
        Me.MinimumSize = New System.Drawing.Size(996, 524)
        Me.Name = "Teacher_Classes"
        Me.Text = "Teacher Classes"
        CType(Me.Classesgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchStudent.ResumeLayout(False)
        Me.SearchStudent.PerformLayout()
        Me.AddClassgroup.ResumeLayout(False)
        Me.AddClassgroup.PerformLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents Classesgrid As System.Windows.Forms.DataGridView
    Friend WithEvents SearchStudent As System.Windows.Forms.GroupBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents Departmentfield As System.Windows.Forms.ComboBox
    Friend WithEvents fieldlabel As System.Windows.Forms.Label
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents Addsearch As System.Windows.Forms.Button
    Friend WithEvents Namefield As System.Windows.Forms.TextBox
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents Classfield As System.Windows.Forms.TextBox
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents AddClassgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Addclassbutton As System.Windows.Forms.Button
    Friend WithEvents Yearfieldadd As System.Windows.Forms.ComboBox
    Friend WithEvents Firstnamelabel As System.Windows.Forms.Label
    Friend WithEvents Subjectfieldadd As System.Windows.Forms.ComboBox
    Friend WithEvents Surnamelabel As System.Windows.Forms.Label
    Friend WithEvents Firstnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Surnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Yearlabel As System.Windows.Forms.Label
    Friend WithEvents Subjectlabel As System.Windows.Forms.Label
    Friend WithEvents Classgrouplabel As System.Windows.Forms.Label
    Friend WithEvents Classgroupfield As System.Windows.Forms.TextBox
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
End Class
