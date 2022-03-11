Module Ex4

    Sub Main()
        Dim num, c As Integer

        Console.WriteLine("Digite um número")
        num = Console.ReadLine()
        c = 0
        Do
            If num Mod 2 = 0 Then
                num = num + 2
                Console.WriteLine(num)
            Else
                num = num + 1
                Console.WriteLine(num)
            End If
            c = c + 1
        Loop Until c = 10
        Console.ReadKey()
    End Sub

End Module
