Module Module1
    ' Author: Hong Zhang
    ' Date: 09/24/2012
    ' Prog: Shipping Charges
    ' Descr: 
    ' This program will ask for the weight of the package,
    ' and then display the charges. 
    ' Input is from the user responses at keyboard 
    ' and output will be calculated according different weight range 
    ' and displayed variables used: weight and charges.

    Sub Main()
        ' Local variables
        Dim weight, charge As Double

        ' Display intro message
        showIntro()

        ' Get the package weight
        getWeight(weight)

        ' Calculate the charge
        calcCharge(weight, charge)

        ' Display charge
        Console.WriteLine("Total Charges will be $ " & charge)

    End Sub

    ' The showIntro module display an introductory screen
    Sub showIntro()
        Console.WriteLine("This program will calculated the charge of the package")
        Console.WriteLine("For your reference the weight of package is")
        Console.WriteLine("2 lb or less, rate per lb = $1.10")
        Console.WriteLine("over 2 lb but not more than 6 lb, rate per lb = $2.20")
        Console.WriteLine("over 6 lb but not more than 10 lb, rate per lb = $3.70")
        Console.WriteLine("over 10 lb, rate per lb = $3.80")
    End Sub

    ' The weight module gets the weight of the package 
    ' and stores it in the reference varialbe weight.
    Sub getWeight(ByRef weight As Double)
        Console.Write("Enter the package weight: ")
        weight = CDbl(Console.ReadLine())
    End Sub

    ' The calcCharge module calculates the charge with
    ' not more than 2 lb, over 2 lb but not more than 6 lb, 
    ' over 6 lb but not more than 10 lb or over 10 lb.
    Sub calcCharge(ByVal weight, ByRef charge)
        ' Local named constant
        Const less2lb_Rate As Double = 1.1
        Const less6lb_Rate As Double = 2.2
        Const less10lb_Rate As Double = 3.7
        Const over10lb_Rate As Double = 3.8
        ' Calculate the charge
        If weight <= 2 Then
            charge = weight * less2lb_Rate
        ElseIf weight <= 6 Then
            charge = weight * less6lb_Rate
        ElseIf weight <= 10 Then
            charge = weight * less10lb_Rate
        Else
            charge = weight * over10lb_Rate
        End If
    End Sub

    ' Sample Output
    ' This program will calculated the charge of the package
    ' For your reference the weight of package is
    ' 2 lb or less, rate per lb = $1.10
    ' over 2 lb but not more than 6 lb, rate per lb = $2.20
    ' over 6 lb but not more than 10 lb, rate per lb = $3.70
    ' over 10 lb, rate per lb = $3.80
    ' Enter the package weight: 2
    ' Total Charges will be $ 2.2
    ' Press any key to continue . . .

    ' This program will calculated the charge of the package
    ' For your reference the weight of package is
    ' 2 lb or less, rate per lb = $1.10
    ' over 2 lb but not more than 6 lb, rate per lb = $2.20
    ' over 6 lb but not more than 10 lb, rate per lb = $3.70
    ' over 10 lb, rate per lb = $3.80
    ' Enter the package weight: 4.56
    ' Total Charges will be $ 10.032
    ' Press any key to continue . . .

    ' This program will calculated the charge of the package
    ' For your reference the weight of package is
    ' 2 lb or less, rate per lb = $1.10
    ' over 2 lb but not more than 6 lb, rate per lb = $2.20
    ' over 6 lb but not more than 10 lb, rate per lb = $3.70
    ' over 10 lb, rate per lb = $3.80
    ' Enter the package weight: 9.34
    ' Total Charges will be $ 34.558
    ' Press any key to continue . . .

    ' This program will calculated the charge of the package
    ' For your reference the weight of package is
    ' 2 lb or less, rate per lb = $1.10
    ' over 2 lb but not more than 6 lb, rate per lb = $2.20
    ' over 6 lb but not more than 10 lb, rate per lb = $3.70
    ' over 10 lb, rate per lb = $3.80
    ' Enter the package weight: 11.38
    ' Total Charges will be $ 43.244
    ' Press any key to continue . . .

End Module
