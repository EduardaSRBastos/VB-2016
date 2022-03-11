Module ex4

    Sub Main()
        Dim N, l, c As Integer
        Dim M1(3, 5) As Integer

        Console.WriteLine("Digite o número")
        N = Console.ReadLine()

        For l = 0 To 3
            For c = 0 To 5
                M1(l, c) = N - c
                Console.Write(M1(l, c))

            Next
            N = N - 1
            Console.ReadKey()
            Console.WriteLine()
        Next

    End Sub

End Module
