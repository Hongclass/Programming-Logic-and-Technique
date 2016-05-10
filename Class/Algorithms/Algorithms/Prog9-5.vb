Module Module1

    Sub Main()
        ' CIS1400 -- Programming and Logic Technique
        ' Selection Sort Program 9-5 in Gaddis
        ' Constant for the array size
        Const SIZE As Integer = 6
        ' An array of Integer
        Dim numbers() As Integer = {4, 6, 1, 3, 5, 2}
        ' Loop counter
        Dim index As Integer
        ' Display the array in its original order
        System.Console.WriteLine("Original order:")
        For index = 0 to SIZE - 1
            System.Console.WriteLine(numbers(index))
        Next
        ' Sort the numbers
        selectionSort(numbers, SIZE)
        ' Display a blank line
        System.Console.WriteLine()
        ' Display the sorted array
        System.Console.WriteLine("Sorted order:")
        For index = 0 to SIZE - 1
            System.Console.WriteLine(numbers(index))
        Next
    End Sub

    ' The selectionSort module accepts an array of Integers
    ' and the array's size as arguments.  When the module
    ' is finished, the values in the array will be sorted
    ' in ascending order.
    Sub selectionSort(ByRef array() As Integer, ByVal arraySize As Integer)
        ' startScan will hold the starting position of the scan
        Dim startScan As Integer
        ' minIndex will hold the subscript of the element with 
        ' the smallest value found in the scanned area
        Dim minIndex As Integer
        ' minValue will hold the smallest value found in the
        ' scanned area
        Dim minValue As Integer
        ' index is a counter variable used to hold a subscript
        Dim index As Integer
        ' The outer loop iterates once for each element in the
        ' array, except the last element.  The startScan variable
        ' marks the position where the scan should begin.
        For startScan = 0 to arraySize - 2
            ' assume the first element in the scannable area
            ' is the smallest value
            minIndex = startScan
            minValue = array(startScan)
            ' scan the array, starting at the 2nd element in
            ' the scannable area.  We are looking for the smallest
            ' value in the scannable area
            For index = startScan + 1 to arraySize - 1
                If array(index) < minValue Then
                    minValue = array(index)
                    minIndex = index
                End If
            Next
            ' swap the element with the smallest value
            ' with the first element in the scannable area
            swap(array(minIndex), array(startScan))
        Next
    End Sub

    ' The swap module accepts two Integer arguments
    ' and swaps their contents.
    Sub swap(ByRef a As Integer, ByRef b As Integer)
        ' Local variable for temporary storage.
        Dim temp As Integer
        ' Swap the values in a and b
        temp = a
        a = b
        b = temp
    End Sub
End Module
