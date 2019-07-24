'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Teacher_Classes
    'Stores the teacherID variable within this form so that it can be used witihn any sub 
    Dim TID As Integer
    'This sub is performed when the form initially loads
    Private Sub teacher_classes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Calls the database connect sub from the module
        DatabaseConnect()
        'the datagrid's visibility is set to false
        Classesgrid.Visible = False
        'stores dt as a variable datatable
        Dim dt As New DataTable
        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
        'sets the datasource of the combobox
        Yearfieldadd.DataSource = dt
        'sets the display member of the combobox
        Yearfieldadd.DisplayMember = "Year"
        'sets the valuemember of the combobox, so that the selected index of each combobox row is the chronological ID of the valuemember column ID
        Yearfieldadd.ValueMember = "DatasetID.DatasetID"

        dt = GenerateCombo("Subject", "SubjectID, Subject", True)
        Subjectfieldadd.DataSource = dt
        Subjectfieldadd.DisplayMember = "Subject"
        Subjectfieldadd.ValueMember = "SubjectID"
    End Sub
    'this function returns a true or false state depending on whether the conditions within the sub have been met or not met
    Public Function editedcheck() As Boolean
        Call DatabaseConnect()
        'initially edited check is set to true
        editedcheck = True
        'However if any of the following textbox fields are not blank then the editedcheck variable is set to false
        If Firstnamefield.Text <> "" Then
            editedcheck = False
        End If
        If Surnamefield.Text <> "" Then
            editedcheck = False
        End If
        If Classgroupfield.Text <> "" Then
            editedcheck = False
        End If
        If Subjectfield.Text <> "" Then
            editedcheck = False
        End If
        If Yearfield.Text <> "" Then
            editedcheck = False
        End If
    End Function
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'calls the edited check function 
        If editedcheck() Then
            'if edited check is true and nothing has been altered on the form then the following forms either display or close
            Main_Menu.Show()
            Edit_Classes.Close()
            Me.Close()
        ElseIf editedcheck() = False Then
            'however if the editedcheck state is false then a mesagebox with yes and no options is displayed to the user asking them if they really want to leave the form since they have written information in the forms textboxes
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms are either displayed or closed
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                Edit_Classes.Close()
                Me.Close()
                'but if the user clicks no then nothing happens and the user reamins on the current form
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'when a button that is part of the button column is clicked, the code within the following sub is run
    Private Sub Classes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Classesgrid.CellContentClick
        'stores the ClassID
        Dim ClassID As String

        If e.ColumnIndex = 7 Then
            Edit_Classes.Close()
            'sets the value of the ClassID as the value of the cell that is on the same row as the button that has been clicked 
            ClassID = Classesgrid.Rows(e.RowIndex).Cells("ClassID").Value
            'sets the ClassID of the edit Class form as the ClassID of this form
            Edit_Classes.ClassID = ClassID
            'show the editstudentform and closes this form
            Edit_Classes.Show()
        End If
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
                wherelabel.Visible = False

            Case "Teacher Name"
                Namefield.Visible = True
                Subjectfield.Visible = False
                Departmentfield.Visible = False
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Name:"
            Case "Class"
                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = False
                Departmentfield.Visible = False
                Classfield.Visible = True
                Yearfield.Visible = False
                wherelabel.Text = "Class:"
            Case "Subject"
                'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
                dt = GenerateCombo("Subject", "SubjectID, Subject", True)
                'sets the datasource of the combobox
                Subjectfield.DataSource = dt
                'sets the display member of the combobox
                Subjectfield.DisplayMember = "Subject"
                'sets the valuemember of the combobox, so that the selected index of each combobox row is the chronological ID of the valuemember column ID
                Subjectfield.ValueMember = "SubjectID"

                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = True
                Departmentfield.Visible = False
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Subject:"
            Case "Department"
                dt = GenerateCombo("Department", "DepartmentID,Department", True)
                Departmentfield.DataSource = dt
                Departmentfield.DisplayMember = "Department"
                Departmentfield.ValueMember = "Department"

                Namefield.Visible = False
                Namefield.Visible = False
                Subjectfield.Visible = False
                Departmentfield.Visible = True
                Classfield.Visible = False
                Yearfield.Visible = False
                wherelabel.Text = "Department:"
        End Select
    End Sub
    'When the search button is clicked the code within the following sub is run
    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addsearch.Click
        'clears all columns from the Classesgrid
        Classesgrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As New DataSet

        'sets the SQL statement
        sql = "SELECT DISTINCT Class.ClassID, Class.ClassGroup, Subject.Subject, Department.Department, DatasetID.Year, Teacher.Firstname, Teacher.Surname FROM Department INNER JOIN Subject ON Department.DepartmentID = Subject.DepartmentID INNER JOIN Class INNER JOIN DatasetID ON Class.DatasetID = DatasetID.DatasetID ON Subject.SubjectID = Class.SubjectID INNER JOIN Teacher INNER JOIN Teaches ON Teacher.TeacherID = Teaches.TeacherID ON Class.TeacherID = Teacher.TeacherID"
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case ""
                sql = sql & "  WHERE DatasetID.DatasetID = '" & moduleDataset & "' ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Teacher Name"
                sql = sql & " WHERE (Teacher.Firstname LIKE '%" & Namefield.Text & "%' Or Teacher.Surname LIKE '%" & Namefield.Text & "%') AND DatasetID.DatasetID = '" & moduleDataset & "' ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
              Case "Department"
                sql = sql & " WHERE Department.Department = '" & Departmentfield.Text & "' AND DatasetID.DatasetID = '" & moduleDataset & "' ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Subject"
                sql = sql & " WHERE Subject.Subject = '" & Subjectfield.Text & "' AND DatasetID.DatasetID = '" & moduleDataset & "'ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
            Case "Class"
                sql = sql & " WHERE Class.ClassGroup LIKE '%" & Classfield.Text & "%' AND DatasetID.DatasetID = '" & moduleDataset & "'ORDER BY Teacher.Firstname ASC, Teacher.Surname ASC, Class.ClassID ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Classesgrid.DataSource = ds
        'sets the datagrid as visible
        Classesgrid.Visible = True
        'sets the datamember of the datagrid
        Classesgrid.DataMember = "temp"
        'hides the ClassID column from the user
        Classesgrid.Columns("ClassID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Columnview As New DataGridViewButtonColumn
        With Columnview
            'sets the header text of the button column
            .HeaderText = "Class Details"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "Edit Class"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        Classesgrid.Columns.Add(Columnview)
        'auto resizes the column widths of the datagrid
        Classesgrid.AutoResizeColumns()
    End Sub
    'this function returns a true or false state depending on whether the conditions within the sub have been met or not met
    Public Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially txtvalidate check is set to true
        txtvalidate = True
        'if any of the following text boxes are blank then the background colour of them changes to a red colour indicating an error otherwise their background colours are set to white
        If Subjectfieldadd.Text = "" Then
            Subjectfieldadd.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Subjectfieldadd.BackColor = Color.White
        End If
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
        If Yearfieldadd.Text = "" Then
            Yearfieldadd.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Yearfieldadd.BackColor = Color.White
        End If
    End Function
    'This function returns either a true or false condition depending on whether the user has entered a valid teacher's name into the name textboxes 
    Public Function nameexists() As Boolean
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
        sql = "Select * FROM Teacher WHERE Firstname = '" & Firstnamefield.Text & "' AND Surname = '" & Surnamefield.Text & "'"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Teacher")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Teacher")

        If dt.Rows.Count >= 1 Then
            'if there are more than one row in the datatable then the nameexists condition is set to true and TID variable is set to the teacherID variable of the row returned in the Datatable
            nameexists = True
            TID = ds.Tables(0).Rows(0).Item("TeacherID").ToString()
        Else
            'if there is not a row then the condition is set to false
            nameexists = False
        End If
    End Function
    'the following sub is run when the Addclassbutton is clicked
    Private Sub Addclassbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addclassbutton.Click
        'stores da as a SQL dataadapter
        Dim da As New SqlDataAdapter
        'tores dt as a datatable
        Dim dt As New DataTable
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the ClassID
        Dim CID As Integer

        'sets the SQL statement query
        sql = "Select TOP 1 ClassID FROM Class ORDER BY ClassID DESC"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "Class")
        dt = ds.Tables("Class")
        'The ClassID is then set as the value of the highest ClassID found from the Query and then incremented by 1, the SQL statement takes into account removing classes so that inserting a record will use the first available ClassID
        CID = ds.Tables(0).Rows(0).Item("ClassID").ToString() + 1

        DatabaseConnect()

        'if both of the following conditions have been met then the insert continues
        If txtvalidate() = True Then
            If nameexists() = True Then

                'sets the SQL insert statement
                sql = "INSERT INTO Class (ClassID, SubjectID, TeacherID, ClassGroup, DatasetID) VALUES (@ClassID, @SubjectID, @TeacherID, @ClassG, @Year)"
                'uses cmmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("ClassID", CID)
                    'the value of this parameter is set to the selected valuemember of the combobox 
                    cmd.Parameters.AddWithValue("SubjectID", Subjectfieldadd.SelectedValue)
                    cmd.Parameters.AddWithValue("TeacherID", TID)
                    cmd.Parameters.AddWithValue("ClassG", Classgroupfield.Text)
                    cmd.Parameters.AddWithValue("Year", Yearfieldadd.SelectedValue)
                    'execute the SQL command
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                'displays a messagebox to the user to verify that the record has been added to the database
                MsgBox("Record Added", MsgBoxStyle.Information)
                'this command clicks the search button, which essentially refreshes the datagrid so that the user can visibly see that their record has been added
                Addsearch.PerformClick()
            Else
                'if the namevaildate state is not true then the following messagebox displays to the user
                MsgBox("The Entered Teacher Name does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If
        Else
            'if the txtvalidate state is not true then the following messagebox displays to the user
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