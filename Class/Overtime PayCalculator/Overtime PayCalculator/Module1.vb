Module Module1
    ' Author: Hong Zhang
    ' Date:   09/17/2012
    ' Prog:   Overtime PayCalculator
    ' Descr:
    ' This program will calculate regular pay
    ' and determine if the employee has worked overtime 
    ' and if so, it will add the overtime rate.

    ' Global constant
    Const BASE_HOURS As Integer = 40

    Sub Main()
        ' Local variables
        Dim overTime As Boolean = False
        Dim hoursWorked, payRate, grossPay As Double

        ' Get the number of hours worked
        getHoursWorked(hoursWorked)

        ' Get the hourly pay rate
        getPayRate(payRate)

        ' Determine if overtime
        If hoursWorked > BASE_HOURS Then
            overTime = True
        End If

        ' Calculate the gross pay
        calcPay(overTime, hoursWorked, payRate, grossPay)

        ' Display gross pay
        Console.WriteLine("The gross pay is $" & grossPay)

    End Sub

    ' The getHoursWorked module gets the number 
    ' hours worked and stores it in the 
    ' reference variable hours
    Sub getHoursWorked(ByRef hoursWorked As Double)
        Console.Write("Enter the number of hours worked. ")
        hoursWorked = CDbl(Console.ReadLine())
    End Sub

    ' The getPayRate module gets the hourly
    ' pay rate and stores it in the
    ' reference variable rate.
    Sub getPayRate(ByRef Rate As Double)
        Console.Write("Enter the hourly pay rate. ")
        Rate = CDbl(Console.ReadLine())
    End Sub

    ' The calcPay module calculates gross pay
    ' with or without overtime.
    Sub calcPay(ByVal overTime As Boolean, ByVal hoursWorked As Double, ByVal rate As Double, ByRef gross As Double)
        ' Local named constant
        Const OverTime_MULTIPLIER As Double = 1.5
        ' Local variables
        Dim overTimeHours, overTimePay As Double
        ' Calculate gross pay
        If overTime Then
            overTimeHours = hoursWorked - BASE_HOURS
            overTimePay = overTimeHours * rate * OverTime_MULTIPLIER
            gross = BASE_HOURS * rate + overTimePay
        Else
            gross = hoursWorked * rate
        End If
    End Sub

End Module
