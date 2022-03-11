Module ex1

    Sub Main()
        Dim num1, num2, num3 As Double

        Console.WriteLine("Digite o 1º número")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o 2º número")
        num2 = Console.ReadLine()
        Console.WriteLine("Digite o 3º número")
        num3 = Console.ReadLine()
        If (num1 > num2) And (num1 > num3) Then
            Console.WriteLine("O número maior é: {0}", num1)
        ElseIf (num2 > num3) And (num2 > num1)
            Console.WriteLine("O número maior é: {0}", num2)
        ElseIf (num3 > num1) And (num3 > num2)
            Console.WriteLine("O número maior é: {0}", num3)
        Else
            Console.WriteLine("Os números são iguais")
        End If
        Console.ReadKey()
    End Sub

End Module
