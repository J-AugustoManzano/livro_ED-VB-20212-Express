Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NUMERO As Single
        NUMERO = TextBox1.Text
        If (NUMERO >= 20) And (NUMERO <= 90) Then
            MsgBox("O valor está entre 20 e 90")
        Else
            MsgBox("O valor não está entre 20 e 90")
        End If
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
