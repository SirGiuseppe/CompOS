'A4A Systems, LoSwitch Engine 1.01
'Copyright(C) 2015 A4A Systems, U.S.
'Do Not Duplicate

Module LogonProviders
    Public Sub LocalAcc()
        Login.Button2.BackColor = Color.Blue
        Login.Button3.BackColor = Color.MediumBlue
        Login.Button4.BackColor = Color.MediumBlue
        Login.Button5.BackColor = Color.MediumBlue
    End Sub
    Public Sub Other1()
        Login.Button2.BackColor = Color.MediumBlue
        Login.Button3.BackColor = Color.Blue
        Login.Button4.BackColor = Color.MediumBlue
        Login.Button5.BackColor = Color.MediumBlue
    End Sub
    Public Sub Other2()
        Login.Button2.BackColor = Color.MediumBlue
        Login.Button3.BackColor = Color.MediumBlue
        Login.Button4.BackColor = Color.Blue
        Login.Button5.BackColor = Color.MediumBlue
    End Sub
    Public Sub Other3()
        Login.Button2.BackColor = Color.MediumBlue
        Login.Button3.BackColor = Color.MediumBlue
        Login.Button4.BackColor = Color.MediumBlue
        Login.Button5.BackColor = Color.Blue
    End Sub
    Public Sub LogonButton()
        If Login.Button2.BackColor = Color.Blue Then
            'Insert Local Logon Code Here.
        ElseIf Login.Button3.BackColor = Color.Blue Then
            A4Aid()
        ElseIf Login.Button4.BackColor = Color.Blue Then
            'Insert Provider 2 Code Here.
        ElseIf Login.Button5.BackColor = Color.Blue Then
            'Insert Provider 3 Code Here.
        End If
    End Sub
End Module
