Module ex_6

    Sub Main()
        Dim nome As String
        Dim nhoras, venc As Double
        Dim nsecao As Integer
        Console.WriteLine("Digite o nome do funcionário")
        nome = Console.ReadLine()
        Console.WriteLine("Digite o nº de horas trabalhadas")
        nhoras = Console.ReadLine()
        Console.WriteLine("Digite o nº de seção")
        nsecao = Console.ReadLine()
        If (nsecao = 1) Then
            venc = (nhoras * 15)
        Else
            If (nsecao = 2) Then
                venc = (nhoras * 20)
            Else
                If (nsecao = 3) Then
                    venc = (nhoras * 30)
                Else
                    Console.WriteLine("Seção inválida")
                End If
            End If
        End If
        Console.WriteLine("Vencimento: {0}", venc)
        Console.WriteLine("Funcionário: {0}", nome)
        Console.ReadKey()
    End Sub

End Module
