Imports System

Module Program
    Sub Main()
        Dim num1, num2, acum, acum2, acum3, acum4, acum5 As Integer
        Dim while_i, while_j, while_k, while_h As Byte

        Console.WriteLine("Ingrese el un numero: ")
        num1 = Console.ReadLine()
        Do
            Console.WriteLine("Ingrese el segundo numero: ")
            num2 = Console.ReadLine()
        Loop While (num1 > num2)
        'For
        For i As Int16 = num1 To num2
            If (i Mod 5) = 0 Then
                acum = acum + 1
            End If
        Next
        Console.WriteLine("Entre " & num1 & " y " & num2 & " hay " & acum & " numeros multiplos por 5.")
        'Do-While
        acum3 = 0
        while_j = num1
        Do While (while_j <= num2)
            If (while_j Mod 5) = 0 Then
                acum3 = acum3 + 1
            End If
            while_j = while_j + 1
        Loop
        Console.WriteLine("Entre " & num1 & " y " & num2 & " hay " & acum3 & " numeros multiplos por 5.")
        'Do-Until
        while_k = num1
        Do Until (while_k > num2)
            If (while_k Mod 5) = 0 Then
                acum4 = acum4 + 1
            End If
            while_k = while_k + 1
        Loop
        Console.WriteLine("Entre " & num1 & " y " & num2 & " hay " & acum4 & " numeros multiplos por 5.")
        'Do-Loop-While
        acum2 = 0
        while_i = num1
        Do
            If (while_i Mod 5) = 0 Then
                acum2 = acum2 + 1
            End If
            while_i = while_i + 1
        Loop While (while_i <= num2)
        Console.WriteLine("Entre " & num1 & " y " & num2 & " hay " & acum2 & " numeros multiplos por 5.")
        'Do-Loop-Until
        while_h = num1
        Do
            If (while_h Mod 5) = 0 Then
                acum5 = acum5 + 1
            End If
            while_h = while_h + 1
        Loop Until (while_h > num2)
        Console.WriteLine("Entre " & num1 & " y " & num2 & " hay " & acum5 & " numeros multiplos por 5.")
    End Sub
End Module
