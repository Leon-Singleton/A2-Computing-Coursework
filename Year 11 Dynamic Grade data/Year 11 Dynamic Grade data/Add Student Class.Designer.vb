<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Student_Class
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Student_Class))
        Me.addstudentlink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow1 = New System.Windows.Forms.Label()
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow2 = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Searchgroup = New System.Windows.Forms.GroupBox()
        Me.Displaystudent = New System.Windows.Forms.Button()
        Me.SearchDataset = New System.Windows.Forms.ComboBox()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.fieldlabel = New System.Windows.Forms.Label()
        Me.SearchSNS = New System.Windows.Forms.ComboBox()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.SearchEthnicity = New System.Windows.Forms.ComboBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.Studentdisplaygrid = New System.Windows.Forms.DataGridView()
        Me.formheader = New System.Windows.Forms.Label()
        Me.Currentclassgrid = New System.Windows.Forms.DataGridView()
        Me.Gridheaderlabel = New System.Windows.Forms.Label()
        Me.firstnamelabel = New System.Windows.Forms.Label()
        Me.surnamelabel = New System.Windows.Forms.Label()
        Me.formlabel = New System.Windows.Forms.Label()
        Me.yearlabel = New System.Windows.Forms.Label()
        Me.Firstnamefield = New System.Windows.Forms.TextBox()
        Me.Yearfield = New System.Windows.Forms.TextBox()
        Me.Formfield = New System.Windows.Forms.TextBox()
        Me.Surnamefield = New System.Windows.Forms.TextBox()
        Me.addstudentgroup = New System.Windows.Forms.GroupBox()
        Me.addstudent = New System.Windows.Forms.Button()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Searchgroup.SuspendLayout()
        CType(Me.Studentdisplaygrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Currentclassgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addstudentgroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'addstudentlink
        '
        Me.addstudentlink.AutoSize = True
        Me.addstudentlink.BackColor = System.Drawing.Color.White
        Me.addstudentlink.Enabled = False
        Me.addstudentlink.LinkColor = System.Drawing.Color.Gray
        Me.addstudentlink.Location = New System.Drawing.Point(194, 12)
        Me.addstudentlink.Name = "addstudentlink"
        Me.addstudentlink.Size = New System.Drawing.Size(66, 13)
        Me.addstudentlink.TabIndex = 101
        Me.addstudentlink.TabStop = True
        Me.addstudentlink.Text = "Add Student"
        '
        'linkarrow1
        '
        Me.linkarrow1.AutoSize = True
        Me.linkarrow1.BackColor = System.Drawing.Color.White
        Me.linkarrow1.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow1.Location = New System.Drawing.Point(175, 8)
        Me.linkarrow1.Name = "linkarrow1"
        Me.linkarrow1.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow1.TabIndex = 100
        Me.linkarrow1.Text = "4"
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(95, 11)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(83, 13)
        Me.Classeslink.TabIndex = 99
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Student Classes"
        '
        'linkarrow2
        '
        Me.linkarrow2.AutoSize = True
        Me.linkarrow2.BackColor = System.Drawing.Color.White
        Me.linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow2.Location = New System.Drawing.Point(78, 8)
        Me.linkarrow2.Name = "linkarrow2"
        Me.linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow2.TabIndex = 98
        Me.linkarrow2.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(22, 11)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 97
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(4, 2)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(415, 31)
        Me.banner.TabIndex = 102
        Me.banner.TabStop = False
        '
        'Searchgroup
        '
        Me.Searchgroup.BackColor = System.Drawing.Color.Transparent
        Me.Searchgroup.Controls.Add(Me.Displaystudent)
        Me.Searchgroup.Controls.Add(Me.SearchDataset)
        Me.Searchgroup.Controls.Add(Me.Field)
        Me.Searchgroup.Controls.Add(Me.SearchYear)
        Me.Searchgroup.Controls.Add(Me.SearchName)
        Me.Searchgroup.Controls.Add(Me.SearchForm)
        Me.Searchgroup.Controls.Add(Me.fieldlabel)
        Me.Searchgroup.Controls.Add(Me.SearchSNS)
        Me.Searchgroup.Controls.Add(Me.wherelabel)
        Me.Searchgroup.Controls.Add(Me.SearchEthnicity)
        Me.Searchgroup.Controls.Add(Me.SearchGender)
        Me.Searchgroup.ForeColor = System.Drawing.Color.Maroon
        Me.Searchgroup.Location = New System.Drawing.Point(3, 166)
        Me.Searchgroup.Name = "Searchgroup"
        Me.Searchgroup.Size = New System.Drawing.Size(316, 93)
        Me.Searchgroup.TabIndex = 104
        Me.Searchgroup.TabStop = False
        Me.Searchgroup.Text = "Search for a Student"
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
        Me.Displaystudent.Location = New System.Drawing.Point(247, 37)
        Me.Displaystudent.Name = "Displaystudent"
        Me.Displaystudent.Size = New System.Drawing.Size(61, 35)
        Me.Displaystudent.TabIndex = 115
        Me.Displaystudent.Text = "Search"
        Me.Displaystudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Displaystudent.UseVisualStyleBackColor = True
        Me.Displaystudent.Visible = False
        '
        'SearchDataset
        '
        Me.SearchDataset.FormattingEnabled = True
        Me.SearchDataset.Location = New System.Drawing.Point(85, 56)
        Me.SearchDataset.Name = "SearchDataset"
        Me.SearchDataset.Size = New System.Drawing.Size(142, 21)
        Me.SearchDataset.TabIndex = 116
        Me.SearchDataset.Visible = False
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Name", "Form"})
        Me.Field.Location = New System.Drawing.Point(106, 19)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(121, 21)
        Me.Field.TabIndex = 115
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(85, 56)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(142, 21)
        Me.SearchYear.TabIndex = 124
        Me.SearchYear.Visible = False
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(85, 57)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(142, 20)
        Me.SearchName.TabIndex = 117
        Me.SearchName.Visible = False
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(85, 55)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(142, 21)
        Me.SearchForm.TabIndex = 123
        Me.SearchForm.Visible = False
        '
        'fieldlabel
        '
        Me.fieldlabel.AutoSize = True
        Me.fieldlabel.ForeColor = System.Drawing.Color.Maroon
        Me.fieldlabel.Location = New System.Drawing.Point(6, 22)
        Me.fieldlabel.Name = "fieldlabel"
        Me.fieldlabel.Size = New System.Drawing.Size(96, 13)
        Me.fieldlabel.TabIndex = 118
        Me.fieldlabel.Text = "Select an attribute:"
        '
        'SearchSNS
        '
        Me.SearchSNS.FormattingEnabled = True
        Me.SearchSNS.Location = New System.Drawing.Point(85, 57)
        Me.SearchSNS.Name = "SearchSNS"
        Me.SearchSNS.Size = New System.Drawing.Size(142, 21)
        Me.SearchSNS.TabIndex = 122
        Me.SearchSNS.Visible = False
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.ForeColor = System.Drawing.Color.Maroon
        Me.wherelabel.Location = New System.Drawing.Point(10, 59)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(37, 13)
        Me.wherelabel.TabIndex = 119
        Me.wherelabel.Text = "Value:"
        Me.wherelabel.Visible = False
        '
        'SearchEthnicity
        '
        Me.SearchEthnicity.FormattingEnabled = True
        Me.SearchEthnicity.Location = New System.Drawing.Point(85, 56)
        Me.SearchEthnicity.Name = "SearchEthnicity"
        Me.SearchEthnicity.Size = New System.Drawing.Size(142, 21)
        Me.SearchEthnicity.TabIndex = 121
        Me.SearchEthnicity.Visible = False
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(85, 57)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(142, 21)
        Me.SearchGender.TabIndex = 120
        Me.SearchGender.Visible = False
        '
        'Studentdisplaygrid
        '
        Me.Studentdisplaygrid.AllowUserToAddRows = False
        Me.Studentdisplaygrid.AllowUserToDeleteRows = False
        Me.Studentdisplaygrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Studentdisplaygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Studentdisplaygrid.Location = New System.Drawing.Point(3, 265)
        Me.Studentdisplaygrid.Name = "Studentdisplaygrid"
        Me.Studentdisplaygrid.ReadOnly = True
        Me.Studentdisplaygrid.RowHeadersVisible = False
        Me.Studentdisplaygrid.Size = New System.Drawing.Size(415, 163)
        Me.Studentdisplaygrid.TabIndex = 106
        Me.Studentdisplaygrid.Visible = False
        '
        'formheader
        '
        Me.formheader.AutoSize = True
        Me.formheader.BackColor = System.Drawing.Color.Transparent
        Me.formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formheader.ForeColor = System.Drawing.Color.Maroon
        Me.formheader.Location = New System.Drawing.Point(8, 45)
        Me.formheader.Name = "formheader"
        Me.formheader.Size = New System.Drawing.Size(180, 20)
        Me.formheader.TabIndex = 114
        Me.formheader.Text = "Add Student to Class"
        '
        'Currentclassgrid
        '
        Me.Currentclassgrid.AllowUserToAddRows = False
        Me.Currentclassgrid.AllowUserToDeleteRows = False
        Me.Currentclassgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Currentclassgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Currentclassgrid.Location = New System.Drawing.Point(5, 98)
        Me.Currentclassgrid.Name = "Currentclassgrid"
        Me.Currentclassgrid.ReadOnly = True
        Me.Currentclassgrid.RowHeadersVisible = False
        Me.Currentclassgrid.Size = New System.Drawing.Size(314, 62)
        Me.Currentclassgrid.TabIndex = 113
        Me.Currentclassgrid.Visible = False
        '
        'Gridheaderlabel
        '
        Me.Gridheaderlabel.AutoSize = True
        Me.Gridheaderlabel.BackColor = System.Drawing.Color.Transparent
        Me.Gridheaderlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridheaderlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gridheaderlabel.Location = New System.Drawing.Point(8, 79)
        Me.Gridheaderlabel.Name = "Gridheaderlabel"
        Me.Gridheaderlabel.Size = New System.Drawing.Size(147, 16)
        Me.Gridheaderlabel.TabIndex = 112
        Me.Gridheaderlabel.Text = "Current Selected Class:"
        '
        'firstnamelabel
        '
        Me.firstnamelabel.AutoSize = True
        Me.firstnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.firstnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.firstnamelabel.Location = New System.Drawing.Point(9, 31)
        Me.firstnamelabel.Name = "firstnamelabel"
        Me.firstnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.firstnamelabel.TabIndex = 115
        Me.firstnamelabel.Text = "Firstname:"
        '
        'surnamelabel
        '
        Me.surnamelabel.AutoSize = True
        Me.surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.surnamelabel.Location = New System.Drawing.Point(9, 64)
        Me.surnamelabel.Name = "surnamelabel"
        Me.surnamelabel.Size = New System.Drawing.Size(52, 13)
        Me.surnamelabel.TabIndex = 116
        Me.surnamelabel.Text = "Surname:"
        '
        'formlabel
        '
        Me.formlabel.AutoSize = True
        Me.formlabel.BackColor = System.Drawing.Color.Transparent
        Me.formlabel.ForeColor = System.Drawing.Color.Maroon
        Me.formlabel.Location = New System.Drawing.Point(9, 97)
        Me.formlabel.Name = "formlabel"
        Me.formlabel.Size = New System.Drawing.Size(33, 13)
        Me.formlabel.TabIndex = 117
        Me.formlabel.Text = "Form:"
        '
        'yearlabel
        '
        Me.yearlabel.AutoSize = True
        Me.yearlabel.BackColor = System.Drawing.Color.Transparent
        Me.yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.yearlabel.Location = New System.Drawing.Point(9, 130)
        Me.yearlabel.Name = "yearlabel"
        Me.yearlabel.Size = New System.Drawing.Size(32, 13)
        Me.yearlabel.TabIndex = 118
        Me.yearlabel.Text = "Year:"
        '
        'Firstnamefield
        '
        Me.Firstnamefield.Enabled = False
        Me.Firstnamefield.Location = New System.Drawing.Point(97, 28)
        Me.Firstnamefield.Name = "Firstnamefield"
        Me.Firstnamefield.Size = New System.Drawing.Size(132, 20)
        Me.Firstnamefield.TabIndex = 119
        '
        'Yearfield
        '
        Me.Yearfield.Enabled = False
        Me.Yearfield.Location = New System.Drawing.Point(97, 127)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(132, 20)
        Me.Yearfield.TabIndex = 120
        '
        'Formfield
        '
        Me.Formfield.Enabled = False
        Me.Formfield.Location = New System.Drawing.Point(97, 94)
        Me.Formfield.Name = "Formfield"
        Me.Formfield.Size = New System.Drawing.Size(132, 20)
        Me.Formfield.TabIndex = 121
        '
        'Surnamefield
        '
        Me.Surnamefield.Enabled = False
        Me.Surnamefield.Location = New System.Drawing.Point(97, 61)
        Me.Surnamefield.Name = "Surnamefield"
        Me.Surnamefield.Size = New System.Drawing.Size(132, 20)
        Me.Surnamefield.TabIndex = 122
        '
        'addstudentgroup
        '
        Me.addstudentgroup.BackColor = System.Drawing.Color.Transparent
        Me.addstudentgroup.Controls.Add(Me.addstudent)
        Me.addstudentgroup.Controls.Add(Me.Formfield)
        Me.addstudentgroup.Controls.Add(Me.Surnamefield)
        Me.addstudentgroup.Controls.Add(Me.firstnamelabel)
        Me.addstudentgroup.Controls.Add(Me.surnamelabel)
        Me.addstudentgroup.Controls.Add(Me.Yearfield)
        Me.addstudentgroup.Controls.Add(Me.formlabel)
        Me.addstudentgroup.Controls.Add(Me.Firstnamefield)
        Me.addstudentgroup.Controls.Add(Me.yearlabel)
        Me.addstudentgroup.ForeColor = System.Drawing.Color.Maroon
        Me.addstudentgroup.Location = New System.Drawing.Point(7, 267)
        Me.addstudentgroup.Name = "addstudentgroup"
        Me.addstudentgroup.Size = New System.Drawing.Size(408, 161)
        Me.addstudentgroup.TabIndex = 123
        Me.addstudentgroup.TabStop = False
        Me.addstudentgroup.Text = "Add Selected Student to Class"
        Me.addstudentgroup.Visible = False
        '
        'addstudent
        '
        Me.addstudent.BackgroundImage = CType(resources.GetObject("addstudent.BackgroundImage"), System.Drawing.Image)
        Me.addstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addstudent.FlatAppearance.BorderSize = 0
        Me.addstudent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.addstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.addstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.addstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addstudent.ForeColor = System.Drawing.Color.White
        Me.addstudent.Location = New System.Drawing.Point(262, 111)
        Me.addstudent.Name = "addstudent"
        Me.addstudent.Size = New System.Drawing.Size(111, 36)
        Me.addstudent.TabIndex = 123
        Me.addstudent.Text = "Add Selected Student"
        Me.addstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.addstudent.UseVisualStyleBackColor = True
        '
        'Add_Student_Class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(425, 438)
        Me.Controls.Add(Me.addstudentgroup)
        Me.Controls.Add(Me.formheader)
        Me.Controls.Add(Me.Currentclassgrid)
        Me.Controls.Add(Me.Gridheaderlabel)
        Me.Controls.Add(Me.Searchgroup)
        Me.Controls.Add(Me.addstudentlink)
        Me.Controls.Add(Me.linkarrow1)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow2)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Studentdisplaygrid)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(441, 476)
        Me.MinimumSize = New System.Drawing.Size(441, 476)
        Me.Name = "Add_Student_Class"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student Class"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Searchgroup.ResumeLayout(False)
        Me.Searchgroup.PerformLayout()
        CType(Me.Studentdisplaygrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Currentclassgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addstudentgroup.ResumeLayout(False)
        Me.addstudentgroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addstudentlink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow1 As System.Windows.Forms.Label
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Searchgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Studentdisplaygrid As System.Windows.Forms.DataGridView
    Friend WithEvents formheader As System.Windows.Forms.Label
    Friend WithEvents Currentclassgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Gridheaderlabel As System.Windows.Forms.Label
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents fieldlabel As System.Windows.Forms.Label
    Friend WithEvents SearchSNS As System.Windows.Forms.ComboBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents SearchEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents Displaystudent As System.Windows.Forms.Button
    Friend WithEvents firstnamelabel As System.Windows.Forms.Label
    Friend WithEvents surnamelabel As System.Windows.Forms.Label
    Friend WithEvents formlabel As System.Windows.Forms.Label
    Friend WithEvents yearlabel As System.Windows.Forms.Label
    Friend WithEvents Firstnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Yearfield As System.Windows.Forms.TextBox
    Friend WithEvents Formfield As System.Windows.Forms.TextBox
    Friend WithEvents Surnamefield As System.Windows.Forms.TextBox
    Friend WithEvents addstudentgroup As System.Windows.Forms.GroupBox
    Friend WithEvents addstudent As System.Windows.Forms.Button
    Friend WithEvents SearchDataset As System.Windows.Forms.ComboBox
End Class
