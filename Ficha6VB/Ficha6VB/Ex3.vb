Module Ex3

    Sub Main()
        Dim c As Integer

        c = 0
        While c < 80
            c = c + 1
            If c Mod 2 = 0 Then
                Console.WriteLine(c)
            End If
        End While
        Console.ReadKey()
    End Sub
End Module
