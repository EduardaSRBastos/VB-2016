Module Ex4

    Sub Main()
        Dim n, c, i, cont As Double

        For c = 0 To 10
            Console.WriteLine("Digite um número")
            n = Console.ReadLine()
            cont = 0
            For i = 1 To n
                If n Mod i = 0 Then
                    cont = cont + 1
                End If
            Next
            If cont = 2 Then
                Console.WriteLine("O número é primo")
            Else
                Console.WriteLine("O número não é primo")
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
