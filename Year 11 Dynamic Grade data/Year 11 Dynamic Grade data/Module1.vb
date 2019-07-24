'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Imports System
Imports System.IO
Imports System.Text
'since this is a module any subs within this module can be called from any forms
Public Module Module1
    'stores the connection string as a public variable that can be used across all forms
    Public connectionString As String
    'stores the SQL connection as a public varaible that can be used across all forms
    Public con As SqlConnection
    'Stores a SQL query as a public sring variable that can be used across all forms
    Public sql As String
    'stores an autosize columns variable that can be used across all forms
    Public Property AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode
    'these usernames and passwords are stored so that their stored vairable are not reset when switching forms
    Public modulepassword As String
    Public moduleusername As String
    Public moduleuserid As Integer
    'stores the current dataset in use by the system
    Public moduleDataset As String = "0"
    Public addnewdataset As Boolean
    Sub DatabaseConnect()
        'stores the connection path
        Dim connectionstring As String
        'stores the SQL server connection
        Dim connection As New SqlConnection
        'sets the connection path
        connectionstring = "Data Source=STUDENTDEV;Initial Catalog=dn.lsingleton;User ID=dn.lsingleton;Password=6tnwm5"
        'the connection is then set as a SQL connection that uses the connection path of the conectionstring variable
        con = New SqlConnection(connectionstring)

        'a try catch is used to prevent the program from crashing
        Try
            'attempts to connect to the database using the conection path
            con.Open()
        Catch ex As Exception
            'if the database can not be connected to then the following error message is displayed
            MsgBox("Can not open SQL Server connection! Make Sure Server Device is Switched on. ")
        End Try
    End Sub
    'The following function generates a combo box by using a table and field that is passed into the function and a true/false statement to declare whether the top row of the combobox is empty
    Function GenerateCombo(table As String, field As String, needEmpty As Boolean)
        'selects distinct field from a table and then order in ascending order
        sql = "SELECT DISTINCT " & field & " FROM " & table & " ORDER BY " & field & " ASC"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset
        Dim FilterDS As New DataSet
        'stores a datatable
        Dim FilterDT As DataTable

        'the dataadapter fills the dataset with the results of the SQL query
        dataadapter.Fill(FilterDS, table)
        'the datatable is set as the first dataset table
        FilterDT = FilterDS.Tables(0)
        'if needempty is true then the datatable inserts an empty row at row position zero in the combobox
        If needEmpty Then
            Dim drNewRow As DataRow = FilterDT.NewRow
            FilterDT.Rows.InsertAt(drNewRow, 0)
            FilterDT.AcceptChanges()
        End If
        'returns the datatble
        Return FilterDT
    End Function
    'the following function generates a dataset by passing a sql string and a table into the function when it is called
    Function generateDataset(ByVal sql As String, ByVal table As String)
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet()
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, table)
        'returns the dataset
        Return ds
    End Function
    'This function generates a dataset for editing class values by passing a classID into the function
    Public Function Editclassvalues(ByVal ClassID As String)
        'sets the SQL statement
        sql = "SELECT DISTINCT Class.ClassID, Teacher.Firstname, Teacher.Surname, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID WHERE Class.ClassID = '" & ClassID & "'"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, "temp")
        'returns the dataset
        Return ds
    End Function
    'This function generates a dataset for editing grade values by passing a GradeID into the function
    Public Function Editgradevalues(ByVal GradeID As String)
        'sets the SQL statement
        sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Grade.GradeID = '" & GradeID & "'"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, "temp")
        'returns the dataset
        Return ds
    End Function
    'This function generates a dataset for adding grade values by passing a StudentID into the function
    Public Function Addgradevalues(ByVal StudentID As String)
        'sets the SQL statement
        sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentID = '" & StudentID & "'"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, "temp")
        'returns the dataset
        Return ds
    End Function
    'This function generates a dataset for editing student values by passing a StudentID into the function
    Public Function StudentEditValues(ByVal StudentID As String)
        'sets the SQL statement
        sql = "Select * FROM Student WHERE StudentID = " & StudentID & ";"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, "Student")
        'returns the dataset
        Return ds
    End Function
    'This function generates a dataset for editing teacher values by passing a TeacherID into the function
    Public Function TeacherEditValues(ByVal TeacherID As String)
        'sets the SQL statement
        sql = "Select * FROM Teacher WHERE TeacherID = " & TeacherID & ";"
        'stores a SQL datadapter variable that connects to the connection and uses the above SQL statement to query the SQL database 
        Dim dataadapter As New SqlDataAdapter(sql, con)
        'stores a dataset variable
        Dim ds As New DataSet
        'The dataadapter fills the dataset with the result of the SQL query
        dataadapter.Fill(ds, "Teacher")
        'returns the dataset
        Return ds
    End Function
    'this function sets a variable GCSEweighting that determines what percentage a subject point score is multiplied by
    'the values of i (from the for next variable) and the datatable used for the grade prediciton are passed into this function
    Function GCSEGradewighting(ByVal i As Integer, ByVal dt As DataTable)
        'stores the weighting as a double so that it can represent a large floating point number
        Dim GCSEweighting As Double

        'if a new subject has been added to the program then its weighting is set to 1
        GCSEweighting = 1

        'If the value of the cell on the row of i in the datatable under the heading of "subject" matches any of the following list of subjects then the GCSEweighting variable is set, 
        'the weighting variable changes depending on the subject, to indicate the relative difficulty of the subject
        If dt.Rows(i)("Subject").ToString() = "Chemistry" Then
            GCSEweighting = 1.22
        End If
        If dt.Rows(i)("Subject").ToString() = "Physics" Then
            GCSEweighting = 1.19
        End If
        If dt.Rows(i)("Subject").ToString() = "Biology" Then
            GCSEweighting = 1.18
        End If
        If dt.Rows(i)("Subject").ToString() = "German" Or dt.Rows(i)("Subject").ToString() = "French" Or dt.Rows(i)("Subject").ToString() = "Spanish" Then
            GCSEweighting = 1.12
        End If
        If dt.Rows(i)("Subject").ToString() = "Maths" Then
            GCSEweighting = 1.11
        End If
        If dt.Rows(i)("Subject").ToString() = "Computing" Then
            GCSEweighting = 1.08
        End If
        If dt.Rows(i)("Subject").ToString() = "History" Then
            GCSEweighting = 1.03
        End If
        If dt.Rows(i)("Subject").ToString() = "ICT" Then
            GCSEweighting = 1.03
        End If
        If dt.Rows(i)("Subject").ToString() = "Geography" Then
            GCSEweighting = 1
        End If
        If dt.Rows(i)("Subject").ToString() = "English Language" Or dt.Rows(i)("Subject").ToString() = "English Literature" Then
            GCSEweighting = 0.98
        End If
        If dt.Rows(i)("Subject").ToString() = "Music" Then
            GCSEweighting = 0.96
        End If
        If dt.Rows(i)("Subject").ToString() = "Religous Studies" Then
            GCSEweighting = 0.94
        End If
        If dt.Rows(i)("Subject").ToString() = "Business Sudies" Then
            GCSEweighting = 0.93
        End If
        If dt.Rows(i)("Subject").ToString() = "Art" Or dt.Rows(i)("Subject").ToString() = "Graphics" Then
            GCSEweighting = 0.86
        End If
        If dt.Rows(i)("Subject").ToString() = "Textiles" Or dt.Rows(i)("Subject").ToString() = "Health And Social care" Then
            GCSEweighting = 0.88
        End If
        If dt.Rows(i)("Subject").ToString() = "Resistant Materials" Or dt.Rows(i)("Subject").ToString() = "Physichal Education" Then
            GCSEweighting = 0.87
        End If
        If dt.Rows(i)("Subject").ToString() = "Leisure and Tourism" Or dt.Rows(i)("Subject").ToString() = "Drama" Then
            GCSEweighting = 0.84
        End If

        'returns the variable GCSEweighting
        Return GCSEweighting
    End Function
    'this function returns a predicted grade as a letter
    'the values of the subject and average pointscore are passed into this function, the index of i in the for next statement is passed to this function and the datatable in use is also passed
    Function A2predictedgrade(ByVal subject As String, ByVal i As Integer, ByVal dt As DataTable, ByVal averagepointscore As Integer)
        'Predictedgrade is stored as a string because it returns a non-numeric grade
        Dim predictedgrade As String
        'subject point score is stored as a double so that it can be a large floating point number
        Dim subjectpointscore As Double

        'if a new subject has been added to the system then the subjectpointscore of that subject is set as the averagepointscore
        subjectpointscore = averagepointscore

        'If the value of the cell on the row of i in the datatable under the heading of "subject" matches any of the following list of subjects then the Subjectpointscore variable is set, 
        ' 'the variable changes depending on the subject, to indicate the relative difficulty of the subject, and equals the averagepointscore multiplied by the relative difficulty weighting of that subject
        If dt.Rows(i)("Subject").ToString() = "Chemistry" Then
            subjectpointscore = averagepointscore * 0.83
        End If
        If dt.Rows(i)("Subject").ToString() = "Physics" Then
            subjectpointscore = averagepointscore * 0.85
        End If
        If dt.Rows(i)("Subject").ToString() = "Biology" Then
            subjectpointscore = averagepointscore * 0.85
        End If
        If dt.Rows(i)("Subject").ToString() = "German" Or dt.Rows(i)("Subject").ToString() = "French" Or dt.Rows(i)("Subject").ToString() = "Spanish" Then
            subjectpointscore = averagepointscore * 0.87
        End If
        If dt.Rows(i)("Subject").ToString() = "Maths" Then
            subjectpointscore = averagepointscore * 0.89
        End If
        If dt.Rows(i)("Subject").ToString() = "Computing" Then
            subjectpointscore = averagepointscore * 0.9
        End If
        If dt.Rows(i)("Subject").ToString() = "History" Then
            subjectpointscore = averagepointscore * 0.91
        End If
        If dt.Rows(i)("Subject").ToString() = "ICT" Then
            subjectpointscore = averagepointscore * 0.95
        End If
        If dt.Rows(i)("Subject").ToString() = "Geography" Then
            subjectpointscore = averagepointscore * 0.93
        End If
        If dt.Rows(i)("Subject").ToString() = "English Language" Or dt.Rows(i)("Subject").ToString() = "English Literature" Then
            subjectpointscore = averagepointscore * 0.94
        End If
        If dt.Rows(i)("Subject").ToString() = "Music" Then
            subjectpointscore = averagepointscore * 0.96
        End If
        If dt.Rows(i)("Subject").ToString() = "Religous Studies" Then
            subjectpointscore = averagepointscore * 0.99
        End If
        If dt.Rows(i)("Subject").ToString() = "Business Sudies" Then
            subjectpointscore = averagepointscore * 1.01
        End If
        If dt.Rows(i)("Subject").ToString() = "Art" Or dt.Rows(i)("Subject").ToString() = "Graphics" Then
            subjectpointscore = averagepointscore * 1.03
        End If
        If dt.Rows(i)("Subject").ToString() = "Textiles" Or dt.Rows(i)("Subject").ToString() = "Health And Social care" Then
            subjectpointscore = averagepointscore * 1.02
        End If
        If dt.Rows(i)("Subject").ToString() = "Resistant Materials" Or dt.Rows(i)("Subject").ToString() = "Physichal Education" Then
            subjectpointscore = averagepointscore * 0.88
        End If
        If dt.Rows(i)("Subject").ToString() = "Leisure and Tourism" Or dt.Rows(i)("Subject").ToString() = "Drama" Then
            subjectpointscore = averagepointscore * 0.97
        End If


        'The value of the subjectpointscore determines the predicted grade variable
        'for example if the subjectpoint score is 42, then it is lower then 46 but greater than 40, which therefore returns a predicted grade of C
        If subjectpointscore >= 58 Then
            predictedgrade = "A*"
        ElseIf subjectpointscore < 58 And subjectpointscore >= 52 Then
            predictedgrade = "A"
        ElseIf subjectpointscore < 52 And subjectpointscore >= 46 Then
            predictedgrade = "B"
        ElseIf subjectpointscore < 46 And subjectpointscore >= 40 Then
            predictedgrade = "C"
        ElseIf subjectpointscore < 40 And subjectpointscore >= 34 Then
            predictedgrade = "D"
        ElseIf subjectpointscore < 34 And subjectpointscore >= 28 Then
            predictedgrade = "E"
        ElseIf subjectpointscore < 28 Then
            predictedgrade = "F"
        End If

        'returns the predictedgrade variable (the predicted grade that will be output to the user for that given subject)
        Return predictedgrade
    End Function
End Module
