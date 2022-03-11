Module Ex6

    Sub Main()
        Dim carater(20) As String
        Dim inverso(20) As String
        Dim i As Integer

        For i = 0 To 19
            Console.WriteLine("Digite o {0}º carater", i + 1)
            carater(i) = Console.ReadLine()
        Next
        For i = 0 To 19
            Console.WriteLine("Vector lido: {0}", carater(i))
        Next

        Array.Reverse(carater)
        inverso = carater
        For i = 0 To 19
            Console.WriteLine("Vector criado: {0}", inverso(i))
        Next

        Console.ReadKey()
    End Sub

End Module
