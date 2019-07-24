Public Class Myclasses
    Private Sub MyClasses(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        classgrid.Columns.Clear()
        DatabaseConnect()
        'stores a dataset variable
        Dim ds As DataSet
        'sets the SQL statement
        sql = "SELECT DISTINCT Class.ClassID, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year, Teacher.Firstname, Teacher.Surname FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID WHERE Teacher.LoginID = '" & moduleuserid & "'  and DatasetID.DatasetID = '" & moduleDataset & "'  ORDER BY Class.ClassID ASC"
        'sets the datagrid as visible
        classgrid.Visible = True
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Class")
        'sets the datasource of the datagrid
        classgrid.DataSource = ds.Tables(0)
        'sets the datamember of the datagrid
        classgrid.DataMember = ""
        'hides the ClassID column from the user
        classgrid.Columns("ClassID").Visible = False

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

        Dim studentadd As New DataGridViewButtonColumn
        With studentadd
            .HeaderText = "Add a Student to this Class"
            .Name = "Details"
            .Text = "Add Student"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button columns to the datagrid
        classgrid.Columns.Add(StudentColumn)
        classgrid.Columns.Add(studentadd)

        'auto resizes the column widths of the datagrid
        classgrid.AutoResizeColumns()
    End Sub
    'shows the main menu and closes the my classes form
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        Main_Menu.Show()
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
        End If
    End Sub
    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        MyClasses(e, e)
    End Sub
    'handles the instance the classesgrid buttons are clicked
    Private Sub classgrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles classgrid.CellContentClick
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the classID
        Dim ClassID As String

        'if the selected index of the button that is clicked is the seventh column then the following action is performed
        If e.ColumnIndex = 7 Then
            ClassID = classgrid.Rows(e.RowIndex).Cells("ClassID").Value
            'clears the current datagrid column selection
            classgrid.Columns.Clear()

            'sets the SQL statement query
            sql = "SELECT Class.ClassID, Student.Firstname, Student.Surname, Student.Form, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN  Subject ON Class.SubjectID = Subject.SubjectID INNER JOIN Department ON Subject.DepartmentID = Department.DepartmentID INNER JOIN Student ON StudentGroup.StudentID = Student.StudentID INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID WHERE Class.ClassID = '" & ClassID & "' ORDER BY Student.Firstname ASC, Student.Surname ASC"

            'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
            ds = generateDataset(sql, "temp")
            'sets the datasource of the datagrid
            Viewstudentsgrid.DataSource = ds
            'sets the following datagrids as either visible or not visible
            classgrid.Visible = False
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
            ClassID = classgrid.Rows(e.RowIndex).Cells("ClassID").Value

            Dim AddNewStudenttoclass As New Edit_Classes
            'sets the ClassID of the add student Class form as the ClassID of this form
            Add_Student_Class.ClassID = ClassID
            Add_Student_Class.Show()
        End If

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

            Dim removestudentfromclass As New Remove_Student_Class
            'sets the following four variables of the remove student class form as the values of their variables found from the datagrid of this form
            Remove_Student_Class.ClassID = ClassID
            Remove_Student_Class.Fname = fname
            Remove_Student_Class.Sname = sname
            Remove_Student_Class.Form = form
            Remove_Student_Class.Show()
        End If
    End Sub
End Class