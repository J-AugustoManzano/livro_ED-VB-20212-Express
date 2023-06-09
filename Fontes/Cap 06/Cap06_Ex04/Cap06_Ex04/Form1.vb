Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CONTROLE As Control
        Dim I As Byte
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                CONTROLE.Text = ""
            End If
        Next
        Label3.Text = "Label3"
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MD(8) As Single
        Dim SOMA, MEDIA As Single
        Dim I As Byte
        SOMA = 0
        MD(1) = Val(TextBox1.Text)
        MD(2) = Val(TextBox2.Text)
        MD(3) = Val(TextBox3.Text)
        MD(4) = Val(TextBox4.Text)
        MD(5) = Val(TextBox5.Text)
        MD(6) = Val(TextBox6.Text)
        MD(7) = Val(TextBox7.Text)
        MD(8) = Val(TextBox8.Text)

        For I = 1 To 8
            SOMA = SOMA + MD(I)
        Next
        MEDIA = SOMA / 8
        Label3.Text = Str(MEDIA)

    End Sub
End Class
