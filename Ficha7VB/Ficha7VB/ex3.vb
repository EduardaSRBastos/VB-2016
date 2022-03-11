Module ex3

    Sub Main()
        Dim n As Integer

        Console.WriteLine("Digite o número")
        n = Console.ReadLine()
        For c As Integer = 1 To 30
            Console.WriteLine(n + c)
        Next
        Console.ReadKey()
    End Sub

End Module
