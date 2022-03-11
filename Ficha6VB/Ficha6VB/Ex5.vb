Module Ex5

    Sub Main()
        Dim nome, mnome As String
        Dim idade, c, midade As Integer

        midade = 0
        mnome = ""
        c = 0
        While c < 5
            Console.WriteLine("Digite o nome do aluno")
            nome = Console.ReadLine()
            Console.WriteLine("Digite a idade")
            idade = Console.ReadLine()
            If idade > midade Then
                midade = idade
                mnome = nome
            End If
            c = c + 1
        End While
        Console.WriteLine("O aluno com maior idade é: {0}", mnome)
        Console.ReadKey()
    End Sub
End Module
