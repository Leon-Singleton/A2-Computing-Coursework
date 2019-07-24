'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Edit_Grade
    'sets the variable that is recieved from the Grade form as a private variable which can be used in any sub within this class
    Private _GradeID As Integer
    'stores a studentID variable within this calss
    Dim SID As Integer


    'sets the values of several variables that can be used to check the values of these variables later in the code, they can be used in any sub
    Dim Gradecheck As String
    Dim Gradetypecheck As String
    Dim Yearcheck As String
    'creates a property of the variable that is being recieved
    Public Property GradeID() As Integer
        Get
            'gets the variable from the form that has been specified, in this case the grade form
            Return _GradeID
        End Get
        Set(ByVal value As Integer)
            'sets the variable that has been recieved by the get statement as the equivalent variable that will be used in this form
            _GradeID = value
        End Set
    End Property
    'This sub runs when the Edit grade form is initially loaded
    Private Sub Edit_Grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

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
        dt = GenerateCombo("GradeType", "GradeTypeID, GradeType", False)
        'sets the datasource of the combobox
        Gradetypefield.DataSource = dt
        'sets the display member of the combobox
        Gradetypefield.DisplayMember = "GradeType"
        'sets the index value of each item in the Gradetype combobox to match their corresponding ID's
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

        'the dataset is set as the returned dataset after passing GradeID in to the Editgradevalues function in the module
        ds = Editgradevalues(GradeID)
        'the following textbox fields are set to their respective values under their column headings within the dataset
        Firstname.Text = ds.Tables(0).Rows(0).Item("Firstname").ToString()
        Surname.Text = ds.Tables(0).Rows(0).Item("Surname").ToString()
        Subjectfield.Text = ds.Tables(0).Rows(0).Item("Subject").ToString()
        LevelField.Text = ds.Tables(0).Rows(0).Item("Level").ToString()

        'the following variables are set to their equivalent values under their respective headings in the dataset
        Gradecheck = ds.Tables(0).Rows(0).Item("Grade").ToString()
        Gradetypecheck = ds.Tables(0).Rows(0).Item("GradeType").ToString()
        Yearcheck = ds.Tables(0).Rows(0).Item("Year").ToString()
        'sets the text of the textboxes as the values of the varaibles above that have been set
        Gradefield.Text = Gradecheck
        Gradetypefield.Text = Gradetypecheck
        Yearfield.Text = Yearcheck
    End Sub
    'this sub runs when the Grade link is clicked
    Private Sub GradeLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SubjectLink.LinkClicked
        'the following forms either display or close if edited check is true
        If editedcheck() Then
            Grade.Show()
            Add_Student_Grade.Close()
            Me.Close()
            'if edited check is not true then a dialog message dsiplays to the user with a yes/no option
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms either display or close
            If result = DialogResult.Yes Then
                Grade.Show()
                Add_Student_Grade.Close()
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
            Add_Student_Grade.Close()
            Grade.Close()
            MyClassGrades.Close()
            Me.Close()
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                Add_Student_Grade.Close()
                Grade.Close()
                MyClassGrades.Close()
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
        If Gradefield.Text <> Gradecheck Then
            editedcheck = False
        End If
        If Gradetypefield.Text <> Gradetypecheck Then
            editedcheck = False
        End If
        If Yearfield.Text <> Yearcheck Then
            editedcheck = False
        End If
    End Function
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidate = True

        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
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
    'this function returns a true or false state depending on whether conditions within the function have been met or not
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
    'this function returns a true or false state depending on whether the GradeID exists
    Public Function IDexists(ByVal GradeID As String) As Boolean
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
        sql = "Select * from Grade where GradeID = " & GradeID & ""
        'sets the conncection path as the connectionstring of con from the module
        Cmd.Connection = con
        'sets the command statement as the SQL statement
        Cmd.CommandText = sql
        'the datadapter then uses this SQL command to Query the database
        da.SelectCommand = Cmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Grade")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Grade")
        'if the nubmer of rows in the datatable is one or more then the IDexists state is set to true otherwise it is set to false
        If dt.Rows.Count >= 1 Then
            IDexists = True
        Else
            IDexists = False
        End If
    End Function
    'this function returns a true or false state depending on whether the row exists in the database, and works in a similar mannar as the function seen above
    Public Function rowexists(ByVal SID As Integer) As Boolean
        Dim Cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Call DatabaseConnect()
        sql = "Select DISTINCT * FROM Grade WHERE StudentID = '" & SID & "' AND LevelID = '" & LevelField.SelectedValue & "' AND SubjectID = '" & Subjectfield.SelectedValue & "' AND Grade = '" & Gradefield.Text & "' AND GradeTypeID = '" & Gradetypefield.SelectedValue & "' AND DatasetID = '" & Yearfield.SelectedValue & "';"
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
            'If the GradeID exists then the code continues
            If IDexists(GradeID) = True Then
                'if the grade entered is valid and can be applied to the selected keystage then the code continues
                If gradevalidate() = True Then
                    'sets the SQL statement
                    sql = "UPDATE Grade SET Grade.Grade = @Grade, Grade.GradetypeID = @GradeT, Grade.DatasetID = @Year WHERE GradeID = " & GradeID & ";"
                    'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
                    Using cmd = New SqlCommand(sql, con)
                        'sets the parameters of the vlues to be inserted
                        cmd.Parameters.AddWithValue("Grade", Gradefield.Text)
                        cmd.Parameters.AddWithValue("GradeT", Gradetypefield.SelectedValue)
                        cmd.Parameters.AddWithValue("Year", Yearfield.SelectedValue)
                        'executes the SQL command
                        cmd.ExecuteNonQuery()
                    End Using
                    'closes connection with the database
                    con.Close()
                    'informs the user with a message that the record has been updated
                    MsgBox("Record Updated", MsgBoxStyle.Information)
                Else
                    'if the grade entered is not valid for that Keystage then the following error message displays and nothing happens
                    MsgBox("That grade cannot be applied to that Subject Level (Keystage)", MsgBoxStyle.Information, MessageBoxButtons.OK)
                End If
            Else
                ' 'If the GradeID does not exist then the following error message displays and nothing happens
                MsgBox("The current GradeID does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If
        Else
            'if one or more of the textboxes on the form are blank then the following error message displays and nothing happens
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the delete button is clicked and works in a similar manner to the code in the above sub
    Private Sub Deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deletebtn.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        DatabaseConnect()

        'this block of code sets the StudentID of the record that the user wants to delete based on the values of the firstname and surname textboxes
        sql = "Select Distinct StudentID FROM Student WHERE Firstname = '" & Firstname.Text & "' AND Surname = '" & Surname.Text & "' "
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "Student")
        dt = ds.Tables("Student")
        SID = ds.Tables(0).Rows(0).Item("StudentID").ToString()


        If txtvalidate() Then
            If rowexists(SID) = True Then
                'provides a yes/no dialog box aasking the user if they really want to delete the record
                Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                'if the answer is yes then the following code deletes the record from the database using the SQL statement below
                If result = DialogResult.Yes Then
                    sql = "DELETE FROM Grade WHERE StudentID = '" & SID & "' AND LevelID = '" & LevelField.SelectedValue & "' AND SubjectID = '" & Subjectfield.SelectedValue & "' AND Grade = '" & Gradefield.Text & "' AND GradeTypeID = '" & Gradetypefield.SelectedValue & "' AND DatasetID = '" & Yearfield.SelectedValue & "';"
                    Using cmd = New SqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    con.Close()
                    MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                    'the following forms are either displayed or closed
                    Grade.Show()
                    Me.Close()
                    'but if the answer is no nothing happens
                ElseIf result = DialogResult.No Then
                End If
            Else
                'if the rowexits state is not true the appropriate error message is displayed
                MsgBox("The Entered Record does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
            End If
        Else
            'if the txtvalidate state is not true the appropriate error message is displayed
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
End Class