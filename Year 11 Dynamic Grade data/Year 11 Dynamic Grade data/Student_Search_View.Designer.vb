<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Search_View
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Displaystudent = New System.Windows.Forms.Button()
        Me.Field = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DnlsingletonDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._dn_lsingletonDataSet = New Year_11_Dynamic_Grade_data._dn_lsingletonDataSet()
        Me.StudentTableAdapter = New Year_11_Dynamic_Grade_data._dn_lsingletonDataSetTableAdapters.StudentTableAdapter()
        Me.SearchEthnicity = New System.Windows.Forms.ComboBox()
        Me.SearchSNS = New System.Windows.Forms.ComboBox()
        Me.SearchForm = New System.Windows.Forms.ComboBox()
        Me.SearchYear = New System.Windows.Forms.ComboBox()
        Me.SearchDataset = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DnlsingletonDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dn_lsingletonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1192, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Return to main menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'SearchName
        '
        Me.SearchName.Location = New System.Drawing.Point(277, 21)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.Size = New System.Drawing.Size(142, 20)
        Me.SearchName.TabIndex = 5
        Me.SearchName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search Student Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1137, 456)
        Me.DataGridView1.TabIndex = 8
        '
        'Displaystudent
        '
        Me.Displaystudent.Location = New System.Drawing.Point(430, 18)
        Me.Displaystudent.Name = "Displaystudent"
        Me.Displaystudent.Size = New System.Drawing.Size(75, 23)
        Me.Displaystudent.TabIndex = 9
        Me.Displaystudent.Text = "Search"
        Me.Displaystudent.UseVisualStyleBackColor = True
        '
        'Field
        '
        Me.Field.FormattingEnabled = True
        Me.Field.Items.AddRange(New Object() {"", "Name", "Gender", "SNS", "Ethncity", "Attendance", "Form ", "Year", "Dataset"})
        Me.Field.Location = New System.Drawing.Point(52, 20)
        Me.Field.Name = "Field"
        Me.Field.Size = New System.Drawing.Size(121, 21)
        Me.Field.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchDataset)
        Me.GroupBox1.Controls.Add(Me.SearchYear)
        Me.GroupBox1.Controls.Add(Me.SearchForm)
        Me.GroupBox1.Controls.Add(Me.SearchSNS)
        Me.GroupBox1.Controls.Add(Me.SearchEthnicity)
        Me.GroupBox1.Controls.Add(Me.SearchGender)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SearchName)
        Me.GroupBox1.Controls.Add(Me.Displaystudent)
        Me.GroupBox1.Controls.Add(Me.Field)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 49)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'SearchGender
        '
        Me.SearchGender.FormattingEnabled = True
        Me.SearchGender.Location = New System.Drawing.Point(277, 21)
        Me.SearchGender.Name = "SearchGender"
        Me.SearchGender.Size = New System.Drawing.Size(142, 21)
        Me.SearchGender.TabIndex = 14
        Me.SearchGender.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.DnlsingletonDataSetBindingSource
        '
        'DnlsingletonDataSetBindingSource
        '
        Me.DnlsingletonDataSetBindingSource.DataSource = Me._dn_lsingletonDataSet
        Me.DnlsingletonDataSetBindingSource.Position = 0
        '
        '_dn_lsingletonDataSet
        '
        Me._dn_lsingletonDataSet.DataSetName = "_dn_lsingletonDataSet"
        Me._dn_lsingletonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'SearchEthnicity
        '
        Me.SearchEthnicity.FormattingEnabled = True
        Me.SearchEthnicity.Location = New System.Drawing.Point(277, 20)
        Me.SearchEthnicity.Name = "SearchEthnicity"
        Me.SearchEthnicity.Size = New System.Drawing.Size(142, 21)
        Me.SearchEthnicity.TabIndex = 15
        '
        'SearchSNS
        '
        Me.SearchSNS.FormattingEnabled = True
        Me.SearchSNS.Location = New System.Drawing.Point(277, 21)
        Me.SearchSNS.Name = "SearchSNS"
        Me.SearchSNS.Size = New System.Drawing.Size(142, 21)
        Me.SearchSNS.TabIndex = 16
        '
        'SearchForm
        '
        Me.SearchForm.FormattingEnabled = True
        Me.SearchForm.Location = New System.Drawing.Point(277, 20)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(142, 21)
        Me.SearchForm.TabIndex = 17
        '
        'SearchYear
        '
        Me.SearchYear.FormattingEnabled = True
        Me.SearchYear.Location = New System.Drawing.Point(277, 21)
        Me.SearchYear.Name = "SearchYear"
        Me.SearchYear.Size = New System.Drawing.Size(142, 21)
        Me.SearchYear.TabIndex = 18
        '
        'SearchDataset
        '
        Me.SearchDataset.FormattingEnabled = True
        Me.SearchDataset.Location = New System.Drawing.Point(277, 21)
        Me.SearchDataset.Name = "SearchDataset"
        Me.SearchDataset.Size = New System.Drawing.Size(142, 21)
        Me.SearchDataset.TabIndex = 19
        '
        'Student_Search_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Student_Search_View"
        Me.Text = "Search_View"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DnlsingletonDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dn_lsingletonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Displaystudent As System.Windows.Forms.Button
    Friend WithEvents DnlsingletonDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _dn_lsingletonDataSet As Year_11_Dynamic_Grade_data._dn_lsingletonDataSet
    Friend WithEvents Field As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SearchGender As System.Windows.Forms.ComboBox
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As Year_11_Dynamic_Grade_data._dn_lsingletonDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents SearchEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSNS As System.Windows.Forms.ComboBox
    Friend WithEvents SearchForm As System.Windows.Forms.ComboBox
    Friend WithEvents SearchDataset As System.Windows.Forms.ComboBox
    Friend WithEvents SearchYear As System.Windows.Forms.ComboBox
End Class
