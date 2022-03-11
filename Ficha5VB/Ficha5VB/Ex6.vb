Module Ex6

    Sub Main()
        Dim notateo, notapra, media, c As Double

        c = 0
        Do
            Console.WriteLine("Digite a nota do teste teórico")
            notateo = Console.ReadLine()
            Console.WriteLine("Digite a nota do teste práctico")
            notapra = Console.ReadLine()
            media = (notateo + notapra) / 2
            Console.WriteLine("A média é: {0}", media)
            If media >= 9.5 Then
                Console.WriteLine("Aluno aprovado")
            Else
                Console.WriteLine("Aluno reprovado")
            End If
        Loop Until c = 30
        Console.ReadKey()
    End Sub

End Module
