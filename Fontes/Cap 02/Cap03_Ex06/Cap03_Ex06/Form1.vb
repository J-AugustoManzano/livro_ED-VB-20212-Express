Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NOME1, SEXO1 As String
        Dim NOME2, SEXO2 As String
        NOME1 = TextBox1.Text.ToUpper
        SEXO1 = TextBox2.Text.ToUpper
        NOME2 = TextBox3.Text.ToUpper
        SEXO2 = TextBox4.Text.ToUpper
        If (SEXO1 = "MASCULINO") Xor (SEXO2 = "MASCULINO") Then
            MsgBox(NOME1 & " pode dançar com " & NOME2)
        Else
            MsgBox(NOME1 & " não pode dançar com " & NOME2)
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub
End Class
