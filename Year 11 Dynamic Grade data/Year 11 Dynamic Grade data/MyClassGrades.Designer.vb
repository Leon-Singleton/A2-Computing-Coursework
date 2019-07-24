<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyClassGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyClassGrades))
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Clearselection = New System.Windows.Forms.Button()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.Classgrid = New System.Windows.Forms.DataGridView()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Classgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(93, 14)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(86, 13)
        Me.Classeslink.TabIndex = 134
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "My Class Grades"
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(75, 11)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 133
        Me.linkarrow.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(18, 14)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 132
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
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
        Me.printbutton.Location = New System.Drawing.Point(733, 5)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 131
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(6, 4)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(721, 31)
        Me.banner.TabIndex = 130
        Me.banner.TabStop = False
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
        Me.Clearselection.Location = New System.Drawing.Point(159, 42)
        Me.Clearselection.Name = "Clearselection"
        Me.Clearselection.Size = New System.Drawing.Size(114, 30)
        Me.Clearselection.TabIndex = 136
        Me.Clearselection.Text = "ClearSelection"
        Me.Clearselection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Clearselection.UseVisualStyleBackColor = False
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(8, 42)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(144, 20)
        Me.Formheader.TabIndex = 135
        Me.Formheader.Text = "My Class Grades"
        '
        'Classgrid
        '
        Me.Classgrid.AllowUserToAddRows = False
        Me.Classgrid.AllowUserToDeleteRows = False
        Me.Classgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Classgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Classgrid.Location = New System.Drawing.Point(6, 78)
        Me.Classgrid.Name = "Classgrid"
        Me.Classgrid.ReadOnly = True
        Me.Classgrid.RowHeadersVisible = False
        Me.Classgrid.Size = New System.Drawing.Size(760, 411)
        Me.Classgrid.TabIndex = 137
        Me.Classgrid.Visible = False
        '
        'MyClassGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(769, 493)
        Me.Controls.Add(Me.Classgrid)
        Me.Controls.Add(Me.Clearselection)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.banner)
        Me.Name = "MyClassGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Class Grades"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Classgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Clearselection As System.Windows.Forms.Button
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents Classgrid As System.Windows.Forms.DataGridView
End Class
