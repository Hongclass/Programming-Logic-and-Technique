Module Module1

    ' **MODIFY** HINT: VB PLC page 75
    ' #1--> Use VB array length property instead of SIZE when displaying
    ' #2--> Remove initialization list and read input from user
    ' #3--> Creat a function to total the value of passed array elements

    Sub Main()
        ' Declare a constant for the array size
        Const SIZE As Integer = 5

        ' #1--> Use VB array length property instead of SIZE when displaying
        ' Declare an array initialized with values
        ' Dim scores() As Double = {2.5, 8.3, 6.5, 4.0, 5.2}

        ' #2--> Remove initialization list and read input from user
        Dim scores(SIZE - 1) As Double

        ' Declare variable to accumulate the total
        ' Dim total As Double = 0
        ' Declare variable to hold average
        Dim average As Double
        ' Declare counter variable for loop
        Dim index As Integer

        ' Calculate total of all array elements
        ' #1--> Use VB array length property instead of SIZE when displaying
        ' For index = 0 To SIZE - 1
        ' total = total + scores(index)
        ' Next
        ' #2--> Remove initialization list and read input from user
        For index = 0 To scores.Length - 1
            Console.Write("Enter your test score: ")
            scores(index) = CDbl(Console.ReadLine())
            ' total = total + scores(index)
        Next
        ' #3--> Creat a function to total the value of passed array elements
        ' function call
        Dim total As Integer
        total = getTotal(scores)
        ' Calculate the average of the array elements
        ' average = getTotal(scores) / SIZE
        average = total / scores.Length
        Console.WriteLine("The average of the array elements is " & average)
    End Sub

    ' #3--> Creat a function to total the value of passed array elements--- VB PLC page 80
    Function getTotal(ByVal scores() As Double) As Double
        ' loop counter
        Dim index As Integer
        ' accumulator, initialized to 0
        Dim total As Double = 0
        ' Cacculate the total of the array elements
        For index = 0 To scores.Length - 1
            total = total + socres(index)
        Next
        ' Return the total
        Return total
    End Function

End Module
