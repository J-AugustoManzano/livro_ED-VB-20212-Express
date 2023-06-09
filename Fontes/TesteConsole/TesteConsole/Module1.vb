Module Module1

    Dim opcao As String
    Dim r, a, b As Single
    Dim msg As String

    Sub Main()

        ' Programa Principal

        msg = "Tecle algo para continuar. "

        opcao = "0"
        Do While (opcao <> "5")
            Console.Title = "Calculadora"
            Console.BackgroundColor = ConsoleColor.Black
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("Menu Principal")
            Console.WriteLine("--------------")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1 - Soma")
            Console.WriteLine("2 - Subtracao")
            Console.WriteLine("3 - Multiplicacao")
            Console.WriteLine("4 - Divisao")
            Console.WriteLine("5 - Fim de Programa")
            Console.WriteLine()
            Console.Write("Escolha uma opcao: ")
            opcao = Console.ReadLine()
            If opcao <> "5" Then
                Select Case opcao
                    Case "1"
                        rotsoma()
                    Case "2"
                        rotsubtracao()
                    Case "3"
                        rotmultiplicacao()
                    Case "4"
                        rotdivisao()
                    Case Else
                        Console.WriteLine("Opcao invalida")
                        Console.Write(msg)
                        Console.ReadKey()
                End Select
            End If
        Loop

    End Sub


    ' Subrotinas

    Function calculo(ByVal x As Single, ByVal y As Single, _
                     ByVal operador As String) As Single
        Select Case (operador)
            Case "+"
                calculo = x + y
            Case "-"
                calculo = x - y
            Case "*"
                calculo = x * y
            Case "/"
                calculo = x / y
        End Select
    End Function

    Sub entrada()
        Console.Write("Entre um valor para A: ")
        a = Console.ReadLine()
        Console.Write("Entre um valor para B: ")
        b = Console.ReadLine()
    End Sub

    Sub rotdivisao()
        Console.Clear()
        Console.WriteLine("Rotina de Divisao")
        Console.WriteLine("-----------------")
        Console.WriteLine()
        entrada()
        If (b = 0) Then
            Console.WriteLine()
            Console.WriteLine("Erro.")
            Console.WriteLine()
            Console.Write(msg)
            Console.ReadKey()
        Else
            r = calculo(a, b, "/")
            saida()
        End If
    End Sub

    Sub rotmultiplicacao()
        Console.Clear()
        Console.WriteLine("Rotina de Multiplicacao")
        Console.WriteLine("-----------------------")
        Console.WriteLine()
        entrada()
        r = calculo(a, b, "*")
        saida()
    End Sub

    Sub rotsoma()
        Console.Clear()
        Console.WriteLine("Rotina de Soma")
        Console.WriteLine("--------------")
        Console.WriteLine()
        entrada()
        r = calculo(a, b, "+")
        saida()
    End Sub

    Sub rotsubtracao()
        Console.Clear()
        Console.WriteLine("Rotina de Subtracao")
        Console.WriteLine("-------------------")
        Console.WriteLine()
        entrada()
        r = calculo(a, b, "-")
        saida()
    End Sub

    Sub saida()
        Console.WriteLine()
        Console.Write("O resultado entre A e B = " & r)
        Console.WriteLine()
        Console.WriteLine()
        Console.Write(msg)
        Console.ReadKey()
    End Sub

End Module
