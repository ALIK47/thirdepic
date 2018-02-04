Module Module1

    Sub Main()

        Dim x, xFrnt, xBck, y, yFrnt, yBck As String

        Console.Write("Enter first word")
        x = Console.ReadLine()
        Console.Write("Enter second word")
        y = Console.ReadLine()

        If Len(x) Mod 2 = 0 Then
            xFrnt = Mid(x, 1, Len(x) / 2)
            xBck = Mid(x, Len(x) / 2 + 1)
        Else
            xFrnt = Mid(x, 1, (Len(x) + 1) / 2)
            xBck = Mid(x, (Len(x) + 3) / 2)
        End If

        If Len(y) Mod 2 = 0 Then
            yFrnt = Mid(y, 1, Len(y) / 2)
            yBck = Mid(y, Len(y) / 2 + 1)
        Else
            yFrnt = Mid(y, 1, (Len(y) + 1) / 2)
            yBck = Mid(y, (Len(y) + 3) / 2)
        End If

        Console.WriteLine(xFrnt & yFrnt & xBck & yBck)
        Console.ReadKey()
      
    End Sub

End Module
