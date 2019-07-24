'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Public Class Developer_Features
    'stores a series of check variables which store a string
    Dim subjectcheck As String
    Dim departmentcheck As String
    Dim levelchack As String
    Dim yearcheck As String
    Dim gradetypecheck As String

    'stores a series of validation variables that can either be true or false
    Dim subjectdelete As Boolean = False
    Dim GradeTypedelete As Boolean = False
    Dim Leveldelete As Boolean = False
    Dim Yeardelete As Boolean = False
    Dim userdelete As Boolean = False
    Dim useredit As Boolean = False

    'this sub runs when a cell that is part of the datagrid is clicked by the user
    Private Sub CurrentvaluesGrid_ContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Viewcurrentvalues.CellClick

        'if the subjectdelete state is true then the row that the the button clicked by the user is removed from the database
        If subjectdelete = True Then
            'sets the subjectdelete state back to false
            subjectdelete = False
            deletesubject(e)
            End If

        If Leveldelete = True Then
            Leveldelete = False
            deletelevel(e)
        End If

        If GradeTypedelete = True Then
            GradeTypedelete = False
            deletegradetype(e)
        End If

        If useredit = True Then
            edituser(e)

        End If

        If userdelete = True Then
            userdelete = False
            deleteuser(e)
        End If

        If Yeardelete = True Then
            Yeardelete = False
            deletedataset(e)
        End If
    End Sub
    'this sub rusn when the form initialy loads
    Private Sub DeveloperFeatures(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'stores dt as a datatable
        Dim dt As New DataTable
        'runs the databaseconnect sub from the public module
        DatabaseConnect()

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("Department", "DepartmentID, Department", True)
        'sets the datasource of the combobox
        Departmentfield.DataSource = dt
        'sets the display member of the combobox
        Departmentfield.DisplayMember = "Department"
        'the index of each item in the combobox is set as their corresponding ID from the database
        Departmentfield.ValueMember = "DepartmentID"
        'datagrid is not visible
        Viewcurrentvalues.Visible = False

        If addnewdataset = True Then
            Adminaction.Text = "Add a new Dataset Year"
        End If
    End Sub
    'this sub runs when the main menu link is clicked
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'if the value of the editedcheck function is true the following forms either display or close
        If editedcheck() = True Then
            Main_Menu.Show()
            Me.Close()
            'if the value of the editedcheck function is false the following messagebox warning displays to the user, if they select yes the following forms close or open
        ElseIf editedcheck() = False Then
            Dim result As Integer = MessageBox.Show("Do you really want to change window?", "Edited Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Main_Menu.Show()
                Me.Close()
                'if the user selects no then nothing happens
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub
    'this function stores an editedcheck variable as either true or false
    Public Function editedcheck() As Boolean
        'calls the databaseconnect sub from within the public module
        Call DatabaseConnect()
        'the state of this function is initially set to true
        editedcheck = True
        'if any of the following fields are not empty then the state of this sub changes to false
        If Newsubjectfield.Text <> "" Then
            editedcheck = False
        End If
        If Departmentfield.Text <> "" Then
            editedcheck = False
        End If
        If Datasetyearfield.Text <> "" Then
            editedcheck = False
        End If
        If Levelfield.Text <> "" Then
            editedcheck = False
        End If
        If Newgradetypefield.Text <> "" Then
            editedcheck = False
        End If
    End Function
    'this sub runs when the viewcurrentsubjects button is clicked by the user
    Private Sub Viewcurrentsubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewcurrentsubjects.Click
        'clears the current selection of columns in the viewcurrentvalues datagrid
        Viewcurrentvalues.Columns.Clear()
        'the subject delete state is set to true and all other states are set to false
        subjectdelete = True
        userdelete = False
        Leveldelete = False
        GradeTypedelete = False
        Yeardelete = False
        useredit = False
        'stores a dataset
        Dim ds As New DataSet

        'sets the SQL statement
        sql = "SELECT DISTINCT Subject.SubjectID, Subject.Subject, Department.Department FROM Subject, Department WHERE Subject.DepartmentID=Department.DepartmentID ORDER BY Subject.Subject ASC"
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'sets the datasource of the datagrid
        Viewcurrentvalues.DataSource = ds
        'sets the datagrid as visible
        Viewcurrentvalues.Visible = True
        'sets the datamember of the datagrid
        Viewcurrentvalues.DataMember = "temp"

        'creates a new variable that stores information for a button column that can be added to the datagrid
        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            'sets the header text of the button column
            .HeaderText = "Record Details"
            'sets the name of the button column
            .Name = "SubjectRecord"
            'sets the text displayed on the buttons of the button column in the datagrid
            .Text = "Delete Record"
            .UseColumnTextForButtonValue = True
        End With

        'adds the button column to the datagrid if the number of columns is 3
        If Viewcurrentvalues.Columns.Count = 3 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
    End Sub
    'this sub works like the example above but selects levels instead
    Private Sub Viewcurrentlevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewcurrentlevel.Click
        Viewcurrentvalues.Columns.Clear()
        subjectdelete = False
        userdelete = False
        Leveldelete = True
        GradeTypedelete = False
        Yeardelete = False
        useredit = False

        Dim ds As New DataSet
        sql = "SELECT DISTINCT * FROM Level ORDER BY Level ASC"
        ds = generateDataset(sql, "temp")
        Viewcurrentvalues.DataSource = ds
        Viewcurrentvalues.Visible = True
        Viewcurrentvalues.DataMember = "temp"

        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            .HeaderText = "Record Details"
            .Name = "LevelRecord"
            .Text = "Delete Record"
            .UseColumnTextForButtonValue = True
        End With
        If Viewcurrentvalues.Columns.Count = 2 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
    End Sub
    'this sub works like the example above but selects dataset years instead
    Private Sub Viewcurrentdatasetyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewcurrentdatasetyear.Click
        Viewcurrentvalues.Columns.Clear()
        subjectdelete = False
        userdelete = False
        Leveldelete = False
        GradeTypedelete = False
        Yeardelete = True
        useredit = False

        Dim ds As New DataSet
        sql = "SELECT DISTINCT * FROM DatasetID ORDER BY Year ASC"
        ds = generateDataset(sql, "temp")
        Viewcurrentvalues.DataSource = ds
        Viewcurrentvalues.Visible = True
        Viewcurrentvalues.DataMember = "temp"

        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            .HeaderText = "Record Details"
            .Name = "YearRecord"
            .Text = "Delete Record"
            .UseColumnTextForButtonValue = True
        End With
        If Viewcurrentvalues.Columns.Count = 2 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
    End Sub
    'this sub works like the example above but selects logins that can be deleted
    Private Sub viewlogins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewlogins.Click
        Viewcurrentvalues.Columns.Clear()
        subjectdelete = False
        Leveldelete = False
        userdelete = True
        GradeTypedelete = False
        Yeardelete = False
        useredit = False

        Dim ds As New DataSet
        sql = "SELECT DISTINCT * FROM UserLogin ORDER BY LoginID ASC"
        ds = generateDataset(sql, "temp")
        Viewcurrentvalues.DataSource = ds
        Viewcurrentvalues.Visible = True
        Viewcurrentvalues.DataMember = "temp"

        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            .HeaderText = "Record Details"
            .Name = "LoginRecord"
            .Text = "Delete Record"
            .UseColumnTextForButtonValue = True
        End With
        If Viewcurrentvalues.Columns.Count = 4 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
        Viewcurrentvalues.AutoResizeColumns()
    End Sub
    'this sub works like the example above but selects logins that can be edited
    Private Sub vieweditlogins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vieweditlogins.Click
        Viewcurrentvalues.Columns.Clear()
        subjectdelete = False
        Leveldelete = False
        userdelete = True
        GradeTypedelete = False
        Yeardelete = False
        useredit = True

        Dim ds As New DataSet
        sql = "SELECT DISTINCT * FROM UserLogin ORDER BY LoginID ASC"
        ds = generateDataset(sql, "temp")
        Viewcurrentvalues.DataSource = ds
        Viewcurrentvalues.Visible = True
        Viewcurrentvalues.DataMember = "temp"

        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            .HeaderText = "Record Details"
            .Name = "LoginRecord"
            .Text = "Edit Record"
            .UseColumnTextForButtonValue = True
        End With
        If Viewcurrentvalues.Columns.Count = 4 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
        Viewcurrentvalues.AutoResizeColumns()
    End Sub
    'this sub works like the example above but selects grade types instead
    Private Sub Viewcurrentgradetype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewcurrentgradetype.Click
        Viewcurrentvalues.Columns.Clear()
        subjectdelete = False
        Leveldelete = False
        userdelete = False
        GradeTypedelete = True
        Yeardelete = False
        useredit = False

        Dim ds As New DataSet
        sql = "SELECT DISTINCT * FROM GradeType ORDER BY GradeType ASC"
        ds = generateDataset(sql, "temp")
        Viewcurrentvalues.DataSource = ds
        Viewcurrentvalues.Visible = True
        Viewcurrentvalues.DataMember = "temp"

        Dim Columnedit As New DataGridViewButtonColumn
        With Columnedit
            .HeaderText = "Record Details"
            .Name = "GradetypeRecord"
            .Text = "Delete Record"
            .UseColumnTextForButtonValue = True
        End With
        If Viewcurrentvalues.Columns.Count = 2 Then
            Viewcurrentvalues.Columns.Add(Columnedit)
        End If
    End Sub
    'this function returns a true or false state depending on whether conditions within the function have been met or not
    Public Function txtvalidatesubject() As Boolean
        Call DatabaseConnect()
        'initially the functions state is set to true
        txtvalidatesubject = True
        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Newsubjectfield.Text = "" Then
            Newsubjectfield.BackColor = Color.Salmon
            txtvalidatesubject = False
        Else
            Newsubjectfield.BackColor = Color.White
        End If
        If Departmentfield.Text = "" Then
            Departmentfield.BackColor = Color.Salmon
            txtvalidatesubject = False
        Else
            Departmentfield.BackColor = Color.White
        End If
    End Function
    'this function works like the one above but deals with the level fields
    Public Function txtvalidatelevel() As Boolean
        Call DatabaseConnect()
        txtvalidatelevel = True
        If Levelfield.Text = "" Then
            Levelfield.BackColor = Color.Salmon
            txtvalidatelevel = False
        Else
            Levelfield.BackColor = Color.White
        End If
    End Function
    'this function works like the one above but deals with the dataset year fields
    Public Function txtvalidatedataset() As Boolean
        Call DatabaseConnect()
        txtvalidatedataset = True
        If Datasetyearfield.Text = "" Then
            Datasetyearfield.BackColor = Color.Salmon
            txtvalidatedataset = False
        Else
            Datasetyearfield.BackColor = Color.White
        End If
    End Function
    'this function works like the one above but deals with the gradetype fields
    Public Function txtvalidategradetype() As Boolean
        Call DatabaseConnect()
        txtvalidategradetype = True
        If Newgradetypefield.Text = "" Then
            Newgradetypefield.BackColor = Color.Salmon
            txtvalidategradetype = False
        Else
            Newgradetypefield.BackColor = Color.White
        End If
    End Function
    'this function works like the one above but deals with the login fields
    Public Function txtvalidatelogin() As Boolean
        Call DatabaseConnect()
        txtvalidatelogin = True
        If usernamefield.Text = "" Then
            usernamefield.BackColor = Color.Salmon
            txtvalidatelogin = False
        Else
            usernamefield.BackColor = Color.White
        End If
        If passwordfield.Text = "" Then
            passwordfield.BackColor = Color.Salmon
            txtvalidatelogin = False
        Else
            passwordfield.BackColor = Color.White
        End If
        If adminfield.Text = "" Then
            adminfield.BackColor = Color.Salmon
            txtvalidatelogin = False
        Else
            adminfield.BackColor = Color.White
        End If
    End Function
    'this sub runs when the user clicks the add subject button, which adds the contents of the subject fields as a new record into the database
    Private Sub Addsubjectbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addsubjectbutton.Click
        'stores a SQL data adapter
        Dim da As New SqlDataAdapter
        'stores a datatable
        Dim dt As New DataTable
        'stores a dataset
        Dim ds As New DataSet
        'stores a studentID
        Dim SID As Integer
        'sets the SQL satatement
        sql = "Select TOP 1 SubjectID FROM Subject ORDER BY SubjectID DESC"
        'stores cmmd as a SQL command that uses the above SQL statement and the connection string of con
        Dim cmmd As New SqlCommand(sql, con)
        'sets the dataadapter select command as cmmd
        da.SelectCommand = cmmd
        'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
        da.Fill(ds, "Subject")
        'the datatble variable is then set to the table result of the dataset variable
        dt = ds.Tables("Subject")
        'The StudentID is then set as the value of the highest StudentID found from the Query and then incremented by 1, the SQL statement takes into account removing Students so that inserting a record will use the first available StudentID
        SID = ds.Tables(0).Rows(0).Item("SubjectID").ToString() + 1

        DatabaseConnect()
        'if the subject related textboxes have all been filled in then the code continues
        If txtvalidatesubject() Then
            'sets the SQL statement 
            sql = "INSERT INTO Subject(SubjectID, DepartmentID, Subject) VALUES (@SubjectID, @DepartmentID, @Subject)"
            'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
            Using cmd = New SqlCommand(sql, con)
                'sets the parameters of the values to be inserted
                cmd.Parameters.AddWithValue("SubjectID", SID)
                cmd.Parameters.AddWithValue("Subject", Newsubjectfield.Text)
                cmd.Parameters.AddWithValue("DepartmentID", Departmentfield.SelectedValue)
                cmd.ExecuteNonQuery()
            End Using
            'closes the database connection
            con.Close()
            'notifies the user with the appropriate message
            MsgBox("Record Inserted", MsgBoxStyle.Information)
            'this commands clicks the viewcurrentsubjects button which essentially refreshes the datagrid
            Viewcurrentsubjects.PerformClick()
        Else
            'if one or more textboxes have not been completed the following error message displays and nothing happens
            MsgBox("one or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the user clicks the add level button, which adds the contents of the level fields as a new record into the database
    'this sub works like the add subject example above
    Private Sub Addlevelbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addlevelbutton.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim LID As Integer
        sql = "Select TOP 1 levelID FROM Level ORDER BY LevelID DESC"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "Level")
        dt = ds.Tables("Level")
        LID = ds.Tables(0).Rows(0).Item("levelID").ToString() + 1

        DatabaseConnect()
        If txtvalidatelevel() Then
            sql = "INSERT INTO Level(LevelID, Level) VALUES (@LevelID, @Level)"
            Using cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("levelID", LID)
                cmd.Parameters.AddWithValue("level", Levelfield.Text)
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
            Viewcurrentlevel.PerformClick()
        Else
            MsgBox("one or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the user clicks the add dataset button, which adds the contents of the dataset fields as a new record into the database
    'this sub works like the add subject example above
    Private Sub Adddatasetyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adddatasetyear.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim DID As Integer
        sql = "Select TOP 1 DatasetID FROM DatasetID ORDER BY DatasetID DESC"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "DatasetID")
        dt = ds.Tables("DatasetID")
        DID = ds.Tables(0).Rows(0).Item("DatasetID").ToString() + 1

        DatabaseConnect()
        If txtvalidatedataset() Then
            sql = "INSERT INTO DatasetID(DatasetID, Year) VALUES (@DatasetID, @Year)"
            Using cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("datasetID", DID)
                cmd.Parameters.AddWithValue("year", Datasetyearfield.Text)
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
            Viewcurrentdatasetyear.PerformClick()
        Else
            MsgBox("one or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the user clicks the add gradetype button, which adds the contents of the gradetype fields as a new record into the database
    'this sub works like the add subject example above
    Private Sub Addgradetypebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addgradetypebutton.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim GTID As Integer
        sql = "Select TOP 1 GradeTypeID FROM GradeType ORDER BY GradeTypeID DESC"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "GradeType")
        dt = ds.Tables("GradeType")
        GTID = ds.Tables(0).Rows(0).Item("GradeTypeID").ToString() + 1

        DatabaseConnect()
        If txtvalidategradetype() Then
            sql = "INSERT INTO GradeType (GradeTypeID, GradeType) VALUES (@GradeTypeID, @GradeType)"
            Using cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("GradeTypeID", GTID)
                cmd.Parameters.AddWithValue("GradeType", Newgradetypefield.Text)
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
            Viewcurrentgradetype.PerformClick()
        Else
            MsgBox("one or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the user clicks the add user button, which adds the contents of the userlogin fields as a new record into the database
    'this sub works like the add subject example above
    Private Sub adduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adduser.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim LID As Integer
        sql = "Select TOP 1 LoginID FROM UserLogin ORDER BY LoginID DESC"
        Dim cmmd As New SqlCommand(sql, con)
        da.SelectCommand = cmmd
        da.Fill(ds, "UserLogin")
        dt = ds.Tables("UserLogin")
        LID = ds.Tables(0).Rows(0).Item("LoginID").ToString() + 1

        DatabaseConnect()
        If txtvalidatelogin() Then
            sql = "INSERT INTO UserLogin (LoginID, LoginUsername, Password, Admin) VALUES (@LoginID, @Username, @Password, @Admin)"
            Using cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("LoginID", LID)
                cmd.Parameters.AddWithValue("Username", usernamefield.Text)
                cmd.Parameters.AddWithValue("Password", passwordfield.Text)
                cmd.Parameters.AddWithValue("Admin", adminfield.Text)
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            MsgBox("Record Inserted", MsgBoxStyle.Information)
            viewlogins.PerformClick()
        Else
            MsgBox("one or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'this sub runs when the admin action field changes text value
    Private Sub adminaction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adminaction.SelectedIndexChanged
        'this case sattement selects a series of cases depending on the user's selection choice from the combobox
        Select Case Adminaction.Text
            'if the field is blank then all of these groupboxes are non visible
            Case ""
                Subjectgroup.Visible = False
                Levelgroup.Visible = False
                Addlogingroup.Visible = False
                Viewcurrentvalues.Visible = False
                Gradetypegroup.Visible = False
                Dataset.Visible = False
                Editlogingroup.Visible = False
                'if the field matches this text then all of these groupboxes either become visible or non-visible to the user
            Case "Add a new Dataset Year"
                Subjectgroup.Visible = False
                Levelgroup.Visible = False
                Addlogingroup.Visible = False
                Dataset.Visible = True
                Editlogingroup.Visible = False
                Gradetypegroup.Visible = False
                'this programatically clicks the view dataset year button so that the datagrid also loads with the current selection of datasets
                Viewcurrentdatasetyear.PerformClick()
            Case "Add a new Grade Type"
                Subjectgroup.Visible = False
                Levelgroup.Visible = False
                Addlogingroup.Visible = False
                Dataset.Visible = False
                Editlogingroup.Visible = False
                Gradetypegroup.Visible = True
                Viewcurrentgradetype.PerformClick()
            Case "Add a new Subject"
                Levelgroup.Visible = False
                Addlogingroup.Visible = False
                Gradetypegroup.Visible = False
                Dataset.Visible = False
                Editlogingroup.Visible = False
                Subjectgroup.Visible = True
                Viewcurrentsubjects.PerformClick()
            Case "Add a new Level"
                Subjectgroup.Visible = False
                Addlogingroup.Visible = False
                Gradetypegroup.Visible = False
                Dataset.Visible = False
                Editlogingroup.Visible = False
                Levelgroup.Visible = True
                Viewcurrentlevel.PerformClick()
            Case "Add a new login"
                Subjectgroup.Visible = False
                Gradetypegroup.Visible = False
                Dataset.Visible = False
                Levelgroup.Visible = False
                Addlogingroup.Visible = True
                Editlogingroup.Visible = False
                viewlogins.PerformClick()
            Case "Edit an existing login"
                Subjectgroup.Visible = False
                Gradetypegroup.Visible = False
                Dataset.Visible = False
                Levelgroup.Visible = False
                Addlogingroup.Visible = False
                Editlogingroup.Visible = True
                vieweditlogins.PerformClick()
                Editlogingroup.Visible = False
        End Select
    End Sub
    'this sub runs when the editlogin button is clicked by the user
    Private Sub editlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editlogin.Click
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        DatabaseConnect()

        'sets the update SQL statement
        sql = "UPDATE UserLogin SET LoginUsername = @LoginUsername, Password = @Password, Admin = @Admin WHERE LoginID = '" & loginidfield.Text & "'"
        'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
        Using cmd = New SqlCommand(sql, con)
            'sets the parameters of the vlues to be updated
            cmd.Parameters.AddWithValue("LoginUsername", usernamefield1.Text)
            cmd.Parameters.AddWithValue("Password", passwordfield1.Text)
            cmd.Parameters.AddWithValue("Admin", adminfield1.Text)
            cmd.ExecuteNonQuery()
        End Using
        'closes the database connection
        con.Close()
        'notifies the user with the appropriate message
        MsgBox("Record Updated", MsgBoxStyle.Information)
        'programatically clicks the vieweditlogins sub so that the datagrid refreshes with the new value that has been updated
        vieweditlogins.PerformClick()
    End Sub
    'processes deleteing a subject
    Sub deletesubject(ByVal e)
        'if the button clicked by the user contains the Delete record text the delete function continues processing
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("SubjectRecord").Value = "Delete Record" Then
            'stores varaibles that are set as their corrsponding cell values on the row of the delete record button clicked by the user
            Dim subjectID = Viewcurrentvalues.Rows(e.RowIndex).Cells("SubjectID").Value
            Dim Subject = Viewcurrentvalues.Rows(e.RowIndex).Cells("Subject").Value
            Dim Department = Viewcurrentvalues.Rows(e.RowIndex).Cells("Department").Value
            DatabaseConnect()
            'displays a messagebox with a yes/no input that asks the user if they really want to delete the record
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                'if the result is yes:
                'the SQL delete statement is set
                sql = "DELETE FROM Subject WHERE SubjectID = '" & subjectID & "' AND Subject = '" & Subject & "'"
                'uses cmd as a new SQL command that uses the above SQL statement and the connection string of con
                Using cmd = New SqlCommand(sql, con)
                    'executes teh query
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                'notifies the user with the following message
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                'this commands clicks the viewcurrentsubjects button which essentially refreshes the datagrid
                Viewcurrentsubjects.PerformClick()
                'if the user selects no then the subjectdelete state is set as true and nothing happens
            ElseIf result = DialogResult.No Then
                subjectdelete = True
            End If
        Else
        End If
    End Sub
    'processes deleteing a dataset
    Sub deletedataset(ByVal e)
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("YearRecord").Value = "Delete Record" Then
            Dim DatasetID = Viewcurrentvalues.Rows(e.RowIndex).Cells("DatasetID").Value
            Dim Year = Viewcurrentvalues.Rows(e.RowIndex).Cells("Year").Value
            DatabaseConnect()
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record? THIS CANNOT BE UNDONE", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                sql = "DELETE FROM DatasetID WHERE DatasetID = '" & DatasetID & "' AND Year = '" & Year & "'"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                Viewcurrentdatasetyear.PerformClick()
            ElseIf result = DialogResult.No Then
                Yeardelete = True
            End If
        Else
        End If
    End Sub
    'processes deleteing a user
    Sub deleteuser(ByVal e)
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginRecord").Value = "Delete Record" Then
            Dim LoginID = Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginID").Value
            Dim LoginUsername = Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginUsername").Value
            Dim Password = Viewcurrentvalues.Rows(e.RowIndex).Cells("Password").Value
            DatabaseConnect()
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                sql = "DELETE FROM UserLogin WHERE LoginID = '" & LoginID & "' AND LoginUsername = '" & LoginUsername & "' AND Password = '" & Password & "'"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                viewlogins.PerformClick()
            ElseIf result = DialogResult.No Then
                userdelete = True
            End If
        Else
        End If
    End Sub
    'processes deleteing a gradetype
    Sub deletegradetype(ByVal e)
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("GradetypeRecord").Value = "Delete Record" Then
            Dim GradeTypeID = Viewcurrentvalues.Rows(e.RowIndex).Cells("GradeTypeID").Value
            Dim GradeType = Viewcurrentvalues.Rows(e.RowIndex).Cells("GradeType").Value
            DatabaseConnect()
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                sql = "DELETE FROM GradeType WHERE GradeTypeID = '" & GradeTypeID & "' AND GradeType = '" & GradeType & "'"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                Viewcurrentgradetype.PerformClick()
            ElseIf result = DialogResult.No Then
                GradeTypedelete = True
            End If
        Else
        End If
    End Sub
    'processes editing a user
    Sub edituser(ByVal e)
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginRecord").Value = "Edit Record" Then

            Dim LoginUsername = Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginUsername").Value
            Dim Password = Viewcurrentvalues.Rows(e.RowIndex).Cells("Password").Value
            Dim admin = Viewcurrentvalues.Rows(e.RowIndex).Cells("Admin").Value
            Dim loginid = Viewcurrentvalues.Rows(e.RowIndex).Cells("LoginID").Value
            DatabaseConnect()

            usernamefield1.Text = LoginUsername
            passwordfield1.Text = Password
            adminfield1.Text = admin
            loginidfield.Text = loginid
            Editlogingroup.Visible = True
        End If
    End Sub
    'processes deleteing a level
    Sub deletelevel(ByVal e)
        If Viewcurrentvalues.Rows(e.RowIndex).Cells("LevelRecord").Value = "Delete Record" Then
            Dim LevelID = Viewcurrentvalues.Rows(e.RowIndex).Cells("LevelID").Value
            Dim Level = Viewcurrentvalues.Rows(e.RowIndex).Cells("Level").Value
            DatabaseConnect()
            Dim result As Integer = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                sql = "DELETE FROM Level WHERE LevelID = '" & LevelID & "' AND Level = '" & Level & "'"
                Using cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                MsgBox("Record Deleted From Database", MsgBoxStyle.Information)
                Viewcurrentlevel.PerformClick()
            ElseIf result = DialogResult.No Then
                Leveldelete = True
            End If
        Else
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
            'Percentageschart.Printing.Print(True)
        End If
    End Sub
End Class