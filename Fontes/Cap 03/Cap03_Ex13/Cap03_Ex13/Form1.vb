Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MSG As String
        Dim RESP As Integer
        MSG = "Selecione um botão"
        RESP = MsgBox(MSG, vbOKCancel)
        If (RESP = vbOK) Then
            MsgBox("Acionou o botão 'OK'.")
        End If
        If (RESP = vbCancel) Then
            MsgBox("Acionou o botão 'Cancelar'.")
        End If
    End Sub
End Class
