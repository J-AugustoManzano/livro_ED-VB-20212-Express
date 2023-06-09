Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C, X As Single
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        X = Val(TextBox3.Text)
        If Not (X > 5) Then
            C = (A + B) * X
        Else
            C = (A - B) * X
        End If
        MsgBox("Resultado de C = " + Str(C))
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub
End Class
