Imports System.IO

Module Module1
    ' Author:   Hong Zhang
    ' Date:     11/12/2012
    ' Prog:     Sorted Names and Name Search
    ' Description:
    ' Program to create an array of 20 names from the data file names.dat, 
    ' sort this array of 20 names in ascending order, display the sorted list 
    ' of names to the user with a descriptive message and enter a name to search
    ' in this array.

    Sub Main()
        Const SIZE As Integer = 20
        Dim names(SIZE - 1) As String
        getNames(names, SIZE)
        bubbleSort(names, SIZE)
        showNames(names, SIZE)
        searchName(names, SIZE)

    End Sub

    ' The getNames module create an array 
    ' from the data file names.dat
    Sub getNames(ByRef names() As String, ByVal arraySize As Integer)
        Dim myFile As StreamReader
        Dim numRead As Integer
        ' open file for input
        myFile = File.OpenText("I:\Programming Logic and Technique\Assignment\lab 9\names.dat")
        numRead = 0
        ' read names from file into array
        Do While Not myFile.Peek = -1 And numRead <= arraySize - 1
            names(numRead) = myFile.ReadLine
            numRead = numRead + 1
        Loop
        ' close file
        myFile.Close()
    End Sub

    ' The bubbleSort module sorts the array of 20 names 
    ' in ascending order
    Sub bubbleSort(ByRef names() As String, ByVal arraySize As Integer)
        Dim maxElement As Integer
        Dim index As Integer
        ' sort the names in ascending order
        For maxElement = arraySize - 1 To 0 Step -1
            For index = 0 To maxElement - 1
                If names(index) > names(index + 1) Then
                    swap(names(index), names(index + 1))
                End If
            Next
        Next
    End Sub

    ' The swap module accepts two Integer arguments
    ' and swaps their contents.
    Sub swap(ByRef a As String, ByRef b As String)
        Dim temp As String
        ' Swap the values in a and b
        temp = a
        a = b
        b = temp
    End Sub

    ' The showNames module displays the contents
    ' of the array that is passed as an argument.
    Sub showNames(ByRef names() As String, ByVal arraySize As Integer)
        Dim index As Integer
        Console.WriteLine("Here are the students' names read from file")
        Console.WriteLine("and sorted in ascending order: ")
        For index = 0 To arraySize - 1
            System.Console.WriteLine("No." & index + 1 & " " & names(index))
        Next
    End Sub

    ' The searchName modul ask user to enter a name and search
    ' in this array.
    Sub searchName(ByRef names() As String, ByVal arraySize As Integer)
        Dim searchName As String
        Dim index As Integer
        Dim again As String = "Y"
        While again = "Y" Or again = "y"
            Console.WriteLine("   ")
            System.Console.Write("Enter a name to search for: ")
            searchName = System.Console.ReadLine()
            index = binarySearch(names, searchName, arraySize)
            If index <> -1 Then
                System.Console.WriteLine(searchName & " was No. " & index + 1 & " name in the file.")
            Else
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
        Dim first As Integer = 0
        Dim last As Integer = arraySize - 1
        Dim position As Integer = -1
        Dim found As Boolean = False
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

    ' Here are the students' names read from file
    ' and sorted in ascending order:
    ' No.1 Amit Arora
    ' No.2 Anita Hamid
    ' No.3 Anita Mossey
    ' No.4 Caitlin Everett
    ' No.5 Carole Arett-Abood
    ' No.6 Chris Eicher
    ' No.7 Dale Saari
    ' No.8 Derek Plate
    ' No.9 Doug Huh
    ' No.10 Elijah Ewasiuk
    ' No.11 Greg Dzunicsko
    ' No.12 Jude Booth
    ' No.13 Kim Jackson
    ' No.14 Marilyn Comer
    ' No.15 Papitcho Ntendayi Odia
    ' No.16 Ryan Daily
    ' No.17 Saravanan Rajendran
    ' No.18 Scott Burgholzer
    ' No.19 Zach Cavalier
    ' No.20 Zack Coffman

    ' Enter a name to search for: Caitlin Everett
    ' Caitlin Everett was No. 4 name in the file.
    ' Do you want to search again? (Y=Yes, N=No) y

    ' Enter a name to search for: Rayan Daily
    ' Rayan Daily was not found.
    ' Do you want to search again? (Y=Yes, N=No) n
    ' Press any key to continue . . .

End Module

   