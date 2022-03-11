Module Ex3
    Sub Main()
        Dim nome As String
        Dim depart, nhoras, venc As Integer

        Console.WriteLine("Digite o nome do funcionário")
        nome = Console.ReadLine()
        Console.WriteLine("Digite o departamento")
        depart = Console.ReadLine()

        Console.WriteLine("Digite o nº de horas trabalhadas")
        nhoras = Console.ReadLine()

        Select Case depart
            Case 19
                venc = nhoras * 10
            Case 20
                venc = nhoras * 15
            Case 21, 22, 23
                venc = nhoras * 20
            Case 24
                venc = nhoras * 25
            Case 25
                venc = nhoras * 30
            Case Else
                Console.WriteLine("Digitou um departamento errado")
        End Select
        Console.WriteLine("Funcionário: {0}", nome)
        Console.WriteLine("Vencimento: {0}", venc)
        Console.ReadKey()
    End Sub
End Module
