Module Module1

    Sub Main()
        Dim raio, Pi, area As Double
        Pi = 3.14

        Console.WriteLine("Digite o raio da circunferência")
        raio = Console.ReadLine()

        area = Pi * (raio * raio)
        Console.WriteLine("A área da circunferência é: {0}", area)
        Console.ReadKey()

    End Sub

End Module
