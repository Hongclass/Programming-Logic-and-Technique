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
                                  "May", "June", "July", "August", "September",
                                  "October", "November", "December"}
        ' Array to hold each month’s rainfall.
        Dim rainfalls(SIZE - 1) As Double
        ' Get each month’s rainfall.
        Dim index As Integer
        For index = 0 To SIZE - 1
            Console.WriteLine("Enter the rainfall of " & months(index) & ": ")
            rainfalls(index) = CDbl(Console.ReadLine())
            ' Validate user input cannot accept negative numbers.
            Do While rainfalls(index) < 0
                Console.WriteLine("Rainfall must be greater than 0. ")
                Console.WriteLine("Please enter correct value. ")
                rainfalls(index) = CDbl(Console.ReadLine())
            Loop
        Next
        ' Display each month's rainfall.
        Console.WriteLine("Here is each month’s rainfall.")
        For index = 0 To SIZE - 1
            Console.WriteLine(months(index) & " : " & rainfalls(index))
        Next
        ' Display the total for a year.
        Console.WriteLine("The total rainfall for the year is " & getTotal(rainfalls) & " inches.")
        ' Display the average monthly rainfall.
        Console.WriteLine("The average rainfall for the year is " & getAverage(rainfalls) & " inches.")
        ' find the value of highest and lowest amounts.
        findValue(rainfalls, months)

    End Sub

    ' The getTotal function determines the total rainfall of the year.
    Function getTotal(ByVal rainfalls() As Double)
        Dim total As Double = 0
        For index = 0 To rainfalls.Length - 1
            total = total + rainfalls(index)
        Next
        Return total
    End Function

    ' The getAverage function calculates the average rainfall of the year.
    Function getAverage(ByVal rainfalls() As Double)
        Dim average As Double
        average = getTotal(rainfalls) / rainfalls.Length
        Return average
    End Function

    ' The findValue module find the months with the highest and lowest amounts.
    Sub findValue(ByVal rainfalls() As Double, ByVal months() As String)
        Dim amount As Integer = 0
        Console.WriteLine("The highest amount of rainfall was " & months(GetLargestRainfall(rainfalls, amount)) &
                          " : " & rainfalls(GetLargestRainfall(rainfalls, amount)) & " inches.")
        Console.WriteLine("The lowest amount of rainfall was " & months(GetSmallestRainfall(rainfalls, amount)) &
                          " : " & rainfalls(GetSmallestRainfall(rainfalls, amount)) & " inches.")
    End Sub

    ' The GetLargestRainfall funtion finds the month with the highest amounts.
    Function GetLargestRainfall(ByVal rainfalls() As Double, ByVal amount As Integer)
        Dim highest As Double
        highest = rainfalls(0)
        For index = 1 To rainfalls.Length - 1
            If rainfalls(index) > highest Then
                highest = rainfalls(index)
                amount = index
            End If
        Next
        Return amount
    End Function

    ' The GetSmallestRainfall funtion finds the month with the lowest amounts.
    Function GetSmallestRainfall(ByVal rainfalls() As Double, ByVal amount As Integer)
        Dim lowest As Double
        lowest = rainfalls(0)
        For index = 1 To rainfalls.Length - 1
            If rainfalls(index) < lowest Then
                lowest = rainfalls(index)
                amount = index
            End If
        Next
        Return amount
    End Function

    ' sample output
    ' Enter the rainfall of January:
    ' -443
    ' Rainfall must be greater than 0.
    ' Please enter correct value.
    ' 35.67
    ' Enter the rainfall of February:
    ' 768.43
    ' Enter the rainfall of March:
    ' 64
    ' Rainfall must be greater than 0.
    ' Please enter correct value.
    ' 53.45
    ' Enter the rainfall of April:
    ' 56.4
    ' Enter the rainfall of May:
    ' 553.75
    ' Enter the rainfall of June:
    ' 2665.75
    ' Enter the rainfall of July:
    ' 5.7
    ' Enter the rainfall of August:
    ' 533.46
    ' Enter the rainfall of September:
    ' 546.44
    ' Enter the rainfall of October:
    ' 75.64
    ' Enter the rainfall of November:
    ' 236.7
    ' Enter the rainfall of December:
    ' 43.6
    ' Here is each month's rainfall.
    ' January : 35.67
    ' February : 768.43
    ' March : 53.45
    ' April : 56.4
    ' May : 553.75
    ' June : 2665.75
    ' July : 5.7
    ' August : 533.46
    ' September : 546.44
    ' October : 75.64
    ' November : 236.7
    ' December : 43.6
    ' The total rainfall for the year is 5574.99 inches.
    ' The average rainfall for the year is 464.5825 inches.
    ' The highest amount of rainfall was June : 2665.75 inches.
    ' The lowest amount of rainfall was July : 5.7 inches.
    ' Press any key to continue . . .

End Module
