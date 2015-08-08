Public Class Shutdown
    Dim x As Integer
    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShutdownFadei()
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 1
        If x = 15 Then 'Set timer to run 15 seconds to unload OS
            If Label1.Text = "Restarting..." Then
                Spl.Show()
                Me.Close()
            Else
                Label1.Text = "Shutdown Complete"
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Shutdown_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        ShutdownFadeo()
    End Sub
End Class