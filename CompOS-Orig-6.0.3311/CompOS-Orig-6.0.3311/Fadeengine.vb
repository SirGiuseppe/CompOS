Module Fadeengine
    Public Sub LoginFadei() 'Fade-in for form "Login"
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.2
            Login.Opacity = fade
            Login.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub LoginFadeo() 'Fade-out for Form "Login"
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.3
            Login.Opacity = fade
            Login.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub ShutdownFadei() 'Fade-in for Form "Shutdown"
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.2
            Shutdown.Opacity = fade
            Shutdown.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub ShutdownFadeo() 'Fade-out for Form "Shutdown"
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.3
            Shutdown.Opacity = fade
            Shutdown.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
End Module
