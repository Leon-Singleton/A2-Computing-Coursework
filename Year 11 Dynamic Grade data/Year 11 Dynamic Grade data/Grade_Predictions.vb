'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Data.DataTable
Public Class Predictions
    'stores a studentID and an averagepointscore variable that can only be used within this class
    Dim StudentID As Integer
    Dim averagepointscore As Double
    'this sub runs when the main menu is clicked

    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'displays the main menu and closes this form
        Main_Menu.Show()
        Me.Close()
    End Sub
    'this sub runs when the form initially loads
    Private Sub Predicted_Grades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'runs the databaseconnect sub from the public module
        DatabaseConnect()
        'datagrid is not visible
        Predictedgradesgrid.Visible = False
        'the current selection of columns in datagrid are cleared
        Predictedgradesgrid.Columns.Clear()

        Dim dt As DataTable

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("Subject", "SubjectID, Subject", True)
        'sets the datasource of the combobox
        SubjectField.DataSource = dt
        'sets the display member of the combobox
        SubjectField.DisplayMember = "Subject"
        'the index of each item in the combobox is set as their corresponding ID from the database
        SubjectField.ValueMember = "SubjectID"

        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        classyearfield.DataSource = dt
        classyearfield.DisplayMember = "Year"
        classyearfield.ValueMember = "DatasetID.DatasetID"

        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        Yearfield.DataSource = dt
        Yearfield.DisplayMember = "Year"
        Yearfield.ValueMember = "DatasetID.DatasetID"

        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        yearcombo.DataSource = dt
        yearcombo.DisplayMember = "Year"
        yearcombo.ValueMember = "DatasetID.DatasetID"
    End Sub
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Field.SelectedIndexChanged
        'stores dt as a datatable
        Dim dt As DataTable

        'sets the wherelabel as visible to the user
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
                wherelabel.Visible = False
                selectstudent.Visible = False
            Case "Name"
                SearchGender.Visible = False
                SearchName.Visible = True
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                SearchDataset.Visible = False
                selectstudent.Visible = True
                wherelabel.Text = "Name:"
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
                selectstudent.Visible = True
                wherelabel.Text = "Gender:"
            Case "Form"
                dt = GenerateCombo("Student", "Form", False)
                SearchForm.DataSource = dt
                SearchForm.DisplayMember = "Form"

                SearchGender.Visible = False
                SearchName.Visible = False
                SearchEthnicity.Visible = False
                SearchSNS.Visible = False
                SearchForm.Visible = True
                SearchYear.Visible = False
                SearchDataset.Visible = False
                selectstudent.Visible = True
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
                selectstudent.Visible = True
                wherelabel.Text = "Year:"
        End Select
    End Sub
    'When the search button is clicked the code within the following sub is run
    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectstudent.Click
        Viewpredictionsgrid.Visible = False
        'clears all columns from the predictedgradesgrid
        Predictedgradesgrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As New DataSet

        grouppredictionsgrid.Visible = False
        createcsv.Visible = False

        'sets the SQL statement
        sql = "SELECT  StudentID, Firstname, Surname, Gender, Form, Year FROM Student"
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case ""
                sql = sql & " ORDER BY StudentID ASC"
            Case "Name"
                sql = sql & " WHERE Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%' ORDER BY StudentID ASC"
            Case "Gender"
                sql = sql & " WHERE Gender LIKE '%" & SearchGender.Text & "%'ORDER BY StudentID ASC"
            Case "Form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%'ORDER BY StudentID ASC"
            Case "Year"
                sql = sql & " WHERE Year LIKE '%" & SearchYear.Text & "%'ORDER BY StudentID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Predictedgradesgrid.DataSource = ds
        'sets the datagrid as visible
        Predictedgradesgrid.Visible = True
        'sets the datamember of the datagrid
        Predictedgradesgrid.DataMember = "temp"
        'hides the StudentID column from the user
        Predictedgradesgrid.Columns("StudentID").Visible = False
        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Columnview As New DataGridViewButtonColumn
        With Columnview
            'sets the header text of the button column
            .HeaderText = "Student'S GCSE Grades"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "View Grades"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        Predictedgradesgrid.Columns.Add(Columnview)
        'auto resizes the column widths of the datagrid
        Predictedgradesgrid.AutoResizeColumns()
    End Sub
    'this sub runs when a button cell that is part of the datagrid is clicked
    Private Sub Predictedgradesgrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Predictedgradesgrid.CellContentClick
        'stores two datasets
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        'stores a datatable
        Dim dt As New DataTable
        'stores an index that will be used in my for next statement
        Dim i As Integer
        'stores a predictedvalue as a double precision floating point number
        Dim predictedvalue As Double
        'stores the total of all the predicted values as a double precison floating point number
        Dim currentpredictedtotal As Double = 0

        grouppredictionsgrid.Visible = False
        createcsv.Visible = False

        'if the cell button clicked by the user is part of the 8th column index then the the code within this if statement runs
        If e.ColumnIndex = 8 Then
            'stores a datatable
            Dim dt1 As New DataTable
            'stores the actual predited grade
            Dim predictedgrade As String
            'stores the subject text
            Dim subject As String

            'adds the to columns to the datatable
            dt.Columns.Add("Subject")
            dt.Columns.Add("Predicted A2 Grade")

            'queries all of the subjects and places them in alphabetical order
            sql = "SELECT DISTINCT Subject FROM Subject Order By Subject ASC"
            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")
            'the dt1 datatable is filled with the contents of the dataset
            dt1 = ds.Tables(0)

            'this for next statement runs for every row in the dt1 datatable
            For i = 0 To dt1.Rows.Count - 1
                'the subject variable (text) is set as text under the subject heading in the datatable that is on the same row as the value of the index i
                subject = dt1.Rows(i)("Subject").ToString()
                'the predited grade is received after passing the subject text value, the index position i, the datatable and the averagepintscore into the A2predictedgrade function in the public module
                predictedgrade = A2predictedgrade(subject, i, dt1, averagepointscore)
                'adds the subject and predicted grade into the dt datatable into he next available row
                dt.Rows.Add(subject, predictedgrade)
                'repeats for each row
            Next
            'sets the datasource of the viewpredictionsgrid as dt and sets it as visible to the user
            Viewpredictionsgrid.DataSource = dt
            Viewpredictionsgrid.Visible = True

        End If

        'if the cell button clicked by the user is part of the 6th column index then the the code within this if statement runs
        If e.ColumnIndex = 6 Then
            'stores GCSEweighting as a double precision floating point number
            Dim GCSEgradeweighting As Double
            'the StudentID variable is set as the StudentID value underneath the StudentID column header and is on the same row as the button clicked by the user
            StudentID = Predictedgradesgrid.Rows(e.RowIndex).Cells("StudentID").Value
            Predictedgradesgrid.Columns.Clear()

            'this variable is used to count the number of GCSE grades a student has
            Dim count As Integer
            count = 0

            'sets the SQL statement
            sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & StudentID & "' ORDER BY GradeID ASC"
            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")

            'sets the datasource of the datagrid, the datamember and sets the datagrid as visible
            Predictedgradesgrid.DataSource = ds
            Predictedgradesgrid.Visible = True
            Predictedgradesgrid.DataMember = "temp"
            'hides the GradeID column of the datagrid from the user
            Predictedgradesgrid.Columns("GradeID").Visible = False
            'sets the dt datatable as the dataset
            dt = ds.Tables(0)
            'automatically re-sizes the the columns of the datagrid
            Predictedgradesgrid.AutoResizeColumns()

            'this for next statement generates a total predicted value score by reading the each row of the datatable and then applying a gcse weighting to the each grade 
            For i = 0 To (dt.Rows.Count - 1)

                'if the value of the grade underneath the Grade header in the datatable on the row of the i index is an A* then this if statement runs
                If dt.Rows(i)("Grade").ToString() = "A*" Then
                    'the GCSE gradeweighting variable is recieved after passing the datatable and the row index into the GCSEgradeweighting function in the public module
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    'the predicted value is set as a national value but then is multiplied by the weighting value
                    predictedvalue = 58 * GCSEgradeweighting
                    count = count + 1
                End If

                'all of the following if statements work like the one above for all the other different grades
                If dt.Rows(i)("Grade").ToString() = "A" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 52 * GCSEgradeweighting
                    count = count + 1
                End If

                If dt.Rows(i)("Grade").ToString() = "B" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 46 * GCSEgradeweighting
                    count = count + 1
                End If

                If dt.Rows(i)("Grade").ToString() = "C" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 40 * GCSEgradeweighting
                    count = count + 1
                End If

                If dt.Rows(i)("Grade").ToString() = "D" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 34 * GCSEgradeweighting
                    count = count + 1
                End If

                If dt.Rows(i)("Grade").ToString() = "E" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 28 * GCSEgradeweighting
                    count = count + 1
                End If

                If dt.Rows(i)("Grade").ToString() = "F" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 22 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt.Rows(i)("Grade").ToString() = "4" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 0
                End If
                If dt.Rows(i)("Grade").ToString() = "5" Then
                    GCSEgradeweighting = GCSEGradewighting(i, dt)
                    predictedvalue = 0
                End If
                'the current predicted total equals the previous currentpredicted total + the predicted value
                currentpredictedtotal = currentpredictedtotal + predictedvalue
            Next

            'the average point score is set as a mean average by getting the total point score and dividing by the number of datatable rows
            averagepointscore = currentpredictedtotal / count

            'creates a new variable that stores information for a button column that can be added to the datagrid
            Dim Columnview As New DataGridViewButtonColumn
            With Columnview
                'sets the header text of the button column
                .HeaderText = "View Predicted Grades"
                'sets the name of the button column
                .Name = "Details"
                'sets the text displayed on the buttons of the button column in the datagrid
                .Text = "Predicted Grades"
                .UseColumnTextForButtonValue = True
            End With

            'adds the button column to the datagrid
            Predictedgradesgrid.Columns.Add(Columnview)
            'auto resizes the column widths of the datagrid
        End If
    End Sub
    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        Predicted_Grades_Load(e, e)
    End Sub
    'this sub runs when all of the fields that require the user's input have been completed
    Private Sub formfieldgenerate()
        'selects the forms based on the user's choice of year
        sql = "SELECT Distinct Form FROM Student WHERE DatasetID = '" & Yearfield.SelectedIndex & "'"
        'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
        Using comm As SqlCommand = New SqlCommand(sql, con)
            'stores a SQL dataadareader which can read the contents of the sql query from the database
            Dim rs As SqlDataReader = comm.ExecuteReader
            'stores a datatable
            Dim dt As DataTable = New DataTable
            'the datatable is filled with the values that the datareader reads
            dt.Load(rs)

            'sets the displaymemeber of the combobox
            formfield.DisplayMember = "Form"
            'sets the datasource of the combobox
            formfield.DataSource = dt
        End Using
    End Sub
    'this function handles every instance of the yearfield when it changes
    Private Sub Yearfield_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Yearfield.SelectedIndexChanged
        'if the yearfield is not blank then the following objects become visible
        If Yearfield.Text <> "" Then
            formfieldgenerate()
            formfield.Visible = True
            labelform.Visible = True
            Searchgroup.Visible = True
        Else
            'otherwise the following objects are not visible
            formfield.Visible = False
            labelform.Visible = False
            Searchgroup.Visible = False
        End If
    End Sub
    Private Sub Searchgroup_Click(sender As System.Object, e As System.EventArgs) Handles Searchgroup.Click

        Dim sql2 As String

        'sets the SQL statement
        sql2 = "SELECT DISTINCT Student.StudentID, Student.Firstname, Student.Surname FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.Form = '" & formfield.Text & "' AND Student.DatasetID = '" & Yearfield.SelectedValue & "' ORDER BY Student.StudentID ASC"
        'passes the SQL2 statement into the groupredictions sub which generates a datatable filled with predicted grades
        grouppredictions(sql2)

    End Sub
    Private Sub yearsearch_Click(sender As System.Object, e As System.EventArgs) Handles yearsearch.Click

        Dim sql2 As String
        'sets the SQL statement
        sql2 = "SELECT DISTINCT Student.StudentID, Student.Firstname, Student.Surname FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.DatasetID = '" & yearcombo.SelectedValue & "' ORDER BY Student.StudentID ASC"
        grouppredictions(sql2)

    End Sub
    Private Sub Classsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Classsearch.Click

        Dim sql2 As String
        'sets the SQL statement
        sql2 = "SELECT DISTINCT Student.StudentID, Student.Firstname, Student.Surname FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Class.Classgroup = '" & Classgroupfield.Text & "' ORDER BY Student.StudentID ASC"
        grouppredictions(sql2)

    End Sub
    Sub grouppredictions(ByVal sql2 As String)
        grouppredictionsgrid.Visible = True


        'calls the Loadgraphic class
        Dim objPlsWait As New clsOPAWaitScreen
        objPlsWait.ShowWaitScreen("")

        'stores subjects
        Dim dt As New DataTable
        'stores students
        Dim dt1 As New DataTable
        'stores studentsgrades
        Dim dt2 As New DataTable
        'stores the grid that will be displayed
        Dim dt3 As New DataTable
        Dim ds As DataSet
        'stores index variables used in my for next statements
        Dim i As Integer
        Dim s As Integer
        Dim z As Integer

        'stores the predictedvalue point score of a Grade
        Dim predictedvalue As Double
        'stores the total of all the predictedvalues
        Dim currentpredictedtotal As Double = 0
        'stores the actual predicted grade
        Dim predictedgrade As String
        'stores a subject
        Dim subject As String
        'stores a weighting variable that is applied to the predictedvalue depending on the subject
        Dim GCSEgradeweighting As Double

        'Stores a students firstname and surname
        Dim firstname As String
        Dim surname As String

        'sets the other two grids on the form as non-visible
        Predictedgradesgrid.Visible = False
        Viewpredictionsgrid.Visible = False

        'queries all of the subjects and places them in alphabetical order
        sql = "SELECT DISTINCT Subject FROM Subject Order By Subject ASC"
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'the dt datatable is filled with the contents of the dataset
        dt = ds.Tables(0)

        'the dataset is set after passing the SQL2 statement which is set depending on the user's filter selection, and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql2, "temp")
        'the dt1 table is filled with a list of students
        dt1 = ds.Tables(0)

        'A firstname and surname column is added to the dt3 datatable which will  be later displayed to teh user
        dt3.Columns.Add("Firstname")
        dt3.Columns.Add("Surname")

        'this for next statement loops through all the rows in the students datatable and stores the firstname and surname of a student
        'these firstname and surnames are then written the the dt3 datatable
        For i = 0 To (dt1.Rows.Count - 1)
            firstname = dt1.Rows(i)("Firstname").ToString()
            surname = dt1.Rows(i)("Surname").ToString()
            dt3.Rows.Add(firstname, surname)
        Next

        'This for next statement loops through the subjects datatable and sets a subject variable for each row, this subject row variable is then added the dt3 datatable as a new column heading
        For i = 0 To (dt.Rows.Count - 1)
            subject = dt.Rows(i)("Subject").ToString()
            dt3.Columns.Add(subject)
        Next

        'this for next loop loops through every students
        'for eachs student the dt2 datatable is filled with that students grades 
        For i = 0 To (dt1.Rows.Count - 1)
            averagepointscore = 0
            currentpredictedtotal = 0
            StudentID = dt1.Rows(i)("StudentID").ToString()
            sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & StudentID & "' ORDER BY GradeID ASC"
            ds = generateDataset(sql, "temp")
            dt2 = ds.Tables(0)

            'counts the number of GCSE grades
            Dim count As Integer
            count = 0

            'this for next statement then loops through that students grades and then applies a predictedvalue depending on the grade, this grade later has a weighting applied to it
            For s = 0 To (dt2.Rows.Count - 1)
              
                'if the value of the grade underneath the Grade header in the datatable on the row of the i index is an A* then this if statement runs
                If dt2.Rows(s)("Grade").ToString() = "A*" Then
                    'the GCSE gradeweighting variable is recieved after passing the datatable and the row index into the GCSEgradeweighting function in the public module
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    'the predicted value is set as a national value but then is multiplied by the weighting value
                    predictedvalue = 58 * GCSEgradeweighting
                    count = count + 1
                End If
                'all of the following if statements work like the one above for all the other different grades
                If dt2.Rows(s)("Grade").ToString() = "A" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 52 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "B" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 46 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "C" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 40 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "D" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 34 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "E" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 28 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "F" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 22 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "4" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 0
                End If
                If dt2.Rows(s)("Grade").ToString() = "5" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 0
                End If
                'the current predicted total equals the previous currentpredicted total + the predicted value
                currentpredictedtotal = currentpredictedtotal + predictedvalue
            Next

            'a mean average point score for the student is created by taking the total of all the predicted values and dividing by the number of grades
            averagepointscore = currentpredictedtotal / count

            'this for next statement then loops through every subject within the dt datatable 
            For z = 0 To (dt.Rows.Count - 1)
                'the subject variable is set as the value of the cell that is part of the row index z
                subject = dt.Rows(z)("Subject").ToString()
                'the actual predicted grade is set by passing the subject, row index, datatable and average point score to the A2predictedgrade sub in the public module
                predictedgrade = A2predictedgrade(subject, z, dt, averagepointscore)
                'the predicted grade is then written on the row index of i underneath the subject header variable
                dt3.Rows(i)(subject) = predictedgrade
            Next
        Next
        'the grids datasource is set to dt3
        grouppredictionsgrid.DataSource = dt3
        'the grid auto-resizes its columns
        grouppredictionsgrid.AutoResizeColumns()
        'the button that creates a spreadsheet file becomes visible to the user
        createcsv.Visible = True

        'closes the Laod graphic form and resets its objplswait variable
        objPlsWait.CloseWaitScreen()
        objPlsWait = Nothing
    End Sub
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createcsv.Click

        'Build the CSV file data as a Comma separated string.
        Dim csv As String = String.Empty

        'Adds the Header row for CSV file by taking all the headers of each datagrid column.
        For Each column As DataGridViewColumn In grouppredictionsgrid.Columns
            csv += column.HeaderText & ","c
        Next

        'Adds a new line
        csv += vbCr & vbLf

        'Deals with adding the Rows to the string based on tyhe values of the rows in the datagrid
        For Each row As DataGridViewRow In grouppredictionsgrid.Rows
            For Each cell As DataGridViewCell In row.Cells
                'Adds the Data rows.
                csv += cell.Value.ToString().Replace(",", ";") & ","c
            Next

            'Adds new line.
            csv += vbCr & vbLf
        Next

        'stores a save dialog variable
        Dim saveFileDialog1 As New SaveFileDialog()

        'sets the file formats that the savedialog is restricted to, in this case a CSV file
        saveFileDialog1.Filter = "Spreadsheet CSV file (*.csv)|*.csv"
        'Sets the filter index of the save dialog as the user is restricted to saving the file as a CSV
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        'if the user clicks the save option within the save dialog box the  CSV file is saved in the current directory that is shown in the savedialog.
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'Creates a streamwriter that creates a file with the user's savedialog name for the file
            Dim sw As StreamWriter = New StreamWriter(saveFileDialog1.OpenFile())
            'if the stream writer is not empty then the streamwriter saves a CSV formatted file with the CSV string that has been created
            If (sw IsNot Nothing) Then
                sw.WriteLine(csv)
                'closes the streamwriter
                sw.Close()
            End If
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
    'this sub handles every instance of the yearcombo field when it is altered
    Private Sub yearcombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles yearcombo.SelectedIndexChanged
        'if the yearcombo is not blank then the search button appears
        If yearcombo.Text <> "" Then
            yearsearch.Visible = True
        Else
            yearsearch.Visible = False
        End If
    End Sub

    'this sub runs when the text within the subject field is altered
    Private Sub SubjectField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectField.SelectedIndexChanged
        If SubjectField.Text = "" Then
            Classlabel.Visible = False
            Classsearch.Visible = False
            Classgroupfield.Visible = False
        ElseIf classyearfield.Text <> "" And SubjectField.Text <> "" Then
            Classfieldgenerate()
        End If
    End Sub


    'this sub runs when all of the fields that require the user's input have been completed
    Private Sub Classfieldgenerate()
        'selects the classes based on the user's choice of subject and year
        sql = "SELECT Distinct Class.ClassID, Class.ClassGroup FROM  Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN DatasetID INNER JOIN Class ON DatasetID.DatasetID = Class.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN StudentGroup ON Class.ClassID = StudentGroup.ClassID WHERE Class.SubjectID = '" & SubjectField.SelectedValue & "' And Class.DatasetID = '" & classyearfield.SelectedValue & "' ORDER BY Class.ClassID ASC"
        'stores a SQL command that uses the SQL statement to query the database that is found when following the connection string of con
        Using comm As SqlCommand = New SqlCommand(sql, con)
            'stores a SQL dataadareader which can read the contents of the sql query from the database
            Dim rs As SqlDataReader = comm.ExecuteReader
            'stores a datatable
            Dim dt As DataTable = New DataTable
            'the datatable is filled with the values that the datareader reads
            dt.Load(rs)

            'the index of each item(class) in the combobox is set as its correspoinding ID in the database
            Classgroupfield.ValueMember = "ClassID"
            'sets the displaymemeber of the combobox
            Classgroupfield.DisplayMember = "ClassGroup"
            'sets the datasource of the combobox
            Classgroupfield.DataSource = dt
        End Using
        'makes the class combobox and its label visible to the user
        Classlabel.Visible = True
        Classgroupfield.Visible = True
    End Sub

    'this sub handles the instance the classyearfield is changed
    Private Sub classyearfield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles classyearfield.SelectedIndexChanged
        'sets the visible property of the search button depending on whether there is text in the classyearfield
        If classyearfield.Text = "" Then
            Classlabel.Visible = False
            Classsearch.Visible = False
            Classgroupfield.Visible = False
        ElseIf classyearfield.Text <> "" And SubjectField.Text <> "" Then
            'runs the classfieldgenerate sub
            Classfieldgenerate()
        End If
    End Sub
    'this sub handles the instance the classgroupfield is changed
    Private Sub Classgroupfield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Classgroupfield.SelectedIndexChanged
        'sets the visible property of the search button depending on whether there is text in the classgroupfield
        If Classgroupfield.Text <> "" Then
            Classsearch.Visible = True
        Else
            Classsearch.Visible = False
        End If
    End Sub
End Class