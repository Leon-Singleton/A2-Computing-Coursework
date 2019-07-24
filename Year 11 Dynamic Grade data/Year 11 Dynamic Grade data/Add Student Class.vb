'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Add_Student_Class
    'sets the variable that is recieved from the StudentClass form as a private variable which can be used in any sub within this class
    Private _ClassID As Integer
    'stores a studentID variable which can only be used within this class
    Dim studentid As Integer
    'creates a property of the variable that is being recieved
    Public Property ClassID() As Integer
        Get
            'gets the variable from the form that has been specified, in this case the grade form
            Return _ClassID
        End Get
        Set(ByVal value As Integer)
            'sets the variable that has been recieved by the get statement as the equivalent variable that will be used in this form
            _ClassID = value
        End Set
    End Property
    'this sub runs when the main menu link is clicked by the user
    Private Sub MainMenu_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'the follwoing forms either display or close
        Main_Menu.Show()
        Student_Classes.Close()
        Remove_Student_Class.Close()
        Myclasses.Close()
        Me.Close()
    End Sub
    'this sub runs when the Student Classes link is clicked by the user
    Private Sub Classeslink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Classeslink.LinkClicked
        'the follwoing forms either display or close
        Student_Classes.Show()
        Me.Close()
    End Sub
    'this sub runs when the form is initially loaded
    Private Sub Addstudentclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'clears the curernt selection of columns in the datagrid
        Currentclassgrid.Columns.Clear()
        'stores ds as a dataset
        Dim ds As New DataSet

        'sets the SQL statement which queries the database
        sql = "SELECT DISTINCT Class.ClassGroup, Subject.Subject, DatasetID.Year FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID WHERE CLass.ClassID = " & ClassID & ""
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Currentclassgrid.DataSource = ds
        'sets the datagrid as visible
        Currentclassgrid.Visible = True
        'sets the datamember of the datagrid
        Currentclassgrid.DataMember = "temp"
        'auto resizes the columns within the datagrid
        Currentclassgrid.AutoResizeColumns()

    End Sub
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Field.SelectedIndexChanged
        'stores dt as a datatable

        'sets the wherelabel as visible to the user
        wherelabel.Visible = True

        'This case statement selects which textbox or combobox is visible when the corrsponding text value of the field combobox is selected and sets all other textboxes or comboboxes as not visible when a case is selected by the user's mouse click choice
        Select Case Field.Text
            Case ""
                SearchName.Visible = False
                SearchForm.Visible = False
                Displaystudent.Visible = False
                wherelabel.Visible = False
            Case "Name"
                SearchName.Visible = True
                SearchForm.Visible = False
                Displaystudent.Visible = True
                wherelabel.Text = "Name:"
            Case "Form"

                'selects the forms based on the user's choice of year
                sql = "SELECT Distinct Form FROM Student WHERE DatasetID = '" & moduleDataset & "' "
                'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
                Using comm As SqlCommand = New SqlCommand(sql, con)
                    'stores a SQL dataadareader which can read the contents of the sql query from the database
                    Dim rs As SqlDataReader = comm.ExecuteReader
                    'stores a datatable
                    Dim dt As DataTable = New DataTable
                    'the datatable is filled with the values that the datareader reads
                    dt.Load(rs)

                    'sets the displaymemeber of the combobox
                    SearchForm.DisplayMember = "Form"
                    'sets the datasource of the combobox
                    SearchForm.DataSource = dt
                End Using

                SearchName.Visible = False
                SearchForm.Visible = True

                Displaystudent.Visible = True
                wherelabel.Text = "Form:"
        End Select
    End Sub
    'this sub runs when the search button is clicked by the user
    Private Sub Displaystudent_Click(sender As System.Object, e As System.EventArgs) Handles Displaystudent.Click
        'clears the current selection of columns in the studentgrid
        Studentdisplaygrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As DataSet

        'sets the SQL statement
        sql = " Select Firstname, Surname, Form, Year FROM Student "
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case "Name"
                sql = sql & " WHERE (Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%') and DatasetID = '" & moduleDataset & "'  ORDER BY StudentID ASC "
            Case "Form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Year"
                sql = sql & " WHERE Year LIKE '%" & SearchYear.Text & "%' and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Student")
        'sets the datasrouce of the datagrid
        Studentdisplaygrid.DataSource = ds
        'sets the following datagrids as either visible or false
        addstudentgroup.Visible = False
        Studentdisplaygrid.Visible = True
        'sets the datamember of the datagrid
        Studentdisplaygrid.DataMember = "Student"

        'if there is only one row in the datagrid then the entered username is not a valid username and so the following error message is displayed to the user and the grid is not visible
        If (Studentdisplaygrid.Rows.Count = 0) Then
            MsgBox("Please enter a valid name")
            Studentdisplaygrid.Visible = False
        End If

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim StudentColumn As New DataGridViewButtonColumn
        With StudentColumn
            'sets the header text of the button column
            .HeaderText = "Select Student"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "Select"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        Studentdisplaygrid.Columns.Add(StudentColumn)
        'auto resizes the column widths of the datagrid
        Studentdisplaygrid.AutoResizeColumns()
    End Sub
    'this function returns a true or false state depending on whether the student selected is a part of the current selected class
    Public Function validatestudentclass(ByVal studentid As Integer) As Boolean
        'stores cmd as a sqlcommand()
        Dim Cmd As New SqlCommand
        'stores da as a SQL dataadapter
        Dim da As New SqlDataAdapter
        'stores dt as a datatable
        Dim dt As New DataTable
        'stores ds as a dataset
        Dim ds As New DataSet
        'connects to the SQL database by calling the DatabaseConnect from the module
        Call DatabaseConnect()

        'sets the SQL statemnt
        sql = "Select  * FROM StudentGroup WHERE StudentID = '" & studentid & "' AND ClassID = '" & ClassID & "' "
        'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'the datadapter then uses this SQL command to Query the database
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "temp")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("temp")
        'if the nubmer of rows in the datatable is one or more then the IDexists state is set to false otherwise it is set to true
        If dt.Rows.Count >= 1 Then
            validatestudentclass = False
        Else
            validatestudentclass = True
        End If
    End Function
    'this sub runs when one of the buttons that is part of the button column on the datagrid is clicked
    Private Sub StudentGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Studentdisplaygrid.CellClick
        'stores variables to identify the student
        Dim firstname As String
        Dim surname As String
        Dim form As String
        Dim year As String

        Dim Cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        'if the cell clicked is of index 4 then the following code runs
        If e.ColumnIndex = 4 Then
            'the student's information variables are set as their corrsponding values under their respective headings on the same row as the button clicked
            firstname = Studentdisplaygrid.Rows(e.RowIndex).Cells("Firstname").Value
            surname = Studentdisplaygrid.Rows(e.RowIndex).Cells("Surname").Value
            form = Studentdisplaygrid.Rows(e.RowIndex).Cells("Form").Value
            year = Studentdisplaygrid.Rows(e.RowIndex).Cells("Year").Value

            'this block of code sets the StudentID of the record that the user wants to add based on the values of the student information variables
            sql = "Select DISTINCT StudentID FROM Student WHERE Firstname = '" & firstname & "' AND Surname = '" & surname & "' AND Form = '" & form & "' AND Year = '" & year & "' "
            Dim cmmd As New SqlCommand(sql, con)
            da.SelectCommand = cmmd
            da.Fill(ds, "Student")
            dt = ds.Tables("Student")
            studentid = ds.Tables(0).Rows(0).Item("StudentID").ToString()

            'if the student is not a part of the current selected class then the following code runs
            If validatestudentclass(studentid) = True Then

                'the values of the textbox fields are set as there respective variables
                Firstnamefield.Text = firstname
                Surnamefield.Text = surname
                Formfield.Text = form
                Yearfield.Text = year

                'the datagrid is set to be no longer visible and the add group becomes visible
                addstudentgroup.Visible = True
                Studentdisplaygrid.Visible = False
            Else
                'if the student is in the currently selected class then the following error message is displayed and nothing happens
                MsgBox("That Student is already in the Selected Class", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If

        End If

    End Sub
    'this sub runs when the add button is clicked by the user
    Private Sub addstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstudent.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        'stores the studentgroupid of the record that will be inserted
        Dim StudentGroupID As Integer

        'sets the SQL satatement
        sql = "Select TOP 1 StudentGroupID FROM StudentGroup ORDER BY StudentGroupID DESC"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "studentgroup")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("studentgroup")
        'The StudentgroupID is then set as the value of the highest studentgroupID found from the Query and then incremented by 1, the SQL statement takes into account removing students from classes so that inserting a record will use the first available studentgroupID
        StudentGroupID = ds.Tables(0).Rows(0).Item("StudentGroupID").ToString() + 1

        DatabaseConnect()
        'sets the SQL statement
        sql = "INSERT INTO StudentGroup (StudentGroupID, ClassID, StudentID) VALUES (@StudentGroupID, @ClassID, @StudentID)"
        'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
        Using cmd = New SqlCommand(sql, con)
            'sets the parameters of the vlues to be inserted
            cmd.Parameters.AddWithValue("StudentGroupID", StudentGroupID)
            cmd.Parameters.AddWithValue("ClassID", ClassID)
            cmd.Parameters.AddWithValue("StudentID", studentid)
            cmd.ExecuteNonQuery()
        End Using
        'closes the database connection
        con.Close()
        'notifies the user with the appropriate message
        MsgBox("Record Added", MsgBoxStyle.Information)
        'closes this form
        Me.Close()

    End Sub
End Class