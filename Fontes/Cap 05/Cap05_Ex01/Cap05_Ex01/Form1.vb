Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Long
        N = Val(TextBox1.Text)
        Fatorial(N)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Fatorial(ByVal X As Long)
        Dim F = 1, I As Long
        For I = 1 To X
            F = F * I
        Next
        MsgBox("Fatorial = " & Str(F))
    End Sub

End Class
