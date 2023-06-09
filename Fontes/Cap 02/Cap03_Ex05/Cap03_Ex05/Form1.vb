Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SEXO As String
        SEXO = TextBox1.Text.ToUpper
        If (SEXO = "MASCULINO") Or (SEXO = "FEMININO") Then
            MsgBox("Sexo válido")
        Else
            MsgBox("Sexo inválido")
        End If
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
