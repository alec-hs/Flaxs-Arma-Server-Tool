Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        'One of the global exceptions we are catching is not thread safe, 
        'so we need to make it thread safe first.
        Private Delegate Sub SafeApplicationThreadException(ByVal sender As Object,
        ByVal e As Threading.ThreadExceptionEventArgs)

        Private Sub ShowDebugOutput(ByVal ex As Exception)

            'Display the output form
            Dim frmD As New ErrReport()
            frmD.rtfError.AppendText(ex.ToString())
            frmD.ShowDialog()

            'Perform application cleanup
            'TODO: Add your application cleanup code here.

            'Exit the application - Or try to recover from the exception:
            'Environment.Exit(0)

        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object,
    ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            'There are three places to catch all global unhandled exceptions:
            'AppDomain.CurrentDomain.UnhandledException event.
            'System.Windows.Forms.Application.ThreadException event.
            'MyApplication.UnhandledException event.
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf AppDomain_UnhandledException
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf App_ThreadException

        End Sub

        Private Sub App_ThreadException(ByVal sender As Object,
    ByVal e As Threading.ThreadExceptionEventArgs)

            'This is not thread safe, so make it thread safe.
            If MainForm.InvokeRequired Then
                ' Invoke back to the main thread
                MainForm.Invoke(New SafeApplicationThreadException(AddressOf App_ThreadException),
            New Object() {sender, e})
            Else
                ShowDebugOutput(e.Exception)
            End If

        End Sub

        Private Sub AppDomain_UnhandledException(ByVal sender As Object,
    ByVal e As UnhandledExceptionEventArgs)

            ShowDebugOutput(DirectCast(e.ExceptionObject, Exception))

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object,
        e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) _
        Handles Me.UnhandledException

            ShowDebugOutput(e.Exception)

        End Sub
    End Class
End Namespace
