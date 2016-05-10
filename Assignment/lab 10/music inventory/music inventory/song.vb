Public Class Song
    ' Author:   Hong Zhang
    ' Date:     11/26/2012
    ' Program:  song class   
    ' Description:
    ' Class to contain a song's artist, title, time and year. 

    ' field declarations
    Private artist As String
    Private title As String
    Private time As Date
    Private year As Integer

    ' constructor
    Public Sub New(ByVal artistName As String, ByVal songTitle As String, ByVal songTime As Date, _
                   ByVal releaseYear As Integer)
        artist = artistName
        title = songTitle
        time = songTime
        year = releaseYear
    End Sub

    ' mutator methods 
    Public Sub SetArtist(ByVal artistName As String)
        artist = artistName
    End Sub

    Public Sub SetTitle(ByVal songTitle As String)
        title = songTitle
    End Sub

    Public Sub SetTime(ByVal songTime As Date)
        time = songTime
    End Sub

    Public Sub SetYear(ByVal releaseYear As Integer)
        year = releaseYear
    End Sub

    ' accessor functions 
    Public Function getArtist() As String
        Return artist
    End Function

    Public Function getTitle() As String
        Return title
    End Function

    Public Function getTime() As Date
        Return time
    End Function

    Public Function getYear() As Integer
        Return year
    End Function

End Class
