Module Ex3

    Sub Main()
        Dim n, c, fact As Double

        For n = 1 To 20
            fact = 1
            For c = 0 To n - 1
                fact = fact * (n - c)
            Next
            Console.WriteLine("O factorial do N= {0} é {1}", n, fact)
        Next
        Console.ReadKey()
    End Sub

End Module
