Module Module1

    Sub Main()

        Dim text As String
        text = Console.ReadLine()

        If Len(text) > 3 Then
            Console.WriteLine(Left(text, 2) & Right(txt, 2))
        Else : Console.WriteLine("")
        End If

        Console.ReadKey()
    End Sub

End Module
