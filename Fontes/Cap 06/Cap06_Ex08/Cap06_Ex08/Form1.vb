Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VALOR As New List(Of Integer)
        Dim SOMA As Integer
        Dim CONTROLE As Control
        Dim I As Byte
        SOMA = 0
        VALOR.Add(Val(TextBox1.Text))
        VALOR.Add(Val(TextBox2.Text))
        VALOR.Add(Val(TextBox3.Text))
        VALOR.Add(Val(TextBox4.Text))
        VALOR.Add(Val(TextBox5.Text))
        For I = 0 To 4
            If (VALOR(I) Mod 2 = 0) Then
                SOMA = SOMA + VALOR(I)
            End If
        Next
        MsgBox("Soma = " & SOMA.ToString)
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                CONTROLE.Text = ""
            End If
        Next
        TextBox1.Focus()
    End Sub
End Class
