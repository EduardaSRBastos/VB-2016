Module Ex2

    Sub Main()
        Dim num(15) As Double
        Dim i, soma, media As Double

        For i = 0 To 14
            Console.WriteLine("Digite o {0} º número:", i + 1)
            num(i) = Console.ReadLine()
            soma = soma + num(i)
        Next
        media = soma / 15
        Console.WriteLine("A soma é= {0}", soma)
        Console.WriteLine("A média é= {0}", media)
        Console.ReadKey()
    End Sub

End Module
