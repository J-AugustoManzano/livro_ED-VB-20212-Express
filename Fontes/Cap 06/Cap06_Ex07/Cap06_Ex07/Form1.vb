Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CONTROLE As Control
        Dim I As Byte
        ListBox1.Items.Clear()
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                CONTROLE.Text = ""
            End If
        Next
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim A(3, 3) As Integer
        Dim I, J As Byte
        ListBox1.Items.Clear()

        ' Linha 1, Colunas 1, 2 e 3

        A(1, 1) = TextBox1.Text
        A(1, 2) = TextBox2.Text
        A(1, 3) = TextBox3.Text

        ' Linha 2, Colunas 1, 2 e 3

        A(2, 1) = TextBox4.Text
        A(2, 2) = TextBox5.Text
        A(2, 3) = TextBox6.Text

        ' Linha 3, Colunas 1, 2 e 3

        A(3, 1) = TextBox7.Text
        A(3, 2) = TextBox8.Text
        A(3, 3) = TextBox9.Text

        ' Processamento e saida da diagonal principal

        For I = 1 To 3
            For J = I To 3
                If (I = J) Then
                    ListBox1.Items.Add(A(I, J))
                End If
            Next J
        Next I
    End Sub
End Class
