Imports System

Module Program
    Sub Main()
        Dim ing As UShort

        ingreso(ing)

        'Potencia(ing)
    End Sub
    Private Function Potencia(ByVal numero As Integer) As Integer

        For i As Byte = 2 To 5
            numero = numero ^ i
            Console.WriteLine("El numero ingresado elevado a la " & i & " es " & numero)
        Next

        Return Potencia
    End Function
    Private Sub ingreso(ByRef num As UShort)
        Do
            Console.WriteLine("Ingrese un numero: ")
            num = Console.ReadLine()
            If (num < 0) Then
                Console.WriteLine("Error. Ingrese un numero entero positivo.")
            End If
        Loop While (num < 0)
    End Sub
End Module