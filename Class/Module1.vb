Module Module1
    ' Name: Hong Zhang
    ' Date: 09/10/2012
    ' Descr:
    ' In-class exercise to creat the Visual Basic implementation
    ' of the PayCalculator program.
    '
    Sub Main()
        Dim hours, payRate, grossPay, taxes, netPay As Double
        Const TAX_RATE As Double = 0.25 ' named constant for tax rate
        Console.Write("Enter the number of hours ")
        hours = CDbl(Console.ReadLine())
        Console.Write("Enter the hourly pay rate ")
        payRate = CDbl(Console.ReadLine())
        ' calculate taxes, gross and net pay
        grossPay = hours * payRate
        Console.WriteLine("The gross pay is $" & grossPay)
        taxes = grossPay * TAX_RATE
        Console.WriteLine("the taxes are $" & taxes)
        netPay = grossPay - taxes
        Console.WriteLine("The net Pay is $" & netPay)
    End Sub

End Module
