'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Login
    'when the login button is clicked the following seqence is run to check the user and password login credentials
    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Loginbutton.Click
        'stores cmd as a sqlcommand()
        Dim Cmd As New SqlCommand
        'stores da as a SQL dataadapter
        Dim da As New SqlDataAdapter
        'stores dt as a datatable
        Dim dt As New DataTable
        'stores ds as a dataset
        Dim ds As New DataSet

        'sets stored variables for the username and password as strings
        Dim password As String
        Dim Username As String
        'Stores the connection variable as an sqlConnection that can create a link between the program and the SQL server
        Dim con As New SqlConnection
        'stores the sql command that is sued to query the SQL Server Database
        Dim sqlquery As New SqlCommand
        'A second username variable is required so that the stored username can be swapped later
        Dim username1 As String

        'This is the connection path that the SQLconection variable follows, using the following ID and password to connect
        con.ConnectionString = "Data Source=STUDENTDEV;Initial Catalog=dn.lsingleton;User ID=dn.lsingleton;Password=6tnwm5"

        Try
            'Tries to connect to the SQL Database.
            con.Open()
        Catch ex As Exception
            'If the SQL database can not been found the following messagebox displays, preventing the program from crashing otherwise
            MsgBox("Can not open SQL Server connection! ")
        End Try

        'Sets the SQL command query of the connection with the following SQL statement
        sqlquery.Connection = con
        sqlquery.CommandText = "SELECT  LoginUsername, Password FROM UserLogin WHERE LoginUsername = '" & txtUsername.Text & "'  AND Password = '" & txtPassword.Text & "'"

        'Creates a stored varieble using a SQL data reader to check if there is a row returned when the SQL statement is carried out
        Dim check As SqlDataReader = sqlquery.ExecuteReader()

        If check.HasRows Then
            While check.Read()

                'checks if the username and password in the text fields match a record from the Database table
                password = check("Password").ToString()
                Username = check("LoginUsername").ToString()

                'Swaps the username variables
                If Username = check("LoginUsername") Then
                    username1 = Username
                End If

                'sets the module usernames and passwords
                modulepassword = txtPassword.Text
                moduleusername = txtUsername.Text

                'displays the main menu form and hides the login from
                Main_Menu.Show()
                Me.Close()


            End While
            'closes the open connection string and data adapter
            con.Close()
            check.Dispose()
            'opens a new database connection
            DatabaseConnect()
            'sets the sql statement
            sql = "SELECT DISTINCT * FROM UserLogin WHERE LoginUsername = '" & moduleusername & "'  AND Password = '" & modulepassword & "'"
            'sets the conncection path as the connectionstring of con from the module
            Cmd.Connection = con
            'sets the command statement as the SQL statement
            Cmd.CommandText = sql
            'the datadapter then uses this SQL command to Query the database
            da.SelectCommand = Cmd
            'the dataadapter retrieves the query results from the SQL statement after connecting to the Database and fills a dataset
            da.Fill(ds, "temp")
            'the datatable variable is then set to the table result of the dataset variable
            moduleuserid = ds.Tables(0).Rows(0).Item("LoginID").ToString()

        Else
            'If the username and password do not match a valid login from the SQL Database table then the following message is displayed to the user
            MessageBox.Show("Invalid Username or Password", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'resets the text of the username and text properties to blank text
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If
    End Sub
End Class