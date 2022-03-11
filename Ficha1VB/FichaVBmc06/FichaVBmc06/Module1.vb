Module Module1

    Sub Main()
        Dim custouniP1, custouniP2, custouniP3, precouniP1 As Double
        Dim precouniP2, precouniP3, quantP1, quantP2, quantP3 As Double
        Dim LP1, LP2, LP3, LT As Double

        Console.WriteLine("Digite o custo do produto 1")
        custouniP1 = Console.ReadLine
        Console.WriteLine("Digite o preço do produto 1")
        precouniP1 = Console.ReadLine
        Console.WriteLine("Digite a quantidade do produto 1")
        quantP1 = Console.ReadLine
        Console.WriteLine("Digite o custo do produto 2")
        custouniP2 = Console.ReadLine
        Console.WriteLine("Digite o preço do produto 2")
        precouniP2 = Console.ReadLine
        Console.WriteLine("Digite a quantidade do produto 2")
        quantP2 = Console.ReadLine
        Console.WriteLine("Digite o custo do produto 3")
        custouniP3 = Console.ReadLine
        Console.WriteLine("Digite o preço do produto 3")
        precouniP3 = Console.ReadLine
        Console.WriteLine("Digite a quantidade do produto 3")
        quantP3 = Console.ReadLine

        LP1 = (precouniP1 - custouniP1) * quantP1
        LP2 = (precouniP2 - custouniP2) * quantP2
        LP3 = (precouniP3 - custouniP3) * quantP3
        Console.WriteLine("O lucro do produto 1 é {0}", LP1)
        Console.WriteLine("O lucro do produto 2 é {0}", LP2)
        Console.WriteLine("O lucro do produto 3 é {0}", LP3)
        LT = LP1 + LP2 + LP3
        Console.WriteLine("O lucro total é {0}", LT)

        Console.ReadKey()
    End Sub

End Module
