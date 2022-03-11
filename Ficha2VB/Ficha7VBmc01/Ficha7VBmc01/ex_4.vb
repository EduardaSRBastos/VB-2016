Module ex_4

    Sub Main()
        Dim num1, num2, num3 As Double

        Console.WriteLine("Digite o 1ºnúmero")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o 2ºnúmero")
        num2 = Console.ReadLine()
        Console.WriteLine("Digite o 3ºnúmero")
        num3 = Console.ReadLine()

        If (num1 > num2) And (num1 > num3) Then
            Console.WriteLine("o número maior é: {0}", num1)
        Else
            If (num2 > num3) Then
                Console.WriteLine("o número maior é: {0}", num2)
            Else
                Console.WriteLine("o número maior é: {0}", num3)
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
