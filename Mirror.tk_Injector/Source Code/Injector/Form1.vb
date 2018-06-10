Public Class Form1
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'If MephTextBox1.Text = "Username" And MephTextBox2.Text = "Password" Then
    '   MsgBox("Success!")
    'Me.Hide()
    '      Form2.Show()
    'Else
    '        MsgBox("Login Failed!")
    'End If
    ' End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class