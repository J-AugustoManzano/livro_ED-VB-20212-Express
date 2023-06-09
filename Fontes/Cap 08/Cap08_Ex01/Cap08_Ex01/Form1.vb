Public Class Form1

    Dim ALUNO As New CadAluno

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        Label6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ALUNO.NOME = TextBox1.Text
        ALUNO.SALA = TextBox6.Text
        ALUNO.NOTA(1) = Val(TextBox2.Text)
        ALUNO.NOTA(2) = Val(TextBox3.Text)
        ALUNO.NOTA(3) = Val(TextBox4.Text)
        ALUNO.NOTA(4) = Val(TextBox5.Text)
        ALUNO.CalcMedia()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ALUNO.NOME.ToUpper
        TextBox6.Text = ALUNO.SALA
        TextBox2.Text = Format(ALUNO.NOTA(1), "#0.00")
        TextBox3.Text = Format(ALUNO.NOTA(2), "#0.00")
        TextBox4.Text = Format(ALUNO.NOTA(3), "#0.00")
        TextBox5.Text = Format(ALUNO.NOTA(4), "#0.00")
        Label6.Text = Format(ALUNO.CalcMedia(), "#0.00")
    End Sub
End Class
