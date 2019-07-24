<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remove_Student_Class
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
        Me.removestudentlink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow2 = New System.Windows.Forms.Label()
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow1 = New System.Windows.Forms.Label()
        Me.MainMenulink = New System.Windows.Forms.LinkLabel()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Currentclassgrid = New System.Windows.Forms.DataGridView()
        Me.DatagridHeaderlabel = New System.Windows.Forms.Label()
        Me.formtitle = New System.Windows.Forms.Label()
        Me.Surnamefield = New System.Windows.Forms.TextBox()
        Me.Firstnamefield = New System.Windows.Forms.TextBox()
        Me.surnamelabel = New System.Windows.Forms.Label()
        Me.firstnamelabel = New System.Windows.Forms.Label()
        Me.Removefromclass = New System.Windows.Forms.Button()
        Me.Formfield = New System.Windows.Forms.TextBox()
        Me.formlabel = New System.Windows.Forms.Label()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Currentclassgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'removestudentlink
        '
        Me.removestudentlink.AutoSize = True
        Me.removestudentlink.BackColor = System.Drawing.Color.White
        Me.removestudentlink.Enabled = False
        Me.removestudentlink.LinkColor = System.Drawing.Color.Gray
        Me.removestudentlink.Location = New System.Drawing.Point(194, 13)
        Me.removestudentlink.Name = "removestudentlink"
        Me.removestudentlink.Size = New System.Drawing.Size(87, 13)
        Me.removestudentlink.TabIndex = 107
        Me.removestudentlink.TabStop = True
        Me.removestudentlink.Text = "Remove Student"
        '
        'linkarrow2
        '
        Me.linkarrow2.AutoSize = True
        Me.linkarrow2.BackColor = System.Drawing.Color.White
        Me.linkarrow2.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow2.Location = New System.Drawing.Point(176, 9)
        Me.linkarrow2.Name = "linkarrow2"
        Me.linkarrow2.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow2.TabIndex = 106
        Me.linkarrow2.Text = "4"
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(94, 12)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(83, 13)
        Me.Classeslink.TabIndex = 105
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Student Classes"
        '
        'linkarrow1
        '
        Me.linkarrow1.AutoSize = True
        Me.linkarrow1.BackColor = System.Drawing.Color.White
        Me.linkarrow1.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow1.Location = New System.Drawing.Point(76, 9)
        Me.linkarrow1.Name = "linkarrow1"
        Me.linkarrow1.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow1.TabIndex = 104
        Me.linkarrow1.Text = "4"
        '
        'MainMenulink
        '
        Me.MainMenulink.AutoSize = True
        Me.MainMenulink.BackColor = System.Drawing.Color.White
        Me.MainMenulink.Location = New System.Drawing.Point(20, 12)
        Me.MainMenulink.Name = "MainMenulink"
        Me.MainMenulink.Size = New System.Drawing.Size(60, 13)
        Me.MainMenulink.TabIndex = 103
        Me.MainMenulink.TabStop = True
        Me.MainMenulink.Text = "Main Menu"
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg_editadd_2
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(2, 3)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(305, 31)
        Me.banner.TabIndex = 108
        Me.banner.TabStop = False
        '
        'Currentclassgrid
        '
        Me.Currentclassgrid.AllowUserToAddRows = False
        Me.Currentclassgrid.AllowUserToDeleteRows = False
        Me.Currentclassgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Currentclassgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Currentclassgrid.Location = New System.Drawing.Point(6, 100)
        Me.Currentclassgrid.Name = "Currentclassgrid"
        Me.Currentclassgrid.ReadOnly = True
        Me.Currentclassgrid.RowHeadersVisible = False
        Me.Currentclassgrid.Size = New System.Drawing.Size(301, 62)
        Me.Currentclassgrid.TabIndex = 110
        Me.Currentclassgrid.Visible = False
        '
        'DatagridHeaderlabel
        '
        Me.DatagridHeaderlabel.AutoSize = True
        Me.DatagridHeaderlabel.BackColor = System.Drawing.Color.Transparent
        Me.DatagridHeaderlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatagridHeaderlabel.ForeColor = System.Drawing.Color.Maroon
        Me.DatagridHeaderlabel.Location = New System.Drawing.Point(6, 75)
        Me.DatagridHeaderlabel.Name = "DatagridHeaderlabel"
        Me.DatagridHeaderlabel.Size = New System.Drawing.Size(147, 16)
        Me.DatagridHeaderlabel.TabIndex = 109
        Me.DatagridHeaderlabel.Text = "Current Selected Class:"
        '
        'formtitle
        '
        Me.formtitle.AutoSize = True
        Me.formtitle.BackColor = System.Drawing.Color.Transparent
        Me.formtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formtitle.ForeColor = System.Drawing.Color.Maroon
        Me.formtitle.Location = New System.Drawing.Point(8, 39)
        Me.formtitle.Name = "formtitle"
        Me.formtitle.Size = New System.Drawing.Size(238, 20)
        Me.formtitle.TabIndex = 111
        Me.formtitle.Text = "Remove Student From Class"
        '
        'Surnamefield
        '
        Me.Surnamefield.Enabled = False
        Me.Surnamefield.Location = New System.Drawing.Point(114, 207)
        Me.Surnamefield.Name = "Surnamefield"
        Me.Surnamefield.Size = New System.Drawing.Size(132, 20)
        Me.Surnamefield.TabIndex = 113
        '
        'Firstnamefield
        '
        Me.Firstnamefield.Enabled = False
        Me.Firstnamefield.Location = New System.Drawing.Point(114, 175)
        Me.Firstnamefield.Name = "Firstnamefield"
        Me.Firstnamefield.Size = New System.Drawing.Size(132, 20)
        Me.Firstnamefield.TabIndex = 112
        '
        'surnamelabel
        '
        Me.surnamelabel.AutoSize = True
        Me.surnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.surnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.surnamelabel.Location = New System.Drawing.Point(12, 207)
        Me.surnamelabel.Name = "surnamelabel"
        Me.surnamelabel.Size = New System.Drawing.Size(89, 13)
        Me.surnamelabel.TabIndex = 115
        Me.surnamelabel.Text = "Student Surname"
        '
        'firstnamelabel
        '
        Me.firstnamelabel.AutoSize = True
        Me.firstnamelabel.BackColor = System.Drawing.Color.Transparent
        Me.firstnamelabel.ForeColor = System.Drawing.Color.Maroon
        Me.firstnamelabel.Location = New System.Drawing.Point(12, 178)
        Me.firstnamelabel.Name = "firstnamelabel"
        Me.firstnamelabel.Size = New System.Drawing.Size(95, 13)
        Me.firstnamelabel.TabIndex = 114
        Me.firstnamelabel.Text = "Student Firstname:"
        '
        'Removefromclass
        '
        Me.Removefromclass.BackColor = System.Drawing.Color.Transparent
        Me.Removefromclass.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.common_button_blue_md
        Me.Removefromclass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Removefromclass.FlatAppearance.BorderSize = 0
        Me.Removefromclass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Removefromclass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Removefromclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Removefromclass.ForeColor = System.Drawing.Color.White
        Me.Removefromclass.Location = New System.Drawing.Point(96, 261)
        Me.Removefromclass.Name = "Removefromclass"
        Me.Removefromclass.Size = New System.Drawing.Size(116, 26)
        Me.Removefromclass.TabIndex = 117
        Me.Removefromclass.Text = "Remove from Class"
        Me.Removefromclass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Removefromclass.UseVisualStyleBackColor = False
        '
        'Formfield
        '
        Me.Formfield.Enabled = False
        Me.Formfield.Location = New System.Drawing.Point(114, 235)
        Me.Formfield.Name = "Formfield"
        Me.Formfield.Size = New System.Drawing.Size(132, 20)
        Me.Formfield.TabIndex = 118
        '
        'formlabel
        '
        Me.formlabel.AutoSize = True
        Me.formlabel.BackColor = System.Drawing.Color.Transparent
        Me.formlabel.ForeColor = System.Drawing.Color.Maroon
        Me.formlabel.Location = New System.Drawing.Point(12, 235)
        Me.formlabel.Name = "formlabel"
        Me.formlabel.Size = New System.Drawing.Size(70, 13)
        Me.formlabel.TabIndex = 119
        Me.formlabel.Text = "Student Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Remove_Student_Class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(314, 294)
        Me.Controls.Add(Me.Formfield)
        Me.Controls.Add(Me.formlabel)
        Me.Controls.Add(Me.Removefromclass)
        Me.Controls.Add(Me.Surnamefield)
        Me.Controls.Add(Me.Firstnamefield)
        Me.Controls.Add(Me.surnamelabel)
        Me.Controls.Add(Me.firstnamelabel)
        Me.Controls.Add(Me.formtitle)
        Me.Controls.Add(Me.Currentclassgrid)
        Me.Controls.Add(Me.DatagridHeaderlabel)
        Me.Controls.Add(Me.removestudentlink)
        Me.Controls.Add(Me.linkarrow2)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow1)
        Me.Controls.Add(Me.MainMenulink)
        Me.Controls.Add(Me.banner)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(330, 332)
        Me.MinimumSize = New System.Drawing.Size(330, 332)
        Me.Name = "Remove_Student_Class"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Student Class"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Currentclassgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents removestudentlink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow2 As System.Windows.Forms.Label
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow1 As System.Windows.Forms.Label
    Friend WithEvents MainMenulink As System.Windows.Forms.LinkLabel
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Currentclassgrid As System.Windows.Forms.DataGridView
    Friend WithEvents DatagridHeaderlabel As System.Windows.Forms.Label
    Friend WithEvents formtitle As System.Windows.Forms.Label
    Friend WithEvents Surnamefield As System.Windows.Forms.TextBox
    Friend WithEvents Firstnamefield As System.Windows.Forms.TextBox
    Friend WithEvents surnamelabel As System.Windows.Forms.Label
    Friend WithEvents firstnamelabel As System.Windows.Forms.Label
    Friend WithEvents Removefromclass As System.Windows.Forms.Button
    Friend WithEvents Formfield As System.Windows.Forms.TextBox
    Friend WithEvents formlabel As System.Windows.Forms.Label
End Class
