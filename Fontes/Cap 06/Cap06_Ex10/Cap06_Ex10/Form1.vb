Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Structure CadAluno
        Dim NOME As String
        Dim NOTA1 As Single
        Dim NOTA2 As Single
        Dim NOTA3 As Single
        Dim NOTA4 As Single
    End Structure

    Dim ALUNO As CadAluno

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ALUNO.NOME = TextBox1.Text
        ALUNO.NOTA1 = Val(TextBox2.Text)
        ALUNO.NOTA2 = Val(TextBox3.Text)
        ALUNO.NOTA3 = Val(TextBox4.Text)
        ALUNO.NOTA4 = Val(TextBox5.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ALUNO.NOME.ToUpper
        TextBox2.Text = Format(ALUNO.NOTA1, "#0.00")
        TextBox3.Text = Format(ALUNO.NOTA2, "#0.00")
        TextBox4.Text = Format(ALUNO.NOTA3, "#0.00")
        TextBox5.Text = Format(ALUNO.NOTA4, "#0.00")
    End Sub
End Class
