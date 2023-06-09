Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FAT = 1, N, I As Long
        N = Val(TextBox1.Text)
        For I = 1 To N Step 1
            FAT = FAT * I
        Next I
        MsgBox("Fatorial = " & Str(FAT), 64, "Resultado da Fatorial")
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
