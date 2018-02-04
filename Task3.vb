Module Module1

    Sub Main()

        Dim x, x2 As String
        Dim y As Char

        Console.WriteLine("Enter word: ")
        x = Console.ReadLine()
        y = x(0)
        x2 = y

        For i = 1 To Len(x) - 1
            If x(i) <> y Then
                x2 = x2 & x(i)
            Else : x2 = x2 & "*"
            End If
        Next

        Console.WriteLine(x2)





    End Sub

End Module
