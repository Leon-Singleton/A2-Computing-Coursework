Public Class Student_Search_View
    Private Sub student_search_view(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        DatabaseConnect()
        'TODO: This line of code loads data into the '_dn_lsingletonDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me._dn_lsingletonDataSet.Student)
        DataGridView1.Visible = False
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Displaystudent_Click(sender As System.Object, e As System.EventArgs) Handles Displaystudent.Click
        Dim sql As String
        Dim ds As DataSet

        sql = " Select * FROM Student"
        Select Case Field.Text
            Case "Name"
                sql = sql & " WHERE Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%'"
            Case "Gender"
                sql = sql & " WHERE Gender LIKE '%" & SearchGender.Text & "%'"
            Case "Etnicity"
                sql = sql & " WHERE Ethnicity LIKE '%" & SearchEthnicity.Text & "%'"
            Case "SSN"
                sql = sql & " WHERE SNS LIKE '%" & SearchSNS.Text & "%'"
            Case "form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%'"
            Case "Year"
                sql = sql & " WHERE Year LIKE '%" & SearchYear.Text & "%'"
            Case "Dataset"
                sql = sql & " WHERE Dataset LIKE '%" & SearchDataset.Text & "%'"
        End Select

        ds = generateDataset(sql)
        DataGridView1.DataSource = ds
        DataGridView1.Visible = True
        DataGridView1.DataMember = "Student"
    End Sub

    Private Sub Searchbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchName.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Field_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Field.SelectedIndexChanged

        Dim dt As DataTable
        Select Case Field.Text
            Case ""
                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.visible = False
                SearchDataset.visible = False
            Case "Name"
                dt = GenerateCombo("Student", "Name", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Name"


                SearchGender.Visible = False
                SearchName.Visible = True
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
            Case "Gender"
                dt = GenerateCombo("Student", "Gender", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Gender"

                SearchGender.Visible = True
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
            Case "Etnicity"
                dt = GenerateCombo("Student", "Ethnicity", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Ethnicity"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = True
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
            Case "SNS"
                dt = GenerateCombo("Student", "SNS", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "SNS"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = True
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
            Case "Form"
                dt = GenerateCombo("Student", "Form", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Form"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = True
                SearchYear.Visible = False
                SearchDataset.Visible = False
            Case "Year"
                dt = GenerateCombo("Student", "Year", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Year"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = True
                SearchDataset.Visible = False
            Case "Dataset"
                dt = GenerateCombo("Student", "Dataset", False)
                SearchGender.DataSource = dt
                SearchGender.DisplayMember = "Dataset"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = True
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SearchGender.SelectedIndexChanged

    End Sub
End Class


