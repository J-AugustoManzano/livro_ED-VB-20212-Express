Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ROTULO As New Label
        ROTULO.Text = "Estudo Dirigido de Visual Basic"
        ROTULO.SetBounds(68, 115, 153, 25)
        Me.Controls.Add(ROTULO)
    End Sub
End Class
