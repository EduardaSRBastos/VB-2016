Module Ex1
    Dim num1, num2, opcao, diferenca, soma, i As Double
    Sub Main()

        Do

            Console.WriteLine("Digite a opção")
            opcao = Console.ReadLine()

            Select Case opcao
                Case 1
                    opcao1()
                    i = 1
                Case 2
                    If i = 1 Then
                        opcao2()
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
                Case 3
                    If i = 1 Then
                        opcao3()
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
                Case 4
                    If i = 1 Then
                        opcao4()
                    Else
                        Console.WriteLine("Tem que escrever a opção 1")
                    End If
                Case Else
                    Console.WriteLine("Opção inválida")
            End Select
        Loop Until opcao = 5
    End Sub
    Sub opcao1()
        Console.WriteLine("Digite o 1ºnúmero")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o 2ºnúmero")
        num2 = Console.ReadLine()
    End Sub
    Sub opcao2()
        If num1 Mod 2 = 0 Then
            Console.WriteLine("Par= {0}", num1)
        Else
            Console.WriteLine("Impar= {0}", num1)
        End If
        If num2 Mod 2 = 0 Then
            Console.WriteLine("Par= {0}", num2)
        Else
            Console.WriteLine("Impar= {0}", num2)
        End If
    End Sub
    Sub opcao3()
        If num1 > num2 Then
            diferenca = num1 - num2
            Console.WriteLine("Diferença= {0}", diferenca)
        Else
            Console.WriteLine("Não é possível")
        End If
    End Sub
    Sub opcao4()
        soma = num1 + num2
        Console.WriteLine("Soma= {0}", soma)
    End Sub
End Module
