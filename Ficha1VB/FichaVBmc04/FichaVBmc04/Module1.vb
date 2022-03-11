Module Module1

    Sub Main()
        Dim base, altura, area As Double

        Console.WriteLine("Digite a base do triângulo")
        base = Console.ReadLine()
        Console.WriteLine("Digite a altura do triângulo")
        altura = Console.ReadLine()

        area = (base * altura) / 2
        Console.WriteLine("A área do triângulo é {0}", area)
        Console.ReadKey()

    End Sub

End Module
