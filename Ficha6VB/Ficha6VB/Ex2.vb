Module Ex2

    Sub Main()
        Dim num, c As Integer

        c = 0
        Console.WriteLine("Digite um número")
        num = Console.ReadLine()
        While c < 30
            c = c + 1
            num = num + 1
            Console.WriteLine(num)
        End While
        Console.ReadKey()
    End Sub
End Module
