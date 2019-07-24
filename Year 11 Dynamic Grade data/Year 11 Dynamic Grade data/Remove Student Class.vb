'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Remove_Student_Class
    'sets the variables that are recieved from the student classes form as private variables which can be used in any sub within this class
    Private _ClassID As Integer
    Private _Fname As String
    Private _Sname As String
    Private _Form As String
    'creates a property of the variable that is being recieved
    Public Property Fname() As String
        Get
            'gets the variable from the form that has been specified, in this case the student classes form
            Return _Fname
        End Get
        Set(ByVal value As String)
            'sets the variable that has been recieved by the get statement as the equivalent variable that will be used in this form
            _Fname = value
        End Set
    End Property
    Public Property Form() As String
        Get
            Return _Form
        End Get
        Set(ByVal value As String)
            _Form = value
        End Set
    End Property
    Public Property Sname() As String
        Get
            Return _Sname
        End Get
        Set(ByVal value As String)
            _Sname = value
        End Set
    End Property
    Public Property ClassID() As Integer
        Get
            Return _ClassID
        End Get
        Set(ByVal value As Integer)
            _ClassID = value
        End Set
    End Property
    'when the main menu link is clicked the following forms either close or open
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenulink.LinkClicked
        Main_Menu.Show()
        Add_Student_Class.Close()
        Student_Classes.Close()
        Myclasses.Close()
        Me.Close()
    End Sub
    'when the Classes link is clicked the following forms either close or open
    Private Sub Classeslink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Classeslink.LinkClicked
        Student_Classes.Show()
        Me.Close()
    End Sub
    'this sub runs when the form initially loads
    Private Sub Removestudentclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'clears the current column selection of the datagrid
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

        'sets teh follwoing text fields as the corresponding variables that have been recieved from the Student classes form
        Firstnamefield.Text = Fname
        Surnamefield.Text = Sname
        Formfield.Text = Form
    End Sub
    'this sub runs the following code when the remove button is clicked
    Private Sub removefromclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Removefromclass.Click
        'stores the StudentID 
        Dim studentID As String
        'stores da as a SQL data adapter
        Dim da As New SqlDataAdapter
        'stores dt as a datatable
        Dim dt As New DataTable
        'stores ds as a dataset
        Dim ds As New DataSet

        'Calls the database connect sub from the module
        DatabaseConnect()

        'sets the SQL statement which finds the StudentID from the values that have been entered in the firstname and surname textboxes
        sql = "Select Distinct StudentID FROM Student WHERE Firstname = '" & Firstnamefield.Text & "' AND Surname = '" & Surnamefield.Text & "' "
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Student")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Student")
        'The student ID variable is then set to the first row that is returned in the dataset after querying the database with the above SQl statement
        studentID = ds.Tables(0).Rows(0).Item("StudentID").ToString()

        'Stores a yes/no messagebox with the following message
        Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'if the user clicks the yes option when prompted the folliwng runs
        If result = DialogResult.Yes Then
            'sets the SQL statemnt
            sql = "DELETE FROM StudentGroup WHERE StudentID = '" & studentID & "' AND ClassID = '" & ClassID & "'"
            'uses cmmd as a new SQL command that uses the above SQL statement and the connection string of con
            Using cmd = New SqlCommand(sql, con)
                'executes the query and deletes the record from the Dataabse
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            'displays a messagebox to the user to verify that the record has been deleted from the database
            MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
            'closes this form and displays the student classes form
            Student_Classes.Show()
            Me.Close()
            'but if the user clicks the no option when prompted nothing happens
        ElseIf result = DialogResult.No Then
        End If

    End Sub
End Class