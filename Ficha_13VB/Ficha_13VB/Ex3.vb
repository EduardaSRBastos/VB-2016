Module Ex3
    Sub main()
        Dim opcao, i As Integer

        Console.WriteLine("Opções:")
        Console.WriteLine("1. Lista planetas")
        Console.WriteLine("2. Posição relativa ao Sol")
        Console.WriteLine("3. Posição relativa a Terra")
        Console.WriteLine("4. Sair")
        Console.WriteLine()
        Do
            Console.WriteLine("Digite uma opção")
            opcao = Console.ReadLine()
            Select Case opcao
                Case 1
                    i = 1
                    lista()
                Case 2
                    If i = i Then
                        Console.WriteLine(distancia)
                    Else
                        Console.WriteLine("Tem que digitar a opção 1 primeiro")
                    End If
                Case 3
                    If i = 1 Then
                        Console.WriteLine(distanciaterra)
                    Else
                        Console.WriteLine("Tem que digitar a opção 1 primeiro")
                    End If
            End Select
        Loop Until opcao = 4
        Console.WriteLine("Prima uma tecla para sair")
        Console.ReadKey()
    End Sub
    Sub lista()

        Console.WriteLine("Mercúrio")
            Console.WriteLine("Vénus")
            Console.WriteLine("Terra")
            Console.WriteLine("Marte")
            Console.WriteLine("Júpiter")
            Console.WriteLine("Saturno")
            Console.WriteLine("Úrano")
            Console.WriteLine("Neptuno")
            Console.WriteLine("Plutão")

    End Sub
    Function distancia() As String
        Dim planeta As String

        Console.WriteLine("Digite o planeta da lista da opção 1")
        planeta = Console.ReadLine()

        If planeta = "Mercúrio" Then
            Console.WriteLine("distância ao Sol = {0}", 1)
        ElseIf planeta = "Vénus" Then
            Console.WriteLine("distância ao Sol = {0}", 2)
        ElseIf planeta = "Terra" Then
            Console.WriteLine("distância ao Sol = {0}", 3)
        ElseIf planeta = "Marte" Then
            Console.WriteLine("distância ao Sol = {0}", 4)
        ElseIf planeta = "Júpiter" Then
            Console.WriteLine("distância ao Sol= {0}", 5)
        ElseIf planeta = "Saturno" Then
            Console.WriteLine("distância ao Sol= {0}", 6)
        ElseIf planeta = "Úrano" Then
            Console.WriteLine("distância ao Sol= {0}", 7)
        ElseIf planeta = "Neptuno" Then
            Console.WriteLine("distância ao Sol = {0}", 8)
        ElseIf planeta = "Plutão" Then
            Console.WriteLine("distância ao Sol= {0}", 9)
        End If
        Return distancia
    End Function
    Function distanciaterra() As String
        Dim planeta As String

        Console.WriteLine("Digite o planeta da lista da opção 1")
        planeta = Console.ReadLine()

        If planeta = "Mercúrio" Then
            Console.WriteLine("distância à Terra= {0}", -2)
        ElseIf planeta = "Vénus" Then
            Console.WriteLine("distância à Terra= {0}", -1)
        ElseIf planeta = "Terra" Then
            Console.WriteLine("distância à Terra= {0}", 0)
        ElseIf planeta = "Marte" Then
            Console.WriteLine("distância à Terra= {0}", 1)
        ElseIf planeta = "Júpiter" Then
            Console.WriteLine("distância à Terra= {0}", 2)
        ElseIf planeta = "Saturno" Then
            Console.WriteLine("distância à Terra= {0}", 3)
        ElseIf planeta = "Úrano" Then
            Console.WriteLine("distância à Terra= {0}", 4)
        ElseIf planeta = "Neptuno" Then
            Console.WriteLine("distância à Terra= {0}", 5)
        ElseIf planeta = "Plutão" Then
            Console.WriteLine("distância à Terra= {0}", 6)
        End If
        Return distanciaterra
    End Function
End Module
