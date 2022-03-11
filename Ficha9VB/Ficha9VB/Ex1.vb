Module Ex1

    Sub Main()
        Dim aluno, nota, media, c, soma As Double
        Dim nome As String

        soma = 0
        For aluno = 1 To 20
            Console.WriteLine("Digite o nome")
            nome = Console.ReadLine()
            For c = 1 To 10
                Console.WriteLine("Digite a avaliação")
                nota = Console.ReadLine()
                soma = soma + nota

            Next
            media = soma / 10
            Console.WriteLine("A média  do aluno {0} é: {1}", nome, media)

        Next
        Console.ReadKey()
    End Sub

End Module
