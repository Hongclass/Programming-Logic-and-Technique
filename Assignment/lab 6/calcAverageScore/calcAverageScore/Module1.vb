Module Module1
    ' Author: Hong Zhang
    ' Date: 10/15/2012
    ' Program: Test average and grade
    ' Description:
    ' This program will calculate the average score and determine the grade 
    ' after the user input five test scores.

    Sub Main()
        ' Declare variables to hold. 
        Dim score As Double
        Dim total As Double = 0.0
        Dim counter As Integer
        Dim averageScore As Double
        ' Explain what I am doing.
        Console.WriteLine("The program will calculate the")
        Console.WriteLine("average of five test scores.")
        ' Get five scores and accumulate them.
        For counter = 1 To 5
            ' Get a test score.
            Console.WriteLine("Enter a test score: ")
            score = CDbl(Console.ReadLine())
            getValidScore(score)
            total = total + score
        Next
        ' Caculate the average score of five test scores.
        averageScore = calcAverage(total)
        ' Display the average score of five test scores.
        Console.WriteLine("The average score of five test scores is " & averageScore)
    End Sub

    ' This mudole will determine the input is vaild or not.
    Sub getValidScore(ByVal score As Double)
        Dim markGrade As String
        ' Validete the test score.
        While isInvalidScore(score)
            If isInvalidScore(score) Then
                Console.WriteLine("Error: The score cannot be less than 0 or greater than 100.")
                Console.WriteLine("Enter the correct score.")
                score = CDbl(Console.ReadLine())
            End If
        End While
        ' Determine these scores's grades and display.
        markGrade = determineGrade(score)
        Console.WriteLine("The grade of this test is " & markGrade)
    End Sub

    Function isInvalidScore(ByVal score As Double) As Boolean
        ' A local variable to hold True or False.
        Dim status As Boolean
        ' If the score is invalid, set status to True.
        ' Otherwise, set status to False.
        If score < 0 Or score > 100 Then
            status = True
        Else
            status = False
        End If
        ' Reture the test status.
        Return status
    End Function

    Function calcAverage(ByVal total As Double) As Double
        Dim average As Double
        average = total / 5
        Return average
    End Function

    ' The determineGrade function accepts the score as an argument
    ' and retures the grade as a string.
    Function determineGrade(ByVal score As Double) As String
        ' Local variable to hold grade.
        Dim grade As String
        ' Determin the grade.
        If score < 60 Then
            grade = "F"
        ElseIf score < 70 Then
            grade = "D"
        ElseIf score < 80 Then
            grade = "C"
        ElseIf score < 90 Then
            grade = "B"
        Else
            grade = "A"
        End If
        ' Return the grade
        Return grade
    End Function

    ' sample output
    ' The program will calculate the
    ' average of five test scores.
    ' Enter a test score:
    ' 56
    ' The grade of this test is F
    ' Enter a test score:
    ' -9
    ' Error: The score cannot be less than 0 or greater than 100.
    ' Enter the correct score.
    ' 87
    ' The grade of this test is B
    ' Enter a test score:
    ' 98
    ' The grade of this test is A
    ' Enter a test score:
    ' 76
    ' The grade of this test is C
    ' Enter a test score:
    ' 65
    ' The grade of this test is D
    ' The average score of five test scores is 57.2
    ' Press any key to continue . . .

End Module
