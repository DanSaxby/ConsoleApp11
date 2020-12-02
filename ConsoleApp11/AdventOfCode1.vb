Imports System.IO
Module AdventOfCode1
    Sub AOC1()
        Dim linecount As String = File.ReadAllLines("AOC1.txt").Length
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim count As Integer
        Using sr As New StreamReader("AOC1.txt")

            For i As Integer = 0 To linecount
                num1 = sr.ReadLine()
                Using sr2 As New StreamReader("AOC1.txt")
                    For t As Integer = 0 To linecount
                        num2 = sr2.ReadLine()
                        Using sr3 As New StreamReader("AOC1.txt")
                            For e As Integer = 0 To linecount
                                num3 = sr3.ReadLine()
                                count = num1 + num2 + num3
                                If count = 2020 And num3 <> 0 And num2 <> 0 And num1 <> 0 Then
                                    Console.WriteLine(num1 * num2 * num3)
                                    Console.ReadLine()
                                    'Else

                                    '    Console.WriteLine(count)
                                End If
                            Next

                        End Using
                    Next
                End Using
            Next
        End Using

    End Sub
End Module
