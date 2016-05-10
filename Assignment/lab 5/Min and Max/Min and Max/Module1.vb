Module Module1
    ' Author: Hong Zhang
    ' Date: 10/01/2012
    ' Program: Largest and smallest
    ' Description: 
    ' This Program will find max and min numbers in a set of user’s input

    Sub Main()
        ' Declare needed variables
        Dim data, min, max As Integer
        ' Display intro message
        showIntro()
        ' Get initial input 
        ' and set minimum and maximum values
        initialInput(data, min, max)
        ' Declare a variable to hold the number
        Dim keepGoing As Integer
        ' Loop over repeated user entry
        Do
            ' Get second input
            Console.Write("Enter your next number: ")
            keepGoing = CInt(Console.ReadLine())
            ' New number entry replace the current max or min
            Compare(keepGoing, min, max)
        Loop Until keepGoing = -99
        Compare(keepGoing, min, max)
        ' Display min and max found in the loop
        output(min, max)
    End Sub

    ' The showIntro module display an 
    ' introductory screen
    Sub showIntro()
        Console.WriteLine("Enter a series of numbers.")
        Console.WriteLine("The Program will find max and min numbers.")
        Console.WriteLine("-99 will end the input.")
    End Sub

    ' The initialInput (data, min, max) module
    ' will input initial data 
    ' and declare variables min and max 
    ' to hold the current minimum and maximum values.  
    Sub initialInput(ByVal data, ByRef min, ByRef max)
        Console.Write("Enter your first number: ")
        data = CDbl(Console.ReadLine())
        ' Initialize minimum and maximum values 
        ' to the first data point entered by the user.
        min = data
        max = data
    End Sub
    ' The compare(keepGoing, min, max)module
    ' wiill use new number entry to replace the current max or min
    Sub compare(ByVal keepGoing, ByRef min, ByRef max)
        If keepGoing < min Then
            min = keepGoing
        ElseIf keepGoing > max Then
            max = keepGoing
        End If
    End Sub

    ' The output (min, max) module 
    ' will display min and max found in the loop
    Sub output(ByVal min, ByVal max)
        Console.WriteLine("The smallest number = " & min)
        Console.WriteLine("The largest  number = " & max)
    End Sub

    ' sample output
    ' Enter a series of numbers.
    ' The Program will find max and min numbers.
    ' -99 will end the input.
    ' Enter your first number: 12
    ' Enter your next number: 34
    ' Enter your next number: 357
    ' Enter your next number: -43
    ' Enter your next number: 054
    ' Enter your next number: -974
    ' Enter your next number: -99
    ' The smallest number = -974
    ' The largest  number = 357
    ' Press any key to continue . . .

End Module
