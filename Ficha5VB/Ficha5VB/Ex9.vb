Module Ex9

    Sub Main()
        Dim num, c, cp, ci As Double

        c = 0
        cp = 0
        ci = 0
        Do
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            If num Mod 2 = 0 Then
                cp = cp + 1
            Else
                ci = ci + 1
            End If
            c = c + 1
        Loop Until c = 30
        Console.WriteLine(" Digitou {0} {1}", cp, "números pares")
        Console.WriteLine(" Digitou {0} {1}", ci, "números ímpares")
        Console.ReadKey()
    End Sub

End Module
