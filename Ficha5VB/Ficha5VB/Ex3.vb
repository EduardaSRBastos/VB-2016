Module Ex3

    Sub Main()
        Dim num, c As Integer

        Console.WriteLine("Digite um número")
        num = Console.ReadLine()
        c = 0
        Do
            c = c + 1
            num = num + 1
            Console.WriteLine(num)
        Loop Until c = 20
        Console.ReadKey()
    End Sub

End Module
