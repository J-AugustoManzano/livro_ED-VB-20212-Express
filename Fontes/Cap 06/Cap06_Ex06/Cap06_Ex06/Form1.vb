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
        Dim CONTROLE As Control
        Dim NOME(10), X As String
        Dim I, J As Byte

        'Trecho da entrada de dados

        ListBox1.Items.Clear()

        J = 1
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                NOME(J) = CONTROLE.Text
                J += 1
            End If
        Next

        'Trecho que ordena

        For I = 1 To 9
            For J = I + 1 To 10
                If (NOME(I) > NOME(J)) Then
                    X = NOME(I)
                    NOME(I) = NOME(J)
                    NOME(J) = X
                End If
            Next J
        Next I

        'Apresentação lista ordenada

        For I = 1 To 10
            ListBox1.Items.Add(NOME(I))
        Next

    End Sub
End Class
