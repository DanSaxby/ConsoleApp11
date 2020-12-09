Imports System.IO
Module MainAOC

    Sub Main()
        Dim linecount As Integer = File.ReadAllLines("AOC3.txt").Length
        Dim TreeMap(30, (linecount - 1)) As Char
        Dim line As String
        Dim countx, county, i, treecount As Integer

        Using sr As New StreamReader("AOC3.txt")
            county = 0
            For i = 0 To linecount - 1
                line = sr.ReadLine()
                countx = 0
                For Each t In line
                    TreeMap(countx, county) = t
                    countx += 1
                Next
                county += 1
            Next
        End Using
        countx = 0
        county = 0
        counttrees(1, 1, linecount, TreeMap)
        counttrees(3, 1, linecount, TreeMap)
        counttrees(5, 1, linecount, TreeMap)
        counttrees(7, 1, linecount, TreeMap)
        counttrees(1, 2, linecount, TreeMap)
        Console.ReadLine()
    End Sub
    Sub counttrees(X As Integer, Y As Integer, linecount As Integer, treemap(,) As Char)
        Dim countx, county, treecount As Integer
        While county <> linecount
            If county <= 323 Then

                If countx > 30 Then
                countx = countx - 31
            End If
                If treemap(countx, county) = "#" Then
                    treecount += 1
                End If

            End If
            countx += X
            county += Y
        End While
        Console.WriteLine(treecount)
    End Sub




End Module
