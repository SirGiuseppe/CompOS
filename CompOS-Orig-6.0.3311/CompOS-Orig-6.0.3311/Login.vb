Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginFadei()
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
End Class