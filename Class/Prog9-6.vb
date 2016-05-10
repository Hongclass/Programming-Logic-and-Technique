Module Module1

    Sub Main()
        ' CIS1400 -- Programming and Logic Technique
        ' Insertion Sort Program 9-6 in Gaddis
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
        insertionSort(numbers, SIZE)
        ' Display a blank line
        System.Console.WriteLine()
        ' Display the sorted array
        System.Console.WriteLine("Sorted order:")
        For index = 0 to SIZE - 1
            System.Console.WriteLine(numbers(index))
        Next
    End Sub

    ' The insertionSort module accepts an array of Integers
    ' and the array's size as arguments.  When the module
    ' is finished, the values in the array will be sorted
    ' in ascending order.
    Sub insertionSort(ByRef array() As Integer, ByVal arraySize As Integer)
        ' loop counter
        Dim index As Integer
        ' variable used to scan through the array
        Dim scan As Integer
        ' variable to hold the first unsorted value
        Dim unsortedValue As Integer
        ' The outer loop steps the index variable through
        ' each subscript in the array, starting at 1.  This
        ' is because element 0 is considered already sorted.
        For index = 1 to arraySize - 1
            ' The first element outside the sorted subset is
            ' array(index).  Store the value of this element
            ' in unsortedValue.
            unsortedValue = array(index)
            ' Start scan at the subscript of the first element
            ' outside the sorted subset.
            scan = index
            ' Move the first element outside the sorted subset
            ' into its proper position within the sorted subset.
            ' NOTE: VB AndAlso operator achieves short-circuit evaluation
            ' so invalid index isn't checked on second sub-expression
            ' when the scan has a value of 0
            While scan > 0 AndAlso array(scan-1) > array(scan)
                swap(array(scan), array(scan-1))
                scan = scan - 1
            End While
            ' Insert the unsorted value in its proper position
            ' within the sorted subset.
            array(scan) = unsortedValue
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
