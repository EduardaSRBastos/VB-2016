Module ex1_2

    Sub Main()
        Dim c, x As Integer

        c = 2
        Do
            Console.WriteLine(c)
            x = 0
            While x < 2
                x = x + 1
                Console.WriteLine(x)
            End While
            c = c - 1
        Loop Until c < 0
        Console.ReadKey()
    End Sub

End Module
