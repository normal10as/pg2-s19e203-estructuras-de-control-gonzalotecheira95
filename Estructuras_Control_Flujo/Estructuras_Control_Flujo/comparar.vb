Imports System

Module Program
    Sub Main()
        Dim num1, num2 As Short

        Console.WriteLine("Ingrese un valor para comparar: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        num2 = Console.ReadLine()

        If num1 > num2 Then
            Console.WriteLine("El primer valor es mayor.")
        ElseIf num1 < num2 Then
            Console.WriteLine("El segundo valor es el mayor.")
        ElseIf num1 = num2 Then
            Console.WriteLine("Los numeros tienen el mismo valor.")
        End If

    End Sub
End Module
