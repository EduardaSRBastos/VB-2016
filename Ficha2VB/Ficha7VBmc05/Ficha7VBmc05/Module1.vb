Module Module1

    Sub Main()
        Dim lado1, lado2, lado3 As Double
        Console.WriteLine("Indique o 1ºlado")
        lado1 = Console.ReadLine()
        Console.WriteLine("Indique o 2ºlado")
        lado2 = Console.ReadLine()
        Console.WriteLine("Indique o 3ºlado")
        lado3 = Console.ReadLine()
        If (lado1 = lado2) And (lado2 = lado3) Then
            Console.WriteLine("O triângulo é equilátero.")
        Else
            If (lado1 = lado2) Or (lado2 = lado3) Or (lado3 = lado1) Then
                Console.WriteLine("O triângulo é isósceles.")
            Else
                Console.WriteLine("O triângulo é escaleno.")
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
