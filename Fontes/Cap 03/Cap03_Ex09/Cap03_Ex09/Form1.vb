Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R, A, B As Single
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        If (RadioButton1.Checked) Then
            R = A + B
        End If
        If (RadioButton2.Checked) Then
            R = A - B
        End If
        If (RadioButton3.Checked) Then
            R = A * B
        End If
        If (RadioButton4.Checked) Then
            If (B = 0) Then
                MsgBox("ERRO – Divisor igual a zero!")
            Else
                R = A / B
            End If
        End If
        TextBox3.Text = R
        TextBox1.Focus()
    End Sub
End Class
