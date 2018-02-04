Module Module1

    Sub Main()

        Dim NoOfDonuts As Integer
        NoOfDonuts = Console.ReadLine()

        If NoOfDonuts > 9 Then
            Console.WriteLine("Number of donuts: many")
        Else : Console.WriteLine("Number of donuts: " & NoOfDonuts)
        End If

        Console.ReadKey()

    End Sub

End Module
