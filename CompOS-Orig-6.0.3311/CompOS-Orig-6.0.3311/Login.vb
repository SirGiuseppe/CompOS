Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginFadei() 'Commences Fade-in effect.
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        Label2.Text = DateString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Blue
        Button3.BackColor = Color.MediumBlue
        Button4.BackColor = Color.MediumBlue
        Button5.BackColor = Color.MediumBlue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ShutdownSystem() 'Shuts Down Device
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RestartSystem() 'Restarts Device
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shutdown.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LogonButton()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.BackColor = Color.MediumBlue
        Button3.BackColor = Color.Blue
        Button4.BackColor = Color.MediumBlue
        Button5.BackColor = Color.MediumBlue
        A4Aid()
    End Sub
End Class