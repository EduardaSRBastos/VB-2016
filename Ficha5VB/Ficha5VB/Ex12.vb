Module Ex12

    Sub Main()
        Dim N, soma, S, c As Double

        c = 1
        soma = 0

        Console.WriteLine("Digite um número")
        N = Console.ReadLine()

        Do
            S = N / c
            c = c + 1
            soma = S + c
        Loop Until c = 21
        Console.WriteLine("Valor de S: {0}", soma)
        Console.ReadKey()

    End Sub

End Module
