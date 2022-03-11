Module ex6

    Sub Main()
        Dim n, s As Double

        s = 0
        Do
            Console.WriteLine("Digite o número")
            n = Console.ReadLine()
        Loop Until n >= 1

        For index As Double = 0 To n
            s = s + (n / index)
        Next

        Console.WriteLine("Valor= {0}", s)
        Console.ReadKey()
    End Sub

End Module
