Imports System.IO

Module Module1
    ' Author:   Hong Zhang
    ' Date:     11/26/2012
    ' Prog:     music inventory
    ' Description:
    ' Program to prompt the user to input two songs' detail information,
    ' then calculate the total running time for both songs 
    ' and finnally write these data to a text file.

    Sub Main()
        ' declare some variables
        Dim firstSongArtist As String
        Dim firstSongTitle As String
        Dim firstSongTime As Date
        Dim firstSongYear As Integer

        Dim my1stSong As Song

        Dim secondSongArtist As String
        Dim secondSongTitle As String
        Dim secondSongTime As Date
        Dim secondSongYear As Integer

        Dim my2ndSong As Song

        Dim time1 As Date
        Dim time2 As Date

        Dim strH1 As String
        Dim strM1 As String
        Dim strS1 As String
        Dim a1 As Integer
        Dim b1 As Integer
        Dim c1 As Integer
        Dim second1 As Integer

        Dim strH2 As String
        Dim strM2 As String
        Dim strS2 As String
        Dim a2 As Integer
        Dim b2 As Integer
        Dim c2 As Integer
        Dim second2 As Integer

        Dim totalSecond As Integer

        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer

        Dim myFile As StreamWriter

        ' input first song's information
        Console.WriteLine("Enter 1st song artist: ")
        firstSongArtist = CStr(Console.ReadLine())
        Console.WriteLine("Enter 1st song name: ")
        firstSongTitle = CStr(Console.ReadLine())
        Console.WriteLine("Enter 1st song time (formate: hour: minute: second): ")
        firstSongTime = CDate(Console.ReadLine())
        Console.WriteLine("Enter 1st song release year: ")
        firstSongYear = CInt(Console.ReadLine())
        Console.WriteLine("  ")

        ' creat first song's object of the Song type
        my1stSong = New Song(firstSongArtist, firstSongTitle, firstSongTime, firstSongYear)

        ' input second song's information
        Console.WriteLine("Enter 2nd song artist: ")
        secondSongArtist = CStr(Console.ReadLine())
        Console.WriteLine("Enter 2nd song name: ")
        secondSongTitle = CStr(Console.ReadLine())
        Console.WriteLine("Enter 2nd song time(formate: hour: minute: second): ")
        secondSongTime = CDate(Console.ReadLine())
        Console.WriteLine("Enter 2nd song release year: ")
        secondSongYear = CInt(Console.ReadLine())

        ' creat second song's object of the Song type
        my2ndSong = New Song(secondSongArtist, secondSongTitle, secondSongTime, secondSongYear)

        ' caculate and display two song's total running time
        time1 = my1stSong.getTime()
        time2 = my2ndSong.getTime()

        strH1 = Left(time1, 2)
        strM1 = Mid(time1, 4, 2)
        strS1 = Right(time1, 2)

        a1 = Replace(strH1, ":", "")
        b1 = Replace(strM1, ":", "")
        c1 = Replace(strS1, ":", "")

        second1 = a1 * 60 * 60 + b1 * 60 + c1

        strH2 = Left(time2, 2)
        strM2 = Mid(time2, 4, 2)
        strS2 = Right(time2, 2)

        a2 = Replace(strH2, ":", "")
        b2 = Replace(strM2, ":", "")
        c2 = Replace(strS2, ":", "")

        second2 = a2 * 60 * 60 + b2 * 60 + c2

        totalSecond = second1 + second2

        hour = Int(totalSecond / (60 * 60))
        minute = Int((totalSecond - 60 * 60 * hour) / 60)
        second = totalSecond - 60 * 60 * hour - 60 * minute

        Console.WriteLine("  ")
        Console.WriteLine("The total running time of songs is " & hour & ":" & minute & ":" & second & ".")

        myFile = File.CreateText("I:\Programming Logic and Technique\Assignment\lab 10\music inventory\song_inventory.dat")
        myFile.WriteLine("1st song artist: " & my1stSong.getArtist())
        myFile.WriteLine("1st song name: " & my1stSong.getTitle())
        myFile.WriteLine("1st song time: " & my1stSong.getTime())
        myFile.WriteLine("1st song release year: " & my1stSong.getYear())
        myFile.WriteLine("2nd song artist: " & my2ndSong.getArtist())
        myFile.WriteLine("2nd song name: " & my2ndSong.getTitle())
        myFile.WriteLine("2nd song time: " & my2ndSong.getTime())
        myFile.WriteLine("2nd song release year: " & my2ndSong.getYear())
        myFile.Close()

    End Sub

    ' sample output
    ' Enter 1st song artist:
    ' Best Coast
    ' Enter 1st song name:
    ' The Only Place
    ' Enter 1st song time (formate: hour: minute: second):
    ' 00:02:44
    ' Enter 1st song release year:
    ' 2012

    ' Enter 2nd song artist:
    ' Graveyard
    ' Enter 2nd song name:
    ' Endless Night
    ' Enter 2nd song time(formate: hour: minute: second):
    ' 00:02:46
    ' Enter 2nd song release year:
    ' 2012

    ' The total running time of songs is 0:5:30.
    ' Press any key to continue . . .

End Module
