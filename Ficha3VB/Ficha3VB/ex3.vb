Module ex3
    Sub Main()
        Dim codigo, cor, tipo As String
        Dim preco As Double

        Console.WriteLine("Digite o código de artigo")
        codigo = Console.ReadLine()
        Console.WriteLine("Digite o tipo de artigo")
        tipo = Console.ReadLine()
        Console.WriteLine("Digite a cor")
        cor = Console.ReadLine()
        Console.WriteLine("Digite o preço base")
        preco = Console.ReadLine()

        If (cor = "Verde" And (tipo = "A" Or tipo = "C")) Then
            Console.WriteLine("O valor do preço unitário é: {0}", preco + 100)
        ElseIf (cor = "Azul" And (tipo = "A" Or tipo = "C"))
            Console.WriteLine("O valor do preço unitário é: {0}", preco + 120)
        ElseIf (cor = "Verde" And tipo = "B")
            Console.WriteLine("O valor do preço unitário é: {0}", preco + 130)
        ElseIf (cor = "Azul" And tipo = "B")
            Console.WriteLine("O valor do preço unitário é: {0}", preco + 150)
        Else
            Console.WriteLine("Valor errado digitado")
        End If
        Console.ReadKey()
    End Sub
End Module
