Module Module1
    ' Author: Hong Zhang
    ' Date: 09/17/2012
    ' Prog: PropertyTax
    ' Descr:
    ' Convert input actual property into assessed property and property tax 
    ' for subsequent output.

    ' Global constant
    Const Assessed_Percent_Value As Double = 0.6
    Const Property_Tax_Percent As Double = 0.64

    Sub Main()
        ' Declare needed variables
        Dim ActualProperty, convAssessedProperty, convPropertyTax As Double
        ' Display the intro message
        showIntro()
        ' Get the actual value of property 
        getProperty(ActualProperty)
        'Convert Actual Property to Assessed Property 
        PropertyToAssessment(ActualProperty, convAssessedProperty)
        ' Display converted amount of Assessed Property
        displayAssessedProperty(convAssessedProperty)
        ' Convert Assessed Property to Property Tax
        AssessmentToTax(convAssessedProperty, convPropertyTax)
        ' Display converted amount of Property Tax
        displayPropertyTax(convPropertyTax)
    End Sub

    ' The showIntro module display an 
    ' introductory screen 
    Sub showIntro()
        Console.WriteLine("This program converts measurements")
        Console.WriteLine("in actual property to assessed property and property tax.")
        Console.WriteLine("For your reference the formula is:")
        Console.WriteLine(" Assessed property = 60% of actual property.")
        Console.WriteLine(" Property tax = ( assessed property /100 ) * $0.64.")
    End Sub

    ' The getProperty module gets the actual value of property 
    ' and stores it in the reference variable ActualProperty.
    Sub getProperty(ByRef ActualProperty As Double)
        Console.Write("Enter the actual value of property: $")
        ActualProperty = CDbl(Console.ReadLine())
    End Sub

    ' The PropertyToAssessment module takes an input 
    ' actual value of property and returns the converted 
    ' assessed property in the passed reference variable. 
    Sub PropertyToAssessment(ByVal ActualProperty As Double, ByRef AssessedProperty As Double)
        AssessedProperty = ActualProperty * Assessed_Percent_Value
    End Sub

    'The displayAssessedProperty module displays the 
    ' equivalent number of assessed property. 
    Sub displayAssessedProperty(ByVal AssessedProperty As Double)
        Console.WriteLine("That converts to assessed property: $" & AssessedProperty & ".")
    End Sub

    ' The AssessmentToTax module takes assessed property
    ' and returns the converted property tax
    ' in the passed reference variable. 
    Sub AssessmentToTax(ByVal AssessedProperty As Double, ByRef PropertyTax As Double)
        PropertyTax = (AssessedProperty / 100) * Property_Tax_Percent
    End Sub

    ' The displayPropertyTax module displays the 
    ' equivalent number of property tax. 
    Sub displayPropertyTax(ByVal PropertyTax As Double)
        Console.WriteLine("That converts to property tax: $" & PropertyTax & ".")
    End Sub

    ' Sample Output
    ' This program converts measurements
    ' in actual property to assessed property and property tax.
    ' For your reference the formula is:
    ' Assessed property = 60% of actual property.
    ' Property tax = ( assessed property /100 ) * $0.64.
    ' Enter the actual value of property: $1234567.89
    ' That converts to assessed property: $740740.734.
    ' That converts to property tax: $4740.7406976.
    ' Press any key to continue . . .

End Module
