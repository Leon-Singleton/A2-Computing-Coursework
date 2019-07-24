'imports the following system code commands so that i can use them appropriately
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.DataTable
Public Class Compare_Subject_Percentages
    'stores series as an empty string that can be used within this class
    Dim series As String = Nothing
    'i and p are used as an index variable in my for next statements
    Dim i As Integer = 0
    Dim p As Integer = 0
    'these variables store the number of grades counted
    Dim threegrade As Integer = 0
    Dim fourgrade As Integer = 0
    Dim fivegrade As Integer = 0
    Dim Astargrade As Integer
    Dim Agrade As Integer = 0
    Dim Bgrade As Integer = 0
    Dim Cgrade As Integer = 0
    Dim Dgrade As Integer = 0
    Dim Egrade As Integer = 0
    Dim Fgrade As Integer = 0
    Dim Ggrade As Integer = 0
    'this sub runs when the form initally loads
    Private Sub CompareSubject_Percentages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'runs the databaseconnect sub from the public module
        DatabaseConnect()
        'stores dt as datatable
        Dim dt As DataTable
        p = 0

        'Uses the Generate combo function of the module to populate a combobox by passing the table, field and needempty variables to the Generatecombo function and then returning the result in a datatable
        dt = GenerateCombo("Subject", "SubjectID, Subject", True)
        'sets the datasource of the combobox
        SubjectField.DataSource = dt
        'sets the display member of the combobox
        SubjectField.DisplayMember = "Subject"
        'the index of each item in the combobox is set as their corresponding ID from the database
        SubjectField.ValueMember = "SubjectID"

        dt = GenerateCombo("DatasetID", "DatasetID, Year", True)
        Yearfield.DataSource = dt
        Yearfield.DisplayMember = "Year"
        Yearfield.ValueMember = "DatasetID"

        dt = GenerateCombo("Level", "levelID, Level", True)
        Levelfield.DataSource = dt
        Levelfield.DisplayMember = "Level"
        Levelfield.ValueMember = "LevelID"

        dt = GenerateCombo("GradeType", "GradeTypeID, GradeType", True)
        Gradetypefield.DataSource = dt
        Gradetypefield.DisplayMember = "GradeType"
        Gradetypefield.ValueMember = "GradeTypeID"

        'sets the default text of the grapgytypefield
        Graphtypefield.Text = "Standard Grade Percentage Graph"
    End Sub
    'this sub handles the instance the main menu link is clicekd by the user
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'closes this form and shows the main menu form
        Main_Menu.Show()
        Me.Close()
    End Sub
    'this function returns a true or false state depending on whether the conditions within this sub have been met or not
    Public Function textvalidate() As Boolean
        'initially the functions state is set to true
        textvalidate = True
        'if any of the textboxes are left blank then the function returns a false state and the background of the textbox field changes to red, otherwise the background of the textbox changews to white
        If Levelfield.Text = "" Then
            textvalidate = False
            Levelfield.BackColor = Color.Salmon
        Else
            Levelfield.BackColor = Color.White
        End If
        If SubjectField.Text = "" Then
            textvalidate = False
            SubjectField.BackColor = Color.Salmon
        Else
            SubjectField.BackColor = Color.White
        End If
        If Gradetypefield.Text = "" Then
            textvalidate = False
            Gradetypefield.BackColor = Color.Salmon
        Else
            Gradetypefield.BackColor = Color.White
        End If
        If Yearfield.Text = "" Then
            textvalidate = False
            Yearfield.BackColor = Color.Salmon
        Else
            Yearfield.BackColor = Color.White
        End If
    End Function
    'this sub deals with KS4 percentages
    Public Sub kS4percentages()
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores dt as a datatable
        Dim dt As New DataTable

        ' This SQL statement fills a dataset depending on the users department choice
        sql = "SELECT   [A*],[A],[B],[C],[D],[E],[F],[G] FROM Grade PIVOT (Count(GradeID) FOR Grade IN ([A*],[A],[B],[C],[D],[E],[F],[G])) AS PVTTable WHERE SubjectID = '" & SubjectField.SelectedValue & "' and DatasetID = '" & Yearfield.SelectedValue & "' and LevelID = '" & Levelfield.SelectedValue & "' and GradeTypeID = '" & Gradetypefield.SelectedValue & "'"
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'the datatable contents is set as the returned dataset once the SQL statement has filled the dataset
        dt = ds.Tables(0)

        'this for next statement loops itself to the last row containing a grade
        'it counts the number of each grade within the dataset
        For i = 0 To (dt.Rows.Count - 1)
            'if there is a matching grade under any of the columns in the dataset for each row then the count of that corresponding grade count increases by 1
            If dt.Rows(i)("A*").ToString() = "1" Then
                Astargrade = Astargrade + 1
            End If
            If dt.Rows(i)("A").ToString() = "1" Then
                Agrade = Agrade + 1
            End If
            If dt.Rows(i)("B").ToString() = "1" Then
                Bgrade = Bgrade + 1
            End If
            If dt.Rows(i)("C").ToString() = "1" Then
                Cgrade = Cgrade + 1
            End If
            If dt.Rows(i)("D").ToString() = "1" Then
                Dgrade = Dgrade + 1
            End If
            If dt.Rows(i)("E").ToString() = "1" Then
                Egrade = Egrade + 1
            End If
            If dt.Rows(i)("F").ToString() = "1" Then
                Fgrade = Fgrade + 1
            End If
            If dt.Rows(i)("G").ToString() = "1" Then
                Ggrade = Ggrade + 1
            End If
        Next

        'sets the value of the text labels within the table that corresponds to the index value of p
        If p = 0 Then
            'the text values of the labels in the table when the tableviewbutton is clicked are set to their corresponding number of grades counted from the dataset
            tbl1astar.Text = Astargrade & " out of " & dt.Rows.Count
            tbl1a.Text = Agrade & " out of " & dt.Rows.Count
            tbl1b.Text = Bgrade & " out of " & dt.Rows.Count
            tbl1c.Text = Cgrade & " out of " & dt.Rows.Count
            tbl1d.Text = Dgrade & " out of " & dt.Rows.Count
            tbl1e.Text = Egrade & " out of " & dt.Rows.Count
            tbl1f.Text = Fgrade & " out of " & dt.Rows.Count
            tbl1ggrade.Text = Ggrade & " out of " & dt.Rows.Count
            'this sets the label of the table, so the user knows what the data in the table correlates to
            Table1label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            'this sets the atoc label text of the table by adding up all the grades from A* to c and then dividing by the total number of grades in the dataset, which is then converted to a percentage and displayed as a percentage
            tbl1atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt.Rows.Count) * 100) & "%)"
        End If
        If p = 1 Then
            tbl2astar.Text = Astargrade & " out of " & dt.Rows.Count
            tbl2a.Text = Agrade & " out of " & dt.Rows.Count
            tbl2b.Text = Bgrade & " out of " & dt.Rows.Count
            tbl2c.Text = Cgrade & " out of " & dt.Rows.Count
            tbl2d.Text = Dgrade & " out of " & dt.Rows.Count
            tbl2e.Text = Egrade & " out of " & dt.Rows.Count
            tbl2f.Text = Fgrade & " out of " & dt.Rows.Count
            tbl2ggrade.Text = Ggrade & " out of " & dt.Rows.Count
            Table2label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            tbl2atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt.Rows.Count) * 100) & "%)"
        End If
        If p = 2 Then
            tbl3astar.Text = Astargrade & " out of " & dt.Rows.Count
            tbl3a.Text = Agrade & " out of " & dt.Rows.Count
            tbl3b.Text = Bgrade & " out of " & dt.Rows.Count
            tbl3c.Text = Cgrade & " out of " & dt.Rows.Count
            tbl3d.Text = Dgrade & " out of " & dt.Rows.Count
            tbl3e.Text = Egrade & " out of " & dt.Rows.Count
            tbl3f.Text = Fgrade & " out of " & dt.Rows.Count
            tbl3ggrade.Text = Ggrade & " out of " & dt.Rows.Count
            Table3label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            tbl3atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt.Rows.Count) * 100) & "%)"
        End If
        If p = 3 Then
            tbl4astar.Text = Astargrade & " out of " & dt.Rows.Count
            tbl4a.Text = Agrade & " out of " & dt.Rows.Count
            tbl4b.Text = Bgrade & " out of " & dt.Rows.Count
            tbl4c.Text = Cgrade & " out of " & dt.Rows.Count
            tbl4d.Text = Dgrade & " out of " & dt.Rows.Count
            tbl4e.Text = Egrade & " out of " & dt.Rows.Count
            tbl4f.Text = Fgrade & " out of " & dt.Rows.Count
            tbl4ggrade.Text = Ggrade & " out of " & dt.Rows.Count
            Table4label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            tbl4atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt.Rows.Count) * 100) & "%)"
        End If

        'this if statement selects what type of graph to display based on the user's selection
        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            'name of the series is set dynamically depending on users choices
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            'adds a series to the graph
            Subjectpercentageschart.Series.Add(series)
            'adds datapoints to the series of the graph, these points work cumulatively so that each following data point adds all the previous data points values to it
            Subjectpercentageschart.Series(series).Points.AddY(Astargrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Agrade + Astargrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Bgrade + Astargrade + Agrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Cgrade + Astargrade + Agrade + Bgrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Ggrade + Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
        Else
            'name of the series is set dynamically depending on users choices
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            'adds a series to the graph
            Subjectpercentageschart.Series.Add(series)
            'adds datapoints to the series of the graph equivalent to the number of grades counted
            Subjectpercentageschart.Series(series).Points.AddY(Astargrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Agrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Bgrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Cgrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Dgrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Egrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Fgrade / dt.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Ggrade / dt.Rows.Count)
        End If

        'sets the labels of the datapoints on the series 
        Subjectpercentageschart.Series(series).Points(0).AxisLabel = "A*"
        Subjectpercentageschart.Series(series).Points(1).AxisLabel = "A"
        Subjectpercentageschart.Series(series).Points(2).AxisLabel = "B"
        Subjectpercentageschart.Series(series).Points(3).AxisLabel = "C"
        Subjectpercentageschart.Series(series).Points(4).AxisLabel = "D"
        Subjectpercentageschart.Series(series).Points(5).AxisLabel = "E"
        Subjectpercentageschart.Series(series).Points(6).AxisLabel = "F"
        Subjectpercentageschart.Series(series).Points(7).AxisLabel = "G"
    End Sub
    'this sub deals with KS2 percentages and works similarly to the Sub above
    Public Sub KS2percentages()
        Dim ds As New DataSet
        Dim dt As New DataTable

        ' This SQL statement fills a dataset depending on the users class choice
        sql = "SELECT [3],[4],[5] FROM Grade PIVOT (Count(GradeID) FOR Grade IN ([3],[4],[5])) AS PVTTable WHERE SubjectID = '" & SubjectField.SelectedValue & "' and DatasetID = '" & Yearfield.SelectedValue & "' and LevelID = '" & Levelfield.SelectedValue & "' and GradeTypeID = '" & Gradetypefield.SelectedValue & "'"
        ds = generateDataset(sql, "temp")
        dt = ds.Tables(0)

        'counts the number of KS2 grades
        For i = 0 To (dt.Rows.Count - 1)
            If dt.Rows(i)("3").ToString() = "1" Then
                threegrade = threegrade + 1
            End If
            If dt.Rows(i)("4").ToString() = "1" Then
                fourgrade = fourgrade + 1
            End If
            If dt.Rows(i)("5").ToString() = "1" Then
                fivegrade = fivegrade + 1
            End If
        Next

        'sets the type of series to add to the graph based on whether the user wants to see a cumulative or non-cumulative graph
        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            Subjectpercentageschart.Series.Add(series)
            'adds a cumulative series of datapoints
            Subjectpercentageschart.Series(series).Points.AddY(((fivegrade) / dt.Rows.Count))
            Subjectpercentageschart.Series(series).Points.AddY((((fourgrade + fivegrade) / dt.Rows.Count)))
            Subjectpercentageschart.Series(series).Points.AddY((((threegrade + fourgrade + fivegrade) / dt.Rows.Count)))
        Else
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " " & Yearfield.Text
            Subjectpercentageschart.Series.Add(series)
            'adds a non-cumulative series of datapoints
            Subjectpercentageschart.Series(series).Points.AddY(((fivegrade) / dt.Rows.Count))
            Subjectpercentageschart.Series(series).Points.AddY(((fourgrade) / dt.Rows.Count))
            Subjectpercentageschart.Series(series).Points.AddY(((threegrade) / dt.Rows.Count))
        End If

        Subjectpercentageschart.Series(series).Points(0).AxisLabel = "3"
        Subjectpercentageschart.Series(series).Points(1).AxisLabel = "4"
        Subjectpercentageschart.Series(series).Points(2).AxisLabel = "5"
    End Sub
    'this sub deals with A2 prediction percentages
    Public Sub A2Predictions(ByVal sql2 As String)
        'stores subjects
        Dim dt As New DataTable
        'stores students
        Dim dt1 As New DataTable
        'stores studentsgrades
        Dim dt2 As New DataTable
        'stores the grid that will be displayed
        Dim dt3 As New DataTable
        Dim ds As DataSet
        'stores index variables used in my for next statements
        Dim i As Integer
        Dim s As Integer

        'stores the predictedvalue point score of a Grade
        Dim predictedvalue As Double
        'stores the total of all the predictedvalues
        Dim currentpredictedtotal As Double = 0
        'stores the actual predicted grade
        Dim predictedgrade As String
        'stores a subject
        Dim subject As String
        'stores a weighting variable that is applied to the predictedvalue depending on the subject
        Dim GCSEgradeweighting As Double
        'stores the averagepointscore for a student
        Dim averagepointscore As Double
        'stores the ID of a student
        Dim StudentID As Integer

        'queries all of the subjects and places them in alphabetical order
        sql = "SELECT DISTINCT Subject FROM Subject Where Subject.Subject = '" & SubjectField.Text & "' ORDER BY Subject ASC"
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'the dt datatable is filled with the a list of subjects from the database
        dt = ds.Tables(0)

        'the dataset is set after passing the SQL2 statement which is set depending on the user's filter selection, and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql2, "temp")
        'the dt1 table is filled with a list of students
        dt1 = ds.Tables(0)

        'this for next loop loops through every student
        'for eachs student the dt2 datatable is filled with that students grades 
        dt3.Columns.Add("Grade")
        For i = 0 To (dt1.Rows.Count - 1)
            averagepointscore = 0
            currentpredictedtotal = 0
            StudentID = dt1.Rows(i)("StudentID").ToString()
            sql = "SELECT DISTINCT Grade.GradeID, Student.Firstname, Student.Surname, Subject.Subject, Grade.Grade, [Level].[Level], GradeType.GradeType, DatasetID.Year FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.StudentId = '" & StudentID & "'  ORDER BY GradeID ASC"
            ds = generateDataset(sql, "temp")
            dt2 = ds.Tables(0)

            'this variable is used to count the number of GCSE grades a student has
            Dim count As Integer
            count = 0

            'this for next statement then loops through all of a students grades and then applies a predictedvalue depending on the grade, this grade later has a weighting applied to it
            For s = 0 To (dt2.Rows.Count - 1)

                'if the value of the grade underneath the Grade header in the datatable on the row of the i index is an A* then this if statement runs
                If dt2.Rows(s)("Grade").ToString() = "A*" Then
                    'the GCSE gradeweighting variable is recieved after passing the datatable and the row index into the GCSEgradeweighting function in the public module
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    'the predicted value is set as a national value but then is multiplied by the weighting value
                    predictedvalue = 58 * GCSEgradeweighting
                    count = count + 1
                End If
                'all of the following if statements work like the one above for all the other different grades
                If dt2.Rows(s)("Grade").ToString() = "A" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 52 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "B" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 46 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "C" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 40 * GCSEgradeweighting
                    count = count + 1

                End If
                If dt2.Rows(s)("Grade").ToString() = "D" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 34 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "E" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 28 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "F" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 22 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "G" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 16 * GCSEgradeweighting
                    count = count + 1
                End If
                If dt2.Rows(s)("Grade").ToString() = "4" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 0
                End If
                If dt2.Rows(s)("Grade").ToString() = "5" Then
                    GCSEgradeweighting = GCSEGradewighting(s, dt2)
                    predictedvalue = 0
                End If
                'the current predicted total equals the previous currentpredicted total + the predicted value
                currentpredictedtotal = currentpredictedtotal + predictedvalue
            Next

            'a mean average point score for the student is created by taking the total of all the predicted values and dividing by the number of grades
            averagepointscore = currentpredictedtotal / count

            'the subject variable is set as the value of the subject field
            subject = SubjectField.Text
            'the actual predicted grade is set by passing the subject, row index, datatable and average point score to the A2predictedgrade sub in the public module
            predictedgrade = A2predictedgrade(subject, 0, dt, averagepointscore)
            'the predicted grade is then written on the row index of i underneath the grade header 
            dt3.Rows.Add()
            dt3.Rows(i)("Grade") = predictedgrade
        Next

        'this for next statement loops itself to the last row containing a grade
        'it counts the number of each grade within the dataset
        For i = 0 To (dt3.Rows.Count - 1)
            'if there is a 1 under any of the columns in the dataset for each row then the count of that corresponding grade increases by 1

            If dt3.Rows(i)("Grade").ToString() = "A*" Then
                Astargrade = Astargrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "A" Then
                Agrade = Agrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "B" Then
                Bgrade = Bgrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "C" Then
                Cgrade = Cgrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "D" Then
                Dgrade = Dgrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "E" Then
                Egrade = Egrade + 1
            End If
            If dt3.Rows(i)("Grade").ToString() = "F" Then
                Fgrade = Fgrade + 1
            End If
        Next

        'sets the value of the text labels within the table that corresponds to the index value of p
        If p = 0 Then
            'the text values of the labels in the table when the tableviewbutton is clicked are set to their corresponding number of grades counted from the dataset
            tbl1g.Visible = False
            tbl1ggrade.Visible = False
            Utable1.Text = "U"
            tbl1astar.Text = Astargrade & " out of " & dt3.Rows.Count
            tbl1a.Text = Agrade & " out of " & dt3.Rows.Count
            tbl1b.Text = Bgrade & " out of " & dt3.Rows.Count
            tbl1c.Text = Cgrade & " out of " & dt3.Rows.Count
            tbl1d.Text = Dgrade & " out of " & dt3.Rows.Count
            tbl1e.Text = Egrade & " out of " & dt3.Rows.Count
            tbl1f.Text = Fgrade & " out of " & dt3.Rows.Count
            'this sets the label of the table, so the user knows what the data in the table correlates to
            Table1label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicts " & Yearfield.Text
            'this sets the atoc label text of the table by adding up all the grades from A* to c and then dividing by the total number of grades in the dataset, which is then converted to a percentage and displayed as a percentage
            tbl1atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt3.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt3.Rows.Count) * 100) & "%)"
        End If
        If p = 1 Then
            tbl2g.Visible = False
            tbl2ggrade.Visible = False
            Utable2.Text = "U"
            tbl2astar.Text = Astargrade & " out of " & dt3.Rows.Count
            tbl2a.Text = Agrade & " out of " & dt3.Rows.Count
            tbl2b.Text = Bgrade & " out of " & dt3.Rows.Count
            tbl2c.Text = Cgrade & " out of " & dt3.Rows.Count
            tbl2d.Text = Dgrade & " out of " & dt3.Rows.Count
            tbl2e.Text = Egrade & " out of " & dt3.Rows.Count
            tbl2f.Text = Fgrade & " out of " & dt3.Rows.Count
            Table2label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicts " & Yearfield.Text
            tbl2atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt3.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt3.Rows.Count) * 100) & "%)"
        End If
        If p = 2 Then
            tbl3g.Visible = False
            tbl3ggrade.Visible = False
            Utable3.Text = "U"
            tbl3astar.Text = Astargrade & " out of " & dt3.Rows.Count
            tbl3a.Text = Agrade & " out of " & dt3.Rows.Count
            tbl3b.Text = Bgrade & " out of " & dt3.Rows.Count
            tbl3c.Text = Cgrade & " out of " & dt3.Rows.Count
            tbl3d.Text = Dgrade & " out of " & dt3.Rows.Count
            tbl3e.Text = Egrade & " out of " & dt3.Rows.Count
            tbl3f.Text = Fgrade & " out of " & dt3.Rows.Count
            Table3label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicts " & Yearfield.Text
            tbl3atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt3.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt3.Rows.Count) * 100) & "%)"
        End If
        If p = 3 Then
            tbl4g.Visible = False
            tbl4ggrade.Visible = False
            Utable4.Text = "U"
            tbl4astar.Text = Astargrade & " out of " & dt3.Rows.Count
            tbl4a.Text = Agrade & " out of " & dt3.Rows.Count
            tbl4b.Text = Bgrade & " out of " & dt3.Rows.Count
            tbl4c.Text = Cgrade & " out of " & dt3.Rows.Count
            tbl4d.Text = Dgrade & " out of " & dt3.Rows.Count
            tbl4e.Text = Egrade & " out of " & dt3.Rows.Count
            tbl4f.Text = Fgrade & " out of " & dt3.Rows.Count
            Table4label.Text = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicts " & Yearfield.Text
            tbl4atoc.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt3.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt3.Rows.Count) * 100) & "%)"
        End If

        'this if statement selects what type of graph to display based on the user's selection
        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            'name of the series is set dynamically depending on users choices
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicted " & Yearfield.Text
            'adds a series to the graph
            Subjectpercentageschart.Series.Add(series)
            'adds datapoints to the series of the graph, these points work cumulatively so that each following data point adds all the previous data points values to it
            Subjectpercentageschart.Series(series).Points.AddY(Astargrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Agrade + Astargrade) / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Bgrade + Astargrade + Agrade) / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Cgrade + Astargrade + Agrade + Bgrade) / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY((Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
        Else
            'name of the series is set dynamically depending on users choices
            series = "Subject " & p + 1 & ": " & SubjectField.Text & " A2 Predicted " & Yearfield.Text
            'adds a series to the graph
            Subjectpercentageschart.Series.Add(series)
            'adds datapoints to the series of the graph equivalent to the number of grades counted
            Subjectpercentageschart.Series(series).Points.AddY(Astargrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Agrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Bgrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Cgrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Dgrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Egrade / dt3.Rows.Count)
            Subjectpercentageschart.Series(series).Points.AddY(Fgrade / dt3.Rows.Count)
        End If

        'sets the labels of the datapoints on the series 
        Subjectpercentageschart.Series(series).Points(0).AxisLabel = "A*"
        Subjectpercentageschart.Series(series).Points(1).AxisLabel = "A"
        Subjectpercentageschart.Series(series).Points(2).AxisLabel = "B"
        Subjectpercentageschart.Series(series).Points(3).AxisLabel = "C"
        Subjectpercentageschart.Series(series).Points(4).AxisLabel = "D"
        Subjectpercentageschart.Series(series).Points(5).AxisLabel = "E"
        Subjectpercentageschart.Series(series).Points(6).AxisLabel = "U"
    End Sub
    'this sub runs when the view percentages button is clicked by the user
    Private Sub Addsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addsearch.Click
        'if the state of the txtvalidate function is true then the following code runs
        If textvalidate() = True Then
            'this if statement validates the users selection, since only english language or maths are stored for KS2, the program prevents the user from displaying an empty graph for KS2 if any other subject is chosen. An appropriate error message is also displayed
            If Levelfield.Text = "KS2" And SubjectField.Text <> "English Language" And SubjectField.Text <> "Maths" Then
                MsgBox("That subject is not a part of that KeyStage(Level)", MsgBoxStyle.Information, MessageBoxButtons.OK)
            Else
                'prevents the user from adding more than 4 series
                If p = 4 Then
                    MsgBox("You cannot compare any more than 4 Chart series")
                Else
                    'the count of the grade variables are reset to 0
                    Astargrade = 0
                    Agrade = 0
                    Bgrade = 0
                    Cgrade = 0
                    Dgrade = 0
                    Egrade = 0
                    Fgrade = 0
                    Ggrade = 0
                    threegrade = 0
                    fourgrade = 0
                    fivegrade = 0

                    'stores a dataset
                    Dim ds As New DataSet
                    'stores a datatable
                    Dim dt As New DataTable

                    'the current graph series and title labels are cleared if they have already been set
                    Subjectpercentageschart.Titles.Clear()
                    'the toggle labels button becmoes visible
                    labelstoggle.Visible = True

                    'calls the Loadgraphic class
                    Dim objPlsWait As New clsOPAWaitScreen
                    objPlsWait.ShowWaitScreen("")


                    If Gradetypefield.Text = "A2 Predicted" Then

                        tabletitle1.Text = "Number of Student's Predicted Grade"
                        tabletitle2.Text = "Number of Student's Predicted Grade"
                        tabletitle3.Text = "Number of Student's Predicted Grade"
                        tabletitle4.Text = "Number of Student's Predicted Grade"

                        'sets the chart label text depending on the users graphtype selection
                        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
                            chartlabel.Text = "Cumulative Predictions by Grade (%)"
                        Else
                            chartlabel.Text = "Percentage of Students Predicted a Grade (%)"
                        End If

                        'selects all students within the year the user has selected in the yearfield
                        Dim sql2 As String
                        sql2 = "SELECT DISTINCT Student.StudentID, Student.Firstname, Student.Surname FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.DatasetID = '" & Yearfield.SelectedValue & "' ORDER BY Student.StudentID ASC"
                        'passes the SQl statement to the A2predictions sub
                        A2Predictions(sql2)

                    Else

                        'sets the chart label text depending on the users graphtype selection
                        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
                            chartlabel.Text = "Cumulative Percentage by Grade (%)"
                        Else
                            chartlabel.Text = "Percentage of Students Achieving a Grade (%)"
                        End If

                        If Levelfield.Text = "KS4" Then
                            'if the levelfield value is KS4 then this code runs
                            'runs the KS4 percentages sub
                            kS4percentages()
                            'the graph becomes visible
                            Subjectpercentageschart.Visible = True
                        Else
                            'runs the KS2 percentages sub
                            KS2percentages()
                            'the graph becomes visible
                            Subjectpercentageschart.Visible = True
                        End If
                    End If

                'disables the legend from the graph
                Subjectpercentageschart.Series(p).IsVisibleInLegend = True
                'shows the values of datapoints
                Subjectpercentageschart.Series(p).IsValueShownAsLabel = True
                'sets the colour of the datapoint labels as maroon
                Subjectpercentageschart.Series(p).ChartType = DataVisualization.Charting.SeriesChartType.Line
                'changes the chart colour to skyblue
                Subjectpercentageschart.Series(p).LabelForeColor = Color.Maroon
                'changes the chart to a 3D bar style
                Subjectpercentageschart.Series(0).Color = Color.DarkGreen
                'sets the minimum and maximum axis
                Subjectpercentageschart.ChartAreas(0).AxisY.Minimum = 0
                Subjectpercentageschart.ChartAreas(0).AxisY.Maximum = 1
                'sets the format of the chart labels
                Subjectpercentageschart.ChartAreas(0).AxisY.LabelStyle.Format = "#%"
                'sets the format of the series labels
                Subjectpercentageschart.Series(p).LabelFormat = "##.##" & "%"
                'sets the colour of the axis labels
                Subjectpercentageschart.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Maroon
                Subjectpercentageschart.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Maroon
                'sets the background of the chart as transparent
                Subjectpercentageschart.ChartAreas(0).BackColor = Color.Transparent
                'increments the value of p by 1 as a new series is added by the user
                p = p + 1
                'graph becoms visible
                Subjectpercentageschart.Visible = True
                'if the user selects KS4 then the groupview groupbox is visible
                If Levelfield.Text = "KS4" Then
                    Groupview.Visible = True
                End If

                'these fields are no longer enables so that the user cannot add a series for KS2 and KS4, or add a series ofr one graph type and a series for the other graph type
                Gradetypefield.Enabled = False
                Graphtypefield.Enabled = False
                Levelfield.Enabled = False

                    'closes the loadgraphic wait and resets its objplswait variable
                    objPlsWait.CloseWaitScreen()
                    objPlsWait = Nothing
                    Addsearch.Text = "Add Series"
                End If
            End If
        Else
            'if the state of the txtvalidate function is not true then the following error message displays and nothing else happens
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If

    End Sub
    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        CompareSubject_Percentages(e, e)
    End Sub
    'this sub runs when the toggle labels button is clicked by the user
    Private Sub labelstoggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelstoggle.Click
        'stores an index variable
        Dim s As Integer
        'if the user wishes to turn chart labels off then the following code runs
        If labelstoggle.Text = "Toggle Chart Labels Off" Then
            'this for next statemnt goes through every series that has been added by the user and turns off labels for that series
            For s = 0 To (p - 1)
                Subjectpercentageschart.Series(s).IsValueShownAsLabel = False
            Next
            'changes the text of the button 
            labelstoggle.Text = "Toggle Chart Labels On"
            'but if the user wishes to turn chart labels on then the following code runs
        ElseIf labelstoggle.Text = "Toggle Chart Labels On" Then
            For s = 0 To (p - 1)
                Subjectpercentageschart.Series(s).IsValueShownAsLabel = True
            Next
            'changes the text of the button 
            labelstoggle.Text = "Toggle Chart Labels Off"
        End If
    End Sub
    'this sub runs when the view graph button is clicked by the user
    Private Sub Graphview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graphview.Click
        'the following objects are set to either visible or non-visible
        'all tables and table headings are no longer visible
        Subjectpercentageschart.Visible = True
        Comparesubjectgroup.Visible = True
        labelstoggle.Visible = True
        Table1label.Visible = False
        Table2label.Visible = False
        Table3label.Visible = False
        Table4label.Visible = False
        Seriestable1.Visible = False
        Seriestable2.Visible = False
        Seriestable3.Visible = False
        Seriestable4.Visible = False
    End Sub
    'this sub runs when the view number of students... button is clicked by the user
    Private Sub TablesView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablesView.Click
        'the following objects are set to non-visible
        Subjectpercentageschart.Visible = False
        Comparesubjectgroup.Visible = False
        labelstoggle.Visible = False
        'the following tables and table headings become visible depending on the value of p as it is incrmented
        Select Case (p)
            Case 1
                Table1label.Visible = True
                Seriestable1.Visible = True
            Case 2
                Table1label.Visible = True
                Seriestable1.Visible = True
                Table2label.Visible = True
                Seriestable2.Visible = True
            Case 3
                Table1label.Visible = True
                Seriestable1.Visible = True
                Table2label.Visible = True
                Seriestable2.Visible = True
                Seriestable3.Visible = True
                Table3label.Visible = True
            Case 4
                Table1label.Visible = True
                Seriestable1.Visible = True
                Table2label.Visible = True
                Seriestable2.Visible = True
                Seriestable3.Visible = True
                Table3label.Visible = True
                Table4label.Visible = True
                Seriestable4.Visible = True
        End Select
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
    'this sub determines whether the gradetypefield is enabled, depending on hte user's level choice.
    Private Sub Levelfield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Levelfield.SelectedIndexChanged
        If Levelfield.Text = "KS2" Then
            Gradetypefield.Enabled = False
            Gradetypefield.Text = "Achieved"
        Else
            Gradetypefield.Enabled = True
        End If
    End Sub
End Class