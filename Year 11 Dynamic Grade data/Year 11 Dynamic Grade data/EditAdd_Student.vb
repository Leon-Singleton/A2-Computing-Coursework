'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Add_Edit_Student
    'sets the variables that are recieved from the student form as private variables which can be used in any sub within this class
    Private _StudentID As Integer
    Dim SID As Integer

    'sets the values of several variables that can be used to check the values of these variables later in the code, they can be used in any sub
    Dim Fnamecheck As String
    Dim Snamecheck As String
    Dim Gendercheck As String
    Dim Ethnicitycheck As String
    Dim attendancheck As String
    Dim DOBcheck As String
    Dim SNScheck As String
    Dim FSMcheck As String
    Dim Formcheck As String
    Dim Yearcheck As String
    Dim DatasetCheck As String
    'creates a property of the variable that is being recieved
    Public Property StudentID() As Integer
        Get
            'gets the variable from the form that has been specified, in this case the student form
            Return _StudentID
        End Get
        Set(ByVal value As Integer)
            'sets the variable that has been recieved by the get statement as the equivalent variable that will be used in this form
            _StudentID = value
        End Set
    End Property
    'This sub runs when the Edit Student form is initially loaded
    Private Sub student_search_view(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'calls database connect from the public module
        DatabaseConnect()
        'stores dt as a datatable
        Dim dt As DataTable

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("Student", "Gender", True)
        'sets the datasource of the combobox
        Gender.DataSource = dt
        'sets the display member of the combobox
        Gender.DisplayMember = "Gender"

        dt = GenerateCombo("Student", "FSM", False)
        Free_School_Meals.DataSource = dt
        Free_School_Meals.DisplayMember = "FSM"

        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        Dataset.DataSource = dt
        Dataset.DisplayMember = "Year"
        Dataset.ValueMember = "DatasetID.DatasetID"
        'stores ds as a dataset
        Dim ds As DataSet

        'If there is a Student ID then the following is altered
        If StudentID Then
            'all text properties are changed to edit rather than add

            Datasetlabel.Visible = False
            Dataset.Visible = False
            Add_Edit.Text = "Edit"
            Add_Edit.Visible = True
            Delete.Visible = True
            editlabel.Text = "Edit Student"
            Adddetail.Text = "Edit Student Details"
            DatasetCheck = "aa"
            Dataset.Text = "aa"
            Me.Text = "Edit Student"
            'the dataset is set as the returned dataset after passing StudentID in to the studenteditvalues function in the module
            ds = StudentEditValues(StudentID)
            'the following variables are set to their equivalent values under their respective headings in the dataset
            Fnamecheck = ds.Tables(0).Rows(0).Item("Firstname").ToString()
            Snamecheck = ds.Tables(0).Rows(0).Item("Surname").ToString()
            Formcheck = ds.Tables(0).Rows(0).Item("Form").ToString()
            Gendercheck = ds.Tables(0).Rows(0).Item("Gender").ToString()
            Ethnicitycheck = ds.Tables(0).Rows(0).Item("Ethnicity").ToString()
            attendancheck = ds.Tables(0).Rows(0).Item("Attendance").ToString()
            SNScheck = ds.Tables(0).Rows(0).Item("SNS").ToString()
            Yearcheck = ds.Tables(0).Rows(0).Item("Year").ToString()
            FSMcheck = ds.Tables(0).Rows(0).Item("FSM").ToString()
            'sets the format for the date of birth textbox
            DateOfBirth.CustomFormat = "yyyy-MM-dd"
            DOBcheck = ds.Tables(0).Rows(0).Item("DateOfBirth").ToString()

            'sets the text of the textboxes as the values of the varaibles above that have been set
            Firstname.Text = Fnamecheck
            Surname.Text = Snamecheck
            Form.Text = Formcheck
            Ethnicity.Text = Ethnicitycheck
            Gender.Text = Gendercheck
            Attendance.Text = attendancheck
            SNS.Text = SNScheck
            Free_School_Meals.Text = FSMcheck
            Year.Text = Yearcheck
            Dataset.Text = DatasetCheck
            DateOfBirth.Text = DOBcheck
        End If
    End Sub
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function editedcheck() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        editedcheck = True

        'but if any of the following textbox fields values are not the same as their respective stored variables then the functions state is set to false
        If Firstname.Text <> Fnamecheck Then
            editedcheck = False
        End If
        If Surname.Text <> Snamecheck Then
            editedcheck = False
        End If
        If Gender.Text <> Gendercheck Then
            editedcheck = False
        End If
        If Ethnicity.Text <> Ethnicitycheck Then
            editedcheck = False
        End If
        If Attendance.Text <> attendancheck Then
            editedcheck = False
        End If
        If Free_School_Meals.Text <> FSMcheck Then
            editedcheck = False
        End If
        If SNS.Text <> SNScheck Then
            editedcheck = False
        End If
        If Form.Text <> Formcheck Then
            editedcheck = False
        End If
        If Year.Text <> Yearcheck Then
            editedcheck = False
        End If
    End Function
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidate = True

        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Firstname.Text = "" Then
            Firstname.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Firstname.BackColor = Color.White
        End If
        If Surname.Text = "" Then
            Surname.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Surname.BackColor = Color.White
        End If
        If Gender.Text = "" Then
            Gender.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Gender.BackColor = Color.White
        End If
        If Ethnicity.Text = "" Then
            Ethnicity.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Ethnicity.BackColor = Color.White
        End If
        If Attendance.Text = "" Then
            Attendance.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Attendance.BackColor = Color.White
        End If
        If SNS.Text = "" Then
            SNS.BackColor = Color.Salmon
            txtvalidate = False
        Else
            SNS.BackColor = Color.White
        End If
        If Free_School_Meals.Text = "" Then
            Free_School_Meals.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Free_School_Meals.BackColor = Color.White
        End If
        If Form.Text = "" Then
            Form.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Form.BackColor = Color.White
        End If
        If Year.Text = "" Then
            Year.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Year.BackColor = Color.White
        End If
        If Dataset.Text = "" Then
            Dataset.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Dataset.BackColor = Color.White
        End If
    End Function
    'this function returns a true or false state depending on whether the TeacherID exists
    Public Function IDexists(ByVal studentID As String) As Boolean
        'stores cmd as a sqlcommand
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
        sql = "Select * from Student where StudentID = " & studentID & ""
        'sets the conncection path as the connectionstring of con from the module
        Cmd.Connection = con
        'sets the command statement as the SQL statement
        Cmd.CommandText = sql
        'the datadapter then uses this SQL command to Query the database
        da.SelectCommand = Cmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Student")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Student")
        'if the nubmer of rows in the datatable is one or more then the IDexists state is set to true otherwise it is set to false
        If dt.Rows.Count >= 1 Then
            IDexists = True
        Else
            IDexists = False
        End If
    End Function
    'this function returns a true or false state depending on whether the row exists in the database, and works in a similar mannar as the function seen above
    Public Function rowexists() As Boolean
        Dim Cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        Call DatabaseConnect()
        sql = "SELECT DISTINCT Student.Gender, Student.Attendance, Student.Ethnicity, Student.Firstname, Student.Surname FROM Student WHERE Student.Firstname = '" & Firstname.Text & "' AND Student.Surname = '" & Surname.Text & "' AND Student.Gender = '" & Gender.Text & "' AND Student.Ethnicity = '" & Ethnicity.Text & "' AND Student.Attendance = '" & Attendance.Text & "';"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "temp")
        dt = ds.Tables("temp")
        If dt.Rows.Count >= 1 Then
            rowexists = True
        Else
            rowexists = False
        End If
    End Function
    'this sub runs when the add_edit button is clicked by the user
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Edit.Click

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        'stores a StudentID that will be used as the teacherID to be inserted in the database
        Dim Sid As Integer
        'sets the SQL satatement
        sql = "SELECT TOP 1 StudentID FROM Student ORDER BY StudentID DESC"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Student")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Student")
        'The StudentID is then set as the value of the highest StudentID found from the Query and then incremented by 1, the SQL statement takes into account deleting teachers so that inserting a Student will use the first available StudentiD
        Sid = ds.Tables(0).Rows(0).Item("StudentID").ToString() + 1


        DatabaseConnect()
        'if the textboxes have text and have been validated the program continues
        If txtvalidate() = True Then
            'if the StudentID does not already exist then the program continues with an insert statement
            If IDexists(StudentID) = False Then
                'sets the SQL statement
                sql = "INSERT INTO STUDENT(StudentID, Firstname, Surname, Gender, FSM, SNS, Ethnicity, Attendance, DateOfBirth, Form, Year, DatasetID) VALUES (@StudentID, @Fname, @Sname, @Gender, @Meals, @SNS, @Ethnicity, @Attendance, @Birth, @Form, @year, @Dataset)"
                'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("Fname", Firstname.Text)
                    cmd.Parameters.AddWithValue("Sname", Surname.Text)
                    cmd.Parameters.AddWithValue("Gender", Gender.Text)
                    cmd.Parameters.AddWithValue("Meals", Free_School_Meals.Text)
                    cmd.Parameters.AddWithValue("SNS", SNS.Text)
                    cmd.Parameters.AddWithValue("Ethnicity", Ethnicity.Text)
                    cmd.Parameters.AddWithValue("Attendance", Attendance.Text)
                    cmd.Parameters.AddWithValue("Birth", DateOfBirth.Text)
                    cmd.Parameters.AddWithValue("Form", Form.Text)
                    cmd.Parameters.AddWithValue("Year", Year.Text)
                    cmd.Parameters.AddWithValue("Dataset", Dataset.SelectedValue)
                    cmd.Parameters.AddWithValue("StudentID", Sid)
                    'executes the SQL command
                    cmd.ExecuteNonQuery()
                End Using
                'closes the database connection
                con.Close()
                'notifies the user with the appropriate message
                MsgBox("Record Added to Database", MsgBoxStyle.Information)
                'closes this form and shows the Student view form
                Student_View.Show()
                Me.Close()
            Else
                sql = "UPDATE Student SET  Firstname = @Fname, Surname = @Sname, Gender = @Gender, FSM = @Meals, SNS = @SNS, Ethnicity = @Ethnicity, Attendance = @Attendance, DateOfBirth = @Birth, Form = @Form, Year = @Year WHERE StudentID = " & StudentID & ";"
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("Fname", Firstname.Text)
                    cmd.Parameters.AddWithValue("Sname", Surname.Text)
                    cmd.Parameters.AddWithValue("Gender", Gender.Text)
                    cmd.Parameters.AddWithValue("Meals", Free_School_Meals.Text)
                    cmd.Parameters.AddWithValue("SNS", SNS.Text)
                    cmd.Parameters.AddWithValue("Ethnicity", Ethnicity.Text)
                    cmd.Parameters.AddWithValue("Attendance", Attendance.Text)
                    cmd.Parameters.AddWithValue("Birth", DateOfBirth.Text)
                    cmd.Parameters.AddWithValue("Form", Form.Text)
                    cmd.Parameters.AddWithValue("Year", Year.Text)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Updated", MsgBoxStyle.Information)
            End If
        Else
            'if the textvalidate has been returned as false then the following error message displays to the user
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the delete button is clicked and works in a similar manner to the code in the above sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        DatabaseConnect()
        'checks if the record that the user wants to delete exists in the database
        If rowexists() = True Then
            'this block of code sets the StudentID of the record that the user wants to delete based on the values of the firstname and surname textboxes
            sql = "Select * FROM Student WHERE Firstname = '" & Firstname.Text & "' AND Surname = '" & Surname.Text & "' "
            Dim cmmd As New SqlCommand(sql, con)
            da.SelectCommand = cmmd
            da.Fill(ds, "Student")
            dt = ds.Tables("Student")
            SID = ds.Tables(0).Rows(0).Item("StudentID").ToString()
            'provides a yes/no dialog box asking the user if they really want to delete the record
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the answer is yes then the following code deletes the record from the database using the SQL statement below
            If result = DialogResult.Yes Then
                sql = "DELETE FROM Student WHERE Student.StudentID = '" & SID & "';"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                Student_View.Show()
                Me.Close()
                'but if the answer is no nothing happens
            ElseIf result = DialogResult.No Then
            End If
        Else
            ' if the record that the user wants to delete does not exist in the database, the following message is displayed
            MsgBox("The Entered Student does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the Teacher link is clicked
    Private Sub Student_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Student.LinkClicked
        'the following forms either display or close if edited check is true
        If editedcheck() = True Then
            Student_View.Show()
            Me.Close()
            'if edited check is not true then a dialog message dsiplays to the user with a yes/no option
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms either display or close
            If result = DialogResult.Yes Then
                Student_View.Show()
                Me.Close()
                'if the user clicks no then nothing happens
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'this sub runs when the main menu link is clicked and functions in the same mannar as the teacher link above
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        If editedcheck() = True Then
            Main_Menu.Show()
            Student_View.Close()
            Me.Close()
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                Student_View.Close()
                Me.Close()
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
   

End Class