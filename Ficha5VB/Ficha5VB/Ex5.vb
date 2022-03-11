Module Ex5

    Sub Main()
        Dim num, media, c, soma As Double

        soma = 0
        c = 0
        Do
            c = c + 1
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            soma = soma + num
        Loop Until c = 20
        media = soma / 20
        Console.WriteLine("A média é:{0}", media)
        Console.ReadKey()
    End Sub

End Module
