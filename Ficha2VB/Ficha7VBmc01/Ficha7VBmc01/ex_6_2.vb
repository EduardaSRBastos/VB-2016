Module ex_6_2
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

        Select Case nsecao
            Case 1
                venc = (nhoras * 15)
            Case 2
                venc = (nhoras * 20)
            Case 3
                venc = (nhoras * 30)
            Case Else
                Console.WriteLine("Seção inválida")
        End Select
        Console.WriteLine("Vencimento: {0}", venc)
        Console.WriteLine("Funcionário: {0}", nome)

        Console.ReadKey()
    End Sub
End Module
