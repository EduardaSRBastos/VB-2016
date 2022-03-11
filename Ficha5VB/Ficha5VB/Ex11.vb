Module Ex11

    Sub Main()
        Dim num, manum, menum, c As Double

        menum = 9999
        manum = -9999
        c = 0
        Do
            c = c + 1
            Console.WriteLine("Digite um número")
            num = Console.ReadLine()
            If num > manum Then
                manum = num
            ElseIf menum > num Then
                menum = num
            End If
        Loop Until c = 30
        Console.WriteLine("O maior número é: {0}", manum)
        Console.WriteLine("O menor número é: {0}", menum)
        Console.ReadKey()
    End Sub

End Module
