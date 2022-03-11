Module Ex2
    Dim n, i As Integer
    Dim vet(n) As Integer
    Sub main()

        leitura(n, vet)
        Console.WriteLine("A média é de: {0}", media(n, vet))
        Console.ReadKey()
    End Sub
    Sub leitura(ByRef n As Integer, ByRef vet() As Integer)

        Console.WriteLine("Digite um valor")
        n = Console.ReadLine()
        ReDim vet(n)
    End Sub
    Function media(ByRef n As Integer, ByRef vet() As Integer)
        Dim i, soma As Integer

        For i = 0 To n - 1
            Console.WriteLine("Digite o {0}º valor", i + 1)
            vet(i) = Console.ReadLine()
            soma = soma + vet(i)
        Next
        media = soma / n
        Return media
    End Function
End Module
