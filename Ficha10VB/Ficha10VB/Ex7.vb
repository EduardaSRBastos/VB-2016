Module Ex7

    Sub Main()
        Dim num(10) As Double
        Dim i, media, soma, opcao As Double

        soma = 0
        Do
            Console.WriteLine("Entre com uma opção:")
            opcao = Console.ReadLine()
            Select Case opcao
                Case 1
                    For i = 0 To 9
                        Console.WriteLine("Leitura de 10 valores")
                        Console.WriteLine("Digite o {0}º valor", i)
                        num(i) = Console.ReadLine()
                        soma = soma + num(i)
                    Next
                Case 2
                    For i = 0 To 9
                        Console.WriteLine("Mostra elementos")

                    Next
                Case 3
                    Array.Reverse(num)
                    For i = 0 To 9
                        Console.WriteLine("Inverte valores lidos.")
                        Console.WriteLine(num(i))
                    Next
                Case 4
                    Console.WriteLine("Média dos elementos lidos.")
                    media = soma / 10
                    Console.WriteLine("Média= {0}", media)
            End Select
        Loop Until opcao = 5
        Console.ReadKey()
    End Sub

End Module
