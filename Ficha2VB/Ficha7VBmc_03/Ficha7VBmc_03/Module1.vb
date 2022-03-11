Module Module1

    Sub Main()
        Dim idade1, idade2 As Integer
        Dim nome1, nome2 As String

        Console.WriteLine("Digite o nome da 1ªpessoa")
        nome1 = Console.ReadLine()
        Console.WriteLine("Digite a idade da 1ªpessoa")
        idade1 = Console.ReadLine()
        Console.WriteLine("Digite o nome da 2ªpessoa")
        nome2 = Console.ReadLine()
        Console.WriteLine("Digite a idade da 2ªpessoa")
        idade2 = Console.ReadLine()

        If (idade1 > idade2) Then
            Console.WriteLine("A pessoa com maior idade é: {0}", nome1)
        ElseIf (idade2 > idade1)
            Console.WriteLine("A pessoa com maior idade é: {0}", nome2)
        Else
            Console.WriteLine("As duas pessoas têm a mesma idade")
        End If
        Console.ReadKey()
    End Sub

End Module
