Public Class LoadGraphic
    'this public sub sets the text of the lblmsg
    Public Sub SetMessage(ByVal strMessage As String)
        lblmsg.Text = strMessage
    End Sub
End Class
Public Class clsOPAWaitScreen
    'stores a thread that can be used to run a simultaneous process 
    Dim Thread1 As System.Threading.Thread

    'this sub calls the makeithappen sub and starts the thread process
    Public Sub ShowWaitScreen(ByVal strMessage As String)
        Thread1 = New System.Threading.Thread(AddressOf MakeItHappen)
        'Name is being used here to pass parameters (In this case a message)
        Thread1.Name = strMessage
        Thread1.Start()
    End Sub
    'this sub opens the thread process
    Private Sub MakeItHappen(ByVal strMsg As String)
        'stores a varaible which is a new instance of this form
        Dim objPlsWait As New LoadGraphic
        Try
            'the thread attempts to set the message of the form and show the form
            objPlsWait.SetMessage(System.Threading.Thread.CurrentThread.Name)
            objPlsWait.ShowDialog()
        Catch ex As Exception
            ' Do nothing supress error.
        Finally
            'resets the objpleasewait variable and disposes of the existing objplswit variable
            If objPlsWait IsNot Nothing Then objPlsWait.Dispose() : objPlsWait = Nothing
        End Try
    End Sub
    'this sub is called to end the thread process
    Public Sub CloseWaitScreen()
        ' Makes the form go away.
        Thread1.Abort(Nothing)
    End Sub
End Class
