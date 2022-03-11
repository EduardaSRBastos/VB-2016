Module Ex1

    Sub Main()
        Dim tipo, quant As Integer

        Console.WriteLine("Digite o tipo da batata")
        tipo = Console.ReadLine()
        Console.WriteLine("Digite a quantidade")
        quant = Console.ReadLine()

        Select Case tipo
            Case 1
                Console.WriteLine("Valor a pagar: {0} euros, Qualidade: Branca", 0.2 * quant)
            Case 2
                Console.WriteLine("Valor a pagar: {0} euros, Qualidade: Branca", 0.25 * quant)
            Case 3
                Console.WriteLine("Valor a pagar: {0} euros, Qualidade: Rosada", 0.3 * quant)
            Case 4
                Console.WriteLine("Valor a pagar: {0} euros, Qualidade: Extra", 0.35 * quant)
            Case 5
                Console.WriteLine("Valor a pagar: {0} euros, Qualidade: Extra", 0.4 * quant)
            Case Else
                Console.WriteLine("Digitou um valor errado")
        End Select
        Console.ReadKey()
    End Sub

End Module
