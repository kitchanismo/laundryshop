Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private WithEvents DLLDomain As AppDomain = AppDomain.CurrentDomain
        Private Function DLL_AssemblyResolve(ByVal sender As Object, ByVal args As System.ResolveEventArgs) As System.Reflection.Assembly Handles DLLDomain.AssemblyResolve
            If args.Name.Contains("kitchanismoV2") Then
                Return System.Reflection.Assembly.Load(My.Resources.kitchanismoV2)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

