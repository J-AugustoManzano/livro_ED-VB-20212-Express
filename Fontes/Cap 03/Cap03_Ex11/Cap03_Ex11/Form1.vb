Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TEXTO As String
        Dim TITULO As String
        Dim PEDIDO, NUMERO As Byte
        Dim NUMERO_RANDOMICO As New Random()
        TEXTO = "Entre um numero entre 1 e 5"
        TITULO = "Tente sua Sorte"
        NUMERO = NUMERO_RANDOMICO.Next(1, 6)
        PEDIDO = Val(InputBox(TEXTO, TITULO, , 50, 70))
        If (PEDIDO = 0) Then
            MsgBox("Não houve entrada!", 48)
        Else
            If (PEDIDO = NUMERO) Then
                MsgBox("Acertou - valor sorteado: " & Str(NUMERO), 64)
            Else
                MsgBox("Errou - valor sorteado: " & Str(NUMERO), 16)
            End If
        End If
    End Sub
End Class
