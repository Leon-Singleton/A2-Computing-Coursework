<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Developer_Features
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Developer_Features))
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.Developer = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Subjectgroup = New System.Windows.Forms.GroupBox()
        Me.Viewcurrentsubjects = New System.Windows.Forms.Button()
        Me.Addsubjectbutton = New System.Windows.Forms.Button()
        Me.Departmentlabel = New System.Windows.Forms.Label()
        Me.Departmentfield = New System.Windows.Forms.ComboBox()
        Me.Newsubjectlabel = New System.Windows.Forms.Label()
        Me.Newsubjectfield = New System.Windows.Forms.TextBox()
        Me.Levelgroup = New System.Windows.Forms.GroupBox()
        Me.Viewcurrentlevel = New System.Windows.Forms.Button()
        Me.Addlevelbutton = New System.Windows.Forms.Button()
        Me.Newlevellabel = New System.Windows.Forms.Label()
        Me.Levelfield = New System.Windows.Forms.TextBox()
        Me.Gradetypegroup = New System.Windows.Forms.GroupBox()
        Me.Viewcurrentgradetype = New System.Windows.Forms.Button()
        Me.Addgradetypebutton = New System.Windows.Forms.Button()
        Me.Newgradetypelabel = New System.Windows.Forms.Label()
        Me.Newgradetypefield = New System.Windows.Forms.TextBox()
        Me.Dataset = New System.Windows.Forms.GroupBox()
        Me.Viewcurrentdatasetyear = New System.Windows.Forms.Button()
        Me.Adddatasetyear = New System.Windows.Forms.Button()
        Me.Newdatasetyearlabel = New System.Windows.Forms.Label()
        Me.Datasetyearfield = New System.Windows.Forms.TextBox()
        Me.Viewcurrentvalues = New System.Windows.Forms.DataGridView()
        Me.Admingroup = New System.Windows.Forms.GroupBox()
        Me.Adminaction = New System.Windows.Forms.ComboBox()
        Me.adminactionlabel = New System.Windows.Forms.Label()
        Me.edittitle = New System.Windows.Forms.Label()
        Me.Addlogingroup = New System.Windows.Forms.GroupBox()
        Me.adminfield = New System.Windows.Forms.ComboBox()
        Me.passwordlabel = New System.Windows.Forms.Label()
        Me.passwordfield = New System.Windows.Forms.TextBox()
        Me.adminlabel = New System.Windows.Forms.Label()
        Me.viewlogins = New System.Windows.Forms.Button()
        Me.adduser = New System.Windows.Forms.Button()
        Me.usernamelabel = New System.Windows.Forms.Label()
        Me.usernamefield = New System.Windows.Forms.TextBox()
        Me.Editlogingroup = New System.Windows.Forms.GroupBox()
        Me.loginidlabel = New System.Windows.Forms.Label()
        Me.loginidfield = New System.Windows.Forms.TextBox()
        Me.adminfield1 = New System.Windows.Forms.ComboBox()
        Me.passwordlabel1 = New System.Windows.Forms.Label()
        Me.passwordfield1 = New System.Windows.Forms.TextBox()
        Me.adminlabel1 = New System.Windows.Forms.Label()
        Me.vieweditlogins = New System.Windows.Forms.Button()
        Me.editlogin = New System.Windows.Forms.Button()
        Me.usernamelabel1 = New System.Windows.Forms.Label()
        Me.usernamefield1 = New System.Windows.Forms.TextBox()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Subjectgroup.SuspendLayout()
        Me.Levelgroup.SuspendLayout()
        Me.Gradetypegroup.SuspendLayout()
        Me.Dataset.SuspendLayout()
        CType(Me.Viewcurrentvalues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Admingroup.SuspendLayout()
        Me.Addlogingroup.SuspendLayout()
        Me.Editlogingroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(68, 9)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 72
        Me.linkarrow.Text = "4"
        '
        'Developer
        '
        Me.Developer.AutoSize = True
        Me.Developer.BackColor = System.Drawing.Color.White
        Me.Developer.Enabled = False
        Me.Developer.LinkColor = System.Drawing.Color.Gray
        Me.Developer.Location = New System.Drawing.Point(91, 12)
        Me.Developer.Name = "Developer"
        Me.Developer.Size = New System.Drawing.Size(80, 13)
        Me.Developer.TabIndex = 71
        Me.Developer.TabStop = True
        Me.Developer.Text = "Admin Features"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 70
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(2, 3)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(724, 31)
        Me.banner.TabIndex = 84
        Me.banner.TabStop = False
        '
        'Subjectgroup
        '
        Me.Subjectgroup.BackColor = System.Drawing.Color.Transparent
        Me.Subjectgroup.Controls.Add(Me.Viewcurrentsubjects)
        Me.Subjectgroup.Controls.Add(Me.Addsubjectbutton)
        Me.Subjectgroup.Controls.Add(Me.Departmentlabel)
        Me.Subjectgroup.Controls.Add(Me.Departmentfield)
        Me.Subjectgroup.Controls.Add(Me.Newsubjectlabel)
        Me.Subjectgroup.Controls.Add(Me.Newsubjectfield)
        Me.Subjectgroup.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectgroup.Location = New System.Drawing.Point(57, 160)
        Me.Subjectgroup.Name = "Subjectgroup"
        Me.Subjectgroup.Size = New System.Drawing.Size(205, 143)
        Me.Subjectgroup.TabIndex = 85
        Me.Subjectgroup.TabStop = False
        Me.Subjectgroup.Text = "Add a new subject"
        Me.Subjectgroup.Visible = False
        '
        'Viewcurrentsubjects
        '
        Me.Viewcurrentsubjects.BackgroundImage = CType(resources.GetObject("Viewcurrentsubjects.BackgroundImage"), System.Drawing.Image)
        Me.Viewcurrentsubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewcurrentsubjects.FlatAppearance.BorderSize = 0
        Me.Viewcurrentsubjects.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentsubjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentsubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentsubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Viewcurrentsubjects.ForeColor = System.Drawing.Color.White
        Me.Viewcurrentsubjects.Location = New System.Drawing.Point(27, 109)
        Me.Viewcurrentsubjects.Name = "Viewcurrentsubjects"
        Me.Viewcurrentsubjects.Size = New System.Drawing.Size(148, 23)
        Me.Viewcurrentsubjects.TabIndex = 96
        Me.Viewcurrentsubjects.Text = "View Current Subjects"
        Me.Viewcurrentsubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Viewcurrentsubjects.UseVisualStyleBackColor = True
        '
        'Addsubjectbutton
        '
        Me.Addsubjectbutton.BackgroundImage = CType(resources.GetObject("Addsubjectbutton.BackgroundImage"), System.Drawing.Image)
        Me.Addsubjectbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addsubjectbutton.FlatAppearance.BorderSize = 0
        Me.Addsubjectbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addsubjectbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addsubjectbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addsubjectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addsubjectbutton.ForeColor = System.Drawing.Color.White
        Me.Addsubjectbutton.Location = New System.Drawing.Point(57, 80)
        Me.Addsubjectbutton.Name = "Addsubjectbutton"
        Me.Addsubjectbutton.Size = New System.Drawing.Size(75, 23)
        Me.Addsubjectbutton.TabIndex = 86
        Me.Addsubjectbutton.Text = "Add"
        Me.Addsubjectbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addsubjectbutton.UseVisualStyleBackColor = True
        '
        'Departmentlabel
        '
        Me.Departmentlabel.AutoSize = True
        Me.Departmentlabel.Location = New System.Drawing.Point(6, 58)
        Me.Departmentlabel.Name = "Departmentlabel"
        Me.Departmentlabel.Size = New System.Drawing.Size(62, 13)
        Me.Departmentlabel.TabIndex = 89
        Me.Departmentlabel.Text = "Department"
        '
        'Departmentfield
        '
        Me.Departmentfield.FormattingEnabled = True
        Me.Departmentfield.Location = New System.Drawing.Point(94, 55)
        Me.Departmentfield.Name = "Departmentfield"
        Me.Departmentfield.Size = New System.Drawing.Size(100, 21)
        Me.Departmentfield.TabIndex = 2
        '
        'Newsubjectlabel
        '
        Me.Newsubjectlabel.AutoSize = True
        Me.Newsubjectlabel.Location = New System.Drawing.Point(6, 31)
        Me.Newsubjectlabel.Name = "Newsubjectlabel"
        Me.Newsubjectlabel.Size = New System.Drawing.Size(71, 13)
        Me.Newsubjectlabel.TabIndex = 87
        Me.Newsubjectlabel.Text = "New Subject:"
        '
        'Newsubjectfield
        '
        Me.Newsubjectfield.Location = New System.Drawing.Point(94, 28)
        Me.Newsubjectfield.Name = "Newsubjectfield"
        Me.Newsubjectfield.Size = New System.Drawing.Size(100, 20)
        Me.Newsubjectfield.TabIndex = 1
        '
        'Levelgroup
        '
        Me.Levelgroup.BackColor = System.Drawing.Color.Transparent
        Me.Levelgroup.Controls.Add(Me.Viewcurrentlevel)
        Me.Levelgroup.Controls.Add(Me.Addlevelbutton)
        Me.Levelgroup.Controls.Add(Me.Newlevellabel)
        Me.Levelgroup.Controls.Add(Me.Levelfield)
        Me.Levelgroup.ForeColor = System.Drawing.Color.Maroon
        Me.Levelgroup.Location = New System.Drawing.Point(59, 164)
        Me.Levelgroup.Name = "Levelgroup"
        Me.Levelgroup.Size = New System.Drawing.Size(200, 143)
        Me.Levelgroup.TabIndex = 90
        Me.Levelgroup.TabStop = False
        Me.Levelgroup.Text = "Add a new Level"
        Me.Levelgroup.Visible = False
        '
        'Viewcurrentlevel
        '
        Me.Viewcurrentlevel.BackgroundImage = CType(resources.GetObject("Viewcurrentlevel.BackgroundImage"), System.Drawing.Image)
        Me.Viewcurrentlevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewcurrentlevel.FlatAppearance.BorderSize = 0
        Me.Viewcurrentlevel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentlevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentlevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Viewcurrentlevel.ForeColor = System.Drawing.Color.White
        Me.Viewcurrentlevel.Location = New System.Drawing.Point(23, 113)
        Me.Viewcurrentlevel.Name = "Viewcurrentlevel"
        Me.Viewcurrentlevel.Size = New System.Drawing.Size(148, 23)
        Me.Viewcurrentlevel.TabIndex = 97
        Me.Viewcurrentlevel.Text = "View Current Levels"
        Me.Viewcurrentlevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Viewcurrentlevel.UseVisualStyleBackColor = True
        '
        'Addlevelbutton
        '
        Me.Addlevelbutton.BackgroundImage = CType(resources.GetObject("Addlevelbutton.BackgroundImage"), System.Drawing.Image)
        Me.Addlevelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addlevelbutton.FlatAppearance.BorderSize = 0
        Me.Addlevelbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addlevelbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addlevelbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addlevelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addlevelbutton.ForeColor = System.Drawing.Color.White
        Me.Addlevelbutton.Location = New System.Drawing.Point(57, 81)
        Me.Addlevelbutton.Name = "Addlevelbutton"
        Me.Addlevelbutton.Size = New System.Drawing.Size(75, 23)
        Me.Addlevelbutton.TabIndex = 86
        Me.Addlevelbutton.Text = "Add"
        Me.Addlevelbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addlevelbutton.UseVisualStyleBackColor = True
        '
        'Newlevellabel
        '
        Me.Newlevellabel.AutoSize = True
        Me.Newlevellabel.Location = New System.Drawing.Point(6, 51)
        Me.Newlevellabel.Name = "Newlevellabel"
        Me.Newlevellabel.Size = New System.Drawing.Size(61, 13)
        Me.Newlevellabel.TabIndex = 87
        Me.Newlevellabel.Text = "New Level:"
        '
        'Levelfield
        '
        Me.Levelfield.Location = New System.Drawing.Point(94, 48)
        Me.Levelfield.Name = "Levelfield"
        Me.Levelfield.Size = New System.Drawing.Size(100, 20)
        Me.Levelfield.TabIndex = 3
        '
        'Gradetypegroup
        '
        Me.Gradetypegroup.BackColor = System.Drawing.Color.Transparent
        Me.Gradetypegroup.Controls.Add(Me.Viewcurrentgradetype)
        Me.Gradetypegroup.Controls.Add(Me.Addgradetypebutton)
        Me.Gradetypegroup.Controls.Add(Me.Newgradetypelabel)
        Me.Gradetypegroup.Controls.Add(Me.Newgradetypefield)
        Me.Gradetypegroup.ForeColor = System.Drawing.Color.Maroon
        Me.Gradetypegroup.Location = New System.Drawing.Point(57, 166)
        Me.Gradetypegroup.Name = "Gradetypegroup"
        Me.Gradetypegroup.Size = New System.Drawing.Size(204, 143)
        Me.Gradetypegroup.TabIndex = 91
        Me.Gradetypegroup.TabStop = False
        Me.Gradetypegroup.Text = "Add a new Grade Type"
        Me.Gradetypegroup.Visible = False
        '
        'Viewcurrentgradetype
        '
        Me.Viewcurrentgradetype.BackgroundImage = CType(resources.GetObject("Viewcurrentgradetype.BackgroundImage"), System.Drawing.Image)
        Me.Viewcurrentgradetype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewcurrentgradetype.FlatAppearance.BorderSize = 0
        Me.Viewcurrentgradetype.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentgradetype.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentgradetype.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentgradetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Viewcurrentgradetype.ForeColor = System.Drawing.Color.White
        Me.Viewcurrentgradetype.Location = New System.Drawing.Point(26, 110)
        Me.Viewcurrentgradetype.Name = "Viewcurrentgradetype"
        Me.Viewcurrentgradetype.Size = New System.Drawing.Size(148, 23)
        Me.Viewcurrentgradetype.TabIndex = 94
        Me.Viewcurrentgradetype.Text = "View Current Grade Types"
        Me.Viewcurrentgradetype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Viewcurrentgradetype.UseVisualStyleBackColor = True
        '
        'Addgradetypebutton
        '
        Me.Addgradetypebutton.BackgroundImage = CType(resources.GetObject("Addgradetypebutton.BackgroundImage"), System.Drawing.Image)
        Me.Addgradetypebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addgradetypebutton.FlatAppearance.BorderSize = 0
        Me.Addgradetypebutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addgradetypebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addgradetypebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addgradetypebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addgradetypebutton.ForeColor = System.Drawing.Color.White
        Me.Addgradetypebutton.Location = New System.Drawing.Point(56, 79)
        Me.Addgradetypebutton.Name = "Addgradetypebutton"
        Me.Addgradetypebutton.Size = New System.Drawing.Size(75, 23)
        Me.Addgradetypebutton.TabIndex = 86
        Me.Addgradetypebutton.Text = "Add"
        Me.Addgradetypebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addgradetypebutton.UseVisualStyleBackColor = True
        '
        'Newgradetypelabel
        '
        Me.Newgradetypelabel.AutoSize = True
        Me.Newgradetypelabel.Location = New System.Drawing.Point(6, 51)
        Me.Newgradetypelabel.Name = "Newgradetypelabel"
        Me.Newgradetypelabel.Size = New System.Drawing.Size(91, 13)
        Me.Newgradetypelabel.TabIndex = 87
        Me.Newgradetypelabel.Text = "New Grade Type:"
        '
        'Newgradetypefield
        '
        Me.Newgradetypefield.Location = New System.Drawing.Point(99, 48)
        Me.Newgradetypefield.Name = "Newgradetypefield"
        Me.Newgradetypefield.Size = New System.Drawing.Size(100, 20)
        Me.Newgradetypefield.TabIndex = 5
        '
        'Dataset
        '
        Me.Dataset.BackColor = System.Drawing.Color.Transparent
        Me.Dataset.Controls.Add(Me.Viewcurrentdatasetyear)
        Me.Dataset.Controls.Add(Me.Adddatasetyear)
        Me.Dataset.Controls.Add(Me.Newdatasetyearlabel)
        Me.Dataset.Controls.Add(Me.Datasetyearfield)
        Me.Dataset.ForeColor = System.Drawing.Color.Maroon
        Me.Dataset.Location = New System.Drawing.Point(57, 161)
        Me.Dataset.Name = "Dataset"
        Me.Dataset.Size = New System.Drawing.Size(205, 143)
        Me.Dataset.TabIndex = 92
        Me.Dataset.TabStop = False
        Me.Dataset.Text = "Add a new Dataset Year"
        Me.Dataset.Visible = False
        '
        'Viewcurrentdatasetyear
        '
        Me.Viewcurrentdatasetyear.BackgroundImage = CType(resources.GetObject("Viewcurrentdatasetyear.BackgroundImage"), System.Drawing.Image)
        Me.Viewcurrentdatasetyear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewcurrentdatasetyear.FlatAppearance.BorderSize = 0
        Me.Viewcurrentdatasetyear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentdatasetyear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentdatasetyear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Viewcurrentdatasetyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Viewcurrentdatasetyear.ForeColor = System.Drawing.Color.White
        Me.Viewcurrentdatasetyear.Location = New System.Drawing.Point(24, 109)
        Me.Viewcurrentdatasetyear.Name = "Viewcurrentdatasetyear"
        Me.Viewcurrentdatasetyear.Size = New System.Drawing.Size(158, 23)
        Me.Viewcurrentdatasetyear.TabIndex = 95
        Me.Viewcurrentdatasetyear.Text = "View Current Dataset Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Viewcurrentdatasetyear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Viewcurrentdatasetyear.UseVisualStyleBackColor = True
        '
        'Adddatasetyear
        '
        Me.Adddatasetyear.BackgroundImage = CType(resources.GetObject("Adddatasetyear.BackgroundImage"), System.Drawing.Image)
        Me.Adddatasetyear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Adddatasetyear.FlatAppearance.BorderSize = 0
        Me.Adddatasetyear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Adddatasetyear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Adddatasetyear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Adddatasetyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adddatasetyear.ForeColor = System.Drawing.Color.White
        Me.Adddatasetyear.Location = New System.Drawing.Point(57, 74)
        Me.Adddatasetyear.Name = "Adddatasetyear"
        Me.Adddatasetyear.Size = New System.Drawing.Size(75, 23)
        Me.Adddatasetyear.TabIndex = 86
        Me.Adddatasetyear.Text = "Add"
        Me.Adddatasetyear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Adddatasetyear.UseVisualStyleBackColor = True
        '
        'Newdatasetyearlabel
        '
        Me.Newdatasetyearlabel.AutoSize = True
        Me.Newdatasetyearlabel.Location = New System.Drawing.Point(6, 51)
        Me.Newdatasetyearlabel.Name = "Newdatasetyearlabel"
        Me.Newdatasetyearlabel.Size = New System.Drawing.Size(97, 13)
        Me.Newdatasetyearlabel.TabIndex = 87
        Me.Newdatasetyearlabel.Text = "New Dataset Year:"
        '
        'Datasetyearfield
        '
        Me.Datasetyearfield.Location = New System.Drawing.Point(105, 46)
        Me.Datasetyearfield.Name = "Datasetyearfield"
        Me.Datasetyearfield.Size = New System.Drawing.Size(89, 20)
        Me.Datasetyearfield.TabIndex = 4
        '
        'Viewcurrentvalues
        '
        Me.Viewcurrentvalues.AllowUserToAddRows = False
        Me.Viewcurrentvalues.AllowUserToDeleteRows = False
        Me.Viewcurrentvalues.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Viewcurrentvalues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Viewcurrentvalues.Location = New System.Drawing.Point(332, 58)
        Me.Viewcurrentvalues.Name = "Viewcurrentvalues"
        Me.Viewcurrentvalues.ReadOnly = True
        Me.Viewcurrentvalues.RowHeadersVisible = False
        Me.Viewcurrentvalues.Size = New System.Drawing.Size(427, 453)
        Me.Viewcurrentvalues.TabIndex = 94
        '
        'Admingroup
        '
        Me.Admingroup.BackColor = System.Drawing.Color.Transparent
        Me.Admingroup.Controls.Add(Me.Adminaction)
        Me.Admingroup.Controls.Add(Me.adminactionlabel)
        Me.Admingroup.ForeColor = System.Drawing.Color.Maroon
        Me.Admingroup.Location = New System.Drawing.Point(12, 70)
        Me.Admingroup.Name = "Admingroup"
        Me.Admingroup.Size = New System.Drawing.Size(314, 68)
        Me.Admingroup.TabIndex = 95
        Me.Admingroup.TabStop = False
        Me.Admingroup.Text = "Admin Functions"
        '
        'Adminaction
        '
        Me.Adminaction.FormattingEnabled = True
        Me.Adminaction.Items.AddRange(New Object() {"", "Add a new Dataset Year", "Add a new Grade Type", "Add a new Subject", "Add a new Level", "Add a new login", "Edit an existing login"})
        Me.Adminaction.Location = New System.Drawing.Point(147, 28)
        Me.Adminaction.Name = "Adminaction"
        Me.Adminaction.Size = New System.Drawing.Size(144, 21)
        Me.Adminaction.TabIndex = 97
        '
        'adminactionlabel
        '
        Me.adminactionlabel.AutoSize = True
        Me.adminactionlabel.Location = New System.Drawing.Point(15, 31)
        Me.adminactionlabel.Name = "adminactionlabel"
        Me.adminactionlabel.Size = New System.Drawing.Size(126, 13)
        Me.adminactionlabel.TabIndex = 96
        Me.adminactionlabel.Text = "Choose an Admin Action:"
        '
        'edittitle
        '
        Me.edittitle.AutoSize = True
        Me.edittitle.BackColor = System.Drawing.Color.Transparent
        Me.edittitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edittitle.ForeColor = System.Drawing.Color.Maroon
        Me.edittitle.Location = New System.Drawing.Point(12, 38)
        Me.edittitle.Name = "edittitle"
        Me.edittitle.Size = New System.Drawing.Size(144, 24)
        Me.edittitle.TabIndex = 96
        Me.edittitle.Text = "Admin Features"
        '
        'Addlogingroup
        '
        Me.Addlogingroup.BackColor = System.Drawing.Color.Transparent
        Me.Addlogingroup.Controls.Add(Me.adminfield)
        Me.Addlogingroup.Controls.Add(Me.passwordlabel)
        Me.Addlogingroup.Controls.Add(Me.passwordfield)
        Me.Addlogingroup.Controls.Add(Me.adminlabel)
        Me.Addlogingroup.Controls.Add(Me.viewlogins)
        Me.Addlogingroup.Controls.Add(Me.adduser)
        Me.Addlogingroup.Controls.Add(Me.usernamelabel)
        Me.Addlogingroup.Controls.Add(Me.usernamefield)
        Me.Addlogingroup.ForeColor = System.Drawing.Color.Maroon
        Me.Addlogingroup.Location = New System.Drawing.Point(57, 161)
        Me.Addlogingroup.Name = "Addlogingroup"
        Me.Addlogingroup.Size = New System.Drawing.Size(205, 210)
        Me.Addlogingroup.TabIndex = 96
        Me.Addlogingroup.TabStop = False
        Me.Addlogingroup.Text = "Add a new Login"
        Me.Addlogingroup.Visible = False
        '
        'adminfield
        '
        Me.adminfield.FormattingEnabled = True
        Me.adminfield.Items.AddRange(New Object() {"1", "0"})
        Me.adminfield.Location = New System.Drawing.Point(108, 103)
        Me.adminfield.Name = "adminfield"
        Me.adminfield.Size = New System.Drawing.Size(90, 21)
        Me.adminfield.TabIndex = 100
        '
        'passwordlabel
        '
        Me.passwordlabel.AutoSize = True
        Me.passwordlabel.Location = New System.Drawing.Point(7, 80)
        Me.passwordlabel.Name = "passwordlabel"
        Me.passwordlabel.Size = New System.Drawing.Size(81, 13)
        Me.passwordlabel.TabIndex = 99
        Me.passwordlabel.Text = "New Password:"
        '
        'passwordfield
        '
        Me.passwordfield.Location = New System.Drawing.Point(108, 76)
        Me.passwordfield.Name = "passwordfield"
        Me.passwordfield.Size = New System.Drawing.Size(89, 20)
        Me.passwordfield.TabIndex = 98
        '
        'adminlabel
        '
        Me.adminlabel.AutoSize = True
        Me.adminlabel.Location = New System.Drawing.Point(7, 107)
        Me.adminlabel.Name = "adminlabel"
        Me.adminlabel.Size = New System.Drawing.Size(97, 13)
        Me.adminlabel.TabIndex = 97
        Me.adminlabel.Text = "Admin Permissions:"
        '
        'viewlogins
        '
        Me.viewlogins.BackgroundImage = CType(resources.GetObject("viewlogins.BackgroundImage"), System.Drawing.Image)
        Me.viewlogins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewlogins.FlatAppearance.BorderSize = 0
        Me.viewlogins.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.viewlogins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.viewlogins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.viewlogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewlogins.ForeColor = System.Drawing.Color.White
        Me.viewlogins.Location = New System.Drawing.Point(30, 165)
        Me.viewlogins.Name = "viewlogins"
        Me.viewlogins.Size = New System.Drawing.Size(148, 23)
        Me.viewlogins.TabIndex = 95
        Me.viewlogins.Text = "View Current Logins"
        Me.viewlogins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.viewlogins.UseVisualStyleBackColor = True
        '
        'adduser
        '
        Me.adduser.BackgroundImage = CType(resources.GetObject("adduser.BackgroundImage"), System.Drawing.Image)
        Me.adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adduser.FlatAppearance.BorderSize = 0
        Me.adduser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.adduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.adduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adduser.ForeColor = System.Drawing.Color.White
        Me.adduser.Location = New System.Drawing.Point(60, 134)
        Me.adduser.Name = "adduser"
        Me.adduser.Size = New System.Drawing.Size(75, 23)
        Me.adduser.TabIndex = 86
        Me.adduser.Text = "Add"
        Me.adduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.adduser.UseVisualStyleBackColor = True
        '
        'usernamelabel
        '
        Me.usernamelabel.AutoSize = True
        Me.usernamelabel.Location = New System.Drawing.Point(7, 51)
        Me.usernamelabel.Name = "usernamelabel"
        Me.usernamelabel.Size = New System.Drawing.Size(83, 13)
        Me.usernamelabel.TabIndex = 87
        Me.usernamelabel.Text = "New Username:"
        '
        'usernamefield
        '
        Me.usernamefield.Location = New System.Drawing.Point(108, 47)
        Me.usernamefield.Name = "usernamefield"
        Me.usernamefield.Size = New System.Drawing.Size(89, 20)
        Me.usernamefield.TabIndex = 4
        '
        'Editlogingroup
        '
        Me.Editlogingroup.BackColor = System.Drawing.Color.Transparent
        Me.Editlogingroup.Controls.Add(Me.loginidlabel)
        Me.Editlogingroup.Controls.Add(Me.loginidfield)
        Me.Editlogingroup.Controls.Add(Me.adminfield1)
        Me.Editlogingroup.Controls.Add(Me.passwordlabel1)
        Me.Editlogingroup.Controls.Add(Me.passwordfield1)
        Me.Editlogingroup.Controls.Add(Me.adminlabel1)
        Me.Editlogingroup.Controls.Add(Me.vieweditlogins)
        Me.Editlogingroup.Controls.Add(Me.editlogin)
        Me.Editlogingroup.Controls.Add(Me.usernamelabel1)
        Me.Editlogingroup.Controls.Add(Me.usernamefield1)
        Me.Editlogingroup.ForeColor = System.Drawing.Color.Maroon
        Me.Editlogingroup.Location = New System.Drawing.Point(57, 158)
        Me.Editlogingroup.Name = "Editlogingroup"
        Me.Editlogingroup.Size = New System.Drawing.Size(205, 221)
        Me.Editlogingroup.TabIndex = 97
        Me.Editlogingroup.TabStop = False
        Me.Editlogingroup.Text = "Edit an Exisiting Login"
        Me.Editlogingroup.Visible = False
        '
        'loginidlabel
        '
        Me.loginidlabel.AutoSize = True
        Me.loginidlabel.Location = New System.Drawing.Point(8, 31)
        Me.loginidlabel.Name = "loginidlabel"
        Me.loginidlabel.Size = New System.Drawing.Size(50, 13)
        Me.loginidlabel.TabIndex = 102
        Me.loginidlabel.Text = "Login ID:"
        '
        'loginidfield
        '
        Me.loginidfield.Enabled = False
        Me.loginidfield.Location = New System.Drawing.Point(109, 27)
        Me.loginidfield.Name = "loginidfield"
        Me.loginidfield.Size = New System.Drawing.Size(89, 20)
        Me.loginidfield.TabIndex = 101
        '
        'adminfield1
        '
        Me.adminfield1.FormattingEnabled = True
        Me.adminfield1.Items.AddRange(New Object() {"1", "0"})
        Me.adminfield1.Location = New System.Drawing.Point(108, 115)
        Me.adminfield1.Name = "adminfield1"
        Me.adminfield1.Size = New System.Drawing.Size(90, 21)
        Me.adminfield1.TabIndex = 100
        '
        'passwordlabel1
        '
        Me.passwordlabel1.AutoSize = True
        Me.passwordlabel1.Location = New System.Drawing.Point(7, 92)
        Me.passwordlabel1.Name = "passwordlabel1"
        Me.passwordlabel1.Size = New System.Drawing.Size(56, 13)
        Me.passwordlabel1.TabIndex = 99
        Me.passwordlabel1.Text = "Password:"
        '
        'passwordfield1
        '
        Me.passwordfield1.Location = New System.Drawing.Point(108, 88)
        Me.passwordfield1.Name = "passwordfield1"
        Me.passwordfield1.Size = New System.Drawing.Size(89, 20)
        Me.passwordfield1.TabIndex = 98
        '
        'adminlabel1
        '
        Me.adminlabel1.AutoSize = True
        Me.adminlabel1.Location = New System.Drawing.Point(7, 119)
        Me.adminlabel1.Name = "adminlabel1"
        Me.adminlabel1.Size = New System.Drawing.Size(97, 13)
        Me.adminlabel1.TabIndex = 97
        Me.adminlabel1.Text = "Admin Permissions:"
        '
        'vieweditlogins
        '
        Me.vieweditlogins.BackgroundImage = CType(resources.GetObject("vieweditlogins.BackgroundImage"), System.Drawing.Image)
        Me.vieweditlogins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vieweditlogins.FlatAppearance.BorderSize = 0
        Me.vieweditlogins.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.vieweditlogins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.vieweditlogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vieweditlogins.ForeColor = System.Drawing.Color.White
        Me.vieweditlogins.Location = New System.Drawing.Point(32, 180)
        Me.vieweditlogins.Name = "vieweditlogins"
        Me.vieweditlogins.Size = New System.Drawing.Size(148, 23)
        Me.vieweditlogins.TabIndex = 95
        Me.vieweditlogins.Text = "View Current Logins"
        Me.vieweditlogins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.vieweditlogins.UseVisualStyleBackColor = True
        '
        'editlogin
        '
        Me.editlogin.BackgroundImage = CType(resources.GetObject("editlogin.BackgroundImage"), System.Drawing.Image)
        Me.editlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editlogin.FlatAppearance.BorderSize = 0
        Me.editlogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.editlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editlogin.ForeColor = System.Drawing.Color.White
        Me.editlogin.Location = New System.Drawing.Point(62, 149)
        Me.editlogin.Name = "editlogin"
        Me.editlogin.Size = New System.Drawing.Size(75, 23)
        Me.editlogin.TabIndex = 86
        Me.editlogin.Text = "Edit"
        Me.editlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.editlogin.UseVisualStyleBackColor = True
        '
        'usernamelabel1
        '
        Me.usernamelabel1.AutoSize = True
        Me.usernamelabel1.Location = New System.Drawing.Point(7, 63)
        Me.usernamelabel1.Name = "usernamelabel1"
        Me.usernamelabel1.Size = New System.Drawing.Size(58, 13)
        Me.usernamelabel1.TabIndex = 87
        Me.usernamelabel1.Text = "Username:"
        '
        'usernamefield1
        '
        Me.usernamefield1.Location = New System.Drawing.Point(108, 59)
        Me.usernamefield1.Name = "usernamefield1"
        Me.usernamefield1.Size = New System.Drawing.Size(89, 20)
        Me.usernamefield1.TabIndex = 4
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
        Me.printbutton.Location = New System.Drawing.Point(730, 3)
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
        'Developer_Features
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(766, 523)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.edittitle)
        Me.Controls.Add(Me.Admingroup)
        Me.Controls.Add(Me.Viewcurrentvalues)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.Developer)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Subjectgroup)
        Me.Controls.Add(Me.Gradetypegroup)
        Me.Controls.Add(Me.Editlogingroup)
        Me.Controls.Add(Me.Dataset)
        Me.Controls.Add(Me.Addlogingroup)
        Me.Controls.Add(Me.Levelgroup)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(782, 561)
        Me.MinimumSize = New System.Drawing.Size(782, 561)
        Me.Name = "Developer_Features"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Features"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Subjectgroup.ResumeLayout(False)
        Me.Subjectgroup.PerformLayout()
        Me.Levelgroup.ResumeLayout(False)
        Me.Levelgroup.PerformLayout()
        Me.Gradetypegroup.ResumeLayout(False)
        Me.Gradetypegroup.PerformLayout()
        Me.Dataset.ResumeLayout(False)
        Me.Dataset.PerformLayout()
        CType(Me.Viewcurrentvalues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Admingroup.ResumeLayout(False)
        Me.Admingroup.PerformLayout()
        Me.Addlogingroup.ResumeLayout(False)
        Me.Addlogingroup.PerformLayout()
        Me.Editlogingroup.ResumeLayout(False)
        Me.Editlogingroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents Developer As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Subjectgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Newsubjectlabel As System.Windows.Forms.Label
    Friend WithEvents Newsubjectfield As System.Windows.Forms.TextBox
    Friend WithEvents Departmentlabel As System.Windows.Forms.Label
    Friend WithEvents Departmentfield As System.Windows.Forms.ComboBox
    Friend WithEvents Addsubjectbutton As System.Windows.Forms.Button
    Friend WithEvents Levelgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Addlevelbutton As System.Windows.Forms.Button
    Friend WithEvents Newlevellabel As System.Windows.Forms.Label
    Friend WithEvents Levelfield As System.Windows.Forms.TextBox
    Friend WithEvents Gradetypegroup As System.Windows.Forms.GroupBox
    Friend WithEvents Addgradetypebutton As System.Windows.Forms.Button
    Friend WithEvents Newgradetypelabel As System.Windows.Forms.Label
    Friend WithEvents Newgradetypefield As System.Windows.Forms.TextBox
    Friend WithEvents Dataset As System.Windows.Forms.GroupBox
    Friend WithEvents Adddatasetyear As System.Windows.Forms.Button
    Friend WithEvents Newdatasetyearlabel As System.Windows.Forms.Label
    Friend WithEvents Datasetyearfield As System.Windows.Forms.TextBox
    Friend WithEvents Viewcurrentsubjects As System.Windows.Forms.Button
    Friend WithEvents Viewcurrentlevel As System.Windows.Forms.Button
    Friend WithEvents Viewcurrentgradetype As System.Windows.Forms.Button
    Friend WithEvents Viewcurrentdatasetyear As System.Windows.Forms.Button
    Friend WithEvents Viewcurrentvalues As System.Windows.Forms.DataGridView
    Friend WithEvents Admingroup As System.Windows.Forms.GroupBox
    Friend WithEvents Adminaction As System.Windows.Forms.ComboBox
    Friend WithEvents adminactionlabel As System.Windows.Forms.Label
    Friend WithEvents edittitle As System.Windows.Forms.Label
    Friend WithEvents Addlogingroup As System.Windows.Forms.GroupBox
    Friend WithEvents passwordlabel As System.Windows.Forms.Label
    Friend WithEvents passwordfield As System.Windows.Forms.TextBox
    Friend WithEvents adminlabel As System.Windows.Forms.Label
    Friend WithEvents viewlogins As System.Windows.Forms.Button
    Friend WithEvents adduser As System.Windows.Forms.Button
    Friend WithEvents usernamelabel As System.Windows.Forms.Label
    Friend WithEvents usernamefield As System.Windows.Forms.TextBox
    Friend WithEvents adminfield As System.Windows.Forms.ComboBox
    Friend WithEvents Editlogingroup As System.Windows.Forms.GroupBox
    Friend WithEvents adminfield1 As System.Windows.Forms.ComboBox
    Friend WithEvents passwordlabel1 As System.Windows.Forms.Label
    Friend WithEvents passwordfield1 As System.Windows.Forms.TextBox
    Friend WithEvents adminlabel1 As System.Windows.Forms.Label
    Friend WithEvents vieweditlogins As System.Windows.Forms.Button
    Friend WithEvents editlogin As System.Windows.Forms.Button
    Friend WithEvents usernamelabel1 As System.Windows.Forms.Label
    Friend WithEvents usernamefield1 As System.Windows.Forms.TextBox
    Friend WithEvents loginidlabel As System.Windows.Forms.Label
    Friend WithEvents loginidfield As System.Windows.Forms.TextBox
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
End Class
