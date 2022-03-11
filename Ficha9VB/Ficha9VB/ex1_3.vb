Module ex1_3

    Sub Main()
        Dim c, x As Integer

        For c = 1 To 2
            Console.WriteLine(c)
            x = 0
            Do
                x = x + 1
                Console.WriteLine(x)
            Loop Until x = 3
        Next
        Console.ReadKey()
    End Sub

End Module
