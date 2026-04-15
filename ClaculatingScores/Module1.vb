Imports System.Net.Security

Module Module1
    ' Nothing goes here for right now - NO GLOBAL VARIABLES
    Sub Main()
        Dim Scores(26) As Integer ' Inside the () is the max index
        Dim total As Integer
        Dim High As Integer = 1 'Pick a low to claculate a high
        Dim Low As Integer = 999
        Dim HighPlace As Integer
        Dim LowPlace As Integer
        Scores(0) = 16
        Scores(1) = 14
        Scores(2) = 16
        Scores(3) = 15
        Scores(4) = 18
        Scores(5) = 17
        Scores(6) = 26
        Scores(7) = 22
        Scores(8) = 23
        Scores(9) = 25
        Scores(10) = 24
        Scores(11) = 25
        Scores(12) = 28
        Scores(13) = 29
        Scores(14) = 14
        Scores(15) = 20
        Scores(16) = 18
        Scores(17) = 28
        Scores(18) = 25
        Scores(19) = 26
        Scores(20) = 15
        Scores(21) = 25
        Scores(22) = 26
        Scores(23) = 27
        Scores(24) = 22
        Scores(25) = 25
        Scores(26) = 20

        ' Traverse means to go through the array usually index by index
        For i = 0 To 26
            total = total + Scores(i)
        Next
        Console.WriteLine(total)

        'Find and output the highest number
        For i = 0 To 26
            If Scores(i) > High Then
                High = Scores(i)
            End If
        Next
        Console.WriteLine(High)

        For i = 0 To 26
            If Scores(i) < Low Then
                Low = Scores(i)
            End If
        Next
        Console.WriteLine(Low)
    End Sub

End Module
