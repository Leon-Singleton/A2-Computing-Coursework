Public Class MyClassGrades
    Private Sub MyClassGrades(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Classgrid.Columns.Clear()
        DatabaseConnect()
        'stores a dataset variable
        Dim ds As DataSet
        'sets the SQL statement
        sql = "SELECT DISTINCT Class.ClassID, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year, Teacher.Firstname, Teacher.Surname FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID WHERE Teacher.LoginID = '" & moduleuserid & "'  and DatasetID.DatasetID = '" & moduleDataset & "' ORDER BY Class.ClassID ASC"
        'sets the datagrid as visible
        Classgrid.Visible = True
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Class")
        'sets the datasource of the datagrid
        Classgrid.DataSource = ds.Tables(0)
        'sets the datamember of the datagrid
        Classgrid.DataMember = ""
        'hides the ClassID column from the user
        Classgrid.Columns("ClassID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim viewgrades As New DataGridViewButtonColumn
        With viewgrades
            'sets the header text of the button column
            .HeaderText = "View Class Grades"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "View Grades"
            .UseColumnTextForButtonValue = True
        End With




        'adds the button columns to the datagrid
        Classgrid.Columns.Add(viewgrades)
        'auto resizes the column widths of the datagrid
        Classgrid.AutoResizeColumns()
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
        End If
    End Sub

    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        MyClassGrades(e, e)
    End Sub

    Private Sub Classgrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Classgrid.CellContentClick
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the classID
        Dim ClassID As String
        'stores a GradeID
        Dim GradeID As String
        'stores the subject string
        Dim subject As String
        'stores a studentID
        Dim studentid As Integer

        'if the selected index of the button that is clicked is the seventh column then the following action is performed
        If e.ColumnIndex = 7 Then
            ClassID = Classgrid.Rows(e.RowIndex).Cells("ClassID").Value
            subject = Classgrid.Rows(e.RowIndex).Cells("Subject").Value
            'clears the current datagrid column selection
            Classgrid.Columns.Clear()

            'sets the SQL statement query
            sql = "SELECT DISTINCT Grade.GradeID, Student.StudentID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID CROSS JOIN Student LEFT OUTER JOIN StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade ON Class.SubjectID = Grade.SubjectID INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID INNER JOIN [Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID ON Student.StudentID = Grade.StudentID AND Student.StudentID = StudentGroup.StudentID WHERE Class.ClassID = '" & ClassID & "' AND level.Level = 'KS4' AND Subject.Subject = '" & subject & "' ORDER BY Student.Firstname ASC, Student.Surname ASC"
            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")
            'sets the datasource of the datagrid
            Classgrid.DataSource = ds
            'sets the following datagrids as either visible or not visible
            Classgrid.Visible = True
            'sets the datamember of the datagrid
            Classgrid.DataMember = "temp"

            Classgrid.Columns("GradeID").Visible = False
            Classgrid.Columns("StudentID").Visible = False

            'creates a new variable that stores information for a button column that can be added to the datagrid
            Dim editgrade As New DataGridViewButtonColumn
            With editgrade
                'sets the header text of the button column
                .HeaderText = "Edit Class Grade"
                'sets the name of the button column
                .Name = "Details"
                'sets the text displayed on the buttons of the button column in the datagrid
                .Text = "Edit Grade"
                .UseColumnTextForButtonValue = True
            End With

            'creates a new variable that stores information for a button column that can be added to the datagrid
            Dim allgrades As New DataGridViewButtonColumn
            With allgrades
                'sets the header text of the button column
                .HeaderText = "View all Student's Grades"
                'sets the name of the button column
                .Name = "Details"
                'sets the text displayed on the buttons of the button column in the datagrid
                .Text = "View Grades"
                .UseColumnTextForButtonValue = True
            End With

            'adds the button column to the datagrid
            Classgrid.Columns.Add(editgrade)
            Classgrid.Columns.Add(allgrades)

            'auto resizes the column selection
            Classgrid.AutoResizeColumns()
        End If

        If e.ColumnIndex = 9 Then
            Edit_Grade.Close()
            'the GradeID variable is set as teh value of the cell that is on the same row as the button that is clicked and is under the GradeID header column
            GradeID = Classgrid.Rows(e.RowIndex).Cells("GradeID").Value

            'the GradeId of the Edit Grade Form is set to the Grade ID that is found from this form
            Edit_Grade.GradeID = GradeID
            'The edit grade form is displayed
            Edit_Grade.Show()
        End If

        If e.ColumnIndex = 10 Then
            'the studentID variable is set as the STudentID that is on the same row as the button clicked by the user
            studentid = Classgrid.Rows(e.RowIndex).Cells("StudentID").Value
            'clears the current selection of columns in the datagrid
            Classgrid.Columns.Clear()

            'works like the example above in the addsearch sub and displays the results of the SQL statement query below in addgradegrid which is then set as visible
            sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & studentid & "' ORDER BY GradeID ASC"
            ds = generateDataset(sql, "temp")
            Classgrid.DataSource = ds
            Classgrid.Visible = True
            Classgrid.DataMember = "temp"
            Classgrid.Columns("GradeID").Visible = False
            'auto resizes the column selection
            Classgrid.AutoResizeColumns()
        End If


    End Sub
    'shows the main menu and closes the my classes form
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        Main_Menu.Show()
        Me.Close()
    End Sub
End Class