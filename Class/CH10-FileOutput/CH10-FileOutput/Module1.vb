' Include VB import statement to allow access to input/output routines.
Imports System.IO

' Author: Hong Zhang
' Date: 10/22/2012
' Program: FileOutput
' Descrpition: Small example to output data (Textbook Prog 10-1).

Module Module1

    Sub Main()
        ' 
        ' Create array of names to write 
        Dim names() As String = {"Amit Arora", "Anita Hamid", _
                                 "Hong Zhang"}
        '#1-->Create internal file variable.
        Dim myFile As StreamWriter
        '#2-->Link internal file variable with external file on storage.
        ' myFile = File.CreateText("J:\Programming Logic and Technique\class\philosophers.dat")
        myFile = File.AppendText("J:\Programming Logic and Technique\class\philosophers.dat")
        '#3-->Write out data to file
        myFile.WriteLine("John Locke")
        myFile.WriteLine("David Hume")
        myFile.WriteLine("Edmund Burke")
        ' use loop to process array of names
        Dim counter As Integer
        For counter = 0 To names.Length - 1
            myFile.WriteLine(names(counter))
        Next
        '#4-->Flush output buffer and unlind internal file variable from
        '     external file on storage.
        myFile.Close()
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
