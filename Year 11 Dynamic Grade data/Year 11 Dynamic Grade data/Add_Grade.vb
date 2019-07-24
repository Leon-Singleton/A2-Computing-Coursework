'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable

Public Class Add_Student_Grade
    ''stores a studentID that can be used anywhere within this class
    Dim studentID As Integer
    'stores a validation variable that validates which action to perform later on
    Dim validate6 As Boolean = True
    'this sub runs when the form is initially loaded
    Private Sub Add_Grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'calls database connect from the public module
        DatabaseConnect()
        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'the datagrid is set to not be visible
        AddGradeGrid.Visible = False
        'clears the current selection of columns in the datagrid
        AddGradeGrid.Columns.Clear()
    End Sub
    'this sub runs when the Grade link is clicked
    Private Sub GradeLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GradeLink.LinkClicked
        'the following forms either display or close if edited check is true
        If editedcheck() Then
            Grade.Show()
            Edit_Grade.Close()
            Me.Close()
            'if edited check is not true then a dialog message dsiplays to the user with a yes/no option
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms either display or close
            If result = DialogResult.Yes Then
                Grade.Show()
                Edit_Grade.Close()
                Me.Close()
                'if the user clicks no then nothing happens
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'this sub runs when the main menu link is clicked and functions in the same mannar as the teacher link above
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        If editedcheck() Then
            Main_Menu.Show()
            Edit_Grade.Close()
            Grade.Close()
            Me.Close()
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                Edit_Grade.Close()
                Grade.Close()
                Me.Close()
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function editedcheck() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        editedcheck = True
        'but if any of the following textbox fields values are not the same as their respective stored variables then the functions state is set to false

        If Subjectfield.Text <> "" Then
            editedcheck = False
        End If
        If LevelField.Text <> "" Then
            editedcheck = False
        End If
        If Gradefield.Text <> "" Then
            editedcheck = False
        End If
        If Yearfield.Text <> "" Then
            editedcheck = False
        End If
    End Function
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Field.SelectedIndexChanged
        'stores dt as a datatable
        Dim dt As New DataTable
        'sets the wherelabel as visible to the user
        wherelabel.Visible = True

        'This case statement selects which textbox or combobox is visible when the corrsponding text value of the field combobox is selected and sets all other textboxes or comboboxes as not visible when a case is selected by the user's mouse click choice
        Select Case Field.Text
            Case ""
                SearchGender.Visible = False
                SearchName.Visible = False
                SearchForm.Visible = False
                SearchYear.Visible = False
                wherelabel.Visible = False
                Addsearch.Visible = False
            Case "Name"
                SearchGender.Visible = False
                SearchName.Visible = True
                SearchForm.Visible = False
                SearchYear.Visible = False
                Addsearch.Visible = True
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
                SearchForm.Visible = False
                SearchYear.Visible = False
                Addsearch.Visible = True
                wherelabel.Text = "Gender:"
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
                Addsearch.Visible = True
                wherelabel.Text = "Form:"
        End Select
    End Sub
    'this sub runs when the search button is clicked by the user
    Private Sub Addsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addsearch.Click
        'clears the current selection of columns in the studentgrid
        AddGradeGrid.Columns.Clear()
        'the validation variable is set to true
        validate6 = True
        'stores a dataset variable
        Dim ds As New DataSet

        'sets the SQL statement
        sql = "SELECT  StudentID, Firstname, Surname, Gender, Form, Year FROM Student"
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case ""
                sql = sql & " ORDER BY StudentID ASC"
            Case "Name"
                sql = sql & " WHERE (Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%') and DatasetID = '" & moduleDataset & "' ORDER BY StudentID ASC"
            Case "Gender"
                sql = sql & " WHERE Gender LIKE '%" & SearchGender.Text & "%'and DatasetID = '" & moduleDataset & "'ORDER BY StudentID ASC"
            Case "Form"
                sql = sql & " WHERE Form LIKE '%" & SearchForm.Text & "%'and DatasetID = '" & moduleDataset & "'ORDER BY StudentID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasrouce of the datagrid
        AddGradeGrid.DataSource = ds
        'grid becomes visible
        AddGradeGrid.Visible = True
        'sets the datamember of the datagrid
        AddGradeGrid.DataMember = "temp"
        AddGradeGrid.Columns("StudentID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Columnview As New DataGridViewButtonColumn
        With Columnview
            'sets the header text of the button column
            .HeaderText = "Grade Details"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "View Grades"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        AddGradeGrid.Columns.Add(Columnview)
        'auto resizes the column widths of the datagrid
        AddGradeGrid.AutoResizeColumns()
    End Sub
    'this sub runs when a button that is part of the datagrid is clicked by the user
    Private Sub AddGradeGrid_ContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AddGradeGrid.CellClick
        'two differnet datasets are stored
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim dt As DataTable
        'stores a GRADEID
        Dim GradeID As String

        'if the index of the button clicked is 6 and the validate property is true then the code within this if statement runs
        If e.ColumnIndex = 6 And validate6 = True Then
            'the studentID variable is set as the STudentID that is on the same row as the button clicked by the user
            studentID = AddGradeGrid.Rows(e.RowIndex).Cells("StudentID").Value
            'clears the current selection of columns in the datagrid
            AddGradeGrid.Columns.Clear()

            'works like the example above in the addsearch sub and displays the results of the SQL statement query below in addgradegrid which is then set as visible
            sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & studentID & "' ORDER BY GradeID ASC"
            ds = generateDataset(sql, "temp")
            AddGradeGrid.DataSource = ds
            AddGradeGrid.Visible = True
            AddGradeGrid.DataMember = "temp"
            AddGradeGrid.Columns("GradeID").Visible = False
            'auto resizes the column selection
            AddGradeGrid.AutoResizeColumns()

            'add grade group and all of its controls become visible to the user
            Addgradegroup.Visible = True

            'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
            dt = GenerateCombo("GradeType", "GradeTypeID, GradeType", False)
            'sets the datasource of the combobox
            Gradetypefield.DataSource = dt
            'sets the display member of the combobox
            Gradetypefield.DisplayMember = "GradeType"
            'the index of each item in the combobox is set as their corresponding ID from the database
            Gradetypefield.ValueMember = "GradeTypeID"

            dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
            Yearfield.DataSource = dt
            Yearfield.DisplayMember = "Year"
            Yearfield.ValueMember = "DatasetID.DatasetID"

            dt = GenerateCombo("Subject", "SubjectID, Subject", True)
            Subjectfield.DataSource = dt
            Subjectfield.DisplayMember = "Subject"
            Subjectfield.ValueMember = "SubjectID"

            dt = GenerateCombo("Level", "LevelID,Level", True)
            LevelField.DataSource = dt
            LevelField.DisplayMember = "Level"
            LevelField.ValueMember = "LevelID"

            dt = GenerateCombo("Grade", "Grade", True)
            Gradefield.DataSource = dt
            Gradefield.DisplayMember = "Grade"

            'creates a new variable that stores information for a button column that can be added to the datagrid
            Dim Columnedit As New DataGridViewButtonColumn
            With Columnedit
                'sets the header text of the button column
                .HeaderText = "Grade Details"
                'sets the name of the button column
                .Name = "Details"
                'sets the text displayed on the buttons of the button column in the datagrid
                .Text = "Edit Grade"
                .UseColumnTextForButtonValue = True
            End With
            'if the number of columns in the datagrid is 8 then the button column is added to the datagrid
            If AddGradeGrid.Columns.Count = 8 Then
                AddGradeGrid.Columns.Add(Columnedit)
            End If

            'resizes all columns in the datagrid
            AddGradeGrid.AutoResizeColumns()

            'the dataset1 is set as the returned dataset after passing studentid into the addgradevalues of the module
            ds1 = Addgradevalues(studentID)
            'the firstname and surname textboxes text are set as their corresponding values in the dataset underneath their respective headings
            Firstname.Text = ds.Tables(0).Rows(0).Item("Firstname").ToString()
            Surname.Text = ds.Tables(0).Rows(0).Item("Surname").ToString()
            'the validate state is set to false
            validate6 = False
        End If

        'if the button clicked is on the eigth column then this if statement runs
        If e.ColumnIndex = 8 Then
            Edit_Grade.Close()
            'GradeID is set to its corresponding value in the datagrid underneath its respective heading, and on the same row as the button clicked
            GradeID = AddGradeGrid.Rows(e.RowIndex).Cells("GradeID").Value
            
            'passes the gradeID of this form to the EditGrade form
            Edit_Grade.GradeID = GradeID
            Edit_Grade.Show()
        End If

    End Sub
    ' 'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function gradevalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        gradevalidate = True
        'if the levelfield is KS2 and the value of the gradefield is a number( which can only be applied to KS2 subjects) then this functions state is set to false
        If LevelField.Text = "KS4" And IsNumeric(Gradefield.Text) = True Then
            gradevalidate = False
        End If
        'if the levelfield is KS4 and the value of the gradefield is not a number(which can only be applied to KS2 subjects) then this functions state is set to false
        If LevelField.Text = "KS2" And IsNumeric(Gradefield.Text) = False Then
            gradevalidate = False
        End If
    End Function
    'this function returns a true or false state depending on whether the row exists in the database
    Public Function Gradeexists() As Boolean
        Call DatabaseConnect()
        'the functions state is initially set to false
        Gradeexists = False
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
        sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & studentID & "' AND Grade.SubjectID = '" & Subjectfield.SelectedValue & "' AND Grade.LevelID = '" & LevelField.SelectedValue & "' AND Grade.GradeTypeID = '" & Gradetypefield.SelectedValue & "' ORDER BY GradeID ASC"
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
            Gradeexists = True
        Else
            Gradeexists = False
        End If
    End Function
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidate = True
        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Subjectfield.Text = "" Then
            Subjectfield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Subjectfield.BackColor = Color.White
        End If
        If LevelField.Text = "" Then
            LevelField.BackColor = Color.Salmon
            txtvalidate = False
        Else
            LevelField.BackColor = Color.White
        End If
        If Gradefield.Text = "" Then
            Gradefield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Gradefield.BackColor = Color.White
        End If
        If Gradetypefield.Text = "" Then
            Gradetypefield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Gradetypefield.BackColor = Color.White
        End If
        If Yearfield.Text = "" Then
            Yearfield.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Yearfield.BackColor = Color.White
        End If
    End Function
    'this sub runs when the add button is clicked by the user
    Private Sub Addgradebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addgradebutton.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        'stores the GradeID of the record that will be inserted
        Dim gID As Integer
        'sets the SQL satatement
        sql = "Select TOP 1 GradeID FROM Grade ORDER BY GradeID DESC"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Grade")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Grade")
        'The GradeID is then set as the value of the highest GradeID found from the Query and then incremented by 1, the SQL statement takes into account removing grades so that inserting a record will use the first available GradeID
        gID = ds.Tables(0).Rows(0).Item("GradeID").ToString() + 1
        DatabaseConnect()

        'if the textboxes have all been filled in then the code continues
        If txtvalidate() = True Then
            'if the selected grade can be applied to the selectedkeystage then the code continues
            If gradevalidate() = True Then
                'if a grade does not already exist for the selected student the code continues
                If Gradeexists() = False Then
                    'sets the SQL statement 
                    sql = "INSERT INTO Grade (GradeID, StudentID, SubjectID, LevelID, Grade, GradeTypeID, DatasetID) VALUES (@GradeID, @StudentID, @SubjectID, @LevelID, @Grade, @GradeT, @Year)"
                    'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
                    Using cmd = New SqlCommand(sql, con)
                        'sets the parameters of the vlues to be inserted
                        cmd.Parameters.AddWithValue("GradeID", gID)
                        cmd.Parameters.AddWithValue("StudentID", studentID)
                        cmd.Parameters.AddWithValue("SubjectID", Subjectfield.SelectedValue)
                        cmd.Parameters.AddWithValue("LevelID", LevelField.SelectedValue)
                        cmd.Parameters.AddWithValue("Grade", Gradefield.Text)
                        cmd.Parameters.AddWithValue("GradeT", Gradetypefield.SelectedValue)
                        cmd.Parameters.AddWithValue("Year", Yearfield.SelectedValue)
                        cmd.ExecuteNonQuery()
                    End Using
                    'closes the database connection
                    con.Close()
                    'notifies the user with the appropriate message
                    MsgBox("Record Added", MsgBoxStyle.Information)

                    'the following code is similar to the code in the addgradeclick sub and essentially, refreshed the datagrid to show the new record
                    AddGradeGrid.Columns.Clear()
                    sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & studentID & "'"
                    ds = generateDataset(sql, "temp")
                    AddGradeGrid.DataSource = ds
                    AddGradeGrid.Visible = True
                    AddGradeGrid.DataMember = "temp"
                    AddGradeGrid.AutoResizeColumns()
                    Dim Columnedit As New DataGridViewButtonColumn
                    With Columnedit
                        .HeaderText = "Grade Details"
                        .Name = "Details"
                        .Text = "Edit Grade"
                        .UseColumnTextForButtonValue = True
                    End With
                    If AddGradeGrid.Columns.Count = 8 Then
                        AddGradeGrid.Columns.Add(Columnedit)
                    End If
                    AddGradeGrid.AutoResizeColumns()
                Else
                    'if a grade for the selected student already exists for the selected subject the following error message displays and nothing happens
                    MsgBox("A grade is already Assigned to that subject", MsgBoxStyle.Information, MessageBoxButtons.OK)
                End If
            Else
                'if the selected grade can not be applied to the selectedkeystage the following error message displays and nothing happens
                MsgBox("That grade cannot be applied to that Subject Level (Keystage)", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If
        Else
            'if one or more textboxes have not been completed the following error message displays and nothing happens
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'deals with the print form button
    Private Sub printbutton_Click(sender As System.Object, e As System.EventArgs) Handles printbutton.Click
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
        End If
    End Sub
End Class