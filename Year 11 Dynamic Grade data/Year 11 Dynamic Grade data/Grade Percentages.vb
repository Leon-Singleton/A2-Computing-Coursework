Public Class Grade_Percentages
    'stores series as an empty string that can be used within this class
    Dim series As String = Nothing
    'i is used as an index variable in my for next statements
    Dim i As Integer = 0

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
    Private Sub Grade_Percentages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'runs the databaseconnect sub from the public module
        DatabaseConnect()
        'sets the screenarea of the form so that it is displayed center screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        'stores dt as datatable
        Dim dt As DataTable

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

        'the text of the graphtype combobox is set as following
        Graphtypefield.Text = "Standard Grade Percentage Graph"
    End Sub
    'this sub deals with KS4 percentages
    Public Sub kS4percentages()
        'stores ds as a dataset
        Dim ds As New DataSet
        'stores dt as a datatable
        Dim dt As New DataTable

        ' This SQL statement uses a pivot to create a custom set of columns that writes a 1 or 0 under that column if the corrsponding grade belongs under that column, a 0 means that row does not have that grade, a 1 in the pivot table means that row does have a grade eqiuvalent to its column value
        sql = "SELECT   [A*],[A],[B],[C],[D],[E],[F],[G] FROM Grade PIVOT (Count(GradeID) FOR Grade IN ([A*],[A],[B],[C],[D],[E],[F],[G])) AS PVTTable WHERE SubjectID = '" & SubjectField.SelectedValue & "' and DatasetID = '" & Yearfield.SelectedValue & "' and LevelID = '" & Levelfield.SelectedValue & "' and GradeTypeID = '" & Gradetypefield.SelectedValue & "'"
        'the dataset is set after passing the following SQL statement and table into the GenerateDataset sub of the public module
        ds = generateDataset(sql, "temp")
        'the datatable contents is set as the returned dataset once the SQL statement has filled the dataset
        dt = ds.Tables(0)

        'this for next statement loops itself to the last row containing a grade
        'it counts the number of each grade within the dataset
        For i = 0 To (dt.Rows.Count - 1)
            'if there is a 1 under any of the columns in the dataset for each row then the count of that corresponding grade increases by 1

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

        'the text values of the labels in the table when the tableviewbutton is clicked are set to their corresponding number of grades counted from the dataset
        gradeAstar.Text = Astargrade & " out of " & dt.Rows.Count
        gradeA.Text = Agrade & " out of " & dt.Rows.Count
        gradeB.Text = Bgrade & " out of " & dt.Rows.Count
        gradeC.Text = Cgrade & " out of " & dt.Rows.Count
        gradeD.Text = Dgrade & " out of " & dt.Rows.Count
        gradeE.Text = Egrade & " out of " & dt.Rows.Count
        Utable1.Text = "F"
        gradeF.Text = Fgrade & " out of " & dt.Rows.Count
        gradeG.Text = Ggrade & " out of " & dt.Rows.Count
        KS4Table.Size = New Size(358, 211)

        'this sets the atoc label text of the table by adding up all the grades from A* to c and then dividing by the total number of grades in the dataset, which is then converted to a percentage and displayed as a percentage
        AtoC.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt.Rows.Count) * 100) & "%)"

        'this if statement selects what type of graph to display based on the user's selection

        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            'if the user wants to see a cumulative graph then the name of the graph changes
            series = "Cumulative Grade Percentage"
            'adds a series to the graph
            Percentageschart.Series.Add(series)
            'adds datapoints to the series of the graph, these points work cumulatively so that each following data point adds all the previous data points values to it
            Percentageschart.Series(series).Points.AddY(Astargrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Agrade + Astargrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Bgrade + Astargrade + Agrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Cgrade + Astargrade + Agrade + Bgrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Ggrade + Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt.Rows.Count)
        Else
            'if the user wants to see a non-cumulative graph then the name of the graph changes
            series = "Non-Cumulative Grade Percentage"
            'adds a series to the graph
            Percentageschart.Series.Add(series)
            'adds datapoints to the series of the graph equivalent to the number of grades counted
            Percentageschart.Series(series).Points.AddY(Astargrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Agrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Bgrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Cgrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Dgrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Egrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Fgrade / dt.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Ggrade / dt.Rows.Count)
        End If
        'sets the labels of the datapoints on the series 
        Percentageschart.Series(series).Points(0).AxisLabel = "A*"
        Percentageschart.Series(series).Points(1).AxisLabel = "A"
        Percentageschart.Series(series).Points(2).AxisLabel = "B"
        Percentageschart.Series(series).Points(3).AxisLabel = "C"
        Percentageschart.Series(series).Points(4).AxisLabel = "D"
        Percentageschart.Series(series).Points(5).AxisLabel = "E"
        Percentageschart.Series(series).Points(6).AxisLabel = "F"
        Percentageschart.Series(series).Points(7).AxisLabel = "G"
    End Sub
    'this sub deals with KS2 percentages and works similarly to the Sub above
    Public Sub KS2percentages()
        Dim ds As New DataSet
        Dim dt As New DataTable

        'a pivot table is also used here to return a dataset that writes a 1 or a 0 if there is a corrsponding grade on that row under each column
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
        'sets the text values of the labels within the table when the tableview button is clicked
        Grade3.Text = threegrade & " out of " & dt.Rows.Count
        Grade4.Text = fourgrade & " out of " & dt.Rows.Count
        Grade5.Text = fivegrade & " out of " & dt.Rows.Count

        'sets the type of series to add to the graph based on whether the user wants to see a cumulative or non-cumulative graph
        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            series = "Cumulative Grade Percentage"
            Percentageschart.Series.Add(series)
            'adds a cumulative series of datapoints
            Percentageschart.Series(series).Points.AddY(((fivegrade) / dt.Rows.Count))
            Percentageschart.Series(series).Points.AddY((((fourgrade + fivegrade) / dt.Rows.Count)))
            Percentageschart.Series(series).Points.AddY((((threegrade + fourgrade + fivegrade) / dt.Rows.Count)))
        Else
            series = "Non-Cumulative Grade Percentage"
            Percentageschart.Series.Add(series)
            'adds a non-cumulative series of datapoints
            Percentageschart.Series(series).Points.AddY(((fivegrade) / dt.Rows.Count))
            Percentageschart.Series(series).Points.AddY(((fourgrade) / dt.Rows.Count))
            Percentageschart.Series(series).Points.AddY(((threegrade) / dt.Rows.Count))
        End If
        'sets the datapoint labels of the graph
        Percentageschart.Series(series).Points(0).AxisLabel = "3"
        Percentageschart.Series(series).Points(1).AxisLabel = "4"
        Percentageschart.Series(series).Points(2).AxisLabel = "5"
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
        sql = "SELECT DISTINCT Subject FROM Subject Where Subject.Subject = '" & SubjectField.Text & "' Order By Subject ASC"
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

        'the text values of the labels in the table when the tableviewbutton is clicked are set to their corresponding number of grades counted from the dataset
        gradeAstar.Text = Astargrade & " out of " & dt3.Rows.Count
        gradeA.Text = Agrade & " out of " & dt3.Rows.Count
        gradeB.Text = Bgrade & " out of " & dt3.Rows.Count
        gradeC.Text = Cgrade & " out of " & dt3.Rows.Count
        gradeD.Text = Dgrade & " out of " & dt3.Rows.Count
        gradeE.Text = Egrade & " out of " & dt3.Rows.Count
        Utable1.Text = "U"
        gradeF.Text = Fgrade & " out of " & dt3.Rows.Count
        KS4Table.Size = New Size(358, 187)

        'this sets the atoc label text of the table by adding up all the grades from A* to c and then dividing by the total number of grades in the dataset, which is then converted to a percentage and displayed as a percentage
        AtoC.Text = (Agrade + Bgrade + Cgrade + Astargrade) & " out of " & dt3.Rows.Count & " (~" & Int(((Agrade + Bgrade + Cgrade + Astargrade) / dt3.Rows.Count) * 100) & "%)"

        'this if statement selects what type of graph to display based on the user's selection

        If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
            'if the user wants to see a cumulative graph then the name of the graph changes
            series = "Cumulative Grade Percentage"
            'adds a series to the graph
            Percentageschart.Series.Add(series)
            'adds datapoints to the series of the graph, these points work cumulatively so that each following data point adds all the previous data points values to it
            Percentageschart.Series(series).Points.AddY(Astargrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Agrade + Astargrade) / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Bgrade + Astargrade + Agrade) / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Cgrade + Astargrade + Agrade + Bgrade) / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY((Fgrade + Egrade + Dgrade + Astargrade + Agrade + Bgrade + Cgrade) / dt3.Rows.Count)
        Else
            'if the user wants to see a non-cumulative graph then the name of the graph changes
            series = "Non-Cumulative Grade Percentage"
            'adds a series to the graph
            Percentageschart.Series.Add(series)
            'adds datapoints to the series of the graph equivalent to the number of grades counted
            Percentageschart.Series(series).Points.AddY(Astargrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Agrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Bgrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Cgrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Dgrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Egrade / dt3.Rows.Count)
            Percentageschart.Series(series).Points.AddY(Fgrade / dt3.Rows.Count)
        End If
        'sets the labels of the datapoints on the series 
        Percentageschart.Series(series).Points(0).AxisLabel = "A*"
        Percentageschart.Series(series).Points(1).AxisLabel = "A"
        Percentageschart.Series(series).Points(2).AxisLabel = "B"
        Percentageschart.Series(series).Points(3).AxisLabel = "C"
        Percentageschart.Series(series).Points(4).AxisLabel = "D"
        Percentageschart.Series(series).Points(5).AxisLabel = "E"
        Percentageschart.Series(series).Points(6).AxisLabel = "U"
    End Sub
    'this sub runs when the view percentages button is clicked by the user
    Private Sub Addsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addsearch.Click
        'if the state of the txtvalidate function is true then the following code runs
        If textvalidate() = True Then
            'this if statement validates the users selection, since only english language or maths are stored for KS2, the program prevents the user from displaying an empty graph for KS2 if any other subject is chosen. An appropriate error message is also displayed
            If Levelfield.Text = "KS2" And SubjectField.Text <> "English Language" And SubjectField.Text <> "Maths" Then
                MsgBox("That subject is not a part of that KeyStage(Level)", MsgBoxStyle.Information, MessageBoxButtons.OK)
            Else
                'the values of the following variables are all reset to 0 if they have been previously set
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
                i = 0

                'calls the Loadgraphic class
                Dim objPlsWait As New clsOPAWaitScreen
                objPlsWait.ShowWaitScreen("")

                'the current graph series and title labels are cleared if they have already been set
                Percentageschart.Series.Clear()
                Percentageschart.Titles.Clear()

                If Gradetypefield.Text = "A2 Predicted" Then

                    'selects all students within the year the user has selected in the yearfield
                    Dim sql2 As String
                    sql2 = "SELECT DISTINCT Student.StudentID, Student.Firstname, Student.Surname FROM StudentGroup INNER JOIN Class ON StudentGroup.ClassID = Class.ClassID INNER JOIN Grade INNER JOIN[Level] ON Grade.LevelID = [Level].LevelID INNER JOIN GradeType ON Grade.GradeTypeID = GradeType.GradeTypeID INNER JOIN Student ON Grade.StudentID = Student.StudentID ON StudentGroup.StudentID = Student.StudentID INNER JOIN Subject ON Grade.SubjectID = Subject.SubjectID INNER JOIN DatasetID ON Grade.DatasetID = DatasetID.DatasetID WHERE Student.DatasetID = '" & Yearfield.SelectedValue & "' ORDER BY Student.StudentID ASC"
                    'passes the SQl statement to the A2predictions sub
                    A2Predictions(sql2)

                    'sets the chart label text depending on the users graphtype selection
                    If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
                        chartlabel.Text = "Cumulative Predictions by Grade (%)"
                    Else
                        chartlabel.Text = "Percentage of Students Predicted a Grade (%)"
                    End If

                    'sets the table labels text depending on the users graphtype selection
                    If Gradetypefield.Text = "A2 Predicted" Then
                        tabletitle.Text = "Number of Student's Predicted Grade"
                        table2title.Text = "Number of Students Predicted Grades A*-C"
                    Else
                        tabletitle.Text = "Number of Student's Achieving Grade"
                        table2title.Text = "Number of Students Achieved Grades A*-C"
                    End If

                    'sets which objects on the form are visible
                    AtoCtable.Visible = True
                    KS4Table.Visible = True
                    KS2table.Visible = False
                    chartlabel.Visible = True
                    Percentageschart.Visible = True


                ElseIf Gradetypefield.Text <> "A2 Predicted" Then

                    'sets the chart label text depending on the users graphtype selection
                    If Graphtypefield.Text = "Cumulative Grade Percentage Graph" Then
                        chartlabel.Text = "Cumulative Percentage by Grade (%)"
                    Else
                        chartlabel.Text = "Percentage of Students Achieving a Grade (%)"
                    End If

                    'sets the table labels text depending on the users graphtype selection
                    If Gradetypefield.Text <> "A2 Predicted" Then
                        tabletitle.Text = "Number of Student's Achieving Grade"
                        table2title.Text = "Number of Students Achieved Grades A*-C"
                    Else
                        tabletitle.Text = "Number of Student's Predicted Grade"
                        table2title.Text = "Number of Students Predicted Grades A*-C"
                    End If

                    If Levelfield.Text = "KS4" Then
                        'if the levelfield value is KS4 then this code runs
                        'runs the KS4 percentages sub
                        kS4percentages()
                        'sets which objects on the form are visible
                        AtoCtable.Visible = True
                        KS4Table.Visible = True
                        KS2table.Visible = False
                        chartlabel.Visible = True
                        Percentageschart.Visible = True
                    Else
                        'if the levelfield value is not KS4 then this code runs
                        'runs the KS" percentages sub
                        KS2percentages()
                        'sets which objects on the form are visible
                        AtoCtable.Visible = False
                        KS4Table.Visible = False
                        KS2table.Visible = True
                        chartlabel.Visible = True
                        Percentageschart.Visible = True
                    End If
                End If

                'disables the legend from the graph
                Percentageschart.Series(0).IsVisibleInLegend = False
                'shows the values of datapoints
                Percentageschart.Series(0).IsValueShownAsLabel = True
                'sets the colour of the datapoint labels as maroon
                Percentageschart.Series(0).LabelForeColor = Color.Maroon
                'changes the chart colour to skyblue
                Percentageschart.Series(0).Color = Color.SkyBlue
                'changes the chart to a 3D bar style
                Percentageschart.ChartAreas(0).Area3DStyle.Enable3D = True
                'sets the minimum and maximum axis
                Percentageschart.ChartAreas(0).AxisY.Minimum = 0
                Percentageschart.ChartAreas(0).AxisY.Maximum = 1
                'sets the format of the chart labels
                Percentageschart.ChartAreas(0).AxisY.LabelStyle.Format = "#%"
                'sets the format of the series labels
                Percentageschart.Series(0).LabelFormat = "##.##" & "%"
                'sets the colour of the axis labels
                Percentageschart.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Maroon
                Percentageschart.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Maroon
                'sets the background of the chart as transparent
                Percentageschart.ChartAreas(0).BackColor = Color.Transparent

                'the following object is set to visible to the user
                Groupview.Visible = True
                'closes the loadgraphic wait and resets its objplswait variable
                objPlsWait.CloseWaitScreen()
                objPlsWait = Nothing
            End If
        Else
            'if the state of the txtvalidate function is not true then the following error message displays and nothing else happens
            MsgBox("One or more textboxes have not been completed", MsgBoxStyle.Information, MessageBoxButtons.OK)
        End If
        'throbber.Visible = False
    End Sub
    'this sub runs when the main menu is clicked by the user
    Private Sub MainMenu_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MainMenu.LinkClicked
        'shows or closes the following forms
        Main_Menu.Show()
        Me.Close()
    End Sub
    'this sub runs when the view graph button is clicked by the user
    Private Sub Graphview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graphview.Click
        'the following objects are set to either visible or non-visible
        'the table and table headings are no longer visible
        Percentageschart.Visible = True
        KS4Table.Visible = False
        KS2table.Visible = False
        AtoCtable.Visible = False
        chartlabel.Visible = True
    End Sub
    'this sub runs when the view number of students... button is clicked by the user
    Private Sub TablesView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablesView.Click
        'the following objects are set to either visible or non-visible
        Percentageschart.Visible = False
        chartlabel.Visible = False
        'sets which tables to display depending on the level the usr has selected to view
        If Levelfield.Text = "KS4" Then
            AtoCtable.Visible = True
            KS4Table.Visible = True
            KS2table.Visible = False
        Else
            KS2table.Visible = True
            AtoCtable.Visible = False
            KS4Table.Visible = False
        End If
    End Sub
    'this sub is run when the Clear Selection button is clicked
    Private Sub Clearselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearselection.Click
        'clears all controls on this form
        Me.Controls.Clear()
        're-initializes all components of this form
        InitializeComponent()
        'then re-loads this form with all components reset
        Grade_Percentages(e, e)
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

    Private Sub Levelfield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Levelfield.SelectedIndexChanged
        If Levelfield.Text = "KS2" Then
            Gradetypefield.Enabled = False
            Gradetypefield.Text = "Achieved"
        Else
            Gradetypefield.Enabled = True
        End If
    End Sub
End Class