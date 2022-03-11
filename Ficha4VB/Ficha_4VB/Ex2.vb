Module Ex2
    Sub Main()
        Dim vogal As String

        Console.WriteLine("Digite a vogal em minúsculo")
        vogal = Console.ReadLine()

        Select Case vogal
            Case "a"
                Console.WriteLine("A")
            Case "e"
                Console.WriteLine("E")
            Case "i"
                Console.WriteLine("I")
            Case "o"
                Console.WriteLine("O")
            Case "u"
                Console.WriteLine("U")
            Case Else
                Console.WriteLine("Não digitou uma vogal em minúsculo.")
        End Select
        Console.ReadKey()
    End Sub
End Module
