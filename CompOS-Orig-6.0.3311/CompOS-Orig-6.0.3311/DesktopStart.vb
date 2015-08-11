Public Class DesktopStart
    Dim x As Integer
    Private Sub DesktopStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dlfadei()
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub DesktopStart_Exit(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        dlfadeo()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 1
        If x = 7 Then
            If My.Settings.dskpref = "win" Then
                winDesktop.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class