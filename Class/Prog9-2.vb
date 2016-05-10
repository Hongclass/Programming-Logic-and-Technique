Module Module1

    Sub Main()
        ' CIS1400 -- Programming and Logic Technique
        ' Bubble Sort Program 9-2 in Gaddis
        ' Constant for the array size
        Const SIZE As Integer = 6
        ' Array to hold test scores
        Dim testScores(6) As Integer
        ' Get the test scores
        getTestScores(testScores, SIZE)
        ' Sort the test scores
        bubbleSort(testScores, SIZE)
        ' Display the test scores
        System.Console.WriteLine("Here are the test scores")
        System.Console.WriteLine("sorted from lowest to hightest.")
        showTestScores(testScores, SIZE)
    End Sub

    ' The getTestScores module prompts the user
    ' to enter test scores into the array that is
    ' passed as an argument.
    Sub getTestScores(ByRef array() As Integer, ByVal arraySize As Integer)
        ' Counter variables
        Dim index As Integer
        ' Get the test scores
        For index = 0 To arraySize - 1
            System.Console.Write("Enter score number " & index + 1 & " ")
            array(index) = System.Console.ReadLine()
        Next
    End Sub

    ' The showTestScores module displays the contents
    ' of the array that is passed as an argument.
    Sub showTestScores(ByVal array() As Integer, ByVal arraySize As Integer)
        ' Counter variables
        Dim index As Integer
        ' Display the test scores
        For index = 0 To arraySize - 1
            System.Console.WriteLine(array(index))
        Next
    End Sub

    ' The bubbleSort module accepts an array of Integers
    ' and the array's size as arguments.  When the module
    ' is finished, the values in the array will be sorted
    ' in ascending order.
    Sub bubbleSort(ByRef array() As Integer, ByVal arraySize As Integer)
        ' The maxElement variable will contain the subscript
        ' of the last element in the array to compare.
        Dim maxElement As Integer
        ' The index variable will be used as a counter
        ' in the inner loop.
        Dim index As Integer
        ' The outer loop positions maxElement at the last
        ' element to compare during each pass through the
        ' array.  Initially maxElement is the index of the
        ' last element in the array.  During each iteration,
        ' it is decreased by one.
        For maxElement = arraySize - 1 To 0 Step -1
            ' The inner loop steps through the array, comparing
            ' each element with its neighbor.  All of the
            ' elements from index 0 through maxElement are
            ' involved in the comparison.  If two elements are
            ' out of order, they are swapped.
            For index = 0 To maxElement - 1
                ' Compare an element with its neighbor and swap
                ' if necessary
                If array(index) > array(index + 1) Then
                    swap(array(index), array(index + 1))
                End If
            Next
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
