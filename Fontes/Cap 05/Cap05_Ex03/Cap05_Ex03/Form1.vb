Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Long
        N = Val(TextBox1.Text)
        MsgBox("Fatorial = " & Str(Fatorial(N)))
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Function Fatorial(ByVal X As Long) As Long
        Dim I, F As Long
        F = 1
        For I = 1 To X
            F = F * I
        Next
        Fatorial = F
    End Function

End Class
