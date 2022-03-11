Module Ex2
    Dim num, linha As Integer

    Sub main()

        For linha = 1 To 10
            For num = 1 To linha
                Console.Write(num)
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()
    End Sub

End Module
