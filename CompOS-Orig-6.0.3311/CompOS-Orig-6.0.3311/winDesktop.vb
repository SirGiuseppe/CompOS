Public Class winDesktop
    Private Sub winDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dskfadei()
    End Sub
    Private Sub winDesktop_Exit(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        dskfadeo()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If My.Settings.startopen = "FALSE" Then
            Panel2.Visible = True
            My.Settings.startopen = "TRUE"
        Else
            Panel2.Visible = False
            My.Settings.startopen = "FALSE"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShutdownCompOS()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RestartCompOS()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RestartSystem()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ShutdownSystem()
    End Sub
End Class