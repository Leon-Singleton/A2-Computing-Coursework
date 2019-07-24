<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Myclasses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Myclasses))
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.linkarrow = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.classgrid = New System.Windows.Forms.DataGridView()
        Me.Formheader = New System.Windows.Forms.Label()
        Me.Clearselection = New System.Windows.Forms.Button()
        Me.Viewstudentsgrid = New System.Windows.Forms.DataGridView()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.classgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Viewstudentsgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(11, 10)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(721, 31)
        Me.banner.TabIndex = 83
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
        Me.printbutton.Location = New System.Drawing.Point(738, 11)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 126
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(98, 20)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(60, 13)
        Me.Classeslink.TabIndex = 129
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "My Classes"
        '
        'linkarrow
        '
        Me.linkarrow.AutoSize = True
        Me.linkarrow.BackColor = System.Drawing.Color.White
        Me.linkarrow.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.linkarrow.Location = New System.Drawing.Point(80, 17)
        Me.linkarrow.Name = "linkarrow"
        Me.linkarrow.Size = New System.Drawing.Size(25, 19)
        Me.linkarrow.TabIndex = 128
        Me.linkarrow.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(23, 20)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 127
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
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
        'classgrid
        '
        Me.classgrid.AllowUserToAddRows = False
        Me.classgrid.AllowUserToDeleteRows = False
        Me.classgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.classgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.classgrid.Location = New System.Drawing.Point(11, 87)
        Me.classgrid.Name = "classgrid"
        Me.classgrid.ReadOnly = True
        Me.classgrid.RowHeadersVisible = False
        Me.classgrid.Size = New System.Drawing.Size(758, 409)
        Me.classgrid.TabIndex = 130
        Me.classgrid.Visible = False
        '
        'Formheader
        '
        Me.Formheader.AutoSize = True
        Me.Formheader.BackColor = System.Drawing.Color.Transparent
        Me.Formheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formheader.ForeColor = System.Drawing.Color.Maroon
        Me.Formheader.Location = New System.Drawing.Point(14, 49)
        Me.Formheader.Name = "Formheader"
        Me.Formheader.Size = New System.Drawing.Size(99, 20)
        Me.Formheader.TabIndex = 131
        Me.Formheader.Text = "My Classes"
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
        Me.Clearselection.Location = New System.Drawing.Point(131, 49)
        Me.Clearselection.Name = "Clearselection"
        Me.Clearselection.Size = New System.Drawing.Size(114, 30)
        Me.Clearselection.TabIndex = 132
        Me.Clearselection.Text = "ClearSelection"
        Me.Clearselection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Clearselection.UseVisualStyleBackColor = False
        '
        'Viewstudentsgrid
        '
        Me.Viewstudentsgrid.AllowUserToAddRows = False
        Me.Viewstudentsgrid.AllowUserToDeleteRows = False
        Me.Viewstudentsgrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Viewstudentsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Viewstudentsgrid.Location = New System.Drawing.Point(11, 85)
        Me.Viewstudentsgrid.Name = "Viewstudentsgrid"
        Me.Viewstudentsgrid.ReadOnly = True
        Me.Viewstudentsgrid.RowHeadersVisible = False
        Me.Viewstudentsgrid.Size = New System.Drawing.Size(760, 411)
        Me.Viewstudentsgrid.TabIndex = 133
        Me.Viewstudentsgrid.Visible = False
        '
        'Myclasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(781, 508)
        Me.Controls.Add(Me.Clearselection)
        Me.Controls.Add(Me.Formheader)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.linkarrow)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Viewstudentsgrid)
        Me.Controls.Add(Me.classgrid)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(797, 546)
        Me.MinimumSize = New System.Drawing.Size(797, 546)
        Me.Name = "Myclasses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My classes"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.classgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Viewstudentsgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents linkarrow As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents classgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Formheader As System.Windows.Forms.Label
    Friend WithEvents Clearselection As System.Windows.Forms.Button
    Friend WithEvents Viewstudentsgrid As System.Windows.Forms.DataGridView
End Class
