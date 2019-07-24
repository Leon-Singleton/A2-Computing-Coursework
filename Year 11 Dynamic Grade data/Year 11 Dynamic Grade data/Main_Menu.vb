'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Main_Menu
    'The following code is run when the main menu is loaded
    Private Sub MainMenuLoad() Handles Me.Load
        'Stores da as a SQL data adapter
        Dim da As New SqlDataAdapter
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores the Admin ID value which determines whether the logged in user is an admin or a standard user
        Dim AdminID As Integer
        Dim dt As New DataTable

        'Runs the database connect sequence from the module
        DatabaseConnect()

        'Sets the text value of the Currentuser label
        currentuser.Text = ("Currently Logged in as: ")

        'If the username value which has been recieved from the module from is not blank the following sequence is run
        If moduleusername <> "" Then
            'the public sql variable is set
            sql = "Select * FROM Userlogin WHERE LoginUsername = '" & moduleusername & "' AND Password = '" & modulepassword & "' "
            Dim cmmd As New SqlCommand(sql, con)
            'the data adapter creates a connection between the program and the SQL database and uses the SQL statement above to query the database
            da.SelectCommand = cmmd
            'The dataadapter fills the dataset with the result of the SQL query
            da.Fill(ds, "Login")
            'The admin ID value is set as the value of the cell that is part of the Admin column, of the first dataset row 
            AdminID = ds.Tables(0).Rows(0).Item("Admin").ToString()
            'the currentuser label is set as the following text and the username variable that has been passed from the module form
            currentuser.Text = "Currently Logged in as: " & moduleusername
        Else
            'If the username value which has been recieved from the Login from is blank then the current user label text is set as follows
            currentuser.Text = ("Currently Logged in as: ")
        End If
        'if the adminID value is not 1 then the admin controls button is not visible
        If AdminID <> "1" Then
            Adminbutton.Visible = False
            TeacherGroup.Visible = False
            StudentGroup.Visible = False
            Gradegroup.Visible = False
            gradepercentages1.Visible = True
            Predictionsgroup.Text = "Grade"
            Myclassesgroup.Visible = True
            Predictionsgroup.Location = New Point(331, 123)
            Comparegroup.Location = New Point(484, 123)
        Else
            'if the adminID value is 1 then the admin controls button is visible
            Adminbutton.Visible = True
            StudentGroup.Visible = True
            TeacherGroup.Visible = True
            viewgradesbutton.Visible = True
            Myclassesgroup.Visible = False
        End If

        Dim comboindex As New Integer
        comboindex = moduleDataset

            'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
            dt = GenerateCombo("DatasetID", "DatasetID.DatasetID,Year", True)
            'sets the datasource of the combobox
            datasetcombo.DataSource = dt
            'sets the display member of the combobox
            datasetcombo.DisplayMember = "Year"
            'sets the value member of the combobox
        datasetcombo.ValueMember = "DatasetID.DatasetID"
        datasetcombo.SelectedValue = comboindex
    End Sub
    'If the logout icon is clicked the following code is run
    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        'sets the variable result as an information messagebox with yes no options and with the following text
        Dim result As Integer = MessageBox.Show("Do you really want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'if the yes option is clicked the the login form is shown and the main menu form is closed
        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
            'if the no option is cliced then nothing happens
        ElseIf result = DialogResult.No Then
        End If
    End Sub
    'if the student details button is clicked the student details form is showed and the main menu is hidden from the user
    Private Sub studentviewbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentdetailsbutton.Click
        If moduleDataset <> "0" Then
            Student_View.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'if the view grades button is clicked the grade form is showed and the main menu is hidden from the user
    Private Sub gradebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewgradesbutton.Click
        If moduleDataset <> "0" Then
            Grade.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'if the teacher details button is clicked the teacher class view form is showed and the main menu is hidden from the user
    Private Sub teacherbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teacherdetailsbutton.Click
        TeacherView.Show()
        Me.Close()
    End Sub
    'if the predicted grades button is clicked the predicted grades form is showed and the main menu is hidden from the user
    Private Sub predictedgradesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gradepredictsbutton.Click
        Predictions.Show()
        Me.Close()
    End Sub
    'if the teacher classes button is clicked the teacher classes form is showed and the main menu is hidden from the user
    Private Sub teacherClassesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teacherclassesbutton.Click
        If moduleDataset <> "0" Then
            Teacher_Classes.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'if the admin button is clicked the developer features form is showed and the main menu is hidden from the user
    Private Sub Developerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adminbutton.Click
        Developer_Features.Show()
        Me.Close()
    End Sub
    'if the grade percentages button is clicked the grade percentages form is showed and the main menu is hidden from the user
    Private Sub gradepercentagesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gradepercentages.Click
        Grade_Percentages.Show()
        Me.Close()
    End Sub
    'if the student classes button is clicked the student classes form is showed and the main menu is hidden from the user
    Private Sub studentclassesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentClasses.Click
        If moduleDataset <> "0" Then
            Student_Classes.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'if the subjects button is clicked the compare subject percentages form is showed and the main menu is hidden from the user
    Private Sub compareSubjectsbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subjects.Click
        Compare_Subject_Percentages.Show()
        Me.Close()
    End Sub
    'if the classes button is clicked the compare class percentages form is showed and the main menu is hidden from the user
    Private Sub compareClassesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Classes.Click
        Compare_Class_Percentages.Show()
        Me.Close()
    End Sub
    'if the departments button is clicked the compare department percentages form is showed and the main menu is hidden from the user
    Private Sub compareDepartmentsbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Departments.Click
        Compare_Department_Percentages.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gradepercentages1.Click
        'if the grade percentages button is clicked the grade percentages form is showed and the main menu is hidden from the user
        Grade_Percentages.Show()
        Me.Close()
    End Sub
    'if the my classes button is clicked the my classes form is showed and the main menu is hidden from the user
    Private Sub myclassesbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myclassesbutton.Click
        If moduleDataset <> "0" Then
            Myclasses.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    'if the my class grades button is clicked the my class grades form is showed and the main menu is hidden from the user
    Private Sub ClassGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassGrades.Click
        If moduleDataset <> "0" Then
            MyClassGrades.Show()
            Me.Close()
        Else
            MsgBox("Please Select an Academic Year ", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub datasetcombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles datasetcombo.SelectedValueChanged

        'sets the module dataset variable as the selected value of the datasetcombo


        If datasetcombo.Text = "" Then
            moduleDataset = "0"
        Else
            moduleDataset = datasetcombo.SelectedValue.ToString
        End If
    End Sub
End Class