Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R = 99, N As Long
        N = Val(TextBox1.Text)
        Fatorial(N, R)
        MsgBox("Fatorial = " & Str(R))
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Fatorial(ByVal X As Long, ByRef F As Long)
        Dim I As Integer
        F = 1
        For I = 1 To X
            F = F * I
        Next
    End Sub

End Class
