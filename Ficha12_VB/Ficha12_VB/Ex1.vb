Module Ex1

    Sub Main()
        Dim opcao, i, nums As Integer
        Dim num(9) As Integer

        Do
            Console.WriteLine("Digite a opção")
            opcao = Console.ReadLine()
            Select Case opcao
                Case 1
                    i = 1
                    leitura(num, nums)

                Case 2
                    If i = 1 Then
                        mostra(num)
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
                Case 3
                    If i = 1 Then
                        inverte(num)
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
                Case 4
                    If i = 1 Then
                        media(nums)
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
            End Select
        Loop Until opcao = 5
    End Sub
    Sub leitura(ByRef valor() As Integer, ByRef soma As Integer)
        Dim i As Integer

        soma = 0
        For i = 0 To 9
            Console.WriteLine("Digite o {0} º valor", i + 1)
            valor(i) = Console.ReadLine()
            soma = soma + valor(i)
        Next

    End Sub
    Sub mostra(ByRef valor() As Integer)
        Dim i As Integer

        For i = 0 To 9
            Console.WriteLine("Elementos: {0}", valor(i))
        Next
    End Sub
    Sub inverte(ByRef valor() As Integer)
        Dim i As Integer
        Dim inverso(9) As Integer

        Array.Reverse(valor)
        inverso = valor
        For i = 0 To 9
            Console.WriteLine("Inverso: {0}", inverso(i))
        Next
    End Sub
    Sub media(ByRef soma As Integer)
        Dim media As Integer

        media = soma / 10
        Console.WriteLine("Média: {0}", media)
    End Sub
End Module
