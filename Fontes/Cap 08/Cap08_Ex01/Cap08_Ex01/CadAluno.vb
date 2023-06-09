Public Class SalaAula
    Public SALA As String
End Class

Public Class CadAluno
    Inherits SalaAula
    Public NOME As String
    Public NOTA(4) As Single

    Function CalcMedia() As Single
        Dim I As Byte
        Dim SOMA, MEDIA As Single
        SOMA = 0
        For I = 1 To 4
            SOMA = SOMA + NOTA(I)
        Next
        MEDIA = SOMA / 4
        CalcMedia = MEDIA
    End Function

End Class
