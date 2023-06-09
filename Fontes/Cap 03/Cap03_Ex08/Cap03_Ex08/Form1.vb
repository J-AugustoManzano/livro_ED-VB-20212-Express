Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C As Single
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = Val(TextBox3.Text)
        If (A < B + C) And (B < A + C) And (C < A + B) Then
            If (A = B) And (B = C) Then
                MsgBox("Triângulo Equilátero")
            Else
                If (A = B) Or (A = C) Or (C = B) Then
                    MsgBox("Triângulo Isósceles")
                Else
                    MsgBox("Triângulo Escaleno")
                End If
            End If
        Else
            MsgBox("Não é triângulo")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub
End Class
