'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable

Public Class EditAdd_Teacher
    'sets the variables that are recieved from the teacher form as private variables which can be used in any sub within this class
    Private _TeacherID As Integer
    Dim TID As Integer

    'sets two variables, one for firstname and one for surname which can be used with any sub to check the value of these variables
    Dim Fnamecheck As String
    Dim Snamecheck As String
    'creates a property of the variable that is being recieved
    Public Property TeacherID() As Integer
        Get
            'gets the variable from the form that has been specified, in this case the Teacher form
            Return _TeacherID
        End Get
        Set(ByVal value As Integer)
            'sets the variable that has been recieved by the get statement as the equivalent variable that will be used in this form
            _TeacherID = value
        End Set
    End Property
    'this sub runs when the Edit Teacher form initially loads
    Private Sub Edit_teacher(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'sets the screen dimensions of the form to automatically generate center screen of the users display
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'calls database connect from the public module
        DatabaseConnect()
        'stores ds as a dataset
        Dim ds As DataSet

        'the dataset is set as the dataset that is returned when passing the TeacherID into the TeacherEditvalues function in the public module
        ds = TeacherEditValues(TeacherID)

        'If there is a teacher ID then the following is altered
        If TeacherID Then
            'delete button becomes visible
            Delete.Visible = True

            'all text properties are changed to edit rather than add
            AddT.Text = "Edit Teacher Details"
            Add_Edit.Text = "Edit"
            addeditlabel.Text = "Edit Teacher"
            'the dataset is set as the returned dataset after passing TeacherID in to the teachereditvalues function in the module
            ds = TeacherEditValues(TeacherID)
            'fnamecheck and snamecheck variables are set to there equivalent values in the dataset under their respective column headings
            Fnamecheck = ds.Tables(0).Rows(0).Item("Firstname").ToString()
            Snamecheck = ds.Tables(0).Rows(0).Item("Surname").ToString()
            'sets the text of the textboxes as the values of the varaibles fnamecheck and snamecheck
            Firstname.Text = Fnamecheck
            Surname.Text = Snamecheck
        End If

    End Sub
    'this sub runs when the Teacher link is clicked
    Private Sub teacher_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Teacher.LinkClicked
        'the following forms either display or close if edited check is true
        If editedcheck() Then
            Teacher.Show()
            Me.Close()
            'if edited check is not true then a dialog message dsiplays to the user with a yes/no option
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the user clicks yes then the following forms either display or close
            If result = DialogResult.Yes Then
                Teacher.Show()
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
            TeacherView.Close()
            Me.Close()
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                TeacherView.Close()
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
        'but if either the firstname or textbox fields is not the same value as the two variables fnamecheck or snamecheck then the functions state is set to false
        If Firstname.Text <> Fnamecheck Then
            editedcheck = False
        End If
        If Surname.Text <> Snamecheck Then
            editedcheck = False
        End If
    End Function
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function txtvalidate() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidate = True
        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Firstname.Text = "" Then
            Firstname.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Firstname.BackColor = Color.White
        End If
        If Surname.Text = "" Then
            Surname.BackColor = Color.Salmon
            txtvalidate = False
        Else
            Surname.BackColor = Color.White
        End If
    End Function
    'this function returns a true or false state depending on whether the TeacherID exists
    Public Function IDexists(ByVal TeacherID As String) As Boolean
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
        sql = "Select * from Teacher where TeacherID = " & TeacherID & ""
        'sets the conncection path as the connectionstring of con from the module
        Cmd.Connection = con
        'sets the command statement as the SQL statement
        Cmd.CommandText = sql
        'the datadapter then uses this SQL command to Query the database
        da.SelectCommand = Cmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Teacher")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Teacher")

        'if the nubmer of rows in the datatable is one or more than the IDexists state is set to true otherwise it is set to false
        If dt.Rows.Count >= 1 Then
            IDexists = True
        Else
            IDexists = False
        End If

    End Function
    'this function returns a true or false state depending on whether the row exists in the database, and works in a similar mannar as the function seen above
    Public Function rowexists() As Boolean
        Dim Cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        Call DatabaseConnect()
        sql = "SELECT DISTINCT Teacher.Firstname, Teacher.Surname FROM Teacher WHERE Teacher.Firstname = '" & Firstname.Text & "' AND Teacher.Surname = '" & Surname.Text & "';"
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
    'this sub runs when the add_edit button is clicked by the user
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Edit.Click

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        'stores a teacherID that will be used as the teacherID to be inserted in the database
        Dim tID As Integer
        'sets the SQL satatement
        sql = "Select TOP 1 TeacherID from Teacher ORDER BY TeacherID DESC"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Teacher")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Teacher")
        'The TeacherID is then set as the value of the highest TeacherID found from the Query and then incremented by 1, the SQL statement takes into account deleting teachers so that inserting a teacher will use the first available TeacherID
        tID = ds.Tables(0).Rows(0).Item("TeacherID").ToString() + 1


        DatabaseConnect()
        'if the textboxes have text and have been validated the program continues
        If txtvalidate() = True Then
            'if the teacherID does not already exist then the program continues with an insert statement
            If IDexists(TeacherID) = False Then
                'sets the SQL statement
                sql = "INSERT INTO Teacher(TeacherID, Firstname, Surname) VALUES (@TeacherID, @Fname, @Sname)"
                'uses cmmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("Fname", Firstname.Text)
                    cmd.Parameters.AddWithValue("Sname", Surname.Text)
                    cmd.Parameters.AddWithValue("TeacherID", tID)
                    'executes the SQL command
                    cmd.ExecuteNonQuery()
                End Using
                'closes the database connection
                con.Close()
                'notifies the user with the appropriate message:
                MsgBox("Record Added to Database", MsgBoxStyle.Information)
                'closes this form and shows the teacher view form
                Teacher.Show()
                Me.Close()
                'but if the teacherID does exist then the program continues with an update statement
            Else
                'sets the SQL statement
                sql = "UPDATE Teacher SET  Firstname = @Fname, Surname = @Sname WHERE TeacherID = " & TeacherID & ";"
                'uses cmmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'sets the parameters of the vlues to be inserted
                    cmd.Parameters.AddWithValue("Fname", Firstname.Text)
                    cmd.Parameters.AddWithValue("Sname", Surname.Text)
                    'executes the SQL command
                    cmd.ExecuteNonQuery()
                End Using
                'closes the database connection
                con.Close()
                'notifies the user with the appropriate message:
                MsgBox("Record Updated", MsgBoxStyle.Information)
            End If
        Else
            'if the textvalidate has been returned as false then the following error message displays to the user
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the delte button is clicked and works in a similar manner to the code in the above sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        DatabaseConnect()

        'checks if the record that the user wants to delete exists in the database
        If rowexists() = True Then

            'this block of code sets the TeacherID of the record that the user wants to delete based o the values of the firstname and surname textboxes
            sql = "Select * FROM Teacher WHERE Firstname = '" & Firstname.Text & "' AND Surname = '" & Surname.Text & "' "
            Dim cmmd As New SqlCommand(sql, con)
            da.SelectCommand = cmmd
            da.Fill(ds, "Teacher")
            dt = ds.Tables("Teacher")
            TID = ds.Tables(0).Rows(0).Item("TeacherID").ToString()

            'provides a yes/no dialog box aasking the user if they really want to delete the record
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'if the answer is yes then the following code deletes the record from the database using the SQL statement below
            If result = DialogResult.Yes Then
                sql = "DELETE FROM Teacher WHERE Teacher.TeacherID = '" & TID & "' AND Firstname = '" & Firstname.Text & "' and Teacher.Surname = '" & Surname.Text & "';"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                Teacher.Show()
                Me.Close()
                'but if the answer is no nothing happens
            ElseIf result = DialogResult.No Then
            End If
        Else
            ' if the record that the user wants to delete does not exist in the database, the following message is displayed
            MsgBox("The Entered Record does not exist", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If

    End Sub
End Class