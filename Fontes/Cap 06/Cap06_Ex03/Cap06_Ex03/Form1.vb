Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MD1, MD2, MD3, MD4, MD5, MD6, MD7, MD8 As Double
        Dim MEDIA As Double
        MD1 = Val(TextBox1.Text)
        MD2 = Val(TextBox2.Text)
        MD3 = Val(TextBox3.Text)
        MD4 = Val(TextBox4.Text)
        MD5 = Val(TextBox5.Text)
        MD6 = Val(TextBox6.Text)
        MD7 = Val(TextBox7.Text)
        MD8 = Val(TextBox8.Text)
        MEDIA = (MD1 + MD2 + MD3 + MD4 + MD5 + MD6 + MD7 + MD8) / 8
        Label3.Text = Str(MEDIA)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        Label3.Text = "Label3"
        TextBox1.Focus()
    End Sub
End Class
