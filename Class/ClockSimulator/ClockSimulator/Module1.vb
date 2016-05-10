Module Module1

    Sub Main()
        ' local variables
        Dim hours, minutes, secondes As Integer
        ' loop for each hour of the day
        For hours = 0 To 23
            ' loop for each minute of the hour
            For minutes = 0 To 59
                ' loop for each second of the minute
                For seconds = 0 To 59
                    Console.WriteLine(hours & ":" & minutes & ":" & seconds)
                Next
            Next
        Next
    End Sub

End Module
