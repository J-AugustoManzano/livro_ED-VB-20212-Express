Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mes As Integer
        Mes = Val(TextBox1.Text)
        Select Case Mes
            Case 1
                TextBox2.Text = "Janeiro"
            Case 2
                TextBox2.Text = "Fevereiro"
            Case 3
                TextBox2.Text = "Março"
            Case 4
                TextBox2.Text = "Abril"
            Case 5
                TextBox2.Text = "Maio"
            Case 6
                TextBox2.Text = "Junho"
            Case 7
                TextBox2.Text = "Julho"
            Case 8
                TextBox2.Text = "Agosto"
            Case 9
                TextBox2.Text = "Setembro"
            Case 10
                TextBox2.Text = "Outubro"
            Case 11
                TextBox2.Text = "Novembro"
            Case 12
                TextBox2.Text = "Dezembro"
            Case Else
                TextBox2.Text = "Mês Inválido"
        End Select
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
