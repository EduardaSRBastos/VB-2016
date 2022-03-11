Module ex_2

    Sub Main()
        Dim num As Integer
        Console.WriteLine("Introduza um número")
        num = Console.ReadLine()
        If (num Mod 2 = 0) Then
            Console.WriteLine("número par")
        Else
            Console.WriteLine("número ímpar")
        End If
        Console.ReadKey()
    End Sub

End Module
