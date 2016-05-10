Module Module1

    Sub Main()
        ' Local variables
        Dim sales, commissionRate, advancedPay, pay As Double
        ' Get the amount of sales
        sales = getSales()
        ' Get the amount of advanced pay
        advancedPay = getAdvancedPay()
        ' Determine the commission rate
        commissionRate = determineCommissionRate(sales)
        ' Calculate the pay
        pay = sales * commissionRate - advancedPay
        ' Display the amount of pay
        Console.WriteLine("The pay is $" & pay)
        ' Determine whether the pay is negative
        If pay < 0 Then
            Console.WriteLine("The salesperson must reimburse")
            Console.WriteLine("the company.")
        End If
    End Sub

    ' The getSales function gets a salesperson’s
    ' monthly sales from the user and returns
    ' that value as a Real.
    Function getSales() As Double
        ' Local variable to hold the monthly sales
        Dim monthlySales As Double
        ' Get the amount of monthly sales
        Console.Write("Enter the salesperson’s monthly sales: ")
        monthlySales = CDbl(Console.ReadLine())
        ' Return the amount of monthly sales
        Return monthlySales
    End Function

    ' The getAdvancedPay function gets the amount of
    ' advanced pay given to the salesperson and
    ' returns that amount as a Real.
    Function getAdvancedPay() As Double
        ' Local variable to hold the advanced pay
        Dim advanced As Double
        ' Get the amount of advanced pay
        Console.WriteLine("Enter the amount of advanced pay, or")
        Console.Write("0 if no advanced pay was given: ")
        advanced = CDbl(Console.ReadLine())
        ' Return the advanced pay
        Return advanced
    End Function

    ' The determineCommissionRate function accepts the 
    ' amount of sales as an argument and returns the 
    ' commission rate as a Real.
    Function determineCommissionRate(ByVal sales As Double) As Double
        ' local variable to hold commission rate
        Dim rate As Double
        ' determine commission rate
        If sales < 10000.0 Then
            rate = 0.1
        ElseIf sales >= 10000.0 And sales <= 14999.99 Then
            rate = 0.12
        ElseIf sales >= 15000.0 And sales <= 17999.99 Then
            rate = 0.14
        ElseIf sales >= 18000.0 And sales <= 21999.99 Then
            rate = 0.16
        Else
            rate = 0.18
        End If
        ' return the commission rate
        Return rate
    End Function

    ' sample output
    ' Enter the salesperson's monthly sales: 14650.00
    ' Enter the amount of advanced pay, or
    ' 0 if no advanced pay was given: 1000.00
    ' The pay is $758
    ' Press any key to continue . . .

    ' Enter the salesperson's monthly sales: 9000.00
    ' Enter the amount of advanced pay, or
    ' 0 if no advanced pay was given: 0
    ' The pay is $900
    ' Press any key to continue . . .

    ' Enter the salesperson's monthly sales: 12000.00
    ' Enter the amount of advanced pay, or
    ' 0 if no advanced pay was given: 2000.00
    ' The pay is $-560
    ' The salesperson must reimburse
    ' the company.
    ' Press any key to continue . . .
    1
End Module
