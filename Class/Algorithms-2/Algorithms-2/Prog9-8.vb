Module Module1

    Sub Main()
        ' CIS1400 -- Programming and Logic Technique
        ' Binary Search Program 9-8 in Gaddis
        ' Constant for the array size
        Const SIZE As Integer = 6
        ' array of instructor names, already sorted in
        ' ascending order
        Dim names() As String = {"Hall", "Harrison", _
            "Hoyle", "Kimura", "Lopez", "Pike"}
        ' parallel array of instructor phone numbers
        Dim phones() As String = {"555-6783", "555-0199", _
            "555-9974", "555-2377", "555-7772", "555-1716"}
        ' variable to hold the name to search for
        Dim searchName As String
        ' variable to hold the subscript of the name
        Dim index As Integer
        ' variable to contorl the loop
        Dim again As String = "Y"
        While again = "Y" Or again = "y"
            ' get the name to search for
            System.Console.Write("Enter a name to search for: ")
            searchName = System.Console.ReadLine()
            ' search for the last name
            index = binarySearch(names, searchName, SIZE)
            If index <> -1 Then
                ' display the phone number
                System.Console.WriteLine("The phone number is " & phones(index))
            Else
                ' the name was not found in the array
                System.Console.WriteLine(searchName & " was not found.")
            End If
            System.Console.Write("Do you want to search again? (Y=Yes, N=No) ")
            again = System.Console.ReadLine()
        End While
    End Sub

    ' The binarySearch function accepts as arguments a String
    ' array, a value to search the array for, and the size 
    ' of the array.  If the value is found in the array, its
    ' subscript is returned.  Otherwise, -1 is returned,
    ' indicating that the value was not found in the array.
    Function binarySearch(ByVal array() As String, ByVal value As String, _
        ByVal arraySize As Integer) As Integer
        ' Variable to hold the subscript of the first element
        Dim first As Integer = 0
        ' Variable to hold the subscript of the last element
        Dim last As Integer = arraySize - 1
        ' Position of the search value
        Dim position As Integer = -1
        ' Flag
        Dim found As Boolean = False
        ' Variable to hold the subscript of the midpoint
        Dim middle As Integer
        While (Not found) And (first <= last)
            ' calculate the midpoint
            middle = (first + last) / 2
            ' see if the value is found at the midpoint
            If array(middle) = value Then
                found = True
                position = middle
                ' else, if the value is in the lower half...
            ElseIf array(middle) > value Then
                last = middle - 1
                ' else if the value is in the upper half...
            Else
                first = middle + 1
            End If
        End While
        ' return the position of the item, or -1
        ' if the item was not found
        Return position
    End Function

End Module
