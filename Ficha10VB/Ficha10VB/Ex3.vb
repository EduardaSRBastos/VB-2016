Module Ex3

    Sub Main()
        Dim alfabeto(26) As String
        Dim i As Integer

        For i = 0 To 25
            Console.WriteLine("Digite a {0}ª letra", i + 1)
            alfabeto(i) = Console.ReadLine()
        Next
        For i = 0 To 25
            If i Mod 2 = 0 Then
                Console.WriteLine("As letras nas posições pares são: {0}", alfabeto(i))
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
