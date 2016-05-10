' Include VB import statement to allow access to input/output routines.
Imports System.IO

Module Module1
    ' Author: Hong Zhang
    ' Date: 10/29/2012
    ' Program: Average of Numbers
    ' Descrpition: Input data (numbers) from the computer's 
    '              disk, calculate the total and average of 
    '              all the numbers. Then, write the total 
    '              and average back to the file.

    Sub Main()
        Const SIZE As Integer = 5
        ' Declare an input file.
        Dim myFile As StreamReader
        ' Declare some variables.
        Dim number As Double
        Dim count As Integer
        Dim total As Double = 0
        Dim average As Double
        ' Open the numbers.dat file.
        myFile = File.OpenText("E:\COD CLASS\Programming Logic and Technique\Assignment\lab 8\numbers.dat")
        ' Read data from the file.
        Console.WriteLine("Here are the numbers:")
        For count = 1 To SIZE
            number = CDbl(myFile.ReadLine)
            Console.WriteLine(number)
            total = total + number
        Next
        average = total / SIZE
        ' Close the file.
        myFile.Close()
        ' Display the total and the average.
        Console.WriteLine("The total is " & total & ".")
        Console.WriteLine("The average is " & average & ".")

        ' Create internal file variable.
        Dim numberFile As StreamWriter
        ' Write total and average to the file.
        numberFile = File.AppendText("E:\COD CLASS\Programming Logic and Technique\Assignment\lab 8\numbers.dat")
        numberFile.WriteLine("The total is " & total & ".")
        numberFile.WriteLine("The average is " & average & ".")
        numberFile.Close()

    End Sub

    ' Sample Output
    ' Here are the numbers:
    ' 100
    ' 55
    ' 20
    ' 30
    ' 27
    ' The total is 232.
    ' The average is 46.4.
    ' Press any key to continue . . .

End Module
