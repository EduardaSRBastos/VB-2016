Module Ex1

    Sub Main()
        Dim nome As String
        Dim c As Integer

        c = 0
        Console.WriteLine("Digite o nome")
        nome = Console.ReadLine()
        Do
            c = c + 1
            Console.WriteLine(nome)
        Loop Until c = 3
        Console.ReadKey()
    End Sub

End Module
