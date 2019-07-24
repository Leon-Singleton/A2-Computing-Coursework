<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Predictions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Predictions))
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow1 = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.studentgroup = New System.Windows.Forms.GroupBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.SearchDataset = New System.Windows.Forms.ComboBox()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.fieldlabel = New System.Windows.Forms.Label()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.SearchSNS = New System.Windows.Forms.ComboBox()
        Me.selectstudent = New System.Windows.Forms.Button()
        Me.SearchEthnicity = New System.Windows.Forms.ComboBox()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.Predictedgradesgrid = New System.Windows.Forms.DataGridView()
        Me.Clearselection = New System.Windows.Forms.Button()
        Me.formlabel = New System.Windows.Forms.Label()
        Me.Viewpredictionsgrid = New System.Windows.Forms.DataGridView()
        Me.formgroup = New System.Windows.Forms.GroupBox()
        Me.formfield = New System.Windows.Forms.ComboBox()
        Me.labelform = New System.Windows.Forms.Label()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.yearlabel = New System.Windows.Forms.Label()
        Me.Searchgroup = New System.Windows.Forms.Button()
        Me.yeargroup = New System.Windows.Forms.GroupBox()
        Me.yearcombo = New System.Windows.Forms.ComboBox()
        Me.labelyear = New System.Windows.Forms.Label()
        Me.yearsearch = New System.Windows.Forms.Button()
        Me.grouppredictionsgrid = New System.Windows.Forms.DataGridView()
        Me.createcsv = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.ClassPredictiongroup = New System.Windows.Forms.GroupBox()
        Me.Classsearch = New System.Windows.Forms.Button()
        Me.Classgroupfield = New System.Windows.Forms.ComboBox()
        Me.Classlabel = New System.Windows.Forms.Label()
        Me.classyearfield = New System.Windows.Forms.ComboBox()
        Me.classyearlabel = New System.Windows.Forms.Label()
        Me.subjectlabel = New System.Windows.Forms.Label()
        Me.SubjectField = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentgroup.SuspendLayout()
        CType(Me.Predictedgradesgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Viewpredictionsgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formgroup.SuspendLayout()
        Me.yeargroup.SuspendLayout()
        CType(Me.grouppredictionsgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClassPredictiongroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(101, 17)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(91, 13)
        Me.Classeslink.TabIndex = 90
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Grade Predictions"
        '
        'linkarrow1
        '
        Me.linkarrow1.AutoSize = True
        Me.linkarrow1.BackColor = System.Drawing.Color.White
        Me.linkarrow1.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow1.Location = New System.Drawing.Point(81, 15)
        Me.linkarrow1.Name = "linkarrow1"
        Me.linkarrow1.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow1.TabIndex = 89
        Me.linkarrow1.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(24, 17)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 88
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(8, 9)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(1058, 31)
        Me.banner.TabIndex = 87
        Me.banner.TabStop = False
        '
        'studentgroup
        '
        Me.studentgroup.BackColor = System.Drawing.Color.Transparent
        Me.studentgroup.Controls.Add(Me.wherelabel)
        Me.studentgroup.Controls.Add(Me.SearchDataset)
        Me.studentgroup.Controls.Add(Me.SearchYear)
        Me.studentgroup.Controls.Add(Me.fieldlabel)
        Me.studentgroup.Controls.Add(Me.SearchForm)
        Me.studentgroup.Controls.Add(Me.Field)
        Me.studentgroup.Controls.Add(Me.SearchSNS)
        Me.studentgroup.Controls.Add(Me.selectstudent)
        Me.studentgroup.Controls.Add(Me.SearchEthnicity)
        Me.studentgroup.Controls.Add(Me.SearchName)
        Me.studentgroup.Controls.Add(Me.SearchGender)
        Me.studentgroup.ForeColor = System.Drawing.Color.Maroon
        Me.studentgroup.Location = New System.Drawing.Point(3, 77)
        Me.studentgroup.Name = "studentgroup"
        Me.studentgroup.Size = New System.Drawing.Size(240, 123)
        Me.studentgroup.TabIndex = 91
        Me.studentgroup.TabStop = False
        Me.studentgroup.Text = "View Individual Student's A2 Predictions"
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(2, 64)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 57
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'SearchDataset
        '
        Me.SearchDataset.FormattingEnabled = True
        Me.SearchDataset.Location = New System.Drawing.Point(126, 60)
        Me.SearchDataset.Name = "SearchDataset"
        Me.SearchDataset.Size = New System.Drawing.Size(109, 21)
        Me.SearchDataset.TabIndex = 64
        Me.SearchDataset.Visible = False
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(126, 61)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(109, 21)
        Me.SearchYear.TabIndex = 63
        Me.SearchYear.Visible = False
        '
        'fieldlabel
        '
        Me.fieldlabel.AutoSize = True
        Me.fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel.Location = New System.Drawing.Point(2, 30)
        Me.fieldlabel.Name = "fieldlabel"
        Me.fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel.TabIndex = 62
        Me.fieldlabel.Text = "Select an attribute:"
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(126, 60)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(109, 21)
        Me.SearchForm.TabIndex = 62
        Me.SearchForm.Visible = False
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Name", "Gender", "Form", "Year"})
        Me.Field.Location = New System.Drawing.Point(155, 27)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(80, 21)
        Me.Field.TabIndex = 61
        '
        'SearchSNS
        '
        Me.SearchSNS.FormattingEnabled = True
        Me.SearchSNS.Location = New System.Drawing.Point(126, 62)
        Me.SearchSNS.Name = "SearchSNS"
        Me.SearchSNS.Size = New System.Drawing.Size(109, 21)
        Me.SearchSNS.TabIndex = 61
        Me.SearchSNS.Visible = False
        '
        'selectstudent
        '
        Me.selectstudent.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.selectstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selectstudent.FlatAppearance.BorderSize = 0
        Me.selectstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.selectstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.selectstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectstudent.ForeColor = System.Drawing.Color.White
        Me.selectstudent.Location = New System.Drawing.Point(83, 87)
        Me.selectstudent.Name = "selectstudent"
        Me.selectstudent.Size = New System.Drawing.Size(66, 26)
        Me.selectstudent.TabIndex = 55
        Me.selectstudent.Text = "Search"
        Me.selectstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.selectstudent.UseVisualStyleBackColor = True
        Me.selectstudent.Visible = False
        '
        'SearchEthnicity
        '
        Me.SearchEthnicity.FormattingEnabled = True
        Me.SearchEthnicity.Location = New System.Drawing.Point(126, 61)
        Me.SearchEthnicity.Name = "SearchEthnicity"
        Me.SearchEthnicity.Size = New System.Drawing.Size(109, 21)
        Me.SearchEthnicity.TabIndex = 60
        Me.SearchEthnicity.Visible = False
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(126, 62)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(109, 20)
        Me.SearchName.TabIndex = 57
        Me.SearchName.Visible = False
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(126, 62)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(109, 21)
        Me.SearchGender.TabIndex = 59
        Me.SearchGender.Visible = False
        '
        'Predictedgradesgrid
        '
        Me.Predictedgradesgrid.AllowUserToAddRows = False
        Me.Predictedgradesgrid.AllowUserToDeleteRows = False
        Me.Predictedgradesgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Predictedgradesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Predictedgradesgrid.Location = New System.Drawing.Point(248, 46)
        Me.Predictedgradesgrid.Name = "Predictedgradesgrid"
        Me.Predictedgradesgrid.ReadOnly = True
        Me.Predictedgradesgrid.RowHeadersVisible = False
        Me.Predictedgradesgrid.Size = New System.Drawing.Size(637, 647)
        Me.Predictedgradesgrid.TabIndex = 92
        '
        'Clearselection
        '
        Me.Clearselection.BackColor = System.Drawing.Color.Transparent
        Me.Clearselection.BackgroundImage = CType(resources.GetObject("Clearselection.BackgroundImage"), System.Drawing.Image)
        Me.Clearselection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Clearselection.FlatAppearance.BorderSize = 0
        Me.Clearselection.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearselection.ForeColor = System.Drawing.Color.White
        Me.Clearselection.Location = New System.Drawing.Point(5, 663)
        Me.Clearselection.Name = "Clearselection"
        Me.Clearselection.Size = New System.Drawing.Size(100, 29)
        Me.Clearselection.TabIndex = 93
        Me.Clearselection.Text = "ClearSelection"
        Me.Clearselection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Clearselection.UseVisualStyleBackColor = False
        '
        'formlabel
        '
        Me.formlabel.AutoSize = True
        Me.formlabel.BackColor = System.Drawing.Color.Transparent
        Me.formlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formlabel.ForeColor = System.Drawing.Color.Maroon
        Me.formlabel.Location = New System.Drawing.Point(10, 46)
        Me.formlabel.Name = "formlabel"
        Me.formlabel.Size = New System.Drawing.Size(149, 20)
        Me.formlabel.TabIndex = 94
        Me.formlabel.Text = "Predicted Grades"
        '
        'Viewpredictionsgrid
        '
        Me.Viewpredictionsgrid.AllowUserToAddRows = False
        Me.Viewpredictionsgrid.AllowUserToDeleteRows = False
        Me.Viewpredictionsgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Viewpredictionsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Viewpredictionsgrid.Location = New System.Drawing.Point(891, 46)
        Me.Viewpredictionsgrid.Name = "Viewpredictionsgrid"
        Me.Viewpredictionsgrid.ReadOnly = True
        Me.Viewpredictionsgrid.RowHeadersVisible = False
        Me.Viewpredictionsgrid.Size = New System.Drawing.Size(236, 645)
        Me.Viewpredictionsgrid.TabIndex = 95
        Me.Viewpredictionsgrid.Visible = False
        '
        'formgroup
        '
        Me.formgroup.BackColor = System.Drawing.Color.Transparent
        Me.formgroup.Controls.Add(Me.formfield)
        Me.formgroup.Controls.Add(Me.labelform)
        Me.formgroup.Controls.Add(Me.Yearfield)
        Me.formgroup.Controls.Add(Me.yearlabel)
        Me.formgroup.Controls.Add(Me.Searchgroup)
        Me.formgroup.ForeColor = System.Drawing.Color.Maroon
        Me.formgroup.Location = New System.Drawing.Point(3, 232)
        Me.formgroup.Name = "formgroup"
        Me.formgroup.Size = New System.Drawing.Size(240, 114)
        Me.formgroup.TabIndex = 96
        Me.formgroup.TabStop = False
        Me.formgroup.Text = "View a Form's A2 Predicted Grades"
        '
        'formfield
        '
        Me.formfield.FormattingEnabled = True
        Me.formfield.Location = New System.Drawing.Point(125, 54)
        Me.formfield.Name = "formfield"
        Me.formfield.Size = New System.Drawing.Size(110, 21)
        Me.formfield.TabIndex = 99
        Me.formfield.Visible = False
        '
        'labelform
        '
        Me.labelform.AutoSize = True
        Me.labelform.ForeColor = System.Drawing.Color.Maroon
        Me.labelform.Location = New System.Drawing.Point(2, 60)
        Me.labelform.Name = "labelform"
        Me.labelform.Size = New System.Drawing.Size(72, 13)
        Me.labelform.TabIndex = 100
        Me.labelform.Text = "Select a form:"
        Me.labelform.Visible = False
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(125, 23)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(110, 21)
        Me.Yearfield.TabIndex = 97
        '
        'yearlabel
        '
        Me.yearlabel.AutoSize = True
        Me.yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.yearlabel.Location = New System.Drawing.Point(2, 31)
        Me.yearlabel.Name = "yearlabel"
        Me.yearlabel.Size = New System.Drawing.Size(115, 13)
        Me.yearlabel.TabIndex = 98
        Me.yearlabel.Text = "Select Academic Year:"
        '
        'Searchgroup
        '
        Me.Searchgroup.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Searchgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Searchgroup.FlatAppearance.BorderSize = 0
        Me.Searchgroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Searchgroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Searchgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Searchgroup.ForeColor = System.Drawing.Color.White
        Me.Searchgroup.Location = New System.Drawing.Point(83, 81)
        Me.Searchgroup.Name = "Searchgroup"
        Me.Searchgroup.Size = New System.Drawing.Size(66, 26)
        Me.Searchgroup.TabIndex = 55
        Me.Searchgroup.Text = "Search"
        Me.Searchgroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Searchgroup.UseVisualStyleBackColor = True
        Me.Searchgroup.Visible = False
        '
        'yeargroup
        '
        Me.yeargroup.BackColor = System.Drawing.Color.Transparent
        Me.yeargroup.Controls.Add(Me.yearcombo)
        Me.yeargroup.Controls.Add(Me.labelyear)
        Me.yeargroup.Controls.Add(Me.yearsearch)
        Me.yeargroup.ForeColor = System.Drawing.Color.Maroon
        Me.yeargroup.Location = New System.Drawing.Point(5, 558)
        Me.yeargroup.Name = "yeargroup"
        Me.yeargroup.Size = New System.Drawing.Size(240, 91)
        Me.yeargroup.TabIndex = 97
        Me.yeargroup.TabStop = False
        Me.yeargroup.Text = "View a Year's A2 Predicted Grades"
        '
        'yearcombo
        '
        Me.yearcombo.FormattingEnabled = True
        Me.yearcombo.Location = New System.Drawing.Point(123, 31)
        Me.yearcombo.Name = "yearcombo"
        Me.yearcombo.Size = New System.Drawing.Size(115, 21)
        Me.yearcombo.TabIndex = 97
        '
        'labelyear
        '
        Me.labelyear.AutoSize = True
        Me.labelyear.ForeColor = System.Drawing.Color.Maroon
        Me.labelyear.Location = New System.Drawing.Point(2, 34)
        Me.labelyear.Name = "labelyear"
        Me.labelyear.Size = New System.Drawing.Size(115, 13)
        Me.labelyear.TabIndex = 98
        Me.labelyear.Text = "Select Academic Year:"
        '
        'yearsearch
        '
        Me.yearsearch.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.yearsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.yearsearch.FlatAppearance.BorderSize = 0
        Me.yearsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.yearsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.yearsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearsearch.ForeColor = System.Drawing.Color.White
        Me.yearsearch.Location = New System.Drawing.Point(83, 59)
        Me.yearsearch.Name = "yearsearch"
        Me.yearsearch.Size = New System.Drawing.Size(66, 26)
        Me.yearsearch.TabIndex = 55
        Me.yearsearch.Text = "Search"
        Me.yearsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.yearsearch.UseVisualStyleBackColor = True
        Me.yearsearch.Visible = False
        '
        'grouppredictionsgrid
        '
        Me.grouppredictionsgrid.AllowUserToAddRows = False
        Me.grouppredictionsgrid.AllowUserToDeleteRows = False
        Me.grouppredictionsgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grouppredictionsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grouppredictionsgrid.Location = New System.Drawing.Point(248, 46)
        Me.grouppredictionsgrid.Name = "grouppredictionsgrid"
        Me.grouppredictionsgrid.ReadOnly = True
        Me.grouppredictionsgrid.RowHeadersVisible = False
        Me.grouppredictionsgrid.Size = New System.Drawing.Size(879, 645)
        Me.grouppredictionsgrid.TabIndex = 98
        Me.grouppredictionsgrid.Visible = False
        '
        'createcsv
        '
        Me.createcsv.BackColor = System.Drawing.Color.Transparent
        Me.createcsv.BackgroundImage = CType(resources.GetObject("createcsv.BackgroundImage"), System.Drawing.Image)
        Me.createcsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.createcsv.FlatAppearance.BorderSize = 0
        Me.createcsv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.createcsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.createcsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.createcsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createcsv.ForeColor = System.Drawing.Color.White
        Me.createcsv.Location = New System.Drawing.Point(119, 654)
        Me.createcsv.Name = "createcsv"
        Me.createcsv.Size = New System.Drawing.Size(100, 47)
        Me.createcsv.TabIndex = 99
        Me.createcsv.Text = "Create Spreadsheet file"
        Me.createcsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.createcsv.UseVisualStyleBackColor = False
        Me.createcsv.Visible = False
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
        Me.printbutton.Location = New System.Drawing.Point(1073, 9)
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
        'ClassPredictiongroup
        '
        Me.ClassPredictiongroup.BackColor = System.Drawing.Color.Transparent
        Me.ClassPredictiongroup.Controls.Add(Me.Classsearch)
        Me.ClassPredictiongroup.Controls.Add(Me.Classgroupfield)
        Me.ClassPredictiongroup.Controls.Add(Me.Classlabel)
        Me.ClassPredictiongroup.Controls.Add(Me.classyearfield)
        Me.ClassPredictiongroup.Controls.Add(Me.classyearlabel)
        Me.ClassPredictiongroup.Controls.Add(Me.subjectlabel)
        Me.ClassPredictiongroup.Controls.Add(Me.SubjectField)
        Me.ClassPredictiongroup.ForeColor = System.Drawing.Color.Maroon
        Me.ClassPredictiongroup.Location = New System.Drawing.Point(3, 378)
        Me.ClassPredictiongroup.Name = "ClassPredictiongroup"
        Me.ClassPredictiongroup.Size = New System.Drawing.Size(240, 148)
        Me.ClassPredictiongroup.TabIndex = 126
        Me.ClassPredictiongroup.TabStop = False
        Me.ClassPredictiongroup.Text = "View a Class's A2 Predicted Grades"
        '
        'Classsearch
        '
        Me.Classsearch.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Classsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Classsearch.FlatAppearance.BorderSize = 0
        Me.Classsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Classsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Classsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Classsearch.ForeColor = System.Drawing.Color.White
        Me.Classsearch.Location = New System.Drawing.Point(78, 118)
        Me.Classsearch.Name = "Classsearch"
        Me.Classsearch.Size = New System.Drawing.Size(66, 26)
        Me.Classsearch.TabIndex = 127
        Me.Classsearch.Text = "Search"
        Me.Classsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Classsearch.UseVisualStyleBackColor = True
        Me.Classsearch.Visible = False
        '
        'Classgroupfield
        '
        Me.Classgroupfield.FormattingEnabled = True
        Me.Classgroupfield.Location = New System.Drawing.Point(121, 84)
        Me.Classgroupfield.Name = "Classgroupfield"
        Me.Classgroupfield.Size = New System.Drawing.Size(119, 21)
        Me.Classgroupfield.TabIndex = 4
        Me.Classgroupfield.Visible = False
        '
        'Classlabel
        '
        Me.Classlabel.AutoSize = True
        Me.Classlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Classlabel.Location = New System.Drawing.Point(2, 93)
        Me.Classlabel.Name = "Classlabel"
        Me.Classlabel.Size = New System.Drawing.Size(77, 13)
        Me.Classlabel.TabIndex = 66
        Me.Classlabel.Text = "Select a Class:"
        Me.Classlabel.Visible = False
        '
        'classyearfield
        '
        Me.classyearfield.FormattingEnabled = True
        Me.classyearfield.Location = New System.Drawing.Point(121, 53)
        Me.classyearfield.Name = "classyearfield"
        Me.classyearfield.Size = New System.Drawing.Size(119, 21)
        Me.classyearfield.TabIndex = 2
        '
        'classyearlabel
        '
        Me.classyearlabel.AutoSize = True
        Me.classyearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.classyearlabel.Location = New System.Drawing.Point(2, 61)
        Me.classyearlabel.Name = "classyearlabel"
        Me.classyearlabel.Size = New System.Drawing.Size(115, 13)
        Me.classyearlabel.TabIndex = 57
        Me.classyearlabel.Text = "Select Academic Year:"
        '
        'subjectlabel
        '
        Me.subjectlabel.AutoSize = True
        Me.subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.subjectlabel.Location = New System.Drawing.Point(2, 32)
        Me.subjectlabel.Name = "subjectlabel"
        Me.subjectlabel.Size = New System.Drawing.Size(88, 13)
        Me.subjectlabel.TabIndex = 62
        Me.subjectlabel.Text = "Select a Subject:"
        '
        'SubjectField
        '
        Me.SubjectField.FormattingEnabled = True
        Me.SubjectField.Location = New System.Drawing.Point(121, 26)
        Me.SubjectField.Name = "SubjectField"
        Me.SubjectField.Size = New System.Drawing.Size(119, 21)
        Me.SubjectField.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(93, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Or"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(93, 534)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Or"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(93, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Or"
        '
        'Predictions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 703)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClassPredictiongroup)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.createcsv)
        Me.Controls.Add(Me.yeargroup)
        Me.Controls.Add(Me.formgroup)
        Me.Controls.Add(Me.Viewpredictionsgrid)
        Me.Controls.Add(Me.formlabel)
        Me.Controls.Add(Me.Clearselection)
        Me.Controls.Add(Me.Predictedgradesgrid)
        Me.Controls.Add(Me.studentgroup)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow1)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.grouppredictionsgrid)
        Me.MaximumSize = New System.Drawing.Size(1151, 741)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1151, 741)
        Me.Name = "Predictions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Predictions"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentgroup.ResumeLayout(False)
        Me.studentgroup.PerformLayout()
        CType(Me.Predictedgradesgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Viewpredictionsgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formgroup.ResumeLayout(False)
        Me.formgroup.PerformLayout()
        Me.yeargroup.ResumeLayout(False)
        Me.yeargroup.PerformLayout()
        CType(Me.grouppredictionsgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClassPredictiongroup.ResumeLayout(False)
        Me.ClassPredictiongroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow1 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents studentgroup As System.Windows.Forms.GroupBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents SearchDataset As System.Windows.Forms.ComboBox
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents fieldlabel As System.Windows.Forms.Label
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSNS As System.Windows.Forms.ComboBox
    Friend WithEvents selectstudent As System.Windows.Forms.Button
    Friend WithEvents SearchEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents Predictedgradesgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Clearselection As System.Windows.Forms.Button
    Friend WithEvents formlabel As System.Windows.Forms.Label
    Friend WithEvents Viewpredictionsgrid As System.Windows.Forms.DataGridView
    Friend WithEvents formgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Searchgroup As System.Windows.Forms.Button
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents yearlabel As System.Windows.Forms.Label
    Friend WithEvents formfield As System.Windows.Forms.ComboBox
    Friend WithEvents labelform As System.Windows.Forms.Label
    Friend WithEvents yeargroup As System.Windows.Forms.GroupBox
    Friend WithEvents yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents labelyear As System.Windows.Forms.Label
    Friend WithEvents yearsearch As System.Windows.Forms.Button
    Friend WithEvents grouppredictionsgrid As System.Windows.Forms.DataGridView
    Friend WithEvents throbber As System.Windows.Forms.PictureBox
    Friend WithEvents createcsv As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents ClassPredictiongroup As System.Windows.Forms.GroupBox
    Friend WithEvents Classsearch As System.Windows.Forms.Button
    Friend WithEvents Classgroupfield As System.Windows.Forms.ComboBox
    Friend WithEvents Classlabel As System.Windows.Forms.Label
    Friend WithEvents classyearfield As System.Windows.Forms.ComboBox
    Friend WithEvents classyearlabel As System.Windows.Forms.Label
    Friend WithEvents subjectlabel As System.Windows.Forms.Label
    Friend WithEvents SubjectField As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
