Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MSG, RESP As String
        MSG = "Entre algo e acione um botão."
        RESP = InputBox(MSG)
        If (Len(RESP) = 0) Then
            MsgBox("Botão 'Cancelar' acionado.")
        Else
            MsgBox("Botão 'OK' acionado.")
        End If
    End Sub
End Class
