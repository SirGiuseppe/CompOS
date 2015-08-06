'Splash Screen | Minimal v2.4
'Developed by A4A Systems
'(C) 2010-2015 A4A Systems, U.S.
'Do Not Modify wihout permission.
Public Class Spl
    Dim x As Integer
    Private Sub Spl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 1
        If x = 25 Then 'Set timer to run 25 seconds to load OS
            Label1.Text = "Startup complete, proceeding.."
            Login.Show()
            Me.Close()
        End If
    End Sub
    '    Private Sub VBIOS_Load(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.Load 'Bug Found, Enter Detection breaks program.
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
    '            VBIOS.Show()
    '    Me.Close()
    '    End If
    '    End Sub
End Class
