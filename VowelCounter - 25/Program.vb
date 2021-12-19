Imports System

Module Program
    Sub Main(args As String())
        Dim Text As String
        Dim vowels(6) As Int16

        Console.WriteLine("PLease enter some text")
        Text = Console.ReadLine()

        For Each c As Char In Text
            If c = "a" Then
                vowels(1) = vowels(1) + 1
            End If
            If c = "e" Then
                vowels(2) = vowels(2) + 1
            End If
            If c = "i" Then
                vowels(3) = vowels(3) + 1
            End If
            If c = "o" Then
                vowels(4) = vowels(4) + 1
            End If
            If c = "u" Then
                vowels(5) = vowels(5) + 1
            End If
        Next

        Console.WriteLine("In the text " & Text & "there was ")
        Console.WriteLine(vowels(1) & " A" & vbCrLf & vowels(2) & " E" & vbCrLf & vowels(3) & " I" & vbCrLf & vowels(4) & " O" & vbCrLf & vowels(5) & " U" & vbCrLf)

    End Sub
End Module
