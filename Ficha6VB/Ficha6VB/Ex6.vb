Module Ex6

    Sub Main()
        Dim N, s, c As Double

        c = 0
        s = 0
        Console.WriteLine("Digite um número")
        N = Console.ReadLine()
        While N - c >= 1
            c = c + 1
            s = s + (N - c)
            Console.WriteLine(s)
        End While
        Console.ReadKey()
    End Sub
End Module
