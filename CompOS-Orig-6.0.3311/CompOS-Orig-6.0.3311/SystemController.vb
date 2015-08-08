'A4A SystemController 1.01A
'Copyright (C) 2014-2015 A4A Systems, U.S.
'Do Not Duplicate.
Module SystemController
    Public Sub ShutdownSystem()
        System.Diagnostics.Process.Start("shutdown", "-s -t 0")
    End Sub
    Public Sub RestartSystem()
        System.Diagnostics.Process.Start("shutdown", "-r -t 0")
    End Sub
    Public Sub ShutdownCompOS()
        Login.Close()
    End Sub
    Public Sub RestartCompOS()
        Shutdown.Show()
        Shutdown.Label1.Text = "Restarting..."
        Login.Close()
    End Sub
End Module
