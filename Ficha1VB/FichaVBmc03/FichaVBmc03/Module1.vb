Module Module1

    Sub Main()
        Dim nota1, nota2, nota3, media, mediap As Double

        Console.WriteLine("Digite o valor da 1ªnota")
        nota1 = Console.ReadLine()
        Console.WriteLine("Digite o valor da 2ªnota")
        nota2 = Console.ReadLine()
        Console.WriteLine("Digite o valor da 3ªnota")
        nota3 = Console.ReadLine()

        media = (nota1 + nota2 + nota3) / 3
        Console.WriteLine("A média das notas é: {0}", media)
        mediap = (nota1 + 2 * nota2 + 3 * nota3) / 6
        Console.WriteLine("A média ponderada é: {0}", mediap)

        Console.ReadKey()

    End Sub

End Module
