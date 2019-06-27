Imports System

Enum Operaciones
    Suma = 1
    Resta
    Multiplicacion
    Division
End Enum

Module Program
    Sub Main()

        'Llamada a funcion por 2 valores
        Console.WriteLine("El resultado de la operacion es: " & Calcular(Operaciones.Suma, 5, 8) & "")
        Console.WriteLine("El resultado de la operacion es: " & Calcular(Operaciones.Resta, 5, 8))
        Console.WriteLine("El resultado de la operacion es: " & Calcular(Operaciones.Multiplicacion, 5, 8))
        Console.WriteLine("El resultado de la operacion es: " & Calcular(Operaciones.Division, 5, 8))
        Console.WriteLine()
        'Llamada funcion sobrecargada 3 valores
        Console.WriteLine("El resultado de la operacion Suma: " & Calcular(Operaciones.Suma, 5, 8, 8))
        Console.WriteLine("El resultado de la operacion Resta: " & Calcular(Operaciones.Resta, 5, 8, 8))
        Console.WriteLine("El resultado de la operacion Multiplicacion: " & Calcular(Operaciones.Multiplicacion, 5, 8, 8))
        Console.WriteLine("El resultado de la operacion Division : " & Calcular(Operaciones.Division, 5, 8, 8))
        Console.WriteLine()
        'Llamada funcion sobrecargada 4 valores
        Console.WriteLine("El resultado de la operacion Suma: " & Calcular(Operaciones.Suma, 5, 8, 8, 8))
        Console.WriteLine("El resultado de la operacion Resta: " & Calcular(Operaciones.Resta, 5, 8, 8, 8))
        Console.WriteLine("El resultado de la operacion Multiplicacion: " & Calcular(Operaciones.Multiplicacion, 5, 8, 8, 8))
        Console.WriteLine("El resultado de la operacion Division : " & Calcular(Operaciones.Division, 5, 8, 8, 8))
        Console.WriteLine()
        'Llamada funcion sobrecargada sim case
        Console.WriteLine("El Resultado es: " & Calcular(3, 4))

    End Sub
    Private Function Calcular(ByRef val1 As Integer, ByRef val2 As Integer) As Decimal
        Dim resultado As Integer
        resultado = val1 + val2
        Return resultado
    End Function
    Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer) As Decimal
        Dim resultado As Decimal
        Select Case opc
            Case Operaciones.Suma
                resultado = val1 + val2
            Case Operaciones.Resta
                resultado = val1 - val2
            Case Operaciones.Multiplicacion
                resultado = val1 * val2
            Case Operaciones.Division
                resultado = val1 / val2
        End Select

        Return resultado
    End Function

    Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer) As Decimal
        Dim resultado As Decimal
        Select Case opc
            Case Operaciones.Suma
                resultado = val1 + val2 + val3
            Case Operaciones.Resta
                resultado = val1 - val2 * val3
            Case Operaciones.Multiplicacion
                resultado = val1 * val2 * val3
            Case Operaciones.Division
                resultado = val1 / val2 / val3
        End Select

        Return resultado
    End Function
    Private Function Calcular(ByRef opc As Byte, ByRef val1 As Integer, ByRef val2 As Integer, ByRef val3 As Integer,ByRef val4 As Integer) As Decimal
        Dim resultado As Decimal
        Select Case opc
            Case Operaciones.Suma
                resultado = val1 + val2 + val3 + val4
            Case Operaciones.Resta
                resultado = val1 - val2 - val3 - val4
            Case Operaciones.Multiplicacion
                resultado = val1 * val2 * val3 * val4
            Case Operaciones.Division
                resultado = val1 / val2 / val3 / val4
        End Select

        Return resultado
    End Function

End Module
