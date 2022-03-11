Module Ex4

    Sub Main()
        Dim jogador(24) As Double
        Dim i As Integer

        For i = 0 To 23
            Console.WriteLine("Digite a idade do jogador {0}", i + 1)
            jogador(i) = Console.ReadLine()
        Next
        For i = 0 To 23
            If i Mod 2 <> 0 Then
                Console.WriteLine("As idades dos jogadores de número ímpar são: {0}", jogador(i))
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
