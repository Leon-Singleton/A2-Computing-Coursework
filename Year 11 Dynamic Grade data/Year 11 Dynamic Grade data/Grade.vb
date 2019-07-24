'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb

Public Class Grade
    'runs the following sub when the form initially loads
    Private Sub Grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Calls the database connect sub from the module
        DatabaseConnect()

        'sets the screen dimensions to automatically fit centerscreen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'clears the current datagrid column selection
        Gradegrid.Columns.Clear()
        'stores dt as a datatable
        Dim dt As New DataTable

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("Subject", "Subject", True)
        'sets the datasource of the combobox
        Subjectfield.DataSource = dt
        'sets the display member of the combobox
        Subjectfield.DisplayMember = "Subject"

        dt = GenerateCombo("Grade", "Grade", True)
        Gradefield.DataSource = dt
        Gradefield.DisplayMember = "Grade"

        dt = GenerateCombo("Level", "Level", True)
        Levelfield.DataSource = dt
        Levelfield.DisplayMember = "Level"
    End Sub
    'this sub runs when the search button is clicked
    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        'clears the current subject grid column selection
        Subjectgrid.Columns.Clear()
        Dim ds As New DataSet
        'stores a number of SQL strings
        Dim sql1 As String
        Dim sql2 As String
        Dim sql3 As String
        Dim sql5 As String
        Dim sql6 As String
        Dim sql7 As String


        'calls the Loadgraphic class
        Dim objPlsWait As New clsOPAWaitScreen
        objPlsWait.ShowWaitScreen("")

        'If either of the selected fields on the form are not blank then these SQL statements are set as the following which later form a larger SQL WHERE command
        If Subjectfield.Text <> "" Then
            sql1 = " and Subject.Subject = '" & Subjectfield.Text & "'"
        Else
            sql1 = ""
        End If
        If Gradefield.Text <> "" Then
            sql2 = " and Grade.Grade = '" & Gradefield.Text & "'"
        Else
            sql2 = ""
        End If
        If Levelfield.Text <> "" Then
            sql3 = " and Level.Level = '" & Levelfield.Text & "'"
        Else
            sql3 = ""
        End If
        If Firstnamefield.Text <> "" Then
            sql5 = " and Student.Firstname LIKE '%" & Firstnamefield.Text & "%'"
        Else
            sql5 = ""
        End If
        If SurnameField.Text <> "" Then
            sql6 = " and Student.Surname LIKE '%" & SurnameField.Text & "%'"
        Else
            sql6 = ""
        End If
        sql7 = " ORDER BY GradeID ASC"

        'sets the SQl statement, this statement is formed by concatanating all of the avove SQL strings to this string to form a dynamic SQL string that changes depending on the filters the user wants to use in order to query the Grade selection
        sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE DatasetID.DatasetID = '" & moduleDataset & "' " & sql1 & sql2 & sql3 & sql5 & sql6 & sql7
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Subjectgrid.DataSource = ds
        'sets the datagrid as visible
        Subjectgrid.Visible = True
        'sets the datamember of the datagrid
        Subjectgrid.DataMember = "temp"
        'hides the GradeID column from the user
        Subjectgrid.Columns("GradeID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Column As New DataGridViewButtonColumn
        With Column
            'sets the header text of the button column
            .HeaderText = "Grade Details"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "Edit Grade"
            .UseColumnTextForButtonValue = True
        End With
        'adds the button column to the datagrid
        Subjectgrid.Columns.Add(Column)
        'auto resizes the column widths of the datagrid
        Subjectgrid.AutoResizeColumns()

        'closes the Loadgraphic form and resets its objplswait variable
        objPlsWait.CloseWaitScreen()
        objPlsWait = Nothing

    End Sub
    'if a button that is part of the datagrid is clicked then the following sub is run
    Private Sub Subjectgrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Subjectgrid.CellClick
        'stores a GradeID
        Dim GradeID As String
        If e.ColumnIndex = 8 Then
            Edit_Grade.Close()
            'the GradeID variable is set as teh value of the cell that is on the same row as the button that is clicked and is under the GradeID header column
            GradeID = Subjectgrid.Rows(e.RowIndex).Cells("GradeID").Value

            'the GradeId of the Edit Grade Form is set to the Grade ID that is found from this form
            Edit_Grade.GradeID = GradeID
            'The edit grade form is displayed
            Edit_Grade.Show()
        End If
    End Sub
    'when the main menu link is clicked then the following forms are either displayed or closed
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        Main_Menu.Show()
        Edit_Grade.Close()
        Add_Student_Grade.Close()
        Me.Close()
    End Sub
    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        Grade_Load(e, e)
    End Sub
    'when the add grade button is clicked the following forms are either closed or opened
    Private Sub Addbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addbutton.Click
        Add_Student_Grade.Show()
        Edit_Grade.Close()
        Me.Close()
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