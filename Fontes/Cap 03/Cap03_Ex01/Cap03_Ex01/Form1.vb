Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R, A, B As Integer
        A = TextBox1.Text
        B = TextBox2.Text
        R = A + B
        If (R > 10) Then
            Label3.Text = R
        End If
        TextBox1.Focus()
    End Sub
End Class
