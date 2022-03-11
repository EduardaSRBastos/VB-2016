Module Ex2
    Sub main()
        Dim opcao, i, idade As Integer
        Dim nome As String

        Console.WriteLine("Opções:")
        Console.WriteLine("1-Entrada de dados")
        Console.WriteLine("2-Lista de alunos dada uma idade")
        Console.WriteLine("3-Lista de alunos com a mesma inicial")
        Console.WriteLine("4-Lista nova")
        Console.WriteLine("5-Sair")
        Console.ReadKey()
        Do
            Console.WriteLine("Digite a opção")
            opcao = Console.ReadLine()
            Select Case opcao
                Case 1
                    i = 1
                    dados(idade, nome)
                Case 2
                    If i = 1 Then
                        idadeigual(idade, nome)
                    Else
                        Console.WriteLine("Tem que digitar a opção 1 primeiro")
                    End If
                Case 3
                    If i = 1 Then
                        nomeigual(nome)
                    Else
                        Console.WriteLine("Tem que digitar a opção 1 primeiro")
                    End If
                Case 4
                    If i = 1 Then
                        clear(nome, idade)
                    Else
                        Console.WriteLine("Tem que digitar a opção 1 primeiro")
                    End If
            End Select

        Loop Until opcao = 5

    End Sub
    Sub dados(ByRef idade As Integer, ByRef nome As String)
        Dim i As Integer

        Do
            Console.WriteLine("Digite o nome do aluno")
            nome = Console.ReadLine()
            Console.WriteLine("Digite a idade do aluno")
            idade = Console.ReadLine()
        Loop Until i <= 30
    End Sub
    Sub idadeigual(ByRef idade As Integer, ByRef nome As String)
        Dim idades, i As Integer

        Do
            Console.WriteLine("Digite uma idade")
            idades = Console.ReadLine()

            If idades = idade Then
                Console.WriteLine("Os alunos com a idade {0} são: {1}", idade, nome)

            End If
        Loop Until i <= 30
    End Sub
    Sub nomeigual(ByRef nome As String)
        Dim letra As Char
        Dim i As Integer
        Dim nomes(20) As String
        Console.WriteLine("Digite uma inicial de um nome")
        letra = Console.ReadLine()

        Do
            If letra = nome(0) Then
                Console.WriteLine("Nome: {0}", nome)
            End If
        Loop Until i <= 30
    End Sub
    Sub clear(ByRef nome As String, ByRef idade As Integer)
        nome = "---"
        Console.WriteLine("Nome: {0}", nome)
        idade = vbEmpty
        Console.WriteLine("idade: {0}", idade)
    End Sub
End Module