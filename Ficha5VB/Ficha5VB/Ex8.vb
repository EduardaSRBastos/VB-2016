Module Ex8

    Sub Main()
        Dim num, c As Double

        c = 0
        Do
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            c = c + 1
        Loop Until num = 0
        Console.WriteLine("Digitou {0} {1}", c - 1, "número(s)")
        Console.ReadKey()
    End Sub

End Module
