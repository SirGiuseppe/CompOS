Public Class VBIOS
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.LIMSTART = "True"
        Spl.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.EXPKILL = "false" Then
            My.Settings.EXPKILL = "True"
            Label3.Text = "EXPLORER KILL: ENABLED"
        Else
            My.Settings.EXPKILL = "False"
            Label3.Text = "EXPLORER KILL: DISABLED"
        End If
    End Sub

    Private Sub VBIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.EXPKILL = False Then
            Label3.Text = "EXPLORER KILL: DISABLED"
        Else
            Label3.Text = "EXPLORER KILL: ENABLED"
        End If
    End Sub
    ' Bug - KeyPress causes program to fail.
    '    Private Sub VBIOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
    '            Spl.Show()
    '    Me.Close()
    '    End If
    '    End Sub

    '    Private Sub VBIOS_Load(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.Load
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
    '            Spl.Show()
    '    Me.Close()
    '    End If
    '    End Sub
End Class