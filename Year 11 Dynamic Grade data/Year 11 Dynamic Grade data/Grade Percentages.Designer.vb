<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grade_Percentages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grade_Percentages))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.Classeslink = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStudent = New System.Windows.Forms.GroupBox()
        Me.Graphtypefield = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Gradetypefield = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Levelfield = New System.Windows.Forms.ComboBox()
        Me.Levellabel = New System.Windows.Forms.Label()
        Me.Yearfield = New System.Windows.Forms.ComboBox()
        Me.yearlabel = New System.Windows.Forms.Label()
        Me.subjectlabel = New System.Windows.Forms.Label()
        Me.SubjectField = New System.Windows.Forms.ComboBox()
        Me.Addsearch = New System.Windows.Forms.Button()
        Me.chartlabel = New System.Windows.Forms.Label()
        Me.KS4Table = New System.Windows.Forms.TableLayoutPanel()
        Me.Utable1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabletitle = New System.Windows.Forms.Label()
        Me.gradeE = New System.Windows.Forms.Label()
        Me.gradeC = New System.Windows.Forms.Label()
        Me.gradeB = New System.Windows.Forms.Label()
        Me.gradeA = New System.Windows.Forms.Label()
        Me.gradeAstar = New System.Windows.Forms.Label()
        Me.gradeD = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gradeG = New System.Windows.Forms.Label()
        Me.gradeF = New System.Windows.Forms.Label()
        Me.KS2table = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Grade5 = New System.Windows.Forms.Label()
        Me.Grade4 = New System.Windows.Forms.Label()
        Me.Grade3 = New System.Windows.Forms.Label()
        Me.AtoCtable = New System.Windows.Forms.TableLayoutPanel()
        Me.AtoC = New System.Windows.Forms.Label()
        Me.table2title = New System.Windows.Forms.Label()
        Me.Groupview = New System.Windows.Forms.GroupBox()
        Me.TablesView = New System.Windows.Forms.Button()
        Me.Graphview = New System.Windows.Forms.Button()
        Me.Clearselection = New System.Windows.Forms.Button()
        Me.Percentageschart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.printbutton = New System.Windows.Forms.Button()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchStudent.SuspendLayout()
        Me.KS4Table.SuspendLayout()
        Me.KS2table.SuspendLayout()
        Me.AtoCtable.SuspendLayout()
        Me.Groupview.SuspendLayout()
        CType(Me.Percentageschart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'banner
        '
        Me.banner.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.Titlebg
        Me.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner.Location = New System.Drawing.Point(2, 3)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(825, 31)
        Me.banner.TabIndex = 84
        Me.banner.TabStop = False
        '
        'Classeslink
        '
        Me.Classeslink.AutoSize = True
        Me.Classeslink.BackColor = System.Drawing.Color.White
        Me.Classeslink.Enabled = False
        Me.Classeslink.LinkColor = System.Drawing.Color.Gray
        Me.Classeslink.Location = New System.Drawing.Point(87, 12)
        Me.Classeslink.Name = "Classeslink"
        Me.Classeslink.Size = New System.Drawing.Size(99, 13)
        Me.Classeslink.TabIndex = 89
        Me.Classeslink.TabStop = True
        Me.Classeslink.Text = "Grade Percentages"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 19)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "4"
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.Location = New System.Drawing.Point(12, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(60, 13)
        Me.MainMenu.TabIndex = 87
        Me.MainMenu.TabStop = True
        Me.MainMenu.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(11, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 60)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Grade Percentages" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SearchStudent
        '
        Me.SearchStudent.BackColor = System.Drawing.Color.Transparent
        Me.SearchStudent.Controls.Add(Me.Graphtypefield)
        Me.SearchStudent.Controls.Add(Me.Label10)
        Me.SearchStudent.Controls.Add(Me.Gradetypefield)
        Me.SearchStudent.Controls.Add(Me.Label2)
        Me.SearchStudent.Controls.Add(Me.Levelfield)
        Me.SearchStudent.Controls.Add(Me.Levellabel)
        Me.SearchStudent.Controls.Add(Me.Yearfield)
        Me.SearchStudent.Controls.Add(Me.yearlabel)
        Me.SearchStudent.Controls.Add(Me.subjectlabel)
        Me.SearchStudent.Controls.Add(Me.SubjectField)
        Me.SearchStudent.Controls.Add(Me.Addsearch)
        Me.SearchStudent.ForeColor = System.Drawing.Color.Maroon
        Me.SearchStudent.Location = New System.Drawing.Point(12, 69)
        Me.SearchStudent.Name = "SearchStudent"
        Me.SearchStudent.Size = New System.Drawing.Size(346, 229)
        Me.SearchStudent.TabIndex = 91
        Me.SearchStudent.TabStop = False
        Me.SearchStudent.Text = "Select a Subject"
        '
        'Graphtypefield
        '
        Me.Graphtypefield.FormattingEnabled = True
        Me.Graphtypefield.Items.AddRange(New Object() {"Standard Grade Percentage Graph", "Cumulative Grade Percentage Graph"})
        Me.Graphtypefield.Location = New System.Drawing.Point(119, 161)
        Me.Graphtypefield.Name = "Graphtypefield"
        Me.Graphtypefield.Size = New System.Drawing.Size(203, 21)
        Me.Graphtypefield.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(6, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Select a Graph Type:"
        '
        'Gradetypefield
        '
        Me.Gradetypefield.FormattingEnabled = True
        Me.Gradetypefield.Location = New System.Drawing.Point(119, 116)
        Me.Gradetypefield.Name = "Gradetypefield"
        Me.Gradetypefield.Size = New System.Drawing.Size(122, 21)
        Me.Gradetypefield.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(6, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Select a Grade Type:"
        '
        'Levelfield
        '
        Me.Levelfield.FormattingEnabled = True
        Me.Levelfield.Location = New System.Drawing.Point(119, 87)
        Me.Levelfield.Name = "Levelfield"
        Me.Levelfield.Size = New System.Drawing.Size(122, 21)
        Me.Levelfield.TabIndex = 3
        '
        'Levellabel
        '
        Me.Levellabel.AutoSize = True
        Me.Levellabel.ForeColor = System.Drawing.Color.Maroon
        Me.Levellabel.Location = New System.Drawing.Point(4, 90)
        Me.Levellabel.Name = "Levellabel"
        Me.Levellabel.Size = New System.Drawing.Size(78, 13)
        Me.Levellabel.TabIndex = 64
        Me.Levellabel.Text = "Select a Level:"
        '
        'Yearfield
        '
        Me.Yearfield.FormattingEnabled = True
        Me.Yearfield.Location = New System.Drawing.Point(119, 59)
        Me.Yearfield.Name = "Yearfield"
        Me.Yearfield.Size = New System.Drawing.Size(122, 21)
        Me.Yearfield.TabIndex = 2
        '
        'yearlabel
        '
        Me.yearlabel.AutoSize = True
        Me.yearlabel.ForeColor = System.Drawing.Color.Maroon
        Me.yearlabel.Location = New System.Drawing.Point(4, 62)
        Me.yearlabel.Name = "yearlabel"
        Me.yearlabel.Size = New System.Drawing.Size(74, 13)
        Me.yearlabel.TabIndex = 57
        Me.yearlabel.Text = "Select a Year:"
        '
        'subjectlabel
        '
        Me.subjectlabel.AutoSize = True
        Me.subjectlabel.ForeColor = System.Drawing.Color.Maroon
        Me.subjectlabel.Location = New System.Drawing.Point(1, 32)
        Me.subjectlabel.Name = "subjectlabel"
        Me.subjectlabel.Size = New System.Drawing.Size(88, 13)
        Me.subjectlabel.TabIndex = 62
        Me.subjectlabel.Text = "Select a Subject:"
        '
        'SubjectField
        '
        Me.SubjectField.FormattingEnabled = True
        Me.SubjectField.Location = New System.Drawing.Point(120, 27)
        Me.SubjectField.Name = "SubjectField"
        Me.SubjectField.Size = New System.Drawing.Size(122, 21)
        Me.SubjectField.TabIndex = 1
        '
        'Addsearch
        '
        Me.Addsearch.BackColor = System.Drawing.Color.Transparent
        Me.Addsearch.BackgroundImage = CType(resources.GetObject("Addsearch.BackgroundImage"), System.Drawing.Image)
        Me.Addsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Addsearch.FlatAppearance.BorderSize = 0
        Me.Addsearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Addsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addsearch.ForeColor = System.Drawing.Color.White
        Me.Addsearch.Location = New System.Drawing.Point(91, 186)
        Me.Addsearch.Name = "Addsearch"
        Me.Addsearch.Size = New System.Drawing.Size(113, 39)
        Me.Addsearch.TabIndex = 55
        Me.Addsearch.Text = "View Percentages"
        Me.Addsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Addsearch.UseVisualStyleBackColor = False
        '
        'chartlabel
        '
        Me.chartlabel.AutoSize = True
        Me.chartlabel.BackColor = System.Drawing.Color.Transparent
        Me.chartlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chartlabel.ForeColor = System.Drawing.Color.Maroon
        Me.chartlabel.Location = New System.Drawing.Point(408, 54)
        Me.chartlabel.Name = "chartlabel"
        Me.chartlabel.Size = New System.Drawing.Size(368, 25)
        Me.chartlabel.TabIndex = 117
        Me.chartlabel.Text = "Cumulative Percentage by Grade (%)"
        Me.chartlabel.Visible = False
        '
        'KS4Table
        '
        Me.KS4Table.BackColor = System.Drawing.Color.Transparent
        Me.KS4Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.KS4Table.ColumnCount = 2
        Me.KS4Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.KS4Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.KS4Table.Controls.Add(Me.Utable1, 0, 7)
        Me.KS4Table.Controls.Add(Me.Label9, 0, 3)
        Me.KS4Table.Controls.Add(Me.Label7, 0, 2)
        Me.KS4Table.Controls.Add(Me.Label3, 0, 0)
        Me.KS4Table.Controls.Add(Me.Label8, 0, 4)
        Me.KS4Table.Controls.Add(Me.Label6, 0, 5)
        Me.KS4Table.Controls.Add(Me.Label5, 0, 6)
        Me.KS4Table.Controls.Add(Me.Label4, 0, 1)
        Me.KS4Table.Controls.Add(Me.tabletitle, 1, 0)
        Me.KS4Table.Controls.Add(Me.gradeE, 1, 6)
        Me.KS4Table.Controls.Add(Me.gradeC, 1, 4)
        Me.KS4Table.Controls.Add(Me.gradeB, 1, 3)
        Me.KS4Table.Controls.Add(Me.gradeA, 1, 2)
        Me.KS4Table.Controls.Add(Me.gradeAstar, 1, 1)
        Me.KS4Table.Controls.Add(Me.gradeD, 1, 5)
        Me.KS4Table.Controls.Add(Me.Label13, 0, 8)
        Me.KS4Table.Controls.Add(Me.gradeG, 1, 8)
        Me.KS4Table.Controls.Add(Me.gradeF, 1, 7)
        Me.KS4Table.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KS4Table.ForeColor = System.Drawing.Color.Maroon
        Me.KS4Table.Location = New System.Drawing.Point(391, 115)
        Me.KS4Table.Name = "KS4Table"
        Me.KS4Table.RowCount = 10
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.KS4Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.KS4Table.Size = New System.Drawing.Size(358, 211)
        Me.KS4Table.TabIndex = 118
        Me.KS4Table.Visible = False
        '
        'Utable1
        '
        Me.Utable1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Utable1.AutoSize = True
        Me.Utable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utable1.ForeColor = System.Drawing.Color.Maroon
        Me.Utable1.Location = New System.Drawing.Point(23, 164)
        Me.Utable1.Name = "Utable1"
        Me.Utable1.Size = New System.Drawing.Size(19, 20)
        Me.Utable1.TabIndex = 86
        Me.Utable1.Text = "F"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(23, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "B"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(23, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "A"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(6, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Grade"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(23, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "C"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(22, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "D"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "E"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = " A*"
        '
        'tabletitle
        '
        Me.tabletitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tabletitle.AutoSize = True
        Me.tabletitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabletitle.ForeColor = System.Drawing.Color.Maroon
        Me.tabletitle.Location = New System.Drawing.Point(75, 3)
        Me.tabletitle.Name = "tabletitle"
        Me.tabletitle.Size = New System.Drawing.Size(271, 20)
        Me.tabletitle.TabIndex = 78
        Me.tabletitle.Text = "Number of Students achieving Grade"
        '
        'gradeE
        '
        Me.gradeE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeE.AutoSize = True
        Me.gradeE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeE.ForeColor = System.Drawing.Color.Maroon
        Me.gradeE.Location = New System.Drawing.Point(183, 141)
        Me.gradeE.Name = "gradeE"
        Me.gradeE.Size = New System.Drawing.Size(54, 20)
        Me.gradeE.TabIndex = 80
        Me.gradeE.Text = "Grade"
        '
        'gradeC
        '
        Me.gradeC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeC.AutoSize = True
        Me.gradeC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeC.ForeColor = System.Drawing.Color.Maroon
        Me.gradeC.Location = New System.Drawing.Point(183, 95)
        Me.gradeC.Name = "gradeC"
        Me.gradeC.Size = New System.Drawing.Size(54, 20)
        Me.gradeC.TabIndex = 79
        Me.gradeC.Text = "Grade"
        '
        'gradeB
        '
        Me.gradeB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeB.AutoSize = True
        Me.gradeB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeB.ForeColor = System.Drawing.Color.Maroon
        Me.gradeB.Location = New System.Drawing.Point(183, 72)
        Me.gradeB.Name = "gradeB"
        Me.gradeB.Size = New System.Drawing.Size(54, 20)
        Me.gradeB.TabIndex = 81
        Me.gradeB.Text = "Grade"
        '
        'gradeA
        '
        Me.gradeA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeA.AutoSize = True
        Me.gradeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeA.ForeColor = System.Drawing.Color.Maroon
        Me.gradeA.Location = New System.Drawing.Point(183, 49)
        Me.gradeA.Name = "gradeA"
        Me.gradeA.Size = New System.Drawing.Size(54, 20)
        Me.gradeA.TabIndex = 84
        Me.gradeA.Text = "Grade"
        '
        'gradeAstar
        '
        Me.gradeAstar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeAstar.AutoSize = True
        Me.gradeAstar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeAstar.ForeColor = System.Drawing.Color.Maroon
        Me.gradeAstar.Location = New System.Drawing.Point(183, 26)
        Me.gradeAstar.Name = "gradeAstar"
        Me.gradeAstar.Size = New System.Drawing.Size(54, 20)
        Me.gradeAstar.TabIndex = 83
        Me.gradeAstar.Text = "Grade"
        '
        'gradeD
        '
        Me.gradeD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeD.AutoSize = True
        Me.gradeD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeD.ForeColor = System.Drawing.Color.Maroon
        Me.gradeD.Location = New System.Drawing.Point(201, 118)
        Me.gradeD.Name = "gradeD"
        Me.gradeD.Size = New System.Drawing.Size(19, 20)
        Me.gradeD.TabIndex = 85
        Me.gradeD.Text = "F"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(22, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 20)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "G"
        '
        'gradeG
        '
        Me.gradeG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeG.AutoSize = True
        Me.gradeG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeG.ForeColor = System.Drawing.Color.Maroon
        Me.gradeG.Location = New System.Drawing.Point(201, 187)
        Me.gradeG.Name = "gradeG"
        Me.gradeG.Size = New System.Drawing.Size(19, 20)
        Me.gradeG.TabIndex = 87
        Me.gradeG.Text = "F"
        '
        'gradeF
        '
        Me.gradeF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gradeF.AutoSize = True
        Me.gradeF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeF.ForeColor = System.Drawing.Color.Maroon
        Me.gradeF.Location = New System.Drawing.Point(201, 164)
        Me.gradeF.Name = "gradeF"
        Me.gradeF.Size = New System.Drawing.Size(19, 20)
        Me.gradeF.TabIndex = 77
        Me.gradeF.Text = "F"
        '
        'KS2table
        '
        Me.KS2table.BackColor = System.Drawing.Color.Transparent
        Me.KS2table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.KS2table.ColumnCount = 2
        Me.KS2table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.KS2table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.KS2table.Controls.Add(Me.Label14, 0, 3)
        Me.KS2table.Controls.Add(Me.Label15, 0, 2)
        Me.KS2table.Controls.Add(Me.Label16, 0, 0)
        Me.KS2table.Controls.Add(Me.Label21, 0, 1)
        Me.KS2table.Controls.Add(Me.label22, 1, 0)
        Me.KS2table.Controls.Add(Me.Grade5, 1, 3)
        Me.KS2table.Controls.Add(Me.Grade4, 1, 2)
        Me.KS2table.Controls.Add(Me.Grade3, 1, 1)
        Me.KS2table.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KS2table.ForeColor = System.Drawing.Color.Maroon
        Me.KS2table.Location = New System.Drawing.Point(391, 113)
        Me.KS2table.Name = "KS2table"
        Me.KS2table.RowCount = 4
        Me.KS2table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS2table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS2table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS2table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.KS2table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.KS2table.Size = New System.Drawing.Size(358, 93)
        Me.KS2table.TabIndex = 119
        Me.KS2table.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(24, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 20)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "5"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(24, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 20)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "4"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(6, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 20)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Grade"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(24, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 20)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "3"
        '
        'label22
        '
        Me.label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.ForeColor = System.Drawing.Color.Maroon
        Me.label22.Location = New System.Drawing.Point(75, 3)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(271, 20)
        Me.label22.TabIndex = 78
        Me.label22.Text = "Number of Students achieving Grade"
        '
        'Grade5
        '
        Me.Grade5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grade5.AutoSize = True
        Me.Grade5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade5.ForeColor = System.Drawing.Color.Maroon
        Me.Grade5.Location = New System.Drawing.Point(183, 72)
        Me.Grade5.Name = "Grade5"
        Me.Grade5.Size = New System.Drawing.Size(54, 20)
        Me.Grade5.TabIndex = 81
        Me.Grade5.Text = "Grade"
        '
        'Grade4
        '
        Me.Grade4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grade4.AutoSize = True
        Me.Grade4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade4.ForeColor = System.Drawing.Color.Maroon
        Me.Grade4.Location = New System.Drawing.Point(183, 49)
        Me.Grade4.Name = "Grade4"
        Me.Grade4.Size = New System.Drawing.Size(54, 20)
        Me.Grade4.TabIndex = 84
        Me.Grade4.Text = "Grade"
        '
        'Grade3
        '
        Me.Grade3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grade3.AutoSize = True
        Me.Grade3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade3.ForeColor = System.Drawing.Color.Maroon
        Me.Grade3.Location = New System.Drawing.Point(183, 26)
        Me.Grade3.Name = "Grade3"
        Me.Grade3.Size = New System.Drawing.Size(54, 20)
        Me.Grade3.TabIndex = 83
        Me.Grade3.Text = "Grade"
        '
        'AtoCtable
        '
        Me.AtoCtable.BackColor = System.Drawing.Color.Transparent
        Me.AtoCtable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.AtoCtable.ColumnCount = 1
        Me.AtoCtable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AtoCtable.Controls.Add(Me.AtoC, 0, 1)
        Me.AtoCtable.Controls.Add(Me.table2title, 0, 0)
        Me.AtoCtable.Location = New System.Drawing.Point(391, 348)
        Me.AtoCtable.Name = "AtoCtable"
        Me.AtoCtable.RowCount = 2
        Me.AtoCtable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.AtoCtable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.AtoCtable.Size = New System.Drawing.Size(358, 54)
        Me.AtoCtable.TabIndex = 120
        Me.AtoCtable.Visible = False
        '
        'AtoC
        '
        Me.AtoC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AtoC.AutoSize = True
        Me.AtoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtoC.ForeColor = System.Drawing.Color.Maroon
        Me.AtoC.Location = New System.Drawing.Point(169, 28)
        Me.AtoC.Name = "AtoC"
        Me.AtoC.Size = New System.Drawing.Size(19, 20)
        Me.AtoC.TabIndex = 87
        Me.AtoC.Text = "F"
        '
        'table2title
        '
        Me.table2title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.table2title.AutoSize = True
        Me.table2title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2title.ForeColor = System.Drawing.Color.Maroon
        Me.table2title.Location = New System.Drawing.Point(21, 3)
        Me.table2title.Name = "table2title"
        Me.table2title.Size = New System.Drawing.Size(316, 20)
        Me.table2title.TabIndex = 121
        Me.table2title.Text = "Number of Students achieving Grades A*-C"
        '
        'Groupview
        '
        Me.Groupview.BackColor = System.Drawing.Color.Transparent
        Me.Groupview.Controls.Add(Me.TablesView)
        Me.Groupview.Controls.Add(Me.Graphview)
        Me.Groupview.ForeColor = System.Drawing.Color.Maroon
        Me.Groupview.Location = New System.Drawing.Point(15, 374)
        Me.Groupview.Name = "Groupview"
        Me.Groupview.Size = New System.Drawing.Size(125, 130)
        Me.Groupview.TabIndex = 121
        Me.Groupview.TabStop = False
        Me.Groupview.Text = "Change Data View"
        Me.Groupview.Visible = False
        '
        'TablesView
        '
        Me.TablesView.BackColor = System.Drawing.Color.Transparent
        Me.TablesView.BackgroundImage = CType(resources.GetObject("TablesView.BackgroundImage"), System.Drawing.Image)
        Me.TablesView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TablesView.FlatAppearance.BorderSize = 0
        Me.TablesView.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.TablesView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TablesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TablesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TablesView.ForeColor = System.Drawing.Color.White
        Me.TablesView.Location = New System.Drawing.Point(12, 67)
        Me.TablesView.Name = "TablesView"
        Me.TablesView.Size = New System.Drawing.Size(103, 56)
        Me.TablesView.TabIndex = 71
        Me.TablesView.Text = "View Number of Students achieving grade"
        Me.TablesView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TablesView.UseVisualStyleBackColor = False
        '
        'Graphview
        '
        Me.Graphview.BackColor = System.Drawing.Color.Transparent
        Me.Graphview.BackgroundImage = CType(resources.GetObject("Graphview.BackgroundImage"), System.Drawing.Image)
        Me.Graphview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Graphview.FlatAppearance.BorderSize = 0
        Me.Graphview.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Graphview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Graphview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Graphview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Graphview.ForeColor = System.Drawing.Color.White
        Me.Graphview.Location = New System.Drawing.Point(18, 27)
        Me.Graphview.Name = "Graphview"
        Me.Graphview.Size = New System.Drawing.Size(91, 32)
        Me.Graphview.TabIndex = 70
        Me.Graphview.Text = "View Graph"
        Me.Graphview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Graphview.UseVisualStyleBackColor = False
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
        Me.Clearselection.Location = New System.Drawing.Point(16, 321)
        Me.Clearselection.Name = "Clearselection"
        Me.Clearselection.Size = New System.Drawing.Size(150, 37)
        Me.Clearselection.TabIndex = 118
        Me.Clearselection.Text = "Clear Chart Selection"
        Me.Clearselection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Clearselection.UseVisualStyleBackColor = False
        '
        'Percentageschart
        '
        Me.Percentageschart.BackColor = System.Drawing.Color.Transparent
        Me.Percentageschart.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Percentageschart.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Gray
        ChartArea1.BorderColor = System.Drawing.Color.Maroon
        ChartArea1.Name = "ChartArea1"
        Me.Percentageschart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Percentageschart.Legends.Add(Legend1)
        Me.Percentageschart.Location = New System.Drawing.Point(364, 82)
        Me.Percentageschart.Name = "Percentageschart"
        Me.Percentageschart.Size = New System.Drawing.Size(496, 422)
        Me.Percentageschart.TabIndex = 114
        Me.Percentageschart.Text = "Chart1"
        Title1.Name = "Cumulative Grade Percentages"
        Me.Percentageschart.Titles.Add(Title1)
        Me.Percentageschart.Visible = False
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
        'printbutton
        '
        Me.printbutton.BackColor = System.Drawing.Color.Transparent
        Me.printbutton.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.print_icon
        Me.printbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.printbutton.FlatAppearance.BorderSize = 0
        Me.printbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.printbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printbutton.Location = New System.Drawing.Point(829, 3)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(31, 31)
        Me.printbutton.TabIndex = 122
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'Grade_Percentages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(863, 508)
        Me.Controls.Add(Me.Percentageschart)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.Clearselection)
        Me.Controls.Add(Me.Groupview)
        Me.Controls.Add(Me.chartlabel)
        Me.Controls.Add(Me.SearchStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Classeslink)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.AtoCtable)
        Me.Controls.Add(Me.KS2table)
        Me.Controls.Add(Me.KS4Table)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(879, 546)
        Me.MinimumSize = New System.Drawing.Size(879, 546)
        Me.Name = "Grade_Percentages"
        Me.Text = "Grade Percentages"
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchStudent.ResumeLayout(False)
        Me.SearchStudent.PerformLayout()
        Me.KS4Table.ResumeLayout(False)
        Me.KS4Table.PerformLayout()
        Me.KS2table.ResumeLayout(False)
        Me.KS2table.PerformLayout()
        Me.AtoCtable.ResumeLayout(False)
        Me.AtoCtable.PerformLayout()
        Me.Groupview.ResumeLayout(False)
        CType(Me.Percentageschart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents Classeslink As System.Windows.Forms.LinkLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchStudent As System.Windows.Forms.GroupBox
    Friend WithEvents yearlabel As System.Windows.Forms.Label
    Friend WithEvents subjectlabel As System.Windows.Forms.Label
    Friend WithEvents SubjectField As System.Windows.Forms.ComboBox
    Friend WithEvents Addsearch As System.Windows.Forms.Button
    Friend WithEvents Yearfield As System.Windows.Forms.ComboBox
    Friend WithEvents Gradetypefield As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Levelfield As System.Windows.Forms.ComboBox
    Friend WithEvents Levellabel As System.Windows.Forms.Label
    Friend WithEvents chartlabel As System.Windows.Forms.Label
    Friend WithEvents Graphtypefield As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KS4Table As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gradeF As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Utable1 As System.Windows.Forms.Label
    Friend WithEvents tabletitle As System.Windows.Forms.Label
    Friend WithEvents gradeE As System.Windows.Forms.Label
    Friend WithEvents gradeC As System.Windows.Forms.Label
    Friend WithEvents gradeB As System.Windows.Forms.Label
    Friend WithEvents gradeA As System.Windows.Forms.Label
    Friend WithEvents gradeAstar As System.Windows.Forms.Label
    Friend WithEvents gradeD As System.Windows.Forms.Label
    Friend WithEvents KS2table As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents label22 As System.Windows.Forms.Label
    Friend WithEvents Grade5 As System.Windows.Forms.Label
    Friend WithEvents Grade4 As System.Windows.Forms.Label
    Friend WithEvents Grade3 As System.Windows.Forms.Label
    Friend WithEvents AtoCtable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AtoC As System.Windows.Forms.Label
    Friend WithEvents table2title As System.Windows.Forms.Label
    Friend WithEvents Groupview As System.Windows.Forms.GroupBox
    Friend WithEvents TablesView As System.Windows.Forms.Button
    Friend WithEvents Graphview As System.Windows.Forms.Button
    Friend WithEvents Clearselection As System.Windows.Forms.Button
    Friend WithEvents Percentageschart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gradeG As System.Windows.Forms.Label
End Class
