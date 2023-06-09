Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ROTULO1 As New Label
        Dim ROTULO2 As New Label
        Dim ROTULO3 As New Label
        Dim CAMPO(8) As TextBox
        Dim BOTAO1 As New Button
        Dim BOTAO2 As New Button
        Dim I, POSICAO As Byte

        Me.Text = "Média Escolar - Variável Indexada"
        Me.Width = 329
        Me.Height = 300

        ROTULO1.Text = "Entre com as oito médias escolares:"
        ROTULO1.SetBounds(12, 19, 176, 13)
        Me.Controls.Add(ROTULO1)

        ROTULO2.Text = "Média Geral:"
        ROTULO2.SetBounds(141, 234, 67, 13)
        Me.Controls.Add(ROTULO2)

        ROTULO3.Name = "Label3"
        ROTULO3.Text = "Label3"
        ROTULO3.SetBounds(214, 234, 39, 13)
        Me.Controls.Add(ROTULO3)

        POSICAO = 45
        CAMPO(0).Name = "TextBox1"
        For I = 0 To 7 Step 1
            CAMPO(I) = New TextBox
            CAMPO(I).SetBounds(15, POSICAO, 60, 20)
            Me.Controls.Add(CAMPO(I))
            POSICAO += 26
        Next

        BOTAO1.Text = "Processar"
        BOTAO1.SetBounds(133, 198, 73, 23)
        Me.Controls.Add(BOTAO1)
        AddHandler BOTAO1.Click, AddressOf Processar

        BOTAO2.Text = "Limpar"
        BOTAO2.SetBounds(215, 198, 73, 23)
        Me.Controls.Add(BOTAO2)
        AddHandler BOTAO2.Click, AddressOf Limpar

    End Sub

    Private Sub Processar()
        Dim MD(8) As Single
        Dim SOMA, MEDIA As Single
        Dim I, J As Byte
        Dim CONTROLE As Control
        SOMA = 0
        J = 1
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                MD(J) = Val(CONTROLE.Text)
                J += 1
            End If
        Next
        For I = 1 To 8
            SOMA = SOMA + MD(I)
        Next
        MEDIA = SOMA / 8
        Me.Controls("Label3").Text = Str(MEDIA)
    End Sub

    Private Sub Limpar()
        Dim CONTROLE As Control
        Dim I As Byte
        For I = 0 To Me.Controls.Count - 1
            CONTROLE = Me.Controls(I)
            If (TypeOf CONTROLE Is TextBox) Then
                CONTROLE.Text = ""
            End If
        Next
        Me.Controls("Label3").Text = "Label3"
        Me.Controls("TextBox1").Focus()
    End Sub

End Class
