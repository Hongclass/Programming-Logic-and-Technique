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
        ' Array to hold each month’s rainfall.
        Dim rainfalls(SIZE - 1) As Double
        ' Get each month’s rainfall.
        Dim index As Integer
        For index = 0 To SIZE - 1
            Console.WriteLine("Enter the rainfall of month #" & index + 1 & ": ")
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
            Console.WriteLine("month #" & index + 1 & " : " & rainfalls(index))
        Next
        ' Display the total for a year.
        Console.WriteLine("The total rainfall for the year is " & getTotal(rainfalls) & " inches.")
        ' Display the average monthly rainfall.
        Console.WriteLine("The average rainfall for the year is " & getAverage(rainfalls) & " inches.")
        ' find the value of highest and lowest amounts.
        findValue(rainfalls)

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
    Sub findValue(ByVal rainfalls() As Double)
        Dim amount As Integer = 0
        Console.WriteLine("The highest amount of rainfall was month # " & GetLargestRainfall(rainfalls, amount) &
                          " : " & rainfalls(GetLargestRainfall(rainfalls, amount)) & " inches.")
        Console.WriteLine("The lowest amount of rainfall was month # " & GetSmallestRainfall(rainfalls, amount) &
                          " : " & rainfalls(GetSmallestRainfall(rainfalls, amount)) & " inches.")
    End Sub

    ' The GetLargestRainfall funtion finds the month with the highest amounts.
    Function GetLargestRainfall(ByVal rainfalls() As Double, ByVal amount As Integer)
        Dim highest
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
        Dim lowest
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
    ' Enter the rainfall of month #1:
    ' -443
    ' Rainfall must be greater than 0.
    'Please enter correct value.
    '35.67
    'Enter the rainfall of month #2:
    '768.43
    'Enter the rainfall of month #3:
    '-64
    'Rainfall must be greater than 0.
    'Please enter correct value.
    '53.45
    'Enter the rainfall of month #4:
    '56.4
    'Enter the rainfall of month #5:
    '553.75
    'Enter the rainfall of month #6:
    '2665.75
    'Enter the rainfall of month #7:
    '5.7
    'Enter the rainfall of month #8:
    '533.46
    'Enter the rainfall of month #9:
    '546.44
    'Enter the rainfall of month #10:
    '75.64
    'Enter the rainfall of month #11:
    '236.7
    'Enter the rainfall of month #12:
    '43.6
    'Here is each month's rainfall.
    'month #1 : 35.67
    'month #2 : 768.43
    'month #3 : 53.45
    'month #4 : 56.4
    'month #5 : 553.75
    'month #6 : 2665.75
    'month #7 : 5.7
    'month #8 : 533.46
    'month #9 : 546.44
    'month #10 : 75.64
    'month #11 : 236.7
    'month #12 : 43.6
    'The total rainfall for the year is 5574.99 inches.
    ' The average rainfall for the year is 464.5825 inches.
    'The highest amount of rainfall was month # 5 : 2665.75 inches.
    'The lowest amount of rainfall was month # 6 : 5.7 inches.
    ' Press any key to continue . . .

End Module
