Module Module1
    ' Author: Hong Zhang
    ' Date: 10/22/2012
    ' Program: Rainfall Statistics
    ' Description:
    ' This program will takes rainfall statistics and
    ' display the total for a year, average monthly
    ' rainfall, and highest and lowest amounts.

    Sub Main()
        ' Constant for the number of months.
        Const SIZE As Integer = 12
        ' Array to hold each month.
        Dim months() As String = {"January", "February", "March", "April",
                                      "May", "June", "July", "August",
                                      "September", "October", "November", "December"}
        ' Array to hold each month’s rainfall.
        Dim rainfall(SIZE)
        ' Get each month’s rainfall.
        Dim index As Integer
        For index = 0 To SIZE - 1
            Console.Write("Enter the rainfall of " & months(index) & "month: ")
            ' Validate user input cannot accept negative numbers.
            rainfall(index) = CDbl(Console.ReadLine())
            Do While rainfall(index) < 0
                Console.WriteLine("Rainfall must be greater than 0. ")
                Console.WriteLine("Please enter correct value. ")
                rainfall(index) = CDbl(Console.ReadLine())
            Loop
        Next
        ' Display the total for a year, average monthly rainfall, and highest and lowest amounts.
        display(rainfall, months, SIZE)

    End Sub

    ' The display module display each month’s rainfall, the average rainfall, 
    ' the months with the highest and lowest amounts.
    Sub display(ByVal rainfall(), ByVal months(), ByVal arraySize)
        Dim index As Integer
        Console.WriteLine("Here is each month’s rainfall: ")
        For index = 0 To arraySize - 1
            Console.Write(months(index) & ": " & rainfall(index) & "inch(es)")
        Next
        Console.WriteLine("The total rainfall for the year is " & getTotal(rainfall(arraySize), arraySize) & " inches.")
        Console.WriteLine("The average rainfall for the year is " & getAverage(rainfall(arraySize), arraySize) & " inches.")
        Console.WriteLine("The highest amount of rainfall was " & months(arraySize) &
                          ":" & GetLargestRainfall(rainfall(arraySize), arraySize) & " inches.")
        Console.WriteLine("The lowest amount of rainfall was " & months(arraySize) &
                          ":" & GetSmallestRainfall(rainfall(arraySize), arraySize) & " inches.")
    End Sub

    ' The getTotal function determines the total rainfall of the year.
    Function getTotal(ByVal rainfall() As Double, ByVal arraySize As Integer) As Double
        Dim total As Double = 0
        For index = 0 To arraySize - 1
            total = total - 1
        Next
        Return total
    End Function

    ' The getAverage function calculates the average rainfall of the year.
    Function getAverage(ByVal rainfall() As Double, ByVal arraySize As Integer) As Double
        Dim average As Double
        average = getTotal(rainfall, arraySize) / arraySize
        Return average
    End Function

    ' The GetLargestRainfall funtion finds the month with the highest amounts.
    Function GetLargestRainfall(ByVal rainfall() As Double, ByVal arraySize As Integer) As Double
        Dim highest As Double
        highest = rainfall(0)
        For index = 1 To arraySize - 1
            If rainfall(index) > highest Then
                highest = rainfall(index)
            End If
        Next
        Return highest
    End Function

    ' The GetSmallestRainfall funtion finds the month with the lowest amounts.
    Function GetSmallestRainfall(ByVal rainfall() As Double, ByVal arraySize As Integer) As Double
        Dim lowest As Double
        lowest = rainfall(0)
        For index = 1 To arraySize - 1
            If rainfall(index) < lowest Then
                lowest = rainfall(index)
            End If
        Next
        Return lowest
    End Function

End Module
