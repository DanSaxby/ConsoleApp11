Imports System.IO
Module MainAOC

    Sub Main()
        Dim numberofpass As Integer
        Dim linecount As Integer = File.ReadAllLines("AOC4.txt").Length
        Dim line As String
        Dim linearray() As String
        Dim linesplit() As String
        Using sr As New StreamReader("AOC4.txt")
            For i = 0 To linecount - 1
                line = sr.ReadLine()
                If line = Nothing Then
                    numberofpass += 1
                End If
            Next
            numberofpass += 2
        End Using
        Dim Passportarray(numberofpass - 1) As Dictionary(Of String, String)
        For p = 0 To Passportarray.Length - 1
            Passportarray(p) = New Dictionary(Of String, String)
        Next
        Dim count As Integer
        Using sr As New StreamReader("AOC4.txt")

            For i = 0 To linecount - 1
                line = sr.ReadLine()
                If line <> "" Then
                    If line.Contains(" ") Then
                        linearray = line.Split(" ")
                        For Each l In linearray
                            linesplit = l.Split(":")
                            Passportarray(count).Add(linesplit(0), linesplit(0))

                        Next
                    Else
                        linesplit = line.Split(":")
                        Passportarray(count).Add(linesplit(0), linesplit(1))
                    End If
                Else
                    count += 1
                End If
            Next
        End Using
        Dim validpass As Integer
        For Each p In Passportarray
            If p.ContainsKey("byr") And p.ContainsKey("iyr") And p.ContainsKey("eyr") And p.ContainsKey("hgt") And p.ContainsKey("hcl") And p.ContainsKey("ecl") And p.ContainsKey("pid") Then
                validpass += 1
            End If
        Next
        Console.WriteLine(validpass)
        Console.ReadLine()
    End Sub





End Module
