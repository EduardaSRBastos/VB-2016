Module Module1

    Sub Main()
        Dim num1, num2, a, b, c As Double

        Console.WriteLine("Digite o primeiro número")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o segundo número")
        num2 = Console.ReadLine()

        a = num1 / num2
        b = num2 / num1
        c = a - b
        Console.WriteLine("O resultado da alínea a. é {0}", a)
        Console.WriteLine("O resultado da alínea b. é {0}", b)
        Console.WriteLine("O resultado da alínea c. é {0}", c)

        Console.ReadKey()

    End Sub

End Module
