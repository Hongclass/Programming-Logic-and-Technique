Module Module1
    ' Author: Hong Zhang
    ' Date:   09/17/2012
    ' Prog:   TestCase
    ' Descr:  
    ' In-class exercise to practice the use of the
    ' multiple alternative, or case, logic structure.

    Sub Main()
        ' creat variable to store month date
        Dim month As Integer

        ' get month data from user
        Console.Write("Please enter a month number (1,2,3): ")
        month = CInt(Console.ReadLine())

        ' diaplay user entered data
        Console.WriteLine("You entered " & month)

        ' determine which month was entered
        Select Case month
            Case 1
                Console.WriteLine("January")
            Case 2
                Console.WriteLine("February")
            Case 3
                Console.WriteLine("March")
            Case Else
                Console.WriteLine("You entered an invalid month!")
        End Select

        ' display closing message
        Console.WriteLine("That's all folks!")

    End Sub

End Module
