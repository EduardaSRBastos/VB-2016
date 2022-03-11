Module Ex5

    Sub Main()
        Dim quant(12) As Integer
        Dim maiorquant As Integer
        Dim i, mes As Integer

        maiorquant = 0

        For i = 0 To 11
            Console.WriteLine("Digite a quantidade vendida de um produto no mês {0}", i + 1)
            quant(i) = Console.ReadLine()
        Next
        For i = 0 To 11
            If quant(i) > maiorquant Then
                maiorquant = quant(i)
                mes = i + 1
            End If
        Next
        Console.WriteLine("O mês que vendeu mais foi: {0}", mes)
        Console.ReadKey()
    End Sub

End Module
