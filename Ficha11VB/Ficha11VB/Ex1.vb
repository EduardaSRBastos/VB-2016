Module Ex1

    Sub Main()
        Dim num(3, 3) As Double
        Dim i, j, soma, media, maior As Double

        maior = 0
        For i = 0 To 3
            For j = 0 To 3
                Console.WriteLine("Digite o elemento ( {0}, {1} ) da matriz", i, j)
                num(i, j) = Console.ReadLine()
                soma = soma + num(i, j)
            Next
        Next
        Console.WriteLine("Soma: {0}", soma)
        media = soma / 16
        Console.WriteLine("Média: {0}", media)
        For i = 0 To 3
            For j = 0 To 3
                If num(i, j) > maior Then
                    maior = num(i, j)
                End If
            Next
        Next
        Console.WriteLine("O maior elemento: {0}", maior)
        Console.ReadKey()
    End Sub

End Module
