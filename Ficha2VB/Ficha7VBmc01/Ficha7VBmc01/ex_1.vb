Module ex_2

    Sub Main()
        Dim nota_1, nota_2, nota_3, media As Double
        Console.WriteLine("Introduza a nota do teste 1")
        nota_1 = Console.ReadLine()
        Console.WriteLine("Introduza a nota do teste 2")
        nota_2 = Console.ReadLine()
        Console.WriteLine("Introduza a nota do teste 3")
        nota_3 = Console.ReadLine()
        media = (nota_1 + nota_2 + nota_3) / 3
        If (media > 9.4) Then
            Console.WriteLine("Aluno Aprovado")
        Else
            Console.WriteLine("Aluno Reprovado")
        End If
        Console.ReadKey()
    End Sub

End Module
