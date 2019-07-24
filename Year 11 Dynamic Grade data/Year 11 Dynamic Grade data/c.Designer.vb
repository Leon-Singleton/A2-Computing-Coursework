<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subje
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
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Gradelink = New System.Windows.Forms.LinkLabel()
        Me.SubjectGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Namefield = New System.Windows.Forms.TextBox()
        Me.Gradecheck = New System.Windows.Forms.CheckBox()
        Me.Levelcheckbox = New System.Windows.Forms.CheckBox()
        Me.Subjectcheck = New System.Windows.Forms.CheckBox()
        Me.Yearcheck = New System.Windows.Forms.CheckBox()
        Me.Namecheck = New System.Windows.Forms.CheckBox()
        Me.Year = New System.Windows.Forms.Label()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.Name = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.Levelfield = New System.Windows.Forms.ComboBox()
        Me.Grade = New System.Windows.Forms.Label()
        Me.Gradefield = New System.Windows.Forms.ComboBox()
        Me.Subjectl = New System.Windows.Forms.Label()
        Me.subjectfield = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        CType(Me.SubjectGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.Location = New System.Drawing.Point(12, 9)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(78, 13)
        Me.MainMenu.TabIndex = 33
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu-->>"
        '
        'Gradelink
        '
        Me.Gradelink.AutoSize = True
        Me.Gradelink.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Gradelink.Enabled = False
        Me.Gradelink.Location = New System.Drawing.Point(96, 9)
        Me.Gradelink.Name = "Gradelink"
        Me.Gradelink.Size = New System.Drawing.Size(54, 13)
        Me.Gradelink.TabIndex = 34
        Me.Gradelink.TabStop = True
        Me.Gradelink.Text = "Grade-->>"
        '
        'SubjectGrid
        '
        Me.SubjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectGrid.Location = New System.Drawing.Point(3, 153)
        Me.SubjectGrid.Name = "SubjectGrid"
        Me.SubjectGrid.Size = New System.Drawing.Size(725, 324)
        Me.SubjectGrid.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Namefield)
        Me.GroupBox1.Controls.Add(Me.Gradecheck)
        Me.GroupBox1.Controls.Add(Me.Levelcheckbox)
        Me.GroupBox1.Controls.Add(Me.Subjectcheck)
        Me.GroupBox1.Controls.Add(Me.Yearcheck)
        Me.GroupBox1.Controls.Add(Me.Namecheck)
        Me.GroupBox1.Controls.Add(Me.Year)
        Me.GroupBox1.Controls.Add(Me.Yearfield)
        Me.GroupBox1.Controls.Add(Me.Name)
        Me.GroupBox1.Controls.Add(Me.Level)
        Me.GroupBox1.Controls.Add(Me.Levelfield)
        Me.GroupBox1.Controls.Add(Me.Grade)
        Me.GroupBox1.Controls.Add(Me.Gradefield)
        Me.GroupBox1.Controls.Add(Me.Subjectl)
        Me.GroupBox1.Controls.Add(Me.subjectfield)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Search)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Grade By subject"
        '
        'Namefield
        '
        Me.Namefield.Location = New System.Drawing.Point(211, 19)
        Me.Namefield.Name = "Namefield"
        Me.Namefield.Size = New System.Drawing.Size(131, 20)
        Me.Namefield.TabIndex = 55
        '
        'Gradecheck
        '
        Me.Gradecheck.AutoSize = True
        Me.Gradecheck.Location = New System.Drawing.Point(94, 53)
        Me.Gradecheck.Name = "Gradecheck"
        Me.Gradecheck.Size = New System.Drawing.Size(55, 17)
        Me.Gradecheck.TabIndex = 54
        Me.Gradecheck.Text = "Grade"
        Me.Gradecheck.UseVisualStyleBackColor = True
        '
        'Levelcheckbox
        '
        Me.Levelcheckbox.AutoSize = True
        Me.Levelcheckbox.Location = New System.Drawing.Point(94, 70)
        Me.Levelcheckbox.Name = "Levelcheckbox"
        Me.Levelcheckbox.Size = New System.Drawing.Size(52, 17)
        Me.Levelcheckbox.TabIndex = 53
        Me.Levelcheckbox.Text = "Level"
        Me.Levelcheckbox.UseVisualStyleBackColor = True
        '
        'Subjectcheck
        '
        Me.Subjectcheck.AutoSize = True
        Me.Subjectcheck.Location = New System.Drawing.Point(94, 36)
        Me.Subjectcheck.Name = "Subjectcheck"
        Me.Subjectcheck.Size = New System.Drawing.Size(62, 17)
        Me.Subjectcheck.TabIndex = 52
        Me.Subjectcheck.Text = "Subject"
        Me.Subjectcheck.UseVisualStyleBackColor = True
        '
        'Yearcheck
        '
        Me.Yearcheck.AutoSize = True
        Me.Yearcheck.Location = New System.Drawing.Point(94, 87)
        Me.Yearcheck.Name = "Yearcheck"
        Me.Yearcheck.Size = New System.Drawing.Size(48, 17)
        Me.Yearcheck.TabIndex = 51
        Me.Yearcheck.Text = "Year"
        Me.Yearcheck.UseVisualStyleBackColor = True
        '
        'Namecheck
        '
        Me.Namecheck.AutoSize = True
        Me.Namecheck.Location = New System.Drawing.Point(94, 19)
        Me.Namecheck.Name = "Namecheck"
        Me.Namecheck.Size = New System.Drawing.Size(54, 17)
        Me.Namecheck.TabIndex = 36
        Me.Namecheck.Text = "Name"
        Me.Namecheck.UseVisualStyleBackColor = True
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.Location = New System.Drawing.Point(353, 52)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(32, 13)
        Me.Year.TabIndex = 50
        Me.Year.Text = "Year:"
        Me.Year.Visible = False
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Items.AddRange(New Object() {"Art", "Business Studies", "Drama", "English Language", "English Literature", "Food Technology", "Geaography", "Health And Social care", "History", "ICT", "Leisure and Tourism", "Maths", "French", "Spanish", "German", "Music", "Religious Studies", "Reisistant Materials", "Physichal_Education", "Computing", "Biology", "Chemistry", "Physics", "Textiles"})
        Me.Yearfield.Location = New System.Drawing.Point(400, 49)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(131, 21)
        Me.Yearfield.TabIndex = 49
        Me.Yearfield.Visible = False
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(167, 25)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(38, 13)
        Me.Name.TabIndex = 48
        Me.Name.Text = "Name:"
        Me.Name.Visible = False
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Location = New System.Drawing.Point(353, 25)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(36, 13)
        Me.Level.TabIndex = 46
        Me.Level.Text = "Level:"
        Me.Level.Visible = False
        '
        'Levelfield
        '
        Me.Levelfield.FormattingEnabled = True
        Me.Levelfield.Items.AddRange(New Object() {"Art", "Business Studies", "Drama", "English Language", "English Literature", "Food Technology", "Geaography", "Health And Social care", "History", "ICT", "Leisure and Tourism", "Maths", "French", "Spanish", "German", "Music", "Religious Studies", "Reisistant Materials", "Physichal_Education", "Computing", "Biology", "Chemistry", "Physics", "Textiles"})
        Me.Levelfield.Location = New System.Drawing.Point(400, 22)
        Me.Levelfield.Name = "Levelfield"
        Me.Levelfield.Size = New System.Drawing.Size(131, 21)
        Me.Levelfield.TabIndex = 45
        Me.Levelfield.Visible = False
        '
        'Grade
        '
        Me.Grade.AutoSize = True
        Me.Grade.Location = New System.Drawing.Point(167, 81)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(39, 13)
        Me.Grade.TabIndex = 44
        Me.Grade.Text = "Grade:"
        Me.Grade.Visible = False
        '
        'Gradefield
        '
        Me.Gradefield.FormattingEnabled = True
        Me.Gradefield.Items.AddRange(New Object() {"3", "4", "5", "A*", "A", "B", "C", "D", "E", "F"})
        Me.Gradefield.Location = New System.Drawing.Point(216, 78)
        Me.Gradefield.Name = "Gradefield"
        Me.Gradefield.Size = New System.Drawing.Size(131, 21)
        Me.Gradefield.TabIndex = 43
        Me.Gradefield.Visible = False
        '
        'Subjectl
        '
        Me.Subjectl.AutoSize = True
        Me.Subjectl.Location = New System.Drawing.Point(167, 52)
        Me.Subjectl.Name = "Subjectl"
        Me.Subjectl.Size = New System.Drawing.Size(46, 13)
        Me.Subjectl.TabIndex = 42
        Me.Subjectl.Text = "Subject:"
        Me.Subjectl.Visible = False
        '
        'subjectfield
        '
        Me.subjectfield.FormattingEnabled = True
        Me.subjectfield.Items.AddRange(New Object() {"Art", "Business Studies", "Drama", "English Language", "English Literature", "Food Technology", "Geaography", "Health And Social care", "History", "ICT", "Leisure and Tourism", "Maths", "French", "Spanish", "German", "Music", "Religious Studies", "Reisistant Materials", "Physichal_Education", "Computing", "Biology", "Chemistry", "Physics", "Textiles"})
        Me.subjectfield.Location = New System.Drawing.Point(216, 51)
        Me.subjectfield.Name = "subjectfield"
        Me.subjectfield.Size = New System.Drawing.Size(131, 21)
        Me.subjectfield.TabIndex = 41
        Me.subjectfield.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "to search from:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "you would like"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Select the fields"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(615, 84)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 36
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Subje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 480)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SubjectGrid)
        Me.Controls.Add(Me.Gradelink)
        Me.Controls.Add(Me.MainMenu)
        Me.Name = "Subje"
        Me.Text = "Grade"
        CType(Me.SubjectGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Gradelink As System.Windows.Forms.LinkLabel
    Friend WithEvents SubjectGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.Label
    Friend WithEvents Levelfield As System.Windows.Forms.ComboBox
    Friend WithEvents Grade As System.Windows.Forms.Label
    Friend WithEvents Gradefield As System.Windows.Forms.ComboBox
    Friend WithEvents Subjectl As System.Windows.Forms.Label
    Friend WithEvents subjectfield As System.Windows.Forms.ComboBox
    Friend WithEvents Year As System.Windows.Forms.Label
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents Name As System.Windows.Forms.Label
    Friend WithEvents Namecheck As System.Windows.Forms.CheckBox
    Friend WithEvents Gradecheck As System.Windows.Forms.CheckBox
    Friend WithEvents Levelcheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Subjectcheck As System.Windows.Forms.CheckBox
    Friend WithEvents Yearcheck As System.Windows.Forms.CheckBox
    Friend WithEvents Namefield As System.Windows.Forms.TextBox
End Class
