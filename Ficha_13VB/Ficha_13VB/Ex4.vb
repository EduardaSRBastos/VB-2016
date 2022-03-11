Module Ex4
    Sub main()
        Dim palavra As String

        leitura(palavra)
        Console.ReadKey()
        Console.WriteLine("Clique em qualquer tecla para sair.")
    End Sub
    Sub leitura(ByRef palavra As String)
        Dim maior As Integer
        maior = 0
        menor = 20
        Do
            Console.WriteLine("Digite uma palavra")
            palavra = Console.ReadLine()
            Console.WriteLine("Tamanho da palavra: {0}", palavra.Length())
            If palavra.Length > maior Then
                maior = palavra.Length()
            Else
                menor = palavra.Length
            End If

        Loop Until palavra = "STOP"
    End Sub
End Module
