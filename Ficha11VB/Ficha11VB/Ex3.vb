Module Ex3

    Sub Main()
        Dim M1(4, 3) As Double
        Dim M2(4, 3) As Double
        Dim V1(4), V2(4), V3(4), V4(4) As Double
        Dim l, c As Double

        For l = 0 To 4
            For c = 0 To 3
                Console.WriteLine("Digite o elemento ( {0}, {1} ) da matriz 1", l, c)
                M1(l, c) = Console.ReadLine()
            Next
        Next
        For l = 0 To 4
            For c = 0 To 3
                Console.WriteLine("Digite o elemento ( {0}, {1} ) da matriz 2", l, c)
                M2(l, c) = Console.ReadLine()
            Next
        Next
        For l = 0 To 4
            For c = 0 To 3
                V1(l) = M1(l, c) + M2(l, c)
                Console.WriteLine("Vector 1: {0}", V1(l))
            Next
        Next
        For l = 0 To 4
            For c = 0 To 3
                V2(l) = M1(l, c) + M2(l, c)
                Console.WriteLine("Vector 2: {0}", V2(l))
            Next
        Next
        For l = 0 To 4
            For c = 0 To 3
                V3(l) = M1(l, c) + M2(l, c)
                Console.WriteLine("Vector 3: {0}", V3(l))
            Next
        Next
        For l = 0 To 4
            For c = 0 To 3
                V4(l) = M1(l, c) + M2(l, c)
                Console.WriteLine("Vector 4: {0}", V4(l))
            Next
        Next
        Console.ReadKey()
    End Sub

End Module
