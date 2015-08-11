Module A4AdeveloperID
    Public Sub A4Aid()
        'A4A Systems | Developer ID Logon System 1.5B
        'Copyright (C) 2013-2015 A4A Systems, U.S.
        'DO NOT COPY, REDISTRIBUTE, OR OTHERWISE TAMPER WITHOUT WRITTEN CONSENT
        Login.Label5.Text = "WAITING ON A4A ID CONFIRMATION"
        A4AdevID.Show()
    End Sub
    Public Sub adevidchk()
        If A4AdevID.UsernameTextBox.Text = "" Then
            A4AdevID.Label2.Text = ">1 Char Username Required"
        Else
            If My.Computer.FileSystem.DirectoryExists("C:\WINVBIOS\ADEVID\" + A4AdevID.UsernameTextBox.Text + "\") Then
                Dim DEVIDREAD As System.IO.StreamReader = New System.IO.StreamReader("C:\WINVBIOS\ADEVID\" + A4AdevID.UsernameTextBox.Text + "\" + "99o3ee.vbios")
                Dim idline As String
                Dim DEVPASSRD As System.IO.StreamReader = New System.IO.StreamReader("C:\WINVBIOS\ADEVID\" + A4AdevID.UsernameTextBox.Text + "\" + "99o3ee.vbios")
                Dim idpass As String
                Do
                    idpass = A4AdevID.PasswordTextBox.Text
                    idline = DEVIDREAD.ReadLine
                    Console.WriteLine(idpass)
                    Console.WriteLine(idline)
                Loop Until idline Is Nothing
                If A4AdevID.PasswordTextBox.Text = "" Then
                    A4AdevID.Label2.Text = ">1 Char Password Required"
                Else
                    If idpass = DEVPASSRD.ReadLine() = True Then
                        A4AdevID.Label2.Text = "Sign-in Successful."
                        Login.Label5.Text = "ID CONFIRMATION RECIEVED"
                        Login.TextBox1.Text = "3892u89h3y0713n3y478y41054657g34h"
                        Login.TextBox2.Text = "28yght702y6746302756bg14078h73468"
                        A4AdevID.Close()
                        DesktopStart.Show()
                        Login.Close()
                    Else
                        A4AdevID.Label2.Text = "Invalid Username."
                    End If
                End If
            End If
        End If
    End Sub
End Module
