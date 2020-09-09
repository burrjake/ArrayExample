Module ArrayExample

    Sub Main()

    End Sub

    Sub SimpleArray()
        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"
        Console.ReadLine()

        For i = LBound(names) To UBound(names)

        Next
    End Sub

    Sub Multidimensional()
        Dim dataArray(3, 5) As Integer

        dataArray(0, 0) = 5
        dataArray(1, 0) = 7


    End Sub

End Module
