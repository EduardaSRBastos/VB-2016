Module Ex7

    Sub Main()
        Dim num, soma As Double

        soma = 0
        Do
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            soma = soma + num
        Loop Until soma > 5000
        Console.WriteLine("O valor do somatório é: {0}", soma)
        Console.ReadKey()
    End Sub

End Module
