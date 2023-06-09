Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FAT = 1, N, I As Long
        N = Val(TextBox1.Text)
        I = 1
        Do While (I <= N)
            FAT = FAT * I
            I = I + 1
        Loop
        MsgBox("Fatorial = " & Str(FAT), 64, "Resultado da Fatorial")
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
