Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("Você é honesto?", 32 + 4) = vbYes) Then
            MsgBox("Parabéns!!!", 64)
        Else
            MsgBox("Seu pilantra!!!", 16)
        End If
    End Sub
End Class
