Module Module1
    ' Author: Hong Zhang
    ' Date: 09/24/2012
    ' Program: Repetition
    ' Descr:
    ' In-class exercise to practice the use of conditional
    ' loop examples in Visual Basic.

    Sub Main()
        ' WhileLoop()
        ' DoWhile()
        DoUntil()

    End Sub

    ' This module implements the main modul of Program 5-4 on page 179
    ' A pre-test while loop is used
    ' (see Lecture Slide 8 for pseudocode and flowchart)
    Sub whileloop()
        ' local variables
        Dim keepGoing As String
        ' get starting value for condition from user
        Console.Write("Do you want to calculate sales commissions? (y for yes): ")
        keepGoing = Console.ReadLine()
        Do While keepGoing = "y"
            showCommission()
            ' does user want to continue?
            Console.Write("Do you want to calculate another commission? (y for yes): ")
            keepGoing = Console.ReadLine()
        Loop
    End Sub

    ' This module implements the main module of Program 5-5 on page 182
    ' A post-test Do-While loop is used 
    ' (see lecture slide 11 for pseudocode and flowchart)
    Sub DoWhile()
        ' local variables
        Dim keepGoing As String
        Do
            showCommission()
            ' does user want to continue
            Console.Write("Do you want to calculate another commission? (y for yes):")
            keepGoing = Console.ReadLine()
        Loop While keepGoing = "y"
    End Sub

    ' This module implements the main module of 
    ' lecture slide 15 (pseudocode and flowchart)
    Sub DoUntil()
        ' local variables
        Dim keepGoing As String
        'post-test Do-untile loop
        Do
            showCommission()
            ' does user want to continue
            Console.Write("Do you want to calculate another commission? (y for yes):")
            keepGoing = Console.ReadLine()
        Loop Until keepGoing <> "y"
    End Sub

    ' This module calculates and displays the commision
    ' on a given sales amount.
    Sub showCommission()
        Dim sales, commission As Double
        ' local named constant 
        Const COMMISION_RATE As Double = 0.1
        ' get the amount of sales 
        Console.Write("Enter the amount of sales: ")
        sales = CDbl(Console.ReadLine())
        ' calculate and display the commission.
        commission = sales * COMMISION_RATE
        Console.WriteLine("The commission is $ " & commission)
    End Sub

    ' Sample Output
    ' Do you want to calculate sales commissions? (y for yes): y
    ' Enter the amount of sales: 5435
    ' The commission is $ 543.5
    ' Do you want to calculate another commission? (y for yes): n
    ' Press any key to continue . . .

    ' Enter the amount of sales: 3467
    ' The commission is $ 346.7
    ' Do you want to calculate another commission? (y for yes):y
    ' Enter the amount of sales: 34567
    ' The commission is $ 3456.7
    ' Do you want to calculate another commission? (y for yes):n
    ' Press any key to continue . . .

End Module
