Module Module1

    Sub Main()
        ' CIS1400 -- Programming and Logic Technique
        ' Serial Search Example Program 8-6 in Gaddis
        ' Constant for the array size
        Const SIZE As Integer = 10
        ' Declare an array to hold test scores
        Dim scores() As Integer = _
            {87, 75, 98, 100, 82, 72, 88, 92, 60, 78}
        ' Declare a Boolean variable to act as a flag
        Dim found As Boolean
        ' Declare a variable to use as a loop counter
        Dim index As Integer
        ' The flag must initially be set to False
        found = False
        ' Set the counter variable to 0
        index = 0
        ' Step through the array searching for a
        ' score equal to 100.
        While found = False And index <= SIZE - 1
            If scores(index) = 100 Then
                found = True
	    Else
            	index = index + 1
            End If
        End While
        ' Display the search results
        If found Then
            Console.WriteLine("You earned 100 on test number " & index + 1)
        Else
            Console.WriteLine("You did not earn 100 on any test.")
        End If
    End Sub

End Module
