Module ex5

    Sub Main()
        Dim nome, mnome As String
        Dim idade, midade As Integer

        midade = 0
        mnome = ""
        For aluno As Integer = 1 To 15
            Console.WriteLine("Digite o nome")
            nome = Console.ReadLine()
            Console.WriteLine("Digite a idade")
            idade = Console.ReadLine()
            If idade > midade Then
                midade = idade
                mnome = nome
            ElseIf idade = midade Then
                mnome = mnome & " " & nome
            End If
        Next

        Console.WriteLine("O nome do aluno(s) mais velho(s): {0}", mnome)

        Console.ReadKey()
    End Sub

End Module
