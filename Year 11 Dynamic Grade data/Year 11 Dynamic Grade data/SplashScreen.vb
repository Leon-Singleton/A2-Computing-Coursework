Public NotInheritable Class SplashScreen
    'the code encased within this sub is performed when the splashscreen is first loaded
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Sets the title text displayed on the splashscreen
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else

            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Sets the version text displayed by the splashscreen
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'sets the copyright information displayed on the splashscreen
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class
