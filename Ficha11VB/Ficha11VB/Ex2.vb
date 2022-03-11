Module Ex2

    Sub Main()
        Dim M1(9, 4) As Double
        Dim M2(9, 4) As Double
        Dim M3(9, 4) As Double

        For i = 0 To 9
            For j = 0 To 4
                Console.WriteLine("Digite o elemento ( {0}, {1} ) da matriz 1", i, j)
                M1(i, j) = Console.ReadLine()
            Next
        Next
        For i = 0 To 9
            For j = 0 To 4
                Console.WriteLine("Digite o elemento ( {0}, {1} ) da matriz 2", i, j)
                M2(i, j) = Console.ReadLine()
            Next
        Next
        For i = 0 To 9
            For j = 0 To 4
                M3(i, j) = M1(i, j) + M2(i, j)
                Console.WriteLine("Soma do elemento ( {0}, {1} ):", M3(i, j))
            Next
        Next
        Console.ReadKey()
    End Sub

End Module
