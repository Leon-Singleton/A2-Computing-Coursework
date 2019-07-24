<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherView))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.TeacherGroup = New System.Windows.Forms.GroupBox()
        Me.TeacherAdd = New System.Windows.Forms.Button()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.DisplayTeacher = New System.Windows.Forms.Button()
        Me.wherelabel = New System.Windows.Forms.Label()
        Me.Fieldlabel = New System.Windows.Forms.Label()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.TeacherGrid = New System.Windows.Forms.DataGridView()
        Me.Student = New System.Windows.Forms.LinkLabel()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Linkarrow = New System.Windows.Forms.Label()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TeacherGroup.SuspendLayout()
        CType(Me.TeacherGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(1, 41)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(197, 20)
        Me.Formheader.TabIndex = 5
        Me.Formheader.Text = "Search Teacher Details"
        '
        'TeacherGroup
        '
        Me.TeacherGroup.BackColor = System.Drawing.Color.Transparent
        Me.TeacherGroup.Controls.Add(Me.TeacherAdd)
        Me.TeacherGroup.Controls.Add(Me.SearchName)
        Me.TeacherGroup.Controls.Add(Me.DisplayTeacher)
        Me.TeacherGroup.Controls.Add(Me.wherelabel)
        Me.TeacherGroup.Controls.Add(Me.Fieldlabel)
        Me.TeacherGroup.Controls.Add(Me.Field)
        Me.TeacherGroup.ForeColor = System.Drawing.Color.Maroon
        Me.TeacherGroup.Location = New System.Drawing.Point(5, 66)
        Me.TeacherGroup.Name = "TeacherGroup"
        Me.TeacherGroup.Size = New System.Drawing.Size(173, 225)
        Me.TeacherGroup.TabIndex = 6
        Me.TeacherGroup.TabStop = False
        Me.TeacherGroup.Text = "Search Teacher"
        '
        'TeacherAdd
        '
        Me.TeacherAdd.BackColor = System.Drawing.Color.Transparent
        Me.TeacherAdd.BackgroundImage = CType(resources.GetObject("TeacherAdd.BackgroundImage"), System.Drawing.Image)
        Me.TeacherAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TeacherAdd.FlatAppearance.BorderSize = 0
        Me.TeacherAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.TeacherAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TeacherAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TeacherAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeacherAdd.ForeColor = System.Drawing.Color.White
        Me.TeacherAdd.Location = New System.Drawing.Point(22, 172)
        Me.TeacherAdd.Name = "TeacherAdd"
        Me.TeacherAdd.Size = New System.Drawing.Size(103, 37)
        Me.TeacherAdd.TabIndex = 70
        Me.TeacherAdd.Text = "Add Teacher"
        Me.TeacherAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.TeacherAdd.UseVisualStyleBackColor = False
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(60, 68)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(99, 20)
        Me.SearchName.TabIndex = 2
        Me.SearchName.Visible = False
        '
        'DisplayTeacher
        '
        Me.DisplayTeacher.BackgroundImage = CType(resources.GetObject("DisplayTeacher.BackgroundImage"), System.Drawing.Image)
        Me.DisplayTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DisplayTeacher.FlatAppearance.BorderSize = 0
        Me.DisplayTeacher.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.DisplayTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DisplayTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DisplayTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayTeacher.ForeColor = System.Drawing.Color.White
        Me.DisplayTeacher.Location = New System.Drawing.Point(30, 108)
        Me.DisplayTeacher.Name = "DisplayTeacher"
        Me.DisplayTeacher.Size = New System.Drawing.Size(87, 27)
        Me.DisplayTeacher.TabIndex = 7
        Me.DisplayTeacher.Text = "Search"
        Me.DisplayTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DisplayTeacher.UseVisualStyleBackColor = True
        Me.DisplayTeacher.Visible = False
        '
        'wherelabel
        '
        Me.wherelabel.AutoSize = True
        Me.wherelabel.Location = New System.Drawing.Point(12, 73)
        Me.wherelabel.Name = "wherelabel"
        Me.wherelabel.Size = New System.Drawing.Size(38, 13)
        Me.wherelabel.TabIndex = 2
        Me.wherelabel.Text = "Name:"
        Me.wherelabel.Visible = False
        '
        'Fieldlabel
        '
        Me.Fieldlabel.AutoSize = True
        Me.Fieldlabel.Location = New System.Drawing.Point(9, 35)
        Me.Fieldlabel.Name = "Fieldlabel"
        Me.Fieldlabel.Size = New System.Drawing.Size(49, 13)
        Me.Fieldlabel.TabIndex = 1
        Me.Fieldlabel.Text = "Attribute:"
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"Name"})
        Me.Field.Location = New System.Drawing.Point(60, 30)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(99, 21)
        Me.Field.TabIndex = 1
        '
        'TeacherGrid
        '
        Me.TeacherGrid.AllowUserToAddRows = False
        Me.TeacherGrid.AllowUserToDeleteRows = False
        Me.TeacherGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TeacherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherGrid.Location = New System.Drawing.Point(186, 66)
        Me.TeacherGrid.Name = "TeacherGrid"
        Me.TeacherGrid.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TeacherGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TeacherGrid.RowHeadersVisible = False
        Me.TeacherGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TeacherGrid.Size = New System.Drawing.Size(356, 369)
        Me.TeacherGrid.TabIndex = 3
        Me.TeacherGrid.Visible = False
        '
        'Student
        '
        Me.Student.AutoSize = True
        Me.Student.BackColor = System.Drawing.Color.White
        Me.Student.Enabled = False
        Me.Student.LinkColor = System.Drawing.Color.Gray
        Me.Student.Location = New System.Drawing.Point(90, 15)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(47, 13)
        Me.Student.TabIndex = 43
        Me.Student.TabStop = True
        Me.Student.Text = "Teacher"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(12, 15)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 42
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Linkarrow
        '
        Me.Linkarrow.AutoSize = True
        Me.Linkarrow.BackColor = System.Drawing.Color.White
        Me.Linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Linkarrow.Location = New System.Drawing.Point(68, 12)
        Me.Linkarrow.Name = "Linkarrow"
        Me.Linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.Linkarrow.TabIndex = 69
        Me.Linkarrow.Text = "4"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(1, 6)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(508, 31)
        Me.banner.TabIndex = 71
        Me.banner.TabStop = False
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
        Me.printbutton.Location = New System.Drawing.Point(514, 7)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 125
        Me.printbutton.UseVisualStyleBackColor = False
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
        'TeacherView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(547, 440)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.Linkarrow)
        Me.Controls.Add(Me.Student)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.TeacherGrid)
        Me.Controls.Add(Me.TeacherGroup)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(563, 478)
        Me.MinimumSize = New System.Drawing.Size(563, 478)
        Me.Name = "TeacherView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.TeacherGroup.ResumeLayout(False)
        Me.TeacherGroup.PerformLayout()
        CType(Me.TeacherGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents TeacherGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Fieldlabel As System.Windows.Forms.Label
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents wherelabel As System.Windows.Forms.Label
    Friend WithEvents TeacherGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DisplayTeacher As System.Windows.Forms.Button
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents Student As System.Windows.Forms.LinkLabel
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Linkarrow As System.Windows.Forms.Label
    Friend WithEvents TeacherAdd As System.Windows.Forms.Button
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
