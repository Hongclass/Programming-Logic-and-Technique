' needed to access input/output routines
Imports System.IO

' Author:  Hong Zhang
' Date:    10/22/2012
' Program: FileInput
' Description: Small program to get input from existing text file
'              (Textbook Prog 10-2)

Module Module1

    Sub Main()
        '#1--.Creat file variable
        Dim myFile As StreamReader
        ' Creat variables to hold data read from file
        Dim name1, name2, name3 As String
        ' named constant to hold the number of names
        Const MAX_NAMES As Integer = 3
        ' array of names
        ' remember array dimension in VB is index of last element
        Dim names(MAX_NAMES - 1) As String
        '#2-->Link internal file variable with external file on storage
        myFile = File.OpenText("J:\Programming Logic and Technique\class\philosophers.dat")
        '#3-->Read data from external file on storage into internal VB variables
        name1 = myFile.ReadLine()
        name2 = myFile.ReadLine()
        name3 = myFile.ReadLine()
        ' read data from file into array
        Dim numRead, counter As Integer
        ' initialize number read
        numRead = 0
        Do Until myFile.Peek = -1 Or numRead = MAX_NAMES
            names(numRead) = myFile.ReadLine()
            numRead = numRead + 1

        Loop
        '#4-->close file and unlink internal file variable from external file on storage
        myFile.Close()
        ' Display data read from file
        Console.WriteLine(name1)
        Console.WriteLine(name2)
        Console.WriteLine(name3)
        ' use loop to diaplay array of names
        Console.WriteLine("Displaying array--" & numRead)
        For counter = 0 To numRead - 1
            Console.WriteLine("Philosopher " & counter + 1 & " is " & names(counter))
        Next
    End Sub

End Module
