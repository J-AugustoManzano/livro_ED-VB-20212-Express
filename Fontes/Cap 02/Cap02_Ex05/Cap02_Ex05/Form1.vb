Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NOME, SOBRE_NOME As String
        NOME = InputBox("Entre seu nome:")
        SOBRE_NOME = InputBox("Entre seu sobre nome:")
        MsgBox(NOME & " " & SOBRE_NOME)
    End Sub
End Class
