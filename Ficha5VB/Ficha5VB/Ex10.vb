Module Ex10

    Sub Main()
        Dim num, c, c10, c20, c100, soma As Double

        c10 = 0
        c20 = 0
        c100 = 0
        soma = 0
        Do
            c = c + 1
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            soma = soma + num
            If num > 100 Then
                c100 = c100 + 1
                c20 = c20 + 1
                c10 = c10 + 1
            ElseIf num > 20 Then
                c20 = c20 + 1
                c10 = c10 + 1
            ElseIf num > 10 Then
                c10 = c10 + 1
            Else
                Console.WriteLine("Digitou um número abaixo de 10")
            End If
        Loop Until c = 40
        Console.WriteLine("O somatório total é {0}", soma)
        Console.WriteLine(" Digitou {0} {1}", c100, "números maiores que 100")
        Console.WriteLine(" Digitou {0} {1}", c20, "números maiores que 20")
        Console.WriteLine(" Digitou {0} {1}", c10, "números maiores que 10")
        Console.ReadKey()
    End Sub

End Module
