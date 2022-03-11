Module ex2

    Sub Main()
        Dim n, total As Integer

        Console.WriteLine("Digite o número")
        n = Console.ReadLine()
        For c As Integer = 1 To 10

            total = n * c
            Console.WriteLine("{0} x {1} = {2}", n, c, total)
        Next
        Console.ReadKey()
    End Sub

End Module
