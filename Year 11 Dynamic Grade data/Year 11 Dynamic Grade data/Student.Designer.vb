<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_View))
        Me.formtitle = New System.Windows.Forms.Label()
        Me.StudentGrid = New System.Windows.Forms.DataGridView()
        Me.Displaystudent = New System.Windows.Forms.Button()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.studentgroup = New System.Windows.Forms.GroupBox()
        Me.SearchDataset = New System.Windows.Forms.ComboBox()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.Addstudent = New System.Windows.Forms.Button()
        Me.SearchSNS = New System.Windows.Forms.ComboBox()
        Me.SearchEthnicity = New System.Windows.Forms.ComboBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.Fieldlabel = New System.Windows.Forms.Label()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.Student = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.Banner = New System.Windows.Forms.PictureBox()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.newdataset = New System.Windows.Forms.Button()
        Me.academicyearcombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.importcsv = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentgroup.SuspendLayout()
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'formtitle
        '
        Me.formtitle.AutoSize = True
        Me.formtitle.BackColor = System.Drawing.Color.Transparent
        Me.formtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formtitle.ForeColor = System.Drawing.Color.Maroon
        Me.formtitle.Location = New System.Drawing.Point(5, 41)
        Me.formtitle.Name = "formtitle"
        Me.formtitle.Size = New System.Drawing.Size(196, 20)
        Me.formtitle.TabIndex = 6
        Me.formtitle.Text = "Search Student Details"
        '
        'StudentGrid
        '
        Me.StudentGrid.AllowUserToAddRows = False
        Me.StudentGrid.AllowUserToDeleteRows = False
        Me.StudentGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGrid.Location = New System.Drawing.Point(246, 67)
        Me.StudentGrid.Name = "StudentGrid"
        Me.StudentGrid.ReadOnly = True
        Me.StudentGrid.RowHeadersVisible = False
        Me.StudentGrid.Size = New System.Drawing.Size(965, 392)
        Me.StudentGrid.TabIndex = 8
        Me.StudentGrid.Visible = False
        '
        'Displaystudent
        '
        Me.Displaystudent.BackgroundImage = CType(resources.GetObject("Displaystudent.BackgroundImage"), System.Drawing.Image)
        Me.Displaystudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Displaystudent.FlatAppearance.BorderSize = 0
        Me.Displaystudent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Displaystudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Displaystudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Displaystudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Displaystudent.ForeColor = System.Drawing.Color.White
        Me.Displaystudent.Location = New System.Drawing.Point(80, 119)
        Me.Displaystudent.Name = "Displaystudent"
        Me.Displaystudent.Size = New System.Drawing.Size(86, 29)
        Me.Displaystudent.TabIndex = 9
        Me.Displaystudent.Text = "Search"
        Me.Displaystudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Displaystudent.UseVisualStyleBackColor = True
        Me.Displaystudent.Visible = False
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Name", "Gender", "SNS", "Ethnicity", "Form"})
        Me.Field.Location = New System.Drawing.Point(107, 41)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(121, 21)
        Me.Field.TabIndex = 1
        '
        'studentgroup
        '
        Me.studentgroup.BackColor = System.Drawing.Color.Transparent
        Me.studentgroup.Controls.Add(Me.SearchDataset)
        Me.studentgroup.Controls.Add(Me.SearchYear)
        Me.studentgroup.Controls.Add(Me.SearchForm)
        Me.studentgroup.Controls.Add(Me.Addstudent)
        Me.studentgroup.Controls.Add(Me.SearchSNS)
        Me.studentgroup.Controls.Add(Me.SearchEthnicity)
        Me.studentgroup.Controls.Add(Me.SearchGender)
        Me.studentgroup.Controls.Add(Me.wherelabel)
        Me.studentgroup.Controls.Add(Me.Fieldlabel)
        Me.studentgroup.Controls.Add(Me.SearchName)
        Me.studentgroup.Controls.Add(Me.Displaystudent)
        Me.studentgroup.Controls.Add(Me.Field)
        Me.studentgroup.ForeColor = System.Drawing.Color.Maroon
        Me.studentgroup.Location = New System.Drawing.Point(5, 67)
        Me.studentgroup.Name = "studentgroup"
        Me.studentgroup.Size = New System.Drawing.Size(235, 243)
        Me.studentgroup.TabIndex = 11
        Me.studentgroup.TabStop = False
        Me.studentgroup.Text = "Search Student"
        '
        'SearchDataset
        '
        Me.SearchDataset.FormattingEnabled = True
        Me.SearchDataset.Location = New System.Drawing.Point(90, 78)
        Me.SearchDataset.Name = "SearchDataset"
        Me.SearchDataset.Size = New System.Drawing.Size(142, 21)
        Me.SearchDataset.TabIndex = 2
        Me.SearchDataset.Visible = False
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(90, 77)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(142, 21)
        Me.SearchYear.TabIndex = 18
        Me.SearchYear.Visible = False
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(90, 76)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(142, 21)
        Me.SearchForm.TabIndex = 17
        Me.SearchForm.Visible = False
        '
        'Addstudent
        '
        Me.Addstudent.BackColor = System.Drawing.Color.Transparent
        Me.Addstudent.BackgroundImage = CType(resources.GetObject("Addstudent.BackgroundImage"), System.Drawing.Image)
        Me.Addstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addstudent.FlatAppearance.BorderSize = 0
        Me.Addstudent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addstudent.ForeColor = System.Drawing.Color.White
        Me.Addstudent.Location = New System.Drawing.Point(67, 177)
        Me.Addstudent.Name = "Addstudent"
        Me.Addstudent.Size = New System.Drawing.Size(108, 49)
        Me.Addstudent.TabIndex = 13
        Me.Addstudent.Text = "Add New Student"
        Me.Addstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Addstudent.UseVisualStyleBackColor = False
        '
        'SearchSNS
        '
        Me.SearchSNS.FormattingEnabled = True
        Me.SearchSNS.Location = New System.Drawing.Point(90, 78)
        Me.SearchSNS.Name = "SearchSNS"
        Me.SearchSNS.Size = New System.Drawing.Size(142, 21)
        Me.SearchSNS.TabIndex = 16
        Me.SearchSNS.Visible = False
        '
        'SearchEthnicity
        '
        Me.SearchEthnicity.FormattingEnabled = True
        Me.SearchEthnicity.Location = New System.Drawing.Point(90, 77)
        Me.SearchEthnicity.Name = "SearchEthnicity"
        Me.SearchEthnicity.Size = New System.Drawing.Size(142, 21)
        Me.SearchEthnicity.TabIndex = 15
        Me.SearchEthnicity.Visible = False
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(90, 78)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(142, 21)
        Me.SearchGender.TabIndex = 14
        Me.SearchGender.Visible = False
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(8, 81)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 12
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'Fieldlabel
        '
        Me.Fieldlabel.AutoSize = True
        Me.Fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Fieldlabel.Location = New System.Drawing.Point(3, 43)
        Me.Fieldlabel.Name = "Fieldlabel"
        Me.Fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.Fieldlabel.TabIndex = 11
        Me.Fieldlabel.Text = "Select an attribute:"
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(90, 78)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(142, 20)
        Me.SearchName.TabIndex = 5
        Me.SearchName.Visible = False
        '
        'Student
        '
        Me.Student.AutoSize = True
        Me.Student.BackColor = System.Drawing.Color.White
        Me.Student.Enabled = False
        Me.Student.LinkColor = System.Drawing.Color.Gray
        Me.Student.Location = New System.Drawing.Point(93, 13)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(44, 13)
        Me.Student.TabIndex = 41
        Me.Student.TabStop = True
        Me.Student.Text = "Student"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(14, 13)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 40
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(70, 10)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 69
        Me.linkarrow.Text = "4"
        '
        'Banner
        '
        Me.Banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Banner.Location = New System.Drawing.Point(2, 4)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(1175, 31)
        Me.Banner.TabIndex = 83
        Me.Banner.TabStop = False
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
        Me.printbutton.Location = New System.Drawing.Point(1180, 4)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.newdataset)
        Me.GroupBox1.Controls.Add(Me.academicyearcombo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.importcsv)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 137)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import CSV"
        '
        'newdataset
        '
        Me.newdataset.BackgroundImage = CType(resources.GetObject("newdataset.BackgroundImage"), System.Drawing.Image)
        Me.newdataset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.newdataset.FlatAppearance.BorderSize = 0
        Me.newdataset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.newdataset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.newdataset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.newdataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newdataset.ForeColor = System.Drawing.Color.White
        Me.newdataset.Location = New System.Drawing.Point(49, 21)
        Me.newdataset.Name = "newdataset"
        Me.newdataset.Size = New System.Drawing.Size(143, 38)
        Me.newdataset.TabIndex = 19
        Me.newdataset.Text = "Add a new Dataset Year"
        Me.newdataset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.newdataset.UseVisualStyleBackColor = True
        '
        'academicyearcombo
        '
        Me.academicyearcombo.FormattingEnabled = True
        Me.academicyearcombo.Location = New System.Drawing.Point(133, 67)
        Me.academicyearcombo.Name = "academicyearcombo"
        Me.academicyearcombo.Size = New System.Drawing.Size(92, 21)
        Me.academicyearcombo.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Select an Academic Year:"
        '
        'importcsv
        '
        Me.importcsv.BackgroundImage = CType(resources.GetObject("importcsv.BackgroundImage"), System.Drawing.Image)
        Me.importcsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.importcsv.FlatAppearance.BorderSize = 0
        Me.importcsv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.importcsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.importcsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.importcsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.importcsv.ForeColor = System.Drawing.Color.White
        Me.importcsv.Location = New System.Drawing.Point(63, 94)
        Me.importcsv.Name = "importcsv"
        Me.importcsv.Size = New System.Drawing.Size(97, 36)
        Me.importcsv.TabIndex = 10
        Me.importcsv.Text = "Import CSV file"
        Me.importcsv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.importcsv.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Student_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(1215, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.Student)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.studentgroup)
        Me.Controls.Add(Me.StudentGrid)
        Me.Controls.Add(Me.formtitle)
        Me.Controls.Add(Me.Banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1231, 503)
        Me.MinimumSize = New System.Drawing.Size(1231, 503)
        Me.Name = "Student_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentgroup.ResumeLayout(False)
        Me.studentgroup.PerformLayout()
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents formtitle As System.Windows.Forms.Label
    Friend WithEvents Displaystudent As System.Windows.Forms.Button
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents studentgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Fieldlabel As System.Windows.Forms.Label
    Friend WithEvents StudentGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Addstudent As System.Windows.Forms.Button
    Friend WithEvents Student As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents SearchDataset As System.Windows.Forms.ComboBox
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSNS As System.Windows.Forms.ComboBox
    Friend WithEvents SearchEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents Banner As System.Windows.Forms.PictureBox
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents academicyearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents importcsv As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents newdataset As System.Windows.Forms.Button
End Class
