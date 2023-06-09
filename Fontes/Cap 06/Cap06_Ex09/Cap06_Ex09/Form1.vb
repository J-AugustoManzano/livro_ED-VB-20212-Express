Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ALUNO As New Dictionary(Of String, Single)
        Dim PEGA As KeyValuePair(Of String, Single)
        Dim SOMA, MEDIA As Single
        Dim CONTROLE As Control
        Dim I As Byte
        SOMA = 0
        ALUNO.Add(TextBox1.Text, Val(TextBox2.Text))
        ALUNO.Add(TextBox3.Text, Val(TextBox4.Text))
        ALUNO.Add(TextBox5.Text, Val(TextBox6.Text))
        ALUNO.Add(TextBox7.Text, Val(TextBox8.Text))
        For Each PEGA In ALUNO
            SOMA = SOMA + PEGA.Value
        Next
        MEDIA = SOMA / 4
        MsgBox("Média Geral = " & MEDIA.ToString)
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                CONTROLE.Text = ""
            End If
        Next
        TextBox1.Focus()
    End Sub
End Class
