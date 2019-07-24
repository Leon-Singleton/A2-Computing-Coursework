Imports System.Data.SqlClient
Imports System.Data
Public Class Student_Classes
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'when the main menu link is clicked the follwoing forms are either displayed or closed
        Main_Menu.Show()
        Remove_Student_Class.Close()
        Add_Student_Class.Close()
        Me.Close()
    End Sub
    'This sub is performed when the form initially loads
    Private Sub Student_classes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        DatabaseConnect()
        'the datagrid's visibility is set to false
        Classesgrid.Visible = False
        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addremoveField.SelectedIndexChanged
        'stores dt as a datatable
        Dim dt As DataTable
        wherelabel.Visible = True

        'This case statement selects which textbox or combobox is visible when the corrsponding text value of the field combobox is selected and sets all other textboxes or comboboxes as not visible when a case is selected by the user's mouse click choice
        Select Case addremoveField.Text
            Case ""
                wherelabel.Visible = False

            Case "Teacher Name"
                Namefield.Visible = True
                Subjectfield.Visible = False
                Departmentfield.Visible = False
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Name:"
            Case "Class"
                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = False
                Departmentfield.Visible = False
                Classfield.Visible = True
                Yearfield.Visible = False
                wherelabel.Text = "Class:"
            Case "Subject"
                'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
                dt = GenerateCombo("Subject", "SubjectID, Subject", True)
                'sets the datasource of the combobox
                Subjectfield.DataSource = dt
                'sets the display member of the combobox
                Subjectfield.DisplayMember = "Subject"
                'sets the valuemember of the combobox, so that the selected index of each combobox row is the chronological ID of the valuemember column ID
                Subjectfield.ValueMember = "SubjectID"

                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = True
                Departmentfield.Visible = False
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Subject:"
            Case "Department"
                dt = GenerateCombo("Department", "DepartmentID,Department", True)
                Departmentfield.DataSource = dt
                Departmentfield.DisplayMember = "Department"
                Departmentfield.ValueMember = "Department"

                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = False
                Departmentfield.Visible = True
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Department:"
            Case "Year"
                dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
                Yearfield.DataSource = dt
                Yearfield.DisplayMember = "Year"
                Yearfield.ValueMember = "DatasetID.DatasetID"

                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = False
                Departmentfield.Visible = False
                Classfield.Visible = False
                Yearfield.Visible = True
                wherelabel.Text = "Year:"
        End Select
    End Sub
    'When the search button is clicked the code within the following sub is run
    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        'clears all columns from the Classesgrid
        Classesgrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As New DataSet
        'sets the SQL statement
        sql = "SELECT DISTINCT Class.ClassID, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year, Teacher.Firstname, Teacher.Surname FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID"
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case addremoveField.Text
            Case ""
                sql = sql & " WHERE DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Teacher Name"
                sql = sql & " WHERE Teacher.Firstname LIKE '%" & Namefield.Text & "%' Or Teacher.Surname LIKE '%" & Namefield.Text & "%' and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Year"
                sql = sql & " WHERE DatasetID.Year = '" & Yearfield.Text & "' and DatasetID.DatasetID = '" & moduleDataset & "' ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Department"
                sql = sql & " WHERE Department.Department = '" & Departmentfield.Text & "' and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Subject"
                sql = sql & " WHERE Subject.Subject = '" & Subjectfield.Text & "' and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Class"
                sql = sql & " WHERE Class.ClassGroup LIKE '%" & Classfield.Text & "%' and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Classesgrid.DataSource = ds
        'sets the datagrid as visible
        Classesgrid.Visible = True
        'sets the other datagrdis as not visible
        Studentclassesgrid.Visible = False
        Viewstudentsgrid.Visible = False
        'sets the datamember of the datagrid
        Classesgrid.DataMember = "temp"
        'hides the ClassID column from the user
        Classesgrid.Columns("ClassID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim StudentColumn As New DataGridViewButtonColumn
        With StudentColumn
            'sets the header text of the button column
            .HeaderText = "View Current Students"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "View Students"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        Classesgrid.Columns.Add(StudentColumn)

        Dim Columnview As New DataGridViewButtonColumn
        With Columnview
            .HeaderText = "Add a Student to this Class"
            .Name = "Details"
            .Text = "Add Student"
            .UseColumnTextForButtonValue = True
        End With

        Classesgrid.Columns.Add(Columnview)
        'auto resizes the column widths of the datagrid
        Classesgrid.AutoResizeColumns()
    End Sub
    'when the remove student from class button is clicked, the code within the following sub is run
    Private Sub delete_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Viewstudentsgrid.CellContentClick
        'stores ds as a new dataset
        Dim ds As New DataSet
        'stores the ClassID
        Dim ClassID As String
        'stores the firstname of a student
        Dim fname As String
        'Stores the surname of the student
        Dim sname As String
        'stores the form of the student
        Dim form As String


        If e.ColumnIndex = 8 Then
            Remove_Student_Class.Close()
            'sets the value of these four variables as the value of the cell with the selected column name that is on the same row as the button that has been clicked 
            ClassID = Viewstudentsgrid.Rows(e.RowIndex).Cells("ClassID").Value
            fname = Viewstudentsgrid.Rows(e.RowIndex).Cells("Firstname").Value
            sname = Viewstudentsgrid.Rows(e.RowIndex).Cells("Surname").Value
            form = Viewstudentsgrid.Rows(e.RowIndex).Cells("form").Value

            'sets the following four variables of the remove student class form as the values of their variables found from the datagrid of this form
            Remove_Student_Class.ClassID = ClassID
            Remove_Student_Class.Fname = fname
            Remove_Student_Class.Sname = sname
            Remove_Student_Class.Form = form
            Remove_Student_Class.Show()
        End If

    End Sub
    'this sub runs the following code if one of the two buttons on the classes grid is clicked
    Private Sub Classes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Classesgrid.CellContentClick
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the classID
        Dim ClassID As String

        'if the selected index of the button that is clicked is the seventh column then the following actionis performed
        If e.ColumnIndex = 7 Then
            ClassID = Classesgrid.Rows(e.RowIndex).Cells("ClassID").Value
            'clears the current datagrid column selection
            Viewstudentsgrid.Columns.Clear()
            Classesgrid.Columns.Clear()

            'sets the SQL statement query
            sql = "SELECT Class.ClassID, Student.Firstname, Student.Surname, Student.Form, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN  Subject ON Class.SubjectID = Subject.SubjectID INNER JOIN Department ON Subject.DepartmentID = Department.DepartmentID INNER JOIN Student ON StudentGroup.StudentID = Student.StudentID INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID WHERE Class.ClassID = '" & ClassID & "'  and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Student.Firstname ASC, Student.Surname ASC"

            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")
            'sets the datasource of the datagrid
            Viewstudentsgrid.DataSource = ds
            'sets the following datagrids as either visible or not visible
            Classesgrid.Visible = False
            Studentclassesgrid.Visible = False
            Viewstudentsgrid.Visible = True
            'sets the datamember of the datagrid
            Viewstudentsgrid.DataMember = "temp"
            'makes the ClassID column not visible to the user
            Viewstudentsgrid.Columns("ClassID").Visible = False

            'creates a new variable that stores information for a button column that can be added to the datagrid
            Dim deleteStudentColumn As New DataGridViewButtonColumn
            With deleteStudentColumn
                'sets the header text of the button column
                .HeaderText = "Remove this Student from this class"
                'sets the name of the button column
                .Name = "Details"
                'sets the text displayed on each button of the button column
                .Text = "Remove Student"
                .UseColumnTextForButtonValue = True
            End With

            'adds the button column to the datagrid
            Viewstudentsgrid.Columns.Add(deleteStudentColumn)
            'automatically resizes all column widths in the datagrid
            Viewstudentsgrid.AutoResizeColumns()
        End If

        'if the selected index of the button that is clicked is the eighth column then the following actionis performed
        If e.ColumnIndex = 8 Then
            Add_Student_Class.Close()
            'returns the value of the ClassID that is on the same row as the button clicked and is under the column with the header of classID
            ClassID = Classesgrid.Rows(e.RowIndex).Cells("ClassID").Value

            'sets the ClassID of the add student Class form as the ClassID of this form
            Add_Student_Class.ClassID = ClassID
            Add_Student_Class.Show()
        End If
    End Sub
    'when the text within the studentclassesfield combobox is changed then the code within this sub is run
    Private Sub studentclassesfield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentclassesfield.SelectedIndexChanged
        'stores dt as a datatable
        Dim dt As New DataTable
        'sets the wherelabel as visible to the user
        Wherelabel1.Visible = True

        'This case statement selects which textbox or combobox is visible when the corrsponding text value of the field combobox is selected and sets all other textboxes or comboboxes as not visible when a case is selected by the user's mouse click choice
        Select Case studentclassesfield.Text
            Case ""
                SearchGender.Visible = False
                SearchName.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                Studentclassesgrid.Visible = False
                Wherelabel1.Visible = False
            Case "Name"
                SearchGender.Visible = False
                SearchName.Visible = True
                SearchForm.Visible = False
                SearchYear.Visible = False
                Wherelabel1.Text = "Name:"
            Case "Gender"
                'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
                dt = GenerateCombo("Student", "Gender", False)
                'sets the datasource of the combobox
                SearchGender.DataSource = dt
                'sets the display member of the combobox
                SearchGender.DisplayMember = "Gender"

                SearchGender.Visible = True
                SearchName.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                Wherelabel1.Text = "Gender:"
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
                SearchForm.Visible = True
                SearchYear.Visible = False
                Wherelabel1.Text = "Form:"
            Case "Year"
                dt = GenerateCombo("Student", "Year", False)
                SearchYear.DataSource = dt
                SearchYear.DisplayMember = "Year"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = True
                Wherelabel1.Text = "Year:"
        End Select
    End Sub
    'this sub runs the following code when the search students button is clicked
    Private Sub Searchstudentclasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchstudentclasses.Click
        'clears the current datagrid column selection
        Studentclassesgrid.Columns.Clear()
        'sets the two other datagrids visible state to false
        Classesgrid.Visible = False
        Viewstudentsgrid.Visible = False
        'stores ds as a dataset variable
        Dim ds As DataSet

        'sets the SQL statemnt
        sql = " Select StudentID, Firstname, Surname, Gender, DateOfBirth, Form, Year FROM Student "
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case studentclassesfield.Text
            Case ""
                sql = sql & " WHERE DatasetID = '" & moduleDataset & "'  ORDER BY StudentID ASC"
            Case "Name"
                sql = sql & " WHERE (Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%') and DatasetID = '" & moduleDataset & "'  ORDER BY StudentID ASC "
            Case "Gender"
                sql = sql & " WHERE Gender LIKE '%" & SearchGender.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Year"
                sql = sql & " WHERE Year LIKE '%" & SearchYear.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Student")
        'sets the datasource of the datagrid
        Studentclassesgrid.DataSource = ds
        'sets the datagrid as visible
        Studentclassesgrid.Visible = True
        'sets the datamember of the datagrid
        Studentclassesgrid.DataMember = "Student"
        'hides the StudentID column from the user
        Studentclassesgrid.Columns("StudentID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Column As New DataGridViewButtonColumn
        With Column
            'sets the header text of the button column
            .HeaderText = "View a Students Classes"
            'sets the name of the button column
            .Name = "Details"
            'sets the text of the button column
            .Text = "View Classes"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the studentclasses datagrid
        Studentclassesgrid.Columns.Add(Column)
        'autoresizes all columns in the datagrid
        Studentclassesgrid.AutoResizeColumns()

        'if there are not any rows returned in the datagrid then the user is asked to enter a valid name and the datagrid is not visible
        If (Studentclassesgrid.Rows.Count = 0) Then
            MsgBox("Please enter a valid name")
            Studentclassesgrid.Visible = False
        End If
    End Sub

    Private Sub studentsClasses_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Studentclassesgrid.CellContentClick
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the studentID
        Dim studentid As String
        If e.ColumnIndex = 7 Then
            'the StudentID variable is set to the StudentID of the StudentID that is on the same row as the button that is clicked        
            studentid = Studentclassesgrid.Rows(e.RowIndex).Cells("StudentID").Value
            'clears the current datagrid column selection
            Studentclassesgrid.Columns.Clear()
            'sets the SQL statement
            sql = "SELECT Class.ClassID, Student.Firstname, Student.Surname, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN  Subject ON Class.SubjectID = Subject.SubjectID INNER JOIN Department ON Subject.DepartmentID = Department.DepartmentID INNER JOIN Student ON StudentGroup.StudentID = Student.StudentID INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID WHERE Student.StudentID = '" & studentid & "' ORDER BY Class.ClassID ASC"
            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")
            'sets the datasource of the datagrid
            Studentclassesgrid.DataSource = ds
            'sets the datamember of the datagrid
            Studentclassesgrid.DataMember = "temp"
        End If
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
End Class