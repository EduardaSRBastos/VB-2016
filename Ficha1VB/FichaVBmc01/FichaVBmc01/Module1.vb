Module Module1

    Sub Main()
        Dim larg, comp, soma As Double

        Console.WriteLine("Digite a largura do retângulo")
        larg = Console.ReadLine()
        Console.WriteLine("Digite o comprimento do retângulo")
        comp = Console.ReadLine()

        soma = larg + comp + larg + comp
        Console.WriteLine("O perímetro do retângulo é: {0}", soma)

        Console.ReadKey()

    End Sub

End Module
