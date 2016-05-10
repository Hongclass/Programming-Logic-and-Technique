Module Module1
    ' Author: Hong Zhang
    ' Date: 09/10/2012
    ' Prog: CupOunceConversion
    ' Descr:
    ' Convert input cups into ounces for subsequent output.

    ' Global constant
    Const OUNCES_PER_CUP As Integer = 8

    Sub Main()
        ' Declare needed variables
        Dim cupsNeeded, convOunces As Double
        ' Display the intro message
        showIntro()
        ' Get the number of cups
        getCups(cupsNeeded)
        ' Convert cups to ounces
        cupsToOunces(cupsNeeded, convOunces)
        ' Display converted amount
        displayOunces(convOunces)
    End Sub

    ' The showIntro module displays an
    ' introductory screen.
    Sub showIntro()
        Console.WriteLine("This program converts measurements")
        Console.WriteLine("in cups to fluid ounces. For your")
        Console.WriteLine("reference the formula is:")
        Console.WriteLine("    1 cup = 8 fluid ounces.")
    End Sub

    ' The getCups module get the number of cups
    ' and stroes it in the reference variable cups.
    Sub getcups(ByRef cups As Double)
        Console.Write("Enter the number of cups: ")
        cups = CDbl(Console.ReadLine())
    End Sub

    ' The cupsToOunces module takes an input number
    ' of cups and returns the converted ounces
    ' in the passed reference variable
    Sub cupsToOunces(ByVal cups As Double, ByRef ounces As Double)
        ounces = cups * OUNCES_PER_CUP
    End Sub

    ' The displayOunces module displays the 
    ' equivalent number of ounces.
    Sub displayOunces(ByVal ounces As Double)
        Console.WriteLine("That converts to " & ounces & " ounces.")
    End Sub

    'Sample Output
    'This program converts measurements
    'in cups to fluid ounces. For your
    'reference the formula is:
    '1 cup = 8 fluid ounces.
    'Enter the number of cups: 6.9
    'That converts to 55.2 ounces.
    'Press any key to continue . . .

End Module
