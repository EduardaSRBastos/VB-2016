Module Ex2

    Sub Main()
        Dim s, n, c As Double

        For n = 1 To 20
            s = 0
            For c = 1 To n
                s = s + (n / c)

            Next
            Console.WriteLine("Para o N= {0}, o valor da soma é: {1}", n, s)
        Next
        Console.ReadKey()
    End Sub

End Module
