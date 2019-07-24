Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.IO
Public Class Student_View
    Public Property AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode
    'This sub is performed when the form initially loads
    Private Sub student_search_view(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable

        'Calls the database connect sub from the module
        DatabaseConnect()
        'sets the screenarea of the form so that it is displayed center screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'studentgrid initially is set to not be visible
        StudentGrid.Visible = False
        addnewdataset = False
        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        'sets the datasource of the combobox
        academicyearcombo.DataSource = dt
        'sets the display member of the combobox
        academicyearcombo.DisplayMember = "Year"
        'sets the value member of the combobox
        academicyearcombo.ValueMember = "DatasetID.DatasetID"
    End Sub
    'When the search button is clicked the code within the following sub is run
    Private Sub Displaystudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Displaystudent.Click
        'clears all columns from the studentgrid
        StudentGrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As DataSet

        'sets the SQL statement
        sql = " Select StudentID, Firstname, Surname, Gender, FSM, SNS, Ethnicity, Attendance, DateOfBirth, Form, Year  FROM Student "
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case "Name"
                sql = sql & " WHERE (Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%') and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC "
            Case "Gender"
                sql = sql & " WHERE Gender LIKE '%" & SearchGender.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Ethnicity"
                sql = sql & " WHERE Ethnicity LIKE '%" & SearchEthnicity.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "SNS"
                sql = sql & " WHERE SNS LIKE '%" & SearchSNS.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Year"
                sql = sql & " WHERE Year LIKE '%" & SearchYear.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Student")
        'sets the datasource of the datagrid
        StudentGrid.DataSource = ds
        'sets the datagrid as visible
        StudentGrid.Visible = True
        'sets the datamember of the datagrid
        StudentGrid.DataMember = "Student"
        'hides the StudentID column from the user
        StudentGrid.Columns("StudentID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Column As New DataGridViewButtonColumn
        With Column
            'sets the header text of the button column
            .HeaderText = "Student Details"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "Edit Details"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        StudentGrid.Columns.Add(Column)
        'auto resizes the column widths of the datagrid
        StudentGrid.AutoResizeColumns()

        'if there is only one row in the datagrid then the entered username is not a valid username and so the following error message is displayed to the user and the grid is not visible
        If (StudentGrid.Rows.Count = 0) Then
            MsgBox("Please enter a valid name")
            StudentGrid.Visible = False
        End If
    End Sub
    'when a button that is part of the button column is clicked, the code within the following sub is run
    Private Sub StudentGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentGrid.CellClick
        'stores the studentID
        Dim StudentId As Integer

        If e.ColumnIndex = 11 Then
            Add_Edit_Student.Close()
            'sets the value of the StudentID as the value of the cell that is on the same row as the Edit Details button that is clicked 
            StudentId = StudentGrid.Rows(e.RowIndex).Cells("StudentID").Value

            'sets the student ID of the edit student form as the studentID of this form
            Add_Edit_Student.StudentID = StudentId
            'show the editstudentform and closes this form
            Add_Edit_Student.Show()
        End If

    End Sub
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Field.SelectedIndexChanged
        'stores dt as a datatable
        Dim dt As New DataTable

        'sets the wherelabel and datagrids as visible to the user
        Displaystudent.Visible = True
        wherelabel.Visible = True

        'This case statement selects which textbox or combobox is visible when the corrsponding text value of the field combobox is selected and sets all other textboxes or comboboxes as not visible when a case is selected by the user's mouse click choice
        Select Case Field.Text
            Case ""
                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                Displaystudent.Visible = False
                wherelabel.Visible = False
            Case "Name"
                SearchGender.Visible = False
                SearchName.Visible = True
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                wherelabel.Text = "Name:"
            Case "Gender"
                'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
                dt = GenerateCombo("Student", "Gender", False)
                'sets the datasource of the combobox
                SearchGender.DataSource = dt
                'sets the display member of the combobox
                SearchGender.DisplayMember = "Gender"

                SearchGender.Visible = True
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                wherelabel.Text = "Gender:"
            Case "Ethnicity"
                dt = GenerateCombo("Student", "Ethnicity", False)
                SearchEthnicity.DataSource = dt
                SearchEthnicity.DisplayMember = "Ethnicity"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = True
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                wherelabel.Text = "Ethnicity:"
            Case "SNS"
                dt = GenerateCombo("Student", "SNS", False)
                SearchSNS.DataSource = dt
                SearchSNS.DisplayMember = "SNS"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = True
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                wherelabel.Text = "SNS:"
            Case "Form"
                'selects the forms based on the user's choice of year
                sql = "SELECT Distinct Form FROM Student WHERE DatasetID = '" & moduleDataset & "'"
                'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
                Using comm As SqlCommand = New SqlCommand(sql, con)
                    'stores a SQL dataadareader which can read the contents of the sql query from the database
                    Dim rs As SqlDataReader = comm.ExecuteReader
                    'stores a datatable
                    'the datatable is filled with the values that the datareader reads
                    dt.Load(rs)

                    'sets the displaymemeber of the combobox
                    SearchForm.DisplayMember = "Form"
                    'sets the datasource of the combobox
                    SearchForm.DataSource = dt
                End Using

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = True
                SearchYear.Visible = False
                SearchDataset.Visible = False
                wherelabel.Text = "Form:"
            Case "Year"
                dt = GenerateCombo("Student", "Year", False)
                SearchYear.DataSource = dt
                SearchYear.DisplayMember = "Year"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = True
                SearchDataset.Visible = False
                wherelabel.Text = "Year:"
        End Select
    End Sub
    'When the main menu label is clicked the main menu form is showed to the user and this form closes
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        Main_Menu.Show()
        Add_Edit_Student.Close()
        Me.Close()
    End Sub
    'deals with the print form button
    Private Sub printbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printbutton.Click
        'sets the printer settings to default
        PrintForm.PrinterSettings = PrintDialog.PrinterSettings
        If PrintDialog.ShowDialog() = DialogResult.OK Then
            'allows the user to change print settings
            PrintForm.PrinterSettings = PrintDialog.PrinterSettings
            'changes the orientation of the printed document to landscape
            Me.PrintForm.PrinterSettings.DefaultPageSettings.Landscape = True
            'refreshes the form so that the printdialog is not printed along with the form
            Me.Refresh()
            'prints the current form
            Me.PrintForm.Print()
            'Percentageschart.Printing.Print(True)
        End If
    End Sub
    'this sub handles the add student button
    Private Sub Addstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addstudent.Click
        'opens the add student form
        Add_Edit_Student.Show()
    End Sub
    'this sub is resposible for importing a CSV file and writing its contents into the database
    Private Sub importcsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles importcsv.Click
        'checks whether the user has selected a value in the academicyearcombo box
        If academicyearcombo.SelectedValue <> "0" Then
            Dim dlg As New OpenFileDialog
            Dim ds As New DataSet
            Dim path As String = "My Filename"
            Dim path1 As String
            Dim dt As New DataTable
            Dim dt1 As New DataTable
            Dim griddt As New DataTable
            Dim rowadded As String
            Dim da As New SqlDataAdapter
            'stores a StudentID that will be used as the Studentid to be inserted in the database
            Dim Sid As Integer

            'filters the file selection the user can attempt to open in the open dialog box
            dlg.Filter = "CSV Files|*.csv|Any Files|*.*"

            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                'sets the file path of the CSV file the user wants to import as the location they have selected from theopen file dialog
                path = System.IO.Path.GetDirectoryName(path)
                path = dlg.FileName
                path1 = dlg.FileName
                path = System.IO.Path.GetDirectoryName(path)
                path1 = System.IO.Path.GetFileName(path1)


                'sets a connection string up between the system and the selected CSV file
                Dim strConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Extended Properties=Text;"
                Dim conn As New OleDbConnection(strConnString)
                'opens the connection
                conn.Open()

                'selects all contents from the CSV file using the above connection string
                Dim cmd As New OleDbCommand("SELECT * FROM [" & path1 & "]", conn)
                Dim da1 As New OleDbDataAdapter()

                'fills the griddt datatable with the selected contents of the CSV file
                da1.SelectCommand = cmd
                da1.Fill(griddt)
                'disposes of the data adapter and closes the connection between the system and the CSV file
                da1.Dispose()
                conn.Close()

                'adds a new column to the griddt datagrid
                griddt.Columns.Add("Inserted (True/False)")

                Try
                    Dim x As Integer = 0
                    Dim csvrows As Integer
                    'stores a varaible as the nubmer of rows in the griddt datagrid
                    csvrows = griddt.Rows.Count

                    'sets the SQL satatement
                    sql = "SELECT TOP 1 StudentID FROM Student ORDER BY StudentID DESC"
                    'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
                    Dim cmmd As New SqlCommand(sql, con)
                    'sets the dataadapter select command as cmmd
                    da.SelectCommand = cmmd
                    'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
                    da.Fill(ds, "Student")
                    'The StudentID is then set as the value of the highest StudentID found from the Query and then incremented by 1, the SQL statement takes into account deleting teachers so that inserting a Student will use the first available StudentiD
                    Sid = ds.Tables(0).Rows(0).Item("StudentID").ToString() + 1

                    While (x <= csvrows - 1)
                        'stores variables as the nubmer of rows before and after inserting a new record
                        Dim originaldatabaserows As Integer
                        Dim afterinsertdatabaserows As Integer

                        'sets the SQL statemnt
                        sql = "SELECT * From Student"
                        Dim sqlcommand As New SqlCommand(sql, con)
                        'the datadapter then uses this SQL command to Query the database
                        da.SelectCommand = sqlcommand
                        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
                        da.Fill(ds, "temp")
                        'the datatble variable is then set to the table result of the dataset variable
                        dt = ds.Tables("temp")
                        'the original rows variableis set as the number of rows returned
                        originaldatabaserows = dt.Rows.Count

                        'executes an insert statement using the following parameters, which depend on the row index x within the griddt datatable, the dataset selected by the user and the studentID.
                        sql = "INSERT INTO Student VALUES(@SID, @Fname, @Sname, @Gender, @FSM, @SNS, @Ethnicity, @Attendance, @DOB, @Form, @Year, @DatasetID) SET ANSI_WARNINGS  OFF"
                        Using cmd1 = New SqlCommand(sql, con)
                            cmd1.Parameters.AddWithValue("SID", Sid)
                            cmd1.Parameters.AddWithValue("Fname", griddt.Rows(x)(0))
                            cmd1.Parameters.AddWithValue("Sname", griddt.Rows(x)(1))
                            cmd1.Parameters.AddWithValue("Gender", griddt.Rows(x)(2))
                            cmd1.Parameters.AddWithValue("FSM", griddt.Rows(x)(3))
                            cmd1.Parameters.AddWithValue("SNS", griddt.Rows(x)(4))
                            cmd1.Parameters.AddWithValue("Ethnicity", griddt.Rows(x)(5))
                            cmd1.Parameters.AddWithValue("Attendance", dt.Rows(x)(6))
                            cmd1.Parameters.AddWithValue("DOB", griddt.Rows(x)(7))
                            cmd1.Parameters.AddWithValue("Form", griddt.Rows(x)(8))
                            cmd1.Parameters.AddWithValue("Year", griddt.Rows(x)(9))
                            cmd1.Parameters.AddWithValue("DatasetID", academicyearcombo.SelectedValue)
                            'exectues the insert query
                            cmd1.ExecuteNonQuery()
                        End Using

                        'sets the after insert variable as the new number of rows
                        sql = "SELECT * From Student"
                        Dim sqlcommand2 As New SqlCommand(sql, con)
                        da.SelectCommand = sqlcommand
                        da.Fill(ds, "temp1")
                        dt1 = ds.Tables("temp1")
                        afterinsertdatabaserows = dt1.Rows.Count

                        'sets the string property of the rowadded variable if the result of the following calculation equals 1 + the row index
                        If (afterinsertdatabaserows) - (originaldatabaserows) = (1 + x) Then
                            rowadded = "True"
                        Else
                            rowadded = "False"
                        End If

                        'adds this result to the Griddt datatable
                        griddt.Rows(x)("Inserted (True/False)") = rowadded

                        'increments the studentID and row indexes by 1
                        x = x + 1
                        Sid = Sid + 1
                    End While
                    'informs the user the insert has been successful
                    MsgBox("Insert Data Successful", MsgBoxStyle.Information, "Data Upload")
                    dt = Nothing
                    'catches any errors during an insert and displays this to the user

                    'sets the datasource of the datagrid
                    StudentGrid.DataSource = griddt
                    'sets the datagrid as visible
                    StudentGrid.Visible = True
                    'sets the datamember of the datagrid
                    StudentGrid.DataMember = ""
                    'auto resizes all columns in the datagridview
                    StudentGrid.AutoResizeColumns()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub addnewdataset_Click(sender As System.Object, e As System.EventArgs) Handles newdataset.Click
        addnewdataset = True
        Developer_Features.Show()
        Me.Close()
    End Sub
End Class