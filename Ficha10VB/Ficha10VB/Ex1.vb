Module Ex1

    Sub Main()
        Dim num(20) As Double
        Dim i, soma, subtracao As Double

        For i = 0 To 19
            Console.WriteLine("Digite o {0}º número", i + 1)
            num(i) = Console.ReadLine()
        Next
        soma = num(7) + num(17)
        subtracao = num(19) - num(0)
        Console.WriteLine("O 3º elemento é: {0}", num(3))
        Console.WriteLine("O último menos o primeiro é: {0}", subtracao)
        Console.WriteLine(" O 8º elemento lido + o 18º é: {0}", soma)
        Console.ReadKey()
    End Sub

End Module
