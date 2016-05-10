Module Module1

    ' **MODIFY** HINT: VB PLC page 75
    ' #1--> Use VB array length property instead of SIZE when displaying
    ' #2--> Remove initialization list and read input from user

    Sub Main()
        ' Declare a constant for the array size
        Const SIZE As Integer = 5
        Dim scores(SIZE - 1) As Double
        ' Declare variable to accumulate the total
        Dim total As Double = 0
        ' Declare variable to hold average
        Dim average As Double
        ' Declare counter variable for loop
        Dim index As Integer
        ' Calculate total of all array elements
        For index = 0 To scores.Length - 1
            Console.Write("Enter your test score: ")
            scores(index) = CDbl(Console.ReadLine())
            total = total + scores(index)
        Next
        ' Calculate the average of the array elements
        average = total / SIZE
        Console.WriteLine("The average of the array elements is " & average)
    End Sub

End Module
