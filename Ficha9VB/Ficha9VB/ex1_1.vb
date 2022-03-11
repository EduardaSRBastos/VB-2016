Module ex1_1

    Sub Main()
        Dim c, x As Integer

        c = 0
        Do
            Console.WriteLine(c)
            x = 0
            Do
                x = x + 1
                Console.WriteLine(x)
            Loop Until x = 3
            c = c + 1
        Loop Until c = 2
        Console.ReadKey()
    End Sub

End Module
