Public Class TeacherView
    'This sub is performed when the form initially loads
    Private Sub teacher_class_view(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Calls the database connect sub from the module
        DatabaseConnect()
        'teachergrid initially is set to not be visible
        TeacherGrid.Visible = False
        'sets the screenarea of the form so that it is displayed center screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    'When the search button is clicked the code within the following sub is run
    Private Sub DisplayTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayTeacher.Click
        'clears all columns from the teachergrid
        TeacherGrid.Columns.Clear()
        'stores a dataset variable
        Dim ds As DataSet

        'sets the SQL statement
        sql = "SELECT TeacherID, Firstname, Surname FROM Teacher"
        'This Case statement is used to alter the SQL query depending on which text is selected from the combobox, when a case is selected the above SQL statement and the corresponding case 'SQL where statement' are concatenated to form one SQL statement
        Select Case Field.Text
            Case ""
                sql = sql & "ORDER BY Firstname ASC, Surname ASC"
            Case "Name"
                sql = sql & " WHERE Firstname LIKE '%" & SearchName.Text & "%' Or Surname LIKE '%" & SearchName.Text & "%' ORDER BY Firstname ASC, Surname ASC"
        End Select

        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "Teacher")
        'sets the datasrouce of the datagrid
        TeacherGrid.DataSource = ds
        'sets the datagrid as visible
        TeacherGrid.Visible = True
        'sets the datamember of the datagrid
        TeacherGrid.DataMember = "Teacher"
        'sets the teacherID column to not visible
        TeacherGrid.Columns("TeacherID").Visible = False

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Column As New DataGridViewButtonColumn
        With Column
            'sets the header text of the button column
            .HeaderText = "Teacher Details"
            'sets the name of the button column
            .Name = "Details"
            'sets the text displayed on the buttons of the button column
            .Text = "Edit Details"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid
        TeacherGrid.Columns.Add(Column)

        'auto resizes the column widths of the datagrid
        TeacherGrid.AutoResizeColumns()

        'if there is only one row in the datagrid then the entered username is not a valid username and so the following error message is displayed to the user and the grid is not visible
        If (TeacherGrid.Rows.Count = 0) Then
            MsgBox("Please enter a valid name")
            TeacherGrid.Visible = False
        End If

    End Sub
    'when a button that is part of the button column is clicked, the code within the following sub is run
    Private Sub TeacherGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TeacherGrid.CellClick
        'stores the TeacherID
        Dim TeacherID As String

        If e.ColumnIndex = 3 Then
            EditAdd_Teacher.Close()
            'sets the value of the TeacherID as the value of the cell that is on the same row as the Edit Details button that is clicked 
            TeacherID = TeacherGrid.Rows(e.RowIndex).Cells("TeacherID").Value

            'sets the Teacher ID of the edit Teacher form as the TeacherID of this form
            EditAdd_Teacher.TeacherID = TeacherID
            'show the editTeacher and closes this form
            EditAdd_Teacher.Show()
        End If
    End Sub
    'when the text within the field combobox is changed then the code within this sub is run
    Private Sub Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Field.SelectedIndexChanged
        'sets the wherelabel and datagrids as visible to the user
        DisplayTeacher.Visible = True
        wherelabel.Visible = True
        SearchName.Visible = True
        'This case statement decides what to do if the field.text value is blank, if it is then the following features are set to not visible 
        Select Case Field.Text
            Case ""
                DisplayTeacher.Visible = False
                wherelabel.Visible = False
                SearchName.Visible = False
        End Select
    End Sub
    'When the main menu label is clicked the main menu form is showed to the user and this form closes
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        Main_Menu.Show()
        EditAdd_Teacher.Close()
        Me.Close()
    End Sub
    'if the add teacher button is clicked by the user then the edit teacher form is displayed to the user
    Private Sub TeacherAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherAdd.Click
        EditAdd_Teacher.Show()
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
End Class