Module Ex4

    Sub Main()
        Dim a, b, c, d As Integer
        Dim carat As String

        carat = "n"
        a = 0
        b = 0
        c = 0
        d = 0
        While carat <> " "
            Console.WriteLine("Digite a sequência de carateres")
            carat = Console.ReadLine()
            Select Case carat
                Case "a", "e", "i", "o", "u"
                    a = a + 1
                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                    b = b + 1
                Case ".", ",", ";", ":", "!", "?"
                    c = c + 1
                Case Else
                    d = d + 1
            End Select
        End While
        Console.WriteLine("Total de vogais :{0}", a)
        Console.WriteLine("Total de dígitos numéricos :{0}", b)
        Console.WriteLine("Total de carateres de pontuação :{0}", c)
        Console.WriteLine("Total de outros carateres :{0}", d - 1)
        Console.ReadKey()
    End Sub
End Module
