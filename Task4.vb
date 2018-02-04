Module Module1

    Sub Main()

        Dim s1 As String
        Dim s2 As String
        Dim s3 As String = ""

        Console.Write("plz enter first word ")
        s1 = Console.ReadLine()

        Console.Write("Enter second word")
        s2 = Console.ReadLine()

        s3 = Mid(s2, 1, 2) & Mid(s1, 3) & " " & Mid(s1, 1, 2) & Mid(s2, 3)
        Console.WriteLine(s3)

        Console.ReadKey()

    End Sub

End Module
