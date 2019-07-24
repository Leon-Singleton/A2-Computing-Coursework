<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grade))
        Me.Subjectgrid = New System.Windows.Forms.DataGridView()
        Me.Gradegrid = New System.Windows.Forms.DataGridView()
        Me.Subjectfield = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Subjectlabel = New System.Windows.Forms.Label()
        Me.Gradelink = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Gradelabel = New System.Windows.Forms.Label()
        Me.Gradefield = New System.Windows.Forms.ComboBox()
        Me.Levellabel = New System.Windows.Forms.Label()
        Me.Levelfield = New System.Windows.Forms.ComboBox()
        Me.Firtnamelabel = New System.Windows.Forms.Label()
        Me.Firstnamefield = New System.Windows.Forms.TextBox()
        Me.SurnameField = New System.Windows.Forms.TextBox()
        Me.Surnamelabel = New System.Windows.Forms.Label()
        Me.Clearselection = New System.Windows.Forms.Button()
        Me.viewstudentgroup = New System.Windows.Forms.GroupBox()
        Me.Addbutton = New System.Windows.Forms.Button()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        CType(Me.Subjectgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gradegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewstudentgroup.SuspendLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Subjectgrid
        '
        Me.Subjectgrid.AllowUserToAddRows = False
        Me.Subjectgrid.AllowUserToDeleteRows = False
        Me.Subjectgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Subjectgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Subjectgrid.Location = New System.Drawing.Point(217, 64)
        Me.Subjectgrid.Name = "Subjectgrid"
        Me.Subjectgrid.ReadOnly = True
        Me.Subjectgrid.RowHeadersVisible = False
        Me.Subjectgrid.Size = New System.Drawing.Size(713, 346)
        Me.Subjectgrid.TabIndex = 0
        Me.Subjectgrid.Visible = False
        '
        'Gradegrid
        '
        Me.Gradegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gradegrid.Location = New System.Drawing.Point(3, 137)
        Me.Gradegrid.Name = "Gradegrid"
        Me.Gradegrid.Size = New System.Drawing.Size(735, 299)
        Me.Gradegrid.TabIndex = 0
        '
        'Subjectfield
        '
        Me.Subjectfield.FormattingEnabled = True
        Me.Subjectfield.Location = New System.Drawing.Point(66, 93)
        Me.Subjectfield.Name = "Subjectfield"
        Me.Subjectfield.Size = New System.Drawing.Size(121, 21)
        Me.Subjectfield.TabIndex = 3
        '
        'Search
        '
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search.FlatAppearance.BorderSize = 0
        Me.Search.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.Location = New System.Drawing.Point(66, 189)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(100, 26)
        Me.Search.TabIndex = 2
        Me.Search.Text = "Search"
        Me.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Search.UseVisualStyleBackColor = True
        '
        'Subjectlabel
        '
        Me.Subjectlabel.AutoSize = True
        Me.Subjectlabel.BackColor = System.Drawing.Color.Transparent
        Me.Subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.Subjectlabel.Location = New System.Drawing.Point(10, 98)
        Me.Subjectlabel.Name = "Subjectlabel"
        Me.Subjectlabel.Size = New System.Drawing.Size(46, 13)
        Me.Subjectlabel.TabIndex = 3
        Me.Subjectlabel.Text = "Subject:"
        '
        'Gradelink
        '
        Me.Gradelink.AutoSize = True
        Me.Gradelink.BackColor = System.Drawing.Color.White
        Me.Gradelink.Enabled = False
        Me.Gradelink.LinkColor = System.Drawing.Color.Gray
        Me.Gradelink.Location = New System.Drawing.Point(96, 13)
        Me.Gradelink.Name = "Gradelink"
        Me.Gradelink.Size = New System.Drawing.Size(36, 13)
        Me.Gradelink.TabIndex = 43
        Me.Gradelink.TabStop = True
        Me.Gradelink.Text = "Grade"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(14, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 42
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Gradelabel
        '
        Me.Gradelabel.AutoSize = True
        Me.Gradelabel.BackColor = System.Drawing.Color.Transparent
        Me.Gradelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Gradelabel.Location = New System.Drawing.Point(10, 129)
        Me.Gradelabel.Name = "Gradelabel"
        Me.Gradelabel.Size = New System.Drawing.Size(39, 13)
        Me.Gradelabel.TabIndex = 45
        Me.Gradelabel.Text = "Grade:"
        '
        'Gradefield
        '
        Me.Gradefield.FormattingEnabled = True
        Me.Gradefield.Location = New System.Drawing.Point(66, 124)
        Me.Gradefield.Name = "Gradefield"
        Me.Gradefield.Size = New System.Drawing.Size(121, 21)
        Me.Gradefield.TabIndex = 4
        '
        'Levellabel
        '
        Me.Levellabel.AutoSize = True
        Me.Levellabel.BackColor = System.Drawing.Color.Transparent
        Me.Levellabel.ForeColor = System.Drawing.Color.Maroon
        Me.Levellabel.Location = New System.Drawing.Point(10, 160)
        Me.Levellabel.Name = "Levellabel"
        Me.Levellabel.Size = New System.Drawing.Size(36, 13)
        Me.Levellabel.TabIndex = 47
        Me.Levellabel.Text = "Level:"
        '
        'Levelfield
        '
        Me.Levelfield.FormattingEnabled = True
        Me.Levelfield.Location = New System.Drawing.Point(66, 155)
        Me.Levelfield.Name = "Levelfield"
        Me.Levelfield.Size = New System.Drawing.Size(121, 21)
        Me.Levelfield.TabIndex = 5
        '
        'Firtnamelabel
        '
        Me.Firtnamelabel.AutoSize = True
        Me.Firtnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Firtnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Firtnamelabel.Location = New System.Drawing.Point(10, 36)
        Me.Firtnamelabel.Name = "Firtnamelabel"
        Me.Firtnamelabel.Size = New System.Drawing.Size(55, 13)
        Me.Firtnamelabel.TabIndex = 50
        Me.Firtnamelabel.Text = "Firstname:"
        '
        'Firstnamefield
        '
        Me.Firstnamefield.Location = New System.Drawing.Point(66, 33)
        Me.Firstnamefield.Name = "Firstnamefield"
        Me.Firstnamefield.Size = New System.Drawing.Size(121, 20)
        Me.Firstnamefield.TabIndex = 1
        '
        'SurnameField
        '
        Me.SurnameField.Location = New System.Drawing.Point(66, 63)
        Me.SurnameField.Name = "SurnameField"
        Me.SurnameField.Size = New System.Drawing.Size(121, 20)
        Me.SurnameField.TabIndex = 2
        '
        'Surnamelabel
        '
        Me.Surnamelabel.AutoSize = True
        Me.Surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.Surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.Surnamelabel.Location = New System.Drawing.Point(10, 67)
        Me.Surnamelabel.Name = "Surnamelabel"
        Me.Surnamelabel.Size = New System.Drawing.Size(52, 13)
        Me.Surnamelabel.TabIndex = 52
        Me.Surnamelabel.Text = "Surname:"
        '
        'Clearselection
        '
        Me.Clearselection.BackgroundImage = CType(resources.GetObject("Clearselection.BackgroundImage"), System.Drawing.Image)
        Me.Clearselection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Clearselection.FlatAppearance.BorderSize = 0
        Me.Clearselection.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Clearselection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearselection.ForeColor = System.Drawing.Color.White
        Me.Clearselection.Location = New System.Drawing.Point(66, 223)
        Me.Clearselection.Name = "Clearselection"
        Me.Clearselection.Size = New System.Drawing.Size(100, 26)
        Me.Clearselection.TabIndex = 54
        Me.Clearselection.Text = "ClearSelection"
        Me.Clearselection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Clearselection.UseVisualStyleBackColor = True
        '
        'viewstudentgroup
        '
        Me.viewstudentgroup.BackColor = System.Drawing.Color.Transparent
        Me.viewstudentgroup.Controls.Add(Me.Search)
        Me.viewstudentgroup.Controls.Add(Me.Addbutton)
        Me.viewstudentgroup.Controls.Add(Me.Clearselection)
        Me.viewstudentgroup.Controls.Add(Me.Subjectfield)
        Me.viewstudentgroup.Controls.Add(Me.SurnameField)
        Me.viewstudentgroup.Controls.Add(Me.Subjectlabel)
        Me.viewstudentgroup.Controls.Add(Me.Surnamelabel)
        Me.viewstudentgroup.Controls.Add(Me.Gradefield)
        Me.viewstudentgroup.Controls.Add(Me.Firstnamefield)
        Me.viewstudentgroup.Controls.Add(Me.Gradelabel)
        Me.viewstudentgroup.Controls.Add(Me.Firtnamelabel)
        Me.viewstudentgroup.Controls.Add(Me.Levelfield)
        Me.viewstudentgroup.Controls.Add(Me.Levellabel)
        Me.viewstudentgroup.ForeColor = System.Drawing.Color.Maroon
        Me.viewstudentgroup.Location = New System.Drawing.Point(6, 64)
        Me.viewstudentgroup.Name = "viewstudentgroup"
        Me.viewstudentgroup.Size = New System.Drawing.Size(205, 342)
        Me.viewstudentgroup.TabIndex = 55
        Me.viewstudentgroup.TabStop = False
        Me.viewstudentgroup.Text = "View/Edit a students grade"
        '
        'Addbutton
        '
        Me.Addbutton.BackColor = System.Drawing.Color.Transparent
        Me.Addbutton.BackgroundImage = CType(resources.GetObject("Addbutton.BackgroundImage"), System.Drawing.Image)
        Me.Addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addbutton.FlatAppearance.BorderSize = 0
        Me.Addbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbutton.ForeColor = System.Drawing.Color.White
        Me.Addbutton.Location = New System.Drawing.Point(66, 262)
        Me.Addbutton.Name = "Addbutton"
        Me.Addbutton.Size = New System.Drawing.Size(100, 69)
        Me.Addbutton.TabIndex = 56
        Me.Addbutton.Text = "Add a Grade or view a Student's Grades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Addbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Addbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addbutton.UseVisualStyleBackColor = False
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(71, 10)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 69
        Me.linkarrow.Text = "4"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(6, 4)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(887, 31)
        Me.banner.TabIndex = 70
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
        Me.Formheader.Size = New System.Drawing.Size(59, 20)
        Me.Formheader.TabIndex = 83
        Me.Formheader.Text = "Grade"
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
        Me.printbutton.Location = New System.Drawing.Point(899, 4)
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
        'Grade
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(936, 413)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.viewstudentgroup)
        Me.Controls.Add(Me.Gradelink)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Subjectgrid)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(952, 451)
        Me.MinimumSize = New System.Drawing.Size(952, 451)
        Me.Name = "Grade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade"
        CType(Me.Subjectgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gradegrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewstudentgroup.ResumeLayout(False)
        Me.viewstudentgroup.PerformLayout()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Subjectgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Gradegrid As System.Windows.Forms.DataGridView
    Friend WithEvents Subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Subjectlabel As System.Windows.Forms.Label
    Friend WithEvents Gradelink As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Gradelabel As System.Windows.Forms.Label
    Friend WithEvents Gradefield As System.Windows.Forms.ComboBox
    Friend WithEvents Levellabel As System.Windows.Forms.Label
    Friend WithEvents Levelfield As System.Windows.Forms.ComboBox
    Friend WithEvents Firtnamelabel As System.Windows.Forms.Label
    Friend WithEvents Firstnamefield As System.Windows.Forms.TextBox
    Friend WithEvents SurnameField As System.Windows.Forms.TextBox
    Friend WithEvents Surnamelabel As System.Windows.Forms.Label
    Friend WithEvents Clearselection As System.Windows.Forms.Button
    Friend WithEvents viewstudentgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Addbutton As System.Windows.Forms.Button
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
End Class
