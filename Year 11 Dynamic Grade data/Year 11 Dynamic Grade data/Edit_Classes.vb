'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Edit_Classes
    'sets the variable that is recieved from the Grade form as a private variable which can be used in any sub within this class
    Private _ClassID As Integer
    'stores two seperate TeacherID variables within this calss
    Dim TeacherID As Integer
    Dim TID As Integer

    'sets the values of several variables that can be used to check the values of these variables later in the code, they can be used in any sub
    Dim Fnamecheck As String
    Dim Snamecheck As String
    Dim Classgroupcheck As String
    Dim Subjectcheck As String
    Dim Yearcheck As String
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
    'this sub runs when the Teacher classes link is clicked
    Private Sub Classeslink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Classeslink.LinkClicked
        'the following forms either display or close if edited check is true
        If editedcheck() Then
            Teacher_Classes.Show()
            Me.Close()
        ElseIf editedcheck() = False Then
            'if edited check is not true then a dialog message dsiplays to the user with a yes/no option
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms either display or close
            If result = DialogResult.Yes Then
                Teacher_Classes.Show()
                Me.Close()
                'if the user clicks no then nothing happens
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'this sub runs when the main menu link is clicked and functions in the same mannar as the teacher link above
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        If editedcheck() Then
            Teacher_Classes.Close()
            Me.Close()
            Main_Menu.Show()
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Teacher_Classes.Close()
                Me.Close()
                Main_Menu.Show()
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'This sub runs when the Edit classes form is initially loaded
    Private Sub Edit_classes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'calls database connect from the public module
        DatabaseConnect()
        'stores dt as a datatable
        Dim dt As DataTable
        'stores ds as a dataset
        Dim ds As DataSet

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        'sets the datasource of the combobox
        Yearfield.DataSource = dt
        'sets the display member of the combobox
        Yearfield.DisplayMember = "Year"
        'sets the index value of each item in the Gradetype combobox to match their corresponding ID's
        Yearfield.ValueMember = "DatasetID.DatasetID"

        dt = GenerateCombo("Subject", "SubjectID, Subject", True)
        Subjectfield.DataSource = dt
        Subjectfield.DisplayMember = "Subject"
        Subjectfield.ValueMember = "SubjectID"

        ds = Editclassvalues(ClassID)
        Fnamecheck = ds.Tables(0).Rows(0).Item("Firstname").ToString()
        Snamecheck = ds.Tables(0).Rows(0).Item("Surname").ToString()
        Classgroupcheck = ds.Tables(0).Rows(0).Item("ClassGroup").ToString()
        Subjectcheck = ds.Tables(0).Rows(0).Item("Subject").ToString()
        Yearcheck = ds.Tables(0).Rows(0).Item("Year").ToString()

        Firstnamefield.Text = Fnamecheck
        Surnamefield.Text = Snamecheck
        Subjectfield.Text = Subjectcheck
        Classgroupfield.Text = Classgroupcheck
        Yearfield.Text = Yearcheck

    End Sub
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function editedcheck() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        editedcheck = True
        'but if any of the following textbox fields values are not the same as their respective stored variables then the functions state is set to false
        If Firstnamefield.Text <> Fnamecheck Then
            editedcheck = False
        End If
        If Surnamefield.Text <> Snamecheck Then
            editedcheck = False
        End If
        If Subjectfield.Text <> Subjectcheck Then
            editedcheck = False
        End If
        If Classgroupfield.Text <> Classgroupcheck Then
            editedcheck = False
        End If
        If Yearfield.Text <> Yearcheck Then
            editedcheck = False
        End If
    End Function
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Private Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidate = True

        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Firstnamefield.Text = "" Then
            Firstnamefield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Firstnamefield.BackColor = Color.White
        End If
        If Surnamefield.Text = "" Then
            Surnamefield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Surnamefield.BackColor = Color.White
        End If
        If Classgroupfield.Text = "" Then
            Classgroupfield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Classgroupfield.BackColor = Color.White
        End If
        If Subjectfield.Text = "" Then
            Subjectfield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Subjectfield.BackColor = Color.White
        End If
        If Yearfield.Text = "" Then
            Yearfield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Yearfield.BackColor = Color.White
        End If

    End Function
    'this function returns a true or false state depending on whether the Teacher name exists
    Public Function nameexists() As Boolean
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
        sql = "Select * FROM Teacher WHERE Firstname = '" & Firstnamefield.Text & "' AND Surname = '" & Surnamefield.Text & "'"
        'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'the datadapter then uses this SQL command to Query the database
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Teacher")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Teacher")
        'if the nubmer of rows in the datatable is one or more then the IDexists state is set to true otherwise it is set to false
        If dt.Rows.Count >= 1 Then
            nameexists = True
            TID = ds.Tables(0).Rows(0).Item("TeacherID").ToString()
        Else
            nameexists = False
        End If
    End Function
    'this function returns a true or false state depending on whether the row exists in the database, and works in a similar mannar as the function seen above
    Public Function rowexists() As Boolean
        Dim Cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Dim ds As New DataSet
        Call DatabaseConnect()
        sql = "SELECT DISTINCT Class.ClassID, Teacher.Firstname, Teacher.Surname, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID WHERE Teacher.Firstname = '" & Firstnamefield.Text & "' AND Teacher.Surname = '" & Surnamefield.Text & "' AND Class.SubjectID = '" & Subjectfield.SelectedValue & "' AND Class.DatasetID = '" & Yearfield.SelectedValue & "' AND Class.ClassGroup = '" & Classgroupfield.Text & "'"
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
    'this sub runs when the edit button is clicked by the user
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        DatabaseConnect()

        'if the textboxes on the form are all not blank then the code continues
        If txtvalidate() = True Then
            ''If the TeacherName exists then the code continues
            If nameexists() = True Then
                'sets the SQL statement
                sql = "UPDATE Class SET Class.TeacherID = @TeacherID, Class.ClassGroup = @ClassG, Class.SubjectID = @Subject, Class.DatasetID = @Year WHERE Class.ClassID = '" & ClassID & "'"
                'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("TeacherID", TID)
                    cmd.Parameters.AddWithValue("Year", Yearfield.SelectedValue)
                    cmd.Parameters.AddWithValue("Subject", Subjectfield.SelectedValue)
                    cmd.Parameters.AddWithValue("ClassG", Classgroupfield.Text)
                    'executes the SQL command
                    cmd.ExecuteNonQuery()
                End Using
                'closes connection with the database
                con.Close()
                'informs the user with a message that the record has been updated
                MsgBox("Record Updated", MsgBoxStyle.Information)
            Else
                'but if the teacher name entered by the user does not exist then the following error message displays and nothing happens
                MsgBox("The Entered Teacher Name does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If
        Else
            'if any of the textbox fields are left blank then the following error message displays and nothing happens
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If

    End Sub
    'this sub runs when the delete button is clicked and works in a similar manner to the code in the above sub
    Private Sub Deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deletebtn.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        DatabaseConnect()

        'checks to see if the record actually exists based on the information in the textboxes
        If rowexists() = True Then
            'this block of code sets the StudentID of the record that the user wants to delete based on the values of the firstname and surname textboxes
            sql = "Select * FROM Teacher WHERE Firstname = '" & Firstnamefield.Text & "' AND Surname = '" & Surnamefield.Text & "' "
            Dim cmmd As New SqlCommand(sql, con)
            da.SelectCommand = cmmd
            da.Fill(ds, "Teacher")
            dt = ds.Tables("Teacher")
            TID = ds.Tables(0).Rows(0).Item("TeacherID").ToString()

            'provides a yes/no dialog box aasking the user if they really want to delete the record
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the answer is yes then the following code deletes the record from the database using the SQL statement below
            If result = DialogResult.Yes Then
                sql = "DELETE FROM Class WHERE TeacherID = '" & TID & "'  AND SubjectID = '" & Subjectfield.SelectedValue & "' AND DatasetID = '" & Yearfield.SelectedValue & "' AND ClassGroup = '" & Classgroupfield.Text & "'"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                'the following forms are either displayed or closed
                Teacher_Classes.Show()
                Me.Close()
                'but if the answer is no nothing happens
            ElseIf result = DialogResult.No Then
            End If
        Else
            'if the record does not exist then the following error message displays and nothing happens
            MsgBox("The Entered Record does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
End Class