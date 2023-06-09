Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R, X, A, B As Integer
        A = TextBox1.Text
        B = TextBox2.Text
        X = A + B
        If (X >= 10) Then
            MsgBox("R = " + Str(R + 5), 64, "Resultado V")
        Else
            MsgBox("R = " + Str(R - 7), 64, "Resultado F")
        End If
        TextBox1.Focus()
    End Sub
End Class
