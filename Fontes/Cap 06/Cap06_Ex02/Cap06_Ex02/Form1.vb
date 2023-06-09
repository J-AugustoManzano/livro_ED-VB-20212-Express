Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BOTAO As New Button
        BOTAO.Text = "Me Acione"
        BOTAO.SetBounds(84, 100, 120, 46)
        Me.Controls.Add(BOTAO)
        AddHandler BOTAO.Click, AddressOf Apresenta
    End Sub

    Private Sub Apresenta()
        MessageBox.Show("Uau!!! Você me acionou.")
    End Sub

End Class
